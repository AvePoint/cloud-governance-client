namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class ManagePermissionRequestExample : ExampleBase
    {
        public void Run()
        {
            try
            {
                var request = new ManagePermissionRequest();
                var apiInstance = new RequestsApi(Configuration.Default);                
                request.ServiceId = new Guid("8a578313-3098-4845-b04c-3f6ebaf9b489");
                request.Department = "IT";
                request.Summary = "MP Summary" + $"{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                request.ObjectUrl = "https://xxxx.sharepoint.com/sites/xxx";
                request.SpGroupManagement = new List<SPGroupManagementModel>();
                var permissionModel = new PermissionManagementModel();
                permissionModel.PermissionItems = new List<ObjectPermissionManagementModel>();
                var permissionModelItem = new ObjectPermissionManagementModel();
                permissionModelItem.ObjectInfo = new ApiUser()
                {
                    LoginName = "admin@xxx.onmicrosoft.com",
                    DisplayName = "Admin"
                };
                permissionModelItem.ObjectType = SPPrincipalType.User;
                permissionModelItem.Action = ManagePermissionAction.Added;
                permissionModelItem.GrantPermissionSetting = new GrantPermissionModel() 
                { 
                    PermissionDurationSettings = new TemporaryPermissionRequestSetting()
                    { 
                        IsGrantTemporaryPermission = false 
                    } 
                };
                permissionModelItem.Permissions = new List<string>()
                {
                    "Design"
                };
                permissionModel.PermissionItems.Add(permissionModelItem);
                permissionModel.IsUniquePermission = true;
                request.PermissionManagement = permissionModel;
                request.Metadatas = new List<RequestMetadata>();
                var result = apiInstance.SubmitManagePermissionRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
