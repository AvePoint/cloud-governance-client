# Cloud.Governance.NewSdk.Api.ServicesApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCreateListService**](ServicesApi.md#addcreatelistservice) | **POST** /services/createsite | Add create site service
[**AddCreateWebService**](ServicesApi.md#addcreatewebservice) | **POST** /services/createweb | 
[**GetChangeGroupSettingService**](ServicesApi.md#getchangegroupsettingservice) | **GET** /services/changegroupsetting/{id} | get change group setting service
[**GetChangeListSettingService**](ServicesApi.md#getchangelistsettingservice) | **GET** /services/changelistsetting/{id} | get change list setting service
[**GetChangePermissionService**](ServicesApi.md#getchangepermissionservice) | **GET** /services/changepermission/{id} | get change permission service
[**GetChangeSiteContactService**](ServicesApi.md#getchangesitecontactservice) | **GET** /services/changesitecontact/{id} | get change site contact service
[**GetChangeSiteSettingService**](ServicesApi.md#getchangesitesettingservice) | **GET** /services/changesitesetting/{id} | get change site setting service
[**GetChangeWebContactService**](ServicesApi.md#getchangewebcontactservice) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
[**GetChangeWebSettingsService**](ServicesApi.md#getchangewebsettingsservice) | **GET** /services/changewebsettings/{id} | get change web setting service
[**GetClonePermissionService**](ServicesApi.md#getclonepermissionservice) | **GET** /services/clonepermission/{id} | get clone permission service
[**GetContentMoveProfiles**](ServicesApi.md#getcontentmoveprofiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
[**GetContentMoveService**](ServicesApi.md#getcontentmoveservice) | **GET** /services/contentmove/{id} | get content move service
[**GetCreateGroupService**](ServicesApi.md#getcreategroupservice) | **GET** /services/creategroup/{id} | get create group service
[**GetCreateListService**](ServicesApi.md#getcreatelistservice) | **GET** /services/createlist/{id} | get create list service
[**GetCreateSiteService**](ServicesApi.md#getcreatesiteservice) | **GET** /services/createsite/{id} | get create site service
[**GetCreateWebService**](ServicesApi.md#getcreatewebservice) | **GET** /services/createweb/{id} | get create web service
[**GetCustomService**](ServicesApi.md#getcustomservice) | **GET** /services/custom/{id} | get custom service
[**GetGrantPermissionService**](ServicesApi.md#getgrantpermissionservice) | **GET** /services/grantpermission/{id} | get grant permission service
[**GetGroupLifecycleService**](ServicesApi.md#getgrouplifecycleservice) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
[**GetManagePermissionService**](ServicesApi.md#getmanagepermissionservice) | **GET** /services/managepermission/{id} | get manage permission service
[**GetMyQuickServices**](ServicesApi.md#getmyquickservices) | **GET** /services/my/quick | get configued quick services that can be used to start a request
[**GetMyServices**](ServicesApi.md#getmyservices) | **GET** /services/my | get services that can be used to start a request
[**GetMyServicesWithContext**](ServicesApi.md#getmyserviceswithcontext) | **GET** /services/my/workspace/{objecttype}/{objectid} | get services that can be used to start a request within context
[**GetSiteLifecycleService**](ServicesApi.md#getsitelifecycleservice) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
[**GetWebLifecycleService**](ServicesApi.md#getweblifecycleservice) | **GET** /services/weblifecycle/{id} | get web lifecycle service
[**ValidateForChangeGroupSettingService**](ServicesApi.md#validateforchangegroupsettingservice) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
[**ValidateForChangeListSettingService**](ServicesApi.md#validateforchangelistsettingservice) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
[**ValidateForChangePermissionService**](ServicesApi.md#validateforchangepermissionservice) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
[**ValidateForChangeSiteContactService**](ServicesApi.md#validateforchangesitecontactservice) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
[**ValidateForChangeSiteSettingService**](ServicesApi.md#validateforchangesitesettingservice) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
[**ValidateForChangeWebContactService**](ServicesApi.md#validateforchangewebcontactservice) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
[**ValidateForChangeWebSettingService**](ServicesApi.md#validateforchangewebsettingservice) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
[**ValidateForClonePermissionService**](ServicesApi.md#validateforclonepermissionservice) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
[**ValidateForContentMoveService**](ServicesApi.md#validateforcontentmoveservice) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
[**ValidateForCreateListService**](ServicesApi.md#validateforcreatelistservice) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
[**ValidateForCreateWebService**](ServicesApi.md#validateforcreatewebservice) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
[**ValidateForGrantPermissionService**](ServicesApi.md#validateforgrantpermissionservice) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
[**ValidateForGroupLifecycleService**](ServicesApi.md#validateforgrouplifecycleservice) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
[**ValidateForManagePermissionService**](ServicesApi.md#validateformanagepermissionservice) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
[**ValidateForSiteLifecycleService**](ServicesApi.md#validateforsitelifecycleservice) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
[**ValidateForWebLifecycleService**](ServicesApi.md#validateforweblifecycleservice) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service


<a name="addcreatelistservice"></a>
# **AddCreateListService**
> Guid AddCreateListService (CreateSiteService createSiteService = null)

Add create site service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class AddCreateListServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var createSiteService = new CreateSiteService(); // CreateSiteService |  (optional) 

            try
            {
                // Add create site service
                Guid result = apiInstance.AddCreateListService(createSiteService);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.AddCreateListService: " + e.Message );
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
 **createSiteService** | [**CreateSiteService**](CreateSiteService.md)|  | [optional] 

### Return type

**Guid**

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

<a name="addcreatewebservice"></a>
# **AddCreateWebService**
> Guid AddCreateWebService (CreateWebService createWebService = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class AddCreateWebServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var createWebService = new CreateWebService(); // CreateWebService |  (optional) 

            try
            {
                Guid result = apiInstance.AddCreateWebService(createWebService);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.AddCreateWebService: " + e.Message );
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
 **createWebService** | [**CreateWebService**](CreateWebService.md)|  | [optional] 

### Return type

**Guid**

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

<a name="getchangegroupsettingservice"></a>
# **GetChangeGroupSettingService**
> ChangeGroupSettingService GetChangeGroupSettingService (Guid id, Guid? questionnaireId = null)

get change group setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangeGroupSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get change group setting service
                ChangeGroupSettingService result = apiInstance.GetChangeGroupSettingService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangeGroupSettingService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangeGroupSettingService**](ChangeGroupSettingService.md)

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

<a name="getchangelistsettingservice"></a>
# **GetChangeListSettingService**
> ChangeListSettingService GetChangeListSettingService (Guid id, Guid? questionnaireId = null)

get change list setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangeListSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get change list setting service
                ChangeListSettingService result = apiInstance.GetChangeListSettingService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangeListSettingService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangeListSettingService**](ChangeListSettingService.md)

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

<a name="getchangepermissionservice"></a>
# **GetChangePermissionService**
> ChangePermissionService GetChangePermissionService (Guid id, Guid? questionnaireId = null)

get change permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangePermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get change permission service
                ChangePermissionService result = apiInstance.GetChangePermissionService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangePermissionService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangePermissionService**](ChangePermissionService.md)

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

<a name="getchangesitecontactservice"></a>
# **GetChangeSiteContactService**
> ChangeSiteContactService GetChangeSiteContactService (Guid id, Guid? questionnaireId = null)

get change site contact service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangeSiteContactServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get change site contact service
                ChangeSiteContactService result = apiInstance.GetChangeSiteContactService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangeSiteContactService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangeSiteContactService**](ChangeSiteContactService.md)

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

<a name="getchangesitesettingservice"></a>
# **GetChangeSiteSettingService**
> ChangeSiteSettingService GetChangeSiteSettingService (Guid id, Guid? questionnaireId = null)

get change site setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangeSiteSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get change site setting service
                ChangeSiteSettingService result = apiInstance.GetChangeSiteSettingService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangeSiteSettingService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangeSiteSettingService**](ChangeSiteSettingService.md)

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

<a name="getchangewebcontactservice"></a>
# **GetChangeWebContactService**
> ChangeWebContactService GetChangeWebContactService (Guid id, Guid? questionnaireId = null)

validate permissions, scope for change web contact service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangeWebContactServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // validate permissions, scope for change web contact service
                ChangeWebContactService result = apiInstance.GetChangeWebContactService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangeWebContactService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangeWebContactService**](ChangeWebContactService.md)

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

<a name="getchangewebsettingsservice"></a>
# **GetChangeWebSettingsService**
> ChangeWebSettingService GetChangeWebSettingsService (Guid id, Guid? questionnaireId = null)

get change web setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetChangeWebSettingsServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get change web setting service
                ChangeWebSettingService result = apiInstance.GetChangeWebSettingsService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetChangeWebSettingsService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ChangeWebSettingService**](ChangeWebSettingService.md)

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

<a name="getclonepermissionservice"></a>
# **GetClonePermissionService**
> ClonePermissionService GetClonePermissionService (Guid id, Guid? questionnaireId = null)

get clone permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetClonePermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get clone permission service
                ClonePermissionService result = apiInstance.GetClonePermissionService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetClonePermissionService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ClonePermissionService**](ClonePermissionService.md)

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

<a name="getcontentmoveprofiles"></a>
# **GetContentMoveProfiles**
> ContentMoveProfiles GetContentMoveProfiles ()

get content move profiles from cloud management

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetContentMoveProfilesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);

            try
            {
                // get content move profiles from cloud management
                ContentMoveProfiles result = apiInstance.GetContentMoveProfiles();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetContentMoveProfiles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ContentMoveProfiles**](ContentMoveProfiles.md)

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

<a name="getcontentmoveservice"></a>
# **GetContentMoveService**
> ContentMoveService GetContentMoveService (Guid id, Guid? questionnaireId = null)

get content move service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetContentMoveServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get content move service
                ContentMoveService result = apiInstance.GetContentMoveService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetContentMoveService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ContentMoveService**](ContentMoveService.md)

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

<a name="getcreategroupservice"></a>
# **GetCreateGroupService**
> CreateGroupService GetCreateGroupService (Guid id, Guid? questionnaireId = null)

get create group service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetCreateGroupServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get create group service
                CreateGroupService result = apiInstance.GetCreateGroupService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetCreateGroupService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**CreateGroupService**](CreateGroupService.md)

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

<a name="getcreatelistservice"></a>
# **GetCreateListService**
> CreateListService GetCreateListService (Guid id, Guid? questionnaireId = null)

get create list service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetCreateListServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get create list service
                CreateListService result = apiInstance.GetCreateListService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetCreateListService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**CreateListService**](CreateListService.md)

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

<a name="getcreatesiteservice"></a>
# **GetCreateSiteService**
> CreateSiteService GetCreateSiteService (Guid id, Guid? questionnaireId = null)

get create site service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetCreateSiteServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get create site service
                CreateSiteService result = apiInstance.GetCreateSiteService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetCreateSiteService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**CreateSiteService**](CreateSiteService.md)

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

<a name="getcreatewebservice"></a>
# **GetCreateWebService**
> CreateWebService GetCreateWebService (Guid id, Guid? questionnaireId = null)

get create web service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetCreateWebServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get create web service
                CreateWebService result = apiInstance.GetCreateWebService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetCreateWebService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**CreateWebService**](CreateWebService.md)

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

<a name="getcustomservice"></a>
# **GetCustomService**
> ServiceForRequest GetCustomService (Guid id, Guid? questionnaireId = null)

get custom service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetCustomServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get custom service
                ServiceForRequest result = apiInstance.GetCustomService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetCustomService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ServiceForRequest**](ServiceForRequest.md)

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

<a name="getgrantpermissionservice"></a>
# **GetGrantPermissionService**
> GrantPermissionService GetGrantPermissionService (Guid id, Guid? questionnaireId = null)

get grant permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGrantPermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get grant permission service
                GrantPermissionService result = apiInstance.GetGrantPermissionService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetGrantPermissionService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**GrantPermissionService**](GrantPermissionService.md)

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

<a name="getgrouplifecycleservice"></a>
# **GetGroupLifecycleService**
> GroupLifecycleService GetGroupLifecycleService (Guid id, Guid? questionnaireId = null)

get group lifecycle service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetGroupLifecycleServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get group lifecycle service
                GroupLifecycleService result = apiInstance.GetGroupLifecycleService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetGroupLifecycleService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**GroupLifecycleService**](GroupLifecycleService.md)

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

<a name="getmanagepermissionservice"></a>
# **GetManagePermissionService**
> ManagePermissionService GetManagePermissionService (Guid id, Guid? questionnaireId = null)

get manage permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetManagePermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get manage permission service
                ManagePermissionService result = apiInstance.GetManagePermissionService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetManagePermissionService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ManagePermissionService**](ManagePermissionService.md)

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

<a name="getmyquickservices"></a>
# **GetMyQuickServices**
> List&lt;ServiceList&gt; GetMyQuickServices ()

get configued quick services that can be used to start a request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetMyQuickServicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);

            try
            {
                // get configued quick services that can be used to start a request
                List<ServiceList> result = apiInstance.GetMyQuickServices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetMyQuickServices: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ServiceList&gt;**](ServiceList.md)

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

<a name="getmyservices"></a>
# **GetMyServices**
> ServiceListPageResult GetMyServices (string search = null)

get services that can be used to start a request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetMyServicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var search = search_example;  // string |  (optional) 

            try
            {
                // get services that can be used to start a request
                ServiceListPageResult result = apiInstance.GetMyServices(search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetMyServices: " + e.Message );
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
 **search** | **string**|  | [optional] 

### Return type

[**ServiceListPageResult**](ServiceListPageResult.md)

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

<a name="getmyserviceswithcontext"></a>
# **GetMyServicesWithContext**
> List&lt;ServiceList&gt; GetMyServicesWithContext (WorkspaceType objecttype, string objectid, string search = null)

get services that can be used to start a request within context

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetMyServicesWithContextExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var objecttype = new WorkspaceType(); // WorkspaceType | 
            var objectid = objectid_example;  // string | 
            var search = search_example;  // string |  (optional) 

            try
            {
                // get services that can be used to start a request within context
                List<ServiceList> result = apiInstance.GetMyServicesWithContext(objecttype, objectid, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetMyServicesWithContext: " + e.Message );
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
 **objecttype** | [**WorkspaceType**](WorkspaceType.md)|  | 
 **objectid** | **string**|  | 
 **search** | **string**|  | [optional] 

### Return type

[**List&lt;ServiceList&gt;**](ServiceList.md)

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

<a name="getsitelifecycleservice"></a>
# **GetSiteLifecycleService**
> SiteLifecycleService GetSiteLifecycleService (Guid id, Guid? questionnaireId = null)

get site lifecycle service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSiteLifecycleServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get site lifecycle service
                SiteLifecycleService result = apiInstance.GetSiteLifecycleService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetSiteLifecycleService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**SiteLifecycleService**](SiteLifecycleService.md)

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

<a name="getweblifecycleservice"></a>
# **GetWebLifecycleService**
> WebLifecycleService GetWebLifecycleService (Guid id, Guid? questionnaireId = null)

get web lifecycle service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetWebLifecycleServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var questionnaireId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // get web lifecycle service
                WebLifecycleService result = apiInstance.GetWebLifecycleService(id, questionnaireId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetWebLifecycleService: " + e.Message );
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
 **questionnaireId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**WebLifecycleService**](WebLifecycleService.md)

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

<a name="validateforchangegroupsettingservice"></a>
# **ValidateForChangeGroupSettingService**
> ChangeGroupSettingCheckResult ValidateForChangeGroupSettingService (Guid id, GroupValidationParameter groupValidationParameter = null)

validate permissions, scope for change group setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangeGroupSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupValidationParameter = new GroupValidationParameter(); // GroupValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change group setting service
                ChangeGroupSettingCheckResult result = apiInstance.ValidateForChangeGroupSettingService(id, groupValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangeGroupSettingService: " + e.Message );
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
 **groupValidationParameter** | [**GroupValidationParameter**](GroupValidationParameter.md)|  | [optional] 

### Return type

[**ChangeGroupSettingCheckResult**](ChangeGroupSettingCheckResult.md)

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

<a name="validateforchangelistsettingservice"></a>
# **ValidateForChangeListSettingService**
> ChangeListSettingValidateResult ValidateForChangeListSettingService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for change list setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangeListSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change list setting service
                ChangeListSettingValidateResult result = apiInstance.ValidateForChangeListSettingService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangeListSettingService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeListSettingValidateResult**](ChangeListSettingValidateResult.md)

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

<a name="validateforchangepermissionservice"></a>
# **ValidateForChangePermissionService**
> ChangePermissionValidateResult ValidateForChangePermissionService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for change permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangePermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change permission service
                ChangePermissionValidateResult result = apiInstance.ValidateForChangePermissionService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangePermissionService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangePermissionValidateResult**](ChangePermissionValidateResult.md)

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

<a name="validateforchangesitecontactservice"></a>
# **ValidateForChangeSiteContactService**
> ChangeSiteContactValidateResult ValidateForChangeSiteContactService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for change site contact service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangeSiteContactServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change site contact service
                ChangeSiteContactValidateResult result = apiInstance.ValidateForChangeSiteContactService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangeSiteContactService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeSiteContactValidateResult**](ChangeSiteContactValidateResult.md)

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

<a name="validateforchangesitesettingservice"></a>
# **ValidateForChangeSiteSettingService**
> ChangeSiteSettingValidateResult ValidateForChangeSiteSettingService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for change site setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangeSiteSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change site setting service
                ChangeSiteSettingValidateResult result = apiInstance.ValidateForChangeSiteSettingService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangeSiteSettingService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeSiteSettingValidateResult**](ChangeSiteSettingValidateResult.md)

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

<a name="validateforchangewebcontactservice"></a>
# **ValidateForChangeWebContactService**
> ChangeWebContactValidateResult ValidateForChangeWebContactService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for change web contact service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangeWebContactServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change web contact service
                ChangeWebContactValidateResult result = apiInstance.ValidateForChangeWebContactService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangeWebContactService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeWebContactValidateResult**](ChangeWebContactValidateResult.md)

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

<a name="validateforchangewebsettingservice"></a>
# **ValidateForChangeWebSettingService**
> ChangeWebUrlValidateResult ValidateForChangeWebSettingService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for change web setting service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForChangeWebSettingServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for change web setting service
                ChangeWebUrlValidateResult result = apiInstance.ValidateForChangeWebSettingService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForChangeWebSettingService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeWebUrlValidateResult**](ChangeWebUrlValidateResult.md)

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

<a name="validateforclonepermissionservice"></a>
# **ValidateForClonePermissionService**
> ClonePermissionValidateResult ValidateForClonePermissionService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for clone permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForClonePermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for clone permission service
                ClonePermissionValidateResult result = apiInstance.ValidateForClonePermissionService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForClonePermissionService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ClonePermissionValidateResult**](ClonePermissionValidateResult.md)

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

<a name="validateforcontentmoveservice"></a>
# **ValidateForContentMoveService**
> ContentMoveUrlValidationResult ValidateForContentMoveService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for content move service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForContentMoveServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for content move service
                ContentMoveUrlValidationResult result = apiInstance.ValidateForContentMoveService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForContentMoveService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ContentMoveUrlValidationResult**](ContentMoveUrlValidationResult.md)

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

<a name="validateforcreatelistservice"></a>
# **ValidateForCreateListService**
> CreateListUrlValidationResult ValidateForCreateListService (Guid id, ListValidationParameter listValidationParameter = null)

validate permissions, scope for create list service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForCreateListServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var listValidationParameter = new ListValidationParameter(); // ListValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for create list service
                CreateListUrlValidationResult result = apiInstance.ValidateForCreateListService(id, listValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForCreateListService: " + e.Message );
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
 **listValidationParameter** | [**ListValidationParameter**](ListValidationParameter.md)|  | [optional] 

### Return type

[**CreateListUrlValidationResult**](CreateListUrlValidationResult.md)

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

<a name="validateforcreatewebservice"></a>
# **ValidateForCreateWebService**
> CreateWebUrlValidationResult ValidateForCreateWebService (Guid id, CreateWebValidationParameter createWebValidationParameter = null)

validate permissions, scope for create web service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForCreateWebServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var createWebValidationParameter = new CreateWebValidationParameter(); // CreateWebValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for create web service
                CreateWebUrlValidationResult result = apiInstance.ValidateForCreateWebService(id, createWebValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForCreateWebService: " + e.Message );
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
 **createWebValidationParameter** | [**CreateWebValidationParameter**](CreateWebValidationParameter.md)|  | [optional] 

### Return type

[**CreateWebUrlValidationResult**](CreateWebUrlValidationResult.md)

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

<a name="validateforgrantpermissionservice"></a>
# **ValidateForGrantPermissionService**
> GrantPermissionUrlValidationResult ValidateForGrantPermissionService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for grant permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForGrantPermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for grant permission service
                GrantPermissionUrlValidationResult result = apiInstance.ValidateForGrantPermissionService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForGrantPermissionService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**GrantPermissionUrlValidationResult**](GrantPermissionUrlValidationResult.md)

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

<a name="validateforgrouplifecycleservice"></a>
# **ValidateForGroupLifecycleService**
> GroupLifecycleValidateResult ValidateForGroupLifecycleService (Guid id, GroupValidationParameter groupValidationParameter = null)

validate permissions, scope for group lifecycle service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForGroupLifecycleServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupValidationParameter = new GroupValidationParameter(); // GroupValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for group lifecycle service
                GroupLifecycleValidateResult result = apiInstance.ValidateForGroupLifecycleService(id, groupValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForGroupLifecycleService: " + e.Message );
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
 **groupValidationParameter** | [**GroupValidationParameter**](GroupValidationParameter.md)|  | [optional] 

### Return type

[**GroupLifecycleValidateResult**](GroupLifecycleValidateResult.md)

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

<a name="validateformanagepermissionservice"></a>
# **ValidateForManagePermissionService**
> ManagePermissionValidateResult ValidateForManagePermissionService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for manage permission service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForManagePermissionServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for manage permission service
                ManagePermissionValidateResult result = apiInstance.ValidateForManagePermissionService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForManagePermissionService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ManagePermissionValidateResult**](ManagePermissionValidateResult.md)

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

<a name="validateforsitelifecycleservice"></a>
# **ValidateForSiteLifecycleService**
> SiteLifecycleValidateResult ValidateForSiteLifecycleService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for site lifecycle service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForSiteLifecycleServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for site lifecycle service
                SiteLifecycleValidateResult result = apiInstance.ValidateForSiteLifecycleService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForSiteLifecycleService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**SiteLifecycleValidateResult**](SiteLifecycleValidateResult.md)

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

<a name="validateforweblifecycleservice"></a>
# **ValidateForWebLifecycleService**
> WebLifecycleValidateResult ValidateForWebLifecycleService (Guid id, SiteValidationParameter siteValidationParameter = null)

validate permissions, scope for web lifecycle service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ValidateForWebLifecycleServiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var siteValidationParameter = new SiteValidationParameter(); // SiteValidationParameter |  (optional) 

            try
            {
                // validate permissions, scope for web lifecycle service
                WebLifecycleValidateResult result = apiInstance.ValidateForWebLifecycleService(id, siteValidationParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ValidateForWebLifecycleService: " + e.Message );
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
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**WebLifecycleValidateResult**](WebLifecycleValidateResult.md)

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

