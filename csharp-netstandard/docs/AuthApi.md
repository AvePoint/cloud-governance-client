# Cloud.Governance.Client.Api.AuthApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDelegateAccessToken**](AuthApi.md#getdelegateaccesstoken) | **POST** /auth/token/delegate | get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
[**GetTokenUsage**](AuthApi.md#gettokenusage) | **GET** /auth/token/usage | 
[**GetUserTokenUrl**](AuthApi.md#getusertokenurl) | **GET** /auth/token/user/url | get the url which used to get user access token
[**RefreshUserAccessToken**](AuthApi.md#refreshuseraccesstoken) | **POST** /auth/token/user/refresh | refresh user access token


<a name="getdelegateaccesstoken"></a>
# **GetDelegateAccessToken**
> DelegatedAccessTokenApiResult GetDelegateAccessToken (Guid clientId, string clientSecret, string userPrincipalName)

get delegate access token by client id and client secret which created in cloud governance Api Authentication Management

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetDelegateAccessTokenExample
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

            var apiInstance = new AuthApi(config);
            var clientId = new Guid(); // Guid | 
            var clientSecret = clientSecret_example;  // string | 
            var userPrincipalName = userPrincipalName_example;  // string | 

            try
            {
                // get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
                DelegatedAccessTokenApiResult result = apiInstance.GetDelegateAccessToken(clientId, clientSecret, userPrincipalName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetDelegateAccessToken: " + e.Message );
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
 **clientId** | [**Guid**](Guid.md)|  | 
 **clientSecret** | **string**|  | 
 **userPrincipalName** | **string**|  | 

### Return type

[**DelegatedAccessTokenApiResult**](DelegatedAccessTokenApiResult.md)

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
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokenusage"></a>
# **GetTokenUsage**
> void GetTokenUsage ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetTokenUsageExample
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

            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.GetTokenUsage();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetTokenUsage: " + e.Message );
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertokenurl"></a>
# **GetUserTokenUrl**
> string GetUserTokenUrl (string redirectUri = null)

get the url which used to get user access token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetUserTokenUrlExample
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

            var apiInstance = new AuthApi(config);
            var redirectUri = redirectUri_example;  // string | your application url to receive the token (optional) 

            try
            {
                // get the url which used to get user access token
                string result = apiInstance.GetUserTokenUrl(redirectUri);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetUserTokenUrl: " + e.Message );
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
 **redirectUri** | **string**| your application url to receive the token | [optional] 

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
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshuseraccesstoken"></a>
# **RefreshUserAccessToken**
> DelegatedAccessTokenApiResult RefreshUserAccessToken (string refreshToken)

refresh user access token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class RefreshUserAccessTokenExample
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

            var apiInstance = new AuthApi(config);
            var refreshToken = refreshToken_example;  // string | 

            try
            {
                // refresh user access token
                DelegatedAccessTokenApiResult result = apiInstance.RefreshUserAccessToken(refreshToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.RefreshUserAccessToken: " + e.Message );
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
 **refreshToken** | **string**|  | 

### Return type

[**DelegatedAccessTokenApiResult**](DelegatedAccessTokenApiResult.md)

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
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

