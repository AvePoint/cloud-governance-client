# CloudGovernanceApi.UsersApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**checkUserExistsInAOS**](UsersApi.md#checkUserExistsInAOS) | **GET** /users/avepointonlineservices/validate | check user exists in Aos
[**getAzureAdUserPropertyValue**](UsersApi.md#getAzureAdUserPropertyValue) | **GET** /users/{username}/azuread/property | get user&#39;s property value by property name from azure ad
[**getUpsUserPropertyValue**](UsersApi.md#getUpsUserPropertyValue) | **GET** /users/{username}/userprofile/property | get user&#39;s property value by property name from user profile service
[**getUserBasicProperties**](UsersApi.md#getUserBasicProperties) | **GET** /users/me/properties | get my basic properties, City, Country, Office, Department, JobTitle,State
[**getUserBasicPropertyValue**](UsersApi.md#getUserBasicPropertyValue) | **GET** /users/me/property/{name} | get my basic property value, Department, Email, DisplayName, Manager
[**getUserPhoto**](UsersApi.md#getUserPhoto) | **GET** /users/{username}/photo | get user&#39;s photo
[**getUserRelationship**](UsersApi.md#getUserRelationship) | **GET** /users/{username}/relationship | get user relationship
[**getUsersFromSharePoint**](UsersApi.md#getUsersFromSharePoint) | **POST** /users/sharepoint/validate | get users from sharepoint
[**resolveUsers**](UsersApi.md#resolveUsers) | **GET** /users/resolve | resolve users
[**resolveUsersWithExternalSharingOption**](UsersApi.md#resolveUsersWithExternalSharingOption) | **GET** /users/resolve/{externalSharingOption} | resolve user including external users
[**searchUsers**](UsersApi.md#searchUsers) | **GET** /users/search | search users
[**searchUsersWithExternalSharingOption**](UsersApi.md#searchUsersWithExternalSharingOption) | **GET** /users/search/{externalSharingOption} | search user including external users
[**updateUserInfo**](UsersApi.md#updateUserInfo) | **POST** /users | 



## checkUserExistsInAOS

> Boolean checkUserExistsInAOS(name)

check user exists in Aos

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let name = "name_example"; // String | 
apiInstance.checkUserExistsInAOS(name, (error, data, response) => {
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
 **name** | **String**|  | 

### Return type

**Boolean**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getAzureAdUserPropertyValue

> StringModel getAzureAdUserPropertyValue(username, propertyName)

get user&#39;s property value by property name from azure ad

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let username = "username_example"; // String | 
let propertyName = "propertyName_example"; // String | 
apiInstance.getAzureAdUserPropertyValue(username, propertyName, (error, data, response) => {
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
 **username** | **String**|  | 
 **propertyName** | **String**|  | 

### Return type

[**StringModel**](StringModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getUpsUserPropertyValue

> StringModel getUpsUserPropertyValue(username, propertyName)

get user&#39;s property value by property name from user profile service

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let username = "username_example"; // String | 
let propertyName = "propertyName_example"; // String | 
apiInstance.getUpsUserPropertyValue(username, propertyName, (error, data, response) => {
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
 **username** | **String**|  | 
 **propertyName** | **String**|  | 

### Return type

[**StringModel**](StringModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getUserBasicProperties

> getUserBasicProperties()

get my basic properties, City, Country, Office, Department, JobTitle,State

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
apiInstance.getUserBasicProperties((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getUserBasicPropertyValue

> getUserBasicPropertyValue(name)

get my basic property value, Department, Email, DisplayName, Manager

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let name = "name_example"; // String | 
apiInstance.getUserBasicPropertyValue(name, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getUserPhoto

> getUserPhoto(username, opts)

get user&#39;s photo

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let username = "username_example"; // String | 
let opts = {
  'size': "'48x48'" // String | 
};
apiInstance.getUserPhoto(username, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **String**|  | 
 **size** | **String**|  | [optional] [default to &#39;48x48&#39;]

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getUserRelationship

> UserRelationShip getUserRelationship(username)

get user relationship

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let username = "username_example"; // String | 
apiInstance.getUserRelationship(username, (error, data, response) => {
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
 **username** | **String**|  | 

### Return type

[**UserRelationShip**](UserRelationShip.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getUsersFromSharePoint

> ApiUser getUsersFromSharePoint(opts)

get users from sharepoint

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let opts = {
  'username': "username_example", // String | 
  'requestBody': ["null"] // [String] | 
};
apiInstance.getUsersFromSharePoint(opts, (error, data, response) => {
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
 **username** | **String**|  | [optional] 
 **requestBody** | [**[String]**](String.md)|  | [optional] 

### Return type

[**ApiUser**](ApiUser.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## resolveUsers

> [ApiUser] resolveUsers(keyword, userType, sharingOptions, opts)

resolve users

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let keyword = "keyword_example"; // String | 
let userType = new CloudGovernanceApi.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
let sharingOptions = new CloudGovernanceApi.ExternalSharingOptions(); // ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3
let opts = {
  'siteUrlOrTenantId': "''" // String | 
};
apiInstance.resolveUsers(keyword, userType, sharingOptions, opts, (error, data, response) => {
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
 **keyword** | **String**|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **sharingOptions** | [**ExternalSharingOptions**](.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | 
 **siteUrlOrTenantId** | **String**|  | [optional] [default to &#39;&#39;]

### Return type

[**[ApiUser]**](ApiUser.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## resolveUsersWithExternalSharingOption

> [SharingEnabledUser] resolveUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType)

resolve user including external users

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let keyword = "keyword_example"; // String | 
let siteUrlOrTenantId = "siteUrlOrTenantId_example"; // String | 
let externalSharingOption = new CloudGovernanceApi.ExternalSharingOptions(); // ExternalSharingOptions | 
let userType = new CloudGovernanceApi.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
apiInstance.resolveUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType, (error, data, response) => {
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
 **keyword** | **String**|  | 
 **siteUrlOrTenantId** | **String**|  | 
 **externalSharingOption** | [**ExternalSharingOptions**](.md)|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 

### Return type

[**[SharingEnabledUser]**](SharingEnabledUser.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## searchUsers

> [ApiUser] searchUsers(keyword, userType, sharingOptions, opts)

search users

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let keyword = "keyword_example"; // String | 
let userType = new CloudGovernanceApi.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
let sharingOptions = new CloudGovernanceApi.ExternalSharingOptions(); // ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3
let opts = {
  'siteUrlOrTenantId': "''" // String | 
};
apiInstance.searchUsers(keyword, userType, sharingOptions, opts, (error, data, response) => {
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
 **keyword** | **String**|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **sharingOptions** | [**ExternalSharingOptions**](.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | 
 **siteUrlOrTenantId** | **String**|  | [optional] [default to &#39;&#39;]

### Return type

[**[ApiUser]**](ApiUser.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## searchUsersWithExternalSharingOption

> [SharingEnabledUser] searchUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType)

search user including external users

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let keyword = "keyword_example"; // String | 
let siteUrlOrTenantId = "siteUrlOrTenantId_example"; // String | 
let externalSharingOption = new CloudGovernanceApi.ExternalSharingOptions(); // ExternalSharingOptions | 
let userType = new CloudGovernanceApi.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
apiInstance.searchUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType, (error, data, response) => {
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
 **keyword** | **String**|  | 
 **siteUrlOrTenantId** | **String**|  | 
 **externalSharingOption** | [**ExternalSharingOptions**](.md)|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 

### Return type

[**[SharingEnabledUser]**](SharingEnabledUser.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## updateUserInfo

> updateUserInfo(opts)



### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.UsersApi();
let opts = {
  'apiUser': new CloudGovernanceApi.ApiUser() // ApiUser | 
};
apiInstance.updateUserInfo(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiUser** | [**ApiUser**](ApiUser.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined

