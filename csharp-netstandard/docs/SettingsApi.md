# Cloud.Governance.NewSdk.Api.SettingsApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditMyPersonalSettings**](SettingsApi.md#editmypersonalsettings) | **PUT** /settings/my | edit my personal settings
[**GetApplicationSettings**](SettingsApi.md#getapplicationsettings) | **GET** /settings/app | get application settings
[**GetDynamicMembershipRuleItems**](SettingsApi.md#getdynamicmembershipruleitems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
[**GetHelpLink**](SettingsApi.md#gethelplink) | **GET** /settings/helplink | get help link
[**GetMyPersonalSettings**](SettingsApi.md#getmypersonalsettings) | **GET** /settings/my | get my personal settings
[**GetNews**](SettingsApi.md#getnews) | **GET** /settings/news | get news
[**GetPermissionLevels**](SettingsApi.md#getpermissionlevels) | **GET** /settings/office365/permissionlevels | get permission levels
[**GetSupportedLanguages**](SettingsApi.md#getsupportedlanguages) | **GET** /settings/languages | get supported language
[**GetTimeZones**](SettingsApi.md#gettimezones) | **GET** /settings/timezones | get timezones


<a name="editmypersonalsettings"></a>
# **EditMyPersonalSettings**
> void EditMyPersonalSettings (PersonalSettings personalSettings = null)

edit my personal settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class EditMyPersonalSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);
            var personalSettings = new PersonalSettings(); // PersonalSettings |  (optional) 

            try
            {
                // edit my personal settings
                apiInstance.EditMyPersonalSettings(personalSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.EditMyPersonalSettings: " + e.Message );
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
 **personalSettings** | [**PersonalSettings**](PersonalSettings.md)|  | [optional] 

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

<a name="getapplicationsettings"></a>
# **GetApplicationSettings**
> ApplicationSettings GetApplicationSettings (int? localeId = null)

get application settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetApplicationSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);
            var localeId = 56;  // int? |  (optional) 

            try
            {
                // get application settings
                ApplicationSettings result = apiInstance.GetApplicationSettings(localeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetApplicationSettings: " + e.Message );
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
 **localeId** | **int?**|  | [optional] 

### Return type

[**ApplicationSettings**](ApplicationSettings.md)

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

<a name="getdynamicmembershipruleitems"></a>
# **GetDynamicMembershipRuleItems**
> InlineResponse200 GetDynamicMembershipRuleItems (Guid tenantid)

get group/teams dynamic membership rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetDynamicMembershipRuleItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);
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

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethelplink"></a>
# **GetHelpLink**
> CustomHelpLinkModel GetHelpLink ()

get help link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetHelpLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);

            try
            {
                // get help link
                CustomHelpLinkModel result = apiInstance.GetHelpLink();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetHelpLink: " + e.Message );
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

[**CustomHelpLinkModel**](CustomHelpLinkModel.md)

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

<a name="getmypersonalsettings"></a>
# **GetMyPersonalSettings**
> PersonalSettings GetMyPersonalSettings ()

get my personal settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetMyPersonalSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);

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

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnews"></a>
# **GetNews**
> NewsAndUpdatesInfo GetNews ()

get news

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetNewsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);

            try
            {
                // get news
                NewsAndUpdatesInfo result = apiInstance.GetNews();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetNews: " + e.Message );
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

[**NewsAndUpdatesInfo**](NewsAndUpdatesInfo.md)

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

<a name="getpermissionlevels"></a>
# **GetPermissionLevels**
> List&lt;PermissionLevel&gt; GetPermissionLevels ()

get permission levels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetPermissionLevelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);

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

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupportedlanguages"></a>
# **GetSupportedLanguages**
> List&lt;ResourceValue&gt; GetSupportedLanguages ()

get supported language

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetSupportedLanguagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);

            try
            {
                // get supported language
                List<ResourceValue> result = apiInstance.GetSupportedLanguages();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSupportedLanguages: " + e.Message );
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

[**List&lt;ResourceValue&gt;**](ResourceValue.md)

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

<a name="gettimezones"></a>
# **GetTimeZones**
> List&lt;ResourceValue&gt; GetTimeZones ()

get timezones

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetTimeZonesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SettingsApi(Configuration.Default);

            try
            {
                // get timezones
                List<ResourceValue> result = apiInstance.GetTimeZones();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetTimeZones: " + e.Message );
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

[**List&lt;ResourceValue&gt;**](ResourceValue.md)

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

