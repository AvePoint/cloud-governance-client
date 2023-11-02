namespace NetFramework
{
    using Cloud.Governance.Client.Api;
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
                var requestApi = new RequestsApi(Configuration.Default);
                var serviceApi = new ServicesApi(Configuration.Default);

                var serviceId = serviceApi.GetServiceId(data.ServiceName);
                var service = serviceApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                //uncomment below to show the validation result of current url
                //var validateResult = serviceApi.ValidateForManagePermissionService(serviceId, new SiteValidationParameter
                //{
                //    Uri = data.ObjectUrl
                //});

                request.Summary = $"Summary_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                request.ObjectType = NodeType.DocumentLibrary;
                var userPermissions = new PermissionManagementModel
                {
                    IsUniquePermission = true,
                    IsPermissionInheritanceChanged = true
                };
                request.PermissionManagement = userPermissions;
                var id = requestApi.SubmitManagePermissionRequest(request);
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
