
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class ChangeListSettings_Name : TestBase
    {
        public ChangeListSettings_Name(ApiConfig config) : base(config) { }

        public Guid Run(ChangeListSettingsTestData data)
        {
            try
            {
                var result = Guid.Empty;
                var serviceApi = new ServicesApi(Configuration.Default);
                var requestApi = new RequestsApi(Configuration.Default);
                var serviceId = serviceApi.GetServiceId(data.ServiceName);
                var service = serviceApi.GetChangeListSettingService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"{data.Summary}_{DateTime.Now}";

                var validationParameters = new SiteValidationParameter
                {
                    Uri = data.Uri,
                    IgnoreLock = false
                };
                var validationResult = serviceApi.ValidateForChangeListSettingService(serviceId, validationParameters);
                var originalInfo = validationResult.Lists[0];

                request.ObjectInfo.WebUrl = validationResult.WebUrl;
                request.ObjectInfo.SiteUrl = validationResult.SiteUrl;
                request.ObjectInfo.ObjectUrl = originalInfo.Url;

                request.ListTitle.ChangeValue = $"{data.ListName}_{DateTime.Now}";

                // not required
                request.ListDescription.ChangeValue = originalInfo.Description;

                // not required
                request.NavigationSetting.OriginalValue = request.NavigationSetting.ChangeValue = originalInfo.IsOnQuickLaunch;

                // not required
                request.VersionSetting.OriginalValue = request.VersionSetting.ChangeValue = new ListVersionSettings
                {
                    RequireContentApproval = originalInfo.IsEnableModeration,
                    ListType = originalInfo.IsLibrary ? ListType.Library : ListType.List,
                    EnableMajorAndMinorVersions = originalInfo.IsEnableModeration && originalInfo.IsEnableVersioning && originalInfo.IsEnableMinorVersion,
                    EnableMajorVersionLimit = originalInfo.IsEnableVersioning,
                    EnableMajorVersions = originalInfo.IsEnableVersioning,
                    MajorVersionLimit = originalInfo.MajorVersionLimit,
                    EnableMinorVersionLimit = originalInfo.IsEnableMinorVersion,
                    MinorVersionsLimit = originalInfo.MajorWithMinorVersionsLimit
                };

                result = requestApi.SubmitChangeListSettingRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while changing list settings and calling RequestsApi.SubmitChangeListSettingRequest: {e}");
                Console.WriteLine($"Status code: {e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
