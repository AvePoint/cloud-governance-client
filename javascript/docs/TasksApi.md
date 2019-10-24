# CloudGovernanceApi.TasksApi

All URIs are relative to *https://cg-api.avepointlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addMembersForGroupMembershipRecertification**](TasksApi.md#addMembersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/members | add members for group membership recertification
[**addOwnersForGroupMembershipRecertification**](TasksApi.md#addOwnersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/owners | add owners for group membership recertification
[**approveTask**](TasksApi.md#approveTask) | **POST** /tasks/{id}/approve | approve task
[**claimElectionTask**](TasksApi.md#claimElectionTask) | **POST** /tasks/{id}/election/claim | claim election task
[**claimSiteOwnershipRecertificationTask**](TasksApi.md#claimSiteOwnershipRecertificationTask) | **POST** /tasks/{id}/site/recertification/ownership/claim/{secondarycontact} | claim site ownership recertification task
[**declineElectionTask**](TasksApi.md#declineElectionTask) | **POST** /tasks/{id}/election/decline | decline election task
[**declineSiteOwnershipRecertificationTask**](TasksApi.md#declineSiteOwnershipRecertificationTask) | **POST** /tasks/{id}/site/recertification/ownership/decline | decline site ownership recertification task
[**demoteAsMembersForGroupMembershipRecertification**](TasksApi.md#demoteAsMembersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/demoteasmember | demote as members for group membership recertification
[**editArchiveGroupRequest**](TasksApi.md#editArchiveGroupRequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
[**editArchiveSiteRequest**](TasksApi.md#editArchiveSiteRequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
[**editArchiveWebRequest**](TasksApi.md#editArchiveWebRequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
[**editChangeGroupPolicyRequest**](TasksApi.md#editChangeGroupPolicyRequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
[**editChangeGroupQuotaRequest**](TasksApi.md#editChangeGroupQuotaRequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
[**editChangeGroupRequest**](TasksApi.md#editChangeGroupRequest) | **PUT** /tasks/{id}/changegroup | edit create change group request in task
[**editChangeListSettingRequest**](TasksApi.md#editChangeListSettingRequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
[**editChangePermissionRequest**](TasksApi.md#editChangePermissionRequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
[**editChangeSiteContactRequest**](TasksApi.md#editChangeSiteContactRequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request in task
[**editChangeSitePolicyRequest**](TasksApi.md#editChangeSitePolicyRequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
[**editChangeSiteQuotaRequest**](TasksApi.md#editChangeSiteQuotaRequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
[**editChangeSiteSettingRequest**](TasksApi.md#editChangeSiteSettingRequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request in task
[**editChangeWebContactRequest**](TasksApi.md#editChangeWebContactRequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
[**editChangeWebSettingRequest**](TasksApi.md#editChangeWebSettingRequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
[**editClonePermissionRequest**](TasksApi.md#editClonePermissionRequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request in task
[**editContentMoveRequest**](TasksApi.md#editContentMoveRequest) | **PUT** /tasks/{id}/contentmove | edit content move request in task
[**editCreateGroupRequest**](TasksApi.md#editCreateGroupRequest) | **PUT** /tasks/{id}/creategroup | edit create site group request in task
[**editCreateListRequest**](TasksApi.md#editCreateListRequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
[**editCreateSiteRequest**](TasksApi.md#editCreateSiteRequest) | **PUT** /tasks/{id}/createsite | edit create site request in task
[**editCreateWebRequest**](TasksApi.md#editCreateWebRequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
[**editCustomRequest**](TasksApi.md#editCustomRequest) | **PUT** /tasks/{id}/custom | edit custom request in task
[**editDeleteGroupRequest**](TasksApi.md#editDeleteGroupRequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
[**editDeleteSiteRequest**](TasksApi.md#editDeleteSiteRequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
[**editDeleteWebRequest**](TasksApi.md#editDeleteWebRequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
[**editExtendGroupRequest**](TasksApi.md#editExtendGroupRequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
[**editExtendSiteRequest**](TasksApi.md#editExtendSiteRequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
[**editGrantPermissionRequest**](TasksApi.md#editGrantPermissionRequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
[**editLockSiteRequest**](TasksApi.md#editLockSiteRequest) | **PUT** /tasks/{id}/locksite | edit lock site request in task
[**editManagePermissionRequest**](TasksApi.md#editManagePermissionRequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request in task
[**editRestoreGroupRequest**](TasksApi.md#editRestoreGroupRequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
[**editUnLockSiteRequest**](TasksApi.md#editUnLockSiteRequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request in task
[**getChangePermissionReport**](TasksApi.md#getChangePermissionReport) | **GET** /tasks/changepermission/{id}/permission | get change permission report
[**getChangePermissionReportByVersion**](TasksApi.md#getChangePermissionReportByVersion) | **GET** /tasks/changepermission/{id}/permission/{version} | get change permission report with specific version
[**getChangePermissionReportFilters**](TasksApi.md#getChangePermissionReportFilters) | **GET** /tasks/changepermission/{id}/permission/filters | get change permission report filters
[**getChangePermissionReportFiltersByVersion**](TasksApi.md#getChangePermissionReportFiltersByVersion) | **GET** /tasks/changepermission/{id}/permission/filters/{version} | get change permission report filters with specific version
[**getChangePermissionReportFiltersForSPGroup**](TasksApi.md#getChangePermissionReportFiltersForSPGroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters | get change permission report filters for a sharepoint group
[**getChangePermissionReportFiltersForSPGroupByVersion**](TasksApi.md#getChangePermissionReportFiltersForSPGroupByVersion) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters/{version} | get change permission report filters for a sharepoint group with specific version
[**getChangePermissionReportForSPGroup**](TasksApi.md#getChangePermissionReportForSPGroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid} | get change permission report for a sharepoint group
[**getChangePermissionReportForSPGroupByVersion**](TasksApi.md#getChangePermissionReportForSPGroupByVersion) | **GET** /tasks/changepermission/{id}/permission/{version}/group/{groupid} | get change permission report for a sharepoint group with specific version
[**getChangePermissionReportPermissionLevels**](TasksApi.md#getChangePermissionReportPermissionLevels) | **GET** /tasks/changepermission/{id}/permissionlevels | get change permission report permission levels
[**getChangePermissionReportProperties**](TasksApi.md#getChangePermissionReportProperties) | **GET** /tasks/changepermission/{id}/properties | get change permission report properties
[**getClonePermissionReport**](TasksApi.md#getClonePermissionReport) | **GET** /tasks/clonepermission/{id}/permission | get clone permission report
[**getClonePermissionReportProperties**](TasksApi.md#getClonePermissionReportProperties) | **GET** /tasks/clonepermission/{id}/properties | get clone permission report properties
[**getGetManualArchiveReport**](TasksApi.md#getGetManualArchiveReport) | **GET** /tasks/{id}/manualarchive | get manual archive report
[**getGetManualArchiveReportFilters**](TasksApi.md#getGetManualArchiveReportFilters) | **GET** /tasks/{id}/manualarchive/filters | get manual archive report filters
[**getGroupMembershipRecertificationReport**](TasksApi.md#getGroupMembershipRecertificationReport) | **GET** /tasks/{id}/group/recertification/membership | get group membership recertification report
[**getGroupMembershipRecertificationReportByVersion**](TasksApi.md#getGroupMembershipRecertificationReportByVersion) | **GET** /tasks/{id}/group/recertification/membership/{version} | get group membership recertification report by version
[**getGroupMembershipRecertificationReportFilters**](TasksApi.md#getGroupMembershipRecertificationReportFilters) | **GET** /tasks/{id}/group/recertification/membership/filters | get group membership recertification report filters
[**getGroupMembershipRecertificationReportFiltersByVersion**](TasksApi.md#getGroupMembershipRecertificationReportFiltersByVersion) | **GET** /tasks/{id}/group/recertification/membership/filters/{version} | get group membership recertification report filters by version
[**getGroupMembershipRecertificationReportProperties**](TasksApi.md#getGroupMembershipRecertificationReportProperties) | **GET** /tasks/{id}/group/recertification/membership/properties | get group membership recertification report properties
[**getGroupPermissionRecertificationReport**](TasksApi.md#getGroupPermissionRecertificationReport) | **GET** /tasks/{id}/group/recertification/permission | get group permission recertification report
[**getGroupPermissionRecertificationReportByVersion**](TasksApi.md#getGroupPermissionRecertificationReportByVersion) | **GET** /tasks/{id}/group/recertification/permission/{version} | get group permission recertification report by version
[**getGroupPermissionRecertificationReportFilters**](TasksApi.md#getGroupPermissionRecertificationReportFilters) | **GET** /tasks/{id}/group/recertification/permission/filters | get group permission recertification report filters
[**getGroupPermissionRecertificationReportFiltersForSPGroup**](TasksApi.md#getGroupPermissionRecertificationReportFiltersForSPGroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid}/filters | get group permission recertification report filters for sharepoint group
[**getGroupPermissionRecertificationReportForSPGroup**](TasksApi.md#getGroupPermissionRecertificationReportForSPGroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid} | get group permission recertification report for sharepoint group
[**getGroupPermissionRecertificationReportProperties**](TasksApi.md#getGroupPermissionRecertificationReportProperties) | **GET** /tasks/{id}/group/recertification/permission/properties | get group permission recertification report properties
[**getMyTaskFilters**](TasksApi.md#getMyTaskFilters) | **GET** /tasks/my/filters | get my task filters
[**getMyTasks**](TasksApi.md#getMyTasks) | **GET** /tasks/my | get my tasks
[**getRemovePermissionReport**](TasksApi.md#getRemovePermissionReport) | **GET** /tasks/removepermission/{id}/permission | get remove permission report
[**getRemovePermissionReportProperties**](TasksApi.md#getRemovePermissionReportProperties) | **GET** /tasks/removepermission/{id}/properties | get remove permission report properties
[**getSiteMetadataRecertificationReport**](TasksApi.md#getSiteMetadataRecertificationReport) | **GET** /tasks/{id}/site/recertification/metadata | get site metadata recertification metadata
[**getSiteMetadataRecertificationReportProperties**](TasksApi.md#getSiteMetadataRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/metadata/properties | get site metadata recertification report properties
[**getSiteOwnershipRecertificationReportProperties**](TasksApi.md#getSiteOwnershipRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/ownership/properties | get site ownership recertification report properties
[**getSitePermissionRecertificatioPermissionFilters**](TasksApi.md#getSitePermissionRecertificatioPermissionFilters) | **GET** /tasks/{id}/site/recertification/permission/filters | get site permission recertification permission filters
[**getSitePermissionRecertificatioReportFiltersByVersion**](TasksApi.md#getSitePermissionRecertificatioReportFiltersByVersion) | **GET** /tasks/{id}/site/recertification/permission/filters/{version} | get site permission recertification permission filters with specific version
[**getSitePermissionRecertificatioReportFiltersForSPGroup**](TasksApi.md#getSitePermissionRecertificatioReportFiltersForSPGroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters | 
[**getSitePermissionRecertificatioReportFiltersForSPGroupByVersion**](TasksApi.md#getSitePermissionRecertificatioReportFiltersForSPGroupByVersion) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters/{version} | 
[**getSitePermissionRecertificationPermissionLevels**](TasksApi.md#getSitePermissionRecertificationPermissionLevels) | **GET** /tasks/{id}/recertification/permissionlevels | get site permission recertification permission levels
[**getSitePermissionRecertificationReport**](TasksApi.md#getSitePermissionRecertificationReport) | **GET** /tasks/{id}/site/recertification/permission | get site permission recertification report
[**getSitePermissionRecertificationReportByVersion**](TasksApi.md#getSitePermissionRecertificationReportByVersion) | **GET** /tasks/{id}/site/recertification/permission/{version} | get site permission recertification report by specific version
[**getSitePermissionRecertificationReportForSPGroup**](TasksApi.md#getSitePermissionRecertificationReportForSPGroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid} | get site permission recertification group permission items
[**getSitePermissionRecertificationReportForSPGroupByVersion**](TasksApi.md#getSitePermissionRecertificationReportForSPGroupByVersion) | **GET** /tasks/{id}/site/recertification/permission/{version}/group/{groupid} | get site permission recertification group permission items with specific version with specific version
[**getSitePermissionRecertificationReportProperties**](TasksApi.md#getSitePermissionRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/permission/properties | get site permission recertification report properties
[**getTaskByBatchId**](TasksApi.md#getTaskByBatchId) | **GET** /tasks/my/{batchid} | get task by batch id
[**getTaskById**](TasksApi.md#getTaskById) | **GET** /tasks/{id} | get my task by id
[**promoteAsOwnersForGroupMembershipRecertification**](TasksApi.md#promoteAsOwnersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/promoteasowner | promote as owners for group membership recertification
[**reassignTask**](TasksApi.md#reassignTask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
[**rejectTask**](TasksApi.md#rejectTask) | **POST** /tasks/{id}/reject | reject task
[**removeUsersForGroupMembershipRecertification**](TasksApi.md#removeUsersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/removeuser | remove users for group membership recertification
[**reseAllChangesForChangePermissionTask**](TasksApi.md#reseAllChangesForChangePermissionTask) | **POST** /tasks/changepermission/{id}/resetallchange | save all changes for change permission task
[**resetAllChangesForRecertificationTask**](TasksApi.md#resetAllChangesForRecertificationTask) | **POST** /tasks/{id}/recertification/resetallchange | reset all changes for site/group recertification task
[**resetMyChangesForChangePermissionTask**](TasksApi.md#resetMyChangesForChangePermissionTask) | **POST** /tasks/changepermission/{id}/resetmychange | save my changes for change permission task
[**resetMyChangesForRecertificationTask**](TasksApi.md#resetMyChangesForRecertificationTask) | **POST** /tasks/{id}/recertification/resetmychange | reset my changes for site/group recertification task
[**retryErrorTask**](TasksApi.md#retryErrorTask) | **POST** /tasks/{id}/retry | retry error task
[**saveChangePermissionActions**](TasksApi.md#saveChangePermissionActions) | **POST** /tasks/changepermission/{id}/permission | save change permission actions
[**saveClonePermissionReport**](TasksApi.md#saveClonePermissionReport) | **POST** /tasks/clonepermission/{id}/permission | Save clone permission report
[**saveGetManualArchiveReport**](TasksApi.md#saveGetManualArchiveReport) | **POST** /tasks/{id}/manualarchive | save manual archive report
[**saveGroupPermissionRecertificationResults**](TasksApi.md#saveGroupPermissionRecertificationResults) | **POST** /tasks/{id}/group/recertification/permission | save group permission recertification results
[**saveRemovePermissionReport**](TasksApi.md#saveRemovePermissionReport) | **POST** /tasks/removepermission/{id}/permission | save remove permission report
[**saveSiteMetadataRecertificationResult**](TasksApi.md#saveSiteMetadataRecertificationResult) | **POST** /tasks/{id}/site/recertification/metadata | save site metadata recertification metadata
[**saveSitePermissionRecertificationResult**](TasksApi.md#saveSitePermissionRecertificationResult) | **POST** /tasks/{id}/site/recertification/permission | save site permission recertification permissions
[**skipErrorTask**](TasksApi.md#skipErrorTask) | **POST** /tasks/{id}/skip | skip error task
[**specifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived**](TasksApi.md#specifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived) | **POST** /tasks/{id}/election/specify/contacts | specify primary and secondary contact when primary contact is deactived
[**specifySecondaryContactWhenSecondaryContactIsDeactived**](TasksApi.md#specifySecondaryContactWhenSecondaryContactIsDeactived) | **POST** /tasks/{id}/election/specify/secondarycontact | specify secondary contact when secondary contact is deactived
[**submitArchiveGroupAutoTask**](TasksApi.md#submitArchiveGroupAutoTask) | **POST** /tasks/archivegroup | submit archive group auto task
[**submitArchiveSiteAutoTask**](TasksApi.md#submitArchiveSiteAutoTask) | **POST** /tasks/archivesite | submit site archive auto task
[**submitChangeSitePolicyAutoTask**](TasksApi.md#submitChangeSitePolicyAutoTask) | **POST** /tasks/changesitepolicy | submit site policy change auto task
[**submitContinueAccessGroupAutoTask**](TasksApi.md#submitContinueAccessGroupAutoTask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
[**submitContinueAccessSiteAutoTask**](TasksApi.md#submitContinueAccessSiteAutoTask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
[**submitDeleteGroupAutoTask**](TasksApi.md#submitDeleteGroupAutoTask) | **POST** /tasks/deletegroup | submit delete group auto task
[**submitDeleteSiteAutoTask**](TasksApi.md#submitDeleteSiteAutoTask) | **POST** /tasks/deletesite | submit site delete auto task
[**submitExtendGroupAutoTask**](TasksApi.md#submitExtendGroupAutoTask) | **POST** /tasks/extendgroup | submit extend group auto task
[**submitExtendSiteAutoTask**](TasksApi.md#submitExtendSiteAutoTask) | **POST** /tasks/extendsite | submit site extend auto task
[**submitRecertificationTask**](TasksApi.md#submitRecertificationTask) | **POST** /tasks/{id}/submit | submit site/group recertification task
[**viewSiteOwnershipRecertificationTask**](TasksApi.md#viewSiteOwnershipRecertificationTask) | **GET** /tasks/{id}/site/recertification/ownership | view site ownership recertification task



## addMembersForGroupMembershipRecertification

> addMembersForGroupMembershipRecertification(id, opts)

add members for group membership recertification

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'apiUser': [new CloudGovernanceApi.ApiUser()] // [ApiUser] | 
};
apiInstance.addMembersForGroupMembershipRecertification(id, opts, (error, data, response) => {
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
 **apiUser** | [**[ApiUser]**](ApiUser.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## addOwnersForGroupMembershipRecertification

> addOwnersForGroupMembershipRecertification(id, opts)

add owners for group membership recertification

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'apiUser': [new CloudGovernanceApi.ApiUser()] // [ApiUser] | 
};
apiInstance.addOwnersForGroupMembershipRecertification(id, opts, (error, data, response) => {
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
 **apiUser** | [**[ApiUser]**](ApiUser.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## approveTask

> approveTask(id, opts)

approve task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.approveTask(id, opts, (error, data, response) => {
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
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## claimElectionTask

> claimElectionTask(id, opts)

claim election task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'secondarycontact': "secondarycontact_example" // String | 
};
apiInstance.claimElectionTask(id, opts, (error, data, response) => {
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
 **secondarycontact** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## claimSiteOwnershipRecertificationTask

> claimSiteOwnershipRecertificationTask(id, secondarycontact)

claim site ownership recertification task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let secondarycontact = "secondarycontact_example"; // String | 
apiInstance.claimSiteOwnershipRecertificationTask(id, secondarycontact, (error, data, response) => {
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
 **secondarycontact** | **String**|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## declineElectionTask

> declineElectionTask(id)

decline election task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.declineElectionTask(id, (error, data, response) => {
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


## declineSiteOwnershipRecertificationTask

> declineSiteOwnershipRecertificationTask(id)

decline site ownership recertification task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.declineSiteOwnershipRecertificationTask(id, (error, data, response) => {
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


## demoteAsMembersForGroupMembershipRecertification

> demoteAsMembersForGroupMembershipRecertification(id, opts)

demote as members for group membership recertification

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'apiUser': [new CloudGovernanceApi.ApiUser()] // [ApiUser] | 
};
apiInstance.demoteAsMembersForGroupMembershipRecertification(id, opts, (error, data, response) => {
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
 **apiUser** | [**[ApiUser]**](ApiUser.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editArchiveGroupRequest

> editArchiveGroupRequest(id, opts)

edit archive group request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'archiveGroupRequest': new CloudGovernanceApi.ArchiveGroupRequest() // ArchiveGroupRequest | 
};
apiInstance.editArchiveGroupRequest(id, opts, (error, data, response) => {
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
 **archiveGroupRequest** | [**ArchiveGroupRequest**](ArchiveGroupRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editArchiveSiteRequest

> editArchiveSiteRequest(id, opts)

edit archive site request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'archiveSiteRequest': new CloudGovernanceApi.ArchiveSiteRequest() // ArchiveSiteRequest | 
};
apiInstance.editArchiveSiteRequest(id, opts, (error, data, response) => {
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
 **archiveSiteRequest** | [**ArchiveSiteRequest**](ArchiveSiteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editArchiveWebRequest

> editArchiveWebRequest(id, opts)

edit archive web request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'archiveWebLifecycleRequest': new CloudGovernanceApi.ArchiveWebLifecycleRequest() // ArchiveWebLifecycleRequest | 
};
apiInstance.editArchiveWebRequest(id, opts, (error, data, response) => {
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
 **archiveWebLifecycleRequest** | [**ArchiveWebLifecycleRequest**](ArchiveWebLifecycleRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeGroupPolicyRequest

> editChangeGroupPolicyRequest(id, opts)

edit change group policy request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeGroupPolicyRequest': new CloudGovernanceApi.ChangeGroupPolicyRequest() // ChangeGroupPolicyRequest | 
};
apiInstance.editChangeGroupPolicyRequest(id, opts, (error, data, response) => {
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
 **changeGroupPolicyRequest** | [**ChangeGroupPolicyRequest**](ChangeGroupPolicyRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeGroupQuotaRequest

> editChangeGroupQuotaRequest(id, opts)

edit change group quota request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeGroupQuotaRequest': new CloudGovernanceApi.ChangeGroupQuotaRequest() // ChangeGroupQuotaRequest | 
};
apiInstance.editChangeGroupQuotaRequest(id, opts, (error, data, response) => {
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
 **changeGroupQuotaRequest** | [**ChangeGroupQuotaRequest**](ChangeGroupQuotaRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeGroupRequest

> editChangeGroupRequest(id, opts)

edit create change group request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeGroupSettingRequest': new CloudGovernanceApi.ChangeGroupSettingRequest() // ChangeGroupSettingRequest | 
};
apiInstance.editChangeGroupRequest(id, opts, (error, data, response) => {
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
 **changeGroupSettingRequest** | [**ChangeGroupSettingRequest**](ChangeGroupSettingRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeListSettingRequest

> editChangeListSettingRequest(id, opts)

edit change list setting request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeListSettingRequest': new CloudGovernanceApi.ChangeListSettingRequest() // ChangeListSettingRequest | 
};
apiInstance.editChangeListSettingRequest(id, opts, (error, data, response) => {
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
 **changeListSettingRequest** | [**ChangeListSettingRequest**](ChangeListSettingRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangePermissionRequest

> editChangePermissionRequest(id, opts)

edit change permission request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changePermissionRequest': new CloudGovernanceApi.ChangePermissionRequest() // ChangePermissionRequest | 
};
apiInstance.editChangePermissionRequest(id, opts, (error, data, response) => {
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
 **changePermissionRequest** | [**ChangePermissionRequest**](ChangePermissionRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeSiteContactRequest

> editChangeSiteContactRequest(id, opts)

edit change site administrator/contact request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeSiteContactRequest': new CloudGovernanceApi.ChangeSiteContactRequest() // ChangeSiteContactRequest | 
};
apiInstance.editChangeSiteContactRequest(id, opts, (error, data, response) => {
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
 **changeSiteContactRequest** | [**ChangeSiteContactRequest**](ChangeSiteContactRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeSitePolicyRequest

> editChangeSitePolicyRequest(id, opts)

edit change site policy request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeSitePolicyRequest': new CloudGovernanceApi.ChangeSitePolicyRequest() // ChangeSitePolicyRequest | 
};
apiInstance.editChangeSitePolicyRequest(id, opts, (error, data, response) => {
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
 **changeSitePolicyRequest** | [**ChangeSitePolicyRequest**](ChangeSitePolicyRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeSiteQuotaRequest

> editChangeSiteQuotaRequest(id, opts)

edit change site quota request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeSiteQuotaRequest': new CloudGovernanceApi.ChangeSiteQuotaRequest() // ChangeSiteQuotaRequest | 
};
apiInstance.editChangeSiteQuotaRequest(id, opts, (error, data, response) => {
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
 **changeSiteQuotaRequest** | [**ChangeSiteQuotaRequest**](ChangeSiteQuotaRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeSiteSettingRequest

> editChangeSiteSettingRequest(id, opts)

edit change site setting request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeSiteSettingRequest': new CloudGovernanceApi.ChangeSiteSettingRequest() // ChangeSiteSettingRequest | 
};
apiInstance.editChangeSiteSettingRequest(id, opts, (error, data, response) => {
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
 **changeSiteSettingRequest** | [**ChangeSiteSettingRequest**](ChangeSiteSettingRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeWebContactRequest

> editChangeWebContactRequest(id, opts)

edit change web contact request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeWebContactRequest': new CloudGovernanceApi.ChangeWebContactRequest() // ChangeWebContactRequest | 
};
apiInstance.editChangeWebContactRequest(id, opts, (error, data, response) => {
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
 **changeWebContactRequest** | [**ChangeWebContactRequest**](ChangeWebContactRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editChangeWebSettingRequest

> editChangeWebSettingRequest(id, opts)

edit change web setting request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'changeWebSettingRequest': new CloudGovernanceApi.ChangeWebSettingRequest() // ChangeWebSettingRequest | 
};
apiInstance.editChangeWebSettingRequest(id, opts, (error, data, response) => {
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
 **changeWebSettingRequest** | [**ChangeWebSettingRequest**](ChangeWebSettingRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editClonePermissionRequest

> editClonePermissionRequest(id, opts)

edit clone permission request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'clonePermissionRequest': new CloudGovernanceApi.ClonePermissionRequest() // ClonePermissionRequest | 
};
apiInstance.editClonePermissionRequest(id, opts, (error, data, response) => {
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
 **clonePermissionRequest** | [**ClonePermissionRequest**](ClonePermissionRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editContentMoveRequest

> editContentMoveRequest(id, opts)

edit content move request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'contentMoveRequest': new CloudGovernanceApi.ContentMoveRequest() // ContentMoveRequest | 
};
apiInstance.editContentMoveRequest(id, opts, (error, data, response) => {
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
 **contentMoveRequest** | [**ContentMoveRequest**](ContentMoveRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editCreateGroupRequest

> editCreateGroupRequest(id, opts)

edit create site group request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'createGroupRequest': new CloudGovernanceApi.CreateGroupRequest() // CreateGroupRequest | 
};
apiInstance.editCreateGroupRequest(id, opts, (error, data, response) => {
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
 **createGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editCreateListRequest

> editCreateListRequest(id, opts)

edit create list request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'createListRequest': new CloudGovernanceApi.CreateListRequest() // CreateListRequest | 
};
apiInstance.editCreateListRequest(id, opts, (error, data, response) => {
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
 **createListRequest** | [**CreateListRequest**](CreateListRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editCreateSiteRequest

> editCreateSiteRequest(id, opts)

edit create site request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'createSiteRequest': new CloudGovernanceApi.CreateSiteRequest() // CreateSiteRequest | 
};
apiInstance.editCreateSiteRequest(id, opts, (error, data, response) => {
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
 **createSiteRequest** | [**CreateSiteRequest**](CreateSiteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editCreateWebRequest

> editCreateWebRequest(id, opts)

edit create web request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'createWebRequest': new CloudGovernanceApi.CreateWebRequest() // CreateWebRequest | 
};
apiInstance.editCreateWebRequest(id, opts, (error, data, response) => {
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
 **createWebRequest** | [**CreateWebRequest**](CreateWebRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editCustomRequest

> editCustomRequest(id, opts)

edit custom request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'apiRequest': new CloudGovernanceApi.ApiRequest() // ApiRequest | 
};
apiInstance.editCustomRequest(id, opts, (error, data, response) => {
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
 **apiRequest** | [**ApiRequest**](ApiRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editDeleteGroupRequest

> editDeleteGroupRequest(id, opts)

edit delete change group request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'deleteGroupRequest': new CloudGovernanceApi.DeleteGroupRequest() // DeleteGroupRequest | 
};
apiInstance.editDeleteGroupRequest(id, opts, (error, data, response) => {
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
 **deleteGroupRequest** | [**DeleteGroupRequest**](DeleteGroupRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editDeleteSiteRequest

> editDeleteSiteRequest(id, opts)

edit delete site request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'deleteSiteRequest': new CloudGovernanceApi.DeleteSiteRequest() // DeleteSiteRequest | 
};
apiInstance.editDeleteSiteRequest(id, opts, (error, data, response) => {
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
 **deleteSiteRequest** | [**DeleteSiteRequest**](DeleteSiteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editDeleteWebRequest

> editDeleteWebRequest(id, opts)

edit delete web request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'deleteWebLifecycleRequest': new CloudGovernanceApi.DeleteWebLifecycleRequest() // DeleteWebLifecycleRequest | 
};
apiInstance.editDeleteWebRequest(id, opts, (error, data, response) => {
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
 **deleteWebLifecycleRequest** | [**DeleteWebLifecycleRequest**](DeleteWebLifecycleRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editExtendGroupRequest

> editExtendGroupRequest(id, opts)

edit extend group request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'extendGroupRequest': new CloudGovernanceApi.ExtendGroupRequest() // ExtendGroupRequest | 
};
apiInstance.editExtendGroupRequest(id, opts, (error, data, response) => {
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
 **extendGroupRequest** | [**ExtendGroupRequest**](ExtendGroupRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editExtendSiteRequest

> editExtendSiteRequest(id, opts)

edit extend site request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'extendSiteRequest': new CloudGovernanceApi.ExtendSiteRequest() // ExtendSiteRequest | 
};
apiInstance.editExtendSiteRequest(id, opts, (error, data, response) => {
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
 **extendSiteRequest** | [**ExtendSiteRequest**](ExtendSiteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editGrantPermissionRequest

> editGrantPermissionRequest(id, opts)

edit grant permission request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'grantPermissionRequest': new CloudGovernanceApi.GrantPermissionRequest() // GrantPermissionRequest | 
};
apiInstance.editGrantPermissionRequest(id, opts, (error, data, response) => {
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
 **grantPermissionRequest** | [**GrantPermissionRequest**](GrantPermissionRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editLockSiteRequest

> editLockSiteRequest(id, opts)

edit lock site request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'lockSiteRequest': new CloudGovernanceApi.LockSiteRequest() // LockSiteRequest | 
};
apiInstance.editLockSiteRequest(id, opts, (error, data, response) => {
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
 **lockSiteRequest** | [**LockSiteRequest**](LockSiteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editManagePermissionRequest

> editManagePermissionRequest(id, opts)

edit manage permission request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'managePermissionRequest': new CloudGovernanceApi.ManagePermissionRequest() // ManagePermissionRequest | 
};
apiInstance.editManagePermissionRequest(id, opts, (error, data, response) => {
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
 **managePermissionRequest** | [**ManagePermissionRequest**](ManagePermissionRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editRestoreGroupRequest

> editRestoreGroupRequest(id, opts)

edit restore group request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'restoreGroupRequest': new CloudGovernanceApi.RestoreGroupRequest() // RestoreGroupRequest | 
};
apiInstance.editRestoreGroupRequest(id, opts, (error, data, response) => {
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
 **restoreGroupRequest** | [**RestoreGroupRequest**](RestoreGroupRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## editUnLockSiteRequest

> editUnLockSiteRequest(id, opts)

edit unlock site request in task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'unlockSiteRequest': new CloudGovernanceApi.UnlockSiteRequest() // UnlockSiteRequest | 
};
apiInstance.editUnLockSiteRequest(id, opts, (error, data, response) => {
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
 **unlockSiteRequest** | [**UnlockSiteRequest**](UnlockSiteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## getChangePermissionReport

> PermissionActionItemPageResult getChangePermissionReport(id, opts)

get change permission report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getChangePermissionReport(id, opts, (error, data, response) => {
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


## getChangePermissionReportByVersion

> PermissionActionItemPageResult getChangePermissionReportByVersion(id, version, opts)

get change permission report with specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 789; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getChangePermissionReportByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getChangePermissionReportFilters

> DistinctPageResult getChangePermissionReportFilters(id, opts)

get change permission report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getChangePermissionReportFilters(id, opts, (error, data, response) => {
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


## getChangePermissionReportFiltersByVersion

> DistinctPageResult getChangePermissionReportFiltersByVersion(id, version, opts)

get change permission report filters with specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 789; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getChangePermissionReportFiltersByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getChangePermissionReportFiltersForSPGroup

> DistinctPageResult getChangePermissionReportFiltersForSPGroup(id, groupid, opts)

get change permission report filters for a sharepoint group

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getChangePermissionReportFiltersForSPGroup(id, groupid, opts, (error, data, response) => {
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


## getChangePermissionReportFiltersForSPGroupByVersion

> DistinctPageResult getChangePermissionReportFiltersForSPGroupByVersion(id, groupid, version, opts)

get change permission report filters for a sharepoint group with specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let version = 789; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getChangePermissionReportFiltersForSPGroupByVersion(id, groupid, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getChangePermissionReportForSPGroup

> PermissionActionItemPageResult getChangePermissionReportForSPGroup(id, groupid, opts)

get change permission report for a sharepoint group

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getChangePermissionReportForSPGroup(id, groupid, opts, (error, data, response) => {
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


## getChangePermissionReportForSPGroupByVersion

> PermissionActionItemPageResult getChangePermissionReportForSPGroupByVersion(id, version, groupid, opts)

get change permission report for a sharepoint group with specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 789; // Number | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getChangePermissionReportForSPGroupByVersion(id, version, groupid, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getChangePermissionReportPermissionLevels

> [PermissionLevel] getChangePermissionReportPermissionLevels(id)

get change permission report permission levels

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getChangePermissionReportPermissionLevels(id, (error, data, response) => {
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


## getChangePermissionReportProperties

> RecertificationReportProperties getChangePermissionReportProperties(id)

get change permission report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getChangePermissionReportProperties(id, (error, data, response) => {
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

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getClonePermissionReport

> ClonePermissionSecuritySearchResultPageResult getClonePermissionReport(id, opts)

get clone permission report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action
  'body': null // Object | 
};
apiInstance.getClonePermissionReport(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**ClonePermissionSecuritySearchResultPageResult**](ClonePermissionSecuritySearchResultPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getClonePermissionReportProperties

> ClonePermissionReportProperty getClonePermissionReportProperties(id)

get clone permission report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getClonePermissionReportProperties(id, (error, data, response) => {
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

[**ClonePermissionReportProperty**](ClonePermissionReportProperty.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGetManualArchiveReport

> ManuallyArchiveRecordModelPageResult getGetManualArchiveReport(id, opts)

get manual archive report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> rowKey, partitionKey, siteId, url, nodeType
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> rowKey, partitionKey, siteId, url, nodeType
  'body': null // Object | 
};
apiInstance.getGetManualArchiveReport(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**ManuallyArchiveRecordModelPageResult**](ManuallyArchiveRecordModelPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGetManualArchiveReportFilters

> DistinctPageResult getGetManualArchiveReportFilters(id, opts)

get manual archive report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> rowKey, partitionKey, siteId, url, nodeType
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> rowKey, partitionKey, siteId, url, nodeType
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGetManualArchiveReportFilters(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembershipRecertificationReport

> MembershipRecertificationItemPageResult getGroupMembershipRecertificationReport(id, opts)

get group membership recertification report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'body': null // Object | 
};
apiInstance.getGroupMembershipRecertificationReport(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**MembershipRecertificationItemPageResult**](MembershipRecertificationItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupMembershipRecertificationReportByVersion

> MembershipRecertificationItemPageResult getGroupMembershipRecertificationReportByVersion(id, version, opts)

get group membership recertification report by version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 56; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'body': null // Object | 
};
apiInstance.getGroupMembershipRecertificationReportByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**MembershipRecertificationItemPageResult**](MembershipRecertificationItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupMembershipRecertificationReportFilters

> DistinctPageResult getGroupMembershipRecertificationReportFilters(id, opts)

get group membership recertification report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGroupMembershipRecertificationReportFilters(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembershipRecertificationReportFiltersByVersion

> DistinctPageResult getGroupMembershipRecertificationReportFiltersByVersion(id, version, opts)

get group membership recertification report filters by version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 56; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGroupMembershipRecertificationReportFiltersByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupMembershipRecertificationReportProperties

> MembershipRecertificationReportProperties getGroupMembershipRecertificationReportProperties(id)

get group membership recertification report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getGroupMembershipRecertificationReportProperties(id, (error, data, response) => {
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

[**MembershipRecertificationReportProperties**](MembershipRecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRecertificationReport

> GroupPermissionActionItemPageResult getGroupPermissionRecertificationReport(id, opts)

get group permission recertification report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'body': null // Object | 
};
apiInstance.getGroupPermissionRecertificationReport(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRecertificationReportByVersion

> GroupPermissionActionItemPageResult getGroupPermissionRecertificationReportByVersion(id, version, opts)

get group permission recertification report by version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 56; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'body': null // Object | 
};
apiInstance.getGroupPermissionRecertificationReportByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRecertificationReportFilters

> DistinctPageResult getGroupPermissionRecertificationReportFilters(id, opts)

get group permission recertification report filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGroupPermissionRecertificationReportFilters(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRecertificationReportFiltersForSPGroup

> DistinctPageResult getGroupPermissionRecertificationReportFiltersForSPGroup(id, groupid, opts)

get group permission recertification report filters for sharepoint group

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getGroupPermissionRecertificationReportFiltersForSPGroup(id, groupid, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRecertificationReportForSPGroup

> GroupPermissionActionItemPageResult getGroupPermissionRecertificationReportForSPGroup(id, groupid, opts)

get group permission recertification report for sharepoint group

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType
  'body': null // Object | 
};
apiInstance.getGroupPermissionRecertificationReportForSPGroup(id, groupid, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getGroupPermissionRecertificationReportProperties

> RecertificationReportProperties getGroupPermissionRecertificationReportProperties(id)

get group permission recertification report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getGroupPermissionRecertificationReportProperties(id, (error, data, response) => {
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

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyTaskFilters

> DistinctPageResult getMyTaskFilters(opts)

get my task filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'isconfirmtask': false, // Boolean | 
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getMyTaskFilters(opts, (error, data, response) => {
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
 **isconfirmtask** | **Boolean**|  | [optional] [default to false]
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getMyTasks

> TaskListPageResult getMyTasks(opts)

get my tasks

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'isconfirmtask': false, // Boolean | 
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status
  'search': "search_example", // String | Search for title
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getMyTasks(opts, (error, data, response) => {
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
 **isconfirmtask** | **Boolean**|  | [optional] [default to false]
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **search** | **String**| Search for title | [optional] 
 **top** | **Number**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **Number**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**TaskListPageResult**](TaskListPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getRemovePermissionReport

> SecuritySearchResultPageResult getRemovePermissionReport(id, opts)

get remove permission report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action
  'body': null // Object | 
};
apiInstance.getRemovePermissionReport(id, opts, (error, data, response) => {
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
 **filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**SecuritySearchResultPageResult**](SecuritySearchResultPageResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json


## getRemovePermissionReportProperties

> RecertificationReportProperties getRemovePermissionReportProperties(id)

get remove permission report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getRemovePermissionReportProperties(id, (error, data, response) => {
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

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteMetadataRecertificationReport

> [CustomMetadata] getSiteMetadataRecertificationReport(id)

get site metadata recertification metadata

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getSiteMetadataRecertificationReport(id, (error, data, response) => {
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


## getSiteMetadataRecertificationReportProperties

> MetadataRecertificationReportProperties getSiteMetadataRecertificationReportProperties(id)

get site metadata recertification report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getSiteMetadataRecertificationReportProperties(id, (error, data, response) => {
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

[**MetadataRecertificationReportProperties**](MetadataRecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSiteOwnershipRecertificationReportProperties

> RecertificationReportProperties getSiteOwnershipRecertificationReportProperties(id)

get site ownership recertification report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getSiteOwnershipRecertificationReportProperties(id, (error, data, response) => {
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

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getSitePermissionRecertificatioPermissionFilters

> DistinctPageResult getSitePermissionRecertificatioPermissionFilters(id, opts)

get site permission recertification permission filters

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getSitePermissionRecertificatioPermissionFilters(id, opts, (error, data, response) => {
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


## getSitePermissionRecertificatioReportFiltersByVersion

> DistinctPageResult getSitePermissionRecertificatioReportFiltersByVersion(id, version, opts)

get site permission recertification permission filters with specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 789; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getSitePermissionRecertificatioReportFiltersByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getSitePermissionRecertificatioReportFiltersForSPGroup

> DistinctPageResult getSitePermissionRecertificatioReportFiltersForSPGroup(id, groupid, opts)



### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getSitePermissionRecertificatioReportFiltersForSPGroup(id, groupid, opts, (error, data, response) => {
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


## getSitePermissionRecertificatioReportFiltersForSPGroupByVersion

> DistinctPageResult getSitePermissionRecertificatioReportFiltersForSPGroupByVersion(id, groupid, version, opts)



### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let version = 789; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'distinct': "distinct_example", // String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'top': 56, // Number |  Define the number of records you want to return, max value is 200, default value is 200
  'skip': 56 // Number |  Define the number of records you want to skip, default value is 0
};
apiInstance.getSitePermissionRecertificatioReportFiltersForSPGroupByVersion(id, groupid, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getSitePermissionRecertificationPermissionLevels

> [PermissionLevel] getSitePermissionRecertificationPermissionLevels(id)

get site permission recertification permission levels

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getSitePermissionRecertificationPermissionLevels(id, (error, data, response) => {
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


## getSitePermissionRecertificationReport

> PermissionActionItemPageResult getSitePermissionRecertificationReport(id, opts)

get site permission recertification report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getSitePermissionRecertificationReport(id, opts, (error, data, response) => {
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


## getSitePermissionRecertificationReportByVersion

> PermissionActionItemPageResult getSitePermissionRecertificationReportByVersion(id, version, opts)

get site permission recertification report by specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 789; // Number | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getSitePermissionRecertificationReportByVersion(id, version, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getSitePermissionRecertificationReportForSPGroup

> PermissionActionItemPageResult getSitePermissionRecertificationReportForSPGroup(id, groupid, opts)

get site permission recertification group permission items

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getSitePermissionRecertificationReportForSPGroup(id, groupid, opts, (error, data, response) => {
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


## getSitePermissionRecertificationReportForSPGroupByVersion

> PermissionActionItemPageResult getSitePermissionRecertificationReportForSPGroupByVersion(id, version, groupid, opts)

get site permission recertification group permission items with specific version with specific version

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let version = 789; // Number | 
let groupid = null; // String | 
let opts = {
  'filter': "filter_example", // String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'orderby': "orderby_example", // String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator
  'body': null // Object | 
};
apiInstance.getSitePermissionRecertificationReportForSPGroupByVersion(id, version, groupid, opts, (error, data, response) => {
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
 **version** | **Number**|  | 
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


## getSitePermissionRecertificationReportProperties

> RecertificationReportProperties getSitePermissionRecertificationReportProperties(id)

get site permission recertification report properties

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getSitePermissionRecertificationReportProperties(id, (error, data, response) => {
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

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getTaskByBatchId

> TaskList getTaskByBatchId(batchid)

get task by batch id

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let batchid = null; // String | 
apiInstance.getTaskByBatchId(batchid, (error, data, response) => {
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
 **batchid** | [**String**](.md)|  | 

### Return type

[**TaskList**](TaskList.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## getTaskById

> ApiTask getTaskById(id)

get my task by id

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.getTaskById(id, (error, data, response) => {
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

[**ApiTask**](ApiTask.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json


## promoteAsOwnersForGroupMembershipRecertification

> promoteAsOwnersForGroupMembershipRecertification(id, opts)

promote as owners for group membership recertification

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'apiUser': [new CloudGovernanceApi.ApiUser()] // [ApiUser] | 
};
apiInstance.promoteAsOwnersForGroupMembershipRecertification(id, opts, (error, data, response) => {
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
 **apiUser** | [**[ApiUser]**](ApiUser.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## reassignTask

> reassignTask(id, user)

reassign task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let user = "user_example"; // String | 
apiInstance.reassignTask(id, user, (error, data, response) => {
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
 **user** | **String**|  | 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rejectTask

> rejectTask(id, opts)

reject task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.rejectTask(id, opts, (error, data, response) => {
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
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## removeUsersForGroupMembershipRecertification

> removeUsersForGroupMembershipRecertification(id, opts)

remove users for group membership recertification

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'requestBody': ["null"] // [String] | 
};
apiInstance.removeUsersForGroupMembershipRecertification(id, opts, (error, data, response) => {
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
 **requestBody** | [**[String]**](String.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## reseAllChangesForChangePermissionTask

> reseAllChangesForChangePermissionTask(id)

save all changes for change permission task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.reseAllChangesForChangePermissionTask(id, (error, data, response) => {
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


## resetAllChangesForRecertificationTask

> resetAllChangesForRecertificationTask(id)

reset all changes for site/group recertification task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.resetAllChangesForRecertificationTask(id, (error, data, response) => {
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


## resetMyChangesForChangePermissionTask

> resetMyChangesForChangePermissionTask(id)

save my changes for change permission task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.resetMyChangesForChangePermissionTask(id, (error, data, response) => {
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


## resetMyChangesForRecertificationTask

> resetMyChangesForRecertificationTask(id)

reset my changes for site/group recertification task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.resetMyChangesForRecertificationTask(id, (error, data, response) => {
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


## retryErrorTask

> retryErrorTask(id, opts)

retry error task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.retryErrorTask(id, opts, (error, data, response) => {
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
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveChangePermissionActions

> saveChangePermissionActions(id, opts)

save change permission actions

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'permissionActionItem': [new CloudGovernanceApi.PermissionActionItem()] // [PermissionActionItem] | 
};
apiInstance.saveChangePermissionActions(id, opts, (error, data, response) => {
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


## saveClonePermissionReport

> saveClonePermissionReport(id, opts)

Save clone permission report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'securitySearchResult': [new CloudGovernanceApi.SecuritySearchResult()] // [SecuritySearchResult] | 
};
apiInstance.saveClonePermissionReport(id, opts, (error, data, response) => {
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
 **securitySearchResult** | [**[SecuritySearchResult]**](SecuritySearchResult.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveGetManualArchiveReport

> saveGetManualArchiveReport(id, opts)

save manual archive report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'manuallyArchiveRecordModel': [new CloudGovernanceApi.ManuallyArchiveRecordModel()] // [ManuallyArchiveRecordModel] | 
};
apiInstance.saveGetManualArchiveReport(id, opts, (error, data, response) => {
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
 **manuallyArchiveRecordModel** | [**[ManuallyArchiveRecordModel]**](ManuallyArchiveRecordModel.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveGroupPermissionRecertificationResults

> saveGroupPermissionRecertificationResults(id, opts)

save group permission recertification results

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'groupPermissionActionItem': [new CloudGovernanceApi.GroupPermissionActionItem()] // [GroupPermissionActionItem] | 
};
apiInstance.saveGroupPermissionRecertificationResults(id, opts, (error, data, response) => {
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
 **groupPermissionActionItem** | [**[GroupPermissionActionItem]**](GroupPermissionActionItem.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveRemovePermissionReport

> saveRemovePermissionReport(id, opts)

save remove permission report

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'securitySearchResult': [new CloudGovernanceApi.SecuritySearchResult()] // [SecuritySearchResult] | 
};
apiInstance.saveRemovePermissionReport(id, opts, (error, data, response) => {
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
 **securitySearchResult** | [**[SecuritySearchResult]**](SecuritySearchResult.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveSiteMetadataRecertificationResult

> saveSiteMetadataRecertificationResult(id, opts)

save site metadata recertification metadata

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'requestMetadata': [new CloudGovernanceApi.RequestMetadata()] // [RequestMetadata] | 
};
apiInstance.saveSiteMetadataRecertificationResult(id, opts, (error, data, response) => {
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
 **requestMetadata** | [**[RequestMetadata]**](RequestMetadata.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## saveSitePermissionRecertificationResult

> saveSitePermissionRecertificationResult(id, opts)

save site permission recertification permissions

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'permissionActionItem': [new CloudGovernanceApi.PermissionActionItem()] // [PermissionActionItem] | 
};
apiInstance.saveSitePermissionRecertificationResult(id, opts, (error, data, response) => {
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


## skipErrorTask

> skipErrorTask(id, opts)

skip error task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.skipErrorTask(id, opts, (error, data, response) => {
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
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## specifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived

> specifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived(id, opts)

specify primary and secondary contact when primary contact is deactived

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'primarycontact': "primarycontact_example", // String | 
  'secondarycontact': "secondarycontact_example", // String | 
  'primarycontactemail': null, // String | 
  'secodnarycontactemail': null // String | 
};
apiInstance.specifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived(id, opts, (error, data, response) => {
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
 **primarycontact** | **String**|  | [optional] 
 **secondarycontact** | **String**|  | [optional] 
 **primarycontactemail** | [**String**](.md)|  | [optional] 
 **secodnarycontactemail** | [**String**](.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## specifySecondaryContactWhenSecondaryContactIsDeactived

> specifySecondaryContactWhenSecondaryContactIsDeactived(id, opts)

specify secondary contact when secondary contact is deactived

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'secondarycontact': "secondarycontact_example" // String | 
};
apiInstance.specifySecondaryContactWhenSecondaryContactIsDeactived(id, opts, (error, data, response) => {
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
 **secondarycontact** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## submitArchiveGroupAutoTask

> submitArchiveGroupAutoTask(opts)

submit archive group auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskArchiveRequest': new CloudGovernanceApi.AutoTaskArchiveRequest() // AutoTaskArchiveRequest | 
};
apiInstance.submitArchiveGroupAutoTask(opts, (error, data, response) => {
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
 **autoTaskArchiveRequest** | [**AutoTaskArchiveRequest**](AutoTaskArchiveRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitArchiveSiteAutoTask

> submitArchiveSiteAutoTask(opts)

submit site archive auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskArchiveRequest': new CloudGovernanceApi.AutoTaskArchiveRequest() // AutoTaskArchiveRequest | 
};
apiInstance.submitArchiveSiteAutoTask(opts, (error, data, response) => {
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
 **autoTaskArchiveRequest** | [**AutoTaskArchiveRequest**](AutoTaskArchiveRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitChangeSitePolicyAutoTask

> submitChangeSitePolicyAutoTask(opts)

submit site policy change auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskChangePolicyRequest': new CloudGovernanceApi.AutoTaskChangePolicyRequest() // AutoTaskChangePolicyRequest | 
};
apiInstance.submitChangeSitePolicyAutoTask(opts, (error, data, response) => {
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
 **autoTaskChangePolicyRequest** | [**AutoTaskChangePolicyRequest**](AutoTaskChangePolicyRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitContinueAccessGroupAutoTask

> submitContinueAccessGroupAutoTask(opts)

submit group continue access auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'id': null, // String | 
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.submitContinueAccessGroupAutoTask(opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | [optional] 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitContinueAccessSiteAutoTask

> submitContinueAccessSiteAutoTask(opts)

submit site continue access auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'id': null, // String | 
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.submitContinueAccessSiteAutoTask(opts, (error, data, response) => {
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
 **id** | [**String**](.md)|  | [optional] 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitDeleteGroupAutoTask

> submitDeleteGroupAutoTask(opts)

submit delete group auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskDeleteRequest': new CloudGovernanceApi.AutoTaskDeleteRequest() // AutoTaskDeleteRequest | 
};
apiInstance.submitDeleteGroupAutoTask(opts, (error, data, response) => {
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
 **autoTaskDeleteRequest** | [**AutoTaskDeleteRequest**](AutoTaskDeleteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitDeleteSiteAutoTask

> submitDeleteSiteAutoTask(opts)

submit site delete auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskDeleteRequest': new CloudGovernanceApi.AutoTaskDeleteRequest() // AutoTaskDeleteRequest | 
};
apiInstance.submitDeleteSiteAutoTask(opts, (error, data, response) => {
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
 **autoTaskDeleteRequest** | [**AutoTaskDeleteRequest**](AutoTaskDeleteRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitExtendGroupAutoTask

> submitExtendGroupAutoTask(opts)

submit extend group auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskExtendRequest': new CloudGovernanceApi.AutoTaskExtendRequest() // AutoTaskExtendRequest | 
};
apiInstance.submitExtendGroupAutoTask(opts, (error, data, response) => {
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
 **autoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitExtendSiteAutoTask

> submitExtendSiteAutoTask(opts)

submit site extend auto task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let opts = {
  'autoTaskExtendRequest': new CloudGovernanceApi.AutoTaskExtendRequest() // AutoTaskExtendRequest | 
};
apiInstance.submitExtendSiteAutoTask(opts, (error, data, response) => {
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
 **autoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## submitRecertificationTask

> submitRecertificationTask(id, opts)

submit site/group recertification task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
let opts = {
  'commentsParam': new CloudGovernanceApi.CommentsParam() // CommentsParam | 
};
apiInstance.submitRecertificationTask(id, opts, (error, data, response) => {
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
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: Not defined


## viewSiteOwnershipRecertificationTask

> OwnershipRecertification viewSiteOwnershipRecertificationTask(id)

view site ownership recertification task

### Example

```javascript
import CloudGovernanceApi from 'cloud_governance_api';
let defaultClient = CloudGovernanceApi.ApiClient.instance;
// Configure API key authorization: BearerAuth
let BearerAuth = defaultClient.authentications['BearerAuth'];
BearerAuth.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//BearerAuth.apiKeyPrefix = 'Token';

let apiInstance = new CloudGovernanceApi.TasksApi();
let id = null; // String | 
apiInstance.viewSiteOwnershipRecertificationTask(id, (error, data, response) => {
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

[**OwnershipRecertification**](OwnershipRecertification.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

