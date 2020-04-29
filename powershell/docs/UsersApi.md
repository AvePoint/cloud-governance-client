# Cloud.Governance.Client.Cloud.Governance.Client\Api.UsersApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-CheckUserExistsInAOS**](UsersApi.md#Invoke-CheckUserExistsInAOS) | **GET** /users/avepointonlineservices/validate | check user exists in Aos
[**Get-AzureAdUserPropertyValue**](UsersApi.md#Get-AzureAdUserPropertyValue) | **GET** /users/{username}/azuread/property | get user&#39;s property value by property name from azure ad
[**Get-UpsUserPropertyValue**](UsersApi.md#Get-UpsUserPropertyValue) | **GET** /users/{username}/userprofile/property | get user&#39;s property value by property name from user profile service
[**Get-UserBasicProperties**](UsersApi.md#Get-UserBasicProperties) | **GET** /users/me/properties | get my basic properties, City, Country, Office, Department, JobTitle,State
[**Get-UserBasicPropertyValue**](UsersApi.md#Get-UserBasicPropertyValue) | **GET** /users/me/property/{name} | get my basic property value, Department, Email, DisplayName, Manager
[**Get-UserPhoto**](UsersApi.md#Get-UserPhoto) | **GET** /users/{username}/photo | get user&#39;s photo
[**Get-UserRelationship**](UsersApi.md#Get-UserRelationship) | **GET** /users/{username}/relationship | get user relationship
[**Get-UsersFromSharePoint**](UsersApi.md#Get-UsersFromSharePoint) | **POST** /users/sharepoint/validate | get users from sharepoint
[**Resolve-Users**](UsersApi.md#Resolve-Users) | **GET** /users/resolve | resolve users
[**Resolve-UsersWithExternalSharingOption**](UsersApi.md#Resolve-UsersWithExternalSharingOption) | **GET** /users/resolve/{externalSharingOption} | resolve user including external users
[**Search-Users**](UsersApi.md#Search-Users) | **GET** /users/search | search users
[**Search-UsersWithExternalSharingOption**](UsersApi.md#Search-UsersWithExternalSharingOption) | **GET** /users/search/{externalSharingOption} | search user including external users
[**Update-UserInfo**](UsersApi.md#Update-UserInfo) | **POST** /users | 


<a name="Invoke-CheckUserExistsInAOS"></a>
# **Invoke-CheckUserExistsInAOS**
> Boolean Invoke-CheckUserExistsInAOS<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

check user exists in Aos

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



$Name = "Name_example" # String |  (default to null)

# check user exists in Aos
try {
    $Result = Invoke-CheckUserExistsInAOS -Name $Name
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Name** | **String**|  | [default to null]

### Return type

**Boolean**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AzureAdUserPropertyValue"></a>
# **Get-AzureAdUserPropertyValue**
> StringModel Get-AzureAdUserPropertyValue<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PropertyName] <String><br>

get user's property value by property name from azure ad

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



$Username = "Username_example" # String |  (default to null)
$PropertyName = "PropertyName_example" # String |  (default to null)

# get user's property value by property name from azure ad
try {
    $Result = Get-AzureAdUserPropertyValue -Username $Username -PropertyName $PropertyName
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | [default to null]
 **PropertyName** | **String**|  | [default to null]

### Return type

[**StringModel**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UpsUserPropertyValue"></a>
# **Get-UpsUserPropertyValue**
> StringModel Get-UpsUserPropertyValue<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PropertyName] <String><br>

get user's property value by property name from user profile service

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



$Username = "Username_example" # String |  (default to null)
$PropertyName = "PropertyName_example" # String |  (default to null)

# get user's property value by property name from user profile service
try {
    $Result = Get-UpsUserPropertyValue -Username $Username -PropertyName $PropertyName
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | [default to null]
 **PropertyName** | **String**|  | [default to null]

### Return type

[**StringModel**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UserBasicProperties"></a>
# **Get-UserBasicProperties**
> void Get-UserBasicProperties<br>

get my basic properties, City, Country, Office, Department, JobTitle,State

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




# get my basic properties, City, Country, Office, Department, JobTitle,State
try {
    Get-UserBasicProperties
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

<a name="Get-UserBasicPropertyValue"></a>
# **Get-UserBasicPropertyValue**
> void Get-UserBasicPropertyValue<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

get my basic property value, Department, Email, DisplayName, Manager

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



$Name = "Name_example" # String |  (default to null)

# get my basic property value, Department, Email, DisplayName, Manager
try {
    Get-UserBasicPropertyValue -Name $Name
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Name** | **String**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UserPhoto"></a>
# **Get-UserPhoto**
> void Get-UserPhoto<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Size] <String><br>

get user's photo

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



$Username = "Username_example" # String |  (default to null)
$Size = "Size_example" # String |  (optional) (default to 48x48)

# get user's photo
try {
    Get-UserPhoto -Username $Username -Size $Size
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | [default to null]
 **Size** | **String**|  | [optional] [default to 48x48]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UserRelationship"></a>
# **Get-UserRelationship**
> UserRelationShip Get-UserRelationship<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>

get user relationship

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



$Username = "Username_example" # String |  (default to null)

# get user relationship
try {
    $Result = Get-UserRelationship -Username $Username
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | [default to null]

### Return type

[**UserRelationShip**](UserRelationShip.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UsersFromSharePoint"></a>
# **Get-UsersFromSharePoint**
> ApiUser Get-UsersFromSharePoint<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Username] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestBody] <String[]><br>

get users from sharepoint

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



$Username = "Username_example" # String |  (optional) (default to null)
$RequestBody = @("Property_example") # String[] |  (optional)

# get users from sharepoint
try {
    $Result = Get-UsersFromSharePoint -Username $Username -RequestBody $RequestBody
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Username** | **String**|  | [optional] [default to null]
 **RequestBody** | [**String[]**](String.md)|  | [optional] 

### Return type

[**ApiUser**](ApiUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-Users"></a>
# **Resolve-Users**
> ApiUser[] Resolve-Users<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Keyword] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserType] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserSource] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SharingOptions] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrlOrTenantId] <String><br>

resolve users

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



$Keyword = "Keyword_example" # String |  (default to null)
$UserType = (New-UserType) # UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4 (default to null)
$UserSource = (New-UserSource) # UserSource | All=0, Local=1, Azure=2, SharePoint=3 (default to null)
$SharingOptions = (New-ExternalSharingOptions) # ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3 (default to null)
$SiteUrlOrTenantId = "SiteUrlOrTenantId_example" # String |  (optional) (default to )

# resolve users
try {
    $Result = Resolve-Users -Keyword $Keyword -UserType $UserType -UserSource $UserSource -SharingOptions $SharingOptions -SiteUrlOrTenantId $SiteUrlOrTenantId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Keyword** | **String**|  | [default to null]
 **UserType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | [default to null]
 **UserSource** | [**UserSource**](UserSource.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | [default to null]
 **SharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | [default to null]
 **SiteUrlOrTenantId** | **String**|  | [optional] [default to ]

### Return type

[**ApiUser[]**](ApiUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Resolve-UsersWithExternalSharingOption"></a>
# **Resolve-UsersWithExternalSharingOption**
> SharingEnabledUser[] Resolve-UsersWithExternalSharingOption<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Keyword] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrlOrTenantId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExternalSharingOption] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserType] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserSource] <PSCustomObject><br>

resolve user including external users

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



$Keyword = "Keyword_example" # String |  (default to null)
$SiteUrlOrTenantId = "SiteUrlOrTenantId_example" # String |  (default to null)
$ExternalSharingOption = (New-ExternalSharingOptions) # ExternalSharingOptions |  (default to null)
$UserType = (New-UserType) # UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4 (default to null)
$UserSource = (New-UserSource) # UserSource | All=0, Local=1, Azure=2, SharePoint=3 (default to null)

# resolve user including external users
try {
    $Result = Resolve-UsersWithExternalSharingOption -Keyword $Keyword -SiteUrlOrTenantId $SiteUrlOrTenantId -ExternalSharingOption $ExternalSharingOption -UserType $UserType -UserSource $UserSource
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Keyword** | **String**|  | [default to null]
 **SiteUrlOrTenantId** | **String**|  | [default to null]
 **ExternalSharingOption** | [**ExternalSharingOptions**](ExternalSharingOptions.md)|  | [default to null]
 **UserType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | [default to null]
 **UserSource** | [**UserSource**](UserSource.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | [default to null]

### Return type

[**SharingEnabledUser[]**](SharingEnabledUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Search-Users"></a>
# **Search-Users**
> ApiUser[] Search-Users<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Keyword] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserType] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserSource] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SharingOptions] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrlOrTenantId] <String><br>

search users

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



$Keyword = "Keyword_example" # String |  (default to null)
$UserType =  # UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4 (default to null)
$UserSource =  # UserSource | All=0, Local=1, Azure=2, SharePoint=3 (default to null)
$SharingOptions =  # ExternalSharingOptions | Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3 (default to null)
$SiteUrlOrTenantId = "SiteUrlOrTenantId_example" # String |  (optional) (default to )

# search users
try {
    Result = Search-Users -Keyword $Keyword -UserType $UserType -UserSource $UserSource -SharingOptions $SharingOptions -SiteUrlOrTenantId $SiteUrlOrTenantId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Keyword** | **String**|  | [default to null]
 **UserType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | [default to null]
 **UserSource** | [**UserSource**](UserSource.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | [default to null]
 **SharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md)| Disabled&#x3D;0, VerifiedGuestUser&#x3D;1, Anyone&#x3D;2, ExistingGuestUser&#x3D;3 | [default to null]
 **SiteUrlOrTenantId** | **String**|  | [optional] [default to ]

### Return type

[**ApiUser[]**](ApiUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Search-UsersWithExternalSharingOption"></a>
# **Search-UsersWithExternalSharingOption**
> SharingEnabledUser[] Search-UsersWithExternalSharingOption<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Keyword] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrlOrTenantId] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExternalSharingOption] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserType] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UserSource] <PSCustomObject><br>

search user including external users

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



$Keyword = "Keyword_example" # String |  (default to null)
$SiteUrlOrTenantId = "SiteUrlOrTenantId_example" # String |  (default to null)
$ExternalSharingOption =  # ExternalSharingOptions |  (default to null)
$UserType =  # UserType | All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4 (default to null)
$UserSource =  # UserSource | All=0, Local=1, Azure=2, SharePoint=3 (default to null)

# search user including external users
try {
    $Result = Search-UsersWithExternalSharingOption -Keyword $Keyword -SiteUrlOrTenantId $SiteUrlOrTenantId -ExternalSharingOption $ExternalSharingOption -UserType $UserType -UserSource $UserSource
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Keyword** | **String**|  | [default to null]
 **SiteUrlOrTenantId** | **String**|  | [default to null]
 **ExternalSharingOption** | [**ExternalSharingOptions**](ExternalSharingOptions.md)|  | [default to null]
 **UserType** | [**UserType**](UserType.md)| All&#x3D;0, User&#x3D;1, Group&#x3D;2, DistributionList&#x3D;3, UserAndGroup&#x3D;4 | [default to null]
 **UserSource** | [**UserSource**](UserSource.md)| All&#x3D;0, Local&#x3D;1, Azure&#x3D;2, SharePoint&#x3D;3 | [default to null]

### Return type

[**SharingEnabledUser[]**](SharingEnabledUser.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-UserInfo"></a>
# **Update-UserInfo**
> void Update-UserInfo<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UpdatableApiUser] <PSCustomObject><br>



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



$UpdatableApiUser = (New-UpdatableApiUser -Email "Email_example"  -JobTitle "JobTitle_example"  -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false) # UpdatableApiUser |  (optional)

try {
    Update-UserInfo -UpdatableApiUser $UpdatableApiUser
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UpdatableApiUser** | [**UpdatableApiUser**](UpdatableApiUser.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

