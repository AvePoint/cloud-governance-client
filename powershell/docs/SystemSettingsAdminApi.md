# Cloud.Governance.Client.Cloud.Governance.Client\Api.SystemSettingsAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add-ExecutionSchedule**](SystemSettingsAdminApi.md#Add-ExecutionSchedule) | **POST** /admin/settings/system/executionschedules | add execution schedule
[**Add-NewDepartment**](SystemSettingsAdminApi.md#Add-NewDepartment) | **POST** /admin/settings/system/departments | create a new department
[**Invoke-CreateApiSetting**](SystemSettingsAdminApi.md#Invoke-CreateApiSetting) | **POST** /admin/settings/system/api | create api authentication profile
[**Invoke-CreateExportLocations**](SystemSettingsAdminApi.md#Invoke-CreateExportLocations) | **POST** /admin/settings/system/exportlocations | create export location
[**Invoke-CreateTerminology**](SystemSettingsAdminApi.md#Invoke-CreateTerminology) | **POST** /admin/settings/system/terminologies/one | create a new terminology
[**Invoke-CreateTextValidationRule**](SystemSettingsAdminApi.md#Invoke-CreateTextValidationRule) | **POST** /admin/settings/system/validation/text | create text validation rule
[**Invoke-DeleteDepartment**](SystemSettingsAdminApi.md#Invoke-DeleteDepartment) | **DELETE** /admin/settings/system/departments/{id} | delete department
[**Invoke-DeleteExecutionSchedule**](SystemSettingsAdminApi.md#Invoke-DeleteExecutionSchedule) | **DELETE** /admin/settings/system/executionschedules/{id} | delete execution schedule by id
[**Invoke-DeleteExecutionSchedules**](SystemSettingsAdminApi.md#Invoke-DeleteExecutionSchedules) | **DELETE** /admin/settings/system/executionschedules | delete execution schedules
[**Invoke-DeleteExportLocation**](SystemSettingsAdminApi.md#Invoke-DeleteExportLocation) | **DELETE** /admin/settings/system/exportlocations/{id} | delete export location
[**Invoke-DeleteExportLocations**](SystemSettingsAdminApi.md#Invoke-DeleteExportLocations) | **DELETE** /admin/settings/system/exportlocations | delete export locations
[**Invoke-DeleteSelectedApiSettings**](SystemSettingsAdminApi.md#Invoke-DeleteSelectedApiSettings) | **DELETE** /admin/settings/system/api | remove selected api authentication profile
[**Invoke-DeleteTerminology**](SystemSettingsAdminApi.md#Invoke-DeleteTerminology) | **DELETE** /admin/settings/system/terminologies | delete terminologies
[**Invoke-DeleteTerminologyById**](SystemSettingsAdminApi.md#Invoke-DeleteTerminologyById) | **DELETE** /admin/settings/system/terminologies/{id} | delete terminology by id
[**Invoke-DeleteTextValidationRule**](SystemSettingsAdminApi.md#Invoke-DeleteTextValidationRule) | **DELETE** /admin/settings/system/validation/text | delete text validation rules
[**Invoke-DeleteTextValidationRuleById**](SystemSettingsAdminApi.md#Invoke-DeleteTextValidationRuleById) | **DELETE** /admin/settings/system/validation/text/{id} | delete text validation rule by id
[**Edit-Department**](SystemSettingsAdminApi.md#Edit-Department) | **PUT** /admin/settings/system/departments | edit department
[**Edit-ExecutionSchedule**](SystemSettingsAdminApi.md#Edit-ExecutionSchedule) | **PUT** /admin/settings/system/executionschedules | edit execution schedule
[**Edit-ExportLocations**](SystemSettingsAdminApi.md#Edit-ExportLocations) | **PUT** /admin/settings/system/exportlocations | edit export location
[**Edit-Terminology**](SystemSettingsAdminApi.md#Edit-Terminology) | **PUT** /admin/settings/system/terminologies | edit terminology
[**Edit-TextValidatioinRule**](SystemSettingsAdminApi.md#Edit-TextValidatioinRule) | **PUT** /admin/settings/system/validation/text | edit text validation rule
[**Get-AccountManagementGroupMembers**](SystemSettingsAdminApi.md#Get-AccountManagementGroupMembers) | **GET** /admin/settings/system/accountmanagement/groups/{id}/users | get users of account management
[**Get-AccountManagementGroups**](SystemSettingsAdminApi.md#Get-AccountManagementGroups) | **GET** /admin/settings/system/accountmanagement/groups | get groups of account management
[**Get-ApiSetting**](SystemSettingsAdminApi.md#Get-ApiSetting) | **GET** /admin/settings/system/api/{id} | get api authentication profile view
[**Get-ApiSettingFilters**](SystemSettingsAdminApi.md#Get-ApiSettingFilters) | **GET** /admin/settings/system/api/filters | get filters of api authentication profile
[**Get-ApiSettings**](SystemSettingsAdminApi.md#Get-ApiSettings) | **GET** /admin/settings/system/api | get all api authentication profiles
[**Get-DemoPreparationDuration**](SystemSettingsAdminApi.md#Get-DemoPreparationDuration) | **GET** /admin/settings/system/tools/duration | get duration of demo preparation
[**Get-DepartmentByName**](SystemSettingsAdminApi.md#Get-DepartmentByName) | **GET** /admin/settings/system/departments/{name} | get department with name
[**Get-DepartmentSettings**](SystemSettingsAdminApi.md#Get-DepartmentSettings) | **GET** /admin/settings/system/departments/settings | get department settings
[**Get-Departments**](SystemSettingsAdminApi.md#Get-Departments) | **GET** /admin/settings/system/departments | get departments
[**Get-ExecutionSchedule**](SystemSettingsAdminApi.md#Get-ExecutionSchedule) | **GET** /admin/settings/system/executionschedules/{id} | get executionn schedule
[**Get-ExecutionScheduleList**](SystemSettingsAdminApi.md#Get-ExecutionScheduleList) | **GET** /admin/settings/system/executionschedules | get execution schedule list
[**Get-ExecutionScheduleListFilters**](SystemSettingsAdminApi.md#Get-ExecutionScheduleListFilters) | **GET** /admin/settings/system/executionschedules/filters | get execution schedule list fileters
[**Get-ExportLocation**](SystemSettingsAdminApi.md#Get-ExportLocation) | **GET** /admin/settings/system/exportlocations/{id} | get export location
[**Get-ExportLocations**](SystemSettingsAdminApi.md#Get-ExportLocations) | **GET** /admin/settings/system/exportlocations | get export locations
[**Get-GlobalPersonalSettings**](SystemSettingsAdminApi.md#Get-GlobalPersonalSettings) | **GET** /admin/settings/system/default | get global personal settings
[**Get-HelpLinks**](SystemSettingsAdminApi.md#Get-HelpLinks) | **GET** /admin/settings/system/helplinks | get help links
[**Get-NewsConfiguration**](SystemSettingsAdminApi.md#Get-NewsConfiguration) | **GET** /admin/settings/system/news | get news and updates
[**Get-QuickRequestSettings**](SystemSettingsAdminApi.md#Get-QuickRequestSettings) | **GET** /admin/settings/system/quickrequests | get quick requests
[**Get-ScheduleReferencedServices**](SystemSettingsAdminApi.md#Get-ScheduleReferencedServices) | **GET** /admin/settings/system/executionschedules/{id}/services | get referenced services
[**Get-Terminologies**](SystemSettingsAdminApi.md#Get-Terminologies) | **GET** /admin/settings/system/terminologies | get terminologies
[**Get-TerminologyById**](SystemSettingsAdminApi.md#Get-TerminologyById) | **GET** /admin/settings/system/terminologies/{id} | get terminology
[**Get-TerminologyFilters**](SystemSettingsAdminApi.md#Get-TerminologyFilters) | **GET** /admin/settings/system/terminologies/filters | get terminology filters
[**Get-TextValiationRuleFilters**](SystemSettingsAdminApi.md#Get-TextValiationRuleFilters) | **GET** /admin/settings/system/validation/text/filters | get text validation rule list filters
[**Get-TextValiationRules**](SystemSettingsAdminApi.md#Get-TextValiationRules) | **GET** /admin/settings/system/validation/text | get text validation rule list
[**Get-TextValidationRuleById**](SystemSettingsAdminApi.md#Get-TextValidationRuleById) | **GET** /admin/settings/system/validation/text/{id} | get text validation rule
[**Get-TimerConfigurations**](SystemSettingsAdminApi.md#Get-TimerConfigurations) | **GET** /admin/settings/system/timers | get timer configurations
[**Get-UploadFileUrL**](SystemSettingsAdminApi.md#Get-UploadFileUrL) | **GET** /admin/settings/system/support/uploadurl | Get upload file url
[**Get-relatedServices**](SystemSettingsAdminApi.md#Get-relatedServices) | **GET** /admin/settings/system/departments/{name}/services | get related services
[**Import-Terminolog**](SystemSettingsAdminApi.md#Import-Terminolog) | **POST** /admin/settings/system/terminologies | import terminologies, max count once import is 10000
[**Save-DepartmentsSettings**](SystemSettingsAdminApi.md#Save-DepartmentsSettings) | **POST** /admin/settings/system/departments/settings | save departments
[**Save-GlobalPersonalSettings**](SystemSettingsAdminApi.md#Save-GlobalPersonalSettings) | **POST** /admin/settings/system/default | save global personal settings
[**Save-HelpLinks**](SystemSettingsAdminApi.md#Save-HelpLinks) | **POST** /admin/settings/system/helplinks | save help links
[**Save-NewsAndUpdates**](SystemSettingsAdminApi.md#Save-NewsAndUpdates) | **POST** /admin/settings/system/news | save news and updates
[**Save-QuickRequestSettigns**](SystemSettingsAdminApi.md#Save-QuickRequestSettigns) | **POST** /admin/settings/system/quickrequests | save quick requests
[**Save-TimerConfigurations**](SystemSettingsAdminApi.md#Save-TimerConfigurations) | **POST** /admin/settings/system/timers | save timer configurations
[**Send-InviteSupport**](SystemSettingsAdminApi.md#Send-InviteSupport) | **POST** /admin/settings/system/support | send invite support
[**Submit-DemoPreparation**](SystemSettingsAdminApi.md#Submit-DemoPreparation) | **POST** /admin/settings/system/tools | submit demo preparation request
[**Invoke-ValidateAzureStorage**](SystemSettingsAdminApi.md#Invoke-ValidateAzureStorage) | **POST** /admin/settings/system/exportlocations/azurestorage/validation | validate azure storage
[**Invoke-ValidateSharePointUrl**](SystemSettingsAdminApi.md#Invoke-ValidateSharePointUrl) | **POST** /admin/settings/system/exportlocations/url/validation | validate sharepoint folder or library url


<a name="Add-ExecutionSchedule"></a>
# **Add-ExecutionSchedule**
> UUID Add-ExecutionSchedule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExecutionScheduleModel] <PSCustomObject><br>

add execution schedule

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



$ExecutionScheduleModel = (New-ExecutionScheduleModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Schedules @((New-ScheduleItemModel -Days @((New-DayOfWeek))  -BeginHours 123  -EndHours 123))  -TimeZone 123  -IsAdjustDaylight $false) # ExecutionScheduleModel |  (optional)

# add execution schedule
try {
    $Result = Add-ExecutionSchedule -ExecutionScheduleModel $ExecutionScheduleModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ExecutionScheduleModel** | [**ExecutionScheduleModel**](ExecutionScheduleModel.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Add-NewDepartment"></a>
# **Add-NewDepartment**
> Int32 Add-NewDepartment<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Department] <String><br>

create a new department

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



$Department = "Department_example" # String |  (optional) (default to null)

# create a new department
try {
    $Result = Add-NewDepartment -Department $Department
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Department** | **String**|  | [optional] [default to null]

### Return type

**Int32**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-CreateApiSetting"></a>
# **Invoke-CreateApiSetting**
> ApiSettingViewModel Invoke-CreateApiSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ApiSettingModel] <PSCustomObject><br>

create api authentication profile

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



$ApiSettingModel = (New-ApiSettingModel -Name "Name_example"  -Duration 123  -DurationType (New-DurationType)) # ApiSettingModel |  (optional)

# create api authentication profile
try {
    $Result = Invoke-CreateApiSetting -ApiSettingModel $ApiSettingModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ApiSettingModel** | [**ApiSettingModel**](ApiSettingModel.md)|  | [optional] 

### Return type

[**ApiSettingViewModel**](ApiSettingViewModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-CreateExportLocations"></a>
# **Invoke-CreateExportLocations**
> Int32 Invoke-CreateExportLocations<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExportLocationModel] <PSCustomObject><br>

create export location

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



$ExportLocationModel = (New-ExportLocationModel -Id 123  -Name "Name_example"  -Description "Description_example"  -StorageType (New-StorageType)  -AzureStorage (New-AzureStorageContainer -ContainerName "ContainerName_example"  -AccountName "AccountName_example"  -AccountKey "AccountKey_example"  -NeedHttps $false)  -SharePointUrl "TODO") # ExportLocationModel |  (optional)

# create export location
try {
    $Result = Invoke-CreateExportLocations -ExportLocationModel $ExportLocationModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ExportLocationModel** | [**ExportLocationModel**](ExportLocationModel.md)|  | [optional] 

### Return type

**Int32**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-CreateTerminology"></a>
# **Invoke-CreateTerminology**
> UUID Invoke-CreateTerminology<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TerminologyModel] <PSCustomObject><br>

create a new terminology

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



$TerminologyModel = (New-TerminologyModel -Id "TODO"  -LanguageId 123  -OriginalTerminology "OriginalTerminology_example"  -NewTerminology "NewTerminology_example") # TerminologyModel |  (optional)

# create a new terminology
try {
    $Result = Invoke-CreateTerminology -TerminologyModel $TerminologyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TerminologyModel** | [**TerminologyModel**](TerminologyModel.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-CreateTextValidationRule"></a>
# **Invoke-CreateTextValidationRule**
> UUID Invoke-CreateTextValidationRule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TextValidationRuleModel] <PSCustomObject><br>

create text validation rule

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



$TextValidationRuleModel = (New-TextValidationRuleModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -RegularExpression "RegularExpression_example"  -ErrorMessage "ErrorMessage_example"  -ValidationTestText "ValidationTestText_example") # TextValidationRuleModel |  (optional)

# create text validation rule
try {
    $Result = Invoke-CreateTextValidationRule -TextValidationRuleModel $TextValidationRuleModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TextValidationRuleModel** | [**TextValidationRuleModel**](TextValidationRuleModel.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteDepartment"></a>
# **Invoke-DeleteDepartment**
> void Invoke-DeleteDepartment<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <Int32><br>

delete department

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



$Id = 987 # Int32 |  (default to null)

# delete department
try {
    Invoke-DeleteDepartment -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | **Int32**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteExecutionSchedule"></a>
# **Invoke-DeleteExecutionSchedule**
> void Invoke-DeleteExecutionSchedule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete execution schedule by id

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

# delete execution schedule by id
try {
    Invoke-DeleteExecutionSchedule -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteExecutionSchedules"></a>
# **Invoke-DeleteExecutionSchedules**
> void Invoke-DeleteExecutionSchedules<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

delete execution schedules

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



$UUID = @("TODO") # UUID[] |  (optional)

# delete execution schedules
try {
    Invoke-DeleteExecutionSchedules -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteExportLocation"></a>
# **Invoke-DeleteExportLocation**
> void Invoke-DeleteExportLocation<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <Int32><br>

delete export location

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



$Id = 987 # Int32 |  (default to null)

# delete export location
try {
    Invoke-DeleteExportLocation -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | **Int32**|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteExportLocations"></a>
# **Invoke-DeleteExportLocations**
> void Invoke-DeleteExportLocations<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-RequestBody] <System.Nullable[Int32][]><br>

delete export locations

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



$RequestBody = @(123) # Int32[] |  (optional)

# delete export locations
try {
    Invoke-DeleteExportLocations -RequestBody $RequestBody
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **RequestBody** | [**Int32[]**](Int32.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteSelectedApiSettings"></a>
# **Invoke-DeleteSelectedApiSettings**
> void Invoke-DeleteSelectedApiSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

remove selected api authentication profile

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



$UUID = @("TODO") # UUID[] |  (optional)

# remove selected api authentication profile
try {
    Invoke-DeleteSelectedApiSettings -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteTerminology"></a>
# **Invoke-DeleteTerminology**
> void Invoke-DeleteTerminology<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

delete terminologies

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



$UUID = @("TODO") # UUID[] |  (optional)

# delete terminologies
try {
    Invoke-DeleteTerminology -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteTerminologyById"></a>
# **Invoke-DeleteTerminologyById**
> void Invoke-DeleteTerminologyById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete terminology by id

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

# delete terminology by id
try {
    Invoke-DeleteTerminologyById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteTextValidationRule"></a>
# **Invoke-DeleteTextValidationRule**
> void Invoke-DeleteTextValidationRule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

delete text validation rules

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



$UUID = @("TODO") # UUID[] |  (optional)

# delete text validation rules
try {
    Invoke-DeleteTextValidationRule -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteTextValidationRuleById"></a>
# **Invoke-DeleteTextValidationRuleById**
> void Invoke-DeleteTextValidationRuleById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete text validation rule by id

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

# delete text validation rule by id
try {
    Invoke-DeleteTextValidationRuleById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-Department"></a>
# **Edit-Department**
> void Edit-Department<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-StringModel] <PSCustomObject><br>

edit department

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



$StringModel = (New-StringModel -Id "Id_example"  -Name "Name_example") # StringModel |  (optional)

# edit department
try {
    Edit-Department -StringModel $StringModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **StringModel** | [**StringModel**](StringModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ExecutionSchedule"></a>
# **Edit-ExecutionSchedule**
> void Edit-ExecutionSchedule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExecutionScheduleModel] <PSCustomObject><br>

edit execution schedule

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



$ExecutionScheduleModel = (New-ExecutionScheduleModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -Schedules @((New-ScheduleItemModel -Days @((New-DayOfWeek))  -BeginHours 123  -EndHours 123))  -TimeZone 123  -IsAdjustDaylight $false) # ExecutionScheduleModel |  (optional)

# edit execution schedule
try {
    Edit-ExecutionSchedule -ExecutionScheduleModel $ExecutionScheduleModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ExecutionScheduleModel** | [**ExecutionScheduleModel**](ExecutionScheduleModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-ExportLocations"></a>
# **Edit-ExportLocations**
> void Edit-ExportLocations<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-ExportLocationModel] <PSCustomObject><br>

edit export location

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



$ExportLocationModel = (New-ExportLocationModel -Id 123  -Name "Name_example"  -Description "Description_example"  -StorageType (New-StorageType)  -AzureStorage (New-AzureStorageContainer -ContainerName "ContainerName_example"  -AccountName "AccountName_example"  -AccountKey "AccountKey_example"  -NeedHttps $false)  -SharePointUrl "TODO") # ExportLocationModel |  (optional)

# edit export location
try {
    Edit-ExportLocations -ExportLocationModel $ExportLocationModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ExportLocationModel** | [**ExportLocationModel**](ExportLocationModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-Terminology"></a>
# **Edit-Terminology**
> void Edit-Terminology<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TerminologyModel] <PSCustomObject><br>

edit terminology

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



$TerminologyModel = (New-TerminologyModel -Id "TODO"  -LanguageId 123  -OriginalTerminology "OriginalTerminology_example"  -NewTerminology "NewTerminology_example") # TerminologyModel |  (optional)

# edit terminology
try {
    Edit-Terminology -TerminologyModel $TerminologyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TerminologyModel** | [**TerminologyModel**](TerminologyModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Edit-TextValidatioinRule"></a>
# **Edit-TextValidatioinRule**
> void Edit-TextValidatioinRule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TextValidationRuleModel] <PSCustomObject><br>

edit text validation rule

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



$TextValidationRuleModel = (New-TextValidationRuleModel -Id "TODO"  -Name "Name_example"  -Description "Description_example"  -RegularExpression "RegularExpression_example"  -ErrorMessage "ErrorMessage_example"  -ValidationTestText "ValidationTestText_example") # TextValidationRuleModel |  (optional)

# edit text validation rule
try {
    Edit-TextValidatioinRule -TextValidationRuleModel $TextValidationRuleModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TextValidationRuleModel** | [**TextValidationRuleModel**](TextValidationRuleModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AccountManagementGroupMembers"></a>
# **Get-AccountManagementGroupMembers**
> UserListPageResult Get-AccountManagementGroupMembers<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <Int32><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get users of account management

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



$Id = 987 # Int32 |  (default to null)
$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, loginName, displayName, email, isDomainGroup, authenticationType (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, loginName, displayName, email, isDomainGroup, authenticationType (optional) (default to null)
$Search = "Search_example" # String | Search for displayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get users of account management
try {
    $Result = Get-AccountManagementGroupMembers -Id $Id -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | **Int32**|  | [default to null]
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, loginName, displayName, email, isDomainGroup, authenticationType | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, loginName, displayName, email, isDomainGroup, authenticationType | [optional] [default to null]
 **Search** | **String**| Search for displayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**UserListPageResult**](UserListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-AccountManagementGroups"></a>
# **Get-AccountManagementGroups**
> GroupListPageResult Get-AccountManagementGroups<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get groups of account management

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, description (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get groups of account management
try {
    $Result = Get-AccountManagementGroups -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**GroupListPageResult**](GroupListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ApiSetting"></a>
# **Get-ApiSetting**
> ApiSettingViewModel Get-ApiSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get api authentication profile view

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

# get api authentication profile view
try {
    $Result = Get-ApiSetting -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**ApiSettingViewModel**](ApiSettingViewModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ApiSettingFilters"></a>
# **Get-ApiSettingFilters**
> DistinctPageResult Get-ApiSettingFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get filters of api authentication profile

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, modified, created, createdByDisplayName (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, name, modified, created, createdByDisplayName (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get filters of api authentication profile
try {
    $Result = Get-ApiSettingFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, modified, created, createdByDisplayName | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, modified, created, createdByDisplayName | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ApiSettings"></a>
# **Get-ApiSettings**
> ApiSettingGridModelPageResult Get-ApiSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all api authentication profiles

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, modified, created, createdByDisplayName (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, modified, created, createdByDisplayName (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all api authentication profiles
try {
    $Result = Get-ApiSettings -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, modified, created, createdByDisplayName | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, modified, created, createdByDisplayName | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**ApiSettingGridModelPageResult**](ApiSettingGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-DemoPreparationDuration"></a>
# **Get-DemoPreparationDuration**
> TaskDurationModel Get-DemoPreparationDuration<br>

get duration of demo preparation

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




# get duration of demo preparation
try {
    $Result = Get-DemoPreparationDuration
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TaskDurationModel**](TaskDurationModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-DepartmentByName"></a>
# **Get-DepartmentByName**
> StringModel Get-DepartmentByName<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

get department with name

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

# get department with name
try {
    $Result = Get-DepartmentByName -Name $Name
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Name** | **String**|  | [default to null]

### Return type

[**StringModel**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-DepartmentSettings"></a>
# **Get-DepartmentSettings**
> DepartmentSettingsModel Get-DepartmentSettings<br>

get department settings

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




# get department settings
try {
    $Result = Get-DepartmentSettings
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DepartmentSettingsModel**](DepartmentSettingsModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Departments"></a>
# **Get-Departments**
> DepartmentListPageResult Get-Departments<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get departments

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, modifiedTime (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, modifiedTime (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get departments
try {
    $Result = Get-Departments -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, modifiedTime | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, modifiedTime | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DepartmentListPageResult**](DepartmentListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ExecutionSchedule"></a>
# **Get-ExecutionSchedule**
> ExecutionScheduleModel Get-ExecutionSchedule<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get executionn schedule

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

# get executionn schedule
try {
    $Result = Get-ExecutionSchedule -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**ExecutionScheduleModel**](ExecutionScheduleModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ExecutionScheduleList"></a>
# **Get-ExecutionScheduleList**
> ExecutionScheduleListPageResult Get-ExecutionScheduleList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get execution schedule list

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, modified (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, description, modified (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get execution schedule list
try {
    $Result = Get-ExecutionScheduleList -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, modified | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description, modified | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**ExecutionScheduleListPageResult**](ExecutionScheduleListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ExecutionScheduleListFilters"></a>
# **Get-ExecutionScheduleListFilters**
> DistinctPageResult Get-ExecutionScheduleListFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get execution schedule list fileters

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, modified (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, name, description, modified (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get execution schedule list fileters
try {
    $Result = Get-ExecutionScheduleListFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, modified | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, description, modified | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ExportLocation"></a>
# **Get-ExportLocation**
> ExportLocationModel Get-ExportLocation<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <Int32><br>

get export location

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



$Id = 987 # Int32 |  (default to null)

# get export location
try {
    $Result = Get-ExportLocation -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | **Int32**|  | [default to null]

### Return type

[**ExportLocationModel**](ExportLocationModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ExportLocations"></a>
# **Get-ExportLocations**
> ExportLocationGridModelPageResult Get-ExportLocations<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get export locations

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, storageType, modifiedTime (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, description, storageType, modifiedTime (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get export locations
try {
    $Result = Get-ExportLocations -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, storageType, modifiedTime | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description, storageType, modifiedTime | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**ExportLocationGridModelPageResult**](ExportLocationGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-GlobalPersonalSettings"></a>
# **Get-GlobalPersonalSettings**
> GlobalPersonalSettingModel Get-GlobalPersonalSettings<br>

get global personal settings

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




# get global personal settings
try {
    $Result = Get-GlobalPersonalSettings
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GlobalPersonalSettingModel**](GlobalPersonalSettingModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-HelpLinks"></a>
# **Get-HelpLinks**
> CustomHelpLinkModel Get-HelpLinks<br>

get help links

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




# get help links
try {
    $Result = Get-HelpLinks
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CustomHelpLinkModel**](CustomHelpLinkModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-NewsConfiguration"></a>
# **Get-NewsConfiguration**
> NewsAndUpdatesModel Get-NewsConfiguration<br>

get news and updates

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




# get news and updates
try {
    $Result = Get-NewsConfiguration
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NewsAndUpdatesModel**](NewsAndUpdatesModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-QuickRequestSettings"></a>
# **Get-QuickRequestSettings**
> QuickRequestManagementViewModel Get-QuickRequestSettings<br>

get quick requests

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




# get quick requests
try {
    $Result = Get-QuickRequestSettings
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**QuickRequestManagementViewModel**](QuickRequestManagementViewModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ScheduleReferencedServices"></a>
# **Get-ScheduleReferencedServices**
> String[] Get-ScheduleReferencedServices<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get referenced services

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

# get referenced services
try {
    $Result = Get-ScheduleReferencedServices -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

**String[]**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Terminologies"></a>
# **Get-Terminologies**
> TerminologyListPageResult Get-Terminologies<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get terminologies

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, languageId, originalTerminology, newTerminology, modifiedTime (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, languageId, originalTerminology, newTerminology, modifiedTime (optional) (default to null)
$Search = "Search_example" # String | Search for originalTerminology (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get terminologies
try {
    $Result = Get-Terminologies -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, languageId, originalTerminology, newTerminology, modifiedTime | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, languageId, originalTerminology, newTerminology, modifiedTime | [optional] [default to null]
 **Search** | **String**| Search for originalTerminology | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**TerminologyListPageResult**](TerminologyListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TerminologyById"></a>
# **Get-TerminologyById**
> TerminologyModel Get-TerminologyById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get terminology

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

# get terminology
try {
    $Result = Get-TerminologyById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**TerminologyModel**](TerminologyModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TerminologyFilters"></a>
# **Get-TerminologyFilters**
> DistinctPageResult Get-TerminologyFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get terminology filters

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, languageId, originalTerminology, newTerminology, modifiedTime (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, languageId, originalTerminology, newTerminology, modifiedTime (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get terminology filters
try {
    $Result = Get-TerminologyFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, languageId, originalTerminology, newTerminology, modifiedTime | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, languageId, originalTerminology, newTerminology, modifiedTime | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TextValiationRuleFilters"></a>
# **Get-TextValiationRuleFilters**
> DistinctPageResult Get-TextValiationRuleFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get text validation rule list filters

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, lastModifiedTime, createdBy (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, name, description, lastModifiedTime, createdBy (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get text validation rule list filters
try {
    $Result = Get-TextValiationRuleFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, lastModifiedTime, createdBy | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, description, lastModifiedTime, createdBy | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TextValiationRules"></a>
# **Get-TextValiationRules**
> TextValidationRuleListPageResult Get-TextValiationRules<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get text validation rule list

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, lastModifiedTime, createdBy (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, description, lastModifiedTime, createdBy (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get text validation rule list
try {
    $Result = Get-TextValiationRules -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, lastModifiedTime, createdBy | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description, lastModifiedTime, createdBy | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**TextValidationRuleListPageResult**](TextValidationRuleListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TextValidationRuleById"></a>
# **Get-TextValidationRuleById**
> TextValidationRuleModel Get-TextValidationRuleById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get text validation rule

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

# get text validation rule
try {
    $Result = Get-TextValidationRuleById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**TextValidationRuleModel**](TextValidationRuleModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-TimerConfigurations"></a>
# **Get-TimerConfigurations**
> TimerConfigurationModel Get-TimerConfigurations<br>

get timer configurations

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




# get timer configurations
try {
    $Result = Get-TimerConfigurations
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TimerConfigurationModel**](TimerConfigurationModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-UploadFileUrL"></a>
# **Get-UploadFileUrL**
> SASUriModel Get-UploadFileUrL<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-FileName] <String><br>

Get upload file url

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



$FileName = "FileName_example" # String |  (optional) (default to null)

# Get upload file url
try {
    $Result = Get-UploadFileUrL -FileName $FileName
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **FileName** | **String**|  | [optional] [default to null]

### Return type

[**SASUriModel**](SASUriModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-relatedServices"></a>
# **Get-relatedServices**
> GuidModel[] Get-relatedServices<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Name] <String><br>

get related services

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

# get related services
try {
    $Result = Get-relatedServices -Name $Name
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Name** | **String**|  | [default to null]

### Return type

[**GuidModel[]**](GuidModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Import-Terminolog"></a>
# **Import-Terminolog**
> TerminologyImportedModel[] Import-Terminolog<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TerminologyModel] <PSCustomObject[]><br>

import terminologies, max count once import is 10000

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



$TerminologyModel = @() # TerminologyModel[] |  (optional)

# import terminologies, max count once import is 10000
try {
    $Result = Import-Terminolog -TerminologyModel $TerminologyModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TerminologyModel** | [**TerminologyModel[]**](TerminologyModel.md)|  | [optional] 

### Return type

[**TerminologyImportedModel[]**](TerminologyImportedModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-DepartmentsSettings"></a>
# **Save-DepartmentsSettings**
> void Save-DepartmentsSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DepartmentSettingsModel] <PSCustomObject><br>

save departments

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



$DepartmentSettingsModel = (New-DepartmentSettingsModel -DataSource (New-DepartmentSource)  -Departments @((New-DepartmentActionModel -Id 123  -Name "Name_example"  -ActionType (New-ObjectActionType)))) # DepartmentSettingsModel |  (optional)

# save departments
try {
    Save-DepartmentsSettings -DepartmentSettingsModel $DepartmentSettingsModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **DepartmentSettingsModel** | [**DepartmentSettingsModel**](DepartmentSettingsModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-GlobalPersonalSettings"></a>
# **Save-GlobalPersonalSettings**
> void Save-GlobalPersonalSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-GlobalPersonalSettingModel] <PSCustomObject><br>

save global personal settings

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



$GlobalPersonalSettingModel = (New-GlobalPersonalSettingModel -LanguageId 123  -TimeZoneId 123  -IsAdjustDaylight $false) # GlobalPersonalSettingModel |  (optional)

# save global personal settings
try {
    Save-GlobalPersonalSettings -GlobalPersonalSettingModel $GlobalPersonalSettingModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **GlobalPersonalSettingModel** | [**GlobalPersonalSettingModel**](GlobalPersonalSettingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-HelpLinks"></a>
# **Save-HelpLinks**
> void Save-HelpLinks<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-CustomHelpLinkModel] <PSCustomObject><br>

save help links

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



$CustomHelpLinkModel = (New-CustomHelpLinkModel -LinkType (New-HelpLinkType)  -HelpLink "HelpLink_example") # CustomHelpLinkModel |  (optional)

# save help links
try {
    Save-HelpLinks -CustomHelpLinkModel $CustomHelpLinkModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **CustomHelpLinkModel** | [**CustomHelpLinkModel**](CustomHelpLinkModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-NewsAndUpdates"></a>
# **Save-NewsAndUpdates**
> void Save-NewsAndUpdates<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-NewsAndUpdatesModel] <PSCustomObject><br>

save news and updates

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



$NewsAndUpdatesModel = (New-NewsAndUpdatesModel -CustomizedTitle "CustomizedTitle_example"  -Title "Title_example"  -Content "Content_example") # NewsAndUpdatesModel |  (optional)

# save news and updates
try {
    Save-NewsAndUpdates -NewsAndUpdatesModel $NewsAndUpdatesModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **NewsAndUpdatesModel** | [**NewsAndUpdatesModel**](NewsAndUpdatesModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-QuickRequestSettigns"></a>
# **Save-QuickRequestSettigns**
> void Save-QuickRequestSettigns<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuickRequestManagementModel] <PSCustomObject><br>

save quick requests

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



$QuickRequestManagementModel = (New-QuickRequestManagementModel -IsCategoryEnabledSelectAll $false  -SelectedCategories @("TODO")  -IsServiceEnabledSelectAll $false  -SelectedServices @("TODO")) # QuickRequestManagementModel |  (optional)

# save quick requests
try {
    Save-QuickRequestSettigns -QuickRequestManagementModel $QuickRequestManagementModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **QuickRequestManagementModel** | [**QuickRequestManagementModel**](QuickRequestManagementModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Save-TimerConfigurations"></a>
# **Save-TimerConfigurations**
> void Save-TimerConfigurations<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-TimerConfigurationModel] <PSCustomObject><br>

save timer configurations

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



$TimerConfigurationModel = (New-TimerConfigurationModel -IsRecertificationJobEnabled $false  -SiteStatusScanJob (New-TimerConfigurationItem -IsEnabled $false  -Interval 123  -IntervalType (New-DurationType))  -WebSynchronizationJob (New-TimerConfigurationItem -IsEnabled $false  -Interval 123  -IntervalType )  -SiteSynchronizationJob   -SiteContentArchivalJob   -SiteContactStatusScanJob   -GroupOrTeamsSynchronizationJob   -UserProfileMetadataSynchronizationJob   -UserProfileRoleMetadataSynchronizationJob ) # TimerConfigurationModel |  (optional)

# save timer configurations
try {
    Save-TimerConfigurations -TimerConfigurationModel $TimerConfigurationModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **TimerConfigurationModel** | [**TimerConfigurationModel**](TimerConfigurationModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Send-InviteSupport"></a>
# **Send-InviteSupport**
> void Send-InviteSupport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-InviteSupportModel] <PSCustomObject><br>

send invite support

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



$InviteSupportModel = (New-InviteSupportModel -Services @((New-ApiFeedbackServiceType))  -IssueType (New-IssueType)  -Severity (New-Severity)  -Detail "Detail_example"  -RelatedServiceName "RelatedServiceName_example"  -FileName "FileName_example"  -ContactName "ContactName_example"  -ContactOption (New-ContactOption)  -ContactDetail "ContactDetail_example"  -ContactCC "ContactCC_example") # InviteSupportModel |  (optional)

# send invite support
try {
    Send-InviteSupport -InviteSupportModel $InviteSupportModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **InviteSupportModel** | [**InviteSupportModel**](InviteSupportModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-DemoPreparation"></a>
# **Submit-DemoPreparation**
> void Submit-DemoPreparation<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-DemoPreparationModel] <PSCustomObject><br>

submit demo preparation request

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



$DemoPreparationModel = (New-DemoPreparationModel -Duration (New-TaskDurationModel -IsEnabled $false  -Duration 123  -ReminderInterval 123  -Assignee "Assignee_example")  -SiteJobs (New-SiteJobTriggers -RenewalJob (New-SiteJobTrigger -Url "TODO"  -IsEnabled $false)  -ContactElectionJob (New-SiteJobTrigger -Url "TODO"  -IsEnabled $false)  -StorageThresholdJob   -StatusScanJob (New-SiteStatusScanJobTrigger -JobType (New-StatusScanDemoJobType)  -Url "TODO"  -IsEnabled $false)  -AutoLockJob (New-SiteAutoLockJobTrigger -JobType (New-SiteAutoLockJobTriggerType)  -Url "TODO"  -IsEnabled $false)  -RecertificationJob (New-SiteRecertificationJobTrigger -JobType (New-SiteRecertificationType)  -Url "TODO"  -IsEnabled $false)  -AutomaticImportJob (New-AutoImportObjectDemoJob -ProfileName "ProfileName_example"  -IsEnabled $false))  -GroupJobs (New-GroupJobTriggers -RenewalJob (New-GroupJobTrigger -GroupNameOrId "GroupNameOrId_example"  -IsEnabled $false)  -StatusScanJob (New-GroupStatusScanJobTrigger -JobType (New-StatusScanDemoJobType)  -GroupNameOrId "GroupNameOrId_example"  -IsEnabled $false)  -DeleteExpiredGroupJob (New-GroupJobTrigger -GroupNameOrId "GroupNameOrId_example"  -IsEnabled $false)  -ArchiveExpiredGroupJob   -StorageThresholdJob   -RecertificationJob (New-GroupRecertificationJobTrigger -JobType (New-GroupRecertificationType)  -GroupNameOrId "GroupNameOrId_example"  -IsEnabled $false)  -AutomaticImportJob (New-AutoImportObjectDemoJob -ProfileName "ProfileName_example"  -IsEnabled $false))) # DemoPreparationModel |  (optional)

# submit demo preparation request
try {
    Submit-DemoPreparation -DemoPreparationModel $DemoPreparationModel
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **DemoPreparationModel** | [**DemoPreparationModel**](DemoPreparationModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateAzureStorage"></a>
# **Invoke-ValidateAzureStorage**
> Boolean Invoke-ValidateAzureStorage<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-AzureStorage] <PSCustomObject><br>

validate azure storage

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



$AzureStorage = (New-AzureStorage -AccountName "AccountName_example"  -AccountKey "AccountKey_example"  -NeedHttps $false) # AzureStorage |  (optional)

# validate azure storage
try {
    $Result = Invoke-ValidateAzureStorage -AzureStorage $AzureStorage
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AzureStorage** | [**AzureStorage**](AzureStorage.md)|  | [optional] 

### Return type

**Boolean**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-ValidateSharePointUrl"></a>
# **Invoke-ValidateSharePointUrl**
> Boolean Invoke-ValidateSharePointUrl<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Body] <URI><br>

validate sharepoint folder or library url

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



$Body = TODO # URI |  (optional)

# validate sharepoint folder or library url
try {
    $Result = Invoke-ValidateSharePointUrl -Body $Body
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Body** | **URI**|  | [optional] 

### Return type

**Boolean**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

