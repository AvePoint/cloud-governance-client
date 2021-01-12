# Cloud.Governance.Client.Api.AuthApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDelegateAccessToken**](AuthApi.md#getdelegateaccesstoken) | **POST** /auth/token/delegate | get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
[**RefreshUserAccessToken**](AuthApi.md#refreshuseraccesstoken) | **POST** /auth/token/refresh | refresh user access token


<a name="getdelegateaccesstoken"></a>
# **GetDelegateAccessToken**
> DelegatedAccessTokenApiResult GetDelegateAccessToken (ApiCredential apiCredential)

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

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "{Cloud_Governance_Modern_API_Endpoint}";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new AuthApi(config);

            var apiCredential = new ApiCredential(); // ApiCredential | 

            try
            {
                // get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
                DelegatedAccessTokenApiResult result = apiInstance.GetDelegateAccessToken(apiCredential);
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
 **apiCredential** | [**ApiCredential**](ApiCredential.md)|  | 

### Return type

[**DelegatedAccessTokenApiResult**](DelegatedAccessTokenApiResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DelegatedAccessToken |  -  |
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

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "{Cloud_Governance_Modern_API_Endpoint}";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

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

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

