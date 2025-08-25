# Cloud.Governance.Client - A PowerShell client for AvePoint Cloud Governance public REST endpoints providing the functionalities of Cloud Governance.

- SDK version: 8.8.0

<a name="frameworks-supported"></a>
## Frameworks supported
- PowerShell 5.0 or later

<a name="installation"></a>
## Installation

To install from PowerShell Gallery (https://www.powershellgallery.com/packages/Cloud.Governance.Client)
```powershell
Import-Module -Name Cloud.Governance.Client -Verbose
```

## Documentation for API Endpoints

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthApi* | [**Get-DelegateAccessToken**](docs/AuthApi.md#Get-DelegateAccessToken) | **POST** /auth/token/delegate | get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
*AuthApi* | [**Invoke-RefreshUserAccessToken**](docs/AuthApi.md#Invoke-RefreshUserAccessToken) | **POST** /auth/token/refresh | refresh user access token
*AuthAdminApi* | [**Invoke-DeleteTokenCache**](docs/AuthAdminApi.md#Invoke-DeleteTokenCache) | **DELETE** /admin/auth/token/cache | delete token cache
*GuestUsersAdminApi* | [**Get-ManagedGuestUsers**](docs/GuestUsersAdminApi.md#Get-ManagedGuestUsers) | **GET** /admin/directory/guestusers | get all managed guest users
*JobmonitorAdminApi* | [**Get-AllJobMonitorReports**](docs/JobmonitorAdminApi.md#Get-AllJobMonitorReports) | **GET** /admin/jobmonitor | get all jobs
*JobmonitorAdminApi* | [**Get-WorkspacejobBasicInfo**](docs/JobmonitorAdminApi.md#Get-WorkspacejobBasicInfo) | **GET** /admin/jobmonitor/{id}/basic | get workspace job basic information              support action:unlock/specify contact/restore workspace/refresh guest invite status
*JobsAdminApi* | [**Get-Jobs**](docs/JobsAdminApi.md#Get-Jobs) | **GET** /admin/jobs | Get worker jobs
*JobsAdminApi* | [**Get-RelatedJobs**](docs/JobsAdminApi.md#Get-RelatedJobs) | **GET** /admin/jobs/relations | Get related worker job
*MetadataAdminApi* | [**Get-AllMetadata**](docs/MetadataAdminApi.md#Get-AllMetadata) | **GET** /admin/metadata | get all metadata
*MetadataAdminApi* | [**Get-SingleMetadataById**](docs/MetadataAdminApi.md#Get-SingleMetadataById) | **GET** /admin/metadata/{id} | Get metadata by id
*Office365Api* | [**New-ACGSecurityGroup**](docs/Office365Api.md#new-acgsecuritygroup) | **POST** /office365/securitygroups | Create mail-enabled security group
*Office365Api* | [**Get-ACGAllSiteDesigns**](docs/Office365Api.md#get-acgallsitedesigns) | **GET** /office365/allsitedesigns | get all site designs by site url
*Office365Api* | [**Get-GroupAllMembersByGroupValue**](docs/Office365Api.md#Get-GroupAllMembersByGroupValue) | **GET** /office365/groups/allmembers | get group members by group email
*Office365Api* | [**Get-ACGGroupMembers**](docs/Office365Api.md#get-acggroupmembers) | **GET** /office365/groups/{email}/memberswithoutowner | get group members without owners by group email
*Office365Api* | [**Get-ACGGroupOwners**](docs/Office365Api.md#get-acggroupowners) | **GET** /office365/groups/{email}/owners | get group owners by group email
*Office365Api* | [**Get-HubSiteUrlsByUrl**](docs/Office365Api.md#Get-HubSiteUrlsByUrl) | **GET** /office365/hubsiteurls | get all hubsite urls from site's tenant
*Office365Api* | [**Get-HubSitesByUrl**](docs/Office365Api.md#Get-HubSitesByUrl) | **GET** /office365/hubsites | get all hubsites from site's tenant
*Office365Api* | [**Get-OfficeSiteTemplates**](docs/Office365Api.md#get-officesitetemplates) | **GET** /office365/{officeTenantId}/sites/templates/{languageId} | get site templates with language code identifier
*Office365Api* | [**Get-OwnedTeams**](docs/Office365Api.md#Get-OwnedTeams) | **GET** /office365/teams/my | get all teams that owner is curernt user
*Office365Api* | [**Get-ACGPermissions**](docs/Office365Api.md#get-acgpermissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
*Office365Api* | [**Get-ACGRoleAssignment**](docs/Office365Api.md#get-acgroleassignment) | **GET** /office365/roleassignment | get site permimssion role assignment
*Office365Api* | [**Get-ACGSiteDesigns**](docs/Office365Api.md#get-acgsitedesigns) | **GET** /office365/sitedesigns | get site designs by site url
*Office365Api* | [**Get-SitePermissionLevels**](docs/Office365Api.md#Get-SitePermissionLevels) | **GET** /office365/sites/permissionlevels | get site permission levels
*Office365Api* | [**Get-SiteSensitivityLabels**](docs/Office365Api.md#Get-SiteSensitivityLabels) | **GET** /office365/sites/sensitivitylabelsetting | get site sharePoint groups
*Office365Api* | [**Get-SiteSharePointGroups**](docs/Office365Api.md#Get-SiteSharePointGroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
*Office365Api* | [**Get-ACGSiteStatus**](docs/Office365Api.md#get-acgsitestatus) | **GET** /office365/sites/status | check site collection status by full url
*Office365Api* | [**Get-ACGSiteTemplates**](docs/Office365Api.md#get-acgsitetemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
*Office365Api* | [**Get-ACGTeamSiteDesigns**](docs/Office365Api.md#get-acgteamsitedesigns) | **GET** /office365/teamsitedesigns | 
*Office365Api* | [**Invoke-HasPermission**](docs/Office365Api.md#Invoke-HasPermission) | **GET** /office365/sites/haspermission | whether user has permission on the site
*Office365Api* | [**Remove-ACGSecurityGroup**](docs/Office365Api.md#remove-acgsecuritygroup) | **DELETE** /office365/securitygroups/{name} | Remove mail-enabled security group by group name
*Office365AdminApi* | [**Add-WebUserCustomAction**](docs/Office365AdminApi.md#Add-WebUserCustomAction) | **POST** /admin/office365/web/usercustomactions | add user custom actions, if exists, will update the existing one.
*Office365AdminApi* | [**Invoke-DeleteWebUserCustomAction**](docs/Office365AdminApi.md#Invoke-DeleteWebUserCustomAction) | **DELETE** /admin/office365/web/usercustomactions | delete user custom actions by action name
*Office365AdminApi* | [**Get-AzureADExtensionPropertyNamesWithDataType**](docs/Office365AdminApi.md#Get-AzureADExtensionPropertyNamesWithDataType) | **GET** /admin/office365/azuread/{tenantId}/property/custom | get azure ad custom property with data type
*Office365AdminApi* | [**Get-AzureAdCustomPropertyNames**](docs/Office365AdminApi.md#Get-AzureAdCustomPropertyNames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
*Office365AdminApi* | [**Get-DownloadFileUrL**](docs/Office365AdminApi.md#Get-DownloadFileUrL) | **GET** /admin/office365/downloadurl/{type} | get download file url
*Office365AdminApi* | [**Get-TenantIdByUrl**](docs/Office365AdminApi.md#Get-TenantIdByUrl) | **GET** /admin/office365/tenantid | get tenant ids by url
*Office365AdminApi* | [**Get-TenantIds**](docs/Office365AdminApi.md#Get-TenantIds) | **GET** /admin/office365/tenantids | get tenant ids by filter expression
*Office365AdminApi* | [**Get-UploadFileUrL**](docs/Office365AdminApi.md#Get-UploadFileUrL) | **GET** /admin/office365/uploadurl/{type} | get upload file url
*Office365SettingsAdminApi* | [**Update-DenyAddAndCustomizePagesStatus**](docs/Office365SettingsAdminApi.md#Update-DenyAddAndCustomizePagesStatus) | **PUT** /admin/settings/office365/updatedenyaddandcustomizepagesstatus | update denyaddandcustomizepages status by custom action
*ReportAdminApi* | [**Invoke-GeTaskReport**](docs/ReportAdminApi.md#Invoke-GeTaskReport) | **GET** /admin/report/tasks | get all tasks report
*ReportAdminApi* | [**Get-RequestReport**](docs/ReportAdminApi.md#Get-RequestReport) | **GET** /admin/report/requests | get requests report
*ReportAdminApi* | [**Get-WorkspaceReport**](docs/ReportAdminApi.md#Get-WorkspaceReport) | **GET** /admin/report/workspaces | get workspaces report
*RequestsApi* | [**Stop-Request**](docs/RequestsApi.md#Stop-Request) | **GET** /requests/{id}/cancel | cancel request
*RequestsApi* | [**Get-ArchiveGroupRequest**](docs/RequestsApi.md#Get-ArchiveGroupRequest) | **GET** /requests/archivegroup/{id} | get archive group request
*RequestsApi* | [**Get-ArchiveSiteRequest**](docs/RequestsApi.md#Get-ArchiveSiteRequest) | **GET** /requests/archivesite/{id} | get archive site request
*RequestsApi* | [**Get-ArchiveWebRequest**](docs/RequestsApi.md#Get-ArchiveWebRequest) | **GET** /requests/archiveweb/{id} | get archive web request
*RequestsApi* | [**Get-ChagneGroupPolicyRequest**](docs/RequestsApi.md#Get-ChagneGroupPolicyRequest) | **GET** /requests/changegrouppolicy/{id} | get change group policy request
*RequestsApi* | [**Get-ChangeGroupQuotaRequest**](docs/RequestsApi.md#Get-ChangeGroupQuotaRequest) | **GET** /requests/changegroupquota/{id} | get change group quota request
*RequestsApi* | [**Get-ChangeGroupSettingRequest**](docs/RequestsApi.md#Get-ChangeGroupSettingRequest) | **GET** /requests/changegroup/{id} | get change group settings request
*RequestsApi* | [**Get-ChangeListSettingRequest**](docs/RequestsApi.md#Get-ChangeListSettingRequest) | **GET** /requests/changelistsetting/{id} | get change list settings request
*RequestsApi* | [**Get-ChangePermissionRequest**](docs/RequestsApi.md#Get-ChangePermissionRequest) | **GET** /requests/changepermission/{id} | get change permission request
*RequestsApi* | [**Get-ChangePrivateChannelRequest**](docs/RequestsApi.md#Get-ChangePrivateChannelRequest) | **GET** /requests/changeprivatechannel/{id} | get change private channel request
*RequestsApi* | [**Get-ChangeSiteContactRequest**](docs/RequestsApi.md#Get-ChangeSiteContactRequest) | **GET** /requests/changesite/adminorcontact/{id} | get change site administrator or contact request
*RequestsApi* | [**Get-ChangeSitePolicyRequest**](docs/RequestsApi.md#Get-ChangeSitePolicyRequest) | **GET** /requests/changesitepolicy/{id} | get change site policy request
*RequestsApi* | [**Get-ChangeSiteQuotaRequest**](docs/RequestsApi.md#Get-ChangeSiteQuotaRequest) | **GET** /requests/changesitequota/{id} | get change site quota request
*RequestsApi* | [**Get-ChangeSiteSettingRequest**](docs/RequestsApi.md#Get-ChangeSiteSettingRequest) | **GET** /requests/changesite/setting/{id} | get change site settings request
*RequestsApi* | [**Get-ChangeWebContactRequest**](docs/RequestsApi.md#Get-ChangeWebContactRequest) | **GET** /requests/changewebcontact/{id} | get change web contact request
*RequestsApi* | [**Get-ChangeWebSettingRequest**](docs/RequestsApi.md#Get-ChangeWebSettingRequest) | **GET** /requests/changewebsettings/{id} | get change web settings request
*RequestsApi* | [**Get-ClonePermissionRequest**](docs/RequestsApi.md#Get-ClonePermissionRequest) | **GET** /requests/clonepermission/{id} | get clone permission request
*RequestsApi* | [**Get-ContentMoveRequest**](docs/RequestsApi.md#Get-ContentMoveRequest) | **GET** /requests/contentmove/{id} | get content move request
*RequestsApi* | [**Get-CreateGroupRequest**](docs/RequestsApi.md#Get-CreateGroupRequest) | **GET** /requests/creategroup/{id} | get create group request
*RequestsApi* | [**Get-CreateGuestUserRequest**](docs/RequestsApi.md#Get-CreateGuestUserRequest) | **GET** /requests/createguestuser/{id} | get create guest user request
*RequestsApi* | [**Get-CreateListRequest**](docs/RequestsApi.md#Get-CreateListRequest) | **GET** /requests/createlist/{id} | get create list request
*RequestsApi* | [**Get-CreatePrivateChannelRequest**](docs/RequestsApi.md#Get-CreatePrivateChannelRequest) | **GET** /requests/createprivatechannel/{id} | get private channel request
*RequestsApi* | [**Get-CreateSiteRequest**](docs/RequestsApi.md#Get-CreateSiteRequest) | **GET** /requests/createsite/{id} | get create site request
*RequestsApi* | [**Get-CreateWebRequest**](docs/RequestsApi.md#Get-CreateWebRequest) | **GET** /requests/createweb/{id} | get create web request
*RequestsApi* | [**Get-CustomRequest**](docs/RequestsApi.md#Get-CustomRequest) | **GET** /requests/custom/{id} | get custom service request
*RequestsApi* | [**Get-DeleteGroupRequest**](docs/RequestsApi.md#Get-DeleteGroupRequest) | **GET** /requests/deletegroup/{id} | get delete group request
*RequestsApi* | [**Get-DeleteSiteRequest**](docs/RequestsApi.md#Get-DeleteSiteRequest) | **GET** /requests/deletesite/{id} | get delete site request
*RequestsApi* | [**Get-DeleteWebRequest**](docs/RequestsApi.md#Get-DeleteWebRequest) | **GET** /requests/deleteweb/{id} | get delete web request
*RequestsApi* | [**Get-DynamicRequest**](docs/RequestsApi.md#Get-DynamicRequest) | **GET** /requests/dynamic/{id} | get dynamic request
*RequestsApi* | [**Get-DynamicRequestChangeContactGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeContactGallery) | **GET** /requests/dynamic/{id}/gallery/changecontact | 
*RequestsApi* | [**Get-DynamicRequestChangeExchangeResourceMembershipGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeExchangeResourceMembershipGallery) | **GET** /requests/dynamic/{id}/gallery/changeexchangeresourcemembership | 
*RequestsApi* | [**Get-DynamicRequestChangeLicenseGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeLicenseGallery) | **GET** /requests/dynamic/{id}/gallery/changelicense | 
*RequestsApi* | [**Get-DynamicRequestChangeSecurityGroupSettingsGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeSecurityGroupSettingsGallery) | **GET** /requests/dynamic/{id}/gallery/changesecuritygroupsettings | 
*RequestsApi* | [**Get-DynamicRequestChangeSharedChannelGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeSharedChannelGallery) | **GET** /requests/dynamic/{id}/gallery/changesharedchannel | 
*RequestsApi* | [**Get-DynamicRequestChangeSharedMailboxPermissionGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeSharedMailboxPermissionGallery) | **GET** /requests/dynamic/{id}/gallery/changesharedmailboxpermission | 
*RequestsApi* | [**Get-DynamicRequestChangeSiteProfileGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeSiteProfileGallery) | **GET** /requests/dynamic/{id}/gallery/changesiteprofile | 
*RequestsApi* | [**Get-DynamicRequestChangeSiteSettingGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeSiteSettingGallery) | **GET** /requests/dynamic/{id}/gallery/changesitesetting | 
*RequestsApi* | [**Get-DynamicRequestChangeTeamSettingGallery**](docs/RequestsApi.md#Get-DynamicRequestChangeTeamSettingGallery) | **GET** /requests/dynamic/{id}/gallery/changeteamsetting | 
*RequestsApi* | [**Get-DynamicRequestCreateCommunityGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateCommunityGallery) | **GET** /requests/dynamic/{id}/gallery/createCommunity | 
*RequestsApi* | [**Get-DynamicRequestCreateDistributionListGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateDistributionListGallery) | **GET** /requests/dynamic/{id}/gallery/createdistributionlist | 
*RequestsApi* | [**Get-DynamicRequestCreateEquipmentMailboxGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateEquipmentMailboxGallery) | **GET** /requests/dynamic/{id}/gallery/createequipmentmailbox | 
*RequestsApi* | [**Get-DynamicRequestCreateGroupGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateGroupGallery) | **GET** /requests/dynamic/{id}/gallery/creategroups | 
*RequestsApi* | [**Get-DynamicRequestCreateLibraryGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateLibraryGallery) | **GET** /requests/dynamic/{id}/gallery/createlibrary | 
*RequestsApi* | [**Get-DynamicRequestCreateMailEnabledGroupGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateMailEnabledGroupGallery) | **GET** /requests/dynamic/{id}/gallery/createmailenabledgroup | 
*RequestsApi* | [**Get-DynamicRequestCreateRoomMailboxGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateRoomMailboxGallery) | **GET** /requests/dynamic/{id}/gallery/createroommailbox | 
*RequestsApi* | [**Get-DynamicRequestCreateSecurityGroupGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateSecurityGroupGallery) | **GET** /requests/dynamic/{id}/gallery/createsecuritygroupgallery | 
*RequestsApi* | [**Get-DynamicRequestCreateSharedChannelGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateSharedChannelGallery) | **GET** /requests/dynamic/{id}/gallery/createsharedchannel | 
*RequestsApi* | [**Get-DynamicRequestCreateSharedMailboxGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateSharedMailboxGallery) | **GET** /requests/dynamic/{id}/gallery/createsharedmailbox | 
*RequestsApi* | [**Get-DynamicRequestCreateSiteGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateSiteGallery) | **GET** /requests/dynamic/{id}/gallery/createsite | 
*RequestsApi* | [**Get-DynamicRequestCreateTeamsGallery**](docs/RequestsApi.md#Get-DynamicRequestCreateTeamsGallery) | **GET** /requests/dynamic/{id}/gallery/createteams | 
*RequestsApi* | [**Get-DynamicRequestExchangeResourceLifecycleGallery**](docs/RequestsApi.md#Get-DynamicRequestExchangeResourceLifecycleGallery) | **GET** /requests/dynamic/{id}/gallery/exchangeresourcelifecycle | 
*RequestsApi* | [**Get-DynamicRequestInviteGuestGallery**](docs/RequestsApi.md#Get-DynamicRequestInviteGuestGallery) | **GET** /requests/dynamic/{id}/gallery/inviteguest | 
*RequestsApi* | [**Get-DynamicRequestM365GroupLifecycleGallery**](docs/RequestsApi.md#Get-DynamicRequestM365GroupLifecycleGallery) | **GET** /requests/dynamic/{id}/gallery/m365grouplifecycle | 
*RequestsApi* | [**Get-DynamicRequestSCLifecycleGallery**](docs/RequestsApi.md#Get-DynamicRequestSCLifecycleGallery) | **GET** /requests/dynamic/{id}/gallery/sclifecycle | 
*RequestsApi* | [**Get-DynamicRequestSharedMailboxLifecycleGallery**](docs/RequestsApi.md#Get-DynamicRequestSharedMailboxLifecycleGallery) | **GET** /requests/dynamic/{id}/gallery/sharedmailboxlifecycle | 
*RequestsApi* | [**Get-DynamicRequestTeamLifecycleGallery**](docs/RequestsApi.md#Get-DynamicRequestTeamLifecycleGallery) | **GET** /requests/dynamic/{id}/gallery/teamlifecycle | 
*RequestsApi* | [**Get-ExtendGroupRequest**](docs/RequestsApi.md#Get-ExtendGroupRequest) | **GET** /requests/extendgroup/{id} | get extend group request
*RequestsApi* | [**Get-ExtendSiteRequest**](docs/RequestsApi.md#Get-ExtendSiteRequest) | **GET** /requests/extendsite/{id} | get extend site request
*RequestsApi* | [**Get-GrantPermissionRequest**](docs/RequestsApi.md#Get-GrantPermissionRequest) | **GET** /requests/grantpermission/{id} | get grant permission request
*RequestsApi* | [**Get-LockSiteReuqest**](docs/RequestsApi.md#Get-LockSiteReuqest) | **GET** /requests/locksite/{id} | get lock site request
*RequestsApi* | [**Get-ManagePermissionRequest**](docs/RequestsApi.md#Get-ManagePermissionRequest) | **GET** /requests/managepermission/{id} | get manage permission request
*RequestsApi* | [**Get-MyRequests**](docs/RequestsApi.md#Get-MyRequests) | **GET** /requests/my | get my requests
*RequestsApi* | [**Get-RequestById**](docs/RequestsApi.md#Get-RequestById) | **GET** /requests/{id} | get request by id
*RequestsApi* | [**Get-RestoreGroupRequest**](docs/RequestsApi.md#Get-RestoreGroupRequest) | **GET** /requests/restoregroup/{id} | get restore group request
*RequestsApi* | [**Get-SiteCollectionLifecycleRequest**](docs/RequestsApi.md#Get-SiteCollectionLifecycleRequest) | **GET** /requests/sitelifecycle/{id} | get site lifecycel request
*RequestsApi* | [**Get-Tasks**](docs/RequestsApi.md#Get-Tasks) | **GET** /requests/{requestid}/tasks | get task by request id
*RequestsApi* | [**Get-UnlockSiteRequest**](docs/RequestsApi.md#Get-UnlockSiteRequest) | **GET** /requests/unlocksite/{id} | get unlock site request
*RequestsApi* | [**Invoke-IsUrlExistsInPendingRequests**](docs/RequestsApi.md#Invoke-IsUrlExistsInPendingRequests) | **GET** /requests/isUrlExistInPendingRequests | check url exists in pending requests.
*RequestsApi* | [**Submit-ArchiveGroupRequest**](docs/RequestsApi.md#Submit-ArchiveGroupRequest) | **POST** /requests/archivegroup | submit archive group group request
*RequestsApi* | [**Submit-ArchiveGroupRequestV2**](docs/RequestsApi.md#Submit-ArchiveGroupRequestV2) | **POST** /requests/archivegroup/v2 | submit archive group request, and return request info.
*RequestsApi* | [**Submit-ArchiveSiteRequest**](docs/RequestsApi.md#Submit-ArchiveSiteRequest) | **POST** /requests/archivesite | submit archive site request
*RequestsApi* | [**Submit-ArchiveSiteRequestV2**](docs/RequestsApi.md#Submit-ArchiveSiteRequestV2) | **POST** /requests/archivesite/v2 | submit archive site request, and return request info.
*RequestsApi* | [**Submit-ArchiveWebRequest**](docs/RequestsApi.md#Submit-ArchiveWebRequest) | **POST** /requests/archiveweb | submit archive web request
*RequestsApi* | [**Submit-ChangeGroupPolicyRequest**](docs/RequestsApi.md#Submit-ChangeGroupPolicyRequest) | **POST** /requests/changegrouppolicy | submit change group policy request
*RequestsApi* | [**Submit-ChangeGroupPolicyRequestV2**](docs/RequestsApi.md#Submit-ChangeGroupPolicyRequestV2) | **POST** /requests/changegrouppolicy/v2 | submit change group policy request, and return request info.
*RequestsApi* | [**Submit-ChangeGroupQuotaRequest**](docs/RequestsApi.md#Submit-ChangeGroupQuotaRequest) | **POST** /requests/changegroupquota | submit change group quota request
*RequestsApi* | [**Submit-ChangeGroupQuotaRequestV2**](docs/RequestsApi.md#Submit-ChangeGroupQuotaRequestV2) | **POST** /requests/changegroupquota/v2 | submit change group quota request, and return request info.
*RequestsApi* | [**Submit-ChangeGroupSettingRequest**](docs/RequestsApi.md#Submit-ChangeGroupSettingRequest) | **POST** /requests/changegroup | submit change group settings request
*RequestsApi* | [**Submit-ChangeGroupSettingRequestV2**](docs/RequestsApi.md#Submit-ChangeGroupSettingRequestV2) | **POST** /requests/changegroup/v2 | submit change group settings request, and return request info.
*RequestsApi* | [**Submit-ChangeListSettingRequest**](docs/RequestsApi.md#Submit-ChangeListSettingRequest) | **POST** /requests/changelistsetting | submit change list settings request
*RequestsApi* | [**Submit-ChangePermissionRequest**](docs/RequestsApi.md#Submit-ChangePermissionRequest) | **POST** /requests/changepermission | submit change permission request
*RequestsApi* | [**Submit-ChangePermissionRequestV2**](docs/RequestsApi.md#Submit-ChangePermissionRequestV2) | **POST** /requests/changepermission/v2 | submit change permission request, and return request info.
*RequestsApi* | [**Submit-ChangePrivateChannelRequest**](docs/RequestsApi.md#Submit-ChangePrivateChannelRequest) | **POST** /requests/changeprivatechannel | submit change private channel request
*RequestsApi* | [**Submit-ChangeSiteContactRequest**](docs/RequestsApi.md#Submit-ChangeSiteContactRequest) | **POST** /requests/changesite/adminorcontact | submit change site administrator or contact request
*RequestsApi* | [**Submit-ChangeSiteContactRequestV2**](docs/RequestsApi.md#Submit-ChangeSiteContactRequestV2) | **POST** /requests/changesite/v2/adminorcontact | submit change site administrator or contact request, and return request info.
*RequestsApi* | [**Submit-ChangeSitePolicyRequest**](docs/RequestsApi.md#Submit-ChangeSitePolicyRequest) | **POST** /requests/changesitepolicy | submit change site policy request
*RequestsApi* | [**Submit-ChangeSitePolicyRequestV2**](docs/RequestsApi.md#Submit-ChangeSitePolicyRequestV2) | **POST** /requests/changesitepolicy/v2 | submit change site policy request, and return request info.
*RequestsApi* | [**Submit-ChangeSiteQuotaRequest**](docs/RequestsApi.md#Submit-ChangeSiteQuotaRequest) | **POST** /requests/changesitequota | submit change site quota request
*RequestsApi* | [**Submit-ChangeSiteQuotaRequestV2**](docs/RequestsApi.md#Submit-ChangeSiteQuotaRequestV2) | **POST** /requests/changesitequota/v2 | submit change site quota request, and return request info.
*RequestsApi* | [**Submit-ChangeSiteSettingRequest**](docs/RequestsApi.md#Submit-ChangeSiteSettingRequest) | **POST** /requests/changesite/setting | submit change site settings request
*RequestsApi* | [**Submit-ChangeSiteSettingRequestV2**](docs/RequestsApi.md#Submit-ChangeSiteSettingRequestV2) | **POST** /requests/changesite/v2/setting | submit change site setting request, and return request info.
*RequestsApi* | [**Submit-ChangeWebContactRequest**](docs/RequestsApi.md#Submit-ChangeWebContactRequest) | **POST** /requests/changewebcontact | submit change web contact request
*RequestsApi* | [**Submit-ChangeWebSettingRequest**](docs/RequestsApi.md#Submit-ChangeWebSettingRequest) | **POST** /requests/changewebsettings | submit change web settings request
*RequestsApi* | [**Submit-ClonePermissionRequest**](docs/RequestsApi.md#Submit-ClonePermissionRequest) | **POST** /requests/clonepermission | get clone permission request
*RequestsApi* | [**Submit-ContentMoveRequest**](docs/RequestsApi.md#Submit-ContentMoveRequest) | **POST** /requests/contentmove | submit create content move request
*RequestsApi* | [**Submit-ContentMoveRequestV2**](docs/RequestsApi.md#Submit-ContentMoveRequestV2) | **POST** /requests/contentmove/v2 | submit create content move request, and return request info.
*RequestsApi* | [**Submit-CreateGroupRequest**](docs/RequestsApi.md#Submit-CreateGroupRequest) | **POST** /requests/creategroup | submit create group request
*RequestsApi* | [**Submit-CreateGroupRequestV2**](docs/RequestsApi.md#Submit-CreateGroupRequestV2) | **POST** /requests/creategroup/v2 | submit create group request, and return request info.
*RequestsApi* | [**Submit-CreateGuestUserRequest**](docs/RequestsApi.md#Submit-CreateGuestUserRequest) | **POST** /requests/createguestuser | submit create guest user request
*RequestsApi* | [**Submit-CreateListRequest**](docs/RequestsApi.md#Submit-CreateListRequest) | **POST** /requests/createlist | submit create list request
*RequestsApi* | [**Submit-CreatePrivateChannelRequest**](docs/RequestsApi.md#Submit-CreatePrivateChannelRequest) | **POST** /requests/createprivatechannel | submit private channel request
*RequestsApi* | [**Submit-CreateSiteRequest**](docs/RequestsApi.md#Submit-CreateSiteRequest) | **POST** /requests/createsite | submit create site collection request
*RequestsApi* | [**Submit-CreateSiteRequestV2**](docs/RequestsApi.md#Submit-CreateSiteRequestV2) | **POST** /requests/createsite/v2 | submit create site collection request, and return request info.
*RequestsApi* | [**Submit-CreateWebRequest**](docs/RequestsApi.md#Submit-CreateWebRequest) | **POST** /requests/createweb | submit create web request
*RequestsApi* | [**Submit-CreateWebRequestV2**](docs/RequestsApi.md#Submit-CreateWebRequestV2) | **POST** /requests/createweb/v2 | submit create web request, and return request info.
*RequestsApi* | [**Submit-CustomRequest**](docs/RequestsApi.md#Submit-CustomRequest) | **POST** /requests/custom | submit custom service request
*RequestsApi* | [**Submit-CustomRequestV2**](docs/RequestsApi.md#Submit-CustomRequestV2) | **POST** /requests/custom/v2 | submit custom service request, and return request info.
*RequestsApi* | [**Submit-DeleteGroupRequest**](docs/RequestsApi.md#Submit-DeleteGroupRequest) | **POST** /requests/deletegroup | submit delete group request
*RequestsApi* | [**Submit-DeleteGroupRequestV2**](docs/RequestsApi.md#Submit-DeleteGroupRequestV2) | **POST** /requests/deletegroup/v2 | submit delete group request, and return request info.
*RequestsApi* | [**Submit-DeleteSiteRequest**](docs/RequestsApi.md#Submit-DeleteSiteRequest) | **POST** /requests/deletesite | submit delete site request
*RequestsApi* | [**Submit-DeleteSiteRequestV2**](docs/RequestsApi.md#Submit-DeleteSiteRequestV2) | **POST** /requests/deletesite/v2 | submit delete site request, and return request info.
*RequestsApi* | [**Submit-DeleteWebRequest**](docs/RequestsApi.md#Submit-DeleteWebRequest) | **POST** /requests/deleteweb | submit delete web request
*RequestsApi* | [**Submit-DynamicRequest**](docs/RequestsApi.md#Submit-DynamicRequest) | **POST** /requests/dynamic | submit dynamic request
*RequestsApi* | [**Submit-DynamicRequestByTemplate**](docs/RequestsApi.md#Submit-DynamicRequestByTemplate) | **POST** /requests/dynamic/template | 
*RequestsApi* | [**Submit-ExtendGroupRequest**](docs/RequestsApi.md#Submit-ExtendGroupRequest) | **POST** /requests/extendgroup | submit extend group request
*RequestsApi* | [**Submit-ExtendGroupRequestV2**](docs/RequestsApi.md#Submit-ExtendGroupRequestV2) | **POST** /requests/extendgroup/v2 | submit extend group request, and return request info.
*RequestsApi* | [**Submit-ExtendSiteRequest**](docs/RequestsApi.md#Submit-ExtendSiteRequest) | **POST** /requests/extendsite | submit extend site request
*RequestsApi* | [**Submit-ExtendSiteRequestV2**](docs/RequestsApi.md#Submit-ExtendSiteRequestV2) | **POST** /requests/extendsite/v2 | submit extend site request, and return request info.
*RequestsApi* | [**Submit-GrantPermissionRequest**](docs/RequestsApi.md#Submit-GrantPermissionRequest) | **POST** /requests/grantpermission | get submit grant permission request
*RequestsApi* | [**Submit-GrantPermissionRequestV2**](docs/RequestsApi.md#Submit-GrantPermissionRequestV2) | **POST** /requests/grantpermission/v2 | submit grant permission request, and return request info.
*RequestsApi* | [**Submit-LockSiteRequest**](docs/RequestsApi.md#Submit-LockSiteRequest) | **POST** /requests/locksite | submit lock site request
*RequestsApi* | [**Submit-LockSiteRequestV2**](docs/RequestsApi.md#Submit-LockSiteRequestV2) | **POST** /requests/locksite/v2 | submit lock site request, and return request info.
*RequestsApi* | [**Submit-ManagePermissionRequest**](docs/RequestsApi.md#Submit-ManagePermissionRequest) | **POST** /requests/managepermission | submit manage permission request
*RequestsApi* | [**Submit-ManagePermissionRequestV2**](docs/RequestsApi.md#Submit-ManagePermissionRequestV2) | **POST** /requests/managepermission/v2 | submit manage permission request, and return request info.
*RequestsApi* | [**Submit-RestoreGroupRequest**](docs/RequestsApi.md#Submit-RestoreGroupRequest) | **POST** /requests/restoregroup | submit restore group request
*RequestsApi* | [**Submit-RestoreGroupRequestV2**](docs/RequestsApi.md#Submit-RestoreGroupRequestV2) | **POST** /requests/restoregroup/v2 | submit restore group request, and return request info.
*RequestsApi* | [**Submit-UnlockSiteRequest**](docs/RequestsApi.md#Submit-UnlockSiteRequest) | **POST** /requests/unlocksite | submit unlock site request
*RequestsApi* | [**Submit-UnlockSiteRequestV2**](docs/RequestsApi.md#Submit-UnlockSiteRequestV2) | **POST** /requests/unlocksite/v2 | submit unlock site request, and return request info.
*RequestsAdminApi* | [**Get-AllRequests**](docs/RequestsAdminApi.md#Get-AllRequests) | **GET** /admin/directory/requests | get all requests
*ServicesApi* | [**Get-ChangeGroupSettingService**](docs/ServicesApi.md#Get-ChangeGroupSettingService) | **GET** /services/changegroupsetting/{id} | get change group setting service
*ServicesApi* | [**Get-ChangeListSettingService**](docs/ServicesApi.md#Get-ChangeListSettingService) | **GET** /services/changelistsetting/{id} | get change list setting service
*ServicesApi* | [**Get-ChangePermissionService**](docs/ServicesApi.md#Get-ChangePermissionService) | **GET** /services/changepermission/{id} | get change permission service
*ServicesApi* | [**Get-ChangePrivateChannelService**](docs/ServicesApi.md#Get-ChangePrivateChannelService) | **GET** /services/changeprivatechannel/{id} | get private channel service detail
*ServicesApi* | [**Get-ChangeSiteContactService**](docs/ServicesApi.md#Get-ChangeSiteContactService) | **GET** /services/changesitecontact/{id} | get change site contact service
*ServicesApi* | [**Get-ChangeSiteSettingService**](docs/ServicesApi.md#Get-ChangeSiteSettingService) | **GET** /services/changesitesetting/{id} | get change site setting service
*ServicesApi* | [**Get-ChangeWebContactService**](docs/ServicesApi.md#Get-ChangeWebContactService) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
*ServicesApi* | [**Get-ChangeWebSettingsService**](docs/ServicesApi.md#Get-ChangeWebSettingsService) | **GET** /services/changewebsettings/{id} | get change web setting service
*ServicesApi* | [**Get-ClonePermissionService**](docs/ServicesApi.md#Get-ClonePermissionService) | **GET** /services/clonepermission/{id} | get clone permission service
*ServicesApi* | [**Get-ContentMoveProfiles**](docs/ServicesApi.md#Get-ContentMoveProfiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
*ServicesApi* | [**Get-ContentMoveService**](docs/ServicesApi.md#Get-ContentMoveService) | **GET** /services/contentmove/{id} | get content move service
*ServicesApi* | [**Get-CreateGroupService**](docs/ServicesApi.md#Get-CreateGroupService) | **GET** /services/creategroup/{id} | get create group service
*ServicesApi* | [**Get-CreateGuestUserService**](docs/ServicesApi.md#Get-CreateGuestUserService) | **GET** /services/createguestuser/{id} | get create group service
*ServicesApi* | [**Get-CreateListService**](docs/ServicesApi.md#Get-CreateListService) | **GET** /services/createlist/{id} | get create list service
*ServicesApi* | [**Get-CreatePrivateChannelService**](docs/ServicesApi.md#Get-CreatePrivateChannelService) | **GET** /services/createprivatechannel/{id} | get private channel service detail
*ServicesApi* | [**Get-CreateSiteService**](docs/ServicesApi.md#Get-CreateSiteService) | **GET** /services/createsite/{id} | get create site service
*ServicesApi* | [**Get-CreateWebService**](docs/ServicesApi.md#Get-CreateWebService) | **GET** /services/createweb/{id} | get create web service
*ServicesApi* | [**Get-CustomService**](docs/ServicesApi.md#Get-CustomService) | **GET** /services/custom/{id} | get custom service
*ServicesApi* | [**Get-DynamicService**](docs/ServicesApi.md#Get-DynamicService) | **GET** /services/dynamic/{id} | get dynamic service
*ServicesApi* | [**Get-DynamicServiceRequestTemplate**](docs/ServicesApi.md#Get-DynamicServiceRequestTemplate) | **GET** /services/dynamic/{id}/template | 
*ServicesApi* | [**Get-GrantPermissionService**](docs/ServicesApi.md#Get-GrantPermissionService) | **GET** /services/grantpermission/{id} | get grant permission service
*ServicesApi* | [**Get-GroupLifecycleService**](docs/ServicesApi.md#Get-GroupLifecycleService) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
*ServicesApi* | [**Get-ManagePermissionService**](docs/ServicesApi.md#Get-ManagePermissionService) | **GET** /services/managepermission/{id} | get manage permission service
*ServicesApi* | [**Get-MyServices**](docs/ServicesApi.md#Get-MyServices) | **GET** /services/my | get services that can be used to start a request
*ServicesApi* | [**Get-ServiceId**](docs/ServicesApi.md#Get-ServiceId) | **GET** /services/id | get service id by service name
*ServicesApi* | [**Get-SiteLifecycleService**](docs/ServicesApi.md#Get-SiteLifecycleService) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
*ServicesApi* | [**Get-WebLifecycleService**](docs/ServicesApi.md#Get-WebLifecycleService) | **GET** /services/weblifecycle/{id} | get web lifecycle service
*ServicesApi* | [**Resolve-EmailForCreateGuestUserService**](docs/ServicesApi.md#Resolve-EmailForCreateGuestUserService) | **GET** /services/createguestuser/{id}/email/validate | validate guest user email
*ServicesApi* | [**Resolve-EmailsForCreateGuestUserService**](docs/ServicesApi.md#Resolve-EmailsForCreateGuestUserService) | **POST** /services/createguestuser/{id}/email/validate | validate guest user emails
*ServicesApi* | [**Resolve-ForChangeGroupSettingService**](docs/ServicesApi.md#Resolve-ForChangeGroupSettingService) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
*ServicesApi* | [**Resolve-ForChangeListSettingService**](docs/ServicesApi.md#Resolve-ForChangeListSettingService) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
*ServicesApi* | [**Resolve-ForChangePermissionService**](docs/ServicesApi.md#Resolve-ForChangePermissionService) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
*ServicesApi* | [**Resolve-ForChangeSiteContactService**](docs/ServicesApi.md#Resolve-ForChangeSiteContactService) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
*ServicesApi* | [**Resolve-ForChangeSiteSettingService**](docs/ServicesApi.md#Resolve-ForChangeSiteSettingService) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
*ServicesApi* | [**Resolve-ForChangeWebContactService**](docs/ServicesApi.md#Resolve-ForChangeWebContactService) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
*ServicesApi* | [**Resolve-ForChangeWebSettingService**](docs/ServicesApi.md#Resolve-ForChangeWebSettingService) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
*ServicesApi* | [**Resolve-ForClonePermissionService**](docs/ServicesApi.md#Resolve-ForClonePermissionService) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
*ServicesApi* | [**Resolve-ForContentMoveService**](docs/ServicesApi.md#Resolve-ForContentMoveService) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
*ServicesApi* | [**Resolve-ForCreateGuestUserService**](docs/ServicesApi.md#Resolve-ForCreateGuestUserService) | **POST** /services/createguestuser/{id}/group/validate | validate groups can invite
*ServicesApi* | [**Resolve-ForCreateListService**](docs/ServicesApi.md#Resolve-ForCreateListService) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
*ServicesApi* | [**Resolve-ForCreateWebService**](docs/ServicesApi.md#Resolve-ForCreateWebService) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
*ServicesApi* | [**Resolve-ForGrantPermissionService**](docs/ServicesApi.md#Resolve-ForGrantPermissionService) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
*ServicesApi* | [**Resolve-ForGroupLifecycleService**](docs/ServicesApi.md#Resolve-ForGroupLifecycleService) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
*ServicesApi* | [**Resolve-ForManagePermissionService**](docs/ServicesApi.md#Resolve-ForManagePermissionService) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
*ServicesApi* | [**Resolve-ForSiteLifecycleService**](docs/ServicesApi.md#Resolve-ForSiteLifecycleService) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
*ServicesApi* | [**Resolve-ForWebLifecycleService**](docs/ServicesApi.md#Resolve-ForWebLifecycleService) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service
*ServicesApi* | [**Resolve-TeamForChangePrivateChannelService**](docs/ServicesApi.md#Resolve-TeamForChangePrivateChannelService) | **POST** /services/changeprivatechannel/{serviceId}/team/validation | validate teams for change private channel service
*ServicesApi* | [**Resolve-TeamForCreatePrivateChannelService**](docs/ServicesApi.md#Resolve-TeamForCreatePrivateChannelService) | **POST** /services/createprivatechannel/{serviceId}/team/validation | validate teams for create private channel service
*ServicesAdminApi* | [**Get-Services**](docs/ServicesAdminApi.md#Get-Services) | **GET** /admin/services | get all services
*SettingsApi* | [**Get-DynamicMembershipRuleItems**](docs/SettingsApi.md#Get-DynamicMembershipRuleItems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
*SettingsApi* | [**Get-MyPersonalSettings**](docs/SettingsApi.md#Get-MyPersonalSettings) | **GET** /settings/my | get my personal settings
*SettingsApi* | [**Get-ACGPermissionLevels**](docs/SettingsApi.md#get-acgpermissionlevels) | **GET** /settings/office365/permissionlevels | get permission levels
*SharedMailboxesAdminApi* | [**Get-SharedMailboxes**](docs/SharedMailboxesAdminApi.md#Get-SharedMailboxes) | **GET** /admin/directory/sharedmailbox | get managed shared mailboxes
*SharedMailboxesAdminApi* | [**Get-SharedMailboxesFilters**](docs/SharedMailboxesAdminApi.md#Get-SharedMailboxesFilters) | **GET** /admin/directory/sharedmailbox/filters | get filters for shared mailbox report
*SharedMailboxesAdminApi* | [**Invoke-SpecifySharedMailboxContacts**](docs/SharedMailboxesAdminApi.md#Invoke-SpecifySharedMailboxContacts) | **POST** /admin/directory/sharedmailbox/contacts | specify contacts
*SystemSettingsAdminApi* | [**Get-HookMessageSamples**](docs/SystemSettingsAdminApi.md#Get-HookMessageSamples) | **GET** /admin/settings/system/hooks/messages/sample | 
*TasksApi* | [**Approve-Task**](docs/TasksApi.md#Approve-Task) | **POST** /tasks/{id}/approve | approve task
*TasksApi* | [**Edit-ArchiveGroupRequest**](docs/TasksApi.md#Edit-ArchiveGroupRequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
*TasksApi* | [**Edit-ArchiveSiteRequest**](docs/TasksApi.md#Edit-ArchiveSiteRequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
*TasksApi* | [**Edit-ArchiveWebRequest**](docs/TasksApi.md#Edit-ArchiveWebRequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
*TasksApi* | [**Edit-ChangeGroupPolicyRequest**](docs/TasksApi.md#Edit-ChangeGroupPolicyRequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
*TasksApi* | [**Edit-ChangeGroupQuotaRequest**](docs/TasksApi.md#Edit-ChangeGroupQuotaRequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
*TasksApi* | [**Edit-ChangeGroupRequest**](docs/TasksApi.md#Edit-ChangeGroupRequest) | **PUT** /tasks/{id}/changegroup | edit create change group request
*TasksApi* | [**Edit-ChangeListSettingRequest**](docs/TasksApi.md#Edit-ChangeListSettingRequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
*TasksApi* | [**Edit-ChangePermissionRequest**](docs/TasksApi.md#Edit-ChangePermissionRequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
*TasksApi* | [**Edit-ChangeSiteContactRequest**](docs/TasksApi.md#Edit-ChangeSiteContactRequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request
*TasksApi* | [**Edit-ChangeSitePolicyRequest**](docs/TasksApi.md#Edit-ChangeSitePolicyRequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
*TasksApi* | [**Edit-ChangeSiteQuotaRequest**](docs/TasksApi.md#Edit-ChangeSiteQuotaRequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
*TasksApi* | [**Edit-ChangeSiteSettingRequest**](docs/TasksApi.md#Edit-ChangeSiteSettingRequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request
*TasksApi* | [**Edit-ChangeWebContactRequest**](docs/TasksApi.md#Edit-ChangeWebContactRequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
*TasksApi* | [**Edit-ChangeWebSettingRequest**](docs/TasksApi.md#Edit-ChangeWebSettingRequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
*TasksApi* | [**Edit-ClonePermissionRequest**](docs/TasksApi.md#Edit-ClonePermissionRequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request
*TasksApi* | [**Edit-ContentMoveRequest**](docs/TasksApi.md#Edit-ContentMoveRequest) | **PUT** /tasks/{id}/contentmove | edit content move request
*TasksApi* | [**Edit-CreateGroupRequest**](docs/TasksApi.md#Edit-CreateGroupRequest) | **PUT** /tasks/{id}/creategroup | edit create site group request
*TasksApi* | [**Edit-CreateGuestUserRequest**](docs/TasksApi.md#Edit-CreateGuestUserRequest) | **PUT** /tasks/{id}/createguestuser | edit create guest user request in task
*TasksApi* | [**Edit-CreateListRequest**](docs/TasksApi.md#Edit-CreateListRequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
*TasksApi* | [**Edit-CreateSiteRequest**](docs/TasksApi.md#Edit-CreateSiteRequest) | **PUT** /tasks/{id}/createsite | edit create site request
*TasksApi* | [**Edit-CreateWebRequest**](docs/TasksApi.md#Edit-CreateWebRequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
*TasksApi* | [**Edit-CustomRequest**](docs/TasksApi.md#Edit-CustomRequest) | **PUT** /tasks/{id}/custom | edit custom request
*TasksApi* | [**Edit-DeleteGroupRequest**](docs/TasksApi.md#Edit-DeleteGroupRequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
*TasksApi* | [**Edit-DeleteSiteRequest**](docs/TasksApi.md#Edit-DeleteSiteRequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
*TasksApi* | [**Edit-DeleteWebRequest**](docs/TasksApi.md#Edit-DeleteWebRequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
*TasksApi* | [**Edit-DynamicServiceRequest**](docs/TasksApi.md#Edit-DynamicServiceRequest) | **PUT** /tasks/{id}/dynamic | edit dynamic service request
*TasksApi* | [**Edit-ExtendGroupRequest**](docs/TasksApi.md#Edit-ExtendGroupRequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
*TasksApi* | [**Edit-ExtendSiteRequest**](docs/TasksApi.md#Edit-ExtendSiteRequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
*TasksApi* | [**Edit-GrantPermissionRequest**](docs/TasksApi.md#Edit-GrantPermissionRequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
*TasksApi* | [**Edit-LockSiteRequest**](docs/TasksApi.md#Edit-LockSiteRequest) | **PUT** /tasks/{id}/locksite | edit lock site request
*TasksApi* | [**Edit-ManagePermissionRequest**](docs/TasksApi.md#Edit-ManagePermissionRequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request
*TasksApi* | [**Edit-RestoreGroupRequest**](docs/TasksApi.md#Edit-RestoreGroupRequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
*TasksApi* | [**Edit-UnLockSiteRequest**](docs/TasksApi.md#Edit-UnLockSiteRequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request
*TasksApi* | [**Get-BatchTasksById**](docs/TasksApi.md#Get-BatchTasksById) | **GET** /tasks/{id}/batchTasks | get all batch tasks by id
*TasksApi* | [**Get-MyTasks**](docs/TasksApi.md#Get-MyTasks) | **GET** /tasks/my/v2 | get my tasks
*TasksApi* | [**Get-TaskByBatchId**](docs/TasksApi.md#Get-TaskByBatchId) | **GET** /tasks/my/{batchid} | get my task by batch id
*TasksApi* | [**Get-TaskById**](docs/TasksApi.md#Get-TaskById) | **GET** /tasks/{id} | get task by id
*TasksApi* | [**Invoke-ReassignTask**](docs/TasksApi.md#Invoke-ReassignTask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
*TasksApi* | [**Deny-Task**](docs/TasksApi.md#Deny-Task) | **POST** /tasks/{id}/reject | reject task
*TasksApi* | [**Invoke-RetryErrorTask**](docs/TasksApi.md#Invoke-RetryErrorTask) | **POST** /tasks/{id}/retry | retry error task
*TasksApi* | [**Skip-ErrorTask**](docs/TasksApi.md#Skip-ErrorTask) | **POST** /tasks/{id}/skip | skip error task
*TasksApi* | [**Submit-ContinueAccessGroupAutoTask**](docs/TasksApi.md#Submit-ContinueAccessGroupAutoTask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
*TasksApi* | [**Submit-ContinueAccessSiteAutoTask**](docs/TasksApi.md#Submit-ContinueAccessSiteAutoTask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
*TasksApi* | [**Submit-ExtendGroupAutoTask**](docs/TasksApi.md#Submit-ExtendGroupAutoTask) | **POST** /tasks/extendgroup | submit extend group auto task
*TasksApi* | [**Submit-ExtendSiteAutoTask**](docs/TasksApi.md#Submit-ExtendSiteAutoTask) | **POST** /tasks/extendsite | submit site extend auto task
*TasksAdminApi* | [**Get-AllTasks**](docs/TasksAdminApi.md#Get-AllTasks) | **GET** /admin/directory/tasks | get all tasks
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedAdGroups**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedAdGroups) | **POST** /admin/directory/unmanaged/adgroup/import | manually import existing azure ad groups
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedEnvironments**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedEnvironments) | **POST** /admin/directory/unmanaged/environment/import | manually import existing environments
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedGroups**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedGroups) | **POST** /admin/directory/unmanaged/group/import | manually import existing microsoft 365 groups
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedPowerApps**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedPowerApps) | **POST** /admin/directory/unmanaged/powerapps/import | manually import existing power apps
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedPowerAutomate**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedPowerAutomate) | **POST** /admin/directory/unmanaged/powerautomate/import | manually import existing power automate
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedPowerBI**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedPowerBI) | **POST** /admin/directory/unmanaged/powerbi/import | manually import existing power bi
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedSharedMailboxes**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedSharedMailboxes) | **POST** /admin/directory/unmanaged/sharedmailbox/import | manually import existing shared mailbox
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedSites**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedSites) | **POST** /admin/directory/unmanaged/site/import | manually import existing site collections
*UnmanagedDirectoryAdminApi* | [**Import-UnmanagedTeams**](docs/UnmanagedDirectoryAdminApi.md#Import-UnmanagedTeams) | **POST** /admin/directory/unmanaged/team/import | manually import existing microsoft teams
*UsersApi* | [**Invoke-FilterUsersByAttribute**](docs/UsersApi.md#Invoke-FilterUsersByAttribute) | **GET** /users/filter | filter users by property value
*UsersApi* | [**Get-AzureAdUserPropertyValue**](docs/UsersApi.md#Get-AzureAdUserPropertyValue) | **GET** /users/{username}/azuread/property | get Azure Ad user's property value
*UsersApi* | [**Get-ExtensionAzureAdUserPropertyValues**](docs/UsersApi.md#Get-ExtensionAzureAdUserPropertyValues) | **GET** /users/{username}/azuread/extensionproperties | get user's extension property value from azure ad
*UsersApi* | [**Invoke-IsMemberOfGroup**](docs/UsersApi.md#Invoke-IsMemberOfGroup) | **GET** /users/{userprincipalname}/ismemberof/{groupid} | Is Member Of Group
*UsersApi* | [**Resolve-ACGUsers**](docs/UsersApi.md#resolve-acgusers) | **GET** /users/resolve | resolve users
*UsersApi* | [**Search-ACGUsers**](docs/UsersApi.md#search-acgusers) | **GET** /users/search | search users
*WorkspaceApi* | [**Get-GroupMetadata**](docs/WorkspaceApi.md#Get-GroupMetadata) | **GET** /workspace/groups/{id}/metadata | get group/teams metadata
*WorkspaceApi* | [**Get-MyExchangeResourceInformation**](docs/WorkspaceApi.md#Get-MyExchangeResourceInformation) | **GET** /workspace/exchangeresource/{id} | 
*WorkspaceApi* | [**Get-MyGroupInformation**](docs/WorkspaceApi.md#Get-MyGroupInformation) | **GET** /workspace/groups/{id} | get O365 group/teams information
*WorkspaceApi* | [**Get-MyResourceMailboxInformation**](docs/WorkspaceApi.md#Get-MyResourceMailboxInformation) | **GET** /workspace/resourcemailbox/{id} | 
*WorkspaceApi* | [**Get-MySharedMailboxInformation**](docs/WorkspaceApi.md#Get-MySharedMailboxInformation) | **GET** /workspace/sharedmailbox/{id} | 
*WorkspaceApi* | [**Get-MySiteInformation**](docs/WorkspaceApi.md#Get-MySiteInformation) | **GET** /workspace/sites/{id} | get site information
*WorkspaceApi* | [**Get-SiteMetadata**](docs/WorkspaceApi.md#Get-SiteMetadata) | **GET** /workspace/sites/metadata | get site metadata
*WorkspaceApi* | [**Get-WorkspaceItems**](docs/WorkspaceApi.md#Get-WorkspaceItems) | **GET** /workspace/my | get my workspace items
*WorkspacesAdminApi* | [**Invoke-ApplyCommunitiesProfiles**](docs/WorkspacesAdminApi.md#Invoke-ApplyCommunitiesProfiles) | **POST** /admin/directory/workspace/communities/profiles | apply groups policy
*WorkspacesAdminApi* | [**Invoke-ApplyGroupProfiles**](docs/WorkspacesAdminApi.md#Invoke-ApplyGroupProfiles) | **POST** /admin/directory/workspace/group/applyprofiles | apply group profiles
*WorkspacesAdminApi* | [**Invoke-ApplyGroupsPolicy**](docs/WorkspacesAdminApi.md#Invoke-ApplyGroupsPolicy) | **POST** /admin/directory/workspace/groups/policy | apply groups policy
*WorkspacesAdminApi* | [**Invoke-ApplySiteProfiles**](docs/WorkspacesAdminApi.md#Invoke-ApplySiteProfiles) | **POST** /admin/directory/workspace/sites/profiles | apply site profiles
*WorkspacesAdminApi* | [**Invoke-ApplySitesPolicy**](docs/WorkspacesAdminApi.md#Invoke-ApplySitesPolicy) | **POST** /admin/directory/workspace/sites/policy | apply site policy
*WorkspacesAdminApi* | [**Invoke-ApplyTeamProfiles**](docs/WorkspacesAdminApi.md#Invoke-ApplyTeamProfiles) | **POST** /admin/directory/workspace/teams/profiles | apply team profiles
*WorkspacesAdminApi* | [**Invoke-ArchiveWorkspace**](docs/WorkspacesAdminApi.md#Invoke-ArchiveWorkspace) | **POST** /admin/directory/workspace/archive | archive workspace
*WorkspacesAdminApi* | [**Complete-WorkspaceRenewalTask**](docs/WorkspacesAdminApi.md#Complete-WorkspaceRenewalTask) | **POST** /admin/directory/workspace/renewal/complete | completed renewal task
*WorkspacesAdminApi* | [**Invoke-DeleteWorkspaces**](docs/WorkspacesAdminApi.md#Invoke-DeleteWorkspaces) | **DELETE** /admin/directory/workspace | delete workspaces
*WorkspacesAdminApi* | [**Get-OngoingTasks**](docs/WorkspacesAdminApi.md#Get-OngoingTasks) | **GET** /admin/directory/workspace/{type}/ongoningtasks | get workspace ongoing tasks
*WorkspacesAdminApi* | [**Get-WorkspaceFilters**](docs/WorkspacesAdminApi.md#Get-WorkspaceFilters) | **GET** /admin/directory/workspace/filters | get filters for workspace report
*WorkspacesAdminApi* | [**Get-Workspaces**](docs/WorkspacesAdminApi.md#Get-Workspaces) | **GET** /admin/directory/workspace | get managed workspaces
*WorkspacesAdminApi* | [**Get-WorkspacesPost**](docs/WorkspacesAdminApi.md#Get-WorkspacesPost) | **POST** /admin/directory/workspace | get managed workspaces
*WorkspacesAdminApi* | [**Lock-Workspaces**](docs/WorkspacesAdminApi.md#Lock-Workspaces) | **POST** /admin/directory/workspace/lock | lock sites or Office365 group sites
*WorkspacesAdminApi* | [**Invoke-SpecifyContacts**](docs/WorkspacesAdminApi.md#Invoke-SpecifyContacts) | **POST** /admin/directory/workspace/contacts | specify contacts
*WorkspacesAdminApi* | [**Invoke-TriggerWorkspaceRenewal**](docs/WorkspacesAdminApi.md#Invoke-TriggerWorkspaceRenewal) | **POST** /admin/directory/workspace/renewal/trigger | trigger workspace renewal
*WorkspacesAdminApi* | [**Invoke-TriggerWorkspacesElection**](docs/WorkspacesAdminApi.md#Invoke-TriggerWorkspacesElection) | **POST** /admin/directory/workspace/election/trigger | trigger workspace election
*WorkspacesAdminApi* | [**Unlock-Workspace**](docs/WorkspacesAdminApi.md#Unlock-Workspace) | **POST** /admin/directory/workspace/unlock | unlock sites and Office365 group site
*WorkspacesAdminApi* | [**Update-Metadatas**](docs/WorkspacesAdminApi.md#Update-Metadatas) | **POST** /admin/directory/workspace/metadata | update metadatas for workspaces


## Documentation for Models

 - [Cloud.Governance.Client\Model.ActivityModelbase](docs/ActivityModelbase.md)
 - [Cloud.Governance.Client\Model.AddGroupMemberType](docs/AddGroupMemberType.md)
 - [Cloud.Governance.Client\Model.AddSiteColumnToList](docs/AddSiteColumnToList.md)
 - [Cloud.Governance.Client\Model.AdministrativeUnit](docs/AdministrativeUnit.md)
 - [Cloud.Governance.Client\Model.AllRequestDetails](docs/AllRequestDetails.md)
 - [Cloud.Governance.Client\Model.AllRequestDetailsPageResult](docs/AllRequestDetailsPageResult.md)
 - [Cloud.Governance.Client\Model.AllRequestList](docs/AllRequestList.md)
 - [Cloud.Governance.Client\Model.AllRequestListPageResult](docs/AllRequestListPageResult.md)
 - [Cloud.Governance.Client\Model.AllTaskList](docs/AllTaskList.md)
 - [Cloud.Governance.Client\Model.AllTaskListPageResult](docs/AllTaskListPageResult.md)
 - [Cloud.Governance.Client\Model.AnnoymouslinkPermissions](docs/AnnoymouslinkPermissions.md)
 - [Cloud.Governance.Client\Model.AnonymousLinkSettings](docs/AnonymousLinkSettings.md)
 - [Cloud.Governance.Client\Model.ApiCategoryType](docs/ApiCategoryType.md)
 - [Cloud.Governance.Client\Model.ApiCredential](docs/ApiCredential.md)
 - [Cloud.Governance.Client\Model.ApiDurationType](docs/ApiDurationType.md)
 - [Cloud.Governance.Client\Model.ApiError](docs/ApiError.md)
 - [Cloud.Governance.Client\Model.ApiMyGroup](docs/ApiMyGroup.md)
 - [Cloud.Governance.Client\Model.ApiMyGroupPrimaryContact](docs/ApiMyGroupPrimaryContact.md)
 - [Cloud.Governance.Client\Model.ApiProfileObjectType](docs/ApiProfileObjectType.md)
 - [Cloud.Governance.Client\Model.ApiRequest](docs/ApiRequest.md)
 - [Cloud.Governance.Client\Model.ApiRequestProgressStatus](docs/ApiRequestProgressStatus.md)
 - [Cloud.Governance.Client\Model.ApiSiteStatus](docs/ApiSiteStatus.md)
 - [Cloud.Governance.Client\Model.ApiTask](docs/ApiTask.md)
 - [Cloud.Governance.Client\Model.ApiTaskDynamicProperties](docs/ApiTaskDynamicProperties.md)
 - [Cloud.Governance.Client\Model.ApiUploadFileType](docs/ApiUploadFileType.md)
 - [Cloud.Governance.Client\Model.ApiUser](docs/ApiUser.md)
 - [Cloud.Governance.Client\Model.ApiUserChangedProperty](docs/ApiUserChangedProperty.md)
 - [Cloud.Governance.Client\Model.ApiUserIListChangedProperty](docs/ApiUserIListChangedProperty.md)
 - [Cloud.Governance.Client\Model.ApiUserPageResult](docs/ApiUserPageResult.md)
 - [Cloud.Governance.Client\Model.ApiUserType](docs/ApiUserType.md)
 - [Cloud.Governance.Client\Model.ApmTemplateSetting](docs/ApmTemplateSetting.md)
 - [Cloud.Governance.Client\Model.ApmTemplateSettingApmTemplate](docs/ApmTemplateSettingApmTemplate.md)
 - [Cloud.Governance.Client\Model.AppInfo](docs/AppInfo.md)
 - [Cloud.Governance.Client\Model.AppSettingType](docs/AppSettingType.md)
 - [Cloud.Governance.Client\Model.AppSettings](docs/AppSettings.md)
 - [Cloud.Governance.Client\Model.ApplyCommunityProfilesModel](docs/ApplyCommunityProfilesModel.md)
 - [Cloud.Governance.Client\Model.ApplyGroupPolicyModel](docs/ApplyGroupPolicyModel.md)
 - [Cloud.Governance.Client\Model.ApplyGroupPolicyModelLifecycleRenewalSetting](docs/ApplyGroupPolicyModelLifecycleRenewalSetting.md)
 - [Cloud.Governance.Client\Model.ApplyPolicyStatus](docs/ApplyPolicyStatus.md)
 - [Cloud.Governance.Client\Model.ApplyProfilesModel](docs/ApplyProfilesModel.md)
 - [Cloud.Governance.Client\Model.ApplySitePolicyModel](docs/ApplySitePolicyModel.md)
 - [Cloud.Governance.Client\Model.ApplyTeamProfilesModel](docs/ApplyTeamProfilesModel.md)
 - [Cloud.Governance.Client\Model.ApproveProcessModel](docs/ApproveProcessModel.md)
 - [Cloud.Governance.Client\Model.ArchiveGroupRequest](docs/ArchiveGroupRequest.md)
 - [Cloud.Governance.Client\Model.ArchiveSiteRequest](docs/ArchiveSiteRequest.md)
 - [Cloud.Governance.Client\Model.ArchiveWebLifecycleRequest](docs/ArchiveWebLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.ArchiveWorkspaceParameter](docs/ArchiveWorkspaceParameter.md)
 - [Cloud.Governance.Client\Model.AssignBy](docs/AssignBy.md)
 - [Cloud.Governance.Client\Model.AssociateToHubSite](docs/AssociateToHubSite.md)
 - [Cloud.Governance.Client\Model.AuthenticationType](docs/AuthenticationType.md)
 - [Cloud.Governance.Client\Model.AutoCompleteRenewalTaskParameter](docs/AutoCompleteRenewalTaskParameter.md)
 - [Cloud.Governance.Client\Model.AutoGenerateUrlSetting](docs/AutoGenerateUrlSetting.md)
 - [Cloud.Governance.Client\Model.AutoGenerateUrlSettingRandomStringSettings](docs/AutoGenerateUrlSettingRandomStringSettings.md)
 - [Cloud.Governance.Client\Model.AutoGenerateUrlSettingSequentialNumberingSettings](docs/AutoGenerateUrlSettingSequentialNumberingSettings.md)
 - [Cloud.Governance.Client\Model.AutoGenerateUrlType](docs/AutoGenerateUrlType.md)
 - [Cloud.Governance.Client\Model.AutoImportPhase](docs/AutoImportPhase.md)
 - [Cloud.Governance.Client\Model.AutoImportProcessHookMessage](docs/AutoImportProcessHookMessage.md)
 - [Cloud.Governance.Client\Model.AutoTaskExtendRequest](docs/AutoTaskExtendRequest.md)
 - [Cloud.Governance.Client\Model.AutoTaskExtendRequestComments](docs/AutoTaskExtendRequestComments.md)
 - [Cloud.Governance.Client\Model.AzureAdMetadataSettings](docs/AzureAdMetadataSettings.md)
 - [Cloud.Governance.Client\Model.AzureAdMetadataSettingsOffice365Tenant](docs/AzureAdMetadataSettingsOffice365Tenant.md)
 - [Cloud.Governance.Client\Model.AzureAdMetadataSettingsValue](docs/AzureAdMetadataSettingsValue.md)
 - [Cloud.Governance.Client\Model.BackupEnvironmentSetting](docs/BackupEnvironmentSetting.md)
 - [Cloud.Governance.Client\Model.BookingRequestType](docs/BookingRequestType.md)
 - [Cloud.Governance.Client\Model.BooleanChangedProperty](docs/BooleanChangedProperty.md)
 - [Cloud.Governance.Client\Model.BooleanMetadataSettings](docs/BooleanMetadataSettings.md)
 - [Cloud.Governance.Client\Model.BriefGroupPolicy](docs/BriefGroupPolicy.md)
 - [Cloud.Governance.Client\Model.CategoryType](docs/CategoryType.md)
 - [Cloud.Governance.Client\Model.ChangeContactByUrlSetting](docs/ChangeContactByUrlSetting.md)
 - [Cloud.Governance.Client\Model.ChangeContactByUserSetting](docs/ChangeContactByUserSetting.md)
 - [Cloud.Governance.Client\Model.ChangeContactMethod](docs/ChangeContactMethod.md)
 - [Cloud.Governance.Client\Model.ChangeContactObjectModel](docs/ChangeContactObjectModel.md)
 - [Cloud.Governance.Client\Model.ChangeExchangeResourceMembershipGalleryRequestModel](docs/ChangeExchangeResourceMembershipGalleryRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupInfo](docs/ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupInfo.md)
 - [Cloud.Governance.Client\Model.ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership](docs/ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership.md)
 - [Cloud.Governance.Client\Model.ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers](docs/ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers.md)
 - [Cloud.Governance.Client\Model.ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel](docs/ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.ChangeExchangeResourceSettingsGroupModel](docs/ChangeExchangeResourceSettingsGroupModel.md)
 - [Cloud.Governance.Client\Model.ChangeGroupPolicyRequest](docs/ChangeGroupPolicyRequest.md)
 - [Cloud.Governance.Client\Model.ChangeGroupPolicyRequestOriginalPolicy](docs/ChangeGroupPolicyRequestOriginalPolicy.md)
 - [Cloud.Governance.Client\Model.ChangeGroupPolicyRequestPolicy](docs/ChangeGroupPolicyRequestPolicy.md)
 - [Cloud.Governance.Client\Model.ChangeGroupPolicyResult](docs/ChangeGroupPolicyResult.md)
 - [Cloud.Governance.Client\Model.ChangeGroupQuotaRequest](docs/ChangeGroupQuotaRequest.md)
 - [Cloud.Governance.Client\Model.ChangeGroupQuotaResult](docs/ChangeGroupQuotaResult.md)
 - [Cloud.Governance.Client\Model.ChangeGroupRequestDescription](docs/ChangeGroupRequestDescription.md)
 - [Cloud.Governance.Client\Model.ChangeGroupRequestName](docs/ChangeGroupRequestName.md)
 - [Cloud.Governance.Client\Model.ChangeGroupRequestVisibility](docs/ChangeGroupRequestVisibility.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingCheckResult](docs/ChangeGroupSettingCheckResult.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingCheckResultLocaleSettings](docs/ChangeGroupSettingCheckResultLocaleSettings.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingCheckResultSensitivity](docs/ChangeGroupSettingCheckResultSensitivity.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingCheckResultTimeZoneSettings](docs/ChangeGroupSettingCheckResultTimeZoneSettings.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingRequest](docs/ChangeGroupSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingRequestLocaleSettings](docs/ChangeGroupSettingRequestLocaleSettings.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingRequestOriginalLocaleSettings](docs/ChangeGroupSettingRequestOriginalLocaleSettings.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingRequestOriginalTimeZoneSettings](docs/ChangeGroupSettingRequestOriginalTimeZoneSettings.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingRequestTimeZoneSettings](docs/ChangeGroupSettingRequestTimeZoneSettings.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingService](docs/ChangeGroupSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingServiceCustomActions](docs/ChangeGroupSettingServiceCustomActions.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingServiceRequestTemplate](docs/ChangeGroupSettingServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingValidationParameter](docs/ChangeGroupSettingValidationParameter.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingsModel](docs/ChangeGroupSettingsModel.md)
 - [Cloud.Governance.Client\Model.ChangeGroupTeamPicture](docs/ChangeGroupTeamPicture.md)
 - [Cloud.Governance.Client\Model.ChangeHubSiteContentModel](docs/ChangeHubSiteContentModel.md)
 - [Cloud.Governance.Client\Model.ChangeHubSiteContentModelChangedValueRequestModel](docs/ChangeHubSiteContentModelChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeHubSiteContentModelChangedValueRequestModelNewValue](docs/ChangeHubSiteContentModelChangedValueRequestModelNewValue.md)
 - [Cloud.Governance.Client\Model.ChangeHubSiteMethod](docs/ChangeHubSiteMethod.md)
 - [Cloud.Governance.Client\Model.ChangeHubsiteActionType](docs/ChangeHubsiteActionType.md)
 - [Cloud.Governance.Client\Model.ChangeLicenseGallery](docs/ChangeLicenseGallery.md)
 - [Cloud.Governance.Client\Model.ChangeLicenseGalleryLicenseDetails](docs/ChangeLicenseGalleryLicenseDetails.md)
 - [Cloud.Governance.Client\Model.ChangeLicenseGalleryUsersInfo](docs/ChangeLicenseGalleryUsersInfo.md)
 - [Cloud.Governance.Client\Model.ChangeLicenseModel](docs/ChangeLicenseModel.md)
 - [Cloud.Governance.Client\Model.ChangeLicenseModelLicenseUpdateInfo](docs/ChangeLicenseModelLicenseUpdateInfo.md)
 - [Cloud.Governance.Client\Model.ChangeLicenseUserModel](docs/ChangeLicenseUserModel.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingObjectInfo](docs/ChangeListSettingObjectInfo.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingRequest](docs/ChangeListSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingRequestListTitle](docs/ChangeListSettingRequestListTitle.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingRequestNavigationSetting](docs/ChangeListSettingRequestNavigationSetting.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingRequestObjectInfo](docs/ChangeListSettingRequestObjectInfo.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingRequestVersionSetting](docs/ChangeListSettingRequestVersionSetting.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingService](docs/ChangeListSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingServiceRequestTemplate](docs/ChangeListSettingServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingValidateResult](docs/ChangeListSettingValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeMetadataActionSetting](docs/ChangeMetadataActionSetting.md)
 - [Cloud.Governance.Client\Model.ChangePermissionRequest](docs/ChangePermissionRequest.md)
 - [Cloud.Governance.Client\Model.ChangePermissionRequestObjectProperty](docs/ChangePermissionRequestObjectProperty.md)
 - [Cloud.Governance.Client\Model.ChangePermissionService](docs/ChangePermissionService.md)
 - [Cloud.Governance.Client\Model.ChangePermissionServiceRequestTemplate](docs/ChangePermissionServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangePermissionServiceScopeSettings](docs/ChangePermissionServiceScopeSettings.md)
 - [Cloud.Governance.Client\Model.ChangePermissionValidateResult](docs/ChangePermissionValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangePictureOptionType](docs/ChangePictureOptionType.md)
 - [Cloud.Governance.Client\Model.ChangePictureOptionTypeForSite](docs/ChangePictureOptionTypeForSite.md)
 - [Cloud.Governance.Client\Model.ChangePolicyActionSetting](docs/ChangePolicyActionSetting.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelCheckResult](docs/ChangePrivateChannelCheckResult.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelCheckResultTeam](docs/ChangePrivateChannelCheckResultTeam.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelFieldModel](docs/ChangePrivateChannelFieldModel.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelFieldName](docs/ChangePrivateChannelFieldName.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelQuotaModel](docs/ChangePrivateChannelQuotaModel.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelQuotaType](docs/ChangePrivateChannelQuotaType.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequest](docs/ChangePrivateChannelRequest.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestChannel](docs/ChangePrivateChannelRequestChannel.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestChannelDescription](docs/ChangePrivateChannelRequestChannelDescription.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestMembers](docs/ChangePrivateChannelRequestMembers.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestName](docs/ChangePrivateChannelRequestName.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestOwners](docs/ChangePrivateChannelRequestOwners.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestQuotaStorage](docs/ChangePrivateChannelRequestQuotaStorage.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelRequestTeam](docs/ChangePrivateChannelRequestTeam.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelService](docs/ChangePrivateChannelService.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelServiceChangePrivateChannelQuotaSetting](docs/ChangePrivateChannelServiceChangePrivateChannelQuotaSetting.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelServiceRequestTemplate](docs/ChangePrivateChannelServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangePrivateChannelValidationParameter](docs/ChangePrivateChannelValidationParameter.md)
 - [Cloud.Governance.Client\Model.ChangeSecurityGroupSettingsGalleryRequestModel](docs/ChangeSecurityGroupSettingsGalleryRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupDescription](docs/ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupDescription.md)
 - [Cloud.Governance.Client\Model.ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupName](docs/ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupName.md)
 - [Cloud.Governance.Client\Model.ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility](docs/ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility.md)
 - [Cloud.Governance.Client\Model.ChangeSecurityGroupSettingsGalleryRequestModelGroupSettingInfo](docs/ChangeSecurityGroupSettingsGalleryRequestModelGroupSettingInfo.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelGallery](docs/ChangeSharedChannelGallery.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelGalleryOwners](docs/ChangeSharedChannelGalleryOwners.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelGallerySharedChannelDescription](docs/ChangeSharedChannelGallerySharedChannelDescription.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelGallerySharedChannelInfo](docs/ChangeSharedChannelGallerySharedChannelInfo.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelGallerySharedChannelName](docs/ChangeSharedChannelGallerySharedChannelName.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelGallerySiteStorage](docs/ChangeSharedChannelGallerySiteStorage.md)
 - [Cloud.Governance.Client\Model.ChangeSharedChannelModel](docs/ChangeSharedChannelModel.md)
 - [Cloud.Governance.Client\Model.ChangeSharedMailboxModel](docs/ChangeSharedMailboxModel.md)
 - [Cloud.Governance.Client\Model.ChangeSharedMailboxPermissionGallery](docs/ChangeSharedMailboxPermissionGallery.md)
 - [Cloud.Governance.Client\Model.ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo](docs/ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactElectionProfileModel](docs/ChangeSiteContactElectionProfileModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction](docs/ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactRequest](docs/ChangeSiteContactRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactRequestChangeByUserSetting](docs/ChangeSiteContactRequestChangeByUserSetting.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactService](docs/ChangeSiteContactService.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactServiceRequestTemplate](docs/ChangeSiteContactServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactSubRequest](docs/ChangeSiteContactSubRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactSubRequestAdminContactSettings](docs/ChangeSiteContactSubRequestAdminContactSettings.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactValidateResult](docs/ChangeSiteContactValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeSiteExternalSharingProfileModel](docs/ChangeSiteExternalSharingProfileModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteHubSiteRequestModel](docs/ChangeSiteHubSiteRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteHubSiteRequestModelChangeHubSite](docs/ChangeSiteHubSiteRequestModelChangeHubSite.md)
 - [Cloud.Governance.Client\Model.ChangeSiteObjectModel](docs/ChangeSiteObjectModel.md)
 - [Cloud.Governance.Client\Model.ChangeSitePicture](docs/ChangeSitePicture.md)
 - [Cloud.Governance.Client\Model.ChangeSitePolicyRequest](docs/ChangeSitePolicyRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSitePolicyRequestOriginalPolicy](docs/ChangeSitePolicyRequestOriginalPolicy.md)
 - [Cloud.Governance.Client\Model.ChangeSitePolicyRequestPolicy](docs/ChangeSitePolicyRequestPolicy.md)
 - [Cloud.Governance.Client\Model.ChangeSitePolicySetting](docs/ChangeSitePolicySetting.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfileOngoingActionModel](docs/ChangeSiteProfileOngoingActionModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesGallery](docs/ChangeSiteProfilesGallery.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesGallerySiteContactElectionProfile](docs/ChangeSiteProfilesGallerySiteContactElectionProfile.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesGallerySiteExternalSharingProfile](docs/ChangeSiteProfilesGallerySiteExternalSharingProfile.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesGallerySiteProfileInfo](docs/ChangeSiteProfilesGallerySiteProfileInfo.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesGallerySiteRenewalProfile](docs/ChangeSiteProfilesGallerySiteRenewalProfile.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesGallerySiteStorageManagementProfile](docs/ChangeSiteProfilesGallerySiteStorageManagementProfile.md)
 - [Cloud.Governance.Client\Model.ChangeSiteProfilesModel](docs/ChangeSiteProfilesModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteQuotaRequest](docs/ChangeSiteQuotaRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteQuotaSettings](docs/ChangeSiteQuotaSettings.md)
 - [Cloud.Governance.Client\Model.ChangeSiteRenewProfileModel](docs/ChangeSiteRenewProfileModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModel](docs/ChangeSiteSettingGalleryRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangeSitePicture](docs/ChangeSiteSettingGalleryRequestModelChangeSitePicture.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteClassification](docs/ChangeSiteSettingGalleryRequestModelChangedSiteClassification.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteDesign](docs/ChangeSiteSettingGalleryRequestModelChangedSiteDesign.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteHubSite](docs/ChangeSiteSettingGalleryRequestModelChangedSiteHubSite.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteSensitivityLabel](docs/ChangeSiteSettingGalleryRequestModelChangedSiteSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteSharing](docs/ChangeSiteSettingGalleryRequestModelChangedSiteSharing.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteTimeZone](docs/ChangeSiteSettingGalleryRequestModelChangedSiteTimeZone.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelChangedSiteTitle](docs/ChangeSiteSettingGalleryRequestModelChangedSiteTitle.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingGalleryRequestModelSiteInfo](docs/ChangeSiteSettingGalleryRequestModelSiteInfo.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingRequest](docs/ChangeSiteSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingRequestHubSiteSettings](docs/ChangeSiteSettingRequestHubSiteSettings.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingService](docs/ChangeSiteSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingServiceChangeMetadataSettings](docs/ChangeSiteSettingServiceChangeMetadataSettings.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingServiceDeploymentManagerPlanSettings](docs/ChangeSiteSettingServiceDeploymentManagerPlanSettings.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingServiceRequestTemplate](docs/ChangeSiteSettingServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingValidateResult](docs/ChangeSiteSettingValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModel](docs/ChangeSiteSharingRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModelExternalSharing](docs/ChangeSiteSharingRequestModelExternalSharing.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModelGuestAccessExpireSetting](docs/ChangeSiteSharingRequestModelGuestAccessExpireSetting.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModelLinkPermissionType](docs/ChangeSiteSharingRequestModelLinkPermissionType.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModelSharingAdvanceSetting](docs/ChangeSiteSharingRequestModelSharingAdvanceSetting.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModelSharingLinkType](docs/ChangeSiteSharingRequestModelSharingLinkType.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSharingRequestModelTenantLevelSetting](docs/ChangeSiteSharingRequestModelTenantLevelSetting.md)
 - [Cloud.Governance.Client\Model.ChangeSiteStorageManagementProfileModel](docs/ChangeSiteStorageManagementProfileModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteStorageSettingModel](docs/ChangeSiteStorageSettingModel.md)
 - [Cloud.Governance.Client\Model.ChangeSiteStorageSettingModelChangedSiteStorage](docs/ChangeSiteStorageSettingModelChangedSiteStorage.md)
 - [Cloud.Governance.Client\Model.ChangeTeamClassificationAndSensitivityLabel](docs/ChangeTeamClassificationAndSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.ChangeTeamClassificationAndSensitivityLabelClassification](docs/ChangeTeamClassificationAndSensitivityLabelClassification.md)
 - [Cloud.Governance.Client\Model.ChangeTeamClassificationAndSensitivityLabelSensitivityLabel](docs/ChangeTeamClassificationAndSensitivityLabelSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.ChangeTeamDisplayName](docs/ChangeTeamDisplayName.md)
 - [Cloud.Governance.Client\Model.ChangeTeamFunStuff](docs/ChangeTeamFunStuff.md)
 - [Cloud.Governance.Client\Model.ChangeTeamMemberPermission](docs/ChangeTeamMemberPermission.md)
 - [Cloud.Governance.Client\Model.ChangeTeamMentions](docs/ChangeTeamMentions.md)
 - [Cloud.Governance.Client\Model.ChangeTeamPrivacySetting](docs/ChangeTeamPrivacySetting.md)
 - [Cloud.Governance.Client\Model.ChangeTeamRequestDescription](docs/ChangeTeamRequestDescription.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModel](docs/ChangeTeamSettingGalleryRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList](docs/ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamClassificationAndSensitivityLabel](docs/ChangeTeamSettingGalleryRequestModelChangeTeamClassificationAndSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamDescription](docs/ChangeTeamSettingGalleryRequestModelChangeTeamDescription.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamDisplayName](docs/ChangeTeamSettingGalleryRequestModelChangeTeamDisplayName.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission](docs/ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamOutlookExperience](docs/ChangeTeamSettingGalleryRequestModelChangeTeamOutlookExperience.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamPicture](docs/ChangeTeamSettingGalleryRequestModelChangeTeamPicture.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelChangeTeamPrivacySetting](docs/ChangeTeamSettingGalleryRequestModelChangeTeamPrivacySetting.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelFunStuffSettings](docs/ChangeTeamSettingGalleryRequestModelFunStuffSettings.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelGuestPermissions](docs/ChangeTeamSettingGalleryRequestModelGuestPermissions.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelMentions](docs/ChangeTeamSettingGalleryRequestModelMentions.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingGalleryRequestModelTeamSettingInfo](docs/ChangeTeamSettingGalleryRequestModelTeamSettingInfo.md)
 - [Cloud.Governance.Client\Model.ChangeTeamSettingModel](docs/ChangeTeamSettingModel.md)
 - [Cloud.Governance.Client\Model.ChangeTemplateGiphyRatingType](docs/ChangeTemplateGiphyRatingType.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactByUrlSetting](docs/ChangeWebContactByUrlSetting.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactByUrlSettingPrimaryContact](docs/ChangeWebContactByUrlSettingPrimaryContact.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactRequest](docs/ChangeWebContactRequest.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactService](docs/ChangeWebContactService.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactServiceRequestTemplate](docs/ChangeWebContactServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactSubRequest](docs/ChangeWebContactSubRequest.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactSubRequestContactChangeSettings](docs/ChangeWebContactSubRequestContactChangeSettings.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactValidateResult](docs/ChangeWebContactValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeWebSPObject](docs/ChangeWebSPObject.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingRequest](docs/ChangeWebSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingRequestChangedMetadata](docs/ChangeWebSettingRequestChangedMetadata.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingRequestUrl](docs/ChangeWebSettingRequestUrl.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingService](docs/ChangeWebSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingServiceRequestTemplate](docs/ChangeWebSettingServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ChangeWebUrlValidateResult](docs/ChangeWebUrlValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangedLicense](docs/ChangedLicense.md)
 - [Cloud.Governance.Client\Model.ChangedMembership](docs/ChangedMembership.md)
 - [Cloud.Governance.Client\Model.ChangedSiteDesignModel](docs/ChangedSiteDesignModel.md)
 - [Cloud.Governance.Client\Model.ChangedSiteDesignModelChangedValueRequestModel](docs/ChangedSiteDesignModelChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.ChangedSiteDesignModelChangedValueRequestModelNewValue](docs/ChangedSiteDesignModelChangedValueRequestModelNewValue.md)
 - [Cloud.Governance.Client\Model.ChoiceMetadataSettings](docs/ChoiceMetadataSettings.md)
 - [Cloud.Governance.Client\Model.ChoiceType](docs/ChoiceType.md)
 - [Cloud.Governance.Client\Model.ClaimStatus](docs/ClaimStatus.md)
 - [Cloud.Governance.Client\Model.ClonePermissionAdditionalOption](docs/ClonePermissionAdditionalOption.md)
 - [Cloud.Governance.Client\Model.ClonePermissionOption](docs/ClonePermissionOption.md)
 - [Cloud.Governance.Client\Model.ClonePermissionRequest](docs/ClonePermissionRequest.md)
 - [Cloud.Governance.Client\Model.ClonePermissionService](docs/ClonePermissionService.md)
 - [Cloud.Governance.Client\Model.ClonePermissionServiceRequestTemplate](docs/ClonePermissionServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ClonePermissionValidateResult](docs/ClonePermissionValidateResult.md)
 - [Cloud.Governance.Client\Model.CloneTeam](docs/CloneTeam.md)
 - [Cloud.Governance.Client\Model.CommentsParam](docs/CommentsParam.md)
 - [Cloud.Governance.Client\Model.CommonSharingExpirationType](docs/CommonSharingExpirationType.md)
 - [Cloud.Governance.Client\Model.CommonStatus](docs/CommonStatus.md)
 - [Cloud.Governance.Client\Model.Communication](docs/Communication.md)
 - [Cloud.Governance.Client\Model.ConflictResolutionSetting](docs/ConflictResolutionSetting.md)
 - [Cloud.Governance.Client\Model.ConflictSolutionType](docs/ConflictSolutionType.md)
 - [Cloud.Governance.Client\Model.ConstructGroupId](docs/ConstructGroupId.md)
 - [Cloud.Governance.Client\Model.ConstructedUrl](docs/ConstructedUrl.md)
 - [Cloud.Governance.Client\Model.ConstructureType](docs/ConstructureType.md)
 - [Cloud.Governance.Client\Model.Contact](docs/Contact.md)
 - [Cloud.Governance.Client\Model.ContactInformation](docs/ContactInformation.md)
 - [Cloud.Governance.Client\Model.ContainerInfo](docs/ContainerInfo.md)
 - [Cloud.Governance.Client\Model.ContainerScopeSetting](docs/ContainerScopeSetting.md)
 - [Cloud.Governance.Client\Model.ContainerScopeSettingContainer](docs/ContainerScopeSettingContainer.md)
 - [Cloud.Governance.Client\Model.ContainerScopeType](docs/ContainerScopeType.md)
 - [Cloud.Governance.Client\Model.ContentMoveAction](docs/ContentMoveAction.md)
 - [Cloud.Governance.Client\Model.ContentMoveCommonSetting](docs/ContentMoveCommonSetting.md)
 - [Cloud.Governance.Client\Model.ContentMoveCommonSettingBackupSettings](docs/ContentMoveCommonSettingBackupSettings.md)
 - [Cloud.Governance.Client\Model.ContentMoveCommonSettingConflictResolutionSettings](docs/ContentMoveCommonSettingConflictResolutionSettings.md)
 - [Cloud.Governance.Client\Model.ContentMoveCommonSettingProfileMappings](docs/ContentMoveCommonSettingProfileMappings.md)
 - [Cloud.Governance.Client\Model.ContentMoveMethod](docs/ContentMoveMethod.md)
 - [Cloud.Governance.Client\Model.ContentMoveProfileMappings](docs/ContentMoveProfileMappings.md)
 - [Cloud.Governance.Client\Model.ContentMoveProfiles](docs/ContentMoveProfiles.md)
 - [Cloud.Governance.Client\Model.ContentMoveRequest](docs/ContentMoveRequest.md)
 - [Cloud.Governance.Client\Model.ContentMoveRequestCommonSettings](docs/ContentMoveRequestCommonSettings.md)
 - [Cloud.Governance.Client\Model.ContentMoveRequestCopySettings](docs/ContentMoveRequestCopySettings.md)
 - [Cloud.Governance.Client\Model.ContentMoveSPObject](docs/ContentMoveSPObject.md)
 - [Cloud.Governance.Client\Model.ContentMoveSPObjectMapping](docs/ContentMoveSPObjectMapping.md)
 - [Cloud.Governance.Client\Model.ContentMoveSPObjectMappingSource](docs/ContentMoveSPObjectMappingSource.md)
 - [Cloud.Governance.Client\Model.ContentMoveService](docs/ContentMoveService.md)
 - [Cloud.Governance.Client\Model.ContentMoveServiceCopySettingAssignBy](docs/ContentMoveServiceCopySettingAssignBy.md)
 - [Cloud.Governance.Client\Model.ContentMoveServiceRequestTemplate](docs/ContentMoveServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ContentMoveUrlValidationParameter](docs/ContentMoveUrlValidationParameter.md)
 - [Cloud.Governance.Client\Model.ContentMoveUrlValidationResult](docs/ContentMoveUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.ContentTypes](docs/ContentTypes.md)
 - [Cloud.Governance.Client\Model.ContructUrlSetting](docs/ContructUrlSetting.md)
 - [Cloud.Governance.Client\Model.ConvertAutomaticReply](docs/ConvertAutomaticReply.md)
 - [Cloud.Governance.Client\Model.ConvertEmail](docs/ConvertEmail.md)
 - [Cloud.Governance.Client\Model.ConvertHubSite](docs/ConvertHubSite.md)
 - [Cloud.Governance.Client\Model.ConvertHubSiteActionType](docs/ConvertHubSiteActionType.md)
 - [Cloud.Governance.Client\Model.CopyMoveSetting](docs/CopyMoveSetting.md)
 - [Cloud.Governance.Client\Model.CopyMoveSettingAssignBy](docs/CopyMoveSettingAssignBy.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGallery](docs/CreateCommunityGallery.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryClassificationAndSensitivityLabel](docs/CreateCommunityGalleryClassificationAndSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryCommunityInfo](docs/CreateCommunityGalleryCommunityInfo.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryContact](docs/CreateCommunityGalleryContact.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryContentTypes](docs/CreateCommunityGalleryContentTypes.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryDynamicMembershipRules](docs/CreateCommunityGalleryDynamicMembershipRules.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryElectionProfile](docs/CreateCommunityGalleryElectionProfile.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryExternalSharingSettingProfile](docs/CreateCommunityGalleryExternalSharingSettingProfile.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryGovernancePanel](docs/CreateCommunityGalleryGovernancePanel.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryHubSite](docs/CreateCommunityGalleryHubSite.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryLocale](docs/CreateCommunityGalleryLocale.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryMembers](docs/CreateCommunityGalleryMembers.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryNameAndDescription](docs/CreateCommunityGalleryNameAndDescription.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryOwners](docs/CreateCommunityGalleryOwners.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryPrivacy](docs/CreateCommunityGalleryPrivacy.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryQuotaSettingProfile](docs/CreateCommunityGalleryQuotaSettingProfile.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryRenewalProfile](docs/CreateCommunityGalleryRenewalProfile.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryShowLinksInRequestDetailsPage](docs/CreateCommunityGalleryShowLinksInRequestDetailsPage.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGallerySiteDesign](docs/CreateCommunityGallerySiteDesign.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryTenant](docs/CreateCommunityGalleryTenant.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryTimeZone](docs/CreateCommunityGalleryTimeZone.md)
 - [Cloud.Governance.Client\Model.CreateCommunityGalleryWelcomeEmail](docs/CreateCommunityGalleryWelcomeEmail.md)
 - [Cloud.Governance.Client\Model.CreateDistributionListGallery](docs/CreateDistributionListGallery.md)
 - [Cloud.Governance.Client\Model.CreateDistributionListGalleryCommunication](docs/CreateDistributionListGalleryCommunication.md)
 - [Cloud.Governance.Client\Model.CreateDistributionListGalleryDeliveryManagement](docs/CreateDistributionListGalleryDeliveryManagement.md)
 - [Cloud.Governance.Client\Model.CreateDistributionListGalleryGroupEmailAddress](docs/CreateDistributionListGalleryGroupEmailAddress.md)
 - [Cloud.Governance.Client\Model.CreateDistributionListGalleryMembershipApproval](docs/CreateDistributionListGalleryMembershipApproval.md)
 - [Cloud.Governance.Client\Model.CreateDistributionListGalleryMessageApproval](docs/CreateDistributionListGalleryMessageApproval.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGallery](docs/CreateEquipmentMailboxGallery.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryAddressBookPolicy](docs/CreateEquipmentMailboxGalleryAddressBookPolicy.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryAlias](docs/CreateEquipmentMailboxGalleryAlias.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryBookingDelegateSetting](docs/CreateEquipmentMailboxGalleryBookingDelegateSetting.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryBookingOption](docs/CreateEquipmentMailboxGalleryBookingOption.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryCapacity](docs/CreateEquipmentMailboxGalleryCapacity.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryCompany](docs/CreateEquipmentMailboxGalleryCompany.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryContactInformation](docs/CreateEquipmentMailboxGalleryContactInformation.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryDepartment](docs/CreateEquipmentMailboxGalleryDepartment.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryDisableAccountSetting](docs/CreateEquipmentMailboxGalleryDisableAccountSetting.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryGlobalAddressList](docs/CreateEquipmentMailboxGalleryGlobalAddressList.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryMailTip](docs/CreateEquipmentMailboxGalleryMailTip.md)
 - [Cloud.Governance.Client\Model.CreateEquipmentMailboxGalleryMultiGeoLocationSetting](docs/CreateEquipmentMailboxGalleryMultiGeoLocationSetting.md)
 - [Cloud.Governance.Client\Model.CreateGroupGallery](docs/CreateGroupGallery.md)
 - [Cloud.Governance.Client\Model.CreateGroupGalleryAdministrativeUnit](docs/CreateGroupGalleryAdministrativeUnit.md)
 - [Cloud.Governance.Client\Model.CreateGroupGalleryGroupId](docs/CreateGroupGalleryGroupId.md)
 - [Cloud.Governance.Client\Model.CreateGroupGalleryGroupPicture](docs/CreateGroupGalleryGroupPicture.md)
 - [Cloud.Governance.Client\Model.CreateGroupGalleryOutsideSenders](docs/CreateGroupGalleryOutsideSenders.md)
 - [Cloud.Governance.Client\Model.CreateGroupGallerySubscribeMembers](docs/CreateGroupGallerySubscribeMembers.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequest](docs/CreateGroupRequest.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestHubSiteSettings](docs/CreateGroupRequestHubSiteSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestLeasePeriodSettings](docs/CreateGroupRequestLeasePeriodSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestLinks](docs/CreateGroupRequestLinks.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestLocaleSettings](docs/CreateGroupRequestLocaleSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestMultiGeoLocation](docs/CreateGroupRequestMultiGeoLocation.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestPrimaryContact](docs/CreateGroupRequestPrimaryContact.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestSecondaryContact](docs/CreateGroupRequestSecondaryContact.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestTeamsSettings](docs/CreateGroupRequestTeamsSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestTemplateSettings](docs/CreateGroupRequestTemplateSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequestTimeZoneSettings](docs/CreateGroupRequestTimeZoneSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupService](docs/CreateGroupService.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceGroupIdConstructureSettings](docs/CreateGroupServiceGroupIdConstructureSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceGroupNameConstructureSettings](docs/CreateGroupServiceGroupNameConstructureSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceHubSiteSettings](docs/CreateGroupServiceHubSiteSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceMultiGeoSetting](docs/CreateGroupServiceMultiGeoSetting.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceRequestTemplate](docs/CreateGroupServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceTeamsSettings](docs/CreateGroupServiceTeamsSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupServiceTemplateSettings](docs/CreateGroupServiceTemplateSettings.md)
 - [Cloud.Governance.Client\Model.CreateGroupType](docs/CreateGroupType.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserRequest](docs/CreateGuestUserRequest.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserRequestOneTimeSettings](docs/CreateGuestUserRequestOneTimeSettings.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserRequestUserProperties](docs/CreateGuestUserRequestUserProperties.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserService](docs/CreateGuestUserService.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserServiceRequestTemplate](docs/CreateGuestUserServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserSubRequest](docs/CreateGuestUserSubRequest.md)
 - [Cloud.Governance.Client\Model.CreateGuestUserValidationResult](docs/CreateGuestUserValidationResult.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGallery](docs/CreateLibraryGallery.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryAddSiteColumns](docs/CreateLibraryGalleryAddSiteColumns.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryConstructedUrl](docs/CreateLibraryGalleryConstructedUrl.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryCreateLibraryNotifyOpusForNewFiles](docs/CreateLibraryGalleryCreateLibraryNotifyOpusForNewFiles.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryLibraryDesign](docs/CreateLibraryGalleryLibraryDesign.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryLibraryRecordDeclaration](docs/CreateLibraryGalleryLibraryRecordDeclaration.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryLibraryUrl](docs/CreateLibraryGalleryLibraryUrl.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryNameDescription](docs/CreateLibraryGalleryNameDescription.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryNavigationSetting](docs/CreateLibraryGalleryNavigationSetting.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryPermissionSettings](docs/CreateLibraryGalleryPermissionSettings.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryPnpTemplate](docs/CreateLibraryGalleryPnpTemplate.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGallerySetColumnDefaultValue](docs/CreateLibraryGallerySetColumnDefaultValue.md)
 - [Cloud.Governance.Client\Model.CreateLibraryGalleryVersionSetting](docs/CreateLibraryGalleryVersionSetting.md)
 - [Cloud.Governance.Client\Model.CreateListRequest](docs/CreateListRequest.md)
 - [Cloud.Governance.Client\Model.CreateListRequestParentObject](docs/CreateListRequestParentObject.md)
 - [Cloud.Governance.Client\Model.CreateListRequestPermissionSettings](docs/CreateListRequestPermissionSettings.md)
 - [Cloud.Governance.Client\Model.CreateListRequestVersionSettings](docs/CreateListRequestVersionSettings.md)
 - [Cloud.Governance.Client\Model.CreateListSPObject](docs/CreateListSPObject.md)
 - [Cloud.Governance.Client\Model.CreateListService](docs/CreateListService.md)
 - [Cloud.Governance.Client\Model.CreateListServiceListTemplateSettings](docs/CreateListServiceListTemplateSettings.md)
 - [Cloud.Governance.Client\Model.CreateListServicePermissionSettings](docs/CreateListServicePermissionSettings.md)
 - [Cloud.Governance.Client\Model.CreateListServiceRequestTemplate](docs/CreateListServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.CreateListServiceUrlSettings](docs/CreateListServiceUrlSettings.md)
 - [Cloud.Governance.Client\Model.CreateListUrlSettings](docs/CreateListUrlSettings.md)
 - [Cloud.Governance.Client\Model.CreateListUrlSettingsContructUrlSetting](docs/CreateListUrlSettingsContructUrlSetting.md)
 - [Cloud.Governance.Client\Model.CreateListUrlSettingsTextValidationRule](docs/CreateListUrlSettingsTextValidationRule.md)
 - [Cloud.Governance.Client\Model.CreateListUrlValidationResult](docs/CreateListUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.CreateMailEnabledGroupGallery](docs/CreateMailEnabledGroupGallery.md)
 - [Cloud.Governance.Client\Model.CreateMailEnabledGroupGalleryDeliveryStatusNotifications](docs/CreateMailEnabledGroupGalleryDeliveryStatusNotifications.md)
 - [Cloud.Governance.Client\Model.CreateMailEnabledGroupGalleryMembershipApproval](docs/CreateMailEnabledGroupGalleryMembershipApproval.md)
 - [Cloud.Governance.Client\Model.CreatePrivateChannelCheckResult](docs/CreatePrivateChannelCheckResult.md)
 - [Cloud.Governance.Client\Model.CreatePrivateChannelRequest](docs/CreatePrivateChannelRequest.md)
 - [Cloud.Governance.Client\Model.CreatePrivateChannelService](docs/CreatePrivateChannelService.md)
 - [Cloud.Governance.Client\Model.CreatePrivateChannelValidationParameter](docs/CreatePrivateChannelValidationParameter.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxAddressBookPolicyRequestModel](docs/CreateResourceMailboxAddressBookPolicyRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxAliasRequestModel](docs/CreateResourceMailboxAliasRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxBookingDelegateSettingRequestModel](docs/CreateResourceMailboxBookingDelegateSettingRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxBookingOptionRequestModel](docs/CreateResourceMailboxBookingOptionRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxCapacityRequestModel](docs/CreateResourceMailboxCapacityRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxCompanyRequestModel](docs/CreateResourceMailboxCompanyRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxContactInformationRequestModel](docs/CreateResourceMailboxContactInformationRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxDepartmentRequestModel](docs/CreateResourceMailboxDepartmentRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxDisableAccountRequestModel](docs/CreateResourceMailboxDisableAccountRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxExchangeGlobalAddressListRequestModel](docs/CreateResourceMailboxExchangeGlobalAddressListRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateResourceMailboxMailTipRequestModel](docs/CreateResourceMailboxMailTipRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxAdditionalInformationRequestModel](docs/CreateRoomMailboxAdditionalInformationRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxGallery](docs/CreateRoomMailboxGallery.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxGalleryAdditionalInformation](docs/CreateRoomMailboxGalleryAdditionalInformation.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxGalleryRoomList](docs/CreateRoomMailboxGalleryRoomList.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxGalleryRoomPlace](docs/CreateRoomMailboxGalleryRoomPlace.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxRoomListRequestModel](docs/CreateRoomMailboxRoomListRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateRoomMailboxRoomPlaceRequestModel](docs/CreateRoomMailboxRoomPlaceRequestModel.md)
 - [Cloud.Governance.Client\Model.CreateSecurityGroupGallery](docs/CreateSecurityGroupGallery.md)
 - [Cloud.Governance.Client\Model.CreateSharedChannelGallery](docs/CreateSharedChannelGallery.md)
 - [Cloud.Governance.Client\Model.CreateSharedChannelGallerySharedChannelInfo](docs/CreateSharedChannelGallerySharedChannelInfo.md)
 - [Cloud.Governance.Client\Model.CreateSharedChannelModel](docs/CreateSharedChannelModel.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGallery](docs/CreateSharedMailboxGallery.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryAutoMappingSettings](docs/CreateSharedMailboxGalleryAutoMappingSettings.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryAutomaticReplies](docs/CreateSharedMailboxGalleryAutomaticReplies.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryContactInformation](docs/CreateSharedMailboxGalleryContactInformation.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryEmailForwarding](docs/CreateSharedMailboxGalleryEmailForwarding.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryLanguageDataTime](docs/CreateSharedMailboxGalleryLanguageDataTime.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryPolicies](docs/CreateSharedMailboxGalleryPolicies.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGallerySentItems](docs/CreateSharedMailboxGallerySentItems.md)
 - [Cloud.Governance.Client\Model.CreateSharedMailboxGalleryTimeZone](docs/CreateSharedMailboxGalleryTimeZone.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallery](docs/CreateSiteGallery.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryActivateFeatures](docs/CreateSiteGalleryActivateFeatures.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryAddSiteColumns](docs/CreateSiteGalleryAddSiteColumns.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryAlternateCssUrl](docs/CreateSiteGalleryAlternateCssUrl.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryDpmPlanSetting](docs/CreateSiteGalleryDpmPlanSetting.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryElectionProfile](docs/CreateSiteGalleryElectionProfile.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryPermissionSetting](docs/CreateSiteGalleryPermissionSetting.md)
 - [Cloud.Governance.Client\Model.CreateSiteGalleryScAvePointPortalManagerTemplate](docs/CreateSiteGalleryScAvePointPortalManagerTemplate.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteAdmins](docs/CreateSiteGallerySiteAdmins.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteClassificationAndSensitivityLabel](docs/CreateSiteGallerySiteClassificationAndSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteCloudGovernancePanel](docs/CreateSiteGallerySiteCloudGovernancePanel.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteDepthLimit](docs/CreateSiteGallerySiteDepthLimit.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteInformationIcon](docs/CreateSiteGallerySiteInformationIcon.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteLanguage](docs/CreateSiteGallerySiteLanguage.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySitePicture](docs/CreateSiteGallerySitePicture.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteTemplate](docs/CreateSiteGallerySiteTemplate.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteTitleAndDescription](docs/CreateSiteGallerySiteTitleAndDescription.md)
 - [Cloud.Governance.Client\Model.CreateSiteGallerySiteUrlSetting](docs/CreateSiteGallerySiteUrlSetting.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequest](docs/CreateSiteRequest.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestHubSiteSettings](docs/CreateSiteRequestHubSiteSettings.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestLeasePeriodSettings](docs/CreateSiteRequestLeasePeriodSettings.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestMultiGeoLocation](docs/CreateSiteRequestMultiGeoLocation.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestPrimaryAdmin](docs/CreateSiteRequestPrimaryAdmin.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestPrimaryContact](docs/CreateSiteRequestPrimaryContact.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestSecondaryContact](docs/CreateSiteRequestSecondaryContact.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestSiteDesign](docs/CreateSiteRequestSiteDesign.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestSiteUrl](docs/CreateSiteRequestSiteUrl.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequestYammerGroupSettings](docs/CreateSiteRequestYammerGroupSettings.md)
 - [Cloud.Governance.Client\Model.CreateSiteService](docs/CreateSiteService.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceDeploymentManagerPlanSettings](docs/CreateSiteServiceDeploymentManagerPlanSettings.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceLeasePeriodSettings](docs/CreateSiteServiceLeasePeriodSettings.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceMultiGeoSetting](docs/CreateSiteServiceMultiGeoSetting.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceRequestTemplate](docs/CreateSiteServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceSiteTitleSetting](docs/CreateSiteServiceSiteTitleSetting.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceSiteUrlSetting](docs/CreateSiteServiceSiteUrlSetting.md)
 - [Cloud.Governance.Client\Model.CreateSiteServiceYammerGroupSettings](docs/CreateSiteServiceYammerGroupSettings.md)
 - [Cloud.Governance.Client\Model.CreateTeamGallery](docs/CreateTeamGallery.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryCloneTeam](docs/CreateTeamGalleryCloneTeam.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryFunSetting](docs/CreateTeamGalleryFunSetting.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryGuestPermissionSetting](docs/CreateTeamGalleryGuestPermissionSetting.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryMemberPermissionSetting](docs/CreateTeamGalleryMemberPermissionSetting.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryMentionSetting](docs/CreateTeamGalleryMentionSetting.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryTeamId](docs/CreateTeamGalleryTeamId.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryTeamMessagingSettings](docs/CreateTeamGalleryTeamMessagingSettings.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryTeamSiteUrl](docs/CreateTeamGalleryTeamSiteUrl.md)
 - [Cloud.Governance.Client\Model.CreateTeamGalleryTeamTemplate](docs/CreateTeamGalleryTeamTemplate.md)
 - [Cloud.Governance.Client\Model.CreateWebRequest](docs/CreateWebRequest.md)
 - [Cloud.Governance.Client\Model.CreateWebRequestWebLanguage](docs/CreateWebRequestWebLanguage.md)
 - [Cloud.Governance.Client\Model.CreateWebRequestYammerGroupSettings](docs/CreateWebRequestYammerGroupSettings.md)
 - [Cloud.Governance.Client\Model.CreateWebScopeSettings](docs/CreateWebScopeSettings.md)
 - [Cloud.Governance.Client\Model.CreateWebService](docs/CreateWebService.md)
 - [Cloud.Governance.Client\Model.CreateWebServiceAppSettings](docs/CreateWebServiceAppSettings.md)
 - [Cloud.Governance.Client\Model.CreateWebServiceNotifyPrimaryContactSettings](docs/CreateWebServiceNotifyPrimaryContactSettings.md)
 - [Cloud.Governance.Client\Model.CreateWebServiceRequestTemplate](docs/CreateWebServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.CreateWebServiceScopeSettings](docs/CreateWebServiceScopeSettings.md)
 - [Cloud.Governance.Client\Model.CreateWebUrlValidationResult](docs/CreateWebUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.CreateWebValidationParameter](docs/CreateWebValidationParameter.md)
 - [Cloud.Governance.Client\Model.CustomActionSettings](docs/CustomActionSettings.md)
 - [Cloud.Governance.Client\Model.CustomActionSettingsBeforeApprovalProcessExecution](docs/CustomActionSettingsBeforeApprovalProcessExecution.md)
 - [Cloud.Governance.Client\Model.CustomExtensionPropertyModel](docs/CustomExtensionPropertyModel.md)
 - [Cloud.Governance.Client\Model.CustomMetadata](docs/CustomMetadata.md)
 - [Cloud.Governance.Client\Model.CustomMetadataAzureAdMetadataSettings](docs/CustomMetadataAzureAdMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataBooleanMetadataSettings](docs/CustomMetadataBooleanMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataChoiceMetadataSettings](docs/CustomMetadataChoiceMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataLinkMetadataSettings](docs/CustomMetadataLinkMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataNonAzureAdMetadataSettings](docs/CustomMetadataNonAzureAdMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataSharePointListMetadataSettings](docs/CustomMetadataSharePointListMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataSingleLineOrMultipleLineMetadataSettings](docs/CustomMetadataSingleLineOrMultipleLineMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataTermsMetadataSettings](docs/CustomMetadataTermsMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataUserMetadataSettings](docs/CustomMetadataUserMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomMetadataUserProfileMetadataSettings](docs/CustomMetadataUserProfileMetadataSettings.md)
 - [Cloud.Governance.Client\Model.CustomSiteTemplate](docs/CustomSiteTemplate.md)
 - [Cloud.Governance.Client\Model.DRPermissionSetting](docs/DRPermissionSetting.md)
 - [Cloud.Governance.Client\Model.DRSiteTemplate](docs/DRSiteTemplate.md)
 - [Cloud.Governance.Client\Model.DRSiteUrlSetting](docs/DRSiteUrlSetting.md)
 - [Cloud.Governance.Client\Model.DelegatedAccessToken](docs/DelegatedAccessToken.md)
 - [Cloud.Governance.Client\Model.DelegatedAccessTokenApiResult](docs/DelegatedAccessTokenApiResult.md)
 - [Cloud.Governance.Client\Model.DelegatedAccessTokenApiResultValue](docs/DelegatedAccessTokenApiResultValue.md)
 - [Cloud.Governance.Client\Model.DeleteGroupRequest](docs/DeleteGroupRequest.md)
 - [Cloud.Governance.Client\Model.DeleteSiteRequest](docs/DeleteSiteRequest.md)
 - [Cloud.Governance.Client\Model.DeleteType](docs/DeleteType.md)
 - [Cloud.Governance.Client\Model.DeleteWebLifecycleRequest](docs/DeleteWebLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.DeleteWorkspaceParameter](docs/DeleteWorkspaceParameter.md)
 - [Cloud.Governance.Client\Model.DeliveryManagement](docs/DeliveryManagement.md)
 - [Cloud.Governance.Client\Model.DeliveryStatusNotificationsRequestModel](docs/DeliveryStatusNotificationsRequestModel.md)
 - [Cloud.Governance.Client\Model.DeploymentManagerPlanSettings](docs/DeploymentManagerPlanSettings.md)
 - [Cloud.Governance.Client\Model.DepthLimitSetting](docs/DepthLimitSetting.md)
 - [Cloud.Governance.Client\Model.DirectorySyncState](docs/DirectorySyncState.md)
 - [Cloud.Governance.Client\Model.DisplayInReportType](docs/DisplayInReportType.md)
 - [Cloud.Governance.Client\Model.DistinctResult](docs/DistinctResult.md)
 - [Cloud.Governance.Client\Model.DpmPlanSetting](docs/DpmPlanSetting.md)
 - [Cloud.Governance.Client\Model.DpmServiceSetting](docs/DpmServiceSetting.md)
 - [Cloud.Governance.Client\Model.DueDateType](docs/DueDateType.md)
 - [Cloud.Governance.Client\Model.DurationDateType](docs/DurationDateType.md)
 - [Cloud.Governance.Client\Model.DynamicChangeContactGalleryRequestModel](docs/DynamicChangeContactGalleryRequestModel.md)
 - [Cloud.Governance.Client\Model.DynamicChangeContactGalleryRequestModelChangeContactInfo](docs/DynamicChangeContactGalleryRequestModelChangeContactInfo.md)
 - [Cloud.Governance.Client\Model.DynamicChangeContactGalleryRequestModelObjectInfo](docs/DynamicChangeContactGalleryRequestModelObjectInfo.md)
 - [Cloud.Governance.Client\Model.DynamicChangeContactModel](docs/DynamicChangeContactModel.md)
 - [Cloud.Governance.Client\Model.DynamicExchangeResource](docs/DynamicExchangeResource.md)
 - [Cloud.Governance.Client\Model.DynamicGroupRule](docs/DynamicGroupRule.md)
 - [Cloud.Governance.Client\Model.DynamicGroupRuleInfo](docs/DynamicGroupRuleInfo.md)
 - [Cloud.Governance.Client\Model.DynamicGroupRuleModel](docs/DynamicGroupRuleModel.md)
 - [Cloud.Governance.Client\Model.DynamicMembership](docs/DynamicMembership.md)
 - [Cloud.Governance.Client\Model.DynamicRequest](docs/DynamicRequest.md)
 - [Cloud.Governance.Client\Model.DynamicRequestApproveProcess](docs/DynamicRequestApproveProcess.md)
 - [Cloud.Governance.Client\Model.DynamicRequestTemplateModel](docs/DynamicRequestTemplateModel.md)
 - [Cloud.Governance.Client\Model.DynamicRuleCondition](docs/DynamicRuleCondition.md)
 - [Cloud.Governance.Client\Model.DynamicRuleConditionType](docs/DynamicRuleConditionType.md)
 - [Cloud.Governance.Client\Model.DynamicRuleElement](docs/DynamicRuleElement.md)
 - [Cloud.Governance.Client\Model.DynamicServiceForRequest](docs/DynamicServiceForRequest.md)
 - [Cloud.Governance.Client\Model.ElectionContact](docs/ElectionContact.md)
 - [Cloud.Governance.Client\Model.ElectionHookMessage](docs/ElectionHookMessage.md)
 - [Cloud.Governance.Client\Model.ElectionHookMessageNewPrimaryContact](docs/ElectionHookMessageNewPrimaryContact.md)
 - [Cloud.Governance.Client\Model.ElectionHookMessageNewSecondaryContact](docs/ElectionHookMessageNewSecondaryContact.md)
 - [Cloud.Governance.Client\Model.ElectionHookMessageOriginalPrimaryContact](docs/ElectionHookMessageOriginalPrimaryContact.md)
 - [Cloud.Governance.Client\Model.ElectionHookMessageOriginalSecondaryContact](docs/ElectionHookMessageOriginalSecondaryContact.md)
 - [Cloud.Governance.Client\Model.EmailAddress](docs/EmailAddress.md)
 - [Cloud.Governance.Client\Model.EmailForward](docs/EmailForward.md)
 - [Cloud.Governance.Client\Model.EndUserReportMetadata](docs/EndUserReportMetadata.md)
 - [Cloud.Governance.Client\Model.EnpowerContactStatus](docs/EnpowerContactStatus.md)
 - [Cloud.Governance.Client\Model.EntraGroupLifecycleActionType](docs/EntraGroupLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.ExchangeResourceLifecycleGallery](docs/ExchangeResourceLifecycleGallery.md)
 - [Cloud.Governance.Client\Model.ExchangeResourceLifecycleGalleryGroupInfo](docs/ExchangeResourceLifecycleGalleryGroupInfo.md)
 - [Cloud.Governance.Client\Model.ExchangeResourceLifecycleGalleryLifecycleActions](docs/ExchangeResourceLifecycleGalleryLifecycleActions.md)
 - [Cloud.Governance.Client\Model.ExchangeResourceLifecycleGalleryLifecycleScopeSetting](docs/ExchangeResourceLifecycleGalleryLifecycleScopeSetting.md)
 - [Cloud.Governance.Client\Model.ExchangeResourceStatus](docs/ExchangeResourceStatus.md)
 - [Cloud.Governance.Client\Model.ExchangeResourceType](docs/ExchangeResourceType.md)
 - [Cloud.Governance.Client\Model.ExecutionModel](docs/ExecutionModel.md)
 - [Cloud.Governance.Client\Model.ExecutionParameter](docs/ExecutionParameter.md)
 - [Cloud.Governance.Client\Model.ExpirationType](docs/ExpirationType.md)
 - [Cloud.Governance.Client\Model.ExtendGroupRequest](docs/ExtendGroupRequest.md)
 - [Cloud.Governance.Client\Model.ExtendGroupResult](docs/ExtendGroupResult.md)
 - [Cloud.Governance.Client\Model.ExtendSiteRequest](docs/ExtendSiteRequest.md)
 - [Cloud.Governance.Client\Model.ExtendSiteSetting](docs/ExtendSiteSetting.md)
 - [Cloud.Governance.Client\Model.ExtendType](docs/ExtendType.md)
 - [Cloud.Governance.Client\Model.ExternalDomainListType](docs/ExternalDomainListType.md)
 - [Cloud.Governance.Client\Model.ExternalSharingOptions](docs/ExternalSharingOptions.md)
 - [Cloud.Governance.Client\Model.ExternalSharingProfile](docs/ExternalSharingProfile.md)
 - [Cloud.Governance.Client\Model.ExternalUserSharingSettings](docs/ExternalUserSharingSettings.md)
 - [Cloud.Governance.Client\Model.ExternalUserSharingSettingsAnonymousLinkSettings](docs/ExternalUserSharingSettingsAnonymousLinkSettings.md)
 - [Cloud.Governance.Client\Model.ExternalUserSharingType](docs/ExternalUserSharingType.md)
 - [Cloud.Governance.Client\Model.ExternalUserState](docs/ExternalUserState.md)
 - [Cloud.Governance.Client\Model.ExternalUserType](docs/ExternalUserType.md)
 - [Cloud.Governance.Client\Model.FolderDefaultValueSetting](docs/FolderDefaultValueSetting.md)
 - [Cloud.Governance.Client\Model.GallerySetting](docs/GallerySetting.md)
 - [Cloud.Governance.Client\Model.Gallerybase](docs/Gallerybase.md)
 - [Cloud.Governance.Client\Model.GeoLocationBase](docs/GeoLocationBase.md)
 - [Cloud.Governance.Client\Model.GeoLocationModel](docs/GeoLocationModel.md)
 - [Cloud.Governance.Client\Model.GetDynamicMembershipRuleItems200Response](docs/GetDynamicMembershipRuleItems200Response.md)
 - [Cloud.Governance.Client\Model.GiphyRatingType](docs/GiphyRatingType.md)
 - [Cloud.Governance.Client\Model.GlobalAddressList](docs/GlobalAddressList.md)
 - [Cloud.Governance.Client\Model.GovernancePanel](docs/GovernancePanel.md)
 - [Cloud.Governance.Client\Model.GrantPermissionGroup](docs/GrantPermissionGroup.md)
 - [Cloud.Governance.Client\Model.GrantPermissionModel](docs/GrantPermissionModel.md)
 - [Cloud.Governance.Client\Model.GrantPermissionModelPermissionDurationSettings](docs/GrantPermissionModelPermissionDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionModelWelcomeEmailSettings](docs/GrantPermissionModelWelcomeEmailSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequest](docs/GrantPermissionRequest.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestDurationSettings](docs/GrantPermissionRequestDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestExternalUserSharingSettings](docs/GrantPermissionRequestExternalUserSharingSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestPermissionDurationSettings](docs/GrantPermissionRequestPermissionDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestPermissionSettings](docs/GrantPermissionRequestPermissionSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestPermissionSettingsSelectedSPGroup](docs/GrantPermissionRequestPermissionSettingsSelectedSPGroup.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestUrl](docs/GrantPermissionRequestUrl.md)
 - [Cloud.Governance.Client\Model.GrantPermissionSPObject](docs/GrantPermissionSPObject.md)
 - [Cloud.Governance.Client\Model.GrantPermissionService](docs/GrantPermissionService.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServiceDurationSettings](docs/GrantPermissionServiceDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServicePermissionDurationSettings](docs/GrantPermissionServicePermissionDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServicePermissionSettings](docs/GrantPermissionServicePermissionSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServiceRequestTemplate](docs/GrantPermissionServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServiceUserLevelControlSettings](docs/GrantPermissionServiceUserLevelControlSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionUrlValidationResult](docs/GrantPermissionUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.GroupClassificationModel](docs/GroupClassificationModel.md)
 - [Cloud.Governance.Client\Model.GroupConstructureRule](docs/GroupConstructureRule.md)
 - [Cloud.Governance.Client\Model.GroupEnableSharingStatus](docs/GroupEnableSharingStatus.md)
 - [Cloud.Governance.Client\Model.GroupIdConstructureSettings](docs/GroupIdConstructureSettings.md)
 - [Cloud.Governance.Client\Model.GroupIdRuleType](docs/GroupIdRuleType.md)
 - [Cloud.Governance.Client\Model.GroupInOutRuleType](docs/GroupInOutRuleType.md)
 - [Cloud.Governance.Client\Model.GroupLeasePeriodSettings](docs/GroupLeasePeriodSettings.md)
 - [Cloud.Governance.Client\Model.GroupLeasePeriodType](docs/GroupLeasePeriodType.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleActionType](docs/GroupLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleRequest](docs/GroupLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleService](docs/GroupLifecycleService.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleServiceRequestTemplate](docs/GroupLifecycleServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleValidateResult](docs/GroupLifecycleValidateResult.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleValidateResultChangePolicySetting](docs/GroupLifecycleValidateResultChangePolicySetting.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleValidateResultChangeQuotaSetting](docs/GroupLifecycleValidateResultChangeQuotaSetting.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleValidateResultExtendSetting](docs/GroupLifecycleValidateResultExtendSetting.md)
 - [Cloud.Governance.Client\Model.GroupLinks](docs/GroupLinks.md)
 - [Cloud.Governance.Client\Model.GroupMembershipAction](docs/GroupMembershipAction.md)
 - [Cloud.Governance.Client\Model.GroupMembershipItem](docs/GroupMembershipItem.md)
 - [Cloud.Governance.Client\Model.GroupNameConstructureSettings](docs/GroupNameConstructureSettings.md)
 - [Cloud.Governance.Client\Model.GroupObjectType](docs/GroupObjectType.md)
 - [Cloud.Governance.Client\Model.GroupOwnerType](docs/GroupOwnerType.md)
 - [Cloud.Governance.Client\Model.GroupPolicySubType](docs/GroupPolicySubType.md)
 - [Cloud.Governance.Client\Model.GroupRestrictionType](docs/GroupRestrictionType.md)
 - [Cloud.Governance.Client\Model.GroupScopeType](docs/GroupScopeType.md)
 - [Cloud.Governance.Client\Model.GroupSettingModel](docs/GroupSettingModel.md)
 - [Cloud.Governance.Client\Model.GroupStatus](docs/GroupStatus.md)
 - [Cloud.Governance.Client\Model.GroupTeamPicture](docs/GroupTeamPicture.md)
 - [Cloud.Governance.Client\Model.GroupUser](docs/GroupUser.md)
 - [Cloud.Governance.Client\Model.GroupValidationParameter](docs/GroupValidationParameter.md)
 - [Cloud.Governance.Client\Model.GuestPermissions](docs/GuestPermissions.md)
 - [Cloud.Governance.Client\Model.GuestUserGridModel](docs/GuestUserGridModel.md)
 - [Cloud.Governance.Client\Model.GuestUserGridModelPageResult](docs/GuestUserGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.GuestUserPropertyModel](docs/GuestUserPropertyModel.md)
 - [Cloud.Governance.Client\Model.GuestUserRequestOneTimeRenewalSettingModel](docs/GuestUserRequestOneTimeRenewalSettingModel.md)
 - [Cloud.Governance.Client\Model.GuestUserStatus](docs/GuestUserStatus.md)
 - [Cloud.Governance.Client\Model.GuidBooleanModel](docs/GuidBooleanModel.md)
 - [Cloud.Governance.Client\Model.GuidModel](docs/GuidModel.md)
 - [Cloud.Governance.Client\Model.HandleOngoingType](docs/HandleOngoingType.md)
 - [Cloud.Governance.Client\Model.HandleTaskType](docs/HandleTaskType.md)
 - [Cloud.Governance.Client\Model.HookMessageList](docs/HookMessageList.md)
 - [Cloud.Governance.Client\Model.HookMessageListAutoImportCompleted](docs/HookMessageListAutoImportCompleted.md)
 - [Cloud.Governance.Client\Model.HookMessageListElectionHookMessage](docs/HookMessageListElectionHookMessage.md)
 - [Cloud.Governance.Client\Model.HookMessageListLifecycleHookMessage](docs/HookMessageListLifecycleHookMessage.md)
 - [Cloud.Governance.Client\Model.HookMessageListRenewalTaskCompleted](docs/HookMessageListRenewalTaskCompleted.md)
 - [Cloud.Governance.Client\Model.HookMessageListRequestsRelated](docs/HookMessageListRequestsRelated.md)
 - [Cloud.Governance.Client\Model.HookMessageListTaskCreated](docs/HookMessageListTaskCreated.md)
 - [Cloud.Governance.Client\Model.HookMessageObjectType](docs/HookMessageObjectType.md)
 - [Cloud.Governance.Client\Model.HubSiteChangedSettings](docs/HubSiteChangedSettings.md)
 - [Cloud.Governance.Client\Model.HubSiteSetting](docs/HubSiteSetting.md)
 - [Cloud.Governance.Client\Model.HubSiteSettingAssociateToHubSite](docs/HubSiteSettingAssociateToHubSite.md)
 - [Cloud.Governance.Client\Model.HubSiteSettingRegisterAsHubSite](docs/HubSiteSettingRegisterAsHubSite.md)
 - [Cloud.Governance.Client\Model.HubSiteSettings](docs/HubSiteSettings.md)
 - [Cloud.Governance.Client\Model.HubSiteType](docs/HubSiteType.md)
 - [Cloud.Governance.Client\Model.HubSiteUrl](docs/HubSiteUrl.md)
 - [Cloud.Governance.Client\Model.ImportEnvironmentModel](docs/ImportEnvironmentModel.md)
 - [Cloud.Governance.Client\Model.ImportGroupModel](docs/ImportGroupModel.md)
 - [Cloud.Governance.Client\Model.ImportMetadataModel](docs/ImportMetadataModel.md)
 - [Cloud.Governance.Client\Model.ImportObjectType](docs/ImportObjectType.md)
 - [Cloud.Governance.Client\Model.ImportSharedMailboxModel](docs/ImportSharedMailboxModel.md)
 - [Cloud.Governance.Client\Model.ImportSiteModel](docs/ImportSiteModel.md)
 - [Cloud.Governance.Client\Model.ImportTeamModel](docs/ImportTeamModel.md)
 - [Cloud.Governance.Client\Model.InformationIconSetting](docs/InformationIconSetting.md)
 - [Cloud.Governance.Client\Model.InsightsStatus](docs/InsightsStatus.md)
 - [Cloud.Governance.Client\Model.Int32ChangedValueRequestModel](docs/Int32ChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.Int64ChangedProperty](docs/Int64ChangedProperty.md)
 - [Cloud.Governance.Client\Model.Int64ChangedValueRequestModel](docs/Int64ChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.IntModel](docs/IntModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestAddToGroupsRequestModel](docs/InviteGuestAddToGroupsRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestContactInformationRequestModel](docs/InviteGuestContactInformationRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestGallery](docs/InviteGuestGallery.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryAddToGroups](docs/InviteGuestGalleryAddToGroups.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryContactInformation](docs/InviteGuestGalleryContactInformation.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryEmailAddress](docs/InviteGuestGalleryEmailAddress.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryInviteGuestUserScope](docs/InviteGuestGalleryInviteGuestUserScope.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryLimitDomains](docs/InviteGuestGalleryLimitDomains.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryManager](docs/InviteGuestGalleryManager.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryMultipleInvite](docs/InviteGuestGalleryMultipleInvite.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryRenewalProfile](docs/InviteGuestGalleryRenewalProfile.md)
 - [Cloud.Governance.Client\Model.InviteGuestGalleryUsageLocation](docs/InviteGuestGalleryUsageLocation.md)
 - [Cloud.Governance.Client\Model.InviteGuestMode](docs/InviteGuestMode.md)
 - [Cloud.Governance.Client\Model.InviteGuestOneTimeRenewalSettingModel](docs/InviteGuestOneTimeRenewalSettingModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestRenewalProfileRequestModel](docs/InviteGuestRenewalProfileRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestRenewalProfileRequestModelOneTimeRenewalSetting](docs/InviteGuestRenewalProfileRequestModelOneTimeRenewalSetting.md)
 - [Cloud.Governance.Client\Model.InviteGuestScopeRequestModel](docs/InviteGuestScopeRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestUsageLocationRequestModel](docs/InviteGuestUsageLocationRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestUserPropertyRequestModel](docs/InviteGuestUserPropertyRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteGuestUserTypePropertyRequestModel](docs/InviteGuestUserTypePropertyRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteMultipleGuestRequestModel](docs/InviteMultipleGuestRequestModel.md)
 - [Cloud.Governance.Client\Model.InviteType](docs/InviteType.md)
 - [Cloud.Governance.Client\Model.ItemConflictResolutionType](docs/ItemConflictResolutionType.md)
 - [Cloud.Governance.Client\Model.JobMode](docs/JobMode.md)
 - [Cloud.Governance.Client\Model.JobMonitorGridModel](docs/JobMonitorGridModel.md)
 - [Cloud.Governance.Client\Model.JobMonitorGridModelPageResult](docs/JobMonitorGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.JobMonitorModel](docs/JobMonitorModel.md)
 - [Cloud.Governance.Client\Model.JobStatus](docs/JobStatus.md)
 - [Cloud.Governance.Client\Model.JobType](docs/JobType.md)
 - [Cloud.Governance.Client\Model.JoinGroupApproval](docs/JoinGroupApproval.md)
 - [Cloud.Governance.Client\Model.LanguageWithTemplates](docs/LanguageWithTemplates.md)
 - [Cloud.Governance.Client\Model.LeaseDateType](docs/LeaseDateType.md)
 - [Cloud.Governance.Client\Model.LeaseStartDateType](docs/LeaseStartDateType.md)
 - [Cloud.Governance.Client\Model.LibraryDesign](docs/LibraryDesign.md)
 - [Cloud.Governance.Client\Model.LibraryRecordDeclaration](docs/LibraryRecordDeclaration.md)
 - [Cloud.Governance.Client\Model.LibraryScope](docs/LibraryScope.md)
 - [Cloud.Governance.Client\Model.LibraryVersionSetting](docs/LibraryVersionSetting.md)
 - [Cloud.Governance.Client\Model.LicenseInfo](docs/LicenseInfo.md)
 - [Cloud.Governance.Client\Model.LicenseUpdateInfo](docs/LicenseUpdateInfo.md)
 - [Cloud.Governance.Client\Model.LifecycleAction](docs/LifecycleAction.md)
 - [Cloud.Governance.Client\Model.LifecycleActions](docs/LifecycleActions.md)
 - [Cloud.Governance.Client\Model.LifecycleHookMessage](docs/LifecycleHookMessage.md)
 - [Cloud.Governance.Client\Model.LifecycleJobTimeBaseType](docs/LifecycleJobTimeBaseType.md)
 - [Cloud.Governance.Client\Model.LifecycleRenewalSetting](docs/LifecycleRenewalSetting.md)
 - [Cloud.Governance.Client\Model.LifecycleSCModel](docs/LifecycleSCModel.md)
 - [Cloud.Governance.Client\Model.LifecycleScopeSetting](docs/LifecycleScopeSetting.md)
 - [Cloud.Governance.Client\Model.LifecycleScopeSettingGallery](docs/LifecycleScopeSettingGallery.md)
 - [Cloud.Governance.Client\Model.LifecycleScopeSettingOffice365Tenant](docs/LifecycleScopeSettingOffice365Tenant.md)
 - [Cloud.Governance.Client\Model.LifecycleTeamModel](docs/LifecycleTeamModel.md)
 - [Cloud.Governance.Client\Model.LinkMetadataSettings](docs/LinkMetadataSettings.md)
 - [Cloud.Governance.Client\Model.LinkPermissionType](docs/LinkPermissionType.md)
 - [Cloud.Governance.Client\Model.LinkPermissionTypeChangedValueRequestModel](docs/LinkPermissionTypeChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.LinkValue](docs/LinkValue.md)
 - [Cloud.Governance.Client\Model.ListColumnDefaultValue](docs/ListColumnDefaultValue.md)
 - [Cloud.Governance.Client\Model.ListPermissionSetting](docs/ListPermissionSetting.md)
 - [Cloud.Governance.Client\Model.ListPermissionSettings](docs/ListPermissionSettings.md)
 - [Cloud.Governance.Client\Model.ListTemplate](docs/ListTemplate.md)
 - [Cloud.Governance.Client\Model.ListTemplateSettings](docs/ListTemplateSettings.md)
 - [Cloud.Governance.Client\Model.ListType](docs/ListType.md)
 - [Cloud.Governance.Client\Model.ListValidationParameter](docs/ListValidationParameter.md)
 - [Cloud.Governance.Client\Model.ListVersionSettings](docs/ListVersionSettings.md)
 - [Cloud.Governance.Client\Model.ListVersionSettingsChangedProperty](docs/ListVersionSettingsChangedProperty.md)
 - [Cloud.Governance.Client\Model.LocaleSettings](docs/LocaleSettings.md)
 - [Cloud.Governance.Client\Model.LocalizedMetadataTermsAndConditionsModel](docs/LocalizedMetadataTermsAndConditionsModel.md)
 - [Cloud.Governance.Client\Model.LockSiteCollectionType](docs/LockSiteCollectionType.md)
 - [Cloud.Governance.Client\Model.LockSiteParameter](docs/LockSiteParameter.md)
 - [Cloud.Governance.Client\Model.LockSiteRequest](docs/LockSiteRequest.md)
 - [Cloud.Governance.Client\Model.LockSiteSetting](docs/LockSiteSetting.md)
 - [Cloud.Governance.Client\Model.LockedBy](docs/LockedBy.md)
 - [Cloud.Governance.Client\Model.LogicalOperator](docs/LogicalOperator.md)
 - [Cloud.Governance.Client\Model.LogicalOperatorType](docs/LogicalOperatorType.md)
 - [Cloud.Governance.Client\Model.LookupListValue](docs/LookupListValue.md)
 - [Cloud.Governance.Client\Model.LookupValue](docs/LookupValue.md)
 - [Cloud.Governance.Client\Model.LookupValueTargetUser](docs/LookupValueTargetUser.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleActionType](docs/M365GroupLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleActions](docs/M365GroupLifecycleActions.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleGallery](docs/M365GroupLifecycleGallery.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleGalleryM365GroupInfo](docs/M365GroupLifecycleGalleryM365GroupInfo.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleGalleryM365GroupLifecycleActions](docs/M365GroupLifecycleGalleryM365GroupLifecycleActions.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleGalleryM365GroupLifecycleScopeSetting](docs/M365GroupLifecycleGalleryM365GroupLifecycleScopeSetting.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleModel](docs/M365GroupLifecycleModel.md)
 - [Cloud.Governance.Client\Model.M365GroupLifecycleScopeSetting](docs/M365GroupLifecycleScopeSetting.md)
 - [Cloud.Governance.Client\Model.MailboxAutoMapping](docs/MailboxAutoMapping.md)
 - [Cloud.Governance.Client\Model.MailboxAutomaticReply](docs/MailboxAutomaticReply.md)
 - [Cloud.Governance.Client\Model.MailboxLanguageDataTime](docs/MailboxLanguageDataTime.md)
 - [Cloud.Governance.Client\Model.MailboxSentItems](docs/MailboxSentItems.md)
 - [Cloud.Governance.Client\Model.MailboxSharedMailboxPolicy](docs/MailboxSharedMailboxPolicy.md)
 - [Cloud.Governance.Client\Model.ManagePermissionAction](docs/ManagePermissionAction.md)
 - [Cloud.Governance.Client\Model.ManagePermissionGrantSetting](docs/ManagePermissionGrantSetting.md)
 - [Cloud.Governance.Client\Model.ManagePermissionOption](docs/ManagePermissionOption.md)
 - [Cloud.Governance.Client\Model.ManagePermissionOptionGrantPermissionSetting](docs/ManagePermissionOptionGrantPermissionSetting.md)
 - [Cloud.Governance.Client\Model.ManagePermissionRequest](docs/ManagePermissionRequest.md)
 - [Cloud.Governance.Client\Model.ManagePermissionRequestPermissionManagement](docs/ManagePermissionRequestPermissionManagement.md)
 - [Cloud.Governance.Client\Model.ManagePermissionSPObject](docs/ManagePermissionSPObject.md)
 - [Cloud.Governance.Client\Model.ManagePermissionService](docs/ManagePermissionService.md)
 - [Cloud.Governance.Client\Model.ManagePermissionServicePermissionOptions](docs/ManagePermissionServicePermissionOptions.md)
 - [Cloud.Governance.Client\Model.ManagePermissionServiceRequestTemplate](docs/ManagePermissionServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.ManagePermissionServiceSharePointGroupOptions](docs/ManagePermissionServiceSharePointGroupOptions.md)
 - [Cloud.Governance.Client\Model.ManagePermissionServiceUserScopeSetting](docs/ManagePermissionServiceUserScopeSetting.md)
 - [Cloud.Governance.Client\Model.ManagePermissionSharePointGroupOption](docs/ManagePermissionSharePointGroupOption.md)
 - [Cloud.Governance.Client\Model.ManagePermissionUserSetting](docs/ManagePermissionUserSetting.md)
 - [Cloud.Governance.Client\Model.ManagePermissionValidateResult](docs/ManagePermissionValidateResult.md)
 - [Cloud.Governance.Client\Model.ManagePermissionValidateResultObject](docs/ManagePermissionValidateResultObject.md)
 - [Cloud.Governance.Client\Model.ManualImportAdGroupJobModel](docs/ManualImportAdGroupJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportEnvironmentJobModel](docs/ManualImportEnvironmentJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportGroupJobModel](docs/ManualImportGroupJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportPowerAppsJobModel](docs/ManualImportPowerAppsJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportPowerAutomateJobModel](docs/ManualImportPowerAutomateJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportPowerBIJobModel](docs/ManualImportPowerBIJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportSharedMailboxJobModel](docs/ManualImportSharedMailboxJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportSiteJobModel](docs/ManualImportSiteJobModel.md)
 - [Cloud.Governance.Client\Model.ManualImportTeamJobModel](docs/ManualImportTeamJobModel.md)
 - [Cloud.Governance.Client\Model.ManuallyInputUrlSetting](docs/ManuallyInputUrlSetting.md)
 - [Cloud.Governance.Client\Model.MembershipApproval](docs/MembershipApproval.md)
 - [Cloud.Governance.Client\Model.MembershipUserType](docs/MembershipUserType.md)
 - [Cloud.Governance.Client\Model.MessageApproval](docs/MessageApproval.md)
 - [Cloud.Governance.Client\Model.MessageCode](docs/MessageCode.md)
 - [Cloud.Governance.Client\Model.MetadataActionType](docs/MetadataActionType.md)
 - [Cloud.Governance.Client\Model.MetadataDisplayType](docs/MetadataDisplayType.md)
 - [Cloud.Governance.Client\Model.MetadataFieldType](docs/MetadataFieldType.md)
 - [Cloud.Governance.Client\Model.MultiGeoControlMode](docs/MultiGeoControlMode.md)
 - [Cloud.Governance.Client\Model.MultiGeoLocationSetting](docs/MultiGeoLocationSetting.md)
 - [Cloud.Governance.Client\Model.MultiGeoSerivceSetting](docs/MultiGeoSerivceSetting.md)
 - [Cloud.Governance.Client\Model.MultiGeoSerivceSettingDefaultLocation](docs/MultiGeoSerivceSettingDefaultLocation.md)
 - [Cloud.Governance.Client\Model.MultiGeoSetting](docs/MultiGeoSetting.md)
 - [Cloud.Governance.Client\Model.MyExchangeResource](docs/MyExchangeResource.md)
 - [Cloud.Governance.Client\Model.MyResourceMailbox](docs/MyResourceMailbox.md)
 - [Cloud.Governance.Client\Model.MySharedMailbox](docs/MySharedMailbox.md)
 - [Cloud.Governance.Client\Model.MySite](docs/MySite.md)
 - [Cloud.Governance.Client\Model.MySiteType](docs/MySiteType.md)
 - [Cloud.Governance.Client\Model.NameDescription](docs/NameDescription.md)
 - [Cloud.Governance.Client\Model.NavigationSetting](docs/NavigationSetting.md)
 - [Cloud.Governance.Client\Model.NodeType](docs/NodeType.md)
 - [Cloud.Governance.Client\Model.NonAzureAdMetadataSettings](docs/NonAzureAdMetadataSettings.md)
 - [Cloud.Governance.Client\Model.NotifyOpusForNewFilesRequestModel](docs/NotifyOpusForNewFilesRequestModel.md)
 - [Cloud.Governance.Client\Model.ObjectPermissionManagementModel](docs/ObjectPermissionManagementModel.md)
 - [Cloud.Governance.Client\Model.ObjectPermissionManagementModelGrantPermissionSetting](docs/ObjectPermissionManagementModelGrantPermissionSetting.md)
 - [Cloud.Governance.Client\Model.ObjectValidateResult](docs/ObjectValidateResult.md)
 - [Cloud.Governance.Client\Model.Office365SiteSettingModel](docs/Office365SiteSettingModel.md)
 - [Cloud.Governance.Client\Model.Office365Tenant](docs/Office365Tenant.md)
 - [Cloud.Governance.Client\Model.OfficeTenant](docs/OfficeTenant.md)
 - [Cloud.Governance.Client\Model.OldMetadataGridModel](docs/OldMetadataGridModel.md)
 - [Cloud.Governance.Client\Model.OldMetadataGridModelPageResult](docs/OldMetadataGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.OneTimeRenewalOption](docs/OneTimeRenewalOption.md)
 - [Cloud.Governance.Client\Model.OutlookExperience](docs/OutlookExperience.md)
 - [Cloud.Governance.Client\Model.OutsideSenders](docs/OutsideSenders.md)
 - [Cloud.Governance.Client\Model.PermissionChangedType](docs/PermissionChangedType.md)
 - [Cloud.Governance.Client\Model.PermissionLevel](docs/PermissionLevel.md)
 - [Cloud.Governance.Client\Model.PermissionManagementModel](docs/PermissionManagementModel.md)
 - [Cloud.Governance.Client\Model.PermissionObjectProperty](docs/PermissionObjectProperty.md)
 - [Cloud.Governance.Client\Model.PermissionSettings](docs/PermissionSettings.md)
 - [Cloud.Governance.Client\Model.PersonalSettings](docs/PersonalSettings.md)
 - [Cloud.Governance.Client\Model.PersonalSettingsProperties](docs/PersonalSettingsProperties.md)
 - [Cloud.Governance.Client\Model.PersonalSettingsPropertyInfo](docs/PersonalSettingsPropertyInfo.md)
 - [Cloud.Governance.Client\Model.PnpTemplate](docs/PnpTemplate.md)
 - [Cloud.Governance.Client\Model.PolicyWithTemplates](docs/PolicyWithTemplates.md)
 - [Cloud.Governance.Client\Model.PredefinedOwnerOrMembers](docs/PredefinedOwnerOrMembers.md)
 - [Cloud.Governance.Client\Model.PrincipalType](docs/PrincipalType.md)
 - [Cloud.Governance.Client\Model.Privacy](docs/Privacy.md)
 - [Cloud.Governance.Client\Model.QueryTemplateResultModel](docs/QueryTemplateResultModel.md)
 - [Cloud.Governance.Client\Model.QuestionAnswerResponse](docs/QuestionAnswerResponse.md)
 - [Cloud.Governance.Client\Model.QuotaProfile](docs/QuotaProfile.md)
 - [Cloud.Governance.Client\Model.RegisterAsHubSite](docs/RegisterAsHubSite.md)
 - [Cloud.Governance.Client\Model.RemoteNodeInfo](docs/RemoteNodeInfo.md)
 - [Cloud.Governance.Client\Model.RemoteNodeType](docs/RemoteNodeType.md)
 - [Cloud.Governance.Client\Model.RenewalProfile](docs/RenewalProfile.md)
 - [Cloud.Governance.Client\Model.RenewalTaskHookMessage](docs/RenewalTaskHookMessage.md)
 - [Cloud.Governance.Client\Model.ReportMetadata](docs/ReportMetadata.md)
 - [Cloud.Governance.Client\Model.RequestGroupWithPermissions](docs/RequestGroupWithPermissions.md)
 - [Cloud.Governance.Client\Model.RequestGroupWithPermissionsGroupOwner](docs/RequestGroupWithPermissionsGroupOwner.md)
 - [Cloud.Governance.Client\Model.RequestHookMessage](docs/RequestHookMessage.md)
 - [Cloud.Governance.Client\Model.RequestList](docs/RequestList.md)
 - [Cloud.Governance.Client\Model.RequestListPageResult](docs/RequestListPageResult.md)
 - [Cloud.Governance.Client\Model.RequestMetadata](docs/RequestMetadata.md)
 - [Cloud.Governance.Client\Model.RequestMetadataLinkValue](docs/RequestMetadataLinkValue.md)
 - [Cloud.Governance.Client\Model.RequestMetadataListChangedProperty](docs/RequestMetadataListChangedProperty.md)
 - [Cloud.Governance.Client\Model.RequestMetadataLookupListValue](docs/RequestMetadataLookupListValue.md)
 - [Cloud.Governance.Client\Model.RequestMetadataTermsValue](docs/RequestMetadataTermsValue.md)
 - [Cloud.Governance.Client\Model.RequestMetadataUpsOrAzureAdValue](docs/RequestMetadataUpsOrAzureAdValue.md)
 - [Cloud.Governance.Client\Model.RequestProgressStatus](docs/RequestProgressStatus.md)
 - [Cloud.Governance.Client\Model.RequestResourceType](docs/RequestResourceType.md)
 - [Cloud.Governance.Client\Model.RequestSensitivityLabel](docs/RequestSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.RequestStatus](docs/RequestStatus.md)
 - [Cloud.Governance.Client\Model.RequestTeamsSettings](docs/RequestTeamsSettings.md)
 - [Cloud.Governance.Client\Model.RequestUserWithPermissions](docs/RequestUserWithPermissions.md)
 - [Cloud.Governance.Client\Model.RequestUserWithPermissionsUser](docs/RequestUserWithPermissionsUser.md)
 - [Cloud.Governance.Client\Model.RestoreGroupRequest](docs/RestoreGroupRequest.md)
 - [Cloud.Governance.Client\Model.RootSiteWithManagedPaths](docs/RootSiteWithManagedPaths.md)
 - [Cloud.Governance.Client\Model.SASUriModel](docs/SASUriModel.md)
 - [Cloud.Governance.Client\Model.SCLifecycleActionModel](docs/SCLifecycleActionModel.md)
 - [Cloud.Governance.Client\Model.SCLifecycleActionType](docs/SCLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.SCLifecycleGallery](docs/SCLifecycleGallery.md)
 - [Cloud.Governance.Client\Model.SCLifecycleGalleryScInfo](docs/SCLifecycleGalleryScInfo.md)
 - [Cloud.Governance.Client\Model.SCLifecycleGalleryScLifecycleActionDetails](docs/SCLifecycleGalleryScLifecycleActionDetails.md)
 - [Cloud.Governance.Client\Model.SCLifecycleLockType](docs/SCLifecycleLockType.md)
 - [Cloud.Governance.Client\Model.SPBaseType](docs/SPBaseType.md)
 - [Cloud.Governance.Client\Model.SPGroup](docs/SPGroup.md)
 - [Cloud.Governance.Client\Model.SPGroupEditOption](docs/SPGroupEditOption.md)
 - [Cloud.Governance.Client\Model.SPGroupEditOptionType](docs/SPGroupEditOptionType.md)
 - [Cloud.Governance.Client\Model.SPGroupManagementModel](docs/SPGroupManagementModel.md)
 - [Cloud.Governance.Client\Model.SPGroupOwner](docs/SPGroupOwner.md)
 - [Cloud.Governance.Client\Model.SPGroupViewOption](docs/SPGroupViewOption.md)
 - [Cloud.Governance.Client\Model.SPGroupViewOptionType](docs/SPGroupViewOptionType.md)
 - [Cloud.Governance.Client\Model.SPList](docs/SPList.md)
 - [Cloud.Governance.Client\Model.SPListTemplateType](docs/SPListTemplateType.md)
 - [Cloud.Governance.Client\Model.SPNode](docs/SPNode.md)
 - [Cloud.Governance.Client\Model.SPPrincipal](docs/SPPrincipal.md)
 - [Cloud.Governance.Client\Model.SPPrincipalType](docs/SPPrincipalType.md)
 - [Cloud.Governance.Client\Model.SPRoleAssignment](docs/SPRoleAssignment.md)
 - [Cloud.Governance.Client\Model.SPTenantSharingSettingModel](docs/SPTenantSharingSettingModel.md)
 - [Cloud.Governance.Client\Model.SPUserManagementModel](docs/SPUserManagementModel.md)
 - [Cloud.Governance.Client\Model.ScopeType](docs/ScopeType.md)
 - [Cloud.Governance.Client\Model.SenderOptions](docs/SenderOptions.md)
 - [Cloud.Governance.Client\Model.SensitivityLabelModel](docs/SensitivityLabelModel.md)
 - [Cloud.Governance.Client\Model.ServiceForRequest](docs/ServiceForRequest.md)
 - [Cloud.Governance.Client\Model.ServiceGridModel](docs/ServiceGridModel.md)
 - [Cloud.Governance.Client\Model.ServiceGridModelPageResult](docs/ServiceGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.ServiceGroupWithPermissions](docs/ServiceGroupWithPermissions.md)
 - [Cloud.Governance.Client\Model.ServiceLanguageSetting](docs/ServiceLanguageSetting.md)
 - [Cloud.Governance.Client\Model.ServiceList](docs/ServiceList.md)
 - [Cloud.Governance.Client\Model.ServiceListPageResult](docs/ServiceListPageResult.md)
 - [Cloud.Governance.Client\Model.ServicePlanModel](docs/ServicePlanModel.md)
 - [Cloud.Governance.Client\Model.ServiceScopeSettings](docs/ServiceScopeSettings.md)
 - [Cloud.Governance.Client\Model.ServiceTeamsSettings](docs/ServiceTeamsSettings.md)
 - [Cloud.Governance.Client\Model.ServiceType](docs/ServiceType.md)
 - [Cloud.Governance.Client\Model.ServiceUserWithPermissions](docs/ServiceUserWithPermissions.md)
 - [Cloud.Governance.Client\Model.SharePointBuildInGroupType](docs/SharePointBuildInGroupType.md)
 - [Cloud.Governance.Client\Model.SharePointListMetadataSettings](docs/SharePointListMetadataSettings.md)
 - [Cloud.Governance.Client\Model.SharePointListMetadataSettingsValue](docs/SharePointListMetadataSettingsValue.md)
 - [Cloud.Governance.Client\Model.SharedChannelChangedMembership](docs/SharedChannelChangedMembership.md)
 - [Cloud.Governance.Client\Model.SharedChannelDescription](docs/SharedChannelDescription.md)
 - [Cloud.Governance.Client\Model.SharedChannelName](docs/SharedChannelName.md)
 - [Cloud.Governance.Client\Model.SharedMailboxBasicGridModel](docs/SharedMailboxBasicGridModel.md)
 - [Cloud.Governance.Client\Model.SharedMailboxBasicGridModelPageResult](docs/SharedMailboxBasicGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.SharedMailboxLifecycleGalleryRequestModel](docs/SharedMailboxLifecycleGalleryRequestModel.md)
 - [Cloud.Governance.Client\Model.SharingAdvanceSettingModel](docs/SharingAdvanceSettingModel.md)
 - [Cloud.Governance.Client\Model.SharingAdvanceSettingModelChangedValueRequestModel](docs/SharingAdvanceSettingModelChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.SharingAdvanceSettingModelChangedValueRequestModelNewValue](docs/SharingAdvanceSettingModelChangedValueRequestModelNewValue.md)
 - [Cloud.Governance.Client\Model.SharingCapabilities](docs/SharingCapabilities.md)
 - [Cloud.Governance.Client\Model.SharingCapabilitiesChangedValueRequestModel](docs/SharingCapabilitiesChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.SharingDomainRestrictionMode](docs/SharingDomainRestrictionMode.md)
 - [Cloud.Governance.Client\Model.SharingEnabledUser](docs/SharingEnabledUser.md)
 - [Cloud.Governance.Client\Model.SharingExpireSettingModel](docs/SharingExpireSettingModel.md)
 - [Cloud.Governance.Client\Model.SharingExpireSettingModelChangedValueRequestModel](docs/SharingExpireSettingModelChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.SharingExpireSettingModelChangedValueRequestModelNewValue](docs/SharingExpireSettingModelChangedValueRequestModelNewValue.md)
 - [Cloud.Governance.Client\Model.SharingLinkType](docs/SharingLinkType.md)
 - [Cloud.Governance.Client\Model.SharingLinkTypeChangedValueRequestModel](docs/SharingLinkTypeChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.ShowLinksInRequestDetailsPage](docs/ShowLinksInRequestDetailsPage.md)
 - [Cloud.Governance.Client\Model.SingleLineOrMultipleLineMetadataSettings](docs/SingleLineOrMultipleLineMetadataSettings.md)
 - [Cloud.Governance.Client\Model.SiteAdmins](docs/SiteAdmins.md)
 - [Cloud.Governance.Client\Model.SiteAlternateCssUrl](docs/SiteAlternateCssUrl.md)
 - [Cloud.Governance.Client\Model.SiteClassification](docs/SiteClassification.md)
 - [Cloud.Governance.Client\Model.SiteClassificationAndSensitivityLabel](docs/SiteClassificationAndSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.SiteClassificationAndSensitivityLabelClassification](docs/SiteClassificationAndSensitivityLabelClassification.md)
 - [Cloud.Governance.Client\Model.SiteClassificationAndSensitivityLabelSensitivityLabel](docs/SiteClassificationAndSensitivityLabelSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.SiteCloudGovernancePanel](docs/SiteCloudGovernancePanel.md)
 - [Cloud.Governance.Client\Model.SiteColumns](docs/SiteColumns.md)
 - [Cloud.Governance.Client\Model.SiteConstructTitleType](docs/SiteConstructTitleType.md)
 - [Cloud.Governance.Client\Model.SiteConstructUrlType](docs/SiteConstructUrlType.md)
 - [Cloud.Governance.Client\Model.SiteDesign](docs/SiteDesign.md)
 - [Cloud.Governance.Client\Model.SiteDesignModel](docs/SiteDesignModel.md)
 - [Cloud.Governance.Client\Model.SiteElectionProfile](docs/SiteElectionProfile.md)
 - [Cloud.Governance.Client\Model.SiteFeature](docs/SiteFeature.md)
 - [Cloud.Governance.Client\Model.SiteLanguage](docs/SiteLanguage.md)
 - [Cloud.Governance.Client\Model.SiteLeasePeriodRequestSettings](docs/SiteLeasePeriodRequestSettings.md)
 - [Cloud.Governance.Client\Model.SiteLeasePeriodServiceSettings](docs/SiteLeasePeriodServiceSettings.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleActionType](docs/SiteLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleRequest](docs/SiteLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleService](docs/SiteLifecycleService.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleServiceChangePolicySetting](docs/SiteLifecycleServiceChangePolicySetting.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleServiceRequestTemplate](docs/SiteLifecycleServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResult](docs/SiteLifecycleValidateResult.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResultChangePolicySetting](docs/SiteLifecycleValidateResultChangePolicySetting.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResultChangeQuotaSetting](docs/SiteLifecycleValidateResultChangeQuotaSetting.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResultExtendSetting](docs/SiteLifecycleValidateResultExtendSetting.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResultLockSetting](docs/SiteLifecycleValidateResultLockSetting.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResultUnlockSetting](docs/SiteLifecycleValidateResultUnlockSetting.md)
 - [Cloud.Governance.Client\Model.SiteLockType](docs/SiteLockType.md)
 - [Cloud.Governance.Client\Model.SitePicture](docs/SitePicture.md)
 - [Cloud.Governance.Client\Model.SitePolicyRef](docs/SitePolicyRef.md)
 - [Cloud.Governance.Client\Model.SiteSensitivityLabel](docs/SiteSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.SiteSharingStatus](docs/SiteSharingStatus.md)
 - [Cloud.Governance.Client\Model.SiteStatus](docs/SiteStatus.md)
 - [Cloud.Governance.Client\Model.SiteTemplate](docs/SiteTemplate.md)
 - [Cloud.Governance.Client\Model.SiteTemplateSetting](docs/SiteTemplateSetting.md)
 - [Cloud.Governance.Client\Model.SiteTemplateSettingCustomSiteTemplate](docs/SiteTemplateSettingCustomSiteTemplate.md)
 - [Cloud.Governance.Client\Model.SiteTemplateSettingSiteTemplate](docs/SiteTemplateSettingSiteTemplate.md)
 - [Cloud.Governance.Client\Model.SiteTemplateTypeInSiteDesign](docs/SiteTemplateTypeInSiteDesign.md)
 - [Cloud.Governance.Client\Model.SiteTemplateTypeSetting](docs/SiteTemplateTypeSetting.md)
 - [Cloud.Governance.Client\Model.SiteTimeZone](docs/SiteTimeZone.md)
 - [Cloud.Governance.Client\Model.SiteTitleConstructureRule](docs/SiteTitleConstructureRule.md)
 - [Cloud.Governance.Client\Model.SiteTitleDescription](docs/SiteTitleDescription.md)
 - [Cloud.Governance.Client\Model.SiteTitleSetting](docs/SiteTitleSetting.md)
 - [Cloud.Governance.Client\Model.SiteUrl](docs/SiteUrl.md)
 - [Cloud.Governance.Client\Model.SiteUrlSetting](docs/SiteUrlSetting.md)
 - [Cloud.Governance.Client\Model.SiteUrlSettingAutoGenerateUrlSetting](docs/SiteUrlSettingAutoGenerateUrlSetting.md)
 - [Cloud.Governance.Client\Model.SiteUrlSettingManuallyInputSetting](docs/SiteUrlSettingManuallyInputSetting.md)
 - [Cloud.Governance.Client\Model.SiteValidationParameter](docs/SiteValidationParameter.md)
 - [Cloud.Governance.Client\Model.SpecifyContactParameter](docs/SpecifyContactParameter.md)
 - [Cloud.Governance.Client\Model.StartDateType](docs/StartDateType.md)
 - [Cloud.Governance.Client\Model.StringChangedProperty](docs/StringChangedProperty.md)
 - [Cloud.Governance.Client\Model.StringChangedValueRequestModel](docs/StringChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.StringModel](docs/StringModel.md)
 - [Cloud.Governance.Client\Model.StringModelChangedValueRequestModel](docs/StringModelChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.SubRequestType](docs/SubRequestType.md)
 - [Cloud.Governance.Client\Model.SubscribeMembers](docs/SubscribeMembers.md)
 - [Cloud.Governance.Client\Model.TaskApprovalStatus](docs/TaskApprovalStatus.md)
 - [Cloud.Governance.Client\Model.TaskComment](docs/TaskComment.md)
 - [Cloud.Governance.Client\Model.TaskDynamicActions](docs/TaskDynamicActions.md)
 - [Cloud.Governance.Client\Model.TaskHookMessage](docs/TaskHookMessage.md)
 - [Cloud.Governance.Client\Model.TaskList](docs/TaskList.md)
 - [Cloud.Governance.Client\Model.TaskListPageResult](docs/TaskListPageResult.md)
 - [Cloud.Governance.Client\Model.TaskPriority](docs/TaskPriority.md)
 - [Cloud.Governance.Client\Model.TaskReport](docs/TaskReport.md)
 - [Cloud.Governance.Client\Model.TaskReportPageResult](docs/TaskReportPageResult.md)
 - [Cloud.Governance.Client\Model.TaskResult](docs/TaskResult.md)
 - [Cloud.Governance.Client\Model.TaskStatus](docs/TaskStatus.md)
 - [Cloud.Governance.Client\Model.TaskType](docs/TaskType.md)
 - [Cloud.Governance.Client\Model.TeamClassification](docs/TeamClassification.md)
 - [Cloud.Governance.Client\Model.TeamClassificationAndSensitivityLabel](docs/TeamClassificationAndSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.TeamElectionProfile](docs/TeamElectionProfile.md)
 - [Cloud.Governance.Client\Model.TeamFunSetting](docs/TeamFunSetting.md)
 - [Cloud.Governance.Client\Model.TeamGuestPermissionSetting](docs/TeamGuestPermissionSetting.md)
 - [Cloud.Governance.Client\Model.TeamId](docs/TeamId.md)
 - [Cloud.Governance.Client\Model.TeamLifecycleActionModel](docs/TeamLifecycleActionModel.md)
 - [Cloud.Governance.Client\Model.TeamLifecycleActionType](docs/TeamLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.TeamLifecycleGallery](docs/TeamLifecycleGallery.md)
 - [Cloud.Governance.Client\Model.TeamLifecycleGalleryTeamInfo](docs/TeamLifecycleGalleryTeamInfo.md)
 - [Cloud.Governance.Client\Model.TeamLifecycleGalleryTeamLifecycleActionDetails](docs/TeamLifecycleGalleryTeamLifecycleActionDetails.md)
 - [Cloud.Governance.Client\Model.TeamLocale](docs/TeamLocale.md)
 - [Cloud.Governance.Client\Model.TeamMemberPermissionSetting](docs/TeamMemberPermissionSetting.md)
 - [Cloud.Governance.Client\Model.TeamMembers](docs/TeamMembers.md)
 - [Cloud.Governance.Client\Model.TeamMentionSetting](docs/TeamMentionSetting.md)
 - [Cloud.Governance.Client\Model.TeamMessagingSettings](docs/TeamMessagingSettings.md)
 - [Cloud.Governance.Client\Model.TeamNameDescription](docs/TeamNameDescription.md)
 - [Cloud.Governance.Client\Model.TeamOwners](docs/TeamOwners.md)
 - [Cloud.Governance.Client\Model.TeamSensitivityLabel](docs/TeamSensitivityLabel.md)
 - [Cloud.Governance.Client\Model.TeamSensitivityLabelChangedValueRequestModel](docs/TeamSensitivityLabelChangedValueRequestModel.md)
 - [Cloud.Governance.Client\Model.TeamSiteStatus](docs/TeamSiteStatus.md)
 - [Cloud.Governance.Client\Model.TeamSiteUrl](docs/TeamSiteUrl.md)
 - [Cloud.Governance.Client\Model.TeamTemplate](docs/TeamTemplate.md)
 - [Cloud.Governance.Client\Model.TeamTimeZone](docs/TeamTimeZone.md)
 - [Cloud.Governance.Client\Model.TeamsTemplateServiceSettings](docs/TeamsTemplateServiceSettings.md)
 - [Cloud.Governance.Client\Model.TeamsTemplateSettings](docs/TeamsTemplateSettings.md)
 - [Cloud.Governance.Client\Model.TeamsTemplateSettingsSelectedMSTemplate](docs/TeamsTemplateSettingsSelectedMSTemplate.md)
 - [Cloud.Governance.Client\Model.TeamsTemplateSettingsSelectedTemplate](docs/TeamsTemplateSettingsSelectedTemplate.md)
 - [Cloud.Governance.Client\Model.TemplateAssignBy](docs/TemplateAssignBy.md)
 - [Cloud.Governance.Client\Model.TemplateGiphyRatingType](docs/TemplateGiphyRatingType.md)
 - [Cloud.Governance.Client\Model.TemplateWithPermissions](docs/TemplateWithPermissions.md)
 - [Cloud.Governance.Client\Model.TemporaryPermissionRequestSetting](docs/TemporaryPermissionRequestSetting.md)
 - [Cloud.Governance.Client\Model.TermsMetadataSettings](docs/TermsMetadataSettings.md)
 - [Cloud.Governance.Client\Model.TermsValue](docs/TermsValue.md)
 - [Cloud.Governance.Client\Model.TermsValueTermGroup](docs/TermsValueTermGroup.md)
 - [Cloud.Governance.Client\Model.TermsValueTermSet](docs/TermsValueTermSet.md)
 - [Cloud.Governance.Client\Model.TermsValueTermStore](docs/TermsValueTermStore.md)
 - [Cloud.Governance.Client\Model.TextModel](docs/TextModel.md)
 - [Cloud.Governance.Client\Model.TextValidationRuleRef](docs/TextValidationRuleRef.md)
 - [Cloud.Governance.Client\Model.TextValidationType](docs/TextValidationType.md)
 - [Cloud.Governance.Client\Model.ThemeSettingType](docs/ThemeSettingType.md)
 - [Cloud.Governance.Client\Model.TimeZoneSettings](docs/TimeZoneSettings.md)
 - [Cloud.Governance.Client\Model.TreeNode](docs/TreeNode.md)
 - [Cloud.Governance.Client\Model.TreeNodeExtension](docs/TreeNodeExtension.md)
 - [Cloud.Governance.Client\Model.TreeNodeParent](docs/TreeNodeParent.md)
 - [Cloud.Governance.Client\Model.TreeNodeType](docs/TreeNodeType.md)
 - [Cloud.Governance.Client\Model.TriggerType](docs/TriggerType.md)
 - [Cloud.Governance.Client\Model.UnlockSiteRequest](docs/UnlockSiteRequest.md)
 - [Cloud.Governance.Client\Model.UnlockSiteSetting](docs/UnlockSiteSetting.md)
 - [Cloud.Governance.Client\Model.UpdateMetadataParameter](docs/UpdateMetadataParameter.md)
 - [Cloud.Governance.Client\Model.UrlRandomStringSettings](docs/UrlRandomStringSettings.md)
 - [Cloud.Governance.Client\Model.UrlSequentialNumberingSettings](docs/UrlSequentialNumberingSettings.md)
 - [Cloud.Governance.Client\Model.UserCustomAction](docs/UserCustomAction.md)
 - [Cloud.Governance.Client\Model.UserGroupPermissions](docs/UserGroupPermissions.md)
 - [Cloud.Governance.Client\Model.UserInfo](docs/UserInfo.md)
 - [Cloud.Governance.Client\Model.UserLevelControlMode](docs/UserLevelControlMode.md)
 - [Cloud.Governance.Client\Model.UserLevelControlSettings](docs/UserLevelControlSettings.md)
 - [Cloud.Governance.Client\Model.UserLevelRestrictionType](docs/UserLevelRestrictionType.md)
 - [Cloud.Governance.Client\Model.UserManagementSourceType](docs/UserManagementSourceType.md)
 - [Cloud.Governance.Client\Model.UserMembershipInfo](docs/UserMembershipInfo.md)
 - [Cloud.Governance.Client\Model.UserMembershipStatus](docs/UserMembershipStatus.md)
 - [Cloud.Governance.Client\Model.UserMetadataSettings](docs/UserMetadataSettings.md)
 - [Cloud.Governance.Client\Model.UserProfileMetadataSettings](docs/UserProfileMetadataSettings.md)
 - [Cloud.Governance.Client\Model.UserSource](docs/UserSource.md)
 - [Cloud.Governance.Client\Model.WebLifecycleActionType](docs/WebLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.WebLifecycleRequest](docs/WebLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.WebLifecycleService](docs/WebLifecycleService.md)
 - [Cloud.Governance.Client\Model.WebLifecycleServiceRequestTemplate](docs/WebLifecycleServiceRequestTemplate.md)
 - [Cloud.Governance.Client\Model.WebLifecycleValidateResult](docs/WebLifecycleValidateResult.md)
 - [Cloud.Governance.Client\Model.WebServiceAuthenticationType](docs/WebServiceAuthenticationType.md)
 - [Cloud.Governance.Client\Model.WelcomeEmail](docs/WelcomeEmail.md)
 - [Cloud.Governance.Client\Model.WelcomeEmailSettings](docs/WelcomeEmailSettings.md)
 - [Cloud.Governance.Client\Model.WorkerJobGridModel](docs/WorkerJobGridModel.md)
 - [Cloud.Governance.Client\Model.WorkerJobGridModelPageResult](docs/WorkerJobGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.WorkerJobModel](docs/WorkerJobModel.md)
 - [Cloud.Governance.Client\Model.WorkerObjectType](docs/WorkerObjectType.md)
 - [Cloud.Governance.Client\Model.WorksapceOngoingTasksModel](docs/WorksapceOngoingTasksModel.md)
 - [Cloud.Governance.Client\Model.WorkspaceActionParameter](docs/WorkspaceActionParameter.md)
 - [Cloud.Governance.Client\Model.WorkspaceArchivedType](docs/WorkspaceArchivedType.md)
 - [Cloud.Governance.Client\Model.WorkspaceCreatedSourceType](docs/WorkspaceCreatedSourceType.md)
 - [Cloud.Governance.Client\Model.WorkspaceGridModel](docs/WorkspaceGridModel.md)
 - [Cloud.Governance.Client\Model.WorkspaceGridModelPageResult](docs/WorkspaceGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.WorkspaceIdTypeModel](docs/WorkspaceIdTypeModel.md)
 - [Cloud.Governance.Client\Model.WorkspaceList](docs/WorkspaceList.md)
 - [Cloud.Governance.Client\Model.WorkspaceListPageResult](docs/WorkspaceListPageResult.md)
 - [Cloud.Governance.Client\Model.WorkspaceReport](docs/WorkspaceReport.md)
 - [Cloud.Governance.Client\Model.WorkspaceReportPageResult](docs/WorkspaceReportPageResult.md)
 - [Cloud.Governance.Client\Model.WorkspaceSendCancelEmailParameter](docs/WorkspaceSendCancelEmailParameter.md)
 - [Cloud.Governance.Client\Model.WorkspaceStatus](docs/WorkspaceStatus.md)
 - [Cloud.Governance.Client\Model.WorkspaceType](docs/WorkspaceType.md)
 - [Cloud.Governance.Client\Model.YammerCommunityInfoModel](docs/YammerCommunityInfoModel.md)
 - [Cloud.Governance.Client\Model.YammerGroupJoinType](docs/YammerGroupJoinType.md)
 - [Cloud.Governance.Client\Model.YammerGroupRequestSettings](docs/YammerGroupRequestSettings.md)
 - [Cloud.Governance.Client\Model.YammerGroupServiceSettings](docs/YammerGroupServiceSettings.md)
 - [Cloud.Governance.Client\Model.YammerGroupType](docs/YammerGroupType.md)


## Documentation for Authorization


### clientSecret

- **Type**: API key

- **API key parameter name**: clientSecret
- **Location**: HTTP header


### userPrincipalName

- **Type**: API key

- **API key parameter name**: userPrincipalName
- **Location**: HTTP header

