﻿
namespace NetFramework
{
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class Library_InheritParentPermission : TestBase
    {
        public Library_InheritParentPermission(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_InheritPermissionForLibrary_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                request.ObjectType = NodeType.DocumentLibrary;
                var userPermissions = new PermissionManagementModel
                {
                    IsUniquePermission = true,
                    IsPermissionInheritanceChanged = true
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
