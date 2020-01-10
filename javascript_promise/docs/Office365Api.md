# CgClient.Office365Api

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getGroupInfo**](Office365Api.md#getGroupInfo) | **GET** /office365/groups/{tenantid}/{id} | get group information
[**getGroupMembers**](Office365Api.md#getGroupMembers) | **GET** /office365/groups/{email}/members | get group members by group email
[**getGroupMembersByGroupName**](Office365Api.md#getGroupMembersByGroupName) | **GET** /office365/groups/members | get group members by group name
[**getGroupOwners**](Office365Api.md#getGroupOwners) | **GET** /office365/groups/{email}/owners | get group owners by group email
[**getHubSites**](Office365Api.md#getHubSites) | **GET** /office365/hubsites/{tenantid} | get all hubsites from a specific tenant
[**getHubSitesFromTenantOfSite**](Office365Api.md#getHubSitesFromTenantOfSite) | **GET** /office365/hubsites | get all hubsites from site&#39;s tenant
[**getOwnedTeams**](Office365Api.md#getOwnedTeams) | **GET** /office365/teams/my | get all teams that owner is curernt user
[**getPermissions**](Office365Api.md#getPermissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
[**getRoleAssignment**](Office365Api.md#getRoleAssignment) | **GET** /office365/roleassignment | get site permimssion role assignment
[**getSiteDesigns**](Office365Api.md#getSiteDesigns) | **GET** /office365/sitedesigns | get site designs by site url
[**getSiteInfo**](Office365Api.md#getSiteInfo) | **GET** /office365/sites | get site collection information with url
[**getSitePermissionLevels**](Office365Api.md#getSitePermissionLevels) | **GET** /office365/sites/permissionlevels | get site permission levels
[**getSiteSharePointGroups**](Office365Api.md#getSiteSharePointGroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
[**getSiteTemplates**](Office365Api.md#getSiteTemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
[**getYammerGroup**](Office365Api.md#getYammerGroup) | **GET** /office365/yammergroup/{networkid}/{name} | get yammer group
[**loadContainers**](Office365Api.md#loadContainers) | **GET** /office365/containers/{serviceid} | load the containers from cloud management
[**loadFolders**](Office365Api.md#loadFolders) | **GET** /office365/folders/{listid} | load sharepoint folders
[**loadItems**](Office365Api.md#loadItems) | **GET** /office365/items/{listid} | load sharepoint items
[**loadLists**](Office365Api.md#loadLists) | **GET** /office365/lists | load sharepoint lists
[**loadManagedMetadata**](Office365Api.md#loadManagedMetadata) | **GET** /office365/managedmetadata/{termStoreid}/{groupid}/{termsetid}/{parentid} | load managed metadata terms
[**loadManagedSites**](Office365Api.md#loadManagedSites) | **GET** /office365/managedsites/{serviceid}/{containerid}/{isselected} | load sharepoint sites
[**loadWebs**](Office365Api.md#loadWebs) | **GET** /office365/webs/{serviceid}/{siteorwebid}/{isselected}/{issite} | load sharepoint webs



## getGroupInfo

> AzureADGroup getGroupInfo(tenantid, id)

get group information

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


var apiInstance = new CgClient.Office365Api();
var tenantid = "tenantid_example"; // String | 
var id = "id_example"; // String | 
apiInstance.getGroupInfo(tenantid, id).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantid** | **String**|  | 
 **id** | **String**|  | 

### Return type

[**AzureADGroup**](AzureADGroup.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembers

> ApiUserPageResult getGroupMembers(email, opts)

get group members by group email

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


var apiInstance = new CgClient.Office365Api();
var email = "email_example"; // String | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.getGroupMembers(email, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembersByGroupName

> ApiUserPageResult getGroupMembersByGroupName(url, opts)

get group members by group name

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


var apiInstance = new CgClient.Office365Api();
var url = "url_example"; // String | 
var opts = {
  'name': "name_example", // String | 
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.getGroupMembersByGroupName(url, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **String**|  | 
 **name** | **String**|  | [optional] 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupOwners

> ApiUserPageResult getGroupOwners(email, opts)

get group owners by group email

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


var apiInstance = new CgClient.Office365Api();
var email = "email_example"; // String | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.getGroupOwners(email, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getHubSites

> [GuidModel] getHubSites(tenantid)

get all hubsites from a specific tenant

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


var apiInstance = new CgClient.Office365Api();
var tenantid = null; // String | 
apiInstance.getHubSites(tenantid).then(function(data) {
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

[**[GuidModel]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getHubSitesFromTenantOfSite

> [GuidModel] getHubSitesFromTenantOfSite(opts)

get all hubsites from site&#39;s tenant

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


var apiInstance = new CgClient.Office365Api();
var opts = {
  'siteUrl': "siteUrl_example" // String | any site url in your tenant
};
apiInstance.getHubSitesFromTenantOfSite(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **siteUrl** | **String**| any site url in your tenant | [optional] 

### Return type

[**[GuidModel]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getOwnedTeams

> [GuidModel] getOwnedTeams()

get all teams that owner is curernt user

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


var apiInstance = new CgClient.Office365Api();
apiInstance.getOwnedTeams().then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[GuidModel]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getPermissions

> UserGroupPermissions getPermissions(webUrl)

get web permissions for creating list request by web url

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


var apiInstance = new CgClient.Office365Api();
var webUrl = "webUrl_example"; // String | 
apiInstance.getPermissions(webUrl).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webUrl** | **String**|  | 

### Return type

[**UserGroupPermissions**](UserGroupPermissions.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getRoleAssignment

> [SPRoleAssignment] getRoleAssignment(url, type)

get site permimssion role assignment

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


var apiInstance = new CgClient.Office365Api();
var url = "url_example"; // String | 
var type = new CgClient.NodeType(); // NodeType | 
apiInstance.getRoleAssignment(url, type).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **String**|  | 
 **type** | [**NodeType**](.md)|  | 

### Return type

[**[SPRoleAssignment]**](SPRoleAssignment.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteDesigns

> [StringModel] getSiteDesigns(opts)

get site designs by site url

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


var apiInstance = new CgClient.Office365Api();
var opts = {
  'siteUrl': "siteUrl_example" // String | 
};
apiInstance.getSiteDesigns(opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **siteUrl** | **String**|  | [optional] 

### Return type

[**[StringModel]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteInfo

> SiteInfo getSiteInfo(fullUrl)

get site collection information with url

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


var apiInstance = new CgClient.Office365Api();
var fullUrl = "fullUrl_example"; // String | 
apiInstance.getSiteInfo(fullUrl).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fullUrl** | **String**|  | 

### Return type

[**SiteInfo**](SiteInfo.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePermissionLevels

> [PermissionLevel] getSitePermissionLevels(uri)

get site permission levels

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


var apiInstance = new CgClient.Office365Api();
var uri = "uri_example"; // String | 
apiInstance.getSitePermissionLevels(uri).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uri** | **String**|  | 

### Return type

[**[PermissionLevel]**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteSharePointGroups

> [SPGroup] getSiteSharePointGroups(uri)

get site sharePoint groups

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


var apiInstance = new CgClient.Office365Api();
var uri = "uri_example"; // String | 
apiInstance.getSiteSharePointGroups(uri).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uri** | **String**|  | 

### Return type

[**[SPGroup]**](SPGroup.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteTemplates

> [SiteTemplate] getSiteTemplates(languageid, opts)

get site templates with language code identifier

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


var apiInstance = new CgClient.Office365Api();
var languageid = 56; // Number | 
var opts = {
  'url': "url_example" // String | 
};
apiInstance.getSiteTemplates(languageid, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **languageid** | **Number**|  | 
 **url** | **String**|  | [optional] 

### Return type

[**[SiteTemplate]**](SiteTemplate.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getYammerGroup

> YammerGroup getYammerGroup(networkid, name)

get yammer group

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


var apiInstance = new CgClient.Office365Api();
var networkid = "networkid_example"; // String | 
var name = "name_example"; // String | 
apiInstance.getYammerGroup(networkid, name).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **networkid** | **String**|  | 
 **name** | **String**|  | 

### Return type

[**YammerGroup**](YammerGroup.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadContainers

> SPNodePageResult loadContainers(serviceid, opts)

load the containers from cloud management

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


var apiInstance = new CgClient.Office365Api();
var serviceid = "serviceid_example"; // String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadContainers(serviceid, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadFolders

> SPNodePageResult loadFolders(listid, folderorlisturl, opts)

load sharepoint folders

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


var apiInstance = new CgClient.Office365Api();
var listid = null; // String | 
var folderorlisturl = "folderorlisturl_example"; // String | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadFolders(listid, folderorlisturl, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listid** | [**String**](.md)|  | 
 **folderorlisturl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadItems

> SPNodePageResult loadItems(listid, folderorlisturl, opts)

load sharepoint items

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


var apiInstance = new CgClient.Office365Api();
var listid = null; // String | 
var folderorlisturl = "folderorlisturl_example"; // String | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadItems(listid, folderorlisturl, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listid** | [**String**](.md)|  | 
 **folderorlisturl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadLists

> SPNodePageResult loadLists(siteorweburl, opts)

load sharepoint lists

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


var apiInstance = new CgClient.Office365Api();
var siteorweburl = "siteorweburl_example"; // String | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadLists(siteorweburl, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **siteorweburl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadManagedMetadata

> ApiTermInfoPageResult loadManagedMetadata(termStoreid, groupid, termsetid, parentid, admincenterurl, opts)

load managed metadata terms

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


var apiInstance = new CgClient.Office365Api();
var termStoreid = null; // String | 
var groupid = null; // String | 
var termsetid = null; // String | 
var parentid = null; // String | 
var admincenterurl = "admincenterurl_example"; // String | 
var opts = {
  'skip': 56, // Number | 
  'top': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadManagedMetadata(termStoreid, groupid, termsetid, parentid, admincenterurl, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **termStoreid** | [**String**](.md)|  | 
 **groupid** | [**String**](.md)|  | 
 **termsetid** | [**String**](.md)|  | 
 **parentid** | [**String**](.md)|  | 
 **admincenterurl** | **String**|  | 
 **skip** | **Number**|  | [optional] 
 **top** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiTermInfoPageResult**](ApiTermInfoPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadManagedSites

> SPNodePageResult loadManagedSites(serviceid, containerid, isselected, opts)

load sharepoint sites

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


var apiInstance = new CgClient.Office365Api();
var serviceid = "serviceid_example"; // String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
var containerid = null; // String | 
var isselected = true; // Boolean | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadManagedSites(serviceid, containerid, isselected, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **containerid** | [**String**](.md)|  | 
 **isselected** | **Boolean**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadWebs

> SPNodePageResult loadWebs(serviceid, siteorwebid, isselected, issite, siteOrWebUrl, opts)

load sharepoint webs

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


var apiInstance = new CgClient.Office365Api();
var serviceid = "serviceid_example"; // String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
var siteorwebid = null; // String | 
var isselected = true; // Boolean | 
var issite = true; // Boolean | 
var siteOrWebUrl = "siteOrWebUrl_example"; // String | 
var opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadWebs(serviceid, siteorwebid, isselected, issite, siteOrWebUrl, opts).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});

```

### Parameters



Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **siteorwebid** | [**String**](.md)|  | 
 **isselected** | **Boolean**|  | 
 **issite** | **Boolean**|  | 
 **siteOrWebUrl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

