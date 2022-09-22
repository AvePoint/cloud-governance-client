# Cloud.Governance.Client.Api.WorkspacesAdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyGroupsPolicy**](WorkspacesAdminApi.md#applygroupspolicy) | **POST** /admin/directory/workspace/groups/policy | apply groups policy
[**ApplySitesPolicy**](WorkspacesAdminApi.md#applysitespolicy) | **POST** /admin/directory/workspace/sites/policy | apply site policy
[**ArchiveWorkspace**](WorkspacesAdminApi.md#archiveworkspace) | **POST** /admin/directory/workspace/archive | archive workspace
[**CompleteWorkspaceRenewalTask**](WorkspacesAdminApi.md#completeworkspacerenewaltask) | **POST** /admin/directory/workspace/renewal/complete | completed renewal task
[**DeleteWorkspaces**](WorkspacesAdminApi.md#deleteworkspaces) | **DELETE** /admin/directory/workspace | delete workspaces
[**GetOngoingTasks**](WorkspacesAdminApi.md#getongoingtasks) | **GET** /admin/directory/workspace/{type}/ongoningtasks | get workspace ongoing tasks
[**GetWorkspaceFilters**](WorkspacesAdminApi.md#getworkspacefilters) | **GET** /admin/directory/workspace/filters | get filters for workspace report
[**GetWorkspaces**](WorkspacesAdminApi.md#getworkspaces) | **GET** /admin/directory/workspace | get managed workspaces
[**LockWorkspaces**](WorkspacesAdminApi.md#lockworkspaces) | **POST** /admin/directory/workspace/lock | lock sites or Office365 group sites
[**SpecifyContacts**](WorkspacesAdminApi.md#specifycontacts) | **POST** /admin/directory/workspace/contacts | specify contacts
[**TriggerWorkspaceRenewal**](WorkspacesAdminApi.md#triggerworkspacerenewal) | **POST** /admin/directory/workspace/renewal/trigger | trigger workspace renewal
[**TriggerWorkspacesElection**](WorkspacesAdminApi.md#triggerworkspaceselection) | **POST** /admin/directory/workspace/election/trigger | trigger workspace election
[**UnlockWorkspace**](WorkspacesAdminApi.md#unlockworkspace) | **POST** /admin/directory/workspace/unlock | unlock sites and Office365 group site


<a name="applygroupspolicy"></a>
# **ApplyGroupsPolicy**
> void ApplyGroupsPolicy (ApplyGroupPolicyModel applyGroupPolicyModel = null)

apply groups policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ApplyGroupsPolicyExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var applyGroupPolicyModel = new ApplyGroupPolicyModel(); // ApplyGroupPolicyModel | apply policy setting (optional) 

            try
            {
                // apply groups policy
                apiInstance.ApplyGroupsPolicy(applyGroupPolicyModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.ApplyGroupsPolicy: " + e.Message );
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
 **applyGroupPolicyModel** | [**ApplyGroupPolicyModel**](ApplyGroupPolicyModel.md)| apply policy setting | [optional] 

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
| **200** | start to apply site policy |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applysitespolicy"></a>
# **ApplySitesPolicy**
> void ApplySitesPolicy (ApplySitePolicyModel applySitePolicyModel = null)

apply site policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ApplySitesPolicyExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var applySitePolicyModel = new ApplySitePolicyModel(); // ApplySitePolicyModel | apply policy setting (optional) 

            try
            {
                // apply site policy
                apiInstance.ApplySitesPolicy(applySitePolicyModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.ApplySitesPolicy: " + e.Message );
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
 **applySitePolicyModel** | [**ApplySitePolicyModel**](ApplySitePolicyModel.md)| apply policy setting | [optional] 

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
| **200** | start to apply site policy |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="archiveworkspace"></a>
# **ArchiveWorkspace**
> void ArchiveWorkspace (ArchiveWorkspaceParameter archiveWorkspaceParameter = null)

archive workspace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ArchiveWorkspaceExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var archiveWorkspaceParameter = new ArchiveWorkspaceParameter(); // ArchiveWorkspaceParameter |  (optional) 

            try
            {
                // archive workspace
                apiInstance.ArchiveWorkspace(archiveWorkspaceParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.ArchiveWorkspace: " + e.Message );
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
 **archiveWorkspaceParameter** | [**ArchiveWorkspaceParameter**](ArchiveWorkspaceParameter.md)|  | [optional] 

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

<a name="completeworkspacerenewaltask"></a>
# **CompleteWorkspaceRenewalTask**
> void CompleteWorkspaceRenewalTask (string filter = null, AutoCompleteRenewalTaskParameter autoCompleteRenewalTaskParameter = null)

completed renewal task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class CompleteWorkspaceRenewalTaskExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var filter = filter_example;  // string |  (optional) 
            var autoCompleteRenewalTaskParameter = new AutoCompleteRenewalTaskParameter(); // AutoCompleteRenewalTaskParameter |  (optional) 

            try
            {
                // completed renewal task
                apiInstance.CompleteWorkspaceRenewalTask(filter, autoCompleteRenewalTaskParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.CompleteWorkspaceRenewalTask: " + e.Message );
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
 **autoCompleteRenewalTaskParameter** | [**AutoCompleteRenewalTaskParameter**](AutoCompleteRenewalTaskParameter.md)|  | [optional] 

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

<a name="deleteworkspaces"></a>
# **DeleteWorkspaces**
> void DeleteWorkspaces (DeleteWorkspaceParameter deleteWorkspaceParameter = null)

delete workspaces

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteWorkspacesExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var deleteWorkspaceParameter = new DeleteWorkspaceParameter(); // DeleteWorkspaceParameter |  (optional) 

            try
            {
                // delete workspaces
                apiInstance.DeleteWorkspaces(deleteWorkspaceParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.DeleteWorkspaces: " + e.Message );
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
 **deleteWorkspaceParameter** | [**DeleteWorkspaceParameter**](DeleteWorkspaceParameter.md)|  | [optional] 

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

<a name="getongoingtasks"></a>
# **GetOngoingTasks**
> List&lt;WorksapceOngoingTasksModel&gt; GetOngoingTasks (WorkspaceType type, string groupNameOrUrl)

get workspace ongoing tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetOngoingTasksExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var type = ;  // WorkspaceType | 
            var groupNameOrUrl = groupNameOrUrl_example;  // string | 

            try
            {
                // get workspace ongoing tasks
                List<WorksapceOngoingTasksModel> result = apiInstance.GetOngoingTasks(type, groupNameOrUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.GetOngoingTasks: " + e.Message );
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
 **type** | **WorkspaceType**|  | 
 **groupNameOrUrl** | **string**|  | 

### Return type

[**List&lt;WorksapceOngoingTasksModel&gt;**](WorksapceOngoingTasksModel.md)

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

<a name="getworkspacefilters"></a>
# **GetWorkspaceFilters**
> List&lt;DistinctResult&gt; GetWorkspaceFilters (string distinct = null)

get filters for workspace report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetWorkspaceFiltersExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var distinct = distinct_example;  // string | support value: PolicyId,PolicyName,PhaseProfileId,PhaseProfileName,GeoLocation,Classification and metadata (optional) 

            try
            {
                // get filters for workspace report
                List<DistinctResult> result = apiInstance.GetWorkspaceFilters(distinct);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.GetWorkspaceFilters: " + e.Message );
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
 **distinct** | **string**| support value: PolicyId,PolicyName,PhaseProfileId,PhaseProfileName,GeoLocation,Classification and metadata | [optional] 

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
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspaces"></a>
# **GetWorkspaces**
> WorkspaceGridModelPageResult GetWorkspaces (string filter = null, string orderby = null, string search = null, int? top = null, string skip = null, string nexttoken = null)

get managed workspaces

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetWorkspacesExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, phaseAssignees, phaseProfileName, phaseProfileId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, phaseAssignees, phaseProfileName, phaseProfileId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = skip_example;  // string |  Define the number of records you want to skip, default value is 0 (optional) 
            var nexttoken = nexttoken_example;  // string |  Use the next token to get the next paging result (optional) 

            try
            {
                // get managed workspaces
                WorkspaceGridModelPageResult result = apiInstance.GetWorkspaces(filter, orderby, search, top, skip, nexttoken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.GetWorkspaces: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, phaseAssignees, phaseProfileName, phaseProfileId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, lockedBy, phaseAssignees, phaseProfileName, phaseProfileId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **string**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **nexttoken** | **string**|  Use the next token to get the next paging result | [optional] 

### Return type

[**WorkspaceGridModelPageResult**](WorkspaceGridModelPageResult.md)

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

<a name="lockworkspaces"></a>
# **LockWorkspaces**
> void LockWorkspaces (LockSiteParameter lockSiteParameter = null)

lock sites or Office365 group sites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LockWorkspacesExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var lockSiteParameter = new LockSiteParameter(); // LockSiteParameter |  (optional) 

            try
            {
                // lock sites or Office365 group sites
                apiInstance.LockWorkspaces(lockSiteParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.LockWorkspaces: " + e.Message );
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
 **lockSiteParameter** | [**LockSiteParameter**](LockSiteParameter.md)|  | [optional] 

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

<a name="specifycontacts"></a>
# **SpecifyContacts**
> void SpecifyContacts (string filter = null, SpecifyContactParameter specifyContactParameter = null)

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
    public class SpecifyContactsExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var filter = filter_example;  // string |  (optional) 
            var specifyContactParameter = new SpecifyContactParameter(); // SpecifyContactParameter |  (optional) 

            try
            {
                // specify contacts
                apiInstance.SpecifyContacts(filter, specifyContactParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.SpecifyContacts: " + e.Message );
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

<a name="triggerworkspacerenewal"></a>
# **TriggerWorkspaceRenewal**
> void TriggerWorkspaceRenewal (string filter = null, WorkspaceSendCancelEmailParameter workspaceSendCancelEmailParameter = null)

trigger workspace renewal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class TriggerWorkspaceRenewalExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var filter = filter_example;  // string |  (optional) 
            var workspaceSendCancelEmailParameter = new WorkspaceSendCancelEmailParameter(); // WorkspaceSendCancelEmailParameter |  (optional) 

            try
            {
                // trigger workspace renewal
                apiInstance.TriggerWorkspaceRenewal(filter, workspaceSendCancelEmailParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.TriggerWorkspaceRenewal: " + e.Message );
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
 **workspaceSendCancelEmailParameter** | [**WorkspaceSendCancelEmailParameter**](WorkspaceSendCancelEmailParameter.md)|  | [optional] 

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

<a name="triggerworkspaceselection"></a>
# **TriggerWorkspacesElection**
> void TriggerWorkspacesElection (string filter = null, WorkspaceActionParameter workspaceActionParameter = null)

trigger workspace election

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class TriggerWorkspacesElectionExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var filter = filter_example;  // string |  (optional) 
            var workspaceActionParameter = new WorkspaceActionParameter(); // WorkspaceActionParameter |  (optional) 

            try
            {
                // trigger workspace election
                apiInstance.TriggerWorkspacesElection(filter, workspaceActionParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.TriggerWorkspacesElection: " + e.Message );
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
 **workspaceActionParameter** | [**WorkspaceActionParameter**](WorkspaceActionParameter.md)|  | [optional] 

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

<a name="unlockworkspace"></a>
# **UnlockWorkspace**
> void UnlockWorkspace (WorkspaceActionParameter workspaceActionParameter = null)

unlock sites and Office365 group site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UnlockWorkspaceExample
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

            var apiInstance = new WorkspacesAdminApi(config);

            var workspaceActionParameter = new WorkspaceActionParameter(); // WorkspaceActionParameter |  (optional) 

            try
            {
                // unlock sites and Office365 group site
                apiInstance.UnlockWorkspace(workspaceActionParameter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspacesAdminApi.UnlockWorkspace: " + e.Message );
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
 **workspaceActionParameter** | [**WorkspaceActionParameter**](WorkspaceActionParameter.md)|  | [optional] 

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

