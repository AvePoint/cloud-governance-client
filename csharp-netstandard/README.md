The C# library for the Cloud Governance Api

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6

<a name="installation"></a>
## Installation
Install-Package Cloud.Governance.Client

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            
            Configuration config = new Configuration();

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "Cloud_Governance_Modern_API_Endpoint";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user’s account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new WorkspacesAdminApi(config);
            
            var updateMetadataParameter = new UpdateMetadataParameter(); // UpdateMetadataParameter |  (optional) 

            try
            {
                // update metadatas for workspaces
                apiInstance.UpdateMetadatas(updateMetadataParameter);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.UpdateMetadatas: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthApi* | [**GetDelegateAccessToken**](docs/AuthApi.md#getdelegateaccesstoken) | **POST** /auth/token/delegate | get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
*AuthApi* | [**RefreshUserAccessToken**](docs/AuthApi.md#refreshuseraccesstoken) | **POST** /auth/token/refresh | refresh user access token
*AuthAdminApi* | [**DeleteTokenCache**](docs/AuthAdminApi.md#deletetokencache) | **DELETE** /admin/auth/token/cache | delete token cache
*GuestUsersAdminApi* | [**GetManagedGuestUsers**](docs/GuestUsersAdminApi.md#getmanagedguestusers) | **GET** /admin/directory/guestusers | get all managed guest users
*JobmonitorAdminApi* | [**GetAllJobMonitorReports**](docs/JobmonitorAdminApi.md#getalljobmonitorreports) | **GET** /admin/jobmonitor | get all jobs
*JobmonitorAdminApi* | [**GetWorkspacejobBasicInfo**](docs/JobmonitorAdminApi.md#getworkspacejobbasicinfo) | **GET** /admin/jobmonitor/{id}/basic | get workspace job basic information              support action:unlock/specify contact/restore workspace/refresh guest invite status
*JobsAdminApi* | [**GetJobs**](docs/JobsAdminApi.md#getjobs) | **GET** /admin/jobs | Get worker jobs
*JobsAdminApi* | [**GetRelatedJobs**](docs/JobsAdminApi.md#getrelatedjobs) | **GET** /admin/jobs/relations | Get related worker job
*MetadataAdminApi* | [**GetAllMetadata**](docs/MetadataAdminApi.md#getallmetadata) | **GET** /admin/metadata | get all metadata
*MetadataAdminApi* | [**GetSingleMetadataById**](docs/MetadataAdminApi.md#getsinglemetadatabyid) | **GET** /admin/metadata/{id} | Get metadata by id
*Office365Api* | [**CreateSecurityGroup**](docs/Office365Api.md#createsecuritygroup) | **POST** /office365/securitygroups | Create mail-enabled security group
*Office365Api* | [**GetAllSiteDesigns**](docs/Office365Api.md#getallsitedesigns) | **GET** /office365/allsitedesigns | get all site designs by site url
*Office365Api* | [**GetGroupAllMembersByGroupValue**](docs/Office365Api.md#getgroupallmembersbygroupvalue) | **GET** /office365/groups/allmembers | get group members by group email
*Office365Api* | [**GetGroupMembers**](docs/Office365Api.md#getgroupmembers) | **GET** /office365/groups/{email}/memberswithoutowner | get group members without owners by group email
*Office365Api* | [**GetGroupOwners**](docs/Office365Api.md#getgroupowners) | **GET** /office365/groups/{email}/owners | get group owners by group email
*Office365Api* | [**GetHubSiteUrlsByUrl**](docs/Office365Api.md#gethubsiteurlsbyurl) | **GET** /office365/hubsiteurls | get all hubsite urls from site's tenant
*Office365Api* | [**GetHubSitesByUrl**](docs/Office365Api.md#gethubsitesbyurl) | **GET** /office365/hubsites | get all hubsites from site's tenant
*Office365Api* | [**GetOfficeSiteTemplates**](docs/Office365Api.md#getofficesitetemplates) | **GET** /office365/{officeTenantId}/sites/templates/{languageId} | get site templates with language code identifier
*Office365Api* | [**GetOwnedTeams**](docs/Office365Api.md#getownedteams) | **GET** /office365/teams/my | get all teams that owner is curernt user
*Office365Api* | [**GetPermissions**](docs/Office365Api.md#getpermissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
*Office365Api* | [**GetRoleAssignment**](docs/Office365Api.md#getroleassignment) | **GET** /office365/roleassignment | get site permimssion role assignment
*Office365Api* | [**GetSiteDesigns**](docs/Office365Api.md#getsitedesigns) | **GET** /office365/sitedesigns | get site designs by site url
*Office365Api* | [**GetSitePermissionLevels**](docs/Office365Api.md#getsitepermissionlevels) | **GET** /office365/sites/permissionlevels | get site permission levels
*Office365Api* | [**GetSiteSensitivityLabels**](docs/Office365Api.md#getsitesensitivitylabels) | **GET** /office365/sites/sensitivitylabelsetting | get site sharePoint groups
*Office365Api* | [**GetSiteSharePointGroups**](docs/Office365Api.md#getsitesharepointgroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
*Office365Api* | [**GetSiteStatus**](docs/Office365Api.md#getsitestatus) | **GET** /office365/sites/status | check site collection status by full url
*Office365Api* | [**GetSiteTemplates**](docs/Office365Api.md#getsitetemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
*Office365Api* | [**GetTeamSiteDesigns**](docs/Office365Api.md#getteamsitedesigns) | **GET** /office365/teamsitedesigns | 
*Office365Api* | [**HasPermission**](docs/Office365Api.md#haspermission) | **GET** /office365/sites/haspermission | whether user has permission on the site
*Office365Api* | [**RemoveSecurityGroup**](docs/Office365Api.md#removesecuritygroup) | **DELETE** /office365/securitygroups/{name} | Remove mail-enabled security group by group name
*Office365AdminApi* | [**AddWebUserCustomAction**](docs/Office365AdminApi.md#addwebusercustomaction) | **POST** /admin/office365/web/usercustomactions | add user custom actions, if exists, will update the existing one.
*Office365AdminApi* | [**DeleteWebUserCustomAction**](docs/Office365AdminApi.md#deletewebusercustomaction) | **DELETE** /admin/office365/web/usercustomactions | delete user custom actions by action name
*Office365AdminApi* | [**GetAzureADExtensionPropertyNamesWithDataType**](docs/Office365AdminApi.md#getazureadextensionpropertynameswithdatatype) | **GET** /admin/office365/azuread/{tenantId}/property/custom | get azure ad custom property with data type
*Office365AdminApi* | [**GetAzureAdCustomPropertyNames**](docs/Office365AdminApi.md#getazureadcustompropertynames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
*Office365AdminApi* | [**GetDownloadFileUrL**](docs/Office365AdminApi.md#getdownloadfileurl) | **GET** /admin/office365/downloadurl/{type} | get download file url
*Office365AdminApi* | [**GetTenantIdByUrl**](docs/Office365AdminApi.md#gettenantidbyurl) | **GET** /admin/office365/tenantid | get tenant ids by url
*Office365AdminApi* | [**GetTenantIds**](docs/Office365AdminApi.md#gettenantids) | **GET** /admin/office365/tenantids | get tenant ids by filter expression
*Office365AdminApi* | [**GetUploadFileUrL**](docs/Office365AdminApi.md#getuploadfileurl) | **GET** /admin/office365/uploadurl/{type} | get upload file url
*Office365SettingsAdminApi* | [**UpdateDenyAddAndCustomizePagesStatus**](docs/Office365SettingsAdminApi.md#updatedenyaddandcustomizepagesstatus) | **PUT** /admin/settings/office365/updatedenyaddandcustomizepagesstatus | update denyaddandcustomizepages status by custom action
*ReportAdminApi* | [**GeTaskReport**](docs/ReportAdminApi.md#getaskreport) | **GET** /admin/report/tasks | get all tasks report
*ReportAdminApi* | [**GetRequestReport**](docs/ReportAdminApi.md#getrequestreport) | **GET** /admin/report/requests | get requests report
*ReportAdminApi* | [**GetWorkspaceReport**](docs/ReportAdminApi.md#getworkspacereport) | **GET** /admin/report/workspaces | get workspaces report
*RequestsApi* | [**CancelRequest**](docs/RequestsApi.md#cancelrequest) | **GET** /requests/{id}/cancel | cancel request
*RequestsApi* | [**GetArchiveGroupRequest**](docs/RequestsApi.md#getarchivegrouprequest) | **GET** /requests/archivegroup/{id} | get archive group request
*RequestsApi* | [**GetArchiveSiteRequest**](docs/RequestsApi.md#getarchivesiterequest) | **GET** /requests/archivesite/{id} | get archive site request
*RequestsApi* | [**GetArchiveWebRequest**](docs/RequestsApi.md#getarchivewebrequest) | **GET** /requests/archiveweb/{id} | get archive web request
*RequestsApi* | [**GetChagneGroupPolicyRequest**](docs/RequestsApi.md#getchagnegrouppolicyrequest) | **GET** /requests/changegrouppolicy/{id} | get change group policy request
*RequestsApi* | [**GetChangeGroupQuotaRequest**](docs/RequestsApi.md#getchangegroupquotarequest) | **GET** /requests/changegroupquota/{id} | get change group quota request
*RequestsApi* | [**GetChangeGroupSettingRequest**](docs/RequestsApi.md#getchangegroupsettingrequest) | **GET** /requests/changegroup/{id} | get change group settings request
*RequestsApi* | [**GetChangeListSettingRequest**](docs/RequestsApi.md#getchangelistsettingrequest) | **GET** /requests/changelistsetting/{id} | get change list settings request
*RequestsApi* | [**GetChangePermissionRequest**](docs/RequestsApi.md#getchangepermissionrequest) | **GET** /requests/changepermission/{id} | get change permission request
*RequestsApi* | [**GetChangePrivateChannelRequest**](docs/RequestsApi.md#getchangeprivatechannelrequest) | **GET** /requests/changeprivatechannel/{id} | get change private channel request
*RequestsApi* | [**GetChangeSiteContactRequest**](docs/RequestsApi.md#getchangesitecontactrequest) | **GET** /requests/changesite/adminorcontact/{id} | get change site administrator or contact request
*RequestsApi* | [**GetChangeSitePolicyRequest**](docs/RequestsApi.md#getchangesitepolicyrequest) | **GET** /requests/changesitepolicy/{id} | get change site policy request
*RequestsApi* | [**GetChangeSiteQuotaRequest**](docs/RequestsApi.md#getchangesitequotarequest) | **GET** /requests/changesitequota/{id} | get change site quota request
*RequestsApi* | [**GetChangeSiteSettingRequest**](docs/RequestsApi.md#getchangesitesettingrequest) | **GET** /requests/changesite/setting/{id} | get change site settings request
*RequestsApi* | [**GetChangeWebContactRequest**](docs/RequestsApi.md#getchangewebcontactrequest) | **GET** /requests/changewebcontact/{id} | get change web contact request
*RequestsApi* | [**GetChangeWebSettingRequest**](docs/RequestsApi.md#getchangewebsettingrequest) | **GET** /requests/changewebsettings/{id} | get change web settings request
*RequestsApi* | [**GetClonePermissionRequest**](docs/RequestsApi.md#getclonepermissionrequest) | **GET** /requests/clonepermission/{id} | get clone permission request
*RequestsApi* | [**GetContentMoveRequest**](docs/RequestsApi.md#getcontentmoverequest) | **GET** /requests/contentmove/{id} | get content move request
*RequestsApi* | [**GetCreateGroupRequest**](docs/RequestsApi.md#getcreategrouprequest) | **GET** /requests/creategroup/{id} | get create group request
*RequestsApi* | [**GetCreateGuestUserRequest**](docs/RequestsApi.md#getcreateguestuserrequest) | **GET** /requests/createguestuser/{id} | get create guest user request
*RequestsApi* | [**GetCreateListRequest**](docs/RequestsApi.md#getcreatelistrequest) | **GET** /requests/createlist/{id} | get create list request
*RequestsApi* | [**GetCreatePrivateChannelRequest**](docs/RequestsApi.md#getcreateprivatechannelrequest) | **GET** /requests/createprivatechannel/{id} | get private channel request
*RequestsApi* | [**GetCreateSiteRequest**](docs/RequestsApi.md#getcreatesiterequest) | **GET** /requests/createsite/{id} | get create site request
*RequestsApi* | [**GetCreateWebRequest**](docs/RequestsApi.md#getcreatewebrequest) | **GET** /requests/createweb/{id} | get create web request
*RequestsApi* | [**GetCustomRequest**](docs/RequestsApi.md#getcustomrequest) | **GET** /requests/custom/{id} | get custom service request
*RequestsApi* | [**GetDeleteGroupRequest**](docs/RequestsApi.md#getdeletegrouprequest) | **GET** /requests/deletegroup/{id} | get delete group request
*RequestsApi* | [**GetDeleteSiteRequest**](docs/RequestsApi.md#getdeletesiterequest) | **GET** /requests/deletesite/{id} | get delete site request
*RequestsApi* | [**GetDeleteWebRequest**](docs/RequestsApi.md#getdeletewebrequest) | **GET** /requests/deleteweb/{id} | get delete web request
*RequestsApi* | [**GetDynamicRequest**](docs/RequestsApi.md#getdynamicrequest) | **GET** /requests/dynamic/{id} | get dynamic request
*RequestsApi* | [**GetDynamicRequestChangeContactGallery**](docs/RequestsApi.md#getdynamicrequestchangecontactgallery) | **GET** /requests/dynamic/{id}/gallery/changecontact | 
*RequestsApi* | [**GetDynamicRequestChangeExchangeResourceMembershipGallery**](docs/RequestsApi.md#getdynamicrequestchangeexchangeresourcemembershipgallery) | **GET** /requests/dynamic/{id}/gallery/changeexchangeresourcemembership | 
*RequestsApi* | [**GetDynamicRequestChangeLicenseGallery**](docs/RequestsApi.md#getdynamicrequestchangelicensegallery) | **GET** /requests/dynamic/{id}/gallery/changelicense | 
*RequestsApi* | [**GetDynamicRequestChangeSecurityGroupSettingsGallery**](docs/RequestsApi.md#getdynamicrequestchangesecuritygroupsettingsgallery) | **GET** /requests/dynamic/{id}/gallery/changesecuritygroupsettings | 
*RequestsApi* | [**GetDynamicRequestChangeSharedChannelGallery**](docs/RequestsApi.md#getdynamicrequestchangesharedchannelgallery) | **GET** /requests/dynamic/{id}/gallery/changesharedchannel | 
*RequestsApi* | [**GetDynamicRequestChangeSharedMailboxPermissionGallery**](docs/RequestsApi.md#getdynamicrequestchangesharedmailboxpermissiongallery) | **GET** /requests/dynamic/{id}/gallery/changesharedmailboxpermission | 
*RequestsApi* | [**GetDynamicRequestChangeSiteProfileGallery**](docs/RequestsApi.md#getdynamicrequestchangesiteprofilegallery) | **GET** /requests/dynamic/{id}/gallery/changesiteprofile | 
*RequestsApi* | [**GetDynamicRequestChangeSiteSettingGallery**](docs/RequestsApi.md#getdynamicrequestchangesitesettinggallery) | **GET** /requests/dynamic/{id}/gallery/changesitesetting | 
*RequestsApi* | [**GetDynamicRequestChangeTeamSettingGallery**](docs/RequestsApi.md#getdynamicrequestchangeteamsettinggallery) | **GET** /requests/dynamic/{id}/gallery/changeteamsetting | 
*RequestsApi* | [**GetDynamicRequestCreateCommunityGallery**](docs/RequestsApi.md#getdynamicrequestcreatecommunitygallery) | **GET** /requests/dynamic/{id}/gallery/createCommunity | 
*RequestsApi* | [**GetDynamicRequestCreateDistributionListGallery**](docs/RequestsApi.md#getdynamicrequestcreatedistributionlistgallery) | **GET** /requests/dynamic/{id}/gallery/createdistributionlist | 
*RequestsApi* | [**GetDynamicRequestCreateEquipmentMailboxGallery**](docs/RequestsApi.md#getdynamicrequestcreateequipmentmailboxgallery) | **GET** /requests/dynamic/{id}/gallery/createequipmentmailbox | 
*RequestsApi* | [**GetDynamicRequestCreateGroupGallery**](docs/RequestsApi.md#getdynamicrequestcreategroupgallery) | **GET** /requests/dynamic/{id}/gallery/creategroups | 
*RequestsApi* | [**GetDynamicRequestCreateLibraryGallery**](docs/RequestsApi.md#getdynamicrequestcreatelibrarygallery) | **GET** /requests/dynamic/{id}/gallery/createlibrary | 
*RequestsApi* | [**GetDynamicRequestCreateMailEnabledGroupGallery**](docs/RequestsApi.md#getdynamicrequestcreatemailenabledgroupgallery) | **GET** /requests/dynamic/{id}/gallery/createmailenabledgroup | 
*RequestsApi* | [**GetDynamicRequestCreateRoomMailboxGallery**](docs/RequestsApi.md#getdynamicrequestcreateroommailboxgallery) | **GET** /requests/dynamic/{id}/gallery/createroommailbox | 
*RequestsApi* | [**GetDynamicRequestCreateSecurityGroupGallery**](docs/RequestsApi.md#getdynamicrequestcreatesecuritygroupgallery) | **GET** /requests/dynamic/{id}/gallery/createsecuritygroupgallery | 
*RequestsApi* | [**GetDynamicRequestCreateSharedChannelGallery**](docs/RequestsApi.md#getdynamicrequestcreatesharedchannelgallery) | **GET** /requests/dynamic/{id}/gallery/createsharedchannel | 
*RequestsApi* | [**GetDynamicRequestCreateSharedMailboxGallery**](docs/RequestsApi.md#getdynamicrequestcreatesharedmailboxgallery) | **GET** /requests/dynamic/{id}/gallery/createsharedmailbox | 
*RequestsApi* | [**GetDynamicRequestCreateSiteGallery**](docs/RequestsApi.md#getdynamicrequestcreatesitegallery) | **GET** /requests/dynamic/{id}/gallery/createsite | 
*RequestsApi* | [**GetDynamicRequestCreateTeamsGallery**](docs/RequestsApi.md#getdynamicrequestcreateteamsgallery) | **GET** /requests/dynamic/{id}/gallery/createteams | 
*RequestsApi* | [**GetDynamicRequestExchangeResourceLifecycleGallery**](docs/RequestsApi.md#getdynamicrequestexchangeresourcelifecyclegallery) | **GET** /requests/dynamic/{id}/gallery/exchangeresourcelifecycle | 
*RequestsApi* | [**GetDynamicRequestInviteGuestGallery**](docs/RequestsApi.md#getdynamicrequestinviteguestgallery) | **GET** /requests/dynamic/{id}/gallery/inviteguest | 
*RequestsApi* | [**GetDynamicRequestM365GroupLifecycleGallery**](docs/RequestsApi.md#getdynamicrequestm365grouplifecyclegallery) | **GET** /requests/dynamic/{id}/gallery/m365grouplifecycle | 
*RequestsApi* | [**GetDynamicRequestSCLifecycleGallery**](docs/RequestsApi.md#getdynamicrequestsclifecyclegallery) | **GET** /requests/dynamic/{id}/gallery/sclifecycle | 
*RequestsApi* | [**GetDynamicRequestSharedMailboxLifecycleGallery**](docs/RequestsApi.md#getdynamicrequestsharedmailboxlifecyclegallery) | **GET** /requests/dynamic/{id}/gallery/sharedmailboxlifecycle | 
*RequestsApi* | [**GetDynamicRequestTeamLifecycleGallery**](docs/RequestsApi.md#getdynamicrequestteamlifecyclegallery) | **GET** /requests/dynamic/{id}/gallery/teamlifecycle | 
*RequestsApi* | [**GetExtendGroupRequest**](docs/RequestsApi.md#getextendgrouprequest) | **GET** /requests/extendgroup/{id} | get extend group request
*RequestsApi* | [**GetExtendSiteRequest**](docs/RequestsApi.md#getextendsiterequest) | **GET** /requests/extendsite/{id} | get extend site request
*RequestsApi* | [**GetGrantPermissionRequest**](docs/RequestsApi.md#getgrantpermissionrequest) | **GET** /requests/grantpermission/{id} | get grant permission request
*RequestsApi* | [**GetLockSiteReuqest**](docs/RequestsApi.md#getlocksitereuqest) | **GET** /requests/locksite/{id} | get lock site request
*RequestsApi* | [**GetManagePermissionRequest**](docs/RequestsApi.md#getmanagepermissionrequest) | **GET** /requests/managepermission/{id} | get manage permission request
*RequestsApi* | [**GetMyRequests**](docs/RequestsApi.md#getmyrequests) | **GET** /requests/my | get my requests
*RequestsApi* | [**GetRequestById**](docs/RequestsApi.md#getrequestbyid) | **GET** /requests/{id} | get request by id
*RequestsApi* | [**GetRestoreGroupRequest**](docs/RequestsApi.md#getrestoregrouprequest) | **GET** /requests/restoregroup/{id} | get restore group request
*RequestsApi* | [**GetSiteCollectionLifecycleRequest**](docs/RequestsApi.md#getsitecollectionlifecyclerequest) | **GET** /requests/sitelifecycle/{id} | get site lifecycel request
*RequestsApi* | [**GetTasks**](docs/RequestsApi.md#gettasks) | **GET** /requests/{requestid}/tasks | get task by request id
*RequestsApi* | [**GetUnlockSiteRequest**](docs/RequestsApi.md#getunlocksiterequest) | **GET** /requests/unlocksite/{id} | get unlock site request
*RequestsApi* | [**IsUrlExistsInPendingRequests**](docs/RequestsApi.md#isurlexistsinpendingrequests) | **GET** /requests/isUrlExistInPendingRequests | check url exists in pending requests.
*RequestsApi* | [**SubmitArchiveGroupRequest**](docs/RequestsApi.md#submitarchivegrouprequest) | **POST** /requests/archivegroup | submit archive group group request
*RequestsApi* | [**SubmitArchiveGroupRequestV2**](docs/RequestsApi.md#submitarchivegrouprequestv2) | **POST** /requests/archivegroup/v2 | submit archive group request, and return request info.
*RequestsApi* | [**SubmitArchiveSiteRequest**](docs/RequestsApi.md#submitarchivesiterequest) | **POST** /requests/archivesite | submit archive site request
*RequestsApi* | [**SubmitArchiveSiteRequestV2**](docs/RequestsApi.md#submitarchivesiterequestv2) | **POST** /requests/archivesite/v2 | submit archive site request, and return request info.
*RequestsApi* | [**SubmitArchiveWebRequest**](docs/RequestsApi.md#submitarchivewebrequest) | **POST** /requests/archiveweb | submit archive web request
*RequestsApi* | [**SubmitChangeGroupPolicyRequest**](docs/RequestsApi.md#submitchangegrouppolicyrequest) | **POST** /requests/changegrouppolicy | submit change group policy request
*RequestsApi* | [**SubmitChangeGroupPolicyRequestV2**](docs/RequestsApi.md#submitchangegrouppolicyrequestv2) | **POST** /requests/changegrouppolicy/v2 | submit change group policy request, and return request info.
*RequestsApi* | [**SubmitChangeGroupQuotaRequest**](docs/RequestsApi.md#submitchangegroupquotarequest) | **POST** /requests/changegroupquota | submit change group quota request
*RequestsApi* | [**SubmitChangeGroupQuotaRequestV2**](docs/RequestsApi.md#submitchangegroupquotarequestv2) | **POST** /requests/changegroupquota/v2 | submit change group quota request, and return request info.
*RequestsApi* | [**SubmitChangeGroupSettingRequest**](docs/RequestsApi.md#submitchangegroupsettingrequest) | **POST** /requests/changegroup | submit change group settings request
*RequestsApi* | [**SubmitChangeGroupSettingRequestV2**](docs/RequestsApi.md#submitchangegroupsettingrequestv2) | **POST** /requests/changegroup/v2 | submit change group settings request, and return request info.
*RequestsApi* | [**SubmitChangeListSettingRequest**](docs/RequestsApi.md#submitchangelistsettingrequest) | **POST** /requests/changelistsetting | submit change list settings request
*RequestsApi* | [**SubmitChangePermissionRequest**](docs/RequestsApi.md#submitchangepermissionrequest) | **POST** /requests/changepermission | submit change permission request
*RequestsApi* | [**SubmitChangePermissionRequestV2**](docs/RequestsApi.md#submitchangepermissionrequestv2) | **POST** /requests/changepermission/v2 | submit change permission request, and return request info.
*RequestsApi* | [**SubmitChangePrivateChannelRequest**](docs/RequestsApi.md#submitchangeprivatechannelrequest) | **POST** /requests/changeprivatechannel | submit change private channel request
*RequestsApi* | [**SubmitChangeSiteContactRequest**](docs/RequestsApi.md#submitchangesitecontactrequest) | **POST** /requests/changesite/adminorcontact | submit change site administrator or contact request
*RequestsApi* | [**SubmitChangeSiteContactRequestV2**](docs/RequestsApi.md#submitchangesitecontactrequestv2) | **POST** /requests/changesite/v2/adminorcontact | submit change site administrator or contact request, and return request info.
*RequestsApi* | [**SubmitChangeSitePolicyRequest**](docs/RequestsApi.md#submitchangesitepolicyrequest) | **POST** /requests/changesitepolicy | submit change site policy request
*RequestsApi* | [**SubmitChangeSitePolicyRequestV2**](docs/RequestsApi.md#submitchangesitepolicyrequestv2) | **POST** /requests/changesitepolicy/v2 | submit change site policy request, and return request info.
*RequestsApi* | [**SubmitChangeSiteQuotaRequest**](docs/RequestsApi.md#submitchangesitequotarequest) | **POST** /requests/changesitequota | submit change site quota request
*RequestsApi* | [**SubmitChangeSiteQuotaRequestV2**](docs/RequestsApi.md#submitchangesitequotarequestv2) | **POST** /requests/changesitequota/v2 | submit change site quota request, and return request info.
*RequestsApi* | [**SubmitChangeSiteSettingRequest**](docs/RequestsApi.md#submitchangesitesettingrequest) | **POST** /requests/changesite/setting | submit change site settings request
*RequestsApi* | [**SubmitChangeSiteSettingRequestV2**](docs/RequestsApi.md#submitchangesitesettingrequestv2) | **POST** /requests/changesite/v2/setting | submit change site setting request, and return request info.
*RequestsApi* | [**SubmitChangeWebContactRequest**](docs/RequestsApi.md#submitchangewebcontactrequest) | **POST** /requests/changewebcontact | submit change web contact request
*RequestsApi* | [**SubmitChangeWebSettingRequest**](docs/RequestsApi.md#submitchangewebsettingrequest) | **POST** /requests/changewebsettings | submit change web settings request
*RequestsApi* | [**SubmitClonePermissionRequest**](docs/RequestsApi.md#submitclonepermissionrequest) | **POST** /requests/clonepermission | get clone permission request
*RequestsApi* | [**SubmitContentMoveRequest**](docs/RequestsApi.md#submitcontentmoverequest) | **POST** /requests/contentmove | submit create content move request
*RequestsApi* | [**SubmitContentMoveRequestV2**](docs/RequestsApi.md#submitcontentmoverequestv2) | **POST** /requests/contentmove/v2 | submit create content move request, and return request info.
*RequestsApi* | [**SubmitCreateGroupRequest**](docs/RequestsApi.md#submitcreategrouprequest) | **POST** /requests/creategroup | submit create group request
*RequestsApi* | [**SubmitCreateGroupRequestV2**](docs/RequestsApi.md#submitcreategrouprequestv2) | **POST** /requests/creategroup/v2 | submit create group request, and return request info.
*RequestsApi* | [**SubmitCreateGuestUserRequest**](docs/RequestsApi.md#submitcreateguestuserrequest) | **POST** /requests/createguestuser | submit create guest user request
*RequestsApi* | [**SubmitCreateListRequest**](docs/RequestsApi.md#submitcreatelistrequest) | **POST** /requests/createlist | submit create list request
*RequestsApi* | [**SubmitCreatePrivateChannelRequest**](docs/RequestsApi.md#submitcreateprivatechannelrequest) | **POST** /requests/createprivatechannel | submit private channel request
*RequestsApi* | [**SubmitCreateSiteRequest**](docs/RequestsApi.md#submitcreatesiterequest) | **POST** /requests/createsite | submit create site collection request
*RequestsApi* | [**SubmitCreateSiteRequestV2**](docs/RequestsApi.md#submitcreatesiterequestv2) | **POST** /requests/createsite/v2 | submit create site collection request, and return request info.
*RequestsApi* | [**SubmitCreateWebRequest**](docs/RequestsApi.md#submitcreatewebrequest) | **POST** /requests/createweb | submit create web request
*RequestsApi* | [**SubmitCreateWebRequestV2**](docs/RequestsApi.md#submitcreatewebrequestv2) | **POST** /requests/createweb/v2 | submit create web request, and return request info.
*RequestsApi* | [**SubmitCustomRequest**](docs/RequestsApi.md#submitcustomrequest) | **POST** /requests/custom | submit custom service request
*RequestsApi* | [**SubmitCustomRequestV2**](docs/RequestsApi.md#submitcustomrequestv2) | **POST** /requests/custom/v2 | submit custom service request, and return request info.
*RequestsApi* | [**SubmitDeleteGroupRequest**](docs/RequestsApi.md#submitdeletegrouprequest) | **POST** /requests/deletegroup | submit delete group request
*RequestsApi* | [**SubmitDeleteGroupRequestV2**](docs/RequestsApi.md#submitdeletegrouprequestv2) | **POST** /requests/deletegroup/v2 | submit delete group request, and return request info.
*RequestsApi* | [**SubmitDeleteSiteRequest**](docs/RequestsApi.md#submitdeletesiterequest) | **POST** /requests/deletesite | submit delete site request
*RequestsApi* | [**SubmitDeleteSiteRequestV2**](docs/RequestsApi.md#submitdeletesiterequestv2) | **POST** /requests/deletesite/v2 | submit delete site request, and return request info.
*RequestsApi* | [**SubmitDeleteWebRequest**](docs/RequestsApi.md#submitdeletewebrequest) | **POST** /requests/deleteweb | submit delete web request
*RequestsApi* | [**SubmitDynamicRequest**](docs/RequestsApi.md#submitdynamicrequest) | **POST** /requests/dynamic | submit dynamic request
*RequestsApi* | [**SubmitDynamicRequestByTemplate**](docs/RequestsApi.md#submitdynamicrequestbytemplate) | **POST** /requests/dynamic/template | 
*RequestsApi* | [**SubmitExtendGroupRequest**](docs/RequestsApi.md#submitextendgrouprequest) | **POST** /requests/extendgroup | submit extend group request
*RequestsApi* | [**SubmitExtendGroupRequestV2**](docs/RequestsApi.md#submitextendgrouprequestv2) | **POST** /requests/extendgroup/v2 | submit extend group request, and return request info.
*RequestsApi* | [**SubmitExtendSiteRequest**](docs/RequestsApi.md#submitextendsiterequest) | **POST** /requests/extendsite | submit extend site request
*RequestsApi* | [**SubmitExtendSiteRequestV2**](docs/RequestsApi.md#submitextendsiterequestv2) | **POST** /requests/extendsite/v2 | submit extend site request, and return request info.
*RequestsApi* | [**SubmitGrantPermissionRequest**](docs/RequestsApi.md#submitgrantpermissionrequest) | **POST** /requests/grantpermission | get submit grant permission request
*RequestsApi* | [**SubmitGrantPermissionRequestV2**](docs/RequestsApi.md#submitgrantpermissionrequestv2) | **POST** /requests/grantpermission/v2 | submit grant permission request, and return request info.
*RequestsApi* | [**SubmitLockSiteRequest**](docs/RequestsApi.md#submitlocksiterequest) | **POST** /requests/locksite | submit lock site request
*RequestsApi* | [**SubmitLockSiteRequestV2**](docs/RequestsApi.md#submitlocksiterequestv2) | **POST** /requests/locksite/v2 | submit lock site request, and return request info.
*RequestsApi* | [**SubmitManagePermissionRequest**](docs/RequestsApi.md#submitmanagepermissionrequest) | **POST** /requests/managepermission | submit manage permission request
*RequestsApi* | [**SubmitManagePermissionRequestV2**](docs/RequestsApi.md#submitmanagepermissionrequestv2) | **POST** /requests/managepermission/v2 | submit manage permission request, and return request info.
*RequestsApi* | [**SubmitRestoreGroupRequest**](docs/RequestsApi.md#submitrestoregrouprequest) | **POST** /requests/restoregroup | submit restore group request
*RequestsApi* | [**SubmitRestoreGroupRequestV2**](docs/RequestsApi.md#submitrestoregrouprequestv2) | **POST** /requests/restoregroup/v2 | submit restore group request, and return request info.
*RequestsApi* | [**SubmitUnlockSiteRequest**](docs/RequestsApi.md#submitunlocksiterequest) | **POST** /requests/unlocksite | submit unlock site request
*RequestsApi* | [**SubmitUnlockSiteRequestV2**](docs/RequestsApi.md#submitunlocksiterequestv2) | **POST** /requests/unlocksite/v2 | submit unlock site request, and return request info.
*RequestsAdminApi* | [**GetAllRequests**](docs/RequestsAdminApi.md#getallrequests) | **GET** /admin/directory/requests | get all requests
*ServicesApi* | [**GetChangeGroupSettingService**](docs/ServicesApi.md#getchangegroupsettingservice) | **GET** /services/changegroupsetting/{id} | get change group setting service
*ServicesApi* | [**GetChangeListSettingService**](docs/ServicesApi.md#getchangelistsettingservice) | **GET** /services/changelistsetting/{id} | get change list setting service
*ServicesApi* | [**GetChangePermissionService**](docs/ServicesApi.md#getchangepermissionservice) | **GET** /services/changepermission/{id} | get change permission service
*ServicesApi* | [**GetChangePrivateChannelService**](docs/ServicesApi.md#getchangeprivatechannelservice) | **GET** /services/changeprivatechannel/{id} | get private channel service detail
*ServicesApi* | [**GetChangeSiteContactService**](docs/ServicesApi.md#getchangesitecontactservice) | **GET** /services/changesitecontact/{id} | get change site contact service
*ServicesApi* | [**GetChangeSiteSettingService**](docs/ServicesApi.md#getchangesitesettingservice) | **GET** /services/changesitesetting/{id} | get change site setting service
*ServicesApi* | [**GetChangeWebContactService**](docs/ServicesApi.md#getchangewebcontactservice) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
*ServicesApi* | [**GetChangeWebSettingsService**](docs/ServicesApi.md#getchangewebsettingsservice) | **GET** /services/changewebsettings/{id} | get change web setting service
*ServicesApi* | [**GetClonePermissionService**](docs/ServicesApi.md#getclonepermissionservice) | **GET** /services/clonepermission/{id} | get clone permission service
*ServicesApi* | [**GetContentMoveProfiles**](docs/ServicesApi.md#getcontentmoveprofiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
*ServicesApi* | [**GetContentMoveService**](docs/ServicesApi.md#getcontentmoveservice) | **GET** /services/contentmove/{id} | get content move service
*ServicesApi* | [**GetCreateGroupService**](docs/ServicesApi.md#getcreategroupservice) | **GET** /services/creategroup/{id} | get create group service
*ServicesApi* | [**GetCreateGuestUserService**](docs/ServicesApi.md#getcreateguestuserservice) | **GET** /services/createguestuser/{id} | get create group service
*ServicesApi* | [**GetCreateListService**](docs/ServicesApi.md#getcreatelistservice) | **GET** /services/createlist/{id} | get create list service
*ServicesApi* | [**GetCreatePrivateChannelService**](docs/ServicesApi.md#getcreateprivatechannelservice) | **GET** /services/createprivatechannel/{id} | get private channel service detail
*ServicesApi* | [**GetCreateSiteService**](docs/ServicesApi.md#getcreatesiteservice) | **GET** /services/createsite/{id} | get create site service
*ServicesApi* | [**GetCreateWebService**](docs/ServicesApi.md#getcreatewebservice) | **GET** /services/createweb/{id} | get create web service
*ServicesApi* | [**GetCustomService**](docs/ServicesApi.md#getcustomservice) | **GET** /services/custom/{id} | get custom service
*ServicesApi* | [**GetDynamicService**](docs/ServicesApi.md#getdynamicservice) | **GET** /services/dynamic/{id} | get dynamic service
*ServicesApi* | [**GetDynamicServiceRequestTemplate**](docs/ServicesApi.md#getdynamicservicerequesttemplate) | **GET** /services/dynamic/{id}/template | 
*ServicesApi* | [**GetGrantPermissionService**](docs/ServicesApi.md#getgrantpermissionservice) | **GET** /services/grantpermission/{id} | get grant permission service
*ServicesApi* | [**GetGroupLifecycleService**](docs/ServicesApi.md#getgrouplifecycleservice) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
*ServicesApi* | [**GetManagePermissionService**](docs/ServicesApi.md#getmanagepermissionservice) | **GET** /services/managepermission/{id} | get manage permission service
*ServicesApi* | [**GetMyServices**](docs/ServicesApi.md#getmyservices) | **GET** /services/my | get services that can be used to start a request
*ServicesApi* | [**GetServiceId**](docs/ServicesApi.md#getserviceid) | **GET** /services/id | get service id by service name
*ServicesApi* | [**GetSiteLifecycleService**](docs/ServicesApi.md#getsitelifecycleservice) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
*ServicesApi* | [**GetWebLifecycleService**](docs/ServicesApi.md#getweblifecycleservice) | **GET** /services/weblifecycle/{id} | get web lifecycle service
*ServicesApi* | [**ValidateEmailForCreateGuestUserService**](docs/ServicesApi.md#validateemailforcreateguestuserservice) | **GET** /services/createguestuser/{id}/email/validate | validate guest user email
*ServicesApi* | [**ValidateEmailsForCreateGuestUserService**](docs/ServicesApi.md#validateemailsforcreateguestuserservice) | **POST** /services/createguestuser/{id}/email/validate | validate guest user emails
*ServicesApi* | [**ValidateForChangeGroupSettingService**](docs/ServicesApi.md#validateforchangegroupsettingservice) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
*ServicesApi* | [**ValidateForChangeListSettingService**](docs/ServicesApi.md#validateforchangelistsettingservice) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
*ServicesApi* | [**ValidateForChangePermissionService**](docs/ServicesApi.md#validateforchangepermissionservice) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
*ServicesApi* | [**ValidateForChangeSiteContactService**](docs/ServicesApi.md#validateforchangesitecontactservice) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
*ServicesApi* | [**ValidateForChangeSiteSettingService**](docs/ServicesApi.md#validateforchangesitesettingservice) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
*ServicesApi* | [**ValidateForChangeWebContactService**](docs/ServicesApi.md#validateforchangewebcontactservice) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
*ServicesApi* | [**ValidateForChangeWebSettingService**](docs/ServicesApi.md#validateforchangewebsettingservice) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
*ServicesApi* | [**ValidateForClonePermissionService**](docs/ServicesApi.md#validateforclonepermissionservice) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
*ServicesApi* | [**ValidateForContentMoveService**](docs/ServicesApi.md#validateforcontentmoveservice) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
*ServicesApi* | [**ValidateForCreateGuestUserService**](docs/ServicesApi.md#validateforcreateguestuserservice) | **POST** /services/createguestuser/{id}/group/validate | validate groups can invite
*ServicesApi* | [**ValidateForCreateListService**](docs/ServicesApi.md#validateforcreatelistservice) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
*ServicesApi* | [**ValidateForCreateWebService**](docs/ServicesApi.md#validateforcreatewebservice) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
*ServicesApi* | [**ValidateForGrantPermissionService**](docs/ServicesApi.md#validateforgrantpermissionservice) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
*ServicesApi* | [**ValidateForGroupLifecycleService**](docs/ServicesApi.md#validateforgrouplifecycleservice) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
*ServicesApi* | [**ValidateForManagePermissionService**](docs/ServicesApi.md#validateformanagepermissionservice) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
*ServicesApi* | [**ValidateForSiteLifecycleService**](docs/ServicesApi.md#validateforsitelifecycleservice) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
*ServicesApi* | [**ValidateForWebLifecycleService**](docs/ServicesApi.md#validateforweblifecycleservice) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service
*ServicesApi* | [**ValidateTeamForChangePrivateChannelService**](docs/ServicesApi.md#validateteamforchangeprivatechannelservice) | **POST** /services/changeprivatechannel/{serviceId}/team/validation | validate teams for change private channel service
*ServicesApi* | [**ValidateTeamForCreatePrivateChannelService**](docs/ServicesApi.md#validateteamforcreateprivatechannelservice) | **POST** /services/createprivatechannel/{serviceId}/team/validation | validate teams for create private channel service
*ServicesAdminApi* | [**GetServices**](docs/ServicesAdminApi.md#getservices) | **GET** /admin/services | get all services
*SettingsApi* | [**GetDynamicMembershipRuleItems**](docs/SettingsApi.md#getdynamicmembershipruleitems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
*SettingsApi* | [**GetMyPersonalSettings**](docs/SettingsApi.md#getmypersonalsettings) | **GET** /settings/my | get my personal settings
*SettingsApi* | [**GetPermissionLevels**](docs/SettingsApi.md#getpermissionlevels) | **GET** /settings/office365/permissionlevels | get permission levels
*SharedMailboxesAdminApi* | [**GetSharedMailboxes**](docs/SharedMailboxesAdminApi.md#getsharedmailboxes) | **GET** /admin/directory/sharedmailbox | get managed shared mailboxes
*SharedMailboxesAdminApi* | [**GetSharedMailboxesFilters**](docs/SharedMailboxesAdminApi.md#getsharedmailboxesfilters) | **GET** /admin/directory/sharedmailbox/filters | get filters for shared mailbox report
*SharedMailboxesAdminApi* | [**SpecifySharedMailboxContacts**](docs/SharedMailboxesAdminApi.md#specifysharedmailboxcontacts) | **POST** /admin/directory/sharedmailbox/contacts | specify contacts
*SystemSettingsAdminApi* | [**GetHookMessageSamples**](docs/SystemSettingsAdminApi.md#gethookmessagesamples) | **GET** /admin/settings/system/hooks/messages/sample | 
*TasksApi* | [**ApproveTask**](docs/TasksApi.md#approvetask) | **POST** /tasks/{id}/approve | approve task
*TasksApi* | [**EditArchiveGroupRequest**](docs/TasksApi.md#editarchivegrouprequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
*TasksApi* | [**EditArchiveSiteRequest**](docs/TasksApi.md#editarchivesiterequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
*TasksApi* | [**EditArchiveWebRequest**](docs/TasksApi.md#editarchivewebrequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
*TasksApi* | [**EditChangeGroupPolicyRequest**](docs/TasksApi.md#editchangegrouppolicyrequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
*TasksApi* | [**EditChangeGroupQuotaRequest**](docs/TasksApi.md#editchangegroupquotarequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
*TasksApi* | [**EditChangeGroupRequest**](docs/TasksApi.md#editchangegrouprequest) | **PUT** /tasks/{id}/changegroup | edit create change group request
*TasksApi* | [**EditChangeListSettingRequest**](docs/TasksApi.md#editchangelistsettingrequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
*TasksApi* | [**EditChangePermissionRequest**](docs/TasksApi.md#editchangepermissionrequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
*TasksApi* | [**EditChangeSiteContactRequest**](docs/TasksApi.md#editchangesitecontactrequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request
*TasksApi* | [**EditChangeSitePolicyRequest**](docs/TasksApi.md#editchangesitepolicyrequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
*TasksApi* | [**EditChangeSiteQuotaRequest**](docs/TasksApi.md#editchangesitequotarequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
*TasksApi* | [**EditChangeSiteSettingRequest**](docs/TasksApi.md#editchangesitesettingrequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request
*TasksApi* | [**EditChangeWebContactRequest**](docs/TasksApi.md#editchangewebcontactrequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
*TasksApi* | [**EditChangeWebSettingRequest**](docs/TasksApi.md#editchangewebsettingrequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
*TasksApi* | [**EditClonePermissionRequest**](docs/TasksApi.md#editclonepermissionrequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request
*TasksApi* | [**EditContentMoveRequest**](docs/TasksApi.md#editcontentmoverequest) | **PUT** /tasks/{id}/contentmove | edit content move request
*TasksApi* | [**EditCreateGroupRequest**](docs/TasksApi.md#editcreategrouprequest) | **PUT** /tasks/{id}/creategroup | edit create site group request
*TasksApi* | [**EditCreateGuestUserRequest**](docs/TasksApi.md#editcreateguestuserrequest) | **PUT** /tasks/{id}/createguestuser | edit create guest user request in task
*TasksApi* | [**EditCreateListRequest**](docs/TasksApi.md#editcreatelistrequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
*TasksApi* | [**EditCreateSiteRequest**](docs/TasksApi.md#editcreatesiterequest) | **PUT** /tasks/{id}/createsite | edit create site request
*TasksApi* | [**EditCreateWebRequest**](docs/TasksApi.md#editcreatewebrequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
*TasksApi* | [**EditCustomRequest**](docs/TasksApi.md#editcustomrequest) | **PUT** /tasks/{id}/custom | edit custom request
*TasksApi* | [**EditDeleteGroupRequest**](docs/TasksApi.md#editdeletegrouprequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
*TasksApi* | [**EditDeleteSiteRequest**](docs/TasksApi.md#editdeletesiterequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
*TasksApi* | [**EditDeleteWebRequest**](docs/TasksApi.md#editdeletewebrequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
*TasksApi* | [**EditDynamicServiceRequest**](docs/TasksApi.md#editdynamicservicerequest) | **PUT** /tasks/{id}/dynamic | edit dynamic service request
*TasksApi* | [**EditExtendGroupRequest**](docs/TasksApi.md#editextendgrouprequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
*TasksApi* | [**EditExtendSiteRequest**](docs/TasksApi.md#editextendsiterequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
*TasksApi* | [**EditGrantPermissionRequest**](docs/TasksApi.md#editgrantpermissionrequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
*TasksApi* | [**EditLockSiteRequest**](docs/TasksApi.md#editlocksiterequest) | **PUT** /tasks/{id}/locksite | edit lock site request
*TasksApi* | [**EditManagePermissionRequest**](docs/TasksApi.md#editmanagepermissionrequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request
*TasksApi* | [**EditRestoreGroupRequest**](docs/TasksApi.md#editrestoregrouprequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
*TasksApi* | [**EditUnLockSiteRequest**](docs/TasksApi.md#editunlocksiterequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request
*TasksApi* | [**GetBatchTasksById**](docs/TasksApi.md#getbatchtasksbyid) | **GET** /tasks/{id}/batchTasks | get all batch tasks by id
*TasksApi* | [**GetMyTasks**](docs/TasksApi.md#getmytasks) | **GET** /tasks/my/v2 | get my tasks
*TasksApi* | [**GetTaskByBatchId**](docs/TasksApi.md#gettaskbybatchid) | **GET** /tasks/my/{batchid} | get my task by batch id
*TasksApi* | [**GetTaskById**](docs/TasksApi.md#gettaskbyid) | **GET** /tasks/{id} | get task by id
*TasksApi* | [**ReassignTask**](docs/TasksApi.md#reassigntask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
*TasksApi* | [**RejectTask**](docs/TasksApi.md#rejecttask) | **POST** /tasks/{id}/reject | reject task
*TasksApi* | [**RetryErrorTask**](docs/TasksApi.md#retryerrortask) | **POST** /tasks/{id}/retry | retry error task
*TasksApi* | [**SkipErrorTask**](docs/TasksApi.md#skiperrortask) | **POST** /tasks/{id}/skip | skip error task
*TasksApi* | [**SubmitContinueAccessGroupAutoTask**](docs/TasksApi.md#submitcontinueaccessgroupautotask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
*TasksApi* | [**SubmitContinueAccessSiteAutoTask**](docs/TasksApi.md#submitcontinueaccesssiteautotask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
*TasksApi* | [**SubmitExtendGroupAutoTask**](docs/TasksApi.md#submitextendgroupautotask) | **POST** /tasks/extendgroup | submit extend group auto task
*TasksApi* | [**SubmitExtendSiteAutoTask**](docs/TasksApi.md#submitextendsiteautotask) | **POST** /tasks/extendsite | submit site extend auto task
*TasksAdminApi* | [**GetAllTasks**](docs/TasksAdminApi.md#getalltasks) | **GET** /admin/directory/tasks | get all tasks
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedAdGroups**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedadgroups) | **POST** /admin/directory/unmanaged/adgroup/import | manually import existing azure ad groups
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedEnvironments**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedenvironments) | **POST** /admin/directory/unmanaged/environment/import | manually import existing environments
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedGroups**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedgroups) | **POST** /admin/directory/unmanaged/group/import | manually import existing microsoft 365 groups
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedPowerApps**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedpowerapps) | **POST** /admin/directory/unmanaged/powerapps/import | manually import existing power apps
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedPowerAutomate**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedpowerautomate) | **POST** /admin/directory/unmanaged/powerautomate/import | manually import existing power automate
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedPowerBI**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedpowerbi) | **POST** /admin/directory/unmanaged/powerbi/import | manually import existing power bi
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedSharedMailboxes**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedsharedmailboxes) | **POST** /admin/directory/unmanaged/sharedmailbox/import | manually import existing shared mailbox
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedSites**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedsites) | **POST** /admin/directory/unmanaged/site/import | manually import existing site collections
*UnmanagedDirectoryAdminApi* | [**ImportUnmanagedTeams**](docs/UnmanagedDirectoryAdminApi.md#importunmanagedteams) | **POST** /admin/directory/unmanaged/team/import | manually import existing microsoft teams
*UsersApi* | [**FilterUsersByAttribute**](docs/UsersApi.md#filterusersbyattribute) | **GET** /users/filter | filter users by property value
*UsersApi* | [**GetAzureAdUserPropertyValue**](docs/UsersApi.md#getazureaduserpropertyvalue) | **GET** /users/{username}/azuread/property | get Azure Ad user's property value
*UsersApi* | [**GetExtensionAzureAdUserPropertyValues**](docs/UsersApi.md#getextensionazureaduserpropertyvalues) | **GET** /users/{username}/azuread/extensionproperties | get user's extension property value from azure ad
*UsersApi* | [**IsMemberOfGroup**](docs/UsersApi.md#ismemberofgroup) | **GET** /users/{userprincipalname}/ismemberof/{groupid} | Is Member Of Group
*UsersApi* | [**ResolveUsers**](docs/UsersApi.md#resolveusers) | **GET** /users/resolve | resolve users
*UsersApi* | [**SearchUsers**](docs/UsersApi.md#searchusers) | **GET** /users/search | search users
*WorkspaceApi* | [**GetGroupMetadata**](docs/WorkspaceApi.md#getgroupmetadata) | **GET** /workspace/groups/{id}/metadata | get group/teams metadata
*WorkspaceApi* | [**GetMyExchangeResourceInformation**](docs/WorkspaceApi.md#getmyexchangeresourceinformation) | **GET** /workspace/exchangeresource/{id} | 
*WorkspaceApi* | [**GetMyGroupInformation**](docs/WorkspaceApi.md#getmygroupinformation) | **GET** /workspace/groups/{id} | get O365 group/teams information
*WorkspaceApi* | [**GetMyResourceMailboxInformation**](docs/WorkspaceApi.md#getmyresourcemailboxinformation) | **GET** /workspace/resourcemailbox/{id} | 
*WorkspaceApi* | [**GetMySharedMailboxInformation**](docs/WorkspaceApi.md#getmysharedmailboxinformation) | **GET** /workspace/sharedmailbox/{id} | 
*WorkspaceApi* | [**GetMySiteInformation**](docs/WorkspaceApi.md#getmysiteinformation) | **GET** /workspace/sites/{id} | get site information
*WorkspaceApi* | [**GetSiteMetadata**](docs/WorkspaceApi.md#getsitemetadata) | **GET** /workspace/sites/metadata | get site metadata
*WorkspaceApi* | [**GetWorkspaceItems**](docs/WorkspaceApi.md#getworkspaceitems) | **GET** /workspace/my | get my workspace items
*WorkspacesAdminApi* | [**ApplyCommunitiesProfiles**](docs/WorkspacesAdminApi.md#applycommunitiesprofiles) | **POST** /admin/directory/workspace/communities/profiles | apply groups policy
*WorkspacesAdminApi* | [**ApplyGroupProfiles**](docs/WorkspacesAdminApi.md#applygroupprofiles) | **POST** /admin/directory/workspace/group/applyprofiles | apply group profiles
*WorkspacesAdminApi* | [**ApplyGroupsPolicy**](docs/WorkspacesAdminApi.md#applygroupspolicy) | **POST** /admin/directory/workspace/groups/policy | apply groups policy
*WorkspacesAdminApi* | [**ApplySiteProfiles**](docs/WorkspacesAdminApi.md#applysiteprofiles) | **POST** /admin/directory/workspace/sites/profiles | apply site profiles
*WorkspacesAdminApi* | [**ApplySitesPolicy**](docs/WorkspacesAdminApi.md#applysitespolicy) | **POST** /admin/directory/workspace/sites/policy | apply site policy
*WorkspacesAdminApi* | [**ApplyTeamProfiles**](docs/WorkspacesAdminApi.md#applyteamprofiles) | **POST** /admin/directory/workspace/teams/profiles | apply team profiles
*WorkspacesAdminApi* | [**ArchiveWorkspace**](docs/WorkspacesAdminApi.md#archiveworkspace) | **POST** /admin/directory/workspace/archive | archive workspace
*WorkspacesAdminApi* | [**CompleteWorkspaceRenewalTask**](docs/WorkspacesAdminApi.md#completeworkspacerenewaltask) | **POST** /admin/directory/workspace/renewal/complete | completed renewal task
*WorkspacesAdminApi* | [**DeleteWorkspaces**](docs/WorkspacesAdminApi.md#deleteworkspaces) | **DELETE** /admin/directory/workspace | delete workspaces
*WorkspacesAdminApi* | [**GetOngoingTasks**](docs/WorkspacesAdminApi.md#getongoingtasks) | **GET** /admin/directory/workspace/{type}/ongoningtasks | get workspace ongoing tasks
*WorkspacesAdminApi* | [**GetWorkspaceFilters**](docs/WorkspacesAdminApi.md#getworkspacefilters) | **GET** /admin/directory/workspace/filters | get filters for workspace report
*WorkspacesAdminApi* | [**GetWorkspaces**](docs/WorkspacesAdminApi.md#getworkspaces) | **GET** /admin/directory/workspace | get managed workspaces
*WorkspacesAdminApi* | [**GetWorkspacesPost**](docs/WorkspacesAdminApi.md#getworkspacespost) | **POST** /admin/directory/workspace | get managed workspaces
*WorkspacesAdminApi* | [**LockWorkspaces**](docs/WorkspacesAdminApi.md#lockworkspaces) | **POST** /admin/directory/workspace/lock | lock sites or Office365 group sites
*WorkspacesAdminApi* | [**SpecifyContacts**](docs/WorkspacesAdminApi.md#specifycontacts) | **POST** /admin/directory/workspace/contacts | specify contacts
*WorkspacesAdminApi* | [**TriggerWorkspaceRenewal**](docs/WorkspacesAdminApi.md#triggerworkspacerenewal) | **POST** /admin/directory/workspace/renewal/trigger | trigger workspace renewal
*WorkspacesAdminApi* | [**TriggerWorkspacesElection**](docs/WorkspacesAdminApi.md#triggerworkspaceselection) | **POST** /admin/directory/workspace/election/trigger | trigger workspace election
*WorkspacesAdminApi* | [**UnlockWorkspace**](docs/WorkspacesAdminApi.md#unlockworkspace) | **POST** /admin/directory/workspace/unlock | unlock sites and Office365 group site
*WorkspacesAdminApi* | [**UpdateMetadatas**](docs/WorkspacesAdminApi.md#updatemetadatas) | **POST** /admin/directory/workspace/metadata | update metadatas for workspaces


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ActivityModelbase](docs/ActivityModelbase.md)
 - [Model.AddGroupMemberType](docs/AddGroupMemberType.md)
 - [Model.AddSiteColumnToList](docs/AddSiteColumnToList.md)
 - [Model.AdministrativeUnit](docs/AdministrativeUnit.md)
 - [Model.AllRequestDetails](docs/AllRequestDetails.md)
 - [Model.AllRequestDetailsPageResult](docs/AllRequestDetailsPageResult.md)
 - [Model.AllRequestList](docs/AllRequestList.md)
 - [Model.AllRequestListPageResult](docs/AllRequestListPageResult.md)
 - [Model.AllTaskList](docs/AllTaskList.md)
 - [Model.AllTaskListPageResult](docs/AllTaskListPageResult.md)
 - [Model.AnnoymouslinkPermissions](docs/AnnoymouslinkPermissions.md)
 - [Model.AnonymousLinkSettings](docs/AnonymousLinkSettings.md)
 - [Model.ApiCategoryType](docs/ApiCategoryType.md)
 - [Model.ApiCredential](docs/ApiCredential.md)
 - [Model.ApiDurationType](docs/ApiDurationType.md)
 - [Model.ApiError](docs/ApiError.md)
 - [Model.ApiMyGroup](docs/ApiMyGroup.md)
 - [Model.ApiProfileObjectType](docs/ApiProfileObjectType.md)
 - [Model.ApiRequest](docs/ApiRequest.md)
 - [Model.ApiRequestProgressStatus](docs/ApiRequestProgressStatus.md)
 - [Model.ApiSiteStatus](docs/ApiSiteStatus.md)
 - [Model.ApiTask](docs/ApiTask.md)
 - [Model.ApiTaskDynamicProperties](docs/ApiTaskDynamicProperties.md)
 - [Model.ApiUploadFileType](docs/ApiUploadFileType.md)
 - [Model.ApiUser](docs/ApiUser.md)
 - [Model.ApiUserChangedProperty](docs/ApiUserChangedProperty.md)
 - [Model.ApiUserIListChangedProperty](docs/ApiUserIListChangedProperty.md)
 - [Model.ApiUserPageResult](docs/ApiUserPageResult.md)
 - [Model.ApiUserType](docs/ApiUserType.md)
 - [Model.ApmTemplateSetting](docs/ApmTemplateSetting.md)
 - [Model.AppInfo](docs/AppInfo.md)
 - [Model.AppSettingType](docs/AppSettingType.md)
 - [Model.AppSettings](docs/AppSettings.md)
 - [Model.ApplyCommunityProfilesModel](docs/ApplyCommunityProfilesModel.md)
 - [Model.ApplyGroupPolicyModel](docs/ApplyGroupPolicyModel.md)
 - [Model.ApplyPolicyStatus](docs/ApplyPolicyStatus.md)
 - [Model.ApplyProfilesModel](docs/ApplyProfilesModel.md)
 - [Model.ApplySitePolicyModel](docs/ApplySitePolicyModel.md)
 - [Model.ApplyTeamProfilesModel](docs/ApplyTeamProfilesModel.md)
 - [Model.ApproveProcessModel](docs/ApproveProcessModel.md)
 - [Model.ArchiveGroupRequest](docs/ArchiveGroupRequest.md)
 - [Model.ArchiveSiteRequest](docs/ArchiveSiteRequest.md)
 - [Model.ArchiveWebLifecycleRequest](docs/ArchiveWebLifecycleRequest.md)
 - [Model.ArchiveWorkspaceParameter](docs/ArchiveWorkspaceParameter.md)
 - [Model.AssignBy](docs/AssignBy.md)
 - [Model.AssociateToHubSite](docs/AssociateToHubSite.md)
 - [Model.AuthenticationType](docs/AuthenticationType.md)
 - [Model.AutoCompleteRenewalTaskParameter](docs/AutoCompleteRenewalTaskParameter.md)
 - [Model.AutoGenerateUrlSetting](docs/AutoGenerateUrlSetting.md)
 - [Model.AutoGenerateUrlType](docs/AutoGenerateUrlType.md)
 - [Model.AutoImportPhase](docs/AutoImportPhase.md)
 - [Model.AutoImportProcessHookMessage](docs/AutoImportProcessHookMessage.md)
 - [Model.AutoTaskExtendRequest](docs/AutoTaskExtendRequest.md)
 - [Model.AzureAdMetadataSettings](docs/AzureAdMetadataSettings.md)
 - [Model.BackupEnvironmentSetting](docs/BackupEnvironmentSetting.md)
 - [Model.BookingRequestType](docs/BookingRequestType.md)
 - [Model.BooleanChangedProperty](docs/BooleanChangedProperty.md)
 - [Model.BooleanMetadataSettings](docs/BooleanMetadataSettings.md)
 - [Model.BriefGroupPolicy](docs/BriefGroupPolicy.md)
 - [Model.CategoryType](docs/CategoryType.md)
 - [Model.ChangeContactByUrlSetting](docs/ChangeContactByUrlSetting.md)
 - [Model.ChangeContactByUserSetting](docs/ChangeContactByUserSetting.md)
 - [Model.ChangeContactMethod](docs/ChangeContactMethod.md)
 - [Model.ChangeContactObjectModel](docs/ChangeContactObjectModel.md)
 - [Model.ChangeExchangeResourceMembershipGalleryRequestModel](docs/ChangeExchangeResourceMembershipGalleryRequestModel.md)
 - [Model.ChangeExchangeResourceSettingsGroupModel](docs/ChangeExchangeResourceSettingsGroupModel.md)
 - [Model.ChangeGroupPolicyRequest](docs/ChangeGroupPolicyRequest.md)
 - [Model.ChangeGroupPolicyResult](docs/ChangeGroupPolicyResult.md)
 - [Model.ChangeGroupQuotaRequest](docs/ChangeGroupQuotaRequest.md)
 - [Model.ChangeGroupQuotaResult](docs/ChangeGroupQuotaResult.md)
 - [Model.ChangeGroupRequestDescription](docs/ChangeGroupRequestDescription.md)
 - [Model.ChangeGroupRequestName](docs/ChangeGroupRequestName.md)
 - [Model.ChangeGroupRequestVisibility](docs/ChangeGroupRequestVisibility.md)
 - [Model.ChangeGroupSettingCheckResult](docs/ChangeGroupSettingCheckResult.md)
 - [Model.ChangeGroupSettingRequest](docs/ChangeGroupSettingRequest.md)
 - [Model.ChangeGroupSettingService](docs/ChangeGroupSettingService.md)
 - [Model.ChangeGroupSettingValidationParameter](docs/ChangeGroupSettingValidationParameter.md)
 - [Model.ChangeGroupSettingsModel](docs/ChangeGroupSettingsModel.md)
 - [Model.ChangeGroupTeamPicture](docs/ChangeGroupTeamPicture.md)
 - [Model.ChangeHubSiteContentModel](docs/ChangeHubSiteContentModel.md)
 - [Model.ChangeHubSiteContentModelChangedValueRequestModel](docs/ChangeHubSiteContentModelChangedValueRequestModel.md)
 - [Model.ChangeHubSiteMethod](docs/ChangeHubSiteMethod.md)
 - [Model.ChangeHubsiteActionType](docs/ChangeHubsiteActionType.md)
 - [Model.ChangeLicenseGallery](docs/ChangeLicenseGallery.md)
 - [Model.ChangeLicenseModel](docs/ChangeLicenseModel.md)
 - [Model.ChangeLicenseUserModel](docs/ChangeLicenseUserModel.md)
 - [Model.ChangeListSettingObjectInfo](docs/ChangeListSettingObjectInfo.md)
 - [Model.ChangeListSettingRequest](docs/ChangeListSettingRequest.md)
 - [Model.ChangeListSettingService](docs/ChangeListSettingService.md)
 - [Model.ChangeListSettingValidateResult](docs/ChangeListSettingValidateResult.md)
 - [Model.ChangeMetadataActionSetting](docs/ChangeMetadataActionSetting.md)
 - [Model.ChangePermissionRequest](docs/ChangePermissionRequest.md)
 - [Model.ChangePermissionService](docs/ChangePermissionService.md)
 - [Model.ChangePermissionValidateResult](docs/ChangePermissionValidateResult.md)
 - [Model.ChangePictureOptionType](docs/ChangePictureOptionType.md)
 - [Model.ChangePictureOptionTypeForSite](docs/ChangePictureOptionTypeForSite.md)
 - [Model.ChangePolicyActionSetting](docs/ChangePolicyActionSetting.md)
 - [Model.ChangePrivateChannelCheckResult](docs/ChangePrivateChannelCheckResult.md)
 - [Model.ChangePrivateChannelFieldModel](docs/ChangePrivateChannelFieldModel.md)
 - [Model.ChangePrivateChannelFieldName](docs/ChangePrivateChannelFieldName.md)
 - [Model.ChangePrivateChannelQuotaModel](docs/ChangePrivateChannelQuotaModel.md)
 - [Model.ChangePrivateChannelQuotaType](docs/ChangePrivateChannelQuotaType.md)
 - [Model.ChangePrivateChannelRequest](docs/ChangePrivateChannelRequest.md)
 - [Model.ChangePrivateChannelService](docs/ChangePrivateChannelService.md)
 - [Model.ChangePrivateChannelValidationParameter](docs/ChangePrivateChannelValidationParameter.md)
 - [Model.ChangeSecurityGroupSettingsGalleryRequestModel](docs/ChangeSecurityGroupSettingsGalleryRequestModel.md)
 - [Model.ChangeSharedChannelGallery](docs/ChangeSharedChannelGallery.md)
 - [Model.ChangeSharedChannelModel](docs/ChangeSharedChannelModel.md)
 - [Model.ChangeSharedMailboxModel](docs/ChangeSharedMailboxModel.md)
 - [Model.ChangeSharedMailboxPermissionGallery](docs/ChangeSharedMailboxPermissionGallery.md)
 - [Model.ChangeSiteContactElectionProfileModel](docs/ChangeSiteContactElectionProfileModel.md)
 - [Model.ChangeSiteContactRequest](docs/ChangeSiteContactRequest.md)
 - [Model.ChangeSiteContactService](docs/ChangeSiteContactService.md)
 - [Model.ChangeSiteContactSubRequest](docs/ChangeSiteContactSubRequest.md)
 - [Model.ChangeSiteContactValidateResult](docs/ChangeSiteContactValidateResult.md)
 - [Model.ChangeSiteExternalSharingProfileModel](docs/ChangeSiteExternalSharingProfileModel.md)
 - [Model.ChangeSiteHubSiteRequestModel](docs/ChangeSiteHubSiteRequestModel.md)
 - [Model.ChangeSiteObjectModel](docs/ChangeSiteObjectModel.md)
 - [Model.ChangeSitePicture](docs/ChangeSitePicture.md)
 - [Model.ChangeSitePolicyRequest](docs/ChangeSitePolicyRequest.md)
 - [Model.ChangeSitePolicySetting](docs/ChangeSitePolicySetting.md)
 - [Model.ChangeSiteProfileOngoingActionModel](docs/ChangeSiteProfileOngoingActionModel.md)
 - [Model.ChangeSiteProfilesGallery](docs/ChangeSiteProfilesGallery.md)
 - [Model.ChangeSiteProfilesModel](docs/ChangeSiteProfilesModel.md)
 - [Model.ChangeSiteQuotaRequest](docs/ChangeSiteQuotaRequest.md)
 - [Model.ChangeSiteQuotaSettings](docs/ChangeSiteQuotaSettings.md)
 - [Model.ChangeSiteRenewProfileModel](docs/ChangeSiteRenewProfileModel.md)
 - [Model.ChangeSiteSettingGalleryRequestModel](docs/ChangeSiteSettingGalleryRequestModel.md)
 - [Model.ChangeSiteSettingRequest](docs/ChangeSiteSettingRequest.md)
 - [Model.ChangeSiteSettingService](docs/ChangeSiteSettingService.md)
 - [Model.ChangeSiteSettingValidateResult](docs/ChangeSiteSettingValidateResult.md)
 - [Model.ChangeSiteSharingRequestModel](docs/ChangeSiteSharingRequestModel.md)
 - [Model.ChangeSiteStorageManagementProfileModel](docs/ChangeSiteStorageManagementProfileModel.md)
 - [Model.ChangeSiteStorageSettingModel](docs/ChangeSiteStorageSettingModel.md)
 - [Model.ChangeTeamClassificationAndSensitivityLabel](docs/ChangeTeamClassificationAndSensitivityLabel.md)
 - [Model.ChangeTeamDisplayName](docs/ChangeTeamDisplayName.md)
 - [Model.ChangeTeamFunStuff](docs/ChangeTeamFunStuff.md)
 - [Model.ChangeTeamMemberPermission](docs/ChangeTeamMemberPermission.md)
 - [Model.ChangeTeamMentions](docs/ChangeTeamMentions.md)
 - [Model.ChangeTeamPrivacySetting](docs/ChangeTeamPrivacySetting.md)
 - [Model.ChangeTeamRequestDescription](docs/ChangeTeamRequestDescription.md)
 - [Model.ChangeTeamSettingGalleryRequestModel](docs/ChangeTeamSettingGalleryRequestModel.md)
 - [Model.ChangeTeamSettingModel](docs/ChangeTeamSettingModel.md)
 - [Model.ChangeTemplateGiphyRatingType](docs/ChangeTemplateGiphyRatingType.md)
 - [Model.ChangeWebContactByUrlSetting](docs/ChangeWebContactByUrlSetting.md)
 - [Model.ChangeWebContactRequest](docs/ChangeWebContactRequest.md)
 - [Model.ChangeWebContactService](docs/ChangeWebContactService.md)
 - [Model.ChangeWebContactSubRequest](docs/ChangeWebContactSubRequest.md)
 - [Model.ChangeWebContactValidateResult](docs/ChangeWebContactValidateResult.md)
 - [Model.ChangeWebSPObject](docs/ChangeWebSPObject.md)
 - [Model.ChangeWebSettingRequest](docs/ChangeWebSettingRequest.md)
 - [Model.ChangeWebSettingService](docs/ChangeWebSettingService.md)
 - [Model.ChangeWebUrlValidateResult](docs/ChangeWebUrlValidateResult.md)
 - [Model.ChangedLicense](docs/ChangedLicense.md)
 - [Model.ChangedMembership](docs/ChangedMembership.md)
 - [Model.ChangedSiteDesignModel](docs/ChangedSiteDesignModel.md)
 - [Model.ChangedSiteDesignModelChangedValueRequestModel](docs/ChangedSiteDesignModelChangedValueRequestModel.md)
 - [Model.ChoiceMetadataSettings](docs/ChoiceMetadataSettings.md)
 - [Model.ChoiceType](docs/ChoiceType.md)
 - [Model.ClaimStatus](docs/ClaimStatus.md)
 - [Model.ClonePermissionAdditionalOption](docs/ClonePermissionAdditionalOption.md)
 - [Model.ClonePermissionOption](docs/ClonePermissionOption.md)
 - [Model.ClonePermissionRequest](docs/ClonePermissionRequest.md)
 - [Model.ClonePermissionService](docs/ClonePermissionService.md)
 - [Model.ClonePermissionValidateResult](docs/ClonePermissionValidateResult.md)
 - [Model.CloneTeam](docs/CloneTeam.md)
 - [Model.CommentsParam](docs/CommentsParam.md)
 - [Model.CommonSharingExpirationType](docs/CommonSharingExpirationType.md)
 - [Model.CommonStatus](docs/CommonStatus.md)
 - [Model.Communication](docs/Communication.md)
 - [Model.ConflictResolutionSetting](docs/ConflictResolutionSetting.md)
 - [Model.ConflictSolutionType](docs/ConflictSolutionType.md)
 - [Model.ConstructGroupId](docs/ConstructGroupId.md)
 - [Model.ConstructedUrl](docs/ConstructedUrl.md)
 - [Model.ConstructureType](docs/ConstructureType.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactInformation](docs/ContactInformation.md)
 - [Model.ContainerInfo](docs/ContainerInfo.md)
 - [Model.ContainerScopeSetting](docs/ContainerScopeSetting.md)
 - [Model.ContainerScopeType](docs/ContainerScopeType.md)
 - [Model.ContentMoveAction](docs/ContentMoveAction.md)
 - [Model.ContentMoveCommonSetting](docs/ContentMoveCommonSetting.md)
 - [Model.ContentMoveMethod](docs/ContentMoveMethod.md)
 - [Model.ContentMoveProfileMappings](docs/ContentMoveProfileMappings.md)
 - [Model.ContentMoveProfiles](docs/ContentMoveProfiles.md)
 - [Model.ContentMoveRequest](docs/ContentMoveRequest.md)
 - [Model.ContentMoveSPObject](docs/ContentMoveSPObject.md)
 - [Model.ContentMoveSPObjectMapping](docs/ContentMoveSPObjectMapping.md)
 - [Model.ContentMoveService](docs/ContentMoveService.md)
 - [Model.ContentMoveUrlValidationParameter](docs/ContentMoveUrlValidationParameter.md)
 - [Model.ContentMoveUrlValidationResult](docs/ContentMoveUrlValidationResult.md)
 - [Model.ContentTypes](docs/ContentTypes.md)
 - [Model.ContructUrlSetting](docs/ContructUrlSetting.md)
 - [Model.ConvertAutomaticReply](docs/ConvertAutomaticReply.md)
 - [Model.ConvertEmail](docs/ConvertEmail.md)
 - [Model.ConvertHubSite](docs/ConvertHubSite.md)
 - [Model.ConvertHubSiteActionType](docs/ConvertHubSiteActionType.md)
 - [Model.CopyMoveSetting](docs/CopyMoveSetting.md)
 - [Model.CopyMoveSettingAssignBy](docs/CopyMoveSettingAssignBy.md)
 - [Model.CreateCommunityGallery](docs/CreateCommunityGallery.md)
 - [Model.CreateDistributionListGallery](docs/CreateDistributionListGallery.md)
 - [Model.CreateEquipmentMailboxGallery](docs/CreateEquipmentMailboxGallery.md)
 - [Model.CreateGroupGallery](docs/CreateGroupGallery.md)
 - [Model.CreateGroupRequest](docs/CreateGroupRequest.md)
 - [Model.CreateGroupService](docs/CreateGroupService.md)
 - [Model.CreateGroupType](docs/CreateGroupType.md)
 - [Model.CreateGuestUserRequest](docs/CreateGuestUserRequest.md)
 - [Model.CreateGuestUserService](docs/CreateGuestUserService.md)
 - [Model.CreateGuestUserSubRequest](docs/CreateGuestUserSubRequest.md)
 - [Model.CreateGuestUserValidationResult](docs/CreateGuestUserValidationResult.md)
 - [Model.CreateLibraryGallery](docs/CreateLibraryGallery.md)
 - [Model.CreateListRequest](docs/CreateListRequest.md)
 - [Model.CreateListSPObject](docs/CreateListSPObject.md)
 - [Model.CreateListService](docs/CreateListService.md)
 - [Model.CreateListUrlSettings](docs/CreateListUrlSettings.md)
 - [Model.CreateListUrlValidationResult](docs/CreateListUrlValidationResult.md)
 - [Model.CreateMailEnabledGroupGallery](docs/CreateMailEnabledGroupGallery.md)
 - [Model.CreatePrivateChannelCheckResult](docs/CreatePrivateChannelCheckResult.md)
 - [Model.CreatePrivateChannelRequest](docs/CreatePrivateChannelRequest.md)
 - [Model.CreatePrivateChannelService](docs/CreatePrivateChannelService.md)
 - [Model.CreatePrivateChannelValidationParameter](docs/CreatePrivateChannelValidationParameter.md)
 - [Model.CreateResourceMailboxAddressBookPolicyRequestModel](docs/CreateResourceMailboxAddressBookPolicyRequestModel.md)
 - [Model.CreateResourceMailboxAliasRequestModel](docs/CreateResourceMailboxAliasRequestModel.md)
 - [Model.CreateResourceMailboxBookingDelegateSettingRequestModel](docs/CreateResourceMailboxBookingDelegateSettingRequestModel.md)
 - [Model.CreateResourceMailboxBookingOptionRequestModel](docs/CreateResourceMailboxBookingOptionRequestModel.md)
 - [Model.CreateResourceMailboxCapacityRequestModel](docs/CreateResourceMailboxCapacityRequestModel.md)
 - [Model.CreateResourceMailboxCompanyRequestModel](docs/CreateResourceMailboxCompanyRequestModel.md)
 - [Model.CreateResourceMailboxContactInformationRequestModel](docs/CreateResourceMailboxContactInformationRequestModel.md)
 - [Model.CreateResourceMailboxDepartmentRequestModel](docs/CreateResourceMailboxDepartmentRequestModel.md)
 - [Model.CreateResourceMailboxDisableAccountRequestModel](docs/CreateResourceMailboxDisableAccountRequestModel.md)
 - [Model.CreateResourceMailboxExchangeGlobalAddressListRequestModel](docs/CreateResourceMailboxExchangeGlobalAddressListRequestModel.md)
 - [Model.CreateResourceMailboxMailTipRequestModel](docs/CreateResourceMailboxMailTipRequestModel.md)
 - [Model.CreateRoomMailboxAdditionalInformationRequestModel](docs/CreateRoomMailboxAdditionalInformationRequestModel.md)
 - [Model.CreateRoomMailboxGallery](docs/CreateRoomMailboxGallery.md)
 - [Model.CreateRoomMailboxRoomListRequestModel](docs/CreateRoomMailboxRoomListRequestModel.md)
 - [Model.CreateRoomMailboxRoomPlaceRequestModel](docs/CreateRoomMailboxRoomPlaceRequestModel.md)
 - [Model.CreateSecurityGroupGallery](docs/CreateSecurityGroupGallery.md)
 - [Model.CreateSharedChannelGallery](docs/CreateSharedChannelGallery.md)
 - [Model.CreateSharedChannelModel](docs/CreateSharedChannelModel.md)
 - [Model.CreateSharedMailboxGallery](docs/CreateSharedMailboxGallery.md)
 - [Model.CreateSiteGallery](docs/CreateSiteGallery.md)
 - [Model.CreateSiteRequest](docs/CreateSiteRequest.md)
 - [Model.CreateSiteService](docs/CreateSiteService.md)
 - [Model.CreateTeamGallery](docs/CreateTeamGallery.md)
 - [Model.CreateWebRequest](docs/CreateWebRequest.md)
 - [Model.CreateWebScopeSettings](docs/CreateWebScopeSettings.md)
 - [Model.CreateWebService](docs/CreateWebService.md)
 - [Model.CreateWebUrlValidationResult](docs/CreateWebUrlValidationResult.md)
 - [Model.CreateWebValidationParameter](docs/CreateWebValidationParameter.md)
 - [Model.CustomActionSettings](docs/CustomActionSettings.md)
 - [Model.CustomExtensionPropertyModel](docs/CustomExtensionPropertyModel.md)
 - [Model.CustomMetadata](docs/CustomMetadata.md)
 - [Model.CustomSiteTemplate](docs/CustomSiteTemplate.md)
 - [Model.DRPermissionSetting](docs/DRPermissionSetting.md)
 - [Model.DRSiteTemplate](docs/DRSiteTemplate.md)
 - [Model.DRSiteUrlSetting](docs/DRSiteUrlSetting.md)
 - [Model.DelegatedAccessToken](docs/DelegatedAccessToken.md)
 - [Model.DelegatedAccessTokenApiResult](docs/DelegatedAccessTokenApiResult.md)
 - [Model.DeleteGroupRequest](docs/DeleteGroupRequest.md)
 - [Model.DeleteSiteRequest](docs/DeleteSiteRequest.md)
 - [Model.DeleteType](docs/DeleteType.md)
 - [Model.DeleteWebLifecycleRequest](docs/DeleteWebLifecycleRequest.md)
 - [Model.DeleteWorkspaceParameter](docs/DeleteWorkspaceParameter.md)
 - [Model.DeliveryManagement](docs/DeliveryManagement.md)
 - [Model.DeliveryStatusNotificationsRequestModel](docs/DeliveryStatusNotificationsRequestModel.md)
 - [Model.DeploymentManagerPlanSettings](docs/DeploymentManagerPlanSettings.md)
 - [Model.DepthLimitSetting](docs/DepthLimitSetting.md)
 - [Model.DirectorySyncState](docs/DirectorySyncState.md)
 - [Model.DisplayInReportType](docs/DisplayInReportType.md)
 - [Model.DistinctResult](docs/DistinctResult.md)
 - [Model.DpmPlanSetting](docs/DpmPlanSetting.md)
 - [Model.DpmServiceSetting](docs/DpmServiceSetting.md)
 - [Model.DueDateType](docs/DueDateType.md)
 - [Model.DurationDateType](docs/DurationDateType.md)
 - [Model.DynamicChangeContactGalleryRequestModel](docs/DynamicChangeContactGalleryRequestModel.md)
 - [Model.DynamicChangeContactModel](docs/DynamicChangeContactModel.md)
 - [Model.DynamicExchangeResource](docs/DynamicExchangeResource.md)
 - [Model.DynamicGroupRule](docs/DynamicGroupRule.md)
 - [Model.DynamicGroupRuleInfo](docs/DynamicGroupRuleInfo.md)
 - [Model.DynamicGroupRuleModel](docs/DynamicGroupRuleModel.md)
 - [Model.DynamicMembership](docs/DynamicMembership.md)
 - [Model.DynamicRequest](docs/DynamicRequest.md)
 - [Model.DynamicRequestTemplateModel](docs/DynamicRequestTemplateModel.md)
 - [Model.DynamicRuleCondition](docs/DynamicRuleCondition.md)
 - [Model.DynamicRuleConditionType](docs/DynamicRuleConditionType.md)
 - [Model.DynamicRuleElement](docs/DynamicRuleElement.md)
 - [Model.DynamicServiceForRequest](docs/DynamicServiceForRequest.md)
 - [Model.ElectionContact](docs/ElectionContact.md)
 - [Model.ElectionHookMessage](docs/ElectionHookMessage.md)
 - [Model.EmailAddress](docs/EmailAddress.md)
 - [Model.EmailForward](docs/EmailForward.md)
 - [Model.EndUserReportMetadata](docs/EndUserReportMetadata.md)
 - [Model.EnpowerContactStatus](docs/EnpowerContactStatus.md)
 - [Model.EntraGroupLifecycleActionType](docs/EntraGroupLifecycleActionType.md)
 - [Model.ExchangeResourceLifecycleGallery](docs/ExchangeResourceLifecycleGallery.md)
 - [Model.ExchangeResourceStatus](docs/ExchangeResourceStatus.md)
 - [Model.ExchangeResourceType](docs/ExchangeResourceType.md)
 - [Model.ExecutionModel](docs/ExecutionModel.md)
 - [Model.ExecutionParameter](docs/ExecutionParameter.md)
 - [Model.ExpirationType](docs/ExpirationType.md)
 - [Model.ExtendGroupRequest](docs/ExtendGroupRequest.md)
 - [Model.ExtendGroupResult](docs/ExtendGroupResult.md)
 - [Model.ExtendSiteRequest](docs/ExtendSiteRequest.md)
 - [Model.ExtendSiteSetting](docs/ExtendSiteSetting.md)
 - [Model.ExtendType](docs/ExtendType.md)
 - [Model.ExternalDomainListType](docs/ExternalDomainListType.md)
 - [Model.ExternalSharingOptions](docs/ExternalSharingOptions.md)
 - [Model.ExternalSharingProfile](docs/ExternalSharingProfile.md)
 - [Model.ExternalUserSharingSettings](docs/ExternalUserSharingSettings.md)
 - [Model.ExternalUserSharingType](docs/ExternalUserSharingType.md)
 - [Model.ExternalUserState](docs/ExternalUserState.md)
 - [Model.ExternalUserType](docs/ExternalUserType.md)
 - [Model.FolderDefaultValueSetting](docs/FolderDefaultValueSetting.md)
 - [Model.GallerySetting](docs/GallerySetting.md)
 - [Model.Gallerybase](docs/Gallerybase.md)
 - [Model.GeoLocationBase](docs/GeoLocationBase.md)
 - [Model.GeoLocationModel](docs/GeoLocationModel.md)
 - [Model.GiphyRatingType](docs/GiphyRatingType.md)
 - [Model.GlobalAddressList](docs/GlobalAddressList.md)
 - [Model.GovernancePanel](docs/GovernancePanel.md)
 - [Model.GrantPermissionGroup](docs/GrantPermissionGroup.md)
 - [Model.GrantPermissionModel](docs/GrantPermissionModel.md)
 - [Model.GrantPermissionRequest](docs/GrantPermissionRequest.md)
 - [Model.GrantPermissionRequestDurationSettings](docs/GrantPermissionRequestDurationSettings.md)
 - [Model.GrantPermissionRequestPermissionSettings](docs/GrantPermissionRequestPermissionSettings.md)
 - [Model.GrantPermissionSPObject](docs/GrantPermissionSPObject.md)
 - [Model.GrantPermissionService](docs/GrantPermissionService.md)
 - [Model.GrantPermissionServiceDurationSettings](docs/GrantPermissionServiceDurationSettings.md)
 - [Model.GrantPermissionServicePermissionSettings](docs/GrantPermissionServicePermissionSettings.md)
 - [Model.GrantPermissionUrlValidationResult](docs/GrantPermissionUrlValidationResult.md)
 - [Model.GroupClassificationModel](docs/GroupClassificationModel.md)
 - [Model.GroupConstructureRule](docs/GroupConstructureRule.md)
 - [Model.GroupEnableSharingStatus](docs/GroupEnableSharingStatus.md)
 - [Model.GroupIdConstructureSettings](docs/GroupIdConstructureSettings.md)
 - [Model.GroupIdRuleType](docs/GroupIdRuleType.md)
 - [Model.GroupInOutRuleType](docs/GroupInOutRuleType.md)
 - [Model.GroupLeasePeriodSettings](docs/GroupLeasePeriodSettings.md)
 - [Model.GroupLeasePeriodType](docs/GroupLeasePeriodType.md)
 - [Model.GroupLifecycleActionType](docs/GroupLifecycleActionType.md)
 - [Model.GroupLifecycleRequest](docs/GroupLifecycleRequest.md)
 - [Model.GroupLifecycleService](docs/GroupLifecycleService.md)
 - [Model.GroupLifecycleValidateResult](docs/GroupLifecycleValidateResult.md)
 - [Model.GroupLinks](docs/GroupLinks.md)
 - [Model.GroupMembershipAction](docs/GroupMembershipAction.md)
 - [Model.GroupMembershipItem](docs/GroupMembershipItem.md)
 - [Model.GroupNameConstructureSettings](docs/GroupNameConstructureSettings.md)
 - [Model.GroupObjectType](docs/GroupObjectType.md)
 - [Model.GroupOwnerType](docs/GroupOwnerType.md)
 - [Model.GroupPolicySubType](docs/GroupPolicySubType.md)
 - [Model.GroupRestrictionType](docs/GroupRestrictionType.md)
 - [Model.GroupScopeType](docs/GroupScopeType.md)
 - [Model.GroupSettingModel](docs/GroupSettingModel.md)
 - [Model.GroupStatus](docs/GroupStatus.md)
 - [Model.GroupTeamPicture](docs/GroupTeamPicture.md)
 - [Model.GroupUser](docs/GroupUser.md)
 - [Model.GroupValidationParameter](docs/GroupValidationParameter.md)
 - [Model.GuestPermissions](docs/GuestPermissions.md)
 - [Model.GuestUserGridModel](docs/GuestUserGridModel.md)
 - [Model.GuestUserGridModelPageResult](docs/GuestUserGridModelPageResult.md)
 - [Model.GuestUserPropertyModel](docs/GuestUserPropertyModel.md)
 - [Model.GuestUserRequestOneTimeRenewalSettingModel](docs/GuestUserRequestOneTimeRenewalSettingModel.md)
 - [Model.GuestUserStatus](docs/GuestUserStatus.md)
 - [Model.GuidBooleanModel](docs/GuidBooleanModel.md)
 - [Model.GuidModel](docs/GuidModel.md)
 - [Model.HandleOngoingType](docs/HandleOngoingType.md)
 - [Model.HandleTaskType](docs/HandleTaskType.md)
 - [Model.HookMessageList](docs/HookMessageList.md)
 - [Model.HookMessageObjectType](docs/HookMessageObjectType.md)
 - [Model.HubSiteChangedSettings](docs/HubSiteChangedSettings.md)
 - [Model.HubSiteSetting](docs/HubSiteSetting.md)
 - [Model.HubSiteSettings](docs/HubSiteSettings.md)
 - [Model.HubSiteType](docs/HubSiteType.md)
 - [Model.HubSiteUrl](docs/HubSiteUrl.md)
 - [Model.ImportEnvironmentModel](docs/ImportEnvironmentModel.md)
 - [Model.ImportGroupModel](docs/ImportGroupModel.md)
 - [Model.ImportMetadataModel](docs/ImportMetadataModel.md)
 - [Model.ImportObjectType](docs/ImportObjectType.md)
 - [Model.ImportSharedMailboxModel](docs/ImportSharedMailboxModel.md)
 - [Model.ImportSiteModel](docs/ImportSiteModel.md)
 - [Model.ImportTeamModel](docs/ImportTeamModel.md)
 - [Model.InformationIconSetting](docs/InformationIconSetting.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InsightsStatus](docs/InsightsStatus.md)
 - [Model.Int32ChangedValueRequestModel](docs/Int32ChangedValueRequestModel.md)
 - [Model.Int64ChangedProperty](docs/Int64ChangedProperty.md)
 - [Model.Int64ChangedValueRequestModel](docs/Int64ChangedValueRequestModel.md)
 - [Model.IntModel](docs/IntModel.md)
 - [Model.InviteGuestAddToGroupsRequestModel](docs/InviteGuestAddToGroupsRequestModel.md)
 - [Model.InviteGuestContactInformationRequestModel](docs/InviteGuestContactInformationRequestModel.md)
 - [Model.InviteGuestGallery](docs/InviteGuestGallery.md)
 - [Model.InviteGuestMode](docs/InviteGuestMode.md)
 - [Model.InviteGuestOneTimeRenewalSettingModel](docs/InviteGuestOneTimeRenewalSettingModel.md)
 - [Model.InviteGuestRenewalProfileRequestModel](docs/InviteGuestRenewalProfileRequestModel.md)
 - [Model.InviteGuestScopeRequestModel](docs/InviteGuestScopeRequestModel.md)
 - [Model.InviteGuestUsageLocationRequestModel](docs/InviteGuestUsageLocationRequestModel.md)
 - [Model.InviteGuestUserPropertyRequestModel](docs/InviteGuestUserPropertyRequestModel.md)
 - [Model.InviteGuestUserTypePropertyRequestModel](docs/InviteGuestUserTypePropertyRequestModel.md)
 - [Model.InviteMultipleGuestRequestModel](docs/InviteMultipleGuestRequestModel.md)
 - [Model.InviteType](docs/InviteType.md)
 - [Model.ItemConflictResolutionType](docs/ItemConflictResolutionType.md)
 - [Model.JobMode](docs/JobMode.md)
 - [Model.JobMonitorGridModel](docs/JobMonitorGridModel.md)
 - [Model.JobMonitorGridModelPageResult](docs/JobMonitorGridModelPageResult.md)
 - [Model.JobMonitorModel](docs/JobMonitorModel.md)
 - [Model.JobStatus](docs/JobStatus.md)
 - [Model.JobType](docs/JobType.md)
 - [Model.JoinGroupApproval](docs/JoinGroupApproval.md)
 - [Model.LanguageWithTemplates](docs/LanguageWithTemplates.md)
 - [Model.LeaseDateType](docs/LeaseDateType.md)
 - [Model.LeaseStartDateType](docs/LeaseStartDateType.md)
 - [Model.LibraryDesign](docs/LibraryDesign.md)
 - [Model.LibraryRecordDeclaration](docs/LibraryRecordDeclaration.md)
 - [Model.LibraryScope](docs/LibraryScope.md)
 - [Model.LibraryVersionSetting](docs/LibraryVersionSetting.md)
 - [Model.LicenseInfo](docs/LicenseInfo.md)
 - [Model.LicenseUpdateInfo](docs/LicenseUpdateInfo.md)
 - [Model.LifecycleAction](docs/LifecycleAction.md)
 - [Model.LifecycleActions](docs/LifecycleActions.md)
 - [Model.LifecycleHookMessage](docs/LifecycleHookMessage.md)
 - [Model.LifecycleJobTimeBaseType](docs/LifecycleJobTimeBaseType.md)
 - [Model.LifecycleRenewalSetting](docs/LifecycleRenewalSetting.md)
 - [Model.LifecycleSCModel](docs/LifecycleSCModel.md)
 - [Model.LifecycleScopeSetting](docs/LifecycleScopeSetting.md)
 - [Model.LifecycleTeamModel](docs/LifecycleTeamModel.md)
 - [Model.LinkMetadataSettings](docs/LinkMetadataSettings.md)
 - [Model.LinkPermissionType](docs/LinkPermissionType.md)
 - [Model.LinkPermissionTypeChangedValueRequestModel](docs/LinkPermissionTypeChangedValueRequestModel.md)
 - [Model.LinkValue](docs/LinkValue.md)
 - [Model.ListColumnDefaultValue](docs/ListColumnDefaultValue.md)
 - [Model.ListPermissionSetting](docs/ListPermissionSetting.md)
 - [Model.ListPermissionSettings](docs/ListPermissionSettings.md)
 - [Model.ListTemplate](docs/ListTemplate.md)
 - [Model.ListTemplateSettings](docs/ListTemplateSettings.md)
 - [Model.ListType](docs/ListType.md)
 - [Model.ListValidationParameter](docs/ListValidationParameter.md)
 - [Model.ListVersionSettings](docs/ListVersionSettings.md)
 - [Model.ListVersionSettingsChangedProperty](docs/ListVersionSettingsChangedProperty.md)
 - [Model.LocaleSettings](docs/LocaleSettings.md)
 - [Model.LocalizedMetadataTermsAndConditionsModel](docs/LocalizedMetadataTermsAndConditionsModel.md)
 - [Model.LockSiteCollectionType](docs/LockSiteCollectionType.md)
 - [Model.LockSiteParameter](docs/LockSiteParameter.md)
 - [Model.LockSiteRequest](docs/LockSiteRequest.md)
 - [Model.LockSiteSetting](docs/LockSiteSetting.md)
 - [Model.LockedBy](docs/LockedBy.md)
 - [Model.LogicalOperator](docs/LogicalOperator.md)
 - [Model.LogicalOperatorType](docs/LogicalOperatorType.md)
 - [Model.LookupListValue](docs/LookupListValue.md)
 - [Model.LookupValue](docs/LookupValue.md)
 - [Model.M365GroupLifecycleActionType](docs/M365GroupLifecycleActionType.md)
 - [Model.M365GroupLifecycleActions](docs/M365GroupLifecycleActions.md)
 - [Model.M365GroupLifecycleGallery](docs/M365GroupLifecycleGallery.md)
 - [Model.M365GroupLifecycleModel](docs/M365GroupLifecycleModel.md)
 - [Model.M365GroupLifecycleScopeSetting](docs/M365GroupLifecycleScopeSetting.md)
 - [Model.MailboxAutoMapping](docs/MailboxAutoMapping.md)
 - [Model.MailboxAutomaticReply](docs/MailboxAutomaticReply.md)
 - [Model.MailboxLanguageDataTime](docs/MailboxLanguageDataTime.md)
 - [Model.MailboxSentItems](docs/MailboxSentItems.md)
 - [Model.MailboxSharedMailboxPolicy](docs/MailboxSharedMailboxPolicy.md)
 - [Model.ManagePermissionAction](docs/ManagePermissionAction.md)
 - [Model.ManagePermissionGrantSetting](docs/ManagePermissionGrantSetting.md)
 - [Model.ManagePermissionOption](docs/ManagePermissionOption.md)
 - [Model.ManagePermissionRequest](docs/ManagePermissionRequest.md)
 - [Model.ManagePermissionSPObject](docs/ManagePermissionSPObject.md)
 - [Model.ManagePermissionService](docs/ManagePermissionService.md)
 - [Model.ManagePermissionSharePointGroupOption](docs/ManagePermissionSharePointGroupOption.md)
 - [Model.ManagePermissionUserSetting](docs/ManagePermissionUserSetting.md)
 - [Model.ManagePermissionValidateResult](docs/ManagePermissionValidateResult.md)
 - [Model.ManualImportAdGroupJobModel](docs/ManualImportAdGroupJobModel.md)
 - [Model.ManualImportEnvironmentJobModel](docs/ManualImportEnvironmentJobModel.md)
 - [Model.ManualImportGroupJobModel](docs/ManualImportGroupJobModel.md)
 - [Model.ManualImportPowerAppsJobModel](docs/ManualImportPowerAppsJobModel.md)
 - [Model.ManualImportPowerAutomateJobModel](docs/ManualImportPowerAutomateJobModel.md)
 - [Model.ManualImportPowerBIJobModel](docs/ManualImportPowerBIJobModel.md)
 - [Model.ManualImportSharedMailboxJobModel](docs/ManualImportSharedMailboxJobModel.md)
 - [Model.ManualImportSiteJobModel](docs/ManualImportSiteJobModel.md)
 - [Model.ManualImportTeamJobModel](docs/ManualImportTeamJobModel.md)
 - [Model.ManuallyInputUrlSetting](docs/ManuallyInputUrlSetting.md)
 - [Model.MembershipApproval](docs/MembershipApproval.md)
 - [Model.MembershipUserType](docs/MembershipUserType.md)
 - [Model.MessageApproval](docs/MessageApproval.md)
 - [Model.MessageCode](docs/MessageCode.md)
 - [Model.MetadataActionType](docs/MetadataActionType.md)
 - [Model.MetadataDisplayType](docs/MetadataDisplayType.md)
 - [Model.MetadataFieldType](docs/MetadataFieldType.md)
 - [Model.MultiGeoControlMode](docs/MultiGeoControlMode.md)
 - [Model.MultiGeoLocationSetting](docs/MultiGeoLocationSetting.md)
 - [Model.MultiGeoSerivceSetting](docs/MultiGeoSerivceSetting.md)
 - [Model.MultiGeoSetting](docs/MultiGeoSetting.md)
 - [Model.MyExchangeResource](docs/MyExchangeResource.md)
 - [Model.MyResourceMailbox](docs/MyResourceMailbox.md)
 - [Model.MySharedMailbox](docs/MySharedMailbox.md)
 - [Model.MySite](docs/MySite.md)
 - [Model.MySiteType](docs/MySiteType.md)
 - [Model.NameDescription](docs/NameDescription.md)
 - [Model.NavigationSetting](docs/NavigationSetting.md)
 - [Model.NodeType](docs/NodeType.md)
 - [Model.NonAzureAdMetadataSettings](docs/NonAzureAdMetadataSettings.md)
 - [Model.NotifyOpusForNewFilesRequestModel](docs/NotifyOpusForNewFilesRequestModel.md)
 - [Model.ObjectPermissionManagementModel](docs/ObjectPermissionManagementModel.md)
 - [Model.ObjectValidateResult](docs/ObjectValidateResult.md)
 - [Model.Office365SiteSettingModel](docs/Office365SiteSettingModel.md)
 - [Model.Office365Tenant](docs/Office365Tenant.md)
 - [Model.OfficeTenant](docs/OfficeTenant.md)
 - [Model.OldMetadataGridModel](docs/OldMetadataGridModel.md)
 - [Model.OldMetadataGridModelPageResult](docs/OldMetadataGridModelPageResult.md)
 - [Model.OneTimeRenewalOption](docs/OneTimeRenewalOption.md)
 - [Model.OutlookExperience](docs/OutlookExperience.md)
 - [Model.OutsideSenders](docs/OutsideSenders.md)
 - [Model.PermissionChangedType](docs/PermissionChangedType.md)
 - [Model.PermissionLevel](docs/PermissionLevel.md)
 - [Model.PermissionManagementModel](docs/PermissionManagementModel.md)
 - [Model.PermissionObjectProperty](docs/PermissionObjectProperty.md)
 - [Model.PermissionSettings](docs/PermissionSettings.md)
 - [Model.PersonalSettings](docs/PersonalSettings.md)
 - [Model.PersonalSettingsPropertyInfo](docs/PersonalSettingsPropertyInfo.md)
 - [Model.PnpTemplate](docs/PnpTemplate.md)
 - [Model.PolicyWithTemplates](docs/PolicyWithTemplates.md)
 - [Model.PredefinedOwnerOrMembers](docs/PredefinedOwnerOrMembers.md)
 - [Model.PrincipalType](docs/PrincipalType.md)
 - [Model.Privacy](docs/Privacy.md)
 - [Model.QueryTemplateResultModel](docs/QueryTemplateResultModel.md)
 - [Model.QuestionAnswerResponse](docs/QuestionAnswerResponse.md)
 - [Model.QuotaProfile](docs/QuotaProfile.md)
 - [Model.RegisterAsHubSite](docs/RegisterAsHubSite.md)
 - [Model.RemoteNodeInfo](docs/RemoteNodeInfo.md)
 - [Model.RemoteNodeType](docs/RemoteNodeType.md)
 - [Model.RenewalProfile](docs/RenewalProfile.md)
 - [Model.RenewalTaskHookMessage](docs/RenewalTaskHookMessage.md)
 - [Model.ReportMetadata](docs/ReportMetadata.md)
 - [Model.RequestGroupWithPermissions](docs/RequestGroupWithPermissions.md)
 - [Model.RequestHookMessage](docs/RequestHookMessage.md)
 - [Model.RequestList](docs/RequestList.md)
 - [Model.RequestListPageResult](docs/RequestListPageResult.md)
 - [Model.RequestMetadata](docs/RequestMetadata.md)
 - [Model.RequestMetadataListChangedProperty](docs/RequestMetadataListChangedProperty.md)
 - [Model.RequestProgressStatus](docs/RequestProgressStatus.md)
 - [Model.RequestResourceType](docs/RequestResourceType.md)
 - [Model.RequestSensitivityLabel](docs/RequestSensitivityLabel.md)
 - [Model.RequestStatus](docs/RequestStatus.md)
 - [Model.RequestTeamsSettings](docs/RequestTeamsSettings.md)
 - [Model.RequestUserWithPermissions](docs/RequestUserWithPermissions.md)
 - [Model.RestoreGroupRequest](docs/RestoreGroupRequest.md)
 - [Model.RootSiteWithManagedPaths](docs/RootSiteWithManagedPaths.md)
 - [Model.SASUriModel](docs/SASUriModel.md)
 - [Model.SCLifecycleActionModel](docs/SCLifecycleActionModel.md)
 - [Model.SCLifecycleActionType](docs/SCLifecycleActionType.md)
 - [Model.SCLifecycleGallery](docs/SCLifecycleGallery.md)
 - [Model.SCLifecycleLockType](docs/SCLifecycleLockType.md)
 - [Model.SPBaseType](docs/SPBaseType.md)
 - [Model.SPGroup](docs/SPGroup.md)
 - [Model.SPGroupEditOption](docs/SPGroupEditOption.md)
 - [Model.SPGroupEditOptionType](docs/SPGroupEditOptionType.md)
 - [Model.SPGroupManagementModel](docs/SPGroupManagementModel.md)
 - [Model.SPGroupViewOption](docs/SPGroupViewOption.md)
 - [Model.SPGroupViewOptionType](docs/SPGroupViewOptionType.md)
 - [Model.SPList](docs/SPList.md)
 - [Model.SPListTemplateType](docs/SPListTemplateType.md)
 - [Model.SPNode](docs/SPNode.md)
 - [Model.SPPrincipal](docs/SPPrincipal.md)
 - [Model.SPPrincipalType](docs/SPPrincipalType.md)
 - [Model.SPRoleAssignment](docs/SPRoleAssignment.md)
 - [Model.SPTenantSharingSettingModel](docs/SPTenantSharingSettingModel.md)
 - [Model.SPUserManagementModel](docs/SPUserManagementModel.md)
 - [Model.ScopeType](docs/ScopeType.md)
 - [Model.SenderOptions](docs/SenderOptions.md)
 - [Model.SensitivityLabelModel](docs/SensitivityLabelModel.md)
 - [Model.ServiceForRequest](docs/ServiceForRequest.md)
 - [Model.ServiceGridModel](docs/ServiceGridModel.md)
 - [Model.ServiceGridModelPageResult](docs/ServiceGridModelPageResult.md)
 - [Model.ServiceGroupWithPermissions](docs/ServiceGroupWithPermissions.md)
 - [Model.ServiceLanguageSetting](docs/ServiceLanguageSetting.md)
 - [Model.ServiceList](docs/ServiceList.md)
 - [Model.ServiceListPageResult](docs/ServiceListPageResult.md)
 - [Model.ServicePlanModel](docs/ServicePlanModel.md)
 - [Model.ServiceScopeSettings](docs/ServiceScopeSettings.md)
 - [Model.ServiceTeamsSettings](docs/ServiceTeamsSettings.md)
 - [Model.ServiceType](docs/ServiceType.md)
 - [Model.ServiceUserWithPermissions](docs/ServiceUserWithPermissions.md)
 - [Model.SharePointBuildInGroupType](docs/SharePointBuildInGroupType.md)
 - [Model.SharePointListMetadataSettings](docs/SharePointListMetadataSettings.md)
 - [Model.SharedChannelChangedMembership](docs/SharedChannelChangedMembership.md)
 - [Model.SharedChannelDescription](docs/SharedChannelDescription.md)
 - [Model.SharedChannelName](docs/SharedChannelName.md)
 - [Model.SharedMailboxBasicGridModel](docs/SharedMailboxBasicGridModel.md)
 - [Model.SharedMailboxBasicGridModelPageResult](docs/SharedMailboxBasicGridModelPageResult.md)
 - [Model.SharedMailboxLifecycleGalleryRequestModel](docs/SharedMailboxLifecycleGalleryRequestModel.md)
 - [Model.SharingAdvanceSettingModel](docs/SharingAdvanceSettingModel.md)
 - [Model.SharingAdvanceSettingModelChangedValueRequestModel](docs/SharingAdvanceSettingModelChangedValueRequestModel.md)
 - [Model.SharingCapabilities](docs/SharingCapabilities.md)
 - [Model.SharingCapabilitiesChangedValueRequestModel](docs/SharingCapabilitiesChangedValueRequestModel.md)
 - [Model.SharingDomainRestrictionMode](docs/SharingDomainRestrictionMode.md)
 - [Model.SharingEnabledUser](docs/SharingEnabledUser.md)
 - [Model.SharingExpireSettingModel](docs/SharingExpireSettingModel.md)
 - [Model.SharingExpireSettingModelChangedValueRequestModel](docs/SharingExpireSettingModelChangedValueRequestModel.md)
 - [Model.SharingLinkType](docs/SharingLinkType.md)
 - [Model.SharingLinkTypeChangedValueRequestModel](docs/SharingLinkTypeChangedValueRequestModel.md)
 - [Model.ShowLinksInRequestDetailsPage](docs/ShowLinksInRequestDetailsPage.md)
 - [Model.SingleLineOrMultipleLineMetadataSettings](docs/SingleLineOrMultipleLineMetadataSettings.md)
 - [Model.SiteAdmins](docs/SiteAdmins.md)
 - [Model.SiteAlternateCssUrl](docs/SiteAlternateCssUrl.md)
 - [Model.SiteClassification](docs/SiteClassification.md)
 - [Model.SiteClassificationAndSensitivityLabel](docs/SiteClassificationAndSensitivityLabel.md)
 - [Model.SiteCloudGovernancePanel](docs/SiteCloudGovernancePanel.md)
 - [Model.SiteColumns](docs/SiteColumns.md)
 - [Model.SiteConstructTitleType](docs/SiteConstructTitleType.md)
 - [Model.SiteConstructUrlType](docs/SiteConstructUrlType.md)
 - [Model.SiteDesign](docs/SiteDesign.md)
 - [Model.SiteDesignModel](docs/SiteDesignModel.md)
 - [Model.SiteElectionProfile](docs/SiteElectionProfile.md)
 - [Model.SiteFeature](docs/SiteFeature.md)
 - [Model.SiteLanguage](docs/SiteLanguage.md)
 - [Model.SiteLeasePeriodRequestSettings](docs/SiteLeasePeriodRequestSettings.md)
 - [Model.SiteLeasePeriodServiceSettings](docs/SiteLeasePeriodServiceSettings.md)
 - [Model.SiteLifecycleActionType](docs/SiteLifecycleActionType.md)
 - [Model.SiteLifecycleRequest](docs/SiteLifecycleRequest.md)
 - [Model.SiteLifecycleService](docs/SiteLifecycleService.md)
 - [Model.SiteLifecycleValidateResult](docs/SiteLifecycleValidateResult.md)
 - [Model.SiteLockType](docs/SiteLockType.md)
 - [Model.SitePicture](docs/SitePicture.md)
 - [Model.SitePolicyRef](docs/SitePolicyRef.md)
 - [Model.SiteSensitivityLabel](docs/SiteSensitivityLabel.md)
 - [Model.SiteSharingStatus](docs/SiteSharingStatus.md)
 - [Model.SiteStatus](docs/SiteStatus.md)
 - [Model.SiteTemplate](docs/SiteTemplate.md)
 - [Model.SiteTemplateSetting](docs/SiteTemplateSetting.md)
 - [Model.SiteTemplateTypeInSiteDesign](docs/SiteTemplateTypeInSiteDesign.md)
 - [Model.SiteTemplateTypeSetting](docs/SiteTemplateTypeSetting.md)
 - [Model.SiteTimeZone](docs/SiteTimeZone.md)
 - [Model.SiteTitleConstructureRule](docs/SiteTitleConstructureRule.md)
 - [Model.SiteTitleDescription](docs/SiteTitleDescription.md)
 - [Model.SiteTitleSetting](docs/SiteTitleSetting.md)
 - [Model.SiteUrl](docs/SiteUrl.md)
 - [Model.SiteUrlSetting](docs/SiteUrlSetting.md)
 - [Model.SiteValidationParameter](docs/SiteValidationParameter.md)
 - [Model.SpecifyContactParameter](docs/SpecifyContactParameter.md)
 - [Model.StartDateType](docs/StartDateType.md)
 - [Model.StringChangedProperty](docs/StringChangedProperty.md)
 - [Model.StringChangedValueRequestModel](docs/StringChangedValueRequestModel.md)
 - [Model.StringModel](docs/StringModel.md)
 - [Model.StringModelChangedValueRequestModel](docs/StringModelChangedValueRequestModel.md)
 - [Model.SubRequestType](docs/SubRequestType.md)
 - [Model.SubscribeMembers](docs/SubscribeMembers.md)
 - [Model.TaskApprovalStatus](docs/TaskApprovalStatus.md)
 - [Model.TaskComment](docs/TaskComment.md)
 - [Model.TaskDynamicActions](docs/TaskDynamicActions.md)
 - [Model.TaskHookMessage](docs/TaskHookMessage.md)
 - [Model.TaskList](docs/TaskList.md)
 - [Model.TaskListPageResult](docs/TaskListPageResult.md)
 - [Model.TaskPriority](docs/TaskPriority.md)
 - [Model.TaskReport](docs/TaskReport.md)
 - [Model.TaskReportPageResult](docs/TaskReportPageResult.md)
 - [Model.TaskResult](docs/TaskResult.md)
 - [Model.TaskStatus](docs/TaskStatus.md)
 - [Model.TaskType](docs/TaskType.md)
 - [Model.TeamClassification](docs/TeamClassification.md)
 - [Model.TeamClassificationAndSensitivityLabel](docs/TeamClassificationAndSensitivityLabel.md)
 - [Model.TeamElectionProfile](docs/TeamElectionProfile.md)
 - [Model.TeamFunSetting](docs/TeamFunSetting.md)
 - [Model.TeamGuestPermissionSetting](docs/TeamGuestPermissionSetting.md)
 - [Model.TeamId](docs/TeamId.md)
 - [Model.TeamLifecycleActionModel](docs/TeamLifecycleActionModel.md)
 - [Model.TeamLifecycleActionType](docs/TeamLifecycleActionType.md)
 - [Model.TeamLifecycleGallery](docs/TeamLifecycleGallery.md)
 - [Model.TeamLocale](docs/TeamLocale.md)
 - [Model.TeamMemberPermissionSetting](docs/TeamMemberPermissionSetting.md)
 - [Model.TeamMembers](docs/TeamMembers.md)
 - [Model.TeamMentionSetting](docs/TeamMentionSetting.md)
 - [Model.TeamMessagingSettings](docs/TeamMessagingSettings.md)
 - [Model.TeamNameDescription](docs/TeamNameDescription.md)
 - [Model.TeamOwners](docs/TeamOwners.md)
 - [Model.TeamSensitivityLabel](docs/TeamSensitivityLabel.md)
 - [Model.TeamSensitivityLabelChangedValueRequestModel](docs/TeamSensitivityLabelChangedValueRequestModel.md)
 - [Model.TeamSiteStatus](docs/TeamSiteStatus.md)
 - [Model.TeamSiteUrl](docs/TeamSiteUrl.md)
 - [Model.TeamTemplate](docs/TeamTemplate.md)
 - [Model.TeamTimeZone](docs/TeamTimeZone.md)
 - [Model.TeamsTemplateServiceSettings](docs/TeamsTemplateServiceSettings.md)
 - [Model.TeamsTemplateSettings](docs/TeamsTemplateSettings.md)
 - [Model.TemplateAssignBy](docs/TemplateAssignBy.md)
 - [Model.TemplateGiphyRatingType](docs/TemplateGiphyRatingType.md)
 - [Model.TemplateWithPermissions](docs/TemplateWithPermissions.md)
 - [Model.TemporaryPermissionRequestSetting](docs/TemporaryPermissionRequestSetting.md)
 - [Model.TermsMetadataSettings](docs/TermsMetadataSettings.md)
 - [Model.TermsValue](docs/TermsValue.md)
 - [Model.TextModel](docs/TextModel.md)
 - [Model.TextValidationRuleRef](docs/TextValidationRuleRef.md)
 - [Model.TextValidationType](docs/TextValidationType.md)
 - [Model.ThemeSettingType](docs/ThemeSettingType.md)
 - [Model.TimeZoneSettings](docs/TimeZoneSettings.md)
 - [Model.TreeNode](docs/TreeNode.md)
 - [Model.TreeNodeExtension](docs/TreeNodeExtension.md)
 - [Model.TreeNodeType](docs/TreeNodeType.md)
 - [Model.TriggerType](docs/TriggerType.md)
 - [Model.UnlockSiteRequest](docs/UnlockSiteRequest.md)
 - [Model.UnlockSiteSetting](docs/UnlockSiteSetting.md)
 - [Model.UpdateMetadataParameter](docs/UpdateMetadataParameter.md)
 - [Model.UrlRandomStringSettings](docs/UrlRandomStringSettings.md)
 - [Model.UrlSequentialNumberingSettings](docs/UrlSequentialNumberingSettings.md)
 - [Model.UserCustomAction](docs/UserCustomAction.md)
 - [Model.UserGroupPermissions](docs/UserGroupPermissions.md)
 - [Model.UserInfo](docs/UserInfo.md)
 - [Model.UserLevelControlMode](docs/UserLevelControlMode.md)
 - [Model.UserLevelControlSettings](docs/UserLevelControlSettings.md)
 - [Model.UserLevelRestrictionType](docs/UserLevelRestrictionType.md)
 - [Model.UserManagementSourceType](docs/UserManagementSourceType.md)
 - [Model.UserMembershipInfo](docs/UserMembershipInfo.md)
 - [Model.UserMembershipStatus](docs/UserMembershipStatus.md)
 - [Model.UserMetadataSettings](docs/UserMetadataSettings.md)
 - [Model.UserProfileMetadataSettings](docs/UserProfileMetadataSettings.md)
 - [Model.UserSource](docs/UserSource.md)
 - [Model.WebLifecycleActionType](docs/WebLifecycleActionType.md)
 - [Model.WebLifecycleRequest](docs/WebLifecycleRequest.md)
 - [Model.WebLifecycleService](docs/WebLifecycleService.md)
 - [Model.WebLifecycleValidateResult](docs/WebLifecycleValidateResult.md)
 - [Model.WebServiceAuthenticationType](docs/WebServiceAuthenticationType.md)
 - [Model.WelcomeEmail](docs/WelcomeEmail.md)
 - [Model.WelcomeEmailSettings](docs/WelcomeEmailSettings.md)
 - [Model.WorkerJobGridModel](docs/WorkerJobGridModel.md)
 - [Model.WorkerJobGridModelPageResult](docs/WorkerJobGridModelPageResult.md)
 - [Model.WorkerJobModel](docs/WorkerJobModel.md)
 - [Model.WorkerObjectType](docs/WorkerObjectType.md)
 - [Model.WorksapceOngoingTasksModel](docs/WorksapceOngoingTasksModel.md)
 - [Model.WorkspaceActionParameter](docs/WorkspaceActionParameter.md)
 - [Model.WorkspaceArchivedType](docs/WorkspaceArchivedType.md)
 - [Model.WorkspaceCreatedSourceType](docs/WorkspaceCreatedSourceType.md)
 - [Model.WorkspaceGridModel](docs/WorkspaceGridModel.md)
 - [Model.WorkspaceGridModelPageResult](docs/WorkspaceGridModelPageResult.md)
 - [Model.WorkspaceIdTypeModel](docs/WorkspaceIdTypeModel.md)
 - [Model.WorkspaceList](docs/WorkspaceList.md)
 - [Model.WorkspaceListPageResult](docs/WorkspaceListPageResult.md)
 - [Model.WorkspaceReport](docs/WorkspaceReport.md)
 - [Model.WorkspaceReportPageResult](docs/WorkspaceReportPageResult.md)
 - [Model.WorkspaceSendCancelEmailParameter](docs/WorkspaceSendCancelEmailParameter.md)
 - [Model.WorkspaceStatus](docs/WorkspaceStatus.md)
 - [Model.WorkspaceType](docs/WorkspaceType.md)
 - [Model.YammerCommunityInfoModel](docs/YammerCommunityInfoModel.md)
 - [Model.YammerGroupJoinType](docs/YammerGroupJoinType.md)
 - [Model.YammerGroupRequestSettings](docs/YammerGroupRequestSettings.md)
 - [Model.YammerGroupServiceSettings](docs/YammerGroupServiceSettings.md)
 - [Model.YammerGroupType](docs/YammerGroupType.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="clientSecret"></a>
### clientSecret

- **Type**: API key
- **API key parameter name**: clientSecret
- **Location**: HTTP header

<a name="userPrincipalName"></a>
### userPrincipalName

- **Type**: API key
- **API key parameter name**: userPrincipalName
- **Location**: HTTP header

