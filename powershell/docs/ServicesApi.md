# Cloud.Governance.Client.Cloud.Governance.Client\Api.ServicesApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add-CreateListService**](ServicesApi.md#Add-CreateListService) | **POST** /services/createsite | Add create site service
[**Get-ChangeGroupSettingService**](ServicesApi.md#Get-ChangeGroupSettingService) | **GET** /services/changegroupsetting/{id} | get change group setting service
[**Get-ChangeListSettingService**](ServicesApi.md#Get-ChangeListSettingService) | **GET** /services/changelistsetting/{id} | get change list setting service
[**Get-ChangePermissionService**](ServicesApi.md#Get-ChangePermissionService) | **GET** /services/changepermission/{id} | get change permission service
[**Get-ChangeSiteContactService**](ServicesApi.md#Get-ChangeSiteContactService) | **GET** /services/changesitecontact/{id} | get change site contact service
[**Get-ChangeSiteSettingService**](ServicesApi.md#Get-ChangeSiteSettingService) | **GET** /services/changesitesetting/{id} | get change site setting service
[**Get-ChangeWebContactService**](ServicesApi.md#Get-ChangeWebContactService) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
[**Get-ChangeWebSettingsService**](ServicesApi.md#Get-ChangeWebSettingsService) | **GET** /services/changewebsettings/{id} | get change web setting service
[**Get-ClonePermissionService**](ServicesApi.md#Get-ClonePermissionService) | **GET** /services/clonepermission/{id} | get clone permission service
[**Get-ContentMoveProfiles**](ServicesApi.md#Get-ContentMoveProfiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
[**Get-ContentMoveService**](ServicesApi.md#Get-ContentMoveService) | **GET** /services/contentmove/{id} | get content move service
[**Get-CreateGroupService**](ServicesApi.md#Get-CreateGroupService) | **GET** /services/creategroup/{id} | get create group service
[**Get-CreateListService**](ServicesApi.md#Get-CreateListService) | **GET** /services/createlist/{id} | get create list service
[**Get-CreateSiteService**](ServicesApi.md#Get-CreateSiteService) | **GET** /services/createsite/{id} | get create site service
[**Get-CreateWebService**](ServicesApi.md#Get-CreateWebService) | **GET** /services/createweb/{id} | get create web service
[**Get-CustomService**](ServicesApi.md#Get-CustomService) | **GET** /services/custom/{id} | get custom service
[**Get-GrantPermissionService**](ServicesApi.md#Get-GrantPermissionService) | **GET** /services/grantpermission/{id} | get grant permission service
[**Get-GroupLifecycleService**](ServicesApi.md#Get-GroupLifecycleService) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
[**Get-GroupPolicyExpirationSetting**](ServicesApi.md#Get-GroupPolicyExpirationSetting) | **GET** /services/grouplifecycle/{id}/policyexpirationsetting | get the group policy expiration setting
[**Get-ManagePermissionService**](ServicesApi.md#Get-ManagePermissionService) | **GET** /services/managepermission/{id} | get manage permission service
[**Get-MyQuickServices**](ServicesApi.md#Get-MyQuickServices) | **GET** /services/my/quick | get configued quick services that can be used to start a request
[**Get-MyServices**](ServicesApi.md#Get-MyServices) | **GET** /services/my | get services that can be used to start a request
[**Get-MyServicesWithContext**](ServicesApi.md#Get-MyServicesWithContext) | **GET** /services/my/workspace/{objecttype}/{objectid} | get services that can be used to start a request within context
[**Get-SiteLifecycleService**](ServicesApi.md#Get-SiteLifecycleService) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
[**Get-SitePolicyExpirationSetting**](ServicesApi.md#Get-SitePolicyExpirationSetting) | **GET** /services/sitelifecycle/{id}/policyexpirationsetting | get the site collection policy expiration setting
[**Get-WebLifecycleService**](ServicesApi.md#Get-WebLifecycleService) | **GET** /services/weblifecycle/{id} | get web lifecycle service
[**Invoke-ValidateForChangeGroupSettingService**](ServicesApi.md#Invoke-ValidateForChangeGroupSettingService) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
[**Invoke-ValidateForChangeListSettingService**](ServicesApi.md#Invoke-ValidateForChangeListSettingService) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
[**Invoke-ValidateForChangePermissionService**](ServicesApi.md#Invoke-ValidateForChangePermissionService) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
[**Invoke-ValidateForChangeSiteContactService**](ServicesApi.md#Invoke-ValidateForChangeSiteContactService) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
[**Invoke-ValidateForChangeSiteSettingService**](ServicesApi.md#Invoke-ValidateForChangeSiteSettingService) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
[**Invoke-ValidateForChangeWebContactService**](ServicesApi.md#Invoke-ValidateForChangeWebContactService) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
[**Invoke-ValidateForChangeWebSettingService**](ServicesApi.md#Invoke-ValidateForChangeWebSettingService) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
[**Invoke-ValidateForClonePermissionService**](ServicesApi.md#Invoke-ValidateForClonePermissionService) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
[**Invoke-ValidateForContentMoveService**](ServicesApi.md#Invoke-ValidateForContentMoveService) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
[**Invoke-ValidateForCreateListService**](ServicesApi.md#Invoke-ValidateForCreateListService) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
[**Invoke-ValidateForCreateWebService**](ServicesApi.md#Invoke-ValidateForCreateWebService) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
[**Invoke-ValidateForGrantPermissionService**](ServicesApi.md#Invoke-ValidateForGrantPermissionService) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
[**Invoke-ValidateForGroupLifecycleService**](ServicesApi.md#Invoke-ValidateForGroupLifecycleService) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
[**Invoke-ValidateForManagePermissionService**](ServicesApi.md#Invoke-ValidateForManagePermissionService) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
[**Invoke-ValidateForSiteLifecycleService**](ServicesApi.md#Invoke-ValidateForSiteLifecycleService) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
[**Invoke-ValidateForWebLifecycleService**](ServicesApi.md#Invoke-ValidateForWebLifecycleService) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service


<a name="Add-CreateListService"></a>
# **Add-CreateListService**
> UUID Add-CreateListService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateSiteService] <PSCustomObject><br>

Add create site service

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



$CreateSiteService = (New-CreateSiteService -ScopeSettings (New-ServiceScopeSettings -SelectedNodes @((New-SPNode -Id "TODO"  -FullUrl "FullUrl_example"  -Type (New-NodeType)  -Name "Name_example"  -Title "Title_example"  -IsSelected $false))  -AutoPopulateUrlWithSPContext $false  -AutoPopulateUrlWithSPContextAssignBy (New-AssignBy))  -AdminCenterUrl "AdminCenterUrl_example"  -SiteLanguages @((New-IntModel -Id 123  -Name "Name_example"  -Description "Description_example"))  -RootSiteAndManagedPaths @((New-RootSiteWithManagedPaths -RootSite "RootSite_example"  -ManagedPaths @("ManagedPaths_example")))  -SiteUrlSetting (New-SiteUrlSetting -Type (New-SiteConstructUrlType)  -ManuallyInputSetting (New-ManuallyInputUrlSetting -EnableConstructUrl $false  -EnableUrlValidation $false  -ConstructUrlAssignBy (New-AssignBy)  -ValidationRule (New-TextValidationRuleRef -Id "TODO"  -Name "Name_example"  -Expression "Expression_example"  -ErrorMessage "ErrorMessage_example")  -Rules @("Rules_example")  -Suffix "Suffix_example"  -Connection "Connection_example"  -ContructUrlAssignBy )  -AutoGenerateUrlSetting (New-AutoGenerateUrlSetting -GenerateUrlType (New-AutoGenerateUrlType)  -SequentialNumberingSettings (New-UrlSequentialNumberingSettings -Prefix "Prefix_example"  -Delimiter "Delimiter_example"  -SequenceNumber "SequenceNumber_example")  -RandomStringSettings (New-UrlRandomStringSettings -Prefix "Prefix_example"  -MaxLength 123  -MinLength 123)))  -MultiGeoSetting (New-MultiGeoSerivceSetting -IsMultiGeoTenant $false  -AllLocations @((New-GeoLocationModel -RootSiteUrl "RootSiteUrl_example"  -TenantAdminUrl "TenantAdminUrl_example"  -Name "Name_example"  -DisplayName "DisplayName_example"))  -IsEnabled $false  -ControlMode (New-MultiGeoControlMode)  -DefaultLocation (New-GeoLocationBase -Name "Name_example"  -DisplayName "DisplayName_example")  -SelectedLocations @((New-GeoLocationBase -Name "Name_example"  -DisplayName "DisplayName_example"))  -LocationAssignBy   -UserRoleForLocation "UserRoleForLocation_example")  -SiteTitleSetting (New-SiteTitleSetting -TitleAssignBy 123  -EnableTitleConstructure $false  -TitlePrefixes @((New-SiteTitleConstructureRule -Type (New-SiteConstructTitleType)  -Value "Value_example"))  -TitleSuffixes @((New-SiteTitleConstructureRule -Type (New-SiteConstructTitleType)  -Value "Value_example")))  -Policies @((New-PolicyRef -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Category "Category_example"  -TenantId "TODO"  -Status (New-CommonStatus)))  -DeploymentManagerPlanSettings (New-DeploymentManagerPlanSettings -Enabled $false  -Plans @("Plans_example")  -AssignBy   -Default "Default_example")  -PolicyIdsAndTemplates @((New-PolicyWithTemplates -PolicyId "TODO"  -DefaultTemplate "DefaultTemplate_example"  -Templates @((New-SiteTemplate -Id "Id_example"  -Title "Title_example"  -Category "Category_example"))))  -TemplateIdsAndPermissions @((New-TemplateWithPermissions -TemplateId "TemplateId_example"  -IsUseCommon $false  -UserPermissions @((New-ServiceUserWithPermissions -UserAssignBy   -User (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -PermissionLevels @((New-PermissionLevel -Id "TODO"  -IdInSharePoint 123  -Name "Name_example"  -Description "Description_example"  -IsExcluded $false))))  -GroupPermissions @((New-ServiceGroupWithPermissions -UsersAssignBy   -GroupOwnerAssignBy   -AllowChangePermissionLevel $false  -Removable $false  -Name "Name_example"  -Description "Description_example"  -Users @((New-GroupUser -IsEnforce $false  -IsHide $false  -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false))  -PermissionLevels @((New-PermissionLevel -Id "TODO"  -IdInSharePoint 123  -Name "Name_example"  -Description "Description_example"  -IsExcluded $false))  -GroupOwner (New-ApiUser -Id "Id_example"  -LoginName "LoginName_example"  -DisplayName "DisplayName_example"  -IsGroup $false  -Email "Email_example"  -JobTitle "JobTitle_example"  -PhysicalDeliveryOfficeName "PhysicalDeliveryOfficeName_example"  -IsOtherTenantUser $false)  -GroupOwnerType (New-GroupOwnerType)  -BuildInGroupType (New-SharePointBuildInGroupType)))))  -PermissionSettings (New-PermissionSettings -AllowGrantUserPermission $false  -PreventGrantSpecificPermissionLevels $false  -PreventPermissionLevles @())  -LeasePeriodSettings (New-SiteLeasePeriodServiceSettings -LeasePeriodAssignBy   -LeaseWarningAssignBy   -LeaseEnabled $false  -LeaseWarningEnabled $false  -ApprovalProcessId "TODO"  -LeaseInterval 123  -LeaseDurationType (New-ApiDurationType)  -LeaseWarningInterval 123  -LeaseWarningDurationType (New-ApiDurationType))  -TimeZones @((New-IntModel -Id 123  -Name "Name_example"  -Description "Description_example"))  -YammerGroupSettings (New-YammerGroupServiceSettings -NetworkId "NetworkId_example"  -AllowCreate $false  -AllowReuseExisting $false  -Enabled $false  -CreateNewGroupAssignBy   -NameOrId "NameOrId_example"  -Description "Description_example"  -Type (New-YammerGroupType)  -JoinType (New-YammerGroupJoinType)  -IsListInDirectory $false  -IsGroupAlreadyExisted $false)  -Classifications @("Classifications_example")  -HubSiteSettings (New-HubSiteSettings -Enabled $false  -Action (New-ConvertHubSiteActionType)  -AssociatedHubSiteId "TODO"  -AssociatedHubSiteTitle "AssociatedHubSiteTitle_example")  -EnabledCustomTemplate $false  -CustomSiteTemplateListURL "CustomSiteTemplateListURL_example"  -DefaultPrimaryAdmin   -DefaultAdditionalAdmins @()  -DefaultPrimaryAdminReal   -DefaultAdditionalAdminsReal @()  -DefaultPrimaryContact   -DefaultSecondaryContact   -DefaultSiteLanguage 123  -DefaultRootSite "DefaultRootSite_example"  -DefaultManagedPath "DefaultManagedPath_example"  -DefaultPolicy "TODO"  -DefaultTemplate "DefaultTemplate_example"  -DefaultTimeZone 123  -DefaultClassification "DefaultClassification_example"  -DefaultDesignType "DefaultDesignType_example"  -SiteLanguageAssignBy   -TemplateAssignBy   -PolicyAssignBy   -PermissionAssignBy   -RootSiteAndManagedPathAssignBy   -TimeZoneAssignBy   -PrimaryAdminAssignBy   -AdditionalAdminAssignBy   -PrimaryContactAssignBy   -SecondaryContactAssignBy   -DesignTypeAssignBy   -ClassificationAssignBy   -HubSiteAssignBy   -DepartmentAssignBy   -Metadatas @((New-CustomMetadata -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Type (New-MetadataFieldType)  -DisplayType (New-DisplayInReportType)  -AssignBy   -EnableTextValidation $false  -TextValidationRule (New-TextValidationRuleRef -Id "TODO"  -Name "Name_example"  -Expression "Expression_example"  -ErrorMessage "ErrorMessage_example")  -BooleanMetadataSettings (New-BooleanMetadataSettings -EnableTerms $false  -Value $false  -TermsAndConditions "TermsAndConditions_example")  -TermsMetadataSettings (New-TermsMetadataSettings -AllowMultiple $false  -AdminCenter "AdminCenter_example"  -Value @((New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"))  -TermStore (New-GuidModel -Id "TODO"  -Name "Name_example"  -Description "Description_example")  -TermGroup   -TermSet   -Scope )  -UserMetadataSettings (New-UserMetadataSettings -Value @()  -AllowReferenceAsRoleInApprovalProcess $false)  -UserProfileMetadataSettings (New-UserProfileMetadataSettings -AdminCenter "AdminCenter_example"  -EnableValueSync $false  -EnableRoleValueSync $false  -Value (New-LookupValue -Tenant "Tenant_example"  -Property "Property_example"  -TargetUser   -UserPropertyValue "UserPropertyValue_example"  -UserPropertyDisplayValue "UserPropertyDisplayValue_example")  -Property "Property_example"  -AllowReferenceAsRoleInApprovalProcess $false)  -AzureAdMetadataSettings (New-AzureAdMetadataSettings -Office365Tenant   -UseBuiltInProperty $false  -Value (New-LookupValue -Tenant "Tenant_example"  -Property "Property_example"  -TargetUser   -UserPropertyValue "UserPropertyValue_example"  -UserPropertyDisplayValue "UserPropertyDisplayValue_example")  -Property "Property_example"  -AllowReferenceAsRoleInApprovalProcess $false)  -ChoiceMetadataSettings (New-ChoiceMetadataSettings -Choices @("Choices_example")  -Value @("Value_example")  -ChoiceType (New-ChoiceType))  -LinkMetadataSettings (New-LinkMetadataSettings -Title "Title_example"  -Address "Address_example")  -SingleLineOrMultipleLineMetadataSettings (New-SingleLineOrMultipleLineMetadataSettings -Value "Value_example")))  -HideRequestSummary $false  -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Type (New-ServiceType)  -Department "Department_example"  -LoadDepartmentFromUps $false  -Departments @("Departments_example")  -ServiceContact   -ServiceAdminContact   -ApproversContainManagerRole $false  -Status (New-CommonStatus)  -ShowServiceInCatalog $false  -CustomActions (New-CustomActionSettings -BeforeApprovalProcessExecution (New-ExecutionModel -Enabled $false  -WebServiceAddress "WebServiceAddress_example"  -WebServiceAuthenticationType (New-WebServiceAuthenticationType)  -WebServiceAppClientId "WebServiceAppClientId_example"  -MethodName "MethodName_example"  -Arguments @((New-ExecutionParameter -Name "Name_example"  -Type "Type_example"  -Value "Value_example")))  -AfterApprovalProcessExecution (New-ExecutionModel -Enabled $false  -WebServiceAddress "WebServiceAddress_example"  -WebServiceAuthenticationType (New-WebServiceAuthenticationType)  -WebServiceAppClientId "WebServiceAppClientId_example"  -MethodName "MethodName_example"  -Arguments @((New-ExecutionParameter -Name "Name_example"  -Type "Type_example"  -Value "Value_example")))  -PostExecution   -BeforeSubmission   -WhenErrorTaskGenerated )  -ApprovalProcessId "TODO"  -LanguageId 123  -CategoryId "CategoryId_example") # CreateSiteService |  (optional)

# Add create site service
try {
    $Result = Add-CreateListService -CreateSiteService $CreateSiteService
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **CreateSiteService** | [**CreateSiteService**](CreateSiteService.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeGroupSettingService"></a>
# **Get-ChangeGroupSettingService**
> ChangeGroupSettingService Get-ChangeGroupSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get change group setting service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get change group setting service
try {
    $Result = Get-ChangeGroupSettingService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangeGroupSettingService**](ChangeGroupSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeListSettingService"></a>
# **Get-ChangeListSettingService**
> ChangeListSettingService Get-ChangeListSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get change list setting service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get change list setting service
try {
    $Result = Get-ChangeListSettingService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangeListSettingService**](ChangeListSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangePermissionService"></a>
# **Get-ChangePermissionService**
> ChangePermissionService Get-ChangePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get change permission service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get change permission service
try {
    $Result = Get-ChangePermissionService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangePermissionService**](ChangePermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeSiteContactService"></a>
# **Get-ChangeSiteContactService**
> ChangeSiteContactService Get-ChangeSiteContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get change site contact service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get change site contact service
try {
    $Result = Get-ChangeSiteContactService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangeSiteContactService**](ChangeSiteContactService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeSiteSettingService"></a>
# **Get-ChangeSiteSettingService**
> ChangeSiteSettingService Get-ChangeSiteSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get change site setting service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get change site setting service
try {
    $Result = Get-ChangeSiteSettingService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangeSiteSettingService**](ChangeSiteSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeWebContactService"></a>
# **Get-ChangeWebContactService**
> ChangeWebContactService Get-ChangeWebContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

validate permissions, scope for change web contact service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# validate permissions, scope for change web contact service
try {
    $Result = Get-ChangeWebContactService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangeWebContactService**](ChangeWebContactService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ChangeWebSettingsService"></a>
# **Get-ChangeWebSettingsService**
> ChangeWebSettingService Get-ChangeWebSettingsService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get change web setting service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get change web setting service
try {
    $Result = Get-ChangeWebSettingsService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ChangeWebSettingService**](ChangeWebSettingService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ClonePermissionService"></a>
# **Get-ClonePermissionService**
> ClonePermissionService Get-ClonePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get clone permission service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get clone permission service
try {
    $Result = Get-ClonePermissionService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ClonePermissionService**](ClonePermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ContentMoveProfiles"></a>
# **Get-ContentMoveProfiles**
> ContentMoveProfiles Get-ContentMoveProfiles<br>

get content move profiles from cloud management

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




# get content move profiles from cloud management
try {
    $Result = Get-ContentMoveProfiles
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ContentMoveProfiles**](ContentMoveProfiles.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ContentMoveService"></a>
# **Get-ContentMoveService**
> ContentMoveService Get-ContentMoveService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get content move service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get content move service
try {
    $Result = Get-ContentMoveService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ContentMoveService**](ContentMoveService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateGroupService"></a>
# **Get-CreateGroupService**
> CreateGroupService Get-CreateGroupService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get create group service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get create group service
try {
    $Result = Get-CreateGroupService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**CreateGroupService**](CreateGroupService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateListService"></a>
# **Get-CreateListService**
> CreateListService Get-CreateListService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get create list service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get create list service
try {
    $Result = Get-CreateListService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**CreateListService**](CreateListService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateSiteService"></a>
# **Get-CreateSiteService**
> CreateSiteService Get-CreateSiteService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get create site service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get create site service
try {
    $Result = Get-CreateSiteService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**CreateSiteService**](CreateSiteService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CreateWebService"></a>
# **Get-CreateWebService**
> CreateWebService Get-CreateWebService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get create web service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get create web service
try {
    $Result = Get-CreateWebService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**CreateWebService**](CreateWebService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-CustomService"></a>
# **Get-CustomService**
> ServiceForRequest Get-CustomService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get custom service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get custom service
try {
    $Result = Get-CustomService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ServiceForRequest**](ServiceForRequest.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GrantPermissionService"></a>
# **Get-GrantPermissionService**
> GrantPermissionService Get-GrantPermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get grant permission service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get grant permission service
try {
    $Result = Get-GrantPermissionService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**GrantPermissionService**](GrantPermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupLifecycleService"></a>
# **Get-GroupLifecycleService**
> GroupLifecycleService Get-GroupLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get group lifecycle service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get group lifecycle service
try {
    $Result = Get-GroupLifecycleService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**GroupLifecycleService**](GroupLifecycleService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GroupPolicyExpirationSetting"></a>
# **Get-GroupPolicyExpirationSetting**
> PolicyExpirationSettingModel Get-GroupPolicyExpirationSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get the group policy expiration setting

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

# get the group policy expiration setting
try {
    $Result = Get-GroupPolicyExpirationSetting -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**PolicyExpirationSettingModel**](PolicyExpirationSettingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ManagePermissionService"></a>
# **Get-ManagePermissionService**
> ManagePermissionService Get-ManagePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get manage permission service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get manage permission service
try {
    $Result = Get-ManagePermissionService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**ManagePermissionService**](ManagePermissionService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyQuickServices"></a>
# **Get-MyQuickServices**
> ServiceList[] Get-MyQuickServices<br>

get configued quick services that can be used to start a request

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




# get configued quick services that can be used to start a request
try {
    $Result = Get-MyQuickServices
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServiceList[]**](ServiceList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyServices"></a>
# **Get-MyServices**
> ServiceListPageResult Get-MyServices<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get services that can be used to start a request

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



$Search = "Search_example" # String |  (optional) (default to null)

# get services that can be used to start a request
try {
    $Result = Get-MyServices -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**ServiceListPageResult**](ServiceListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-MyServicesWithContext"></a>
# **Get-MyServicesWithContext**
> ServiceListPageResult Get-MyServicesWithContext<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Objecttype] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Objectid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>

get services that can be used to start a request within context

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



$Objecttype = (New-WorkspaceType) # WorkspaceType |  (default to null)
$Objectid = "Objectid_example" # String |  (default to null)
$Search = "Search_example" # String |  (optional) (default to null)

# get services that can be used to start a request within context
try {
    $Result = Get-MyServicesWithContext -Objecttype $Objecttype -Objectid $Objectid -Search $Search
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Objecttype** | [**WorkspaceType**](WorkspaceType.md)|  | [default to null]
 **Objectid** | **String**|  | [default to null]
 **Search** | **String**|  | [optional] [default to null]

### Return type

[**ServiceListPageResult**](ServiceListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SiteLifecycleService"></a>
# **Get-SiteLifecycleService**
> SiteLifecycleService Get-SiteLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get site lifecycle service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get site lifecycle service
try {
    $Result = Get-SiteLifecycleService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**SiteLifecycleService**](SiteLifecycleService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-SitePolicyExpirationSetting"></a>
# **Get-SitePolicyExpirationSetting**
> PolicyExpirationSettingModel Get-SitePolicyExpirationSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get the site collection policy expiration setting

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

# get the site collection policy expiration setting
try {
    $Result = Get-SitePolicyExpirationSetting -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**PolicyExpirationSettingModel**](PolicyExpirationSettingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-WebLifecycleService"></a>
# **Get-WebLifecycleService**
> WebLifecycleService Get-WebLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireId] <PSCustomObject><br>

get web lifecycle service

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
$QuestionnaireId = TODO # UUID |  (optional) (default to null)

# get web lifecycle service
try {
    $Result = Get-WebLifecycleService -Id $Id -QuestionnaireId $QuestionnaireId
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **QuestionnaireId** | [**UUID**](UUID.md)|  | [optional] [default to null]

### Return type

[**WebLifecycleService**](WebLifecycleService.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangeGroupSettingService"></a>
# **Invoke-ValidateForChangeGroupSettingService**
> ChangeGroupSettingCheckResult Invoke-ValidateForChangeGroupSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ChangeGroupSettingValidationParameter] <PSCustomObject><br>

validate permissions, scope for change group setting service

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
$ChangeGroupSettingValidationParameter = (New-ChangeGroupSettingValidationParameter -GroupEmail "GroupEmail_example"  -GroupId "TODO"  -IsEditTask $false  -IsFromQuestionnaire $false) # ChangeGroupSettingValidationParameter |  (optional)

# validate permissions, scope for change group setting service
try {
    $Result = Invoke-ValidateForChangeGroupSettingService -Id $Id -ChangeGroupSettingValidationParameter $ChangeGroupSettingValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ChangeGroupSettingValidationParameter** | [**ChangeGroupSettingValidationParameter**](ChangeGroupSettingValidationParameter.md)|  | [optional] 

### Return type

[**ChangeGroupSettingCheckResult**](ChangeGroupSettingCheckResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangeListSettingService"></a>
# **Invoke-ValidateForChangeListSettingService**
> ChangeListSettingValidateResult Invoke-ValidateForChangeListSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change list setting service

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
$SiteValidationParameter = (New-SiteValidationParameter -Uri "TODO"  -IgnoreLock $false  -IsEditTask $false  -IsFromQuestionnaire $false) # SiteValidationParameter |  (optional)

# validate permissions, scope for change list setting service
try {
    $Result = Invoke-ValidateForChangeListSettingService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeListSettingValidateResult**](ChangeListSettingValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangePermissionService"></a>
# **Invoke-ValidateForChangePermissionService**
> ChangePermissionValidateResult Invoke-ValidateForChangePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change permission service

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
$SiteValidationParameter = (New-SiteValidationParameter -Uri "TODO"  -IgnoreLock $false  -IsEditTask $false  -IsFromQuestionnaire $false) # SiteValidationParameter |  (optional)

# validate permissions, scope for change permission service
try {
    $Result = Invoke-ValidateForChangePermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangePermissionValidateResult**](ChangePermissionValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangeSiteContactService"></a>
# **Invoke-ValidateForChangeSiteContactService**
> ChangeSiteContactValidateResult Invoke-ValidateForChangeSiteContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change site contact service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for change site contact service
try {
    $Result = Invoke-ValidateForChangeSiteContactService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeSiteContactValidateResult**](ChangeSiteContactValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangeSiteSettingService"></a>
# **Invoke-ValidateForChangeSiteSettingService**
> ChangeSiteSettingValidateResult Invoke-ValidateForChangeSiteSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change site setting service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for change site setting service
try {
    $Result = Invoke-ValidateForChangeSiteSettingService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeSiteSettingValidateResult**](ChangeSiteSettingValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangeWebContactService"></a>
# **Invoke-ValidateForChangeWebContactService**
> ChangeWebContactValidateResult Invoke-ValidateForChangeWebContactService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change web contact service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for change web contact service
try {
    $Result = Invoke-ValidateForChangeWebContactService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeWebContactValidateResult**](ChangeWebContactValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForChangeWebSettingService"></a>
# **Invoke-ValidateForChangeWebSettingService**
> ChangeWebUrlValidateResult Invoke-ValidateForChangeWebSettingService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for change web setting service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for change web setting service
try {
    $Result = Invoke-ValidateForChangeWebSettingService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ChangeWebUrlValidateResult**](ChangeWebUrlValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForClonePermissionService"></a>
# **Invoke-ValidateForClonePermissionService**
> ClonePermissionValidateResult Invoke-ValidateForClonePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for clone permission service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for clone permission service
try {
    $Result = Invoke-ValidateForClonePermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ClonePermissionValidateResult**](ClonePermissionValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForContentMoveService"></a>
# **Invoke-ValidateForContentMoveService**
> ContentMoveUrlValidationResult Invoke-ValidateForContentMoveService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for content move service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for content move service
try {
    $Result = Invoke-ValidateForContentMoveService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ContentMoveUrlValidationResult**](ContentMoveUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForCreateListService"></a>
# **Invoke-ValidateForCreateListService**
> CreateListUrlValidationResult Invoke-ValidateForCreateListService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ListValidationParameter] <PSCustomObject><br>

validate permissions, scope for create list service

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
$ListValidationParameter = (New-ListValidationParameter -ListUrl "ListUrl_example"  -ParentUrl "ParentUrl_example"  -ListTitle "ListTitle_example"  -IsDocumentLibrary $false  -IsEditTask $false  -IsFromQuestionnaire $false) # ListValidationParameter |  (optional)

# validate permissions, scope for create list service
try {
    $Result = Invoke-ValidateForCreateListService -Id $Id -ListValidationParameter $ListValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **ListValidationParameter** | [**ListValidationParameter**](ListValidationParameter.md)|  | [optional] 

### Return type

[**CreateListUrlValidationResult**](CreateListUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForCreateWebService"></a>
# **Invoke-ValidateForCreateWebService**
> CreateWebUrlValidationResult Invoke-ValidateForCreateWebService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CreateWebValidationParameter] <PSCustomObject><br>

validate permissions, scope for create web service

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
$CreateWebValidationParameter = (New-CreateWebValidationParameter -ParentUrl "TODO"  -Uri "TODO"  -IgnoreLock $false  -IsEditTask $false  -IsFromQuestionnaire $false) # CreateWebValidationParameter |  (optional)

# validate permissions, scope for create web service
try {
    $Result = Invoke-ValidateForCreateWebService -Id $Id -CreateWebValidationParameter $CreateWebValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **CreateWebValidationParameter** | [**CreateWebValidationParameter**](CreateWebValidationParameter.md)|  | [optional] 

### Return type

[**CreateWebUrlValidationResult**](CreateWebUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForGrantPermissionService"></a>
# **Invoke-ValidateForGrantPermissionService**
> GrantPermissionUrlValidationResult Invoke-ValidateForGrantPermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for grant permission service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for grant permission service
try {
    $Result = Invoke-ValidateForGrantPermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**GrantPermissionUrlValidationResult**](GrantPermissionUrlValidationResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForGroupLifecycleService"></a>
# **Invoke-ValidateForGroupLifecycleService**
> GroupLifecycleValidateResult Invoke-ValidateForGroupLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GroupValidationParameter] <PSCustomObject><br>

validate permissions, scope for group lifecycle service

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
$GroupValidationParameter = (New-GroupValidationParameter -GroupId "TODO"  -IsEditTask $false  -IsFromQuestionnaire $false) # GroupValidationParameter |  (optional)

# validate permissions, scope for group lifecycle service
try {
    $Result = Invoke-ValidateForGroupLifecycleService -Id $Id -GroupValidationParameter $GroupValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **GroupValidationParameter** | [**GroupValidationParameter**](GroupValidationParameter.md)|  | [optional] 

### Return type

[**GroupLifecycleValidateResult**](GroupLifecycleValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForManagePermissionService"></a>
# **Invoke-ValidateForManagePermissionService**
> ManagePermissionValidateResult Invoke-ValidateForManagePermissionService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for manage permission service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for manage permission service
try {
    $Result = Invoke-ValidateForManagePermissionService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**ManagePermissionValidateResult**](ManagePermissionValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForSiteLifecycleService"></a>
# **Invoke-ValidateForSiteLifecycleService**
> SiteLifecycleValidateResult Invoke-ValidateForSiteLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for site lifecycle service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for site lifecycle service
try {
    $Result = Invoke-ValidateForSiteLifecycleService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**SiteLifecycleValidateResult**](SiteLifecycleValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateForWebLifecycleService"></a>
# **Invoke-ValidateForWebLifecycleService**
> WebLifecycleValidateResult Invoke-ValidateForWebLifecycleService<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SiteValidationParameter] <PSCustomObject><br>

validate permissions, scope for web lifecycle service

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
$SiteValidationParameter =  # SiteValidationParameter |  (optional)

# validate permissions, scope for web lifecycle service
try {
    $Result = Invoke-ValidateForWebLifecycleService -Id $Id -SiteValidationParameter $SiteValidationParameter
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **SiteValidationParameter** | [**SiteValidationParameter**](SiteValidationParameter.md)|  | [optional] 

### Return type

[**WebLifecycleValidateResult**](WebLifecycleValidateResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

