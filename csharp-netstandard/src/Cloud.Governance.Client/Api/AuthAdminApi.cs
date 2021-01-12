

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
    public interface IAuthAdminApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// delete token cache
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <returns></returns>
        void DeleteTokenCache(ApiCredential apiCredential);

        /// <summary>
        /// delete token cache
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTokenCacheWithHttpInfo(ApiCredential apiCredential);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthAdminApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// delete token cache
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteTokenCacheAsync(ApiCredential apiCredential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// delete token cache
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTokenCacheWithHttpInfoAsync(ApiCredential apiCredential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthAdminApi : IAuthAdminApiSync, IAuthAdminApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthAdminApi : IAuthAdminApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthAdminApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthAdminApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AuthAdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthAdminApi(Cloud.Governance.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthAdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthAdminApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
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
        /// delete token cache 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <returns></returns>
        public void DeleteTokenCache(ApiCredential apiCredential)
        {
            DeleteTokenCacheWithHttpInfo(apiCredential);
        }

        /// <summary>
        /// delete token cache 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> DeleteTokenCacheWithHttpInfo(ApiCredential apiCredential)
        {
            // verify the required parameter 'apiCredential' is set
            if (apiCredential == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'apiCredential' when calling AuthAdminApi->DeleteTokenCache");

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

            localVarRequestOptions.Data = apiCredential;

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
            var localVarResponse = this.Client.Delete<Object>("/admin/auth/token/cache", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteTokenCache", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete token cache 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteTokenCacheAsync(ApiCredential apiCredential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteTokenCacheWithHttpInfoAsync(apiCredential, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// delete token cache 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiCredential"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> DeleteTokenCacheWithHttpInfoAsync(ApiCredential apiCredential, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'apiCredential' is set
            if (apiCredential == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'apiCredential' when calling AuthAdminApi->DeleteTokenCache");


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

            localVarRequestOptions.Data = apiCredential;

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/admin/auth/token/cache", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteTokenCache", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
