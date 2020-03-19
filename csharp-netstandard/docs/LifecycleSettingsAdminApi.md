# Cloud.Governance.Client.Api.LifecycleSettingsAdminApi

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReminder**](LifecycleSettingsAdminApi.md#addreminder) | **POST** /admin/settings/lifecycle/reminders | create reminder
[**DeleteReminder**](LifecycleSettingsAdminApi.md#deletereminder) | **DELETE** /admin/settings/lifecycle/reminders/{id} | delete reminder
[**DeleteReminders**](LifecycleSettingsAdminApi.md#deletereminders) | **DELETE** /admin/settings/lifecycle/reminders | delete reminders
[**EditReminder**](LifecycleSettingsAdminApi.md#editreminder) | **PUT** /admin/settings/lifecycle/reminders | Edit reminder
[**GerminderById**](LifecycleSettingsAdminApi.md#germinderbyid) | **GET** /admin/settings/lifecycle/reminders/{id} | get reminder
[**GetElectionProcessSettings**](LifecycleSettingsAdminApi.md#getelectionprocesssettings) | **GET** /admin/settings/lifecycle/election | get election process settings
[**GetRecertificationProfiles**](LifecycleSettingsAdminApi.md#getrecertificationprofiles) | **GET** /admin/settings/lifecycle/recertification | get recertification profiles
[**GetReminders**](LifecycleSettingsAdminApi.md#getreminders) | **GET** /admin/settings/lifecycle/reminders | get reminder list
[**SaveElectionProcessSettings**](LifecycleSettingsAdminApi.md#saveelectionprocesssettings) | **POST** /admin/settings/lifecycle/election | 


<a name="addreminder"></a>
# **AddReminder**
> Guid AddReminder (ReminderModel reminderModel = null)

create reminder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class AddReminderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var reminderModel = new ReminderModel(); // ReminderModel |  (optional) 

            try
            {
                // create reminder
                Guid result = apiInstance.AddReminder(reminderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.AddReminder: " + e.Message );
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
 **reminderModel** | [**ReminderModel**](ReminderModel.md)|  | [optional] 

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

<a name="deletereminder"></a>
# **DeleteReminder**
> void DeleteReminder (Guid id)

delete reminder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteReminderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // delete reminder
                apiInstance.DeleteReminder(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.DeleteReminder: " + e.Message );
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

<a name="deletereminders"></a>
# **DeleteReminders**
> void DeleteReminders (List<Guid> requestBody = null)

delete reminders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteRemindersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // delete reminders
                apiInstance.DeleteReminders(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.DeleteReminders: " + e.Message );
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

<a name="editreminder"></a>
# **EditReminder**
> void EditReminder (ReminderModel reminderModel = null)

Edit reminder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditReminderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var reminderModel = new ReminderModel(); // ReminderModel |  (optional) 

            try
            {
                // Edit reminder
                apiInstance.EditReminder(reminderModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.EditReminder: " + e.Message );
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
 **reminderModel** | [**ReminderModel**](ReminderModel.md)|  | [optional] 

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

<a name="germinderbyid"></a>
# **GerminderById**
> ReminderModel GerminderById (Guid id)

get reminder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GerminderByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // get reminder
                ReminderModel result = apiInstance.GerminderById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.GerminderById: " + e.Message );
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

[**ReminderModel**](ReminderModel.md)

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

<a name="getelectionprocesssettings"></a>
# **GetElectionProcessSettings**
> ElectionProcessViewModel GetElectionProcessSettings ()

get election process settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetElectionProcessSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);

            try
            {
                // get election process settings
                ElectionProcessViewModel result = apiInstance.GetElectionProcessSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.GetElectionProcessSettings: " + e.Message );
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

[**ElectionProcessViewModel**](ElectionProcessViewModel.md)

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

<a name="getrecertificationprofiles"></a>
# **GetRecertificationProfiles**
> RecertificationProfileGridModelPageResult GetRecertificationProfiles (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get recertification profiles

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetRecertificationProfilesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, type, category, modifiedTime (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description, type, category, modifiedTime (optional) 
            var search = search_example;  // string | Search for  (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get recertification profiles
                RecertificationProfileGridModelPageResult result = apiInstance.GetRecertificationProfiles(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.GetRecertificationProfiles: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, type, category, modifiedTime | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description, type, category, modifiedTime | [optional] 
 **search** | **string**| Search for  | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**RecertificationProfileGridModelPageResult**](RecertificationProfileGridModelPageResult.md)

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

<a name="getreminders"></a>
# **GetReminders**
> ReminderGridModelPageResult GetReminders (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get reminder list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetRemindersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, lastModifiedTime (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description, lastModifiedTime (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get reminder list
                ReminderGridModelPageResult result = apiInstance.GetReminders(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.GetReminders: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, lastModifiedTime | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description, lastModifiedTime | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**ReminderGridModelPageResult**](ReminderGridModelPageResult.md)

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

<a name="saveelectionprocesssettings"></a>
# **SaveElectionProcessSettings**
> void SaveElectionProcessSettings (ElectionProcessModel electionProcessModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveElectionProcessSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new LifecycleSettingsAdminApi(config);
            var electionProcessModel = new ElectionProcessModel(); // ElectionProcessModel |  (optional) 

            try
            {
                apiInstance.SaveElectionProcessSettings(electionProcessModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifecycleSettingsAdminApi.SaveElectionProcessSettings: " + e.Message );
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
 **electionProcessModel** | [**ElectionProcessModel**](ElectionProcessModel.md)|  | [optional] 

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

