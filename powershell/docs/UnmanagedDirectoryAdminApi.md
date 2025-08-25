# UnmanagedDirectoryAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Import-UnmanagedAdGroups**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedAdGroups) | **POST** /admin/directory/unmanaged/adgroup/import | manually import existing azure ad groups
[**Import-UnmanagedEnvironments**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedEnvironments) | **POST** /admin/directory/unmanaged/environment/import | manually import existing environments
[**Import-UnmanagedGroups**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedGroups) | **POST** /admin/directory/unmanaged/group/import | manually import existing microsoft 365 groups
[**Import-UnmanagedPowerApps**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedPowerApps) | **POST** /admin/directory/unmanaged/powerapps/import | manually import existing power apps
[**Import-UnmanagedPowerAutomate**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedPowerAutomate) | **POST** /admin/directory/unmanaged/powerautomate/import | manually import existing power automate
[**Import-UnmanagedPowerBI**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedPowerBI) | **POST** /admin/directory/unmanaged/powerbi/import | manually import existing power bi
[**Import-UnmanagedSharedMailboxes**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedSharedMailboxes) | **POST** /admin/directory/unmanaged/sharedmailbox/import | manually import existing shared mailbox
[**Import-UnmanagedSites**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedSites) | **POST** /admin/directory/unmanaged/site/import | manually import existing site collections
[**Import-UnmanagedTeams**](UnmanagedDirectoryAdminApi.md#Import-UnmanagedTeams) | **POST** /admin/directory/unmanaged/team/import | manually import existing microsoft teams


<a name="Import-UnmanagedAdGroups"></a>
# **Import-UnmanagedAdGroups**
> void Import-UnmanagedAdGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportAdGroupJobModel] <PSCustomObject><br>

manually import existing azure ad groups

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



$ManualImportAdGroupJobModel = $ImportObjectType = New-ImportObjectType 
$ManualImportAdGroupJobModel = New-ManualImportAdGroupJobModel -ObjectType $ImportObjectType -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportAdGroupJobModel |  (optional)

