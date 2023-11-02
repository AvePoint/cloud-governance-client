namespace NetFramework
{
    using System;
    using System.Collections.Generic;
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System.Net;
    public class GrantPermissionToList : TestBase
    {
        public GrantPermissionToList(ApiConfig authData) : base(authData) { }

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
                var apiUsers = this.ResolveUsers(data.UserLoginNames, ApiUserType.UserAndGroup);

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
                    IsBreakInheritance = true,
                    IsGrantPermissionDirectly = true,
                    SelectedPermissionLevels = selectedPermissionLevels,
                };
                #endregion

                request.Summary = $"Summary_GrantUserPermission_List{DateTime.Now}";
                request.ServiceId = serviceId;
                request.Url = grantPermissionSPObject;
                request.SelectedUsers = selectedUsers;
                request.PermissionSettings = permissionSettings;
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
