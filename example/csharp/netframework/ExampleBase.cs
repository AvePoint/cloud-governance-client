namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;

    public class ExampleBase
    {

        public ServicesApi ServicesApi { get; set; }

        public ExampleBase(ApiConfig config)
        {
            Configuration.Default.BasePath = config.ApiEndPoint;

            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", config.Secret);

            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", config.UserPrincipalName);

            this.ServicesApi = new ServicesApi(Configuration.Default);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public Guid GetServiceId(String serviceName)
        {
            return this.ServicesApi.GetServiceId(serviceName);
        }

        public CreateSiteService GetCreateSiteService(String serviceName)
        {
            var serviceId = this.GetServiceId(serviceName);
            return this.ServicesApi.GetCreateSiteService(serviceId);
        }

        public List<RequestMetadata> GetMetadatas(Dictionary<String,String> metadata)
        {
            var result = new List<RequestMetadata>();
            if (metadata != null)
            {
                foreach (var kvp in metadata)
                {
                    result.Add(new RequestMetadata(name: kvp.Key, value: kvp.Value));
                }
            }
            return result;
        }
    }
}
