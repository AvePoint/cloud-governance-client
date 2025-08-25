# Cloud.Governance.Client.Api.Office365AdminApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWebUserCustomAction**](Office365AdminApi.md#addwebusercustomaction) | **POST** /admin/office365/web/usercustomactions | add user custom actions, if exists, will update the existing one.
[**DeleteWebUserCustomAction**](Office365AdminApi.md#deletewebusercustomaction) | **DELETE** /admin/office365/web/usercustomactions | delete user custom actions by action name
[**GetAzureADExtensionPropertyNamesWithDataType**](Office365AdminApi.md#getazureadextensionpropertynameswithdatatype) | **GET** /admin/office365/azuread/{tenantId}/property/custom | get azure ad custom property with data type
[**GetAzureAdCustomPropertyNames**](Office365AdminApi.md#getazureadcustompropertynames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
[**GetDownloadFileUrL**](Office365AdminApi.md#getdownloadfileurl) | **GET** /admin/office365/downloadurl/{type} | get download file url
[**GetTenantIdByUrl**](Office365AdminApi.md#gettenantidbyurl) | **GET** /admin/office365/tenantid | get tenant ids by url
[**GetTenantIds**](Office365AdminApi.md#gettenantids) | **GET** /admin/office365/tenantids | get tenant ids by filter expression
[**GetUploadFileUrL**](Office365AdminApi.md#getuploadfileurl) | **GET** /admin/office365/uploadurl/{type} | get upload file url


<a name="addwebusercustomaction"></a>
# **AddWebUserCustomAction**
> void AddWebUserCustomAction (UserCustomAction userCustomAction)

add user custom actions, if exists, will update the existing one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class AddWebUserCustomActionExample
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

            var apiInstance = new Office365AdminApi(config);

            var userCustomAction = new UserCustomAction(); // UserCustomAction | 

            try
            {
                // add user custom actions, if exists, will update the existing one.
                apiInstance.AddWebUserCustomAction(userCustomAction);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.AddWebUserCustomAction: " + e.Message );
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
 **userCustomAction** | [**UserCustomAction**](UserCustomAction.md)|  | 

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

<a name="deletewebusercustomaction"></a>
# **DeleteWebUserCustomAction**
> void DeleteWebUserCustomAction (string webFullUrl, string name)

delete user custom actions by action name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class DeleteWebUserCustomActionExample
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

            var apiInstance = new Office365AdminApi(config);

            var webFullUrl = webFullUrl_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                // delete user custom actions by action name
                apiInstance.DeleteWebUserCustomAction(webFullUrl, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.DeleteWebUserCustomAction: " + e.Message );
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
 **webFullUrl** | **string**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getazureadextensionpropertynameswithdatatype"></a>
# **GetAzureADExtensionPropertyNamesWithDataType**
> List&lt;CustomExtensionPropertyModel&gt; GetAzureADExtensionPropertyNamesWithDataType (Guid tenantId)

get azure ad custom property with data type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAzureADExtensionPropertyNamesWithDataTypeExample
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

            var apiInstance = new Office365AdminApi(config);

            var tenantId = new Guid(); // Guid | 

            try
            {
                // get azure ad custom property with data type
                List<CustomExtensionPropertyModel> result = apiInstance.GetAzureADExtensionPropertyNamesWithDataType(tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetAzureADExtensionPropertyNamesWithDataType: " + e.Message );
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
 **tenantId** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;CustomExtensionPropertyModel&gt;**](CustomExtensionPropertyModel.md)

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

<a name="getazureadcustompropertynames"></a>
# **GetAzureAdCustomPropertyNames**
> List&lt;string&gt; GetAzureAdCustomPropertyNames (Guid tenantId, bool? isSearchUserProperty = null)

get azure ad custom property names

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAzureAdCustomPropertyNamesExample
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

            var apiInstance = new Office365AdminApi(config);

            var tenantId = new Guid(); // Guid | 
            var isSearchUserProperty = true;  // bool? |  (optional)  (default to false)

            try
            {
                // get azure ad custom property names
                List<string> result = apiInstance.GetAzureAdCustomPropertyNames(tenantId, isSearchUserProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetAzureAdCustomPropertyNames: " + e.Message );
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
 **tenantId** | [**Guid**](Guid.md)|  | 
 **isSearchUserProperty** | **bool?**|  | [optional] [default to false]

### Return type

**List<string>**

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

<a name="getdownloadfileurl"></a>
# **GetDownloadFileUrL**
> SASUriModel GetDownloadFileUrL (ApiUploadFileType type, string fileName)

get download file url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetDownloadFileUrLExample
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

            var apiInstance = new Office365AdminApi(config);

            var type = ;  // ApiUploadFileType | 
            var fileName = fileName_example;  // string | 

            try
            {
                // get download file url
                SASUriModel result = apiInstance.GetDownloadFileUrL(type, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetDownloadFileUrL: " + e.Message );
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
 **type** | **ApiUploadFileType**|  | 
 **fileName** | **string**|  | 

### Return type

[**SASUriModel**](SASUriModel.md)

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

<a name="gettenantidbyurl"></a>
# **GetTenantIdByUrl**
> void GetTenantIdByUrl (string uri)

get tenant ids by url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetTenantIdByUrlExample
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

            var apiInstance = new Office365AdminApi(config);

            var uri = uri_example;  // string | 

            try
            {
                // get tenant ids by url
                apiInstance.GetTenantIdByUrl(uri);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetTenantIdByUrl: " + e.Message );
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
 **uri** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettenantids"></a>
# **GetTenantIds**
> void GetTenantIds (Guid? viewId = null, string filter = null, string orderby = null, string search = null, int? top = null, string skip = null, string nexttoken = null)

get tenant ids by filter expression

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetTenantIdsExample
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

            var apiInstance = new Office365AdminApi(config);

            var viewId = new Guid?(); // Guid? |  (optional) 
            var filter = filter_example;  // string | Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, primaryContactStatusOfEnpower, secondaryContact, secondaryContactStatusOfEnpower, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, legalHold, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, tenantId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional) 
            var orderby = orderby_example;  // string | Order by one field, supported fields:<br/> id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, primaryContactStatusOfEnpower, secondaryContact, secondaryContactStatusOfEnpower, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, legalHold, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, tenantId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional) 
            var search = search_example;  // string | Search for name (optional) 
            var top = 56;  // int? |  Define the number of records you want to return, max value is 200, default value is 200 (optional) 
            var skip = skip_example;  // string |  Define the number of records you want to skip, default value is 0 (optional) 
            var nexttoken = nexttoken_example;  // string |  Use the next token to get the next paging result (optional) 

            try
            {
                // get tenant ids by filter expression
                apiInstance.GetTenantIds(viewId, filter, orderby, search, top, skip, nexttoken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetTenantIds: " + e.Message );
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
 **viewId** | [**Guid?**](Guid?.md)|  | [optional] 
 **filter** | **string**| Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, primaryContactStatusOfEnpower, secondaryContact, secondaryContactStatusOfEnpower, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, legalHold, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, tenantId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **orderby** | **string**| Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, primaryContactStatusOfEnpower, secondaryContact, secondaryContactStatusOfEnpower, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, siteStatus, legalHold, lockedBy, lastSyncTime, createdSource, siteTemplate, siteTemplateTitle, tenantId, quotaProfileName, quotaProfileId, externalSharingProfileName, externalSharingProfileId, electionProfileName, electionProfileId, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase | [optional] 
 **search** | **string**| Search for name | [optional] 
 **top** | **int?**|  Define the number of records you want to return, max value is 200, default value is 200 | [optional] 
 **skip** | **string**|  Define the number of records you want to skip, default value is 0 | [optional] 
 **nexttoken** | **string**|  Use the next token to get the next paging result | [optional] 

### Return type

void (empty response body)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadfileurl"></a>
# **GetUploadFileUrL**
> SASUriModel GetUploadFileUrL (ApiUploadFileType type, string fileName)

get upload file url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetUploadFileUrLExample
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

            var apiInstance = new Office365AdminApi(config);

            var type = ;  // ApiUploadFileType | 
            var fileName = fileName_example;  // string | 

            try
            {
                // get upload file url
                SASUriModel result = apiInstance.GetUploadFileUrL(type, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetUploadFileUrL: " + e.Message );
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
 **type** | **ApiUploadFileType**|  | 
 **fileName** | **string**|  | 

### Return type

[**SASUriModel**](SASUriModel.md)

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

