# Cloud.Governance.Client.Api.Office365Api

All URIs are relative to *https://API_BASE_URL*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGroupInfo**](Office365Api.md#getgroupinfo) | **GET** /office365/groups/{tenantid}/{id} | get group information
[**GetGroupMembers**](Office365Api.md#getgroupmembers) | **GET** /office365/groups/{email}/members | get group members by group email
[**GetGroupMembersByGroupName**](Office365Api.md#getgroupmembersbygroupname) | **GET** /office365/groups/members | get group members by group name
[**GetGroupOwners**](Office365Api.md#getgroupowners) | **GET** /office365/groups/{email}/owners | get group owners by group email
[**GetHubSites**](Office365Api.md#gethubsites) | **GET** /office365/hubsites/{tenantid} | get all hubsites from a specific tenant
[**GetHubSitesFromTenantOfSite**](Office365Api.md#gethubsitesfromtenantofsite) | **GET** /office365/hubsites | get all hubsites from site&#39;s tenant
[**GetOwnedTeams**](Office365Api.md#getownedteams) | **GET** /office365/teams/my | get all teams that owner is curernt user
[**GetPermissions**](Office365Api.md#getpermissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
[**GetRoleAssignment**](Office365Api.md#getroleassignment) | **GET** /office365/roleassignment | get site permimssion role assignment
[**GetSiteDesigns**](Office365Api.md#getsitedesigns) | **GET** /office365/sitedesigns | get site designs by site url
[**GetSiteInfo**](Office365Api.md#getsiteinfo) | **GET** /office365/sites | get site collection information with url
[**GetSitePermissionLevels**](Office365Api.md#getsitepermissionlevels) | **GET** /office365/sites/permissionlevels | get site permission levels
[**GetSiteSharePointGroups**](Office365Api.md#getsitesharepointgroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
[**GetSiteTemplates**](Office365Api.md#getsitetemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
[**GetYammerGroup**](Office365Api.md#getyammergroup) | **GET** /office365/yammergroup/{networkid}/{name} | get yammer group
[**LoadContainers**](Office365Api.md#loadcontainers) | **GET** /office365/containers/{serviceid} | load the containers from cloud management
[**LoadFolders**](Office365Api.md#loadfolders) | **GET** /office365/folders/{listid} | load sharepoint folders
[**LoadItems**](Office365Api.md#loaditems) | **GET** /office365/items/{listid} | load sharepoint items
[**LoadLists**](Office365Api.md#loadlists) | **GET** /office365/lists | load sharepoint lists
[**LoadManagedMetadata**](Office365Api.md#loadmanagedmetadata) | **GET** /office365/managedmetadata/{termStoreid}/{groupid}/{termsetid}/{parentid} | load managed metadata terms
[**LoadManagedSites**](Office365Api.md#loadmanagedsites) | **GET** /office365/managedsites/{serviceid}/{containerid}/{isselected} | load sharepoint sites
[**LoadWebs**](Office365Api.md#loadwebs) | **GET** /office365/webs/{serviceid}/{siteorwebid}/{isselected}/{issite} | load sharepoint webs


<a name="getgroupinfo"></a>
# **GetGroupInfo**
> AzureADGroup GetGroupInfo (string tenantid, string id)

get group information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var tenantid = tenantid_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                // get group information
                AzureADGroup result = apiInstance.GetGroupInfo(tenantid, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetGroupInfo: " + e.Message );
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
 **tenantid** | **string**|  | 
 **id** | **string**|  | 

### Return type

[**AzureADGroup**](AzureADGroup.md)

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

<a name="getgroupmembers"></a>
# **GetGroupMembers**
> ApiUserPageResult GetGroupMembers (string email, int? top = null, int? skip = null, string search = null)

get group members by group email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var email = email_example;  // string | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // get group members by group email
                ApiUserPageResult result = apiInstance.GetGroupMembers(email, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetGroupMembers: " + e.Message );
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
 **email** | **string**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

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

<a name="getgroupmembersbygroupname"></a>
# **GetGroupMembersByGroupName**
> ApiUserPageResult GetGroupMembersByGroupName (string url, string name = null, int? top = null, int? skip = null, string search = null)

get group members by group name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupMembersByGroupNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var url = url_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // get group members by group name
                ApiUserPageResult result = apiInstance.GetGroupMembersByGroupName(url, name, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetGroupMembersByGroupName: " + e.Message );
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
 **url** | **string**|  | 
 **name** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

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

<a name="getgroupowners"></a>
# **GetGroupOwners**
> ApiUserPageResult GetGroupOwners (string email, int? top = null, int? skip = null, string search = null)

get group owners by group email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetGroupOwnersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var email = email_example;  // string | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // get group owners by group email
                ApiUserPageResult result = apiInstance.GetGroupOwners(email, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetGroupOwners: " + e.Message );
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
 **email** | **string**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**ApiUserPageResult**](ApiUserPageResult.md)

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

<a name="gethubsites"></a>
# **GetHubSites**
> List&lt;GuidModel&gt; GetHubSites (Guid tenantid)

get all hubsites from a specific tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetHubSitesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var tenantid = new Guid(); // Guid | 

            try
            {
                // get all hubsites from a specific tenant
                List<GuidModel> result = apiInstance.GetHubSites(tenantid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetHubSites: " + e.Message );
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
 **tenantid** | [**Guid**](Guid.md)|  | 

### Return type

[**List&lt;GuidModel&gt;**](GuidModel.md)

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

<a name="gethubsitesfromtenantofsite"></a>
# **GetHubSitesFromTenantOfSite**
> List&lt;GuidModel&gt; GetHubSitesFromTenantOfSite (string siteUrl = null)

get all hubsites from site's tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetHubSitesFromTenantOfSiteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var siteUrl = siteUrl_example;  // string | any site url in your tenant (optional) 

            try
            {
                // get all hubsites from site's tenant
                List<GuidModel> result = apiInstance.GetHubSitesFromTenantOfSite(siteUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetHubSitesFromTenantOfSite: " + e.Message );
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
 **siteUrl** | **string**| any site url in your tenant | [optional] 

### Return type

[**List&lt;GuidModel&gt;**](GuidModel.md)

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

<a name="getownedteams"></a>
# **GetOwnedTeams**
> List&lt;GuidModel&gt; GetOwnedTeams ()

get all teams that owner is curernt user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetOwnedTeamsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);

            try
            {
                // get all teams that owner is curernt user
                List<GuidModel> result = apiInstance.GetOwnedTeams();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetOwnedTeams: " + e.Message );
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

[**List&lt;GuidModel&gt;**](GuidModel.md)

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

<a name="getpermissions"></a>
# **GetPermissions**
> UserGroupPermissions GetPermissions (string webUrl)

get web permissions for creating list request by web url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetPermissionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var webUrl = webUrl_example;  // string | 

            try
            {
                // get web permissions for creating list request by web url
                UserGroupPermissions result = apiInstance.GetPermissions(webUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetPermissions: " + e.Message );
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
 **webUrl** | **string**|  | 

### Return type

[**UserGroupPermissions**](UserGroupPermissions.md)

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

<a name="getroleassignment"></a>
# **GetRoleAssignment**
> List&lt;SPRoleAssignment&gt; GetRoleAssignment (string url, NodeType type)

get site permimssion role assignment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetRoleAssignmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var url = url_example;  // string | 
            var type = new NodeType(); // NodeType | 

            try
            {
                // get site permimssion role assignment
                List<SPRoleAssignment> result = apiInstance.GetRoleAssignment(url, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetRoleAssignment: " + e.Message );
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
 **url** | **string**|  | 
 **type** | [**NodeType**](NodeType.md)|  | 

### Return type

[**List&lt;SPRoleAssignment&gt;**](SPRoleAssignment.md)

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

<a name="getsitedesigns"></a>
# **GetSiteDesigns**
> List&lt;StringModel&gt; GetSiteDesigns (string siteUrl = null)

get site designs by site url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteDesignsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var siteUrl = siteUrl_example;  // string |  (optional) 

            try
            {
                // get site designs by site url
                List<StringModel> result = apiInstance.GetSiteDesigns(siteUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetSiteDesigns: " + e.Message );
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
 **siteUrl** | **string**|  | [optional] 

### Return type

[**List&lt;StringModel&gt;**](StringModel.md)

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

<a name="getsiteinfo"></a>
# **GetSiteInfo**
> SiteInfo GetSiteInfo (string fullUrl)

get site collection information with url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var fullUrl = fullUrl_example;  // string | 

            try
            {
                // get site collection information with url
                SiteInfo result = apiInstance.GetSiteInfo(fullUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetSiteInfo: " + e.Message );
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
 **fullUrl** | **string**|  | 

### Return type

[**SiteInfo**](SiteInfo.md)

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

<a name="getsitepermissionlevels"></a>
# **GetSitePermissionLevels**
> List&lt;PermissionLevel&gt; GetSitePermissionLevels (string uri)

get site permission levels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSitePermissionLevelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var uri = uri_example;  // string | 

            try
            {
                // get site permission levels
                List<PermissionLevel> result = apiInstance.GetSitePermissionLevels(uri);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetSitePermissionLevels: " + e.Message );
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

[**List&lt;PermissionLevel&gt;**](PermissionLevel.md)

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

<a name="getsitesharepointgroups"></a>
# **GetSiteSharePointGroups**
> List&lt;SPGroup&gt; GetSiteSharePointGroups (string uri)

get site sharePoint groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteSharePointGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var uri = uri_example;  // string | 

            try
            {
                // get site sharePoint groups
                List<SPGroup> result = apiInstance.GetSiteSharePointGroups(uri);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetSiteSharePointGroups: " + e.Message );
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

[**List&lt;SPGroup&gt;**](SPGroup.md)

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

<a name="getsitetemplates"></a>
# **GetSiteTemplates**
> List&lt;SiteTemplate&gt; GetSiteTemplates (int languageid, string url = null)

get site templates with language code identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetSiteTemplatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var languageid = 56;  // int | 
            var url = url_example;  // string |  (optional) 

            try
            {
                // get site templates with language code identifier
                List<SiteTemplate> result = apiInstance.GetSiteTemplates(languageid, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetSiteTemplates: " + e.Message );
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
 **languageid** | **int**|  | 
 **url** | **string**|  | [optional] 

### Return type

[**List&lt;SiteTemplate&gt;**](SiteTemplate.md)

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

<a name="getyammergroup"></a>
# **GetYammerGroup**
> YammerGroup GetYammerGroup (string networkid, string name)

get yammer group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetYammerGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var networkid = networkid_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                // get yammer group
                YammerGroup result = apiInstance.GetYammerGroup(networkid, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.GetYammerGroup: " + e.Message );
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
 **networkid** | **string**|  | 
 **name** | **string**|  | 

### Return type

[**YammerGroup**](YammerGroup.md)

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

<a name="loadcontainers"></a>
# **LoadContainers**
> SPNodePageResult LoadContainers (string serviceid, int? top = null, int? skip = null, string search = null)

load the containers from cloud management

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadContainersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var serviceid = serviceid_example;  // string | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load the containers from cloud management
                SPNodePageResult result = apiInstance.LoadContainers(serviceid, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadContainers: " + e.Message );
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
 **serviceid** | **string**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

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

<a name="loadfolders"></a>
# **LoadFolders**
> SPNodePageResult LoadFolders (Guid listid, string folderorlisturl, int? top = null, int? skip = null, string search = null)

load sharepoint folders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadFoldersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var listid = new Guid(); // Guid | 
            var folderorlisturl = folderorlisturl_example;  // string | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load sharepoint folders
                SPNodePageResult result = apiInstance.LoadFolders(listid, folderorlisturl, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadFolders: " + e.Message );
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
 **listid** | [**Guid**](Guid.md)|  | 
 **folderorlisturl** | **string**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

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

<a name="loaditems"></a>
# **LoadItems**
> SPNodePageResult LoadItems (Guid listid, string folderorlisturl, int? top = null, int? skip = null, string search = null)

load sharepoint items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var listid = new Guid(); // Guid | 
            var folderorlisturl = folderorlisturl_example;  // string | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load sharepoint items
                SPNodePageResult result = apiInstance.LoadItems(listid, folderorlisturl, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadItems: " + e.Message );
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
 **listid** | [**Guid**](Guid.md)|  | 
 **folderorlisturl** | **string**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

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

<a name="loadlists"></a>
# **LoadLists**
> SPNodePageResult LoadLists (string siteorweburl, int? top = null, int? skip = null, string search = null)

load sharepoint lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadListsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var siteorweburl = siteorweburl_example;  // string | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load sharepoint lists
                SPNodePageResult result = apiInstance.LoadLists(siteorweburl, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadLists: " + e.Message );
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
 **siteorweburl** | **string**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

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

<a name="loadmanagedmetadata"></a>
# **LoadManagedMetadata**
> ApiTermInfoPageResult LoadManagedMetadata (Guid termStoreid, Guid groupid, Guid termsetid, Guid parentid, string admincenterurl, int? skip = null, int? top = null, string search = null)

load managed metadata terms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadManagedMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var termStoreid = new Guid(); // Guid | 
            var groupid = new Guid(); // Guid | 
            var termsetid = new Guid(); // Guid | 
            var parentid = new Guid(); // Guid | 
            var admincenterurl = admincenterurl_example;  // string | 
            var skip = 56;  // int? |  (optional) 
            var top = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load managed metadata terms
                ApiTermInfoPageResult result = apiInstance.LoadManagedMetadata(termStoreid, groupid, termsetid, parentid, admincenterurl, skip, top, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadManagedMetadata: " + e.Message );
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
 **termStoreid** | [**Guid**](Guid.md)|  | 
 **groupid** | [**Guid**](Guid.md)|  | 
 **termsetid** | [**Guid**](Guid.md)|  | 
 **parentid** | [**Guid**](Guid.md)|  | 
 **admincenterurl** | **string**|  | 
 **skip** | **int?**|  | [optional] 
 **top** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**ApiTermInfoPageResult**](ApiTermInfoPageResult.md)

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

<a name="loadmanagedsites"></a>
# **LoadManagedSites**
> SPNodePageResult LoadManagedSites (string serviceid, Guid containerid, bool isselected, int? top = null, int? skip = null, string search = null)

load sharepoint sites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadManagedSitesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var serviceid = serviceid_example;  // string | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
            var containerid = new Guid(); // Guid | 
            var isselected = true;  // bool | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load sharepoint sites
                SPNodePageResult result = apiInstance.LoadManagedSites(serviceid, containerid, isselected, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadManagedSites: " + e.Message );
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
 **serviceid** | **string**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **containerid** | [**Guid**](Guid.md)|  | 
 **isselected** | **bool**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

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

<a name="loadwebs"></a>
# **LoadWebs**
> SPNodePageResult LoadWebs (string serviceid, Guid siteorwebid, bool isselected, bool issite, string siteOrWebUrl, int? top = null, int? skip = null, string search = null)

load sharepoint webs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class LoadWebsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new Office365Api(Configuration.Default);
            var serviceid = serviceid_example;  // string | If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree
            var siteorwebid = new Guid(); // Guid | 
            var isselected = true;  // bool | 
            var issite = true;  // bool | 
            var siteOrWebUrl = siteOrWebUrl_example;  // string | 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                // load sharepoint webs
                SPNodePageResult result = apiInstance.LoadWebs(serviceid, siteorwebid, isselected, issite, siteOrWebUrl, top, skip, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Office365Api.LoadWebs: " + e.Message );
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
 **serviceid** | **string**| If the service is content manager, you need use Serviceid_Source or Serviceid_Destination to load the source or destination tree | 
 **siteorwebid** | [**Guid**](Guid.md)|  | 
 **isselected** | **bool**|  | 
 **issite** | **bool**|  | 
 **siteOrWebUrl** | **string**|  | 
 **top** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**SPNodePageResult**](SPNodePageResult.md)

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

