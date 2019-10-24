# CloudGovernanceApi.EmailsApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getEmailTemplate**](EmailsApi.md#getEmailTemplate) | **GET** /emails/{type} | get email templates by email template type



## getEmailTemplate

> [GuidModel] getEmailTemplate(type)

get email templates by email template type

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.EmailsApi();
let type = new CloudGovernanceApi.EmailTemplateType(); // EmailTemplateType | 
apiInstance.getEmailTemplate(type, (error, data, response) => {
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
 **type** | [**EmailTemplateType**](.md)|  | 

### Return type

[**[GuidModel]**](GuidModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

