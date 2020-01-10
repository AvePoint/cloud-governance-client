# CgClient.SettingsApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**editMyPersonalSettings**](SettingsApi.md#editMyPersonalSettings) | **PUT** /settings/my | edit my personal settings
[**getApplicationSettings**](SettingsApi.md#getApplicationSettings) | **GET** /settings/app | get application settings
[**getDynamicMembershipRuleItems**](SettingsApi.md#getDynamicMembershipRuleItems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
[**getHelpLink**](SettingsApi.md#getHelpLink) | **GET** /settings/helplink | get help link
[**getMyPersonalSettings**](SettingsApi.md#getMyPersonalSettings) | **GET** /settings/my | get my personal settings
[**getNews**](SettingsApi.md#getNews) | **GET** /settings/news | get news
[**getPermissionLevels**](SettingsApi.md#getPermissionLevels) | **GET** /settings/office365/permissionlevels | get permission levels
[**getSupportedLanguages**](SettingsApi.md#getSupportedLanguages) | **GET** /settings/languages | get supported language
[**getTimeZones**](SettingsApi.md#getTimeZones) | **GET** /settings/timezones | get timezones



## editMyPersonalSettings

> editMyPersonalSettings(opts)

edit my personal settings

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


var apiInstance = new CgClient.SettingsApi();
var opts = {
  'personalSettings': new CgClient.PersonalSettings() // PersonalSettings | 
};
apiInstance.editMyPersonalSettings(opts).then(function() {
  console.log('API called successfully.');
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personalSettings** | [**PersonalSettings**](PersonalSettings.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## getApplicationSettings

> ApplicationSettings getApplicationSettings(opts)

get application settings

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


var apiInstance = new CgClient.SettingsApi();
var opts = {
  'localeId': 56 // Number | 
};
apiInstance.getApplicationSettings(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **localeId** | **Number**|  | [optional] 

### Return type

[**ApplicationSettings**](ApplicationSettings.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getDynamicMembershipRuleItems

> InlineResponse200 getDynamicMembershipRuleItems(tenantid)

get group/teams dynamic membership rules

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


var apiInstance = new CgClient.SettingsApi();
var tenantid = null; // String | 
apiInstance.getDynamicMembershipRuleItems(tenantid).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantid** | [**String**](.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getHelpLink

> CustomHelpLinkModel getHelpLink()

get help link

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


var apiInstance = new CgClient.SettingsApi();
apiInstance.getHelpLink().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**CustomHelpLinkModel**](CustomHelpLinkModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyPersonalSettings

> PersonalSettings getMyPersonalSettings()

get my personal settings

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


var apiInstance = new CgClient.SettingsApi();
apiInstance.getMyPersonalSettings().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**PersonalSettings**](PersonalSettings.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getNews

> NewsAndUpdatesModel getNews()

get news

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


var apiInstance = new CgClient.SettingsApi();
apiInstance.getNews().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**NewsAndUpdatesModel**](NewsAndUpdatesModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getPermissionLevels

> [PermissionLevel] getPermissionLevels()

get permission levels

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


var apiInstance = new CgClient.SettingsApi();
apiInstance.getPermissionLevels().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[PermissionLevel]**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSupportedLanguages

> [ResourceValue] getSupportedLanguages()

get supported language

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


var apiInstance = new CgClient.SettingsApi();
apiInstance.getSupportedLanguages().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[ResourceValue]**](ResourceValue.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getTimeZones

> [ResourceValue] getTimeZones()

get timezones

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


var apiInstance = new CgClient.SettingsApi();
apiInstance.getTimeZones().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[ResourceValue]**](ResourceValue.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

