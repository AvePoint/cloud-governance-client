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
[**Get-ServiceId**](ServicesApi.md#Get-ServiceId) | **GET** /services/id | get service id by service name
[**Get-SiteLifecycleService**](ServicesApi.md#Get-SiteLifecycleService) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
[**Get-WebLifecycleService**](ServicesApi.md#Get-WebLifecycleService) | **GET** /services/weblifecycle/{id} | get web lifecycle service
[**Resolve-EmailForCreateGuestUserService**](ServicesApi.md#Resolve-EmailForCreateGuestUserService) | **GET** /services/createguestuser/{id}/email/validate | validate guest user email
[**Resolve-EmailsForCreateGuestUserService**](ServicesApi.md#Resolve-EmailsForCreateGuestUserService) | **POST** /services/createguestuser/{id}/email/validate | validate guest user emails
[**Resolve-ForChangeGroupSettingService**](ServicesApi.md#Resolve-ForChangeGroupSettingService) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
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
[**Resolve-TeamForChangePrivateChannelService**](ServicesApi.md#Resolve-TeamForChangePrivateChannelService) | **POST** /services/changeprivatechannel/{serviceId}/team/validation | validate teams for change private channel service
[**Resolve-TeamForCreatePrivateChannelService**](ServicesApi.md#Resolve-TeamForCreatePrivateChannelService) | **POST** /services/createprivatechannel/{serviceId}/team/validation | validate teams for create private channel service


<a name="Get-ChangeGroupSettingService"></a>
# **Get-ChangeGroupSettingService**
> ChangeGroupSettingService Get-ChangeGroupSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>



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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 

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
 **Id** | **String**|  | 

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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

<a name="Get-SiteLifecycleService"></a>
# **Get-SiteLifecycleService**
> SiteLifecycleService Get-SiteLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$QuestionnaireId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **QuestionnaireId** | **String**|  | [optional] 
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

<a name="Resolve-EmailForCreateGuestUserService"></a>
# **Resolve-EmailForCreateGuestUserService**
> ObjectValidateResult Resolve-EmailForCreateGuestUserService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Email] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestId] <String><br>

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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$Email = "MyEmail" # String | 
$RequestId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)

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
 **Id** | **String**|  | 
 **Email** | **String**|  | 
 **RequestId** | **String**|  | [optional] 

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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

<a name="Resolve-ForChangeGroupSettingService"></a>
# **Resolve-ForChangeGroupSettingService**
> ChangeGroupSettingCheckResult Resolve-ForChangeGroupSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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

<a name="Resolve-ForChangeListSettingService"></a>
# **Resolve-ForChangeListSettingService**
> ChangeListSettingValidateResult Resolve-ForChangeListSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestId] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$RequestId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
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
 **Id** | **String**|  | 
 **RequestId** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **Id** | **String**|  | 
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

<a name="Resolve-TeamForChangePrivateChannelService"></a>
# **Resolve-TeamForChangePrivateChannelService**
> ChangePrivateChannelCheckResult Resolve-TeamForChangePrivateChannelService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <String><br>
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



$ServiceId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **ServiceId** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ServiceId] <String><br>
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



$ServiceId = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
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
 **ServiceId** | **String**|  | 
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

