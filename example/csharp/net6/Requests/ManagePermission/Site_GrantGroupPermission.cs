
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class Site_GrantGroupPermission : TestBase
    {
        public Site_GrantGroupPermission(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                

                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_GrantGroupPermission_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                ////request.Department = data.Department;
                request.SpGroupManagement = new List<SPGroupManagementModel>();
                request.PermissionManagement = new PermissionManagementModel()
                {
                    IsUniquePermission = true,
                    PermissionItems = new List<ObjectPermissionManagementModel>()
                };
                var groupPermissionInfo = new ObjectPermissionManagementModel()
                {
                    Action = ManagePermissionAction.Added,
                    ObjectType = SPPrincipalType.SecurityGroup,
                    ObjectInfo = new ApiUser()
                    {
                        LoginName = data.ObjectInfoLoginName,
                        IsGroup = true
                    },
                    GrantPermissionSetting = new GrantPermissionModel()
                    {
                        PermissionDurationSettings = new TemporaryPermissionRequestSetting()
                        {
                            IsGrantTemporaryPermission = false,
                            StartTime = DateTime.UtcNow
                        },
                        WelcomeEmailSettings = new WelcomeEmailSettings()
                        {
                            Enabled = false
                        }
                    },
                    Permissions = new List<string>(data.PermissionLevels.Split(';')),
                };
                request.PermissionManagement.PermissionItems.Add(groupPermissionInfo);
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
