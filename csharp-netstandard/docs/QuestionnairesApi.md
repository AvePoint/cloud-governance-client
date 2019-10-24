# Cloud.Governance.NewSdk.Api.QuestionnairesApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetQuestionnaireById**](QuestionnairesApi.md#getquestionnairebyid) | **GET** /questionnaires/{id} | get questionnaire by id
[**SubmitQuestionnaire**](QuestionnairesApi.md#submitquestionnaire) | **POST** /questionnaires | submit questionnaire
[**SubmitQuestionnaireInWorkspace**](QuestionnairesApi.md#submitquestionnaireinworkspace) | **POST** /questionnaires/workspace/{objecttype}/{objectid} | submit questionnaire in workspace


<a name="getquestionnairebyid"></a>
# **GetQuestionnaireById**
> QuestionnaireRef GetQuestionnaireById (Guid id)

get questionnaire by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class GetQuestionnaireByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionnairesApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get questionnaire by id
                QuestionnaireRef result = apiInstance.GetQuestionnaireById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesApi.GetQuestionnaireById: " + e.Message );
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

[**QuestionnaireRef**](QuestionnaireRef.md)

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

<a name="submitquestionnaire"></a>
# **SubmitQuestionnaire**
> List&lt;ServiceList&gt; SubmitQuestionnaire (QuestionnaireRequest questionnaireRequest = null)

submit questionnaire

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitQuestionnaireExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionnairesApi(Configuration.Default);
            var questionnaireRequest = new QuestionnaireRequest(); // QuestionnaireRequest |  (optional) 

            try
            {
                // submit questionnaire
                List<ServiceList> result = apiInstance.SubmitQuestionnaire(questionnaireRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesApi.SubmitQuestionnaire: " + e.Message );
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
 **questionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**List&lt;ServiceList&gt;**](ServiceList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitquestionnaireinworkspace"></a>
# **SubmitQuestionnaireInWorkspace**
> List&lt;ServiceList&gt; SubmitQuestionnaireInWorkspace (WorkspaceType objecttype, string objectid, QuestionnaireRequest questionnaireRequest = null)

submit questionnaire in workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.NewSdk.Api;
using Cloud.Governance.NewSdk.Client;
using Cloud.Governance.NewSdk.Model;

namespace Example
{
    public class SubmitQuestionnaireInWorkspaceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cg-api.avepointlabs.com";
            // Configure API key authorization: BearerAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionnairesApi(Configuration.Default);
            var objecttype = new WorkspaceType(); // WorkspaceType | 
            var objectid = objectid_example;  // string | 
            var questionnaireRequest = new QuestionnaireRequest(); // QuestionnaireRequest |  (optional) 

            try
            {
                // submit questionnaire in workspace
                List<ServiceList> result = apiInstance.SubmitQuestionnaireInWorkspace(objecttype, objectid, questionnaireRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestionnairesApi.SubmitQuestionnaireInWorkspace: " + e.Message );
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
 **objecttype** | [**WorkspaceType**](WorkspaceType.md)|  | 
 **objectid** | **string**|  | 
 **questionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**List&lt;ServiceList&gt;**](ServiceList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

