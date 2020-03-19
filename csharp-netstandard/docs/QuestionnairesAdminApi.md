# Cloud.Governance.Client.Api.QuestionnairesAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSelectedQuestionnaires**](QuestionnairesAdminApi.md#deleteselectedquestionnaires) | **DELETE** /admin/questionnaires | remove selected questionnaires
[**GetQuestionMetadataList**](QuestionnairesAdminApi.md#getquestionmetadatalist) | **GET** /admin/questionnaires/question/metadata | get question metadata list
[**GetQuestionServiceList**](QuestionnairesAdminApi.md#getquestionservicelist) | **GET** /admin/questionnaires/service | get questionnaire service list
[**GetQuestionnaireFilters**](QuestionnairesAdminApi.md#getquestionnairefilters) | **GET** /admin/questionnaires/filters | get filters of questionnaires
[**GetQuestionnaireSetting**](QuestionnairesAdminApi.md#getquestionnairesetting) | **GET** /admin/questionnaires/{id} | get questionnaire setting
[**GetQuestionnaires**](QuestionnairesAdminApi.md#getquestionnaires) | **GET** /admin/questionnaires | get all questionnaires
[**UpdateSelectedQuestionnairesStatus**](QuestionnairesAdminApi.md#updateselectedquestionnairesstatus) | **PATCH** /admin/questionnaires/status/{status} | update the status of selected questionnaires


<a name="deleteselectedquestionnaires"></a>
# **DeleteSelectedQuestionnaires**
> void DeleteSelectedQuestionnaires (List<Guid> requestBody = null)

remove selected questionnaires

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteSelectedQuestionnairesExample
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

            var apiInstance = new QuestionnairesAdminApi(config);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // remove selected questionnaires
                apiInstance.DeleteSelectedQuestionnaires(requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.DeleteSelectedQuestionnaires: " + e.Message );
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

<a name="getquestionmetadatalist"></a>
# **GetQuestionMetadataList**
> List&lt;StringModel&gt; GetQuestionMetadataList ()

get question metadata list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetQuestionMetadataListExample
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

            var apiInstance = new QuestionnairesAdminApi(config);

            try
            {
                // get question metadata list
                List<StringModel> result = apiInstance.GetQuestionMetadataList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.GetQuestionMetadataList: " + e.Message );
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

<a name="getquestionservicelist"></a>
# **GetQuestionServiceList**
> List&lt;StringModel&gt; GetQuestionServiceList ()

get questionnaire service list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetQuestionServiceListExample
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

            var apiInstance = new QuestionnairesAdminApi(config);

            try
            {
                // get questionnaire service list
                List<StringModel> result = apiInstance.GetQuestionServiceList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.GetQuestionServiceList: " + e.Message );
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

<a name="getquestionnairefilters"></a>
# **GetQuestionnaireFilters**
> DistinctPageResult GetQuestionnaireFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get filters of questionnaires

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetQuestionnaireFiltersExample
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

            var apiInstance = new QuestionnairesAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, languageID, status (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, name, description, languageID, status (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get filters of questionnaires
                DistinctPageResult result = apiInstance.GetQuestionnaireFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.GetQuestionnaireFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, languageID, status | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, description, languageID, status | [optional] 
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

<a name="getquestionnairesetting"></a>
# **GetQuestionnaireSetting**
> QuestionnaireModel GetQuestionnaireSetting (Guid id)

get questionnaire setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetQuestionnaireSettingExample
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

            var apiInstance = new QuestionnairesAdminApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // get questionnaire setting
                QuestionnaireModel result = apiInstance.GetQuestionnaireSetting(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.GetQuestionnaireSetting: " + e.Message );
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

[**QuestionnaireModel**](QuestionnaireModel.md)

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

<a name="getquestionnaires"></a>
# **GetQuestionnaires**
> QuestionnaireGridModelPageResult GetQuestionnaires (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all questionnaires

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetQuestionnairesExample
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

            var apiInstance = new QuestionnairesAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, languageID, status (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description, languageID, status (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all questionnaires
                QuestionnaireGridModelPageResult result = apiInstance.GetQuestionnaires(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.GetQuestionnaires: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, languageID, status | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description, languageID, status | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**QuestionnaireGridModelPageResult**](QuestionnaireGridModelPageResult.md)

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

<a name="updateselectedquestionnairesstatus"></a>
# **UpdateSelectedQuestionnairesStatus**
> void UpdateSelectedQuestionnairesStatus (CommonStatus status, List<Guid> requestBody = null)

update the status of selected questionnaires

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdateSelectedQuestionnairesStatusExample
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

            var apiInstance = new QuestionnairesAdminApi(config);
            var status = new CommonStatus(); // CommonStatus | 
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // update the status of selected questionnaires
                apiInstance.UpdateSelectedQuestionnairesStatus(status, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesAdminApi.UpdateSelectedQuestionnairesStatus: " + e.Message );
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

