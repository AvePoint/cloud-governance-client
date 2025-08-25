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
[**Edit-DynamicServiceRequest**](TasksApi.md#Edit-DynamicServiceRequest) | **PUT** /tasks/{id}/dynamic | edit dynamic service request
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CommentsParam = $CommentsParam = New-CommentsParam -Comments "MyComments" # CommentsParam |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ArchiveGroupRequest = $TemplateAssignBy = New-TemplateAssignBy 
$GroupObjectType = New-GroupObjectType 
$ServiceType = New-ServiceType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ArchiveGroupRequest = New-ArchiveGroupRequest -TeamArchivingProfileName "MyTeamArchivingProfileName" -TeamArchivingProfileAssignBy $TemplateAssignBy -IsChangeMembershipAndPermissionBeforeArchive $false -GroupId "MyGroupId" -GroupName "MyGroupName" -GroupEmail "MyGroupEmail" -GroupObjectType $GroupObjectType -LifecycleType $ServiceType -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ArchiveGroupRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ArchiveSiteRequest = $SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ArchiveSiteRequest = New-ArchiveSiteRequest -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ArchiveSiteRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ArchiveWebLifecycleRequest = $WebLifecycleActionType = New-WebLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ArchiveWebLifecycleRequest = New-ArchiveWebLifecycleRequest -Action $WebLifecycleActionType -WebId "MyWebId" -WebUrl "MyWebUrl" -WebRelativeUrl "MyWebRelativeUrl" -WebTitle "MyWebTitle" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -ActionDescription "MyActionDescription" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ArchiveWebLifecycleRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeGroupPolicyRequest = $ChangeGroupPolicyRequestPolicy = New-ChangeGroupPolicyRequestPolicy -Id "MyId" -Name "MyName" -Description "MyDescription"
$ChangeGroupPolicyRequestOriginalPolicy = New-ChangeGroupPolicyRequestOriginalPolicy -Id "MyId" -Name "MyName" -Description "MyDescription"
$AssignBy = New-AssignBy 
$StartDateType = New-StartDateType 
$GroupObjectType = New-GroupObjectType 
$ServiceType = New-ServiceType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeGroupPolicyRequest = New-ChangeGroupPolicyRequest -Policy $ChangeGroupPolicyRequestPolicy -OriginalPolicy $ChangeGroupPolicyRequestOriginalPolicy -IsLeaseEnabled $false -ChangePolicyConfig $AssignBy -StartDateType $StartDateType -SpecifyStartDate (Get-Date) -GroupId "MyGroupId" -GroupName "MyGroupName" -GroupEmail "MyGroupEmail" -GroupObjectType $GroupObjectType -LifecycleType $ServiceType -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeGroupPolicyRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeGroupQuotaRequest = $GroupObjectType = New-GroupObjectType 
$ServiceType = New-ServiceType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeGroupQuotaRequest = New-ChangeGroupQuotaRequest -GroupQuotaSize 0 -OriginalQuotaSize 0 -SharePointSiteSize 0 -GroupId "MyGroupId" -GroupName "MyGroupName" -GroupEmail "MyGroupEmail" -GroupObjectType $GroupObjectType -LifecycleType $ServiceType -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeGroupQuotaRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeGroupSettingRequest = $ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$GroupMembershipAction = New-GroupMembershipAction 
$GroupMembershipItem = New-GroupMembershipItem -LoginName "MyLoginName" -DisplayName "MyDisplayName" -AzureUserType "MyAzureUserType" -IsGroup $false -Action $GroupMembershipAction

$LogicalOperator = New-LogicalOperator 
$CategoryType = New-CategoryType 
$DynamicRuleCondition = New-DynamicRuleCondition 

$AuthenticationType = New-AuthenticationType 
$InviteType = New-InviteType 
$PrincipalType = New-PrincipalType 
$UserInfo = New-UserInfo -IdentityName "MyIdentityName" -UserDisplayName "MyUserDisplayName" -DomainGroup $false -Department "MyDepartment" -MobilePhone "MyMobilePhone" -Manager "MyManager" -Permission "MyPermission" -IsDeleted $false -SecurityToken "MySecurityToken" -UserType 0 -AzureUserType "MyAzureUserType" -LegalPerson $false -AuthenticationType $AuthenticationType -AdminCenterUrl "MyAdminCenterUrl" -InviteType $InviteType -Type "MyType" -IsRegisteredAosGroup $false -IsExternalUser $ExternalUserType -IsAPIExceptional $false -TenantId "MyTenantId" -ObjectId "MyObjectId" -Version 0 -JobTitle "MyJobTitle" -UsageLocation "MyUsageLocation" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsOtherTenantUser $false -IsAccountEnabled $false -NetworkId "MyNetworkId" -IsValidateByProfile $false -ProxyAddresses "MyProxyAddresses" -PrincipalType $PrincipalType -Inviter "MyInviter" -CreatedTime (Get-Date) -LastModifiedTime (Get-Date) -SharePointLogonName "MySharePointLogonName" -Id 0 -DisplayName "MyDisplayName" -Title "MyTitle" -Email "MyEmail" -IsValid $false -ExistInAOS $false

$DynamicGroupRuleInfo = New-DynamicGroupRuleInfo -Id "MyId" -Order 0 -Relation $LogicalOperator -Category $CategoryType -MetadataId "MyMetadataId" -MetadataName "MyMetadataName" -MetadataValue "MyMetadataValue" -MetadataDisplayValue "MyMetadataDisplayValue" -MetadataValueAzureUserType "MyMetadataValueAzureUserType" -Condition $DynamicRuleCondition -DisableEditRule $false -DisableEditRuleValue $false -MetadataUserList $UserInfo

$ChangeHubsiteActionType = New-ChangeHubsiteActionType 

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$AddGroupMemberType = New-AddGroupMemberType 
$GroupObjectType = New-GroupObjectType 
$ChangeGroupSettingRequestTimeZoneSettings = New-ChangeGroupSettingRequestTimeZoneSettings -Enabled $false -TimeZone 0
$ChangeGroupSettingRequestOriginalTimeZoneSettings = New-ChangeGroupSettingRequestOriginalTimeZoneSettings -Enabled $false -TimeZone 0
$ChangeGroupSettingRequestLocaleSettings = New-ChangeGroupSettingRequestLocaleSettings -Enabled $false -Locale 0
$ChangeGroupSettingRequestOriginalLocaleSettings = New-ChangeGroupSettingRequestOriginalLocaleSettings -Enabled $false -Locale 0
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"
$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeGroupSettingRequest = New-ChangeGroupSettingRequest -GroupId "MyGroupId" -GroupEmail "MyGroupEmail" -GroupName "MyGroupName" -OriginalGroupName "MyOriginalGroupName" -GroupDescription "MyGroupDescription" -OriginalGroupDescription "MyOriginalGroupDescription" -OriginalYammerGroupInfo "MyOriginalYammerGroupInfo" -PrimaryContact $ApiMyGroupPrimaryContact -OriginalPrimaryContact $ApiMyGroupPrimaryContact -SecondaryContact $ApiMyGroupPrimaryContact -OriginalSecondaryContact $ApiMyGroupPrimaryContact -GroupOwners $GroupMembershipItem -GroupMembers $GroupMembershipItem -IsDynamicMembership $false -DynamicMembershipRules $DynamicGroupRuleInfo -EnabledSubscribe $false -OriginalEnabledSubscribe $false -EnabledOutsideSender $false -OriginalEnabledOutsideSender $false -HubSiteActionType $ChangeHubsiteActionType -AssociateHubSiteId "MyAssociateHubSiteId" -AssociateHubSiteTitle "MyAssociateHubSiteTitle" -Classification "MyClassification" -OriginalClassification "MyOriginalClassification" -Sensitivity "MySensitivity" -OriginalSensitivity "MyOriginalSensitivity" -EnableTeams $false -OriginalEnableTeams $false -GroupMetadatas $RequestMetadata -OriginalGroupMetadata $RequestMetadata -ChangedDynamicGroupType $AddGroupMemberType -YammerGroupInfo "MyYammerGroupInfo" -GroupObjectType $GroupObjectType -NetworkId "MyNetworkId" -GroupObjectId "MyGroupObjectId" -EnableTeamCollaboration $false -TimeZoneSettings $ChangeGroupSettingRequestTimeZoneSettings -OriginalTimeZoneSettings $ChangeGroupSettingRequestOriginalTimeZoneSettings -LocaleSettings $ChangeGroupSettingRequestLocaleSettings -OriginalLocaleSettings $ChangeGroupSettingRequestOriginalLocaleSettings -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeGroupSettingRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeListSettingRequest = $ChangeListSettingRequestObjectInfo = New-ChangeListSettingRequestObjectInfo -SiteUrl "MySiteUrl" -WebId "MyWebId" -WebUrl "MyWebUrl" -SiteId "MySiteId" -ObjectUrl "MyObjectUrl" -ObjectTitle "MyObjectTitle"
$ChangeListSettingRequestListTitle = New-ChangeListSettingRequestListTitle -ChangeValue "MyChangeValue" -OriginalValue "MyOriginalValue"
$ChangeListSettingRequestNavigationSetting = New-ChangeListSettingRequestNavigationSetting -ChangeValue $false -OriginalValue $false

$ListType = New-ListType 
$CreateListRequestVersionSettings = New-CreateListRequestVersionSettings -ListType $ListType -EnableMajorVersions $false -EnableMajorAndMinorVersions $false -EnableMajorVersionLimit $false -MajorVersionLimit 0 -EnableMinorVersionLimit $false -MinorVersionsLimit 0 -RequireContentApproval $false

$ChangeListSettingRequestVersionSetting = New-ChangeListSettingRequestVersionSetting -ChangeValue $CreateListRequestVersionSettings -OriginalValue $CreateListRequestVersionSettings

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeListSettingRequest = New-ChangeListSettingRequest -ObjectInfo $ChangeListSettingRequestObjectInfo -ListTitle $ChangeListSettingRequestListTitle -ListDescription $ChangeListSettingRequestListTitle -NavigationSetting $ChangeListSettingRequestNavigationSetting -VersionSetting $ChangeListSettingRequestVersionSetting -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeListSettingRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangePermissionRequest = $TreeNodeType = New-TreeNodeType 
$ChangePermissionRequestObjectProperty = New-ChangePermissionRequestObjectProperty -SiteId "MySiteId" -SiteUrl "MySiteUrl" -WebId "MyWebId" -WebServerRelativeUrl "MyWebServerRelativeUrl" -ListTitle "MyListTitle" -ObjectUrl "MyObjectUrl" -IsInherit $false -InheritNodeType $TreeNodeType -TopInheritUrl "MyTopInheritUrl" -CheckType $TreeNodeType

$PermissionChangedType = New-PermissionChangedType 

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangePermissionRequest = New-ChangePermissionRequest -ObjectProperty $ChangePermissionRequestObjectProperty -PermissionChangedType $PermissionChangedType -IsManagedAllUsers $false -SelectedUsers $ApiUser -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangePermissionRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeSiteContactRequest = $ChangeContactMethod = New-ChangeContactMethod 

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$ChangeContactByUrlSetting = New-ChangeContactByUrlSetting -SiteId "MySiteId" -SiteUrl "MySiteUrl" -OriginalPrimaryContact $ApiMyGroupPrimaryContact -NewPrimaryContact $ApiMyGroupPrimaryContact -OriginalSecondaryContact $ApiMyGroupPrimaryContact -NewSecondaryContact $ApiMyGroupPrimaryContact -OriginalPrimaryAdministrator $ApiMyGroupPrimaryContact -NewPrimaryAdministrator $ApiMyGroupPrimaryContact -OriginalAdditionalAdministrators $ApiUser -NewAdditionalAdministrators $ApiUser -SiteTitle "MySiteTitle"

$ChangeSiteContactRequestChangeByUserSetting = New-ChangeSiteContactRequestChangeByUserSetting -CurrentUser $ApiMyGroupPrimaryContact -NewUser $ApiMyGroupPrimaryContact -AlternativeUser $ApiMyGroupPrimaryContact

$ChangeSiteContactSubRequestAdminContactSettings = New-ChangeSiteContactSubRequestAdminContactSettings -SiteId "MySiteId" -SiteUrl "MySiteUrl" -OriginalPrimaryContact $ApiMyGroupPrimaryContact -NewPrimaryContact $ApiMyGroupPrimaryContact -OriginalSecondaryContact $ApiMyGroupPrimaryContact -NewSecondaryContact $ApiMyGroupPrimaryContact -OriginalPrimaryAdministrator $ApiMyGroupPrimaryContact -NewPrimaryAdministrator $ApiMyGroupPrimaryContact -OriginalAdditionalAdministrators $ApiUser -NewAdditionalAdministrators $ApiUser -SiteTitle "MySiteTitle"

$ApiRequestProgressStatus = New-ApiRequestProgressStatus 
$ChangeSiteContactSubRequest = New-ChangeSiteContactSubRequest -Id "MyId" -AssignTo $ApiUser -Reason "MyReason" -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -Status 0 -StatusDescription "MyStatusDescription" -AdminContactSettings $ChangeSiteContactSubRequestAdminContactSettings -ProgressStatus $ApiRequestProgressStatus

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeSiteContactRequest = New-ChangeSiteContactRequest -ChangeContactMethod $ChangeContactMethod -ChangeByUrlSetting $ChangeContactByUrlSetting -ChangeByUserSetting $ChangeSiteContactRequestChangeByUserSetting -SubRequests $ChangeSiteContactSubRequest -IsServiceEnableChangeContact $false -IsServiceEnableChangeAdmin $false -ParentRequestId "MyParentRequestId" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeSiteContactRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeSitePolicyRequest = $ChangeSitePolicyRequestPolicy = New-ChangeSitePolicyRequestPolicy -Id "MyId" -Name "MyName" -Description "MyDescription"
$ChangeSitePolicyRequestOriginalPolicy = New-ChangeSitePolicyRequestOriginalPolicy -Id "MyId" -Name "MyName" -Description "MyDescription"
$AssignBy = New-AssignBy 
$StartDateType = New-StartDateType 
$SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeSitePolicyRequest = New-ChangeSitePolicyRequest -Policy $ChangeSitePolicyRequestPolicy -OriginalPolicy $ChangeSitePolicyRequestOriginalPolicy -IsLeaseEnabled $false -ChangePolicyConfig $AssignBy -StartDateType $StartDateType -SpecifyStartDate (Get-Date) -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeSitePolicyRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeSiteQuotaRequest = $SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeSiteQuotaRequest = New-ChangeSiteQuotaRequest -QuotaSize 0 -SharePointSiteSize 0 -CurrentQuota 0 -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeSiteQuotaRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeSiteSettingRequest = $ChangeListSettingRequestListTitle = New-ChangeListSettingRequestListTitle -ChangeValue "MyChangeValue" -OriginalValue "MyOriginalValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ChangeHubsiteActionType = New-ChangeHubsiteActionType 
$ChangeSiteSettingRequestHubSiteSettings = New-ChangeSiteSettingRequestHubSiteSettings -Enabled $false -IsModernSite $false -Action $ChangeHubsiteActionType -AssociatedHubSiteId "MyAssociatedHubSiteId" -AssociatedHubSiteTitle "MyAssociatedHubSiteTitle"

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"
$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeSiteSettingRequest = New-ChangeSiteSettingRequest -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -SiteTitleSetting $ChangeListSettingRequestListTitle -SiteDescriptionSetting $ChangeListSettingRequestListTitle -EnableChangedMetadata $false -ChangedMetadatas $RequestMetadata -OriginalSiteMetadatas $RequestMetadata -DeploymentPlanName "MyDeploymentPlanName" -HubSiteSettings $ChangeSiteSettingRequestHubSiteSettings -SiteSensitivitySetting $ChangeListSettingRequestListTitle -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeSiteSettingRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeWebContactRequest = $ChangeContactMethod = New-ChangeContactMethod 

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$ChangeSiteContactRequestChangeByUserSetting = New-ChangeSiteContactRequestChangeByUserSetting -CurrentUser $ApiMyGroupPrimaryContact -NewUser $ApiMyGroupPrimaryContact -AlternativeUser $ApiMyGroupPrimaryContact

$ChangeWebContactByUrlSettingPrimaryContact = New-ChangeWebContactByUrlSettingPrimaryContact -ChangeValue $ApiMyGroupPrimaryContact -OriginalValue $ApiMyGroupPrimaryContact

$ChangeWebContactByUrlSetting = New-ChangeWebContactByUrlSetting -SiteId "MySiteId" -SiteUrl "MySiteUrl" -WebId "MyWebId" -WebUrl "MyWebUrl" -WebTitle "MyWebTitle" -PrimaryContact $ChangeWebContactByUrlSettingPrimaryContact -SecondaryContact $ChangeWebContactByUrlSettingPrimaryContact

$ApiRequestProgressStatus = New-ApiRequestProgressStatus 

$ChangeWebContactSubRequestContactChangeSettings = New-ChangeWebContactSubRequestContactChangeSettings -SiteId "MySiteId" -SiteUrl "MySiteUrl" -WebId "MyWebId" -WebUrl "MyWebUrl" -WebTitle "MyWebTitle" -PrimaryContact $ChangeWebContactByUrlSettingPrimaryContact -SecondaryContact $ChangeWebContactByUrlSettingPrimaryContact

$ChangeWebContactSubRequest = New-ChangeWebContactSubRequest -Id "MyId" -AssignTo $ApiMyGroupPrimaryContact -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -Reason "MyReason" -Status 0 -StatusDescription "MyStatusDescription" -ProgressStatus $ApiRequestProgressStatus -ContactChangeSettings $ChangeWebContactSubRequestContactChangeSettings

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeWebContactRequest = New-ChangeWebContactRequest -ChangedMethod $ChangeContactMethod -ChangedByUserSetting $ChangeSiteContactRequestChangeByUserSetting -ChangedByUrlItems $ChangeWebContactByUrlSetting -SubRequests $ChangeWebContactSubRequest -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeWebContactRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ChangeWebSettingRequest = $ChangeWebSettingRequestUrl = New-ChangeWebSettingRequestUrl -SiteUrl "MySiteUrl" -WebUrl "MyWebUrl" -SiteId "MySiteId" -WebId "MyWebId" -WebTitle "MyWebTitle"
$ChangeListSettingRequestListTitle = New-ChangeListSettingRequestListTitle -ChangeValue "MyChangeValue" -OriginalValue "MyOriginalValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ChangeWebSettingRequestChangedMetadata = New-ChangeWebSettingRequestChangedMetadata -ChangeValue $RequestMetadata -OriginalValue $RequestMetadata

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"
$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ChangeWebSettingRequest = New-ChangeWebSettingRequest -Url $ChangeWebSettingRequestUrl -ChangedTitle $ChangeListSettingRequestListTitle -ChangedDescription $ChangeListSettingRequestListTitle -ChangedMetadata $ChangeWebSettingRequestChangedMetadata -DeploymentPlanName "MyDeploymentPlanName" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ChangeWebSettingRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ClonePermissionRequest = $ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$ClonePermissionOption = New-ClonePermissionOption 
$ClonePermissionAdditionalOption = New-ClonePermissionAdditionalOption 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ClonePermissionRequest = New-ClonePermissionRequest -Urls "MyUrls" -SourceUser $ApiMyGroupPrimaryContact -TargetUser $ApiMyGroupPrimaryContact -CloneOption $ClonePermissionOption -AdditionalCloneOption $ClonePermissionAdditionalOption -EnabledRemoveExplicitPermission $false -EnabledRemoveUserFromSPGroup $false -EnabledDeleteUserPermission $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ClonePermissionRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ContentMoveRequest = $ContentMoveMethod = New-ContentMoveMethod 

$ItemConflictResolutionType = New-ItemConflictResolutionType 
$ContentMoveRequestCopySettings = New-ContentMoveRequestCopySettings -IsMigrateConfiguration $false -IsKeepLookAndFeel $false -ColumnsAndContentConflictResolution $ItemConflictResolutionType -IsMigrateSecurity $false -IsMigrateColumnsAndContentTypes $false -IsMigrateContent $false -IsMigrateContentIncludeListAttachment $false

$AzureAdMetadataSettingsOffice365Tenant = New-AzureAdMetadataSettingsOffice365Tenant -Id "MyId" -Name "MyName" -Description "MyDescription"
$ContentMoveCommonSettingProfileMappings = New-ContentMoveCommonSettingProfileMappings -ColumnMapping $AzureAdMetadataSettingsOffice365Tenant -ContentTypeMapping $AzureAdMetadataSettingsOffice365Tenant -UserMapping $AzureAdMetadataSettingsOffice365Tenant -LanguageMapping $AzureAdMetadataSettingsOffice365Tenant

$ContentMoveCommonSettingBackupSettings = New-ContentMoveCommonSettingBackupSettings -IsBackupSource $false -IsBackupDestination $false -StoragePolicy $AzureAdMetadataSettingsOffice365Tenant

$ConflictSolutionType = New-ConflictSolutionType 
$ContentMoveCommonSettingConflictResolutionSettings = New-ContentMoveCommonSettingConflictResolutionSettings -ContainerConflictSolution $ConflictSolutionType -IsCheckLowerObject $false -IsEnableContentConflictResolution $false -ContentConflictSolution $ConflictSolutionType -AppConflictSolution $ConflictSolutionType

$DeleteType = New-DeleteType 
$ContentMoveRequestCommonSettings = New-ContentMoveRequestCommonSettings -IsIncludeVersions $false -IsIncludeWorkflowDefinition $false -IsDisableInformationRightsManagement $false -IsPreserveNullColumnValues $false -IsKeepModifiedByAndModifiedTime $false -ProfileMappings $ContentMoveCommonSettingProfileMappings -BackupSettings $ContentMoveCommonSettingBackupSettings -ConflictResolutionSettings $ContentMoveCommonSettingConflictResolutionSettings -FilterPolicy $AzureAdMetadataSettingsOffice365Tenant -DeleteType $DeleteType -IsDeleteCheckedFiles $false

$NodeType = New-NodeType 
$ContentMoveSPObjectMappingSource = New-ContentMoveSPObjectMappingSource -SiteId "MySiteId" -SiteUrl "MySiteUrl" -Id "MyId" -Title "MyTitle" -FullUrl "MyFullUrl" -Type $NodeType

$ContentMoveAction = New-ContentMoveAction 
$ContentMoveSPObjectMapping = New-ContentMoveSPObjectMapping -Source $ContentMoveSPObjectMappingSource -Destination $ContentMoveSPObjectMappingSource -Action $ContentMoveAction

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ContentMoveRequest = New-ContentMoveRequest -Method $ContentMoveMethod -CopySettings $ContentMoveRequestCopySettings -MoveSettings $ContentMoveRequestCopySettings -CommonSettings $ContentMoveRequestCommonSettings -ObjectMappings $ContentMoveSPObjectMapping -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ContentMoveRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CreateGroupRequest = $CreateGroupType = New-CreateGroupType 

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$CreateGroupRequestLinks = New-CreateGroupRequestLinks -GroupSiteLink "MyGroupSiteLink" -GroupPlannerLink "MyGroupPlannerLink" -GroupFilesLink "MyGroupFilesLink" -GroupConversationsLink "MyGroupConversationsLink" -GroupNotebookLink "MyGroupNotebookLink" -YammerGroupLink "MyYammerGroupLink" -TeamLink "MyTeamLink"

$GroupLeasePeriodType = New-GroupLeasePeriodType 
$ApiDurationType = New-ApiDurationType 
$CreateGroupRequestLeasePeriodSettings = New-CreateGroupRequestLeasePeriodSettings -IsEnabled $false -LeaseType $GroupLeasePeriodType -DurationType $ApiDurationType -DurationInterval 0 -LeaseExpirationDate (Get-Date)

$GiphyRatingType = New-GiphyRatingType 
$CreateGroupRequestTeamsSettings = New-CreateGroupRequestTeamsSettings -AllowMembersCreateUpdateChannels $false -AllowMembersCreatePrivateChannels $false -AllowMemberDeleteRestoreChannels $false -AllowMembersAddRemoveApps $false -AllowMembersCreateUpdateRemoveTabs $false -AllowMembersCreateUpdateRemoveConnections $false -AllowMembersDeleteMessages $false -AllowMembersEditMessages $false -AllowGuestsCreateUpdateChannels $false -AllowGuestsDeleteChannels $false -AllowMentionsTeam $false -AllowMentionsChannel $false -EnableGiphy $false -EnableStickersAndMemes $false -EnableCustomMemes $false -GiphyRatingType $GiphyRatingType

$CreateGroupRequestPrimaryContact = New-CreateGroupRequestPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$CreateGroupRequestSecondaryContact = New-CreateGroupRequestSecondaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$TeamsTemplateSettingsSelectedTemplate = New-TeamsTemplateSettingsSelectedTemplate -Id "MyId" -Name "MyName" -Description "MyDescription"
$TeamsTemplateSettingsSelectedMSTemplate = New-TeamsTemplateSettingsSelectedMSTemplate -Id "MyId" -Name "MyName"
$TextModel = New-TextModel -Description "MyDescription" -Id "MyId" -Name "MyName"
$CreateGroupRequestTemplateSettings = New-CreateGroupRequestTemplateSettings -EnableCreateTeamFromScratch $false -EnableCreateTeamFromExistTeam $false -EnableCreateTeamFromTeamTemplate $false -SelectedTemplate $TeamsTemplateSettingsSelectedTemplate -SelectedMSTemplate $TeamsTemplateSettingsSelectedMSTemplate -TeamTemplates $TextModel -EnableCloneChannels $false -EnableCloneApps $false -EnableCloneTabs $false -EnableCloneMembers $false -EnableCloneTeamSetting $false -EnableCloneTeamPrivacy $false -EnableCloneTeamClassification $false

$LogicalOperator = New-LogicalOperator 
$CategoryType = New-CategoryType 
$DynamicRuleCondition = New-DynamicRuleCondition 

$AuthenticationType = New-AuthenticationType 
$InviteType = New-InviteType 
$PrincipalType = New-PrincipalType 
$UserInfo = New-UserInfo -IdentityName "MyIdentityName" -UserDisplayName "MyUserDisplayName" -DomainGroup $false -Department "MyDepartment" -MobilePhone "MyMobilePhone" -Manager "MyManager" -Permission "MyPermission" -IsDeleted $false -SecurityToken "MySecurityToken" -UserType 0 -AzureUserType "MyAzureUserType" -LegalPerson $false -AuthenticationType $AuthenticationType -AdminCenterUrl "MyAdminCenterUrl" -InviteType $InviteType -Type "MyType" -IsRegisteredAosGroup $false -IsExternalUser $ExternalUserType -IsAPIExceptional $false -TenantId "MyTenantId" -ObjectId "MyObjectId" -Version 0 -JobTitle "MyJobTitle" -UsageLocation "MyUsageLocation" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsOtherTenantUser $false -IsAccountEnabled $false -NetworkId "MyNetworkId" -IsValidateByProfile $false -ProxyAddresses "MyProxyAddresses" -PrincipalType $PrincipalType -Inviter "MyInviter" -CreatedTime (Get-Date) -LastModifiedTime (Get-Date) -SharePointLogonName "MySharePointLogonName" -Id 0 -DisplayName "MyDisplayName" -Title "MyTitle" -Email "MyEmail" -IsValid $false -ExistInAOS $false

$DynamicGroupRuleInfo = New-DynamicGroupRuleInfo -Id "MyId" -Order 0 -Relation $LogicalOperator -Category $CategoryType -MetadataId "MyMetadataId" -MetadataName "MyMetadataName" -MetadataValue "MyMetadataValue" -MetadataDisplayValue "MyMetadataDisplayValue" -MetadataValueAzureUserType "MyMetadataValueAzureUserType" -Condition $DynamicRuleCondition -DisableEditRule $false -DisableEditRuleValue $false -MetadataUserList $UserInfo

$CreateGroupRequestMultiGeoLocation = New-CreateGroupRequestMultiGeoLocation -Name "MyName" -DisplayName "MyDisplayName"

$ConvertHubSiteActionType = New-ConvertHubSiteActionType 
$CreateGroupRequestHubSiteSettings = New-CreateGroupRequestHubSiteSettings -Enabled $false -Action $ConvertHubSiteActionType -AssociatedHubSiteId "MyAssociatedHubSiteId" -AssociatedHubSiteTitle "MyAssociatedHubSiteTitle"

$CreateGroupRequestTimeZoneSettings = New-CreateGroupRequestTimeZoneSettings -Enabled $false -TimeZone 0
$CreateGroupRequestLocaleSettings = New-CreateGroupRequestLocaleSettings -Enabled $false -Locale 0
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$CreateGroupRequest = New-CreateGroupRequest -GroupType $CreateGroupType -GroupId "MyGroupId" -GroupIdWithoutPrefixSuffix "MyGroupIdWithoutPrefixSuffix" -GroupName "MyGroupName" -GroupNameWithoutPrefixSuffix "MyGroupNameWithoutPrefixSuffix" -GroupEmail "MyGroupEmail" -Policy "MyPolicy" -GroupDescription "MyGroupDescription" -Owners $ApiUser -Members $ApiUser -Privacy $false -Subscribe $false -OutsideSender $false -EnableTeamCollaboration $false -Language "MyLanguage" -Classification "MyClassification" -Sensitivity "MySensitivity" -SensitivityName "MySensitivityName" -Links $CreateGroupRequestLinks -LeasePeriodSettings $CreateGroupRequestLeasePeriodSettings -TeamsSettings $CreateGroupRequestTeamsSettings -AppliedSiteDesignId "MyAppliedSiteDesignId" -PrimaryContact $CreateGroupRequestPrimaryContact -SecondaryContact $CreateGroupRequestSecondaryContact -EnableGroupMembershipHidden $false -EnableAssignedMembership $false -EnableDynamicMembership $false -TemplateSettings $CreateGroupRequestTemplateSettings -DynamicMembershipRules $DynamicGroupRuleInfo -MultiGeoLocation $CreateGroupRequestMultiGeoLocation -HubSiteSettings $CreateGroupRequestHubSiteSettings -TimeZoneSettings $CreateGroupRequestTimeZoneSettings -LocaleSettings $CreateGroupRequestLocaleSettings -YammerGroupInfo "MyYammerGroupInfo" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # CreateGroupRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CreateGuestUserRequest = $ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$CreateGuestUserRequestUserProperties = New-CreateGuestUserRequestUserProperties -DisplayName "MyDisplayName" -FirstName "MyFirstName" -LastName "MyLastName" -UserName "MyUserName" -UsageLocation "MyUsageLocation" -UsageLocationDisplayName "MyUsageLocationDisplayName" -JobTitle "MyJobTitle" -JobDepartment "MyJobDepartment" -Manager $ApiMyGroupPrimaryContact -CompanyName "MyCompanyName"

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$OneTimeRenewalOption = New-OneTimeRenewalOption 
$ApiDurationType = New-ApiDurationType 
$CreateGuestUserRequestOneTimeSettings = New-CreateGuestUserRequestOneTimeSettings -Option $OneTimeRenewalOption -Duration 0 -DurationType $ApiDurationType -StartTime (Get-Date)

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ApiRequestProgressStatus = New-ApiRequestProgressStatus 
$CreateGuestUserSubRequest = New-CreateGuestUserSubRequest -Id "MyId" -UserProperties $CreateGuestUserRequestUserProperties -WelcomeEmailMessage "MyWelcomeEmailMessage" -PrimaryContact $ApiMyGroupPrimaryContact -SecondaryContact $ApiMyGroupPrimaryContact -InviteGroups $ApiUser -OneTimeSettings $CreateGuestUserRequestOneTimeSettings -Metadatas $RequestMetadata -ProcessStatus $ApiRequestProgressStatus -AssignTo $ApiUser -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date)

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"
$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$CreateGuestUserRequest = New-CreateGuestUserRequest -UserProperties $CreateGuestUserRequestUserProperties -WelcomeEmailMessage "MyWelcomeEmailMessage" -PrimaryContact $ApiMyGroupPrimaryContact -SecondaryContact $ApiMyGroupPrimaryContact -InviteGroups $ApiUser -OneTimeSettings $CreateGuestUserRequestOneTimeSettings -SubRequestInfos $CreateGuestUserSubRequest -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # CreateGuestUserRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CreateListRequest = $CreateListRequestParentObject = New-CreateListRequestParentObject -ParentUrl "MyParentUrl" -SiteUrl "MySiteUrl" -SiteId "MySiteId"
$ListType = New-ListType 

