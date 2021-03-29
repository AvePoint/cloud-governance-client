
namespace NetFramework
{
    
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class ChangeSiteCollectionPolicy : TestBase
    {
        public ChangeSiteCollectionPolicy(ApiConfig authData) : base(authData) { }

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
                var policy = validationResult.ChangePolicySetting
                    .AllPolicies.FirstOrDefault(
                    p => p.Name.Equals(data.ChangePolicyName, StringComparison.CurrentCultureIgnoreCase));
                var changePolicyRequest = new ChangeSitePolicyRequest
                {
                    ServiceId = request.ServiceId,
                    SiteId = validationResult.SiteId,
                    SiteUrl = validationResult.SiteUrl,
                    Department = request.Department,
                    Metadatas = request.Metadatas,
                    Policy = policy,
                    Summary = $"ChangeSitePolicy_{data.SiteUrl}"
                };
                var result = this.RequestsApi.SubmitChangeSitePolicyRequest(changePolicyRequest);
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
