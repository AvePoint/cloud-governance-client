# CgClient.QuestionnairesApi

All URIs are relative to *https://API_BASE_URL*

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
var CgClient = require('cg-client');
var defaultClient = CgClient.ApiClient.instance;
defaultClient.basePath = "API BASE URL";

// Configure API key authorization: ClientId
var ClientId = defaultClient.authentications['ClientId'];
ClientId.apiKey = 'clientid';

// Configure API key authorization: ClientSecret
var ClientSecret = defaultClient.authentications['ClientSecret'];
ClientSecret.apiKey = 'clientsecret';

// Configure API key authorization: UserPrincipalName
var UserPrincipalName = defaultClient.authentications['UserPrincipalName'];
UserPrincipalName.apiKey = 'userprincipalname';


var apiInstance = new CgClient.QuestionnairesApi();
var id = null; // String | 
apiInstance.getQuestionnaireById(id).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 

### Return type

[**QuestionnaireRef**](QuestionnaireRef.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## submitQuestionnaire

> [ServiceList] submitQuestionnaire(opts)

submit questionnaire

### Example

```javascript
var CgClient = require('cg-client');
var defaultClient = CgClient.ApiClient.instance;
defaultClient.basePath = "API BASE URL";

// Configure API key authorization: ClientId
var ClientId = defaultClient.authentications['ClientId'];
ClientId.apiKey = 'clientid';

// Configure API key authorization: ClientSecret
var ClientSecret = defaultClient.authentications['ClientSecret'];
ClientSecret.apiKey = 'clientsecret';

// Configure API key authorization: UserPrincipalName
var UserPrincipalName = defaultClient.authentications['UserPrincipalName'];
UserPrincipalName.apiKey = 'userprincipalname';


var apiInstance = new CgClient.QuestionnairesApi();
var opts = {
  'questionnaireRequest': new CgClient.QuestionnaireRequest() // QuestionnaireRequest | 
};
apiInstance.submitQuestionnaire(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**[ServiceList]**](ServiceList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## submitQuestionnaireInWorkspace

> [ServiceList] submitQuestionnaireInWorkspace(objecttype, objectid, opts)

submit questionnaire in workspace

### Example

```javascript
var CgClient = require('cg-client');
var defaultClient = CgClient.ApiClient.instance;
defaultClient.basePath = "API BASE URL";

// Configure API key authorization: ClientId
var ClientId = defaultClient.authentications['ClientId'];
ClientId.apiKey = 'clientid';

// Configure API key authorization: ClientSecret
var ClientSecret = defaultClient.authentications['ClientSecret'];
ClientSecret.apiKey = 'clientsecret';

// Configure API key authorization: UserPrincipalName
var UserPrincipalName = defaultClient.authentications['UserPrincipalName'];
UserPrincipalName.apiKey = 'userprincipalname';


var apiInstance = new CgClient.QuestionnairesApi();
var objecttype = new CgClient.WorkspaceType(); // WorkspaceType | 
var objectid = "objectid_example"; // String | 
var opts = {
  'questionnaireRequest': new CgClient.QuestionnaireRequest() // QuestionnaireRequest | 
};
apiInstance.submitQuestionnaireInWorkspace(objecttype, objectid, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

