# Cloud.Governance.Client.Api.RequestsDirectoryAdminApi

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSelectedRequests**](RequestsDirectoryAdminApi.md#deleteselectedrequests) | **DELETE** /admin/directory/requests | remove selected requests
[**GetAllRequests**](RequestsDirectoryAdminApi.md#getallrequests) | **GET** /admin/directory/requests | get all requests
[**GetAllRequestsFilters**](RequestsDirectoryAdminApi.md#getallrequestsfilters) | **GET** /admin/directory/requests/filters | get all requests filters


<a name="deleteselectedrequests"></a>
# **DeleteSelectedRequests**
> void DeleteSelectedRequests (List<Guid> requestBody = null)

remove selected requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteSelectedRequestsExample
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

            var apiInstance = new RequestsDirectoryAdminApi(config);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // remove selected requests
                apiInstance.DeleteSelectedRequests(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsDirectoryAdminApi.DeleteSelectedRequests: " + e.Message );
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

<a name="getallrequests"></a>
# **GetAllRequests**
> AllRequestListPageResult GetAllRequests (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllRequestsExample
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

            var apiInstance = new RequestsDirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var search = search_example;  // string | Search for summary (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all requests
                AllRequestListPageResult result = apiInstance.GetAllRequests(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsDirectoryAdminApi.GetAllRequests: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
 **search** | **string**| Search for summary | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**AllRequestListPageResult**](AllRequestListPageResult.md)

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

<a name="getallrequestsfilters"></a>
# **GetAllRequestsFilters**
> DistinctPageResult GetAllRequestsFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get all requests filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllRequestsFiltersExample
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

            var apiInstance = new RequestsDirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all requests filters
                DistinctPageResult result = apiInstance.GetAllRequestsFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsDirectoryAdminApi.GetAllRequestsFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, serviceId, serviceName, serviceType, ticketNumber, summary, requester, requesterDisplayName, detailStatus, progressStatus, modified, assignTo, assignToDisplayName, serviceAdmin, objectUrl, createdTime | [optional] 
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

