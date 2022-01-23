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
            
            var workspaceActionParameter = new WorkspaceActionParameter(); // WorkspaceActionParameter |  (optional) 

            try
            {
                // unlock sites and Office365 group site
                apiInstance.UnlockWorkspace(workspaceActionParameter);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.UnlockWorkspace: " + e.Message );
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
*JobsAdminApi* | [**GetJobs**](docs/JobsAdminApi.md#getjobs) | **GET** /admin/jobs | Get worker jobs
*JobsAdminApi* | [**GetRelatedJobs**](docs/JobsAdminApi.md#getrelatedjobs) | **GET** /admin/jobs/relations | Get related worker job
*MetadataAdminApi* | [**GetAllMetadata**](docs/MetadataAdminApi.md#getallmetadata) | **GET** /admin/metadata | get all metadata
*MetadataAdminApi* | [**GetSingleMetadataById**](docs/MetadataAdminApi.md#getsinglemetadatabyid) | **GET** /admin/metadata/{id} | Get metadata by id
*Office365Api* | [**CreateSecurityGroup**](docs/Office365Api.md#createsecuritygroup) | **POST** /office365/securitygroups | Create mail-enabled security group
*Office365Api* | [**GetGroupAllMembersByGroupValue**](docs/Office365Api.md#getgroupallmembersbygroupvalue) | **GET** /office365/groups/allmembers | get group members by group email
*Office365Api* | [**GetGroupMembers**](docs/Office365Api.md#getgroupmembers) | **GET** /office365/groups/{email}/memberswithoutowner | get group members without owners by group email
*Office365Api* | [**GetGroupOwners**](docs/Office365Api.md#getgroupowners) | **GET** /office365/groups/{email}/owners | get group owners by group email
*Office365Api* | [**GetHubSitesByUrl**](docs/Office365Api.md#gethubsitesbyurl) | **GET** /office365/hubsites | get all hubsites from site's tenant
*Office365Api* | [**GetOwnedTeams**](docs/Office365Api.md#getownedteams) | **GET** /office365/teams/my | get all teams that owner is curernt user
*Office365Api* | [**GetPermissions**](docs/Office365Api.md#getpermissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
*Office365Api* | [**GetRoleAssignment**](docs/Office365Api.md#getroleassignment) | **GET** /office365/roleassignment | get site permimssion role assignment
*Office365Api* | [**GetSiteDesigns**](docs/Office365Api.md#getsitedesigns) | **GET** /office365/sitedesigns | get site designs by site url
*Office365Api* | [**GetSitePermissionLevels**](docs/Office365Api.md#getsitepermissionlevels) | **GET** /office365/sites/permissionlevels | get site permission levels
*Office365Api* | [**GetSiteSharePointGroups**](docs/Office365Api.md#getsitesharepointgroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
*Office365Api* | [**GetSiteStatus**](docs/Office365Api.md#getsitestatus) | **GET** /office365/sites/status | check site collection status by full url
*Office365Api* | [**GetSiteTemplates**](docs/Office365Api.md#getsitetemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
*Office365Api* | [**HasPermission**](docs/Office365Api.md#haspermission) | **GET** /office365/sites/haspermission | whether user has permission on the site
*Office365Api* | [**RemoveSecurityGroup**](docs/Office365Api.md#removesecuritygroup) | **DELETE** /office365/securitygroups/{name} | Remove mail-enabled security group by group name
*Office365AdminApi* | [**AddWebUserCustomAction**](docs/Office365AdminApi.md#addwebusercustomaction) | **POST** /admin/office365/web/usercustomactions | add user custom actions, if exists, will update the existing one.
*Office365AdminApi* | [**DeleteWebUserCustomAction**](docs/Office365AdminApi.md#deletewebusercustomaction) | **DELETE** /admin/office365/web/usercustomactions | delete user custom actions by action name
*Office365AdminApi* | [**GetAzureAdCustomPropertyNames**](docs/Office365AdminApi.md#getazureadcustompropertynames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
*Office365AdminApi* | [**GetTenantIdByUrl**](docs/Office365AdminApi.md#gettenantidbyurl) | **GET** /admin/office365/tenantid | get tenant ids by url
*ReportAdminApi* | [**GeTaskReport**](docs/ReportAdminApi.md#getaskreport) | **GET** /admin/report/tasks | get all tasks report
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
*RequestsApi* | [**SubmitArchiveSiteRequest**](docs/RequestsApi.md#submitarchivesiterequest) | **POST** /requests/archivesite | submit archive site request
*RequestsApi* | [**SubmitArchiveWebRequest**](docs/RequestsApi.md#submitarchivewebrequest) | **POST** /requests/archiveweb | submit archive web request
*RequestsApi* | [**SubmitChangeGroupPolicyRequest**](docs/RequestsApi.md#submitchangegrouppolicyrequest) | **POST** /requests/changegrouppolicy | submit change group policy request
*RequestsApi* | [**SubmitChangeGroupQuotaRequest**](docs/RequestsApi.md#submitchangegroupquotarequest) | **POST** /requests/changegroupquota | submit change group quota request
*RequestsApi* | [**SubmitChangeGroupSettingRequest**](docs/RequestsApi.md#submitchangegroupsettingrequest) | **POST** /requests/changegroup | submit change group settings request
*RequestsApi* | [**SubmitChangeListSettingRequest**](docs/RequestsApi.md#submitchangelistsettingrequest) | **POST** /requests/changelistsetting | submit change list settings request
*RequestsApi* | [**SubmitChangePermissionRequest**](docs/RequestsApi.md#submitchangepermissionrequest) | **POST** /requests/changepermission | submit change permission request
*RequestsApi* | [**SubmitChangeSiteContactRequest**](docs/RequestsApi.md#submitchangesitecontactrequest) | **POST** /requests/changesite/adminorcontact | submit change site administrator or contact request
*RequestsApi* | [**SubmitChangeSitePolicyRequest**](docs/RequestsApi.md#submitchangesitepolicyrequest) | **POST** /requests/changesitepolicy | submit change site policy request
*RequestsApi* | [**SubmitChangeSiteQuotaRequest**](docs/RequestsApi.md#submitchangesitequotarequest) | **POST** /requests/changesitequota | submit change site quota request
*RequestsApi* | [**SubmitChangeSiteSettingRequest**](docs/RequestsApi.md#submitchangesitesettingrequest) | **POST** /requests/changesite/setting | submit change site settings request
*RequestsApi* | [**SubmitChangeWebContactRequest**](docs/RequestsApi.md#submitchangewebcontactrequest) | **POST** /requests/changewebcontact | submit change web contact request
*RequestsApi* | [**SubmitChangeWebSettingRequest**](docs/RequestsApi.md#submitchangewebsettingrequest) | **POST** /requests/changewebsettings | submit change web settings request
*RequestsApi* | [**SubmitClonePermissionRequest**](docs/RequestsApi.md#submitclonepermissionrequest) | **POST** /requests/clonepermission | get clone permission request
*RequestsApi* | [**SubmitContentMoveRequest**](docs/RequestsApi.md#submitcontentmoverequest) | **POST** /requests/contentmove | submit create content move request
*RequestsApi* | [**SubmitCreateGroupRequest**](docs/RequestsApi.md#submitcreategrouprequest) | **POST** /requests/creategroup | submit create group request
*RequestsApi* | [**SubmitCreateGuestUserRequest**](docs/RequestsApi.md#submitcreateguestuserrequest) | **POST** /requests/createguestuser | submit create guest user request
*RequestsApi* | [**SubmitCreateListRequest**](docs/RequestsApi.md#submitcreatelistrequest) | **POST** /requests/createlist | submit create list request
*RequestsApi* | [**SubmitCreatePrivateChannelRequest**](docs/RequestsApi.md#submitcreateprivatechannelrequest) | **POST** /requests/createprivatechannel | submit private channel request
*RequestsApi* | [**SubmitCreateSiteRequest**](docs/RequestsApi.md#submitcreatesiterequest) | **POST** /requests/createsite | submit create site collection request
*RequestsApi* | [**SubmitCreateWebRequest**](docs/RequestsApi.md#submitcreatewebrequest) | **POST** /requests/createweb | submit create web request
*RequestsApi* | [**SubmitCustomRequest**](docs/RequestsApi.md#submitcustomrequest) | **POST** /requests/custom | submit custom service request
*RequestsApi* | [**SubmitDeleteGroupRequest**](docs/RequestsApi.md#submitdeletegrouprequest) | **POST** /requests/deletegroup | submit delete group request
*RequestsApi* | [**SubmitDeleteSiteRequest**](docs/RequestsApi.md#submitdeletesiterequest) | **POST** /requests/deletesite | submit delete site request
*RequestsApi* | [**SubmitDeleteWebRequest**](docs/RequestsApi.md#submitdeletewebrequest) | **POST** /requests/deleteweb | submit delete web request
*RequestsApi* | [**SubmitExtendGroupRequest**](docs/RequestsApi.md#submitextendgrouprequest) | **POST** /requests/extendgroup | submit extend group request
*RequestsApi* | [**SubmitExtendSiteRequest**](docs/RequestsApi.md#submitextendsiterequest) | **POST** /requests/extendsite | submit extend site request
*RequestsApi* | [**SubmitGrantPermissionRequest**](docs/RequestsApi.md#submitgrantpermissionrequest) | **POST** /requests/grantpermission | get submit grant permission request
*RequestsApi* | [**SubmitLockSiteRequest**](docs/RequestsApi.md#submitlocksiterequest) | **POST** /requests/locksite | submit lock site request
*RequestsApi* | [**SubmitManagePermissionRequest**](docs/RequestsApi.md#submitmanagepermissionrequest) | **POST** /requests/managepermission | submit manage permission request
*RequestsApi* | [**SubmitRestoreGroupRequest**](docs/RequestsApi.md#submitrestoregrouprequest) | **POST** /requests/restoregroup | submit restore group request
*RequestsApi* | [**SubmitUnlockSiteRequest**](docs/RequestsApi.md#submitunlocksiterequest) | **POST** /requests/unlocksite | submit unlock site request
*RequestsAdminApi* | [**GetAllRequests**](docs/RequestsAdminApi.md#getallrequests) | **GET** /admin/directory/requests | get all requests
*ServicesApi* | [**GetChangeGroupSettingService**](docs/ServicesApi.md#getchangegroupsettingservice) | **GET** /services/changegroupsetting/{id} | get change group setting service
*ServicesApi* | [**GetChangeListSettingService**](docs/ServicesApi.md#getchangelistsettingservice) | **GET** /services/changelistsetting/{id} | get change list setting service
*ServicesApi* | [**GetChangePermissionService**](docs/ServicesApi.md#getchangepermissionservice) | **GET** /services/changepermission/{id} | get change permission service
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
*ServicesApi* | [**ValidateTeamForCreatePrivateChannelService**](docs/ServicesApi.md#validateteamforcreateprivatechannelservice) | **POST** /services/createprivatechannel/{serviceId}/team/validation | validate teams for create private channel service
*ServicesAdminApi* | [**GetServices**](docs/ServicesAdminApi.md#getservices) | **GET** /admin/services | get all services
*SettingsApi* | [**GetDynamicMembershipRuleItems**](docs/SettingsApi.md#getdynamicmembershipruleitems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
*SettingsApi* | [**GetMyPersonalSettings**](docs/SettingsApi.md#getmypersonalsettings) | **GET** /settings/my | get my personal settings
*SettingsApi* | [**GetPermissionLevels**](docs/SettingsApi.md#getpermissionlevels) | **GET** /settings/office365/permissionlevels | get permission levels
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
*UsersApi* | [**FilterUsersByAttribute**](docs/UsersApi.md#filterusersbyattribute) | **GET** /users/filter | filter users by property value
*UsersApi* | [**GetAzureAdUserPropertyValue**](docs/UsersApi.md#getazureaduserpropertyvalue) | **GET** /users/{username}/azuread/property | get Azure Ad user's property value
*UsersApi* | [**GetExtensionAzureAdUserPropertyValues**](docs/UsersApi.md#getextensionazureaduserpropertyvalues) | **GET** /users/{username}/azuread/extensionproperties | get user's extension property value from azure ad
*UsersApi* | [**IsMemberOfGroup**](docs/UsersApi.md#ismemberofgroup) | **GET** /users/{userprincipalname}/ismemberof/{groupid} | Is Member Of Group
*UsersApi* | [**ResolveUsers**](docs/UsersApi.md#resolveusers) | **GET** /users/resolve | resolve users
*UsersApi* | [**SearchUsers**](docs/UsersApi.md#searchusers) | **GET** /users/search | search users
*UsersApi* | [**UpdateUserInfo**](docs/UsersApi.md#updateuserinfo) | **POST** /users | add users or update user information
*WorkspaceApi* | [**GetGroupMetadata**](docs/WorkspaceApi.md#getgroupmetadata) | **GET** /workspace/groups/{id}/metadata | get group/teams metadata
*WorkspaceApi* | [**GetMyGroupInformation**](docs/WorkspaceApi.md#getmygroupinformation) | **GET** /workspace/groups/{id} | get O365 group/teams information
*WorkspaceApi* | [**GetMySiteInformation**](docs/WorkspaceApi.md#getmysiteinformation) | **GET** /workspace/sites/{id} | get site information
*WorkspaceApi* | [**GetSiteMetadata**](docs/WorkspaceApi.md#getsitemetadata) | **GET** /workspace/sites/metadata | get site metadata
*WorkspaceApi* | [**GetWorkspaceItems**](docs/WorkspaceApi.md#getworkspaceitems) | **GET** /workspace/my | get my workspace items
*WorkspacesAdminApi* | [**ApplyGroupsPolicy**](docs/WorkspacesAdminApi.md#applygroupspolicy) | **POST** /admin/directory/workspace/groups/policy | apply groups policy
*WorkspacesAdminApi* | [**ApplySitesPolicy**](docs/WorkspacesAdminApi.md#applysitespolicy) | **POST** /admin/directory/workspace/sites/policy | apply site policy
*WorkspacesAdminApi* | [**ArchiveWorkspace**](docs/WorkspacesAdminApi.md#archiveworkspace) | **POST** /admin/directory/workspace/archive | archive workspace
*WorkspacesAdminApi* | [**CompleteWorkspaceRenewalTask**](docs/WorkspacesAdminApi.md#completeworkspacerenewaltask) | **POST** /admin/directory/workspace/renewal/complete | completed renewal task
*WorkspacesAdminApi* | [**DeleteWorkspaces**](docs/WorkspacesAdminApi.md#deleteworkspaces) | **DELETE** /admin/directory/workspace | delete workspaces
*WorkspacesAdminApi* | [**GetOngoingTasks**](docs/WorkspacesAdminApi.md#getongoingtasks) | **GET** /admin/directory/workspace/{type}/ongoningtasks | get workspace ongoing tasks
*WorkspacesAdminApi* | [**GetWorkspaces**](docs/WorkspacesAdminApi.md#getworkspaces) | **GET** /admin/directory/workspace | get managed workspaces
*WorkspacesAdminApi* | [**LockWorkspaces**](docs/WorkspacesAdminApi.md#lockworkspaces) | **POST** /admin/directory/workspace/lock | lock sites or Office365 group sites
*WorkspacesAdminApi* | [**SpecifyContacts**](docs/WorkspacesAdminApi.md#specifycontacts) | **POST** /admin/directory/workspace/contacts | specify contacts
*WorkspacesAdminApi* | [**TriggerWorkspaceRenewal**](docs/WorkspacesAdminApi.md#triggerworkspacerenewal) | **POST** /admin/directory/workspace/renewal/trigger | trigger workspace renewal
*WorkspacesAdminApi* | [**UnlockWorkspace**](docs/WorkspacesAdminApi.md#unlockworkspace) | **POST** /admin/directory/workspace/unlock | unlock sites and Office365 group site


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddGroupMemberType](docs/AddGroupMemberType.md)
 - [Model.AllRequestList](docs/AllRequestList.md)
 - [Model.AllRequestListPageResult](docs/AllRequestListPageResult.md)
 - [Model.AllTaskList](docs/AllTaskList.md)
 - [Model.AllTaskListPageResult](docs/AllTaskListPageResult.md)
 - [Model.AnnoymouslinkPermissions](docs/AnnoymouslinkPermissions.md)
 - [Model.AnonymousLinkSettings](docs/AnonymousLinkSettings.md)
 - [Model.ApiCredential](docs/ApiCredential.md)
 - [Model.ApiDurationType](docs/ApiDurationType.md)
 - [Model.ApiError](docs/ApiError.md)
 - [Model.ApiMyGroup](docs/ApiMyGroup.md)
 - [Model.ApiRequest](docs/ApiRequest.md)
 - [Model.ApiRequestProgressStatus](docs/ApiRequestProgressStatus.md)
 - [Model.ApiSiteStatus](docs/ApiSiteStatus.md)
 - [Model.ApiTask](docs/ApiTask.md)
 - [Model.ApiTaskDynamicProperties](docs/ApiTaskDynamicProperties.md)
 - [Model.ApiUser](docs/ApiUser.md)
 - [Model.ApiUserChangedProperty](docs/ApiUserChangedProperty.md)
 - [Model.ApiUserPageResult](docs/ApiUserPageResult.md)
 - [Model.ApiUserType](docs/ApiUserType.md)
 - [Model.AppSettings](docs/AppSettings.md)
 - [Model.ApplyGroupPolicyModel](docs/ApplyGroupPolicyModel.md)
 - [Model.ApplyPolicyStatus](docs/ApplyPolicyStatus.md)
 - [Model.ApplySitePolicyModel](docs/ApplySitePolicyModel.md)
 - [Model.ArchiveGroupRequest](docs/ArchiveGroupRequest.md)
 - [Model.ArchiveSiteRequest](docs/ArchiveSiteRequest.md)
 - [Model.ArchiveWebLifecycleRequest](docs/ArchiveWebLifecycleRequest.md)
 - [Model.ArchiveWorkspaceParameter](docs/ArchiveWorkspaceParameter.md)
 - [Model.AssignBy](docs/AssignBy.md)
 - [Model.AuthenticationType](docs/AuthenticationType.md)
 - [Model.AutoCompleteRenewalTaskParameter](docs/AutoCompleteRenewalTaskParameter.md)
 - [Model.AutoGenerateUrlSetting](docs/AutoGenerateUrlSetting.md)
 - [Model.AutoGenerateUrlType](docs/AutoGenerateUrlType.md)
 - [Model.AutoImportPhase](docs/AutoImportPhase.md)
 - [Model.AutoImportProcessHookMessage](docs/AutoImportProcessHookMessage.md)
 - [Model.AutoTaskExtendRequest](docs/AutoTaskExtendRequest.md)
 - [Model.AzureAdMetadataSettings](docs/AzureAdMetadataSettings.md)
 - [Model.BackupEnvironmentSetting](docs/BackupEnvironmentSetting.md)
 - [Model.BooleanChangedProperty](docs/BooleanChangedProperty.md)
 - [Model.BooleanMetadataSettings](docs/BooleanMetadataSettings.md)
 - [Model.BriefGroupPolicy](docs/BriefGroupPolicy.md)
 - [Model.CategoryType](docs/CategoryType.md)
 - [Model.ChangeContactByUrlSetting](docs/ChangeContactByUrlSetting.md)
 - [Model.ChangeContactByUserSetting](docs/ChangeContactByUserSetting.md)
 - [Model.ChangeContactMethod](docs/ChangeContactMethod.md)
 - [Model.ChangeGroupPolicyRequest](docs/ChangeGroupPolicyRequest.md)
 - [Model.ChangeGroupPolicyResult](docs/ChangeGroupPolicyResult.md)
 - [Model.ChangeGroupQuotaRequest](docs/ChangeGroupQuotaRequest.md)
 - [Model.ChangeGroupQuotaResult](docs/ChangeGroupQuotaResult.md)
 - [Model.ChangeGroupSettingCheckResult](docs/ChangeGroupSettingCheckResult.md)
 - [Model.ChangeGroupSettingRequest](docs/ChangeGroupSettingRequest.md)
 - [Model.ChangeGroupSettingService](docs/ChangeGroupSettingService.md)
 - [Model.ChangeGroupSettingValidationParameter](docs/ChangeGroupSettingValidationParameter.md)
 - [Model.ChangeHubsiteActionType](docs/ChangeHubsiteActionType.md)
 - [Model.ChangeListSettingObjectInfo](docs/ChangeListSettingObjectInfo.md)
 - [Model.ChangeListSettingRequest](docs/ChangeListSettingRequest.md)
 - [Model.ChangeListSettingService](docs/ChangeListSettingService.md)
 - [Model.ChangeListSettingValidateResult](docs/ChangeListSettingValidateResult.md)
 - [Model.ChangeMetadataActionSetting](docs/ChangeMetadataActionSetting.md)
 - [Model.ChangePermissionRequest](docs/ChangePermissionRequest.md)
 - [Model.ChangePermissionService](docs/ChangePermissionService.md)
 - [Model.ChangePermissionValidateResult](docs/ChangePermissionValidateResult.md)
 - [Model.ChangePolicyActionSetting](docs/ChangePolicyActionSetting.md)
 - [Model.ChangeSiteContactRequest](docs/ChangeSiteContactRequest.md)
 - [Model.ChangeSiteContactService](docs/ChangeSiteContactService.md)
 - [Model.ChangeSiteContactSubRequest](docs/ChangeSiteContactSubRequest.md)
 - [Model.ChangeSiteContactValidateResult](docs/ChangeSiteContactValidateResult.md)
 - [Model.ChangeSitePolicyRequest](docs/ChangeSitePolicyRequest.md)
 - [Model.ChangeSitePolicySetting](docs/ChangeSitePolicySetting.md)
 - [Model.ChangeSiteQuotaRequest](docs/ChangeSiteQuotaRequest.md)
 - [Model.ChangeSiteQuotaSettings](docs/ChangeSiteQuotaSettings.md)
 - [Model.ChangeSiteSettingRequest](docs/ChangeSiteSettingRequest.md)
 - [Model.ChangeSiteSettingService](docs/ChangeSiteSettingService.md)
 - [Model.ChangeSiteSettingValidateResult](docs/ChangeSiteSettingValidateResult.md)
 - [Model.ChangeWebContactByUrlSetting](docs/ChangeWebContactByUrlSetting.md)
 - [Model.ChangeWebContactRequest](docs/ChangeWebContactRequest.md)
 - [Model.ChangeWebContactService](docs/ChangeWebContactService.md)
 - [Model.ChangeWebContactSubRequest](docs/ChangeWebContactSubRequest.md)
 - [Model.ChangeWebContactValidateResult](docs/ChangeWebContactValidateResult.md)
 - [Model.ChangeWebSPObject](docs/ChangeWebSPObject.md)
 - [Model.ChangeWebSettingRequest](docs/ChangeWebSettingRequest.md)
 - [Model.ChangeWebSettingService](docs/ChangeWebSettingService.md)
 - [Model.ChangeWebUrlValidateResult](docs/ChangeWebUrlValidateResult.md)
 - [Model.ChoiceMetadataSettings](docs/ChoiceMetadataSettings.md)
 - [Model.ChoiceType](docs/ChoiceType.md)
 - [Model.ClaimStatus](docs/ClaimStatus.md)
 - [Model.ClonePermissionAdditionalOption](docs/ClonePermissionAdditionalOption.md)
 - [Model.ClonePermissionOption](docs/ClonePermissionOption.md)
 - [Model.ClonePermissionRequest](docs/ClonePermissionRequest.md)
 - [Model.ClonePermissionService](docs/ClonePermissionService.md)
 - [Model.ClonePermissionValidateResult](docs/ClonePermissionValidateResult.md)
 - [Model.CommentsParam](docs/CommentsParam.md)
 - [Model.CommonStatus](docs/CommonStatus.md)
 - [Model.ConflictResolutionSetting](docs/ConflictResolutionSetting.md)
 - [Model.ConflictSolutionType](docs/ConflictSolutionType.md)
 - [Model.ConstructureType](docs/ConstructureType.md)
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
 - [Model.ContructUrlSetting](docs/ContructUrlSetting.md)
 - [Model.ConvertHubSiteActionType](docs/ConvertHubSiteActionType.md)
 - [Model.CopyMoveSetting](docs/CopyMoveSetting.md)
 - [Model.CopyMoveSettingAssignBy](docs/CopyMoveSettingAssignBy.md)
 - [Model.CreateGroupRequest](docs/CreateGroupRequest.md)
 - [Model.CreateGroupService](docs/CreateGroupService.md)
 - [Model.CreateGroupType](docs/CreateGroupType.md)
 - [Model.CreateGuestUserRequest](docs/CreateGuestUserRequest.md)
 - [Model.CreateGuestUserService](docs/CreateGuestUserService.md)
 - [Model.CreateGuestUserSubRequest](docs/CreateGuestUserSubRequest.md)
 - [Model.CreateGuestUserValidationResult](docs/CreateGuestUserValidationResult.md)
 - [Model.CreateListRequest](docs/CreateListRequest.md)
 - [Model.CreateListSPObject](docs/CreateListSPObject.md)
 - [Model.CreateListService](docs/CreateListService.md)
 - [Model.CreateListUrlSettings](docs/CreateListUrlSettings.md)
 - [Model.CreateListUrlValidationResult](docs/CreateListUrlValidationResult.md)
 - [Model.CreatePrivateChannelCheckResult](docs/CreatePrivateChannelCheckResult.md)
 - [Model.CreatePrivateChannelRequest](docs/CreatePrivateChannelRequest.md)
 - [Model.CreatePrivateChannelService](docs/CreatePrivateChannelService.md)
 - [Model.CreatePrivateChannelValidationParameter](docs/CreatePrivateChannelValidationParameter.md)
 - [Model.CreateSiteRequest](docs/CreateSiteRequest.md)
 - [Model.CreateSiteService](docs/CreateSiteService.md)
 - [Model.CreateWebRequest](docs/CreateWebRequest.md)
 - [Model.CreateWebScopeSettings](docs/CreateWebScopeSettings.md)
 - [Model.CreateWebService](docs/CreateWebService.md)
 - [Model.CreateWebUrlValidationResult](docs/CreateWebUrlValidationResult.md)
 - [Model.CreateWebValidationParameter](docs/CreateWebValidationParameter.md)
 - [Model.CustomActionSettings](docs/CustomActionSettings.md)
 - [Model.CustomMetadata](docs/CustomMetadata.md)
 - [Model.DelegatedAccessToken](docs/DelegatedAccessToken.md)
 - [Model.DelegatedAccessTokenApiResult](docs/DelegatedAccessTokenApiResult.md)
 - [Model.DeleteGroupRequest](docs/DeleteGroupRequest.md)
 - [Model.DeleteSiteRequest](docs/DeleteSiteRequest.md)
 - [Model.DeleteType](docs/DeleteType.md)
 - [Model.DeleteWebLifecycleRequest](docs/DeleteWebLifecycleRequest.md)
 - [Model.DeleteWorkspaceParameter](docs/DeleteWorkspaceParameter.md)
 - [Model.DeploymentManagerPlanSettings](docs/DeploymentManagerPlanSettings.md)
 - [Model.DisplayInReportType](docs/DisplayInReportType.md)
 - [Model.DpmServiceSetting](docs/DpmServiceSetting.md)
 - [Model.DueDateType](docs/DueDateType.md)
 - [Model.DurationDateType](docs/DurationDateType.md)
 - [Model.DynamicGroupRuleInfo](docs/DynamicGroupRuleInfo.md)
 - [Model.DynamicRuleCondition](docs/DynamicRuleCondition.md)
 - [Model.DynamicRuleElement](docs/DynamicRuleElement.md)
 - [Model.ElectionContact](docs/ElectionContact.md)
 - [Model.ElectionHookMessage](docs/ElectionHookMessage.md)
 - [Model.EndUserReportMetadata](docs/EndUserReportMetadata.md)
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
 - [Model.ExternalUserSharingSettings](docs/ExternalUserSharingSettings.md)
 - [Model.ExternalUserSharingType](docs/ExternalUserSharingType.md)
 - [Model.ExternalUserState](docs/ExternalUserState.md)
 - [Model.ExternalUserType](docs/ExternalUserType.md)
 - [Model.GeoLocationBase](docs/GeoLocationBase.md)
 - [Model.GeoLocationModel](docs/GeoLocationModel.md)
 - [Model.GiphyRatingType](docs/GiphyRatingType.md)
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
 - [Model.GroupConstructureRule](docs/GroupConstructureRule.md)
 - [Model.GroupEnableSharingStatus](docs/GroupEnableSharingStatus.md)
 - [Model.GroupIdConstructureSettings](docs/GroupIdConstructureSettings.md)
 - [Model.GroupIdRuleType](docs/GroupIdRuleType.md)
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
 - [Model.GroupSettingModel](docs/GroupSettingModel.md)
 - [Model.GroupUser](docs/GroupUser.md)
 - [Model.GroupValidationParameter](docs/GroupValidationParameter.md)
 - [Model.GuestUserGridModel](docs/GuestUserGridModel.md)
 - [Model.GuestUserGridModelPageResult](docs/GuestUserGridModelPageResult.md)
 - [Model.GuestUserPropertyModel](docs/GuestUserPropertyModel.md)
 - [Model.GuestUserRequestOneTimeRenewalSettingModel](docs/GuestUserRequestOneTimeRenewalSettingModel.md)
 - [Model.GuestUserStatus](docs/GuestUserStatus.md)
 - [Model.GuidBooleanModel](docs/GuidBooleanModel.md)
 - [Model.GuidModel](docs/GuidModel.md)
 - [Model.HandleOngoingType](docs/HandleOngoingType.md)
 - [Model.HookMessageList](docs/HookMessageList.md)
 - [Model.HookMessageObjectType](docs/HookMessageObjectType.md)
 - [Model.HubSiteChangedSettings](docs/HubSiteChangedSettings.md)
 - [Model.HubSiteSettings](docs/HubSiteSettings.md)
 - [Model.HubSiteType](docs/HubSiteType.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InsightsStatus](docs/InsightsStatus.md)
 - [Model.IntModel](docs/IntModel.md)
 - [Model.InviteType](docs/InviteType.md)
 - [Model.ItemConflictResolutionType](docs/ItemConflictResolutionType.md)
 - [Model.LanguageWithTemplates](docs/LanguageWithTemplates.md)
 - [Model.LeaseDateType](docs/LeaseDateType.md)
 - [Model.LeaseStartDateType](docs/LeaseStartDateType.md)
 - [Model.LifecycleAction](docs/LifecycleAction.md)
 - [Model.LifecycleHookMessage](docs/LifecycleHookMessage.md)
 - [Model.LifecycleRenewalSetting](docs/LifecycleRenewalSetting.md)
 - [Model.LinkMetadataSettings](docs/LinkMetadataSettings.md)
 - [Model.LinkValue](docs/LinkValue.md)
 - [Model.ListPermissionSettings](docs/ListPermissionSettings.md)
 - [Model.ListTemplate](docs/ListTemplate.md)
 - [Model.ListTemplateSettings](docs/ListTemplateSettings.md)
 - [Model.ListType](docs/ListType.md)
 - [Model.ListValidationParameter](docs/ListValidationParameter.md)
 - [Model.ListVersionSettings](docs/ListVersionSettings.md)
 - [Model.ListVersionSettingsChangedProperty](docs/ListVersionSettingsChangedProperty.md)
 - [Model.LockSiteCollectionType](docs/LockSiteCollectionType.md)
 - [Model.LockSiteParameter](docs/LockSiteParameter.md)
 - [Model.LockSiteRequest](docs/LockSiteRequest.md)
 - [Model.LockSiteSetting](docs/LockSiteSetting.md)
 - [Model.LogicalOperator](docs/LogicalOperator.md)
 - [Model.LookupListValue](docs/LookupListValue.md)
 - [Model.LookupValue](docs/LookupValue.md)
 - [Model.ManagePermissionAction](docs/ManagePermissionAction.md)
 - [Model.ManagePermissionGrantSetting](docs/ManagePermissionGrantSetting.md)
 - [Model.ManagePermissionOption](docs/ManagePermissionOption.md)
 - [Model.ManagePermissionRequest](docs/ManagePermissionRequest.md)
 - [Model.ManagePermissionSPObject](docs/ManagePermissionSPObject.md)
 - [Model.ManagePermissionService](docs/ManagePermissionService.md)
 - [Model.ManagePermissionSharePointGroupOption](docs/ManagePermissionSharePointGroupOption.md)
 - [Model.ManagePermissionUserSetting](docs/ManagePermissionUserSetting.md)
 - [Model.ManagePermissionValidateResult](docs/ManagePermissionValidateResult.md)
 - [Model.ManuallyInputUrlSetting](docs/ManuallyInputUrlSetting.md)
 - [Model.MessageCode](docs/MessageCode.md)
 - [Model.MetadataActionType](docs/MetadataActionType.md)
 - [Model.MetadataDisplayType](docs/MetadataDisplayType.md)
 - [Model.MetadataFieldType](docs/MetadataFieldType.md)
 - [Model.MetadataGridModel](docs/MetadataGridModel.md)
 - [Model.MetadataGridModelPageResult](docs/MetadataGridModelPageResult.md)
 - [Model.MultiGeoControlMode](docs/MultiGeoControlMode.md)
 - [Model.MultiGeoSerivceSetting](docs/MultiGeoSerivceSetting.md)
 - [Model.MultiGeoSetting](docs/MultiGeoSetting.md)
 - [Model.MySite](docs/MySite.md)
 - [Model.MySiteType](docs/MySiteType.md)
 - [Model.NodeType](docs/NodeType.md)
 - [Model.ObjectPermissionManagementModel](docs/ObjectPermissionManagementModel.md)
 - [Model.ObjectValidateResult](docs/ObjectValidateResult.md)
 - [Model.OneTimeRenewalOption](docs/OneTimeRenewalOption.md)
 - [Model.PermissionChangedType](docs/PermissionChangedType.md)
 - [Model.PermissionLevel](docs/PermissionLevel.md)
 - [Model.PermissionManagementModel](docs/PermissionManagementModel.md)
 - [Model.PermissionObjectProperty](docs/PermissionObjectProperty.md)
 - [Model.PermissionSettings](docs/PermissionSettings.md)
 - [Model.PersonalSettings](docs/PersonalSettings.md)
 - [Model.PersonalSettingsPropertyInfo](docs/PersonalSettingsPropertyInfo.md)
 - [Model.PolicyRef](docs/PolicyRef.md)
 - [Model.PolicyWithTemplates](docs/PolicyWithTemplates.md)
 - [Model.PrincipalType](docs/PrincipalType.md)
 - [Model.RenewalTaskHookMessage](docs/RenewalTaskHookMessage.md)
 - [Model.ReportMetadata](docs/ReportMetadata.md)
 - [Model.RequestGroupWithPermissions](docs/RequestGroupWithPermissions.md)
 - [Model.RequestHookMessage](docs/RequestHookMessage.md)
 - [Model.RequestList](docs/RequestList.md)
 - [Model.RequestListPageResult](docs/RequestListPageResult.md)
 - [Model.RequestMetadata](docs/RequestMetadata.md)
 - [Model.RequestMetadataListChangedProperty](docs/RequestMetadataListChangedProperty.md)
 - [Model.RequestProgressStatus](docs/RequestProgressStatus.md)
 - [Model.RequestStatus](docs/RequestStatus.md)
 - [Model.RequestTeamsSettings](docs/RequestTeamsSettings.md)
 - [Model.RequestUserWithPermissions](docs/RequestUserWithPermissions.md)
 - [Model.RestoreGroupRequest](docs/RestoreGroupRequest.md)
 - [Model.RootSiteWithManagedPaths](docs/RootSiteWithManagedPaths.md)
 - [Model.SPBaseType](docs/SPBaseType.md)
 - [Model.SPGroup](docs/SPGroup.md)
 - [Model.SPGroupEditOption](docs/SPGroupEditOption.md)
 - [Model.SPGroupManagementModel](docs/SPGroupManagementModel.md)
 - [Model.SPGroupViewOption](docs/SPGroupViewOption.md)
 - [Model.SPList](docs/SPList.md)
 - [Model.SPListTemplateType](docs/SPListTemplateType.md)
 - [Model.SPNode](docs/SPNode.md)
 - [Model.SPPrincipal](docs/SPPrincipal.md)
 - [Model.SPPrincipalType](docs/SPPrincipalType.md)
 - [Model.SPRoleAssignment](docs/SPRoleAssignment.md)
 - [Model.SPUserManagementModel](docs/SPUserManagementModel.md)
 - [Model.ScopeType](docs/ScopeType.md)
 - [Model.SensitivityLabelModel](docs/SensitivityLabelModel.md)
 - [Model.ServiceForRequest](docs/ServiceForRequest.md)
 - [Model.ServiceGridModel](docs/ServiceGridModel.md)
 - [Model.ServiceGridModelPageResult](docs/ServiceGridModelPageResult.md)
 - [Model.ServiceGroupWithPermissions](docs/ServiceGroupWithPermissions.md)
 - [Model.ServiceList](docs/ServiceList.md)
 - [Model.ServiceListPageResult](docs/ServiceListPageResult.md)
 - [Model.ServiceScopeSettings](docs/ServiceScopeSettings.md)
 - [Model.ServiceTeamsSettings](docs/ServiceTeamsSettings.md)
 - [Model.ServiceType](docs/ServiceType.md)
 - [Model.ServiceUserWithPermissions](docs/ServiceUserWithPermissions.md)
 - [Model.SharePointBuildInGroupType](docs/SharePointBuildInGroupType.md)
 - [Model.SharePointListMetadataSettings](docs/SharePointListMetadataSettings.md)
 - [Model.SharingEnabledUser](docs/SharingEnabledUser.md)
 - [Model.SingleLineOrMultipleLineMetadataSettings](docs/SingleLineOrMultipleLineMetadataSettings.md)
 - [Model.SiteConstructTitleType](docs/SiteConstructTitleType.md)
 - [Model.SiteConstructUrlType](docs/SiteConstructUrlType.md)
 - [Model.SiteLeasePeriodRequestSettings](docs/SiteLeasePeriodRequestSettings.md)
 - [Model.SiteLeasePeriodServiceSettings](docs/SiteLeasePeriodServiceSettings.md)
 - [Model.SiteLifecycleActionType](docs/SiteLifecycleActionType.md)
 - [Model.SiteLifecycleRequest](docs/SiteLifecycleRequest.md)
 - [Model.SiteLifecycleService](docs/SiteLifecycleService.md)
 - [Model.SiteLifecycleValidateResult](docs/SiteLifecycleValidateResult.md)
 - [Model.SiteLockType](docs/SiteLockType.md)
 - [Model.SiteSharingStatus](docs/SiteSharingStatus.md)
 - [Model.SiteStatus](docs/SiteStatus.md)
 - [Model.SiteTemplate](docs/SiteTemplate.md)
 - [Model.SiteTitleConstructureRule](docs/SiteTitleConstructureRule.md)
 - [Model.SiteTitleSetting](docs/SiteTitleSetting.md)
 - [Model.SiteUrl](docs/SiteUrl.md)
 - [Model.SiteUrlSetting](docs/SiteUrlSetting.md)
 - [Model.SiteValidationParameter](docs/SiteValidationParameter.md)
 - [Model.SpecifyContactParameter](docs/SpecifyContactParameter.md)
 - [Model.StartDateType](docs/StartDateType.md)
 - [Model.StringChangedProperty](docs/StringChangedProperty.md)
 - [Model.StringModel](docs/StringModel.md)
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
 - [Model.TeamsTemplateServiceSettings](docs/TeamsTemplateServiceSettings.md)
 - [Model.TeamsTemplateSettings](docs/TeamsTemplateSettings.md)
 - [Model.TemplateWithPermissions](docs/TemplateWithPermissions.md)
 - [Model.TemporaryPermissionRequestSetting](docs/TemporaryPermissionRequestSetting.md)
 - [Model.TermTreeModel](docs/TermTreeModel.md)
 - [Model.TermsMetadataSettings](docs/TermsMetadataSettings.md)
 - [Model.TermsValue](docs/TermsValue.md)
 - [Model.TextModel](docs/TextModel.md)
 - [Model.TextValidationRuleRef](docs/TextValidationRuleRef.md)
 - [Model.ThemeSettingType](docs/ThemeSettingType.md)
 - [Model.TreeNode](docs/TreeNode.md)
 - [Model.TreeNodeExtension](docs/TreeNodeExtension.md)
 - [Model.TreeNodeType](docs/TreeNodeType.md)
 - [Model.TriggerType](docs/TriggerType.md)
 - [Model.UnlockSiteRequest](docs/UnlockSiteRequest.md)
 - [Model.UnlockSiteSetting](docs/UnlockSiteSetting.md)
 - [Model.UpdatableApiUser](docs/UpdatableApiUser.md)
 - [Model.UrlRandomStringSettings](docs/UrlRandomStringSettings.md)
 - [Model.UrlSequentialNumberingSettings](docs/UrlSequentialNumberingSettings.md)
 - [Model.UserCustomAction](docs/UserCustomAction.md)
 - [Model.UserGroupPermissions](docs/UserGroupPermissions.md)
 - [Model.UserInfo](docs/UserInfo.md)
 - [Model.UserLevelControlMode](docs/UserLevelControlMode.md)
 - [Model.UserLevelControlSettings](docs/UserLevelControlSettings.md)
 - [Model.UserLevelRestrictionType](docs/UserLevelRestrictionType.md)
 - [Model.UserManagementSourceType](docs/UserManagementSourceType.md)
 - [Model.UserMetadataSettings](docs/UserMetadataSettings.md)
 - [Model.UserProfileMetadataSettings](docs/UserProfileMetadataSettings.md)
 - [Model.UserSource](docs/UserSource.md)
 - [Model.WebLifecycleActionType](docs/WebLifecycleActionType.md)
 - [Model.WebLifecycleRequest](docs/WebLifecycleRequest.md)
 - [Model.WebLifecycleService](docs/WebLifecycleService.md)
 - [Model.WebLifecycleValidateResult](docs/WebLifecycleValidateResult.md)
 - [Model.WebServiceAuthenticationType](docs/WebServiceAuthenticationType.md)
 - [Model.WelcomeEmailSettings](docs/WelcomeEmailSettings.md)
 - [Model.WorkerJobGridModel](docs/WorkerJobGridModel.md)
 - [Model.WorkerJobGridModelPageResult](docs/WorkerJobGridModelPageResult.md)
 - [Model.WorkerJobModel](docs/WorkerJobModel.md)
 - [Model.WorkerObjectType](docs/WorkerObjectType.md)
 - [Model.WorksapceOngoingTasksModel](docs/WorksapceOngoingTasksModel.md)
 - [Model.WorkspaceActionParameter](docs/WorkspaceActionParameter.md)
 - [Model.WorkspaceArchivedType](docs/WorkspaceArchivedType.md)
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

