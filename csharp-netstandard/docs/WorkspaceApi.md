# Cloud.Governance.NewSdk.Api.WorkspaceApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmGorup**](WorkspaceApi.md#confirmgorup) | **POST** /workspace/groups/{id}/confirm | confirm auto imported group/teams information
[**ConfirmGorupWithUnknowPrimaryContact**](WorkspaceApi.md#confirmgorupwithunknowprimarycontact) | **POST** /workspace/groups/{id}/confirm/assigntoadmincontact | confirm auto imported group/teams by assigning task to administrator
[**ConfirmGroupWithKnowningPrimaryContact**](WorkspaceApi.md#confirmgroupwithknowningprimarycontact) | **POST** /workspace/groups/{id}/confirm/changeprimarycontact | confirm auto imported group/teams by assigning task to the specified primary contact
[**ConfirmSite**](WorkspaceApi.md#confirmsite) | **POST** /workspace/sites/{id}/confirm | confirm auto imported site information
[**ConfirmSiteWitKnowingPrimaryContact**](WorkspaceApi.md#confirmsitewitknowingprimarycontact) | **POST** /workspace/sites/{id}/confirm/changeprimarycontact | confirm auto imported site by assigning task to the specified primary contact
[**ConfirmSiteWithUnknowPrimaryContact**](WorkspaceApi.md#confirmsitewithunknowprimarycontact) | **POST** /workspace/sites/{id}/confirm/assigntoadmincontact | confirm auto imported site by assigning task to administrator
[**GetGroupAutoImportProfile**](WorkspaceApi.md#getgroupautoimportprofile) | **GET** /workspace/groups/{id}/confirm/settings | get group/teams auto-imported profile information
[**GetGroupContacts**](WorkspaceApi.md#getgroupcontacts) | **GET** /workspace/groups/{id}/contacts | get group/teams contacts
[**GetGroupMembershipRenewalItems**](WorkspaceApi.md#getgroupmembershiprenewalitems) | **GET** /workspace/groups/{id}/renew/membership | get group/teams membership renewal items
[**GetGroupMetadataRenewalItems**](WorkspaceApi.md#getgroupmetadatarenewalitems) | **GET** /workspace/groups/{id}/renew/metadata | get group/teams metadata renewal items
[**GetGroupPermissionRenewalFilters**](WorkspaceApi.md#getgrouppermissionrenewalfilters) | **GET** /workspace/groups/{id}/renew/permission/filters | get group/teams permission renewal report filters
[**GetGroupPermissionRenewalFiltersForSPGroup**](WorkspaceApi.md#getgrouppermissionrenewalfiltersforspgroup) | **GET** /workspace/groups/{id}/renew/permission/group/{groupid}/filters | get group/teams permission renewal sharePoint group report filters
[**GetGroupPermissionRenewalItems**](WorkspaceApi.md#getgrouppermissionrenewalitems) | **GET** /workspace/groups/{id}/renew/permissions | get group/teams permission renewal items
[**GetGroupPermissionRenewalItemsForSPGroup**](WorkspaceApi.md#getgrouppermissionrenewalitemsforspgroup) | **GET** /workspace/groups/{id}/renew/permissions/group/{groupid} | get sharePoint group members of group/teams permission renewal item
[**GetGroupPermissionRenewalPermissionLevels**](WorkspaceApi.md#getgrouppermissionrenewalpermissionlevels) | **GET** /workspace/groups/{id}/renew/permissionlevels | get group/teams permission level for permission renewal
[**GetGroupRenewalProfileSettings**](WorkspaceApi.md#getgrouprenewalprofilesettings) | **GET** /workspace/groups/{id}/renew/settings | get group/teams renewal settings
[**GetGroupSharingOptions**](WorkspaceApi.md#getgroupsharingoptions) | **GET** /workspace/groups/sharingoptions | get group sharing options
[**GetMyGroupInformation**](WorkspaceApi.md#getmygroupinformation) | **GET** /workspace/groups/{id} | get O365 group/teams information
[**GetMySiteInformation**](WorkspaceApi.md#getmysiteinformation) | **GET** /workspace/sites/{id} | 
[**GetSiteAutoImportProfile**](WorkspaceApi.md#getsiteautoimportprofile) | **POST** /workspace/sites/{id}/confirm/settings | get site auto import settings
[**GetSiteContacts**](WorkspaceApi.md#getsitecontacts) | **GET** /workspace/sites/{id}/contacts | get site contacts
[**GetSiteMetadata**](WorkspaceApi.md#getsitemetadata) | **GET** /workspace/sites/metadata | get site metadata
[**GetSiteMetadataRenewalItems**](WorkspaceApi.md#getsitemetadatarenewalitems) | **GET** /workspace/sites/{id}/renew/metadata | get site metadata renewal items
[**GetSitePermissionRenewalFilters**](WorkspaceApi.md#getsitepermissionrenewalfilters) | **GET** /workspace/sites/{id}/renew/permission/filters | get site permission renewal report filters
[**GetSitePermissionRenewalFiltersForSPGroup**](WorkspaceApi.md#getsitepermissionrenewalfiltersforspgroup) | **GET** /workspace/sites/{id}/renew/permission/group/{groupid}/filters | get site permission renewal sharePoint group report filters
[**GetSitePermissionRenewalItems**](WorkspaceApi.md#getsitepermissionrenewalitems) | **GET** /workspace/sites/{id}/renew/permissions | get site permission renewal items
[**GetSitePermissionRenewalItemsForSPGroup**](WorkspaceApi.md#getsitepermissionrenewalitemsforspgroup) | **GET** /workspace/sites/{id}/renew/permissions/group/{groupid} | get sharePoint group members of site permission renewal item
[**GetSitePermissionRenewalPermissionLevels**](WorkspaceApi.md#getsitepermissionrenewalpermissionlevels) | **GET** /workspace/sites/{id}/renew/permissionlevels | get site permission level for permission renewal
[**GetSiteRenewalProfileSettings**](WorkspaceApi.md#getsiterenewalprofilesettings) | **GET** /workspace/sites/{id}/renew/settings | get site renewal settings
[**GetSiteSharingOptions**](WorkspaceApi.md#getsitesharingoptions) | **GET** /workspace/sites/sharingoptions | get site sharing options by site url or id
[**GetWorkspaceFilters**](WorkspaceApi.md#getworkspacefilters) | **GET** /workspace/my/filters | get my workspace filters
[**GetWorkspaceItems**](WorkspaceApi.md#getworkspaceitems) | **GET** /workspace/my | get my workspace items
[**ReassignGroupRenewalTask**](WorkspaceApi.md#reassigngrouprenewaltask) | **POST** /workspace/groups/{id}/renew/reassign | reassign the group/teams renewal task
[**ReassignSiteRenewalTask**](WorkspaceApi.md#reassignsiterenewaltask) | **POST** /workspace/sites/{id}/renew/reassign | reassign the site renewal task
[**RejectGroupRenewalTask**](WorkspaceApi.md#rejectgrouprenewaltask) | **POST** /workspace/groups/{id}/renew/reject | reject the group/teams renewal task
[**RejectSiteRenewalTask**](WorkspaceApi.md#rejectsiterenewaltask) | **POST** /workspace/sites/{id}/renew/reject | reject the site renewal task
[**ResetChangeForSiteRenewal**](WorkspaceApi.md#resetchangeforsiterenewal) | **POST** /workspace/sites/{id}/renew/reset | reset your change
[**ResetChangesForGroupRenewal**](WorkspaceApi.md#resetchangesforgrouprenewal) | **POST** /workspace/groups/{id}/renew/reset | reset your change
[**SaveGroupPermissionRenewalItems**](WorkspaceApi.md#savegrouppermissionrenewalitems) | **POST** /workspace/groups/{id}/renew/permissions | save group/teams permission renewal items
[**SaveSitePermissionRenewalItems**](WorkspaceApi.md#savesitepermissionrenewalitems) | **POST** /workspace/sites/{id}/renew/permissions | save site permission renewal items
[**SubmitGroupRenewalTask**](WorkspaceApi.md#submitgrouprenewaltask) | **POST** /workspace/groups/{id}/renew/submit | submit the group/teams renewal task
[**SubmitGroupRenewalTaskForArchiving**](WorkspaceApi.md#submitgrouprenewaltaskforarchiving) | **POST** /workspace/groups/{id}/renew/archive | submit group/teams renewal task with archive
[**SubmitGroupRenewalTaskForDeleting**](WorkspaceApi.md#submitgrouprenewaltaskfordeleting) | **POST** /workspace/groups/{id}/renew/delete | submit group/teams renewal task with deletion
[**SubmitSiteRenewalTask**](WorkspaceApi.md#submitsiterenewaltask) | **POST** /workspace/sites/{id}/renew/submit | submit the site renewal task
[**SubmitSiteRenewalTaskForDeleting**](WorkspaceApi.md#submitsiterenewaltaskfordeleting) | **POST** /workspace/sites/{id}/renew/delete | submit site renewal task with deletion
[**SubmitSiteRenewalTaskWithArchiving**](WorkspaceApi.md#submitsiterenewaltaskwitharchiving) | **POST** /workspace/sites/{id}/renew/archive | approval site renewal task with archive


<a name="confirmgorup"></a>
# **ConfirmGorup**
> void ConfirmGorup (Guid id, ConfirmInformation confirmInformation = null)

confirm auto imported group/teams information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ConfirmGorupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var confirmInformation = new ConfirmInformation(); // ConfirmInformation |  (optional) 

            try
            {
                // confirm auto imported group/teams information
                apiInstance.ConfirmGorup(id, confirmInformation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ConfirmGorup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **confirmInformation** | [**ConfirmInformation**](ConfirmInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmgorupwithunknowprimarycontact"></a>
# **ConfirmGorupWithUnknowPrimaryContact**
> void ConfirmGorupWithUnknowPrimaryContact (Guid id)

confirm auto imported group/teams by assigning task to administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ConfirmGorupWithUnknowPrimaryContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // confirm auto imported group/teams by assigning task to administrator
                apiInstance.ConfirmGorupWithUnknowPrimaryContact(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ConfirmGorupWithUnknowPrimaryContact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmgroupwithknowningprimarycontact"></a>
# **ConfirmGroupWithKnowningPrimaryContact**
> void ConfirmGroupWithKnowningPrimaryContact (Guid id, UserParam userParam = null)

confirm auto imported group/teams by assigning task to the specified primary contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ConfirmGroupWithKnowningPrimaryContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var userParam = new UserParam(); // UserParam |  (optional) 

            try
            {
                // confirm auto imported group/teams by assigning task to the specified primary contact
                apiInstance.ConfirmGroupWithKnowningPrimaryContact(id, userParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ConfirmGroupWithKnowningPrimaryContact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **userParam** | [**UserParam**](UserParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmsite"></a>
# **ConfirmSite**
> void ConfirmSite (Guid id, ConfirmInformation confirmInformation = null)

confirm auto imported site information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ConfirmSiteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var confirmInformation = new ConfirmInformation(); // ConfirmInformation |  (optional) 

            try
            {
                // confirm auto imported site information
                apiInstance.ConfirmSite(id, confirmInformation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ConfirmSite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **confirmInformation** | [**ConfirmInformation**](ConfirmInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmsitewitknowingprimarycontact"></a>
# **ConfirmSiteWitKnowingPrimaryContact**
> void ConfirmSiteWitKnowingPrimaryContact (Guid id, UserParam userParam = null)

confirm auto imported site by assigning task to the specified primary contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ConfirmSiteWitKnowingPrimaryContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var userParam = new UserParam(); // UserParam |  (optional) 

            try
            {
                // confirm auto imported site by assigning task to the specified primary contact
                apiInstance.ConfirmSiteWitKnowingPrimaryContact(id, userParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ConfirmSiteWitKnowingPrimaryContact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **userParam** | [**UserParam**](UserParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmsitewithunknowprimarycontact"></a>
# **ConfirmSiteWithUnknowPrimaryContact**
> void ConfirmSiteWithUnknowPrimaryContact (Guid id)

confirm auto imported site by assigning task to administrator

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ConfirmSiteWithUnknowPrimaryContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // confirm auto imported site by assigning task to administrator
                apiInstance.ConfirmSiteWithUnknowPrimaryContact(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ConfirmSiteWithUnknowPrimaryContact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupautoimportprofile"></a>
# **GetGroupAutoImportProfile**
> AutoImportProfileRef GetGroupAutoImportProfile (Guid id)

get group/teams auto-imported profile information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupAutoImportProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group/teams auto-imported profile information
                AutoImportProfileRef result = apiInstance.GetGroupAutoImportProfile(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupAutoImportProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**AutoImportProfileRef**](AutoImportProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupcontacts"></a>
# **GetGroupContacts**
> ObjectContactModel GetGroupContacts (Guid id)

get group/teams contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group/teams contacts
                ObjectContactModel result = apiInstance.GetGroupContacts(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupContacts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**ObjectContactModel**](ObjectContactModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembershiprenewalitems"></a>
# **GetGroupMembershipRenewalItems**
> List&lt;MembershipRenewalItemModel&gt; GetGroupMembershipRenewalItems (Guid id)

get group/teams membership renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupMembershipRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group/teams membership renewal items
                List<MembershipRenewalItemModel> result = apiInstance.GetGroupMembershipRenewalItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupMembershipRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;MembershipRenewalItemModel&gt;**](MembershipRenewalItemModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmetadatarenewalitems"></a>
# **GetGroupMetadataRenewalItems**
> List&lt;CustomMetadata&gt; GetGroupMetadataRenewalItems (Guid id)

get group/teams metadata renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupMetadataRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group/teams metadata renewal items
                List<CustomMetadata> result = apiInstance.GetGroupMetadataRenewalItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupMetadataRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;CustomMetadata&gt;**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrenewalfilters"></a>
# **GetGroupPermissionRenewalFilters**
> DistinctPageResult GetGroupPermissionRenewalFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get group/teams permission renewal report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupPermissionRenewalFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group/teams permission renewal report filters
                DistinctPageResult result = apiInstance.GetGroupPermissionRenewalFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupPermissionRenewalFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrenewalfiltersforspgroup"></a>
# **GetGroupPermissionRenewalFiltersForSPGroup**
> DistinctPageResult GetGroupPermissionRenewalFiltersForSPGroup (Guid id, Guid groupid, string filter = null, string distinct = null, int? top = null, int? skip = null)

get group/teams permission renewal sharePoint group report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupPermissionRenewalFiltersForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group/teams permission renewal sharePoint group report filters
                DistinctPageResult result = apiInstance.GetGroupPermissionRenewalFiltersForSPGroup(id, groupid, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupPermissionRenewalFiltersForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrenewalitems"></a>
# **GetGroupPermissionRenewalItems**
> PermissionActionItemPageResult GetGroupPermissionRenewalItems (Guid id, string filter = null, string orderby = null, Object body = null)

get group/teams permission renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupPermissionRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // get group/teams permission renewal items
                PermissionActionItemPageResult result = apiInstance.GetGroupPermissionRenewalItems(id, filter, orderby, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupPermissionRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrenewalitemsforspgroup"></a>
# **GetGroupPermissionRenewalItemsForSPGroup**
> PermissionActionItemPageResult GetGroupPermissionRenewalItemsForSPGroup (Guid id, Guid groupid, string filter = null, string orderby = null, Object body = null)

get sharePoint group members of group/teams permission renewal item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupPermissionRenewalItemsForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // get sharePoint group members of group/teams permission renewal item
                PermissionActionItemPageResult result = apiInstance.GetGroupPermissionRenewalItemsForSPGroup(id, groupid, filter, orderby, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupPermissionRenewalItemsForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrenewalpermissionlevels"></a>
# **GetGroupPermissionRenewalPermissionLevels**
> List&lt;PermissionLevel&gt; GetGroupPermissionRenewalPermissionLevels (Guid id)

get group/teams permission level for permission renewal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupPermissionRenewalPermissionLevelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group/teams permission level for permission renewal
                List<PermissionLevel> result = apiInstance.GetGroupPermissionRenewalPermissionLevels(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupPermissionRenewalPermissionLevels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;PermissionLevel&gt;**](PermissionLevel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprenewalprofilesettings"></a>
# **GetGroupRenewalProfileSettings**
> GroupRenewProfileRef GetGroupRenewalProfileSettings (Guid id)

get group/teams renewal settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupRenewalProfileSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group/teams renewal settings
                GroupRenewProfileRef result = apiInstance.GetGroupRenewalProfileSettings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupRenewalProfileSettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**GroupRenewProfileRef**](GroupRenewProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsharingoptions"></a>
# **GetGroupSharingOptions**
> ExternalSharingOptions GetGroupSharingOptions (string emailOrId = null)

get group sharing options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupSharingOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var emailOrId = emailOrId_example;  // string |  (optional) 

            try
            {
                // get group sharing options
                ExternalSharingOptions result = apiInstance.GetGroupSharingOptions(emailOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetGroupSharingOptions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailOrId** | **string**|  | [optional] 

### Return type

[**ExternalSharingOptions**](ExternalSharingOptions.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmygroupinformation"></a>
# **GetMyGroupInformation**
> ApiMyGroup GetMyGroupInformation (Guid id)

get O365 group/teams information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetMyGroupInformationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get O365 group/teams information
                ApiMyGroup result = apiInstance.GetMyGroupInformation(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetMyGroupInformation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**ApiMyGroup**](ApiMyGroup.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmysiteinformation"></a>
# **GetMySiteInformation**
> MySite GetMySiteInformation (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetMySiteInformationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                MySite result = apiInstance.GetMySiteInformation(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetMySiteInformation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**MySite**](MySite.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsiteautoimportprofile"></a>
# **GetSiteAutoImportProfile**
> AutoImportProfileRef GetSiteAutoImportProfile (Guid id)

get site auto import settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteAutoImportProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site auto import settings
                AutoImportProfileRef result = apiInstance.GetSiteAutoImportProfile(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSiteAutoImportProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**AutoImportProfileRef**](AutoImportProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitecontacts"></a>
# **GetSiteContacts**
> ObjectContactModel GetSiteContacts (Guid id)

get site contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site contacts
                ObjectContactModel result = apiInstance.GetSiteContacts(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSiteContacts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**ObjectContactModel**](ObjectContactModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitemetadata"></a>
# **GetSiteMetadata**
> List&lt;CustomMetadata&gt; GetSiteMetadata (string url)

get site metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var url = url_example;  // string | 

            try
            {
                // get site metadata
                List<CustomMetadata> result = apiInstance.GetSiteMetadata(url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSiteMetadata: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**|  | 

### Return type

[**List&lt;CustomMetadata&gt;**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitemetadatarenewalitems"></a>
# **GetSiteMetadataRenewalItems**
> List&lt;CustomMetadata&gt; GetSiteMetadataRenewalItems (Guid id)

get site metadata renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteMetadataRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site metadata renewal items
                List<CustomMetadata> result = apiInstance.GetSiteMetadataRenewalItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSiteMetadataRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;CustomMetadata&gt;**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrenewalfilters"></a>
# **GetSitePermissionRenewalFilters**
> DistinctPageResult GetSitePermissionRenewalFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get site permission renewal report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSitePermissionRenewalFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission renewal report filters
                DistinctPageResult result = apiInstance.GetSitePermissionRenewalFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSitePermissionRenewalFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrenewalfiltersforspgroup"></a>
# **GetSitePermissionRenewalFiltersForSPGroup**
> DistinctPageResult GetSitePermissionRenewalFiltersForSPGroup (Guid id, Guid groupid, string filter = null, string distinct = null, int? top = null, int? skip = null)

get site permission renewal sharePoint group report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSitePermissionRenewalFiltersForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission renewal sharePoint group report filters
                DistinctPageResult result = apiInstance.GetSitePermissionRenewalFiltersForSPGroup(id, groupid, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSitePermissionRenewalFiltersForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrenewalitems"></a>
# **GetSitePermissionRenewalItems**
> PermissionActionItemPageResult GetSitePermissionRenewalItems (Guid id, string filter = null, string orderby = null, Object body = null)

get site permission renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSitePermissionRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // get site permission renewal items
                PermissionActionItemPageResult result = apiInstance.GetSitePermissionRenewalItems(id, filter, orderby, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSitePermissionRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrenewalitemsforspgroup"></a>
# **GetSitePermissionRenewalItemsForSPGroup**
> PermissionActionItemPageResult GetSitePermissionRenewalItemsForSPGroup (Guid id, Guid groupid, string filter = null, string orderby = null, Object body = null)

get sharePoint group members of site permission renewal item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSitePermissionRenewalItemsForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // get sharePoint group members of site permission renewal item
                PermissionActionItemPageResult result = apiInstance.GetSitePermissionRenewalItemsForSPGroup(id, groupid, filter, orderby, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSitePermissionRenewalItemsForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrenewalpermissionlevels"></a>
# **GetSitePermissionRenewalPermissionLevels**
> List&lt;PermissionLevel&gt; GetSitePermissionRenewalPermissionLevels (Guid id)

get site permission level for permission renewal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSitePermissionRenewalPermissionLevelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site permission level for permission renewal
                List<PermissionLevel> result = apiInstance.GetSitePermissionRenewalPermissionLevels(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSitePermissionRenewalPermissionLevels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;PermissionLevel&gt;**](PermissionLevel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsiterenewalprofilesettings"></a>
# **GetSiteRenewalProfileSettings**
> RenewProfileRef GetSiteRenewalProfileSettings (Guid id)

get site renewal settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteRenewalProfileSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site renewal settings
                RenewProfileRef result = apiInstance.GetSiteRenewalProfileSettings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSiteRenewalProfileSettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**RenewProfileRef**](RenewProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitesharingoptions"></a>
# **GetSiteSharingOptions**
> ExternalSharingOptions GetSiteSharingOptions (string siteUrlOrId = null)

get site sharing options by site url or id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteSharingOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var siteUrlOrId = siteUrlOrId_example;  // string |  (optional) 

            try
            {
                // get site sharing options by site url or id
                ExternalSharingOptions result = apiInstance.GetSiteSharingOptions(siteUrlOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetSiteSharingOptions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **siteUrlOrId** | **string**|  | [optional] 

### Return type

[**ExternalSharingOptions**](ExternalSharingOptions.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacefilters"></a>
# **GetWorkspaceFilters**
> DistinctPageResult GetWorkspaceFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get my workspace filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetWorkspaceFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get my workspace filters
                DistinctPageResult result = apiInstance.GetWorkspaceFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaceitems"></a>
# **GetWorkspaceItems**
> List&lt;WorkspaceList&gt; GetWorkspaceItems (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get my workspace items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetWorkspaceItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get my workspace items
                List<WorkspaceList> result = apiInstance.GetWorkspaceItems(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**List&lt;WorkspaceList&gt;**](WorkspaceList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reassigngrouprenewaltask"></a>
# **ReassignGroupRenewalTask**
> void ReassignGroupRenewalTask (Guid id, string userid = null)

reassign the group/teams renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ReassignGroupRenewalTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var userid = userid_example;  // string |  (optional) 

            try
            {
                // reassign the group/teams renewal task
                apiInstance.ReassignGroupRenewalTask(id, userid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ReassignGroupRenewalTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **userid** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reassignsiterenewaltask"></a>
# **ReassignSiteRenewalTask**
> void ReassignSiteRenewalTask (Guid id, string userid = null)

reassign the site renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ReassignSiteRenewalTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var userid = userid_example;  // string |  (optional) 

            try
            {
                // reassign the site renewal task
                apiInstance.ReassignSiteRenewalTask(id, userid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ReassignSiteRenewalTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **userid** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejectgrouprenewaltask"></a>
# **RejectGroupRenewalTask**
> void RejectGroupRenewalTask (Guid id)

reject the group/teams renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class RejectGroupRenewalTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // reject the group/teams renewal task
                apiInstance.RejectGroupRenewalTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.RejectGroupRenewalTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejectsiterenewaltask"></a>
# **RejectSiteRenewalTask**
> void RejectSiteRenewalTask (Guid id)

reject the site renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class RejectSiteRenewalTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // reject the site renewal task
                apiInstance.RejectSiteRenewalTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.RejectSiteRenewalTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetchangeforsiterenewal"></a>
# **ResetChangeForSiteRenewal**
> void ResetChangeForSiteRenewal (Guid id)

reset your change

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ResetChangeForSiteRenewalExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // reset your change
                apiInstance.ResetChangeForSiteRenewal(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ResetChangeForSiteRenewal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetchangesforgrouprenewal"></a>
# **ResetChangesForGroupRenewal**
> void ResetChangesForGroupRenewal (Guid id)

reset your change

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ResetChangesForGroupRenewalExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // reset your change
                apiInstance.ResetChangesForGroupRenewal(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ResetChangesForGroupRenewal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savegrouppermissionrenewalitems"></a>
# **SaveGroupPermissionRenewalItems**
> void SaveGroupPermissionRenewalItems (Guid id, List<PermissionActionItem> permissionActionItem = null)

save group/teams permission renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SaveGroupPermissionRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var permissionActionItem = new List<PermissionActionItem>(); // List<PermissionActionItem> |  (optional) 

            try
            {
                // save group/teams permission renewal items
                apiInstance.SaveGroupPermissionRenewalItems(id, permissionActionItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SaveGroupPermissionRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **permissionActionItem** | [**List&lt;PermissionActionItem&gt;**](PermissionActionItem.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savesitepermissionrenewalitems"></a>
# **SaveSitePermissionRenewalItems**
> void SaveSitePermissionRenewalItems (Guid id, List<PermissionActionItem> permissionActionItem = null)

save site permission renewal items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SaveSitePermissionRenewalItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var permissionActionItem = new List<PermissionActionItem>(); // List<PermissionActionItem> |  (optional) 

            try
            {
                // save site permission renewal items
                apiInstance.SaveSitePermissionRenewalItems(id, permissionActionItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SaveSitePermissionRenewalItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **permissionActionItem** | [**List&lt;PermissionActionItem&gt;**](PermissionActionItem.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitgrouprenewaltask"></a>
# **SubmitGroupRenewalTask**
> bool SubmitGroupRenewalTask (Guid id, RenewModel renewModel = null)

submit the group/teams renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitGroupRenewalTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var renewModel = new RenewModel(); // RenewModel |  (optional) 

            try
            {
                // submit the group/teams renewal task
                bool result = apiInstance.SubmitGroupRenewalTask(id, renewModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SubmitGroupRenewalTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **renewModel** | [**RenewModel**](RenewModel.md)|  | [optional] 

### Return type

**bool**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitgrouprenewaltaskforarchiving"></a>
# **SubmitGroupRenewalTaskForArchiving**
> void SubmitGroupRenewalTaskForArchiving (Guid id)

submit group/teams renewal task with archive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitGroupRenewalTaskForArchivingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // submit group/teams renewal task with archive
                apiInstance.SubmitGroupRenewalTaskForArchiving(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SubmitGroupRenewalTaskForArchiving: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitgrouprenewaltaskfordeleting"></a>
# **SubmitGroupRenewalTaskForDeleting**
> void SubmitGroupRenewalTaskForDeleting (Guid id)

submit group/teams renewal task with deletion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitGroupRenewalTaskForDeletingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // submit group/teams renewal task with deletion
                apiInstance.SubmitGroupRenewalTaskForDeleting(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SubmitGroupRenewalTaskForDeleting: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitsiterenewaltask"></a>
# **SubmitSiteRenewalTask**
> bool SubmitSiteRenewalTask (Guid id, RenewModel renewModel = null)

submit the site renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitSiteRenewalTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var renewModel = new RenewModel(); // RenewModel |  (optional) 

            try
            {
                // submit the site renewal task
                bool result = apiInstance.SubmitSiteRenewalTask(id, renewModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SubmitSiteRenewalTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **renewModel** | [**RenewModel**](RenewModel.md)|  | [optional] 

### Return type

**bool**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitsiterenewaltaskfordeleting"></a>
# **SubmitSiteRenewalTaskForDeleting**
> void SubmitSiteRenewalTaskForDeleting (Guid id)

submit site renewal task with deletion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitSiteRenewalTaskForDeletingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // submit site renewal task with deletion
                apiInstance.SubmitSiteRenewalTaskForDeleting(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SubmitSiteRenewalTaskForDeleting: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitsiterenewaltaskwitharchiving"></a>
# **SubmitSiteRenewalTaskWithArchiving**
> void SubmitSiteRenewalTaskWithArchiving (Guid id)

approval site renewal task with archive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitSiteRenewalTaskWithArchivingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // approval site renewal task with archive
                apiInstance.SubmitSiteRenewalTaskWithArchiving(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.SubmitSiteRenewalTaskWithArchiving: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

