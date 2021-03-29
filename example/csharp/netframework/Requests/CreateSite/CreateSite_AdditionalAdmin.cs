
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class CreateSite_AdditionalAdmin : TestBase
    {
        public CreateSite_AdditionalAdmin(ApiConfig config) : base(config) { }

        public Guid Run(CreateSiteTestData data)
        {

            try
            {
                

                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateSiteService(serviceName);
                var request = service.RequestTemplate;

                request.SiteUrl.Name = $"Api{DateTime.Now.Ticks}";
                request.Summary = $"Summary_{DateTime.Now}";
                request.SiteTitle = $"Title_{DateTime.Now}";
                request.Department = data.Department;
                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };
                request.AdditionalAdmins = new List<ApiUser>();
                var additionalAdmins = new List<String>(data.AdditionalAdminLoginNames.Split(';'));
                foreach (var user in additionalAdmins)
                {
                    if (!String.IsNullOrEmpty(user))
                    {
                        request.AdditionalAdmins.Add(new ApiUser { LoginName = user });
                    }
                }
                return this.RequestsApi.SubmitCreateSiteRequest(request);

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
