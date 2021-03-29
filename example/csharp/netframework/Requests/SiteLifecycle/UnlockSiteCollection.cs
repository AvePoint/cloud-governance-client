
namespace NetFramework
{
    
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class UnlockSiteCollection : TestBase
    {
        public UnlockSiteCollection(ApiConfig authData) : base(authData) { }

        public Guid Run(SiteCollectionLifecycleTestData data)
        {

            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetSiteLifecycleService(serviceId);
                var request = service.RequestTemplate;
                var validationResult = this.ServicesApi.ValidateForSiteLifecycleService(serviceId,
                    new SiteValidationParameter
                    { 
                      Uri = data.SiteUrl
                    });

                var unlockSiteRequest = new UnlockSiteRequest
                {
                    ServiceId = request.ServiceId,
                    SiteId = validationResult.SiteId,
                    SiteUrl = validationResult.SiteUrl,
                    Department = request.Department,
                    Metadatas = request.Metadatas,
                    Summary = $"UnLock_Site_{data.SiteUrl}"
                };
                var result = this.RequestsApi.SubmitUnlockSiteRequest(unlockSiteRequest);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitLockSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

    }
}