$CreateListRequestVersionSettings = New-CreateListRequestVersionSettings -ListType $ListType -EnableMajorVersions $false -EnableMajorAndMinorVersions $false -EnableMajorVersionLimit $false -MajorVersionLimit 0 -EnableMinorVersionLimit $false -MinorVersionsLimit 0 -RequireContentApproval $false

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$RequestUserWithPermissionsUser = New-RequestUserWithPermissionsUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$PermissionLevel = New-PermissionLevel -Id "MyId" -IdInSharePoint 0 -Name "MyName" -Description "MyDescription" -IsExcluded $false -Type 0 -IsCloudGovernanceCustomized $false
$RequestUserWithPermissions = New-RequestUserWithPermissions -User $RequestUserWithPermissionsUser -PermissionLevels $PermissionLevel

$GroupUser = New-GroupUser -IsEnforce $false -IsHide $false -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestGroupWithPermissionsGroupOwner = New-RequestGroupWithPermissionsGroupOwner -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$GroupOwnerType = New-GroupOwnerType 
$SharePointBuildInGroupType = New-SharePointBuildInGroupType 
$SPGroupViewOptionType = New-SPGroupViewOptionType 
$SPGroupEditOptionType = New-SPGroupEditOptionType 
$AssignBy = New-AssignBy 
$RequestGroupWithPermissions = New-RequestGroupWithPermissions -Name "MyName" -Description "MyDescription" -Users $GroupUser -PermissionLevels $PermissionLevel -GroupOwner $RequestGroupWithPermissionsGroupOwner -GroupOwnerType $GroupOwnerType -BuildInGroupType $SharePointBuildInGroupType -SpGroupViewType $SPGroupViewOptionType -SpGroupEditType $SPGroupEditOptionType -SpGroupEditOptionAssignBy $AssignBy -SpGroupViewOptionAssignBy $AssignBy

