# CgClient.UsersApi

All URIs are relative to *https://API_BASE_URL*

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


var apiInstance = new CgClient.UsersApi();
var name = "name_example"; // String | 
apiInstance.checkUserExistsInAOS(name).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**|  | 

### Return type

**Boolean**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getAzureAdUserPropertyValue

> StringModel getAzureAdUserPropertyValue(username, propertyName)

get user&#39;s property value by property name from azure ad

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


var apiInstance = new CgClient.UsersApi();
var username = "username_example"; // String | 
var propertyName = "propertyName_example"; // String | 
apiInstance.getAzureAdUserPropertyValue(username, propertyName).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getUpsUserPropertyValue

> StringModel getUpsUserPropertyValue(username, propertyName)

get user&#39;s property value by property name from user profile service

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


var apiInstance = new CgClient.UsersApi();
var username = "username_example"; // String | 
var propertyName = "propertyName_example"; // String | 
apiInstance.getUpsUserPropertyValue(username, propertyName).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getUserBasicProperties

> getUserBasicProperties()

get my basic properties, City, Country, Office, Department, JobTitle,State

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


var apiInstance = new CgClient.UsersApi();
apiInstance.getUserBasicProperties().then(function() {
  console.log('API called successfully.');
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getUserBasicPropertyValue

> getUserBasicPropertyValue(name)

get my basic property value, Department, Email, DisplayName, Manager

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


var apiInstance = new CgClient.UsersApi();
var name = "name_example"; // String | 
apiInstance.getUserBasicPropertyValue(name).then(function() {
  console.log('API called successfully.');
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**|  | 

### Return type

null (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getUserPhoto

> getUserPhoto(username, opts)

get user&#39;s photo

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


var apiInstance = new CgClient.UsersApi();
var username = "username_example"; // String | 
var opts = {
  'size': "'48x48'" // String | 
};
apiInstance.getUserPhoto(username, opts).then(function() {
  console.log('API called successfully.');
}, function(error) {
  console.error(error);
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getUserRelationship

> UserRelationShip getUserRelationship(username)

get user relationship

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


var apiInstance = new CgClient.UsersApi();
var username = "username_example"; // String | 
apiInstance.getUserRelationship(username).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **String**|  | 

### Return type

[**UserRelationShip**](UserRelationShip.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getUsersFromSharePoint

> ApiUser getUsersFromSharePoint(opts)

get users from sharepoint

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


var apiInstance = new CgClient.UsersApi();
var opts = {
  'username': "username_example", // String | 
  'requestBody': ["null"] // [String] | 
};
apiInstance.getUsersFromSharePoint(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
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

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## resolveUsers

> [ApiUser] resolveUsers(keyword, userType, userSource, sharingOptions, opts)

resolve users

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


var apiInstance = new CgClient.UsersApi();
var keyword = "keyword_example"; // String | 
var userType = new CgClient.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
var userSource = new CgClient.UserSource(); // UserSource | All=0, Local=1, Azure=2, SharePoint=3
var sharingOptions = new CgClient.ExternalSharingOptions(); // ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3
var opts = {
  'siteUrlOrTenantId': "''" // String | 
};
apiInstance.resolveUsers(keyword, userType, userSource, sharingOptions, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | **String**|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **userSource** | [**UserSource**](.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | 
 **sharingOptions** | [**ExternalSharingOptions**](.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | 
 **siteUrlOrTenantId** | **String**|  | [optional] [default to &#39;&#39;]

### Return type

[**[ApiUser]**](ApiUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## resolveUsersWithExternalSharingOption

> [SharingEnabledUser] resolveUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType, userSource)

resolve user including external users

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


var apiInstance = new CgClient.UsersApi();
var keyword = "keyword_example"; // String | 
var siteUrlOrTenantId = "siteUrlOrTenantId_example"; // String | 
var externalSharingOption = new CgClient.ExternalSharingOptions(); // ExternalSharingOptions | 
var userType = new CgClient.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
var userSource = new CgClient.UserSource(); // UserSource | All=0, Local=1, Azure=2, SharePoint=3
apiInstance.resolveUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType, userSource).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | **String**|  | 
 **siteUrlOrTenantId** | **String**|  | 
 **externalSharingOption** | [**ExternalSharingOptions**](.md)|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **userSource** | [**UserSource**](.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | 

### Return type

[**[SharingEnabledUser]**](SharingEnabledUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## searchUsers

> [ApiUser] searchUsers(keyword, userType, userSource, sharingOptions, opts)

search users

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


var apiInstance = new CgClient.UsersApi();
var keyword = "keyword_example"; // String | 
var userType = new CgClient.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
var userSource = new CgClient.UserSource(); // UserSource | All=0, Local=1, Azure=2, SharePoint=3
var sharingOptions = new CgClient.ExternalSharingOptions(); // ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3
var opts = {
  'siteUrlOrTenantId': "''" // String | 
};
apiInstance.searchUsers(keyword, userType, userSource, sharingOptions, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | **String**|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **userSource** | [**UserSource**](.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | 
 **sharingOptions** | [**ExternalSharingOptions**](.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | 
 **siteUrlOrTenantId** | **String**|  | [optional] [default to &#39;&#39;]

### Return type

[**[ApiUser]**](ApiUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## searchUsersWithExternalSharingOption

> [SharingEnabledUser] searchUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType, userSource)

search user including external users

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


var apiInstance = new CgClient.UsersApi();
var keyword = "keyword_example"; // String | 
var siteUrlOrTenantId = "siteUrlOrTenantId_example"; // String | 
var externalSharingOption = new CgClient.ExternalSharingOptions(); // ExternalSharingOptions | 
var userType = new CgClient.UserType(); // UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4
var userSource = new CgClient.UserSource(); // UserSource | All=0, Local=1, Azure=2, SharePoint=3
apiInstance.searchUsersWithExternalSharingOption(keyword, siteUrlOrTenantId, externalSharingOption, userType, userSource).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | **String**|  | 
 **siteUrlOrTenantId** | **String**|  | 
 **externalSharingOption** | [**ExternalSharingOptions**](.md)|  | 
 **userType** | [**UserType**](.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | 
 **userSource** | [**UserSource**](.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | 

### Return type

[**[SharingEnabledUser]**](SharingEnabledUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## updateUserInfo

> updateUserInfo(opts)



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


var apiInstance = new CgClient.UsersApi();
var opts = {
  'updatableApiUser': new CgClient.UpdatableApiUser() // UpdatableApiUser | 
};
apiInstance.updateUserInfo(opts).then(function() {
  console.log('API called successfully.');
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updatableApiUser** | [**UpdatableApiUser**](UpdatableApiUser.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined

