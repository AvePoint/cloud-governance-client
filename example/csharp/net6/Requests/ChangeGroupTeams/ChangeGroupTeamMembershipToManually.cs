
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    
    using System;
    using Cloud.Governance.Client.Model;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeGroupTeamMembershipToManually : TestBase
    {
        public ChangeGroupTeamMembershipToManually(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);
                var users = this.ResolveUsers(data.NewMembers, ApiUserType.User);
                var request = service.RequestTemplate;
                request.Summary = $"Summary_ChangeTeamMembershipToManually_{DateTime.Now}";
                request.GroupEmail = data.GroupEmail;
                request.GroupId = new Guid(group.Id);
                request.OriginalGroupName = group.DisplayName;
                request.ChangedDynamicGroupType = AddGroupMemberType.Manually;
                request.GroupMembers = users.Select(user =>

                    new GroupMembershipItem()
                    {
                        Action = GroupMembershipAction.Added,
                        AzureUserType = user.AzureUserType,
                        IsGroup = false,
                        DisplayName = user.DisplayName,
                        LoginName = user.LoginName
                    }
                ).ToList();
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