$CreateListRequestPermissionSettings = New-CreateListRequestPermissionSettings -StopInheritingPermissions $false -UserPermissions $RequestUserWithPermissions -GroupPermissions $RequestGroupWithPermissions

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$CreateListRequest = New-CreateListRequest -ListTitle "MyListTitle" -ListName "MyListName" -ListDescription "MyListDescription" -ParentObject $CreateListRequestParentObject -ListTemplate "MyListTemplate" -EnableNavigation $false -ListType $ListType -VersionSettings $CreateListRequestVersionSettings -PermissionSettings $CreateListRequestPermissionSettings -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # CreateListRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CreateSiteRequest = $CreateSiteRequestSiteUrl = New-CreateSiteRequestSiteUrl -Root "MyRoot" -ManagedPath "MyManagedPath" -Name "MyName"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$CreateSiteRequestPrimaryAdmin = New-CreateSiteRequestPrimaryAdmin -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$CreateSiteRequestPrimaryContact = New-CreateSiteRequestPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$CreateSiteRequestSecondaryContact = New-CreateSiteRequestSecondaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$CreateSiteRequestSiteDesign = New-CreateSiteRequestSiteDesign -Id "MyId" -Name "MyName"

$ConvertHubSiteActionType = New-ConvertHubSiteActionType 
$CreateSiteRequestHubSiteSettings = New-CreateSiteRequestHubSiteSettings -Enabled $false -Action $ConvertHubSiteActionType -AssociatedHubSiteId "MyAssociatedHubSiteId" -AssociatedHubSiteTitle "MyAssociatedHubSiteTitle"

