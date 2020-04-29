# Cloud.Governance.Client.Cloud.Governance.Client\Api.DashboardAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-CreateLineOrColumnReport**](DashboardAdminApi.md#Invoke-CreateLineOrColumnReport) | **POST** /admin/dashboard/charts/lineorcolumn | create line or column report
[**Invoke-CreatePieReport**](DashboardAdminApi.md#Invoke-CreatePieReport) | **POST** /admin/dashboard/charts/pie | create pie report
[**Invoke-DeleteReport**](DashboardAdminApi.md#Invoke-DeleteReport) | **DELETE** /admin/dashboard/charts/{id} | delete report
[**Get-AllReportsIndex**](DashboardAdminApi.md#Get-AllReportsIndex) | **GET** /admin/dashboard/charts/all | load all report index
[**Get-LastLastModifiedTime**](DashboardAdminApi.md#Get-LastLastModifiedTime) | **GET** /admin/dashboard/charts/timerange | get default time range
[**Get-ReportSettings**](DashboardAdminApi.md#Get-ReportSettings) | **GET** /admin/dashboard/charts/{id}/settings | get report info for edit
[**Invoke-LoadChartStatistics**](DashboardAdminApi.md#Invoke-LoadChartStatistics) | **GET** /admin/dashboard/charts/statistics/{source} | load chart statistic data by source type
[**Invoke-LoadLegendEntries**](DashboardAdminApi.md#Invoke-LoadLegendEntries) | **GET** /admin/dashboard/charts/legendentries/{source}/{legendsource} | load legend entries
[**Update-LineOrColumnReport**](DashboardAdminApi.md#Update-LineOrColumnReport) | **PUT** /admin/dashboard/charts/lineorcolumn | update line or column report
[**Update-PieReport**](DashboardAdminApi.md#Update-PieReport) | **PUT** /admin/dashboard/charts/pie | update pie report


<a name="Invoke-CreateLineOrColumnReport"></a>
# **Invoke-CreateLineOrColumnReport**
> UUID Invoke-CreateLineOrColumnReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-LineOrColumnChartReport] <PSCustomObject><br>

create line or column report

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



$LineOrColumnChartReport = (New-LineOrColumnChartReport -XAxis "XAxis_example"  -YAxis "YAxis_example"  -EnableLegend $false  -SelectedColumn "SelectedColumn_example"  -LegendEntries @("LegendEntries_example")  -Id "TODO"  -Title "Title_example"  -Description "Description_example"  -DataSource (New-ReportDataSource)  -Type (New-ChartType)  -UserId 123  -CreatedTime Get-Date) # LineOrColumnChartReport |  (optional)

# create line or column report
try {
    $Result = Invoke-CreateLineOrColumnReport -LineOrColumnChartReport $LineOrColumnChartReport
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **LineOrColumnChartReport** | [**LineOrColumnChartReport**](LineOrColumnChartReport.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-CreatePieReport"></a>
# **Invoke-CreatePieReport**
> UUID Invoke-CreatePieReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PieChartReport] <PSCustomObject><br>

create pie report

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



$PieChartReport = (New-PieChartReport -StatisticColumn "StatisticColumn_example"  -Id "TODO"  -Title "Title_example"  -Description "Description_example"  -DataSource (New-ReportDataSource)  -Type (New-ChartType)  -UserId 123  -CreatedTime Get-Date) # PieChartReport |  (optional)

# create pie report
try {
    $Result = Invoke-CreatePieReport -PieChartReport $PieChartReport
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **PieChartReport** | [**PieChartReport**](PieChartReport.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-DeleteReport"></a>
# **Invoke-DeleteReport**
> void Invoke-DeleteReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

delete report

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

# delete report
try {
    Invoke-DeleteReport -Id $Id
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

<a name="Get-AllReportsIndex"></a>
# **Get-AllReportsIndex**
> Hashtable Get-AllReportsIndex<br>

load all report index

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




# load all report index
try {
    $Result = Get-AllReportsIndex
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Hashtable**](ChartType.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-LastLastModifiedTime"></a>
# **Get-LastLastModifiedTime**
> Hashtable Get-LastLastModifiedTime<br>

get default time range

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




# get default time range
try {
    $Result = Get-LastLastModifiedTime
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Hashtable**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-ReportSettings"></a>
# **Get-ReportSettings**
> ChartSettings Get-ReportSettings<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Starttime] <System.Nullable[Int64]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Endtime] <System.Nullable[Int64]><br>

get report info for edit

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
$Starttime = 987 # Int64 |  (optional) (default to 0)
$Endtime = 987 # Int64 |  (optional) (default to 0)

# get report info for edit
try {
    $Result = Get-ReportSettings -Id $Id -Starttime $Starttime -Endtime $Endtime
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]
 **Starttime** | **Int64**|  | [optional] [default to 0]
 **Endtime** | **Int64**|  | [optional] [default to 0]

### Return type

[**ChartSettings**](ChartSettings.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadChartStatistics"></a>
# **Invoke-LoadChartStatistics**
> ChartStatistic Invoke-LoadChartStatistics<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Source] <PSCustomObject><br>

load chart statistic data by source type

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



$Source =  # ReportDataSource |  (default to null)

# load chart statistic data by source type
try {
    $Result = Invoke-LoadChartStatistics -Source $Source
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Source** | [**ReportDataSource**](ReportDataSource.md)|  | [default to null]

### Return type

[**ChartStatistic**](ChartStatistic.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Invoke-LoadLegendEntries"></a>
# **Invoke-LoadLegendEntries**
> StringModel[] Invoke-LoadLegendEntries<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Source] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Legendsource] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Starttime] <System.Nullable[Int64]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Endtime] <System.Nullable[Int64]><br>

load legend entries

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



$Source =  # ReportDataSource |  (default to null)
$Legendsource = "Legendsource_example" # String |  (default to null)
$Starttime = 987 # Int64 |  (optional) (default to 0)
$Endtime = 987 # Int64 |  (optional) (default to 0)

# load legend entries
try {
    $Result = Invoke-LoadLegendEntries -Source $Source -Legendsource $Legendsource -Starttime $Starttime -Endtime $Endtime
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Source** | [**ReportDataSource**](ReportDataSource.md)|  | [default to null]
 **Legendsource** | **String**|  | [default to null]
 **Starttime** | **Int64**|  | [optional] [default to 0]
 **Endtime** | **Int64**|  | [optional] [default to 0]

### Return type

[**StringModel[]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-LineOrColumnReport"></a>
# **Update-LineOrColumnReport**
> UUID Update-LineOrColumnReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-LineOrColumnChartReport] <PSCustomObject><br>

update line or column report

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



$LineOrColumnChartReport = (New-LineOrColumnChartReport -XAxis "XAxis_example"  -YAxis "YAxis_example"  -EnableLegend $false  -SelectedColumn "SelectedColumn_example"  -LegendEntries @("LegendEntries_example")  -Id "TODO"  -Title "Title_example"  -Description "Description_example"  -DataSource   -Type   -UserId 123  -CreatedTime Get-Date) # LineOrColumnChartReport |  (optional)

# update line or column report
try {
    $Result = Update-LineOrColumnReport -LineOrColumnChartReport $LineOrColumnChartReport
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **LineOrColumnChartReport** | [**LineOrColumnChartReport**](LineOrColumnChartReport.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-PieReport"></a>
# **Update-PieReport**
> UUID Update-PieReport<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-PieChartReport] <PSCustomObject><br>

update pie report

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



$PieChartReport = (New-PieChartReport -StatisticColumn "StatisticColumn_example"  -Id "TODO"  -Title "Title_example"  -Description "Description_example"  -DataSource   -Type   -UserId 123  -CreatedTime Get-Date) # PieChartReport |  (optional)

# update pie report
try {
    $Result = Update-PieReport -PieChartReport $PieChartReport
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **PieChartReport** | [**PieChartReport**](PieChartReport.md)|  | [optional] 

### Return type

[**UUID**](UUID.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

