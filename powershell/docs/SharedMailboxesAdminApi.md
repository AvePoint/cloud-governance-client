# SharedMailboxesAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-SharedMailboxes**](SharedMailboxesAdminApi.md#Get-SharedMailboxes) | **GET** /admin/directory/sharedmailbox | get managed shared mailboxes
[**Get-SharedMailboxesFilters**](SharedMailboxesAdminApi.md#Get-SharedMailboxesFilters) | **GET** /admin/directory/sharedmailbox/filters | get filters for shared mailbox report
[**Invoke-SpecifySharedMailboxContacts**](SharedMailboxesAdminApi.md#Invoke-SpecifySharedMailboxContacts) | **POST** /admin/directory/sharedmailbox/contacts | specify contacts


<a name="Get-SharedMailboxes"></a>
# **Get-SharedMailboxes**
> SharedMailboxBasicGridModelPageResult Get-SharedMailboxes<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get managed shared mailboxes

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Filter = "MyFilter" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)
$Orderby = "MyOrderby" # String | Order by one field, supported fields:<br/> id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)
$Search = "MySearch" # String | Search for name (optional)
$Top = 56 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional)
$Skip = "MySkip" # String |  Define the number of records you want to skip, default value is 0 (optional)
$Nexttoken = "MyNexttoken" # String |  Use the next token to get the next paging result (optional)

# get managed shared mailboxes
try {
     $Result = Get-SharedMailboxes -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ("Exception occured when calling Get-SharedMailboxes: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **Search** | **String**| Search for name | [optional] 
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **Skip** | **String**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SharedMailboxBasicGridModelPageResult**](SharedMailboxBasicGridModelPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SharedMailboxesFilters"></a>
# **Get-SharedMailboxesFilters**
> DistinctResult[] Get-SharedMailboxesFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>

get filters for shared mailbox report

### Example
```powershell
Import-Module -Name Cloud.Governance.Client

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$Distinct = "MyDistinct" # String | support value: electionProfileName, electionProfileId, claimStatus, phaseProfileName, phaseProfileId, phase and metadata (optional)

# get filters for shared mailbox report
try {
     $Result = Get-SharedMailboxesFilters -Distinct $Distinct
} catch {
    Write-Host ("Exception occured when calling Get-SharedMailboxesFilters: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Distinct** | **String**| support value: electionProfileName, electionProfileId, claimStatus, phaseProfileName, phaseProfileId, phase and metadata | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**DistinctResult[]**](DistinctResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-SpecifySharedMailboxContacts"></a>
# **Invoke-SpecifySharedMailboxContacts**
> void Invoke-SpecifySharedMailboxContacts<br>
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
$ApiMyGroupPrimaryContact = New-ApiMyGroupPrimaryContact -Id "MyId" -LoginName "MyLoginName" -IsExternalUser $ExternalUserType -AzureUserType "MyAzureUserType" -DisplayName "MyDisplayName" -IsGroup $false -IsLocalUser $false -Email "MyEmail" -JobTitle "MyJobTitle" -PhysicalDeliveryOfficeName "MyPhysicalDeliveryOfficeName" -IsValid $false -IsAccountEnabled $false -TenantId "MyTenantId" -AdditionalData @{ key_example =  } -ApiUserType $ApiUserType

$WorkspaceType = New-WorkspaceType 
$WorkspaceIdTypeModel = New-WorkspaceIdTypeModel -ObjectId "MyObjectId" -WorkspaceType $WorkspaceType

$SpecifyContactParameter = New-SpecifyContactParameter -PrimaryContact $ApiMyGroupPrimaryContact -SecondaryContact $ApiMyGroupPrimaryContact -PrimaryContactNotifiedEmail "MyPrimaryContactNotifiedEmail" -SecondaryContactNotifiedEmail "MySecondaryContactNotifiedEmail" -IsRemoveSecondaryContact $false -Workspace $WorkspaceIdTypeModel -IsSelectAllWorkspace $false -Type $WorkspaceType -IsConfirmed $false # SpecifyContactParameter |  (optional)

# specify contacts
try {
     $Result = Invoke-SpecifySharedMailboxContacts -Filter $Filter -SpecifyContactParameter $SpecifyContactParameter
} catch {
    Write-Host ("Exception occured when calling Invoke-SpecifySharedMailboxContacts: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
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

