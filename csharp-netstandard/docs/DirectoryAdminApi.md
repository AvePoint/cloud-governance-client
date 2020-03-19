# Cloud.Governance.Client.Api.DirectoryAdminApi

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyGroupsPolicy**](DirectoryAdminApi.md#applygroupspolicy) | **POST** /admin/directory/groups/policy | apply groups policy
[**ApplySitesPolicy**](DirectoryAdminApi.md#applysitespolicy) | **POST** /admin/directory/sites/policy | apply sites policy
[**ApplyTeamsPolicy**](DirectoryAdminApi.md#applyteamspolicy) | **POST** /admin/directory/teams/policy | apply teams policy
[**ElectContact**](DirectoryAdminApi.md#electcontact) | **POST** /admin/directory/sites/contact/election | elect sites contact
[**GetAllMailContacts**](DirectoryAdminApi.md#getallmailcontacts) | **GET** /admin/directory/sites/contact/mail | get all sites contacts
[**GetManagedGroupFilters**](DirectoryAdminApi.md#getmanagedgroupfilters) | **GET** /admin/directory/groups/filters | get managed groups filters
[**GetManagedGroups**](DirectoryAdminApi.md#getmanagedgroups) | **GET** /admin/directory/groups | get all managed groups
[**GetManagedSites**](DirectoryAdminApi.md#getmanagedsites) | **GET** /admin/directory/sites | get all managed sites
[**GetManagedSitesFilters**](DirectoryAdminApi.md#getmanagedsitesfilters) | **GET** /admin/directory/sites/filters | get managed sites filters
[**GetManagedTeamFilters**](DirectoryAdminApi.md#getmanagedteamfilters) | **GET** /admin/directory/teams/filters | get managed teams filters
[**GetManagedTeams**](DirectoryAdminApi.md#getmanagedteams) | **GET** /admin/directory/teams | get all managed teams
[**GetManagedWebs**](DirectoryAdminApi.md#getmanagedwebs) | **GET** /admin/directory/webs | get all managed webs
[**GetManagedWebsFilters**](DirectoryAdminApi.md#getmanagedwebsfilters) | **GET** /admin/directory/webs/filters | get managed webs filters
[**SpecifyContact**](DirectoryAdminApi.md#specifycontact) | **POST** /admin/directory/sites/contact/specification | specify selected sites contact


<a name="applygroupspolicy"></a>
# **ApplyGroupsPolicy**
> List&lt;string&gt; ApplyGroupsPolicy (ApplyPolicyRequestModel applyPolicyRequestModel = null)

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
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var applyPolicyRequestModel = new ApplyPolicyRequestModel(); // ApplyPolicyRequestModel |  (optional) 

            try
            {
                // apply groups policy
                List<string> result = apiInstance.ApplyGroupsPolicy(applyPolicyRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.ApplyGroupsPolicy: " + e.Message );
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
 **applyPolicyRequestModel** | [**ApplyPolicyRequestModel**](ApplyPolicyRequestModel.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applysitespolicy"></a>
# **ApplySitesPolicy**
> void ApplySitesPolicy (ApplyPolicyRequestModel applyPolicyRequestModel = null)

apply sites policy

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
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var applyPolicyRequestModel = new ApplyPolicyRequestModel(); // ApplyPolicyRequestModel |  (optional) 

            try
            {
                // apply sites policy
                apiInstance.ApplySitesPolicy(applyPolicyRequestModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.ApplySitesPolicy: " + e.Message );
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
 **applyPolicyRequestModel** | [**ApplyPolicyRequestModel**](ApplyPolicyRequestModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applyteamspolicy"></a>
# **ApplyTeamsPolicy**
> List&lt;string&gt; ApplyTeamsPolicy (ApplyPolicyRequestModel applyPolicyRequestModel = null)

apply teams policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ApplyTeamsPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var applyPolicyRequestModel = new ApplyPolicyRequestModel(); // ApplyPolicyRequestModel |  (optional) 

            try
            {
                // apply teams policy
                List<string> result = apiInstance.ApplyTeamsPolicy(applyPolicyRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.ApplyTeamsPolicy: " + e.Message );
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
 **applyPolicyRequestModel** | [**ApplyPolicyRequestModel**](ApplyPolicyRequestModel.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electcontact"></a>
# **ElectContact**
> List&lt;string&gt; ElectContact (ElectUserRequestModel electUserRequestModel = null)

elect sites contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ElectContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var electUserRequestModel = new ElectUserRequestModel(); // ElectUserRequestModel |  (optional) 

            try
            {
                // elect sites contact
                List<string> result = apiInstance.ElectContact(electUserRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.ElectContact: " + e.Message );
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
 **electUserRequestModel** | [**ElectUserRequestModel**](ElectUserRequestModel.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallmailcontacts"></a>
# **GetAllMailContacts**
> string GetAllMailContacts ()

get all sites contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAllMailContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);

            try
            {
                // get all sites contacts
                string result = apiInstance.GetAllMailContacts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetAllMailContacts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedgroupfilters"></a>
# **GetManagedGroupFilters**
> DistinctPageResult GetManagedGroupFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get managed groups filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedGroupFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get managed groups filters
                DistinctPageResult result = apiInstance.GetManagedGroupFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedGroupFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedgroups"></a>
# **GetManagedGroups**
> GroupGridModelPageResult GetManagedGroups (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all managed groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var search = search_example;  // string | Search for groupName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all managed groups
                GroupGridModelPageResult result = apiInstance.GetManagedGroups(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedGroups: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; groupId, groupName, groupSharing, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **search** | **string**| Search for groupName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**GroupGridModelPageResult**](GroupGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedsites"></a>
# **GetManagedSites**
> SiteListPageResult GetManagedSites (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all managed sites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedSitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) 
            var search = search_example;  // string | Search for url (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all managed sites
                SiteListPageResult result = apiInstance.GetManagedSites(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedSites: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] 
 **search** | **string**| Search for url | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**SiteListPageResult**](SiteListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedsitesfilters"></a>
# **GetManagedSitesFilters**
> DistinctPageResult GetManagedSitesFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get managed sites filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedSitesFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get managed sites filters
                DistinctPageResult result = apiInstance.GetManagedSitesFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedSitesFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, description, title, url, department, policyName, policyId, template, owner, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, additionalAdministrators, additionalAdministratorDisplayNames, createdTime, status, claimStatus, sharing, storageQuota, storageUsed, inactivityThresholdTime, leaseExpirationTime, permissionRecertificationStatus, metadataRecertificationStatus, ownershipRecertificationStatus, geoLocation, hub, phase | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedteamfilters"></a>
# **GetManagedTeamFilters**
> DistinctPageResult GetManagedTeamFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get managed teams filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedTeamFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get managed teams filters
                DistinctPageResult result = apiInstance.GetManagedTeamFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedTeamFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedteams"></a>
# **GetManagedTeams**
> TeamsGridModelPageResult GetManagedTeams (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all managed teams

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase (optional) 
            var search = search_example;  // string | Search for teamsName (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all managed teams
                TeamsGridModelPageResult result = apiInstance.GetManagedTeams(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedTeams: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; teamsId, teamsName, teamsSharing, enableTeamsArchive, enableTeamsRestore, id, objectId, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, owners, ownersDisplayName, policyName, policyId, privacy, subscribeMembers, teamsSiteSharing, outsideSenders, language, siteUrl, siteQuota, siteUsage, leaseExpirationTime, createdTime, enableLeaseExtension, enablePolicyChange, enableDeletion, enableSiteQuotaChange, enableLeaseManagement, enableInactivityThreshold, inactivityThresholdTime, classification, enableHiddenMembership, permissionRecertificationStatus, membershipRecertificationStatus, status, hub, geoLocation, phase | [optional] 
 **search** | **string**| Search for teamsName | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**TeamsGridModelPageResult**](TeamsGridModelPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedwebs"></a>
# **GetManagedWebs**
> WebListPageResult GetManagedWebs (string filter = null, string orderby = null, string search = null, int? top = null, int? skip = null)

get all managed webs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedWebsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) 
            var search = search_example;  // string | Search for url (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get all managed webs
                WebListPageResult result = apiInstance.GetManagedWebs(filter, orderby, search, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedWebs: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] 
 **search** | **string**| Search for url | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**WebListPageResult**](WebListPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagedwebsfilters"></a>
# **GetManagedWebsFilters**
> DistinctPageResult GetManagedWebsFilters (string filter = null, string distinct = null, int? top = null, int? skip = null)

get managed webs filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetManagedWebsFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) 
            var distinct = distinct_example;  // string | Get the unique values for one field, supported fields:<br/> id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = 56;  // int? |  Define the number of records you want to skip, default value is 0 (optional) 

            try
            {
                // get managed webs filters
                DistinctPageResult result = apiInstance.GetManagedWebsFilters(filter, distinct, top, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.GetManagedWebsFilters: " + e.Message );
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
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] 
 **distinct** | **string**| Get the unique values for one field, supported fields:&lt;br/&gt; id, description, title, url, template, primaryContact, primaryContactDisplayName, secondaryContact, secondaryContactDisplayName, createdTime, status | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **int?**|  Define the number of records you want to skip, default value is 0 | [optional] 

### Return type

[**DistinctPageResult**](DistinctPageResult.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="specifycontact"></a>
# **SpecifyContact**
> SpecifyContactResultModel SpecifyContact (SpecifyContactModel specifyContactModel = null)

specify selected sites contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SpecifyContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            config.AddApiKey("clientId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientId", "Bearer");
            // Configure API key authorization: ClientSecret
            config.AddApiKey("clientSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("clientSecret", "Bearer");
            // Configure API key authorization: UserPrincipalName
            config.AddApiKey("userPrincipalName", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("userPrincipalName", "Bearer");

            var apiInstance = new DirectoryAdminApi(config);
            var specifyContactModel = new SpecifyContactModel(); // SpecifyContactModel |  (optional) 

            try
            {
                // specify selected sites contact
                SpecifyContactResultModel result = apiInstance.SpecifyContact(specifyContactModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DirectoryAdminApi.SpecifyContact: " + e.Message );
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
 **specifyContactModel** | [**SpecifyContactModel**](SpecifyContactModel.md)|  | [optional] 

### Return type

[**SpecifyContactResultModel**](SpecifyContactResultModel.md)

### Authorization

[ClientId](../README.md#ClientId), [ClientSecret](../README.md#ClientSecret), [UserPrincipalName](../README.md#UserPrincipalName)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