$RequestUserWithPermissionsUser = New-RequestUserWithPermissionsUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$PermissionLevel = New-PermissionLevel -Id "MyId" -IdInSharePoint 0 -Name "MyName" -Description "MyDescription" -IsExcluded $false -Type 0 -IsCloudGovernanceCustomized $false
$RequestUserWithPermissions = New-RequestUserWithPermissions -User $RequestUserWithPermissionsUser -PermissionLevels $PermissionLevel

$GroupUser = New-GroupUser -IsEnforce $false -IsHide $false -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestGroupWithPermissionsGroupOwner = New-RequestGroupWithPermissionsGroupOwner -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$GroupOwnerType = New-GroupOwnerType 
$SharePointBuildInGroupType = New-SharePointBuildInGroupType 
$SPGroupViewOptionType = New-SPGroupViewOptionType 
$SPGroupEditOptionType = New-SPGroupEditOptionType 
$AssignBy = New-AssignBy 
$RequestGroupWithPermissions = New-RequestGroupWithPermissions -Name "MyName" -Description "MyDescription" -Users $GroupUser -PermissionLevels $PermissionLevel -GroupOwner $RequestGroupWithPermissionsGroupOwner -GroupOwnerType $GroupOwnerType -BuildInGroupType $SharePointBuildInGroupType -SpGroupViewType $SPGroupViewOptionType -SpGroupEditType $SPGroupEditOptionType -SpGroupEditOptionAssignBy $AssignBy -SpGroupViewOptionAssignBy $AssignBy

