
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CreateGuestUser_Basic : TestBase
    {
        public CreateGuestUser_Basic(ApiConfig config) : base(config) { }

        public Guid Run(CreateGuestUserTestData data)
        {
            try
            {
                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateGuestUserService(serviceName);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_CreateGuestUser_Basic_{DateTime.Now}";
                request.UserProperties.UserName = $"{DateTime.Now.ToString("yyyymmddhhmmss")}@test.com";
                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };
                return this.RequestsApi.SubmitCreateGuestUserRequest(request);

            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateGuestUserRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }

    }
}
