
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class CreateList_Basic : TestBase
    {
        public CreateList_Basic(ApiConfig config) : base(config) { }

        public Guid Run(CreateListOrLibraryTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateListService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"{data.Summary}_{DateTime.Now}";
                request.ListTitle = $"{data.ListTitle}_{DateTime.Now}";
                request.ListName = $"{data.ListName}_{DateTime.Now}";
                request.ParentObject.ParentUrl = data.WebUrl;
                request.ParentObject.SiteUrl = data.SiteUrl;
                request.ListType = (ListType)Enum.Parse(typeof(ListType), data.List);
                request.ListTemplate = data.ListTemplate;

                var result = this.RequestsApi.SubmitCreateListRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while creating list required and calling RequestsApi.SubmitCreateListRequest: {e}");
                Console.WriteLine($"Status Code: { e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}