$YammerGroupType = New-YammerGroupType 
$YammerGroupJoinType = New-YammerGroupJoinType 
$CreateSiteRequestYammerGroupSettings = New-CreateSiteRequestYammerGroupSettings -NameOrId "MyNameOrId" -Description "MyDescription" -Type $YammerGroupType -JoinType $YammerGroupJoinType -IsListInDirectory $false -IsGroupAlreadyExisted $false

$ApiDurationType = New-ApiDurationType 
$CreateSiteRequestLeasePeriodSettings = New-CreateSiteRequestLeasePeriodSettings -LeaseInterval 0 -LeaseDurationType $ApiDurationType -LeaseWarningInterval 0 -LeaseWarningDurationType $ApiDurationType

$CreateSiteRequestMultiGeoLocation = New-CreateSiteRequestMultiGeoLocation -Name "MyName" -DisplayName "MyDisplayName"
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$CreateSiteRequest = New-CreateSiteRequest -SiteTitle "MySiteTitle" -SiteDescription "MySiteDescription" -SiteUrl $CreateSiteRequestSiteUrl -PolicyId "MyPolicyId" -TimeZone 0 -Language 0 -Template "MyTemplate" -DeploymentManagerPlanName "MyDeploymentManagerPlanName" -PrimaryAdmin $CreateSiteRequestPrimaryAdmin -AdditionalAdmins $ApiUser -PrimaryContact $CreateSiteRequestPrimaryContact -SecondaryContact $CreateSiteRequestSecondaryContact -SiteDesign $CreateSiteRequestSiteDesign -TeamSiteDesign "MyTeamSiteDesign" -Classification "MyClassification" -Sensitivity "MySensitivity" -HubSiteSettings $CreateSiteRequestHubSiteSettings -UserPermissions $RequestUserWithPermissions -GroupPermissions $RequestGroupWithPermissions -YammerGroupSettings $CreateSiteRequestYammerGroupSettings -LeasePeriodSettings $CreateSiteRequestLeasePeriodSettings -MultiGeoLocation $CreateSiteRequestMultiGeoLocation -InputTitle "MyInputTitle" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # CreateSiteRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CreateWebRequest = $CreateWebRequestWebLanguage = New-CreateWebRequestWebLanguage -Id 0 -Name "MyName" -Description "MyDescription"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestUserWithPermissionsUser = New-RequestUserWithPermissionsUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$PermissionLevel = New-PermissionLevel -Id "MyId" -IdInSharePoint 0 -Name "MyName" -Description "MyDescription" -IsExcluded $false -Type 0 -IsCloudGovernanceCustomized $false
$RequestUserWithPermissions = New-RequestUserWithPermissions -User $RequestUserWithPermissionsUser -PermissionLevels $PermissionLevel

