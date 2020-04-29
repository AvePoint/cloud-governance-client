# Cloud.Governance.Client.Cloud.Governance.Client\Api.DirectoryAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-ApplyGroupsPolicy**](DirectoryAdminApi.md#Invoke-ApplyGroupsPolicy) | **POST** /admin/directory/groups/policy | apply groups policy
[**Invoke-ApplySitesPolicy**](DirectoryAdminApi.md#Invoke-ApplySitesPolicy) | **POST** /admin/directory/sites/policy | apply sites policy
[**Invoke-ApplyTeamsPolicy**](DirectoryAdminApi.md#Invoke-ApplyTeamsPolicy) | **POST** /admin/directory/teams/policy | apply teams policy
[**Invoke-ElectContact**](DirectoryAdminApi.md#Invoke-ElectContact) | **POST** /admin/directory/sites/contact/election | elect sites contact
[**Export-ManagedGroups**](DirectoryAdminApi.md#Export-ManagedGroups) | **GET** /admin/directory/groups/export | export all managed groups
[**Export-ManagedSites**](DirectoryAdminApi.md#Export-ManagedSites) | **GET** /admin/directory/sites/export | export all managed sites
[**Export-ManagedTeams**](DirectoryAdminApi.md#Export-ManagedTeams) | **GET** /admin/directory/teams/export | export all managed teams
[**Get-AllMailContacts**](DirectoryAdminApi.md#Get-AllMailContacts) | **GET** /admin/directory/sites/contact/mail | get all sites contacts
[**Get-ManagedGroupFilters**](DirectoryAdminApi.md#Get-ManagedGroupFilters) | **GET** /admin/directory/groups/filters | get managed groups filters
[**Get-ManagedGroups**](DirectoryAdminApi.md#Get-ManagedGroups) | **GET** /admin/directory/groups | get all managed groups
[**Get-ManagedSites**](DirectoryAdminApi.md#Get-ManagedSites) | **GET** /admin/directory/sites | get all managed sites
[**Get-ManagedSitesFilters**](DirectoryAdminApi.md#Get-ManagedSitesFilters) | **GET** /admin/directory/sites/filters | get managed sites filters
[**Get-ManagedTeamFilters**](DirectoryAdminApi.md#Get-ManagedTeamFilters) | **GET** /admin/directory/teams/filters | get managed teams filters
[**Get-ManagedTeams**](DirectoryAdminApi.md#Get-ManagedTeams) | **GET** /admin/directory/teams | get all managed teams
[**Get-ManagedWebs**](DirectoryAdminApi.md#Get-ManagedWebs) | **GET** /admin/directory/webs | get all managed webs
[**Get-ManagedWebsFilters**](DirectoryAdminApi.md#Get-ManagedWebsFilters) | **GET** /admin/directory/webs/filters | get managed webs filters
[**Invoke-SpecifyContact**](DirectoryAdminApi.md#Invoke-SpecifyContact) | **POST** /admin/directory/sites/contact/specification | specify selected sites contact


<a name="Invoke-ApplyGroupsPolicy"></a>
# **Invoke-ApplyGroupsPolicy**
> String[] Invoke-ApplyGroupsPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyPolicyRequestModel] <PSCustomObject><br>

apply groups policy

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



$ApplyPolicyRequestModel = (New-ApplyPolicyRequestModel -PolicyId "TODO"  -LocationId 123  -FolderUrl "FolderUrl_example"  -StartDateType (New-StartDateType)  -IsCheckLock $false  -Filter "Filter_example"  -SelectedObjectsId @("TODO")  -SpecifyDateTicks 123  -IsExportLocation $false) # ApplyPolicyRequestModel |  (optional)

# apply groups policy
try {
    $Result = Invoke-ApplyGroupsPolicy -ApplyPolicyRequestModel $ApplyPolicyRequestModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyPolicyRequestModel** | [**ApplyPolicyRequestModel**](ApplyPolicyRequestModel.md)|  | [optional] 

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ApplySitesPolicy"></a>
# **Invoke-ApplySitesPolicy**
> void Invoke-ApplySitesPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyPolicyRequestModel] <PSCustomObject><br>

apply sites policy

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



$ApplyPolicyRequestModel = (New-ApplyPolicyRequestModel -PolicyId "TODO"  -LocationId 123  -FolderUrl "FolderUrl_example"  -StartDateType (New-StartDateType)  -IsCheckLock $false  -Filter "Filter_example"  -SelectedObjectsId @("TODO")  -SpecifyDateTicks 123  -IsExportLocation $false) # ApplyPolicyRequestModel |  (optional)

# apply sites policy
try {
    Invoke-ApplySitesPolicy -ApplyPolicyRequestModel $ApplyPolicyRequestModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyPolicyRequestModel** | [**ApplyPolicyRequestModel**](ApplyPolicyRequestModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ApplyTeamsPolicy"></a>
# **Invoke-ApplyTeamsPolicy**
> String[] Invoke-ApplyTeamsPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyPolicyRequestModel] <PSCustomObject><br>

apply teams policy

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

$ApplyPolicyRequestModel =  # ApplyPolicyRequestModel |  (optional)

# apply teams policy
try {
    $Result = Invoke-ApplyTeamsPolicy -ApplyPolicyRequestModel $ApplyPolicyRequestModel
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyPolicyRequestModel** | [**ApplyPolicyRequestModel**](ApplyPolicyRequestModel.md)|  | [optional] 

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ElectContact"></a>
# **Invoke-ElectContact**
> String[] Invoke-ElectContact<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ElectUserRequestModel] <PSCustomObject><br>

elect sites contact

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

$ElectUserRequestModel = (New-ElectUserRequestModel -Title "Title_example"  -ExcludeUsers @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -EnableNotifyTask $false  -TaskEmailTemplateId "TODO"  -EnableNotifyPrimaryContact $false  -NotifyPrimaryContactTemplateId "TODO"  -EnableNotifySecondaryContact $false  -NotifySecondaryContactTemplateId "TODO"  -Duration 123  -DurationType (New-ElectionDurationType)  -IsEnableTaskReminder $false  -TaskReminderProfileId "TODO"  -SelectedSiteIds @("SelectedSiteIds_example")) # ElectUserRequestModel |  (optional)

# elect sites contact
try {
    $Result = Invoke-ElectContact -ElectUserRequestModel $ElectUserRequestModel
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ElectUserRequestModel** | [**ElectUserRequestModel**](ElectUserRequestModel.md)|  | [optional] 

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Export-ManagedGroups"></a>
# **Export-ManagedGroups**
> GroupReportPageResult Export-ManagedGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

export all managed groups

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> groupId, groupName, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> groupId, groupName, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub (optional) (default to null)
$Search = "Search_example" # String | Search for groupName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 1000, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# export all managed groups
try {
    $Result = Export-ManagedGroups -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; groupId, groupName, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; groupId, groupName, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub | [optional] [default to null]
 **Search** | **String**| Search for groupName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 1000, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**GroupReportPageResult**](GroupReportPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Export-ManagedSites"></a>
# **Export-ManagedSites**
> SiteReportPageResult Export-ManagedSites<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

export all managed sites

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, department, policyName, template, createdTime, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, hub (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, description, title, url, department, policyName, template, createdTime, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, hub (optional) (default to null)
$Search = "Search_example" # String | Search for url (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 1000, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# export all managed sites
try {
    $Result = Export-ManagedSites -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, department, policyName, template, createdTime, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, hub | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, description, title, url, department, policyName, template, createdTime, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, hub | [optional] [default to null]
 **Search** | **String**| Search for url | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 1000, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**SiteReportPageResult**](SiteReportPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Export-ManagedTeams"></a>
# **Export-ManagedTeams**
> TeamsReportPageResult Export-ManagedTeams<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

export all managed teams

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> teamsId, teamsName, enableTeamsArchive, enableTeamsRestore, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> teamsId, teamsName, enableTeamsArchive, enableTeamsRestore, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub (optional) (default to null)
$Search = "Search_example" # String | Search for teamsName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 1000, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# export all managed teams
try {
    $Result = Export-ManagedTeams -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; teamsId, teamsName, enableTeamsArchive, enableTeamsRestore, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; teamsId, teamsName, enableTeamsArchive, enableTeamsRestore, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, hub | [optional] [default to null]
 **Search** | **String**| Search for teamsName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 1000, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**TeamsReportPageResult**](TeamsReportPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AllMailContacts"></a>
# **Get-AllMailContacts**
> String Get-AllMailContacts<br>

get all sites contacts

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


# get all sites contacts
try {
    $Result = Get-AllMailContacts
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**String**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedGroupFilters"></a>
# **Get-ManagedGroupFilters**
> DistinctPageResult Get-ManagedGroupFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get managed groups filters

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get managed groups filters
try {
    $Result = Get-ManagedGroupFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedGroups"></a>
# **Get-ManagedGroups**
> GroupGridModelPageResult Get-ManagedGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all managed groups

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Search = "Search_example" # String | Search for groupName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all managed groups
try {
    $Result = Get-ManagedGroups -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Search** | **String**| Search for groupName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**GroupGridModelPageResult**](GroupGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedSites"></a>
# **Get-ManagedSites**
> SiteListPageResult Get-ManagedSites<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all managed sites

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) (default to null)
$Search = "Search_example" # String | Search for url (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all managed sites
try {
    $Result = Get-ManagedSites -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] [default to null]
 **Search** | **String**| Search for url | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**SiteListPageResult**](SiteListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedSitesFilters"></a>
# **Get-ManagedSitesFilters**
> DistinctPageResult Get-ManagedSitesFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get managed sites filters

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get managed sites filters
try {
    $Result = Get-ManagedSitesFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedTeamFilters"></a>
# **Get-ManagedTeamFilters**
> DistinctPageResult Get-ManagedTeamFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get managed teams filters

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get managed teams filters
try {
    $Result = Get-ManagedTeamFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedTeams"></a>
# **Get-ManagedTeams**
> TeamsGridModelPageResult Get-ManagedTeams<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all managed teams

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) (default to null)
$Search = "Search_example" # String | Search for teamsName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all managed teams
try {
    $Result = Get-ManagedTeams -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] [default to null]
 **Search** | **String**| Search for teamsName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**TeamsGridModelPageResult**](TeamsGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedWebs"></a>
# **Get-ManagedWebs**
> WebListPageResult Get-ManagedWebs<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all managed webs

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) (default to null)
$Search = "Search_example" # String | Search for url (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all managed webs
try {
    $Result = Get-ManagedWebs -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] [default to null]
 **Search** | **String**| Search for url | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**WebListPageResult**](WebListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagedWebsFilters"></a>
# **Get-ManagedWebsFilters**
> DistinctPageResult Get-ManagedWebsFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get managed webs filters

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

$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get managed webs filters
try {
    $Result = Get-ManagedWebsFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-SpecifyContact"></a>
# **Invoke-SpecifyContact**
> SpecifyContactResultModel Invoke-SpecifyContact<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SpecifyContactModel] <PSCustomObject><br>

specify selected sites contact

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

$SpecifyContactModel = (New-SpecifyContactModel -PrimaryContact (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -SecondaryContact   -PrimaryEmailTemplate "TODO"  -SecondaryEmailTemplate "TODO"  -SelectedSiteIds @("SelectedSiteIds_example")  -IsFromTask $false) # SpecifyContactModel |  (optional)

# specify selected sites contact
try {
    $Result = Invoke-SpecifyContact -SpecifyContactModel $SpecifyContactModel
} catch {
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SpecifyContactModel** | [**SpecifyContactModel**](SpecifyContactModel.md)|  | [optional] 

### Return type

[**SpecifyContactResultModel**](SpecifyContactResultModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

