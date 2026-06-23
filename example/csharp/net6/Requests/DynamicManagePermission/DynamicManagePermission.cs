namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class DynamicManagePermission : TestBase
    {
        public DynamicManagePermission(ApiConfig authData) : base(authData)
        {
        }

        public Guid Run(Guid serviceId)
        {
            try
            {
                var serviceApi = new ServicesApi(Configuration.Default);
                var requestApi = new RequestsApi(Configuration.Default);
                DynamicRequestTemplateModel request = serviceApi.GetDynamicServiceRequestTemplate(serviceId);
                if (request != null && request.ActivityGalleries.Count > 0)
                {
                    request.Summary = "Demo Dynamic manager permission Request";
                    request.NotesToApprovers = "Please approve this request.";
                    request.ActivityGalleries.ForEach(activity =>
                    {
                        if (activity is ManagePermissionGalleryRequestModel managePermissionActivity)
                        {
                            managePermissionActivity.ManagePermissionObjectModel.SiteUrl = "https://bigapp.sharepoint.com/sites/demotesturl";
                            managePermissionActivity.ManagePermissionObjectModel.ObjectUrl = "https://bigapp.sharepoint.com/sites/demotesturl";
                            managePermissionActivity.ManagePermissionObjectModel.ObjectType = ApiModelNodeType.Site;
                            managePermissionActivity.GrantPermissionSettingModel.SpGroupManagement = new List<ApiModelRequestDynamicServiceManagePermissionActivitySPGroupManagementModel>
                {
                    new ApiModelRequestDynamicServiceManagePermissionActivitySPGroupManagementModel
                    {
                        Action = ManagePermissionAction.Changed,
                        Name = new StringChangedProperty
                        {
                            OriginalValue = "DemoSiteTitle 访问者",
                            ChangeValue = "DemoSiteTitle 访问者",
                        },
                        SendMembershipRequestEmailAddress = new StringChangedProperty
                        {
                            OriginalValue = "",
                            ChangeValue = ""
                        },
                        Description = new StringChangedProperty
                        {
                            OriginalValue = "",
                            ChangeValue = ""
                        },
                        Id = 4,//SP Group ID
                        Owner = new GroupOwnerModelChangedProperty
                        {
                            OriginalValue = new GroupOwnerModel(),
                            ChangeValue = new GroupOwnerModel()
                        },
                        Members = new List<ApiModelRequestDynamicServiceManagePermissionActivitySPUserManagementModel>
                        {
                            new ApiModelRequestDynamicServiceManagePermissionActivitySPUserManagementModel
                            {
                                IdentityName = "william3@baron.space",
                                DisplayName = "William3",
                                Action = ManagePermissionAction.Added
                            }
                        }
                    }
                };
                            managePermissionActivity.GrantPermissionSettingModel.PermissionManagement = new ApiModelRequestDynamicServiceManagePermissionActivityPermissionManagementModel
                            {
                                PermissionItems = new List<ApiModelRequestDynamicServiceManagePermissionActivityObjectPermissionManagementModel>
                                {
                                    new ApiModelRequestDynamicServiceManagePermissionActivityObjectPermissionManagementModel
                                    {
                                        Action = ManagePermissionAction.Added,
                                        ObjectType = DomainPermissionManagmentSPPrincipalType.User,
                                        ObjectInfo = new ApiUser
                                        {
                                            LoginName = "william@baron.space",
                                            DisplayName = "William sun"
                                        },
                                        Permissions = new List<String> { "完全控制" }
                                    }
                                }
                            };
                        }
                    });
                }
                var apiRequestInstance = new RequestsApi(Configuration.Default);
                return apiRequestInstance.SubmitDynamicRequestByTemplate(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception while submitting dynamic manage permission request: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                return Guid.Empty;
            }
        }
    }
}