$GroupUser = New-GroupUser -IsEnforce $false -IsHide $false -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestGroupWithPermissionsGroupOwner = New-RequestGroupWithPermissionsGroupOwner -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$GroupOwnerType = New-GroupOwnerType 
$SharePointBuildInGroupType = New-SharePointBuildInGroupType 
$SPGroupViewOptionType = New-SPGroupViewOptionType 
$SPGroupEditOptionType = New-SPGroupEditOptionType 
$AssignBy = New-AssignBy 
$RequestGroupWithPermissions = New-RequestGroupWithPermissions -Name "MyName" -Description "MyDescription" -Users $GroupUser -PermissionLevels $PermissionLevel -GroupOwner $RequestGroupWithPermissionsGroupOwner -GroupOwnerType $GroupOwnerType -BuildInGroupType $SharePointBuildInGroupType -SpGroupViewType $SPGroupViewOptionType -SpGroupEditType $SPGroupEditOptionType -SpGroupEditOptionAssignBy $AssignBy -SpGroupViewOptionAssignBy $AssignBy

$YammerGroupType = New-YammerGroupType 
$YammerGroupJoinType = New-YammerGroupJoinType 
$CreateWebRequestYammerGroupSettings = New-CreateWebRequestYammerGroupSettings -NameOrId "MyNameOrId" -Description "MyDescription" -Type $YammerGroupType -JoinType $YammerGroupJoinType -IsListInDirectory $false -IsGroupAlreadyExisted $false

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$CreateWebRequest = New-CreateWebRequest -WebName "MyWebName" -WebTitle "MyWebTitle" -WebDescription "MyWebDescription" -WebLanguage $CreateWebRequestWebLanguage -WebTemplate "MyWebTemplate" -ParentSiteUrl "MyParentSiteUrl" -ParentWebUrl "MyParentWebUrl" -PrimaryContact $ApiMyGroupPrimaryContact -SecondaryContact $ApiMyGroupPrimaryContact -UserPermissions $RequestUserWithPermissions -GroupPermissions $RequestGroupWithPermissions -YammerGroupSettings $CreateWebRequestYammerGroupSettings -IsOnQuickLaunch $false -IsOnTopLinkBar $false -IsInheritance $false -DeploymentManagerPlanName "MyDeploymentManagerPlanName" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # CreateWebRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ApiRequest = $QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ApiRequest = New-ApiRequest -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ApiRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$DeleteGroupRequest = $GroupObjectType = New-GroupObjectType 
$ServiceType = New-ServiceType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$DeleteGroupRequest = New-DeleteGroupRequest -WarningMessage "MyWarningMessage" -GroupId "MyGroupId" -GroupName "MyGroupName" -GroupEmail "MyGroupEmail" -GroupObjectType $GroupObjectType -LifecycleType $ServiceType -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # DeleteGroupRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$DeleteSiteRequest = $SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$DeleteSiteRequest = New-DeleteSiteRequest -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # DeleteSiteRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$DeleteWebLifecycleRequest = $WebLifecycleActionType = New-WebLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$DeleteWebLifecycleRequest = New-DeleteWebLifecycleRequest -Action $WebLifecycleActionType -WebId "MyWebId" -WebUrl "MyWebUrl" -WebRelativeUrl "MyWebRelativeUrl" -WebTitle "MyWebTitle" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -ActionDescription "MyActionDescription" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # DeleteWebLifecycleRequest |  (optional)

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
 **Id** | **String**|  | 
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

<a name="Edit-DynamicServiceRequest"></a>
# **Edit-DynamicServiceRequest**
> void Edit-DynamicServiceRequest<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DynamicRequest] <PSCustomObject><br>

edit dynamic service request

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
$DynamicRequest = $ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel = New-ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel -Id "MyId" -Name "MyName" -AllowGuestSharing $false -SiteSharing 0 -Privacy $false
$Gallerybase = New-Gallerybase -GalleryType "MyGalleryType" -GalleryInternalName "MyGalleryInternalName" -GalleryMetadata $RequestMetadata -IsTenantAllowGuest $false -RequestSensitivityLabel $ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel

$DynamicRequestApproveProcess = New-DynamicRequestApproveProcess -ApproveProcessId "MyApproveProcessId" -ActivityId "MyActivityId"
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"
$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$DynamicRequest = New-DynamicRequest -ActivityGalleries $Gallerybase -ApproveProcess $DynamicRequestApproveProcess -OrderInfo "MyOrderInfo" -ParentId "MyParentId" -ParentTicketNumber 0 -StartRequestTime (Get-Date) -WarningMessage "MyWarningMessage" -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # DynamicRequest |  (optional)

