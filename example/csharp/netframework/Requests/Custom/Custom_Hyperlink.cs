namespace NetFramework
{
    using Cloud.Governance.Client.Client;
    using System;
    using System.Linq;

    public class Custom_Hyperlink : TestBase
    {
        public Custom_Hyperlink(ApiConfig config) : base(config) { }

        public Guid Run(CustomTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCustomService(serviceId);
                var request = service.RequestTemplate;
                request.Summary = $"Custom_Hyperlink_{DateTime.Now}";
                var metadataInfo = request.Metadatas.FirstOrDefault(m => m.Name.Equals(data.HyperlinkMetadataName, StringComparison.CurrentCultureIgnoreCase));
                if (metadataInfo != null)
                {
                    metadataInfo.Value = data.LinkMetadataValue;
                }
                return this.RequestsApi.SubmitCustomRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCustomRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}