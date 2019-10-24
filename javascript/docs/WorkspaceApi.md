# CloudGovernanceApi.WorkspaceApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**confirmGorup**](WorkspaceApi.md#confirmGorup) | **POST** /workspace/groups/{id}/confirm | confirm auto imported group/teams information
[**confirmGorupWithUnknowPrimaryContact**](WorkspaceApi.md#confirmGorupWithUnknowPrimaryContact) | **POST** /workspace/groups/{id}/confirm/assigntoadmincontact | confirm auto imported group/teams by assigning task to administrator
[**confirmGroupWithKnowningPrimaryContact**](WorkspaceApi.md#confirmGroupWithKnowningPrimaryContact) | **POST** /workspace/groups/{id}/confirm/changeprimarycontact | confirm auto imported group/teams by assigning task to the specified primary contact
[**confirmSite**](WorkspaceApi.md#confirmSite) | **POST** /workspace/sites/{id}/confirm | confirm auto imported site information
[**confirmSiteWitKnowingPrimaryContact**](WorkspaceApi.md#confirmSiteWitKnowingPrimaryContact) | **POST** /workspace/sites/{id}/confirm/changeprimarycontact | confirm auto imported site by assigning task to the specified primary contact
[**confirmSiteWithUnknowPrimaryContact**](WorkspaceApi.md#confirmSiteWithUnknowPrimaryContact) | **POST** /workspace/sites/{id}/confirm/assigntoadmincontact | confirm auto imported site by assigning task to administrator
[**getGroupAutoImportProfile**](WorkspaceApi.md#getGroupAutoImportProfile) | **GET** /workspace/groups/{id}/confirm/settings | get group/teams auto-imported profile information
[**getGroupContacts**](WorkspaceApi.md#getGroupContacts) | **GET** /workspace/groups/{id}/contacts | get group/teams contacts
[**getGroupMembershipRenewalItems**](WorkspaceApi.md#getGroupMembershipRenewalItems) | **GET** /workspace/groups/{id}/renew/membership | get group/teams membership renewal items
[**getGroupMetadataRenewalItems**](WorkspaceApi.md#getGroupMetadataRenewalItems) | **GET** /workspace/groups/{id}/renew/metadata | get group/teams metadata renewal items
[**getGroupPermissionRenewalFilters**](WorkspaceApi.md#getGroupPermissionRenewalFilters) | **GET** /workspace/groups/{id}/renew/permission/filters | get group/teams permission renewal report filters
[**getGroupPermissionRenewalFiltersForSPGroup**](WorkspaceApi.md#getGroupPermissionRenewalFiltersForSPGroup) | **GET** /workspace/groups/{id}/renew/permission/group/{groupid}/filters | get group/teams permission renewal sharePoint group report filters
[**getGroupPermissionRenewalItems**](WorkspaceApi.md#getGroupPermissionRenewalItems) | **GET** /workspace/groups/{id}/renew/permissions | get group/teams permission renewal items
[**getGroupPermissionRenewalItemsForSPGroup**](WorkspaceApi.md#getGroupPermissionRenewalItemsForSPGroup) | **GET** /workspace/groups/{id}/renew/permissions/group/{groupid} | get sharePoint group members of group/teams permission renewal item
[**getGroupPermissionRenewalPermissionLevels**](WorkspaceApi.md#getGroupPermissionRenewalPermissionLevels) | **GET** /workspace/groups/{id}/renew/permissionlevels | get group/teams permission level for permission renewal
[**getGroupRenewalProfileSettings**](WorkspaceApi.md#getGroupRenewalProfileSettings) | **GET** /workspace/groups/{id}/renew/settings | get group/teams renewal settings
[**getGroupSharingOptions**](WorkspaceApi.md#getGroupSharingOptions) | **GET** /workspace/groups/sharingoptions | get group sharing options
[**getMyGroupInformation**](WorkspaceApi.md#getMyGroupInformation) | **GET** /workspace/groups/{id} | get O365 group/teams information
[**getMySiteInformation**](WorkspaceApi.md#getMySiteInformation) | **GET** /workspace/sites/{id} | 
[**getSiteAutoImportProfile**](WorkspaceApi.md#getSiteAutoImportProfile) | **POST** /workspace/sites/{id}/confirm/settings | get site auto import settings
[**getSiteContacts**](WorkspaceApi.md#getSiteContacts) | **GET** /workspace/sites/{id}/contacts | get site contacts
[**getSiteMetadata**](WorkspaceApi.md#getSiteMetadata) | **GET** /workspace/sites/metadata | get site metadata
[**getSiteMetadataRenewalItems**](WorkspaceApi.md#getSiteMetadataRenewalItems) | **GET** /workspace/sites/{id}/renew/metadata | get site metadata renewal items
[**getSitePermissionRenewalFilters**](WorkspaceApi.md#getSitePermissionRenewalFilters) | **GET** /workspace/sites/{id}/renew/permission/filters | get site permission renewal report filters
[**getSitePermissionRenewalFiltersForSPGroup**](WorkspaceApi.md#getSitePermissionRenewalFiltersForSPGroup) | **GET** /workspace/sites/{id}/renew/permission/group/{groupid}/filters | get site permission renewal sharePoint group report filters
[**getSitePermissionRenewalItems**](WorkspaceApi.md#getSitePermissionRenewalItems) | **GET** /workspace/sites/{id}/renew/permissions | get site permission renewal items
[**getSitePermissionRenewalItemsForSPGroup**](WorkspaceApi.md#getSitePermissionRenewalItemsForSPGroup) | **GET** /workspace/sites/{id}/renew/permissions/group/{groupid} | get sharePoint group members of site permission renewal item
[**getSitePermissionRenewalPermissionLevels**](WorkspaceApi.md#getSitePermissionRenewalPermissionLevels) | **GET** /workspace/sites/{id}/renew/permissionlevels | get site permission level for permission renewal
[**getSiteRenewalProfileSettings**](WorkspaceApi.md#getSiteRenewalProfileSettings) | **GET** /workspace/sites/{id}/renew/settings | get site renewal settings
[**getSiteSharingOptions**](WorkspaceApi.md#getSiteSharingOptions) | **GET** /workspace/sites/sharingoptions | get site sharing options by site url or id
[**getWorkspaceFilters**](WorkspaceApi.md#getWorkspaceFilters) | **GET** /workspace/my/filters | get my workspace filters
[**getWorkspaceItems**](WorkspaceApi.md#getWorkspaceItems) | **GET** /workspace/my | get my workspace items
[**reassignGroupRenewalTask**](WorkspaceApi.md#reassignGroupRenewalTask) | **POST** /workspace/groups/{id}/renew/reassign | reassign the group/teams renewal task
[**reassignSiteRenewalTask**](WorkspaceApi.md#reassignSiteRenewalTask) | **POST** /workspace/sites/{id}/renew/reassign | reassign the site renewal task
[**rejectGroupRenewalTask**](WorkspaceApi.md#rejectGroupRenewalTask) | **POST** /workspace/groups/{id}/renew/reject | reject the group/teams renewal task
[**rejectSiteRenewalTask**](WorkspaceApi.md#rejectSiteRenewalTask) | **POST** /workspace/sites/{id}/renew/reject | reject the site renewal task
[**resetChangeForSiteRenewal**](WorkspaceApi.md#resetChangeForSiteRenewal) | **POST** /workspace/sites/{id}/renew/reset | reset your change
[**resetChangesForGroupRenewal**](WorkspaceApi.md#resetChangesForGroupRenewal) | **POST** /workspace/groups/{id}/renew/reset | reset your change
[**saveGroupPermissionRenewalItems**](WorkspaceApi.md#saveGroupPermissionRenewalItems) | **POST** /workspace/groups/{id}/renew/permissions | save group/teams permission renewal items
[**saveSitePermissionRenewalItems**](WorkspaceApi.md#saveSitePermissionRenewalItems) | **POST** /workspace/sites/{id}/renew/permissions | save site permission renewal items
[**submitGroupRenewalTask**](WorkspaceApi.md#submitGroupRenewalTask) | **POST** /workspace/groups/{id}/renew/submit | submit the group/teams renewal task
[**submitGroupRenewalTaskForArchiving**](WorkspaceApi.md#submitGroupRenewalTaskForArchiving) | **POST** /workspace/groups/{id}/renew/archive | submit group/teams renewal task with archive
[**submitGroupRenewalTaskForDeleting**](WorkspaceApi.md#submitGroupRenewalTaskForDeleting) | **POST** /workspace/groups/{id}/renew/delete | submit group/teams renewal task with deletion
[**submitSiteRenewalTask**](WorkspaceApi.md#submitSiteRenewalTask) | **POST** /workspace/sites/{id}/renew/submit | submit the site renewal task
[**submitSiteRenewalTaskForDeleting**](WorkspaceApi.md#submitSiteRenewalTaskForDeleting) | **POST** /workspace/sites/{id}/renew/delete | submit site renewal task with deletion
[**submitSiteRenewalTaskWithArchiving**](WorkspaceApi.md#submitSiteRenewalTaskWithArchiving) | **POST** /workspace/sites/{id}/renew/archive | approval site renewal task with archive



## confirmGorup

> confirmGorup(id, opts)

confirm auto imported group/teams information

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'confirmInformation': new CloudGovernanceApi.ConfirmInformation() // ConfirmInformation | 
};
apiInstance.confirmGorup(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **confirmInformation** | [**ConfirmInformation**](ConfirmInformation.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## confirmGorupWithUnknowPrimaryContact

> confirmGorupWithUnknowPrimaryContact(id)

confirm auto imported group/teams by assigning task to administrator

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.confirmGorupWithUnknowPrimaryContact(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## confirmGroupWithKnowningPrimaryContact

> confirmGroupWithKnowningPrimaryContact(id, opts)

confirm auto imported group/teams by assigning task to the specified primary contact

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'userParam': new CloudGovernanceApi.UserParam() // UserParam | 
};
apiInstance.confirmGroupWithKnowningPrimaryContact(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **userParam** | [**UserParam**](UserParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## confirmSite

> confirmSite(id, opts)

confirm auto imported site information

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'confirmInformation': new CloudGovernanceApi.ConfirmInformation() // ConfirmInformation | 
};
apiInstance.confirmSite(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **confirmInformation** | [**ConfirmInformation**](ConfirmInformation.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## confirmSiteWitKnowingPrimaryContact

> confirmSiteWitKnowingPrimaryContact(id, opts)

confirm auto imported site by assigning task to the specified primary contact

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'userParam': new CloudGovernanceApi.UserParam() // UserParam | 
};
apiInstance.confirmSiteWitKnowingPrimaryContact(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **userParam** | [**UserParam**](UserParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## confirmSiteWithUnknowPrimaryContact

> confirmSiteWithUnknowPrimaryContact(id)

confirm auto imported site by assigning task to administrator

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.confirmSiteWithUnknowPrimaryContact(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## getGroupAutoImportProfile

> AutoImportProfileRef getGroupAutoImportProfile(id)

get group/teams auto-imported profile information

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getGroupAutoImportProfile(id, (error, data, response) => {
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

[**AutoImportProfileRef**](AutoImportProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupContacts

> ObjectContactModel getGroupContacts(id)

get group/teams contacts

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getGroupContacts(id, (error, data, response) => {
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

[**ObjectContactModel**](ObjectContactModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembershipRenewalItems

> [MembershipRenewalItemModel] getGroupMembershipRenewalItems(id)

get group/teams membership renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getGroupMembershipRenewalItems(id, (error, data, response) => {
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

[**[MembershipRenewalItemModel]**](MembershipRenewalItemModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMetadataRenewalItems

> [CustomMetadata] getGroupMetadataRenewalItems(id)

get group/teams metadata renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getGroupMetadataRenewalItems(id, (error, data, response) => {
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

[**[CustomMetadata]**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRenewalFilters

> DistinctPageResult getGroupPermissionRenewalFilters(id, opts)

get group/teams permission renewal report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGroupPermissionRenewalFilters(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRenewalFiltersForSPGroup

> DistinctPageResult getGroupPermissionRenewalFiltersForSPGroup(id, groupid, opts)

get group/teams permission renewal sharePoint group report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGroupPermissionRenewalFiltersForSPGroup(id, groupid, opts, (error, data, response) => {
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
 **groupid** | [**String**](.md)|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRenewalItems

> PermissionActionItemPageResult getGroupPermissionRenewalItems(id, opts)

get group/teams permission renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getGroupPermissionRenewalItems(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRenewalItemsForSPGroup

> PermissionActionItemPageResult getGroupPermissionRenewalItemsForSPGroup(id, groupid, opts)

get sharePoint group members of group/teams permission renewal item

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getGroupPermissionRenewalItemsForSPGroup(id, groupid, opts, (error, data, response) => {
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
 **groupid** | [**String**](.md)|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRenewalPermissionLevels

> [PermissionLevel] getGroupPermissionRenewalPermissionLevels(id)

get group/teams permission level for permission renewal

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getGroupPermissionRenewalPermissionLevels(id, (error, data, response) => {
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

[**[PermissionLevel]**](PermissionLevel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupRenewalProfileSettings

> GroupRenewProfileRef getGroupRenewalProfileSettings(id)

get group/teams renewal settings

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getGroupRenewalProfileSettings(id, (error, data, response) => {
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

[**GroupRenewProfileRef**](GroupRenewProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupSharingOptions

> ExternalSharingOptions getGroupSharingOptions(opts)

get group sharing options

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let opts = {
  'emailOrId': "emailOrId_example" // String | 
};
apiInstance.getGroupSharingOptions(opts, (error, data, response) => {
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
 **emailOrId** | **String**|  | [optional] 

### Return type

[**ExternalSharingOptions**](ExternalSharingOptions.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyGroupInformation

> ApiMyGroup getMyGroupInformation(id)

get O365 group/teams information

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getMyGroupInformation(id, (error, data, response) => {
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

[**ApiMyGroup**](ApiMyGroup.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMySiteInformation

> MySite getMySiteInformation(id)



### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getMySiteInformation(id, (error, data, response) => {
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

[**MySite**](MySite.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteAutoImportProfile

> AutoImportProfileRef getSiteAutoImportProfile(id)

get site auto import settings

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getSiteAutoImportProfile(id, (error, data, response) => {
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

[**AutoImportProfileRef**](AutoImportProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteContacts

> ObjectContactModel getSiteContacts(id)

get site contacts

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getSiteContacts(id, (error, data, response) => {
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

[**ObjectContactModel**](ObjectContactModel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteMetadata

> [CustomMetadata] getSiteMetadata(url)

get site metadata

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let url = "url_example"; // String | 
apiInstance.getSiteMetadata(url, (error, data, response) => {
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

### Return type

[**[CustomMetadata]**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteMetadataRenewalItems

> [CustomMetadata] getSiteMetadataRenewalItems(id)

get site metadata renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getSiteMetadataRenewalItems(id, (error, data, response) => {
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

[**[CustomMetadata]**](CustomMetadata.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePermissionRenewalFilters

> DistinctPageResult getSitePermissionRenewalFilters(id, opts)

get site permission renewal report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getSitePermissionRenewalFilters(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePermissionRenewalFiltersForSPGroup

> DistinctPageResult getSitePermissionRenewalFiltersForSPGroup(id, groupid, opts)

get site permission renewal sharePoint group report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getSitePermissionRenewalFiltersForSPGroup(id, groupid, opts, (error, data, response) => {
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
 **groupid** | [**String**](.md)|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePermissionRenewalItems

> PermissionActionItemPageResult getSitePermissionRenewalItems(id, opts)

get site permission renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getSitePermissionRenewalItems(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getSitePermissionRenewalItemsForSPGroup

> PermissionActionItemPageResult getSitePermissionRenewalItemsForSPGroup(id, groupid, opts)

get sharePoint group members of site permission renewal item

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getSitePermissionRenewalItemsForSPGroup(id, groupid, opts, (error, data, response) => {
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
 **groupid** | [**String**](.md)|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getSitePermissionRenewalPermissionLevels

> [PermissionLevel] getSitePermissionRenewalPermissionLevels(id)

get site permission level for permission renewal

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getSitePermissionRenewalPermissionLevels(id, (error, data, response) => {
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

[**[PermissionLevel]**](PermissionLevel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteRenewalProfileSettings

> RenewProfileRef getSiteRenewalProfileSettings(id)

get site renewal settings

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.getSiteRenewalProfileSettings(id, (error, data, response) => {
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

[**RenewProfileRef**](RenewProfileRef.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteSharingOptions

> ExternalSharingOptions getSiteSharingOptions(opts)

get site sharing options by site url or id

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let opts = {
  'siteUrlOrId': "siteUrlOrId_example" // String | 
};
apiInstance.getSiteSharingOptions(opts, (error, data, response) => {
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
 **siteUrlOrId** | **String**|  | [optional] 

### Return type

[**ExternalSharingOptions**](ExternalSharingOptions.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getWorkspaceFilters

> DistinctPageResult getWorkspaceFilters(opts)

get my workspace filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getWorkspaceFilters(opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getWorkspaceItems

> [WorkspaceList] getWorkspaceItems(opts)

get my workspace items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction
  'search': "search_example", // String | Search for name
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getWorkspaceItems(opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, type, siteUrl, groupEmail, primaryContact, primaryContactEmail, phase, isCurrentRenewer, createdTime, status, autoImportProfileId, pendingAction | [optional] 
 **search** | **String**| Search for name | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**[WorkspaceList]**](WorkspaceList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## reassignGroupRenewalTask

> reassignGroupRenewalTask(id, opts)

reassign the group/teams renewal task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'userid': "userid_example" // String | 
};
apiInstance.reassignGroupRenewalTask(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **userid** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reassignSiteRenewalTask

> reassignSiteRenewalTask(id, opts)

reassign the site renewal task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'userid': "userid_example" // String | 
};
apiInstance.reassignSiteRenewalTask(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **userid** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rejectGroupRenewalTask

> rejectGroupRenewalTask(id)

reject the group/teams renewal task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.rejectGroupRenewalTask(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rejectSiteRenewalTask

> rejectSiteRenewalTask(id)

reject the site renewal task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.rejectSiteRenewalTask(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## resetChangeForSiteRenewal

> resetChangeForSiteRenewal(id)

reset your change

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.resetChangeForSiteRenewal(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## resetChangesForGroupRenewal

> resetChangesForGroupRenewal(id)

reset your change

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.resetChangesForGroupRenewal(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## saveGroupPermissionRenewalItems

> saveGroupPermissionRenewalItems(id, opts)

save group/teams permission renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'permissionActionItem': [new CloudGovernanceApi.PermissionActionItem()] // [PermissionActionItem] | 
};
apiInstance.saveGroupPermissionRenewalItems(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **permissionActionItem** | [**[PermissionActionItem]**](PermissionActionItem.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveSitePermissionRenewalItems

> saveSitePermissionRenewalItems(id, opts)

save site permission renewal items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'permissionActionItem': [new CloudGovernanceApi.PermissionActionItem()] // [PermissionActionItem] | 
};
apiInstance.saveSitePermissionRenewalItems(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 
 **permissionActionItem** | [**[PermissionActionItem]**](PermissionActionItem.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitGroupRenewalTask

> Boolean submitGroupRenewalTask(id, opts)

submit the group/teams renewal task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'renewModel': new CloudGovernanceApi.RenewModel() // RenewModel | 
};
apiInstance.submitGroupRenewalTask(id, opts, (error, data, response) => {
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
 **renewModel** | [**RenewModel**](RenewModel.md)|  | [optional] 

### Return type

**Boolean**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## submitGroupRenewalTaskForArchiving

> submitGroupRenewalTaskForArchiving(id)

submit group/teams renewal task with archive

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.submitGroupRenewalTaskForArchiving(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## submitGroupRenewalTaskForDeleting

> submitGroupRenewalTaskForDeleting(id)

submit group/teams renewal task with deletion

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.submitGroupRenewalTaskForDeleting(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## submitSiteRenewalTask

> Boolean submitSiteRenewalTask(id, opts)

submit the site renewal task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
let opts = {
  'renewModel': new CloudGovernanceApi.RenewModel() // RenewModel | 
};
apiInstance.submitSiteRenewalTask(id, opts, (error, data, response) => {
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
 **renewModel** | [**RenewModel**](RenewModel.md)|  | [optional] 

### Return type

**Boolean**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## submitSiteRenewalTaskForDeleting

> submitSiteRenewalTaskForDeleting(id)

submit site renewal task with deletion

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.submitSiteRenewalTaskForDeleting(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## submitSiteRenewalTaskWithArchiving

> submitSiteRenewalTaskWithArchiving(id)

approval site renewal task with archive

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.WorkspaceApi();
let id = null; // String | 
apiInstance.submitSiteRenewalTaskWithArchiving(id, (error, data, response) => {
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
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