# edit dynamic service request
try {
     $Result = Edit-DynamicServiceRequest -Id $Id -DynamicRequest $DynamicRequest
} catch {
    Write-Host ("Exception occured when calling Edit-DynamicServiceRequest: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | **String**|  | 
 **DynamicRequest** | [**DynamicRequest**](DynamicRequest.md)|  | [optional] 

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ExtendGroupRequest = $ApiDurationType = New-ApiDurationType 
$GroupObjectType = New-GroupObjectType 
$ServiceType = New-ServiceType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ExtendGroupRequest = New-ExtendGroupRequest -ExtendDuration 0 -ExtendDurationType $ApiDurationType -GroupId "MyGroupId" -GroupName "MyGroupName" -GroupEmail "MyGroupEmail" -GroupObjectType $GroupObjectType -LifecycleType $ServiceType -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ExtendGroupRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ExtendSiteRequest = $ApiDurationType = New-ApiDurationType 
$SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ExtendSiteRequest = New-ExtendSiteRequest -ExtendDuration 0 -ExtendDurationType $ApiDurationType -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ExtendSiteRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$GrantPermissionRequest = $NodeType = New-NodeType 
$GrantPermissionRequestUrl = New-GrantPermissionRequestUrl -WebId "MyWebId" -SiteId "MySiteId" -WebServerRelativeUrl "MyWebServerRelativeUrl" -ListTitle "MyListTitle" -TopInheritUrl "MyTopInheritUrl" -InheritNodeType $NodeType -IsInheritedPermission $false -Id "MyId" -Title "MyTitle" -FullUrl "MyFullUrl" -Type $NodeType

$GrantPermissionRequestPermissionSettingsSelectedSPGroup = New-GrantPermissionRequestPermissionSettingsSelectedSPGroup -Id 0 -Name "MyName" -DisplayName "MyDisplayName" -PermissionIds "MyPermissionIds" -Description "MyDescription"
$IntModel = New-IntModel -Id 0 -Name "MyName" -Description "MyDescription"
$GrantPermissionRequestPermissionSettings = New-GrantPermissionRequestPermissionSettings -IsBreakInheritance $false -IsGrantPermissionDirectly $false -SelectedSPGroup $GrantPermissionRequestPermissionSettingsSelectedSPGroup -SelectedPermissionLevels $IntModel

$ExpirationType = New-ExpirationType 
$DurationDateType = New-DurationDateType 
$GrantPermissionRequestPermissionDurationSettings = New-GrantPermissionRequestPermissionDurationSettings -IsGrantTemporaryPermission $false -IsGrantPermissionLevel $false -ExpirationType $ExpirationType -DurationInterval 0 -DurationDateType $DurationDateType -StartTime (Get-Date) -EndTime (Get-Date)

$ApiUserType = New-ApiUserType 
$ExternalUserType = New-ExternalUserType 
$SharingEnabledUser = New-SharingEnabledUser -IsSharePointGroup $false -IsGuestUser $false -IsGuestUserExistsInOrganization $false -ApiUserType $ApiUserType -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  }

$ExternalUserSharingType = New-ExternalUserSharingType 

$AnnoymouslinkPermissions = New-AnnoymouslinkPermissions 
$ExternalUserSharingSettingsAnonymousLinkSettings = New-ExternalUserSharingSettingsAnonymousLinkSettings -Permisssion $AnnoymouslinkPermissions -ExpirationDate (Get-Date)

$GrantPermissionRequestExternalUserSharingSettings = New-GrantPermissionRequestExternalUserSharingSettings -Enabled $false -SharingType $ExternalUserSharingType -AnonymousLinkSettings $ExternalUserSharingSettingsAnonymousLinkSettings

$GrantPermissionModelWelcomeEmailSettings = New-GrantPermissionModelWelcomeEmailSettings -Enabled $false -Subject "MySubject" -PersonalMessage "MyPersonalMessage" -EnabledSendEmailInService $false -WelcomeEmailTemplateId "MyWelcomeEmailTemplateId" -IsWelcomeEmailTemplate $false
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$GrantPermissionRequest = New-GrantPermissionRequest -Url $GrantPermissionRequestUrl -PermissionSettings $GrantPermissionRequestPermissionSettings -PermissionDurationSettings $GrantPermissionRequestPermissionDurationSettings -SelectedUsers $SharingEnabledUser -ExternalUserSharingSettings $GrantPermissionRequestExternalUserSharingSettings -WelcomeEmailSettings $GrantPermissionModelWelcomeEmailSettings -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # GrantPermissionRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$LockSiteRequest = $SiteLockType = New-SiteLockType 
$SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$LockSiteRequest = New-LockSiteRequest -LockType $SiteLockType -LockTypeDescription "MyLockTypeDescription" -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # LockSiteRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$ManagePermissionRequest = $NodeType = New-NodeType 

$ChangeListSettingRequestListTitle = New-ChangeListSettingRequestListTitle -ChangeValue "MyChangeValue" -OriginalValue "MyOriginalValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$ManagePermissionAction = New-ManagePermissionAction 
$SPUserManagementModel = New-SPUserManagementModel -IdentityName "MyIdentityName" -DisplayName "MyDisplayName" -IsGroup $false -AzureUserType "MyAzureUserType" -Action $ManagePermissionAction -ExternalUserType $ExternalUserType -Email "MyEmail"

$SPGroupViewOption = New-SPGroupViewOption 
$SPGroupEditOption = New-SPGroupEditOption 
$SPGroupManagementModel = New-SPGroupManagementModel -Id 0 -Name $ChangeListSettingRequestListTitle -Description "MyDescription" -Owner $ApiMyGroupPrimaryContact -Members $SPUserManagementModel -SpGroupViewType $SPGroupViewOption -SpGroupEditType $SPGroupEditOption -Permissions "MyPermissions" -Action $ManagePermissionAction -IsAllowJoinOrLeaveRequest $false -IsAutoAcceptRequest $false -SendMembershipRequestEmailAddress "MySendMembershipRequestEmailAddress" -IsTemporaryGroup $false -RoleID "MyRoleID" -IsEnabelSPMemberWelcomeEmail $false -SpMemberWelcomeEmailTemplateId "MySpMemberWelcomeEmailTemplateId"

$SPPrincipalType = New-SPPrincipalType 

$SharingEnabledUser = New-SharingEnabledUser -IsSharePointGroup $false -IsGuestUser $false -IsGuestUserExistsInOrganization $false -ApiUserType $ApiUserType -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  }

$ExpirationType = New-ExpirationType 
$ApiDurationType = New-ApiDurationType 
$GrantPermissionModelPermissionDurationSettings = New-GrantPermissionModelPermissionDurationSettings -IsGrantTemporaryPermission $false -IsGrantAdminGroup $false -ExpirationType $ExpirationType -DurationInterval 0 -DurationDateType $ApiDurationType -StartTime (Get-Date) -EndTime (Get-Date) -TempPermissionGroupIdentity "MyTempPermissionGroupIdentity"

$GrantPermissionModelWelcomeEmailSettings = New-GrantPermissionModelWelcomeEmailSettings -Enabled $false -Subject "MySubject" -PersonalMessage "MyPersonalMessage" -EnabledSendEmailInService $false -WelcomeEmailTemplateId "MyWelcomeEmailTemplateId" -IsWelcomeEmailTemplate $false
$ObjectPermissionManagementModelGrantPermissionSetting = New-ObjectPermissionManagementModelGrantPermissionSetting -PermissionDurationSettings $GrantPermissionModelPermissionDurationSettings -WelcomeEmailSettings $GrantPermissionModelWelcomeEmailSettings

$ObjectPermissionManagementModel = New-ObjectPermissionManagementModel -ObjectType $SPPrincipalType -ObjectInfo $ApiMyGroupPrimaryContact -Action $ManagePermissionAction -Permissions "MyPermissions" -OriginalPermissions "MyOriginalPermissions" -ExternalUserType $ExternalUserType -Members $SharingEnabledUser -GrantPermissionSetting $ObjectPermissionManagementModelGrantPermissionSetting -OriginalName "MyOriginalName"

$ManagePermissionRequestPermissionManagement = New-ManagePermissionRequestPermissionManagement -IsUniquePermission $false -IsPermissionInheritanceChanged $false -IsCopyPermissionsFromParent $false -InheritedSiteUrl "MyInheritedSiteUrl" -PermissionItems $ObjectPermissionManagementModel

