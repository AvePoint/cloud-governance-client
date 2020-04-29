# Cloud.Governance.Client.Cloud.Governance.Client\Api.Office365SettingsAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add-ImpersonationAccount**](Office365SettingsAdminApi.md#Add-ImpersonationAccount) | **POST** /admin/settings/office365/accounts | add impersonation account
[**Invoke-DeleteImpersonationAccount**](Office365SettingsAdminApi.md#Invoke-DeleteImpersonationAccount) | **DELETE** /admin/settings/office365/accounts/{id} | delete impersonationn account by id
[**Invoke-DeleteImpersonationAccounts**](Office365SettingsAdminApi.md#Invoke-DeleteImpersonationAccounts) | **DELETE** /admin/settings/office365/accounts | delete impersonation accounts
[**Invoke-Deletepermissionlevel**](Office365SettingsAdminApi.md#Invoke-Deletepermissionlevel) | **DELETE** /admin/settings/office365/permissionlevels/{id} | delete permission level
[**Invoke-Deletepermissionlevels**](Office365SettingsAdminApi.md#Invoke-Deletepermissionlevels) | **DELETE** /admin/settings/office365/permissionlevels | delete permission levels
[**Edit-ImpersonationAccount**](Office365SettingsAdminApi.md#Edit-ImpersonationAccount) | **PUT** /admin/settings/office365/accounts | edit impersonation account
[**Edit-PermissionLevel**](Office365SettingsAdminApi.md#Edit-PermissionLevel) | **PUT** /admin/settings/office365/permissionlevels | edit permission level
[**Get-AppBrandingSettings**](Office365SettingsAdminApi.md#Get-AppBrandingSettings) | **GET** /admin/settings/office365/branding | get app branding settings
[**Get-DefaultDomain**](Office365SettingsAdminApi.md#Get-DefaultDomain) | **GET** /admin/settings/office365/tenants/{id}/domain | get tenants default domain
[**Get-ImpersonationAccount**](Office365SettingsAdminApi.md#Get-ImpersonationAccount) | **GET** /admin/settings/office365/accounts/{id} | get impersonation account
[**Get-ImpersonationAccountList**](Office365SettingsAdminApi.md#Get-ImpersonationAccountList) | **GET** /admin/settings/office365/accounts | get impersonation account list
[**Get-ImpersonationAccountListFilters**](Office365SettingsAdminApi.md#Get-ImpersonationAccountListFilters) | **GET** /admin/settings/office365/accounts/filters | get impersonation account list filters
[**Get-PermissionLevel**](Office365SettingsAdminApi.md#Get-PermissionLevel) | **GET** /admin/settings/office365/permissionlevels/{id} | get permission level by id
[**Get-PermissionLevels**](Office365SettingsAdminApi.md#Get-PermissionLevels) | **GET** /admin/settings/office365/permissionlevels | get permission levels
[**Get-ReferencedServices**](Office365SettingsAdminApi.md#Get-ReferencedServices) | **GET** /admin/settings/office365/permissionlevels/{id}/services | get services that referneced these permission level
[**Get-Tenants**](Office365SettingsAdminApi.md#Get-Tenants) | **GET** /admin/settings/office365/tenants | get office365 tenants
[**Get-UploadUrl**](Office365SettingsAdminApi.md#Get-UploadUrl) | **GET** /admin/settings/office365/branding/url | get upload app branding URL
[**Save-AppBrandingSettings**](Office365SettingsAdminApi.md#Save-AppBrandingSettings) | **POST** /admin/settings/office365/branding | save app branding settings
[**Save-PermissionLevel**](Office365SettingsAdminApi.md#Save-PermissionLevel) | **POST** /admin/settings/office365/permissionlevels | create permission level


<a name="Add-ImpersonationAccount"></a>
# **Add-ImpersonationAccount**
> UUID Add-ImpersonationAccount<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ImpersonationAccountModel] <PSCustomObject><br>

add impersonation account

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



$ImpersonationAccountModel = (New-ImpersonationAccountModel -Id "TODO"  -Domain "Domain_example"  -User (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -Tenant (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -Tenants @((New-StringModel -Id "Id_example"  -Name "Name_example"))) # ImpersonationAccountModel |  (optional)

# add impersonation account
try {
    $Result = Add-ImpersonationAccount -ImpersonationAccountModel $ImpersonationAccountModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ImpersonationAccountModel** | [**ImpersonationAccountModel**](ImpersonationAccountModel.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteImpersonationAccount"></a>
# **Invoke-DeleteImpersonationAccount**
> void Invoke-DeleteImpersonationAccount<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete impersonationn account by id

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

# delete impersonationn account by id
try {
    Invoke-DeleteImpersonationAccount -Id $Id
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

<a name="Invoke-DeleteImpersonationAccounts"></a>
# **Invoke-DeleteImpersonationAccounts**
> void Invoke-DeleteImpersonationAccounts<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

delete impersonation accounts

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

# delete impersonation accounts
try {
    Invoke-DeleteImpersonationAccounts -UUID $UUID
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

<a name="Invoke-Deletepermissionlevel"></a>
# **Invoke-Deletepermissionlevel**
> void Invoke-Deletepermissionlevel<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete permission level

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

# delete permission level
try {
    Invoke-Deletepermissionlevel -Id $Id
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

<a name="Invoke-Deletepermissionlevels"></a>
# **Invoke-Deletepermissionlevels**
> void Invoke-Deletepermissionlevels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

delete permission levels

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

# delete permission levels
try {
    Invoke-Deletepermissionlevels -UUID $UUID
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

<a name="Edit-ImpersonationAccount"></a>
# **Edit-ImpersonationAccount**
> void Edit-ImpersonationAccount<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ImpersonationAccountModel] <PSCustomObject><br>

edit impersonation account

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



$ImpersonationAccountModel = (New-ImpersonationAccountModel -Id "TODO"  -Domain "Domain_example"  -User (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -Tenant (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -Tenants @((New-StringModel -Id "Id_example"  -Name "Name_example"))) # ImpersonationAccountModel |  (optional)

# edit impersonation account
try {
    Edit-ImpersonationAccount -ImpersonationAccountModel $ImpersonationAccountModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ImpersonationAccountModel** | [**ImpersonationAccountModel**](ImpersonationAccountModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-PermissionLevel"></a>
# **Edit-PermissionLevel**
> void Edit-PermissionLevel<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PermissionLevelModel] <PSCustomObject><br>

edit permission level

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



$PermissionLevelModel = (New-PermissionLevelModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Permissions @("Permissions_example")  -LastModifiedTime Get-Date) # PermissionLevelModel |  (optional)

# edit permission level
try {
    Edit-PermissionLevel -PermissionLevelModel $PermissionLevelModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **PermissionLevelModel** | [**PermissionLevelModel**](PermissionLevelModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AppBrandingSettings"></a>
# **Get-AppBrandingSettings**
> AppBrandingModel Get-AppBrandingSettings<br>

get app branding settings

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




# get app branding settings
try {
    $Result = Get-AppBrandingSettings
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AppBrandingModel**](AppBrandingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-DefaultDomain"></a>
# **Get-DefaultDomain**
> String Get-DefaultDomain<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-User] <String><br>

get tenants default domain

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
$User = "User_example" # String |  (default to null)

# get tenants default domain
try {
    $Result = Get-DefaultDomain -Id $Id -User $User
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **User** | **String**|  | [default to null]

### Return type

**String**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ImpersonationAccount"></a>
# **Get-ImpersonationAccount**
> ImpersonationAccountModel Get-ImpersonationAccount<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get impersonation account

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

# get impersonation account
try {
    $Result = Get-ImpersonationAccount -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**ImpersonationAccountModel**](ImpersonationAccountModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ImpersonationAccountList"></a>
# **Get-ImpersonationAccountList**
> ImpersonationAccountListPageResult Get-ImpersonationAccountList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get impersonation account list

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get impersonation account list
try {
    $Result = Get-ImpersonationAccountList -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**ImpersonationAccountListPageResult**](ImpersonationAccountListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ImpersonationAccountListFilters"></a>
# **Get-ImpersonationAccountListFilters**
> DistinctPageResult Get-ImpersonationAccountListFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get impersonation account list filters

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, displayName, tenantId, tenantName, domain, modifiedTime (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get impersonation account list filters
try {
    $Result = Get-ImpersonationAccountListFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, displayName, tenantId, tenantName, domain, modifiedTime | [optional] [default to null]
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

<a name="Get-PermissionLevel"></a>
# **Get-PermissionLevel**
> PermissionLevelViewModel Get-PermissionLevel<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get permission level by id

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

# get permission level by id
try {
    $Result = Get-PermissionLevel -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**PermissionLevelViewModel**](PermissionLevelViewModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-PermissionLevels"></a>
# **Get-PermissionLevels**
> PermissionLevelGridModelPageResult Get-PermissionLevels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get permission levels

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, description (optional) (default to null)
$Search = "Search_example" # String | Search for  (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get permission levels
try {
    $Result = Get-PermissionLevels -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description | [optional] [default to null]
 **Search** | **String**| Search for  | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**PermissionLevelGridModelPageResult**](PermissionLevelGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ReferencedServices"></a>
# **Get-ReferencedServices**
> String[] Get-ReferencedServices<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get services that referneced these permission level

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

# get services that referneced these permission level
try {
    $Result = Get-ReferencedServices -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Tenants"></a>
# **Get-Tenants**
> StringModel[] Get-Tenants<br>

get office365 tenants

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




# get office365 tenants
try {
    $Result = Get-Tenants
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StringModel[]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UploadUrl"></a>
# **Get-UploadUrl**
> SASUriModel Get-UploadUrl<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-FileName] <String><br>

get upload app branding URL

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



$FileName = "FileName_example" # String |  (default to null)

# get upload app branding URL
try {
    $Result = Get-UploadUrl -FileName $FileName
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **FileName** | **String**|  | [default to null]

### Return type

[**SASUriModel**](SASUriModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-AppBrandingSettings"></a>
# **Save-AppBrandingSettings**
> void Save-AppBrandingSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AppBrandingModel] <PSCustomObject><br>

save app branding settings

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



$AppBrandingModel = (New-AppBrandingModel -DataSource (New-BrandingSourceType)  -FileName "FileName_example"  -Link "Link_example") # AppBrandingModel |  (optional)

# save app branding settings
try {
    Save-AppBrandingSettings -AppBrandingModel $AppBrandingModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AppBrandingModel** | [**AppBrandingModel**](AppBrandingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-PermissionLevel"></a>
# **Save-PermissionLevel**
> UUID Save-PermissionLevel<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PermissionLevelModel] <PSCustomObject><br>

create permission level

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



$PermissionLevelModel = (New-PermissionLevelModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Permissions @("Permissions_example")  -LastModifiedTime Get-Date) # PermissionLevelModel |  (optional)

# create permission level
try {
    $Result = Save-PermissionLevel -PermissionLevelModel $PermissionLevelModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **PermissionLevelModel** | [**PermissionLevelModel**](PermissionLevelModel.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

