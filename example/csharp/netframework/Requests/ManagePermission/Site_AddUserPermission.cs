
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class Site_AddUserPermission : TestBase
    {
        public Site_AddUserPermission(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                

                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_AddUserPermissionForSite_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl; 
                //request.Department = data.Department;
                request.PermissionManagement = new PermissionManagementModel() {
                    IsUniquePermission = true
                };                
                var permissionInfo = new ObjectPermissionManagementModel() {
                    Action = ManagePermissionAction.Added,
                    ObjectType = SPPrincipalType.User,
                    Permissions = new List<string>(data.PermissionLevels.Split(';')),
                    ObjectInfo = new ApiUser()
                    {
                        Id = data.UserLoginName,
                        Email = data.UserLoginName,
                        //DisplayName = data.UserDisplayName,
                        LoginName = data.UserLoginName,
                        IsGroup = false
                    },
                    GrantPermissionSetting = new GrantPermissionModel() { PermissionDurationSettings = new TemporaryPermissionRequestSetting(), WelcomeEmailSettings = new WelcomeEmailSettings() }
                };
                request.PermissionManagement.PermissionItems = new List<ObjectPermissionManagementModel>();
                request.PermissionManagement.PermissionItems.Add(permissionInfo);
                var id = this.RequestsApi.SubmitManagePermissionRequest(request);
                return id;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitManagePermissionRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw e;
            }
        }
    }
}
