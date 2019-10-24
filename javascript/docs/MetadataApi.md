# CloudGovernanceApi.MetadataApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getMetadata**](MetadataApi.md#getMetadata) | **GET** /metadata | get metadata
[**getMetadataById**](MetadataApi.md#getMetadataById) | **GET** /metadata/{id} | get metadata by id



## getMetadata

> [CustomMetadata] getMetadata(opts)

get metadata

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.MetadataApi();
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime
  'search': "search_example", // String | Search for name
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getMetadata(opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] 
 **search** | **String**| Search for name | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**[CustomMetadata]**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMetadataById

> CustomMetadata getMetadataById(id)

get metadata by id

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.MetadataApi();
let id = null; // String | 
apiInstance.getMetadataById(id, (error, data, response) => {
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

[**CustomMetadata**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

