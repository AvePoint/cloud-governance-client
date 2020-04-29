# Cloud.Governance.Client.Cloud.Governance.Client\Api.TasksApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add-MembersForGroupMembershipRecertification**](TasksApi.md#Add-MembersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/members | add members for group membership recertification
[**Add-OwnersForGroupMembershipRecertification**](TasksApi.md#Add-OwnersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/owners | add owners for group membership recertification
[**Approve-Task**](TasksApi.md#Approve-Task) | **POST** /tasks/{id}/approve | approve task
[**Invoke-ClaimElectionTask**](TasksApi.md#Invoke-ClaimElectionTask) | **POST** /tasks/{id}/election/claim | claim election task
[**Invoke-ClaimSiteOwnershipRecertificationTask**](TasksApi.md#Invoke-ClaimSiteOwnershipRecertificationTask) | **POST** /tasks/{id}/site/recertification/ownership/claim/{secondarycontact} | claim site ownership recertification task
[**Invoke-DeclineElectionTask**](TasksApi.md#Invoke-DeclineElectionTask) | **POST** /tasks/{id}/election/decline | decline election task
[**Invoke-DeclineSiteOwnershipRecertificationTask**](TasksApi.md#Invoke-DeclineSiteOwnershipRecertificationTask) | **POST** /tasks/{id}/site/recertification/ownership/decline | decline site ownership recertification task
[**Invoke-DemoteAsMembersForGroupMembershipRecertification**](TasksApi.md#Invoke-DemoteAsMembersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/demoteasmember | demote as members for group membership recertification
[**Edit-ArchiveGroupRequest**](TasksApi.md#Edit-ArchiveGroupRequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
[**Edit-ArchiveSiteRequest**](TasksApi.md#Edit-ArchiveSiteRequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
[**Edit-ArchiveWebRequest**](TasksApi.md#Edit-ArchiveWebRequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
[**Edit-ChangeGroupPolicyRequest**](TasksApi.md#Edit-ChangeGroupPolicyRequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
[**Edit-ChangeGroupQuotaRequest**](TasksApi.md#Edit-ChangeGroupQuotaRequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
[**Edit-ChangeGroupRequest**](TasksApi.md#Edit-ChangeGroupRequest) | **PUT** /tasks/{id}/changegroup | edit create change group request in task
[**Edit-ChangeListSettingRequest**](TasksApi.md#Edit-ChangeListSettingRequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
[**Edit-ChangePermissionRequest**](TasksApi.md#Edit-ChangePermissionRequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
[**Edit-ChangeSiteContactRequest**](TasksApi.md#Edit-ChangeSiteContactRequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request in task
[**Edit-ChangeSitePolicyRequest**](TasksApi.md#Edit-ChangeSitePolicyRequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
[**Edit-ChangeSiteQuotaRequest**](TasksApi.md#Edit-ChangeSiteQuotaRequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
[**Edit-ChangeSiteSettingRequest**](TasksApi.md#Edit-ChangeSiteSettingRequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request in task
[**Edit-ChangeWebContactRequest**](TasksApi.md#Edit-ChangeWebContactRequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
[**Edit-ChangeWebSettingRequest**](TasksApi.md#Edit-ChangeWebSettingRequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
[**Edit-ClonePermissionRequest**](TasksApi.md#Edit-ClonePermissionRequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request in task
[**Edit-ContentMoveRequest**](TasksApi.md#Edit-ContentMoveRequest) | **PUT** /tasks/{id}/contentmove | edit content move request in task
[**Edit-CreateGroupRequest**](TasksApi.md#Edit-CreateGroupRequest) | **PUT** /tasks/{id}/creategroup | edit create site group request in task
[**Edit-CreateListRequest**](TasksApi.md#Edit-CreateListRequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
[**Edit-CreateSiteRequest**](TasksApi.md#Edit-CreateSiteRequest) | **PUT** /tasks/{id}/createsite | edit create site request in task
[**Edit-CreateWebRequest**](TasksApi.md#Edit-CreateWebRequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
[**Edit-CustomRequest**](TasksApi.md#Edit-CustomRequest) | **PUT** /tasks/{id}/custom | edit custom request in task
[**Edit-DeleteGroupRequest**](TasksApi.md#Edit-DeleteGroupRequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
[**Edit-DeleteSiteRequest**](TasksApi.md#Edit-DeleteSiteRequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
[**Edit-DeleteWebRequest**](TasksApi.md#Edit-DeleteWebRequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
[**Edit-ExtendGroupRequest**](TasksApi.md#Edit-ExtendGroupRequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
[**Edit-ExtendSiteRequest**](TasksApi.md#Edit-ExtendSiteRequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
[**Edit-GrantPermissionRequest**](TasksApi.md#Edit-GrantPermissionRequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
[**Edit-LockSiteRequest**](TasksApi.md#Edit-LockSiteRequest) | **PUT** /tasks/{id}/locksite | edit lock site request in task
[**Edit-ManagePermissionRequest**](TasksApi.md#Edit-ManagePermissionRequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request in task
[**Edit-RestoreGroupRequest**](TasksApi.md#Edit-RestoreGroupRequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
[**Edit-UnLockSiteRequest**](TasksApi.md#Edit-UnLockSiteRequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request in task
[**Get-ChangePermissionReport**](TasksApi.md#Get-ChangePermissionReport) | **GET** /tasks/changepermission/{id}/permission | get change permission report
[**Get-ChangePermissionReportByVersion**](TasksApi.md#Get-ChangePermissionReportByVersion) | **GET** /tasks/changepermission/{id}/permission/{version} | get change permission report with specific version
[**Get-ChangePermissionReportFilters**](TasksApi.md#Get-ChangePermissionReportFilters) | **GET** /tasks/changepermission/{id}/permission/filters | get change permission report filters
[**Get-ChangePermissionReportFiltersByVersion**](TasksApi.md#Get-ChangePermissionReportFiltersByVersion) | **GET** /tasks/changepermission/{id}/permission/filters/{version} | get change permission report filters with specific version
[**Get-ChangePermissionReportFiltersForSPGroup**](TasksApi.md#Get-ChangePermissionReportFiltersForSPGroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters | get change permission report filters for a sharepoint group
[**Get-ChangePermissionReportFiltersForSPGroupByVersion**](TasksApi.md#Get-ChangePermissionReportFiltersForSPGroupByVersion) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters/{version} | get change permission report filters for a sharepoint group with specific version
[**Get-ChangePermissionReportForSPGroup**](TasksApi.md#Get-ChangePermissionReportForSPGroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid} | get change permission report for a sharepoint group
[**Get-ChangePermissionReportForSPGroupByVersion**](TasksApi.md#Get-ChangePermissionReportForSPGroupByVersion) | **GET** /tasks/changepermission/{id}/permission/{version}/group/{groupid} | get change permission report for a sharepoint group with specific version
[**Get-ChangePermissionReportPermissionLevels**](TasksApi.md#Get-ChangePermissionReportPermissionLevels) | **GET** /tasks/changepermission/{id}/permissionlevels | get change permission report permission levels
[**Get-ChangePermissionReportProperties**](TasksApi.md#Get-ChangePermissionReportProperties) | **GET** /tasks/changepermission/{id}/properties | get change permission report properties
[**Get-ClonePermissionReport**](TasksApi.md#Get-ClonePermissionReport) | **GET** /tasks/clonepermission/{id}/permission | get clone permission report
[**Get-ClonePermissionReportProperties**](TasksApi.md#Get-ClonePermissionReportProperties) | **GET** /tasks/clonepermission/{id}/properties | get clone permission report properties
[**Get-GetManualArchiveReport**](TasksApi.md#Get-GetManualArchiveReport) | **GET** /tasks/{id}/manualarchive | get manual archive report
[**Get-GetManualArchiveReportFilters**](TasksApi.md#Get-GetManualArchiveReportFilters) | **GET** /tasks/{id}/manualarchive/filters | get manual archive report filters
[**Get-GroupMembershipRecertificationReport**](TasksApi.md#Get-GroupMembershipRecertificationReport) | **GET** /tasks/{id}/group/recertification/membership | get group membership recertification report
[**Get-GroupMembershipRecertificationReportByVersion**](TasksApi.md#Get-GroupMembershipRecertificationReportByVersion) | **GET** /tasks/{id}/group/recertification/membership/{version} | get group membership recertification report by version
[**Get-GroupMembershipRecertificationReportFilters**](TasksApi.md#Get-GroupMembershipRecertificationReportFilters) | **GET** /tasks/{id}/group/recertification/membership/filters | get group membership recertification report filters
[**Get-GroupMembershipRecertificationReportFiltersByVersion**](TasksApi.md#Get-GroupMembershipRecertificationReportFiltersByVersion) | **GET** /tasks/{id}/group/recertification/membership/filters/{version} | get group membership recertification report filters by version
[**Get-GroupMembershipRecertificationReportProperties**](TasksApi.md#Get-GroupMembershipRecertificationReportProperties) | **GET** /tasks/{id}/group/recertification/membership/properties | get group membership recertification report properties
[**Get-GroupPermissionRecertificationReport**](TasksApi.md#Get-GroupPermissionRecertificationReport) | **GET** /tasks/{id}/group/recertification/permission | get group permission recertification report
[**Get-GroupPermissionRecertificationReportByVersion**](TasksApi.md#Get-GroupPermissionRecertificationReportByVersion) | **GET** /tasks/{id}/group/recertification/permission/{version} | get group permission recertification report by version
[**Get-GroupPermissionRecertificationReportFilters**](TasksApi.md#Get-GroupPermissionRecertificationReportFilters) | **GET** /tasks/{id}/group/recertification/permission/filters | get group permission recertification report filters
[**Get-GroupPermissionRecertificationReportFiltersForSPGroup**](TasksApi.md#Get-GroupPermissionRecertificationReportFiltersForSPGroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid}/filters | get group permission recertification report filters for sharepoint group
[**Get-GroupPermissionRecertificationReportForSPGroup**](TasksApi.md#Get-GroupPermissionRecertificationReportForSPGroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid} | get group permission recertification report for sharepoint group
[**Get-GroupPermissionRecertificationReportProperties**](TasksApi.md#Get-GroupPermissionRecertificationReportProperties) | **GET** /tasks/{id}/group/recertification/permission/properties | get group permission recertification report properties
[**Get-MyTaskFilters**](TasksApi.md#Get-MyTaskFilters) | **GET** /tasks/my/filters | get my task filters
[**Get-MyTasks**](TasksApi.md#Get-MyTasks) | **GET** /tasks/my | get my tasks
[**Get-RemovePermissionReport**](TasksApi.md#Get-RemovePermissionReport) | **GET** /tasks/removepermission/{id}/permission | get remove permission report
[**Get-RemovePermissionReportProperties**](TasksApi.md#Get-RemovePermissionReportProperties) | **GET** /tasks/removepermission/{id}/properties | get remove permission report properties
[**Get-SiteMetadataRecertificationReport**](TasksApi.md#Get-SiteMetadataRecertificationReport) | **GET** /tasks/{id}/site/recertification/metadata | get site metadata recertification metadata
[**Get-SiteMetadataRecertificationReportProperties**](TasksApi.md#Get-SiteMetadataRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/metadata/properties | get site metadata recertification report properties
[**Get-SiteOwnershipRecertificationReportProperties**](TasksApi.md#Get-SiteOwnershipRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/ownership/properties | get site ownership recertification report properties
[**Get-SitePermissionRecertificatioPermissionFilters**](TasksApi.md#Get-SitePermissionRecertificatioPermissionFilters) | **GET** /tasks/{id}/site/recertification/permission/filters | get site permission recertification permission filters
[**Get-SitePermissionRecertificatioReportFiltersByVersion**](TasksApi.md#Get-SitePermissionRecertificatioReportFiltersByVersion) | **GET** /tasks/{id}/site/recertification/permission/filters/{version} | get site permission recertification permission filters with specific version
[**Get-SitePermissionRecertificatioReportFiltersForSPGroup**](TasksApi.md#Get-SitePermissionRecertificatioReportFiltersForSPGroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters | 
[**Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion**](TasksApi.md#Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters/{version} | 
[**Get-SitePermissionRecertificationPermissionLevels**](TasksApi.md#Get-SitePermissionRecertificationPermissionLevels) | **GET** /tasks/{id}/recertification/permissionlevels | get site permission recertification permission levels
[**Get-SitePermissionRecertificationReport**](TasksApi.md#Get-SitePermissionRecertificationReport) | **GET** /tasks/{id}/site/recertification/permission | get site permission recertification report
[**Get-SitePermissionRecertificationReportByVersion**](TasksApi.md#Get-SitePermissionRecertificationReportByVersion) | **GET** /tasks/{id}/site/recertification/permission/{version} | get site permission recertification report by specific version
[**Get-SitePermissionRecertificationReportForSPGroup**](TasksApi.md#Get-SitePermissionRecertificationReportForSPGroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid} | get site permission recertification group permission items
[**Get-SitePermissionRecertificationReportForSPGroupByVersion**](TasksApi.md#Get-SitePermissionRecertificationReportForSPGroupByVersion) | **GET** /tasks/{id}/site/recertification/permission/{version}/group/{groupid} | get site permission recertification group permission items with specific version with specific version
[**Get-SitePermissionRecertificationReportProperties**](TasksApi.md#Get-SitePermissionRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/permission/properties | get site permission recertification report properties
[**Get-TaskByBatchId**](TasksApi.md#Get-TaskByBatchId) | **GET** /tasks/my/{batchid} | get task by batch id
[**Get-TaskById**](TasksApi.md#Get-TaskById) | **GET** /tasks/{id} | get my task by id
[**Invoke-PromoteAsOwnersForGroupMembershipRecertification**](TasksApi.md#Invoke-PromoteAsOwnersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/promoteasowner | promote as owners for group membership recertification
[**Invoke-ReassignTask**](TasksApi.md#Invoke-ReassignTask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
[**Invoke-RejectTask**](TasksApi.md#Invoke-RejectTask) | **POST** /tasks/{id}/reject | reject task
[**Remove-UsersForGroupMembershipRecertification**](TasksApi.md#Remove-UsersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/removeuser | remove users for group membership recertification
[**Invoke-ReseAllChangesForChangePermissionTask**](TasksApi.md#Invoke-ReseAllChangesForChangePermissionTask) | **POST** /tasks/changepermission/{id}/resetallchange | save all changes for change permission task
[**Reset-AllChangesForRecertificationTask**](TasksApi.md#Reset-AllChangesForRecertificationTask) | **POST** /tasks/{id}/recertification/resetallchange | reset all changes for site/group recertification task
[**Reset-MyChangesForChangePermissionTask**](TasksApi.md#Reset-MyChangesForChangePermissionTask) | **POST** /tasks/changepermission/{id}/resetmychange | save my changes for change permission task
[**Reset-MyChangesForRecertificationTask**](TasksApi.md#Reset-MyChangesForRecertificationTask) | **POST** /tasks/{id}/recertification/resetmychange | reset my changes for site/group recertification task
[**Invoke-RetryErrorTask**](TasksApi.md#Invoke-RetryErrorTask) | **POST** /tasks/{id}/retry | retry error task
[**Save-ChangePermissionActions**](TasksApi.md#Save-ChangePermissionActions) | **POST** /tasks/changepermission/{id}/permission | save change permission actions
[**Save-ClonePermissionReport**](TasksApi.md#Save-ClonePermissionReport) | **POST** /tasks/clonepermission/{id}/permission | Save clone permission report
[**Save-GetManualArchiveReport**](TasksApi.md#Save-GetManualArchiveReport) | **POST** /tasks/{id}/manualarchive | save manual archive report
[**Save-GroupPermissionRecertificationResults**](TasksApi.md#Save-GroupPermissionRecertificationResults) | **POST** /tasks/{id}/group/recertification/permission | save group permission recertification results
[**Save-RemovePermissionReport**](TasksApi.md#Save-RemovePermissionReport) | **POST** /tasks/removepermission/{id}/permission | save remove permission report
[**Save-SiteMetadataRecertificationResult**](TasksApi.md#Save-SiteMetadataRecertificationResult) | **POST** /tasks/{id}/site/recertification/metadata | save site metadata recertification metadata
[**Save-SitePermissionRecertificationResult**](TasksApi.md#Save-SitePermissionRecertificationResult) | **POST** /tasks/{id}/site/recertification/permission | save site permission recertification permissions
[**Skip-ErrorTask**](TasksApi.md#Skip-ErrorTask) | **POST** /tasks/{id}/skip | skip error task
[**Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived**](TasksApi.md#Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived) | **POST** /tasks/{id}/election/specify/contacts | specify primary and secondary contact when primary contact is deactived
[**Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived**](TasksApi.md#Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived) | **POST** /tasks/{id}/election/specify/secondarycontact | specify secondary contact when secondary contact is deactived
[**Submit-ArchiveGroupAutoTask**](TasksApi.md#Submit-ArchiveGroupAutoTask) | **POST** /tasks/archivegroup | submit archive group auto task
[**Submit-ArchiveSiteAutoTask**](TasksApi.md#Submit-ArchiveSiteAutoTask) | **POST** /tasks/archivesite | submit site archive auto task
[**Submit-ChangeSitePolicyAutoTask**](TasksApi.md#Submit-ChangeSitePolicyAutoTask) | **POST** /tasks/changesitepolicy | submit site policy change auto task
[**Submit-ContinueAccessGroupAutoTask**](TasksApi.md#Submit-ContinueAccessGroupAutoTask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
[**Submit-ContinueAccessSiteAutoTask**](TasksApi.md#Submit-ContinueAccessSiteAutoTask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
[**Submit-DeleteGroupAutoTask**](TasksApi.md#Submit-DeleteGroupAutoTask) | **POST** /tasks/deletegroup | submit delete group auto task
[**Submit-DeleteSiteAutoTask**](TasksApi.md#Submit-DeleteSiteAutoTask) | **POST** /tasks/deletesite | submit site delete auto task
[**Submit-ExtendGroupAutoTask**](TasksApi.md#Submit-ExtendGroupAutoTask) | **POST** /tasks/extendgroup | submit extend group auto task
[**Submit-ExtendSiteAutoTask**](TasksApi.md#Submit-ExtendSiteAutoTask) | **POST** /tasks/extendsite | submit site extend auto task
[**Submit-RecertificationTask**](TasksApi.md#Submit-RecertificationTask) | **POST** /tasks/{id}/submit | submit site/group recertification task
[**Invoke-ViewSiteOwnershipRecertificationTask**](TasksApi.md#Invoke-ViewSiteOwnershipRecertificationTask) | **GET** /tasks/{id}/site/recertification/ownership | view site ownership recertification task


<a name="Add-MembersForGroupMembershipRecertification"></a>
# **Add-MembersForGroupMembershipRecertification**
> void Add-MembersForGroupMembershipRecertification<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiUser] <PSCustomObject[]><br>

add members for group membership recertification

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ApiUser = @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)) # ApiUser[] | 

# add members for group membership recertification
try {
    Add-MembersForGroupMembershipRecertification -Id $Id -ApiUser $ApiUser
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ApiUser** | [**ApiUser[]**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Add-OwnersForGroupMembershipRecertification"></a>
# **Add-OwnersForGroupMembershipRecertification**
> void Add-OwnersForGroupMembershipRecertification<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiUser] <PSCustomObject[]><br>

add owners for group membership recertification

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ApiUser = @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)) # ApiUser[] | 

# add owners for group membership recertification
try {
    Add-OwnersForGroupMembershipRecertification -Id $Id -ApiUser $ApiUser
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ApiUser** | [**ApiUser[]**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Approve-Task"></a>
# **Approve-Task**
> void Approve-Task<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

approve task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CommentsParam = (New-CommentsParam -Comments "Comments_example") # CommentsParam |  (optional)

# approve task
try {
    Approve-Task -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ClaimElectionTask"></a>
# **Invoke-ClaimElectionTask**
> void Invoke-ClaimElectionTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Secondarycontact] <String><br>

claim election task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Secondarycontact = "Secondarycontact_example" # String |  (default to null)

# claim election task
try {
    Invoke-ClaimElectionTask -Id $Id -Secondarycontact $Secondarycontact
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Secondarycontact** | **String**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ClaimSiteOwnershipRecertificationTask"></a>
# **Invoke-ClaimSiteOwnershipRecertificationTask**
> void Invoke-ClaimSiteOwnershipRecertificationTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Secondarycontact] <String><br>

claim site ownership recertification task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Secondarycontact = "Secondarycontact_example" # String |  (default to null)

# claim site ownership recertification task
try {
    Invoke-ClaimSiteOwnershipRecertificationTask -Id $Id -Secondarycontact $Secondarycontact
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Secondarycontact** | **String**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeclineElectionTask"></a>
# **Invoke-DeclineElectionTask**
> void Invoke-DeclineElectionTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

decline election task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# decline election task
try {
    Invoke-DeclineElectionTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeclineSiteOwnershipRecertificationTask"></a>
# **Invoke-DeclineSiteOwnershipRecertificationTask**
> void Invoke-DeclineSiteOwnershipRecertificationTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

decline site ownership recertification task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# decline site ownership recertification task
try {
    Invoke-DeclineSiteOwnershipRecertificationTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DemoteAsMembersForGroupMembershipRecertification"></a>
# **Invoke-DemoteAsMembersForGroupMembershipRecertification**
> void Invoke-DemoteAsMembersForGroupMembershipRecertification<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiUser] <PSCustomObject[]><br>

demote as members for group membership recertification

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ApiUser = @() # ApiUser[] | 

# demote as members for group membership recertification
try {
    Invoke-DemoteAsMembersForGroupMembershipRecertification -Id $Id -ApiUser $ApiUser
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ApiUser** | [**ApiUser[]**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ArchiveGroupRequest"></a>
# **Edit-ArchiveGroupRequest**
> void Edit-ArchiveGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ArchiveGroupRequest] <PSCustomObject><br>

edit archive group request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ArchiveGroupRequest = (New-ArchiveGroupRequest -GroupId "TODO"  -GroupName "GroupName_example"  -GroupEmail "GroupEmail_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @((New-RequestMetadata -Id "TODO"  -Name "Name_example"  -BooleanValue $false  -SingleLineOrMultipleLineValue "SingleLineOrMultipleLineValue_example"  -UpsOrAzureAdValue (New-LookupValue -Tenant "Tenant_example"  -Property "Property_example"  -TargetUser   -UserPropertyValue "UserPropertyValue_example"  -UserPropertyDisplayValue "UserPropertyDisplayValue_example")  -TermsValue (New-TermsValue -TermStore (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -TermGroup (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -TermSet   -Value @())  -UserValue @()  -LinkValue (New-LinkValue -Title "Title_example"  -Address "Address_example")  -ChoiceValue @("ChoiceValue_example")  -Type (New-MetadataFieldTypeNullable)  -ValueString "ValueString_example"  -Action (New-MetadataActionType)))  -TicketNumber 123  -Type (New-ServiceTypeNullable)  -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status (New-RequestStatusNullable)  -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ArchiveGroupRequest |  (optional)

# edit archive group request in task
try {
    Edit-ArchiveGroupRequest -Id $Id -ArchiveGroupRequest $ArchiveGroupRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ArchiveGroupRequest** | [**ArchiveGroupRequest**](ArchiveGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ArchiveSiteRequest"></a>
# **Edit-ArchiveSiteRequest**
> void Edit-ArchiveSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ArchiveSiteRequest] <PSCustomObject><br>

edit archive site request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ArchiveSiteRequest = (New-ArchiveSiteRequest -Action (New-SiteLifecycleActionType)  -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @((New-RequestMetadata -Id "TODO"  -Name "Name_example"  -BooleanValue $false  -SingleLineOrMultipleLineValue "SingleLineOrMultipleLineValue_example"  -UpsOrAzureAdValue (New-LookupValue -Tenant "Tenant_example"  -Property "Property_example"  -TargetUser   -UserPropertyValue "UserPropertyValue_example"  -UserPropertyDisplayValue "UserPropertyDisplayValue_example")  -TermsValue (New-TermsValue -TermStore   -TermGroup   -TermSet   -Value @())  -UserValue @()  -LinkValue (New-LinkValue -Title "Title_example"  -Address "Address_example")  -ChoiceValue @("ChoiceValue_example")  -Type (New-MetadataFieldTypeNullable)  -ValueString "ValueString_example"  -Action (New-MetadataActionType)))  -TicketNumber 123  -Type (New-ServiceTypeNullable)  -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status (New-RequestStatusNullable)  -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ArchiveSiteRequest |  (optional)

# edit archive site request in task
try {
    Edit-ArchiveSiteRequest -Id $Id -ArchiveSiteRequest $ArchiveSiteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ArchiveSiteRequest** | [**ArchiveSiteRequest**](ArchiveSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ArchiveWebRequest"></a>
# **Edit-ArchiveWebRequest**
> void Edit-ArchiveWebRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ArchiveWebLifecycleRequest] <PSCustomObject><br>

edit archive web request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ArchiveWebLifecycleRequest = (New-ArchiveWebLifecycleRequest -Action (New-WebLifecycleActionType)  -WebId "TODO"  -WebUrl "WebUrl_example"  -WebRelativeUrl "WebRelativeUrl_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -ActionDescription "ActionDescription_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ArchiveWebLifecycleRequest |  (optional)

# edit archive web request in task
try {
    Edit-ArchiveWebRequest -Id $Id -ArchiveWebLifecycleRequest $ArchiveWebLifecycleRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ArchiveWebLifecycleRequest** | [**ArchiveWebLifecycleRequest**](ArchiveWebLifecycleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeGroupPolicyRequest"></a>
# **Edit-ChangeGroupPolicyRequest**
> void Edit-ChangeGroupPolicyRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupPolicyRequest] <PSCustomObject><br>

edit change group policy request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeGroupPolicyRequest = (New-ChangeGroupPolicyRequest -Policy   -OriginalPolicy   -IsLeaseEnabled $false  -ChangePolicyConfig (New-AssignBy)  -StartDateType (New-StartDateType)  -SpecifyStartDate Get-Date  -GroupId "TODO"  -GroupName "GroupName_example"  -GroupEmail "GroupEmail_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeGroupPolicyRequest |  (optional)

# edit change group policy request in task
try {
    Edit-ChangeGroupPolicyRequest -Id $Id -ChangeGroupPolicyRequest $ChangeGroupPolicyRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeGroupPolicyRequest** | [**ChangeGroupPolicyRequest**](ChangeGroupPolicyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeGroupQuotaRequest"></a>
# **Edit-ChangeGroupQuotaRequest**
> void Edit-ChangeGroupQuotaRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupQuotaRequest] <PSCustomObject><br>

edit change group quota request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeGroupQuotaRequest = (New-ChangeGroupQuotaRequest -GroupQuotaSize 123  -OriginalQuotaSize 123  -GroupId "TODO"  -GroupName "GroupName_example"  -GroupEmail "GroupEmail_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeGroupQuotaRequest |  (optional)

# edit change group quota request in task
try {
    Edit-ChangeGroupQuotaRequest -Id $Id -ChangeGroupQuotaRequest $ChangeGroupQuotaRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeGroupQuotaRequest** | [**ChangeGroupQuotaRequest**](ChangeGroupQuotaRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeGroupRequest"></a>
# **Edit-ChangeGroupRequest**
> void Edit-ChangeGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupSettingRequest] <PSCustomObject><br>

edit create change group request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeGroupSettingRequest = (New-ChangeGroupSettingRequest -GroupId "TODO"  -GroupEmail "GroupEmail_example"  -GroupName "GroupName_example"  -OriginalGroupName "OriginalGroupName_example"  -GroupDescription "GroupDescription_example"  -OriginalGroupDescription "OriginalGroupDescription_example"  -PrimaryContact   -OriginalPrimaryContact   -SecondaryContact   -OriginalSecondaryContact   -GroupOwners @((New-GroupMembershipItem -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -Action (New-GroupMembershipAction)))  -GroupMembers @((New-GroupMembershipItem -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -Action (New-GroupMembershipAction)))  -IsDynamicMembership $false  -DynamicMembershipRules @((New-DynamicGroupRuleInfo -Id "TODO"  -Order 123  -Relation (New-LogicalOperator)  -Category (New-CategoryType)  -MetadataId "TODO"  -MetadataName "MetadataName_example"  -MetadataValue "MetadataValue_example"  -MetadataDisplayValue "MetadataDisplayValue_example"  -Condition (New-DynamicRuleCondition)))  -EnabledSubscribe $false  -OriginalEnabledSubscribe $false  -EnabledOutsideSender $false  -OriginalEnabledOutsideSender $false  -HubSiteActionType (New-ChangeHubsiteActionType)  -AssociateHubSiteId "TODO"  -AssociateHubSiteTitle "AssociateHubSiteTitle_example"  -Classification "Classification_example"  -OriginalClassification "OriginalClassification_example"  -EnableTeams $false  -OriginalEnableTeams $false  -GroupMetadatas @()  -OriginalGroupMetadata @()  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeGroupSettingRequest |  (optional)

# edit create change group request in task
try {
    Edit-ChangeGroupRequest -Id $Id -ChangeGroupSettingRequest $ChangeGroupSettingRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeGroupSettingRequest** | [**ChangeGroupSettingRequest**](ChangeGroupSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeListSettingRequest"></a>
# **Edit-ChangeListSettingRequest**
> void Edit-ChangeListSettingRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeListSettingRequest] <PSCustomObject><br>

edit change list setting request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeListSettingRequest = (New-ChangeListSettingRequest -ObjectInfo (New-ChangeListSettingObjectInfo -SiteUrl "SiteUrl_example"  -WebId "TODO"  -WebUrl "WebUrl_example"  -SiteId "TODO"  -ObjectUrl "ObjectUrl_example"  -ObjectTitle "ObjectTitle_example")  -ListTitle (New-StringChangedProperty -ChangeValue "ChangeValue_example"  -OriginalValue "OriginalValue_example")  -ListDescription (New-StringChangedProperty -ChangeValue "ChangeValue_example"  -OriginalValue "OriginalValue_example")  -NavigationSetting (New-BooleanChangedProperty -ChangeValue $false  -OriginalValue $false)  -VersionSetting (New-ListVersionSettingsChangedProperty -ChangeValue (New-ListVersionSettings -ListType (New-ListType)  -EnableMajorVersions $false  -EnableMajorAndMinorVersions $false  -EnableMajorVersionLimit $false  -MajorVersionLimit 123  -EnableMinorVersionLimit $false  -MinorVersionsLimit 123  -RequireContentApproval $false)  -OriginalValue (New-ListVersionSettings -ListType (New-ListType)  -EnableMajorVersions $false  -EnableMajorAndMinorVersions $false  -EnableMajorVersionLimit $false  -MajorVersionLimit 123  -EnableMinorVersionLimit $false  -MinorVersionsLimit 123  -RequireContentApproval $false))  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeListSettingRequest |  (optional)

# edit change list setting request in task
try {
    Edit-ChangeListSettingRequest -Id $Id -ChangeListSettingRequest $ChangeListSettingRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeListSettingRequest** | [**ChangeListSettingRequest**](ChangeListSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangePermissionRequest"></a>
# **Edit-ChangePermissionRequest**
> void Edit-ChangePermissionRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangePermissionRequest] <PSCustomObject><br>

edit change permission request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangePermissionRequest = (New-ChangePermissionRequest -ObjectProperty (New-PermissionObjectProperty -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -WebId "TODO"  -WebServerRelativeUrl "WebServerRelativeUrl_example"  -ListTitle "ListTitle_example"  -ObjectUrl "ObjectUrl_example"  -IsInherit $false  -InheritNodeType (New-TreeNodeType)  -TopInheritUrl "TopInheritUrl_example"  -CheckType (New-TreeNodeType))  -PermissionChangedType (New-PermissionChangedType)  -IsManagedAllUsers $false  -SelectedUsers @()  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangePermissionRequest |  (optional)

# edit change permission request in task
try {
    Edit-ChangePermissionRequest -Id $Id -ChangePermissionRequest $ChangePermissionRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangePermissionRequest** | [**ChangePermissionRequest**](ChangePermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeSiteContactRequest"></a>
# **Edit-ChangeSiteContactRequest**
> void Edit-ChangeSiteContactRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteContactRequest] <PSCustomObject><br>

edit change site administrator/contact request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeSiteContactRequest = (New-ChangeSiteContactRequest -ChangeContactMethod (New-ChangeContactMethod)  -ChangeByUrlSetting @((New-ChangeContactByUrlSetting -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -OriginalPrimaryContact   -NewPrimaryContact   -OriginalSecondaryContact   -NewSecondaryContact   -OriginalPrimaryAdministrator   -NewPrimaryAdministrator   -OriginalAdditionalAdministrators @()  -NewAdditionalAdministrators @()))  -ChangeByUserSetting (New-ChangeContactByUserSetting -CurrentUser   -NewUser   -AlternativeUser )  -SubRequests @((New-ChangeSiteContactSubRequest -Id "TODO"  -AssignTo @()  -Reason "Reason_example"  -Status 123  -StatusDescription "StatusDescription_example"  -AdminContactSettings (New-ChangeContactByUrlSetting -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -OriginalPrimaryContact   -NewPrimaryContact   -OriginalSecondaryContact   -NewSecondaryContact   -OriginalPrimaryAdministrator   -NewPrimaryAdministrator   -OriginalAdditionalAdministrators @()  -NewAdditionalAdministrators @())  -ProgressStatus (New-ApiRequestProgressStatus)))  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeSiteContactRequest |  (optional)

# edit change site administrator/contact request in task
try {
    Edit-ChangeSiteContactRequest -Id $Id -ChangeSiteContactRequest $ChangeSiteContactRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeSiteContactRequest** | [**ChangeSiteContactRequest**](ChangeSiteContactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeSitePolicyRequest"></a>
# **Edit-ChangeSitePolicyRequest**
> void Edit-ChangeSitePolicyRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSitePolicyRequest] <PSCustomObject><br>

edit change site policy request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeSitePolicyRequest = (New-ChangeSitePolicyRequest -Policy   -OriginalPolicy   -IsLeaseEnabled $false  -ChangePolicyConfig (New-AssignBy)  -StartDateType (New-StartDateType)  -SpecifyStartDate Get-Date  -Action (New-SiteLifecycleActionType)  -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeSitePolicyRequest |  (optional)

# edit change site policy request in task
try {
    Edit-ChangeSitePolicyRequest -Id $Id -ChangeSitePolicyRequest $ChangeSitePolicyRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeSitePolicyRequest** | [**ChangeSitePolicyRequest**](ChangeSitePolicyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeSiteQuotaRequest"></a>
# **Edit-ChangeSiteQuotaRequest**
> void Edit-ChangeSiteQuotaRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteQuotaRequest] <PSCustomObject><br>

edit change site quota request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeSiteQuotaRequest = (New-ChangeSiteQuotaRequest -QuotaSize 123  -Action   -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeSiteQuotaRequest |  (optional)

# edit change site quota request in task
try {
    Edit-ChangeSiteQuotaRequest -Id $Id -ChangeSiteQuotaRequest $ChangeSiteQuotaRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeSiteQuotaRequest** | [**ChangeSiteQuotaRequest**](ChangeSiteQuotaRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeSiteSettingRequest"></a>
# **Edit-ChangeSiteSettingRequest**
> void Edit-ChangeSiteSettingRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteSettingRequest] <PSCustomObject><br>

edit change site setting request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeSiteSettingRequest = (New-ChangeSiteSettingRequest -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -SiteTitleSetting   -SiteDescriptionSetting   -EnableChangedMetadata $false  -ChangedMetadatas @()  -OriginalSiteMetadatas @()  -DeploymentPlanName "DeploymentPlanName_example"  -HubSiteSettings (New-HubSiteChangedSettings -Enabled $false  -IsModernSite $false  -Action (New-ChangeHubsiteActionType)  -AssociatedHubSiteId "TODO"  -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example")  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeSiteSettingRequest |  (optional)

# edit change site setting request in task
try {
    Edit-ChangeSiteSettingRequest -Id $Id -ChangeSiteSettingRequest $ChangeSiteSettingRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeSiteSettingRequest** | [**ChangeSiteSettingRequest**](ChangeSiteSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeWebContactRequest"></a>
# **Edit-ChangeWebContactRequest**
> void Edit-ChangeWebContactRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeWebContactRequest] <PSCustomObject><br>

edit change web contact request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeWebContactRequest = (New-ChangeWebContactRequest -ChangedMethod (New-ChangeContactMethod)  -ChangedByUserSetting (New-ChangeContactByUserSetting -CurrentUser   -NewUser   -AlternativeUser )  -ChangedByUrlItems @((New-ChangeWebContactByUrlSetting -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -WebId "TODO"  -WebUrl "WebUrl_example"  -PrimaryContact (New-ApiUserChangedProperty -ChangeValue   -OriginalValue )  -SecondaryContact (New-ApiUserChangedProperty -ChangeValue   -OriginalValue )))  -SubRequests @((New-ChangeWebContactSubRequest -Id "TODO"  -AssignTo   -Reason "Reason_example"  -Status 123  -StatusDescription "StatusDescription_example"  -ProgressStatus (New-ApiRequestProgressStatus)  -ContactChangeSettings (New-ChangeWebContactByUrlSetting -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -WebId "TODO"  -WebUrl "WebUrl_example"  -PrimaryContact   -SecondaryContact )))  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeWebContactRequest |  (optional)

# edit change web contact request in task
try {
    Edit-ChangeWebContactRequest -Id $Id -ChangeWebContactRequest $ChangeWebContactRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeWebContactRequest** | [**ChangeWebContactRequest**](ChangeWebContactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeWebSettingRequest"></a>
# **Edit-ChangeWebSettingRequest**
> void Edit-ChangeWebSettingRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeWebSettingRequest] <PSCustomObject><br>

edit change web setting request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ChangeWebSettingRequest = (New-ChangeWebSettingRequest -Url (New-ChangeWebSPObject -SiteUrl "SiteUrl_example"  -WebUrl "WebUrl_example"  -SiteId "TODO"  -WebId "TODO")  -ChangedTitle   -ChangedDescription   -ChangedMetadata (New-RequestMetadataListChangedProperty -ChangeValue @()  -OriginalValue @())  -DeploymentPlanName "DeploymentPlanName_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ChangeWebSettingRequest |  (optional)

# edit change web setting request in task
try {
    Edit-ChangeWebSettingRequest -Id $Id -ChangeWebSettingRequest $ChangeWebSettingRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeWebSettingRequest** | [**ChangeWebSettingRequest**](ChangeWebSettingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ClonePermissionRequest"></a>
# **Edit-ClonePermissionRequest**
> void Edit-ClonePermissionRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ClonePermissionRequest] <PSCustomObject><br>

edit clone permission request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ClonePermissionRequest = (New-ClonePermissionRequest -Urls @("Urls_example")  -SourceUser   -TargetUser   -CloneOption (New-ClonePermissionOption)  -AdditionalCloneOption (New-ClonePermissionAdditionalOption)  -EnabledRemoveExplicitPermission $false  -EnabledRemoveUserFromSPGroup $false  -EnabledDeleteUserPermission $false  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ClonePermissionRequest |  (optional)

# edit clone permission request in task
try {
    Edit-ClonePermissionRequest -Id $Id -ClonePermissionRequest $ClonePermissionRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ClonePermissionRequest** | [**ClonePermissionRequest**](ClonePermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ContentMoveRequest"></a>
# **Edit-ContentMoveRequest**
> void Edit-ContentMoveRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ContentMoveRequest] <PSCustomObject><br>

edit content move request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ContentMoveRequest = (New-ContentMoveRequest -Method (New-ContentMoveMethod)  -CopySettings (New-CopyMoveSetting -IsMigrateConfiguration $false  -IsKeepLookAndFeel $false  -ColumnsAndContentConflictResolution (New-ItemConflictResolutionType)  -IsMigrateSecurity $false  -IsMigrateColumnsAndContentTypes $false  -IsMigrateContent $false  -IsMigrateContentIncludeListAttachment $false)  -MoveSettings (New-CopyMoveSetting -IsMigrateConfiguration $false  -IsKeepLookAndFeel $false  -ColumnsAndContentConflictResolution (New-ItemConflictResolutionType)  -IsMigrateSecurity $false  -IsMigrateColumnsAndContentTypes $false  -IsMigrateContent $false  -IsMigrateContentIncludeListAttachment $false)  -CommonSettings (New-ContentMoveCommonSetting -IsIncludeVersions $false  -IsIncludeWorkflowDefinition $false  -IsDisableInformationRightsManagement $false  -IsPreserveNullColumnValues $false  -IsKeepModifiedByAndModifiedTime $false  -ProfileMappings (New-ContentMoveProfileMappings -ColumnMapping   -ContentTypeMapping   -UserMapping   -LanguageMapping )  -BackupSettings (New-BackupEnvironmentSetting -IsBackupSource $false  -IsBackupDestination $false  -StoragePolicy )  -ConflictResolutionSettings (New-ConflictResolutionSetting -ContainerConflictSolution (New-ConflictSolutionType)  -IsCheckLowerObject $false  -IsEnableContentConflictResolution $false  -ContentConflictSolution (New-ConflictSolutionType)  -AppConflictSolution )  -FilterPolicy   -DeleteType (New-DeleteType)  -IsDeleteCheckedFiles $false)  -ObjectMappings @((New-ContentMoveSPObjectMapping -Source (New-ContentMoveSPObject -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -Title "Title_example"  -FullUrl "FullUrl_example"  -Type (New-NodeType))  -Destination (New-ContentMoveSPObject -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -Title "Title_example"  -FullUrl "FullUrl_example"  -Type (New-NodeType))  -Action (New-ContentMoveAction)))  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ContentMoveRequest |  (optional)

# edit content move request in task
try {
    Edit-ContentMoveRequest -Id $Id -ContentMoveRequest $ContentMoveRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ContentMoveRequest** | [**ContentMoveRequest**](ContentMoveRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateGroupRequest"></a>
# **Edit-CreateGroupRequest**
> void Edit-CreateGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateGroupRequest] <PSCustomObject><br>

edit create site group request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CreateGroupRequest = (New-CreateGroupRequest -GroupId "GroupId_example"  -GroupIdWithoutPrefixSuffix "GroupIdWithoutPrefixSuffix_example"  -GroupName "GroupName_example"  -GroupNameWithoutPrefixSuffix "GroupNameWithoutPrefixSuffix_example"  -GroupEmail "GroupEmail_example"  -Policy "TODO"  -GroupDescription "GroupDescription_example"  -Owners @()  -Members @()  -Privacy $false  -Subscribe $false  -OutsideSender $false  -EnableTeamCollaboration $false  -Language "Language_example"  -Classification "Classification_example"  -Links (New-GroupLinks -GroupSiteLink "GroupSiteLink_example"  -GroupPlannerLink "GroupPlannerLink_example"  -GroupFilesLink "GroupFilesLink_example"  -GroupConversationsLink "GroupConversationsLink_example"  -GroupNotebookLink "GroupNotebookLink_example")  -LeasePeriodSettings (New-GroupLeasePeriodSettings -IsEnabled $false  -LeaseType (New-GroupLeasePeriodType)  -DurationType (New-ApiDurationType)  -DurationInterval 123  -LeaseExpirationDate Get-Date)  -TeamsSettings (New-RequestTeamsSettings -AllowMembersCreateUpdateChannels $false  -AllowMembersCreatePrivateChannels $false  -AllowMemberDeleteRestoreChannels $false  -AllowMembersAddRemoveApps $false  -AllowMembersCreateUpdateRemoveTabs $false  -AllowMembersCreateUpdateRemoveConnections $false  -AllowMembersDeleteMessages $false  -AllowMembersEditMessages $false  -AllowGuestsCreateUpdateChannels $false  -AllowGuestsDeleteChannels $false  -AllowMentionsTeam $false  -AllowMentionsChannel $false  -EnableGiphy $false  -EnableStickersAndMemes $false  -EnableCustomMemes $false  -GiphyRatingType (New-GiphyRatingType))  -AppliedSiteDesignId "TODO"  -PrimaryContact   -SecondaryContact   -EnableGroupMembershipHidden $false  -EnableAssignedMembership $false  -EnableDynamicMembership $false  -TemplateSettings (New-TeamsTemplateSettings -EnableCreateTeamFromScratch $false  -EnableCreateTeamFromExistTeam $false  -SelectedTemplate   -EnableCloneChannels $false  -EnableCloneApps $false  -EnableCloneTabs $false  -EnableCloneMembers $false  -EnableCloneTeamSetting $false  -EnableCloneTeamPrivacy $false  -EnableCloneTeamClassification $false)  -DynamicMembershipRules @((New-DynamicGroupRuleInfo -Id "TODO"  -Order 123  -Relation (New-LogicalOperator)  -Category (New-CategoryType)  -MetadataId "TODO"  -MetadataName "MetadataName_example"  -MetadataValue "MetadataValue_example"  -MetadataDisplayValue "MetadataDisplayValue_example"  -Condition (New-DynamicRuleCondition)))  -MultiGeoLocation (New-GeoLocationBase -Name "Name_example"  -DisplayName "DisplayName_example")  -HubSiteSettings (New-HubSiteSettings -Enabled $false  -Action (New-ConvertHubSiteActionType)  -AssociatedHubSiteId "TODO"  -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example")  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # CreateGroupRequest |  (optional)

# edit create site group request in task
try {
    Edit-CreateGroupRequest -Id $Id -CreateGroupRequest $CreateGroupRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CreateGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateListRequest"></a>
# **Edit-CreateListRequest**
> void Edit-CreateListRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateListRequest] <PSCustomObject><br>

edit create list request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CreateListRequest = (New-CreateListRequest -ListTitle "ListTitle_example"  -ListName "ListName_example"  -ListDescription "ListDescription_example"  -ParentObject (New-CreateListSPObject -ParentUrl "ParentUrl_example"  -SiteUrl "SiteUrl_example"  -SiteId "TODO")  -ListTemplate "ListTemplate_example"  -EnableNavigation $false  -ListType   -VersionSettings   -PermissionSettings (New-ListPermissionSettings -StopInheritingPermissions $false  -UserPermissions @((New-RequestUserWithPermissions -User   -PermissionLevels @((New-PermissionLevel -Id "TODO"  -IdInSharePoint 123  -Name "Name_example"  -Description "Description_example"  -IsExcluded $false))))  -GroupPermissions @((New-RequestGroupWithPermissions -Name "Name_example"  -Description "Description_example"  -Users @((New-GroupUser -IsEnforce $false  -IsHide $false  -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -PermissionLevels @((New-PermissionLevel -Id "TODO"  -IdInSharePoint 123  -Name "Name_example"  -Description "Description_example"  -IsExcluded $false))  -GroupOwner   -GroupOwnerType (New-GroupOwnerType)  -BuildInGroupType (New-SharePointBuildInGroupType))))  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # CreateListRequest |  (optional)

# edit create list request in task
try {
    Edit-CreateListRequest -Id $Id -CreateListRequest $CreateListRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CreateListRequest** | [**CreateListRequest**](CreateListRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateSiteRequest"></a>
# **Edit-CreateSiteRequest**
> void Edit-CreateSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateSiteRequest] <PSCustomObject><br>

edit create site request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CreateSiteRequest = (New-CreateSiteRequest -SiteTitle "SiteTitle_example"  -SiteDescription "SiteDescription_example"  -SiteUrl (New-SiteUrl -Root "Root_example"  -ManagedPath "ManagedPath_example"  -Name "Name_example")  -PolicyId "TODO"  -TimeZone 123  -Language 123  -Template "Template_example"  -DeploymentManagerPlanName "DeploymentManagerPlanName_example"  -PrimaryAdmin   -AdditionalAdmins @()  -PrimaryContact   -SecondaryContact   -IsShownClassificationAndDesing $false  -SiteDesign (New-StringModel -Id "Id_example"  -Name "Name_example")  -Classification "Classification_example"  -IsShownHubsiteSettings $false  -HubSiteSettings (New-HubSiteSettings -Enabled $false  -Action (New-ConvertHubSiteActionType)  -AssociatedHubSiteId "TODO"  -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example")  -UserPermissions @((New-RequestUserWithPermissions -User   -PermissionLevels @()))  -GroupPermissions @((New-RequestGroupWithPermissions -Name "Name_example"  -Description "Description_example"  -Users @((New-GroupUser -IsEnforce $false  -IsHide $false  -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -PermissionLevels @()  -GroupOwner   -GroupOwnerType (New-GroupOwnerType)  -BuildInGroupType (New-SharePointBuildInGroupType)))  -YammerGroupSettings (New-YammerGroupRequestSettings -NameOrId "NameOrId_example"  -Description "Description_example"  -Type (New-YammerGroupType)  -JoinType (New-YammerGroupJoinType)  -IsListInDirectory $false  -IsGroupAlreadyExisted $false)  -LeasePeriodSettings (New-SiteLeasePeriodRequestSettings -LeaseInterval 123  -LeaseDurationType (New-ApiDurationType)  -LeaseWarningInterval 123  -LeaseWarningDurationType )  -MultiGeoLocation (New-GeoLocationBase -Name "Name_example"  -DisplayName "DisplayName_example")  -InputTitle "InputTitle_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # CreateSiteRequest |  (optional)

# edit create site request in task
try {
    Edit-CreateSiteRequest -Id $Id -CreateSiteRequest $CreateSiteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CreateSiteRequest** | [**CreateSiteRequest**](CreateSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateWebRequest"></a>
# **Edit-CreateWebRequest**
> void Edit-CreateWebRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateWebRequest] <PSCustomObject><br>

edit create web request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CreateWebRequest = (New-CreateWebRequest -WebName "WebName_example"  -WebTitle "WebTitle_example"  -WebDescription "WebDescription_example"  -WebLanguage (New-IntModel -Id 123  -Name "Name_example"  -Description "Description_example")  -WebTemplate "WebTemplate_example"  -ParentSiteUrl "ParentSiteUrl_example"  -ParentWebUrl "ParentWebUrl_example"  -PrimaryContact   -SecondaryContact   -UserPermissions @()  -GroupPermissions @()  -YammerGroupSettings (New-YammerGroupRequestSettings -NameOrId "NameOrId_example"  -Description "Description_example"  -Type (New-YammerGroupType)  -JoinType (New-YammerGroupJoinType)  -IsListInDirectory $false  -IsGroupAlreadyExisted $false)  -IsOnQuickLaunch $false  -IsOnTopLinkBar $false  -IsInheritance $false  -DeploymentManagerPlanName "DeploymentManagerPlanName_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # CreateWebRequest |  (optional)

# edit create web request in task
try {
    Edit-CreateWebRequest -Id $Id -CreateWebRequest $CreateWebRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CreateWebRequest** | [**CreateWebRequest**](CreateWebRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CustomRequest"></a>
# **Edit-CustomRequest**
> void Edit-CustomRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiRequest] <PSCustomObject><br>

edit custom request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ApiRequest = (New-ApiRequest -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ApiRequest |  (optional)

# edit custom request in task
try {
    Edit-CustomRequest -Id $Id -ApiRequest $ApiRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ApiRequest** | [**ApiRequest**](ApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-DeleteGroupRequest"></a>
# **Edit-DeleteGroupRequest**
> void Edit-DeleteGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DeleteGroupRequest] <PSCustomObject><br>

edit delete change group request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$DeleteGroupRequest = (New-DeleteGroupRequest -GroupId "TODO"  -GroupName "GroupName_example"  -GroupEmail "GroupEmail_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # DeleteGroupRequest |  (optional)

# edit delete change group request in task
try {
    Edit-DeleteGroupRequest -Id $Id -DeleteGroupRequest $DeleteGroupRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **DeleteGroupRequest** | [**DeleteGroupRequest**](DeleteGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-DeleteSiteRequest"></a>
# **Edit-DeleteSiteRequest**
> void Edit-DeleteSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DeleteSiteRequest] <PSCustomObject><br>

edit delete site request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$DeleteSiteRequest = (New-DeleteSiteRequest -Action   -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # DeleteSiteRequest |  (optional)

# edit delete site request in task
try {
    Edit-DeleteSiteRequest -Id $Id -DeleteSiteRequest $DeleteSiteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **DeleteSiteRequest** | [**DeleteSiteRequest**](DeleteSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-DeleteWebRequest"></a>
# **Edit-DeleteWebRequest**
> void Edit-DeleteWebRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DeleteWebLifecycleRequest] <PSCustomObject><br>

edit delete web request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$DeleteWebLifecycleRequest = (New-DeleteWebLifecycleRequest -Action (New-WebLifecycleActionType)  -WebId "TODO"  -WebUrl "WebUrl_example"  -WebRelativeUrl "WebRelativeUrl_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -ActionDescription "ActionDescription_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # DeleteWebLifecycleRequest |  (optional)

# edit delete web request in task
try {
    Edit-DeleteWebRequest -Id $Id -DeleteWebLifecycleRequest $DeleteWebLifecycleRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **DeleteWebLifecycleRequest** | [**DeleteWebLifecycleRequest**](DeleteWebLifecycleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ExtendGroupRequest"></a>
# **Edit-ExtendGroupRequest**
> void Edit-ExtendGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExtendGroupRequest] <PSCustomObject><br>

edit extend group request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ExtendGroupRequest = (New-ExtendGroupRequest -ExtendDuration 123  -ExtendDurationType   -GroupId "TODO"  -GroupName "GroupName_example"  -GroupEmail "GroupEmail_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ExtendGroupRequest |  (optional)

# edit extend group request in task
try {
    Edit-ExtendGroupRequest -Id $Id -ExtendGroupRequest $ExtendGroupRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ExtendGroupRequest** | [**ExtendGroupRequest**](ExtendGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ExtendSiteRequest"></a>
# **Edit-ExtendSiteRequest**
> void Edit-ExtendSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExtendSiteRequest] <PSCustomObject><br>

edit extend site request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ExtendSiteRequest = (New-ExtendSiteRequest -ExtendDuration 123  -ExtendDurationType   -Action   -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ExtendSiteRequest |  (optional)

# edit extend site request in task
try {
    Edit-ExtendSiteRequest -Id $Id -ExtendSiteRequest $ExtendSiteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ExtendSiteRequest** | [**ExtendSiteRequest**](ExtendSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-GrantPermissionRequest"></a>
# **Edit-GrantPermissionRequest**
> void Edit-GrantPermissionRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GrantPermissionRequest] <PSCustomObject><br>

edit grant permission request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$GrantPermissionRequest = (New-GrantPermissionRequest -Url (New-GrantPermissionSPObject -WebId "TODO"  -SiteId "TODO"  -WebServerRelativeUrl "WebServerRelativeUrl_example"  -ListTitle "ListTitle_example"  -TopInheritUrl "TopInheritUrl_example"  -InheritNodeType   -IsInheritedPermission $false  -Id "TODO"  -Title "Title_example"  -FullUrl "FullUrl_example"  -Type )  -PermissionSettings (New-GrantPermissionRequestPermissionSettings -IsBreakInheritance $false  -IsGrantPermissionDirectly $false  -SelectedSPGroup (New-GrantPermissionGroup -Id 123  -Name "Name_example"  -DisplayName "DisplayName_example"  -PermissionIds @("PermissionIds_example")  -Description "Description_example")  -SelectedPermissionLevels @((New-IntModel -Id 123  -Name "Name_example"  -Description "Description_example")))  -PermissionDurationSettings (New-GrantPermissionRequestDurationSettings -IsGrantTemporaryPermission $false  -ExpirationType (New-ExpirationType)  -DurationInterval 123  -DurationDateType (New-DurationDateTypeNullable)  -StartTime Get-Date  -EndTime Get-Date)  -SelectedUsers @((New-SharingEnabledUser -IsSharePointGroup $false  -IsGuestUser $false  -IsGuestUserExistsInOrganization $false  -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -ExternalUserSharingSettings (New-ExternalUserSharingSettings -Enabled $false  -SharingType (New-ExternalUserSharingType)  -AnonymousLinkSettings (New-AnonymousLinkSettings -Permisssion (New-AnnoymouslinkPermissions)  -ExpirationDate Get-Date))  -WelcomeEmailSettings (New-WelcomeEmailSettings -Enabled $false  -Subject "Subject_example"  -PersonalMessage "PersonalMessage_example")  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # GrantPermissionRequest |  (optional)

# edit grant permission request in task
try {
    Edit-GrantPermissionRequest -Id $Id -GrantPermissionRequest $GrantPermissionRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **GrantPermissionRequest** | [**GrantPermissionRequest**](GrantPermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-LockSiteRequest"></a>
# **Edit-LockSiteRequest**
> void Edit-LockSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-LockSiteRequest] <PSCustomObject><br>

edit lock site request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$LockSiteRequest = (New-LockSiteRequest -LockType (New-SiteLockType)  -LockTypeDescription "LockTypeDescription_example"  -Action   -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # LockSiteRequest |  (optional)

# edit lock site request in task
try {
    Edit-LockSiteRequest -Id $Id -LockSiteRequest $LockSiteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **LockSiteRequest** | [**LockSiteRequest**](LockSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ManagePermissionRequest"></a>
# **Edit-ManagePermissionRequest**
> void Edit-ManagePermissionRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManagePermissionRequest] <PSCustomObject><br>

edit manage permission request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ManagePermissionRequest = (New-ManagePermissionRequest -ObjectUrl "ObjectUrl_example"  -ObjectType   -ObjectTitle "ObjectTitle_example"  -SiteUrl "SiteUrl_example"  -WebUrl "WebUrl_example"  -SpGroupManagement @((New-SPGroupManagementModel -Id 123  -Name   -Description "Description_example"  -Owner   -Members @((New-SPUserManagementModel -IdentityName "IdentityName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Action (New-ManagePermissionAction)  -ExternalUserType (New-ExternalUserType)))  -SpGroupViewType (New-SPGroupViewOption)  -SpGroupEditType (New-SPGroupEditOption)  -Permissions @("Permissions_example")  -Action (New-ManagePermissionAction)  -IsAllowJoinOrLeaveRequest $false  -IsAutoAcceptRequest $false  -SendMembershipRequestEmailAddress "SendMembershipRequestEmailAddress_example"  -IsTemporaryGroup $false))  -PermissionManagement (New-PermissionManagementModel -IsUniquePermission $false  -IsPermissionInheritanceChanged $false  -IsCopyPermissionsFromParent $false  -InheritedSiteUrl "InheritedSiteUrl_example"  -PermissionItems @((New-ObjectPermissionManagementModel -ObjectType (New-SPPrincipalType)  -ObjectInfo   -Action   -Permissions @("Permissions_example")  -OriginalPermissions @("OriginalPermissions_example")  -ExternalUserType (New-ExternalUserType)  -Members @((New-SharingEnabledUser -IsSharePointGroup $false  -IsGuestUser $false  -IsGuestUserExistsInOrganization $false  -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -GrantPermissionSetting (New-GrantPermissionModel -PermissionDurationSettings (New-TemporaryPermissionRequestSetting -IsGrantTemporaryPermission $false  -ExpirationType (New-ExpirationType)  -DurationInterval 123  -DurationDateType (New-ApiDurationTypeNullable)  -StartTime Get-Date  -EndTime Get-Date)  -WelcomeEmailSettings (New-WelcomeEmailSettings -Enabled $false  -Subject "Subject_example"  -PersonalMessage "PersonalMessage_example")))))  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # ManagePermissionRequest |  (optional)

# edit manage permission request in task
try {
    Edit-ManagePermissionRequest -Id $Id -ManagePermissionRequest $ManagePermissionRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ManagePermissionRequest** | [**ManagePermissionRequest**](ManagePermissionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-RestoreGroupRequest"></a>
# **Edit-RestoreGroupRequest**
> void Edit-RestoreGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RestoreGroupRequest] <PSCustomObject><br>

edit restore group request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$RestoreGroupRequest = (New-RestoreGroupRequest -GroupId "TODO"  -GroupName "GroupName_example"  -GroupEmail "GroupEmail_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # RestoreGroupRequest |  (optional)

# edit restore group request in task
try {
    Edit-RestoreGroupRequest -Id $Id -RestoreGroupRequest $RestoreGroupRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **RestoreGroupRequest** | [**RestoreGroupRequest**](RestoreGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-UnLockSiteRequest"></a>
# **Edit-UnLockSiteRequest**
> void Edit-UnLockSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UnlockSiteRequest] <PSCustomObject><br>

edit unlock site request in task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$UnlockSiteRequest = (New-UnlockSiteRequest -ExtendDuration 123  -ExtendDurationType   -Action   -ActionDescription "ActionDescription_example"  -SiteId "TODO"  -SiteUrl "SiteUrl_example"  -Id "TODO"  -ServiceId "TODO"  -Department "Department_example"  -Summary "Summary_example"  -NotesToApprovers "NotesToApprovers_example"  -QuestionnaireId "TODO"  -Metadatas @()  -TicketNumber 123  -Type   -TypeDescription "TypeDescription_example"  -Requester "Requester_example"  -Status   -ProgressStatus 123  -ProgressStatusDescription "ProgressStatusDescription_example"  -SubmittedTime Get-Date  -LastUpdated Get-Date  -CreatedTime Get-Date  -AssignTo "AssignTo_example"  -FullPath "FullPath_example") # UnlockSiteRequest |  (optional)

# edit unlock site request in task
try {
    Edit-UnLockSiteRequest -Id $Id -UnlockSiteRequest $UnlockSiteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **UnlockSiteRequest** | [**UnlockSiteRequest**](UnlockSiteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReport"></a>
# **Get-ChangePermissionReport**
> PermissionActionItemPageResult Get-ChangePermissionReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report
try {
    $Result = Get-ChangePermissionReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportByVersion"></a>
# **Get-ChangePermissionReportByVersion**
> PermissionActionItemPageResult Get-ChangePermissionReportByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report with specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report with specific version
try {
    $Result = Get-ChangePermissionReportByVersion -Id $Id -Version $Version -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportFilters"></a>
# **Get-ChangePermissionReportFilters**
> DistinctPageResult Get-ChangePermissionReportFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report filters

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report filters
try {
    $Result = Get-ChangePermissionReportFilters -Id $Id -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportFiltersByVersion"></a>
# **Get-ChangePermissionReportFiltersByVersion**
> DistinctPageResult Get-ChangePermissionReportFiltersByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report filters with specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report filters with specific version
try {
    $Result = Get-ChangePermissionReportFiltersByVersion -Id $Id -Version $Version -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportFiltersForSPGroup"></a>
# **Get-ChangePermissionReportFiltersForSPGroup**
> DistinctPageResult Get-ChangePermissionReportFiltersForSPGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report filters for a sharepoint group

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report filters for a sharepoint group
try {
    $Result = Get-ChangePermissionReportFiltersForSPGroup -Id $Id -Groupid $Groupid -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportFiltersForSPGroupByVersion"></a>
# **Get-ChangePermissionReportFiltersForSPGroupByVersion**
> DistinctPageResult Get-ChangePermissionReportFiltersForSPGroupByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report filters for a sharepoint group with specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report filters for a sharepoint group with specific version
try {
    $Result = Get-ChangePermissionReportFiltersForSPGroupByVersion -Id $Id -Groupid $Groupid -Version $Version -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportForSPGroup"></a>
# **Get-ChangePermissionReportForSPGroup**
> PermissionActionItemPageResult Get-ChangePermissionReportForSPGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report for a sharepoint group

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report for a sharepoint group
try {
    $Result = Get-ChangePermissionReportForSPGroup -Id $Id -Groupid $Groupid -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportForSPGroupByVersion"></a>
# **Get-ChangePermissionReportForSPGroupByVersion**
> PermissionActionItemPageResult Get-ChangePermissionReportForSPGroupByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get change permission report for a sharepoint group with specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get change permission report for a sharepoint group with specific version
try {
    $Result = Get-ChangePermissionReportForSPGroupByVersion -Id $Id -Version $Version -Groupid $Groupid -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportPermissionLevels"></a>
# **Get-ChangePermissionReportPermissionLevels**
> PermissionLevel[] Get-ChangePermissionReportPermissionLevels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get change permission report permission levels

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get change permission report permission levels
try {
   $Result = Get-ChangePermissionReportPermissionLevels -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**PermissionLevel[]**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionReportProperties"></a>
# **Get-ChangePermissionReportProperties**
> RecertificationReportProperties Get-ChangePermissionReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get change permission report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get change permission report properties
try {
    $Result = Get-ChangePermissionReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ClonePermissionReport"></a>
# **Get-ClonePermissionReport**
> ClonePermissionSecuritySearchResultPageResult Get-ClonePermissionReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get clone permission report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) (default to null)
$Search = "Search_example" # String | Search for  (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get clone permission report
try {
    $Result = Get-ClonePermissionReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] [default to null]
 **Search** | **String**| Search for  | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**ClonePermissionSecuritySearchResultPageResult**](ClonePermissionSecuritySearchResultPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ClonePermissionReportProperties"></a>
# **Get-ClonePermissionReportProperties**
> ClonePermissionReportProperty Get-ClonePermissionReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get clone permission report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get clone permission report properties
try {
    $Result = Get-ClonePermissionReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**ClonePermissionReportProperty**](ClonePermissionReportProperty.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GetManualArchiveReport"></a>
# **Get-GetManualArchiveReport**
> ManuallyArchiveRecordModelPageResult Get-GetManualArchiveReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get manual archive report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> rowKey, partitionKey, siteId, url, nodeType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> rowKey, partitionKey, siteId, url, nodeType (optional) (default to null)
$Search = "Search_example" # String | Search for url (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get manual archive report
try {
    $Result = Get-GetManualArchiveReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] [default to null]
 **Search** | **String**| Search for url | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**ManuallyArchiveRecordModelPageResult**](ManuallyArchiveRecordModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GetManualArchiveReportFilters"></a>
# **Get-GetManualArchiveReportFilters**
> DistinctPageResult Get-GetManualArchiveReportFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get manual archive report filters

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> rowKey, partitionKey, siteId, url, nodeType (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> rowKey, partitionKey, siteId, url, nodeType (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get manual archive report filters
try {
    $Result = Get-GetManualArchiveReportFilters -Id $Id -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; rowKey, partitionKey, siteId, url, nodeType | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembershipRecertificationReport"></a>
# **Get-GroupMembershipRecertificationReport**
> MembershipRecertificationItemPageResult Get-GroupMembershipRecertificationReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group membership recertification report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Search = "Search_example" # String | Search for user (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group membership recertification report
try {
    $Result = Get-GroupMembershipRecertificationReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Search** | **String**| Search for user | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**MembershipRecertificationItemPageResult**](MembershipRecertificationItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembershipRecertificationReportByVersion"></a>
# **Get-GroupMembershipRecertificationReportByVersion**
> MembershipRecertificationItemPageResult Get-GroupMembershipRecertificationReportByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int32><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group membership recertification report by version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int32 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Search = "Search_example" # String | Search for user (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group membership recertification report by version
try {
    $Result = Get-GroupMembershipRecertificationReportByVersion -Id $Id -Version $Version -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int32**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Search** | **String**| Search for user | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**MembershipRecertificationItemPageResult**](MembershipRecertificationItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembershipRecertificationReportFilters"></a>
# **Get-GroupMembershipRecertificationReportFilters**
> DistinctPageResult Get-GroupMembershipRecertificationReportFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group membership recertification report filters

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group membership recertification report filters
try {
    $Result = Get-GroupMembershipRecertificationReportFilters -Id $Id -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembershipRecertificationReportFiltersByVersion"></a>
# **Get-GroupMembershipRecertificationReportFiltersByVersion**
> DistinctPageResult Get-GroupMembershipRecertificationReportFiltersByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int32><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group membership recertification report filters by version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int32 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group membership recertification report filters by version
try {
    $Result = Get-GroupMembershipRecertificationReportFiltersByVersion -Id $Id -Version $Version -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int32**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, action, user, userDisplayName, membershipType, accessType | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembershipRecertificationReportProperties"></a>
# **Get-GroupMembershipRecertificationReportProperties**
> MembershipRecertificationReportProperties Get-GroupMembershipRecertificationReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get group membership recertification report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get group membership recertification report properties
try {
    $Result = Get-GroupMembershipRecertificationReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**MembershipRecertificationReportProperties**](MembershipRecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPermissionRecertificationReport"></a>
# **Get-GroupPermissionRecertificationReport**
> GroupPermissionActionItemPageResult Get-GroupPermissionRecertificationReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group permission recertification report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group permission recertification report
try {
    $Result = Get-GroupPermissionRecertificationReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPermissionRecertificationReportByVersion"></a>
# **Get-GroupPermissionRecertificationReportByVersion**
> GroupPermissionActionItemPageResult Get-GroupPermissionRecertificationReportByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int32><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group permission recertification report by version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int32 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group permission recertification report by version
try {
    $Result = Get-GroupPermissionRecertificationReportByVersion -Id $Id -Version $Version -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int32**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPermissionRecertificationReportFilters"></a>
# **Get-GroupPermissionRecertificationReportFilters**
> DistinctPageResult Get-GroupPermissionRecertificationReportFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group permission recertification report filters

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group permission recertification report filters
try {
    $Result = Get-GroupPermissionRecertificationReportFilters -Id $Id -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPermissionRecertificationReportFiltersForSPGroup"></a>
# **Get-GroupPermissionRecertificationReportFiltersForSPGroup**
> DistinctPageResult Get-GroupPermissionRecertificationReportFiltersForSPGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group permission recertification report filters for sharepoint group

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group permission recertification report filters for sharepoint group
try {
    $Result = Get-GroupPermissionRecertificationReportFiltersForSPGroup -Id $Id -Groupid $Groupid -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPermissionRecertificationReportForSPGroup"></a>
# **Get-GroupPermissionRecertificationReportForSPGroup**
> GroupPermissionActionItemPageResult Get-GroupPermissionRecertificationReportForSPGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get group permission recertification report for sharepoint group

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get group permission recertification report for sharepoint group
try {
    $Result = Get-GroupPermissionRecertificationReportForSPGroup -Id $Id -Groupid $Groupid -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, instanceId, type, taskId, displayName, identityName, permissionLevel, titleName, path, sharePointGroup, parentId, idInSharepoint, level, accountType, accessType | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**GroupPermissionActionItemPageResult**](GroupPermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPermissionRecertificationReportProperties"></a>
# **Get-GroupPermissionRecertificationReportProperties**
> RecertificationReportProperties Get-GroupPermissionRecertificationReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get group permission recertification report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get group permission recertification report properties
try {
    $Result = Get-GroupPermissionRecertificationReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyTaskFilters"></a>
# **Get-MyTaskFilters**
> DistinctPageResult Get-MyTaskFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Isconfirmtask] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get my task filters

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Isconfirmtask = true # Boolean |  (optional) (default to false)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get my task filters
try {
    $Result = Get-MyTaskFilters -Isconfirmtask $Isconfirmtask -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Isconfirmtask** | **Boolean**|  | [optional] [default to false]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyTasks"></a>
# **Get-MyTasks**
> TaskListPageResult Get-MyTasks<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Isconfirmtask] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get my tasks

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Isconfirmtask = true # Boolean |  (optional) (default to false)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status (optional) (default to null)
$Search = "Search_example" # String | Search for title (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get my tasks
try {
    $Result = Get-MyTasks -Isconfirmtask $Isconfirmtask -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Isconfirmtask** | **Boolean**|  | [optional] [default to false]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, title, requester, requestTicketNumber, requesterDisplayName, dueDate, serviceType, createdTime, taskType, status | [optional] [default to null]
 **Search** | **String**| Search for title | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**TaskListPageResult**](TaskListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-RemovePermissionReport"></a>
# **Get-RemovePermissionReport**
> SecuritySearchResultPageResult Get-RemovePermissionReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get remove permission report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action (optional) (default to null)
$Search = "Search_example" # String | Search for  (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get remove permission report
try {
    $Result = Get-RemovePermissionReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, displayName, identityName, objectUrl, objectTitle, objectType, accountType, sharePointGroup, permissionLevels, action | [optional] [default to null]
 **Search** | **String**| Search for  | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**SecuritySearchResultPageResult**](SecuritySearchResultPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-RemovePermissionReportProperties"></a>
# **Get-RemovePermissionReportProperties**
> RecertificationReportProperties Get-RemovePermissionReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get remove permission report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get remove permission report properties
try {
    $Result = Get-RemovePermissionReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteMetadataRecertificationReport"></a>
# **Get-SiteMetadataRecertificationReport**
> CustomMetadata[] Get-SiteMetadataRecertificationReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get site metadata recertification metadata

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get site metadata recertification metadata
try {
    $Result = Get-SiteMetadataRecertificationReport -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**CustomMetadata[]**](CustomMetadata.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteMetadataRecertificationReportProperties"></a>
# **Get-SiteMetadataRecertificationReportProperties**
> MetadataRecertificationReportProperties Get-SiteMetadataRecertificationReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get site metadata recertification report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get site metadata recertification report properties
try {
    $Result = Get-SiteMetadataRecertificationReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**MetadataRecertificationReportProperties**](MetadataRecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteOwnershipRecertificationReportProperties"></a>
# **Get-SiteOwnershipRecertificationReportProperties**
> RecertificationReportProperties Get-SiteOwnershipRecertificationReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get site ownership recertification report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get site ownership recertification report properties
try {
    $Result = Get-SiteOwnershipRecertificationReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificatioPermissionFilters"></a>
# **Get-SitePermissionRecertificatioPermissionFilters**
> DistinctPageResult Get-SitePermissionRecertificatioPermissionFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get site permission recertification permission filters

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get site permission recertification permission filters
try {
    $Result = Get-SitePermissionRecertificatioPermissionFilters -Id $Id -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificatioReportFiltersByVersion"></a>
# **Get-SitePermissionRecertificatioReportFiltersByVersion**
> DistinctPageResult Get-SitePermissionRecertificatioReportFiltersByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get site permission recertification permission filters with specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get site permission recertification permission filters with specific version
try {
    $Result = Get-SitePermissionRecertificatioReportFiltersByVersion -Id $Id -Version $Version -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificatioReportFiltersForSPGroup"></a>
# **Get-SitePermissionRecertificatioReportFiltersForSPGroup**
> DistinctPageResult Get-SitePermissionRecertificatioReportFiltersForSPGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

try {
    $Result = Get-SitePermissionRecertificatioReportFiltersForSPGroup -Id $Id -Groupid $Groupid -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion"></a>
# **Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion**
> DistinctPageResult Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

try {
    $Result = Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion -Id $Id -Groupid $Groupid -Version $Version -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificationPermissionLevels"></a>
# **Get-SitePermissionRecertificationPermissionLevels**
> PermissionLevel[] Get-SitePermissionRecertificationPermissionLevels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get site permission recertification permission levels

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get site permission recertification permission levels
try {
    $Result = Get-SitePermissionRecertificationPermissionLevels -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**PermissionLevel[]**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificationReport"></a>
# **Get-SitePermissionRecertificationReport**
> PermissionActionItemPageResult Get-SitePermissionRecertificationReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get site permission recertification report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get site permission recertification report
try {
    $Result = Get-SitePermissionRecertificationReport -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificationReportByVersion"></a>
# **Get-SitePermissionRecertificationReportByVersion**
> PermissionActionItemPageResult Get-SitePermissionRecertificationReportByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get site permission recertification report by specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get site permission recertification report by specific version
try {
    $Result = Get-SitePermissionRecertificationReportByVersion -Id $Id -Version $Version -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificationReportForSPGroup"></a>
# **Get-SitePermissionRecertificationReportForSPGroup**
> PermissionActionItemPageResult Get-SitePermissionRecertificationReportForSPGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get site permission recertification group permission items

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get site permission recertification group permission items
try {
    $Result = Get-SitePermissionRecertificationReportForSPGroup -Id $Id -Groupid $Groupid -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificationReportForSPGroupByVersion"></a>
# **Get-SitePermissionRecertificationReportForSPGroupByVersion**
> PermissionActionItemPageResult Get-SitePermissionRecertificationReportForSPGroupByVersion<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Version] <Int64><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>

get site permission recertification group permission items with specific version with specific version

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Version = 987 # Int64 |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)

# get site permission recertification group permission items with specific version with specific version
try {
    $Result = Get-SitePermissionRecertificationReportForSPGroupByVersion -Id $Id -Version $Version -Groupid $Groupid -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Version** | **Int64**|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, idInSharepoint, accountType, displayName, level, memberOf, path, permissionLevel, sharePointGroup, titleName, userOrGroup, memberId, parentId, parentAccountType, actionType, accessType, isSiteAdministrator | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]

### Return type

[**PermissionActionItemPageResult**](PermissionActionItemPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionRecertificationReportProperties"></a>
# **Get-SitePermissionRecertificationReportProperties**
> RecertificationReportProperties Get-SitePermissionRecertificationReportProperties<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get site permission recertification report properties

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get site permission recertification report properties
try {
    $Result = Get-SitePermissionRecertificationReportProperties -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**RecertificationReportProperties**](RecertificationReportProperties.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TaskByBatchId"></a>
# **Get-TaskByBatchId**
> TaskList Get-TaskByBatchId<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Batchid] <PSCustomObject><br>

get task by batch id

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Batchid = TODO # UUID |  (default to null)

# get task by batch id
try {
    $Result = Get-TaskByBatchId -Batchid $Batchid
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Batchid** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**TaskList**](TaskList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TaskById"></a>
# **Get-TaskById**
> ApiTask Get-TaskById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get my task by id

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# get my task by id
try {
    $Result = Get-TaskById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**ApiTask**](ApiTask.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-PromoteAsOwnersForGroupMembershipRecertification"></a>
# **Invoke-PromoteAsOwnersForGroupMembershipRecertification**
> void Invoke-PromoteAsOwnersForGroupMembershipRecertification<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiUser] <PSCustomObject[]><br>

promote as owners for group membership recertification

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ApiUser = @() # ApiUser[] | 

# promote as owners for group membership recertification
try {
    Invoke-PromoteAsOwnersForGroupMembershipRecertification -Id $Id -ApiUser $ApiUser
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ApiUser** | [**ApiUser[]**](ApiUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ReassignTask"></a>
# **Invoke-ReassignTask**
> void Invoke-ReassignTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-User] <String><br>

reassign task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$User = "User_example" # String |  (default to null)

# reassign task
try {
    Invoke-ReassignTask -Id $Id -User $User
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **User** | **String**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-RejectTask"></a>
# **Invoke-RejectTask**
> void Invoke-RejectTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

reject task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CommentsParam = (New-CommentsParam -Comments "Comments_example") # CommentsParam |  (optional)

# reject task
try {
    Invoke-RejectTask -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Remove-UsersForGroupMembershipRecertification"></a>
# **Remove-UsersForGroupMembershipRecertification**
> void Remove-UsersForGroupMembershipRecertification<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

remove users for group membership recertification

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$UUID = @("TODO") # UUID[] |  (optional)

# remove users for group membership recertification
try {
    Remove-UsersForGroupMembershipRecertification -Id $Id -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ReseAllChangesForChangePermissionTask"></a>
# **Invoke-ReseAllChangesForChangePermissionTask**
> void Invoke-ReseAllChangesForChangePermissionTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

save all changes for change permission task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# save all changes for change permission task
try {
    Invoke-ReseAllChangesForChangePermissionTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Reset-AllChangesForRecertificationTask"></a>
# **Reset-AllChangesForRecertificationTask**
> void Reset-AllChangesForRecertificationTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

reset all changes for site/group recertification task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# reset all changes for site/group recertification task
try {
    Reset-AllChangesForRecertificationTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Reset-MyChangesForChangePermissionTask"></a>
# **Reset-MyChangesForChangePermissionTask**
> void Reset-MyChangesForChangePermissionTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

save my changes for change permission task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# save my changes for change permission task
try {
    Reset-MyChangesForChangePermissionTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Reset-MyChangesForRecertificationTask"></a>
# **Reset-MyChangesForRecertificationTask**
> void Reset-MyChangesForRecertificationTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

reset my changes for site/group recertification task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# reset my changes for site/group recertification task
try {
    Reset-MyChangesForRecertificationTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-RetryErrorTask"></a>
# **Invoke-RetryErrorTask**
> void Invoke-RetryErrorTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

retry error task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CommentsParam =  # CommentsParam |  (optional)

# retry error task
try {
    Invoke-RetryErrorTask -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-ChangePermissionActions"></a>
# **Save-ChangePermissionActions**
> void Save-ChangePermissionActions<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PermissionActionItem] <PSCustomObject[]><br>

save change permission actions

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$PermissionActionItem = @((New-PermissionActionItem -Id "Id_example"  -IdInSharepoint "IdInSharepoint_example"  -AccountType (New-PrincipalType)  -AccountTypeDescription "AccountTypeDescription_example"  -DisplayName "DisplayName_example"  -Level "Level_example"  -LevelDescription "LevelDescription_example"  -MemberOf "MemberOf_example"  -Path "Path_example"  -PermissionLevel "PermissionLevel_example"  -SharePointGroup "SharePointGroup_example"  -TitleName "TitleName_example"  -UserOrGroup "UserOrGroup_example"  -MemberId 123  -ParentId "ParentId_example"  -ParentAccountType 123  -ActionType (New-PermissionActionType)  -AccessType (New-UserAccessType)  -AccessTypeDescription "AccessTypeDescription_example"  -IsSiteAdministrator $false)) # PermissionActionItem[] | 

# save change permission actions
try {
    Save-ChangePermissionActions -Id $Id -PermissionActionItem $PermissionActionItem
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **PermissionActionItem** | [**PermissionActionItem[]**](PermissionActionItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-ClonePermissionReport"></a>
# **Save-ClonePermissionReport**
> void Save-ClonePermissionReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SecuritySearchResult] <PSCustomObject[]><br>

Save clone permission report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$SecuritySearchResult = @((New-SecuritySearchResult -Id "TODO"  -DisplayName "DisplayName_example"  -IdentityName "IdentityName_example"  -ObjectUrl "ObjectUrl_example"  -ObjectTitle "ObjectTitle_example"  -ObjectType "ObjectType_example"  -ObjectTypeDescription "ObjectTypeDescription_example"  -AccountType "AccountType_example"  -AccountTypeDescription "AccountTypeDescription_example"  -SharePointGroup "SharePointGroup_example"  -PermissionLevels "PermissionLevels_example"  -Action (New-ApprovalAction)  -AccessType "AccessType_example")) # SecuritySearchResult[] | 

# Save clone permission report
try {
    Save-ClonePermissionReport -Id $Id -SecuritySearchResult $SecuritySearchResult
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SecuritySearchResult** | [**SecuritySearchResult[]**](SecuritySearchResult.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-GetManualArchiveReport"></a>
# **Save-GetManualArchiveReport**
> void Save-GetManualArchiveReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManuallyArchiveRecordModel] <PSCustomObject[]><br>

save manual archive report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$ManuallyArchiveRecordModel = @((New-ManuallyArchiveRecordModel -RowKey "RowKey_example"  -PartitionKey "PartitionKey_example"  -SiteId "TODO"  -Url "Url_example"  -Version "Version_example"  -IsSelected $false  -NodeType (New-ManualArchiveNodeLevel)  -NodeTypeDescription "NodeTypeDescription_example")) # ManuallyArchiveRecordModel[] | 

# save manual archive report
try {
    Save-GetManualArchiveReport -Id $Id -ManuallyArchiveRecordModel $ManuallyArchiveRecordModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ManuallyArchiveRecordModel** | [**ManuallyArchiveRecordModel[]**](ManuallyArchiveRecordModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-GroupPermissionRecertificationResults"></a>
# **Save-GroupPermissionRecertificationResults**
> void Save-GroupPermissionRecertificationResults<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupPermissionActionItem] <PSCustomObject[]><br>

save group permission recertification results

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$GroupPermissionActionItem = @((New-GroupPermissionActionItem -Id "TODO"  -InstanceId "TODO"  -Type (New-RecertificationActionType)  -TaskId "TODO"  -ActionType (New-PermissionActionType)  -DisplayName "DisplayName_example"  -IdentityName "IdentityName_example"  -PermissionLevel "PermissionLevel_example"  -PermissionIds @(123)  -MemberId 123  -TitleName "TitleName_example"  -Path "Path_example"  -SharePointGroup "SharePointGroup_example"  -ParentId "ParentId_example"  -IdInSharepoint "IdInSharepoint_example"  -Level 123  -LevelDescription "LevelDescription_example"  -AccountType (New-PrincipalType)  -AccountTypeDescription "AccountTypeDescription_example"  -AccessType (New-UserAccessType)  -AccessTypeDescription "AccessTypeDescription_example")) # GroupPermissionActionItem[] | 

# save group permission recertification results
try {
    Save-GroupPermissionRecertificationResults -Id $Id -GroupPermissionActionItem $GroupPermissionActionItem
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **GroupPermissionActionItem** | [**GroupPermissionActionItem[]**](GroupPermissionActionItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-RemovePermissionReport"></a>
# **Save-RemovePermissionReport**
> void Save-RemovePermissionReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SecuritySearchResult] <PSCustomObject[]><br>

save remove permission report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$SecuritySearchResult = @((New-SecuritySearchResult -Id "TODO"  -DisplayName "DisplayName_example"  -IdentityName "IdentityName_example"  -ObjectUrl "ObjectUrl_example"  -ObjectTitle "ObjectTitle_example"  -ObjectType "ObjectType_example"  -ObjectTypeDescription "ObjectTypeDescription_example"  -AccountType "AccountType_example"  -AccountTypeDescription "AccountTypeDescription_example"  -SharePointGroup "SharePointGroup_example"  -PermissionLevels "PermissionLevels_example"  -Action (New-ApprovalAction)  -AccessType "AccessType_example")) # SecuritySearchResult[] | 

# save remove permission report
try {
    Save-RemovePermissionReport -Id $Id -SecuritySearchResult $SecuritySearchResult
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SecuritySearchResult** | [**SecuritySearchResult[]**](SecuritySearchResult.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-SiteMetadataRecertificationResult"></a>
# **Save-SiteMetadataRecertificationResult**
> void Save-SiteMetadataRecertificationResult<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestMetadata] <PSCustomObject[]><br>

save site metadata recertification metadata

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$RequestMetadata = @() # RequestMetadata[] | 

# save site metadata recertification metadata
try {
    Save-SiteMetadataRecertificationResult -Id $Id -RequestMetadata $RequestMetadata
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **RequestMetadata** | [**RequestMetadata[]**](RequestMetadata.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-SitePermissionRecertificationResult"></a>
# **Save-SitePermissionRecertificationResult**
> void Save-SitePermissionRecertificationResult<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PermissionActionItem] <PSCustomObject[]><br>

save site permission recertification permissions

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$PermissionActionItem = @((New-PermissionActionItem -Id "Id_example"  -IdInSharepoint "IdInSharepoint_example"  -AccountType   -AccountTypeDescription "AccountTypeDescription_example"  -DisplayName "DisplayName_example"  -Level "Level_example"  -LevelDescription "LevelDescription_example"  -MemberOf "MemberOf_example"  -Path "Path_example"  -PermissionLevel "PermissionLevel_example"  -SharePointGroup "SharePointGroup_example"  -TitleName "TitleName_example"  -UserOrGroup "UserOrGroup_example"  -MemberId 123  -ParentId "ParentId_example"  -ParentAccountType 123  -ActionType   -AccessType   -AccessTypeDescription "AccessTypeDescription_example"  -IsSiteAdministrator $false)) # PermissionActionItem[] | 

# save site permission recertification permissions
try {
    Save-SitePermissionRecertificationResult -Id $Id -PermissionActionItem $PermissionActionItem
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **PermissionActionItem** | [**PermissionActionItem[]**](PermissionActionItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Skip-ErrorTask"></a>
# **Skip-ErrorTask**
> void Skip-ErrorTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

skip error task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CommentsParam =  # CommentsParam |  (optional)

# skip error task
try {
    Skip-ErrorTask -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived"></a>
# **Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived**
> void Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Primarycontact] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Secondarycontact] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Primarycontactemail] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Secodnarycontactemail] <PSCustomObject><br>

specify primary and secondary contact when primary contact is deactived

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Primarycontact = "Primarycontact_example" # String |  (default to null)
$Secondarycontact = "Secondarycontact_example" # String |  (default to null)
$Primarycontactemail = TODO # UUID |  (optional) (default to null)
$Secodnarycontactemail = TODO # UUID |  (optional) (default to null)

# specify primary and secondary contact when primary contact is deactived
try {
    Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived -Id $Id -Primarycontact $Primarycontact -Secondarycontact $Secondarycontact -Primarycontactemail $Primarycontactemail -Secodnarycontactemail $Secodnarycontactemail
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Primarycontact** | **String**|  | [default to null]
 **Secondarycontact** | **String**|  | [default to null]
 **Primarycontactemail** | [**UUID**](UUID.md)|  | [optional] [default to null]
 **Secodnarycontactemail** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived"></a>
# **Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived**
> void Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Secondarycontact] <String><br>

specify secondary contact when secondary contact is deactived

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$Secondarycontact = "Secondarycontact_example" # String |  (default to null)

# specify secondary contact when secondary contact is deactived
try {
    Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived -Id $Id -Secondarycontact $Secondarycontact
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Secondarycontact** | **String**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ArchiveGroupAutoTask"></a>
# **Submit-ArchiveGroupAutoTask**
> void Submit-ArchiveGroupAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskArchiveRequest] <PSCustomObject><br>

submit archive group auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskArchiveRequest = (New-AutoTaskArchiveRequest -Action (New-LifecycleAction)  -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskArchiveRequest |  (optional)

# submit archive group auto task
try {
    Submit-ArchiveGroupAutoTask -AutoTaskArchiveRequest $AutoTaskArchiveRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskArchiveRequest** | [**AutoTaskArchiveRequest**](AutoTaskArchiveRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ArchiveSiteAutoTask"></a>
# **Submit-ArchiveSiteAutoTask**
> void Submit-ArchiveSiteAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskArchiveRequest] <PSCustomObject><br>

submit site archive auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskArchiveRequest = (New-AutoTaskArchiveRequest -Action (New-LifecycleAction)  -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskArchiveRequest |  (optional)

# submit site archive auto task
try {
    Submit-ArchiveSiteAutoTask -AutoTaskArchiveRequest $AutoTaskArchiveRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskArchiveRequest** | [**AutoTaskArchiveRequest**](AutoTaskArchiveRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ChangeSitePolicyAutoTask"></a>
# **Submit-ChangeSitePolicyAutoTask**
> void Submit-ChangeSitePolicyAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskChangePolicyRequest] <PSCustomObject><br>

submit site policy change auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskChangePolicyRequest = (New-AutoTaskChangePolicyRequest -Action   -Policy   -StartDateType   -SpecifyStartDate Get-Date  -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskChangePolicyRequest |  (optional)

# submit site policy change auto task
try {
    Submit-ChangeSitePolicyAutoTask -AutoTaskChangePolicyRequest $AutoTaskChangePolicyRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskChangePolicyRequest** | [**AutoTaskChangePolicyRequest**](AutoTaskChangePolicyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ContinueAccessGroupAutoTask"></a>
# **Submit-ContinueAccessGroupAutoTask**
> void Submit-ContinueAccessGroupAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

submit group continue access auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (optional) (default to null)
$CommentsParam =  # CommentsParam |  (optional)

# submit group continue access auto task
try {
    Submit-ContinueAccessGroupAutoTask -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [optional] [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ContinueAccessSiteAutoTask"></a>
# **Submit-ContinueAccessSiteAutoTask**
> void Submit-ContinueAccessSiteAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

submit site continue access auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (optional) (default to null)
$CommentsParam =  # CommentsParam |  (optional)

# submit site continue access auto task
try {
    Submit-ContinueAccessSiteAutoTask -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [optional] [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-DeleteGroupAutoTask"></a>
# **Submit-DeleteGroupAutoTask**
> void Submit-DeleteGroupAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskDeleteRequest] <PSCustomObject><br>

submit delete group auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskDeleteRequest = (New-AutoTaskDeleteRequest -Action   -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskDeleteRequest |  (optional)

# submit delete group auto task
try {
    Submit-DeleteGroupAutoTask -AutoTaskDeleteRequest $AutoTaskDeleteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskDeleteRequest** | [**AutoTaskDeleteRequest**](AutoTaskDeleteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-DeleteSiteAutoTask"></a>
# **Submit-DeleteSiteAutoTask**
> void Submit-DeleteSiteAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskDeleteRequest] <PSCustomObject><br>

submit site delete auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskDeleteRequest = (New-AutoTaskDeleteRequest -Action   -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskDeleteRequest |  (optional)

# submit site delete auto task
try {
    Submit-DeleteSiteAutoTask -AutoTaskDeleteRequest $AutoTaskDeleteRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskDeleteRequest** | [**AutoTaskDeleteRequest**](AutoTaskDeleteRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ExtendGroupAutoTask"></a>
# **Submit-ExtendGroupAutoTask**
> void Submit-ExtendGroupAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskExtendRequest] <PSCustomObject><br>

submit extend group auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskExtendRequest = (New-AutoTaskExtendRequest -Action   -ExtendDuration 123  -ExtendDurationType   -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskExtendRequest |  (optional)

# submit extend group auto task
try {
    Submit-ExtendGroupAutoTask -AutoTaskExtendRequest $AutoTaskExtendRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ExtendSiteAutoTask"></a>
# **Submit-ExtendSiteAutoTask**
> void Submit-ExtendSiteAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskExtendRequest] <PSCustomObject><br>

submit site extend auto task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$AutoTaskExtendRequest = (New-AutoTaskExtendRequest -Action   -ExtendDuration 123  -ExtendDurationType   -TaskId "TODO"  -Metadatas @()  -Comments ) # AutoTaskExtendRequest |  (optional)

# submit site extend auto task
try {
    Submit-ExtendSiteAutoTask -AutoTaskExtendRequest $AutoTaskExtendRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-RecertificationTask"></a>
# **Submit-RecertificationTask**
> void Submit-RecertificationTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

submit site/group recertification task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)
$CommentsParam =  # CommentsParam |  (optional)

# submit site/group recertification task
try {
    Submit-RecertificationTask -Id $Id -CommentsParam $CommentsParam
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ViewSiteOwnershipRecertificationTask"></a>
# **Invoke-ViewSiteOwnershipRecertificationTask**
> OwnershipRecertification Invoke-ViewSiteOwnershipRecertificationTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

view site ownership recertification task

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Cloud.Governance.ClientConfiguration

$Configuration["BaseUrl"] = "https://API_BASE_URL"

# Configure API key authorization: ClientId

$Configuration["ApiKey"]["clientId"] = "YOUR_API_KEY"


# Configure API key authorization: ClientSecret
$Configuration["ApiKey"]["clientSecret"] = "YOUR_API_KEY"


# Configure API key authorization: UserPrincipalName
$Configuration["ApiKey"]["userPrincipalName"] = "YOUR_API_KEY"



$Id = TODO # UUID |  (default to null)

# view site ownership recertification task
try {
    $Result = Invoke-ViewSiteOwnershipRecertificationTask -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**OwnershipRecertification**](OwnershipRecertification.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

