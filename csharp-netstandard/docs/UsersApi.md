# Cloud.Governance.NewSdk.Api.UsersApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckUserExistsInAOS**](UsersApi.md#checkuserexistsinaos) | **GET** /users/avepointonlineservices/validate | check user exists in Aos
[**GetAzureAdUserPropertyValue**](UsersApi.md#getazureaduserpropertyvalue) | **GET** /users/{username}/azuread/property | get user&#39;s property value by property name from azure ad
[**GetUpsUserPropertyValue**](UsersApi.md#getupsuserpropertyvalue) | **GET** /users/{username}/userprofile/property | get user&#39;s property value by property name from user profile service
[**GetUserBasicProperties**](UsersApi.md#getuserbasicproperties) | **GET** /users/me/properties | get my basic properties, City, Country, Office, Department, JobTitle,State
[**GetUserBasicPropertyValue**](UsersApi.md#getuserbasicpropertyvalue) | **GET** /users/me/property/{name} | get my basic property value, Department, Email, DisplayName, Manager
[**GetUserPhoto**](UsersApi.md#getuserphoto) | **GET** /users/{username}/photo | get user&#39;s photo
[**GetUserRelationship**](UsersApi.md#getuserrelationship) | **GET** /users/{username}/relationship | get user relationship
[**GetUsersFromSharePoint**](UsersApi.md#getusersfromsharepoint) | **POST** /users/sharepoint/validate | get users from sharepoint
[**ResolveUsers**](UsersApi.md#resolveusers) | **GET** /users/resolve | resolve users
[**ResolveUsersWithExternalSharingOption**](UsersApi.md#resolveuserswithexternalsharingoption) | **GET** /users/resolve/{externalSharingOption} | resolve user including external users
[**SearchUsers**](UsersApi.md#searchusers) | **GET** /users/search | search users
[**SearchUsersWithExternalSharingOption**](UsersApi.md#searchuserswithexternalsharingoption) | **GET** /users/search/{externalSharingOption} | search user including external users
[**UpdateUserInfo**](UsersApi.md#updateuserinfo) | **POST** /users | 


<a name="checkuserexistsinaos"></a>
# **CheckUserExistsInAOS**
> bool CheckUserExistsInAOS (string name)

check user exists in Aos

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class CheckUserExistsInAOSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var name = name_example;  // string | 

            try
            {
                // check user exists in Aos
                bool result = apiInstance.CheckUserExistsInAOS(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CheckUserExistsInAOS: " + e.Message );
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
 **name** | **string**|  | 

### Return type

**bool**

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

<a name="getazureaduserpropertyvalue"></a>
# **GetAzureAdUserPropertyValue**
> StringModel GetAzureAdUserPropertyValue (string username, string propertyName)

get user's property value by property name from azure ad

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetAzureAdUserPropertyValueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | 
            var propertyName = propertyName_example;  // string | 

            try
            {
                // get user's property value by property name from azure ad
                StringModel result = apiInstance.GetAzureAdUserPropertyValue(username, propertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetAzureAdUserPropertyValue: " + e.Message );
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
 **username** | **string**|  | 
 **propertyName** | **string**|  | 

### Return type

[**StringModel**](StringModel.md)

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

<a name="getupsuserpropertyvalue"></a>
# **GetUpsUserPropertyValue**
> StringModel GetUpsUserPropertyValue (string username, string propertyName)

get user's property value by property name from user profile service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetUpsUserPropertyValueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | 
            var propertyName = propertyName_example;  // string | 

            try
            {
                // get user's property value by property name from user profile service
                StringModel result = apiInstance.GetUpsUserPropertyValue(username, propertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUpsUserPropertyValue: " + e.Message );
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
 **username** | **string**|  | 
 **propertyName** | **string**|  | 

### Return type

[**StringModel**](StringModel.md)

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

<a name="getuserbasicproperties"></a>
# **GetUserBasicProperties**
> void GetUserBasicProperties ()

get my basic properties, City, Country, Office, Department, JobTitle,State

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetUserBasicPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);

            try
            {
                // get my basic properties, City, Country, Office, Department, JobTitle,State
                apiInstance.GetUserBasicProperties();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserBasicProperties: " + e.Message );
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

<a name="getuserbasicpropertyvalue"></a>
# **GetUserBasicPropertyValue**
> void GetUserBasicPropertyValue (string name)

get my basic property value, Department, Email, DisplayName, Manager

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetUserBasicPropertyValueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var name = name_example;  // string | 

            try
            {
                // get my basic property value, Department, Email, DisplayName, Manager
                apiInstance.GetUserBasicPropertyValue(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserBasicPropertyValue: " + e.Message );
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
 **name** | **string**|  | 

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

<a name="getuserphoto"></a>
# **GetUserPhoto**
> void GetUserPhoto (string username, string size = null)

get user's photo

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetUserPhotoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | 
            var size = size_example;  // string |  (optional)  (default to "48x48")

            try
            {
                // get user's photo
                apiInstance.GetUserPhoto(username, size);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserPhoto: " + e.Message );
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
 **username** | **string**|  | 
 **size** | **string**|  | [optional] [default to &quot;48x48&quot;]

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

<a name="getuserrelationship"></a>
# **GetUserRelationship**
> UserRelationShip GetUserRelationship (string username)

get user relationship

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetUserRelationshipExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | 

            try
            {
                // get user relationship
                UserRelationShip result = apiInstance.GetUserRelationship(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRelationship: " + e.Message );
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
 **username** | **string**|  | 

### Return type

[**UserRelationShip**](UserRelationShip.md)

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

<a name="getusersfromsharepoint"></a>
# **GetUsersFromSharePoint**
> ApiUser GetUsersFromSharePoint (string username = null, List<string> requestBody = null)

get users from sharepoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetUsersFromSharePointExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string |  (optional) 
            var requestBody = new List<string>(); // List<string> |  (optional) 

            try
            {
                // get users from sharepoint
                ApiUser result = apiInstance.GetUsersFromSharePoint(username, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersFromSharePoint: " + e.Message );
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
 **username** | **string**|  | [optional] 
 **requestBody** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**ApiUser**](ApiUser.md)

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

<a name="resolveusers"></a>
# **ResolveUsers**
> List&lt;ApiUser&gt; ResolveUsers (string keyword, UserType userType, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = null)

resolve users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ResolveUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var keyword = keyword_example;  // string | 
            var userType = new UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
            var sharingOptions = new ExternalSharingOptions(); // ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3
            var siteUrlOrTenantId = siteUrlOrTenantId_example;  // string |  (optional)  (default to "")

            try
            {
                // resolve users
                List<ApiUser> result = apiInstance.ResolveUsers(keyword, userType, sharingOptions, siteUrlOrTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResolveUsers: " + e.Message );
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
 **keyword** | **string**|  | 
 **userType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **sharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | 
 **siteUrlOrTenantId** | **string**|  | [optional] [default to &quot;&quot;]

### Return type

[**List&lt;ApiUser&gt;**](ApiUser.md)

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

<a name="resolveuserswithexternalsharingoption"></a>
# **ResolveUsersWithExternalSharingOption**
> List&lt;SharingEnabledUser&gt; ResolveUsersWithExternalSharingOption (string keyword, string siteUrlOrTenantId, ExternalSharingOptions externalSharingOption, UserType userType)

resolve user including external users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class ResolveUsersWithExternalSharingOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var keyword = keyword_example;  // string | 
            var siteUrlOrTenantId = siteUrlOrTenantId_example;  // string | 
            var externalSharingOption = new ExternalSharingOptions(); // ExternalSharingOptions | 
            var userType = new UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4

            try
            {
                // resolve user including external users
                List<SharingEnabledUser> result = apiInstance.ResolveUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResolveUsersWithExternalSharingOption: " + e.Message );
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
 **keyword** | **string**|  | 
 **siteUrlOrTenantId** | **string**|  | 
 **externalSharingOption** | [**ExternalSharingOptions**](ExternalSharingOptions.md)|  | 
 **userType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 

### Return type

[**List&lt;SharingEnabledUser&gt;**](SharingEnabledUser.md)

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

<a name="searchusers"></a>
# **SearchUsers**
> List&lt;ApiUser&gt; SearchUsers (string keyword, UserType userType, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = null)

search users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var keyword = keyword_example;  // string | 
            var userType = new UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
            var sharingOptions = new ExternalSharingOptions(); // ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3
            var siteUrlOrTenantId = siteUrlOrTenantId_example;  // string |  (optional)  (default to "")

            try
            {
                // search users
                List<ApiUser> result = apiInstance.SearchUsers(keyword, userType, sharingOptions, siteUrlOrTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUsers: " + e.Message );
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
 **keyword** | **string**|  | 
 **userType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **sharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | 
 **siteUrlOrTenantId** | **string**|  | [optional] [default to &quot;&quot;]

### Return type

[**List&lt;ApiUser&gt;**](ApiUser.md)

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

<a name="searchuserswithexternalsharingoption"></a>
# **SearchUsersWithExternalSharingOption**
> List&lt;SharingEnabledUser&gt; SearchUsersWithExternalSharingOption (string keyword, string siteUrlOrTenantId, ExternalSharingOptions externalSharingOption, UserType userType)

search user including external users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SearchUsersWithExternalSharingOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var keyword = keyword_example;  // string | 
            var siteUrlOrTenantId = siteUrlOrTenantId_example;  // string | 
            var externalSharingOption = new ExternalSharingOptions(); // ExternalSharingOptions | 
            var userType = new UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4

            try
            {
                // search user including external users
                List<SharingEnabledUser> result = apiInstance.SearchUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUsersWithExternalSharingOption: " + e.Message );
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
 **keyword** | **string**|  | 
 **siteUrlOrTenantId** | **string**|  | 
 **externalSharingOption** | [**ExternalSharingOptions**](ExternalSharingOptions.md)|  | 
 **userType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 

### Return type

[**List&lt;SharingEnabledUser&gt;**](SharingEnabledUser.md)

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

<a name="updateuserinfo"></a>
# **UpdateUserInfo**
> void UpdateUserInfo (ApiUser apiUser = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class UpdateUserInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var apiUser = new ApiUser(); // ApiUser |  (optional) 

            try
            {
                apiInstance.UpdateUserInfo(apiUser);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserInfo: " + e.Message );
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
 **apiUser** | [**ApiUser**](ApiUser.md)|  | [optional] 

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

