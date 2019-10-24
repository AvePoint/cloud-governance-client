# CloudGovernanceApi.Office365Api

All URIs are relative to *https://cg-api.avepointlabs.com*

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
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let tenantid = "tenantid_example"; // String | 
let id = "id_example"; // String | 
apiInstance.getGroupInfo(tenantid, id, (error, data, response) => {
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
 **tenantid** | **String**|  | 
 **id** | **String**|  | 

### Return type

[**AzureADGroup**](AzureADGroup.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembers

> ApiUserPageResult getGroupMembers(email, opts)

get group members by group email

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let email = "email_example"; // String | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.getGroupMembers(email, opts, (error, data, response) => {
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
 **email** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembersByGroupName

> ApiUserPageResult getGroupMembersByGroupName(url, opts)

get group members by group name

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let url = "url_example"; // String | 
let opts = {
  'name': "name_example", // String | 
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.getGroupMembersByGroupName(url, opts, (error, data, response) => {
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
 **url** | **String**|  | 
 **name** | **String**|  | [optional] 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupOwners

> ApiUserPageResult getGroupOwners(email, opts)

get group owners by group email

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let email = "email_example"; // String | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.getGroupOwners(email, opts, (error, data, response) => {
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
 **email** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getHubSites

> [GuidModel] getHubSites(tenantid)

get all hubsites from a specific tenant

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let tenantid = null; // String | 
apiInstance.getHubSites(tenantid, (error, data, response) => {
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
 **tenantid** | [**String**](.md)|  | 

### Return type

[**[GuidModel]**](GuidModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getHubSitesFromTenantOfSite

> [GuidModel] getHubSitesFromTenantOfSite(opts)

get all hubsites from site&#39;s tenant

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let opts = {
  'siteUrl': "siteUrl_example" // String | any site url in your tenant
};
apiInstance.getHubSitesFromTenantOfSite(opts, (error, data, response) => {
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
 **siteUrl** | **String**| any site url in your tenant | [optional] 

### Return type

[**[GuidModel]**](GuidModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getOwnedTeams

> [GuidModel] getOwnedTeams()

get all teams that owner is curernt user

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
apiInstance.getOwnedTeams((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**[GuidModel]**](GuidModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getPermissions

> UserGroupPermissions getPermissions(webUrl)

get web permissions for creating list request by web url

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let webUrl = "webUrl_example"; // String | 
apiInstance.getPermissions(webUrl, (error, data, response) => {
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
 **webUrl** | **String**|  | 

### Return type

[**UserGroupPermissions**](UserGroupPermissions.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getRoleAssignment

> [SPRoleAssignment] getRoleAssignment(url, type)

get site permimssion role assignment

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let url = "url_example"; // String | 
let type = new CloudGovernanceApi.NodeType(); // NodeType | 
apiInstance.getRoleAssignment(url, type, (error, data, response) => {
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
 **url** | **String**|  | 
 **type** | [**NodeType**](.md)|  | 

### Return type

[**[SPRoleAssignment]**](SPRoleAssignment.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteDesigns

> [StringModel] getSiteDesigns(opts)

get site designs by site url

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let opts = {
  'siteUrl': "siteUrl_example" // String | 
};
apiInstance.getSiteDesigns(opts, (error, data, response) => {
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
 **siteUrl** | **String**|  | [optional] 

### Return type

[**[StringModel]**](StringModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteInfo

> SiteInfo getSiteInfo(fullUrl)

get site collection information with url

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let fullUrl = "fullUrl_example"; // String | 
apiInstance.getSiteInfo(fullUrl, (error, data, response) => {
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
 **fullUrl** | **String**|  | 

### Return type

[**SiteInfo**](SiteInfo.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePermissionLevels

> [PermissionLevel] getSitePermissionLevels(uri)

get site permission levels

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let uri = "uri_example"; // String | 
apiInstance.getSitePermissionLevels(uri, (error, data, response) => {
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
 **uri** | **String**|  | 

### Return type

[**[PermissionLevel]**](PermissionLevel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteSharePointGroups

> [SPGroup] getSiteSharePointGroups(uri)

get site sharePoint groups

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let uri = "uri_example"; // String | 
apiInstance.getSiteSharePointGroups(uri, (error, data, response) => {
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
 **uri** | **String**|  | 

### Return type

[**[SPGroup]**](SPGroup.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteTemplates

> [SiteTemplate] getSiteTemplates(languageid, opts)

get site templates with language code identifier

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let languageid = 56; // Number | 
let opts = {
  'url': "url_example" // String | 
};
apiInstance.getSiteTemplates(languageid, opts, (error, data, response) => {
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
 **languageid** | **Number**|  | 
 **url** | **String**|  | [optional] 

### Return type

[**[SiteTemplate]**](SiteTemplate.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getYammerGroup

> YammerGroup getYammerGroup(networkid, name)

get yammer group

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let networkid = "networkid_example"; // String | 
let name = "name_example"; // String | 
apiInstance.getYammerGroup(networkid, name, (error, data, response) => {
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
 **networkid** | **String**|  | 
 **name** | **String**|  | 

### Return type

[**YammerGroup**](YammerGroup.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadContainers

> SPNodePageResult loadContainers(serviceid, opts)

load the containers from cloud management

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let serviceid = "serviceid_example"; // String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadContainers(serviceid, opts, (error, data, response) => {
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
 **serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadFolders

> SPNodePageResult loadFolders(listid, folderorlisturl, opts)

load sharepoint folders

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let listid = null; // String | 
let folderorlisturl = "folderorlisturl_example"; // String | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadFolders(listid, folderorlisturl, opts, (error, data, response) => {
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
 **listid** | [**String**](.md)|  | 
 **folderorlisturl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadItems

> SPNodePageResult loadItems(listid, folderorlisturl, opts)

load sharepoint items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let listid = null; // String | 
let folderorlisturl = "folderorlisturl_example"; // String | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadItems(listid, folderorlisturl, opts, (error, data, response) => {
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
 **listid** | [**String**](.md)|  | 
 **folderorlisturl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadLists

> SPNodePageResult loadLists(siteorweburl, opts)

load sharepoint lists

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let siteorweburl = "siteorweburl_example"; // String | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadLists(siteorweburl, opts, (error, data, response) => {
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
 **siteorweburl** | **String**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadManagedMetadata

> ApiTermInfoPageResult loadManagedMetadata(termStoreid, groupid, termsetid, parentid, admincenterurl, opts)

load managed metadata terms

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let termStoreid = null; // String | 
let groupid = null; // String | 
let termsetid = null; // String | 
let parentid = null; // String | 
let admincenterurl = "admincenterurl_example"; // String | 
let opts = {
  'skip': 56, // Number | 
  'top': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadManagedMetadata(termStoreid, groupid, termsetid, parentid, admincenterurl, opts, (error, data, response) => {
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

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadManagedSites

> SPNodePageResult loadManagedSites(serviceid, containerid, isselected, opts)

load sharepoint sites

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let serviceid = "serviceid_example"; // String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
let containerid = null; // String | 
let isselected = true; // Boolean | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadManagedSites(serviceid, containerid, isselected, opts, (error, data, response) => {
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
 **serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **containerid** | [**String**](.md)|  | 
 **isselected** | **Boolean**|  | 
 **top** | **Number**|  | [optional] 
 **skip** | **Number**|  | [optional] 
 **search** | **String**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## loadWebs

> SPNodePageResult loadWebs(serviceid, siteorwebid, isselected, issite, siteOrWebUrl, opts)

load sharepoint webs

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.Office365Api();
let serviceid = "serviceid_example"; // String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
let siteorwebid = null; // String | 
let isselected = true; // Boolean | 
let issite = true; // Boolean | 
let siteOrWebUrl = "siteOrWebUrl_example"; // String | 
let opts = {
  'top': 56, // Number | 
  'skip': 56, // Number | 
  'search': "search_example" // String | 
};
apiInstance.loadWebs(serviceid, siteorwebid, isselected, issite, siteOrWebUrl, opts, (error, data, response) => {
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

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

