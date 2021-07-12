# Office365AdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add-WebUserCustomAction**](Office365AdminApi.md#Add-WebUserCustomAction) | **POST** /admin/office365/web/usercustomactions | add user custom actions, if exists, will update the existing one.
[**Invoke-DeleteWebUserCustomAction**](Office365AdminApi.md#Invoke-DeleteWebUserCustomAction) | **DELETE** /admin/office365/web/usercustomactions | delete user custom actions by action name
[**Get-AzureAdCustomPropertyNames**](Office365AdminApi.md#Get-AzureAdCustomPropertyNames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
[**Get-TenantIdByUrl**](Office365AdminApi.md#Get-TenantIdByUrl) | **GET** /admin/office365/tenantid | get tenant ids by url


<a name="Add-WebUserCustomAction"></a>
# **Add-WebUserCustomAction**
> void Add-WebUserCustomAction<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserCustomAction] <PSCustomObject><br>

add user custom actions, if exists, will update the existing one.

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



$UserCustomAction = (Initialize-UserCustomAction -WebFullUrl "WebFullUrl_example" -Title "Title_example" -Sequence 123 -ScriptSrc "ScriptSrc_example" -ScriptBlock "ScriptBlock_example" -Name "Name_example" -Url "Url_example" -Location "Location_example" -Group "Group_example" -ImageUrl "ImageUrl_example" -Description "Description_example") # UserCustomAction | 

# add user custom actions, if exists, will update the existing one.
try {
     $Result = Add-WebUserCustomAction -UserCustomAction $UserCustomAction
} catch {
    Write-Host ("Exception occured when calling Add-WebUserCustomAction: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UserCustomAction** | [**UserCustomAction**](UserCustomAction.md)|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteWebUserCustomAction"></a>
# **Invoke-DeleteWebUserCustomAction**
> void Invoke-DeleteWebUserCustomAction<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-WebFullUrl] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

delete user custom actions by action name

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



$WebFullUrl = "WebFullUrl_example" # String | 
$Name = "Name_example" # String | 

# delete user custom actions by action name
try {
     $Result = Invoke-DeleteWebUserCustomAction -WebFullUrl $WebFullUrl -Name $Name
} catch {
    Write-Host ("Exception occured when calling Invoke-DeleteWebUserCustomAction: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **WebFullUrl** | **String**|  | 
 **Name** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

