# Cloud.Governance.Client.Api.AuthAdminApi

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTokenCache**](AuthAdminApi.md#deletetokencache) | **DELETE** /admin/auth/token/cache | delete token cache
[**UpdateTokenCache**](AuthAdminApi.md#updatetokencache) | **PUT** /admin/auth/token/cache | update token cache


<a name="deletetokencache"></a>
# **DeleteTokenCache**
> void DeleteTokenCache (ApiCredential apiCredential = null)

delete token cache

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteTokenCacheExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "Cloud_Governance_Modern_API_Endpoint";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user’s account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new AuthAdminApi(config);

            var apiCredential = new ApiCredential(); // ApiCredential |  (optional) 

            try
            {
                // delete token cache
                apiInstance.DeleteTokenCache(apiCredential);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthAdminApi.DeleteTokenCache: " + e.Message );
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
 **apiCredential** | [**ApiCredential**](ApiCredential.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

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

<a name="updatetokencache"></a>
# **UpdateTokenCache**
> void UpdateTokenCache (ApiCredential apiCredential = null)

update token cache

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdateTokenCacheExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "Cloud_Governance_Modern_API_Endpoint";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user’s account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new AuthAdminApi(config);

            var apiCredential = new ApiCredential(); // ApiCredential |  (optional) 

            try
            {
                // update token cache
                apiInstance.UpdateTokenCache(apiCredential);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthAdminApi.UpdateTokenCache: " + e.Message );
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
 **apiCredential** | [**ApiCredential**](ApiCredential.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

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

