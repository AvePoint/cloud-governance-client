# ServicesApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-ChangeGroupSettingService**](ServicesApi.md#Get-ChangeGroupSettingService) | **GET** /services/changegroupsetting/{id} | get change group setting service
[**Get-ChangeListSettingService**](ServicesApi.md#Get-ChangeListSettingService) | **GET** /services/changelistsetting/{id} | get change list setting service
[**Get-ChangePermissionService**](ServicesApi.md#Get-ChangePermissionService) | **GET** /services/changepermission/{id} | get change permission service
[**Get-ChangePrivateChannelService**](ServicesApi.md#Get-ChangePrivateChannelService) | **GET** /services/changeprivatechannel/{id} | get private channel service detail
[**Get-ChangeSiteContactService**](ServicesApi.md#Get-ChangeSiteContactService) | **GET** /services/changesitecontact/{id} | get change site contact service
[**Get-ChangeSiteSettingService**](ServicesApi.md#Get-ChangeSiteSettingService) | **GET** /services/changesitesetting/{id} | get change site setting service
[**Get-ChangeWebContactService**](ServicesApi.md#Get-ChangeWebContactService) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
[**Get-ChangeWebSettingsService**](ServicesApi.md#Get-ChangeWebSettingsService) | **GET** /services/changewebsettings/{id} | get change web setting service
[**Get-ClonePermissionService**](ServicesApi.md#Get-ClonePermissionService) | **GET** /services/clonepermission/{id} | get clone permission service
[**Get-ContentMoveProfiles**](ServicesApi.md#Get-ContentMoveProfiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
[**Get-ContentMoveService**](ServicesApi.md#Get-ContentMoveService) | **GET** /services/contentmove/{id} | get content move service
[**Get-CreateGroupService**](ServicesApi.md#Get-CreateGroupService) | **GET** /services/creategroup/{id} | get create group service
[**Get-CreateGuestUserService**](ServicesApi.md#Get-CreateGuestUserService) | **GET** /services/createguestuser/{id} | get create group service
[**Get-CreateListService**](ServicesApi.md#Get-CreateListService) | **GET** /services/createlist/{id} | get create list service
[**Get-CreatePrivateChannelService**](ServicesApi.md#Get-CreatePrivateChannelService) | **GET** /services/createprivatechannel/{id} | get private channel service detail
[**Get-CreateSiteService**](ServicesApi.md#Get-CreateSiteService) | **GET** /services/createsite/{id} | get create site service
[**Get-CreateWebService**](ServicesApi.md#Get-CreateWebService) | **GET** /services/createweb/{id} | get create web service
[**Get-CustomService**](ServicesApi.md#Get-CustomService) | **GET** /services/custom/{id} | get custom service
[**Get-DynamicService**](ServicesApi.md#Get-DynamicService) | **GET** /services/dynamic/{id} | get dynamic service
[**Get-DynamicServiceRequestTemplate**](ServicesApi.md#Get-DynamicServiceRequestTemplate) | **GET** /services/dynamic/{id}/template | 
[**Get-GrantPermissionService**](ServicesApi.md#Get-GrantPermissionService) | **GET** /services/grantpermission/{id} | get grant permission service
[**Get-GroupLifecycleService**](ServicesApi.md#Get-GroupLifecycleService) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
[**Get-ManagePermissionService**](ServicesApi.md#Get-ManagePermissionService) | **GET** /services/managepermission/{id} | get manage permission service
[**Get-MyServices**](ServicesApi.md#Get-MyServices) | **GET** /services/my | get services that can be used to start a request
[**Get-PermissionsForManagePermission**](ServicesApi.md#Get-PermissionsForManagePermission) | **POST** /services/dynamic/{serviceId}/managepermission/url/permission | 
[**Get-ServiceId**](ServicesApi.md#Get-ServiceId) | **GET** /services/id | get service id by service name
[**Get-SiteAdminsForManagePermission**](ServicesApi.md#Get-SiteAdminsForManagePermission) | **POST** /services/dynamic/{serviceId}/managepermission/url/siteadmins | 
[**Get-SiteLifecycleService**](ServicesApi.md#Get-SiteLifecycleService) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
[**Get-WebLifecycleService**](ServicesApi.md#Get-WebLifecycleService) | **GET** /services/weblifecycle/{id} | get web lifecycle service
[**Resolve-ChangeDistributionGroupSettings**](ServicesApi.md#Resolve-ChangeDistributionGroupSettings) | **POST** /services/dynamic/{serviceId}/galleries/changedistributiongroupsettings/{activityId}/distributiongroup/validation | 
[**Resolve-ChangeGroupProfilesSetting**](ServicesApi.md#Resolve-ChangeGroupProfilesSetting) | **POST** /services/dynamic/{serviceId}/galleries/changegroupprofiles/{activityId}/group/validation | 
[**Resolve-ChangePowerBIWorkspaceAccess**](ServicesApi.md#Resolve-ChangePowerBIWorkspaceAccess) | **POST** /services/dynamic/{serviceId}/galleries/changepowerbiworkspaceaccess/{activityId}/powerbi/validation | 
[**Resolve-ChangePrivateChannelSetting**](ServicesApi.md#Resolve-ChangePrivateChannelSetting) | **POST** /services/dynamic/{serviceId}/galleries/changeprivatechannel/{activityId}/team/validation | 
[**Resolve-ChangeResourceMailboxPermission**](ServicesApi.md#Resolve-ChangeResourceMailboxPermission) | **POST** /services/dynamic/{serviceId}/galleries/changeresourcemailboxpermission/{activityId}/resourcemailbox/validation | 
[**Resolve-ChangeSecurityGroupSettings**](ServicesApi.md#Resolve-ChangeSecurityGroupSettings) | **POST** /services/dynamic/{serviceId}/galleries/changesecuritygroupsettings/{activityId}/group/validation | 
[**Resolve-ChangeSharedChannelSetting**](ServicesApi.md#Resolve-ChangeSharedChannelSetting) | **POST** /services/dynamic/{serviceId}/galleries/changesharedchannel/{activityId}/team/validation | 
[**Resolve-ChangeSiteProfilesSetting**](ServicesApi.md#Resolve-ChangeSiteProfilesSetting) | **POST** /services/dynamic/{serviceId}/galleries/changesiteprofiles/{activityId}/site/validation | 
[**Resolve-ChangeTeamProfilesSetting**](ServicesApi.md#Resolve-ChangeTeamProfilesSetting) | **POST** /services/dynamic/{serviceId}/galleries/changeteamprofiles/{activityId}/team/validation | 
[**Resolve-ChangeYammerProfilesSetting**](ServicesApi.md#Resolve-ChangeYammerProfilesSetting) | **POST** /services/dynamic/{serviceId}/galleries/changeyammerprofiles/{activityId}/yammer/validation | 
[**Resolve-ChangeYammerSettings**](ServicesApi.md#Resolve-ChangeYammerSettings) | **POST** /services/dynamic/{serviceId}/galleries/changeyammersettings/{activityId}/yammer/validation | 
[**Resolve-CreatePrivateChannelSetting**](ServicesApi.md#Resolve-CreatePrivateChannelSetting) | **POST** /services/dynamic/{serviceId}/galleries/createprivatechannel/{activityId}/team/validation | 
[**Resolve-CreateSharedChannelSetting**](ServicesApi.md#Resolve-CreateSharedChannelSetting) | **POST** /services/dynamic/{serviceId}/galleries/createsharedchannel/{activityId}/team/validation | 
[**Resolve-EmailForCreateGuestUserService**](ServicesApi.md#Resolve-EmailForCreateGuestUserService) | **GET** /services/createguestuser/{id}/email/validate | validate guest user email
[**Resolve-EmailsForCreateGuestUserService**](ServicesApi.md#Resolve-EmailsForCreateGuestUserService) | **POST** /services/createguestuser/{id}/email/validate | validate guest user emails
[**Resolve-EnableTeamSetting**](ServicesApi.md#Resolve-EnableTeamSetting) | **POST** /services/dynamic/{serviceId}/galleries/enableteam/{activityId}/group/validation | 
[**Resolve-ExchangeResource**](ServicesApi.md#Resolve-ExchangeResource) | **POST** /services/dynamic/{serviceId}/galleries/changegroupmembership/{activityId}/exchangeresource/validation | 
[**Resolve-ForChangeGroupSettingService**](ServicesApi.md#Resolve-ForChangeGroupSettingService) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
[**Resolve-ForChangeLibrarySettingService**](ServicesApi.md#Resolve-ForChangeLibrarySettingService) | **POST** /services/dynamic/{serviceId}/changeLibrarysetting/validation | validate permissions, scope for change list setting service
[**Resolve-ForChangeListSettingService**](ServicesApi.md#Resolve-ForChangeListSettingService) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
[**Resolve-ForChangePermissionService**](ServicesApi.md#Resolve-ForChangePermissionService) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
[**Resolve-ForChangeSiteContactService**](ServicesApi.md#Resolve-ForChangeSiteContactService) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
[**Resolve-ForChangeSiteSettingService**](ServicesApi.md#Resolve-ForChangeSiteSettingService) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
[**Resolve-ForChangeWebContactService**](ServicesApi.md#Resolve-ForChangeWebContactService) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
[**Resolve-ForChangeWebSettingService**](ServicesApi.md#Resolve-ForChangeWebSettingService) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
[**Resolve-ForClonePermissionService**](ServicesApi.md#Resolve-ForClonePermissionService) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
[**Resolve-ForContentMoveService**](ServicesApi.md#Resolve-ForContentMoveService) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
[**Resolve-ForCreateGuestUserService**](ServicesApi.md#Resolve-ForCreateGuestUserService) | **POST** /services/createguestuser/{id}/group/validate | validate groups can invite
[**Resolve-ForCreateListService**](ServicesApi.md#Resolve-ForCreateListService) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
[**Resolve-ForCreateWebService**](ServicesApi.md#Resolve-ForCreateWebService) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
[**Resolve-ForGrantPermissionService**](ServicesApi.md#Resolve-ForGrantPermissionService) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
[**Resolve-ForGroupLifecycleService**](ServicesApi.md#Resolve-ForGroupLifecycleService) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
[**Resolve-ForManagePermissionService**](ServicesApi.md#Resolve-ForManagePermissionService) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
[**Resolve-ForSiteLifecycleService**](ServicesApi.md#Resolve-ForSiteLifecycleService) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
[**Resolve-ForWebLifecycleService**](ServicesApi.md#Resolve-ForWebLifecycleService) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service
[**Resolve-Guest**](ServicesApi.md#Resolve-Guest) | **POST** /services/dynamic/{serviceId}/galleries/guestlifecycle/{activityId}/guest/validation | 
[**Resolve-InviteEmail**](ServicesApi.md#Resolve-InviteEmail) | **POST** /services/dynamic/inviteguest/validateemail | 
[**Resolve-M365User**](ServicesApi.md#Resolve-M365User) | **POST** /services/dynamic/{serviceId}/galleries/userlifecycle/{activityId}/user/validation | 
[**Resolve-ObjectForChangeContact**](ServicesApi.md#Resolve-ObjectForChangeContact) | **POST** /services/dynamic/{serviceId}/changecontact/validation | 
[**Resolve-ObjectForChangeM365GroupSettings**](ServicesApi.md#Resolve-ObjectForChangeM365GroupSettings) | **POST** /services/dynamic/{serviceId}/changem365groupsettings/validation | 
[**Resolve-ObjectForChangeMailEnabledSecurityGroupSettings**](ServicesApi.md#Resolve-ObjectForChangeMailEnabledSecurityGroupSettings) | **POST** /services/dynamic/{serviceId}/changemailenabledsecuritygroupsettings/validation | 
[**Resolve-ObjectForChangeMetadata**](ServicesApi.md#Resolve-ObjectForChangeMetadata) | **POST** /services/dynamic/{serviceId}/changemetadata/validation | 
[**Resolve-SharedMailboxForChangePermission**](ServicesApi.md#Resolve-SharedMailboxForChangePermission) | **POST** /services/dynamic/{serviceId}/changesharedmailboxpermission/validation | 
[**Resolve-SharedMailboxForLifecycle**](ServicesApi.md#Resolve-SharedMailboxForLifecycle) | **POST** /services/dynamic/{serviceId}/sharedmailboxlifecycle/validation | 
[**Resolve-SiteForChangeSetting**](ServicesApi.md#Resolve-SiteForChangeSetting) | **POST** /services/dynamic/{serviceId}/changesitesetting/validation | 
[**Resolve-TeamForChangePrivateChannelService**](ServicesApi.md#Resolve-TeamForChangePrivateChannelService) | **POST** /services/changeprivatechannel/{serviceId}/team/validation | validate teams for change private channel service
[**Resolve-TeamForCreatePrivateChannelService**](ServicesApi.md#Resolve-TeamForCreatePrivateChannelService) | **POST** /services/createprivatechannel/{serviceId}/team/validation | validate teams for create private channel service
[**Resolve-TeamSetting**](ServicesApi.md#Resolve-TeamSetting) | **POST** /services/dynamic/{serviceId}/galleries/changeteamsetting/{activityId}/team/validation | 
[**Resolve-UrlForManagePermission**](ServicesApi.md#Resolve-UrlForManagePermission) | **POST** /services/dynamic/{serviceId}/managepermission/url/validation | 


<a name="Get-ChangeGroupSettingService"></a>
# **Get-ChangeGroupSettingService**
> ChangeGroupSettingService Get-ChangeGroupSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get change group setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get change group setting service
try {
     $Result = Get-ChangeGroupSettingService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangeGroupSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeGroupSettingService**](ChangeGroupSettingService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeListSettingService"></a>
# **Get-ChangeListSettingService**
> ChangeListSettingService Get-ChangeListSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get change list setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get change list setting service
try {
     $Result = Get-ChangeListSettingService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangeListSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeListSettingService**](ChangeListSettingService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionService"></a>
# **Get-ChangePermissionService**
> ChangePermissionService Get-ChangePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get change permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get change permission service
try {
     $Result = Get-ChangePermissionService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangePermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangePermissionService**](ChangePermissionService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePrivateChannelService"></a>
# **Get-ChangePrivateChannelService**
> ChangePrivateChannelService Get-ChangePrivateChannelService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get private channel service detail

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get private channel service detail
try {
     $Result = Get-ChangePrivateChannelService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangePrivateChannelService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangePrivateChannelService**](ChangePrivateChannelService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeSiteContactService"></a>
# **Get-ChangeSiteContactService**
> ChangeSiteContactService Get-ChangeSiteContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get change site contact service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get change site contact service
try {
     $Result = Get-ChangeSiteContactService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangeSiteContactService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSiteContactService**](ChangeSiteContactService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeSiteSettingService"></a>
# **Get-ChangeSiteSettingService**
> ChangeSiteSettingService Get-ChangeSiteSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get change site setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get change site setting service
try {
     $Result = Get-ChangeSiteSettingService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangeSiteSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSiteSettingService**](ChangeSiteSettingService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeWebContactService"></a>
# **Get-ChangeWebContactService**
> ChangeWebContactService Get-ChangeWebContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

validate permissions, scope for change web contact service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# validate permissions, scope for change web contact service
try {
     $Result = Get-ChangeWebContactService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangeWebContactService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeWebContactService**](ChangeWebContactService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeWebSettingsService"></a>
# **Get-ChangeWebSettingsService**
> ChangeWebSettingService Get-ChangeWebSettingsService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get change web setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get change web setting service
try {
     $Result = Get-ChangeWebSettingsService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ChangeWebSettingsService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeWebSettingService**](ChangeWebSettingService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ClonePermissionService"></a>
# **Get-ClonePermissionService**
> ClonePermissionService Get-ClonePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get clone permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get clone permission service
try {
     $Result = Get-ClonePermissionService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ClonePermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ClonePermissionService**](ClonePermissionService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ContentMoveProfiles"></a>
# **Get-ContentMoveProfiles**
> ContentMoveProfiles Get-ContentMoveProfiles<br>

get content move profiles from cloud management

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"




# get content move profiles from cloud management
try {
     $Result = Get-ContentMoveProfiles
} catch {
    Write-Host ("Exception occured when calling Get-ContentMoveProfiles: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters
This endpoint does not need any parameter.

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ContentMoveProfiles**](ContentMoveProfiles.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ContentMoveService"></a>
# **Get-ContentMoveService**
> ContentMoveService Get-ContentMoveService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get content move service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get content move service
try {
     $Result = Get-ContentMoveService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ContentMoveService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ContentMoveService**](ContentMoveService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateGroupService"></a>
# **Get-CreateGroupService**
> CreateGroupService Get-CreateGroupService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get create group service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get create group service
try {
     $Result = Get-CreateGroupService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CreateGroupService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateGroupService**](CreateGroupService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateGuestUserService"></a>
# **Get-CreateGuestUserService**
> CreateGuestUserService Get-CreateGuestUserService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get create group service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get create group service
try {
     $Result = Get-CreateGuestUserService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CreateGuestUserService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateGuestUserService**](CreateGuestUserService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateListService"></a>
# **Get-CreateListService**
> CreateListService Get-CreateListService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get create list service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get create list service
try {
     $Result = Get-CreateListService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CreateListService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateListService**](CreateListService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreatePrivateChannelService"></a>
# **Get-CreatePrivateChannelService**
> CreatePrivateChannelService Get-CreatePrivateChannelService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get private channel service detail

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get private channel service detail
try {
     $Result = Get-CreatePrivateChannelService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CreatePrivateChannelService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreatePrivateChannelService**](CreatePrivateChannelService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateSiteService"></a>
# **Get-CreateSiteService**
> CreateSiteService Get-CreateSiteService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get create site service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get create site service
try {
     $Result = Get-CreateSiteService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CreateSiteService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateSiteService**](CreateSiteService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateWebService"></a>
# **Get-CreateWebService**
> CreateWebService Get-CreateWebService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get create web service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get create web service
try {
     $Result = Get-CreateWebService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CreateWebService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateWebService**](CreateWebService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CustomService"></a>
# **Get-CustomService**
> ServiceForRequest Get-CustomService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get custom service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get custom service
try {
     $Result = Get-CustomService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-CustomService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ServiceForRequest**](ServiceForRequest.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-DynamicService"></a>
# **Get-DynamicService**
> DynamicServiceForRequest Get-DynamicService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get dynamic service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get dynamic service
try {
     $Result = Get-DynamicService -Id $Id -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-DynamicService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**DynamicServiceForRequest**](DynamicServiceForRequest.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-DynamicServiceRequestTemplate"></a>
# **Get-DynamicServiceRequestTemplate**
> DynamicRequestTemplateModel Get-DynamicServiceRequestTemplate<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 

try {
     $Result = Get-DynamicServiceRequestTemplate -Id $Id
} catch {
    Write-Host ("Exception occured when calling Get-DynamicServiceRequestTemplate: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**DynamicRequestTemplateModel**](DynamicRequestTemplateModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GrantPermissionService"></a>
# **Get-GrantPermissionService**
> GrantPermissionService Get-GrantPermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get grant permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get grant permission service
try {
     $Result = Get-GrantPermissionService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-GrantPermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**GrantPermissionService**](GrantPermissionService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupLifecycleService"></a>
# **Get-GroupLifecycleService**
> GroupLifecycleService Get-GroupLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get group lifecycle service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get group lifecycle service
try {
     $Result = Get-GroupLifecycleService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-GroupLifecycleService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**GroupLifecycleService**](GroupLifecycleService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagePermissionService"></a>
# **Get-ManagePermissionService**
> ManagePermissionService Get-ManagePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get manage permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get manage permission service
try {
     $Result = Get-ManagePermissionService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-ManagePermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ManagePermissionService**](ManagePermissionService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyServices"></a>
# **Get-MyServices**
> ServiceListPageResult Get-MyServices<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get services that can be used to start a request

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Search = "MySearch" # String |  (optional)

# get services that can be used to start a request
try {
     $Result = Get-MyServices -Search $Search
} catch {
    Write-Host ("Exception occured when calling Get-MyServices: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Search** | **String**|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ServiceListPageResult**](ServiceListPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-PermissionsForManagePermission"></a>
# **Get-PermissionsForManagePermission**
> SPPermission Get-PermissionsForManagePermission<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GetManagePermissionModelParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$GetManagePermissionModelParameter = $NodeType = New-NodeType 
$ExternalSharingOptions = New-ExternalSharingOptions 
$GetManagePermissionModelParameter = New-GetManagePermissionModelParameter -Uri "MyUri" -NodeType $NodeType -SiteId "MySiteId" -ExternalSharingOptions $ExternalSharingOptions -ManagePermissionSettingActivityId "MyManagePermissionSettingActivityId" # GetManagePermissionModelParameter |  (optional)

try {
     $Result = Get-PermissionsForManagePermission -ServiceId $ServiceId -GetManagePermissionModelParameter $GetManagePermissionModelParameter
} catch {
    Write-Host ("Exception occured when calling Get-PermissionsForManagePermission: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **GetManagePermissionModelParameter** | [**GetManagePermissionModelParameter**](GetManagePermissionModelParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SPPermission**](SPPermission.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ServiceId"></a>
# **Get-ServiceId**
> String Get-ServiceId<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

get service id by service name

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Name = "MyName" # String | service name, case insensitive

# get service id by service name
try {
     $Result = Get-ServiceId -Name $Name
} catch {
    Write-Host ("Exception occured when calling Get-ServiceId: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Name** | **String**| service name, case insensitive | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteAdminsForManagePermission"></a>
# **Get-SiteAdminsForManagePermission**
> ManagePermissionSiteAdminModel[] Get-SiteAdminsForManagePermission<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GetManageSiteAdminModelParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$GetManageSiteAdminModelParameter = $ExternalSharingOptions = New-ExternalSharingOptions 
$GetManageSiteAdminModelParameter = New-GetManageSiteAdminModelParameter -Uri "MyUri" -SiteId "MySiteId" -ExternalSharingOptions $ExternalSharingOptions -ManageSiteAdminSettingActivityId "MyManageSiteAdminSettingActivityId" # GetManageSiteAdminModelParameter |  (optional)

try {
     $Result = Get-SiteAdminsForManagePermission -ServiceId $ServiceId -GetManageSiteAdminModelParameter $GetManageSiteAdminModelParameter
} catch {
    Write-Host ("Exception occured when calling Get-SiteAdminsForManagePermission: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **GetManageSiteAdminModelParameter** | [**GetManageSiteAdminModelParameter**](GetManageSiteAdminModelParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ManagePermissionSiteAdminModel[]**](ManagePermissionSiteAdminModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteLifecycleService"></a>
# **Get-SiteLifecycleService**
> SiteLifecycleService Get-SiteLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get site lifecycle service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get site lifecycle service
try {
     $Result = Get-SiteLifecycleService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-SiteLifecycleService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SiteLifecycleService**](SiteLifecycleService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-WebLifecycleService"></a>
# **Get-WebLifecycleService**
> WebLifecycleService Get-WebLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsValidatePermission] <System.Nullable[Boolean]><br>

get web lifecycle service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$QuestionnaireId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsValidatePermission = $true # Boolean |  (optional) (default to $false)

# get web lifecycle service
try {
     $Result = Get-WebLifecycleService -Id $Id -QuestionnaireId $QuestionnaireId -IsValidatePermission $IsValidatePermission
} catch {
    Write-Host ("Exception occured when calling Get-WebLifecycleService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **QuestionnaireId** | [**String**](String.md)|  | [optional] 
 **IsValidatePermission** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**WebLifecycleService**](WebLifecycleService.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeDistributionGroupSettings"></a>
# **Resolve-ChangeDistributionGroupSettings**
> ChangeDistributionGroupSettingsCheckResult Resolve-ChangeDistributionGroupSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeDistributionGroupSettingsValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeDistributionGroupSettingsValidationParameter = $ChangeDistributionGroupSettingsValidationParameter = New-ChangeDistributionGroupSettingsValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -IsAllowChangeDomain $false -ActionActivityTitle "MyActionActivityTitle" -SendAsActivityId "MySendAsActivityId" -SendOnBehalfActivityId "MySendOnBehalfActivityId" -DeliveryManagementActivityId "MyDeliveryManagementActivityId" # ChangeDistributionGroupSettingsValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeDistributionGroupSettings -ServiceId $ServiceId -ActivityId $ActivityId -ChangeDistributionGroupSettingsValidationParameter $ChangeDistributionGroupSettingsValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeDistributionGroupSettings: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeDistributionGroupSettingsValidationParameter** | [**ChangeDistributionGroupSettingsValidationParameter**](ChangeDistributionGroupSettingsValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeDistributionGroupSettingsCheckResult**](ChangeDistributionGroupSettingsCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeGroupProfilesSetting"></a>
# **Resolve-ChangeGroupProfilesSetting**
> ChangeGroupProfilesCheckResult Resolve-ChangeGroupProfilesSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupSettingsValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeGroupSettingsValidationParameter = $ChangeGroupSettingsValidationParameter = New-ChangeGroupSettingsValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" # ChangeGroupSettingsValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeGroupProfilesSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeGroupSettingsValidationParameter $ChangeGroupSettingsValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeGroupProfilesSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeGroupSettingsValidationParameter** | [**ChangeGroupSettingsValidationParameter**](ChangeGroupSettingsValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeGroupProfilesCheckResult**](ChangeGroupProfilesCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangePowerBIWorkspaceAccess"></a>
# **Resolve-ChangePowerBIWorkspaceAccess**
> ChangePowerBIWorkspaceAccessCheckResult Resolve-ChangePowerBIWorkspaceAccess<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangePowerBIWorkspaceAccessValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangePowerBIWorkspaceAccessValidationParameter = $ChangePowerBIWorkspaceAccessValidationParameter = New-ChangePowerBIWorkspaceAccessValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -ObjectName "MyObjectName" -AdminActivityId "MyAdminActivityId" -ContributorActivityId "MyContributorActivityId" -MemberActivityId "MyMemberActivityId" -ViewerActivityId "MyViewerActivityId" # ChangePowerBIWorkspaceAccessValidationParameter |  (optional)

try {
     $Result = Resolve-ChangePowerBIWorkspaceAccess -ServiceId $ServiceId -ActivityId $ActivityId -ChangePowerBIWorkspaceAccessValidationParameter $ChangePowerBIWorkspaceAccessValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangePowerBIWorkspaceAccess: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangePowerBIWorkspaceAccessValidationParameter** | [**ChangePowerBIWorkspaceAccessValidationParameter**](ChangePowerBIWorkspaceAccessValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangePowerBIWorkspaceAccessCheckResult**](ChangePowerBIWorkspaceAccessCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangePrivateChannelSetting"></a>
# **Resolve-ChangePrivateChannelSetting**
> ChangePrivateChannelDynamicServiceCheckResult Resolve-ChangePrivateChannelSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-ChangePrivateChannelSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangePrivateChannelSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangePrivateChannelDynamicServiceCheckResult**](ChangePrivateChannelDynamicServiceCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeResourceMailboxPermission"></a>
# **Resolve-ChangeResourceMailboxPermission**
> ChangeResourceMailboxPermissionCheckResult Resolve-ChangeResourceMailboxPermission<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeResourceMailboxPermissionValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeResourceMailboxPermissionValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeResourceMailboxPermissionValidationParameter = New-ChangeResourceMailboxPermissionValidationParameter -ScopeActivityId "MyScopeActivityId" -MembersActivityId "MyMembersActivityId" -SendAsActivityId "MySendAsActivityId" -SendOnBehalfActivityId "MySendOnBehalfActivityId" -TenantId "MyTenantId" -ObjectId "MyObjectId" -DisplayName "MyDisplayName" -Email "MyEmail" -Type $WorkspaceType # ChangeResourceMailboxPermissionValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeResourceMailboxPermission -ServiceId $ServiceId -ActivityId $ActivityId -ChangeResourceMailboxPermissionValidationParameter $ChangeResourceMailboxPermissionValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeResourceMailboxPermission: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeResourceMailboxPermissionValidationParameter** | [**ChangeResourceMailboxPermissionValidationParameter**](ChangeResourceMailboxPermissionValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeResourceMailboxPermissionCheckResult**](ChangeResourceMailboxPermissionCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeSecurityGroupSettings"></a>
# **Resolve-ChangeSecurityGroupSettings**
> ChangeExchangeResourceGroupSettingsCheckResult Resolve-ChangeSecurityGroupSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeExchangeResourceGroupSettingsValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeExchangeResourceGroupSettingsValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeExchangeResourceGroupSettingsValidationParameter = New-ChangeExchangeResourceGroupSettingsValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -GroupType $WorkspaceType # ChangeExchangeResourceGroupSettingsValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeSecurityGroupSettings -ServiceId $ServiceId -ActivityId $ActivityId -ChangeExchangeResourceGroupSettingsValidationParameter $ChangeExchangeResourceGroupSettingsValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeSecurityGroupSettings: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeExchangeResourceGroupSettingsValidationParameter** | [**ChangeExchangeResourceGroupSettingsValidationParameter**](ChangeExchangeResourceGroupSettingsValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeExchangeResourceGroupSettingsCheckResult**](ChangeExchangeResourceGroupSettingsCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeSharedChannelSetting"></a>
# **Resolve-ChangeSharedChannelSetting**
> ChangeSharedChannelCheckResult Resolve-ChangeSharedChannelSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeSharedChannelSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeSharedChannelSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSharedChannelCheckResult**](ChangeSharedChannelCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeSiteProfilesSetting"></a>
# **Resolve-ChangeSiteProfilesSetting**
> ChangeSiteProfilesCheckResult Resolve-ChangeSiteProfilesSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeSiteValidationParameter = $ChangeSiteValidationParameter = New-ChangeSiteValidationParameter -SiteUrl "MySiteUrl" -Office365TenantId "MyOffice365TenantId" -ScopeActivityId "MyScopeActivityId" -ClassificationActivityId "MyClassificationActivityId" -SensitivityLabelActivityId "MySensitivityLabelActivityId" -StorageActivityId "MyStorageActivityId" -TitleActivityId "MyTitleActivityId" -HubSiteActivityId "MyHubSiteActivityId" -SharingActivityId "MySharingActivityId" -DescriptionActivityId "MyDescriptionActivityId" -LocaleActivityId "MyLocaleActivityId" -TimeZoneActivityId "MyTimeZoneActivityId" # ChangeSiteValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeSiteProfilesSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeSiteValidationParameter $ChangeSiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeSiteProfilesSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeSiteValidationParameter** | [**ChangeSiteValidationParameter**](ChangeSiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSiteProfilesCheckResult**](ChangeSiteProfilesCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeTeamProfilesSetting"></a>
# **Resolve-ChangeTeamProfilesSetting**
> ChangeTeamProfilesCheckResult Resolve-ChangeTeamProfilesSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeTeamProfilesSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeTeamProfilesSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeTeamProfilesCheckResult**](ChangeTeamProfilesCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeYammerProfilesSetting"></a>
# **Resolve-ChangeYammerProfilesSetting**
> ChangeYammerProfilesCheckResult Resolve-ChangeYammerProfilesSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeYammerSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeYammerSettingValidationParameter = $ChangeYammerSettingValidationParameter = New-ChangeYammerSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeYammerSettingValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeYammerProfilesSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeYammerSettingValidationParameter $ChangeYammerSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeYammerProfilesSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeYammerSettingValidationParameter** | [**ChangeYammerSettingValidationParameter**](ChangeYammerSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeYammerProfilesCheckResult**](ChangeYammerProfilesCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ChangeYammerSettings"></a>
# **Resolve-ChangeYammerSettings**
> ChangeYammerSettingsCheckResult Resolve-ChangeYammerSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeYammerSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeYammerSettingValidationParameter = $ChangeYammerSettingValidationParameter = New-ChangeYammerSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeYammerSettingValidationParameter |  (optional)

try {
     $Result = Resolve-ChangeYammerSettings -ServiceId $ServiceId -ActivityId $ActivityId -ChangeYammerSettingValidationParameter $ChangeYammerSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ChangeYammerSettings: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeYammerSettingValidationParameter** | [**ChangeYammerSettingValidationParameter**](ChangeYammerSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeYammerSettingsCheckResult**](ChangeYammerSettingsCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-CreatePrivateChannelSetting"></a>
# **Resolve-CreatePrivateChannelSetting**
> CreatePrivateChannelDynamicServiceCheckResult Resolve-CreatePrivateChannelSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-CreatePrivateChannelSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-CreatePrivateChannelSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreatePrivateChannelDynamicServiceCheckResult**](CreatePrivateChannelDynamicServiceCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-CreateSharedChannelSetting"></a>
# **Resolve-CreateSharedChannelSetting**
> CreateSharedChannelCheckResult Resolve-CreateSharedChannelSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-CreateSharedChannelSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-CreateSharedChannelSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateSharedChannelCheckResult**](CreateSharedChannelCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-EmailForCreateGuestUserService"></a>
# **Resolve-EmailForCreateGuestUserService**
> ObjectValidateResult Resolve-EmailForCreateGuestUserService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Email] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestId] <PSCustomObject><br>

validate guest user email

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$Email = "MyEmail" # String | 
$RequestId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)

# validate guest user email
try {
     $Result = Resolve-EmailForCreateGuestUserService -Id $Id -Email $Email -RequestId $RequestId
} catch {
    Write-Host ("Exception occured when calling Resolve-EmailForCreateGuestUserService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **Email** | **String**|  | 
 **RequestId** | [**String**](String.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ObjectValidateResult**](ObjectValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-EmailsForCreateGuestUserService"></a>
# **Resolve-EmailsForCreateGuestUserService**
> String[] Resolve-EmailsForCreateGuestUserService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestBody] <String[]><br>

validate guest user emails

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$RequestBody = "MyRequestBody" # String[] |  (optional)

# validate guest user emails
try {
     $Result = Resolve-EmailsForCreateGuestUserService -Id $Id -RequestBody $RequestBody
} catch {
    Write-Host ("Exception occured when calling Resolve-EmailsForCreateGuestUserService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **RequestBody** | [**String[]**](String.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String[]**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-EnableTeamSetting"></a>
# **Resolve-EnableTeamSetting**
> EnableTeamCheckResult Resolve-EnableTeamSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-EnableTeamSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-EnableTeamSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**EnableTeamCheckResult**](EnableTeamCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ExchangeResource"></a>
# **Resolve-ExchangeResource**
> ChangeGroupOwnerMembershipCheckResult Resolve-ExchangeResource<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupOwnerMembershipValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeGroupOwnerMembershipValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeGroupOwnerMembershipValidationParameter = New-ChangeGroupOwnerMembershipValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -GroupType $WorkspaceType # ChangeGroupOwnerMembershipValidationParameter |  (optional)

try {
     $Result = Resolve-ExchangeResource -ServiceId $ServiceId -ActivityId $ActivityId -ChangeGroupOwnerMembershipValidationParameter $ChangeGroupOwnerMembershipValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ExchangeResource: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeGroupOwnerMembershipValidationParameter** | [**ChangeGroupOwnerMembershipValidationParameter**](ChangeGroupOwnerMembershipValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeGroupOwnerMembershipCheckResult**](ChangeGroupOwnerMembershipCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeGroupSettingService"></a>
# **Resolve-ForChangeGroupSettingService**
> ChangeGroupSettingCheckResult Resolve-ForChangeGroupSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupSettingValidationParameter] <PSCustomObject><br>

validate permissions, scope for change group setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangeGroupSettingValidationParameter = $ChangeGroupSettingValidationParameter = New-ChangeGroupSettingValidationParameter -GroupEmail "MyGroupEmail" -GroupId "MyGroupId" -IsEditTask $false -IsFromQuestionnaire $false # ChangeGroupSettingValidationParameter |  (optional)

# validate permissions, scope for change group setting service
try {
     $Result = Resolve-ForChangeGroupSettingService -Id $Id -ChangeGroupSettingValidationParameter $ChangeGroupSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeGroupSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeGroupSettingValidationParameter** | [**ChangeGroupSettingValidationParameter**](ChangeGroupSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeGroupSettingCheckResult**](ChangeGroupSettingCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeLibrarySettingService"></a>
# **Resolve-ForChangeLibrarySettingService**
> ChangeLibrarySettingValidateResult Resolve-ForChangeLibrarySettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change list setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = "MyServiceId" # String | 
$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change list setting service
try {
     $Result = Resolve-ForChangeLibrarySettingService -ServiceId $ServiceId -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeLibrarySettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | **String**|  | 
 **Id** | [**String**](String.md)|  | [optional] 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeLibrarySettingValidateResult**](ChangeLibrarySettingValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeListSettingService"></a>
# **Resolve-ForChangeListSettingService**
> ChangeListSettingValidateResult Resolve-ForChangeListSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change list setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change list setting service
try {
     $Result = Resolve-ForChangeListSettingService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeListSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeListSettingValidateResult**](ChangeListSettingValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangePermissionService"></a>
# **Resolve-ForChangePermissionService**
> ChangePermissionValidateResult Resolve-ForChangePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change permission service
try {
     $Result = Resolve-ForChangePermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangePermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangePermissionValidateResult**](ChangePermissionValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeSiteContactService"></a>
# **Resolve-ForChangeSiteContactService**
> ChangeSiteContactValidateResult Resolve-ForChangeSiteContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change site contact service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change site contact service
try {
     $Result = Resolve-ForChangeSiteContactService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeSiteContactService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSiteContactValidateResult**](ChangeSiteContactValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeSiteSettingService"></a>
# **Resolve-ForChangeSiteSettingService**
> ChangeSiteSettingValidateResult Resolve-ForChangeSiteSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change site setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change site setting service
try {
     $Result = Resolve-ForChangeSiteSettingService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeSiteSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSiteSettingValidateResult**](ChangeSiteSettingValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeWebContactService"></a>
# **Resolve-ForChangeWebContactService**
> ChangeWebContactValidateResult Resolve-ForChangeWebContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change web contact service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change web contact service
try {
     $Result = Resolve-ForChangeWebContactService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeWebContactService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeWebContactValidateResult**](ChangeWebContactValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForChangeWebSettingService"></a>
# **Resolve-ForChangeWebSettingService**
> ChangeWebUrlValidateResult Resolve-ForChangeWebSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change web setting service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for change web setting service
try {
     $Result = Resolve-ForChangeWebSettingService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForChangeWebSettingService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeWebUrlValidateResult**](ChangeWebUrlValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForClonePermissionService"></a>
# **Resolve-ForClonePermissionService**
> ClonePermissionValidateResult Resolve-ForClonePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for clone permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for clone permission service
try {
     $Result = Resolve-ForClonePermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForClonePermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ClonePermissionValidateResult**](ClonePermissionValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForContentMoveService"></a>
# **Resolve-ForContentMoveService**
> ContentMoveUrlValidationResult Resolve-ForContentMoveService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ContentMoveUrlValidationParameter] <PSCustomObject><br>

validate permissions, scope for content move service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ContentMoveUrlValidationParameter = $ContentMoveUrlValidationParameter = New-ContentMoveUrlValidationParameter -IsCheckSourceUrl $false -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # ContentMoveUrlValidationParameter |  (optional)

# validate permissions, scope for content move service
try {
     $Result = Resolve-ForContentMoveService -Id $Id -ContentMoveUrlValidationParameter $ContentMoveUrlValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForContentMoveService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ContentMoveUrlValidationParameter** | [**ContentMoveUrlValidationParameter**](ContentMoveUrlValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ContentMoveUrlValidationResult**](ContentMoveUrlValidationResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForCreateGuestUserService"></a>
# **Resolve-ForCreateGuestUserService**
> CreateGuestUserValidationResult[] Resolve-ForCreateGuestUserService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiUser] <PSCustomObject[]><br>

validate groups can invite

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$RequestId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$ApiUser = $ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType # ApiUser[] |  (optional)

# validate groups can invite
try {
     $Result = Resolve-ForCreateGuestUserService -Id $Id -RequestId $RequestId -ApiUser $ApiUser
} catch {
    Write-Host ("Exception occured when calling Resolve-ForCreateGuestUserService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **RequestId** | [**String**](String.md)|  | [optional] 
 **ApiUser** | [**ApiUser[]**](ApiUser.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateGuestUserValidationResult[]**](CreateGuestUserValidationResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForCreateListService"></a>
# **Resolve-ForCreateListService**
> CreateListUrlValidationResult Resolve-ForCreateListService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ListValidationParameter] <PSCustomObject><br>

validate permissions, scope for create list service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ListValidationParameter = $ListValidationParameter = New-ListValidationParameter -ListUrl "MyListUrl" -ParentUrl "MyParentUrl" -ListTitle "MyListTitle" -IsDocumentLibrary $false -IsEditTask $false -IsFromQuestionnaire $false # ListValidationParameter |  (optional)

# validate permissions, scope for create list service
try {
     $Result = Resolve-ForCreateListService -Id $Id -ListValidationParameter $ListValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForCreateListService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ListValidationParameter** | [**ListValidationParameter**](ListValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateListUrlValidationResult**](CreateListUrlValidationResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForCreateWebService"></a>
# **Resolve-ForCreateWebService**
> CreateWebUrlValidationResult Resolve-ForCreateWebService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateWebValidationParameter] <PSCustomObject><br>

validate permissions, scope for create web service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$CreateWebValidationParameter = $CreateWebValidationParameter = New-CreateWebValidationParameter -ParentUrl "MyParentUrl" -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # CreateWebValidationParameter |  (optional)

# validate permissions, scope for create web service
try {
     $Result = Resolve-ForCreateWebService -Id $Id -CreateWebValidationParameter $CreateWebValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForCreateWebService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CreateWebValidationParameter** | [**CreateWebValidationParameter**](CreateWebValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreateWebUrlValidationResult**](CreateWebUrlValidationResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForGrantPermissionService"></a>
# **Resolve-ForGrantPermissionService**
> GrantPermissionUrlValidationResult Resolve-ForGrantPermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for grant permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for grant permission service
try {
     $Result = Resolve-ForGrantPermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForGrantPermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**GrantPermissionUrlValidationResult**](GrantPermissionUrlValidationResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForGroupLifecycleService"></a>
# **Resolve-ForGroupLifecycleService**
> GroupLifecycleValidateResult Resolve-ForGroupLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupValidationParameter] <PSCustomObject><br>

validate permissions, scope for group lifecycle service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$GroupValidationParameter = $GroupValidationParameter = New-GroupValidationParameter -GroupId "MyGroupId" -IsEditTask $false -IsFromQuestionnaire $false # GroupValidationParameter |  (optional)

# validate permissions, scope for group lifecycle service
try {
     $Result = Resolve-ForGroupLifecycleService -Id $Id -GroupValidationParameter $GroupValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForGroupLifecycleService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **GroupValidationParameter** | [**GroupValidationParameter**](GroupValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**GroupLifecycleValidateResult**](GroupLifecycleValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForManagePermissionService"></a>
# **Resolve-ForManagePermissionService**
> ManagePermissionValidateResult Resolve-ForManagePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for manage permission service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for manage permission service
try {
     $Result = Resolve-ForManagePermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForManagePermissionService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ManagePermissionValidateResult**](ManagePermissionValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForSiteLifecycleService"></a>
# **Resolve-ForSiteLifecycleService**
> SiteLifecycleValidateResult Resolve-ForSiteLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for site lifecycle service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for site lifecycle service
try {
     $Result = Resolve-ForSiteLifecycleService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForSiteLifecycleService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SiteLifecycleValidateResult**](SiteLifecycleValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ForWebLifecycleService"></a>
# **Resolve-ForWebLifecycleService**
> WebLifecycleValidateResult Resolve-ForWebLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for web lifecycle service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SiteValidationParameter = $SiteValidationParameter = New-SiteValidationParameter -Uri "MyUri" -IgnoreLock $false -IsEditTask $false -IsFromQuestionnaire $false # SiteValidationParameter |  (optional)

# validate permissions, scope for web lifecycle service
try {
     $Result = Resolve-ForWebLifecycleService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ForWebLifecycleService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**WebLifecycleValidateResult**](WebLifecycleValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-Guest"></a>
# **Resolve-Guest**
> void Resolve-Guest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GuestLifecycleValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$GuestLifecycleValidationParameter = $GuestLifecycleValidationParameter = New-GuestLifecycleValidationParameter -GuestId "MyGuestId" -OfficeTenantId "MyOfficeTenantId" # GuestLifecycleValidationParameter |  (optional)

try {
     $Result = Resolve-Guest -ServiceId $ServiceId -ActivityId $ActivityId -GuestLifecycleValidationParameter $GuestLifecycleValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-Guest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **GuestLifecycleValidationParameter** | [**GuestLifecycleValidationParameter**](GuestLifecycleValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-InviteEmail"></a>
# **Resolve-InviteEmail**
> ObjectValidateResult Resolve-InviteEmail<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ValidateInviteGuestEmailModel] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ValidateInviteGuestEmailModel = $ValidateInviteGuestEmailModel = New-ValidateInviteGuestEmailModel -TenantId "MyTenantId" -Email "MyEmail" # ValidateInviteGuestEmailModel |  (optional)

try {
     $Result = Resolve-InviteEmail -ValidateInviteGuestEmailModel $ValidateInviteGuestEmailModel
} catch {
    Write-Host ("Exception occured when calling Resolve-InviteEmail: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ValidateInviteGuestEmailModel** | [**ValidateInviteGuestEmailModel**](ValidateInviteGuestEmailModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ObjectValidateResult**](ObjectValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-M365User"></a>
# **Resolve-M365User**
> void Resolve-M365User<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-M365UserLifecycleValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$M365UserLifecycleValidationParameter = $M365UserLifecycleValidationParameter = New-M365UserLifecycleValidationParameter -UserId "MyUserId" -OfficeTenantId "MyOfficeTenantId" -Email "MyEmail" # M365UserLifecycleValidationParameter |  (optional)

try {
     $Result = Resolve-M365User -ServiceId $ServiceId -ActivityId $ActivityId -M365UserLifecycleValidationParameter $M365UserLifecycleValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-M365User: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **M365UserLifecycleValidationParameter** | [**M365UserLifecycleValidationParameter**](M365UserLifecycleValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ObjectForChangeContact"></a>
# **Resolve-ObjectForChangeContact**
> ChangeObjectValidateResult Resolve-ObjectForChangeContact<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeContactValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangeContactValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeContactValidationParameter = New-ChangeContactValidationParameter -ContactActivityId "MyContactActivityId" -ScopeActivityId "MyScopeActivityId" -TenantId "MyTenantId" -ObjectId "MyObjectId" -DisplayName "MyDisplayName" -Email "MyEmail" -Type $WorkspaceType # ChangeContactValidationParameter |  (optional)

try {
     $Result = Resolve-ObjectForChangeContact -ServiceId $ServiceId -ChangeContactValidationParameter $ChangeContactValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ObjectForChangeContact: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ChangeContactValidationParameter** | [**ChangeContactValidationParameter**](ChangeContactValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeObjectValidateResult**](ChangeObjectValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ObjectForChangeM365GroupSettings"></a>
# **Resolve-ObjectForChangeM365GroupSettings**
> ChangeM365GroupSettingsCheckResult Resolve-ObjectForChangeM365GroupSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeM365GroupSettingsValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangeM365GroupSettingsValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeM365GroupSettingsValidationParameter = New-ChangeM365GroupSettingsValidationParameter -ScopeActivityId "MyScopeActivityId" -TenantId "MyTenantId" -ObjectId "MyObjectId" -DisplayName "MyDisplayName" -Email "MyEmail" -Type $WorkspaceType # ChangeM365GroupSettingsValidationParameter |  (optional)

try {
     $Result = Resolve-ObjectForChangeM365GroupSettings -ServiceId $ServiceId -ChangeM365GroupSettingsValidationParameter $ChangeM365GroupSettingsValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ObjectForChangeM365GroupSettings: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ChangeM365GroupSettingsValidationParameter** | [**ChangeM365GroupSettingsValidationParameter**](ChangeM365GroupSettingsValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeM365GroupSettingsCheckResult**](ChangeM365GroupSettingsCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ObjectForChangeMailEnabledSecurityGroupSettings"></a>
# **Resolve-ObjectForChangeMailEnabledSecurityGroupSettings**
> ChangeMailEnabledSecurityGroupSettingsCheckResult Resolve-ObjectForChangeMailEnabledSecurityGroupSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeExchangeResourceGroupSettingsValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String |  (optional)
$ChangeExchangeResourceGroupSettingsValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeExchangeResourceGroupSettingsValidationParameter = New-ChangeExchangeResourceGroupSettingsValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -GroupType $WorkspaceType # ChangeExchangeResourceGroupSettingsValidationParameter |  (optional)

try {
     $Result = Resolve-ObjectForChangeMailEnabledSecurityGroupSettings -ServiceId $ServiceId -ActivityId $ActivityId -ChangeExchangeResourceGroupSettingsValidationParameter $ChangeExchangeResourceGroupSettingsValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ObjectForChangeMailEnabledSecurityGroupSettings: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | [optional] 
 **ChangeExchangeResourceGroupSettingsValidationParameter** | [**ChangeExchangeResourceGroupSettingsValidationParameter**](ChangeExchangeResourceGroupSettingsValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeMailEnabledSecurityGroupSettingsCheckResult**](ChangeMailEnabledSecurityGroupSettingsCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-ObjectForChangeMetadata"></a>
# **Resolve-ObjectForChangeMetadata**
> ChangeMetadataCheckResult Resolve-ObjectForChangeMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeMetadataValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangeMetadataValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeMetadataValidationParameter = New-ChangeMetadataValidationParameter -ScopeActivityId "MyScopeActivityId" -TenantId "MyTenantId" -ObjectId "MyObjectId" -DisplayName "MyDisplayName" -Email "MyEmail" -Type $WorkspaceType # ChangeMetadataValidationParameter |  (optional)

try {
     $Result = Resolve-ObjectForChangeMetadata -ServiceId $ServiceId -ChangeMetadataValidationParameter $ChangeMetadataValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-ObjectForChangeMetadata: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ChangeMetadataValidationParameter** | [**ChangeMetadataValidationParameter**](ChangeMetadataValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeMetadataCheckResult**](ChangeMetadataCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-SharedMailboxForChangePermission"></a>
# **Resolve-SharedMailboxForChangePermission**
> ChangeSharedMailboxPermissionCheckResult Resolve-SharedMailboxForChangePermission<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSharedMailboxPermissionValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangeSharedMailboxPermissionValidationParameter = $WorkspaceType = New-WorkspaceType 
$ChangeSharedMailboxPermissionValidationParameter = New-ChangeSharedMailboxPermissionValidationParameter -ScopeActivityId "MyScopeActivityId" -MembersActivityId "MyMembersActivityId" -SendAsActivityId "MySendAsActivityId" -SendOnBehalfActivityId "MySendOnBehalfActivityId" -TenantId "MyTenantId" -ObjectId "MyObjectId" -DisplayName "MyDisplayName" -Email "MyEmail" -Type $WorkspaceType # ChangeSharedMailboxPermissionValidationParameter |  (optional)

try {
     $Result = Resolve-SharedMailboxForChangePermission -ServiceId $ServiceId -ChangeSharedMailboxPermissionValidationParameter $ChangeSharedMailboxPermissionValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-SharedMailboxForChangePermission: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ChangeSharedMailboxPermissionValidationParameter** | [**ChangeSharedMailboxPermissionValidationParameter**](ChangeSharedMailboxPermissionValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSharedMailboxPermissionCheckResult**](ChangeSharedMailboxPermissionCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-SharedMailboxForLifecycle"></a>
# **Resolve-SharedMailboxForLifecycle**
> ChangeSharedMailboxPermissionCheckResult Resolve-SharedMailboxForLifecycle<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SharedMailboxLifecycleValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$SharedMailboxLifecycleValidationParameter = $WorkspaceType = New-WorkspaceType 
$SharedMailboxLifecycleValidationParameter = New-SharedMailboxLifecycleValidationParameter -ScopeActivityId "MyScopeActivityId" -TenantId "MyTenantId" -ObjectId "MyObjectId" -DisplayName "MyDisplayName" -Email "MyEmail" -Type $WorkspaceType # SharedMailboxLifecycleValidationParameter |  (optional)

try {
     $Result = Resolve-SharedMailboxForLifecycle -ServiceId $ServiceId -SharedMailboxLifecycleValidationParameter $SharedMailboxLifecycleValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-SharedMailboxForLifecycle: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **SharedMailboxLifecycleValidationParameter** | [**SharedMailboxLifecycleValidationParameter**](SharedMailboxLifecycleValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSharedMailboxPermissionCheckResult**](ChangeSharedMailboxPermissionCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-SiteForChangeSetting"></a>
# **Resolve-SiteForChangeSetting**
> ChangeSiteSettingCheckResult Resolve-SiteForChangeSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangeSiteValidationParameter = $ChangeSiteValidationParameter = New-ChangeSiteValidationParameter -SiteUrl "MySiteUrl" -Office365TenantId "MyOffice365TenantId" -ScopeActivityId "MyScopeActivityId" -ClassificationActivityId "MyClassificationActivityId" -SensitivityLabelActivityId "MySensitivityLabelActivityId" -StorageActivityId "MyStorageActivityId" -TitleActivityId "MyTitleActivityId" -HubSiteActivityId "MyHubSiteActivityId" -SharingActivityId "MySharingActivityId" -DescriptionActivityId "MyDescriptionActivityId" -LocaleActivityId "MyLocaleActivityId" -TimeZoneActivityId "MyTimeZoneActivityId" # ChangeSiteValidationParameter |  (optional)

try {
     $Result = Resolve-SiteForChangeSetting -ServiceId $ServiceId -ChangeSiteValidationParameter $ChangeSiteValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-SiteForChangeSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ChangeSiteValidationParameter** | [**ChangeSiteValidationParameter**](ChangeSiteValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeSiteSettingCheckResult**](ChangeSiteSettingCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-TeamForChangePrivateChannelService"></a>
# **Resolve-TeamForChangePrivateChannelService**
> ChangePrivateChannelCheckResult Resolve-TeamForChangePrivateChannelService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangePrivateChannelValidationParameter] <PSCustomObject><br>

validate teams for change private channel service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ChangePrivateChannelValidationParameter = $ChangePrivateChannelValidationParameter = New-ChangePrivateChannelValidationParameter -TeamObjectId "MyTeamObjectId" -TenantId "MyTenantId" -TaskId "MyTaskId" -IsEditTask $false -IsFromQuestionnaire $false # ChangePrivateChannelValidationParameter |  (optional)

# validate teams for change private channel service
try {
     $Result = Resolve-TeamForChangePrivateChannelService -ServiceId $ServiceId -ChangePrivateChannelValidationParameter $ChangePrivateChannelValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-TeamForChangePrivateChannelService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ChangePrivateChannelValidationParameter** | [**ChangePrivateChannelValidationParameter**](ChangePrivateChannelValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangePrivateChannelCheckResult**](ChangePrivateChannelCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-TeamForCreatePrivateChannelService"></a>
# **Resolve-TeamForCreatePrivateChannelService**
> CreatePrivateChannelCheckResult Resolve-TeamForCreatePrivateChannelService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreatePrivateChannelValidationParameter] <PSCustomObject><br>

validate teams for create private channel service

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$CreatePrivateChannelValidationParameter = $CreatePrivateChannelValidationParameter = New-CreatePrivateChannelValidationParameter -TeamObjectId "MyTeamObjectId" -TenantId "MyTenantId" -IsEditTask $false -IsFromQuestionnaire $false # CreatePrivateChannelValidationParameter |  (optional)

# validate teams for create private channel service
try {
     $Result = Resolve-TeamForCreatePrivateChannelService -ServiceId $ServiceId -CreatePrivateChannelValidationParameter $CreatePrivateChannelValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-TeamForCreatePrivateChannelService: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **CreatePrivateChannelValidationParameter** | [**CreatePrivateChannelValidationParameter**](CreatePrivateChannelValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**CreatePrivateChannelCheckResult**](CreatePrivateChannelCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-TeamSetting"></a>
# **Resolve-TeamSetting**
> ChangeTeamSettingCheckResult Resolve-TeamSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ActivityId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeTeamSettingValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ActivityId = "MyActivityId" # String | 
$ChangeTeamSettingValidationParameter = $ChangeTeamSettingValidationParameter = New-ChangeTeamSettingValidationParameter -TenantId "MyTenantId" -ObjectId "MyObjectId" -Email "MyEmail" -DisplayName "MyDisplayName" -RequestId "MyRequestId" # ChangeTeamSettingValidationParameter |  (optional)

try {
     $Result = Resolve-TeamSetting -ServiceId $ServiceId -ActivityId $ActivityId -ChangeTeamSettingValidationParameter $ChangeTeamSettingValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-TeamSetting: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ActivityId** | **String**|  | 
 **ChangeTeamSettingValidationParameter** | [**ChangeTeamSettingValidationParameter**](ChangeTeamSettingValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ChangeTeamSettingCheckResult**](ChangeTeamSettingCheckResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-UrlForManagePermission"></a>
# **Resolve-UrlForManagePermission**
> ManagePermissionValidateResult Resolve-UrlForManagePermission<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManagePermissionValidationParameter] <PSCustomObject><br>



### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$ServiceId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String | 
$ManagePermissionValidationParameter = $ManagePermissionValidationParameter = New-ManagePermissionValidationParameter -Uri "MyUri" -IgnoreLock $false -IsKeepPageUrl $false -Office365TenantId "MyOffice365TenantId" -ScopeActivityId "MyScopeActivityId" # ManagePermissionValidationParameter |  (optional)

try {
     $Result = Resolve-UrlForManagePermission -ServiceId $ServiceId -ManagePermissionValidationParameter $ManagePermissionValidationParameter
} catch {
    Write-Host ("Exception occured when calling Resolve-UrlForManagePermission: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ServiceId** | [**String**](String.md)|  | 
 **ManagePermissionValidationParameter** | [**ManagePermissionValidationParameter**](ManagePermissionValidationParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ManagePermissionValidateResult**](ManagePermissionValidateResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

