

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
    public interface IWorkspacesAdminApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// apply groups policy
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <returns></returns>
        void ApplyGroupsPolicy(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel));

        /// <summary>
        /// apply groups policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApplyGroupsPolicyWithHttpInfo(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel));
        /// <summary>
        /// apply site policy
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <returns></returns>
        void ApplySitesPolicy(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel));

        /// <summary>
        /// apply site policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApplySitesPolicyWithHttpInfo(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel));
        /// <summary>
        /// archive workspace
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <returns></returns>
        void ArchiveWorkspace(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter));

        /// <summary>
        /// archive workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ArchiveWorkspaceWithHttpInfo(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter));
        /// <summary>
        /// completed renewal task
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        void CompleteWorkspaceRenewalTask(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));

        /// <summary>
        /// completed renewal task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CompleteWorkspaceRenewalTaskWithHttpInfo(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));
        /// <summary>
        /// delete workspaces
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        void DeleteWorkspaces(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));

        /// <summary>
        /// delete workspaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWithHttpInfo(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));
        /// <summary>
        /// get workspace ongoing tasks
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <returns>List&lt;WorksapceOngoingTasksModel&gt;</returns>
        List<WorksapceOngoingTasksModel> GetOngoingTasks(WorkspaceType type, string groupNameOrUrl);

        /// <summary>
        /// get workspace ongoing tasks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <returns>ApiResponse of List&lt;WorksapceOngoingTasksModel&gt;</returns>
        ApiResponse<List<WorksapceOngoingTasksModel>> GetOngoingTasksWithHttpInfo(WorkspaceType type, string groupNameOrUrl);
        /// <summary>
        /// get managed workspaces
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>WorkspaceGridModelPageResult</returns>
        WorkspaceGridModelPageResult GetWorkspaces(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string));

        /// <summary>
        /// get managed workspaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ApiResponse of WorkspaceGridModelPageResult</returns>
        ApiResponse<WorkspaceGridModelPageResult> GetWorkspacesWithHttpInfo(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string));
        /// <summary>
        /// lock sites or Office365 group sites
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <returns></returns>
        void LockWorkspaces(LockSiteParameter lockSiteParameter = default(LockSiteParameter));

        /// <summary>
        /// lock sites or Office365 group sites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> LockWorkspacesWithHttpInfo(LockSiteParameter lockSiteParameter = default(LockSiteParameter));
        /// <summary>
        /// trigger workspace renewal
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        void TriggerWorkspaceRenewal(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));

        /// <summary>
        /// trigger workspace renewal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TriggerWorkspaceRenewalWithHttpInfo(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));
        /// <summary>
        /// unlock sites and Office365 group site
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        void UnlockWorkspace(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));

        /// <summary>
        /// unlock sites and Office365 group site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnlockWorkspaceWithHttpInfo(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkspacesAdminApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// apply groups policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApplyGroupsPolicyAsync(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// apply groups policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApplyGroupsPolicyWithHttpInfoAsync(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// apply site policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApplySitesPolicyAsync(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// apply site policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApplySitesPolicyWithHttpInfoAsync(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// archive workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ArchiveWorkspaceAsync(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// archive workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ArchiveWorkspaceWithHttpInfoAsync(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// completed renewal task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CompleteWorkspaceRenewalTaskAsync(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// completed renewal task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CompleteWorkspaceRenewalTaskWithHttpInfoAsync(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// delete workspaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkspacesAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// delete workspaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWithHttpInfoAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get workspace ongoing tasks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;WorksapceOngoingTasksModel&gt;</returns>
        System.Threading.Tasks.Task<List<WorksapceOngoingTasksModel>> GetOngoingTasksAsync(WorkspaceType type, string groupNameOrUrl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get workspace ongoing tasks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;WorksapceOngoingTasksModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WorksapceOngoingTasksModel>>> GetOngoingTasksWithHttpInfoAsync(WorkspaceType type, string groupNameOrUrl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get managed workspaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WorkspaceGridModelPageResult</returns>
        System.Threading.Tasks.Task<WorkspaceGridModelPageResult> GetWorkspacesAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get managed workspaces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WorkspaceGridModelPageResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceGridModelPageResult>> GetWorkspacesWithHttpInfoAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// lock sites or Office365 group sites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task LockWorkspacesAsync(LockSiteParameter lockSiteParameter = default(LockSiteParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// lock sites or Office365 group sites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LockWorkspacesWithHttpInfoAsync(LockSiteParameter lockSiteParameter = default(LockSiteParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// trigger workspace renewal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TriggerWorkspaceRenewalAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// trigger workspace renewal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TriggerWorkspaceRenewalWithHttpInfoAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// unlock sites and Office365 group site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UnlockWorkspaceAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// unlock sites and Office365 group site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UnlockWorkspaceWithHttpInfoAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkspacesAdminApi : IWorkspacesAdminApiSync, IWorkspacesAdminApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkspacesAdminApi : IWorkspacesAdminApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacesAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkspacesAdminApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacesAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkspacesAdminApi(String basePath)
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
        /// Initializes a new instance of the <see cref="WorkspacesAdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkspacesAdminApi(Cloud.Governance.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="WorkspacesAdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WorkspacesAdminApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
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
        /// apply groups policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <returns></returns>
        public void ApplyGroupsPolicy(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel))
        {
            ApplyGroupsPolicyWithHttpInfo(applyGroupPolicyModel);
        }

        /// <summary>
        /// apply groups policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> ApplyGroupsPolicyWithHttpInfo(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel))
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

            localVarRequestOptions.Data = applyGroupPolicyModel;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/groups/policy", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApplyGroupsPolicy", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// apply groups policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApplyGroupsPolicyAsync(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApplyGroupsPolicyWithHttpInfoAsync(applyGroupPolicyModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// apply groups policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applyGroupPolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> ApplyGroupsPolicyWithHttpInfoAsync(ApplyGroupPolicyModel applyGroupPolicyModel = default(ApplyGroupPolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = applyGroupPolicyModel;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/groups/policy", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApplyGroupsPolicy", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// apply site policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <returns></returns>
        public void ApplySitesPolicy(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel))
        {
            ApplySitesPolicyWithHttpInfo(applySitePolicyModel);
        }

        /// <summary>
        /// apply site policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> ApplySitesPolicyWithHttpInfo(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel))
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

            localVarRequestOptions.Data = applySitePolicyModel;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/sites/policy", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApplySitesPolicy", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// apply site policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApplySitesPolicyAsync(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApplySitesPolicyWithHttpInfoAsync(applySitePolicyModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// apply site policy 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applySitePolicyModel">apply policy setting (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> ApplySitesPolicyWithHttpInfoAsync(ApplySitePolicyModel applySitePolicyModel = default(ApplySitePolicyModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = applySitePolicyModel;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/sites/policy", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApplySitesPolicy", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// archive workspace 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <returns></returns>
        public void ArchiveWorkspace(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter))
        {
            ArchiveWorkspaceWithHttpInfo(archiveWorkspaceParameter);
        }

        /// <summary>
        /// archive workspace 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> ArchiveWorkspaceWithHttpInfo(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter))
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

            localVarRequestOptions.Data = archiveWorkspaceParameter;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/archive", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ArchiveWorkspace", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// archive workspace 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ArchiveWorkspaceAsync(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ArchiveWorkspaceWithHttpInfoAsync(archiveWorkspaceParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// archive workspace 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="archiveWorkspaceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> ArchiveWorkspaceWithHttpInfoAsync(ArchiveWorkspaceParameter archiveWorkspaceParameter = default(ArchiveWorkspaceParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = archiveWorkspaceParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/archive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ArchiveWorkspace", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// completed renewal task 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        public void CompleteWorkspaceRenewalTask(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
        {
            CompleteWorkspaceRenewalTaskWithHttpInfo(markAsCanceled, workspaceIdTypeModel);
        }

        /// <summary>
        /// completed renewal task 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> CompleteWorkspaceRenewalTaskWithHttpInfo(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
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

            if (markAsCanceled != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "markAsCanceled", markAsCanceled));
            }
            localVarRequestOptions.Data = workspaceIdTypeModel;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/renewal/complete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CompleteWorkspaceRenewalTask", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// completed renewal task 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CompleteWorkspaceRenewalTaskAsync(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CompleteWorkspaceRenewalTaskWithHttpInfoAsync(markAsCanceled, workspaceIdTypeModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// completed renewal task 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="markAsCanceled"> (optional, default to false)</param>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> CompleteWorkspaceRenewalTaskWithHttpInfoAsync(bool? markAsCanceled = default(bool?), List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (markAsCanceled != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "markAsCanceled", markAsCanceled));
            }
            localVarRequestOptions.Data = workspaceIdTypeModel;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/renewal/complete", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CompleteWorkspaceRenewalTask", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        public void DeleteWorkspaces(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
        {
            DeleteWorkspacesWithHttpInfo(workspaceIdTypeModel);
        }

        /// <summary>
        /// delete workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> DeleteWorkspacesWithHttpInfo(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
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

            localVarRequestOptions.Data = workspaceIdTypeModel;

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
            var localVarResponse = this.Client.Delete<Object>("/admin/directory/workspace", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteWorkspaces", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkspacesAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteWorkspacesWithHttpInfoAsync(workspaceIdTypeModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// delete workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> DeleteWorkspacesWithHttpInfoAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = workspaceIdTypeModel;

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/admin/directory/workspace", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteWorkspaces", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get workspace ongoing tasks 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <returns>List&lt;WorksapceOngoingTasksModel&gt;</returns>
        public List<WorksapceOngoingTasksModel> GetOngoingTasks(WorkspaceType type, string groupNameOrUrl)
        {
            Cloud.Governance.Client.Client.ApiResponse<List<WorksapceOngoingTasksModel>> localVarResponse = GetOngoingTasksWithHttpInfo(type, groupNameOrUrl);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get workspace ongoing tasks 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <returns>ApiResponse of List&lt;WorksapceOngoingTasksModel&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<WorksapceOngoingTasksModel>> GetOngoingTasksWithHttpInfo(WorkspaceType type, string groupNameOrUrl)
        {
            // verify the required parameter 'groupNameOrUrl' is set
            if (groupNameOrUrl == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'groupNameOrUrl' when calling WorkspacesAdminApi->GetOngoingTasks");

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

            localVarRequestOptions.PathParameters.Add("type", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(type)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "groupNameOrUrl", groupNameOrUrl));

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
            var localVarResponse = this.Client.Get<List<WorksapceOngoingTasksModel>>("/admin/directory/workspace/{type}/ongoningtasks", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOngoingTasks", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get workspace ongoing tasks 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;WorksapceOngoingTasksModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<WorksapceOngoingTasksModel>> GetOngoingTasksAsync(WorkspaceType type, string groupNameOrUrl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<WorksapceOngoingTasksModel>> localVarResponse = await GetOngoingTasksWithHttpInfoAsync(type, groupNameOrUrl, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get workspace ongoing tasks 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="groupNameOrUrl"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;WorksapceOngoingTasksModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<WorksapceOngoingTasksModel>>> GetOngoingTasksWithHttpInfoAsync(WorkspaceType type, string groupNameOrUrl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'groupNameOrUrl' is set
            if (groupNameOrUrl == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'groupNameOrUrl' when calling WorkspacesAdminApi->GetOngoingTasks");


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

            localVarRequestOptions.PathParameters.Add("type", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(type)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "groupNameOrUrl", groupNameOrUrl));

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<WorksapceOngoingTasksModel>>("/admin/directory/workspace/{type}/ongoningtasks", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOngoingTasks", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get managed workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>WorkspaceGridModelPageResult</returns>
        public WorkspaceGridModelPageResult GetWorkspaces(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string))
        {
            Cloud.Governance.Client.Client.ApiResponse<WorkspaceGridModelPageResult> localVarResponse = GetWorkspacesWithHttpInfo(filter, orderby, search, top, skip, nexttoken);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get managed workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <returns>ApiResponse of WorkspaceGridModelPageResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<WorkspaceGridModelPageResult> GetWorkspacesWithHttpInfo(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string))
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
            var localVarResponse = this.Client.Get<WorkspaceGridModelPageResult>("/admin/directory/workspace", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWorkspaces", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get managed workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WorkspaceGridModelPageResult</returns>
        public async System.Threading.Tasks.Task<WorkspaceGridModelPageResult> GetWorkspacesAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<WorkspaceGridModelPageResult> localVarResponse = await GetWorkspacesWithHttpInfoAsync(filter, orderby, search, top, skip, nexttoken, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get managed workspaces 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq &#39;value1&#39; and field2 ne &#39;value2&#39;), supported fields :&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="orderby">Order by one field, supported fields:&lt;br/&gt; id, name, description, status, type, url, email, privacy, policyName, policyId, primaryAdministrators, additionalAdministrators, primaryContact, secondaryContact, hubType, associateHubTitle, geoLocation, storageLimit, storageUsed, siteSharing, groupSharing, classification, claimStatus, createdTime, leaseExpirationTime, inactivityThresholdTime, lastRenewalTime, applyPolicyStatus, hasOngoingTasks, lastRenewalBy, phaseAssignees, phaseProfileName, phaseProfileId, phaseStartTime, renewalDueDate, nextRenewalDate, phase (optional)</param>
        /// <param name="search">Search for name (optional)</param>
        /// <param name="top"> Define the number of records you want to return, max value is 200, default value is 200 (optional)</param>
        /// <param name="skip"> Define the number of records you want to skip, default value is 0 (optional)</param>
        /// <param name="nexttoken"> Use the next token to get the next paging result (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WorkspaceGridModelPageResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<WorkspaceGridModelPageResult>> GetWorkspacesWithHttpInfoAsync(string filter = default(string), string orderby = default(string), string search = default(string), int? top = default(int?), string skip = default(string), string nexttoken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<WorkspaceGridModelPageResult>("/admin/directory/workspace", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWorkspaces", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// lock sites or Office365 group sites 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <returns></returns>
        public void LockWorkspaces(LockSiteParameter lockSiteParameter = default(LockSiteParameter))
        {
            LockWorkspacesWithHttpInfo(lockSiteParameter);
        }

        /// <summary>
        /// lock sites or Office365 group sites 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> LockWorkspacesWithHttpInfo(LockSiteParameter lockSiteParameter = default(LockSiteParameter))
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

            localVarRequestOptions.Data = lockSiteParameter;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/lock", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LockWorkspaces", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// lock sites or Office365 group sites 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task LockWorkspacesAsync(LockSiteParameter lockSiteParameter = default(LockSiteParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await LockWorkspacesWithHttpInfoAsync(lockSiteParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// lock sites or Office365 group sites 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lockSiteParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> LockWorkspacesWithHttpInfoAsync(LockSiteParameter lockSiteParameter = default(LockSiteParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = lockSiteParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/lock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LockWorkspaces", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// trigger workspace renewal 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        public void TriggerWorkspaceRenewal(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
        {
            TriggerWorkspaceRenewalWithHttpInfo(workspaceIdTypeModel);
        }

        /// <summary>
        /// trigger workspace renewal 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> TriggerWorkspaceRenewalWithHttpInfo(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
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

            localVarRequestOptions.Data = workspaceIdTypeModel;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/renewal/trigger", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TriggerWorkspaceRenewal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// trigger workspace renewal 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TriggerWorkspaceRenewalAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await TriggerWorkspaceRenewalWithHttpInfoAsync(workspaceIdTypeModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// trigger workspace renewal 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> TriggerWorkspaceRenewalWithHttpInfoAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = workspaceIdTypeModel;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/renewal/trigger", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TriggerWorkspaceRenewal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// unlock sites and Office365 group site 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns></returns>
        public void UnlockWorkspace(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
        {
            UnlockWorkspaceWithHttpInfo(workspaceIdTypeModel);
        }

        /// <summary>
        /// unlock sites and Office365 group site 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Object> UnlockWorkspaceWithHttpInfo(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>))
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

            localVarRequestOptions.Data = workspaceIdTypeModel;

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
            var localVarResponse = this.Client.Post<Object>("/admin/directory/workspace/unlock", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnlockWorkspace", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// unlock sites and Office365 group site 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UnlockWorkspaceAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await UnlockWorkspaceWithHttpInfoAsync(workspaceIdTypeModel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// unlock sites and Office365 group site 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceIdTypeModel"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Object>> UnlockWorkspaceWithHttpInfoAsync(List<WorkspaceIdTypeModel> workspaceIdTypeModel = default(List<WorkspaceIdTypeModel>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = workspaceIdTypeModel;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/directory/workspace/unlock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnlockWorkspace", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
