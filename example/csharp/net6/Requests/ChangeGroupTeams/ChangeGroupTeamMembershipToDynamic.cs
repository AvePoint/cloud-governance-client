
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    
    using System;
    using Cloud.Governance.Client.Model;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeGroupTeamMembershipToDynamic : TestBase
    {
        public ChangeGroupTeamMembershipToDynamic(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);
                var dynamicGroup = this.ResolveUser(data.DynamicGroup, ApiUserType.Group);
                var request = service.RequestTemplate;
                request.Summary = $"Summary_ChangeTeamMembershipToDynamic_{DateTime.Now}";
                request.GroupEmail = data.GroupEmail;
                request.GroupId = new Guid(group.Id);
                request.OriginalGroupName = group.DisplayName;
                request.ChangedDynamicGroupType = AddGroupMemberType.Dynamically;
                if (service.EnableChangeDynamicMembershipRules)
                {
                    var rules = this.SettingsApi.GetDynamicMembershipRuleItems(service.TenantId);
                    var currentRule = rules.Organization.Where(rule => rule.Name.Equals("Group Assignment")).FirstOrDefault();
                    request.DynamicMembershipRules = new List<DynamicGroupRuleInfo>
                    {
                        new DynamicGroupRuleInfo
                        {
                            Category = CategoryType.Organization,
                            Condition = DynamicRuleCondition.In,
                            Id = currentRule.Id,
                            MetadataId = currentRule.Id,
                            MetadataName = currentRule.Name,
                            MetadataValue = dynamicGroup.Id,
                            MetadataDisplayValue = dynamicGroup.DisplayName
                        }
                    };
                }
                var result = this.RequestsApi.SubmitChangeGroupSettingRequest(request);

                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeGroupSettingRequest for ChangeTeamHubsite, exception: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
