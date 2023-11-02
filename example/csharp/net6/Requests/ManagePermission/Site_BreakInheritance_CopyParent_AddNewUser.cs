
namespace NetFramework
{
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class Site_BreakInheritance_CopyParent_AddNewUser : TestBase
    {
        public Site_BreakInheritance_CopyParent_AddNewUser(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_BreakInheritancePermissionForSite_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                request.ObjectType = NodeType.Web;
                var userPermission = new ObjectPermissionManagementModel();
                var grantUser = new ApiUser(loginName: data.GrantUserLoginName);
                userPermission = new ObjectPermissionManagementModel
                {
                    ObjectInfo = grantUser,
                    ObjectType = SPPrincipalType.User,
                    Action = ManagePermissionAction.Added,
                    Permissions = new List<string>(data.PermissionLevels.Split(';')),
                    GrantPermissionSetting = new GrantPermissionModel() { PermissionDurationSettings = new TemporaryPermissionRequestSetting(),WelcomeEmailSettings = new WelcomeEmailSettings()}
                };

                var userPermissions = new PermissionManagementModel
                {
                    PermissionItems = new List<ObjectPermissionManagementModel> { userPermission },
                    IsUniquePermission = false,
                    IsPermissionInheritanceChanged = true,
                    IsCopyPermissionsFromParent = true
                };
                request.PermissionManagement = userPermissions;
                var id = this.RequestsApi.SubmitManagePermissionRequest(request);
                return id;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw e;
            }
        }
    }
}
