
namespace NetFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    public class CreateGroup_DynamicRule : TestBase
    {
        public CreateGroup_DynamicRule(ApiConfig config) : base(config) { }

        public Guid Run(CreateGroupTestData data)
        {
            try
            {
                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateGroupService(serviceName);
                var group = this.ResolveUser(data.DynamicGroup, ApiUserType.Group);
                var request = service.RequestTemplate;
                request.Summary = $"Summary_{DateTime.Now}";
                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };
                request.Owners = data.OwnerList.Split(';').Select(s => new ApiUser() { LoginName = s }).ToList();
                var ticks = DateTime.Now.Ticks;
                request.GroupName = "Api_Sample_Group_" + ticks;
                request.GroupId = "Api_Sample_Group_" + ticks;
                if (service.EnableDynamicMembership)
                {
                    var rules = this.SettingsApi.GetDynamicMembershipRuleItems(service.TenantId);
                    var ruleId = rules.Organization.Where(rule => rule.Name.Equals("Group Assignment")).FirstOrDefault().Id;
                    request.EnableAssignedMembership = false;
                    request.EnableDynamicMembership = true;
                    request.DynamicMembershipRules = new List<DynamicGroupRuleInfo>
                    {
                        new DynamicGroupRuleInfo
                        {
                            Category = CategoryType.Organization,
                            Condition = DynamicRuleCondition.In,
                            Id = ruleId,
                            MetadataId = ruleId,
                            MetadataValue = group.Id,
                            MetadataDisplayValue = group.DisplayName
                        }
                    };
                }
                return this.RequestsApi.SubmitCreateGroupRequest(request);

            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateGroupRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}
