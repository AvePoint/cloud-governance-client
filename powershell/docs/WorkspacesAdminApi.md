# WorkspacesAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-ApplyGroupProfiles**](WorkspacesAdminApi.md#Invoke-ApplyGroupProfiles) | **POST** /admin/directory/workspace/group/applyprofiles | apply group profiles
[**Invoke-ApplyGroupsPolicy**](WorkspacesAdminApi.md#Invoke-ApplyGroupsPolicy) | **POST** /admin/directory/workspace/groups/policy | apply groups policy
[**Invoke-ApplySiteProfiles**](WorkspacesAdminApi.md#Invoke-ApplySiteProfiles) | **POST** /admin/directory/workspace/sites/profiles | apply site profiles
[**Invoke-ApplySitesPolicy**](WorkspacesAdminApi.md#Invoke-ApplySitesPolicy) | **POST** /admin/directory/workspace/sites/policy | apply site policy
[**Invoke-ApplyTeamProfiles**](WorkspacesAdminApi.md#Invoke-ApplyTeamProfiles) | **POST** /admin/directory/workspace/teams/profiles | apply team profiles
[**Invoke-ArchiveWorkspace**](WorkspacesAdminApi.md#Invoke-ArchiveWorkspace) | **POST** /admin/directory/workspace/archive | archive workspace
[**Complete-WorkspaceRenewalTask**](WorkspacesAdminApi.md#Complete-WorkspaceRenewalTask) | **POST** /admin/directory/workspace/renewal/complete | completed renewal task
[**Invoke-DeleteWorkspaces**](WorkspacesAdminApi.md#Invoke-DeleteWorkspaces) | **DELETE** /admin/directory/workspace | delete workspaces
[**Get-OngoingTasks**](WorkspacesAdminApi.md#Get-OngoingTasks) | **GET** /admin/directory/workspace/{type}/ongoningtasks | get workspace ongoing tasks
[**Get-WorkspaceFilters**](WorkspacesAdminApi.md#Get-WorkspaceFilters) | **GET** /admin/directory/workspace/filters | get filters for workspace report
[**Get-Workspaces**](WorkspacesAdminApi.md#Get-Workspaces) | **GET** /admin/directory/workspace | get managed workspaces
[**Lock-Workspaces**](WorkspacesAdminApi.md#Lock-Workspaces) | **POST** /admin/directory/workspace/lock | lock sites or Office365 group sites
[**Invoke-SpecifyContacts**](WorkspacesAdminApi.md#Invoke-SpecifyContacts) | **POST** /admin/directory/workspace/contacts | specify contacts
[**Invoke-TriggerWorkspaceRenewal**](WorkspacesAdminApi.md#Invoke-TriggerWorkspaceRenewal) | **POST** /admin/directory/workspace/renewal/trigger | trigger workspace renewal
[**Invoke-TriggerWorkspacesElection**](WorkspacesAdminApi.md#Invoke-TriggerWorkspacesElection) | **POST** /admin/directory/workspace/election/trigger | trigger workspace election
[**Unlock-Workspace**](WorkspacesAdminApi.md#Unlock-Workspace) | **POST** /admin/directory/workspace/unlock | unlock sites and Office365 group site


<a name="Invoke-ApplyGroupProfiles"></a>
# **Invoke-ApplyGroupProfiles**
> void Invoke-ApplyGroupProfiles<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyTeamProfilesModel] <PSCustomObject><br>

apply group profiles

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



$ApplyTeamProfilesModel = $GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$ApiProfileObjectType = New-ApiProfileObjectType 
$HandleOngoingType = New-HandleOngoingType 
$HandleTaskType = New-HandleTaskType 
$ApplyTeamProfilesModel = New-ApplyTeamProfilesModel -VarFilter "MyVarFilter" -Search "MySearch" -EnableModernRenewalProfile $false -ModernRenewalProfile $GuidModel -EnableElectionProfile $false -ElectionProfile $GuidModel -EnableQuotaProfile $false -QuotaProfile $GuidModel -EnableExternalSharingProfile $false -ExternalSharingProfile $GuidModel -ProfileObjectType $ApiProfileObjectType -SelectedObjects "MySelectedObjects" -HandleOngoingType $HandleOngoingType -HandleTaskType $HandleTaskType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" # ApplyTeamProfilesModel | apply profiles (optional)

# apply group profiles
try {
     $Result = Invoke-ApplyGroupProfiles -ApplyTeamProfilesModel $ApplyTeamProfilesModel
} catch {
    Write-Host ("Exception occured when calling Invoke-ApplyGroupProfiles: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyTeamProfilesModel** | [**ApplyTeamProfilesModel**](ApplyTeamProfilesModel.md)| apply profiles | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ApplyGroupsPolicy"></a>
# **Invoke-ApplyGroupsPolicy**
> void Invoke-ApplyGroupsPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyGroupPolicyModel] <PSCustomObject><br>

apply groups policy

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



$ApplyGroupPolicyModel = $GroupPolicySubType = New-GroupPolicySubType 

$LeaseDateType = New-LeaseDateType 
$LeaseStartDateType = New-LeaseStartDateType 
$HandleOngoingType = New-HandleOngoingType 
$LifecycleRenewalSetting = New-LifecycleRenewalSetting -LeaseDateType $LeaseDateType -StartDateType $LeaseStartDateType -SpecifyStartDate (Get-Date) -HandleOngoingType $HandleOngoingType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -CancelEmailTemplateName "MyCancelEmailTemplateName"

$ApplyGroupPolicyModel = New-ApplyGroupPolicyModel -SubType $GroupPolicySubType -PolicyId "MyPolicyId" -IsApplyAllSetting $false -IsApplyQuota $false -IsApplySharing $false -IsApplyQuotaThreshold $false -IsApplyDeactivatedElection $false -IsApplyLifecycle $false -LifecycleRenewalSetting $LifecycleRenewalSetting -VarFilter "MyVarFilter" -Search "MySearch" -SelectedObjects "MySelectedObjects" -HasOngoingTasks $false -IsApplyUniqueAccess $false # ApplyGroupPolicyModel | apply policy setting (optional)

# apply groups policy
try {
     $Result = Invoke-ApplyGroupsPolicy -ApplyGroupPolicyModel $ApplyGroupPolicyModel
} catch {
    Write-Host ("Exception occured when calling Invoke-ApplyGroupsPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyGroupPolicyModel** | [**ApplyGroupPolicyModel**](ApplyGroupPolicyModel.md)| apply policy setting | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ApplySiteProfiles"></a>
# **Invoke-ApplySiteProfiles**
> void Invoke-ApplySiteProfiles<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyProfilesModel] <PSCustomObject><br>

apply site profiles

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



$ApplyProfilesModel = $GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$ApiProfileObjectType = New-ApiProfileObjectType 
$HandleOngoingType = New-HandleOngoingType 
$HandleTaskType = New-HandleTaskType 
$ApplyProfilesModel = New-ApplyProfilesModel -VarFilter "MyVarFilter" -Search "MySearch" -EnableModernRenewalProfile $false -ModernRenewalProfile $GuidModel -EnableElectionProfile $false -ElectionProfile $GuidModel -EnableQuotaProfile $false -QuotaProfile $GuidModel -EnableExternalSharingProfile $false -ExternalSharingProfile $GuidModel -ProfileObjectType $ApiProfileObjectType -SelectedObjects "MySelectedObjects" -HandleOngoingType $HandleOngoingType -HandleTaskType $HandleTaskType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" # ApplyProfilesModel | apply profiles (optional)

# apply site profiles
try {
     $Result = Invoke-ApplySiteProfiles -ApplyProfilesModel $ApplyProfilesModel
} catch {
    Write-Host ("Exception occured when calling Invoke-ApplySiteProfiles: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyProfilesModel** | [**ApplyProfilesModel**](ApplyProfilesModel.md)| apply profiles | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ApplySitesPolicy"></a>
# **Invoke-ApplySitesPolicy**
> void Invoke-ApplySitesPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplySitePolicyModel] <PSCustomObject><br>

apply site policy

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



$ApplySitePolicyModel = $LeaseDateType = New-LeaseDateType 
$LeaseStartDateType = New-LeaseStartDateType 
$HandleOngoingType = New-HandleOngoingType 
$LifecycleRenewalSetting = New-LifecycleRenewalSetting -LeaseDateType $LeaseDateType -StartDateType $LeaseStartDateType -SpecifyStartDate (Get-Date) -HandleOngoingType $HandleOngoingType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -CancelEmailTemplateName "MyCancelEmailTemplateName"

$ApplySitePolicyModel = New-ApplySitePolicyModel -IsApplyDesigner $false -IsApplySiteMaxDepth $false -IsApplyPolicyIcon $false -IsApplyAosPlans $false -PolicyId "MyPolicyId" -IsApplyAllSetting $false -IsApplyQuota $false -IsApplySharing $false -IsApplyQuotaThreshold $false -IsApplyDeactivatedElection $false -IsApplyLifecycle $false -LifecycleRenewalSetting $LifecycleRenewalSetting -VarFilter "MyVarFilter" -Search "MySearch" -SelectedObjects "MySelectedObjects" -HasOngoingTasks $false -IsApplyUniqueAccess $false # ApplySitePolicyModel | apply policy setting (optional)

# apply site policy
try {
     $Result = Invoke-ApplySitesPolicy -ApplySitePolicyModel $ApplySitePolicyModel
} catch {
    Write-Host ("Exception occured when calling Invoke-ApplySitesPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplySitePolicyModel** | [**ApplySitePolicyModel**](ApplySitePolicyModel.md)| apply policy setting | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ApplyTeamProfiles"></a>
# **Invoke-ApplyTeamProfiles**
> void Invoke-ApplyTeamProfiles<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApplyTeamProfilesModel] <PSCustomObject><br>

apply team profiles

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



$ApplyTeamProfilesModel = $GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$ApiProfileObjectType = New-ApiProfileObjectType 
$HandleOngoingType = New-HandleOngoingType 
$HandleTaskType = New-HandleTaskType 
$ApplyTeamProfilesModel = New-ApplyTeamProfilesModel -VarFilter "MyVarFilter" -Search "MySearch" -EnableModernRenewalProfile $false -ModernRenewalProfile $GuidModel -EnableElectionProfile $false -ElectionProfile $GuidModel -EnableQuotaProfile $false -QuotaProfile $GuidModel -EnableExternalSharingProfile $false -ExternalSharingProfile $GuidModel -ProfileObjectType $ApiProfileObjectType -SelectedObjects "MySelectedObjects" -HandleOngoingType $HandleOngoingType -HandleTaskType $HandleTaskType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" # ApplyTeamProfilesModel | apply profiles (optional)

# apply team profiles
try {
     $Result = Invoke-ApplyTeamProfiles -ApplyTeamProfilesModel $ApplyTeamProfilesModel
} catch {
    Write-Host ("Exception occured when calling Invoke-ApplyTeamProfiles: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApplyTeamProfilesModel** | [**ApplyTeamProfilesModel**](ApplyTeamProfilesModel.md)| apply profiles | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ArchiveWorkspace"></a>
# **Invoke-ArchiveWorkspace**
> void Invoke-ArchiveWorkspace<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ArchiveWorkspaceParameter] <PSCustomObject><br>

archive workspace

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



$Filter = "MyFilter" # String |  (optional)
$ArchiveWorkspaceParameter = $WorkspaceArchivedType = New-WorkspaceArchivedType 

$WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$ArchiveWorkspaceParameter = New-ArchiveWorkspaceParameter -ArchiveProfile "MyArchiveProfile" -WorkspaceType $WorkspaceArchivedType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # ArchiveWorkspaceParameter |  (optional)

# archive workspace
try {
     $Result = Invoke-ArchiveWorkspace -Filter $Filter -ArchiveWorkspaceParameter $ArchiveWorkspaceParameter
} catch {
    Write-Host ("Exception occured when calling Invoke-ArchiveWorkspace: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **ArchiveWorkspaceParameter** | [**ArchiveWorkspaceParameter**](ArchiveWorkspaceParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Complete-WorkspaceRenewalTask"></a>
# **Complete-WorkspaceRenewalTask**
> void Complete-WorkspaceRenewalTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoCompleteRenewalTaskParameter] <PSCustomObject><br>

completed renewal task

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



$Filter = "MyFilter" # String |  (optional)
$AutoCompleteRenewalTaskParameter = $WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$AutoCompleteRenewalTaskParameter = New-AutoCompleteRenewalTaskParameter -IsMarkAsCanceled $false -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # AutoCompleteRenewalTaskParameter |  (optional)

# completed renewal task
try {
     $Result = Complete-WorkspaceRenewalTask -Filter $Filter -AutoCompleteRenewalTaskParameter $AutoCompleteRenewalTaskParameter
} catch {
    Write-Host ("Exception occured when calling Complete-WorkspaceRenewalTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **AutoCompleteRenewalTaskParameter** | [**AutoCompleteRenewalTaskParameter**](AutoCompleteRenewalTaskParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteWorkspaces"></a>
# **Invoke-DeleteWorkspaces**
> void Invoke-DeleteWorkspaces<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DeleteWorkspaceParameter] <PSCustomObject><br>

delete workspaces

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



$DeleteWorkspaceParameter = $WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$DeleteWorkspaceParameter = New-DeleteWorkspaceParameter -EnableRemoveObject $false -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # DeleteWorkspaceParameter |  (optional)

# delete workspaces
try {
     $Result = Invoke-DeleteWorkspaces -DeleteWorkspaceParameter $DeleteWorkspaceParameter
} catch {
    Write-Host ("Exception occured when calling Invoke-DeleteWorkspaces: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **DeleteWorkspaceParameter** | [**DeleteWorkspaceParameter**](DeleteWorkspaceParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-OngoingTasks"></a>
# **Get-OngoingTasks**
> WorksapceOngoingTasksModel[] Get-OngoingTasks<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Type] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupNameOrUrl] <String><br>

get workspace ongoing tasks

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



$Type = "0" # WorkspaceType | 
$GroupNameOrUrl = "MyGroupNameOrUrl" # String | 

# get workspace ongoing tasks
try {
     $Result = Get-OngoingTasks -Type $Type -GroupNameOrUrl $GroupNameOrUrl
} catch {
    Write-Host ("Exception occured when calling Get-OngoingTasks: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Type** | [**WorkspaceType**](WorkspaceType.md)|  | 
 **GroupNameOrUrl** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**WorksapceOngoingTasksModel[]**](WorksapceOngoingTasksModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-WorkspaceFilters"></a>
# **Get-WorkspaceFilters**
> DistinctResult[] Get-WorkspaceFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>

get filters for workspace report

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



$Distinct = "MyDistinct" # String | support value: PolicyId,PolicyName,PhaseProfileId,PhaseProfileName,GeoLocation,Classification and metadata (optional)

# get filters for workspace report
try {
     $Result = Get-WorkspaceFilters -Distinct $Distinct
} catch {
    Write-Host ("Exception occured when calling Get-WorkspaceFilters: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Distinct** | **String**| support value: PolicyId,PolicyName,PhaseProfileId,PhaseProfileName,GeoLocation,Classification and metadata | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**DistinctResult[]**](DistinctResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Workspaces"></a>
# **Get-Workspaces**
> WorkspaceGridModelPageResult Get-Workspaces<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get managed workspaces

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



$Filter = "MyFilter" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)
$Orderby = "MyOrderby" # String | Order by one field, supported fields:<br/> id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)
$Search = "MySearch" # String | Search for name (optional)
$Top = 56 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional)
$Skip = "MySkip" # String |  Define the number of records you want to skip, default value is 0 (optional)
$Nexttoken = "MyNexttoken" # String |  Use the next token to get the next paging result (optional)

# get managed workspaces
try {
     $Result = Get-Workspaces -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ("Exception occured when calling Get-Workspaces: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **Search** | **String**| Search for name | [optional] 
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **Skip** | **String**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**WorkspaceGridModelPageResult**](WorkspaceGridModelPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Lock-Workspaces"></a>
# **Lock-Workspaces**
> void Lock-Workspaces<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-LockSiteParameter] <PSCustomObject><br>

lock sites or Office365 group sites

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



$Filter = "MyFilter" # String |  (optional)
$LockSiteParameter = $LockSiteCollectionType = New-LockSiteCollectionType 

$WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$LockSiteParameter = New-LockSiteParameter -LockType $LockSiteCollectionType -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # LockSiteParameter |  (optional)

# lock sites or Office365 group sites
try {
     $Result = Lock-Workspaces -Filter $Filter -LockSiteParameter $LockSiteParameter
} catch {
    Write-Host ("Exception occured when calling Lock-Workspaces: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **LockSiteParameter** | [**LockSiteParameter**](LockSiteParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-SpecifyContacts"></a>
# **Invoke-SpecifyContacts**
> void Invoke-SpecifyContacts<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SpecifyContactParameter] <PSCustomObject><br>

specify contacts

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



$Filter = "MyFilter" # String |  (optional)
$SpecifyContactParameter = $ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$SpecifyContactParameter = New-SpecifyContactParameter -PrimaryContact $ApiUser -SecondaryContact $ApiUser -PrimaryContactNotifiedEmail "MyPrimaryContactNotifiedEmail" -SecondaryContactNotifiedEmail "MySecondaryContactNotifiedEmail" -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # SpecifyContactParameter |  (optional)

# specify contacts
try {
     $Result = Invoke-SpecifyContacts -Filter $Filter -SpecifyContactParameter $SpecifyContactParameter
} catch {
    Write-Host ("Exception occured when calling Invoke-SpecifyContacts: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **SpecifyContactParameter** | [**SpecifyContactParameter**](SpecifyContactParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-TriggerWorkspaceRenewal"></a>
# **Invoke-TriggerWorkspaceRenewal**
> void Invoke-TriggerWorkspaceRenewal<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-WorkspaceSendCancelEmailParameter] <PSCustomObject><br>

trigger workspace renewal

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



$Filter = "MyFilter" # String |  (optional)
$WorkspaceSendCancelEmailParameter = $WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$WorkspaceSendCancelEmailParameter = New-WorkspaceSendCancelEmailParameter -IsSendCancelEmail $false -CancelEmailTemplateId "MyCancelEmailTemplateId" -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # WorkspaceSendCancelEmailParameter |  (optional)

# trigger workspace renewal
try {
     $Result = Invoke-TriggerWorkspaceRenewal -Filter $Filter -WorkspaceSendCancelEmailParameter $WorkspaceSendCancelEmailParameter
} catch {
    Write-Host ("Exception occured when calling Invoke-TriggerWorkspaceRenewal: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **WorkspaceSendCancelEmailParameter** | [**WorkspaceSendCancelEmailParameter**](WorkspaceSendCancelEmailParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-TriggerWorkspacesElection"></a>
# **Invoke-TriggerWorkspacesElection**
> void Invoke-TriggerWorkspacesElection<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-WorkspaceActionParameter] <PSCustomObject><br>

trigger workspace election

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



$Filter = "MyFilter" # String |  (optional)
$WorkspaceActionParameter = $WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$WorkspaceActionParameter = New-WorkspaceActionParameter -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # WorkspaceActionParameter |  (optional)

# trigger workspace election
try {
     $Result = Invoke-TriggerWorkspacesElection -Filter $Filter -WorkspaceActionParameter $WorkspaceActionParameter
} catch {
    Write-Host ("Exception occured when calling Invoke-TriggerWorkspacesElection: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **WorkspaceActionParameter** | [**WorkspaceActionParameter**](WorkspaceActionParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Unlock-Workspace"></a>
# **Unlock-Workspace**
> void Unlock-Workspace<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-WorkspaceActionParameter] <PSCustomObject><br>

unlock sites and Office365 group site

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



$Filter = "MyFilter" # String |  (optional)
$WorkspaceActionParameter = $WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$WorkspaceActionParameter = New-WorkspaceActionParameter -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType # WorkspaceActionParameter |  (optional)

# unlock sites and Office365 group site
try {
     $Result = Unlock-Workspace -Filter $Filter -WorkspaceActionParameter $WorkspaceActionParameter
} catch {
    Write-Host ("Exception occured when calling Unlock-Workspace: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**|  | [optional] 
 **WorkspaceActionParameter** | [**WorkspaceActionParameter**](WorkspaceActionParameter.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

