namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class DynamicCreateSite : TestBase
    {
        public DynamicCreateSite(ApiConfig authData) : base(authData)
        {
        }

        public Guid Run(Guid serviceId)
        {
            try
            {
                var serviceApi = new ServicesApi(Configuration.Default);
                var requestApi = new RequestsApi(Configuration.Default);
                DynamicRequestTemplateModel request = serviceApi.GetDynamicServiceRequestTemplate(serviceId);
                if (request != null && request.ActivityGalleries.Count > 0)
                {
                    request.Summary = "Demo Dynamic Request";
                    request.NotesToApprovers = "Please approve this request.";
                    request.ActivityGalleries.ForEach(activity =>
                    {
                        if (activity is ApiModelRequestDynamicServiceCreateSiteGalleryCreateSiteGallery createSiteActivity)
                        {
                            createSiteActivity.SiteTitleAndDescription.SiteTitle = "<site title>";
                            createSiteActivity.SiteUrlSetting.RootSite = "<root site>";
                            createSiteActivity.SiteUrlSetting.Url = "<site url>";
                            createSiteActivity.SiteUrlSetting.ManagedPath = "<managed path>";
                            createSiteActivity.SiteTemplate.SiteTemplate = new DRSiteTemplate { TemplateName = "<site template>" };
                            createSiteActivity.SiteLanguage.Language = 1033;// LCID
                            createSiteActivity.SiteContacts.PrimaryContact = new ApiUser("<user object id>", "<login name>");
                            createSiteActivity.SiteContacts.SecondaryContact = null;
                            createSiteActivity.SiteAdmins.PrimaryAdmin = new ApiUser("<user object id>", "<login name>");
                        }
                    });
                }
                var apiRequestInstance = new RequestsApi(Configuration.Default);
                return apiRequestInstance.SubmitDynamicRequestByTemplate(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception while submitting dynamic create site request: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                return Guid.Empty;
            }
        }
    }
}