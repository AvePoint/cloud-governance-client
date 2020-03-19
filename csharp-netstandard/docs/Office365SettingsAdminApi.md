# Cloud.Governance.Client.Api.Office365SettingsAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddImpersonationAccount**](Office365SettingsAdminApi.md#addimpersonationaccount) | **POST** /admin/settings/office365/accounts | add impersonation account
[**DeleteImpersonationAccount**](Office365SettingsAdminApi.md#deleteimpersonationaccount) | **DELETE** /admin/settings/office365/accounts/{id} | delete impersonationn account by id
[**DeleteImpersonationAccounts**](Office365SettingsAdminApi.md#deleteimpersonationaccounts) | **DELETE** /admin/settings/office365/accounts | delete impersonation accounts
[**Deletepermissionlevel**](Office365SettingsAdminApi.md#deletepermissionlevel) | **DELETE** /admin/settings/office365/permissionlevels/{id} | delete permission level
[**Deletepermissionlevels**](Office365SettingsAdminApi.md#deletepermissionlevels) | **DELETE** /admin/settings/office365/permissionlevels | delete permission levels
[**EditImpersonationAccount**](Office365SettingsAdminApi.md#editimpersonationaccount) | **PUT** /admin/settings/office365/accounts | edit impersonation account
[**EditPermissionLevel**](Office365SettingsAdminApi.md#editpermissionlevel) | **PUT** /admin/settings/office365/permissionlevels | edit permission level
[**GetAppBrandingSettings**](Office365SettingsAdminApi.md#getappbrandingsettings) | **GET** /admin/settings/office365/branding | get app branding settings
[**GetDefaultDomain**](Office365SettingsAdminApi.md#getdefaultdomain) | **GET** /admin/settings/office365/tenants/{id}/domain | get tenants default domain
[**GetImpersonationAccount**](Office365SettingsAdminApi.md#getimpersonationaccount) | **GET** /admin/settings/office365/accounts/{id} | get impersonation account
[**GetImpersonationAccountList**](Office365SettingsAdminApi.md#getimpersonationaccountlist) | **GET** /admin/settings/office365/accounts | get impersonation account list
[**GetImpersonationAccountListFilters**](Office365SettingsAdminApi.md#getimpersonationaccountlistfilters) | **GET** /admin/settings/office365/accounts/filters | get impersonation account list filters
[**GetPermissionLevel**](Office365SettingsAdminApi.md#getpermissionlevel) | **GET** /admin/settings/office365/permissionlevels/{id} | get permission level by id
[**GetPermissionLevels**](Office365SettingsAdminApi.md#getpermissionlevels) | **GET** /admin/settings/office365/permissionlevels | get permission levels
[**GetReferencedServices**](Office365SettingsAdminApi.md#getreferencedservices) | **GET** /admin/settings/office365/permissionlevels/{id}/services | get services that referneced these permission level
[**GetTenants**](Office365SettingsAdminApi.md#gettenants) | **GET** /admin/settings/office365/tenants | get office365 tenants
[**GetUploadUrl**](Office365SettingsAdminApi.md#getuploadurl) | **GET** /admin/settings/office365/branding/url | get upload app branding URL
[**SaveAppBrandingSettings**](Office365SettingsAdminApi.md#saveappbrandingsettings) | **POST** /admin/settings/office365/branding | save app branding settings
[**SavePermissionLevel**](Office365SettingsAdminApi.md#savepermissionlevel) | **POST** /admin/settings/office365/permissionlevels | create permission level


<a name="addimpersonationaccount"></a>
# **AddImpersonationAccount**
> Guid AddImpersonationAccount (ImpersonationAccountModel impersonationAccountModel = null)

add impersonation account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class AddImpersonationAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var impersonationAccountModel = new ImpersonationAccountModel(); // ImpersonationAccountModel |  (optional) 

            try
            {
                // add impersonation account
                Guid result = apiInstance.AddImpersonationAccount(impersonationAccountModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.AddImpersonationAccount: " + e.Message );
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
 **impersonationAccountModel** | [**ImpersonationAccountModel**](ImpersonationAccountModel.md)|  | [optional] 

### Return type

**Guid**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteimpersonationaccount"></a>
# **DeleteImpersonationAccount**
> void DeleteImpersonationAccount (Guid id)

delete impersonationn account by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteImpersonationAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // delete impersonationn account by id
                apiInstance.DeleteImpersonationAccount(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.DeleteImpersonationAccount: " + e.Message );
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteimpersonationaccounts"></a>
# **DeleteImpersonationAccounts**
> void DeleteImpersonationAccounts (List<Guid> requestBody = null)

delete impersonation accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteImpersonationAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // delete impersonation accounts
                apiInstance.DeleteImpersonationAccounts(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.DeleteImpersonationAccounts: " + e.Message );
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
 **requestBody** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepermissionlevel"></a>
# **Deletepermissionlevel**
> void Deletepermissionlevel (Guid id)

delete permission level

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeletepermissionlevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // delete permission level
                apiInstance.Deletepermissionlevel(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.Deletepermissionlevel: " + e.Message );
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepermissionlevels"></a>
# **Deletepermissionlevels**
> void Deletepermissionlevels (List<Guid> requestBody = null)

delete permission levels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeletepermissionlevelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // delete permission levels
                apiInstance.Deletepermissionlevels(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.Deletepermissionlevels: " + e.Message );
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
 **requestBody** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editimpersonationaccount"></a>
# **EditImpersonationAccount**
> void EditImpersonationAccount (ImpersonationAccountModel impersonationAccountModel = null)

edit impersonation account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditImpersonationAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var impersonationAccountModel = new ImpersonationAccountModel(); // ImpersonationAccountModel |  (optional) 

            try
            {
                // edit impersonation account
                apiInstance.EditImpersonationAccount(impersonationAccountModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.EditImpersonationAccount: " + e.Message );
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
 **impersonationAccountModel** | [**ImpersonationAccountModel**](ImpersonationAccountModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpermissionlevel"></a>
# **EditPermissionLevel**
> void EditPermissionLevel (PermissionLevelModel permissionLevelModel = null)

edit permission level

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditPermissionLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var permissionLevelModel = new PermissionLevelModel(); // PermissionLevelModel |  (optional) 

            try
            {
                // edit permission level
                apiInstance.EditPermissionLevel(permissionLevelModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.EditPermissionLevel: " + e.Message );
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
 **permissionLevelModel** | [**PermissionLevelModel**](PermissionLevelModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappbrandingsettings"></a>
# **GetAppBrandingSettings**
> AppBrandingModel GetAppBrandingSettings ()

get app branding settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAppBrandingSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);

            try
            {
                // get app branding settings
                AppBrandingModel result = apiInstance.GetAppBrandingSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetAppBrandingSettings: " + e.Message );
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

[**AppBrandingModel**](AppBrandingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultdomain"></a>
# **GetDefaultDomain**
> string GetDefaultDomain (Guid id, string user)

get tenants default domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetDefaultDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var id = new Guid(); // Guid | 
            var user = user_example;  // string | 

            try
            {
                // get tenants default domain
                string result = apiInstance.GetDefaultDomain(id, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetDefaultDomain: " + e.Message );
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
 **user** | **string**|  | 

### Return type

**string**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimpersonationaccount"></a>
# **GetImpersonationAccount**
> ImpersonationAccountModel GetImpersonationAccount (Guid id)

get impersonation account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetImpersonationAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // get impersonation account
                ImpersonationAccountModel result = apiInstance.GetImpersonationAccount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetImpersonationAccount: " + e.Message );
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

[**ImpersonationAccountModel**](ImpersonationAccountModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimpersonationaccountlist"></a>
# **GetImpersonationAccountList**
> ImpersonationAccountListPageResult GetImpersonationAccountList (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get impersonation account list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetImpersonationAccountListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get impersonation account list
                ImpersonationAccountListPageResult result = apiInstance.GetImpersonationAccountList(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetImpersonationAccountList: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**ImpersonationAccountListPageResult**](ImpersonationAccountListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimpersonationaccountlistfilters"></a>
# **GetImpersonationAccountListFilters**
> DistinctPageResult GetImpersonationAccountListFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get impersonation account list filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetImpersonationAccountListFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get impersonation account list filters
                DistinctPageResult result = apiInstance.GetImpersonationAccountListFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetImpersonationAccountListFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissionlevel"></a>
# **GetPermissionLevel**
> PermissionLevelViewModel GetPermissionLevel (Guid id)

get permission level by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetPermissionLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // get permission level by id
                PermissionLevelViewModel result = apiInstance.GetPermissionLevel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetPermissionLevel: " + e.Message );
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

[**PermissionLevelViewModel**](PermissionLevelViewModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissionlevels"></a>
# **GetPermissionLevels**
> PermissionLevelGridModelPageResult GetPermissionLevels (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get permission levels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetPermissionLevelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description (optional) 
            var search = search_example;  // string | Search for  (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get permission levels
                PermissionLevelGridModelPageResult result = apiInstance.GetPermissionLevels(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetPermissionLevels: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description | [optional] 
 **search** | **string**| Search for  | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionLevelGridModelPageResult**](PermissionLevelGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreferencedservices"></a>
# **GetReferencedServices**
> List&lt;string&gt; GetReferencedServices (Guid id)

get services that referneced these permission level

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetReferencedServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // get services that referneced these permission level
                List<string> result = apiInstance.GetReferencedServices(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetReferencedServices: " + e.Message );
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

**List<string>**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettenants"></a>
# **GetTenants**
> List&lt;StringModel&gt; GetTenants ()

get office365 tenants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetTenantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);

            try
            {
                // get office365 tenants
                List<StringModel> result = apiInstance.GetTenants();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetTenants: " + e.Message );
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

[**List&lt;StringModel&gt;**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadurl"></a>
# **GetUploadUrl**
> SASUriModel GetUploadUrl (string fileName)

get upload app branding URL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetUploadUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var fileName = fileName_example;  // string | 

            try
            {
                // get upload app branding URL
                SASUriModel result = apiInstance.GetUploadUrl(fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.GetUploadUrl: " + e.Message );
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
 **fileName** | **string**|  | 

### Return type

[**SASUriModel**](SASUriModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveappbrandingsettings"></a>
# **SaveAppBrandingSettings**
> void SaveAppBrandingSettings (AppBrandingModel appBrandingModel = null)

save app branding settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveAppBrandingSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var appBrandingModel = new AppBrandingModel(); // AppBrandingModel |  (optional) 

            try
            {
                // save app branding settings
                apiInstance.SaveAppBrandingSettings(appBrandingModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.SaveAppBrandingSettings: " + e.Message );
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
 **appBrandingModel** | [**AppBrandingModel**](AppBrandingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepermissionlevel"></a>
# **SavePermissionLevel**
> Guid SavePermissionLevel (PermissionLevelModel permissionLevelModel = null)

create permission level

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SavePermissionLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new Office365SettingsAdminApi(config);
            var permissionLevelModel = new PermissionLevelModel(); // PermissionLevelModel |  (optional) 

            try
            {
                // create permission level
                Guid result = apiInstance.SavePermissionLevel(permissionLevelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365SettingsAdminApi.SavePermissionLevel: " + e.Message );
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
 **permissionLevelModel** | [**PermissionLevelModel**](PermissionLevelModel.md)|  | [optional] 

### Return type

**Guid**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

