
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class Site_GrantUserTemporaryPermission : TestBase
    {
        public Site_GrantUserTemporaryPermission(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                

                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_GrantUserTemporaryPermission_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                ////request.Department = data.Department;
                request.SpGroupManagement = new List<SPGroupManagementModel>();
                request.PermissionManagement = new PermissionManagementModel()
                {
                    IsUniquePermission = true,
                    PermissionItems = new List<ObjectPermissionManagementModel>()
                };
                var objectInfoLoginName = data.ObjectInfoLoginName + DateTime.Now.Millisecond;
                var userPermissionInfo = new ObjectPermissionManagementModel()
                {
                    Action = ManagePermissionAction.Added,
                    ObjectType = SPPrincipalType.SharePointGroup,
                    ObjectInfo = new ApiUser()
                    {
                        Id = objectInfoLoginName,
                        LoginName = objectInfoLoginName,
                        DisplayName = objectInfoLoginName
                    },
                    GrantPermissionSetting = new GrantPermissionModel()
                    {
                        PermissionDurationSettings = new TemporaryPermissionRequestSetting()
                        {
                            DurationDateType = ApiDurationType.Day,
                            DurationInterval = 10,
                            IsGrantTemporaryPermission = true,
                            ExpirationType = ExpirationType.Duration,
                            StartTime = DateTime.UtcNow
                        },
                        WelcomeEmailSettings = new WelcomeEmailSettings()
                    },
                    Permissions = new List<string>(data.PermissionLevels.Split(';')),
                    Members = new List<SharingEnabledUser>()
                    {
                        new SharingEnabledUser()
                        {
                            LoginName = data.UserLoginName,
                            Id = data.UserLoginName
                        }
                    }
                };
                request.PermissionManagement.PermissionItems.Add(userPermissionInfo);
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
