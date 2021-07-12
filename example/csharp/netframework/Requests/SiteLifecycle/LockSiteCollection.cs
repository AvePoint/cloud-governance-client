
namespace NetFramework
{
    
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class LockSiteCollection : TestBase
    {
        public LockSiteCollection(ApiConfig authData) : base(authData) { }

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

                var lockSiteRequest = new LockSiteRequest
                {
                    ServiceId = request.ServiceId,
                    SiteId = validationResult.SiteId,
                    SiteUrl = validationResult.SiteUrl,
                    //Department = request.Department,
                    Metadatas = request.Metadatas,
                    LockType = SiteLockType.ReadOnly,
                    Summary = $"Lock_Site_{data.SiteUrl}"
                };
                // submit lock site request
                Guid result = this.RequestsApi.SubmitLockSiteRequest(lockSiteRequest);
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
