

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
    public interface IServicesAdminApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// get all services
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ServiceGridModelPageResult</returns>
        ServiceGridModelPageResult GetServices(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string));

        /// <summary>
        /// get all services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ApiResponse of ServiceGridModelPageResult</returns>
        ApiResponse<ServiceGridModelPageResult> GetServicesWithHttpInfo(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicesAdminApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// get all services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceGridModelPageResult</returns>
        System.Threading.Tasks.Task<ServiceGridModelPageResult> GetServicesAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get all services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceGridModelPageResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceGridModelPageResult>> GetServicesWithHttpInfoAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicesAdminApi : IServicesAdminApiSync, IServicesAdminApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServicesAdminApi : IServicesAdminApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesAdminApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesAdminApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ServicesAdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServicesAdminApi(Cloud.Governance.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ServicesAdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ServicesAdminApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
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
        /// get all services 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ServiceGridModelPageResult</returns>
        public ServiceGridModelPageResult GetServices(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string))
        {
            Cloud.Governance.Client.Client.ApiResponse<ServiceGridModelPageResult> localVarResponse = GetServicesWithHttpInfo(filter, orderby, search, top, skip, nexttoken);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get all services 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ApiResponse of ServiceGridModelPageResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ServiceGridModelPageResult> GetServicesWithHttpInfo(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }
            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "skip", skip));
            }
            if (nexttoken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "nexttoken", nexttoken));
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
            var localVarResponse = this.Client.Get<ServiceGridModelPageResult>("/admin/services", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get all services 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceGridModelPageResult</returns>
        public async System.Threading.Tasks.Task<ServiceGridModelPageResult> GetServicesAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ServiceGridModelPageResult> localVarResponse = await GetServicesWithHttpInfoAsync(filter, orderby, search, top, skip, nexttoken, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get all services 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, description, name, serviceType, status, language, modifiedTime, createdByDisplayName, createdBy (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceGridModelPageResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ServiceGridModelPageResult>> GetServicesWithHttpInfoAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Cloud.Governance.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }
            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "skip", skip));
            }
            if (nexttoken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "nexttoken", nexttoken));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ServiceGridModelPageResult>("/admin/services", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
