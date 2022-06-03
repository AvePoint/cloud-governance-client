

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
        /// add user custom actions, if exists, will update the existing one.
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <returns></returns>
        void AddWebUserCustomAction(UserCustomAction userCustomAction);

        /// <summary>
        /// add user custom actions, if exists, will update the existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddWebUserCustomActionWithHttpInfo(UserCustomAction userCustomAction);
        /// <summary>
        /// delete user custom actions by action name
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        void DeleteWebUserCustomAction(string webFullUrl, string name);

        /// <summary>
        /// delete user custom actions by action name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWebUserCustomActionWithHttpInfo(string webFullUrl, string name);
        /// <summary>
        /// get azure ad custom property with data type
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <returns>List&lt;CustomExtensionPropertyModel&gt;</returns>
        List<CustomExtensionPropertyModel> GetAzureADExtensionPropertyNamesWithDataType(Guid tenantId);

        /// <summary>
        /// get azure ad custom property with data type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <returns>ApiResponse of List&lt;CustomExtensionPropertyModel&gt;</returns>
        ApiResponse<List<CustomExtensionPropertyModel>> GetAzureADExtensionPropertyNamesWithDataTypeWithHttpInfo(Guid tenantId);
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
        /// <summary>
        /// get tenant ids by filter expression
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns></returns>
        void GetTenantIds(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string));

        /// <summary>
        /// get tenant ids by filter expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetTenantIdsWithHttpInfo(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOffice365AdminApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// add user custom actions, if exists, will update the existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddWebUserCustomActionAsync(UserCustomAction userCustomAction, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// add user custom actions, if exists, will update the existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddWebUserCustomActionWithHttpInfoAsync(UserCustomAction userCustomAction, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// delete user custom actions by action name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWebUserCustomActionAsync(string webFullUrl, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// delete user custom actions by action name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebUserCustomActionWithHttpInfoAsync(string webFullUrl, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get azure ad custom property with data type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;CustomExtensionPropertyModel&gt;</returns>
        System.Threading.Tasks.Task<List<CustomExtensionPropertyModel>> GetAzureADExtensionPropertyNamesWithDataTypeAsync(Guid tenantId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get azure ad custom property with data type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;CustomExtensionPropertyModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CustomExtensionPropertyModel>>> GetAzureADExtensionPropertyNamesWithDataTypeWithHttpInfoAsync(Guid tenantId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
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
        /// <summary>
        /// get tenant ids by filter expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetTenantIdsAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get tenant ids by filter expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetTenantIdsWithHttpInfoAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
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
        /// add user custom actions, if exists, will update the existing one. 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <returns></returns>
        public void AddWebUserCustomAction(UserCustomAction userCustomAction)
        {
            AddWebUserCustomActionWithHttpInfo(userCustomAction);
        }

        /// <summary>
        /// add user custom actions, if exists, will update the existing one. 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> AddWebUserCustomActionWithHttpInfo(UserCustomAction userCustomAction)
        {
            // verify the required parameter 'userCustomAction' is set
            if (userCustomAction == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'userCustomAction' when calling Office365AdminApi->AddWebUserCustomAction");

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

            localVarRequestOptions.Data = userCustomAction;

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
            var localVarResponse = this.Client.Post<Object>("/admin/office365/web/usercustomactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddWebUserCustomAction", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// add user custom actions, if exists, will update the existing one. 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddWebUserCustomActionAsync(UserCustomAction userCustomAction, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AddWebUserCustomActionWithHttpInfoAsync(userCustomAction, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// add user custom actions, if exists, will update the existing one. 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCustomAction"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> AddWebUserCustomActionWithHttpInfoAsync(UserCustomAction userCustomAction, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userCustomAction' is set
            if (userCustomAction == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'userCustomAction' when calling Office365AdminApi->AddWebUserCustomAction");


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

            localVarRequestOptions.Data = userCustomAction;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/office365/web/usercustomactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddWebUserCustomAction", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete user custom actions by action name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public void DeleteWebUserCustomAction(string webFullUrl, string name)
        {
            DeleteWebUserCustomActionWithHttpInfo(webFullUrl, name);
        }

        /// <summary>
        /// delete user custom actions by action name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> DeleteWebUserCustomActionWithHttpInfo(string webFullUrl, string name)
        {
            // verify the required parameter 'webFullUrl' is set
            if (webFullUrl == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'webFullUrl' when calling Office365AdminApi->DeleteWebUserCustomAction");

            // verify the required parameter 'name' is set
            if (name == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'name' when calling Office365AdminApi->DeleteWebUserCustomAction");

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

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "webFullUrl", webFullUrl));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "name", name));

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
            var localVarResponse = this.Client.Delete<Object>("/admin/office365/web/usercustomactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteWebUserCustomAction", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete user custom actions by action name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWebUserCustomActionAsync(string webFullUrl, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteWebUserCustomActionWithHttpInfoAsync(webFullUrl, name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// delete user custom actions by action name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webFullUrl"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> DeleteWebUserCustomActionWithHttpInfoAsync(string webFullUrl, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'webFullUrl' is set
            if (webFullUrl == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'webFullUrl' when calling Office365AdminApi->DeleteWebUserCustomAction");

            // verify the required parameter 'name' is set
            if (name == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'name' when calling Office365AdminApi->DeleteWebUserCustomAction");


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

            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "webFullUrl", webFullUrl));
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "name", name));

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/admin/office365/web/usercustomactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteWebUserCustomAction", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get azure ad custom property with data type 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <returns>List&lt;CustomExtensionPropertyModel&gt;</returns>
        public List<CustomExtensionPropertyModel> GetAzureADExtensionPropertyNamesWithDataType(Guid tenantId)
        {
            Cloud.Governance.Client.Client.ApiResponse<List<CustomExtensionPropertyModel>> localVarResponse = GetAzureADExtensionPropertyNamesWithDataTypeWithHttpInfo(tenantId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get azure ad custom property with data type 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <returns>ApiResponse of List&lt;CustomExtensionPropertyModel&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<CustomExtensionPropertyModel>> GetAzureADExtensionPropertyNamesWithDataTypeWithHttpInfo(Guid tenantId)
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
            var localVarResponse = this.Client.Get<List<CustomExtensionPropertyModel>>("/admin/office365/azuread/{tenantId}/property/custom", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAzureADExtensionPropertyNamesWithDataType", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get azure ad custom property with data type 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;CustomExtensionPropertyModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<CustomExtensionPropertyModel>> GetAzureADExtensionPropertyNamesWithDataTypeAsync(Guid tenantId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<CustomExtensionPropertyModel>> localVarResponse = await GetAzureADExtensionPropertyNamesWithDataTypeWithHttpInfoAsync(tenantId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get azure ad custom property with data type 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;CustomExtensionPropertyModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<CustomExtensionPropertyModel>>> GetAzureADExtensionPropertyNamesWithDataTypeWithHttpInfoAsync(Guid tenantId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<CustomExtensionPropertyModel>>("/admin/office365/azuread/{tenantId}/property/custom", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAzureADExtensionPropertyNamesWithDataType", localVarResponse);
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

        /// <summary>
        /// get tenant ids by filter expression 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns></returns>
        public void GetTenantIds(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string))
        {
            GetTenantIdsWithHttpInfo(filter, orderby, search, top, skip, nexttoken);
        }

        /// <summary>
        /// get tenant ids by filter expression 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> GetTenantIdsWithHttpInfo(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string))
        {
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
            var localVarResponse = this.Client.Get<Object>("/admin/office365/tenantids", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTenantIds", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get tenant ids by filter expression 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetTenantIdsAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await GetTenantIdsWithHttpInfoAsync(filter, orderby, search, top, skip, nexttoken, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// get tenant ids by filter expression 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, enableDynamicMembership, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, lastAccessedTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, sensitivity, insightsStatus, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> GetTenantIdsWithHttpInfoAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/admin/office365/tenantids", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTenantIds", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
