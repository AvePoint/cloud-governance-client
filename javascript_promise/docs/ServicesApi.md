# CgClient.ServicesApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addCreateListService**](ServicesApi.md#addCreateListService) | **POST** /services/createsite | Add create site service
[**getChangeGroupSettingService**](ServicesApi.md#getChangeGroupSettingService) | **GET** /services/changegroupsetting/{id} | get change group setting service
[**getChangeListSettingService**](ServicesApi.md#getChangeListSettingService) | **GET** /services/changelistsetting/{id} | get change list setting service
[**getChangePermissionService**](ServicesApi.md#getChangePermissionService) | **GET** /services/changepermission/{id} | get change permission service
[**getChangeSiteContactService**](ServicesApi.md#getChangeSiteContactService) | **GET** /services/changesitecontact/{id} | get change site contact service
[**getChangeSiteSettingService**](ServicesApi.md#getChangeSiteSettingService) | **GET** /services/changesitesetting/{id} | get change site setting service
[**getChangeWebContactService**](ServicesApi.md#getChangeWebContactService) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
[**getChangeWebSettingsService**](ServicesApi.md#getChangeWebSettingsService) | **GET** /services/changewebsettings/{id} | get change web setting service
[**getClonePermissionService**](ServicesApi.md#getClonePermissionService) | **GET** /services/clonepermission/{id} | get clone permission service
[**getContentMoveProfiles**](ServicesApi.md#getContentMoveProfiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
[**getContentMoveService**](ServicesApi.md#getContentMoveService) | **GET** /services/contentmove/{id} | get content move service
[**getCreateGroupService**](ServicesApi.md#getCreateGroupService) | **GET** /services/creategroup/{id} | get create group service
[**getCreateListService**](ServicesApi.md#getCreateListService) | **GET** /services/createlist/{id} | get create list service
[**getCreateSiteService**](ServicesApi.md#getCreateSiteService) | **GET** /services/createsite/{id} | get create site service
[**getCreateWebService**](ServicesApi.md#getCreateWebService) | **GET** /services/createweb/{id} | get create web service
[**getCustomService**](ServicesApi.md#getCustomService) | **GET** /services/custom/{id} | get custom service
[**getGrantPermissionService**](ServicesApi.md#getGrantPermissionService) | **GET** /services/grantpermission/{id} | get grant permission service
[**getGroupLifecycleService**](ServicesApi.md#getGroupLifecycleService) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
[**getGroupPolicyExpirationSetting**](ServicesApi.md#getGroupPolicyExpirationSetting) | **GET** /services/grouplifecycle/{id}/policyexpirationsetting | get the group policy expiration setting
[**getManagePermissionService**](ServicesApi.md#getManagePermissionService) | **GET** /services/managepermission/{id} | get manage permission service
[**getMyQuickServices**](ServicesApi.md#getMyQuickServices) | **GET** /services/my/quick | get configued quick services that can be used to start a request
[**getMyServices**](ServicesApi.md#getMyServices) | **GET** /services/my | get services that can be used to start a request
[**getMyServicesWithContext**](ServicesApi.md#getMyServicesWithContext) | **GET** /services/my/workspace/{objecttype}/{objectid} | get services that can be used to start a request within context
[**getSiteLifecycleService**](ServicesApi.md#getSiteLifecycleService) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
[**getSitePolicyExpirationSetting**](ServicesApi.md#getSitePolicyExpirationSetting) | **GET** /services/sitelifecycle/{id}/policyexpirationsetting | get the site collection policy expiration setting
[**getWebLifecycleService**](ServicesApi.md#getWebLifecycleService) | **GET** /services/weblifecycle/{id} | get web lifecycle service
[**validateForChangeGroupSettingService**](ServicesApi.md#validateForChangeGroupSettingService) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
[**validateForChangeListSettingService**](ServicesApi.md#validateForChangeListSettingService) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
[**validateForChangePermissionService**](ServicesApi.md#validateForChangePermissionService) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
[**validateForChangeSiteContactService**](ServicesApi.md#validateForChangeSiteContactService) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
[**validateForChangeSiteSettingService**](ServicesApi.md#validateForChangeSiteSettingService) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
[**validateForChangeWebContactService**](ServicesApi.md#validateForChangeWebContactService) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
[**validateForChangeWebSettingService**](ServicesApi.md#validateForChangeWebSettingService) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
[**validateForClonePermissionService**](ServicesApi.md#validateForClonePermissionService) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
[**validateForContentMoveService**](ServicesApi.md#validateForContentMoveService) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
[**validateForCreateListService**](ServicesApi.md#validateForCreateListService) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
[**validateForCreateWebService**](ServicesApi.md#validateForCreateWebService) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
[**validateForGrantPermissionService**](ServicesApi.md#validateForGrantPermissionService) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
[**validateForGroupLifecycleService**](ServicesApi.md#validateForGroupLifecycleService) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
[**validateForManagePermissionService**](ServicesApi.md#validateForManagePermissionService) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
[**validateForSiteLifecycleService**](ServicesApi.md#validateForSiteLifecycleService) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
[**validateForWebLifecycleService**](ServicesApi.md#validateForWebLifecycleService) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service



## addCreateListService

> String addCreateListService(opts)

Add create site service

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


var apiInstance = new CgClient.ServicesApi();
var opts = {
  'createSiteService': new CgClient.CreateSiteService() // CreateSiteService | 
};
apiInstance.addCreateListService(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSiteService** | [**CreateSiteService**](CreateSiteService.md)|  | [optional] 

### Return type

**String**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getChangeGroupSettingService

> ChangeGroupSettingService getChangeGroupSettingService(id, opts)

get change group setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangeGroupSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangeGroupSettingService**](ChangeGroupSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getChangeListSettingService

> ChangeListSettingService getChangeListSettingService(id, opts)

get change list setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangeListSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangeListSettingService**](ChangeListSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getChangePermissionService

> ChangePermissionService getChangePermissionService(id, opts)

get change permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangePermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangePermissionService**](ChangePermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getChangeSiteContactService

> ChangeSiteContactService getChangeSiteContactService(id, opts)

get change site contact service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangeSiteContactService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangeSiteContactService**](ChangeSiteContactService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getChangeSiteSettingService

> ChangeSiteSettingService getChangeSiteSettingService(id, opts)

get change site setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangeSiteSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangeSiteSettingService**](ChangeSiteSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getChangeWebContactService

> ChangeWebContactService getChangeWebContactService(id, opts)

validate permissions, scope for change web contact service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangeWebContactService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangeWebContactService**](ChangeWebContactService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getChangeWebSettingsService

> ChangeWebSettingService getChangeWebSettingsService(id, opts)

get change web setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getChangeWebSettingsService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ChangeWebSettingService**](ChangeWebSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getClonePermissionService

> ClonePermissionService getClonePermissionService(id, opts)

get clone permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getClonePermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ClonePermissionService**](ClonePermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getContentMoveProfiles

> ContentMoveProfiles getContentMoveProfiles()

get content move profiles from cloud management

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


var apiInstance = new CgClient.ServicesApi();
apiInstance.getContentMoveProfiles().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ContentMoveProfiles**](ContentMoveProfiles.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getContentMoveService

> ContentMoveService getContentMoveService(id, opts)

get content move service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getContentMoveService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ContentMoveService**](ContentMoveService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getCreateGroupService

> CreateGroupService getCreateGroupService(id, opts)

get create group service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getCreateGroupService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**CreateGroupService**](CreateGroupService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getCreateListService

> CreateListService getCreateListService(id, opts)

get create list service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getCreateListService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**CreateListService**](CreateListService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getCreateSiteService

> CreateSiteService getCreateSiteService(id, opts)

get create site service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getCreateSiteService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**CreateSiteService**](CreateSiteService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getCreateWebService

> CreateWebService getCreateWebService(id, opts)

get create web service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getCreateWebService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**CreateWebService**](CreateWebService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getCustomService

> ServiceForRequest getCustomService(id, opts)

get custom service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getCustomService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ServiceForRequest**](ServiceForRequest.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGrantPermissionService

> GrantPermissionService getGrantPermissionService(id, opts)

get grant permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getGrantPermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**GrantPermissionService**](GrantPermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupLifecycleService

> GroupLifecycleService getGroupLifecycleService(id, opts)

get group lifecycle service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getGroupLifecycleService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**GroupLifecycleService**](GroupLifecycleService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPolicyExpirationSetting

> PolicyExpirationSettingModel getGroupPolicyExpirationSetting(id)

get the group policy expiration setting

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
apiInstance.getGroupPolicyExpirationSetting(id).then(function(data) {
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

[**PolicyExpirationSettingModel**](PolicyExpirationSettingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getManagePermissionService

> ManagePermissionService getManagePermissionService(id, opts)

get manage permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getManagePermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**ManagePermissionService**](ManagePermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyQuickServices

> [ServiceList] getMyQuickServices()

get configued quick services that can be used to start a request

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


var apiInstance = new CgClient.ServicesApi();
apiInstance.getMyQuickServices().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[ServiceList]**](ServiceList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyServices

> ServiceListPageResult getMyServices(opts)

get services that can be used to start a request

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


var apiInstance = new CgClient.ServicesApi();
var opts = {
  'search': "search_example" // String | 
};
apiInstance.getMyServices(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **String**|  | [optional] 

### Return type

[**ServiceListPageResult**](ServiceListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyServicesWithContext

> ServiceListPageResult getMyServicesWithContext(objecttype, objectid, opts)

get services that can be used to start a request within context

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


var apiInstance = new CgClient.ServicesApi();
var objecttype = new CgClient.WorkspaceType(); // WorkspaceType | 
var objectid = "objectid_example"; // String | 
var opts = {
  'search': "search_example" // String | 
};
apiInstance.getMyServicesWithContext(objecttype, objectid, opts).then(function(data) {
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
 **search** | **String**|  | [optional] 

### Return type

[**ServiceListPageResult**](ServiceListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteLifecycleService

> SiteLifecycleService getSiteLifecycleService(id, opts)

get site lifecycle service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getSiteLifecycleService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**SiteLifecycleService**](SiteLifecycleService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePolicyExpirationSetting

> PolicyExpirationSettingModel getSitePolicyExpirationSetting(id)

get the site collection policy expiration setting

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
apiInstance.getSitePolicyExpirationSetting(id).then(function(data) {
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

[**PolicyExpirationSettingModel**](PolicyExpirationSettingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getWebLifecycleService

> WebLifecycleService getWebLifecycleService(id, opts)

get web lifecycle service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'questionnaireId': null // String | 
};
apiInstance.getWebLifecycleService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **questionnaireId** | [**String**](.md)|  | [optional] 

### Return type

[**WebLifecycleService**](WebLifecycleService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## validateForChangeGroupSettingService

> ChangeGroupSettingCheckResult validateForChangeGroupSettingService(id, opts)

validate permissions, scope for change group setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'changeGroupSettingValidationParameter': new CgClient.ChangeGroupSettingValidationParameter() // ChangeGroupSettingValidationParameter | 
};
apiInstance.validateForChangeGroupSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **changeGroupSettingValidationParameter** | [**ChangeGroupSettingValidationParameter**](ChangeGroupSettingValidationParameter.md)|  | [optional] 

### Return type

[**ChangeGroupSettingCheckResult**](ChangeGroupSettingCheckResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForChangeListSettingService

> ChangeListSettingValidateResult validateForChangeListSettingService(id, opts)

validate permissions, scope for change list setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForChangeListSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeListSettingValidateResult**](ChangeListSettingValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForChangePermissionService

> ChangePermissionValidateResult validateForChangePermissionService(id, opts)

validate permissions, scope for change permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForChangePermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangePermissionValidateResult**](ChangePermissionValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForChangeSiteContactService

> ChangeSiteContactValidateResult validateForChangeSiteContactService(id, opts)

validate permissions, scope for change site contact service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForChangeSiteContactService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeSiteContactValidateResult**](ChangeSiteContactValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForChangeSiteSettingService

> ChangeSiteSettingValidateResult validateForChangeSiteSettingService(id, opts)

validate permissions, scope for change site setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForChangeSiteSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeSiteSettingValidateResult**](ChangeSiteSettingValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForChangeWebContactService

> ChangeWebContactValidateResult validateForChangeWebContactService(id, opts)

validate permissions, scope for change web contact service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForChangeWebContactService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeWebContactValidateResult**](ChangeWebContactValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForChangeWebSettingService

> ChangeWebUrlValidateResult validateForChangeWebSettingService(id, opts)

validate permissions, scope for change web setting service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForChangeWebSettingService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeWebUrlValidateResult**](ChangeWebUrlValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForClonePermissionService

> ClonePermissionValidateResult validateForClonePermissionService(id, opts)

validate permissions, scope for clone permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForClonePermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ClonePermissionValidateResult**](ClonePermissionValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForContentMoveService

> ContentMoveUrlValidationResult validateForContentMoveService(id, opts)

validate permissions, scope for content move service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForContentMoveService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ContentMoveUrlValidationResult**](ContentMoveUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForCreateListService

> CreateListUrlValidationResult validateForCreateListService(id, opts)

validate permissions, scope for create list service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'listValidationParameter': new CgClient.ListValidationParameter() // ListValidationParameter | 
};
apiInstance.validateForCreateListService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **listValidationParameter** | [**ListValidationParameter**](ListValidationParameter.md)|  | [optional] 

### Return type

[**CreateListUrlValidationResult**](CreateListUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForCreateWebService

> CreateWebUrlValidationResult validateForCreateWebService(id, opts)

validate permissions, scope for create web service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'createWebValidationParameter': new CgClient.CreateWebValidationParameter() // CreateWebValidationParameter | 
};
apiInstance.validateForCreateWebService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **createWebValidationParameter** | [**CreateWebValidationParameter**](CreateWebValidationParameter.md)|  | [optional] 

### Return type

[**CreateWebUrlValidationResult**](CreateWebUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForGrantPermissionService

> GrantPermissionUrlValidationResult validateForGrantPermissionService(id, opts)

validate permissions, scope for grant permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForGrantPermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**GrantPermissionUrlValidationResult**](GrantPermissionUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForGroupLifecycleService

> GroupLifecycleValidateResult validateForGroupLifecycleService(id, opts)

validate permissions, scope for group lifecycle service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'groupValidationParameter': new CgClient.GroupValidationParameter() // GroupValidationParameter | 
};
apiInstance.validateForGroupLifecycleService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **groupValidationParameter** | [**GroupValidationParameter**](GroupValidationParameter.md)|  | [optional] 

### Return type

[**GroupLifecycleValidateResult**](GroupLifecycleValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForManagePermissionService

> ManagePermissionValidateResult validateForManagePermissionService(id, opts)

validate permissions, scope for manage permission service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForManagePermissionService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ManagePermissionValidateResult**](ManagePermissionValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForSiteLifecycleService

> SiteLifecycleValidateResult validateForSiteLifecycleService(id, opts)

validate permissions, scope for site lifecycle service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForSiteLifecycleService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**SiteLifecycleValidateResult**](SiteLifecycleValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## validateForWebLifecycleService

> WebLifecycleValidateResult validateForWebLifecycleService(id, opts)

validate permissions, scope for web lifecycle service

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


var apiInstance = new CgClient.ServicesApi();
var id = null; // String | 
var opts = {
  'siteValidationParameter': new CgClient.SiteValidationParameter() // SiteValidationParameter | 
};
apiInstance.validateForWebLifecycleService(id, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 
 **siteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**WebLifecycleValidateResult**](WebLifecycleValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

