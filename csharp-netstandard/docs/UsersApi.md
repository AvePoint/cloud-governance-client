# Cloud.Governance.Client.Api.UsersApi

All URIs are relative to {*Cloud_Governance_Modern_API_Endpoint*}

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterUsersByAttribute**](UsersApi.md#filterusersbyattribute) | **GET** /users/filter | filter users by property value
[**GetAzureAdUserPropertyValue**](UsersApi.md#getazureaduserpropertyvalue) | **GET** /users/{username}/azuread/property | get Azure Ad user&#39;s property value
[**GetExtensionAzureAdUserPropertyValues**](UsersApi.md#getextensionazureaduserpropertyvalues) | **GET** /users/{username}/azuread/extensionproperties | get user&#39;s extension property value from azure ad
[**IsMemberOfGroup**](UsersApi.md#ismemberofgroup) | **GET** /users/{userprincipalname}/ismemberof/{groupid} | Is Member Of Group
[**ResolveUsers**](UsersApi.md#resolveusers) | **GET** /users/resolve | resolve users
[**SearchUsers**](UsersApi.md#searchusers) | **GET** /users/search | search users
[**UpdateUserInfo**](UsersApi.md#updateuserinfo) | **POST** /users | 


<a name="filterusersbyattribute"></a>
# **FilterUsersByAttribute**
> List&lt;ApiUser&gt; FilterUsersByAttribute (string attributeName, string attributeValue, string office365TenantId = null)

filter users by property value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class FilterUsersByAttributeExample
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

            var apiInstance = new UsersApi(config);

            var attributeName = attributeName_example;  // string | azure ad attribute name
            var attributeValue = attributeValue_example;  // string | value of attribute name
            var office365TenantId = office365TenantId_example;  // string | office 365 tenant id, optional, if not specified, only return the first tenant's result which is not empty (optional) 

            try
            {
                // filter users by property value
                List<ApiUser> result = apiInstance.FilterUsersByAttribute(attributeName, attributeValue, office365TenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.FilterUsersByAttribute: " + e.Message );
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
 **attributeName** | **string**| azure ad attribute name | 
 **attributeValue** | **string**| value of attribute name | 
 **office365TenantId** | **string**| office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty | [optional] 

### Return type

[**List&lt;ApiUser&gt;**](ApiUser.md)

### Authorization

[clientSecret](../README.md#clientSecret), [userPrincipalName](../README.md#userPrincipalName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | only return the first 100 users |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getazureaduserpropertyvalue"></a>
# **GetAzureAdUserPropertyValue**
> StringModel GetAzureAdUserPropertyValue (string username, string propertyName)

get Azure Ad user's property value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetAzureAdUserPropertyValueExample
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

            var apiInstance = new UsersApi(config);

            var username = username_example;  // string | 
            var propertyName = propertyName_example;  // string | 

            try
            {
                // get Azure Ad user's property value
                StringModel result = apiInstance.GetAzureAdUserPropertyValue(username, propertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetAzureAdUserPropertyValue: " + e.Message );
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
 **username** | **string**|  | 
 **propertyName** | **string**|  | 

### Return type

[**StringModel**](StringModel.md)

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

<a name="getextensionazureaduserpropertyvalues"></a>
# **GetExtensionAzureAdUserPropertyValues**
> List&lt;StringModel&gt; GetExtensionAzureAdUserPropertyValues (string username)

get user's extension property value from azure ad

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetExtensionAzureAdUserPropertyValuesExample
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

            var apiInstance = new UsersApi(config);

            var username = username_example;  // string | 

            try
            {
                // get user's extension property value from azure ad
                List<StringModel> result = apiInstance.GetExtensionAzureAdUserPropertyValues(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetExtensionAzureAdUserPropertyValues: " + e.Message );
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
 **username** | **string**|  | 

### Return type

[**List&lt;StringModel&gt;**](StringModel.md)

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

<a name="ismemberofgroup"></a>
# **IsMemberOfGroup**
> bool IsMemberOfGroup (string userprincipalname, string groupid)

Is Member Of Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class IsMemberOfGroupExample
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

            var apiInstance = new UsersApi(config);

            var userprincipalname = userprincipalname_example;  // string | 
            var groupid = groupid_example;  // string | 

            try
            {
                // Is Member Of Group
                bool result = apiInstance.IsMemberOfGroup(userprincipalname, groupid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.IsMemberOfGroup: " + e.Message );
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
 **userprincipalname** | **string**|  | 
 **groupid** | **string**|  | 

### Return type

**bool**

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

<a name="resolveusers"></a>
# **ResolveUsers**
> List&lt;ApiUser&gt; ResolveUsers (string keyword, ApiUserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = null, Guid? peopleFilterProfileId = null)

resolve users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class ResolveUsersExample
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

            var apiInstance = new UsersApi(config);

            var keyword = keyword_example;  // string | 
            var userType = ;  // ApiUserType | 
            var userSource = ;  // UserSource | 
            var sharingOptions = ;  // ExternalSharingOptions | 
            var siteUrlOrTenantId = siteUrlOrTenantId_example;  // string |  (optional)  (default to "")
            var peopleFilterProfileId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // resolve users
                List<ApiUser> result = apiInstance.ResolveUsers(keyword, userType, userSource, sharingOptions, siteUrlOrTenantId, peopleFilterProfileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResolveUsers: " + e.Message );
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
 **keyword** | **string**|  | 
 **userType** | **ApiUserType**|  | 
 **userSource** | **UserSource**|  | 
 **sharingOptions** | **ExternalSharingOptions**|  | 
 **siteUrlOrTenantId** | **string**|  | [optional] [default to &quot;&quot;]
 **peopleFilterProfileId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**List&lt;ApiUser&gt;**](ApiUser.md)

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

<a name="searchusers"></a>
# **SearchUsers**
> List&lt;ApiUser&gt; SearchUsers (string keyword, ApiUserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = null, Guid? peopleFilterProfileId = null)

search users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class SearchUsersExample
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

            var apiInstance = new UsersApi(config);

            var keyword = keyword_example;  // string | 
            var userType = ;  // ApiUserType | 
            var userSource = ;  // UserSource | 
            var sharingOptions = ;  // ExternalSharingOptions | 
            var siteUrlOrTenantId = siteUrlOrTenantId_example;  // string |  (optional)  (default to "")
            var peopleFilterProfileId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // search users
                List<ApiUser> result = apiInstance.SearchUsers(keyword, userType, userSource, sharingOptions, siteUrlOrTenantId, peopleFilterProfileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUsers: " + e.Message );
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
 **keyword** | **string**|  | 
 **userType** | **ApiUserType**|  | 
 **userSource** | **UserSource**|  | 
 **sharingOptions** | **ExternalSharingOptions**|  | 
 **siteUrlOrTenantId** | **string**|  | [optional] [default to &quot;&quot;]
 **peopleFilterProfileId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**List&lt;ApiUser&gt;**](ApiUser.md)

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

<a name="updateuserinfo"></a>
# **UpdateUserInfo**
> void UpdateUserInfo (UpdatableApiUser updatableApiUser = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class UpdateUserInfoExample
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

            var apiInstance = new UsersApi(config);

            var updatableApiUser = new UpdatableApiUser(); // UpdatableApiUser |  (optional) 

            try
            {
                apiInstance.UpdateUserInfo(updatableApiUser);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserInfo: " + e.Message );
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
 **updatableApiUser** | [**UpdatableApiUser**](UpdatableApiUser.md)|  | [optional] 

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

