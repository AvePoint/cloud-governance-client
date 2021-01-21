# AuthAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-DeleteTokenCache**](AuthAdminApi.md#Invoke-DeleteTokenCache) | **DELETE** /admin/auth/token/cache | delete token cache


<a name="Invoke-DeleteTokenCache"></a>
# **Invoke-DeleteTokenCache**
> void Invoke-DeleteTokenCache<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiCredential] <PSCustomObject><br>

delete token cache

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



$ApiCredential = (Initialize-ApiCredential-ClientSecret "ClientSecret_example" -UserPrincipalName "UserPrincipalName_example") # ApiCredential | 

# delete token cache
try {
     $Result = Invoke-DeleteTokenCache -ApiCredential $ApiCredential
} catch {
    Write-Host ("Exception occured when calling Invoke-DeleteTokenCache: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApiCredential** | [**ApiCredential**](ApiCredential.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

