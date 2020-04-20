namespace Example
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class CreateSiteWithMultiGeoRequestExample: ExampleBase
    {
        public override void Run()
        {

            try
            {
                var request = new CreateSiteRequest();
                var apiInstance = new RequestsApi(Configuration.Default);
                request.ServiceId = new Guid("3844cf31-4b27-4636-9a15-5548e0eaa906");
                request.Department = "IT";
                string siteName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}";

                request.Summary = siteName + " Summary";
                request.SiteTitle = siteName + " Title";

                var apiServiceInstance = new ServicesApi(Configuration.Default);
                CreateSiteService serviceInfo = apiServiceInstance.GetCreateSiteService(request.ServiceId);
                var allLocations = serviceInfo.MultiGeoSetting.AllLocations;

                var locationName = "KOR";
                var locationDisplayName = "Korea";
                request.MultiGeoLocation = new GeoLocationBase { Name = locationName, DisplayName = locationDisplayName };
                var rootSiteUrl = "https://xxxxx.sharepoint.com";
                foreach (var location in allLocations)
                {
                    if (location.Name.Equals(locationName))
                    {
                        rootSiteUrl = location.RootSiteUrl;
                        break;
                    }
                }
                request.SiteUrl = new SiteUrl()
                {
                    Root = rootSiteUrl,
                    Name = siteName,
                    ManagedPath = "/sites/"
                };

                request.PolicyId = new Guid("ac758b7f-6079-4fd0-8250-48490a5a34a6");
                request.TimeZone = 21;
                request.Language = 1033;
                request.Template = "STS#3#Team site (no Office 365 group)#Collaboration";

                request.PrimaryAdmin = new ApiUser()
                {
                    LoginName = "PrimaryAdmin@example.com",
                    DisplayName = "PrimaryAdmin"
                };

                request.PrimaryContact = new ApiUser()
                {
                    LoginName = "PrimaryContact@example.com",
                    DisplayName = "PrimaryContact"
                };

                request.SecondaryContact = new ApiUser()
                {
                    LoginName = "SecondaryContact@example.com",
                    DisplayName = "SecondaryContact"
                };

                request.HubSiteSettings = new HubSiteSettings();
                request.UserPermissions = new List<RequestUserWithPermissions>();
                request.GroupPermissions = new List<RequestGroupWithPermissions>();
                request.Metadatas = this.GetSampleMetadatas();

                var result = apiInstance.SubmitCreateSiteRequest(request);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
