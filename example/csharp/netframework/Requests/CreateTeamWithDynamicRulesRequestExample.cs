namespace NetFramework
{
    #region using namespaces
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    #endregion

    public class CreateTeamWithDynamicRulesRequestExample : ExampleBase
    {
        public Guid Run()
        {
            try
            {
                var apiInstance = new RequestsApi(Configuration.Default);
                var settingsApi = new SettingsApi(Configuration.Default);
                var request = new CreateGroupRequest();

                //replace the servcie name with your real service name
                var serviceName = "service name";
                var service = this.GetCreateGroupService(serviceName);
                request.ServiceId = service.Id;
                request.EnableDynamicMembership = true;
                var dynamicMembershipRuleItems = settingsApi.GetDynamicMembershipRuleItems(service.TenantId);

                //get first contact property, you can also find contact property by property name
                var contactMetadataId = dynamicMembershipRuleItems.Contact[0].Id;
                var contactMetadataName = dynamicMembershipRuleItems.Contact[0].Name;

                //get first organization property, you can also find organization property by property name
                var organizationMetadataId = dynamicMembershipRuleItems.Organization[0].Id;
                var organizationMetadataName = dynamicMembershipRuleItems.Organization[0].Name;

                //get first license property, you can also find license property by property name
                var licenseMetadataId = dynamicMembershipRuleItems.License[0].Id;
                var licenseMetadataName = dynamicMembershipRuleItems.License[0].Name;

                //get first license property value, you can also find license property value by property name
                var licenseMetadataValue = dynamicMembershipRuleItems.License[0].ChoiceItems[0].Id;
                var licenseMetadataDisplayValue = dynamicMembershipRuleItems.License[0].ChoiceItems[0].Name;

                //replace the user login name with real user login name
                var primaryContactLoginName = "sampleuserA@xxx.xxx";
                var secondaryContactLoginName = "sampleuserB@xxx.xxx";

                var usersApi = new UsersApi(Configuration.Default);
                var primaryContactUser = usersApi.ResolveUsers(primaryContactLoginName, UserType.User, UserSource.Azure, ExternalSharingOptions.Disabled).FirstOrDefault();
                request.PrimaryContact = primaryContactUser;
                var secondaryContactUser = usersApi.ResolveUsers(secondaryContactLoginName, UserType.User, UserSource.Azure, ExternalSharingOptions.Disabled).FirstOrDefault();
                request.SecondaryContact = secondaryContactUser;

                request.DynamicMembershipRules = new List<DynamicGroupRuleInfo> {
                    new DynamicGroupRuleInfo{
                        Id = Guid.NewGuid(),
                        Order = 0,
                        Relation = LogicalOperator.Or,
                        Category = CategoryType.Contact,
                        MetadataId = contactMetadataId,
                        MetadataName = contactMetadataName,
                        MetadataValue = "user display name",//replace with real user display name
                        MetadataDisplayValue = "user display name",//replace with real user display name
                        Condition = DynamicRuleCondition.Equals
                    },
                    new DynamicGroupRuleInfo{
                        Id = Guid.NewGuid(),
                        Order = 1,
                        Relation = LogicalOperator.Or,
                        Category = CategoryType.Organization,
                        MetadataId = organizationMetadataId,
                        MetadataName = organizationMetadataName,
                        MetadataValue = "user login name",//replace with real user login name
                        MetadataDisplayValue = "user display name",//replace with real user display name
                        Condition = DynamicRuleCondition.Is
                    },
                    new DynamicGroupRuleInfo{
                        Id = Guid.NewGuid(),
                        Order = 2,
                        Relation = LogicalOperator.Or,
                        Category = CategoryType.License,
                        MetadataId = licenseMetadataId,
                        MetadataName = licenseMetadataName,
                        MetadataValue = licenseMetadataValue,
                        MetadataDisplayValue = licenseMetadataDisplayValue,
                        Condition = DynamicRuleCondition.Equals
                    },
                };
                request.GroupName = "XXX";//replace with real group/team name
                request.GroupId = "XXX";//replace with real group/team name
                var result = apiInstance.SubmitCreateGroupRequest(request);
                Console.WriteLine(result);
                return result;
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
