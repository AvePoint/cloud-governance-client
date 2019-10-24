# CloudGovernanceApi.QuestionnairesApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getQuestionnaireById**](QuestionnairesApi.md#getQuestionnaireById) | **GET** /questionnaires/{id} | get questionnaire by id
[**submitQuestionnaire**](QuestionnairesApi.md#submitQuestionnaire) | **POST** /questionnaires | submit questionnaire
[**submitQuestionnaireInWorkspace**](QuestionnairesApi.md#submitQuestionnaireInWorkspace) | **POST** /questionnaires/workspace/{objecttype}/{objectid} | submit questionnaire in workspace



## getQuestionnaireById

> QuestionnaireRef getQuestionnaireById(id)

get questionnaire by id

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.QuestionnairesApi();
let id = null; // String | 
apiInstance.getQuestionnaireById(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 

### Return type

[**QuestionnaireRef**](QuestionnaireRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## submitQuestionnaire

> [ServiceList] submitQuestionnaire(opts)

submit questionnaire

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.QuestionnairesApi();
let opts = {
  'questionnaireRequest': new CloudGovernanceApi.QuestionnaireRequest() // QuestionnaireRequest | 
};
apiInstance.submitQuestionnaire(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**[ServiceList]**](ServiceList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## submitQuestionnaireInWorkspace

> [ServiceList] submitQuestionnaireInWorkspace(objecttype, objectid, opts)

submit questionnaire in workspace

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.QuestionnairesApi();
let objecttype = new CloudGovernanceApi.WorkspaceType(); // WorkspaceType | 
let objectid = "objectid_example"; // String | 
let opts = {
  'questionnaireRequest': new CloudGovernanceApi.QuestionnaireRequest() // QuestionnaireRequest | 
};
apiInstance.submitQuestionnaireInWorkspace(objecttype, objectid, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objecttype** | [**WorkspaceType**](.md)|  | 
 **objectid** | **String**|  | 
 **questionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**[ServiceList]**](ServiceList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

