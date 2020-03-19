# Cloud.Governance.Client.Api.TasksDirectoryAdminApi

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllRecertificationTaskFilters**](TasksDirectoryAdminApi.md#getallrecertificationtaskfilters) | **GET** /admin/directory/tasks/recertification/filters | get all recertificate tasks filters
[**GetAllRecertificationTasks**](TasksDirectoryAdminApi.md#getallrecertificationtasks) | **GET** /admin/directory/tasks/recertification | get all tasks
[**GetAllTasks**](TasksDirectoryAdminApi.md#getalltasks) | **GET** /admin/directory/tasks | get all tasks
[**GetAllTasksFilters**](TasksDirectoryAdminApi.md#getalltasksfilters) | **GET** /admin/directory/tasks/filters | get all tasks filters


<a name="getallrecertificationtaskfilters"></a>
# **GetAllRecertificationTaskFilters**
> DistinctPageResult GetAllRecertificationTaskFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get all recertificate tasks filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllRecertificationTaskFiltersExample
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

            var apiInstance = new TasksDirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all recertificate tasks filters
                DistinctPageResult result = apiInstance.GetAllRecertificationTaskFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksDirectoryAdminApi.GetAllRecertificationTaskFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus | [optional] 
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

<a name="getallrecertificationtasks"></a>
# **GetAllRecertificationTasks**
> RecertificationTaskGridModelPageResult GetAllRecertificationTasks (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllRecertificationTasksExample
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

            var apiInstance = new TasksDirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus (optional) 
            var search = search_example;  // string | Search for  (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all tasks
                RecertificationTaskGridModelPageResult result = apiInstance.GetAllRecertificationTasks(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksDirectoryAdminApi.GetAllRecertificationTasks: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; summary, comments, modified, assignTo, assignToDisplayName, objectUrl, createdTime, taskStatus | [optional] 
 **search** | **string**| Search for  | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**RecertificationTaskGridModelPageResult**](RecertificationTaskGridModelPageResult.md)

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

<a name="getalltasks"></a>
# **GetAllTasks**
> AllTaskListPageResult GetAllTasks (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllTasksExample
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

            var apiInstance = new TasksDirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var search = search_example;  // string | Search for summary (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all tasks
                AllTaskListPageResult result = apiInstance.GetAllTasks(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksDirectoryAdminApi.GetAllTasks: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
 **search** | **string**| Search for summary | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**AllTaskListPageResult**](AllTaskListPageResult.md)

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

<a name="getalltasksfilters"></a>
# **GetAllTasksFilters**
> DistinctPageResult GetAllTasksFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get all tasks filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllTasksFiltersExample
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

            var apiInstance = new TasksDirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all tasks filters
                DistinctPageResult result = apiInstance.GetAllTasksFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksDirectoryAdminApi.GetAllTasksFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; comments, taskStatus, id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
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

