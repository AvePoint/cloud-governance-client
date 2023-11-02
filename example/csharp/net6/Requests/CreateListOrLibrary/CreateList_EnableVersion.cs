
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class CreateList_EnableVersion : TestBase
    {
        public CreateList_EnableVersion(ApiConfig config) : base(config) { }

        public Guid Run(CreateListOrLibraryTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateListService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"{data.Summary}_{DateTime.Now}";
                request.ListTitle = $"{data.ListTitle}_{DateTime.Now}";
                request.ListType = (ListType)Enum.Parse(typeof(ListType), data.List);
                request.ListName = $"{data.ListName}_{DateTime.Now}";
                request.ParentObject.ParentUrl = data.WebUrl;
                request.ParentObject.SiteUrl = data.SiteUrl;
                request.ListTemplate = data.ListTemplate;

                request.VersionSettings.RequireContentApproval = false;
                request.VersionSettings.EnableMajorVersions = true;
                request.VersionSettings.MajorVersionLimit = data.MajorVersionLimit;

                var result = this.RequestsApi.SubmitCreateListRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while creating list with version and calling RequestsApi.SubmitCreateListRequest: {e}");
                Console.WriteLine($"Status code: {e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
