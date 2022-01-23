# TasksApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Approve-Task**](TasksApi.md#Approve-Task) | **POST** /tasks/{id}/approve | approve task
[**Edit-ArchiveGroupRequest**](TasksApi.md#Edit-ArchiveGroupRequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
[**Edit-ArchiveSiteRequest**](TasksApi.md#Edit-ArchiveSiteRequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
[**Edit-ArchiveWebRequest**](TasksApi.md#Edit-ArchiveWebRequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
[**Edit-ChangeGroupPolicyRequest**](TasksApi.md#Edit-ChangeGroupPolicyRequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
[**Edit-ChangeGroupQuotaRequest**](TasksApi.md#Edit-ChangeGroupQuotaRequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
[**Edit-ChangeGroupRequest**](TasksApi.md#Edit-ChangeGroupRequest) | **PUT** /tasks/{id}/changegroup | edit create change group request
[**Edit-ChangeListSettingRequest**](TasksApi.md#Edit-ChangeListSettingRequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
[**Edit-ChangePermissionRequest**](TasksApi.md#Edit-ChangePermissionRequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
[**Edit-ChangeSiteContactRequest**](TasksApi.md#Edit-ChangeSiteContactRequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request
[**Edit-ChangeSitePolicyRequest**](TasksApi.md#Edit-ChangeSitePolicyRequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
[**Edit-ChangeSiteQuotaRequest**](TasksApi.md#Edit-ChangeSiteQuotaRequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
[**Edit-ChangeSiteSettingRequest**](TasksApi.md#Edit-ChangeSiteSettingRequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request
[**Edit-ChangeWebContactRequest**](TasksApi.md#Edit-ChangeWebContactRequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
[**Edit-ChangeWebSettingRequest**](TasksApi.md#Edit-ChangeWebSettingRequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
[**Edit-ClonePermissionRequest**](TasksApi.md#Edit-ClonePermissionRequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request
[**Edit-ContentMoveRequest**](TasksApi.md#Edit-ContentMoveRequest) | **PUT** /tasks/{id}/contentmove | edit content move request
[**Edit-CreateGroupRequest**](TasksApi.md#Edit-CreateGroupRequest) | **PUT** /tasks/{id}/creategroup | edit create site group request
[**Edit-CreateGuestUserRequest**](TasksApi.md#Edit-CreateGuestUserRequest) | **PUT** /tasks/{id}/createguestuser | edit create guest user request in task
[**Edit-CreateListRequest**](TasksApi.md#Edit-CreateListRequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
[**Edit-CreateSiteRequest**](TasksApi.md#Edit-CreateSiteRequest) | **PUT** /tasks/{id}/createsite | edit create site request
[**Edit-CreateWebRequest**](TasksApi.md#Edit-CreateWebRequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
[**Edit-CustomRequest**](TasksApi.md#Edit-CustomRequest) | **PUT** /tasks/{id}/custom | edit custom request
[**Edit-DeleteGroupRequest**](TasksApi.md#Edit-DeleteGroupRequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
[**Edit-DeleteSiteRequest**](TasksApi.md#Edit-DeleteSiteRequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
[**Edit-DeleteWebRequest**](TasksApi.md#Edit-DeleteWebRequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
[**Edit-ExtendGroupRequest**](TasksApi.md#Edit-ExtendGroupRequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
[**Edit-ExtendSiteRequest**](TasksApi.md#Edit-ExtendSiteRequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
[**Edit-GrantPermissionRequest**](TasksApi.md#Edit-GrantPermissionRequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
[**Edit-LockSiteRequest**](TasksApi.md#Edit-LockSiteRequest) | **PUT** /tasks/{id}/locksite | edit lock site request
[**Edit-ManagePermissionRequest**](TasksApi.md#Edit-ManagePermissionRequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request
[**Edit-RestoreGroupRequest**](TasksApi.md#Edit-RestoreGroupRequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
[**Edit-UnLockSiteRequest**](TasksApi.md#Edit-UnLockSiteRequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request
[**Get-BatchTasksById**](TasksApi.md#Get-BatchTasksById) | **GET** /tasks/{id}/batchTasks | get all batch tasks by id
[**Get-MyTasks**](TasksApi.md#Get-MyTasks) | **GET** /tasks/my/v2 | get my tasks
[**Get-TaskByBatchId**](TasksApi.md#Get-TaskByBatchId) | **GET** /tasks/my/{batchid} | get my task by batch id
[**Get-TaskById**](TasksApi.md#Get-TaskById) | **GET** /tasks/{id} | get task by id
[**Invoke-ReassignTask**](TasksApi.md#Invoke-ReassignTask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
[**Deny-Task**](TasksApi.md#Deny-Task) | **POST** /tasks/{id}/reject | reject task
[**Invoke-RetryErrorTask**](TasksApi.md#Invoke-RetryErrorTask) | **POST** /tasks/{id}/retry | retry error task
[**Skip-ErrorTask**](TasksApi.md#Skip-ErrorTask) | **POST** /tasks/{id}/skip | skip error task
[**Submit-ContinueAccessGroupAutoTask**](TasksApi.md#Submit-ContinueAccessGroupAutoTask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
[**Submit-ContinueAccessSiteAutoTask**](TasksApi.md#Submit-ContinueAccessSiteAutoTask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
[**Submit-ExtendGroupAutoTask**](TasksApi.md#Submit-ExtendGroupAutoTask) | **POST** /tasks/extendgroup | submit extend group auto task
[**Submit-ExtendSiteAutoTask**](TasksApi.md#Submit-ExtendSiteAutoTask) | **POST** /tasks/extendsite | submit site extend auto task


<a name="Approve-Task"></a>
# **Approve-Task**
> void Approve-Task<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

approve task

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



$Id = "Id_example" # String | 
$CommentsParam = (Initialize-CommentsParam -Comments "Comments_example") # CommentsParam |  (optional)

# approve task
try {
     $Result = Approve-Task -Id $Id -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Approve-Task: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ArchiveGroupRequest = (Initialize-ArchiveGroupRequest -GroupId "GroupId_example" -GroupName "GroupName_example" -GroupEmail "GroupEmail_example" -GroupObjectType (Initialize-GroupObjectType ) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @((Initialize-RequestMetadata -Id "Id_example" -Name "Name_example" -BooleanValue $false -SingleLineOrMultipleLineValue "SingleLineOrMultipleLineValue_example" -UpsOrAzureAdValue (Initialize-LookupValue -Tenant "Tenant_example" -Property "Property_example" -TargetUser (Initialize-ApiUser -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser (Initialize-ExternalUserType ) -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -Email "Email_example" -JobTitle "JobTitle_example" -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -TenantId "TenantId_example" -AdditionalData "TODO" -ApiUserType (Initialize-ApiUserType )) -UserPropertyValue "UserPropertyValue_example" -UserPropertyDisplayValue "UserPropertyDisplayValue_example") -TermsValue (Initialize-TermsValue -TermStore (Initialize-GuidModel -Id "Id_example" -Name "Name_example" -Description "Description_example") -TermGroup (Initialize-GuidModel -Id "Id_example" -Name "Name_example" -Description "Description_example") -TermSet  -Value @()) -UserValue @((Initialize-ApiUser -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser (Initialize-ExternalUserType ) -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -Email "Email_example" -JobTitle "JobTitle_example" -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -TenantId "TenantId_example" -AdditionalData "TODO" -ApiUserType (Initialize-ApiUserType ))) -LinkValue (Initialize-LinkValue -Title "Title_example" -Address "Address_example") -ChoiceValue @("ChoiceValue_example") -LookupListValue (Initialize-LookupListValue -ColumnType "ColumnType_example" -ColumnName "ColumnName_example" -Value "Value_example" -DisplayValue "DisplayValue_example") -Type (Initialize-MetadataFieldType ) -ValueString "ValueString_example" -Value "Value_example" -Action (Initialize-MetadataActionType ) -AllowReferenceAsRoleInApprovalProcess $false)) -TicketNumber 123 -Type (Initialize-ServiceType ) -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status (Initialize-RequestStatus ) -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ArchiveGroupRequest |  (optional)

# edit archive group request in task
try {
     $Result = Edit-ArchiveGroupRequest -Id $Id -ArchiveGroupRequest $ArchiveGroupRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ArchiveGroupRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ArchiveGroupRequest** | [**ArchiveGroupRequest**](ArchiveGroupRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ArchiveSiteRequest = (Initialize-ArchiveSiteRequest -Action (Initialize-SiteLifecycleActionType ) -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @((Initialize-RequestMetadata -Id "Id_example" -Name "Name_example" -BooleanValue $false -SingleLineOrMultipleLineValue "SingleLineOrMultipleLineValue_example" -UpsOrAzureAdValue (Initialize-LookupValue -Tenant "Tenant_example" -Property "Property_example" -TargetUser  -UserPropertyValue "UserPropertyValue_example" -UserPropertyDisplayValue "UserPropertyDisplayValue_example") -TermsValue (Initialize-TermsValue -TermStore  -TermGroup  -TermSet  -Value @()) -UserValue @() -LinkValue (Initialize-LinkValue -Title "Title_example" -Address "Address_example") -ChoiceValue @("ChoiceValue_example") -LookupListValue (Initialize-LookupListValue -ColumnType "ColumnType_example" -ColumnName "ColumnName_example" -Value "Value_example" -DisplayValue "DisplayValue_example") -Type (Initialize-MetadataFieldType ) -ValueString "ValueString_example" -Value "Value_example" -Action (Initialize-MetadataActionType ) -AllowReferenceAsRoleInApprovalProcess $false)) -TicketNumber 123 -Type (Initialize-ServiceType ) -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status (Initialize-RequestStatus ) -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ArchiveSiteRequest |  (optional)

# edit archive site request in task
try {
     $Result = Edit-ArchiveSiteRequest -Id $Id -ArchiveSiteRequest $ArchiveSiteRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ArchiveSiteRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ArchiveSiteRequest** | [**ArchiveSiteRequest**](ArchiveSiteRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ArchiveWebLifecycleRequest = (Initialize-ArchiveWebLifecycleRequest -Action (Initialize-WebLifecycleActionType ) -WebId "WebId_example" -WebUrl "WebUrl_example" -WebRelativeUrl "WebRelativeUrl_example" -WebTitle "WebTitle_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -ActionDescription "ActionDescription_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ArchiveWebLifecycleRequest |  (optional)

# edit archive web request in task
try {
     $Result = Edit-ArchiveWebRequest -Id $Id -ArchiveWebLifecycleRequest $ArchiveWebLifecycleRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ArchiveWebRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ArchiveWebLifecycleRequest** | [**ArchiveWebLifecycleRequest**](ArchiveWebLifecycleRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeGroupPolicyRequest = (Initialize-ChangeGroupPolicyRequest -Policy  -OriginalPolicy  -IsLeaseEnabled $false -ChangePolicyConfig (Initialize-AssignBy ) -StartDateType (Initialize-StartDateType ) -SpecifyStartDate Get-Date -GroupId "GroupId_example" -GroupName "GroupName_example" -GroupEmail "GroupEmail_example" -GroupObjectType (Initialize-GroupObjectType ) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeGroupPolicyRequest |  (optional)

# edit change group policy request in task
try {
     $Result = Edit-ChangeGroupPolicyRequest -Id $Id -ChangeGroupPolicyRequest $ChangeGroupPolicyRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeGroupPolicyRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeGroupPolicyRequest** | [**ChangeGroupPolicyRequest**](ChangeGroupPolicyRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeGroupQuotaRequest = (Initialize-ChangeGroupQuotaRequest -GroupQuotaSize 123 -OriginalQuotaSize 123 -SharePointSiteSize 123 -GroupId "GroupId_example" -GroupName "GroupName_example" -GroupEmail "GroupEmail_example" -GroupObjectType  -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeGroupQuotaRequest |  (optional)

# edit change group quota request in task
try {
     $Result = Edit-ChangeGroupQuotaRequest -Id $Id -ChangeGroupQuotaRequest $ChangeGroupQuotaRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeGroupQuotaRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeGroupQuotaRequest** | [**ChangeGroupQuotaRequest**](ChangeGroupQuotaRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeGroupRequest"></a>
# **Edit-ChangeGroupRequest**
> void Edit-ChangeGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupSettingRequest] <PSCustomObject><br>

edit create change group request

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



$Id = "Id_example" # String | 
$ChangeGroupSettingRequest = (Initialize-ChangeGroupSettingRequest -GroupId "GroupId_example" -GroupEmail "GroupEmail_example" -GroupName "GroupName_example" -OriginalGroupName "OriginalGroupName_example" -GroupDescription "GroupDescription_example" -OriginalGroupDescription "OriginalGroupDescription_example" -OriginalYammerGroupInfo "OriginalYammerGroupInfo_example" -PrimaryContact  -OriginalPrimaryContact  -SecondaryContact  -OriginalSecondaryContact  -GroupOwners @((Initialize-GroupMembershipItem -LoginName "LoginName_example" -DisplayName "DisplayName_example" -AzureUserType "AzureUserType_example" -IsGroup $false -Action (Initialize-GroupMembershipAction ))) -GroupMembers @((Initialize-GroupMembershipItem -LoginName "LoginName_example" -DisplayName "DisplayName_example" -AzureUserType "AzureUserType_example" -IsGroup $false -Action (Initialize-GroupMembershipAction ))) -IsDynamicMembership $false -DynamicMembershipRules @((Initialize-DynamicGroupRuleInfo -Id "Id_example" -Order 123 -Relation (Initialize-LogicalOperator ) -Category (Initialize-CategoryType ) -MetadataId "MetadataId_example" -MetadataName "MetadataName_example" -MetadataValue "MetadataValue_example" -MetadataDisplayValue "MetadataDisplayValue_example" -MetadataValueAzureUserType "MetadataValueAzureUserType_example" -Condition (Initialize-DynamicRuleCondition ) -DisableEditRule $false -DisableEditRuleValue $false)) -EnabledSubscribe $false -OriginalEnabledSubscribe $false -EnabledOutsideSender $false -OriginalEnabledOutsideSender $false -HubSiteActionType (Initialize-ChangeHubsiteActionType ) -AssociateHubSiteId "AssociateHubSiteId_example" -AssociateHubSiteTitle "AssociateHubSiteTitle_example" -Classification "Classification_example" -OriginalClassification "OriginalClassification_example" -Sensitivity "Sensitivity_example" -OriginalSensitivity "OriginalSensitivity_example" -EnableTeams $false -OriginalEnableTeams $false -GroupMetadatas @() -OriginalGroupMetadata @() -ChangedDynamicGroupType (Initialize-AddGroupMemberType ) -YammerGroupInfo "YammerGroupInfo_example" -GroupObjectType  -NetworkId "NetworkId_example" -GroupObjectId "GroupObjectId_example" -EnableTeamCollaboration $false -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeGroupSettingRequest |  (optional)

# edit create change group request
try {
     $Result = Edit-ChangeGroupRequest -Id $Id -ChangeGroupSettingRequest $ChangeGroupSettingRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeGroupRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeGroupSettingRequest** | [**ChangeGroupSettingRequest**](ChangeGroupSettingRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeListSettingRequest = (Initialize-ChangeListSettingRequest -ObjectInfo (Initialize-ChangeListSettingObjectInfo -SiteUrl "SiteUrl_example" -WebId "WebId_example" -WebUrl "WebUrl_example" -SiteId "SiteId_example" -ObjectUrl "ObjectUrl_example" -ObjectTitle "ObjectTitle_example") -ListTitle (Initialize-StringChangedProperty -ChangeValue "ChangeValue_example" -OriginalValue "OriginalValue_example") -ListDescription (Initialize-StringChangedProperty -ChangeValue "ChangeValue_example" -OriginalValue "OriginalValue_example") -NavigationSetting (Initialize-BooleanChangedProperty -ChangeValue $false -OriginalValue $false) -VersionSetting (Initialize-ListVersionSettingsChangedProperty -ChangeValue (Initialize-ListVersionSettings -ListType (Initialize-ListType ) -EnableMajorVersions $false -EnableMajorAndMinorVersions $false -EnableMajorVersionLimit $false -MajorVersionLimit 123 -EnableMinorVersionLimit $false -MinorVersionsLimit 123 -RequireContentApproval $false) -OriginalValue (Initialize-ListVersionSettings -ListType (Initialize-ListType ) -EnableMajorVersions $false -EnableMajorAndMinorVersions $false -EnableMajorVersionLimit $false -MajorVersionLimit 123 -EnableMinorVersionLimit $false -MinorVersionsLimit 123 -RequireContentApproval $false)) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeListSettingRequest |  (optional)

# edit change list setting request in task
try {
     $Result = Edit-ChangeListSettingRequest -Id $Id -ChangeListSettingRequest $ChangeListSettingRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeListSettingRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeListSettingRequest** | [**ChangeListSettingRequest**](ChangeListSettingRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangePermissionRequest = (Initialize-ChangePermissionRequest -ObjectProperty (Initialize-PermissionObjectProperty -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -WebId "WebId_example" -WebServerRelativeUrl "WebServerRelativeUrl_example" -ListTitle "ListTitle_example" -ObjectUrl "ObjectUrl_example" -IsInherit $false -InheritNodeType (Initialize-TreeNodeType ) -TopInheritUrl "TopInheritUrl_example" -CheckType (Initialize-TreeNodeType )) -PermissionChangedType (Initialize-PermissionChangedType ) -IsManagedAllUsers $false -SelectedUsers @() -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangePermissionRequest |  (optional)

# edit change permission request in task
try {
     $Result = Edit-ChangePermissionRequest -Id $Id -ChangePermissionRequest $ChangePermissionRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangePermissionRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangePermissionRequest** | [**ChangePermissionRequest**](ChangePermissionRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeSiteContactRequest"></a>
# **Edit-ChangeSiteContactRequest**
> void Edit-ChangeSiteContactRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteContactRequest] <PSCustomObject><br>

edit change site administrator/contact request

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



$Id = "Id_example" # String | 
$ChangeSiteContactRequest = (Initialize-ChangeSiteContactRequest -ChangeContactMethod (Initialize-ChangeContactMethod ) -ChangeByUrlSetting @((Initialize-ChangeContactByUrlSetting -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -OriginalPrimaryContact  -NewPrimaryContact  -OriginalSecondaryContact  -NewSecondaryContact  -OriginalPrimaryAdministrator  -NewPrimaryAdministrator  -OriginalAdditionalAdministrators @() -NewAdditionalAdministrators @() -SiteTitle "SiteTitle_example")) -ChangeByUserSetting (Initialize-ChangeContactByUserSetting -CurrentUser  -NewUser  -AlternativeUser ) -SubRequests @((Initialize-ChangeSiteContactSubRequest -Id "Id_example" -AssignTo @() -Reason "Reason_example" -Status 123 -StatusDescription "StatusDescription_example" -AdminContactSettings (Initialize-ChangeContactByUrlSetting -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -OriginalPrimaryContact  -NewPrimaryContact  -OriginalSecondaryContact  -NewSecondaryContact  -OriginalPrimaryAdministrator  -NewPrimaryAdministrator  -OriginalAdditionalAdministrators @() -NewAdditionalAdministrators @() -SiteTitle "SiteTitle_example") -ProgressStatus (Initialize-ApiRequestProgressStatus ))) -IsServiceEnableChangeContact $false -IsServiceEnableChangeAdmin $false -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeSiteContactRequest |  (optional)

# edit change site administrator/contact request
try {
     $Result = Edit-ChangeSiteContactRequest -Id $Id -ChangeSiteContactRequest $ChangeSiteContactRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeSiteContactRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeSiteContactRequest** | [**ChangeSiteContactRequest**](ChangeSiteContactRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeSitePolicyRequest = (Initialize-ChangeSitePolicyRequest -Policy  -OriginalPolicy  -IsLeaseEnabled $false -ChangePolicyConfig (Initialize-AssignBy ) -StartDateType (Initialize-StartDateType ) -SpecifyStartDate Get-Date -Action (Initialize-SiteLifecycleActionType ) -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeSitePolicyRequest |  (optional)

# edit change site policy request in task
try {
     $Result = Edit-ChangeSitePolicyRequest -Id $Id -ChangeSitePolicyRequest $ChangeSitePolicyRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeSitePolicyRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeSitePolicyRequest** | [**ChangeSitePolicyRequest**](ChangeSitePolicyRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeSiteQuotaRequest = (Initialize-ChangeSiteQuotaRequest -QuotaSize 123 -SharePointSiteSize 123 -CurrentQuota 123 -Action  -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeSiteQuotaRequest |  (optional)

# edit change site quota request in task
try {
     $Result = Edit-ChangeSiteQuotaRequest -Id $Id -ChangeSiteQuotaRequest $ChangeSiteQuotaRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeSiteQuotaRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeSiteQuotaRequest** | [**ChangeSiteQuotaRequest**](ChangeSiteQuotaRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ChangeSiteSettingRequest"></a>
# **Edit-ChangeSiteSettingRequest**
> void Edit-ChangeSiteSettingRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeSiteSettingRequest] <PSCustomObject><br>

edit change site setting request

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



$Id = "Id_example" # String | 
$ChangeSiteSettingRequest = (Initialize-ChangeSiteSettingRequest -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -SiteTitleSetting  -SiteDescriptionSetting  -EnableChangedMetadata $false -ChangedMetadatas @() -OriginalSiteMetadatas @() -DeploymentPlanName "DeploymentPlanName_example" -HubSiteSettings (Initialize-HubSiteChangedSettings -Enabled $false -IsModernSite $false -Action (Initialize-ChangeHubsiteActionType ) -AssociatedHubSiteId "AssociatedHubSiteId_example" -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example") -SiteSensitivitySetting  -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeSiteSettingRequest |  (optional)

# edit change site setting request
try {
     $Result = Edit-ChangeSiteSettingRequest -Id $Id -ChangeSiteSettingRequest $ChangeSiteSettingRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeSiteSettingRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeSiteSettingRequest** | [**ChangeSiteSettingRequest**](ChangeSiteSettingRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeWebContactRequest = (Initialize-ChangeWebContactRequest -ChangedMethod (Initialize-ChangeContactMethod ) -ChangedByUserSetting (Initialize-ChangeContactByUserSetting -CurrentUser  -NewUser  -AlternativeUser ) -ChangedByUrlItems @((Initialize-ChangeWebContactByUrlSetting -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -WebId "WebId_example" -WebUrl "WebUrl_example" -WebTitle "WebTitle_example" -PrimaryContact (Initialize-ApiUserChangedProperty -ChangeValue  -OriginalValue ) -SecondaryContact (Initialize-ApiUserChangedProperty -ChangeValue  -OriginalValue ))) -SubRequests @((Initialize-ChangeWebContactSubRequest -Id "Id_example" -AssignTo  -Reason "Reason_example" -Status 123 -StatusDescription "StatusDescription_example" -ProgressStatus (Initialize-ApiRequestProgressStatus ) -ContactChangeSettings (Initialize-ChangeWebContactByUrlSetting -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -WebId "WebId_example" -WebUrl "WebUrl_example" -WebTitle "WebTitle_example" -PrimaryContact  -SecondaryContact ))) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeWebContactRequest |  (optional)

# edit change web contact request in task
try {
     $Result = Edit-ChangeWebContactRequest -Id $Id -ChangeWebContactRequest $ChangeWebContactRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeWebContactRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeWebContactRequest** | [**ChangeWebContactRequest**](ChangeWebContactRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ChangeWebSettingRequest = (Initialize-ChangeWebSettingRequest -Url (Initialize-ChangeWebSPObject -SiteUrl "SiteUrl_example" -WebUrl "WebUrl_example" -SiteId "SiteId_example" -WebId "WebId_example" -WebTitle "WebTitle_example") -ChangedTitle  -ChangedDescription  -ChangedMetadata (Initialize-RequestMetadataListChangedProperty -ChangeValue @() -OriginalValue @()) -DeploymentPlanName "DeploymentPlanName_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ChangeWebSettingRequest |  (optional)

# edit change web setting request in task
try {
     $Result = Edit-ChangeWebSettingRequest -Id $Id -ChangeWebSettingRequest $ChangeWebSettingRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ChangeWebSettingRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ChangeWebSettingRequest** | [**ChangeWebSettingRequest**](ChangeWebSettingRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ClonePermissionRequest"></a>
# **Edit-ClonePermissionRequest**
> void Edit-ClonePermissionRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ClonePermissionRequest] <PSCustomObject><br>

edit clone permission request

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



$Id = "Id_example" # String | 
$ClonePermissionRequest = (Initialize-ClonePermissionRequest -Urls @("Urls_example") -SourceUser  -TargetUser  -CloneOption (Initialize-ClonePermissionOption ) -AdditionalCloneOption (Initialize-ClonePermissionAdditionalOption ) -EnabledRemoveExplicitPermission $false -EnabledRemoveUserFromSPGroup $false -EnabledDeleteUserPermission $false -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ClonePermissionRequest |  (optional)

# edit clone permission request
try {
     $Result = Edit-ClonePermissionRequest -Id $Id -ClonePermissionRequest $ClonePermissionRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ClonePermissionRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ClonePermissionRequest** | [**ClonePermissionRequest**](ClonePermissionRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ContentMoveRequest"></a>
# **Edit-ContentMoveRequest**
> void Edit-ContentMoveRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ContentMoveRequest] <PSCustomObject><br>

edit content move request

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



$Id = "Id_example" # String | 
$ContentMoveRequest = (Initialize-ContentMoveRequest -Method (Initialize-ContentMoveMethod ) -CopySettings (Initialize-CopyMoveSetting -IsMigrateConfiguration $false -IsKeepLookAndFeel $false -ColumnsAndContentConflictResolution (Initialize-ItemConflictResolutionType ) -IsMigrateSecurity $false -IsMigrateColumnsAndContentTypes $false -IsMigrateContent $false -IsMigrateContentIncludeListAttachment $false) -MoveSettings (Initialize-CopyMoveSetting -IsMigrateConfiguration $false -IsKeepLookAndFeel $false -ColumnsAndContentConflictResolution (Initialize-ItemConflictResolutionType ) -IsMigrateSecurity $false -IsMigrateColumnsAndContentTypes $false -IsMigrateContent $false -IsMigrateContentIncludeListAttachment $false) -CommonSettings (Initialize-ContentMoveCommonSetting -IsIncludeVersions $false -IsIncludeWorkflowDefinition $false -IsDisableInformationRightsManagement $false -IsPreserveNullColumnValues $false -IsKeepModifiedByAndModifiedTime $false -ProfileMappings (Initialize-ContentMoveProfileMappings -ColumnMapping  -ContentTypeMapping  -UserMapping  -LanguageMapping ) -BackupSettings (Initialize-BackupEnvironmentSetting -IsBackupSource $false -IsBackupDestination $false -StoragePolicy ) -ConflictResolutionSettings (Initialize-ConflictResolutionSetting -ContainerConflictSolution (Initialize-ConflictSolutionType ) -IsCheckLowerObject $false -IsEnableContentConflictResolution $false -ContentConflictSolution (Initialize-ConflictSolutionType ) -AppConflictSolution ) -FilterPolicy  -DeleteType (Initialize-DeleteType ) -IsDeleteCheckedFiles $false) -ObjectMappings @((Initialize-ContentMoveSPObjectMapping -Source (Initialize-ContentMoveSPObject -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -Id "Id_example" -Title "Title_example" -FullUrl "FullUrl_example" -Type (Initialize-NodeType )) -Destination (Initialize-ContentMoveSPObject -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -Id "Id_example" -Title "Title_example" -FullUrl "FullUrl_example" -Type (Initialize-NodeType )) -Action (Initialize-ContentMoveAction ))) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ContentMoveRequest |  (optional)

# edit content move request
try {
     $Result = Edit-ContentMoveRequest -Id $Id -ContentMoveRequest $ContentMoveRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ContentMoveRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ContentMoveRequest** | [**ContentMoveRequest**](ContentMoveRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateGroupRequest"></a>
# **Edit-CreateGroupRequest**
> void Edit-CreateGroupRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateGroupRequest] <PSCustomObject><br>

edit create site group request

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



$Id = "Id_example" # String | 
$CreateGroupRequest = (Initialize-CreateGroupRequest -GroupType (Initialize-CreateGroupType ) -GroupId "GroupId_example" -GroupIdWithoutPrefixSuffix "GroupIdWithoutPrefixSuffix_example" -GroupName "GroupName_example" -GroupNameWithoutPrefixSuffix "GroupNameWithoutPrefixSuffix_example" -GroupEmail "GroupEmail_example" -Policy "Policy_example" -GroupDescription "GroupDescription_example" -Owners @() -Members @() -Privacy $false -Subscribe $false -OutsideSender $false -EnableTeamCollaboration $false -Language "Language_example" -Classification "Classification_example" -Sensitivity "Sensitivity_example" -SensitivityName "SensitivityName_example" -Links (Initialize-GroupLinks -GroupSiteLink "GroupSiteLink_example" -GroupPlannerLink "GroupPlannerLink_example" -GroupFilesLink "GroupFilesLink_example" -GroupConversationsLink "GroupConversationsLink_example" -GroupNotebookLink "GroupNotebookLink_example" -YammerGroupLink "YammerGroupLink_example") -LeasePeriodSettings (Initialize-GroupLeasePeriodSettings -IsEnabled $false -LeaseType (Initialize-GroupLeasePeriodType ) -DurationType (Initialize-ApiDurationType ) -DurationInterval 123 -LeaseExpirationDate Get-Date) -TeamsSettings (Initialize-RequestTeamsSettings -AllowMembersCreateUpdateChannels $false -AllowMembersCreatePrivateChannels $false -AllowMemberDeleteRestoreChannels $false -AllowMembersAddRemoveApps $false -AllowMembersCreateUpdateRemoveTabs $false -AllowMembersCreateUpdateRemoveConnections $false -AllowMembersDeleteMessages $false -AllowMembersEditMessages $false -AllowGuestsCreateUpdateChannels $false -AllowGuestsDeleteChannels $false -AllowMentionsTeam $false -AllowMentionsChannel $false -EnableGiphy $false -EnableStickersAndMemes $false -EnableCustomMemes $false -GiphyRatingType (Initialize-GiphyRatingType )) -AppliedSiteDesignId "AppliedSiteDesignId_example" -PrimaryContact  -SecondaryContact  -EnableGroupMembershipHidden $false -EnableAssignedMembership $false -EnableDynamicMembership $false -TemplateSettings (Initialize-TeamsTemplateSettings -EnableCreateTeamFromScratch $false -EnableCreateTeamFromExistTeam $false -EnableCreateTeamFromTeamTemplate $false -SelectedTemplate  -SelectedMSTemplate (Initialize-StringModel -Id "Id_example" -Name "Name_example") -TeamTemplates @((Initialize-TextModel -Description "Description_example" -Id "Id_example" -Name "Name_example")) -EnableCloneChannels $false -EnableCloneApps $false -EnableCloneTabs $false -EnableCloneMembers $false -EnableCloneTeamSetting $false -EnableCloneTeamPrivacy $false -EnableCloneTeamClassification $false) -DynamicMembershipRules @((Initialize-DynamicGroupRuleInfo -Id "Id_example" -Order 123 -Relation (Initialize-LogicalOperator ) -Category (Initialize-CategoryType ) -MetadataId "MetadataId_example" -MetadataName "MetadataName_example" -MetadataValue "MetadataValue_example" -MetadataDisplayValue "MetadataDisplayValue_example" -MetadataValueAzureUserType "MetadataValueAzureUserType_example" -Condition (Initialize-DynamicRuleCondition ) -DisableEditRule $false -DisableEditRuleValue $false)) -MultiGeoLocation (Initialize-GeoLocationBase -Name "Name_example" -DisplayName "DisplayName_example") -HubSiteSettings (Initialize-HubSiteSettings -Enabled $false -Action (Initialize-ConvertHubSiteActionType ) -AssociatedHubSiteId "AssociatedHubSiteId_example" -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example") -YammerGroupInfo "YammerGroupInfo_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # CreateGroupRequest |  (optional)

# edit create site group request
try {
     $Result = Edit-CreateGroupRequest -Id $Id -CreateGroupRequest $CreateGroupRequest
} catch {
    Write-Host ("Exception occured when calling Edit-CreateGroupRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CreateGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateGuestUserRequest"></a>
# **Edit-CreateGuestUserRequest**
> void Edit-CreateGuestUserRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateGuestUserRequest] <PSCustomObject><br>

edit create guest user request in task

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



$Id = "Id_example" # String | 
$CreateGuestUserRequest = (Initialize-CreateGuestUserRequest -UserProperties (Initialize-GuestUserPropertyModel -DisplayName "DisplayName_example" -FirstName "FirstName_example" -LastName "LastName_example" -UserName "UserName_example" -UsageLocation "UsageLocation_example" -UsageLocationDisplayName "UsageLocationDisplayName_example" -JobTitle "JobTitle_example" -JobDepartment "JobDepartment_example" -Manager  -CompanyName "CompanyName_example") -WelcomeEmailMessage "WelcomeEmailMessage_example" -PrimaryContact  -SecondaryContact  -InviteGroups @() -OneTimeSettings (Initialize-GuestUserRequestOneTimeRenewalSettingModel -Option (Initialize-OneTimeRenewalOption ) -Duration 123 -DurationType (Initialize-ApiDurationType ) -StartTime Get-Date) -SubRequestInfos @((Initialize-CreateGuestUserSubRequest -Id "Id_example" -UserProperties (Initialize-GuestUserPropertyModel -DisplayName "DisplayName_example" -FirstName "FirstName_example" -LastName "LastName_example" -UserName "UserName_example" -UsageLocation "UsageLocation_example" -UsageLocationDisplayName "UsageLocationDisplayName_example" -JobTitle "JobTitle_example" -JobDepartment "JobDepartment_example" -Manager  -CompanyName "CompanyName_example") -WelcomeEmailMessage "WelcomeEmailMessage_example" -PrimaryContact  -SecondaryContact  -InviteGroups @() -OneTimeSettings (Initialize-GuestUserRequestOneTimeRenewalSettingModel -Option (Initialize-OneTimeRenewalOption ) -Duration 123 -DurationType  -StartTime Get-Date) -Metadatas @() -ProcessStatus  -AssignTo @())) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # CreateGuestUserRequest |  (optional)

# edit create guest user request in task
try {
     $Result = Edit-CreateGuestUserRequest -Id $Id -CreateGuestUserRequest $CreateGuestUserRequest
} catch {
    Write-Host ("Exception occured when calling Edit-CreateGuestUserRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CreateGuestUserRequest** | [**CreateGuestUserRequest**](CreateGuestUserRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$CreateListRequest = (Initialize-CreateListRequest -ListTitle "ListTitle_example" -ListName "ListName_example" -ListDescription "ListDescription_example" -ParentObject (Initialize-CreateListSPObject -ParentUrl "ParentUrl_example" -SiteUrl "SiteUrl_example" -SiteId "SiteId_example") -ListTemplate "ListTemplate_example" -EnableNavigation $false -ListType  -VersionSettings  -PermissionSettings (Initialize-ListPermissionSettings -StopInheritingPermissions $false -UserPermissions @((Initialize-RequestUserWithPermissions -User  -PermissionLevels @((Initialize-PermissionLevel -Id "Id_example" -IdInSharePoint 123 -Name "Name_example" -Description "Description_example" -IsExcluded $false -Type 123)))) -GroupPermissions @((Initialize-RequestGroupWithPermissions -Name "Name_example" -Description "Description_example" -Users @((Initialize-GroupUser -IsEnforce $false -IsHide $false -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser  -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -Email "Email_example" -JobTitle "JobTitle_example" -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -TenantId "TenantId_example" -AdditionalData "TODO" -ApiUserType )) -PermissionLevels @((Initialize-PermissionLevel -Id "Id_example" -IdInSharePoint 123 -Name "Name_example" -Description "Description_example" -IsExcluded $false -Type 123)) -GroupOwner  -GroupOwnerType (Initialize-GroupOwnerType ) -BuildInGroupType (Initialize-SharePointBuildInGroupType )))) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # CreateListRequest |  (optional)

# edit create list request in task
try {
     $Result = Edit-CreateListRequest -Id $Id -CreateListRequest $CreateListRequest
} catch {
    Write-Host ("Exception occured when calling Edit-CreateListRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CreateListRequest** | [**CreateListRequest**](CreateListRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CreateSiteRequest"></a>
# **Edit-CreateSiteRequest**
> void Edit-CreateSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateSiteRequest] <PSCustomObject><br>

edit create site request

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



$Id = "Id_example" # String | 
$CreateSiteRequest = (Initialize-CreateSiteRequest -SiteTitle "SiteTitle_example" -SiteDescription "SiteDescription_example" -SiteUrl (Initialize-SiteUrl -Root "Root_example" -ManagedPath "ManagedPath_example" -Name "Name_example") -PolicyId "PolicyId_example" -TimeZone 123 -Language 123 -Template "Template_example" -DeploymentManagerPlanName "DeploymentManagerPlanName_example" -PrimaryAdmin  -AdditionalAdmins @() -PrimaryContact  -SecondaryContact  -SiteDesign (Initialize-StringModel -Id "Id_example" -Name "Name_example") -TeamSiteDesign "TeamSiteDesign_example" -Classification "Classification_example" -Sensitivity "Sensitivity_example" -HubSiteSettings (Initialize-HubSiteSettings -Enabled $false -Action (Initialize-ConvertHubSiteActionType ) -AssociatedHubSiteId "AssociatedHubSiteId_example" -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example") -UserPermissions @((Initialize-RequestUserWithPermissions -User  -PermissionLevels @())) -GroupPermissions @((Initialize-RequestGroupWithPermissions -Name "Name_example" -Description "Description_example" -Users @((Initialize-GroupUser -IsEnforce $false -IsHide $false -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser  -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -Email "Email_example" -JobTitle "JobTitle_example" -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -TenantId "TenantId_example" -AdditionalData "TODO" -ApiUserType )) -PermissionLevels @() -GroupOwner  -GroupOwnerType (Initialize-GroupOwnerType ) -BuildInGroupType (Initialize-SharePointBuildInGroupType ))) -YammerGroupSettings (Initialize-YammerGroupRequestSettings -NameOrId "NameOrId_example" -Description "Description_example" -Type (Initialize-YammerGroupType ) -JoinType (Initialize-YammerGroupJoinType ) -IsListInDirectory $false -IsGroupAlreadyExisted $false) -LeasePeriodSettings (Initialize-SiteLeasePeriodRequestSettings -LeaseInterval 123 -LeaseDurationType  -LeaseWarningInterval 123 -LeaseWarningDurationType ) -MultiGeoLocation (Initialize-GeoLocationBase -Name "Name_example" -DisplayName "DisplayName_example") -InputTitle "InputTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # CreateSiteRequest |  (optional)

# edit create site request
try {
     $Result = Edit-CreateSiteRequest -Id $Id -CreateSiteRequest $CreateSiteRequest
} catch {
    Write-Host ("Exception occured when calling Edit-CreateSiteRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CreateSiteRequest** | [**CreateSiteRequest**](CreateSiteRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$CreateWebRequest = (Initialize-CreateWebRequest -WebName "WebName_example" -WebTitle "WebTitle_example" -WebDescription "WebDescription_example" -WebLanguage (Initialize-IntModel -Id 123 -Name "Name_example" -Description "Description_example") -WebTemplate "WebTemplate_example" -ParentSiteUrl "ParentSiteUrl_example" -ParentWebUrl "ParentWebUrl_example" -PrimaryContact  -SecondaryContact  -UserPermissions @() -GroupPermissions @() -YammerGroupSettings (Initialize-YammerGroupRequestSettings -NameOrId "NameOrId_example" -Description "Description_example" -Type (Initialize-YammerGroupType ) -JoinType (Initialize-YammerGroupJoinType ) -IsListInDirectory $false -IsGroupAlreadyExisted $false) -IsOnQuickLaunch $false -IsOnTopLinkBar $false -IsInheritance $false -DeploymentManagerPlanName "DeploymentManagerPlanName_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # CreateWebRequest |  (optional)

# edit create web request in task
try {
     $Result = Edit-CreateWebRequest -Id $Id -CreateWebRequest $CreateWebRequest
} catch {
    Write-Host ("Exception occured when calling Edit-CreateWebRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CreateWebRequest** | [**CreateWebRequest**](CreateWebRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-CustomRequest"></a>
# **Edit-CustomRequest**
> void Edit-CustomRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiRequest] <PSCustomObject><br>

edit custom request

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



$Id = "Id_example" # String | 
$ApiRequest = (Initialize-ApiRequest -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ApiRequest |  (optional)

# edit custom request
try {
     $Result = Edit-CustomRequest -Id $Id -ApiRequest $ApiRequest
} catch {
    Write-Host ("Exception occured when calling Edit-CustomRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ApiRequest** | [**ApiRequest**](ApiRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$DeleteGroupRequest = (Initialize-DeleteGroupRequest -GroupId "GroupId_example" -GroupName "GroupName_example" -GroupEmail "GroupEmail_example" -GroupObjectType  -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # DeleteGroupRequest |  (optional)

# edit delete change group request in task
try {
     $Result = Edit-DeleteGroupRequest -Id $Id -DeleteGroupRequest $DeleteGroupRequest
} catch {
    Write-Host ("Exception occured when calling Edit-DeleteGroupRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **DeleteGroupRequest** | [**DeleteGroupRequest**](DeleteGroupRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$DeleteSiteRequest = (Initialize-DeleteSiteRequest -Action  -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # DeleteSiteRequest |  (optional)

# edit delete site request in task
try {
     $Result = Edit-DeleteSiteRequest -Id $Id -DeleteSiteRequest $DeleteSiteRequest
} catch {
    Write-Host ("Exception occured when calling Edit-DeleteSiteRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **DeleteSiteRequest** | [**DeleteSiteRequest**](DeleteSiteRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$DeleteWebLifecycleRequest = (Initialize-DeleteWebLifecycleRequest -Action (Initialize-WebLifecycleActionType ) -WebId "WebId_example" -WebUrl "WebUrl_example" -WebRelativeUrl "WebRelativeUrl_example" -WebTitle "WebTitle_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -ActionDescription "ActionDescription_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # DeleteWebLifecycleRequest |  (optional)

# edit delete web request in task
try {
     $Result = Edit-DeleteWebRequest -Id $Id -DeleteWebLifecycleRequest $DeleteWebLifecycleRequest
} catch {
    Write-Host ("Exception occured when calling Edit-DeleteWebRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **DeleteWebLifecycleRequest** | [**DeleteWebLifecycleRequest**](DeleteWebLifecycleRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ExtendGroupRequest = (Initialize-ExtendGroupRequest -ExtendDuration 123 -ExtendDurationType  -GroupId "GroupId_example" -GroupName "GroupName_example" -GroupEmail "GroupEmail_example" -GroupObjectType  -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ExtendGroupRequest |  (optional)

# edit extend group request in task
try {
     $Result = Edit-ExtendGroupRequest -Id $Id -ExtendGroupRequest $ExtendGroupRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ExtendGroupRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ExtendGroupRequest** | [**ExtendGroupRequest**](ExtendGroupRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$ExtendSiteRequest = (Initialize-ExtendSiteRequest -ExtendDuration 123 -ExtendDurationType  -Action  -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ExtendSiteRequest |  (optional)

# edit extend site request in task
try {
     $Result = Edit-ExtendSiteRequest -Id $Id -ExtendSiteRequest $ExtendSiteRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ExtendSiteRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ExtendSiteRequest** | [**ExtendSiteRequest**](ExtendSiteRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$GrantPermissionRequest = (Initialize-GrantPermissionRequest -Url (Initialize-GrantPermissionSPObject -WebId "WebId_example" -SiteId "SiteId_example" -WebServerRelativeUrl "WebServerRelativeUrl_example" -ListTitle "ListTitle_example" -TopInheritUrl "TopInheritUrl_example" -InheritNodeType  -IsInheritedPermission $false -Id "Id_example" -Title "Title_example" -FullUrl "FullUrl_example" -Type ) -PermissionSettings (Initialize-GrantPermissionRequestPermissionSettings -IsBreakInheritance $false -IsGrantPermissionDirectly $false -SelectedSPGroup (Initialize-GrantPermissionGroup -Id 123 -Name "Name_example" -DisplayName "DisplayName_example" -PermissionIds @("PermissionIds_example") -Description "Description_example") -SelectedPermissionLevels @((Initialize-IntModel -Id 123 -Name "Name_example" -Description "Description_example"))) -PermissionDurationSettings (Initialize-GrantPermissionRequestDurationSettings -IsGrantTemporaryPermission $false -IsGrantPermissionLevel $false -ExpirationType (Initialize-ExpirationType ) -DurationInterval 123 -DurationDateType (Initialize-DurationDateType ) -StartTime Get-Date -EndTime Get-Date) -SelectedUsers @((Initialize-SharingEnabledUser -IsSharePointGroup $false -IsGuestUser $false -IsGuestUserExistsInOrganization $false -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser  -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -Email "Email_example" -JobTitle "JobTitle_example" -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -TenantId "TenantId_example" -AdditionalData "TODO" -ApiUserType )) -ExternalUserSharingSettings (Initialize-ExternalUserSharingSettings -Enabled $false -SharingType (Initialize-ExternalUserSharingType ) -AnonymousLinkSettings (Initialize-AnonymousLinkSettings -Permisssion (Initialize-AnnoymouslinkPermissions ) -ExpirationDate Get-Date)) -WelcomeEmailSettings (Initialize-WelcomeEmailSettings -Enabled $false -Subject "Subject_example" -PersonalMessage "PersonalMessage_example" -EnabledSendEmailInService $false -WelcomeEmailTemplateId "WelcomeEmailTemplateId_example" -IsWelcomeEmailTemplate $false) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # GrantPermissionRequest |  (optional)

# edit grant permission request in task
try {
     $Result = Edit-GrantPermissionRequest -Id $Id -GrantPermissionRequest $GrantPermissionRequest
} catch {
    Write-Host ("Exception occured when calling Edit-GrantPermissionRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **GrantPermissionRequest** | [**GrantPermissionRequest**](GrantPermissionRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-LockSiteRequest"></a>
# **Edit-LockSiteRequest**
> void Edit-LockSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-LockSiteRequest] <PSCustomObject><br>

edit lock site request

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



$Id = "Id_example" # String | 
$LockSiteRequest = (Initialize-LockSiteRequest -LockType (Initialize-SiteLockType ) -LockTypeDescription "LockTypeDescription_example" -Action  -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # LockSiteRequest |  (optional)

# edit lock site request
try {
     $Result = Edit-LockSiteRequest -Id $Id -LockSiteRequest $LockSiteRequest
} catch {
    Write-Host ("Exception occured when calling Edit-LockSiteRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **LockSiteRequest** | [**LockSiteRequest**](LockSiteRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ManagePermissionRequest"></a>
# **Edit-ManagePermissionRequest**
> void Edit-ManagePermissionRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ManagePermissionRequest] <PSCustomObject><br>

edit manage permission request

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



$Id = "Id_example" # String | 
$ManagePermissionRequest = (Initialize-ManagePermissionRequest -ObjectUrl "ObjectUrl_example" -ObjectType  -ObjectTitle "ObjectTitle_example" -SiteUrl "SiteUrl_example" -WebUrl "WebUrl_example" -SpGroupManagement @((Initialize-SPGroupManagementModel -Id 123 -Name  -Description "Description_example" -Owner  -Members @((Initialize-SPUserManagementModel -IdentityName "IdentityName_example" -DisplayName "DisplayName_example" -IsGroup $false -AzureUserType "AzureUserType_example" -Action (Initialize-ManagePermissionAction ) -ExternalUserType  -Email "Email_example")) -SpGroupViewType (Initialize-SPGroupViewOption ) -SpGroupEditType (Initialize-SPGroupEditOption ) -Permissions @("Permissions_example") -Action (Initialize-ManagePermissionAction ) -IsAllowJoinOrLeaveRequest $false -IsAutoAcceptRequest $false -SendMembershipRequestEmailAddress "SendMembershipRequestEmailAddress_example" -IsTemporaryGroup $false -RoleID @("RoleID_example"))) -PermissionManagement (Initialize-PermissionManagementModel -IsUniquePermission $false -IsPermissionInheritanceChanged $false -IsCopyPermissionsFromParent $false -InheritedSiteUrl "InheritedSiteUrl_example" -PermissionItems @((Initialize-ObjectPermissionManagementModel -ObjectType (Initialize-SPPrincipalType ) -ObjectInfo  -Action  -Permissions @("Permissions_example") -OriginalPermissions @("OriginalPermissions_example") -ExternalUserType  -Members @((Initialize-SharingEnabledUser -IsSharePointGroup $false -IsGuestUser $false -IsGuestUserExistsInOrganization $false -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser  -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -Email "Email_example" -JobTitle "JobTitle_example" -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -TenantId "TenantId_example" -AdditionalData "TODO" -ApiUserType )) -GrantPermissionSetting (Initialize-GrantPermissionModel -PermissionDurationSettings (Initialize-TemporaryPermissionRequestSetting -IsGrantTemporaryPermission $false -IsGrantAdminGroup $false -ExpirationType (Initialize-ExpirationType ) -DurationInterval 123 -DurationDateType  -StartTime Get-Date -EndTime Get-Date) -WelcomeEmailSettings (Initialize-WelcomeEmailSettings -Enabled $false -Subject "Subject_example" -PersonalMessage "PersonalMessage_example" -EnabledSendEmailInService $false -WelcomeEmailTemplateId "WelcomeEmailTemplateId_example" -IsWelcomeEmailTemplate $false)) -OriginalName "OriginalName_example"))) -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # ManagePermissionRequest |  (optional)

# edit manage permission request
try {
     $Result = Edit-ManagePermissionRequest -Id $Id -ManagePermissionRequest $ManagePermissionRequest
} catch {
    Write-Host ("Exception occured when calling Edit-ManagePermissionRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **ManagePermissionRequest** | [**ManagePermissionRequest**](ManagePermissionRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$RestoreGroupRequest = (Initialize-RestoreGroupRequest -GroupId "GroupId_example" -GroupName "GroupName_example" -GroupEmail "GroupEmail_example" -GroupObjectType  -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # RestoreGroupRequest |  (optional)

# edit restore group request in task
try {
     $Result = Edit-RestoreGroupRequest -Id $Id -RestoreGroupRequest $RestoreGroupRequest
} catch {
    Write-Host ("Exception occured when calling Edit-RestoreGroupRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **RestoreGroupRequest** | [**RestoreGroupRequest**](RestoreGroupRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-UnLockSiteRequest"></a>
# **Edit-UnLockSiteRequest**
> void Edit-UnLockSiteRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UnlockSiteRequest] <PSCustomObject><br>

edit unlock site request

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



$Id = "Id_example" # String | 
$UnlockSiteRequest = (Initialize-UnlockSiteRequest -ExtendDuration 123 -ExtendDurationType  -Action  -ActionDescription "ActionDescription_example" -SiteId "SiteId_example" -SiteUrl "SiteUrl_example" -SiteTitle "SiteTitle_example" -Id "Id_example" -ServiceId "ServiceId_example" -Summary "Summary_example" -NotesToApprovers "NotesToApprovers_example" -QuestionnaireId "QuestionnaireId_example" -Metadatas @() -TicketNumber 123 -Type  -TypeDescription "TypeDescription_example" -Requester "Requester_example" -RequesterLoginName "RequesterLoginName_example" -Status  -ProgressStatus 123 -ProgressStatusDescription "ProgressStatusDescription_example" -SubmittedTime Get-Date -LastUpdated Get-Date -CreatedTime Get-Date -AssignTo "AssignTo_example" -FullPath "FullPath_example") # UnlockSiteRequest |  (optional)

# edit unlock site request
try {
     $Result = Edit-UnLockSiteRequest -Id $Id -UnlockSiteRequest $UnlockSiteRequest
} catch {
    Write-Host ("Exception occured when calling Edit-UnLockSiteRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **UnlockSiteRequest** | [**UnlockSiteRequest**](UnlockSiteRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-BatchTasksById"></a>
# **Get-BatchTasksById**
> ApiTask[] Get-BatchTasksById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get all batch tasks by id

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



$Id = "Id_example" # String | 

# get all batch tasks by id
try {
     $Result = Get-BatchTasksById -Id $Id
} catch {
    Write-Host ("Exception occured when calling Get-BatchTasksById: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiTask[]**](ApiTask.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyTasks"></a>
# **Get-MyTasks**
> TaskListPageResult Get-MyTasks<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TaskApprovalStatus] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get my tasks

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



$TaskApprovalStatus = (Initialize-TaskApprovalStatus ) # TaskApprovalStatus | 
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId (optional)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId (optional)
$Search = "Search_example" # String | Search for title (optional)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional)
$Skip = "Skip_example" # String |  Define the number of records you want to skip, default value is 0 (optional)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional)

# get my tasks
try {
     $Result = Get-MyTasks -TaskApprovalStatus $TaskApprovalStatus -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ("Exception occured when calling Get-MyTasks: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TaskApprovalStatus** | [**TaskApprovalStatus**](TaskApprovalStatus.md)|  | 
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId | [optional] 
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId | [optional] 
 **Search** | **String**| Search for title | [optional] 
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **Skip** | **String**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TaskListPageResult**](TaskListPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TaskByBatchId"></a>
# **Get-TaskByBatchId**
> TaskList Get-TaskByBatchId<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Batchid] <PSCustomObject><br>

get my task by batch id

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



$Batchid = "Batchid_example" # String | 

# get my task by batch id
try {
     $Result = Get-TaskByBatchId -Batchid $Batchid
} catch {
    Write-Host ("Exception occured when calling Get-TaskByBatchId: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Batchid** | [**String**](String.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**TaskList**](TaskList.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TaskById"></a>
# **Get-TaskById**
> ApiTask Get-TaskById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get task by id

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



$Id = "Id_example" # String | 

# get task by id
try {
     $Result = Get-TaskById -Id $Id
} catch {
    Write-Host ("Exception occured when calling Get-TaskById: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiTask**](ApiTask.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$User = "User_example" # String | 

# reassign task
try {
     $Result = Invoke-ReassignTask -Id $Id -User $User
} catch {
    Write-Host ("Exception occured when calling Invoke-ReassignTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **User** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Deny-Task"></a>
# **Deny-Task**
> void Deny-Task<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CommentsParam] <PSCustomObject><br>

reject task

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



$Id = "Id_example" # String | 
$CommentsParam = (Initialize-CommentsParam -Comments "Comments_example") # CommentsParam |  (optional)

# reject task
try {
     $Result = Deny-Task -Id $Id -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Deny-Task: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$CommentsParam =  # CommentsParam |  (optional)

# retry error task
try {
     $Result = Invoke-RetryErrorTask -Id $Id -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Invoke-RetryErrorTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String | 
$CommentsParam =  # CommentsParam |  (optional)

# skip error task
try {
     $Result = Skip-ErrorTask -Id $Id -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Skip-ErrorTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | 
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String |  (optional)
$CommentsParam =  # CommentsParam |  (optional)

# submit group continue access auto task
try {
     $Result = Submit-ContinueAccessGroupAutoTask -Id $Id -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Submit-ContinueAccessGroupAutoTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | [optional] 
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Id = "Id_example" # String |  (optional)
$CommentsParam =  # CommentsParam |  (optional)

# submit site continue access auto task
try {
     $Result = Submit-ContinueAccessSiteAutoTask -Id $Id -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Submit-ContinueAccessSiteAutoTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**String**](String.md)|  | [optional] 
 **CommentsParam** | [**CommentsParam**](CommentsParam.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ExtendGroupAutoTask"></a>
# **Submit-ExtendGroupAutoTask**
> void Submit-ExtendGroupAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskExtendRequest] <PSCustomObject><br>

submit extend group auto task

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



$AutoTaskExtendRequest = (Initialize-AutoTaskExtendRequest -Action (Initialize-LifecycleAction ) -ExtendDuration 123 -ExtendDurationType  -TaskId "TaskId_example" -Metadatas @() -Comments ) # AutoTaskExtendRequest |  (optional)

# submit extend group auto task
try {
     $Result = Submit-ExtendGroupAutoTask -AutoTaskExtendRequest $AutoTaskExtendRequest
} catch {
    Write-Host ("Exception occured when calling Submit-ExtendGroupAutoTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-ExtendSiteAutoTask"></a>
# **Submit-ExtendSiteAutoTask**
> void Submit-ExtendSiteAutoTask<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AutoTaskExtendRequest] <PSCustomObject><br>

submit site extend auto task

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



$AutoTaskExtendRequest = (Initialize-AutoTaskExtendRequest -Action (Initialize-LifecycleAction ) -ExtendDuration 123 -ExtendDurationType  -TaskId "TaskId_example" -Metadatas @() -Comments ) # AutoTaskExtendRequest |  (optional)

# submit site extend auto task
try {
     $Result = Submit-ExtendSiteAutoTask -AutoTaskExtendRequest $AutoTaskExtendRequest
} catch {
    Write-Host ("Exception occured when calling Submit-ExtendSiteAutoTask: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AutoTaskExtendRequest** | [**AutoTaskExtendRequest**](AutoTaskExtendRequest.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

