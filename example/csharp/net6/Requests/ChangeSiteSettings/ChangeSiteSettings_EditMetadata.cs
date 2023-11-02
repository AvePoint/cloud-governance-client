namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class ChangeSiteSettings_EditMetadata : TestBase
    {
        public ChangeSiteSettings_EditMetadata(ApiConfig config) : base(config) { }

        public Guid Run(ChangeSiteSettingTestData data)
        {
            try
            {
                var workspaceApi = new WorkspaceApi(Configuration.Default);
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeSiteSettingService(serviceId);
                var request = service.RequestTemplate;
                var validateResult = this.ServicesApi.ValidateForChangeSiteSettingService(serviceId,
                    new SiteValidationParameter
                    {
                        Uri = data.SiteUrl,
                    });
                request.SiteId = validateResult.SiteId;
                var siteMetadata = workspaceApi.GetSiteMetadata(data.SiteUrl);
                var changedMetadata = new List<RequestMetadata>();
                siteMetadata.ForEach((metadata) =>
                {
                    if (metadata.Name.Equals(data.SingleLineMetadataName,StringComparison.CurrentCultureIgnoreCase))
                    {
                        changedMetadata.Add(new RequestMetadata(name:data.SingleLineMetadataName,value:data.SingleLineMetadataValue,action:MetadataActionType.Edit));
                    }
                });
                request.SiteUrl = data.SiteUrl;
                request.Summary = $"Api_Sample_ChangeSiteSettings_Request";
                request.ChangedMetadatas = changedMetadata;
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
