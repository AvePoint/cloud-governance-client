# Cloud.Governance.Client.Cloud.Governance.Client\Api.ApprovalprocessesAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-CreateApprovalProcess**](ApprovalprocessesAdminApi.md#Invoke-CreateApprovalProcess) | **POST** /admin/approvalprocesses | create approval process
[**Invoke-DeleteSelectedApprovalProcesses**](ApprovalprocessesAdminApi.md#Invoke-DeleteSelectedApprovalProcesses) | **DELETE** /admin/approvalprocesses | remove selected approval processes
[**Get-ApprovalProcessFilters**](ApprovalprocessesAdminApi.md#Get-ApprovalProcessFilters) | **GET** /admin/approvalprocesses/filters | get filters of approval process
[**Get-ApprovalProcessSetting**](ApprovalprocessesAdminApi.md#Get-ApprovalProcessSetting) | **GET** /admin/approvalprocesses/{id} | get edit approval process setting
[**Get-ApprovalProcesses**](ApprovalprocessesAdminApi.md#Get-ApprovalProcesses) | **GET** /admin/approvalprocesses | get all approval processes
[**Update-ApprovalProcess**](ApprovalprocessesAdminApi.md#Update-ApprovalProcess) | **PUT** /admin/approvalprocesses | update approval process
[**Update-SelectedApprovalProcessesStatus**](ApprovalprocessesAdminApi.md#Update-SelectedApprovalProcessesStatus) | **PATCH** /admin/approvalprocesses/status/{status} | update the status of selected approval processes


<a name="Invoke-CreateApprovalProcess"></a>
# **Invoke-CreateApprovalProcess**
> void Invoke-CreateApprovalProcess<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApprovalProcessModel] <PSCustomObject><br>

create approval process

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



$ApprovalProcessModel = (New-ApprovalProcessModel -CompletionTemplateId "TODO"  -StageOne (New-ApprovalProcessStageModel -ApproveOrder (New-ApproveOrder)  -Approvers @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -Description "Description_example"  -Name "Name_example"  -IsAllowAutocrat $false  -IsAllowReassign $false  -DurationSetting (New-ApprovalProcessStageDurationSetting -IsDurationEnabled $false  -Reassigner (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -EscalationUsers @()  -IsEnableDureationReminder $false  -Duration 123  -ReassignTemplateId "TODO"  -AutoRejectTemplateId "TODO"  -NotifyTemplateId "TODO"  -DurationReminderProfileId "TODO"  -DurationType (New-DurationType)  -EscalationType (New-EscalationType))  -EmailSetting (New-ApprovalProcessStageEmailSetting -NotifyApproverWhenAssigned $false  -NotifyApproverEmailTemplateId "TODO"  -NotifyReuqesterWhenApproved $false  -NotifyReuqesterEmailTemplateApprovedId "TODO"  -NotifyReuqesterWhenRejected $false  -NotifyReuqesterEmailTemplateRejectedId "TODO"  -WarnApproverbeforeExpired $false  -WarnApproverbeforeExpiredEmailTemplateId "TODO"  -NotifyApproverWhenExpired $false  -NotifyApproverWhenExpiredEmailTemplateId "TODO"  -NotifyApproverWhenCancelled $false  -NotifyApproverCancelledEmailTemplateId "TODO"  -NotifyApproverWhenRejected $false  -NotifyApproverRejectedEmailTemplateId "TODO"))  -StageTwo (New-ApprovalProcessStageModel -ApproveOrder (New-ApproveOrder)  -Approvers @()  -Description "Description_example"  -Name "Name_example"  -IsAllowAutocrat $false  -IsAllowReassign $false  -DurationSetting (New-ApprovalProcessStageDurationSetting -IsDurationEnabled $false  -Reassigner   -EscalationUsers @()  -IsEnableDureationReminder $false  -Duration 123  -ReassignTemplateId "TODO"  -AutoRejectTemplateId "TODO"  -NotifyTemplateId "TODO"  -DurationReminderProfileId "TODO"  -DurationType (New-DurationType)  -EscalationType (New-EscalationType))  -EmailSetting (New-ApprovalProcessStageEmailSetting -NotifyApproverWhenAssigned $false  -NotifyApproverEmailTemplateId "TODO"  -NotifyReuqesterWhenApproved $false  -NotifyReuqesterEmailTemplateApprovedId "TODO"  -NotifyReuqesterWhenRejected $false  -NotifyReuqesterEmailTemplateRejectedId "TODO"  -WarnApproverbeforeExpired $false  -WarnApproverbeforeExpiredEmailTemplateId "TODO"  -NotifyApproverWhenExpired $false  -NotifyApproverWhenExpiredEmailTemplateId "TODO"  -NotifyApproverWhenCancelled $false  -NotifyApproverCancelledEmailTemplateId "TODO"  -NotifyApproverWhenRejected $false  -NotifyApproverRejectedEmailTemplateId "TODO"))  -StageThree   -StageSettings (New-ApprovalProcessStageSettings -IsAutoApproveWhenRequesterIsApprover $false  -IsEnableAutoApproval $false  -IsAutoApproveWhenRequesterInSpecifiedSecurityGroup $false  -SpecifiedSecurityGroup   -StageCount 123)  -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Status (New-CommonStatus)  -Category "Category_example"  -Cc @()) # ApprovalProcessModel |  (optional)

# create approval process
try {
    Invoke-CreateApprovalProcess -ApprovalProcessModel $ApprovalProcessModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApprovalProcessModel** | [**ApprovalProcessModel**](ApprovalProcessModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteSelectedApprovalProcesses"></a>
# **Invoke-DeleteSelectedApprovalProcesses**
> void Invoke-DeleteSelectedApprovalProcesses<br>
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
    Invoke-DeleteSelectedApprovalProcesses -UUID $UUID
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

<a name="Get-ApprovalProcessFilters"></a>
# **Get-ApprovalProcessFilters**
> DistinctPageResult Get-ApprovalProcessFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get filters of approval process

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get filters of approval process
try {
    $Result = Get-ApprovalProcessFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
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

<a name="Get-ApprovalProcessSetting"></a>
# **Get-ApprovalProcessSetting**
> ApprovalProcessModel Get-ApprovalProcessSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get edit approval process setting

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

# get edit approval process setting
try {
    $Result = Get-ApprovalProcessSetting -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**ApprovalProcessModel**](ApprovalProcessModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ApprovalProcesses"></a>
# **Get-ApprovalProcesses**
> ApprovalProcessGridModelPageResult Get-ApprovalProcesses<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all approval processes

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, status, lastModifiedTime, createdByDisplayName (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all approval processes
try {
    $Result = Get-ApprovalProcesses -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, status, lastModifiedTime, createdByDisplayName | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**ApprovalProcessGridModelPageResult**](ApprovalProcessGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-ApprovalProcess"></a>
# **Update-ApprovalProcess**
> void Update-ApprovalProcess<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApprovalProcessModel] <PSCustomObject><br>

update approval process

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



$ApprovalProcessModel = (New-ApprovalProcessModel -CompletionTemplateId "TODO"  -StageOne   -StageTwo   -StageThree   -StageSettings (New-ApprovalProcessStageSettings -IsAutoApproveWhenRequesterIsApprover $false  -IsEnableAutoApproval $false  -IsAutoApproveWhenRequesterInSpecifiedSecurityGroup $false  -SpecifiedSecurityGroup   -StageCount 123)  -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Status (New-CommonStatus)  -Category "Category_example"  -Cc @()) # ApprovalProcessModel |  (optional)

# update approval process
try {
    Update-ApprovalProcess -ApprovalProcessModel $ApprovalProcessModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApprovalProcessModel** | [**ApprovalProcessModel**](ApprovalProcessModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-SelectedApprovalProcessesStatus"></a>
# **Update-SelectedApprovalProcessesStatus**
> void Update-SelectedApprovalProcessesStatus<br>
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
    Update-SelectedApprovalProcessesStatus -Status $Status -UUID $UUID
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

