# UsersApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-FilterUsersByAttribute**](UsersApi.md#Invoke-FilterUsersByAttribute) | **GET** /users/filter | filter users by property value
[**Get-AzureAdUserPropertyValue**](UsersApi.md#Get-AzureAdUserPropertyValue) | **GET** /users/{username}/azuread/property | get Azure Ad user&#39;s property value
[**Get-ExtensionAzureAdUserPropertyValues**](UsersApi.md#Get-ExtensionAzureAdUserPropertyValues) | **GET** /users/{username}/azuread/extensionproperties | get user&#39;s extension property value from azure ad
[**Invoke-IsMemberOfGroup**](UsersApi.md#Invoke-IsMemberOfGroup) | **GET** /users/{userprincipalname}/ismemberof/{groupid} | Is Member Of Group
[**Resolve-ACGUsers**](UsersApi.md#resolve-acgusers) | **GET** /users/resolve | resolve users
[**Search-ACGUsers**](UsersApi.md#search-acgusers) | **GET** /users/search | search users
[**Update-UserInfo**](UsersApi.md#Update-UserInfo) | **POST** /users | 


<a name="Invoke-FilterUsersByAttribute"></a>
# **Invoke-FilterUsersByAttribute**
> ApiUser[] Invoke-FilterUsersByAttribute<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AttributeName] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AttributeValue] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Office365TenantId] <String><br>

filter users by property value

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



$AttributeName = "AttributeName_example" # String | azure ad attribute name
$AttributeValue = "AttributeValue_example" # String | value of attribute name
$Office365TenantId = "Office365TenantId_example" # String | office 365 tenant id, optional, if not specified, only return the first tenant's result which is not empty (optional)

# filter users by property value
try {
     $Result = Invoke-FilterUsersByAttribute -AttributeName $AttributeName -AttributeValue $AttributeValue -Office365TenantId $Office365TenantId
} catch {
    Write-Host ("Exception occured when calling Invoke-FilterUsersByAttribute: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AttributeName** | **String**| azure ad attribute name | 
 **AttributeValue** | **String**| value of attribute name | 
 **Office365TenantId** | **String**| office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUser[]**](ApiUser.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AzureAdUserPropertyValue"></a>
# **Get-AzureAdUserPropertyValue**
> StringModel Get-AzureAdUserPropertyValue<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PropertyName] <String><br>

get Azure Ad user's property value

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



$Username = "Username_example" # String | 
$PropertyName = "PropertyName_example" # String | 

# get Azure Ad user's property value
try {
     $Result = Get-AzureAdUserPropertyValue -Username $Username -PropertyName $PropertyName
} catch {
    Write-Host ("Exception occured when calling Get-AzureAdUserPropertyValue: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | 
 **PropertyName** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**StringModel**](StringModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ExtensionAzureAdUserPropertyValues"></a>
# **Get-ExtensionAzureAdUserPropertyValues**
> StringModel[] Get-ExtensionAzureAdUserPropertyValues<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>

get user's extension property value from azure ad

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



$Username = "Username_example" # String | 

# get user's extension property value from azure ad
try {
     $Result = Get-ExtensionAzureAdUserPropertyValues -Username $Username
} catch {
    Write-Host ("Exception occured when calling Get-ExtensionAzureAdUserPropertyValues: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**StringModel[]**](StringModel.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-IsMemberOfGroup"></a>
# **Invoke-IsMemberOfGroup**
> Boolean Invoke-IsMemberOfGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Userprincipalname] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <String><br>

Is Member Of Group

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



$Userprincipalname = "Userprincipalname_example" # String | 
$Groupid = "Groupid_example" # String | 

# Is Member Of Group
try {
     $Result = Invoke-IsMemberOfGroup -Userprincipalname $Userprincipalname -Groupid $Groupid
} catch {
    Write-Host ("Exception occured when calling Invoke-IsMemberOfGroup: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Userprincipalname** | **String**|  | 
 **Groupid** | **String**|  | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
**Boolean**

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolve-acgusers"></a>
# **Resolve-ACGUsers**
> ApiUser[] Resolve-ACGUsers<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Keyword] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserType] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserSource] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SharingOptions] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrlOrTenantId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PeopleFilterProfileId] <PSCustomObject><br>

resolve users

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



$Keyword = "Keyword_example" # String | 
$UserType = (New-ApiUserType) # ApiUserType | 
$UserSource = (New-UserSource) # UserSource | 
$SharingOptions = (New-ExternalSharingOptions) # ExternalSharingOptions | 
$SiteUrlOrTenantId = "SiteUrlOrTenantId_example" # String |  (optional) (default to "")
$PeopleFilterProfileId = "PeopleFilterProfileId_example" # String |  (optional)

# resolve users
try {
     $Result = Resolve-ACGUsers -Keyword $Keyword -UserType $UserType -UserSource $UserSource -SharingOptions $SharingOptions -SiteUrlOrTenantId $SiteUrlOrTenantId -PeopleFilterProfileId $PeopleFilterProfileId
} catch {
    Write-Host ("Exception occured when calling Resolve-ACGUsers: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Keyword** | **String**|  | 
 **UserType** | [**ApiUserType**](ApiUserType.md)|  | 
 **UserSource** | [**UserSource**](UserSource.md)|  | 
 **SharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md)|  | 
 **SiteUrlOrTenantId** | **String**|  | [optional] [default to &quot;&quot;]
 **PeopleFilterProfileId** | [**String**](String.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUser[]**](ApiUser.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search-acgusers"></a>
# **Search-ACGUsers**
> ApiUser[] Search-ACGUsers<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Keyword] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserType] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserSource] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SharingOptions] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrlOrTenantId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PeopleFilterProfileId] <PSCustomObject><br>

search users

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



$Keyword = "Keyword_example" # String | 
$UserType = (New-ApiUserType) # ApiUserType | 
$UserSource = (New-UserSource) # UserSource | 
$SharingOptions = (New-ExternalSharingOptions) # ExternalSharingOptions | 
$SiteUrlOrTenantId = "SiteUrlOrTenantId_example" # String |  (optional) (default to "")
$PeopleFilterProfileId = "PeopleFilterProfileId_example" # String |  (optional)

# search users
try {
     $Result = Search-ACGUsers -Keyword $Keyword -UserType $UserType -UserSource $UserSource -SharingOptions $SharingOptions -SiteUrlOrTenantId $SiteUrlOrTenantId -PeopleFilterProfileId $PeopleFilterProfileId
} catch {
    Write-Host ("Exception occured when calling Search-ACGUsers: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Keyword** | **String**|  | 
 **UserType** | [**ApiUserType**](ApiUserType.md)|  | 
 **UserSource** | [**UserSource**](UserSource.md)|  | 
 **SharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md)|  | 
 **SiteUrlOrTenantId** | **String**|  | [optional] [default to &quot;&quot;]
 **PeopleFilterProfileId** | [**String**](String.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUser[]**](ApiUser.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-UserInfo"></a>
# **Update-UserInfo**
> void Update-UserInfo<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UpdatableApiUser] <PSCustomObject><br>



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



$UpdatableApiUser = (New-UpdatableApiUser-Email "Email_example" -JobTitle "JobTitle_example" -TenantId "TenantId_example" -PeopleFilterProfileId "PeopleFilterProfileId_example" -ApiUserType  -Id "Id_example" -LoginName "LoginName_example" -IsExternalUser (New-ExternalUserType) -AzureUserType "AzureUserType_example" -DisplayName "DisplayName_example" -IsGroup $false -IsLocalUser $false -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example" -IsValid $false -AdditionalData "TODO") # UpdatableApiUser |  (optional)

try {
     $Result = Update-UserInfo -UpdatableApiUser $UpdatableApiUser
} catch {
    Write-Host ("Exception occured when calling Update-UserInfo: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UpdatableApiUser** | [**UpdatableApiUser**](UpdatableApiUser.md)|  | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

