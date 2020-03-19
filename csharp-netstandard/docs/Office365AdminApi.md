# Cloud.Governance.Client.Api.Office365AdminApi

All URIs are relative to *Cloud_Governance_Modern_API_Endpoint*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAzureAdBuiltInPropertyNames**](Office365AdminApi.md#getazureadbuiltinpropertynames) | **GET** /admin/office365/azuread/property/names/builtin | get azure ad custom property names
[**GetAzureAdCustomPropertyNames**](Office365AdminApi.md#getazureadcustompropertynames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
[**GetUpsPropertyNames**](Office365AdminApi.md#getupspropertynames) | **GET** /admin/office365/userprofile/property/names | get user profile property names


<a name="getazureadbuiltinpropertynames"></a>
# **GetAzureAdBuiltInPropertyNames**
> List&lt;string&gt; GetAzureAdBuiltInPropertyNames ()

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
    public class GetAzureAdBuiltInPropertyNamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new Office365AdminApi(config);

            try
            {
                // get azure ad custom property names
                List<string> result = apiInstance.GetAzureAdBuiltInPropertyNames();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetAzureAdBuiltInPropertyNames: " + e.Message );
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

**List<string>**

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

<a name="getazureadcustompropertynames"></a>
# **GetAzureAdCustomPropertyNames**
> List&lt;string&gt; GetAzureAdCustomPropertyNames (Guid tenantId)

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
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new Office365AdminApi(config);
            var tenantId = new Guid(); // Guid | 

            try
            {
                // get azure ad custom property names
                List<string> result = apiInstance.GetAzureAdCustomPropertyNames(tenantId);
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

### Return type

**List<string>**

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

<a name="getupspropertynames"></a>
# **GetUpsPropertyNames**
> List&lt;string&gt; GetUpsPropertyNames (string adminCenterUrl)

get user profile property names

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetUpsPropertyNamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "Cloud_Governance_Modern_API_Endpoint";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            var apiInstance = new Office365AdminApi(config);
            var adminCenterUrl = adminCenterUrl_example;  // string | 

            try
            {
                // get user profile property names
                List<string> result = apiInstance.GetUpsPropertyNames(adminCenterUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365AdminApi.GetUpsPropertyNames: " + e.Message );
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
 **adminCenterUrl** | **string**|  | 

### Return type

**List<string>**

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

