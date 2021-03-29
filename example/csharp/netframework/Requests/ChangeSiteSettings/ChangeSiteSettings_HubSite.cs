namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeSiteSettings_HubSite : TestBase
    {
        public ChangeSiteSettings_HubSite(ApiConfig config) : base(config) { }

        public Guid Run(ChangeSiteSettingTestData data)
        {
            try
            {
                var office365Api = new Office365Api(Configuration.Default);
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
                var hubSites = office365Api.GetHubSitesByUrl(data.SiteUrl);
                var hubSite = hubSites.FirstOrDefault(item => item.Name.Equals(data.HubSite,StringComparison.CurrentCultureIgnoreCase));
                request.HubSiteSettings = new HubSiteChangedSettings(true, ChangeHubsiteActionType.AssociateToHubSite, hubSite.Id, hubSite.Name);
                request.Summary = $"Api_Sample_ChangeSiteSettings_Request";
                return this.RequestsApi.SubmitChangeSiteSettingRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeSiteSettingRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}
