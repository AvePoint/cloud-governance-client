# Cloud.Governance.Client.Api.DashboardAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLineOrColumnReport**](DashboardAdminApi.md#createlineorcolumnreport) | **POST** /admin/dashboard/charts/lineorcolumn | create line or column report
[**CreatePieReport**](DashboardAdminApi.md#createpiereport) | **POST** /admin/dashboard/charts/pie | create pie report
[**DeleteReport**](DashboardAdminApi.md#deletereport) | **DELETE** /admin/dashboard/charts/{id} | delete report
[**GetAllReportsIndex**](DashboardAdminApi.md#getallreportsindex) | **GET** /admin/dashboard/charts/all | load all report index
[**GetLastLastModifiedTime**](DashboardAdminApi.md#getlastlastmodifiedtime) | **GET** /admin/dashboard/charts/timerange | get default time range
[**GetReportSettings**](DashboardAdminApi.md#getreportsettings) | **GET** /admin/dashboard/charts/{id}/settings | get report info for edit
[**LoadChartStatistics**](DashboardAdminApi.md#loadchartstatistics) | **GET** /admin/dashboard/charts/statistics/{source} | load chart statistic data by source type
[**LoadLegendEntries**](DashboardAdminApi.md#loadlegendentries) | **GET** /admin/dashboard/charts/legendentries/{source}/{legendsource} | load legend entries
[**UpdateLineOrColumnReport**](DashboardAdminApi.md#updatelineorcolumnreport) | **PUT** /admin/dashboard/charts/lineorcolumn | update line or column report
[**UpdatePieReport**](DashboardAdminApi.md#updatepiereport) | **PUT** /admin/dashboard/charts/pie | update pie report


<a name="createlineorcolumnreport"></a>
# **CreateLineOrColumnReport**
> Guid CreateLineOrColumnReport (LineOrColumnChartReport lineOrColumnChartReport = null)

create line or column report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class CreateLineOrColumnReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var lineOrColumnChartReport = new LineOrColumnChartReport(); // LineOrColumnChartReport |  (optional) 

            try
            {
                // create line or column report
                Guid result = apiInstance.CreateLineOrColumnReport(lineOrColumnChartReport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.CreateLineOrColumnReport: " + e.Message );
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
 **lineOrColumnChartReport** | [**LineOrColumnChartReport**](LineOrColumnChartReport.md)|  | [optional] 

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

<a name="createpiereport"></a>
# **CreatePieReport**
> Guid CreatePieReport (PieChartReport pieChartReport = null)

create pie report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class CreatePieReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var pieChartReport = new PieChartReport(); // PieChartReport |  (optional) 

            try
            {
                // create pie report
                Guid result = apiInstance.CreatePieReport(pieChartReport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.CreatePieReport: " + e.Message );
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
 **pieChartReport** | [**PieChartReport**](PieChartReport.md)|  | [optional] 

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

<a name="deletereport"></a>
# **DeleteReport**
> void DeleteReport (Guid id)

delete report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // delete report
                apiInstance.DeleteReport(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.DeleteReport: " + e.Message );
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

<a name="getallreportsindex"></a>
# **GetAllReportsIndex**
> Dictionary&lt;string, ChartType&gt; GetAllReportsIndex ()

load all report index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllReportsIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);

            try
            {
                // load all report index
                Dictionary<string, ChartType> result = apiInstance.GetAllReportsIndex();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.GetAllReportsIndex: " + e.Message );
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

[**Dictionary&lt;string, ChartType&gt;**](ChartType.md)

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

<a name="getlastlastmodifiedtime"></a>
# **GetLastLastModifiedTime**
> Dictionary&lt;string, long&gt; GetLastLastModifiedTime ()

get default time range

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetLastLastModifiedTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);

            try
            {
                // get default time range
                Dictionary<string, long> result = apiInstance.GetLastLastModifiedTime();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.GetLastLastModifiedTime: " + e.Message );
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

**Dictionary<string, long>**

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

<a name="getreportsettings"></a>
# **GetReportSettings**
> ChartSettings GetReportSettings (Guid id, long? starttime = null, long? endtime = null)

get report info for edit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetReportSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var id = new Guid(); // Guid | 
            var starttime = 789;  // long? |  (optional)  (default to 0)
            var endtime = 789;  // long? |  (optional)  (default to 0)

            try
            {
                // get report info for edit
                ChartSettings result = apiInstance.GetReportSettings(id, starttime, endtime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.GetReportSettings: " + e.Message );
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
 **starttime** | **long?**|  | [optional] [default to 0]
 **endtime** | **long?**|  | [optional] [default to 0]

### Return type

[**ChartSettings**](ChartSettings.md)

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

<a name="loadchartstatistics"></a>
# **LoadChartStatistics**
> ChartStatistic LoadChartStatistics (ReportDataSource source)

load chart statistic data by source type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadChartStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var source = new ReportDataSource(); // ReportDataSource | 

            try
            {
                // load chart statistic data by source type
                ChartStatistic result = apiInstance.LoadChartStatistics(source);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.LoadChartStatistics: " + e.Message );
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
 **source** | [**ReportDataSource**](ReportDataSource.md)|  | 

### Return type

[**ChartStatistic**](ChartStatistic.md)

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

<a name="loadlegendentries"></a>
# **LoadLegendEntries**
> List&lt;StringModel&gt; LoadLegendEntries (ReportDataSource source, string legendsource, long? starttime = null, long? endtime = null)

load legend entries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadLegendEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var source = new ReportDataSource(); // ReportDataSource | 
            var legendsource = legendsource_example;  // string | 
            var starttime = 789;  // long? |  (optional)  (default to 0)
            var endtime = 789;  // long? |  (optional)  (default to 0)

            try
            {
                // load legend entries
                List<StringModel> result = apiInstance.LoadLegendEntries(source, legendsource, starttime, endtime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.LoadLegendEntries: " + e.Message );
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
 **source** | [**ReportDataSource**](ReportDataSource.md)|  | 
 **legendsource** | **string**|  | 
 **starttime** | **long?**|  | [optional] [default to 0]
 **endtime** | **long?**|  | [optional] [default to 0]

### Return type

[**List&lt;StringModel&gt;**](StringModel.md)

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

<a name="updatelineorcolumnreport"></a>
# **UpdateLineOrColumnReport**
> Guid UpdateLineOrColumnReport (LineOrColumnChartReport lineOrColumnChartReport = null)

update line or column report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdateLineOrColumnReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var lineOrColumnChartReport = new LineOrColumnChartReport(); // LineOrColumnChartReport |  (optional) 

            try
            {
                // update line or column report
                Guid result = apiInstance.UpdateLineOrColumnReport(lineOrColumnChartReport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.UpdateLineOrColumnReport: " + e.Message );
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
 **lineOrColumnChartReport** | [**LineOrColumnChartReport**](LineOrColumnChartReport.md)|  | [optional] 

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

<a name="updatepiereport"></a>
# **UpdatePieReport**
> Guid UpdatePieReport (PieChartReport pieChartReport = null)

update pie report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdatePieReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DashboardAdminApi(config);
            var pieChartReport = new PieChartReport(); // PieChartReport |  (optional) 

            try
            {
                // update pie report
                Guid result = apiInstance.UpdatePieReport(pieChartReport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardAdminApi.UpdatePieReport: " + e.Message );
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
 **pieChartReport** | [**PieChartReport**](PieChartReport.md)|  | [optional] 

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

