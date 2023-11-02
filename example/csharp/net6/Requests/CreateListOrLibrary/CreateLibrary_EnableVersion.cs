
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class CreateLibrary_EnableVersion : TestBase
    {
       public CreateLibrary_EnableVersion(ApiConfig config) : base(config) { }

       public Guid Run(CreateListOrLibraryTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateListService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"{data.Summary}_{DateTime.Now}";
                request.ListTitle = $"{data.LibraryTitle}_{DateTime.Now}";
                request.ListType = (ListType)Enum.Parse(typeof(ListType), data.Library);
                request.ListName = $"{data.LibraryName}_{DateTime.Now}";
                request.ParentObject.ParentUrl = data.WebUrl;
                request.ParentObject.SiteUrl = data.SiteUrl;
                request.ListTemplate = data.LibraryTemplate;

                request.VersionSettings.RequireContentApproval = false;
                request.VersionSettings.EnableMajorAndMinorVersions = true;
                request.VersionSettings.EnableMajorVersionLimit = true;
                request.VersionSettings.MajorVersionLimit = data.MajorVersionLimit;
                request.VersionSettings.EnableMinorVersionLimit = true;
                request.VersionSettings.MinorVersionsLimit = data.MinorVersionLimit;

                var result = this.RequestsApi.SubmitCreateListRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while creating library with version and calling RequestsApi.SubmitCreateListRequest: {e}");
                Console.WriteLine($"Status code: {e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
