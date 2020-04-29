# Cloud.Governance.Client.Cloud.Governance.Client\Api.MetadataAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-CreateMetadata**](MetadataAdminApi.md#Invoke-CreateMetadata) | **POST** /admin/metadata | Create metadata
[**Invoke-DeleteMetadata**](MetadataAdminApi.md#Invoke-DeleteMetadata) | **DELETE** /admin/metadata/{id} | delete metadata
[**Get-AllMetadata**](MetadataAdminApi.md#Get-AllMetadata) | **GET** /admin/metadata | get all metadata
[**Get-MetadataFilters**](MetadataAdminApi.md#Get-MetadataFilters) | **GET** /admin/metadata/filters | get metadata filters
[**Get-SingleMetadataById**](MetadataAdminApi.md#Get-SingleMetadataById) | **GET** /admin/metadata/{id} | Get metadata by id
[**Update-Metadata**](MetadataAdminApi.md#Update-Metadata) | **PUT** /admin/metadata | Update metadata


<a name="Invoke-CreateMetadata"></a>
# **Invoke-CreateMetadata**
> UUID Invoke-CreateMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CustomMetadata] <PSCustomObject><br>

Create metadata

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



$CustomMetadata = (New-CustomMetadata -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Type (New-MetadataFieldType)  -DisplayType (New-DisplayInReportType)  -AssignBy (New-AssignBy)  -EnableTextValidation $false  -TextValidationRule (New-TextValidationRuleRef -Id "TODO"  -Name "Name_example"  -Expression "Expression_example"  -ErrorMessage "ErrorMessage_example")  -BooleanMetadataSettings (New-BooleanMetadataSettings -EnableTerms $false  -Value $false  -TermsAndConditions "TermsAndConditions_example")  -TermsMetadataSettings (New-TermsMetadataSettings -AllowMultiple $false  -AdminCenter "AdminCenter_example"  -Value @((New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"))  -TermStore (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -TermGroup   -TermSet   -Scope )  -UserMetadataSettings (New-UserMetadataSettings -Value @((New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -AllowReferenceAsRoleInApprovalProcess $false)  -UserProfileMetadataSettings (New-UserProfileMetadataSettings -AdminCenter "AdminCenter_example"  -EnableValueSync $false  -EnableRoleValueSync $false  -Value (New-LookupValue -Tenant "Tenant_example"  -Property "Property_example"  -TargetUser (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -UserPropertyValue "UserPropertyValue_example"  -UserPropertyDisplayValue "UserPropertyDisplayValue_example")  -Property "Property_example"  -AllowReferenceAsRoleInApprovalProcess $false)  -AzureAdMetadataSettings (New-AzureAdMetadataSettings -Office365Tenant   -UseBuiltInProperty $false  -Value (New-LookupValue -Tenant "Tenant_example"  -Property "Property_example"  -TargetUser   -UserPropertyValue "UserPropertyValue_example"  -UserPropertyDisplayValue "UserPropertyDisplayValue_example")  -Property "Property_example"  -AllowReferenceAsRoleInApprovalProcess $false)  -ChoiceMetadataSettings (New-ChoiceMetadataSettings -Choices @("Choices_example")  -Value @("Value_example")  -ChoiceType (New-ChoiceType))  -LinkMetadataSettings (New-LinkMetadataSettings -Title "Title_example"  -Address "Address_example")  -SingleLineOrMultipleLineMetadataSettings (New-SingleLineOrMultipleLineMetadataSettings -Value "Value_example")) # CustomMetadata |  (optional)

# Create metadata
try {
    $Result = Invoke-CreateMetadata -CustomMetadata $CustomMetadata
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **CustomMetadata** | [**CustomMetadata**](CustomMetadata.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteMetadata"></a>
# **Invoke-DeleteMetadata**
> void Invoke-DeleteMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete metadata

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

# delete metadata
try {
    Invoke-DeleteMetadata -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AllMetadata"></a>
# **Get-AllMetadata**
> MetadataListPageResult Get-AllMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all metadata

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all metadata
try {
    $Result = Get-AllMetadata -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**MetadataListPageResult**](MetadataListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MetadataFilters"></a>
# **Get-MetadataFilters**
> DistinctPageResult Get-MetadataFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get metadata filters

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get metadata filters
try {
    $Result = Get-MetadataFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; createdBy, createdByDisplayName, id, name, description, fieldType, metadataValue, showInReportType, lastModifiedTime | [optional] [default to null]
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

<a name="Get-SingleMetadataById"></a>
# **Get-SingleMetadataById**
> CustomMetadata Get-SingleMetadataById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

Get metadata by id

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

# Get metadata by id
try {
    $Result = Get-SingleMetadataById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**CustomMetadata**](CustomMetadata.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-Metadata"></a>
# **Update-Metadata**
> void Update-Metadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CustomMetadata] <PSCustomObject><br>

Update metadata

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



$CustomMetadata = (New-CustomMetadata -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Type (New-MetadataFieldType)  -DisplayType (New-DisplayInReportType)  -AssignBy (New-AssignBy)  -EnableTextValidation $false  -TextValidationRule (New-TextValidationRuleRef -Id "TODO"  -Name "Name_example"  -Expression "Expression_example"  -ErrorMessage "ErrorMessage_example")  -BooleanMetadataSettings (New-BooleanMetadataSettings -EnableTerms $false  -Value $false  -TermsAndConditions "TermsAndConditions_example")  -TermsMetadataSettings (New-TermsMetadataSettings -AllowMultiple $false  -AdminCenter "AdminCenter_example"  -Value @()  -TermStore   -TermGroup   -TermSet   -Scope )  -UserMetadataSettings (New-UserMetadataSettings -Value @()  -AllowReferenceAsRoleInApprovalProcess $false)  -UserProfileMetadataSettings (New-UserProfileMetadataSettings -AdminCenter "AdminCenter_example"  -EnableValueSync $false  -EnableRoleValueSync $false  -Value   -Property "Property_example"  -AllowReferenceAsRoleInApprovalProcess $false)  -AzureAdMetadataSettings (New-AzureAdMetadataSettings -Office365Tenant   -UseBuiltInProperty $false  -Value   -Property "Property_example"  -AllowReferenceAsRoleInApprovalProcess $false)  -ChoiceMetadataSettings (New-ChoiceMetadataSettings -Choices @("Choices_example")  -Value @("Value_example")  -ChoiceType (New-ChoiceType))  -LinkMetadataSettings (New-LinkMetadataSettings -Title "Title_example"  -Address "Address_example")  -SingleLineOrMultipleLineMetadataSettings (New-SingleLineOrMultipleLineMetadataSettings -Value "Value_example")) # CustomMetadata |  (optional)

# Update metadata
try {
    Update-Metadata -CustomMetadata $CustomMetadata
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **CustomMetadata** | [**CustomMetadata**](CustomMetadata.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