$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$ManagePermissionRequest = New-ManagePermissionRequest -ObjectUrl "MyObjectUrl" -ObjectType $NodeType -ObjectTitle "MyObjectTitle" -SiteUrl "MySiteUrl" -WebUrl "MyWebUrl" -SpGroupManagement $SPGroupManagementModel -PermissionManagement $ManagePermissionRequestPermissionManagement -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # ManagePermissionRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$RestoreGroupRequest = $GroupObjectType = New-GroupObjectType 
$ServiceType = New-ServiceType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$RestoreGroupRequest = New-RestoreGroupRequest -GroupId "MyGroupId" -GroupName "MyGroupName" -GroupEmail "MyGroupEmail" -GroupObjectType $GroupObjectType -LifecycleType $ServiceType -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # RestoreGroupRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$UnlockSiteRequest = $ApiDurationType = New-ApiDurationType 
$SiteLifecycleActionType = New-SiteLifecycleActionType 
$QuestionAnswerResponse = New-QuestionAnswerResponse -Question "MyQuestion" -Value "MyValue"

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$ServiceType = New-ServiceType 
$RequestStatus = New-RequestStatus 
$RequestResourceType = New-RequestResourceType 
$SubRequestType = New-SubRequestType 
$UnlockSiteRequest = New-UnlockSiteRequest -ExtendDuration 0 -ExtendDurationType $ApiDurationType -Action $SiteLifecycleActionType -ActionDescription "MyActionDescription" -SiteId "MySiteId" -SiteUrl "MySiteUrl" -SiteTitle "MySiteTitle" -GenerateFromRenewal $false -GenerateFromElection $false -Id "MyId" -ServiceId "MyServiceId" -Summary "MySummary" -NotesToApprovers "MyNotesToApprovers" -QuestionnaireId "MyQuestionnaireId" -QuestionnaireResponse $QuestionAnswerResponse -Metadatas $RequestMetadata -TicketNumber 0 -Type $ServiceType -TypeDescription "MyTypeDescription" -Requester "MyRequester" -RequesterLoginName "MyRequesterLoginName" -Status $RequestStatus -ProgressStatus 0 -ProgressStatusDescription "MyProgressStatusDescription" -SubmittedTime (Get-Date) -LastUpdated (Get-Date) -CreatedTime (Get-Date) -HasSubRequest $false -IsEnabledPassback $false -RequestResourceType $RequestResourceType -ModifiedBy "MyModifiedBy" -ModifiedByDisplayName "MyModifiedByDisplayName" -ModifiedDate (Get-Date) -AssignTo "MyAssignTo" -FullPath "MyFullPath" -ApprovalStageName "MyApprovalStageName" -Participants "MyParticipants" -ObjectID "MyObjectID" -CreatedSource 0 -SubRequestType $SubRequestType # UnlockSiteRequest |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>

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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 

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
 **Id** | **String**|  | 

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



$TaskApprovalStatus = "0" # TaskApprovalStatus | 
$Filter = "MyFilter" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId, isEnabledPassback (optional)
$Orderby = "MyOrderby" # String | Order by one field, supported fields:<br/> id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId, isEnabledPassback (optional)
$Search = "MySearch" # String | Search for title (optional)
$Top = 56 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional)
$Skip = "MySkip" # String |  Define the number of records you want to skip, default value is 0 (optional)
$Nexttoken = "MyNexttoken" # String |  Use the next token to get the next paging result (optional)

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
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId, isEnabledPassback | [optional] 
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, title, requester, requestId, requestTicketNumber, requesterDisplayName, requesterEmail, dueDate, serviceType, createdTime, taskType, status, taskFullPath, lastUpdated, category, serviceName, objectId, profileId, allowEdit, progressStatus, batchId, isEnabledPassback | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Batchid] <String><br>

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



$Batchid = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 

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
 **Batchid** | **String**|  | 

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>

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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 

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
 **Id** | **String**|  | 

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$User = "MyUser" # String | 

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsPassbackEnabled] <System.Nullable[Boolean]><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$IsPassbackEnabled = $true # Boolean |  (optional) (default to $false)
$CommentsParam = $CommentsParam = New-CommentsParam -Comments "MyComments" # CommentsParam |  (optional)

# reject task
try {
     $Result = Deny-Task -Id $Id -IsPassbackEnabled $IsPassbackEnabled -CommentsParam $CommentsParam
} catch {
    Write-Host ("Exception occured when calling Deny-Task: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | **String**|  | 
 **IsPassbackEnabled** | **Boolean**|  | [optional] [default to $false]
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CommentsParam = $CommentsParam = New-CommentsParam -Comments "MyComments" # CommentsParam |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String | 
$CommentsParam = $CommentsParam = New-CommentsParam -Comments "MyComments" # CommentsParam |  (optional)

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
 **Id** | **String**|  | 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
$CommentsParam = $CommentsParam = New-CommentsParam -Comments "MyComments" # CommentsParam |  (optional)

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
 **Id** | **String**|  | [optional] 
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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>
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



$Id = "38400000-8cf0-11bd-b23e-10b96e4ef00d" # String |  (optional)
$CommentsParam = $CommentsParam = New-CommentsParam -Comments "MyComments" # CommentsParam |  (optional)

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
 **Id** | **String**|  | [optional] 
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



$AutoTaskExtendRequest = $LifecycleAction = New-LifecycleAction 
$ApiDurationType = New-ApiDurationType 

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$AutoTaskExtendRequestComments = New-AutoTaskExtendRequestComments -Comments "MyComments"
$AutoTaskExtendRequest = New-AutoTaskExtendRequest -Action $LifecycleAction -ExtendDuration 0 -ExtendDurationType $ApiDurationType -TaskId "MyTaskId" -Metadatas $RequestMetadata -Comments $AutoTaskExtendRequestComments # AutoTaskExtendRequest |  (optional)

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



$AutoTaskExtendRequest = $LifecycleAction = New-LifecycleAction 
$ApiDurationType = New-ApiDurationType 

$ExternalUserType = New-ExternalUserType 
$ApiUserType = New-ApiUserType 
$LookupValueTargetUser = New-LookupValueTargetUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataUpsOrAzureAdValue = New-RequestMetadataUpsOrAzureAdValue -Tenant "MyTenant" -Property "MyProperty" -ExtensionAttribute "MyExtensionAttribute" -TargetUser $LookupValueTargetUser -UserPropertyValue "MyUserPropertyValue" -UserPropertyDisplayValue "MyUserPropertyDisplayValue" -RoleValue "MyRoleValue"

$TermsValueTermStore = New-TermsValueTermStore -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermGroup = New-TermsValueTermGroup -Id "MyId" -Name "MyName" -Description "MyDescription"
$TermsValueTermSet = New-TermsValueTermSet -Id "MyId" -Name "MyName" -Description "MyDescription"
$GuidModel = New-GuidModel -Id "MyId" -Name "MyName" -Description "MyDescription"
$RequestMetadataTermsValue = New-RequestMetadataTermsValue -TermStore $TermsValueTermStore -TermGroup $TermsValueTermGroup -TermSet $TermsValueTermSet -Value $GuidModel

$ApiUser = New-ApiUser -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$RequestMetadataLinkValue = New-RequestMetadataLinkValue -Title "MyTitle" -Address "MyAddress"
$RequestMetadataLookupListValue = New-RequestMetadataLookupListValue -ColumnType "MyColumnType" -ColumnName "MyColumnName" -Value "MyValue" -DisplayValue "MyDisplayValue"
$MetadataFieldType = New-MetadataFieldType 
$MetadataActionType = New-MetadataActionType 
$RequestMetadata = New-RequestMetadata -Id "MyId" -Name "MyName" -DisplayName "MyDisplayName" -BooleanValue $false -SingleLineOrMultipleLineValue "MySingleLineOrMultipleLineValue" -UpsOrAzureAdValue $RequestMetadataUpsOrAzureAdValue -TermsValue $RequestMetadataTermsValue -UserValue $ApiUser -LinkValue $RequestMetadataLinkValue -ChoiceValue "MyChoiceValue" -LookupListValue $RequestMetadataLookupListValue -Type $MetadataFieldType -ValueString "MyValueString" -ValueDisplayString "MyValueDisplayString" -Value "MyValue" -Action $MetadataActionType -AllowReferenceAsRoleInApprovalProcess $false -AllowBusinessUserToInputSingleValue $false -ActivityId "MyActivityId"

$AutoTaskExtendRequestComments = New-AutoTaskExtendRequestComments -Comments "MyComments"
$AutoTaskExtendRequest = New-AutoTaskExtendRequest -Action $LifecycleAction -ExtendDuration 0 -ExtendDurationType $ApiDurationType -TaskId "MyTaskId" -Metadatas $RequestMetadata -Comments $AutoTaskExtendRequestComments # AutoTaskExtendRequest |  (optional)

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

