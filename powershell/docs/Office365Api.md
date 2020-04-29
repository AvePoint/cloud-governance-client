# Cloud.Governance.Client.Cloud.Governance.Client\Api.Office365Api

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-GroupInfo**](Office365Api.md#Get-GroupInfo) | **GET** /office365/groups/{tenantid}/{id} | get group information
[**Get-GroupMembers**](Office365Api.md#Get-GroupMembers) | **GET** /office365/groups/{email}/members | get group members by group email
[**Get-GroupMembersByGroupName**](Office365Api.md#Get-GroupMembersByGroupName) | **GET** /office365/groups/members | get group members by group name
[**Get-GroupOwners**](Office365Api.md#Get-GroupOwners) | **GET** /office365/groups/{email}/owners | get group owners by group email
[**Get-HubSites**](Office365Api.md#Get-HubSites) | **GET** /office365/hubsites/{tenantid} | get all hubsites from a specific tenant
[**Get-HubSitesFromTenantOfSite**](Office365Api.md#Get-HubSitesFromTenantOfSite) | **GET** /office365/hubsites | get all hubsites from site&#39;s tenant
[**Get-OwnedTeams**](Office365Api.md#Get-OwnedTeams) | **GET** /office365/teams/my | get all teams that owner is curernt user
[**Get-Permissions**](Office365Api.md#Get-Permissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
[**Get-RoleAssignment**](Office365Api.md#Get-RoleAssignment) | **GET** /office365/roleassignment | get site permimssion role assignment
[**Get-SiteDesigns**](Office365Api.md#Get-SiteDesigns) | **GET** /office365/sitedesigns | get site designs by site url
[**Get-SiteInfo**](Office365Api.md#Get-SiteInfo) | **GET** /office365/sites | get site collection information with url
[**Get-SitePermissionLevels**](Office365Api.md#Get-SitePermissionLevels) | **GET** /office365/sites/permissionlevels | get site permission levels
[**Get-SiteSharePointGroups**](Office365Api.md#Get-SiteSharePointGroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
[**Get-SiteTemplates**](Office365Api.md#Get-SiteTemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
[**Get-YammerGroup**](Office365Api.md#Get-YammerGroup) | **GET** /office365/yammergroup/{networkid}/{name} | get yammer group
[**Invoke-LoadContainers**](Office365Api.md#Invoke-LoadContainers) | **GET** /office365/containers/{serviceid} | load the containers from cloud management
[**Invoke-LoadFolders**](Office365Api.md#Invoke-LoadFolders) | **GET** /office365/folders/{listid} | load sharepoint folders
[**Invoke-LoadItems**](Office365Api.md#Invoke-LoadItems) | **GET** /office365/items/{listid} | load sharepoint items
[**Invoke-LoadLists**](Office365Api.md#Invoke-LoadLists) | **GET** /office365/lists | load sharepoint lists
[**Invoke-LoadManagedMetadata**](Office365Api.md#Invoke-LoadManagedMetadata) | **GET** /office365/managedmetadata/{termStoreid}/{groupid}/{termsetid}/{parentid} | load managed metadata terms
[**Invoke-LoadManagedSites**](Office365Api.md#Invoke-LoadManagedSites) | **GET** /office365/managedsites/{serviceid}/{containerid}/{isselected} | load sharepoint sites
[**Invoke-LoadWebs**](Office365Api.md#Invoke-LoadWebs) | **GET** /office365/webs/{serviceid}/{siteorwebid}/{isselected}/{issite} | load sharepoint webs


<a name="Get-GroupInfo"></a>
# **Get-GroupInfo**
> AzureADGroup Get-GroupInfo<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tenantid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <String><br>

get group information

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



$Tenantid = "Tenantid_example" # String |  (default to null)
$Id = "Id_example" # String |  (default to null)

# get group information
try {
    $Result = Get-GroupInfo -Tenantid $Tenantid -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Tenantid** | **String**|  | [default to null]
 **Id** | **String**|  | [default to null]

### Return type

[**AzureADGroup**](AzureADGroup.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembers"></a>
# **Get-GroupMembers**
> ApiUserPageResult Get-GroupMembers<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Email] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get group members by group email

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



$Email = "Email_example" # String |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# get group members by group email
try {
    $Result = Get-GroupMembers -Email $Email -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Email** | **String**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupMembersByGroupName"></a>
# **Get-GroupMembersByGroupName**
> ApiUserPageResult Get-GroupMembersByGroupName<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Url] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get group members by group name

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



$Url = "Url_example" # String |  (default to null)
$Name = "Name_example" # String |  (optional) (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# get group members by group name
try {
    $Result = Get-GroupMembersByGroupName -Url $Url -Name $Name -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Url** | **String**|  | [default to null]
 **Name** | **String**|  | [optional] [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupOwners"></a>
# **Get-GroupOwners**
> ApiUserPageResult Get-GroupOwners<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Email] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get group owners by group email

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



$Email = "Email_example" # String |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# get group owners by group email
try {
    $Result = Get-GroupOwners -Email $Email -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Email** | **String**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-HubSites"></a>
# **Get-HubSites**
> GuidModel[] Get-HubSites<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tenantid] <PSCustomObject><br>

get all hubsites from a specific tenant

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



$Tenantid = TODO # UUID |  (default to null)

# get all hubsites from a specific tenant
try {
    $Result = Get-HubSites -Tenantid $Tenantid
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Tenantid** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**GuidModel[]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-HubSitesFromTenantOfSite"></a>
# **Get-HubSitesFromTenantOfSite**
> GuidModel[] Get-HubSitesFromTenantOfSite<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrl] <URI><br>

get all hubsites from site's tenant

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



$SiteUrl = TODO # URI | any site url in your tenant (optional) (default to null)

# get all hubsites from site's tenant
try {
    $Result = Get-HubSitesFromTenantOfSite -SiteUrl $SiteUrl
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SiteUrl** | **URI**| any site url in your tenant | [optional] [default to null]

### Return type

[**GuidModel[]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-OwnedTeams"></a>
# **Get-OwnedTeams**
> GuidModel[] Get-OwnedTeams<br>

get all teams that owner is curernt user

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




# get all teams that owner is curernt user
try {
    $Result = Get-OwnedTeams
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GuidModel[]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Permissions"></a>
# **Get-Permissions**
> UserGroupPermissions Get-Permissions<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-WebUrl] <String><br>

get web permissions for creating list request by web url

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



$WebUrl = "WebUrl_example" # String |  (default to null)

# get web permissions for creating list request by web url
try {
    $Result = Get-Permissions -WebUrl $WebUrl
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **WebUrl** | **String**|  | [default to null]

### Return type

[**UserGroupPermissions**](UserGroupPermissions.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-RoleAssignment"></a>
# **Get-RoleAssignment**
> SPRoleAssignment[] Get-RoleAssignment<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Url] <URI><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Type] <PSCustomObject><br>

get site permimssion role assignment

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



$Url = TODO # URI |  (default to null)
$Type = (New-NodeType) # NodeType |  (default to null)

# get site permimssion role assignment
try {
    $Result = Get-RoleAssignment -Url $Url -Type $Type
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Url** | **URI**|  | [default to null]
 **Type** | [**NodeType**](NodeType.md)|  | [default to null]

### Return type

[**SPRoleAssignment[]**](SPRoleAssignment.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteDesigns"></a>
# **Get-SiteDesigns**
> StringModel[] Get-SiteDesigns<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteUrl] <URI><br>

get site designs by site url

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



$SiteUrl = TODO # URI |  (optional) (default to null)

# get site designs by site url
try {
    $Result = Get-SiteDesigns -SiteUrl $SiteUrl
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SiteUrl** | **URI**|  | [optional] [default to null]

### Return type

[**StringModel[]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteInfo"></a>
# **Get-SiteInfo**
> SiteInfo Get-SiteInfo<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-FullUrl] <URI><br>

get site collection information with url

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



$FullUrl = TODO # URI |  (default to null)

# get site collection information with url
try {
    $Result = Get-SiteInfo -FullUrl $FullUrl
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **FullUrl** | **URI**|  | [default to null]

### Return type

[**SiteInfo**](SiteInfo.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePermissionLevels"></a>
# **Get-SitePermissionLevels**
> PermissionLevel[] Get-SitePermissionLevels<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Uri] <URI><br>

get site permission levels

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



$Uri = TODO # URI |  (default to null)

# get site permission levels
try {
    $Result = Get-SitePermissionLevels -Uri $Uri
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Uri** | **URI**|  | [default to null]

### Return type

[**PermissionLevel[]**](PermissionLevel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteSharePointGroups"></a>
# **Get-SiteSharePointGroups**
> SPGroup[] Get-SiteSharePointGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Uri] <URI><br>

get site sharePoint groups

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



$Uri = TODO # URI |  (default to null)

# get site sharePoint groups
try {
    $Result = Get-SiteSharePointGroups -Uri $Uri
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Uri** | **URI**|  | [default to null]

### Return type

[**SPGroup[]**](SPGroup.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteTemplates"></a>
# **Get-SiteTemplates**
> SiteTemplate[] Get-SiteTemplates<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Languageid] <Int32><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Url] <URI><br>

get site templates with language code identifier

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



$Languageid = 987 # Int32 |  (default to null)
$Url = TODO # URI |  (optional) (default to null)

# get site templates with language code identifier
try {
    $Result = Get-SiteTemplates -Languageid $Languageid -Url $Url
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Languageid** | **Int32**|  | [default to null]
 **Url** | **URI**|  | [optional] [default to null]

### Return type

[**SiteTemplate[]**](SiteTemplate.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-YammerGroup"></a>
# **Get-YammerGroup**
> YammerGroup Get-YammerGroup<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Networkid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

get yammer group

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



$Networkid = "Networkid_example" # String |  (default to null)
$Name = "Name_example" # String |  (default to null)

# get yammer group
try {
    $Result = Get-YammerGroup -Networkid $Networkid -Name $Name
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Networkid** | **String**|  | [default to null]
 **Name** | **String**|  | [default to null]

### Return type

[**YammerGroup**](YammerGroup.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadContainers"></a>
# **Invoke-LoadContainers**
> SPNodePageResult Invoke-LoadContainers<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Serviceid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load the containers from cloud management

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



$Serviceid = "Serviceid_example" # String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load the containers from cloud management
try {
    $Result = Invoke-LoadContainers -Serviceid $Serviceid -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadFolders"></a>
# **Invoke-LoadFolders**
> SPNodePageResult Invoke-LoadFolders<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Listid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Folderorlisturl] <URI><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load sharepoint folders

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



$Listid = TODO # UUID |  (default to null)
$Folderorlisturl = TODO # URI |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load sharepoint folders
try {
    $Result = Invoke-LoadFolders -Listid $Listid -Folderorlisturl $Folderorlisturl -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Listid** | [**UUID**](UUID.md)|  | [default to null]
 **Folderorlisturl** | **URI**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadItems"></a>
# **Invoke-LoadItems**
> SPNodePageResult Invoke-LoadItems<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Listid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Folderorlisturl] <URI><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load sharepoint items

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



$Listid = TODO # UUID |  (default to null)
$Folderorlisturl = TODO # URI |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load sharepoint items
try {
    $Result = Invoke-LoadItems -Listid $Listid -Folderorlisturl $Folderorlisturl -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Listid** | [**UUID**](UUID.md)|  | [default to null]
 **Folderorlisturl** | **URI**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadLists"></a>
# **Invoke-LoadLists**
> SPNodePageResult Invoke-LoadLists<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Siteorweburl] <URI><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load sharepoint lists

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



$Siteorweburl = TODO # URI |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load sharepoint lists
try {
    $Result = Invoke-LoadLists -Siteorweburl $Siteorweburl -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Siteorweburl** | **URI**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadManagedMetadata"></a>
# **Invoke-LoadManagedMetadata**
> ApiTermInfoPageResult Invoke-LoadManagedMetadata<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TermStoreid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Groupid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Termsetid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Parentid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Admincenterurl] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load managed metadata terms

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



$TermStoreid = TODO # UUID |  (default to null)
$Groupid = TODO # UUID |  (default to null)
$Termsetid = TODO # UUID |  (default to null)
$Parentid = TODO # UUID |  (default to null)
$Admincenterurl = "Admincenterurl_example" # String |  (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load managed metadata terms
try {
    $Result = Invoke-LoadManagedMetadata -TermStoreid $TermStoreid -Groupid $Groupid -Termsetid $Termsetid -Parentid $Parentid -Admincenterurl $Admincenterurl -Skip $Skip -Top $Top -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TermStoreid** | [**UUID**](UUID.md)|  | [default to null]
 **Groupid** | [**UUID**](UUID.md)|  | [default to null]
 **Termsetid** | [**UUID**](UUID.md)|  | [default to null]
 **Parentid** | [**UUID**](UUID.md)|  | [default to null]
 **Admincenterurl** | **String**|  | [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**ApiTermInfoPageResult**](ApiTermInfoPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadManagedSites"></a>
# **Invoke-LoadManagedSites**
> SPNodePageResult Invoke-LoadManagedSites<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Serviceid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Containerid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Isselected] <Boolean><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load sharepoint sites

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



$Serviceid = "Serviceid_example" # String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree (default to null)
$Containerid = TODO # UUID |  (default to null)
$Isselected = true # Boolean |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load sharepoint sites
try {
    $Result = Invoke-LoadManagedSites -Serviceid $Serviceid -Containerid $Containerid -Isselected $Isselected -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | [default to null]
 **Containerid** | [**UUID**](UUID.md)|  | [default to null]
 **Isselected** | **Boolean**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadWebs"></a>
# **Invoke-LoadWebs**
> SPNodePageResult Invoke-LoadWebs<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Serviceid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Siteorwebid] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Isselected] <Boolean><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Issite] <Boolean><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteOrWebUrl] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

load sharepoint webs

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



$Serviceid = "Serviceid_example" # String | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree (default to null)
$Siteorwebid = TODO # UUID |  (default to null)
$Isselected = true # Boolean |  (default to null)
$Issite = true # Boolean |  (default to null)
$SiteOrWebUrl = "SiteOrWebUrl_example" # String |  (default to null)
$Top = 987 # Int32 |  (optional) (default to null)
$Skip = 987 # Int32 |  (optional) (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# load sharepoint webs
try {
    $Result = Invoke-LoadWebs -Serviceid $Serviceid -Siteorwebid $Siteorwebid -Isselected $Isselected -Issite $Issite -SiteOrWebUrl $SiteOrWebUrl -Top $Top -Skip $Skip -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Serviceid** | **String**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | [default to null]
 **Siteorwebid** | [**UUID**](UUID.md)|  | [default to null]
 **Isselected** | **Boolean**|  | [default to null]
 **Issite** | **Boolean**|  | [default to null]
 **SiteOrWebUrl** | **String**|  | [default to null]
 **Top** | **Int32**|  | [optional] [default to null]
 **Skip** | **Int32**|  | [optional] [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

