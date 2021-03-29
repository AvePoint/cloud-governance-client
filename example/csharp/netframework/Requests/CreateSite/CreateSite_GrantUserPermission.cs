namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;

    public class CreateSite_GrantUserPermission : TestBase
    {
        public CreateSite_GrantUserPermission(ApiConfig config) : base(config) { }

        public Guid Run(CreateSiteTestData data)
        {
            try
            {
                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateSiteService(serviceName);
                var request = service.RequestTemplate;

                request.SiteUrl.Name = $"ApiGrantUserPermission{DateTime.Now.Ticks}";
                request.Summary = $"GrantUserPermission_{DateTime.Now}";
                request.SiteTitle = $"GrantUserPermission_{DateTime.Now}";
                request.PrimaryContact = this.ResolveUser(data.PrimaryContactLoginName);
                request.SecondaryContact = this.ResolveUser(data.SecondaryContactLoginName);
                request.Department = data.Department;

                var settingsApi = new SettingsApi(Configuration.Default);
                var permissionLevels = settingsApi.GetPermissionLevels().ToDictionary(p => p.Name, p => p);

                var permissionLevelSettings = data.GrantedUserPermissionLevelNames
                    .Split(new String[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => permissionLevels[p])
                    .ToList();
                request.UserPermissions.Add(new RequestUserWithPermissions
                {
                    User = this.ResolveUser(data.GrantedUserLoginName),
                    PermissionLevels = permissionLevelSettings
                }); 

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