# Cloud.Governance.Client.Api.SystemSettingsAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHookMessageSamples**](SystemSettingsAdminApi.md#gethookmessagesamples) | **GET** /admin/settings/system/hooks/messages/sample | 


<a name="gethookmessagesamples"></a>
# **GetHookMessageSamples**
> HookMessageList GetHookMessageSamples ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetHookMessageSamplesExample
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

            var apiInstance = new SystemSettingsAdminApi(config);


            try
            {
                HookMessageList result = apiInstance.GetHookMessageSamples();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemSettingsAdminApi.GetHookMessageSamples: " + e.Message );
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

[**HookMessageList**](HookMessageList.md)

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
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

