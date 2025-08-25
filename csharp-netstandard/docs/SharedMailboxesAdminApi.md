# Cloud.Governance.Client.Api.SharedMailboxesAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSharedMailboxes**](SharedMailboxesAdminApi.md#getsharedmailboxes) | **GET** /admin/directory/sharedmailbox | get managed shared mailboxes
[**GetSharedMailboxesFilters**](SharedMailboxesAdminApi.md#getsharedmailboxesfilters) | **GET** /admin/directory/sharedmailbox/filters | get filters for shared mailbox report
[**SpecifySharedMailboxContacts**](SharedMailboxesAdminApi.md#specifysharedmailboxcontacts) | **POST** /admin/directory/sharedmailbox/contacts | specify contacts


<a name="getsharedmailboxes"></a>
# **GetSharedMailboxes**
> SharedMailboxBasicGridModelPageResult GetSharedMailboxes (string filter = null, string orderby = null, string search = null, int? top = null, string skip = null, string nexttoken = null)

get managed shared mailboxes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSharedMailboxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "{Cloud_Governance_Modern_API_Endpoint}";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new SharedMailboxesAdminApi(config);

            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = skip_example;  // string |  Define the number of records you want to skip, default value is 0 (optional) 
            var nexttoken = nexttoken_example;  // string |  Use the next token to get the next paging result (optional) 

            try
            {
                // get managed shared mailboxes
                SharedMailboxBasicGridModelPageResult result = apiInstance.GetSharedMailboxes(filter, orderby, search, top, skip, nexttoken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharedMailboxesAdminApi.GetSharedMailboxes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, email, createdTime, lastModifiedTime, lastRenewalTime, electionProfileName, electionProfileId, claimStatus, ongoingTaskCount, tenantId, status, members, directorySyncState, primaryContact, secondaryContact, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **string**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **nexttoken** | **string**|  Use the next token to get the next paging result | [optional] 

### Return type

[**SharedMailboxBasicGridModelPageResult**](SharedMailboxBasicGridModelPageResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsharedmailboxesfilters"></a>
# **GetSharedMailboxesFilters**
> List&lt;DistinctResult&gt; GetSharedMailboxesFilters (string distinct = null)

get filters for shared mailbox report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSharedMailboxesFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "{Cloud_Governance_Modern_API_Endpoint}";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new SharedMailboxesAdminApi(config);

            var distinct = distinct_example;  // string | support value: electionProfileName, electionProfileId, claimStatus, phaseProfileName, phaseProfileId, phase and metadata (optional) 

            try
            {
                // get filters for shared mailbox report
                List<DistinctResult> result = apiInstance.GetSharedMailboxesFilters(distinct);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharedMailboxesAdminApi.GetSharedMailboxesFilters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distinct** | **string**| support value: electionProfileName, electionProfileId, claimStatus, phaseProfileName, phaseProfileId, phase and metadata | [optional] 

### Return type

[**List&lt;DistinctResult&gt;**](DistinctResult.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="specifysharedmailboxcontacts"></a>
# **SpecifySharedMailboxContacts**
> void SpecifySharedMailboxContacts (string filter = null, SpecifyContactParameter specifyContactParameter = null)

specify contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SpecifySharedMailboxContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();

            //You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
            config.BasePath = "{Cloud_Governance_Modern_API_Endpoint}";

            // Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
            config.AddApiKey("clientSecret", "eyJ...");

            // Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
            // Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
            // If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
            config.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new SharedMailboxesAdminApi(config);

            var filter = filter_example;  // string |  (optional) 
            var specifyContactParameter = new SpecifyContactParameter(); // SpecifyContactParameter |  (optional) 

            try
            {
                // specify contacts
                apiInstance.SpecifySharedMailboxContacts(filter, specifyContactParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharedMailboxesAdminApi.SpecifySharedMailboxContacts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 
 **specifyContactParameter** | [**SpecifyContactParameter**](SpecifyContactParameter.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

