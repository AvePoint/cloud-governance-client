# Cloud.Governance.Client.Cloud.Governance.Client\Api.Office365AdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-AzureAdBuiltInPropertyNames**](Office365AdminApi.md#Get-AzureAdBuiltInPropertyNames) | **GET** /admin/office365/azuread/property/names/builtin | get azure ad custom property names
[**Get-AzureAdCustomPropertyNames**](Office365AdminApi.md#Get-AzureAdCustomPropertyNames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
[**Get-UpsPropertyNames**](Office365AdminApi.md#Get-UpsPropertyNames) | **GET** /admin/office365/userprofile/property/names | get user profile property names


<a name="Get-AzureAdBuiltInPropertyNames"></a>
# **Get-AzureAdBuiltInPropertyNames**
> String[] Get-AzureAdBuiltInPropertyNames<br>

get azure ad custom property names

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




# get azure ad custom property names
try {
    $Result = Get-AzureAdBuiltInPropertyNames
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AzureAdCustomPropertyNames"></a>
# **Get-AzureAdCustomPropertyNames**
> String[] Get-AzureAdCustomPropertyNames<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TenantId] <PSCustomObject><br>

get azure ad custom property names

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



$TenantId = TODO # UUID |  (default to null)

# get azure ad custom property names
try {
    $Result = Get-AzureAdCustomPropertyNames -TenantId $TenantId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TenantId** | [**UUID**](UUID.md)|  | [default to null]

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UpsPropertyNames"></a>
# **Get-UpsPropertyNames**
> String[] Get-UpsPropertyNames<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AdminCenterUrl] <String><br>

get user profile property names

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



$AdminCenterUrl = "AdminCenterUrl_example" # String |  (default to null)

# get user profile property names
try {
    $Result = Get-UpsPropertyNames -AdminCenterUrl $AdminCenterUrl
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AdminCenterUrl** | **String**|  | [default to null]

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

