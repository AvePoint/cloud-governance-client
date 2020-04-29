# Cloud.Governance.Client.Cloud.Governance.Client\Api.QuestionnairesAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Invoke-DeleteSelectedQuestionnaires**](QuestionnairesAdminApi.md#Invoke-DeleteSelectedQuestionnaires) | **DELETE** /admin/questionnaires | remove selected questionnaires
[**Get-QuestionMetadataList**](QuestionnairesAdminApi.md#Get-QuestionMetadataList) | **GET** /admin/questionnaires/question/metadata | get question metadata list
[**Get-QuestionServiceList**](QuestionnairesAdminApi.md#Get-QuestionServiceList) | **GET** /admin/questionnaires/service | get questionnaire service list
[**Get-QuestionnaireFilters**](QuestionnairesAdminApi.md#Get-QuestionnaireFilters) | **GET** /admin/questionnaires/filters | get filters of questionnaires
[**Get-QuestionnaireSetting**](QuestionnairesAdminApi.md#Get-QuestionnaireSetting) | **GET** /admin/questionnaires/{id} | get questionnaire setting
[**Get-Questionnaires**](QuestionnairesAdminApi.md#Get-Questionnaires) | **GET** /admin/questionnaires | get all questionnaires
[**Update-SelectedQuestionnairesStatus**](QuestionnairesAdminApi.md#Update-SelectedQuestionnairesStatus) | **PATCH** /admin/questionnaires/status/{status} | update the status of selected questionnaires


<a name="Invoke-DeleteSelectedQuestionnaires"></a>
# **Invoke-DeleteSelectedQuestionnaires**
> void Invoke-DeleteSelectedQuestionnaires<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

remove selected questionnaires

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

# remove selected questionnaires
try {
    Invoke-DeleteSelectedQuestionnaires -UUID $UUID
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

<a name="Get-QuestionMetadataList"></a>
# **Get-QuestionMetadataList**
> StringModel[] Get-QuestionMetadataList<br>

get question metadata list

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




# get question metadata list
try {
    $Result = Get-QuestionMetadataList
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StringModel[]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-QuestionServiceList"></a>
# **Get-QuestionServiceList**
> StringModel[] Get-QuestionServiceList<br>

get questionnaire service list

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




# get questionnaire service list
try {
    $Result = Get-QuestionServiceList
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StringModel[]**](StringModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-QuestionnaireFilters"></a>
# **Get-QuestionnaireFilters**
> DistinctPageResult Get-QuestionnaireFilters<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Distinct] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get filters of questionnaires

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, languageID, status (optional) (default to null)
$Distinct = "Distinct_example" # String | Get the unique values for one field, supported fields:<br/> id, name, description, languageID, status (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get filters of questionnaires
try {
    $Result = Get-QuestionnaireFilters -Filter $Filter -Distinct $Distinct -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, languageID, status | [optional] [default to null]
 **Distinct** | **String**| Get the unique values for one field, supported fields:&lt;br/&gt; id, name, description, languageID, status | [optional] [default to null]
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

<a name="Get-QuestionnaireSetting"></a>
# **Get-QuestionnaireSetting**
> QuestionnaireModel Get-QuestionnaireSetting<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get questionnaire setting

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

# get questionnaire setting
try {
    $Result = Get-QuestionnaireSetting -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**QuestionnaireModel**](QuestionnaireModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-Questionnaires"></a>
# **Get-Questionnaires**
> QuestionnaireGridModelPageResult Get-Questionnaires<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all questionnaires

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, languageID, status (optional) (default to null)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, name, description, languageID, status (optional) (default to null)
$Search = "Search_example" # String | Search for name (optional) (default to null)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 200, default value is 200 (optional) (default to null)
$Skip = 987 # Int32 |  Define the number of records you want to skip, default value is 0 (optional) (default to null)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional) (default to null)

# get all questionnaires
try {
    $Result = Get-Questionnaires -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, languageID, status | [optional] [default to null]
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, name, description, languageID, status | [optional] [default to null]
 **Search** | **String**| Search for name | [optional] [default to null]
 **Top** | **Int32**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] [default to null]
 **Skip** | **Int32**|  Define the number of records you want to skip, default value is 0 | [optional] [default to null]
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] [default to null]

### Return type

[**QuestionnaireGridModelPageResult**](QuestionnaireGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-SelectedQuestionnairesStatus"></a>
# **Update-SelectedQuestionnairesStatus**
> void Update-SelectedQuestionnairesStatus<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Status] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-UUID] <PSCustomObject[]><br>

update the status of selected questionnaires

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



$Status = (New-CommonStatus) # CommonStatus |  (default to null)
$UUID = @("TODO") # UUID[] |  (optional)

# update the status of selected questionnaires
try {
    Update-SelectedQuestionnairesStatus -Status $Status -UUID $UUID
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Status** | [**CommonStatus**](CommonStatus.md)|  | [default to null]
 **UUID** | [**UUID[]**](UUID.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

