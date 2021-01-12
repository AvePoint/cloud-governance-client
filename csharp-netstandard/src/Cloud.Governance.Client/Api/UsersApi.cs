

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Cloud.Governance.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// filter users by property value
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <returns>List&lt;ApiUser&gt;</returns>
        List<ApiUser> FilterUsersByAttribute(string attributeName, string attributeValue, string office365TenantId = default(string));

        /// <summary>
        /// filter users by property value
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <returns>ApiResponse of List&lt;ApiUser&gt;</returns>
        ApiResponse<List<ApiUser>> FilterUsersByAttributeWithHttpInfo(string attributeName, string attributeValue, string office365TenantId = default(string));
        /// <summary>
        /// get Azure Ad user&#39;s property value
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <returns>StringModel</returns>
        StringModel GetAzureAdUserPropertyValue(string username, string propertyName);

        /// <summary>
        /// get Azure Ad user&#39;s property value
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <returns>ApiResponse of StringModel</returns>
        ApiResponse<StringModel> GetAzureAdUserPropertyValueWithHttpInfo(string username, string propertyName);
        /// <summary>
        /// get user&#39;s extension property value from azure ad
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>List&lt;StringModel&gt;</returns>
        List<StringModel> GetExtensionAzureAdUserPropertyValues(string username);

        /// <summary>
        /// get user&#39;s extension property value from azure ad
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>ApiResponse of List&lt;StringModel&gt;</returns>
        ApiResponse<List<StringModel>> GetExtensionAzureAdUserPropertyValuesWithHttpInfo(string username);
        /// <summary>
        /// Is Member Of Group
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <returns>bool</returns>
        bool IsMemberOfGroup(string userprincipalname, string groupid);

        /// <summary>
        /// Is Member Of Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> IsMemberOfGroupWithHttpInfo(string userprincipalname, string groupid);
        /// <summary>
        /// resolve users
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>List&lt;ApiUser&gt;</returns>
        List<ApiUser> ResolveUsers(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?));

        /// <summary>
        /// resolve users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ApiUser&gt;</returns>
        ApiResponse<List<ApiUser>> ResolveUsersWithHttpInfo(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?));
        /// <summary>
        /// search users
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>List&lt;ApiUser&gt;</returns>
        List<ApiUser> SearchUsers(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?));

        /// <summary>
        /// search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ApiUser&gt;</returns>
        ApiResponse<List<ApiUser>> SearchUsersWithHttpInfo(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?));
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <returns></returns>
        void UpdateUserInfo(UpdatableApiUser updatableApiUser = default(UpdatableApiUser));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateUserInfoWithHttpInfo(UpdatableApiUser updatableApiUser = default(UpdatableApiUser));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// filter users by property value
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ApiUser&gt;</returns>
        System.Threading.Tasks.Task<List<ApiUser>> FilterUsersByAttributeAsync(string attributeName, string attributeValue, string office365TenantId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// filter users by property value
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ApiUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ApiUser>>> FilterUsersByAttributeWithHttpInfoAsync(string attributeName, string attributeValue, string office365TenantId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get Azure Ad user&#39;s property value
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringModel</returns>
        System.Threading.Tasks.Task<StringModel> GetAzureAdUserPropertyValueAsync(string username, string propertyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get Azure Ad user&#39;s property value
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringModel>> GetAzureAdUserPropertyValueWithHttpInfoAsync(string username, string propertyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get user&#39;s extension property value from azure ad
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;StringModel&gt;</returns>
        System.Threading.Tasks.Task<List<StringModel>> GetExtensionAzureAdUserPropertyValuesAsync(string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get user&#39;s extension property value from azure ad
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;StringModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StringModel>>> GetExtensionAzureAdUserPropertyValuesWithHttpInfoAsync(string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Is Member Of Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of bool</returns>
        System.Threading.Tasks.Task<bool> IsMemberOfGroupAsync(string userprincipalname, string groupid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Is Member Of Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool>> IsMemberOfGroupWithHttpInfoAsync(string userprincipalname, string groupid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// resolve users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ApiUser&gt;</returns>
        System.Threading.Tasks.Task<List<ApiUser>> ResolveUsersAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// resolve users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ApiUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ApiUser>>> ResolveUsersWithHttpInfoAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ApiUser&gt;</returns>
        System.Threading.Tasks.Task<List<ApiUser>> SearchUsersAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// search users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ApiUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ApiUser>>> SearchUsersWithHttpInfoAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateUserInfoAsync(UpdatableApiUser updatableApiUser = default(UpdatableApiUser), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateUserInfoWithHttpInfoAsync(UpdatableApiUser updatableApiUser = default(UpdatableApiUser), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IUsersApiSync, IUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = Cloud.Governance.Client.Client.Configuration.MergeConfigurations(
                Cloud.Governance.Client.Client.GlobalConfiguration.Instance,
                new Cloud.Governance.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Cloud.Governance.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Cloud.Governance.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Cloud.Governance.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Cloud.Governance.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Cloud.Governance.Client.Client.Configuration.MergeConfigurations(
                Cloud.Governance.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Cloud.Governance.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Cloud.Governance.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Cloud.Governance.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UsersApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Cloud.Governance.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Cloud.Governance.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Cloud.Governance.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloud.Governance.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloud.Governance.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// filter users by property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <returns>List&lt;ApiUser&gt;</returns>
        public List<ApiUser> FilterUsersByAttribute(string attributeName, string attributeValue, string office365TenantId = default(string))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> localVarResponse = FilterUsersByAttributeWithHttpInfo(attributeName, attributeValue, office365TenantId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// filter users by property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <returns>ApiResponse of List&lt;ApiUser&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> FilterUsersByAttributeWithHttpInfo(string attributeName, string attributeValue, string office365TenantId = default(string))
        {
            // verify the required parameter 'attributeName' is set
            if (attributeName == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'attributeName' when calling UsersApi->FilterUsersByAttribute");

            // verify the required parameter 'attributeValue' is set
            if (attributeValue == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'attributeValue' when calling UsersApi->FilterUsersByAttribute");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "attributeName", attributeName));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "attributeValue", attributeValue));
            if (office365TenantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "office365TenantId", office365TenantId));
            }

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ApiUser>>("/users/filter", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FilterUsersByAttribute", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// filter users by property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ApiUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<ApiUser>> FilterUsersByAttributeAsync(string attributeName, string attributeValue, string office365TenantId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> localVarResponse = await FilterUsersByAttributeWithHttpInfoAsync(attributeName, attributeValue, office365TenantId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// filter users by property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeName">azure ad attribute name</param>
        /// <param name="attributeValue">value of attribute name</param>
        /// <param name="office365TenantId">office 365 tenant id, optional, if not specified, only return the first tenant&#39;s result which is not empty (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ApiUser&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>>> FilterUsersByAttributeWithHttpInfoAsync(string attributeName, string attributeValue, string office365TenantId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'attributeName' is set
            if (attributeName == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'attributeName' when calling UsersApi->FilterUsersByAttribute");

            // verify the required parameter 'attributeValue' is set
            if (attributeValue == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'attributeValue' when calling UsersApi->FilterUsersByAttribute");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "attributeName", attributeName));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "attributeValue", attributeValue));
            if (office365TenantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "office365TenantId", office365TenantId));
            }

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ApiUser>>("/users/filter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FilterUsersByAttribute", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get Azure Ad user&#39;s property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <returns>StringModel</returns>
        public StringModel GetAzureAdUserPropertyValue(string username, string propertyName)
        {
            Cloud.Governance.Client.Client.ApiResponse<StringModel> localVarResponse = GetAzureAdUserPropertyValueWithHttpInfo(username, propertyName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get Azure Ad user&#39;s property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <returns>ApiResponse of StringModel</returns>
        public Cloud.Governance.Client.Client.ApiResponse<StringModel> GetAzureAdUserPropertyValueWithHttpInfo(string username, string propertyName)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'username' when calling UsersApi->GetAzureAdUserPropertyValue");

            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'propertyName' when calling UsersApi->GetAzureAdUserPropertyValue");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("username", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(username)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "propertyName", propertyName));

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<StringModel>("/users/{username}/azuread/property", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAzureAdUserPropertyValue", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get Azure Ad user&#39;s property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringModel</returns>
        public async System.Threading.Tasks.Task<StringModel> GetAzureAdUserPropertyValueAsync(string username, string propertyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<StringModel> localVarResponse = await GetAzureAdUserPropertyValueWithHttpInfoAsync(username, propertyName, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get Azure Ad user&#39;s property value 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="propertyName"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringModel)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<StringModel>> GetAzureAdUserPropertyValueWithHttpInfoAsync(string username, string propertyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'username' when calling UsersApi->GetAzureAdUserPropertyValue");

            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'propertyName' when calling UsersApi->GetAzureAdUserPropertyValue");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("username", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(username)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "propertyName", propertyName));

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringModel>("/users/{username}/azuread/property", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAzureAdUserPropertyValue", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get user&#39;s extension property value from azure ad 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>List&lt;StringModel&gt;</returns>
        public List<StringModel> GetExtensionAzureAdUserPropertyValues(string username)
        {
            Cloud.Governance.Client.Client.ApiResponse<List<StringModel>> localVarResponse = GetExtensionAzureAdUserPropertyValuesWithHttpInfo(username);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get user&#39;s extension property value from azure ad 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>ApiResponse of List&lt;StringModel&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<StringModel>> GetExtensionAzureAdUserPropertyValuesWithHttpInfo(string username)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'username' when calling UsersApi->GetExtensionAzureAdUserPropertyValues");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("username", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(username)); // path parameter

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<StringModel>>("/users/{username}/azuread/extensionproperties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExtensionAzureAdUserPropertyValues", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get user&#39;s extension property value from azure ad 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;StringModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<StringModel>> GetExtensionAzureAdUserPropertyValuesAsync(string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<StringModel>> localVarResponse = await GetExtensionAzureAdUserPropertyValuesWithHttpInfoAsync(username, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get user&#39;s extension property value from azure ad 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;StringModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<StringModel>>> GetExtensionAzureAdUserPropertyValuesWithHttpInfoAsync(string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'username' when calling UsersApi->GetExtensionAzureAdUserPropertyValues");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("username", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(username)); // path parameter

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<StringModel>>("/users/{username}/azuread/extensionproperties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExtensionAzureAdUserPropertyValues", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is Member Of Group 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <returns>bool</returns>
        public bool IsMemberOfGroup(string userprincipalname, string groupid)
        {
            Cloud.Governance.Client.Client.ApiResponse<bool> localVarResponse = IsMemberOfGroupWithHttpInfo(userprincipalname, groupid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is Member Of Group 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <returns>ApiResponse of bool</returns>
        public Cloud.Governance.Client.Client.ApiResponse<bool> IsMemberOfGroupWithHttpInfo(string userprincipalname, string groupid)
        {
            // verify the required parameter 'userprincipalname' is set
            if (userprincipalname == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'userprincipalname' when calling UsersApi->IsMemberOfGroup");

            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'groupid' when calling UsersApi->IsMemberOfGroup");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userprincipalname", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(userprincipalname)); // path parameter
            localVarRequestOptions.PathParameters.Add("groupid", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(groupid)); // path parameter

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<bool>("/users/{userprincipalname}/ismemberof/{groupid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsMemberOfGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is Member Of Group 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of bool</returns>
        public async System.Threading.Tasks.Task<bool> IsMemberOfGroupAsync(string userprincipalname, string groupid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<bool> localVarResponse = await IsMemberOfGroupWithHttpInfoAsync(userprincipalname, groupid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is Member Of Group 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userprincipalname"></param>
        /// <param name="groupid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<bool>> IsMemberOfGroupWithHttpInfoAsync(string userprincipalname, string groupid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userprincipalname' is set
            if (userprincipalname == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'userprincipalname' when calling UsersApi->IsMemberOfGroup");

            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'groupid' when calling UsersApi->IsMemberOfGroup");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userprincipalname", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(userprincipalname)); // path parameter
            localVarRequestOptions.PathParameters.Add("groupid", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(groupid)); // path parameter

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<bool>("/users/{userprincipalname}/ismemberof/{groupid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsMemberOfGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// resolve users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>List&lt;ApiUser&gt;</returns>
        public List<ApiUser> ResolveUsers(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> localVarResponse = ResolveUsersWithHttpInfo(keyword, userType, userSource, sharingOptions, siteUrlOrTenantId, peopleFilterProfileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// resolve users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ApiUser&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> ResolveUsersWithHttpInfo(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?))
        {
            // verify the required parameter 'keyword' is set
            if (keyword == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'keyword' when calling UsersApi->ResolveUsers");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "keyword", keyword));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userType", userType));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userSource", userSource));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "sharingOptions", sharingOptions));
            if (siteUrlOrTenantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "siteUrlOrTenantId", siteUrlOrTenantId));
            }
            if (peopleFilterProfileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "peopleFilterProfileId", peopleFilterProfileId));
            }

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ApiUser>>("/users/resolve", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResolveUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// resolve users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ApiUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<ApiUser>> ResolveUsersAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> localVarResponse = await ResolveUsersWithHttpInfoAsync(keyword, userType, userSource, sharingOptions, siteUrlOrTenantId, peopleFilterProfileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// resolve users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ApiUser&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>>> ResolveUsersWithHttpInfoAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'keyword' is set
            if (keyword == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'keyword' when calling UsersApi->ResolveUsers");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "keyword", keyword));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userType", userType));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userSource", userSource));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "sharingOptions", sharingOptions));
            if (siteUrlOrTenantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "siteUrlOrTenantId", siteUrlOrTenantId));
            }
            if (peopleFilterProfileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "peopleFilterProfileId", peopleFilterProfileId));
            }

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ApiUser>>("/users/resolve", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResolveUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// search users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>List&lt;ApiUser&gt;</returns>
        public List<ApiUser> SearchUsers(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> localVarResponse = SearchUsersWithHttpInfo(keyword, userType, userSource, sharingOptions, siteUrlOrTenantId, peopleFilterProfileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// search users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ApiUser&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> SearchUsersWithHttpInfo(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?))
        {
            // verify the required parameter 'keyword' is set
            if (keyword == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'keyword' when calling UsersApi->SearchUsers");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "keyword", keyword));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userType", userType));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userSource", userSource));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "sharingOptions", sharingOptions));
            if (siteUrlOrTenantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "siteUrlOrTenantId", siteUrlOrTenantId));
            }
            if (peopleFilterProfileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "peopleFilterProfileId", peopleFilterProfileId));
            }

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ApiUser>>("/users/search", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// search users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ApiUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<ApiUser>> SearchUsersAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>> localVarResponse = await SearchUsersWithHttpInfoAsync(keyword, userType, userSource, sharingOptions, siteUrlOrTenantId, peopleFilterProfileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// search users 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyword"></param>
        /// <param name="userType"></param>
        /// <param name="userSource"></param>
        /// <param name="sharingOptions"></param>
        /// <param name="siteUrlOrTenantId"> (optional, default to &quot;&quot;)</param>
        /// <param name="peopleFilterProfileId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ApiUser&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<ApiUser>>> SearchUsersWithHttpInfoAsync(string keyword, UserType userType, UserSource userSource, ExternalSharingOptions sharingOptions, string siteUrlOrTenantId = default(string), Guid? peopleFilterProfileId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'keyword' is set
            if (keyword == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'keyword' when calling UsersApi->SearchUsers");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "keyword", keyword));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userType", userType));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "userSource", userSource));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "sharingOptions", sharingOptions));
            if (siteUrlOrTenantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "siteUrlOrTenantId", siteUrlOrTenantId));
            }
            if (peopleFilterProfileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "peopleFilterProfileId", peopleFilterProfileId));
            }

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ApiUser>>("/users/search", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <returns></returns>
        public void UpdateUserInfo(UpdatableApiUser updatableApiUser = default(UpdatableApiUser))
        {
            UpdateUserInfoWithHttpInfo(updatableApiUser);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> UpdateUserInfoWithHttpInfo(UpdatableApiUser updatableApiUser = default(UpdatableApiUser))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = updatableApiUser;

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/users", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateUserInfoAsync(UpdatableApiUser updatableApiUser = default(UpdatableApiUser), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await UpdateUserInfoWithHttpInfoAsync(updatableApiUser, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatableApiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> UpdateUserInfoWithHttpInfoAsync(UpdatableApiUser updatableApiUser = default(UpdatableApiUser), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = updatableApiUser;

            // authentication (clientSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("clientSecret")))
            {
                localVarRequestOptions.HeaderParameters.Add("clientSecret", this.Configuration.GetApiKeyWithPrefix("clientSecret"));
            }
            // authentication (userPrincipalName) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("userPrincipalName")))
            {
                localVarRequestOptions.HeaderParameters.Add("userPrincipalName", this.Configuration.GetApiKeyWithPrefix("userPrincipalName"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/users", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
