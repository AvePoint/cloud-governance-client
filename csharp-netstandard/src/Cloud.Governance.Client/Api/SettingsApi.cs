

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
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// get group/teams dynamic membership rules
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetDynamicMembershipRuleItems(Guid tenantid);

        /// <summary>
        /// get group/teams dynamic membership rules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetDynamicMembershipRuleItemsWithHttpInfo(Guid tenantid);
        /// <summary>
        /// get my personal settings
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PersonalSettings</returns>
        PersonalSettings GetMyPersonalSettings();

        /// <summary>
        /// get my personal settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PersonalSettings</returns>
        ApiResponse<PersonalSettings> GetMyPersonalSettingsWithHttpInfo();
        /// <summary>
        /// get permission levels
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PermissionLevel&gt;</returns>
        List<PermissionLevel> GetPermissionLevels();

        /// <summary>
        /// get permission levels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PermissionLevel&gt;</returns>
        ApiResponse<List<PermissionLevel>> GetPermissionLevelsWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// get group/teams dynamic membership rules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetDynamicMembershipRuleItemsAsync(Guid tenantid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get group/teams dynamic membership rules
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetDynamicMembershipRuleItemsWithHttpInfoAsync(Guid tenantid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get my personal settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PersonalSettings</returns>
        System.Threading.Tasks.Task<PersonalSettings> GetMyPersonalSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get my personal settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PersonalSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<PersonalSettings>> GetMyPersonalSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get permission levels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PermissionLevel&gt;</returns>
        System.Threading.Tasks.Task<List<PermissionLevel>> GetPermissionLevelsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get permission levels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PermissionLevel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PermissionLevel>>> GetPermissionLevelsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi : ISettingsApiSync, ISettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SettingsApi : ISettingsApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsApi(Cloud.Governance.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SettingsApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
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
        /// get group/teams dynamic membership rules 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetDynamicMembershipRuleItems(Guid tenantid)
        {
            Cloud.Governance.Client.Client.ApiResponse<InlineResponse200> localVarResponse = GetDynamicMembershipRuleItemsWithHttpInfo(tenantid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get group/teams dynamic membership rules 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public Cloud.Governance.Client.Client.ApiResponse<InlineResponse200> GetDynamicMembershipRuleItemsWithHttpInfo(Guid tenantid)
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

            localVarRequestOptions.PathParameters.Add("tenantid", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(tenantid)); // path parameter

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
            var localVarResponse = this.Client.Get<InlineResponse200>("/settings/office365/groups/dynamicmembershiprule/{tenantid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDynamicMembershipRuleItems", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get group/teams dynamic membership rules 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetDynamicMembershipRuleItemsAsync(Guid tenantid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<InlineResponse200> localVarResponse = await GetDynamicMembershipRuleItemsWithHttpInfoAsync(tenantid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get group/teams dynamic membership rules 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantid"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<InlineResponse200>> GetDynamicMembershipRuleItemsWithHttpInfoAsync(Guid tenantid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("tenantid", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(tenantid)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<InlineResponse200>("/settings/office365/groups/dynamicmembershiprule/{tenantid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDynamicMembershipRuleItems", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get my personal settings 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PersonalSettings</returns>
        public PersonalSettings GetMyPersonalSettings()
        {
            Cloud.Governance.Client.Client.ApiResponse<PersonalSettings> localVarResponse = GetMyPersonalSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// get my personal settings 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PersonalSettings</returns>
        public Cloud.Governance.Client.Client.ApiResponse<PersonalSettings> GetMyPersonalSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<PersonalSettings>("/settings/my", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMyPersonalSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get my personal settings 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PersonalSettings</returns>
        public async System.Threading.Tasks.Task<PersonalSettings> GetMyPersonalSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<PersonalSettings> localVarResponse = await GetMyPersonalSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get my personal settings 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PersonalSettings)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<PersonalSettings>> GetMyPersonalSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<PersonalSettings>("/settings/my", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMyPersonalSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get permission levels 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PermissionLevel&gt;</returns>
        public List<PermissionLevel> GetPermissionLevels()
        {
            Cloud.Governance.Client.Client.ApiResponse<List<PermissionLevel>> localVarResponse = GetPermissionLevelsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// get permission levels 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PermissionLevel&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<PermissionLevel>> GetPermissionLevelsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<PermissionLevel>>("/settings/office365/permissionlevels", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPermissionLevels", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get permission levels 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PermissionLevel&gt;</returns>
        public async System.Threading.Tasks.Task<List<PermissionLevel>> GetPermissionLevelsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<PermissionLevel>> localVarResponse = await GetPermissionLevelsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get permission levels 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PermissionLevel&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<PermissionLevel>>> GetPermissionLevelsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PermissionLevel>>("/settings/office365/permissionlevels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPermissionLevels", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
