namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CreateSite_EnableMultiGeo : ExampleBase
    {
        public CreateSite_EnableMultiGeo(ApiConfig config) : base(config) { }

        public void Run(CreateSiteTestData data)
        {

            try
            {
                var requestApi = new RequestsApi(Configuration.Default);
                var serviceApi = new ServicesApi(Configuration.Default);

                var serviceName = serviceApi.GetServiceId(data.ServiceName);
                var service = serviceApi.GetCreateSiteService(serviceName);
                var request = service.RequestTemplate;

                request.SiteUrl.Name = $"Api_{DateTime.Now}";
                request.Summary = $"Summary_{DateTime.Now}";
                request.SiteTitle = $"Title_{DateTime.Now}";
                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };

                var allLocations = service.MultiGeoSetting.AllLocations;
                var location= allLocations.First(l => l.DisplayName.EqualsIgnoreCase(data.MultiGeoLocatioinName));
                request.MultiGeoLocation = new GeoLocationBase(name: location.Name);

                var result = requestApi.SubmitCreateSiteRequest(request);
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
