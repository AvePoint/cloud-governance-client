namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;

    public class CreateSite_AddGroupPermission : TestBase
    {
        public CreateSite_AddGroupPermission(ApiConfig config) : base(config) { }

        public Guid Run(CreateSiteTestData data)
        {
            try
            {
                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateSiteService(serviceName);
                var request = service.RequestTemplate;

                request.SiteUrl.Name = $"ApiAddGroupPermission{DateTime.Now.Ticks}";
                request.Summary = $"AddGroupPermission_{DateTime.Now}";
                request.SiteTitle = $"AddGroupPermission_{DateTime.Now}";
                request.PrimaryContact = this.ResolveUser(data.PrimaryContactLoginName);
                request.SecondaryContact = this.ResolveUser(data.SecondaryContactLoginName);
                ////request.Department = data.Department;

                var sharePointGroupMembers = data.SharePointGroupMemberLoginNames
                    .Split(new String[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => this.ResolveUser(p))
                    .Select(user => new GroupUser
                    {
                        Id = user.Id,
                        LoginName = user.LoginName,
                        IsExternalUser = user.IsExternalUser,
                        AzureUserType = user.AzureUserType,
                        DisplayName = user.DisplayName,
                        IsGroup = user.IsGroup,
                        Email = user.Email,
                        IsEnforce = false,
                        IsHide = false,
                    });

                request.GroupPermissions.Find(g => g.Name == data.SharePointGroupName).Users.AddRange(sharePointGroupMembers);
                var requestId = this.RequestsApi.SubmitCreateSiteRequest(request);
                return requestId;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}