# Cloud.Governance.Client.Api.MetadataApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMetadata**](MetadataApi.md#getmetadata) | **GET** /metadata | get metadata
[**GetMetadataById**](MetadataApi.md#getmetadatabyid) | **GET** /metadata/{id} | get metadata by id


<a name="getmetadata"></a>
# **GetMetadata**
> CustomMetadataPageResult GetMetadata (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new MetadataApi(Configuration.Default);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get metadata
                CustomMetadataPageResult result = apiInstance.GetMetadata(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetMetadata: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**CustomMetadataPageResult**](CustomMetadataPageResult.md)

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

<a name="getmetadatabyid"></a>
# **GetMetadataById**
> CustomMetadata GetMetadataById (Guid id)

get metadata by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetMetadataByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new MetadataApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get metadata by id
                CustomMetadata result = apiInstance.GetMetadataById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetMetadataById: " + e.Message );
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

[**CustomMetadata**](CustomMetadata.md)

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