# manually import existing azure ad groups
try {
     $Result = Import-UnmanagedAdGroups -ManualImportAdGroupJobModel $ManualImportAdGroupJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedAdGroups: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportAdGroupJobModel** | [**ManualImportAdGroupJobModel**](ManualImportAdGroupJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedEnvironments"></a>
# **Import-UnmanagedEnvironments**
> String Import-UnmanagedEnvironments<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportEnvironmentJobModel] <PSCustomObject><br>

manually import existing environments

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



$ManualImportEnvironmentJobModel = $ImportObjectType = New-ImportObjectType 

$ImportMetadataModel = New-ImportMetadataModel -Name "MyName" -Value "MyValue"
$ImportEnvironmentModel = New-ImportEnvironmentModel -ObjectType $ImportObjectType -Id "MyId" -Url "MyUrl" -Name "MyName" -TenantId "MyTenantId" -ContactElectionProfile "MyContactElectionProfile" -RenewalProfile "MyRenewalProfile" -PrimaryContact "MyPrimaryContact" -SecondaryContact "MySecondaryContact" -Metadatas $ImportMetadataModel

$ManualImportEnvironmentJobModel = New-ManualImportEnvironmentJobModel -ObjectType $ImportObjectType -Workspaces $ImportEnvironmentModel -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportEnvironmentJobModel |  (optional)

# manually import existing environments
try {
     $Result = Import-UnmanagedEnvironments -ManualImportEnvironmentJobModel $ManualImportEnvironmentJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedEnvironments: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportEnvironmentJobModel** | [**ManualImportEnvironmentJobModel**](ManualImportEnvironmentJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedGroups"></a>
# **Import-UnmanagedGroups**
> String Import-UnmanagedGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportGroupJobModel] <PSCustomObject><br>

manually import existing microsoft 365 groups

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



$ManualImportGroupJobModel = $ImportObjectType = New-ImportObjectType 
$LifecycleJobTimeBaseType = New-LifecycleJobTimeBaseType 

$AppSettingType = New-AppSettingType 
$ImportMetadataModel = New-ImportMetadataModel -Name "MyName" -Value "MyValue"
$ImportGroupModel = New-ImportGroupModel -ObjectType $ImportObjectType -GroupName "MyGroupName" -EmailAddress "MyEmailAddress" -IsKeepSiteQuota $false -AppSetting $AppSettingType -ExternalSharingProfile "MyExternalSharingProfile" -StorageManagementProfile "MyStorageManagementProfile" -ContactElectionProfile "MyContactElectionProfile" -RenewalProfile "MyRenewalProfile" -PrimaryContact "MyPrimaryContact" -SecondaryContact "MySecondaryContact" -Metadatas $ImportMetadataModel

$ManualImportGroupJobModel = New-ManualImportGroupJobModel -ObjectType $ImportObjectType -InactiveJobTimeBaseType $LifecycleJobTimeBaseType -Workspaces $ImportGroupModel -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportGroupJobModel |  (optional)

# manually import existing microsoft 365 groups
try {
     $Result = Import-UnmanagedGroups -ManualImportGroupJobModel $ManualImportGroupJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedGroups: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportGroupJobModel** | [**ManualImportGroupJobModel**](ManualImportGroupJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedPowerApps"></a>
# **Import-UnmanagedPowerApps**
> void Import-UnmanagedPowerApps<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportPowerAppsJobModel] <PSCustomObject><br>

manually import existing power apps

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



$ManualImportPowerAppsJobModel = $ImportObjectType = New-ImportObjectType 
$ManualImportPowerAppsJobModel = New-ManualImportPowerAppsJobModel -ObjectType $ImportObjectType -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportPowerAppsJobModel |  (optional)

# manually import existing power apps
try {
     $Result = Import-UnmanagedPowerApps -ManualImportPowerAppsJobModel $ManualImportPowerAppsJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedPowerApps: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportPowerAppsJobModel** | [**ManualImportPowerAppsJobModel**](ManualImportPowerAppsJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedPowerAutomate"></a>
# **Import-UnmanagedPowerAutomate**
> void Import-UnmanagedPowerAutomate<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportPowerAutomateJobModel] <PSCustomObject><br>

manually import existing power automate

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



$ManualImportPowerAutomateJobModel = $ImportObjectType = New-ImportObjectType 
$ManualImportPowerAutomateJobModel = New-ManualImportPowerAutomateJobModel -ObjectType $ImportObjectType -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportPowerAutomateJobModel |  (optional)

# manually import existing power automate
try {
     $Result = Import-UnmanagedPowerAutomate -ManualImportPowerAutomateJobModel $ManualImportPowerAutomateJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedPowerAutomate: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportPowerAutomateJobModel** | [**ManualImportPowerAutomateJobModel**](ManualImportPowerAutomateJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedPowerBI"></a>
# **Import-UnmanagedPowerBI**
> void Import-UnmanagedPowerBI<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportPowerBIJobModel] <PSCustomObject><br>

manually import existing power bi

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



$ManualImportPowerBIJobModel = $ImportObjectType = New-ImportObjectType 
$ManualImportPowerBIJobModel = New-ManualImportPowerBIJobModel -ObjectType $ImportObjectType -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportPowerBIJobModel |  (optional)

# manually import existing power bi
try {
     $Result = Import-UnmanagedPowerBI -ManualImportPowerBIJobModel $ManualImportPowerBIJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedPowerBI: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportPowerBIJobModel** | [**ManualImportPowerBIJobModel**](ManualImportPowerBIJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedSharedMailboxes"></a>
# **Import-UnmanagedSharedMailboxes**
> void Import-UnmanagedSharedMailboxes<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportSharedMailboxJobModel] <PSCustomObject><br>

manually import existing shared mailbox

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



$ManualImportSharedMailboxJobModel = $ImportObjectType = New-ImportObjectType 

$ImportMetadataModel = New-ImportMetadataModel -Name "MyName" -Value "MyValue"
$ImportSharedMailboxModel = New-ImportSharedMailboxModel -ObjectType $ImportObjectType -SharedMailboxName "MySharedMailboxName" -EmailAddress "MyEmailAddress" -ContactElectionProfile "MyContactElectionProfile" -RenewalProfile "MyRenewalProfile" -PrimaryContact "MyPrimaryContact" -SecondaryContact "MySecondaryContact" -Metadatas $ImportMetadataModel

$ManualImportSharedMailboxJobModel = New-ManualImportSharedMailboxJobModel -ObjectType $ImportObjectType -Workspaces $ImportSharedMailboxModel -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportSharedMailboxJobModel |  (optional)

# manually import existing shared mailbox
try {
     $Result = Import-UnmanagedSharedMailboxes -ManualImportSharedMailboxJobModel $ManualImportSharedMailboxJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedSharedMailboxes: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportSharedMailboxJobModel** | [**ManualImportSharedMailboxJobModel**](ManualImportSharedMailboxJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedSites"></a>
# **Import-UnmanagedSites**
> String Import-UnmanagedSites<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportSiteJobModel] <PSCustomObject><br>

manually import existing site collections

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



$ManualImportSiteJobModel = $ImportObjectType = New-ImportObjectType 
$LifecycleJobTimeBaseType = New-LifecycleJobTimeBaseType 

$AppSettingType = New-AppSettingType 
$ImportMetadataModel = New-ImportMetadataModel -Name "MyName" -Value "MyValue"
$ImportSiteModel = New-ImportSiteModel -ObjectType $ImportObjectType -SiteTitle "MySiteTitle" -SiteUrl "MySiteUrl" -IsKeepSiteQuota $false -AppSetting $AppSettingType -ExternalSharingProfile "MyExternalSharingProfile" -StorageManagementProfile "MyStorageManagementProfile" -ContactElectionProfile "MyContactElectionProfile" -RenewalProfile "MyRenewalProfile" -PrimaryContact "MyPrimaryContact" -SecondaryContact "MySecondaryContact" -Metadatas $ImportMetadataModel

$ManualImportSiteJobModel = New-ManualImportSiteJobModel -ObjectType $ImportObjectType -InactiveJobTimeBaseType $LifecycleJobTimeBaseType -Workspaces $ImportSiteModel -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportSiteJobModel |  (optional)

# manually import existing site collections
try {
     $Result = Import-UnmanagedSites -ManualImportSiteJobModel $ManualImportSiteJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedSites: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportSiteJobModel** | [**ManualImportSiteJobModel**](ManualImportSiteJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-UnmanagedTeams"></a>
# **Import-UnmanagedTeams**
> String Import-UnmanagedTeams<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManualImportTeamJobModel] <PSCustomObject><br>

manually import existing microsoft teams

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



$ManualImportTeamJobModel = $ImportObjectType = New-ImportObjectType 
$LifecycleJobTimeBaseType = New-LifecycleJobTimeBaseType 

$AppSettingType = New-AppSettingType 
$ImportMetadataModel = New-ImportMetadataModel -Name "MyName" -Value "MyValue"
$ImportTeamModel = New-ImportTeamModel -ObjectType $ImportObjectType -TeamName "MyTeamName" -EmailAddress "MyEmailAddress" -IsKeepSiteQuota $false -AppSetting $AppSettingType -ExternalSharingProfile "MyExternalSharingProfile" -StorageManagementProfile "MyStorageManagementProfile" -ContactElectionProfile "MyContactElectionProfile" -RenewalProfile "MyRenewalProfile" -PrimaryContact "MyPrimaryContact" -SecondaryContact "MySecondaryContact" -Metadatas $ImportMetadataModel

$ManualImportTeamJobModel = New-ManualImportTeamJobModel -ObjectType $ImportObjectType -IsIncludeArchivedTeams $false -InactiveJobTimeBaseType $LifecycleJobTimeBaseType -Workspaces $ImportTeamModel -Name "MyName" -Description "MyDescription" -FileName "MyFileName" # ManualImportTeamJobModel |  (optional)

# manually import existing microsoft teams
try {
     $Result = Import-UnmanagedTeams -ManualImportTeamJobModel $ManualImportTeamJobModel
} catch {
    Write-Host ("Exception occured when calling Import-UnmanagedTeams: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ManualImportTeamJobModel** | [**ManualImportTeamJobModel**](ManualImportTeamJobModel.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

