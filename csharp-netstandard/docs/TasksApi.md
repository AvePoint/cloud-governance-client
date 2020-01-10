# Cloud.Governance.Client.Api.TasksApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMembersForGroupMembershipRecertification**](TasksApi.md#addmembersforgroupmembershiprecertification) | **POST** /tasks/{id}/group/recertification/membership/members | add members for group membership recertification
[**AddOwnersForGroupMembershipRecertification**](TasksApi.md#addownersforgroupmembershiprecertification) | **POST** /tasks/{id}/group/recertification/membership/owners | add owners for group membership recertification
[**ApproveTask**](TasksApi.md#approvetask) | **POST** /tasks/{id}/approve | approve task
[**ClaimElectionTask**](TasksApi.md#claimelectiontask) | **POST** /tasks/{id}/election/claim | claim election task
[**ClaimSiteOwnershipRecertificationTask**](TasksApi.md#claimsiteownershiprecertificationtask) | **POST** /tasks/{id}/site/recertification/ownership/claim/{secondarycontact} | claim site ownership recertification task
[**DeclineElectionTask**](TasksApi.md#declineelectiontask) | **POST** /tasks/{id}/election/decline | decline election task
[**DeclineSiteOwnershipRecertificationTask**](TasksApi.md#declinesiteownershiprecertificationtask) | **POST** /tasks/{id}/site/recertification/ownership/decline | decline site ownership recertification task
[**DemoteAsMembersForGroupMembershipRecertification**](TasksApi.md#demoteasmembersforgroupmembershiprecertification) | **POST** /tasks/{id}/group/recertification/membership/demoteasmember | demote as members for group membership recertification
[**EditArchiveGroupRequest**](TasksApi.md#editarchivegrouprequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
[**EditArchiveSiteRequest**](TasksApi.md#editarchivesiterequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
[**EditArchiveWebRequest**](TasksApi.md#editarchivewebrequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
[**EditChangeGroupPolicyRequest**](TasksApi.md#editchangegrouppolicyrequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
[**EditChangeGroupQuotaRequest**](TasksApi.md#editchangegroupquotarequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
[**EditChangeGroupRequest**](TasksApi.md#editchangegrouprequest) | **PUT** /tasks/{id}/changegroup | edit create change group request in task
[**EditChangeListSettingRequest**](TasksApi.md#editchangelistsettingrequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
[**EditChangePermissionRequest**](TasksApi.md#editchangepermissionrequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
[**EditChangeSiteContactRequest**](TasksApi.md#editchangesitecontactrequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request in task
[**EditChangeSitePolicyRequest**](TasksApi.md#editchangesitepolicyrequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
[**EditChangeSiteQuotaRequest**](TasksApi.md#editchangesitequotarequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
[**EditChangeSiteSettingRequest**](TasksApi.md#editchangesitesettingrequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request in task
[**EditChangeWebContactRequest**](TasksApi.md#editchangewebcontactrequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
[**EditChangeWebSettingRequest**](TasksApi.md#editchangewebsettingrequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
[**EditClonePermissionRequest**](TasksApi.md#editclonepermissionrequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request in task
[**EditContentMoveRequest**](TasksApi.md#editcontentmoverequest) | **PUT** /tasks/{id}/contentmove | edit content move request in task
[**EditCreateGroupRequest**](TasksApi.md#editcreategrouprequest) | **PUT** /tasks/{id}/creategroup | edit create site group request in task
[**EditCreateListRequest**](TasksApi.md#editcreatelistrequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
[**EditCreateSiteRequest**](TasksApi.md#editcreatesiterequest) | **PUT** /tasks/{id}/createsite | edit create site request in task
[**EditCreateWebRequest**](TasksApi.md#editcreatewebrequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
[**EditCustomRequest**](TasksApi.md#editcustomrequest) | **PUT** /tasks/{id}/custom | edit custom request in task
[**EditDeleteGroupRequest**](TasksApi.md#editdeletegrouprequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
[**EditDeleteSiteRequest**](TasksApi.md#editdeletesiterequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
[**EditDeleteWebRequest**](TasksApi.md#editdeletewebrequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
[**EditExtendGroupRequest**](TasksApi.md#editextendgrouprequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
[**EditExtendSiteRequest**](TasksApi.md#editextendsiterequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
[**EditGrantPermissionRequest**](TasksApi.md#editgrantpermissionrequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
[**EditLockSiteRequest**](TasksApi.md#editlocksiterequest) | **PUT** /tasks/{id}/locksite | edit lock site request in task
[**EditManagePermissionRequest**](TasksApi.md#editmanagepermissionrequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request in task
[**EditRestoreGroupRequest**](TasksApi.md#editrestoregrouprequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
[**EditUnLockSiteRequest**](TasksApi.md#editunlocksiterequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request in task
[**GetChangePermissionReport**](TasksApi.md#getchangepermissionreport) | **GET** /tasks/changepermission/{id}/permission | get change permission report
[**GetChangePermissionReportByVersion**](TasksApi.md#getchangepermissionreportbyversion) | **GET** /tasks/changepermission/{id}/permission/{version} | get change permission report with specific version
[**GetChangePermissionReportFilters**](TasksApi.md#getchangepermissionreportfilters) | **GET** /tasks/changepermission/{id}/permission/filters | get change permission report filters
[**GetChangePermissionReportFiltersByVersion**](TasksApi.md#getchangepermissionreportfiltersbyversion) | **GET** /tasks/changepermission/{id}/permission/filters/{version} | get change permission report filters with specific version
[**GetChangePermissionReportFiltersForSPGroup**](TasksApi.md#getchangepermissionreportfiltersforspgroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters | get change permission report filters for a sharepoint group
[**GetChangePermissionReportFiltersForSPGroupByVersion**](TasksApi.md#getchangepermissionreportfiltersforspgroupbyversion) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters/{version} | get change permission report filters for a sharepoint group with specific version
[**GetChangePermissionReportForSPGroup**](TasksApi.md#getchangepermissionreportforspgroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid} | get change permission report for a sharepoint group
[**GetChangePermissionReportForSPGroupByVersion**](TasksApi.md#getchangepermissionreportforspgroupbyversion) | **GET** /tasks/changepermission/{id}/permission/{version}/group/{groupid} | get change permission report for a sharepoint group with specific version
[**GetChangePermissionReportPermissionLevels**](TasksApi.md#getchangepermissionreportpermissionlevels) | **GET** /tasks/changepermission/{id}/permissionlevels | get change permission report permission levels
[**GetChangePermissionReportProperties**](TasksApi.md#getchangepermissionreportproperties) | **GET** /tasks/changepermission/{id}/properties | get change permission report properties
[**GetClonePermissionReport**](TasksApi.md#getclonepermissionreport) | **GET** /tasks/clonepermission/{id}/permission | get clone permission report
[**GetClonePermissionReportProperties**](TasksApi.md#getclonepermissionreportproperties) | **GET** /tasks/clonepermission/{id}/properties | get clone permission report properties
[**GetGetManualArchiveReport**](TasksApi.md#getgetmanualarchivereport) | **GET** /tasks/{id}/manualarchive | get manual archive report
[**GetGetManualArchiveReportFilters**](TasksApi.md#getgetmanualarchivereportfilters) | **GET** /tasks/{id}/manualarchive/filters | get manual archive report filters
[**GetGroupMembershipRecertificationReport**](TasksApi.md#getgroupmembershiprecertificationreport) | **GET** /tasks/{id}/group/recertification/membership | get group membership recertification report
[**GetGroupMembershipRecertificationReportByVersion**](TasksApi.md#getgroupmembershiprecertificationreportbyversion) | **GET** /tasks/{id}/group/recertification/membership/{version} | get group membership recertification report by version
[**GetGroupMembershipRecertificationReportFilters**](TasksApi.md#getgroupmembershiprecertificationreportfilters) | **GET** /tasks/{id}/group/recertification/membership/filters | get group membership recertification report filters
[**GetGroupMembershipRecertificationReportFiltersByVersion**](TasksApi.md#getgroupmembershiprecertificationreportfiltersbyversion) | **GET** /tasks/{id}/group/recertification/membership/filters/{version} | get group membership recertification report filters by version
[**GetGroupMembershipRecertificationReportProperties**](TasksApi.md#getgroupmembershiprecertificationreportproperties) | **GET** /tasks/{id}/group/recertification/membership/properties | get group membership recertification report properties
[**GetGroupPermissionRecertificationReport**](TasksApi.md#getgrouppermissionrecertificationreport) | **GET** /tasks/{id}/group/recertification/permission | get group permission recertification report
[**GetGroupPermissionRecertificationReportByVersion**](TasksApi.md#getgrouppermissionrecertificationreportbyversion) | **GET** /tasks/{id}/group/recertification/permission/{version} | get group permission recertification report by version
[**GetGroupPermissionRecertificationReportFilters**](TasksApi.md#getgrouppermissionrecertificationreportfilters) | **GET** /tasks/{id}/group/recertification/permission/filters | get group permission recertification report filters
[**GetGroupPermissionRecertificationReportFiltersForSPGroup**](TasksApi.md#getgrouppermissionrecertificationreportfiltersforspgroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid}/filters | get group permission recertification report filters for sharepoint group
[**GetGroupPermissionRecertificationReportForSPGroup**](TasksApi.md#getgrouppermissionrecertificationreportforspgroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid} | get group permission recertification report for sharepoint group
[**GetGroupPermissionRecertificationReportProperties**](TasksApi.md#getgrouppermissionrecertificationreportproperties) | **GET** /tasks/{id}/group/recertification/permission/properties | get group permission recertification report properties
[**GetMyTaskFilters**](TasksApi.md#getmytaskfilters) | **GET** /tasks/my/filters | get my task filters
[**GetMyTasks**](TasksApi.md#getmytasks) | **GET** /tasks/my | get my tasks
[**GetRemovePermissionReport**](TasksApi.md#getremovepermissionreport) | **GET** /tasks/removepermission/{id}/permission | get remove permission report
[**GetRemovePermissionReportProperties**](TasksApi.md#getremovepermissionreportproperties) | **GET** /tasks/removepermission/{id}/properties | get remove permission report properties
[**GetSiteMetadataRecertificationReport**](TasksApi.md#getsitemetadatarecertificationreport) | **GET** /tasks/{id}/site/recertification/metadata | get site metadata recertification metadata
[**GetSiteMetadataRecertificationReportProperties**](TasksApi.md#getsitemetadatarecertificationreportproperties) | **GET** /tasks/{id}/site/recertification/metadata/properties | get site metadata recertification report properties
[**GetSiteOwnershipRecertificationReportProperties**](TasksApi.md#getsiteownershiprecertificationreportproperties) | **GET** /tasks/{id}/site/recertification/ownership/properties | get site ownership recertification report properties
[**GetSitePermissionRecertificatioPermissionFilters**](TasksApi.md#getsitepermissionrecertificatiopermissionfilters) | **GET** /tasks/{id}/site/recertification/permission/filters | get site permission recertification permission filters
[**GetSitePermissionRecertificatioReportFiltersByVersion**](TasksApi.md#getsitepermissionrecertificatioreportfiltersbyversion) | **GET** /tasks/{id}/site/recertification/permission/filters/{version} | get site permission recertification permission filters with specific version
[**GetSitePermissionRecertificatioReportFiltersForSPGroup**](TasksApi.md#getsitepermissionrecertificatioreportfiltersforspgroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters | 
[**GetSitePermissionRecertificatioReportFiltersForSPGroupByVersion**](TasksApi.md#getsitepermissionrecertificatioreportfiltersforspgroupbyversion) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters/{version} | 
[**GetSitePermissionRecertificationPermissionLevels**](TasksApi.md#getsitepermissionrecertificationpermissionlevels) | **GET** /tasks/{id}/recertification/permissionlevels | get site permission recertification permission levels
[**GetSitePermissionRecertificationReport**](TasksApi.md#getsitepermissionrecertificationreport) | **GET** /tasks/{id}/site/recertification/permission | get site permission recertification report
[**GetSitePermissionRecertificationReportByVersion**](TasksApi.md#getsitepermissionrecertificationreportbyversion) | **GET** /tasks/{id}/site/recertification/permission/{version} | get site permission recertification report by specific version
[**GetSitePermissionRecertificationReportForSPGroup**](TasksApi.md#getsitepermissionrecertificationreportforspgroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid} | get site permission recertification group permission items
[**GetSitePermissionRecertificationReportForSPGroupByVersion**](TasksApi.md#getsitepermissionrecertificationreportforspgroupbyversion) | **GET** /tasks/{id}/site/recertification/permission/{version}/group/{groupid} | get site permission recertification group permission items with specific version with specific version
[**GetSitePermissionRecertificationReportProperties**](TasksApi.md#getsitepermissionrecertificationreportproperties) | **GET** /tasks/{id}/site/recertification/permission/properties | get site permission recertification report properties
[**GetTaskByBatchId**](TasksApi.md#gettaskbybatchid) | **GET** /tasks/my/{batchid} | get task by batch id
[**GetTaskById**](TasksApi.md#gettaskbyid) | **GET** /tasks/{id} | get my task by id
[**PromoteAsOwnersForGroupMembershipRecertification**](TasksApi.md#promoteasownersforgroupmembershiprecertification) | **POST** /tasks/{id}/group/recertification/membership/promoteasowner | promote as owners for group membership recertification
[**ReassignTask**](TasksApi.md#reassigntask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
[**RejectTask**](TasksApi.md#rejecttask) | **POST** /tasks/{id}/reject | reject task
[**RemoveUsersForGroupMembershipRecertification**](TasksApi.md#removeusersforgroupmembershiprecertification) | **POST** /tasks/{id}/group/recertification/membership/removeuser | remove users for group membership recertification
[**ReseAllChangesForChangePermissionTask**](TasksApi.md#reseallchangesforchangepermissiontask) | **POST** /tasks/changepermission/{id}/resetallchange | save all changes for change permission task
[**ResetAllChangesForRecertificationTask**](TasksApi.md#resetallchangesforrecertificationtask) | **POST** /tasks/{id}/recertification/resetallchange | reset all changes for site/group recertification task
[**ResetMyChangesForChangePermissionTask**](TasksApi.md#resetmychangesforchangepermissiontask) | **POST** /tasks/changepermission/{id}/resetmychange | save my changes for change permission task
[**ResetMyChangesForRecertificationTask**](TasksApi.md#resetmychangesforrecertificationtask) | **POST** /tasks/{id}/recertification/resetmychange | reset my changes for site/group recertification task
[**RetryErrorTask**](TasksApi.md#retryerrortask) | **POST** /tasks/{id}/retry | retry error task
[**SaveChangePermissionActions**](TasksApi.md#savechangepermissionactions) | **POST** /tasks/changepermission/{id}/permission | save change permission actions
[**SaveClonePermissionReport**](TasksApi.md#saveclonepermissionreport) | **POST** /tasks/clonepermission/{id}/permission | Save clone permission report
[**SaveGetManualArchiveReport**](TasksApi.md#savegetmanualarchivereport) | **POST** /tasks/{id}/manualarchive | save manual archive report
[**SaveGroupPermissionRecertificationResults**](TasksApi.md#savegrouppermissionrecertificationresults) | **POST** /tasks/{id}/group/recertification/permission | save group permission recertification results
[**SaveRemovePermissionReport**](TasksApi.md#saveremovepermissionreport) | **POST** /tasks/removepermission/{id}/permission | save remove permission report
[**SaveSiteMetadataRecertificationResult**](TasksApi.md#savesitemetadatarecertificationresult) | **POST** /tasks/{id}/site/recertification/metadata | save site metadata recertification metadata
[**SaveSitePermissionRecertificationResult**](TasksApi.md#savesitepermissionrecertificationresult) | **POST** /tasks/{id}/site/recertification/permission | save site permission recertification permissions
[**SkipErrorTask**](TasksApi.md#skiperrortask) | **POST** /tasks/{id}/skip | skip error task
[**SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived**](TasksApi.md#specifyprimaryandsecondarycontactwhenprimarycontactisdeactived) | **POST** /tasks/{id}/election/specify/contacts | specify primary and secondary contact when primary contact is deactived
[**SpecifySecondaryContactWhenSecondaryContactIsDeactived**](TasksApi.md#specifysecondarycontactwhensecondarycontactisdeactived) | **POST** /tasks/{id}/election/specify/secondarycontact | specify secondary contact when secondary contact is deactived
[**SubmitArchiveGroupAutoTask**](TasksApi.md#submitarchivegroupautotask) | **POST** /tasks/archivegroup | submit archive group auto task
[**SubmitArchiveSiteAutoTask**](TasksApi.md#submitarchivesiteautotask) | **POST** /tasks/archivesite | submit site archive auto task
[**SubmitChangeSitePolicyAutoTask**](TasksApi.md#submitchangesitepolicyautotask) | **POST** /tasks/changesitepolicy | submit site policy change auto task
[**SubmitContinueAccessGroupAutoTask**](TasksApi.md#submitcontinueaccessgroupautotask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
[**SubmitContinueAccessSiteAutoTask**](TasksApi.md#submitcontinueaccesssiteautotask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
[**SubmitDeleteGroupAutoTask**](TasksApi.md#submitdeletegroupautotask) | **POST** /tasks/deletegroup | submit delete group auto task
[**SubmitDeleteSiteAutoTask**](TasksApi.md#submitdeletesiteautotask) | **POST** /tasks/deletesite | submit site delete auto task
[**SubmitExtendGroupAutoTask**](TasksApi.md#submitextendgroupautotask) | **POST** /tasks/extendgroup | submit extend group auto task
[**SubmitExtendSiteAutoTask**](TasksApi.md#submitextendsiteautotask) | **POST** /tasks/extendsite | submit site extend auto task
[**SubmitRecertificationTask**](TasksApi.md#submitrecertificationtask) | **POST** /tasks/{id}/submit | submit site/group recertification task
[**ViewSiteOwnershipRecertificationTask**](TasksApi.md#viewsiteownershiprecertificationtask) | **GET** /tasks/{id}/site/recertification/ownership | view site ownership recertification task


<a name="addmembersforgroupmembershiprecertification"></a>
# **AddMembersForGroupMembershipRecertification**
> void AddMembersForGroupMembershipRecertification (Guid id, List<ApiUser> apiUser)

add members for group membership recertification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class AddMembersForGroupMembershipRecertificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var apiUser = new List<ApiUser>(); // List<ApiUser> | 

            try
            {
                // add members for group membership recertification
                apiInstance.AddMembersForGroupMembershipRecertification(id, apiUser);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddMembersForGroupMembershipRecertification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **apiUser** | [**List&lt;ApiUser&gt;**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addownersforgroupmembershiprecertification"></a>
# **AddOwnersForGroupMembershipRecertification**
> void AddOwnersForGroupMembershipRecertification (Guid id, List<ApiUser> apiUser)

add owners for group membership recertification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class AddOwnersForGroupMembershipRecertificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var apiUser = new List<ApiUser>(); // List<ApiUser> | 

            try
            {
                // add owners for group membership recertification
                apiInstance.AddOwnersForGroupMembershipRecertification(id, apiUser);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddOwnersForGroupMembershipRecertification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **apiUser** | [**List&lt;ApiUser&gt;**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approvetask"></a>
# **ApproveTask**
> void ApproveTask (Guid id, CommentsParam commentsParam = null)

approve task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ApproveTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // approve task
                apiInstance.ApproveTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ApproveTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="claimelectiontask"></a>
# **ClaimElectionTask**
> void ClaimElectionTask (Guid id, string secondarycontact)

claim election task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ClaimElectionTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var secondarycontact = secondarycontact_example;  // string | 

            try
            {
                // claim election task
                apiInstance.ClaimElectionTask(id, secondarycontact);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ClaimElectionTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **secondarycontact** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="claimsiteownershiprecertificationtask"></a>
# **ClaimSiteOwnershipRecertificationTask**
> void ClaimSiteOwnershipRecertificationTask (Guid id, string secondarycontact)

claim site ownership recertification task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ClaimSiteOwnershipRecertificationTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var secondarycontact = secondarycontact_example;  // string | 

            try
            {
                // claim site ownership recertification task
                apiInstance.ClaimSiteOwnershipRecertificationTask(id, secondarycontact);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ClaimSiteOwnershipRecertificationTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **secondarycontact** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="declineelectiontask"></a>
# **DeclineElectionTask**
> void DeclineElectionTask (Guid id)

decline election task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeclineElectionTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // decline election task
                apiInstance.DeclineElectionTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeclineElectionTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="declinesiteownershiprecertificationtask"></a>
# **DeclineSiteOwnershipRecertificationTask**
> void DeclineSiteOwnershipRecertificationTask (Guid id)

decline site ownership recertification task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeclineSiteOwnershipRecertificationTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // decline site ownership recertification task
                apiInstance.DeclineSiteOwnershipRecertificationTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeclineSiteOwnershipRecertificationTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="demoteasmembersforgroupmembershiprecertification"></a>
# **DemoteAsMembersForGroupMembershipRecertification**
> void DemoteAsMembersForGroupMembershipRecertification (Guid id, List<ApiUser> apiUser)

demote as members for group membership recertification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DemoteAsMembersForGroupMembershipRecertificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var apiUser = new List<ApiUser>(); // List<ApiUser> | 

            try
            {
                // demote as members for group membership recertification
                apiInstance.DemoteAsMembersForGroupMembershipRecertification(id, apiUser);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DemoteAsMembersForGroupMembershipRecertification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **apiUser** | [**List&lt;ApiUser&gt;**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editarchivegrouprequest"></a>
# **EditArchiveGroupRequest**
> void EditArchiveGroupRequest (Guid id, ArchiveGroupRequest archiveGroupRequest = null)

edit archive group request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditArchiveGroupRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var archiveGroupRequest = new ArchiveGroupRequest(); // ArchiveGroupRequest |  (optional) 

            try
            {
                // edit archive group request in task
                apiInstance.EditArchiveGroupRequest(id, archiveGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditArchiveGroupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **archiveGroupRequest** | [**ArchiveGroupRequest**](ArchiveGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editarchivesiterequest"></a>
# **EditArchiveSiteRequest**
> void EditArchiveSiteRequest (Guid id, ArchiveSiteRequest archiveSiteRequest = null)

edit archive site request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditArchiveSiteRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var archiveSiteRequest = new ArchiveSiteRequest(); // ArchiveSiteRequest |  (optional) 

            try
            {
                // edit archive site request in task
                apiInstance.EditArchiveSiteRequest(id, archiveSiteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditArchiveSiteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **archiveSiteRequest** | [**ArchiveSiteRequest**](ArchiveSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editarchivewebrequest"></a>
# **EditArchiveWebRequest**
> void EditArchiveWebRequest (Guid id, ArchiveWebLifecycleRequest archiveWebLifecycleRequest = null)

edit archive web request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditArchiveWebRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var archiveWebLifecycleRequest = new ArchiveWebLifecycleRequest(); // ArchiveWebLifecycleRequest |  (optional) 

            try
            {
                // edit archive web request in task
                apiInstance.EditArchiveWebRequest(id, archiveWebLifecycleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditArchiveWebRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **archiveWebLifecycleRequest** | [**ArchiveWebLifecycleRequest**](ArchiveWebLifecycleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangegrouppolicyrequest"></a>
# **EditChangeGroupPolicyRequest**
> void EditChangeGroupPolicyRequest (Guid id, ChangeGroupPolicyRequest changeGroupPolicyRequest = null)

edit change group policy request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeGroupPolicyRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeGroupPolicyRequest = new ChangeGroupPolicyRequest(); // ChangeGroupPolicyRequest |  (optional) 

            try
            {
                // edit change group policy request in task
                apiInstance.EditChangeGroupPolicyRequest(id, changeGroupPolicyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeGroupPolicyRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeGroupPolicyRequest** | [**ChangeGroupPolicyRequest**](ChangeGroupPolicyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangegroupquotarequest"></a>
# **EditChangeGroupQuotaRequest**
> void EditChangeGroupQuotaRequest (Guid id, ChangeGroupQuotaRequest changeGroupQuotaRequest = null)

edit change group quota request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeGroupQuotaRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeGroupQuotaRequest = new ChangeGroupQuotaRequest(); // ChangeGroupQuotaRequest |  (optional) 

            try
            {
                // edit change group quota request in task
                apiInstance.EditChangeGroupQuotaRequest(id, changeGroupQuotaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeGroupQuotaRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeGroupQuotaRequest** | [**ChangeGroupQuotaRequest**](ChangeGroupQuotaRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangegrouprequest"></a>
# **EditChangeGroupRequest**
> void EditChangeGroupRequest (Guid id, ChangeGroupSettingRequest changeGroupSettingRequest = null)

edit create change group request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeGroupRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeGroupSettingRequest = new ChangeGroupSettingRequest(); // ChangeGroupSettingRequest |  (optional) 

            try
            {
                // edit create change group request in task
                apiInstance.EditChangeGroupRequest(id, changeGroupSettingRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeGroupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeGroupSettingRequest** | [**ChangeGroupSettingRequest**](ChangeGroupSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangelistsettingrequest"></a>
# **EditChangeListSettingRequest**
> void EditChangeListSettingRequest (Guid id, ChangeListSettingRequest changeListSettingRequest = null)

edit change list setting request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeListSettingRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeListSettingRequest = new ChangeListSettingRequest(); // ChangeListSettingRequest |  (optional) 

            try
            {
                // edit change list setting request in task
                apiInstance.EditChangeListSettingRequest(id, changeListSettingRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeListSettingRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeListSettingRequest** | [**ChangeListSettingRequest**](ChangeListSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangepermissionrequest"></a>
# **EditChangePermissionRequest**
> void EditChangePermissionRequest (Guid id, ChangePermissionRequest changePermissionRequest = null)

edit change permission request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangePermissionRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changePermissionRequest = new ChangePermissionRequest(); // ChangePermissionRequest |  (optional) 

            try
            {
                // edit change permission request in task
                apiInstance.EditChangePermissionRequest(id, changePermissionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangePermissionRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changePermissionRequest** | [**ChangePermissionRequest**](ChangePermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangesitecontactrequest"></a>
# **EditChangeSiteContactRequest**
> void EditChangeSiteContactRequest (Guid id, ChangeSiteContactRequest changeSiteContactRequest = null)

edit change site administrator/contact request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeSiteContactRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeSiteContactRequest = new ChangeSiteContactRequest(); // ChangeSiteContactRequest |  (optional) 

            try
            {
                // edit change site administrator/contact request in task
                apiInstance.EditChangeSiteContactRequest(id, changeSiteContactRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeSiteContactRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeSiteContactRequest** | [**ChangeSiteContactRequest**](ChangeSiteContactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangesitepolicyrequest"></a>
# **EditChangeSitePolicyRequest**
> void EditChangeSitePolicyRequest (Guid id, ChangeSitePolicyRequest changeSitePolicyRequest = null)

edit change site policy request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeSitePolicyRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeSitePolicyRequest = new ChangeSitePolicyRequest(); // ChangeSitePolicyRequest |  (optional) 

            try
            {
                // edit change site policy request in task
                apiInstance.EditChangeSitePolicyRequest(id, changeSitePolicyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeSitePolicyRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeSitePolicyRequest** | [**ChangeSitePolicyRequest**](ChangeSitePolicyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangesitequotarequest"></a>
# **EditChangeSiteQuotaRequest**
> void EditChangeSiteQuotaRequest (Guid id, ChangeSiteQuotaRequest changeSiteQuotaRequest = null)

edit change site quota request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeSiteQuotaRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeSiteQuotaRequest = new ChangeSiteQuotaRequest(); // ChangeSiteQuotaRequest |  (optional) 

            try
            {
                // edit change site quota request in task
                apiInstance.EditChangeSiteQuotaRequest(id, changeSiteQuotaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeSiteQuotaRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeSiteQuotaRequest** | [**ChangeSiteQuotaRequest**](ChangeSiteQuotaRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangesitesettingrequest"></a>
# **EditChangeSiteSettingRequest**
> void EditChangeSiteSettingRequest (Guid id, ChangeSiteSettingRequest changeSiteSettingRequest = null)

edit change site setting request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeSiteSettingRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeSiteSettingRequest = new ChangeSiteSettingRequest(); // ChangeSiteSettingRequest |  (optional) 

            try
            {
                // edit change site setting request in task
                apiInstance.EditChangeSiteSettingRequest(id, changeSiteSettingRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeSiteSettingRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeSiteSettingRequest** | [**ChangeSiteSettingRequest**](ChangeSiteSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangewebcontactrequest"></a>
# **EditChangeWebContactRequest**
> void EditChangeWebContactRequest (Guid id, ChangeWebContactRequest changeWebContactRequest = null)

edit change web contact request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeWebContactRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeWebContactRequest = new ChangeWebContactRequest(); // ChangeWebContactRequest |  (optional) 

            try
            {
                // edit change web contact request in task
                apiInstance.EditChangeWebContactRequest(id, changeWebContactRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeWebContactRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeWebContactRequest** | [**ChangeWebContactRequest**](ChangeWebContactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editchangewebsettingrequest"></a>
# **EditChangeWebSettingRequest**
> void EditChangeWebSettingRequest (Guid id, ChangeWebSettingRequest changeWebSettingRequest = null)

edit change web setting request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditChangeWebSettingRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var changeWebSettingRequest = new ChangeWebSettingRequest(); // ChangeWebSettingRequest |  (optional) 

            try
            {
                // edit change web setting request in task
                apiInstance.EditChangeWebSettingRequest(id, changeWebSettingRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditChangeWebSettingRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **changeWebSettingRequest** | [**ChangeWebSettingRequest**](ChangeWebSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editclonepermissionrequest"></a>
# **EditClonePermissionRequest**
> void EditClonePermissionRequest (Guid id, ClonePermissionRequest clonePermissionRequest = null)

edit clone permission request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditClonePermissionRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var clonePermissionRequest = new ClonePermissionRequest(); // ClonePermissionRequest |  (optional) 

            try
            {
                // edit clone permission request in task
                apiInstance.EditClonePermissionRequest(id, clonePermissionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditClonePermissionRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **clonePermissionRequest** | [**ClonePermissionRequest**](ClonePermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcontentmoverequest"></a>
# **EditContentMoveRequest**
> void EditContentMoveRequest (Guid id, ContentMoveRequest contentMoveRequest = null)

edit content move request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditContentMoveRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var contentMoveRequest = new ContentMoveRequest(); // ContentMoveRequest |  (optional) 

            try
            {
                // edit content move request in task
                apiInstance.EditContentMoveRequest(id, contentMoveRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditContentMoveRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **contentMoveRequest** | [**ContentMoveRequest**](ContentMoveRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcreategrouprequest"></a>
# **EditCreateGroupRequest**
> void EditCreateGroupRequest (Guid id, CreateGroupRequest createGroupRequest = null)

edit create site group request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditCreateGroupRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var createGroupRequest = new CreateGroupRequest(); // CreateGroupRequest |  (optional) 

            try
            {
                // edit create site group request in task
                apiInstance.EditCreateGroupRequest(id, createGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditCreateGroupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **createGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcreatelistrequest"></a>
# **EditCreateListRequest**
> void EditCreateListRequest (Guid id, CreateListRequest createListRequest = null)

edit create list request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditCreateListRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var createListRequest = new CreateListRequest(); // CreateListRequest |  (optional) 

            try
            {
                // edit create list request in task
                apiInstance.EditCreateListRequest(id, createListRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditCreateListRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **createListRequest** | [**CreateListRequest**](CreateListRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcreatesiterequest"></a>
# **EditCreateSiteRequest**
> void EditCreateSiteRequest (Guid id, CreateSiteRequest createSiteRequest = null)

edit create site request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditCreateSiteRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var createSiteRequest = new CreateSiteRequest(); // CreateSiteRequest |  (optional) 

            try
            {
                // edit create site request in task
                apiInstance.EditCreateSiteRequest(id, createSiteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditCreateSiteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **createSiteRequest** | [**CreateSiteRequest**](CreateSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcreatewebrequest"></a>
# **EditCreateWebRequest**
> void EditCreateWebRequest (Guid id, CreateWebRequest createWebRequest = null)

edit create web request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditCreateWebRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var createWebRequest = new CreateWebRequest(); // CreateWebRequest |  (optional) 

            try
            {
                // edit create web request in task
                apiInstance.EditCreateWebRequest(id, createWebRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditCreateWebRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **createWebRequest** | [**CreateWebRequest**](CreateWebRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcustomrequest"></a>
# **EditCustomRequest**
> void EditCustomRequest (Guid id, ApiRequest apiRequest = null)

edit custom request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditCustomRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var apiRequest = new ApiRequest(); // ApiRequest |  (optional) 

            try
            {
                // edit custom request in task
                apiInstance.EditCustomRequest(id, apiRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditCustomRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **apiRequest** | [**ApiRequest**](ApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editdeletegrouprequest"></a>
# **EditDeleteGroupRequest**
> void EditDeleteGroupRequest (Guid id, DeleteGroupRequest deleteGroupRequest = null)

edit delete change group request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditDeleteGroupRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var deleteGroupRequest = new DeleteGroupRequest(); // DeleteGroupRequest |  (optional) 

            try
            {
                // edit delete change group request in task
                apiInstance.EditDeleteGroupRequest(id, deleteGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditDeleteGroupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **deleteGroupRequest** | [**DeleteGroupRequest**](DeleteGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editdeletesiterequest"></a>
# **EditDeleteSiteRequest**
> void EditDeleteSiteRequest (Guid id, DeleteSiteRequest deleteSiteRequest = null)

edit delete site request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditDeleteSiteRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var deleteSiteRequest = new DeleteSiteRequest(); // DeleteSiteRequest |  (optional) 

            try
            {
                // edit delete site request in task
                apiInstance.EditDeleteSiteRequest(id, deleteSiteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditDeleteSiteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **deleteSiteRequest** | [**DeleteSiteRequest**](DeleteSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editdeletewebrequest"></a>
# **EditDeleteWebRequest**
> void EditDeleteWebRequest (Guid id, DeleteWebLifecycleRequest deleteWebLifecycleRequest = null)

edit delete web request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditDeleteWebRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var deleteWebLifecycleRequest = new DeleteWebLifecycleRequest(); // DeleteWebLifecycleRequest |  (optional) 

            try
            {
                // edit delete web request in task
                apiInstance.EditDeleteWebRequest(id, deleteWebLifecycleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditDeleteWebRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **deleteWebLifecycleRequest** | [**DeleteWebLifecycleRequest**](DeleteWebLifecycleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editextendgrouprequest"></a>
# **EditExtendGroupRequest**
> void EditExtendGroupRequest (Guid id, ExtendGroupRequest extendGroupRequest = null)

edit extend group request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditExtendGroupRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var extendGroupRequest = new ExtendGroupRequest(); // ExtendGroupRequest |  (optional) 

            try
            {
                // edit extend group request in task
                apiInstance.EditExtendGroupRequest(id, extendGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditExtendGroupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **extendGroupRequest** | [**ExtendGroupRequest**](ExtendGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editextendsiterequest"></a>
# **EditExtendSiteRequest**
> void EditExtendSiteRequest (Guid id, ExtendSiteRequest extendSiteRequest = null)

edit extend site request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditExtendSiteRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var extendSiteRequest = new ExtendSiteRequest(); // ExtendSiteRequest |  (optional) 

            try
            {
                // edit extend site request in task
                apiInstance.EditExtendSiteRequest(id, extendSiteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditExtendSiteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **extendSiteRequest** | [**ExtendSiteRequest**](ExtendSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editgrantpermissionrequest"></a>
# **EditGrantPermissionRequest**
> void EditGrantPermissionRequest (Guid id, GrantPermissionRequest grantPermissionRequest = null)

edit grant permission request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditGrantPermissionRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var grantPermissionRequest = new GrantPermissionRequest(); // GrantPermissionRequest |  (optional) 

            try
            {
                // edit grant permission request in task
                apiInstance.EditGrantPermissionRequest(id, grantPermissionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditGrantPermissionRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **grantPermissionRequest** | [**GrantPermissionRequest**](GrantPermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editlocksiterequest"></a>
# **EditLockSiteRequest**
> void EditLockSiteRequest (Guid id, LockSiteRequest lockSiteRequest = null)

edit lock site request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditLockSiteRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var lockSiteRequest = new LockSiteRequest(); // LockSiteRequest |  (optional) 

            try
            {
                // edit lock site request in task
                apiInstance.EditLockSiteRequest(id, lockSiteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditLockSiteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **lockSiteRequest** | [**LockSiteRequest**](LockSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editmanagepermissionrequest"></a>
# **EditManagePermissionRequest**
> void EditManagePermissionRequest (Guid id, ManagePermissionRequest managePermissionRequest = null)

edit manage permission request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditManagePermissionRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var managePermissionRequest = new ManagePermissionRequest(); // ManagePermissionRequest |  (optional) 

            try
            {
                // edit manage permission request in task
                apiInstance.EditManagePermissionRequest(id, managePermissionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditManagePermissionRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **managePermissionRequest** | [**ManagePermissionRequest**](ManagePermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editrestoregrouprequest"></a>
# **EditRestoreGroupRequest**
> void EditRestoreGroupRequest (Guid id, RestoreGroupRequest restoreGroupRequest = null)

edit restore group request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditRestoreGroupRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var restoreGroupRequest = new RestoreGroupRequest(); // RestoreGroupRequest |  (optional) 

            try
            {
                // edit restore group request in task
                apiInstance.EditRestoreGroupRequest(id, restoreGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditRestoreGroupRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **restoreGroupRequest** | [**RestoreGroupRequest**](RestoreGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editunlocksiterequest"></a>
# **EditUnLockSiteRequest**
> void EditUnLockSiteRequest (Guid id, UnlockSiteRequest unlockSiteRequest = null)

edit unlock site request in task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class EditUnLockSiteRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var unlockSiteRequest = new UnlockSiteRequest(); // UnlockSiteRequest |  (optional) 

            try
            {
                // edit unlock site request in task
                apiInstance.EditUnLockSiteRequest(id, unlockSiteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.EditUnLockSiteRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **unlockSiteRequest** | [**UnlockSiteRequest**](UnlockSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreport"></a>
# **GetChangePermissionReport**
> PermissionActionItemPageResult GetChangePermissionReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get change permission report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report
                PermissionActionItemPageResult result = apiInstance.GetChangePermissionReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportbyversion"></a>
# **GetChangePermissionReportByVersion**
> PermissionActionItemPageResult GetChangePermissionReportByVersion (Guid id, long version, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get change permission report with specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 789;  // long | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report with specific version
                PermissionActionItemPageResult result = apiInstance.GetChangePermissionReportByVersion(id, version, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportfilters"></a>
# **GetChangePermissionReportFilters**
> DistinctPageResult GetChangePermissionReportFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get change permission report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report filters
                DistinctPageResult result = apiInstance.GetChangePermissionReportFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportfiltersbyversion"></a>
# **GetChangePermissionReportFiltersByVersion**
> DistinctPageResult GetChangePermissionReportFiltersByVersion (Guid id, long version, string filter = null, string distinct = null, int? top = null, int? skip = null)

get change permission report filters with specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportFiltersByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 789;  // long | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report filters with specific version
                DistinctPageResult result = apiInstance.GetChangePermissionReportFiltersByVersion(id, version, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportFiltersByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportfiltersforspgroup"></a>
# **GetChangePermissionReportFiltersForSPGroup**
> DistinctPageResult GetChangePermissionReportFiltersForSPGroup (Guid id, Guid groupid, string filter = null, string distinct = null, int? top = null, int? skip = null)

get change permission report filters for a sharepoint group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportFiltersForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report filters for a sharepoint group
                DistinctPageResult result = apiInstance.GetChangePermissionReportFiltersForSPGroup(id, groupid, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportFiltersForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportfiltersforspgroupbyversion"></a>
# **GetChangePermissionReportFiltersForSPGroupByVersion**
> DistinctPageResult GetChangePermissionReportFiltersForSPGroupByVersion (Guid id, Guid groupid, long version, string filter = null, string distinct = null, int? top = null, int? skip = null)

get change permission report filters for a sharepoint group with specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportFiltersForSPGroupByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var version = 789;  // long | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report filters for a sharepoint group with specific version
                DistinctPageResult result = apiInstance.GetChangePermissionReportFiltersForSPGroupByVersion(id, groupid, version, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportFiltersForSPGroupByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportforspgroup"></a>
# **GetChangePermissionReportForSPGroup**
> PermissionActionItemPageResult GetChangePermissionReportForSPGroup (Guid id, Guid groupid, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get change permission report for a sharepoint group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report for a sharepoint group
                PermissionActionItemPageResult result = apiInstance.GetChangePermissionReportForSPGroup(id, groupid, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportforspgroupbyversion"></a>
# **GetChangePermissionReportForSPGroupByVersion**
> PermissionActionItemPageResult GetChangePermissionReportForSPGroupByVersion (Guid id, long version, Guid groupid, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get change permission report for a sharepoint group with specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportForSPGroupByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 789;  // long | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get change permission report for a sharepoint group with specific version
                PermissionActionItemPageResult result = apiInstance.GetChangePermissionReportForSPGroupByVersion(id, version, groupid, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportForSPGroupByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportpermissionlevels"></a>
# **GetChangePermissionReportPermissionLevels**
> List&lt;PermissionLevel&gt; GetChangePermissionReportPermissionLevels (Guid id)

get change permission report permission levels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportPermissionLevelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get change permission report permission levels
                List<PermissionLevel> result = apiInstance.GetChangePermissionReportPermissionLevels(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportPermissionLevels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;PermissionLevel&gt;**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangepermissionreportproperties"></a>
# **GetChangePermissionReportProperties**
> RecertificationReportProperties GetChangePermissionReportProperties (Guid id)

get change permission report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetChangePermissionReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get change permission report properties
                RecertificationReportProperties result = apiInstance.GetChangePermissionReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetChangePermissionReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclonepermissionreport"></a>
# **GetClonePermissionReport**
> ClonePermissionSecuritySearchResultPageResult GetClonePermissionReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get clone permission report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetClonePermissionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) 
            var search = search_example;  // string | Search for  (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get clone permission report
                ClonePermissionSecuritySearchResultPageResult result = apiInstance.GetClonePermissionReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetClonePermissionReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **search** | **string**| Search for  | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**ClonePermissionSecuritySearchResultPageResult**](ClonePermissionSecuritySearchResultPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclonepermissionreportproperties"></a>
# **GetClonePermissionReportProperties**
> ClonePermissionReportProperty GetClonePermissionReportProperties (Guid id)

get clone permission report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetClonePermissionReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get clone permission report properties
                ClonePermissionReportProperty result = apiInstance.GetClonePermissionReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetClonePermissionReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**ClonePermissionReportProperty**](ClonePermissionReportProperty.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgetmanualarchivereport"></a>
# **GetGetManualArchiveReport**
> ManuallyArchiveRecordModelPageResult GetGetManualArchiveReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get manual archive report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGetManualArchiveReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> rowKey, partitionKey, siteId, url, nodeType (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> rowKey, partitionKey, siteId, url, nodeType (optional) 
            var search = search_example;  // string | Search for url (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get manual archive report
                ManuallyArchiveRecordModelPageResult result = apiInstance.GetGetManualArchiveReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGetManualArchiveReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **search** | **string**| Search for url | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**ManuallyArchiveRecordModelPageResult**](ManuallyArchiveRecordModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgetmanualarchivereportfilters"></a>
# **GetGetManualArchiveReportFilters**
> DistinctPageResult GetGetManualArchiveReportFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get manual archive report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGetManualArchiveReportFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> rowKey, partitionKey, siteId, url, nodeType (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> rowKey, partitionKey, siteId, url, nodeType (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get manual archive report filters
                DistinctPageResult result = apiInstance.GetGetManualArchiveReportFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGetManualArchiveReportFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembershiprecertificationreport"></a>
# **GetGroupMembershipRecertificationReport**
> MembershipRecertificationItemPageResult GetGroupMembershipRecertificationReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get group membership recertification report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembershipRecertificationReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var search = search_example;  // string | Search for user (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group membership recertification report
                MembershipRecertificationItemPageResult result = apiInstance.GetGroupMembershipRecertificationReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupMembershipRecertificationReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **search** | **string**| Search for user | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**MembershipRecertificationItemPageResult**](MembershipRecertificationItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembershiprecertificationreportbyversion"></a>
# **GetGroupMembershipRecertificationReportByVersion**
> MembershipRecertificationItemPageResult GetGroupMembershipRecertificationReportByVersion (Guid id, int version, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get group membership recertification report by version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembershipRecertificationReportByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 56;  // int | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var search = search_example;  // string | Search for user (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group membership recertification report by version
                MembershipRecertificationItemPageResult result = apiInstance.GetGroupMembershipRecertificationReportByVersion(id, version, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupMembershipRecertificationReportByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **int**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **search** | **string**| Search for user | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**MembershipRecertificationItemPageResult**](MembershipRecertificationItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembershiprecertificationreportfilters"></a>
# **GetGroupMembershipRecertificationReportFilters**
> DistinctPageResult GetGroupMembershipRecertificationReportFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get group membership recertification report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembershipRecertificationReportFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group membership recertification report filters
                DistinctPageResult result = apiInstance.GetGroupMembershipRecertificationReportFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupMembershipRecertificationReportFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembershiprecertificationreportfiltersbyversion"></a>
# **GetGroupMembershipRecertificationReportFiltersByVersion**
> DistinctPageResult GetGroupMembershipRecertificationReportFiltersByVersion (Guid id, int version, string filter = null, string distinct = null, int? top = null, int? skip = null)

get group membership recertification report filters by version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembershipRecertificationReportFiltersByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 56;  // int | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group membership recertification report filters by version
                DistinctPageResult result = apiInstance.GetGroupMembershipRecertificationReportFiltersByVersion(id, version, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupMembershipRecertificationReportFiltersByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **int**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembershiprecertificationreportproperties"></a>
# **GetGroupMembershipRecertificationReportProperties**
> MembershipRecertificationReportProperties GetGroupMembershipRecertificationReportProperties (Guid id)

get group membership recertification report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembershipRecertificationReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group membership recertification report properties
                MembershipRecertificationReportProperties result = apiInstance.GetGroupMembershipRecertificationReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupMembershipRecertificationReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**MembershipRecertificationReportProperties**](MembershipRecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrecertificationreport"></a>
# **GetGroupPermissionRecertificationReport**
> GroupPermissionActionItemPageResult GetGroupPermissionRecertificationReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get group permission recertification report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupPermissionRecertificationReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group permission recertification report
                GroupPermissionActionItemPageResult result = apiInstance.GetGroupPermissionRecertificationReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupPermissionRecertificationReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrecertificationreportbyversion"></a>
# **GetGroupPermissionRecertificationReportByVersion**
> GroupPermissionActionItemPageResult GetGroupPermissionRecertificationReportByVersion (Guid id, int version, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get group permission recertification report by version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupPermissionRecertificationReportByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 56;  // int | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group permission recertification report by version
                GroupPermissionActionItemPageResult result = apiInstance.GetGroupPermissionRecertificationReportByVersion(id, version, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupPermissionRecertificationReportByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **int**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrecertificationreportfilters"></a>
# **GetGroupPermissionRecertificationReportFilters**
> DistinctPageResult GetGroupPermissionRecertificationReportFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get group permission recertification report filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupPermissionRecertificationReportFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group permission recertification report filters
                DistinctPageResult result = apiInstance.GetGroupPermissionRecertificationReportFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupPermissionRecertificationReportFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrecertificationreportfiltersforspgroup"></a>
# **GetGroupPermissionRecertificationReportFiltersForSPGroup**
> DistinctPageResult GetGroupPermissionRecertificationReportFiltersForSPGroup (Guid id, Guid groupid, string filter = null, string distinct = null, int? top = null, int? skip = null)

get group permission recertification report filters for sharepoint group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupPermissionRecertificationReportFiltersForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group permission recertification report filters for sharepoint group
                DistinctPageResult result = apiInstance.GetGroupPermissionRecertificationReportFiltersForSPGroup(id, groupid, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupPermissionRecertificationReportFiltersForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrecertificationreportforspgroup"></a>
# **GetGroupPermissionRecertificationReportForSPGroup**
> GroupPermissionActionItemPageResult GetGroupPermissionRecertificationReportForSPGroup (Guid id, Guid groupid, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get group permission recertification report for sharepoint group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupPermissionRecertificationReportForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get group permission recertification report for sharepoint group
                GroupPermissionActionItemPageResult result = apiInstance.GetGroupPermissionRecertificationReportForSPGroup(id, groupid, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupPermissionRecertificationReportForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouppermissionrecertificationreportproperties"></a>
# **GetGroupPermissionRecertificationReportProperties**
> RecertificationReportProperties GetGroupPermissionRecertificationReportProperties (Guid id)

get group permission recertification report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupPermissionRecertificationReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get group permission recertification report properties
                RecertificationReportProperties result = apiInstance.GetGroupPermissionRecertificationReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetGroupPermissionRecertificationReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytaskfilters"></a>
# **GetMyTaskFilters**
> DistinctPageResult GetMyTaskFilters (bool? isconfirmtask = null, string filter = null, string distinct = null, int? top = null, int? skip = null)

get my task filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetMyTaskFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var isconfirmtask = true;  // bool? |  (optional)  (default to false)
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get my task filters
                DistinctPageResult result = apiInstance.GetMyTaskFilters(isconfirmtask, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetMyTaskFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isconfirmtask** | **bool?**|  | [optional] [default to false]
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytasks"></a>
# **GetMyTasks**
> TaskListPageResult GetMyTasks (bool? isconfirmtask = null, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get my tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetMyTasksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var isconfirmtask = true;  // bool? |  (optional)  (default to false)
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) 
            var search = search_example;  // string | Search for title (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get my tasks
                TaskListPageResult result = apiInstance.GetMyTasks(isconfirmtask, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetMyTasks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isconfirmtask** | **bool?**|  | [optional] [default to false]
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] 
 **search** | **string**| Search for title | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**TaskListPageResult**](TaskListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremovepermissionreport"></a>
# **GetRemovePermissionReport**
> SecuritySearchResultPageResult GetRemovePermissionReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get remove permission report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetRemovePermissionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) 
            var search = search_example;  // string | Search for  (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get remove permission report
                SecuritySearchResultPageResult result = apiInstance.GetRemovePermissionReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetRemovePermissionReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] 
 **search** | **string**| Search for  | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**SecuritySearchResultPageResult**](SecuritySearchResultPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremovepermissionreportproperties"></a>
# **GetRemovePermissionReportProperties**
> RecertificationReportProperties GetRemovePermissionReportProperties (Guid id)

get remove permission report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetRemovePermissionReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get remove permission report properties
                RecertificationReportProperties result = apiInstance.GetRemovePermissionReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetRemovePermissionReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitemetadatarecertificationreport"></a>
# **GetSiteMetadataRecertificationReport**
> List&lt;CustomMetadata&gt; GetSiteMetadataRecertificationReport (Guid id)

get site metadata recertification metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteMetadataRecertificationReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site metadata recertification metadata
                List<CustomMetadata> result = apiInstance.GetSiteMetadataRecertificationReport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSiteMetadataRecertificationReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;CustomMetadata&gt;**](CustomMetadata.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitemetadatarecertificationreportproperties"></a>
# **GetSiteMetadataRecertificationReportProperties**
> MetadataRecertificationReportProperties GetSiteMetadataRecertificationReportProperties (Guid id)

get site metadata recertification report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteMetadataRecertificationReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site metadata recertification report properties
                MetadataRecertificationReportProperties result = apiInstance.GetSiteMetadataRecertificationReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSiteMetadataRecertificationReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**MetadataRecertificationReportProperties**](MetadataRecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsiteownershiprecertificationreportproperties"></a>
# **GetSiteOwnershipRecertificationReportProperties**
> RecertificationReportProperties GetSiteOwnershipRecertificationReportProperties (Guid id)

get site ownership recertification report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteOwnershipRecertificationReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site ownership recertification report properties
                RecertificationReportProperties result = apiInstance.GetSiteOwnershipRecertificationReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSiteOwnershipRecertificationReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificatiopermissionfilters"></a>
# **GetSitePermissionRecertificatioPermissionFilters**
> DistinctPageResult GetSitePermissionRecertificatioPermissionFilters (Guid id, string filter = null, string distinct = null, int? top = null, int? skip = null)

get site permission recertification permission filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificatioPermissionFiltersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission recertification permission filters
                DistinctPageResult result = apiInstance.GetSitePermissionRecertificatioPermissionFilters(id, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificatioPermissionFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificatioreportfiltersbyversion"></a>
# **GetSitePermissionRecertificatioReportFiltersByVersion**
> DistinctPageResult GetSitePermissionRecertificatioReportFiltersByVersion (Guid id, long version, string filter = null, string distinct = null, int? top = null, int? skip = null)

get site permission recertification permission filters with specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificatioReportFiltersByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 789;  // long | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission recertification permission filters with specific version
                DistinctPageResult result = apiInstance.GetSitePermissionRecertificatioReportFiltersByVersion(id, version, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificatioReportFiltersByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificatioreportfiltersforspgroup"></a>
# **GetSitePermissionRecertificatioReportFiltersForSPGroup**
> DistinctPageResult GetSitePermissionRecertificatioReportFiltersForSPGroup (Guid id, Guid groupid, string filter = null, string distinct = null, int? top = null, int? skip = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificatioReportFiltersForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                DistinctPageResult result = apiInstance.GetSitePermissionRecertificatioReportFiltersForSPGroup(id, groupid, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificatioReportFiltersForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificatioreportfiltersforspgroupbyversion"></a>
# **GetSitePermissionRecertificatioReportFiltersForSPGroupByVersion**
> DistinctPageResult GetSitePermissionRecertificatioReportFiltersForSPGroupByVersion (Guid id, Guid groupid, long version, string filter = null, string distinct = null, int? top = null, int? skip = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificatioReportFiltersForSPGroupByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var version = 789;  // long | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                DistinctPageResult result = apiInstance.GetSitePermissionRecertificatioReportFiltersForSPGroupByVersion(id, groupid, version, filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificatioReportFiltersForSPGroupByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificationpermissionlevels"></a>
# **GetSitePermissionRecertificationPermissionLevels**
> List&lt;PermissionLevel&gt; GetSitePermissionRecertificationPermissionLevels (Guid id)

get site permission recertification permission levels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificationPermissionLevelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site permission recertification permission levels
                List<PermissionLevel> result = apiInstance.GetSitePermissionRecertificationPermissionLevels(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificationPermissionLevels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;PermissionLevel&gt;**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificationreport"></a>
# **GetSitePermissionRecertificationReport**
> PermissionActionItemPageResult GetSitePermissionRecertificationReport (Guid id, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get site permission recertification report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificationReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission recertification report
                PermissionActionItemPageResult result = apiInstance.GetSitePermissionRecertificationReport(id, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificationReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificationreportbyversion"></a>
# **GetSitePermissionRecertificationReportByVersion**
> PermissionActionItemPageResult GetSitePermissionRecertificationReportByVersion (Guid id, long version, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get site permission recertification report by specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificationReportByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 789;  // long | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission recertification report by specific version
                PermissionActionItemPageResult result = apiInstance.GetSitePermissionRecertificationReportByVersion(id, version, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificationReportByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificationreportforspgroup"></a>
# **GetSitePermissionRecertificationReportForSPGroup**
> PermissionActionItemPageResult GetSitePermissionRecertificationReportForSPGroup (Guid id, Guid groupid, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get site permission recertification group permission items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificationReportForSPGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission recertification group permission items
                PermissionActionItemPageResult result = apiInstance.GetSitePermissionRecertificationReportForSPGroup(id, groupid, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificationReportForSPGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificationreportforspgroupbyversion"></a>
# **GetSitePermissionRecertificationReportForSPGroupByVersion**
> PermissionActionItemPageResult GetSitePermissionRecertificationReportForSPGroupByVersion (Guid id, long version, Guid groupid, string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get site permission recertification group permission items with specific version with specific version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificationReportForSPGroupByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var version = 789;  // long | 
            var groupid = new Guid(); // Guid | 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) 
            var search = search_example;  // string | Search for displayName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get site permission recertification group permission items with specific version with specific version
                PermissionActionItemPageResult result = apiInstance.GetSitePermissionRecertificationReportForSPGroupByVersion(id, version, groupid, filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificationReportForSPGroupByVersion: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **version** | **long**|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] 
 **search** | **string**| Search for displayName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitepermissionrecertificationreportproperties"></a>
# **GetSitePermissionRecertificationReportProperties**
> RecertificationReportProperties GetSitePermissionRecertificationReportProperties (Guid id)

get site permission recertification report properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionRecertificationReportPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get site permission recertification report properties
                RecertificationReportProperties result = apiInstance.GetSitePermissionRecertificationReportProperties(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSitePermissionRecertificationReportProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskbybatchid"></a>
# **GetTaskByBatchId**
> TaskList GetTaskByBatchId (Guid batchid)

get task by batch id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetTaskByBatchIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var batchid = new Guid(); // Guid | 

            try
            {
                // get task by batch id
                TaskList result = apiInstance.GetTaskByBatchId(batchid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskByBatchId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchid** | [**Guid**](Guid.md)|  | 

### Return type

[**TaskList**](TaskList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskbyid"></a>
# **GetTaskById**
> ApiTask GetTaskById (Guid id)

get my task by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetTaskByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // get my task by id
                ApiTask result = apiInstance.GetTaskById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**ApiTask**](ApiTask.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="promoteasownersforgroupmembershiprecertification"></a>
# **PromoteAsOwnersForGroupMembershipRecertification**
> void PromoteAsOwnersForGroupMembershipRecertification (Guid id, List<ApiUser> apiUser)

promote as owners for group membership recertification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class PromoteAsOwnersForGroupMembershipRecertificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var apiUser = new List<ApiUser>(); // List<ApiUser> | 

            try
            {
                // promote as owners for group membership recertification
                apiInstance.PromoteAsOwnersForGroupMembershipRecertification(id, apiUser);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.PromoteAsOwnersForGroupMembershipRecertification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **apiUser** | [**List&lt;ApiUser&gt;**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reassigntask"></a>
# **ReassignTask**
> void ReassignTask (Guid id, string user)

reassign task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ReassignTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var user = user_example;  // string | 

            try
            {
                // reassign task
                apiInstance.ReassignTask(id, user);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ReassignTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **user** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejecttask"></a>
# **RejectTask**
> void RejectTask (Guid id, CommentsParam commentsParam = null)

reject task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class RejectTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // reject task
                apiInstance.RejectTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RejectTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeusersforgroupmembershiprecertification"></a>
# **RemoveUsersForGroupMembershipRecertification**
> void RemoveUsersForGroupMembershipRecertification (Guid id, List<Guid> requestBody = null)

remove users for group membership recertification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class RemoveUsersForGroupMembershipRecertificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // remove users for group membership recertification
                apiInstance.RemoveUsersForGroupMembershipRecertification(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveUsersForGroupMembershipRecertification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **requestBody** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reseallchangesforchangepermissiontask"></a>
# **ReseAllChangesForChangePermissionTask**
> void ReseAllChangesForChangePermissionTask (Guid id)

save all changes for change permission task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ReseAllChangesForChangePermissionTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // save all changes for change permission task
                apiInstance.ReseAllChangesForChangePermissionTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ReseAllChangesForChangePermissionTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetallchangesforrecertificationtask"></a>
# **ResetAllChangesForRecertificationTask**
> void ResetAllChangesForRecertificationTask (Guid id)

reset all changes for site/group recertification task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ResetAllChangesForRecertificationTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // reset all changes for site/group recertification task
                apiInstance.ResetAllChangesForRecertificationTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ResetAllChangesForRecertificationTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetmychangesforchangepermissiontask"></a>
# **ResetMyChangesForChangePermissionTask**
> void ResetMyChangesForChangePermissionTask (Guid id)

save my changes for change permission task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ResetMyChangesForChangePermissionTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // save my changes for change permission task
                apiInstance.ResetMyChangesForChangePermissionTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ResetMyChangesForChangePermissionTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetmychangesforrecertificationtask"></a>
# **ResetMyChangesForRecertificationTask**
> void ResetMyChangesForRecertificationTask (Guid id)

reset my changes for site/group recertification task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ResetMyChangesForRecertificationTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // reset my changes for site/group recertification task
                apiInstance.ResetMyChangesForRecertificationTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ResetMyChangesForRecertificationTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retryerrortask"></a>
# **RetryErrorTask**
> void RetryErrorTask (Guid id, CommentsParam commentsParam = null)

retry error task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class RetryErrorTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // retry error task
                apiInstance.RetryErrorTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RetryErrorTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savechangepermissionactions"></a>
# **SaveChangePermissionActions**
> void SaveChangePermissionActions (Guid id, List<PermissionActionItem> permissionActionItem)

save change permission actions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveChangePermissionActionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var permissionActionItem = new List<PermissionActionItem>(); // List<PermissionActionItem> | 

            try
            {
                // save change permission actions
                apiInstance.SaveChangePermissionActions(id, permissionActionItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveChangePermissionActions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **permissionActionItem** | [**List&lt;PermissionActionItem&gt;**](PermissionActionItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveclonepermissionreport"></a>
# **SaveClonePermissionReport**
> void SaveClonePermissionReport (Guid id, List<SecuritySearchResult> securitySearchResult)

Save clone permission report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveClonePermissionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var securitySearchResult = new List<SecuritySearchResult>(); // List<SecuritySearchResult> | 

            try
            {
                // Save clone permission report
                apiInstance.SaveClonePermissionReport(id, securitySearchResult);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveClonePermissionReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **securitySearchResult** | [**List&lt;SecuritySearchResult&gt;**](SecuritySearchResult.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savegetmanualarchivereport"></a>
# **SaveGetManualArchiveReport**
> void SaveGetManualArchiveReport (Guid id, List<ManuallyArchiveRecordModel> manuallyArchiveRecordModel)

save manual archive report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveGetManualArchiveReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var manuallyArchiveRecordModel = new List<ManuallyArchiveRecordModel>(); // List<ManuallyArchiveRecordModel> | 

            try
            {
                // save manual archive report
                apiInstance.SaveGetManualArchiveReport(id, manuallyArchiveRecordModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveGetManualArchiveReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **manuallyArchiveRecordModel** | [**List&lt;ManuallyArchiveRecordModel&gt;**](ManuallyArchiveRecordModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savegrouppermissionrecertificationresults"></a>
# **SaveGroupPermissionRecertificationResults**
> void SaveGroupPermissionRecertificationResults (Guid id, List<GroupPermissionActionItem> groupPermissionActionItem)

save group permission recertification results

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveGroupPermissionRecertificationResultsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var groupPermissionActionItem = new List<GroupPermissionActionItem>(); // List<GroupPermissionActionItem> | 

            try
            {
                // save group permission recertification results
                apiInstance.SaveGroupPermissionRecertificationResults(id, groupPermissionActionItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveGroupPermissionRecertificationResults: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **groupPermissionActionItem** | [**List&lt;GroupPermissionActionItem&gt;**](GroupPermissionActionItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveremovepermissionreport"></a>
# **SaveRemovePermissionReport**
> void SaveRemovePermissionReport (Guid id, List<SecuritySearchResult> securitySearchResult)

save remove permission report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveRemovePermissionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var securitySearchResult = new List<SecuritySearchResult>(); // List<SecuritySearchResult> | 

            try
            {
                // save remove permission report
                apiInstance.SaveRemovePermissionReport(id, securitySearchResult);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveRemovePermissionReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **securitySearchResult** | [**List&lt;SecuritySearchResult&gt;**](SecuritySearchResult.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savesitemetadatarecertificationresult"></a>
# **SaveSiteMetadataRecertificationResult**
> void SaveSiteMetadataRecertificationResult (Guid id, List<RequestMetadata> requestMetadata)

save site metadata recertification metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveSiteMetadataRecertificationResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var requestMetadata = new List<RequestMetadata>(); // List<RequestMetadata> | 

            try
            {
                // save site metadata recertification metadata
                apiInstance.SaveSiteMetadataRecertificationResult(id, requestMetadata);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveSiteMetadataRecertificationResult: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **requestMetadata** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savesitepermissionrecertificationresult"></a>
# **SaveSitePermissionRecertificationResult**
> void SaveSitePermissionRecertificationResult (Guid id, List<PermissionActionItem> permissionActionItem)

save site permission recertification permissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SaveSitePermissionRecertificationResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var permissionActionItem = new List<PermissionActionItem>(); // List<PermissionActionItem> | 

            try
            {
                // save site permission recertification permissions
                apiInstance.SaveSitePermissionRecertificationResult(id, permissionActionItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SaveSitePermissionRecertificationResult: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **permissionActionItem** | [**List&lt;PermissionActionItem&gt;**](PermissionActionItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="skiperrortask"></a>
# **SkipErrorTask**
> void SkipErrorTask (Guid id, CommentsParam commentsParam = null)

skip error task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SkipErrorTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // skip error task
                apiInstance.SkipErrorTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SkipErrorTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="specifyprimaryandsecondarycontactwhenprimarycontactisdeactived"></a>
# **SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived**
> void SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived (Guid id, string primarycontact, string secondarycontact, Guid? primarycontactemail = null, Guid? secodnarycontactemail = null)

specify primary and secondary contact when primary contact is deactived

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactivedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var primarycontact = primarycontact_example;  // string | 
            var secondarycontact = secondarycontact_example;  // string | 
            var primarycontactemail = new Guid?(); // Guid? |  (optional) 
            var secodnarycontactemail = new Guid?(); // Guid? |  (optional) 

            try
            {
                // specify primary and secondary contact when primary contact is deactived
                apiInstance.SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived(id, primarycontact, secondarycontact, primarycontactemail, secodnarycontactemail);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **primarycontact** | **string**|  | 
 **secondarycontact** | **string**|  | 
 **primarycontactemail** | [**Guid?**](Guid?.md)|  | [optional] 
 **secodnarycontactemail** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="specifysecondarycontactwhensecondarycontactisdeactived"></a>
# **SpecifySecondaryContactWhenSecondaryContactIsDeactived**
> void SpecifySecondaryContactWhenSecondaryContactIsDeactived (Guid id, string secondarycontact)

specify secondary contact when secondary contact is deactived

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SpecifySecondaryContactWhenSecondaryContactIsDeactivedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var secondarycontact = secondarycontact_example;  // string | 

            try
            {
                // specify secondary contact when secondary contact is deactived
                apiInstance.SpecifySecondaryContactWhenSecondaryContactIsDeactived(id, secondarycontact);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SpecifySecondaryContactWhenSecondaryContactIsDeactived: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **secondarycontact** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitarchivegroupautotask"></a>
# **SubmitArchiveGroupAutoTask**
> void SubmitArchiveGroupAutoTask (AutoTaskArchiveRequest autoTaskArchiveRequest = null)

submit archive group auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitArchiveGroupAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskArchiveRequest = new AutoTaskArchiveRequest(); // AutoTaskArchiveRequest |  (optional) 

            try
            {
                // submit archive group auto task
                apiInstance.SubmitArchiveGroupAutoTask(autoTaskArchiveRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitArchiveGroupAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskArchiveRequest** | [**AutoTaskArchiveRequest**](AutoTaskArchiveRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitarchivesiteautotask"></a>
# **SubmitArchiveSiteAutoTask**
> void SubmitArchiveSiteAutoTask (AutoTaskArchiveRequest autoTaskArchiveRequest = null)

submit site archive auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitArchiveSiteAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskArchiveRequest = new AutoTaskArchiveRequest(); // AutoTaskArchiveRequest |  (optional) 

            try
            {
                // submit site archive auto task
                apiInstance.SubmitArchiveSiteAutoTask(autoTaskArchiveRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitArchiveSiteAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskArchiveRequest** | [**AutoTaskArchiveRequest**](AutoTaskArchiveRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitchangesitepolicyautotask"></a>
# **SubmitChangeSitePolicyAutoTask**
> void SubmitChangeSitePolicyAutoTask (AutoTaskChangePolicyRequest autoTaskChangePolicyRequest = null)

submit site policy change auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitChangeSitePolicyAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskChangePolicyRequest = new AutoTaskChangePolicyRequest(); // AutoTaskChangePolicyRequest |  (optional) 

            try
            {
                // submit site policy change auto task
                apiInstance.SubmitChangeSitePolicyAutoTask(autoTaskChangePolicyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitChangeSitePolicyAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskChangePolicyRequest** | [**AutoTaskChangePolicyRequest**](AutoTaskChangePolicyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitcontinueaccessgroupautotask"></a>
# **SubmitContinueAccessGroupAutoTask**
> void SubmitContinueAccessGroupAutoTask (Guid? id = null, CommentsParam commentsParam = null)

submit group continue access auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitContinueAccessGroupAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid?(); // Guid? |  (optional) 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // submit group continue access auto task
                apiInstance.SubmitContinueAccessGroupAutoTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitContinueAccessGroupAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | [optional] 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitcontinueaccesssiteautotask"></a>
# **SubmitContinueAccessSiteAutoTask**
> void SubmitContinueAccessSiteAutoTask (Guid? id = null, CommentsParam commentsParam = null)

submit site continue access auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitContinueAccessSiteAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid?(); // Guid? |  (optional) 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // submit site continue access auto task
                apiInstance.SubmitContinueAccessSiteAutoTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitContinueAccessSiteAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | [optional] 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitdeletegroupautotask"></a>
# **SubmitDeleteGroupAutoTask**
> void SubmitDeleteGroupAutoTask (AutoTaskDeleteRequest autoTaskDeleteRequest = null)

submit delete group auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitDeleteGroupAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskDeleteRequest = new AutoTaskDeleteRequest(); // AutoTaskDeleteRequest |  (optional) 

            try
            {
                // submit delete group auto task
                apiInstance.SubmitDeleteGroupAutoTask(autoTaskDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitDeleteGroupAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskDeleteRequest** | [**AutoTaskDeleteRequest**](AutoTaskDeleteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitdeletesiteautotask"></a>
# **SubmitDeleteSiteAutoTask**
> void SubmitDeleteSiteAutoTask (AutoTaskDeleteRequest autoTaskDeleteRequest = null)

submit site delete auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitDeleteSiteAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskDeleteRequest = new AutoTaskDeleteRequest(); // AutoTaskDeleteRequest |  (optional) 

            try
            {
                // submit site delete auto task
                apiInstance.SubmitDeleteSiteAutoTask(autoTaskDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitDeleteSiteAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskDeleteRequest** | [**AutoTaskDeleteRequest**](AutoTaskDeleteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitextendgroupautotask"></a>
# **SubmitExtendGroupAutoTask**
> void SubmitExtendGroupAutoTask (AutoTaskExtendRequest autoTaskExtendRequest = null)

submit extend group auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitExtendGroupAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskExtendRequest = new AutoTaskExtendRequest(); // AutoTaskExtendRequest |  (optional) 

            try
            {
                // submit extend group auto task
                apiInstance.SubmitExtendGroupAutoTask(autoTaskExtendRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitExtendGroupAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitextendsiteautotask"></a>
# **SubmitExtendSiteAutoTask**
> void SubmitExtendSiteAutoTask (AutoTaskExtendRequest autoTaskExtendRequest = null)

submit site extend auto task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitExtendSiteAutoTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var autoTaskExtendRequest = new AutoTaskExtendRequest(); // AutoTaskExtendRequest |  (optional) 

            try
            {
                // submit site extend auto task
                apiInstance.SubmitExtendSiteAutoTask(autoTaskExtendRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitExtendSiteAutoTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitrecertificationtask"></a>
# **SubmitRecertificationTask**
> void SubmitRecertificationTask (Guid id, CommentsParam commentsParam = null)

submit site/group recertification task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SubmitRecertificationTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 
            var commentsParam = new CommentsParam(); // CommentsParam |  (optional) 

            try
            {
                // submit site/group recertification task
                apiInstance.SubmitRecertificationTask(id, commentsParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SubmitRecertificationTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 
 **commentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsiteownershiprecertificationtask"></a>
# **ViewSiteOwnershipRecertificationTask**
> OwnershipRecertification ViewSiteOwnershipRecertificationTask (Guid id)

view site ownership recertification task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ViewSiteOwnershipRecertificationTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
            var id = new Guid(); // Guid | 

            try
            {
                // view site ownership recertification task
                OwnershipRecertification result = apiInstance.ViewSiteOwnershipRecertificationTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ViewSiteOwnershipRecertificationTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**OwnershipRecertification**](OwnershipRecertification.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

