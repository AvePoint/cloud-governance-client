# Cloud.Governance.Client.Api.ApprovalprocessesAdminApi

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateApprovalProcess**](ApprovalprocessesAdminApi.md#createapprovalprocess) | **POST** /admin/approvalprocesses | create approval process
[**DeleteSelectedApprovalProcesses**](ApprovalprocessesAdminApi.md#deleteselectedapprovalprocesses) | **DELETE** /admin/approvalprocesses | remove selected approval processes
[**GetApprovalProcessFilters**](ApprovalprocessesAdminApi.md#getapprovalprocessfilters) | **GET** /admin/approvalprocesses/filters | get filters of approval process
[**GetApprovalProcessSetting**](ApprovalprocessesAdminApi.md#getapprovalprocesssetting) | **GET** /admin/approvalprocesses/{id} | get edit approval process setting
[**GetApprovalProcesses**](ApprovalprocessesAdminApi.md#getapprovalprocesses) | **GET** /admin/approvalprocesses | get all approval processes
[**UpdateApprovalProcess**](ApprovalprocessesAdminApi.md#updateapprovalprocess) | **PUT** /admin/approvalprocesses | update approval process
[**UpdateSelectedApprovalProcessesStatus**](ApprovalprocessesAdminApi.md#updateselectedapprovalprocessesstatus) | **PATCH** /admin/approvalprocesses/status/{status} | update the status of selected approval processes


<a name="createapprovalprocess"></a>
# **CreateApprovalProcess**
> void CreateApprovalProcess (ApprovalProcessModel approvalProcessModel = null)

create approval process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class CreateApprovalProcessExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var approvalProcessModel = new ApprovalProcessModel(); // ApprovalProcessModel |  (optional) 

            try
            {
                // create approval process
                apiInstance.CreateApprovalProcess(approvalProcessModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.CreateApprovalProcess: " + e.Message );
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
 **approvalProcessModel** | [**ApprovalProcessModel**](ApprovalProcessModel.md)|  | [optional] 

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

<a name="deleteselectedapprovalprocesses"></a>
# **DeleteSelectedApprovalProcesses**
> void DeleteSelectedApprovalProcesses (List<Guid> requestBody = null)

remove selected approval processes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteSelectedApprovalProcessesExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // remove selected approval processes
                apiInstance.DeleteSelectedApprovalProcesses(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.DeleteSelectedApprovalProcesses: " + e.Message );
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

<a name="getapprovalprocessfilters"></a>
# **GetApprovalProcessFilters**
> DistinctPageResult GetApprovalProcessFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get filters of approval process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetApprovalProcessFiltersExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get filters of approval process
                DistinctPageResult result = apiInstance.GetApprovalProcessFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.GetApprovalProcessFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] 
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

<a name="getapprovalprocesssetting"></a>
# **GetApprovalProcessSetting**
> ApprovalProcessModel GetApprovalProcessSetting (Guid id)

get edit approval process setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetApprovalProcessSettingExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // get edit approval process setting
                ApprovalProcessModel result = apiInstance.GetApprovalProcessSetting(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.GetApprovalProcessSetting: " + e.Message );
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

[**ApprovalProcessModel**](ApprovalProcessModel.md)

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

<a name="getapprovalprocesses"></a>
# **GetApprovalProcesses**
> ApprovalProcessGridModelPageResult GetApprovalProcesses (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all approval processes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetApprovalProcessesExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all approval processes
                ApprovalProcessGridModelPageResult result = apiInstance.GetApprovalProcesses(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.GetApprovalProcesses: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**ApprovalProcessGridModelPageResult**](ApprovalProcessGridModelPageResult.md)

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

<a name="updateapprovalprocess"></a>
# **UpdateApprovalProcess**
> void UpdateApprovalProcess (ApprovalProcessModel approvalProcessModel = null)

update approval process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdateApprovalProcessExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var approvalProcessModel = new ApprovalProcessModel(); // ApprovalProcessModel |  (optional) 

            try
            {
                // update approval process
                apiInstance.UpdateApprovalProcess(approvalProcessModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.UpdateApprovalProcess: " + e.Message );
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
 **approvalProcessModel** | [**ApprovalProcessModel**](ApprovalProcessModel.md)|  | [optional] 

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

<a name="updateselectedapprovalprocessesstatus"></a>
# **UpdateSelectedApprovalProcessesStatus**
> void UpdateSelectedApprovalProcessesStatus (CommonStatus status, List<Guid> requestBody = null)

update the status of selected approval processes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdateSelectedApprovalProcessesStatusExample
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

            var apiInstance = new ApprovalprocessesAdminApi(config);
            var status = new CommonStatus(); // CommonStatus | 
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // update the status of selected approval processes
                apiInstance.UpdateSelectedApprovalProcessesStatus(status, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApprovalprocessesAdminApi.UpdateSelectedApprovalProcessesStatus: " + e.Message );
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
 **status** | [**CommonStatus**](CommonStatus.md)|  | 
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

