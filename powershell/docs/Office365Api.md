# Office365Api

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**New-ACGSecurityGroup**](Office365Api.md#new-acgsecuritygroup) | **POST** /office365/securitygroups | Create mail-enabled security group
[**Get-ACGAllSiteDesigns**](Office365Api.md#get-acgallsitedesigns) | **GET** /office365/allsitedesigns | get all site designs by site url
[**Get-GroupAllMembersByGroupValue**](Office365Api.md#Get-GroupAllMembersByGroupValue) | **GET** /office365/groups/allmembers | get group members by group email
[**Get-ACGGroupMembers**](Office365Api.md#get-acggroupmembers) | **GET** /office365/groups/{email}/memberswithoutowner | get group members without owners by group email
[**Get-ACGGroupOwners**](Office365Api.md#get-acggroupowners) | **GET** /office365/groups/{email}/owners | get group owners by group email
[**Get-HubSiteUrlsByUrl**](Office365Api.md#Get-HubSiteUrlsByUrl) | **GET** /office365/hubsiteurls | get all hubsite urls from site&#39;s tenant
[**Get-HubSitesByUrl**](Office365Api.md#Get-HubSitesByUrl) | **GET** /office365/hubsites | get all hubsites from site&#39;s tenant
[**Get-OfficeSiteTemplates**](Office365Api.md#get-officesitetemplates) | **GET** /office365/{officeTenantId}/sites/templates/{languageId} | get site templates with language code identifier
[**Get-OwnedTeams**](Office365Api.md#Get-OwnedTeams) | **GET** /office365/teams/my | get all teams that owner is curernt user
[**Get-ACGPermissions**](Office365Api.md#get-acgpermissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
[**Get-ACGRoleAssignment**](Office365Api.md#get-acgroleassignment) | **GET** /office365/roleassignment | get site permimssion role assignment
[**Get-ACGSiteDesigns**](Office365Api.md#get-acgsitedesigns) | **GET** /office365/sitedesigns | get site designs by site url
[**Get-SitePermissionLevels**](Office365Api.md#Get-SitePermissionLevels) | **GET** /office365/sites/permissionlevels | get site permission levels
[**Get-SiteSensitivityLabels**](Office365Api.md#Get-SiteSensitivityLabels) | **GET** /office365/sites/sensitivitylabelsetting | get site sharePoint groups
[**Get-SiteSharePointGroups**](Office365Api.md#Get-SiteSharePointGroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
[**Get-ACGSiteStatus**](Office365Api.md#get-acgsitestatus) | **GET** /office365/sites/status | check site collection status by full url
[**Get-ACGSiteTemplates**](Office365Api.md#get-acgsitetemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
[**Get-ACGTeamSiteDesigns**](Office365Api.md#get-acgteamsitedesigns) | **GET** /office365/teamsitedesigns | 
[**Invoke-HasPermission**](Office365Api.md#Invoke-HasPermission) | **GET** /office365/sites/haspermission | whether user has permission on the site
[**Remove-ACGSecurityGroup**](Office365Api.md#remove-acgsecuritygroup) | **DELETE** /office365/securitygroups/{name} | Remove mail-enabled security group by group name


<a name="new-acgsecuritygroup"></a>
# **New-ACGSecurityGroup**
> void New-ACGSecurityGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupSettingModel] <PSCustomObject><br>

Create mail-enabled security group

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



$GroupSettingModel = $GroupSettingModel = New-GroupSettingModel -GroupName "MyGroupName" -GroupDescription "MyGroupDescription" -GroupEmailAddress "MyGroupEmailAddress" -Owners "MyOwners" -Members "MyMembers" -GroupDuration 0 -EmailSubject "MyEmailSubject" -EmailBody "MyEmailBody" # GroupSettingModel | GroupName,GroupEmailAddress,Owners,Members (optional)

# Create mail-enabled security group
try {
     $Result = New-ACGSecurityGroup -GroupSettingModel $GroupSettingModel
} catch {
    Write-Host ("Exception occured when calling New-ACGSecurityGroup: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **GroupSettingModel** | [**GroupSettingModel**](GroupSettingModel.md)| GroupName,GroupEmailAddress,Owners,Members | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgallsitedesigns"></a>
# **Get-ACGAllSiteDesigns**
> SiteDesignModel[] Get-ACGAllSiteDesigns<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrl] <String><br>

get all site designs by site url

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



$SiteUrl = "MySiteUrl" # String | 

# get all site designs by site url
try {
     $Result = Get-ACGAllSiteDesigns -SiteUrl $SiteUrl
} catch {
    Write-Host ("Exception occured when calling Get-ACGAllSiteDesigns: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SiteUrl** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SiteDesignModel[]**](SiteDesignModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupAllMembersByGroupValue"></a>
# **Get-GroupAllMembersByGroupValue**
> ApiUserPageResult Get-GroupAllMembersByGroupValue<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ObjectIdOrNameOrEmail] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TenantId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get group members by group email

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



$ObjectIdOrNameOrEmail = "MyObjectIdOrNameOrEmail" # String | 
$TenantId = "MyTenantId" # String | 
$Top = 56 # Int32 |  (optional) (default to 0)
$Skip = 56 # Int32 |  (optional) (default to 0)
$Search = "MySearch" # String |  (optional)

# get group members by group email
try {
     $Result = Get-GroupAllMembersByGroupValue -ObjectIdOrNameOrEmail $ObjectIdOrNameOrEmail -TenantId $TenantId -Top $Top -Skip $Skip -Search $Search
} catch {
    Write-Host ("Exception occured when calling Get-GroupAllMembersByGroupValue: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ObjectIdOrNameOrEmail** | **String**|  | 
 **TenantId** | **String**|  | 
 **Top** | **Int32**|  | [optional] [default to 0]
 **Skip** | **Int32**|  | [optional] [default to 0]
 **Search** | **String**|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acggroupmembers"></a>
# **Get-ACGGroupMembers**
> ApiUserPageResult Get-ACGGroupMembers<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Email] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get group members without owners by group email

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



$Email = "MyEmail" # String | 
$Top = 56 # Int32 |  (optional) (default to 0)
$Skip = 56 # Int32 |  (optional) (default to 0)
$Search = "MySearch" # String |  (optional)

# get group members without owners by group email
try {
     $Result = Get-ACGGroupMembers -Email $Email -Top $Top -Skip $Skip -Search $Search
} catch {
    Write-Host ("Exception occured when calling Get-ACGGroupMembers: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Email** | **String**|  | 
 **Top** | **Int32**|  | [optional] [default to 0]
 **Skip** | **Int32**|  | [optional] [default to 0]
 **Search** | **String**|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acggroupowners"></a>
# **Get-ACGGroupOwners**
> ApiUserPageResult Get-ACGGroupOwners<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Email] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get group owners by group email

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



$Email = "MyEmail" # String | 
$Top = 56 # Int32 |  (optional) (default to 0)
$Skip = 56 # Int32 |  (optional) (default to 0)
$Search = "MySearch" # String |  (optional)

# get group owners by group email
try {
     $Result = Get-ACGGroupOwners -Email $Email -Top $Top -Skip $Skip -Search $Search
} catch {
    Write-Host ("Exception occured when calling Get-ACGGroupOwners: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Email** | **String**|  | 
 **Top** | **Int32**|  | [optional] [default to 0]
 **Skip** | **Int32**|  | [optional] [default to 0]
 **Search** | **String**|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-HubSiteUrlsByUrl"></a>
# **Get-HubSiteUrlsByUrl**
> HubSiteUrl[] Get-HubSiteUrlsByUrl<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrl] <String><br>

get all hubsite urls from site's tenant

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



$SiteUrl = "MySiteUrl" # String | any site url in your tenant

# get all hubsite urls from site's tenant
try {
     $Result = Get-HubSiteUrlsByUrl -SiteUrl $SiteUrl
} catch {
    Write-Host ("Exception occured when calling Get-HubSiteUrlsByUrl: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SiteUrl** | **String**| any site url in your tenant | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**HubSiteUrl[]**](HubSiteUrl.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-HubSitesByUrl"></a>
# **Get-HubSitesByUrl**
> GuidModel[] Get-HubSitesByUrl<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrl] <String><br>

get all hubsites from site's tenant

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



$SiteUrl = "MySiteUrl" # String | any site url in your tenant

# get all hubsites from site's tenant
try {
     $Result = Get-HubSitesByUrl -SiteUrl $SiteUrl
} catch {
    Write-Host ("Exception occured when calling Get-HubSitesByUrl: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SiteUrl** | **String**| any site url in your tenant | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**GuidModel[]**](GuidModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-officesitetemplates"></a>
# **Get-OfficeSiteTemplates**
> SiteTemplate[] Get-OfficeSiteTemplates<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-OfficeTenantId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-LanguageId] <Int32><br>

get site templates with language code identifier

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



$OfficeTenantId = "MyOfficeTenantId" # String | 
$LanguageId = 56 # Int32 |  (default to 0)

# get site templates with language code identifier
try {
     $Result = Get-OfficeSiteTemplates -OfficeTenantId $OfficeTenantId -LanguageId $LanguageId
} catch {
    Write-Host ("Exception occured when calling Get-OfficeSiteTemplates: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **OfficeTenantId** | **String**|  | 
 **LanguageId** | **Int32**|  | [default to 0]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SiteTemplate[]**](SiteTemplate.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-OwnedTeams"></a>
# **Get-OwnedTeams**
> GuidModel[] Get-OwnedTeams<br>

get all teams that owner is curernt user

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




# get all teams that owner is curernt user
try {
     $Result = Get-OwnedTeams
} catch {
    Write-Host ("Exception occured when calling Get-OwnedTeams: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters
This endpoint does not need any parameter.

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**GuidModel[]**](GuidModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgpermissions"></a>
# **Get-ACGPermissions**
> UserGroupPermissions Get-ACGPermissions<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-WebUrl] <String><br>

get web permissions for creating list request by web url

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



$WebUrl = "MyWebUrl" # String | 

# get web permissions for creating list request by web url
try {
     $Result = Get-ACGPermissions -WebUrl $WebUrl
} catch {
    Write-Host ("Exception occured when calling Get-ACGPermissions: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **WebUrl** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**UserGroupPermissions**](UserGroupPermissions.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgroleassignment"></a>
# **Get-ACGRoleAssignment**
> SPRoleAssignment[] Get-ACGRoleAssignment<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Url] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Type] <PSCustomObject><br>

get site permimssion role assignment

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



$Url = "MyUrl" # String | 
$Type = "2" # NodeType | 

# get site permimssion role assignment
try {
     $Result = Get-ACGRoleAssignment -Url $Url -Type $Type
} catch {
    Write-Host ("Exception occured when calling Get-ACGRoleAssignment: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Url** | **String**|  | 
 **Type** | [**NodeType**](NodeType.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SPRoleAssignment[]**](SPRoleAssignment.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgsitedesigns"></a>
# **Get-ACGSiteDesigns**
> StringModel[] Get-ACGSiteDesigns<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrl] <String><br>

get site designs by site url

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



$SiteUrl = "MySiteUrl" # String | 

# get site designs by site url
try {
     $Result = Get-ACGSiteDesigns -SiteUrl $SiteUrl
} catch {
    Write-Host ("Exception occured when calling Get-ACGSiteDesigns: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SiteUrl** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**StringModel[]**](StringModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionLevels"></a>
# **Get-SitePermissionLevels**
> PermissionLevel[] Get-SitePermissionLevels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Uri] <String><br>

get site permission levels

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



$Uri = "MyUri" # String | 

# get site permission levels
try {
     $Result = Get-SitePermissionLevels -Uri $Uri
} catch {
    Write-Host ("Exception occured when calling Get-SitePermissionLevels: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Uri** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**PermissionLevel[]**](PermissionLevel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteSensitivityLabels"></a>
# **Get-SiteSensitivityLabels**
> Office365SiteSettingModel Get-SiteSensitivityLabels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Uri] <String><br>

get site sharePoint groups

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



$Uri = "MyUri" # String | 

# get site sharePoint groups
try {
     $Result = Get-SiteSensitivityLabels -Uri $Uri
} catch {
    Write-Host ("Exception occured when calling Get-SiteSensitivityLabels: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Uri** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**Office365SiteSettingModel**](Office365SiteSettingModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteSharePointGroups"></a>
# **Get-SiteSharePointGroups**
> SPGroup[] Get-SiteSharePointGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Uri] <String><br>

get site sharePoint groups

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



$Uri = "MyUri" # String | 

# get site sharePoint groups
try {
     $Result = Get-SiteSharePointGroups -Uri $Uri
} catch {
    Write-Host ("Exception occured when calling Get-SiteSharePointGroups: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Uri** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SPGroup[]**](SPGroup.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgsitestatus"></a>
# **Get-ACGSiteStatus**
> ApiSiteStatus Get-ACGSiteStatus<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-FullUrl] <String><br>

check site collection status by full url

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



$FullUrl = "MyFullUrl" # String | 

# check site collection status by full url
try {
     $Result = Get-ACGSiteStatus -FullUrl $FullUrl
} catch {
    Write-Host ("Exception occured when calling Get-ACGSiteStatus: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **FullUrl** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiSiteStatus**](ApiSiteStatus.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgsitetemplates"></a>
# **Get-ACGSiteTemplates**
> SiteTemplate[] Get-ACGSiteTemplates<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Url] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Languageid] <Int32><br>

get site templates with language code identifier

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



$Url = "MyUrl" # String | 
$Languageid = 56 # Int32 |  (default to 0)

# get site templates with language code identifier
try {
     $Result = Get-ACGSiteTemplates -Url $Url -Languageid $Languageid
} catch {
    Write-Host ("Exception occured when calling Get-ACGSiteTemplates: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Url** | **String**|  | 
 **Languageid** | **Int32**|  | [default to 0]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SiteTemplate[]**](SiteTemplate.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get-acgteamsitedesigns"></a>
# **Get-ACGTeamSiteDesigns**
> StringModel[] Get-ACGTeamSiteDesigns<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TenantId] <PSCustomObject><br>



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



$TenantId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)

try {
     $Result = Get-ACGTeamSiteDesigns -TenantId $TenantId
} catch {
    Write-Host ("Exception occured when calling Get-ACGTeamSiteDesigns: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TenantId** | [**String**](String.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**StringModel[]**](StringModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-HasPermission"></a>
# **Invoke-HasPermission**
> Boolean Invoke-HasPermission<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Siteurl] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Currentuser] <String><br>

whether user has permission on the site

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



$Siteurl = "MySiteurl" # String | 
$Currentuser = "MyCurrentuser" # String | 

# whether user has permission on the site
try {
     $Result = Invoke-HasPermission -Siteurl $Siteurl -Currentuser $Currentuser
} catch {
    Write-Host ("Exception occured when calling Invoke-HasPermission: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Siteurl** | **String**|  | 
 **Currentuser** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**Boolean**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remove-acgsecuritygroup"></a>
# **Remove-ACGSecurityGroup**
> void Remove-ACGSecurityGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

Remove mail-enabled security group by group name

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



$Name = "MyName" # String | group email address

# Remove mail-enabled security group by group name
try {
     $Result = Remove-ACGSecurityGroup -Name $Name
} catch {
    Write-Host ("Exception occured when calling Remove-ACGSecurityGroup: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Name** | **String**| group email address | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

