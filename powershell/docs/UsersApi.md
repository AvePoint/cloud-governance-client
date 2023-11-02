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



$AttributeName = "MyAttributeName" # String | azure ad attribute name
$AttributeValue = "MyAttributeValue" # String | value of attribute name
$Office365TenantId = "MyOffice365TenantId" # String | office 365 tenant id, optional, if not specified, only return the first tenant's result which is not empty (optional)

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExtensionAttribute] <String><br>

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



$Username = "MyUsername" # String | 
$PropertyName = "MyPropertyName" # String | 
$ExtensionAttribute = "MyExtensionAttribute" # String |  (optional) (default to "")

# get Azure Ad user's property value
try {
     $Result = Get-AzureAdUserPropertyValue -Username $Username -PropertyName $PropertyName -ExtensionAttribute $ExtensionAttribute
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
 **ExtensionAttribute** | **String**|  | [optional] [default to &quot;&quot;]

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



$Username = "MyUsername" # String | 

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



$Userprincipalname = "MyUserprincipalname" # String | 
$Groupid = "MyGroupid" # String | 

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupEmail] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PeopleFilterProfileId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsGetTenantBySiteUrl] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IncludeBlockedUser] <System.Nullable[Boolean]><br>

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



$Keyword = "MyKeyword" # String | 
$UserType = "1" # ApiUserType | 
$UserSource = "0" # UserSource | 
$SharingOptions = "0" # ExternalSharingOptions | 
$SiteUrlOrTenantId = "MySiteUrlOrTenantId" # String |  (optional) (default to "")
$GroupEmail = "MyGroupEmail" # String |  (optional) (default to "")
$PeopleFilterProfileId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsGetTenantBySiteUrl = $true # Boolean |  (optional) (default to $true)
$IncludeBlockedUser = $true # Boolean |  (optional) (default to $false)

# resolve users
try {
     $Result = Resolve-ACGUsers -Keyword $Keyword -UserType $UserType -UserSource $UserSource -SharingOptions $SharingOptions -SiteUrlOrTenantId $SiteUrlOrTenantId -GroupEmail $GroupEmail -PeopleFilterProfileId $PeopleFilterProfileId -IsGetTenantBySiteUrl $IsGetTenantBySiteUrl -IncludeBlockedUser $IncludeBlockedUser
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
 **GroupEmail** | **String**|  | [optional] [default to &quot;&quot;]
 **PeopleFilterProfileId** | [**String**](String.md)|  | [optional] 
 **IsGetTenantBySiteUrl** | **Boolean**|  | [optional] [default to $true]
 **IncludeBlockedUser** | **Boolean**|  | [optional] [default to $false]

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
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupEmail] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PeopleFilterProfileId] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IsGetTenantBySiteUrl] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IncludeBlockedUser] <System.Nullable[Boolean]><br>

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



$Keyword = "MyKeyword" # String | 
$UserType = "1" # ApiUserType | 
$UserSource = "0" # UserSource | 
$SharingOptions = "0" # ExternalSharingOptions | 
$SiteUrlOrTenantId = "MySiteUrlOrTenantId" # String |  (optional) (default to "")
$GroupEmail = "MyGroupEmail" # String |  (optional) (default to "")
$PeopleFilterProfileId = 38400000-8cf0-11bd-b23e-10b96e4ef00d # String |  (optional)
$IsGetTenantBySiteUrl = $true # Boolean |  (optional) (default to $true)
$IncludeBlockedUser = $true # Boolean |  (optional) (default to $false)

# search users
try {
     $Result = Search-ACGUsers -Keyword $Keyword -UserType $UserType -UserSource $UserSource -SharingOptions $SharingOptions -SiteUrlOrTenantId $SiteUrlOrTenantId -GroupEmail $GroupEmail -PeopleFilterProfileId $PeopleFilterProfileId -IsGetTenantBySiteUrl $IsGetTenantBySiteUrl -IncludeBlockedUser $IncludeBlockedUser
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
 **GroupEmail** | **String**|  | [optional] [default to &quot;&quot;]
 **PeopleFilterProfileId** | [**String**](String.md)|  | [optional] 
 **IsGetTenantBySiteUrl** | **Boolean**|  | [optional] [default to $true]
 **IncludeBlockedUser** | **Boolean**|  | [optional] [default to $false]

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**ApiUser[]**](ApiUser.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

