# Cloud.Governance.Client.Cloud.Governance.Client\Api.PoliciesAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-CreateGroupPolicy**](PoliciesAdminApi.md#Invoke-CreateGroupPolicy) | **POST** /admin/policies/group | create group policy
[**Invoke-CreateSitePolicy**](PoliciesAdminApi.md#Invoke-CreateSitePolicy) | **POST** /admin/policies/site | create site collection policy
[**Invoke-DeleteSelectedPolicies**](PoliciesAdminApi.md#Invoke-DeleteSelectedPolicies) | **DELETE** /admin/policies | remove selected approval processes
[**Get-ActivePolicies**](PoliciesAdminApi.md#Get-ActivePolicies) | **GET** /admin/policies/active/{type} | get active policies
[**Get-ChangePolicyScope**](PoliciesAdminApi.md#Get-ChangePolicyScope) | **GET** /admin/policies/scope/{type} | get change policy scope
[**Get-GroupPolicySettings**](PoliciesAdminApi.md#Get-GroupPolicySettings) | **GET** /admin/policies/group/{id} | get edit group policy setting
[**Get-Policies**](PoliciesAdminApi.md#Get-Policies) | **GET** /admin/policies | get all policies
[**Get-PolicyFilters**](PoliciesAdminApi.md#Get-PolicyFilters) | **GET** /admin/policies/filters | get filters of policy
[**Get-SitePolicySettings**](PoliciesAdminApi.md#Get-SitePolicySettings) | **GET** /admin/policies/site/{id} | get edit site collection policy setting
[**Update-GroupPolicy**](PoliciesAdminApi.md#Update-GroupPolicy) | **PUT** /admin/policies/group | update group policy
[**Update-SelectedPoliciesStatus**](PoliciesAdminApi.md#Update-SelectedPoliciesStatus) | **PATCH** /admin/policies/status/{status} | update the status of selected approval processes
[**Update-SitePolicy**](PoliciesAdminApi.md#Update-SitePolicy) | **PUT** /admin/policies/site | update site collection policy


<a name="Invoke-CreateGroupPolicy"></a>
# **Invoke-CreateGroupPolicy**
> void Invoke-CreateGroupPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupPolicyModel] <PSCustomObject><br>

create group policy

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



$GroupPolicyModel = (New-GroupPolicyModel -IsOverwriteLifecycleStartTime $false  -QuotaSize 123  -SharingSettings (New-GroupSharingSetting -EnableManageGroupSharing $false  -EnableInviteGuestUser $false  -EnableManageSiteSharing $false  -SiteSharingType (New-GroupSiteSharingCapabilities))  -LifecycleSettings (New-GroupPolicyLifecycleSetting -DefaultProcess (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -Deletion (New-DeleteGroupSetting -EnableNotify $false  -NotifyUsers @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -EmailTemplate (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -Extension (New-ExtendGroupSetting -ExtendType (New-ExtendType)  -ConstantDuration 123  -ConstantDurationType (New-ApiDurationType)  -MaxDuration 123  -MaxDurationType (New-ApiDurationType)  -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -ChangePolicy (New-ChangeGroupSetting -IsDefineChangeToPolicies $false  -SelectedPoliciesForChangePolicy @((New-ChangePolicyScopeModel -Title "Title_example"  -Description "Description_example"  -Id "TODO"  -Category "Category_example"  -CategoryDisplayName "CategoryDisplayName_example"  -Details "Details_example"  -Type 123  -Owner "Owner_example"  -FarmID "TODO"  -OnlineType 123))  -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Quota (New-ChangeGroupQuotaSetting -ChangeOption (New-ChangeQuotaType)  -MaxValue 123  -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -TeamArchive (New-GroupLifecycleSetting -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -TeamUnArchive (New-GroupLifecycleSetting -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false))  -InactivityThresholdSettings (New-GroupThresholdSetting -Enabled $false  -Duration 123  -DurationType   -ThresholdApprovalProcess   -EnableWarning $false  -WarningProfile   -EnableAdditionalAction $false  -AdditionalActionType (New-AdditionalActionType)  -DeleteGroupDuration 123  -DeleteDurationType   -EnableDeleteRemind $false  -DeleteGroupReminder   -EnableDeleteNotify $false  -DeleteNotifyUsers @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -DeleteNotifyEmail   -ArchiveGroupDuration 123  -ArchiveGroupDurationType   -EnableArchiveRemind $false  -ArchiveGroupReminder   -EnableArchiveNotify $false  -ArchiveNotifyUsers @()  -ArchiveNotifyEmail )  -LeaseThresholdSettings (New-GroupThresholdSetting -Enabled $false  -Duration 123  -DurationType   -ThresholdApprovalProcess   -EnableWarning $false  -WarningProfile   -EnableAdditionalAction $false  -AdditionalActionType (New-AdditionalActionType)  -DeleteGroupDuration 123  -DeleteDurationType   -EnableDeleteRemind $false  -DeleteGroupReminder   -EnableDeleteNotify $false  -DeleteNotifyUsers @()  -DeleteNotifyEmail   -ArchiveGroupDuration 123  -ArchiveGroupDurationType   -EnableArchiveRemind $false  -ArchiveGroupReminder   -EnableArchiveNotify $false  -ArchiveNotifyUsers @()  -ArchiveNotifyEmail )  -QuotaThresholdSettings (New-GroupQuotaThresholdSetting -Enabled $false  -Percentage 123  -NotifiedUsers @())  -RecertificationSettings (New-PolicyRecertificationSetting -IsEnabled $false  -ProfileId "TODO")  -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Category "Category_example"  -TenantId "TODO"  -Status (New-CommonStatus)) # GroupPolicyModel |  (optional)

# create group policy
try {
    Invoke-CreateGroupPolicy -GroupPolicyModel $GroupPolicyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **GroupPolicyModel** | [**GroupPolicyModel**](GroupPolicyModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-CreateSitePolicy"></a>
# **Invoke-CreateSitePolicy**
> void Invoke-CreateSitePolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SitePolicyModel] <PSCustomObject><br>

create site collection policy

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



$SitePolicyModel = (New-SitePolicyModel -ServerResourceQuota 123  -StorageQuota 123  -SharingSetting (New-SitePolicySharingSetting -IsEnabled $false  -SharingCapabilities (New-SharingCapabilities)  -MembersCanShare $false  -AllowMembersEditMembership $false  -AllowAccessRequests $false  -RequestAccessEmail "RequestAccessEmail_example"  -AccessRequestType (New-AccessRequestType)  -AccessRequestMessage "AccessRequestMessage_example")  -IsDesignerEnabled $false  -SiteMaxDepth 123  -SiteMaxDepthType 123  -IsDisplayPolicyIcon $false  -PolicyIconAddress "PolicyIconAddress_example"  -PolicyDetailReferenceURL "PolicyDetailReferenceURL_example"  -AosSettings (New-SitePolicyAosSetting -IsPolicyEnforcerEnabled $false  -PolicyEnforcerProfile "PolicyEnforcerProfile_example"  -IsDpmEnabled $false  -DpmPlan "DpmPlan_example"  -IsBackupEnabled $false  -IsAuditingEnabled $false  -IsArchiveEnabled $false  -ArchiveProfile "ArchiveProfile_example"  -ArchiveApprovalProcess )  -LifecycleSettings (New-SitePolicyLifecycleSetting -Archive (New-SiteArchiveLifecycleItem -Profile "Profile_example"  -IsNotifyEnabled $false  -NotifyUser @()  -NotifyTemplate   -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Deletion (New-SiteDeletionLifecycleItem -IsPermanentlyDelete $false  -IsNotifyEnabled $false  -NotifyUser @()  -NotifyTemplate   -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Extension (New-SiteExtensionLifecycleItem -Type (New-PolicyExtensionType)  -Duration 123  -DurationType (New-DurationType)  -ExtendBasedOnPoint (New-ExtendBasedOnPoint)  -IsEnabled $false  -IsDefaultProcess $false  -Process )  -ChangePolicy (New-SiteChangePolicyLifecycleItem -IsDefineChangeToPolicies $false  -SelectedPoliciesForChangePolicy @((New-ChangePolicyScopeModel -Title "Title_example"  -Description "Description_example"  -Id "TODO"  -Category "Category_example"  -CategoryDisplayName "CategoryDisplayName_example"  -Details "Details_example"  -Type 123  -Owner "Owner_example"  -FarmID "TODO"  -OnlineType 123))  -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Unlock (New-SiteUnlockingLifecycleItem -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Lock (New-SiteLockLifecycleItem -LockType (New-SiteLockType)  -IsNotifyEnabled $false  -NotifyUser @()  -NotifyTemplate   -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Quota (New-SiteQuotaLifecycleItem -Option (New-QuotaOption)  -Size 123)  -DefaultProcess )  -RecertificationSettings (New-PolicyRecertificationSetting -IsEnabled $false  -ProfileId "TODO")  -InactivitySettings (New-SitePolicyExpirationSetting -IsEnabled $false  -Duration 123  -DurationType (New-DurationType)  -Process   -IsAutoLockEnabled $false  -AutoLockProfile   -IsNotifyEnabled $false  -NotifyTemplate )  -LeasePeriodSettings (New-SitePolicyExpirationSetting -IsEnabled $false  -Duration 123  -DurationType   -Process   -IsAutoLockEnabled $false  -AutoLockProfile   -IsNotifyEnabled $false  -NotifyTemplate )  -ElectionSettings (New-SitePolicyElectionSetting -IsEnabled $false  -EnableOnlyOtherContactElection $false  -ExcludeUsers @()  -IsNotifyTaskEnabled $false  -TaskEmailTemplate   -IsNotifyPrimaryContactEnabled $false  -NotifyPrimaryContactTemplate   -IsNotifySecondaryContactEnabled $false  -NotifySecondaryContactTemplate   -Duration 123  -DurationType 123  -IsReminderEnabled $false  -ReminderProfile )  -IsOverwriteLifecycleStartTime $false  -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Category "Category_example"  -TenantId "TODO"  -Status (New-CommonStatus)) # SitePolicyModel |  (optional)

# create site collection policy
try {
    Invoke-CreateSitePolicy -SitePolicyModel $SitePolicyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SitePolicyModel** | [**SitePolicyModel**](SitePolicyModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteSelectedPolicies"></a>
# **Invoke-DeleteSelectedPolicies**
> void Invoke-DeleteSelectedPolicies<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

remove selected approval processes

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



$UUID = @("TODO") # UUID[] |  (optional)

# remove selected approval processes
try {
    Invoke-DeleteSelectedPolicies -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ActivePolicies"></a>
# **Get-ActivePolicies**
> StringModel[] Get-ActivePolicies<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Type] <PSCustomObject><br>

get active policies

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



$Type = (New-PolicyType) # PolicyType |  (default to null)

# get active policies
try {
    $Result = Get-ActivePolicies -Type $Type
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Type** | [**PolicyType**](PolicyType.md)|  | [default to null]

### Return type

[**StringModel[]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePolicyScope"></a>
# **Get-ChangePolicyScope**
> ChangePolicyScopeModel[] Get-ChangePolicyScope<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Type] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TenantId] <String><br>

get change policy scope

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



$Type = (New-PolicyType) # PolicyType |  (default to null)
$TenantId = "TenantId_example" # String |  (optional) (default to null)

# get change policy scope
try {
    $Result = Get-ChangePolicyScope -Type $Type -TenantId $TenantId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Type** | [**PolicyType**](PolicyType.md)|  | [default to null]
 **TenantId** | **String**|  | [optional] [default to null]

### Return type

[**ChangePolicyScopeModel[]**](ChangePolicyScopeModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPolicySettings"></a>
# **Get-GroupPolicySettings**
> GroupPolicyModel Get-GroupPolicySettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get edit group policy setting

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



$Id = TODO # UUID |  (default to null)

# get edit group policy setting
try {
    $Result = Get-GroupPolicySettings -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**GroupPolicyModel**](GroupPolicyModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Policies"></a>
# **Get-Policies**
> PolicyGridModelPageResult Get-Policies<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all policies

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, type, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, type, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all policies
try {
    $Result = Get-Policies -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, type, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, type, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**PolicyGridModelPageResult**](PolicyGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-PolicyFilters"></a>
# **Get-PolicyFilters**
> DistinctPageResult Get-PolicyFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get filters of policy

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, type, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, name, type, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get filters of policy
try {
    $Result = Get-PolicyFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, type, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, type, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
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

<a name="Get-SitePolicySettings"></a>
# **Get-SitePolicySettings**
> SitePolicyModel Get-SitePolicySettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get edit site collection policy setting

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



$Id = TODO # UUID |  (default to null)

# get edit site collection policy setting
try {
    $Result = Get-SitePolicySettings -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**SitePolicyModel**](SitePolicyModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-GroupPolicy"></a>
# **Update-GroupPolicy**
> void Update-GroupPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupPolicyModel] <PSCustomObject><br>

update group policy

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



$GroupPolicyModel = (New-GroupPolicyModel -IsOverwriteLifecycleStartTime $false  -QuotaSize 123  -SharingSettings (New-GroupSharingSetting -EnableManageGroupSharing $false  -EnableInviteGuestUser $false  -EnableManageSiteSharing $false  -SiteSharingType (New-GroupSiteSharingCapabilities))  -LifecycleSettings (New-GroupPolicyLifecycleSetting -DefaultProcess   -Deletion (New-DeleteGroupSetting -EnableNotify $false  -NotifyUsers @()  -EmailTemplate   -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -Extension (New-ExtendGroupSetting -ExtendType (New-ExtendType)  -ConstantDuration 123  -ConstantDurationType   -MaxDuration 123  -MaxDurationType   -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -ChangePolicy (New-ChangeGroupSetting -IsDefineChangeToPolicies $false  -SelectedPoliciesForChangePolicy @()  -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Quota (New-ChangeGroupQuotaSetting -ChangeOption (New-ChangeQuotaType)  -MaxValue 123  -Enabled $false  -ApprovalProcess   -IsUsedDefaultProcess $false)  -TeamArchive   -TeamUnArchive )  -InactivityThresholdSettings   -LeaseThresholdSettings   -QuotaThresholdSettings (New-GroupQuotaThresholdSetting -Enabled $false  -Percentage 123  -NotifiedUsers @())  -RecertificationSettings   -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Category "Category_example"  -TenantId "TODO"  -Status ) # GroupPolicyModel |  (optional)

# update group policy
try {
    Update-GroupPolicy -GroupPolicyModel $GroupPolicyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **GroupPolicyModel** | [**GroupPolicyModel**](GroupPolicyModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-SelectedPoliciesStatus"></a>
# **Update-SelectedPoliciesStatus**
> void Update-SelectedPoliciesStatus<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Status] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

update the status of selected approval processes

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



$Status =  # CommonStatus |  (default to null)
$UUID = @("TODO") # UUID[] |  (optional)

# update the status of selected approval processes
try {
    Update-SelectedPoliciesStatus -Status $Status -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Status** | [**CommonStatus**](CommonStatus.md)|  | [default to null]
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-SitePolicy"></a>
# **Update-SitePolicy**
> void Update-SitePolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SitePolicyModel] <PSCustomObject><br>

update site collection policy

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



$SitePolicyModel = (New-SitePolicyModel -ServerResourceQuota 123  -StorageQuota 123  -SharingSetting (New-SitePolicySharingSetting -IsEnabled $false  -SharingCapabilities (New-SharingCapabilities)  -MembersCanShare $false  -AllowMembersEditMembership $false  -AllowAccessRequests $false  -RequestAccessEmail "RequestAccessEmail_example"  -AccessRequestType (New-AccessRequestType)  -AccessRequestMessage "AccessRequestMessage_example")  -IsDesignerEnabled $false  -SiteMaxDepth 123  -SiteMaxDepthType 123  -IsDisplayPolicyIcon $false  -PolicyIconAddress "PolicyIconAddress_example"  -PolicyDetailReferenceURL "PolicyDetailReferenceURL_example"  -AosSettings (New-SitePolicyAosSetting -IsPolicyEnforcerEnabled $false  -PolicyEnforcerProfile "PolicyEnforcerProfile_example"  -IsDpmEnabled $false  -DpmPlan "DpmPlan_example"  -IsBackupEnabled $false  -IsAuditingEnabled $false  -IsArchiveEnabled $false  -ArchiveProfile "ArchiveProfile_example"  -ArchiveApprovalProcess )  -LifecycleSettings (New-SitePolicyLifecycleSetting -Archive (New-SiteArchiveLifecycleItem -Profile "Profile_example"  -IsNotifyEnabled $false  -NotifyUser @()  -NotifyTemplate   -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Deletion (New-SiteDeletionLifecycleItem -IsPermanentlyDelete $false  -IsNotifyEnabled $false  -NotifyUser @()  -NotifyTemplate   -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Extension (New-SiteExtensionLifecycleItem -Type (New-PolicyExtensionType)  -Duration 123  -DurationType   -ExtendBasedOnPoint (New-ExtendBasedOnPoint)  -IsEnabled $false  -IsDefaultProcess $false  -Process )  -ChangePolicy (New-SiteChangePolicyLifecycleItem -IsDefineChangeToPolicies $false  -SelectedPoliciesForChangePolicy @()  -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Unlock (New-SiteUnlockingLifecycleItem -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Lock (New-SiteLockLifecycleItem -LockType (New-SiteLockType)  -IsNotifyEnabled $false  -NotifyUser @()  -NotifyTemplate   -IsEnabled $false  -IsDefaultProcess $false  -Process )  -Quota (New-SiteQuotaLifecycleItem -Option (New-QuotaOption)  -Size 123)  -DefaultProcess )  -RecertificationSettings   -InactivitySettings   -LeasePeriodSettings   -ElectionSettings (New-SitePolicyElectionSetting -IsEnabled $false  -EnableOnlyOtherContactElection $false  -ExcludeUsers @()  -IsNotifyTaskEnabled $false  -TaskEmailTemplate   -IsNotifyPrimaryContactEnabled $false  -NotifyPrimaryContactTemplate   -IsNotifySecondaryContactEnabled $false  -NotifySecondaryContactTemplate   -Duration 123  -DurationType 123  -IsReminderEnabled $false  -ReminderProfile )  -IsOverwriteLifecycleStartTime $false  -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Category "Category_example"  -TenantId "TODO"  -Status ) # SitePolicyModel |  (optional)

# update site collection policy
try {
    Update-SitePolicy -SitePolicyModel $SitePolicyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SitePolicyModel** | [**SitePolicyModel**](SitePolicyModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

