# Cloud.Governance.Client.Cloud.Governance.Client\Api.QuestionnairesApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-QuestionnaireById**](QuestionnairesApi.md#Get-QuestionnaireById) | **GET** /questionnaires/{id} | get questionnaire by id
[**Submit-Questionnaire**](QuestionnairesApi.md#Submit-Questionnaire) | **POST** /questionnaires | submit questionnaire
[**Submit-QuestionnaireInWorkspace**](QuestionnairesApi.md#Submit-QuestionnaireInWorkspace) | **POST** /questionnaires/workspace/{objecttype}/{objectid} | submit questionnaire in workspace


<a name="Get-QuestionnaireById"></a>
# **Get-QuestionnaireById**
> QuestionnaireRef Get-QuestionnaireById<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Id] <PSCustomObject><br>

get questionnaire by id

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

# get questionnaire by id
try {
    $Result = Get-QuestionnaireById -Id $Id
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Id** | [**UUID**](UUID.md)|  | [default to null]

### Return type

[**QuestionnaireRef**](QuestionnaireRef.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-Questionnaire"></a>
# **Submit-Questionnaire**
> ServiceList[] Submit-Questionnaire<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireRequest] <PSCustomObject><br>

submit questionnaire

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



$QuestionnaireRequest = (New-QuestionnaireRequest -Id "TODO"  -Questions @((New-QuestionRequest -Id "TODO"  -Value (New-StringModel -Id "Id_example"  -Name "Name_example")))  -Services @("TODO")) # QuestionnaireRequest |  (optional)

# submit questionnaire
try {
    $Result = Submit-Questionnaire -QuestionnaireRequest $QuestionnaireRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **QuestionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**ServiceList[]**](ServiceList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Submit-QuestionnaireInWorkspace"></a>
# **Submit-QuestionnaireInWorkspace**
> ServiceList[] Submit-QuestionnaireInWorkspace<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Objecttype] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Objectid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-QuestionnaireRequest] <PSCustomObject><br>

submit questionnaire in workspace

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
$QuestionnaireRequest = (New-QuestionnaireRequest -Id "TODO"  -Questions @((New-QuestionRequest -Id "TODO"  -Value (New-StringModel -Id "Id_example"  -Name "Name_example")))  -Services @("TODO")) # QuestionnaireRequest |  (optional)

# submit questionnaire in workspace
try {
    $Result = Submit-QuestionnaireInWorkspace -Objecttype $Objecttype -Objectid $Objectid -QuestionnaireRequest $QuestionnaireRequest
} catch {
    
    Write-Host ($_.Exception)
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Objecttype** | [**WorkspaceType**](WorkspaceType.md)|  | [default to null]
 **Objectid** | **String**|  | [default to null]
 **QuestionnaireRequest** | [**QuestionnaireRequest**](QuestionnaireRequest.md)|  | [optional] 

### Return type

[**ServiceList[]**](ServiceList.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

