# Office365AdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-AzureAdCustomPropertyNames**](Office365AdminApi.md#Get-AzureAdCustomPropertyNames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
[**Get-TenantIdByUrl**](Office365AdminApi.md#Get-TenantIdByUrl) | **GET** /admin/office365/tenantid | get tenant ids by url


<a name="Get-AzureAdCustomPropertyNames"></a>
# **Get-AzureAdCustomPropertyNames**
> String[] Get-AzureAdCustomPropertyNames<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TenantId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsSearchUserProperty] <System.Nullable[Boolean]><br>

get azure ad custom property names

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



$TenantId = "TenantId_example" # String | 
$IsSearchUserProperty = true # Boolean |  (optional) (default to $false)

# get azure ad custom property names
try {
     $Result = Get-AzureAdCustomPropertyNames -TenantId $TenantId -IsSearchUserProperty $IsSearchUserProperty
} catch {
    Write-Host ("Exception occured when calling Get-AzureAdCustomPropertyNames: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TenantId** | [**String**](String.md)|  | 
 **IsSearchUserProperty** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**String[]**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TenantIdByUrl"></a>
# **Get-TenantIdByUrl**
> void Get-TenantIdByUrl<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Uri] <String><br>

get tenant ids by url

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



$Uri = "Uri_example" # String | 

# get tenant ids by url
try {
     $Result = Get-TenantIdByUrl -Uri $Uri
} catch {
    Write-Host ("Exception occured when calling Get-TenantIdByUrl: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Uri** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

