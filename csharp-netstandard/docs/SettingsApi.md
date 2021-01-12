# Cloud.Governance.Client.Api.SettingsApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDynamicMembershipRuleItems**](SettingsApi.md#getdynamicmembershipruleitems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
[**GetMyPersonalSettings**](SettingsApi.md#getmypersonalsettings) | **GET** /settings/my | get my personal settings
[**GetPermissionLevels**](SettingsApi.md#getpermissionlevels) | **GET** /settings/office365/permissionlevels | get permission levels


<a name="getdynamicmembershipruleitems"></a>
# **GetDynamicMembershipRuleItems**
> InlineResponse200 GetDynamicMembershipRuleItems (Guid tenantid)

get group/teams dynamic membership rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetDynamicMembershipRuleItemsExample
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

            var apiInstance = new SettingsApi(config);

            var tenantid = new Guid(); // Guid | 

            try
            {
                // get group/teams dynamic membership rules
                InlineResponse200 result = apiInstance.GetDynamicMembershipRuleItems(tenantid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetDynamicMembershipRuleItems: " + e.Message );
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
 **tenantid** | [**Guid**](Guid.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

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

<a name="getmypersonalsettings"></a>
# **GetMyPersonalSettings**
> PersonalSettings GetMyPersonalSettings ()

get my personal settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetMyPersonalSettingsExample
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

            var apiInstance = new SettingsApi(config);


            try
            {
                // get my personal settings
                PersonalSettings result = apiInstance.GetMyPersonalSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetMyPersonalSettings: " + e.Message );
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

[**PersonalSettings**](PersonalSettings.md)

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

<a name="getpermissionlevels"></a>
# **GetPermissionLevels**
> List&lt;PermissionLevel&gt; GetPermissionLevels ()

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

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "{Cloud_Governance_Modern_API_Endpoint}";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new SettingsApi(config);


            try
            {
                // get permission levels
                List<PermissionLevel> result = apiInstance.GetPermissionLevels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPermissionLevels: " + e.Message );
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

[**List&lt;PermissionLevel&gt;**](PermissionLevel.md)

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

