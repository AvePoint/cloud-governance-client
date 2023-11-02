
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class ChangeSiteCollectioinDPMPlan : TestBase
    {
        public ChangeSiteCollectioinDPMPlan(ApiConfig config) : base(config) { }

        public Guid Run(ChangeSiteSettingTestData data)
        {
            try
            {
                
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeSiteSettingService(serviceId);
                var request = service.RequestTemplate;
                var validateResult = this.ServicesApi.ValidateForChangeSiteSettingService(serviceId,
                    new SiteValidationParameter
                    {
                        Uri = data.SiteUrl,
                    });
                request.SiteId = validateResult.SiteId;
                request.SiteUrl = data.SiteUrl;
                request.DeploymentPlanName = data.DPMPlanName;
                request.Summary = $"Api_Sample_ChangeSiteSettings_Request";
                return this.RequestsApi.SubmitChangeSiteSettingRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeSiteSettingRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
