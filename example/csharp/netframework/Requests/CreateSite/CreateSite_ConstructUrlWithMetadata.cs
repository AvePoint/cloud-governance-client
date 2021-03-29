namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;

    public class CreateSite_ConstructUrlWithMetadata : TestBase
    {
        public CreateSite_ConstructUrlWithMetadata(ApiConfig config) : base(config) { }

        public Guid Run(CreateSiteTestData data)
        {
            try
            {
                var requestApi = new RequestsApi(Configuration.Default);
                var serviceApi = new ServicesApi(Configuration.Default);

                var serviceName = serviceApi.GetServiceId(data.ServiceName);
                var service = serviceApi.GetCreateSiteService(serviceName);
                var request = service.RequestTemplate;

                request.Summary = $"ConstructUrl_{DateTime.Now}";
                request.SiteTitle = $"ConstructUrl_{DateTime.Now}";
                request.PrimaryContact = this.ResolveUser(data.PrimaryContactLoginName);
                request.SecondaryContact = this.ResolveUser(data.SecondaryContactLoginName);
                request.Department = data.Department;

                var choiceMetadata = request.Metadatas.Find(m => m.Name.Equals(data.ChoiceMetadataName, StringComparison.CurrentCultureIgnoreCase));
                if (choiceMetadata != null)
                {
                    choiceMetadata.Value = data.ChoiceMetadataValue;
                }
                var singleMetadata = request.Metadatas.Find(m => m.Name.Equals(data.SingleLineMetadataName, StringComparison.CurrentCultureIgnoreCase));
                if (singleMetadata != null)
                {
                    singleMetadata.Value = data.SingleLineMetadataValue;
                }

                var requestId = requestApi.SubmitCreateSiteRequest(request);
                return requestId;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}