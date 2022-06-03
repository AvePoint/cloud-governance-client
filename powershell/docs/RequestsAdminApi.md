# RequestsAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get-AllRequests**](RequestsAdminApi.md#Get-AllRequests) | **GET** /admin/directory/requests | get all requests


<a name="Get-AllRequests"></a>
# **Get-AllRequests**
> AllRequestListPageResult Get-AllRequests<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Filter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Search] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Nexttoken] <String><br>

get all requests

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



$Filter = "Filter_example" # String | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, serviceId, serviceName, serviceType, category, approvalStageName, participants, ticketNumber, summary, requester, detailStatus, progressStatus, modified, assignTo, serviceAdmin, objectUrl, objectID, createdTime, hasSubRequest (optional)
$Orderby = "Orderby_example" # String | Order by one field, supported fields:<br/> id, serviceId, serviceName, serviceType, category, approvalStageName, participants, ticketNumber, summary, requester, detailStatus, progressStatus, modified, assignTo, serviceAdmin, objectUrl, objectID, createdTime, hasSubRequest (optional)
$Search = "Search_example" # String | Search for ticketNumber (optional)
$Top = 987 # Int32 |  Define the number of records you want to return, max value is 3000, default value is 200 (optional)
$Skip = "Skip_example" # String |  Define the number of records you want to skip, default value is 0 (optional)
$Nexttoken = "Nexttoken_example" # String |  Use the next token to get the next paging result (optional)

# get all requests
try {
     $Result = Get-AllRequests -Filter $Filter -Orderby $Orderby -Search $Search -Top $Top -Skip $Skip -Nexttoken $Nexttoken
} catch {
    Write-Host ("Exception occured when calling Get-AllRequests: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Filter** | **String**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, serviceId, serviceName, serviceType, category, approvalStageName, participants, ticketNumber, summary, requester, detailStatus, progressStatus, modified, assignTo, serviceAdmin, objectUrl, objectID, createdTime, hasSubRequest | [optional] 
 **Orderby** | **String**| Order by one field, supported fields:&lt;br/&gt; id, serviceId, serviceName, serviceType, category, approvalStageName, participants, ticketNumber, summary, requester, detailStatus, progressStatus, modified, assignTo, serviceAdmin, objectUrl, objectID, createdTime, hasSubRequest | [optional] 
 **Search** | **String**| Search for ticketNumber | [optional] 
 **Top** | **Int32**|  Define the number of records you want to return, max value is 3000, default value is 200 | [optional] 
 **Skip** | **String**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **Nexttoken** | **String**|  Use the next token to get the next paging result | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**AllRequestListPageResult**](AllRequestListPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

