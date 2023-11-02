namespace NetFramework
{
    using System;
    using System.Collections.Generic;
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System.Net;
    public class GrantTemporaryPermissionToSiteWithSpecificDate : TestBase
    {
        public GrantTemporaryPermissionToSiteWithSpecificDate(ApiConfig authData) : base(authData) { }

        public Guid Run(GrantPermissionTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetGrantPermissionService(serviceId);
                var request = service.RequestTemplate;

                #region Validate Url
                var grantPermissionUrlValidationResult = this.ServicesApi.ValidateForGrantPermissionService(serviceId, new SiteValidationParameter(data.ObjectUrl));
                var grantPermissionSPObject = grantPermissionUrlValidationResult.Object;
                #endregion

                #region Validate Users
                var selectedUsers = new List<SharingEnabledUser>();
                var userApi = new UsersApi(Configuration.Default);
                var apiUsers = this.ResolveUsers(data.UserLoginNames);

                foreach (var apiUser in apiUsers)
                {
                    selectedUsers.Add(new SharingEnabledUser { LoginName = apiUser.LoginName, DisplayName = apiUser.DisplayName, Email = apiUser.Email });
                }

                #endregion

                #region Permission Settings
                var selectedPermissionLevelList = new List<String>(data.SelectedPermissionLevels.Split(';'));
                var selectedPermissionLevels = grantPermissionUrlValidationResult.SpPermissionLevels?.FindAll(level => selectedPermissionLevelList.Contains(level.Name));
                var permissionSettings = new GrantPermissionRequestPermissionSettings
                {
                    SelectedPermissionLevels = selectedPermissionLevels,
                    IsGrantPermissionDirectly = true,
                };

                var permissionDurationSetting = new GrantPermissionRequestDurationSettings
                {
                    IsGrantTemporaryPermission = true,
                    IsGrantPermissionLevel = true,
                    ExpirationType = ExpirationType.Date,
                    StartTime = DateTime.UtcNow.AddDays(1),
                    EndTime = DateTime.UtcNow.AddDays(7)
                };
                #endregion

                request.Summary = $"Summary_GrantTemporaryPermission_Date_{DateTime.Now}";
                request.ServiceId = serviceId;
                request.Url = grantPermissionSPObject;
                request.SelectedUsers = selectedUsers;
                request.PermissionSettings = permissionSettings;
                request.PermissionDurationSettings = permissionDurationSetting;
                var id = this.RequestsApi.SubmitGrantPermissionRequest(request);
                return id;
            }
            catch (ApiException ex)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitGrantPermissionRequest: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
    }
}
