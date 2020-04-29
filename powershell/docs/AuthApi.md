# Cloud.Governance.Client.Cloud.Governance.Client\Api.AuthApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-DelegateAccessToken**](AuthApi.md#Get-DelegateAccessToken) | **POST** /auth/token/delegate | get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
[**Get-TokenUsage**](AuthApi.md#Get-TokenUsage) | **GET** /auth/token/usage | 
[**Get-UserTokenUrl**](AuthApi.md#Get-UserTokenUrl) | **GET** /auth/token/user/url | get the url which used to get user access token
[**Invoke-RefreshUserAccessToken**](AuthApi.md#Invoke-RefreshUserAccessToken) | **POST** /auth/token/user/refresh | refresh user access token


<a name="Get-DelegateAccessToken"></a>
# **Get-DelegateAccessToken**
> DelegatedAccessTokenApiResult Get-DelegateAccessToken<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ClientSecret] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserPrincipalName] <String><br>

get delegate access token by client id and client secret which created in cloud governance Api Authentication Management

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



$ClientSecret = "ClientSecret_example" # String |  (default to null)
$UserPrincipalName = "UserPrincipalName_example" # String |  (default to null)

# get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
try {
    $Result = Get-DelegateAccessToken -ClientSecret $ClientSecret -UserPrincipalName $UserPrincipalName
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ClientSecret** | **String**|  | [default to null]
 **UserPrincipalName** | **String**|  | [default to null]

### Return type

[**DelegatedAccessTokenApiResult**](DelegatedAccessTokenApiResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TokenUsage"></a>
# **Get-TokenUsage**
> void Get-TokenUsage<br>



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




try {
    Get-TokenUsage
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UserTokenUrl"></a>
# **Get-UserTokenUrl**
> String Get-UserTokenUrl<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RedirectUri] <String><br>

get the url which used to get user access token

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



$RedirectUri = "RedirectUri_example" # String | your application url to receive the token (optional) (default to null)

# get the url which used to get user access token
try {
    $Result = Get-UserTokenUrl -RedirectUri $RedirectUri
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **RedirectUri** | **String**| your application url to receive the token | [optional] [default to null]

### Return type

**String**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-RefreshUserAccessToken"></a>
# **Invoke-RefreshUserAccessToken**
> DelegatedAccessTokenApiResult Invoke-RefreshUserAccessToken<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RefreshToken] <String><br>

refresh user access token

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



$RefreshToken = "RefreshToken_example" # String |  (default to null)

# refresh user access token
try {
    $Result = Invoke-RefreshUserAccessToken -RefreshToken $RefreshToken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **RefreshToken** | **String**|  | [default to null]

### Return type

[**DelegatedAccessTokenApiResult**](DelegatedAccessTokenApiResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

