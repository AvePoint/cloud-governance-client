
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    
    using System;
    using Cloud.Governance.Client.Model;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeGroupTeamsChangeMembersAdd : TestBase
    {
        public ChangeGroupTeamsChangeMembersAdd(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                var request = service.RequestTemplate;
                request.Summary = $"Summary_ChangeMembersAdd_{DateTime.Now}";
                request.GroupEmail = data.GroupEmail;
                var office365Api = new Office365Api(Configuration.Default);
                var newMembers = this.ResolveUsers(data.NewMembers);
                request.GroupMembers = newMembers.Select(m => new GroupMembershipItem
                {
                    IsGroup = m.IsGroup,
                    Action = GroupMembershipAction.Added,
                    LoginName = m.LoginName,
                }).ToList();
                request.GroupId = new Guid(group.Id);
                var result = this.RequestsApi.SubmitChangeGroupSettingRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while calling RequestsApi.SubmitChangeGroupSettingRequest: {e}");
                Console.WriteLine($"Status Code: { e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
