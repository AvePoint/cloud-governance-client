

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
    public interface IOffice365AdminApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// get azure ad custom property names
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetAzureAdCustomPropertyNames(Guid tenantId, bool? isSearchUserProperty = default(bool?));

        /// <summary>
        /// get azure ad custom property names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetAzureAdCustomPropertyNamesWithHttpInfo(Guid tenantId, bool? isSearchUserProperty = default(bool?));
        /// <summary>
        /// get tenant ids by url
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <returns></returns>
        void GetTenantIdByUrl(string uri);

        /// <summary>
        /// get tenant ids by url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetTenantIdByUrlWithHttpInfo(string uri);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOffice365AdminApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// get azure ad custom property names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetAzureAdCustomPropertyNamesAsync(Guid tenantId, bool? isSearchUserProperty = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get azure ad custom property names
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetAzureAdCustomPropertyNamesWithHttpInfoAsync(Guid tenantId, bool? isSearchUserProperty = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get tenant ids by url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetTenantIdByUrlAsync(string uri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get tenant ids by url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetTenantIdByUrlWithHttpInfoAsync(string uri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOffice365AdminApi : IOffice365AdminApiSync, IOffice365AdminApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Office365AdminApi : IOffice365AdminApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Office365AdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Office365AdminApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Office365AdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Office365AdminApi(String basePath)
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
        /// Initializes a new instance of the <see cref="Office365AdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public Office365AdminApi(Cloud.Governance.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="Office365AdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public Office365AdminApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
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
        /// get azure ad custom property names 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetAzureAdCustomPropertyNames(Guid tenantId, bool? isSearchUserProperty = default(bool?))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<string>> localVarResponse = GetAzureAdCustomPropertyNamesWithHttpInfo(tenantId, isSearchUserProperty);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get azure ad custom property names 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<string>> GetAzureAdCustomPropertyNamesWithHttpInfo(Guid tenantId, bool? isSearchUserProperty = default(bool?))
        {
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

            localVarRequestOptions.PathParameters.Add("tenantId", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            if (isSearchUserProperty != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "isSearchUserProperty", isSearchUserProperty));
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
            var localVarResponse = this.Client.Get<List<string>>("/admin/office365/azuread/{tenantId}/property/names/custom", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAzureAdCustomPropertyNames", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get azure ad custom property names 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetAzureAdCustomPropertyNamesAsync(Guid tenantId, bool? isSearchUserProperty = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<string>> localVarResponse = await GetAzureAdCustomPropertyNamesWithHttpInfoAsync(tenantId, isSearchUserProperty, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get azure ad custom property names 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="isSearchUserProperty"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<string>>> GetAzureAdCustomPropertyNamesWithHttpInfoAsync(Guid tenantId, bool? isSearchUserProperty = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("tenantId", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            if (isSearchUserProperty != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "isSearchUserProperty", isSearchUserProperty));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<string>>("/admin/office365/azuread/{tenantId}/property/names/custom", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAzureAdCustomPropertyNames", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get tenant ids by url 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <returns></returns>
        public void GetTenantIdByUrl(string uri)
        {
            GetTenantIdByUrlWithHttpInfo(uri);
        }

        /// <summary>
        /// get tenant ids by url 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> GetTenantIdByUrlWithHttpInfo(string uri)
        {
            // verify the required parameter 'uri' is set
            if (uri == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'uri' when calling Office365AdminApi->GetTenantIdByUrl");

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "uri", uri));

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
            var localVarResponse = this.Client.Get<Object>("/admin/office365/tenantid", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTenantIdByUrl", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get tenant ids by url 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetTenantIdByUrlAsync(string uri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await GetTenantIdByUrlWithHttpInfoAsync(uri, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// get tenant ids by url 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uri"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> GetTenantIdByUrlWithHttpInfoAsync(string uri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'uri' is set
            if (uri == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'uri' when calling Office365AdminApi->GetTenantIdByUrl");


            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "uri", uri));

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/admin/office365/tenantid", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTenantIdByUrl", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
