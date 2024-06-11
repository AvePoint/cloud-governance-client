# Cloud.Governance.Client.Api.UnmanagedDirectoryAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportUnmanagedAdGroups**](UnmanagedDirectoryAdminApi.md#importunmanagedadgroups) | **POST** /admin/directory/unmanaged/adgroup/import | manually import existing azure ad groups
[**ImportUnmanagedEnvironments**](UnmanagedDirectoryAdminApi.md#importunmanagedenvironments) | **POST** /admin/directory/unmanaged/environment/import | manually import existing environments
[**ImportUnmanagedGroups**](UnmanagedDirectoryAdminApi.md#importunmanagedgroups) | **POST** /admin/directory/unmanaged/group/import | manually import existing microsoft 365 groups
[**ImportUnmanagedPowerApps**](UnmanagedDirectoryAdminApi.md#importunmanagedpowerapps) | **POST** /admin/directory/unmanaged/powerapps/import | manually import existing power apps
[**ImportUnmanagedPowerAutomate**](UnmanagedDirectoryAdminApi.md#importunmanagedpowerautomate) | **POST** /admin/directory/unmanaged/powerautomate/import | manually import existing power automate
[**ImportUnmanagedPowerBI**](UnmanagedDirectoryAdminApi.md#importunmanagedpowerbi) | **POST** /admin/directory/unmanaged/powerbi/import | manually import existing power bi
[**ImportUnmanagedSharedMailboxes**](UnmanagedDirectoryAdminApi.md#importunmanagedsharedmailboxes) | **POST** /admin/directory/unmanaged/sharedmailbox/import | manually import existing shared mailbox
[**ImportUnmanagedSites**](UnmanagedDirectoryAdminApi.md#importunmanagedsites) | **POST** /admin/directory/unmanaged/site/import | manually import existing site collections
[**ImportUnmanagedTeams**](UnmanagedDirectoryAdminApi.md#importunmanagedteams) | **POST** /admin/directory/unmanaged/team/import | manually import existing microsoft teams


<a name="importunmanagedadgroups"></a>
# **ImportUnmanagedAdGroups**
> void ImportUnmanagedAdGroups (ManualImportAdGroupJobModel manualImportAdGroupJobModel = null)

manually import existing azure ad groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedAdGroupsExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportAdGroupJobModel = new ManualImportAdGroupJobModel(); // ManualImportAdGroupJobModel |  (optional) 

            try
            {
                // manually import existing azure ad groups
                apiInstance.ImportUnmanagedAdGroups(manualImportAdGroupJobModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedAdGroups: " + e.Message );
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
 **manualImportAdGroupJobModel** | [**ManualImportAdGroupJobModel**](ManualImportAdGroupJobModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedenvironments"></a>
# **ImportUnmanagedEnvironments**
> Guid ImportUnmanagedEnvironments (ManualImportEnvironmentJobModel manualImportEnvironmentJobModel = null)

manually import existing environments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedEnvironmentsExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportEnvironmentJobModel = new ManualImportEnvironmentJobModel(); // ManualImportEnvironmentJobModel |  (optional) 

            try
            {
                // manually import existing environments
                Guid result = apiInstance.ImportUnmanagedEnvironments(manualImportEnvironmentJobModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedEnvironments: " + e.Message );
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
 **manualImportEnvironmentJobModel** | [**ManualImportEnvironmentJobModel**](ManualImportEnvironmentJobModel.md)|  | [optional] 

### Return type

**Guid**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedgroups"></a>
# **ImportUnmanagedGroups**
> Guid ImportUnmanagedGroups (ManualImportGroupJobModel manualImportGroupJobModel = null)

manually import existing microsoft 365 groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedGroupsExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportGroupJobModel = new ManualImportGroupJobModel(); // ManualImportGroupJobModel |  (optional) 

            try
            {
                // manually import existing microsoft 365 groups
                Guid result = apiInstance.ImportUnmanagedGroups(manualImportGroupJobModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedGroups: " + e.Message );
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
 **manualImportGroupJobModel** | [**ManualImportGroupJobModel**](ManualImportGroupJobModel.md)|  | [optional] 

### Return type

**Guid**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedpowerapps"></a>
# **ImportUnmanagedPowerApps**
> void ImportUnmanagedPowerApps (ManualImportPowerAppsJobModel manualImportPowerAppsJobModel = null)

manually import existing power apps

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedPowerAppsExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportPowerAppsJobModel = new ManualImportPowerAppsJobModel(); // ManualImportPowerAppsJobModel |  (optional) 

            try
            {
                // manually import existing power apps
                apiInstance.ImportUnmanagedPowerApps(manualImportPowerAppsJobModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedPowerApps: " + e.Message );
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
 **manualImportPowerAppsJobModel** | [**ManualImportPowerAppsJobModel**](ManualImportPowerAppsJobModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedpowerautomate"></a>
# **ImportUnmanagedPowerAutomate**
> void ImportUnmanagedPowerAutomate (ManualImportPowerAutomateJobModel manualImportPowerAutomateJobModel = null)

manually import existing power automate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedPowerAutomateExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportPowerAutomateJobModel = new ManualImportPowerAutomateJobModel(); // ManualImportPowerAutomateJobModel |  (optional) 

            try
            {
                // manually import existing power automate
                apiInstance.ImportUnmanagedPowerAutomate(manualImportPowerAutomateJobModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedPowerAutomate: " + e.Message );
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
 **manualImportPowerAutomateJobModel** | [**ManualImportPowerAutomateJobModel**](ManualImportPowerAutomateJobModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedpowerbi"></a>
# **ImportUnmanagedPowerBI**
> void ImportUnmanagedPowerBI (ManualImportPowerBIJobModel manualImportPowerBIJobModel = null)

manually import existing power bi

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedPowerBIExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportPowerBIJobModel = new ManualImportPowerBIJobModel(); // ManualImportPowerBIJobModel |  (optional) 

            try
            {
                // manually import existing power bi
                apiInstance.ImportUnmanagedPowerBI(manualImportPowerBIJobModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedPowerBI: " + e.Message );
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
 **manualImportPowerBIJobModel** | [**ManualImportPowerBIJobModel**](ManualImportPowerBIJobModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedsharedmailboxes"></a>
# **ImportUnmanagedSharedMailboxes**
> void ImportUnmanagedSharedMailboxes (ManualImportSharedMailboxJobModel manualImportSharedMailboxJobModel = null)

manually import existing shared mailbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedSharedMailboxesExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportSharedMailboxJobModel = new ManualImportSharedMailboxJobModel(); // ManualImportSharedMailboxJobModel |  (optional) 

            try
            {
                // manually import existing shared mailbox
                apiInstance.ImportUnmanagedSharedMailboxes(manualImportSharedMailboxJobModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedSharedMailboxes: " + e.Message );
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
 **manualImportSharedMailboxJobModel** | [**ManualImportSharedMailboxJobModel**](ManualImportSharedMailboxJobModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedsites"></a>
# **ImportUnmanagedSites**
> Guid ImportUnmanagedSites (ManualImportSiteJobModel manualImportSiteJobModel = null)

manually import existing site collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedSitesExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportSiteJobModel = new ManualImportSiteJobModel(); // ManualImportSiteJobModel |  (optional) 

            try
            {
                // manually import existing site collections
                Guid result = apiInstance.ImportUnmanagedSites(manualImportSiteJobModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedSites: " + e.Message );
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
 **manualImportSiteJobModel** | [**ManualImportSiteJobModel**](ManualImportSiteJobModel.md)|  | [optional] 

### Return type

**Guid**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importunmanagedteams"></a>
# **ImportUnmanagedTeams**
> Guid ImportUnmanagedTeams (ManualImportTeamJobModel manualImportTeamJobModel = null)

manually import existing microsoft teams

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ImportUnmanagedTeamsExample
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

            var apiInstance = new UnmanagedDirectoryAdminApi(config);

            var manualImportTeamJobModel = new ManualImportTeamJobModel(); // ManualImportTeamJobModel |  (optional) 

            try
            {
                // manually import existing microsoft teams
                Guid result = apiInstance.ImportUnmanagedTeams(manualImportTeamJobModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UnmanagedDirectoryAdminApi.ImportUnmanagedTeams: " + e.Message );
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
 **manualImportTeamJobModel** | [**ManualImportTeamJobModel**](ManualImportTeamJobModel.md)|  | [optional] 

### Return type

**Guid**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

