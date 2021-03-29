
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class Site_DeleteSharePointGroup : TestBase
    {
        public Site_DeleteSharePointGroup(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                

                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_DeleteSharePointGroup_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                request.Department = data.Department;
                request.SpGroupManagement = new List<SPGroupManagementModel>();
                request.PermissionManagement = new PermissionManagementModel()
                {
                    IsUniquePermission = true,
                    PermissionItems = new List<ObjectPermissionManagementModel>()
                };
                var groupMemberLoginNames = data.SpGroupMemberIdentityName.Split(';');
                var spGroup = new SPGroupManagementModel
                {
                    Name = new StringChangedProperty()
                    {
                        OriginalValue = data.SpGroupNameOriginalValue,
                        ChangeValue = data.SpGroupNameChangeValue
                    },
                    Description = data.SpGroupDescription,
                    Owner = new ApiUser()
                    {
                        LoginName = data.SpGroupOwnerLoginName,
                    },
                    Members = new List<SPUserManagementModel>(),
                    Action = ManagePermissionAction.Deleted
                };
                for (int i = 0; i < groupMemberLoginNames.Length; i++)
                {
                    spGroup.Members.Add(new SPUserManagementModel()
                    {
                        IdentityName = groupMemberLoginNames[i],
                    });
                }
                request.SpGroupManagement.Add(spGroup);
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
