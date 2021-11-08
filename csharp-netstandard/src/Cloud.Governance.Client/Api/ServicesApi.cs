

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
    public interface IServicesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// get change group setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeGroupSettingService</returns>
        ChangeGroupSettingService GetChangeGroupSettingService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get change group setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeGroupSettingService</returns>
        ApiResponse<ChangeGroupSettingService> GetChangeGroupSettingServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get change list setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeListSettingService</returns>
        ChangeListSettingService GetChangeListSettingService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get change list setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeListSettingService</returns>
        ApiResponse<ChangeListSettingService> GetChangeListSettingServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get change permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangePermissionService</returns>
        ChangePermissionService GetChangePermissionService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get change permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangePermissionService</returns>
        ApiResponse<ChangePermissionService> GetChangePermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get change site contact service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeSiteContactService</returns>
        ChangeSiteContactService GetChangeSiteContactService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get change site contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteContactService</returns>
        ApiResponse<ChangeSiteContactService> GetChangeSiteContactServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get change site setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeSiteSettingService</returns>
        ChangeSiteSettingService GetChangeSiteSettingService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get change site setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteSettingService</returns>
        ApiResponse<ChangeSiteSettingService> GetChangeSiteSettingServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeWebContactService</returns>
        ChangeWebContactService GetChangeWebContactService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebContactService</returns>
        ApiResponse<ChangeWebContactService> GetChangeWebContactServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get change web setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeWebSettingService</returns>
        ChangeWebSettingService GetChangeWebSettingsService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get change web setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebSettingService</returns>
        ApiResponse<ChangeWebSettingService> GetChangeWebSettingsServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get clone permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ClonePermissionService</returns>
        ClonePermissionService GetClonePermissionService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get clone permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ClonePermissionService</returns>
        ApiResponse<ClonePermissionService> GetClonePermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get content move profiles from cloud management
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ContentMoveProfiles</returns>
        ContentMoveProfiles GetContentMoveProfiles();

        /// <summary>
        /// get content move profiles from cloud management
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ContentMoveProfiles</returns>
        ApiResponse<ContentMoveProfiles> GetContentMoveProfilesWithHttpInfo();
        /// <summary>
        /// get content move service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ContentMoveService</returns>
        ContentMoveService GetContentMoveService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get content move service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ContentMoveService</returns>
        ApiResponse<ContentMoveService> GetContentMoveServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get create group service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateGroupService</returns>
        CreateGroupService GetCreateGroupService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get create group service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateGroupService</returns>
        ApiResponse<CreateGroupService> GetCreateGroupServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get create group service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateGuestUserService</returns>
        CreateGuestUserService GetCreateGuestUserService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get create group service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateGuestUserService</returns>
        ApiResponse<CreateGuestUserService> GetCreateGuestUserServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get create list service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateListService</returns>
        CreateListService GetCreateListService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get create list service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateListService</returns>
        ApiResponse<CreateListService> GetCreateListServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get private channel service detail
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>CreatePrivateChannelService</returns>
        CreatePrivateChannelService GetCreatePrivateChannelService(Guid id);

        /// <summary>
        /// get private channel service detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of CreatePrivateChannelService</returns>
        ApiResponse<CreatePrivateChannelService> GetCreatePrivateChannelServiceWithHttpInfo(Guid id);
        /// <summary>
        /// get create site service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateSiteService</returns>
        CreateSiteService GetCreateSiteService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get create site service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateSiteService</returns>
        ApiResponse<CreateSiteService> GetCreateSiteServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get create web service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateWebService</returns>
        CreateWebService GetCreateWebService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get create web service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateWebService</returns>
        ApiResponse<CreateWebService> GetCreateWebServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get custom service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ServiceForRequest</returns>
        ServiceForRequest GetCustomService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get custom service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ServiceForRequest</returns>
        ApiResponse<ServiceForRequest> GetCustomServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get grant permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>GrantPermissionService</returns>
        GrantPermissionService GetGrantPermissionService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get grant permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of GrantPermissionService</returns>
        ApiResponse<GrantPermissionService> GetGrantPermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get group lifecycle service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>GroupLifecycleService</returns>
        GroupLifecycleService GetGroupLifecycleService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get group lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of GroupLifecycleService</returns>
        ApiResponse<GroupLifecycleService> GetGroupLifecycleServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get manage permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ManagePermissionService</returns>
        ManagePermissionService GetManagePermissionService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get manage permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ManagePermissionService</returns>
        ApiResponse<ManagePermissionService> GetManagePermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get services that can be used to start a request
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <returns>ServiceListPageResult</returns>
        ServiceListPageResult GetMyServices(string search = default(string));

        /// <summary>
        /// get services that can be used to start a request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <returns>ApiResponse of ServiceListPageResult</returns>
        ApiResponse<ServiceListPageResult> GetMyServicesWithHttpInfo(string search = default(string));
        /// <summary>
        /// get service id by service name
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <returns>Guid</returns>
        Guid GetServiceId(string name);

        /// <summary>
        /// get service id by service name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <returns>ApiResponse of Guid</returns>
        ApiResponse<Guid> GetServiceIdWithHttpInfo(string name);
        /// <summary>
        /// get site lifecycle service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>SiteLifecycleService</returns>
        SiteLifecycleService GetSiteLifecycleService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get site lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of SiteLifecycleService</returns>
        ApiResponse<SiteLifecycleService> GetSiteLifecycleServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// get web lifecycle service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>WebLifecycleService</returns>
        WebLifecycleService GetWebLifecycleService(Guid id, Guid? questionnaireId = default(Guid?));

        /// <summary>
        /// get web lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of WebLifecycleService</returns>
        ApiResponse<WebLifecycleService> GetWebLifecycleServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?));
        /// <summary>
        /// validate guest user email
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <returns>ObjectValidateResult</returns>
        ObjectValidateResult ValidateEmailForCreateGuestUserService(Guid id, string email, Guid? requestId = default(Guid?));

        /// <summary>
        /// validate guest user email
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <returns>ApiResponse of ObjectValidateResult</returns>
        ApiResponse<ObjectValidateResult> ValidateEmailForCreateGuestUserServiceWithHttpInfo(Guid id, string email, Guid? requestId = default(Guid?));
        /// <summary>
        /// validate guest user emails
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ValidateEmailsForCreateGuestUserService(Guid id, List<string> requestBody = default(List<string>));

        /// <summary>
        /// validate guest user emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> ValidateEmailsForCreateGuestUserServiceWithHttpInfo(Guid id, List<string> requestBody = default(List<string>));
        /// <summary>
        /// validate permissions, scope for change group setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <returns>ChangeGroupSettingCheckResult</returns>
        ChangeGroupSettingCheckResult ValidateForChangeGroupSettingService(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter));

        /// <summary>
        /// validate permissions, scope for change group setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeGroupSettingCheckResult</returns>
        ApiResponse<ChangeGroupSettingCheckResult> ValidateForChangeGroupSettingServiceWithHttpInfo(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter));
        /// <summary>
        /// validate permissions, scope for change list setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeListSettingValidateResult</returns>
        ChangeListSettingValidateResult ValidateForChangeListSettingService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for change list setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeListSettingValidateResult</returns>
        ApiResponse<ChangeListSettingValidateResult> ValidateForChangeListSettingServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for change permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangePermissionValidateResult</returns>
        ChangePermissionValidateResult ValidateForChangePermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for change permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangePermissionValidateResult</returns>
        ApiResponse<ChangePermissionValidateResult> ValidateForChangePermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for change site contact service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeSiteContactValidateResult</returns>
        ChangeSiteContactValidateResult ValidateForChangeSiteContactService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for change site contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteContactValidateResult</returns>
        ApiResponse<ChangeSiteContactValidateResult> ValidateForChangeSiteContactServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for change site setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeSiteSettingValidateResult</returns>
        ChangeSiteSettingValidateResult ValidateForChangeSiteSettingService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for change site setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteSettingValidateResult</returns>
        ApiResponse<ChangeSiteSettingValidateResult> ValidateForChangeSiteSettingServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeWebContactValidateResult</returns>
        ChangeWebContactValidateResult ValidateForChangeWebContactService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebContactValidateResult</returns>
        ApiResponse<ChangeWebContactValidateResult> ValidateForChangeWebContactServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for change web setting service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeWebUrlValidateResult</returns>
        ChangeWebUrlValidateResult ValidateForChangeWebSettingService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for change web setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebUrlValidateResult</returns>
        ApiResponse<ChangeWebUrlValidateResult> ValidateForChangeWebSettingServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for clone permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ClonePermissionValidateResult</returns>
        ClonePermissionValidateResult ValidateForClonePermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for clone permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ClonePermissionValidateResult</returns>
        ApiResponse<ClonePermissionValidateResult> ValidateForClonePermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for content move service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <returns>ContentMoveUrlValidationResult</returns>
        ContentMoveUrlValidationResult ValidateForContentMoveService(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter));

        /// <summary>
        /// validate permissions, scope for content move service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ContentMoveUrlValidationResult</returns>
        ApiResponse<ContentMoveUrlValidationResult> ValidateForContentMoveServiceWithHttpInfo(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter));
        /// <summary>
        /// validate groups can invite
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <returns>List&lt;CreateGuestUserValidationResult&gt;</returns>
        List<CreateGuestUserValidationResult> ValidateForCreateGuestUserService(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>));

        /// <summary>
        /// validate groups can invite
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <returns>ApiResponse of List&lt;CreateGuestUserValidationResult&gt;</returns>
        ApiResponse<List<CreateGuestUserValidationResult>> ValidateForCreateGuestUserServiceWithHttpInfo(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>));
        /// <summary>
        /// validate permissions, scope for create list service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <returns>CreateListUrlValidationResult</returns>
        CreateListUrlValidationResult ValidateForCreateListService(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter));

        /// <summary>
        /// validate permissions, scope for create list service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of CreateListUrlValidationResult</returns>
        ApiResponse<CreateListUrlValidationResult> ValidateForCreateListServiceWithHttpInfo(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter));
        /// <summary>
        /// validate permissions, scope for create web service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <returns>CreateWebUrlValidationResult</returns>
        CreateWebUrlValidationResult ValidateForCreateWebService(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter));

        /// <summary>
        /// validate permissions, scope for create web service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of CreateWebUrlValidationResult</returns>
        ApiResponse<CreateWebUrlValidationResult> ValidateForCreateWebServiceWithHttpInfo(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter));
        /// <summary>
        /// validate permissions, scope for grant permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>GrantPermissionUrlValidationResult</returns>
        GrantPermissionUrlValidationResult ValidateForGrantPermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for grant permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of GrantPermissionUrlValidationResult</returns>
        ApiResponse<GrantPermissionUrlValidationResult> ValidateForGrantPermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for group lifecycle service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <returns>GroupLifecycleValidateResult</returns>
        GroupLifecycleValidateResult ValidateForGroupLifecycleService(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter));

        /// <summary>
        /// validate permissions, scope for group lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of GroupLifecycleValidateResult</returns>
        ApiResponse<GroupLifecycleValidateResult> ValidateForGroupLifecycleServiceWithHttpInfo(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter));
        /// <summary>
        /// validate permissions, scope for manage permission service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ManagePermissionValidateResult</returns>
        ManagePermissionValidateResult ValidateForManagePermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for manage permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ManagePermissionValidateResult</returns>
        ApiResponse<ManagePermissionValidateResult> ValidateForManagePermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for site lifecycle service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>SiteLifecycleValidateResult</returns>
        SiteLifecycleValidateResult ValidateForSiteLifecycleService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for site lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of SiteLifecycleValidateResult</returns>
        ApiResponse<SiteLifecycleValidateResult> ValidateForSiteLifecycleServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate permissions, scope for web lifecycle service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>WebLifecycleValidateResult</returns>
        WebLifecycleValidateResult ValidateForWebLifecycleService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));

        /// <summary>
        /// validate permissions, scope for web lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of WebLifecycleValidateResult</returns>
        ApiResponse<WebLifecycleValidateResult> ValidateForWebLifecycleServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter));
        /// <summary>
        /// validate teams for create private channel service
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <returns>CreatePrivateChannelCheckResult</returns>
        CreatePrivateChannelCheckResult ValidateTeamForCreatePrivateChannelService(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter));

        /// <summary>
        /// validate teams for create private channel service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of CreatePrivateChannelCheckResult</returns>
        ApiResponse<CreatePrivateChannelCheckResult> ValidateTeamForCreatePrivateChannelServiceWithHttpInfo(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// get change group setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeGroupSettingService</returns>
        System.Threading.Tasks.Task<ChangeGroupSettingService> GetChangeGroupSettingServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get change group setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeGroupSettingService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeGroupSettingService>> GetChangeGroupSettingServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get change list setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeListSettingService</returns>
        System.Threading.Tasks.Task<ChangeListSettingService> GetChangeListSettingServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get change list setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeListSettingService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeListSettingService>> GetChangeListSettingServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get change permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangePermissionService</returns>
        System.Threading.Tasks.Task<ChangePermissionService> GetChangePermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get change permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangePermissionService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangePermissionService>> GetChangePermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get change site contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteContactService</returns>
        System.Threading.Tasks.Task<ChangeSiteContactService> GetChangeSiteContactServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get change site contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteContactService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeSiteContactService>> GetChangeSiteContactServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get change site setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteSettingService</returns>
        System.Threading.Tasks.Task<ChangeSiteSettingService> GetChangeSiteSettingServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get change site setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteSettingService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeSiteSettingService>> GetChangeSiteSettingServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebContactService</returns>
        System.Threading.Tasks.Task<ChangeWebContactService> GetChangeWebContactServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebContactService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeWebContactService>> GetChangeWebContactServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get change web setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebSettingService</returns>
        System.Threading.Tasks.Task<ChangeWebSettingService> GetChangeWebSettingsServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get change web setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebSettingService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeWebSettingService>> GetChangeWebSettingsServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get clone permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClonePermissionService</returns>
        System.Threading.Tasks.Task<ClonePermissionService> GetClonePermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get clone permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClonePermissionService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClonePermissionService>> GetClonePermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get content move profiles from cloud management
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContentMoveProfiles</returns>
        System.Threading.Tasks.Task<ContentMoveProfiles> GetContentMoveProfilesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get content move profiles from cloud management
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContentMoveProfiles)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContentMoveProfiles>> GetContentMoveProfilesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get content move service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContentMoveService</returns>
        System.Threading.Tasks.Task<ContentMoveService> GetContentMoveServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get content move service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContentMoveService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContentMoveService>> GetContentMoveServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get create group service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateGroupService</returns>
        System.Threading.Tasks.Task<CreateGroupService> GetCreateGroupServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get create group service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateGroupService)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateGroupService>> GetCreateGroupServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get create group service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateGuestUserService</returns>
        System.Threading.Tasks.Task<CreateGuestUserService> GetCreateGuestUserServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get create group service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateGuestUserService)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateGuestUserService>> GetCreateGuestUserServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get create list service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateListService</returns>
        System.Threading.Tasks.Task<CreateListService> GetCreateListServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get create list service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateListService)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateListService>> GetCreateListServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get private channel service detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreatePrivateChannelService</returns>
        System.Threading.Tasks.Task<CreatePrivateChannelService> GetCreatePrivateChannelServiceAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get private channel service detail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreatePrivateChannelService)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreatePrivateChannelService>> GetCreatePrivateChannelServiceWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get create site service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateSiteService</returns>
        System.Threading.Tasks.Task<CreateSiteService> GetCreateSiteServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get create site service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateSiteService)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateSiteService>> GetCreateSiteServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get create web service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateWebService</returns>
        System.Threading.Tasks.Task<CreateWebService> GetCreateWebServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get create web service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateWebService)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateWebService>> GetCreateWebServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get custom service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceForRequest</returns>
        System.Threading.Tasks.Task<ServiceForRequest> GetCustomServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get custom service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceForRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceForRequest>> GetCustomServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get grant permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GrantPermissionService</returns>
        System.Threading.Tasks.Task<GrantPermissionService> GetGrantPermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get grant permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GrantPermissionService)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrantPermissionService>> GetGrantPermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get group lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GroupLifecycleService</returns>
        System.Threading.Tasks.Task<GroupLifecycleService> GetGroupLifecycleServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get group lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GroupLifecycleService)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupLifecycleService>> GetGroupLifecycleServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get manage permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ManagePermissionService</returns>
        System.Threading.Tasks.Task<ManagePermissionService> GetManagePermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get manage permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ManagePermissionService)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagePermissionService>> GetManagePermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get services that can be used to start a request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceListPageResult</returns>
        System.Threading.Tasks.Task<ServiceListPageResult> GetMyServicesAsync(string search = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get services that can be used to start a request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceListPageResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceListPageResult>> GetMyServicesWithHttpInfoAsync(string search = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get service id by service name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Guid</returns>
        System.Threading.Tasks.Task<Guid> GetServiceIdAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get service id by service name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Guid)</returns>
        System.Threading.Tasks.Task<ApiResponse<Guid>> GetServiceIdWithHttpInfoAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get site lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SiteLifecycleService</returns>
        System.Threading.Tasks.Task<SiteLifecycleService> GetSiteLifecycleServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get site lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SiteLifecycleService)</returns>
        System.Threading.Tasks.Task<ApiResponse<SiteLifecycleService>> GetSiteLifecycleServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get web lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WebLifecycleService</returns>
        System.Threading.Tasks.Task<WebLifecycleService> GetWebLifecycleServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get web lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WebLifecycleService)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebLifecycleService>> GetWebLifecycleServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate guest user email
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ObjectValidateResult</returns>
        System.Threading.Tasks.Task<ObjectValidateResult> ValidateEmailForCreateGuestUserServiceAsync(Guid id, string email, Guid? requestId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate guest user email
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ObjectValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectValidateResult>> ValidateEmailForCreateGuestUserServiceWithHttpInfoAsync(Guid id, string email, Guid? requestId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate guest user emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> ValidateEmailsForCreateGuestUserServiceAsync(Guid id, List<string> requestBody = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate guest user emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> ValidateEmailsForCreateGuestUserServiceWithHttpInfoAsync(Guid id, List<string> requestBody = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change group setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeGroupSettingCheckResult</returns>
        System.Threading.Tasks.Task<ChangeGroupSettingCheckResult> ValidateForChangeGroupSettingServiceAsync(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change group setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeGroupSettingCheckResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeGroupSettingCheckResult>> ValidateForChangeGroupSettingServiceWithHttpInfoAsync(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change list setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeListSettingValidateResult</returns>
        System.Threading.Tasks.Task<ChangeListSettingValidateResult> ValidateForChangeListSettingServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change list setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeListSettingValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeListSettingValidateResult>> ValidateForChangeListSettingServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangePermissionValidateResult</returns>
        System.Threading.Tasks.Task<ChangePermissionValidateResult> ValidateForChangePermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangePermissionValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangePermissionValidateResult>> ValidateForChangePermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change site contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteContactValidateResult</returns>
        System.Threading.Tasks.Task<ChangeSiteContactValidateResult> ValidateForChangeSiteContactServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change site contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteContactValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeSiteContactValidateResult>> ValidateForChangeSiteContactServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change site setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteSettingValidateResult</returns>
        System.Threading.Tasks.Task<ChangeSiteSettingValidateResult> ValidateForChangeSiteSettingServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change site setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteSettingValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeSiteSettingValidateResult>> ValidateForChangeSiteSettingServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebContactValidateResult</returns>
        System.Threading.Tasks.Task<ChangeWebContactValidateResult> ValidateForChangeWebContactServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change web contact service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebContactValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeWebContactValidateResult>> ValidateForChangeWebContactServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for change web setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebUrlValidateResult</returns>
        System.Threading.Tasks.Task<ChangeWebUrlValidateResult> ValidateForChangeWebSettingServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for change web setting service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebUrlValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChangeWebUrlValidateResult>> ValidateForChangeWebSettingServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for clone permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClonePermissionValidateResult</returns>
        System.Threading.Tasks.Task<ClonePermissionValidateResult> ValidateForClonePermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for clone permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClonePermissionValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClonePermissionValidateResult>> ValidateForClonePermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for content move service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContentMoveUrlValidationResult</returns>
        System.Threading.Tasks.Task<ContentMoveUrlValidationResult> ValidateForContentMoveServiceAsync(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for content move service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContentMoveUrlValidationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContentMoveUrlValidationResult>> ValidateForContentMoveServiceWithHttpInfoAsync(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate groups can invite
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;CreateGuestUserValidationResult&gt;</returns>
        System.Threading.Tasks.Task<List<CreateGuestUserValidationResult>> ValidateForCreateGuestUserServiceAsync(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate groups can invite
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;CreateGuestUserValidationResult&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CreateGuestUserValidationResult>>> ValidateForCreateGuestUserServiceWithHttpInfoAsync(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for create list service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateListUrlValidationResult</returns>
        System.Threading.Tasks.Task<CreateListUrlValidationResult> ValidateForCreateListServiceAsync(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for create list service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateListUrlValidationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateListUrlValidationResult>> ValidateForCreateListServiceWithHttpInfoAsync(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for create web service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateWebUrlValidationResult</returns>
        System.Threading.Tasks.Task<CreateWebUrlValidationResult> ValidateForCreateWebServiceAsync(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for create web service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateWebUrlValidationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateWebUrlValidationResult>> ValidateForCreateWebServiceWithHttpInfoAsync(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for grant permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GrantPermissionUrlValidationResult</returns>
        System.Threading.Tasks.Task<GrantPermissionUrlValidationResult> ValidateForGrantPermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for grant permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GrantPermissionUrlValidationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrantPermissionUrlValidationResult>> ValidateForGrantPermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for group lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GroupLifecycleValidateResult</returns>
        System.Threading.Tasks.Task<GroupLifecycleValidateResult> ValidateForGroupLifecycleServiceAsync(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for group lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GroupLifecycleValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupLifecycleValidateResult>> ValidateForGroupLifecycleServiceWithHttpInfoAsync(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for manage permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ManagePermissionValidateResult</returns>
        System.Threading.Tasks.Task<ManagePermissionValidateResult> ValidateForManagePermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for manage permission service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ManagePermissionValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagePermissionValidateResult>> ValidateForManagePermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for site lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SiteLifecycleValidateResult</returns>
        System.Threading.Tasks.Task<SiteLifecycleValidateResult> ValidateForSiteLifecycleServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for site lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SiteLifecycleValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SiteLifecycleValidateResult>> ValidateForSiteLifecycleServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate permissions, scope for web lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WebLifecycleValidateResult</returns>
        System.Threading.Tasks.Task<WebLifecycleValidateResult> ValidateForWebLifecycleServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate permissions, scope for web lifecycle service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WebLifecycleValidateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebLifecycleValidateResult>> ValidateForWebLifecycleServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// validate teams for create private channel service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreatePrivateChannelCheckResult</returns>
        System.Threading.Tasks.Task<CreatePrivateChannelCheckResult> ValidateTeamForCreatePrivateChannelServiceAsync(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// validate teams for create private channel service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreatePrivateChannelCheckResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreatePrivateChannelCheckResult>> ValidateTeamForCreatePrivateChannelServiceWithHttpInfoAsync(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicesApi : IServicesApiSync, IServicesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServicesApi : IServicesApi
    {
        private Cloud.Governance.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ServicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServicesApi(Cloud.Governance.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ServicesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ServicesApi(Cloud.Governance.Client.Client.ISynchronousClient client, Cloud.Governance.Client.Client.IAsynchronousClient asyncClient, Cloud.Governance.Client.Client.IReadableConfiguration configuration)
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
        /// get change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeGroupSettingService</returns>
        public ChangeGroupSettingService GetChangeGroupSettingService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingService> localVarResponse = GetChangeGroupSettingServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeGroupSettingService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingService> GetChangeGroupSettingServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangeGroupSettingService>("/services/changegroupsetting/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeGroupSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeGroupSettingService</returns>
        public async System.Threading.Tasks.Task<ChangeGroupSettingService> GetChangeGroupSettingServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingService> localVarResponse = await GetChangeGroupSettingServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeGroupSettingService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingService>> GetChangeGroupSettingServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangeGroupSettingService>("/services/changegroupsetting/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeGroupSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeListSettingService</returns>
        public ChangeListSettingService GetChangeListSettingService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingService> localVarResponse = GetChangeListSettingServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeListSettingService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingService> GetChangeListSettingServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangeListSettingService>("/services/changelistsetting/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeListSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeListSettingService</returns>
        public async System.Threading.Tasks.Task<ChangeListSettingService> GetChangeListSettingServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingService> localVarResponse = await GetChangeListSettingServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeListSettingService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingService>> GetChangeListSettingServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangeListSettingService>("/services/changelistsetting/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeListSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangePermissionService</returns>
        public ChangePermissionService GetChangePermissionService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangePermissionService> localVarResponse = GetChangePermissionServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangePermissionService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangePermissionService> GetChangePermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangePermissionService>("/services/changepermission/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangePermissionService</returns>
        public async System.Threading.Tasks.Task<ChangePermissionService> GetChangePermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangePermissionService> localVarResponse = await GetChangePermissionServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangePermissionService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangePermissionService>> GetChangePermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangePermissionService>("/services/changepermission/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeSiteContactService</returns>
        public ChangeSiteContactService GetChangeSiteContactService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactService> localVarResponse = GetChangeSiteContactServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteContactService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactService> GetChangeSiteContactServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangeSiteContactService>("/services/changesitecontact/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeSiteContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteContactService</returns>
        public async System.Threading.Tasks.Task<ChangeSiteContactService> GetChangeSiteContactServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactService> localVarResponse = await GetChangeSiteContactServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteContactService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactService>> GetChangeSiteContactServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangeSiteContactService>("/services/changesitecontact/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeSiteContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeSiteSettingService</returns>
        public ChangeSiteSettingService GetChangeSiteSettingService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingService> localVarResponse = GetChangeSiteSettingServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteSettingService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingService> GetChangeSiteSettingServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangeSiteSettingService>("/services/changesitesetting/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeSiteSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteSettingService</returns>
        public async System.Threading.Tasks.Task<ChangeSiteSettingService> GetChangeSiteSettingServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingService> localVarResponse = await GetChangeSiteSettingServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteSettingService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingService>> GetChangeSiteSettingServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangeSiteSettingService>("/services/changesitesetting/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeSiteSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeWebContactService</returns>
        public ChangeWebContactService GetChangeWebContactService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactService> localVarResponse = GetChangeWebContactServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebContactService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactService> GetChangeWebContactServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangeWebContactService>("/services/changewebcontact/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeWebContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebContactService</returns>
        public async System.Threading.Tasks.Task<ChangeWebContactService> GetChangeWebContactServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactService> localVarResponse = await GetChangeWebContactServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebContactService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactService>> GetChangeWebContactServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangeWebContactService>("/services/changewebcontact/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeWebContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ChangeWebSettingService</returns>
        public ChangeWebSettingService GetChangeWebSettingsService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebSettingService> localVarResponse = GetChangeWebSettingsServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebSettingService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeWebSettingService> GetChangeWebSettingsServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ChangeWebSettingService>("/services/changewebsettings/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeWebSettingsService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebSettingService</returns>
        public async System.Threading.Tasks.Task<ChangeWebSettingService> GetChangeWebSettingsServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebSettingService> localVarResponse = await GetChangeWebSettingsServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebSettingService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeWebSettingService>> GetChangeWebSettingsServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ChangeWebSettingService>("/services/changewebsettings/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChangeWebSettingsService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ClonePermissionService</returns>
        public ClonePermissionService GetClonePermissionService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ClonePermissionService> localVarResponse = GetClonePermissionServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ClonePermissionService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ClonePermissionService> GetClonePermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ClonePermissionService>("/services/clonepermission/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClonePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClonePermissionService</returns>
        public async System.Threading.Tasks.Task<ClonePermissionService> GetClonePermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ClonePermissionService> localVarResponse = await GetClonePermissionServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClonePermissionService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ClonePermissionService>> GetClonePermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ClonePermissionService>("/services/clonepermission/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClonePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get content move profiles from cloud management 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ContentMoveProfiles</returns>
        public ContentMoveProfiles GetContentMoveProfiles()
        {
            Cloud.Governance.Client.Client.ApiResponse<ContentMoveProfiles> localVarResponse = GetContentMoveProfilesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// get content move profiles from cloud management 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ContentMoveProfiles</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ContentMoveProfiles> GetContentMoveProfilesWithHttpInfo()
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
            var localVarResponse = this.Client.Get<ContentMoveProfiles>("/services/contentmove/profiles", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetContentMoveProfiles", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get content move profiles from cloud management 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContentMoveProfiles</returns>
        public async System.Threading.Tasks.Task<ContentMoveProfiles> GetContentMoveProfilesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ContentMoveProfiles> localVarResponse = await GetContentMoveProfilesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get content move profiles from cloud management 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContentMoveProfiles)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ContentMoveProfiles>> GetContentMoveProfilesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ContentMoveProfiles>("/services/contentmove/profiles", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetContentMoveProfiles", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ContentMoveService</returns>
        public ContentMoveService GetContentMoveService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ContentMoveService> localVarResponse = GetContentMoveServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ContentMoveService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ContentMoveService> GetContentMoveServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ContentMoveService>("/services/contentmove/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetContentMoveService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContentMoveService</returns>
        public async System.Threading.Tasks.Task<ContentMoveService> GetContentMoveServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ContentMoveService> localVarResponse = await GetContentMoveServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContentMoveService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ContentMoveService>> GetContentMoveServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ContentMoveService>("/services/contentmove/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetContentMoveService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateGroupService</returns>
        public CreateGroupService GetCreateGroupService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateGroupService> localVarResponse = GetCreateGroupServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateGroupService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateGroupService> GetCreateGroupServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<CreateGroupService>("/services/creategroup/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateGroupService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateGroupService</returns>
        public async System.Threading.Tasks.Task<CreateGroupService> GetCreateGroupServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateGroupService> localVarResponse = await GetCreateGroupServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateGroupService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateGroupService>> GetCreateGroupServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CreateGroupService>("/services/creategroup/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateGroupService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateGuestUserService</returns>
        public CreateGuestUserService GetCreateGuestUserService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateGuestUserService> localVarResponse = GetCreateGuestUserServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateGuestUserService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateGuestUserService> GetCreateGuestUserServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<CreateGuestUserService>("/services/createguestuser/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateGuestUserService</returns>
        public async System.Threading.Tasks.Task<CreateGuestUserService> GetCreateGuestUserServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateGuestUserService> localVarResponse = await GetCreateGuestUserServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create group service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateGuestUserService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateGuestUserService>> GetCreateGuestUserServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CreateGuestUserService>("/services/createguestuser/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateListService</returns>
        public CreateListService GetCreateListService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateListService> localVarResponse = GetCreateListServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateListService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateListService> GetCreateListServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<CreateListService>("/services/createlist/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateListService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateListService</returns>
        public async System.Threading.Tasks.Task<CreateListService> GetCreateListServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateListService> localVarResponse = await GetCreateListServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateListService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateListService>> GetCreateListServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CreateListService>("/services/createlist/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateListService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get private channel service detail 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>CreatePrivateChannelService</returns>
        public CreatePrivateChannelService GetCreatePrivateChannelService(Guid id)
        {
            Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelService> localVarResponse = GetCreatePrivateChannelServiceWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get private channel service detail 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of CreatePrivateChannelService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelService> GetCreatePrivateChannelServiceWithHttpInfo(Guid id)
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = this.Client.Get<CreatePrivateChannelService>("/services/createprivatechannel/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreatePrivateChannelService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get private channel service detail 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreatePrivateChannelService</returns>
        public async System.Threading.Tasks.Task<CreatePrivateChannelService> GetCreatePrivateChannelServiceAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelService> localVarResponse = await GetCreatePrivateChannelServiceWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get private channel service detail 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreatePrivateChannelService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelService>> GetCreatePrivateChannelServiceWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CreatePrivateChannelService>("/services/createprivatechannel/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreatePrivateChannelService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create site service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateSiteService</returns>
        public CreateSiteService GetCreateSiteService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateSiteService> localVarResponse = GetCreateSiteServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create site service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateSiteService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateSiteService> GetCreateSiteServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<CreateSiteService>("/services/createsite/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateSiteService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create site service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateSiteService</returns>
        public async System.Threading.Tasks.Task<CreateSiteService> GetCreateSiteServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateSiteService> localVarResponse = await GetCreateSiteServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create site service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateSiteService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateSiteService>> GetCreateSiteServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CreateSiteService>("/services/createsite/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateSiteService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>CreateWebService</returns>
        public CreateWebService GetCreateWebService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateWebService> localVarResponse = GetCreateWebServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of CreateWebService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateWebService> GetCreateWebServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<CreateWebService>("/services/createweb/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateWebService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateWebService</returns>
        public async System.Threading.Tasks.Task<CreateWebService> GetCreateWebServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateWebService> localVarResponse = await GetCreateWebServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateWebService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateWebService>> GetCreateWebServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CreateWebService>("/services/createweb/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCreateWebService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get custom service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ServiceForRequest</returns>
        public ServiceForRequest GetCustomService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ServiceForRequest> localVarResponse = GetCustomServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get custom service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ServiceForRequest</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ServiceForRequest> GetCustomServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ServiceForRequest>("/services/custom/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get custom service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceForRequest</returns>
        public async System.Threading.Tasks.Task<ServiceForRequest> GetCustomServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ServiceForRequest> localVarResponse = await GetCustomServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get custom service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceForRequest)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ServiceForRequest>> GetCustomServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ServiceForRequest>("/services/custom/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>GrantPermissionService</returns>
        public GrantPermissionService GetGrantPermissionService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<GrantPermissionService> localVarResponse = GetGrantPermissionServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of GrantPermissionService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<GrantPermissionService> GetGrantPermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<GrantPermissionService>("/services/grantpermission/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGrantPermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GrantPermissionService</returns>
        public async System.Threading.Tasks.Task<GrantPermissionService> GetGrantPermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<GrantPermissionService> localVarResponse = await GetGrantPermissionServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GrantPermissionService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<GrantPermissionService>> GetGrantPermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<GrantPermissionService>("/services/grantpermission/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGrantPermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>GroupLifecycleService</returns>
        public GroupLifecycleService GetGroupLifecycleService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleService> localVarResponse = GetGroupLifecycleServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of GroupLifecycleService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleService> GetGroupLifecycleServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<GroupLifecycleService>("/services/grouplifecycle/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroupLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GroupLifecycleService</returns>
        public async System.Threading.Tasks.Task<GroupLifecycleService> GetGroupLifecycleServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleService> localVarResponse = await GetGroupLifecycleServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GroupLifecycleService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleService>> GetGroupLifecycleServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<GroupLifecycleService>("/services/grouplifecycle/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroupLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ManagePermissionService</returns>
        public ManagePermissionService GetManagePermissionService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ManagePermissionService> localVarResponse = GetManagePermissionServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of ManagePermissionService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ManagePermissionService> GetManagePermissionServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<ManagePermissionService>("/services/managepermission/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetManagePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ManagePermissionService</returns>
        public async System.Threading.Tasks.Task<ManagePermissionService> GetManagePermissionServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ManagePermissionService> localVarResponse = await GetManagePermissionServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ManagePermissionService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ManagePermissionService>> GetManagePermissionServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ManagePermissionService>("/services/managepermission/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetManagePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get services that can be used to start a request 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <returns>ServiceListPageResult</returns>
        public ServiceListPageResult GetMyServices(string search = default(string))
        {
            Cloud.Governance.Client.Client.ApiResponse<ServiceListPageResult> localVarResponse = GetMyServicesWithHttpInfo(search);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get services that can be used to start a request 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <returns>ApiResponse of ServiceListPageResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ServiceListPageResult> GetMyServicesWithHttpInfo(string search = default(string))
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

            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "search", search));
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
            var localVarResponse = this.Client.Get<ServiceListPageResult>("/services/my", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMyServices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get services that can be used to start a request 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceListPageResult</returns>
        public async System.Threading.Tasks.Task<ServiceListPageResult> GetMyServicesAsync(string search = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ServiceListPageResult> localVarResponse = await GetMyServicesWithHttpInfoAsync(search, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get services that can be used to start a request 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceListPageResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ServiceListPageResult>> GetMyServicesWithHttpInfoAsync(string search = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "search", search));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ServiceListPageResult>("/services/my", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMyServices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get service id by service name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <returns>Guid</returns>
        public Guid GetServiceId(string name)
        {
            Cloud.Governance.Client.Client.ApiResponse<Guid> localVarResponse = GetServiceIdWithHttpInfo(name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get service id by service name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <returns>ApiResponse of Guid</returns>
        public Cloud.Governance.Client.Client.ApiResponse<Guid> GetServiceIdWithHttpInfo(string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'name' when calling ServicesApi->GetServiceId");

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
            var localVarResponse = this.Client.Get<Guid>("/services/id", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServiceId", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get service id by service name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Guid</returns>
        public async System.Threading.Tasks.Task<Guid> GetServiceIdAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<Guid> localVarResponse = await GetServiceIdWithHttpInfoAsync(name, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get service id by service name 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">service name, case insensitive</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Guid)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<Guid>> GetServiceIdWithHttpInfoAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'name' when calling ServicesApi->GetServiceId");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Guid>("/services/id", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServiceId", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>SiteLifecycleService</returns>
        public SiteLifecycleService GetSiteLifecycleService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleService> localVarResponse = GetSiteLifecycleServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of SiteLifecycleService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleService> GetSiteLifecycleServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<SiteLifecycleService>("/services/sitelifecycle/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSiteLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SiteLifecycleService</returns>
        public async System.Threading.Tasks.Task<SiteLifecycleService> GetSiteLifecycleServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleService> localVarResponse = await GetSiteLifecycleServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SiteLifecycleService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleService>> GetSiteLifecycleServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<SiteLifecycleService>("/services/sitelifecycle/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSiteLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>WebLifecycleService</returns>
        public WebLifecycleService GetWebLifecycleService(Guid id, Guid? questionnaireId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<WebLifecycleService> localVarResponse = GetWebLifecycleServiceWithHttpInfo(id, questionnaireId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <returns>ApiResponse of WebLifecycleService</returns>
        public Cloud.Governance.Client.Client.ApiResponse<WebLifecycleService> GetWebLifecycleServiceWithHttpInfo(Guid id, Guid? questionnaireId = default(Guid?))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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
            var localVarResponse = this.Client.Get<WebLifecycleService>("/services/weblifecycle/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWebLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WebLifecycleService</returns>
        public async System.Threading.Tasks.Task<WebLifecycleService> GetWebLifecycleServiceAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<WebLifecycleService> localVarResponse = await GetWebLifecycleServiceWithHttpInfoAsync(id, questionnaireId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="questionnaireId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WebLifecycleService)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<WebLifecycleService>> GetWebLifecycleServiceWithHttpInfoAsync(Guid id, Guid? questionnaireId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (questionnaireId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "questionnaireId", questionnaireId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<WebLifecycleService>("/services/weblifecycle/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWebLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate guest user email 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <returns>ObjectValidateResult</returns>
        public ObjectValidateResult ValidateEmailForCreateGuestUserService(Guid id, string email, Guid? requestId = default(Guid?))
        {
            Cloud.Governance.Client.Client.ApiResponse<ObjectValidateResult> localVarResponse = ValidateEmailForCreateGuestUserServiceWithHttpInfo(id, email, requestId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate guest user email 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <returns>ApiResponse of ObjectValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ObjectValidateResult> ValidateEmailForCreateGuestUserServiceWithHttpInfo(Guid id, string email, Guid? requestId = default(Guid?))
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'email' when calling ServicesApi->ValidateEmailForCreateGuestUserService");

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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "email", email));
            if (requestId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "requestId", requestId));
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
            var localVarResponse = this.Client.Get<ObjectValidateResult>("/services/createguestuser/{id}/email/validate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateEmailForCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate guest user email 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ObjectValidateResult</returns>
        public async System.Threading.Tasks.Task<ObjectValidateResult> ValidateEmailForCreateGuestUserServiceAsync(Guid id, string email, Guid? requestId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ObjectValidateResult> localVarResponse = await ValidateEmailForCreateGuestUserServiceWithHttpInfoAsync(id, email, requestId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate guest user email 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ObjectValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ObjectValidateResult>> ValidateEmailForCreateGuestUserServiceWithHttpInfoAsync(Guid id, string email, Guid? requestId = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new Cloud.Governance.Client.Client.ApiException(400, "Missing required parameter 'email' when calling ServicesApi->ValidateEmailForCreateGuestUserService");


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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "email", email));
            if (requestId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "requestId", requestId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectValidateResult>("/services/createguestuser/{id}/email/validate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateEmailForCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate guest user emails 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ValidateEmailsForCreateGuestUserService(Guid id, List<string> requestBody = default(List<string>))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<string>> localVarResponse = ValidateEmailsForCreateGuestUserServiceWithHttpInfo(id, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate guest user emails 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<string>> ValidateEmailsForCreateGuestUserServiceWithHttpInfo(Guid id, List<string> requestBody = default(List<string>))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = requestBody;

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
            var localVarResponse = this.Client.Post<List<string>>("/services/createguestuser/{id}/email/validate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateEmailsForCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate guest user emails 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> ValidateEmailsForCreateGuestUserServiceAsync(Guid id, List<string> requestBody = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<string>> localVarResponse = await ValidateEmailsForCreateGuestUserServiceWithHttpInfoAsync(id, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate guest user emails 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<string>>> ValidateEmailsForCreateGuestUserServiceWithHttpInfoAsync(Guid id, List<string> requestBody = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = requestBody;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<string>>("/services/createguestuser/{id}/email/validate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateEmailsForCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <returns>ChangeGroupSettingCheckResult</returns>
        public ChangeGroupSettingCheckResult ValidateForChangeGroupSettingService(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingCheckResult> localVarResponse = ValidateForChangeGroupSettingServiceWithHttpInfo(id, changeGroupSettingValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeGroupSettingCheckResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingCheckResult> ValidateForChangeGroupSettingServiceWithHttpInfo(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = changeGroupSettingValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangeGroupSettingCheckResult>("/services/changegroupsetting/{id}/group/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeGroupSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeGroupSettingCheckResult</returns>
        public async System.Threading.Tasks.Task<ChangeGroupSettingCheckResult> ValidateForChangeGroupSettingServiceAsync(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingCheckResult> localVarResponse = await ValidateForChangeGroupSettingServiceWithHttpInfoAsync(id, changeGroupSettingValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change group setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="changeGroupSettingValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeGroupSettingCheckResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeGroupSettingCheckResult>> ValidateForChangeGroupSettingServiceWithHttpInfoAsync(Guid id, ChangeGroupSettingValidationParameter changeGroupSettingValidationParameter = default(ChangeGroupSettingValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = changeGroupSettingValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangeGroupSettingCheckResult>("/services/changegroupsetting/{id}/group/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeGroupSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeListSettingValidateResult</returns>
        public ChangeListSettingValidateResult ValidateForChangeListSettingService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingValidateResult> localVarResponse = ValidateForChangeListSettingServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeListSettingValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingValidateResult> ValidateForChangeListSettingServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangeListSettingValidateResult>("/services/changelistsetting/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeListSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeListSettingValidateResult</returns>
        public async System.Threading.Tasks.Task<ChangeListSettingValidateResult> ValidateForChangeListSettingServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingValidateResult> localVarResponse = await ValidateForChangeListSettingServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change list setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeListSettingValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeListSettingValidateResult>> ValidateForChangeListSettingServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangeListSettingValidateResult>("/services/changelistsetting/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeListSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangePermissionValidateResult</returns>
        public ChangePermissionValidateResult ValidateForChangePermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangePermissionValidateResult> localVarResponse = ValidateForChangePermissionServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangePermissionValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangePermissionValidateResult> ValidateForChangePermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangePermissionValidateResult>("/services/changepermission/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangePermissionValidateResult</returns>
        public async System.Threading.Tasks.Task<ChangePermissionValidateResult> ValidateForChangePermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangePermissionValidateResult> localVarResponse = await ValidateForChangePermissionServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangePermissionValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangePermissionValidateResult>> ValidateForChangePermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangePermissionValidateResult>("/services/changepermission/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeSiteContactValidateResult</returns>
        public ChangeSiteContactValidateResult ValidateForChangeSiteContactService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactValidateResult> localVarResponse = ValidateForChangeSiteContactServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteContactValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactValidateResult> ValidateForChangeSiteContactServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangeSiteContactValidateResult>("/services/changesitecontact/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeSiteContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteContactValidateResult</returns>
        public async System.Threading.Tasks.Task<ChangeSiteContactValidateResult> ValidateForChangeSiteContactServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactValidateResult> localVarResponse = await ValidateForChangeSiteContactServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change site contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteContactValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeSiteContactValidateResult>> ValidateForChangeSiteContactServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangeSiteContactValidateResult>("/services/changesitecontact/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeSiteContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeSiteSettingValidateResult</returns>
        public ChangeSiteSettingValidateResult ValidateForChangeSiteSettingService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingValidateResult> localVarResponse = ValidateForChangeSiteSettingServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeSiteSettingValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingValidateResult> ValidateForChangeSiteSettingServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangeSiteSettingValidateResult>("/services/changesitesetting/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeSiteSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeSiteSettingValidateResult</returns>
        public async System.Threading.Tasks.Task<ChangeSiteSettingValidateResult> ValidateForChangeSiteSettingServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingValidateResult> localVarResponse = await ValidateForChangeSiteSettingServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change site setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeSiteSettingValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeSiteSettingValidateResult>> ValidateForChangeSiteSettingServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangeSiteSettingValidateResult>("/services/changesitesetting/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeSiteSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeWebContactValidateResult</returns>
        public ChangeWebContactValidateResult ValidateForChangeWebContactService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactValidateResult> localVarResponse = ValidateForChangeWebContactServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebContactValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactValidateResult> ValidateForChangeWebContactServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangeWebContactValidateResult>("/services/changewebcontact/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeWebContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebContactValidateResult</returns>
        public async System.Threading.Tasks.Task<ChangeWebContactValidateResult> ValidateForChangeWebContactServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactValidateResult> localVarResponse = await ValidateForChangeWebContactServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change web contact service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebContactValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeWebContactValidateResult>> ValidateForChangeWebContactServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangeWebContactValidateResult>("/services/changewebcontact/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeWebContactService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ChangeWebUrlValidateResult</returns>
        public ChangeWebUrlValidateResult ValidateForChangeWebSettingService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebUrlValidateResult> localVarResponse = ValidateForChangeWebSettingServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ChangeWebUrlValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ChangeWebUrlValidateResult> ValidateForChangeWebSettingServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ChangeWebUrlValidateResult>("/services/changewebsettings/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeWebSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ChangeWebUrlValidateResult</returns>
        public async System.Threading.Tasks.Task<ChangeWebUrlValidateResult> ValidateForChangeWebSettingServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ChangeWebUrlValidateResult> localVarResponse = await ValidateForChangeWebSettingServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for change web setting service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ChangeWebUrlValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ChangeWebUrlValidateResult>> ValidateForChangeWebSettingServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ChangeWebUrlValidateResult>("/services/changewebsettings/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForChangeWebSettingService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ClonePermissionValidateResult</returns>
        public ClonePermissionValidateResult ValidateForClonePermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ClonePermissionValidateResult> localVarResponse = ValidateForClonePermissionServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ClonePermissionValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ClonePermissionValidateResult> ValidateForClonePermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ClonePermissionValidateResult>("/services/clonepermission/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForClonePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClonePermissionValidateResult</returns>
        public async System.Threading.Tasks.Task<ClonePermissionValidateResult> ValidateForClonePermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ClonePermissionValidateResult> localVarResponse = await ValidateForClonePermissionServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for clone permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClonePermissionValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ClonePermissionValidateResult>> ValidateForClonePermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ClonePermissionValidateResult>("/services/clonepermission/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForClonePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <returns>ContentMoveUrlValidationResult</returns>
        public ContentMoveUrlValidationResult ValidateForContentMoveService(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ContentMoveUrlValidationResult> localVarResponse = ValidateForContentMoveServiceWithHttpInfo(id, contentMoveUrlValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ContentMoveUrlValidationResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ContentMoveUrlValidationResult> ValidateForContentMoveServiceWithHttpInfo(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = contentMoveUrlValidationParameter;

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
            var localVarResponse = this.Client.Post<ContentMoveUrlValidationResult>("/services/contentmove/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForContentMoveService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContentMoveUrlValidationResult</returns>
        public async System.Threading.Tasks.Task<ContentMoveUrlValidationResult> ValidateForContentMoveServiceAsync(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ContentMoveUrlValidationResult> localVarResponse = await ValidateForContentMoveServiceWithHttpInfoAsync(id, contentMoveUrlValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for content move service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="contentMoveUrlValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContentMoveUrlValidationResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ContentMoveUrlValidationResult>> ValidateForContentMoveServiceWithHttpInfoAsync(Guid id, ContentMoveUrlValidationParameter contentMoveUrlValidationParameter = default(ContentMoveUrlValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = contentMoveUrlValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ContentMoveUrlValidationResult>("/services/contentmove/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForContentMoveService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate groups can invite 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <returns>List&lt;CreateGuestUserValidationResult&gt;</returns>
        public List<CreateGuestUserValidationResult> ValidateForCreateGuestUserService(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<CreateGuestUserValidationResult>> localVarResponse = ValidateForCreateGuestUserServiceWithHttpInfo(id, requestId, apiUser);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate groups can invite 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <returns>ApiResponse of List&lt;CreateGuestUserValidationResult&gt;</returns>
        public Cloud.Governance.Client.Client.ApiResponse<List<CreateGuestUserValidationResult>> ValidateForCreateGuestUserServiceWithHttpInfo(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (requestId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "requestId", requestId));
            }
            localVarRequestOptions.Data = apiUser;

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
            var localVarResponse = this.Client.Post<List<CreateGuestUserValidationResult>>("/services/createguestuser/{id}/group/validate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate groups can invite 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;CreateGuestUserValidationResult&gt;</returns>
        public async System.Threading.Tasks.Task<List<CreateGuestUserValidationResult>> ValidateForCreateGuestUserServiceAsync(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<List<CreateGuestUserValidationResult>> localVarResponse = await ValidateForCreateGuestUserServiceWithHttpInfoAsync(id, requestId, apiUser, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate groups can invite 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="requestId"> (optional)</param>
        /// <param name="apiUser"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;CreateGuestUserValidationResult&gt;)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<List<CreateGuestUserValidationResult>>> ValidateForCreateGuestUserServiceWithHttpInfoAsync(Guid id, Guid? requestId = default(Guid?), List<ApiUser> apiUser = default(List<ApiUser>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (requestId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Cloud.Governance.Client.Client.ClientUtils.ParameterToMultiMap("", "requestId", requestId));
            }
            localVarRequestOptions.Data = apiUser;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<CreateGuestUserValidationResult>>("/services/createguestuser/{id}/group/validate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForCreateGuestUserService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <returns>CreateListUrlValidationResult</returns>
        public CreateListUrlValidationResult ValidateForCreateListService(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateListUrlValidationResult> localVarResponse = ValidateForCreateListServiceWithHttpInfo(id, listValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of CreateListUrlValidationResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateListUrlValidationResult> ValidateForCreateListServiceWithHttpInfo(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = listValidationParameter;

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
            var localVarResponse = this.Client.Post<CreateListUrlValidationResult>("/services/createlist/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForCreateListService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateListUrlValidationResult</returns>
        public async System.Threading.Tasks.Task<CreateListUrlValidationResult> ValidateForCreateListServiceAsync(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateListUrlValidationResult> localVarResponse = await ValidateForCreateListServiceWithHttpInfoAsync(id, listValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for create list service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="listValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateListUrlValidationResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateListUrlValidationResult>> ValidateForCreateListServiceWithHttpInfoAsync(Guid id, ListValidationParameter listValidationParameter = default(ListValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = listValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<CreateListUrlValidationResult>("/services/createlist/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForCreateListService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <returns>CreateWebUrlValidationResult</returns>
        public CreateWebUrlValidationResult ValidateForCreateWebService(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateWebUrlValidationResult> localVarResponse = ValidateForCreateWebServiceWithHttpInfo(id, createWebValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of CreateWebUrlValidationResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreateWebUrlValidationResult> ValidateForCreateWebServiceWithHttpInfo(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = createWebValidationParameter;

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
            var localVarResponse = this.Client.Post<CreateWebUrlValidationResult>("/services/createweb/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForCreateWebService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateWebUrlValidationResult</returns>
        public async System.Threading.Tasks.Task<CreateWebUrlValidationResult> ValidateForCreateWebServiceAsync(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreateWebUrlValidationResult> localVarResponse = await ValidateForCreateWebServiceWithHttpInfoAsync(id, createWebValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for create web service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="createWebValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateWebUrlValidationResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreateWebUrlValidationResult>> ValidateForCreateWebServiceWithHttpInfoAsync(Guid id, CreateWebValidationParameter createWebValidationParameter = default(CreateWebValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = createWebValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<CreateWebUrlValidationResult>("/services/createweb/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForCreateWebService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>GrantPermissionUrlValidationResult</returns>
        public GrantPermissionUrlValidationResult ValidateForGrantPermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<GrantPermissionUrlValidationResult> localVarResponse = ValidateForGrantPermissionServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of GrantPermissionUrlValidationResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<GrantPermissionUrlValidationResult> ValidateForGrantPermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<GrantPermissionUrlValidationResult>("/services/grantpermission/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForGrantPermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GrantPermissionUrlValidationResult</returns>
        public async System.Threading.Tasks.Task<GrantPermissionUrlValidationResult> ValidateForGrantPermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<GrantPermissionUrlValidationResult> localVarResponse = await ValidateForGrantPermissionServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for grant permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GrantPermissionUrlValidationResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<GrantPermissionUrlValidationResult>> ValidateForGrantPermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<GrantPermissionUrlValidationResult>("/services/grantpermission/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForGrantPermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <returns>GroupLifecycleValidateResult</returns>
        public GroupLifecycleValidateResult ValidateForGroupLifecycleService(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleValidateResult> localVarResponse = ValidateForGroupLifecycleServiceWithHttpInfo(id, groupValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of GroupLifecycleValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleValidateResult> ValidateForGroupLifecycleServiceWithHttpInfo(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = groupValidationParameter;

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
            var localVarResponse = this.Client.Post<GroupLifecycleValidateResult>("/services/grouplifecycle/{id}/group/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForGroupLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GroupLifecycleValidateResult</returns>
        public async System.Threading.Tasks.Task<GroupLifecycleValidateResult> ValidateForGroupLifecycleServiceAsync(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleValidateResult> localVarResponse = await ValidateForGroupLifecycleServiceWithHttpInfoAsync(id, groupValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for group lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="groupValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GroupLifecycleValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<GroupLifecycleValidateResult>> ValidateForGroupLifecycleServiceWithHttpInfoAsync(Guid id, GroupValidationParameter groupValidationParameter = default(GroupValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = groupValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<GroupLifecycleValidateResult>("/services/grouplifecycle/{id}/group/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForGroupLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ManagePermissionValidateResult</returns>
        public ManagePermissionValidateResult ValidateForManagePermissionService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<ManagePermissionValidateResult> localVarResponse = ValidateForManagePermissionServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of ManagePermissionValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<ManagePermissionValidateResult> ValidateForManagePermissionServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<ManagePermissionValidateResult>("/services/managepermission/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForManagePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ManagePermissionValidateResult</returns>
        public async System.Threading.Tasks.Task<ManagePermissionValidateResult> ValidateForManagePermissionServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<ManagePermissionValidateResult> localVarResponse = await ValidateForManagePermissionServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for manage permission service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ManagePermissionValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<ManagePermissionValidateResult>> ValidateForManagePermissionServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ManagePermissionValidateResult>("/services/managepermission/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForManagePermissionService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>SiteLifecycleValidateResult</returns>
        public SiteLifecycleValidateResult ValidateForSiteLifecycleService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleValidateResult> localVarResponse = ValidateForSiteLifecycleServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of SiteLifecycleValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleValidateResult> ValidateForSiteLifecycleServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<SiteLifecycleValidateResult>("/services/sitelifecycle/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForSiteLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SiteLifecycleValidateResult</returns>
        public async System.Threading.Tasks.Task<SiteLifecycleValidateResult> ValidateForSiteLifecycleServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleValidateResult> localVarResponse = await ValidateForSiteLifecycleServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for site lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SiteLifecycleValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<SiteLifecycleValidateResult>> ValidateForSiteLifecycleServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<SiteLifecycleValidateResult>("/services/sitelifecycle/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForSiteLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>WebLifecycleValidateResult</returns>
        public WebLifecycleValidateResult ValidateForWebLifecycleService(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<WebLifecycleValidateResult> localVarResponse = ValidateForWebLifecycleServiceWithHttpInfo(id, siteValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of WebLifecycleValidateResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<WebLifecycleValidateResult> ValidateForWebLifecycleServiceWithHttpInfo(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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
            var localVarResponse = this.Client.Post<WebLifecycleValidateResult>("/services/weblifecycle/{id}/url/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForWebLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate permissions, scope for web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WebLifecycleValidateResult</returns>
        public async System.Threading.Tasks.Task<WebLifecycleValidateResult> ValidateForWebLifecycleServiceAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<WebLifecycleValidateResult> localVarResponse = await ValidateForWebLifecycleServiceWithHttpInfoAsync(id, siteValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate permissions, scope for web lifecycle service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="siteValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WebLifecycleValidateResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<WebLifecycleValidateResult>> ValidateForWebLifecycleServiceWithHttpInfoAsync(Guid id, SiteValidationParameter siteValidationParameter = default(SiteValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("id", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = siteValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<WebLifecycleValidateResult>("/services/weblifecycle/{id}/url/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateForWebLifecycleService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate teams for create private channel service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <returns>CreatePrivateChannelCheckResult</returns>
        public CreatePrivateChannelCheckResult ValidateTeamForCreatePrivateChannelService(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelCheckResult> localVarResponse = ValidateTeamForCreatePrivateChannelServiceWithHttpInfo(serviceId, createPrivateChannelValidationParameter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate teams for create private channel service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <returns>ApiResponse of CreatePrivateChannelCheckResult</returns>
        public Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelCheckResult> ValidateTeamForCreatePrivateChannelServiceWithHttpInfo(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter))
        {
            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("serviceId", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(serviceId)); // path parameter
            localVarRequestOptions.Data = createPrivateChannelValidationParameter;

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
            var localVarResponse = this.Client.Post<CreatePrivateChannelCheckResult>("/services/createprivatechannel/{serviceId}/team/validation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateTeamForCreatePrivateChannelService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// validate teams for create private channel service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreatePrivateChannelCheckResult</returns>
        public async System.Threading.Tasks.Task<CreatePrivateChannelCheckResult> ValidateTeamForCreatePrivateChannelServiceAsync(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelCheckResult> localVarResponse = await ValidateTeamForCreatePrivateChannelServiceWithHttpInfoAsync(serviceId, createPrivateChannelValidationParameter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// validate teams for create private channel service 
        /// </summary>
        /// <exception cref="Cloud.Governance.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceId"></param>
        /// <param name="createPrivateChannelValidationParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreatePrivateChannelCheckResult)</returns>
        public async System.Threading.Tasks.Task<Cloud.Governance.Client.Client.ApiResponse<CreatePrivateChannelCheckResult>> ValidateTeamForCreatePrivateChannelServiceWithHttpInfoAsync(Guid serviceId, CreatePrivateChannelValidationParameter createPrivateChannelValidationParameter = default(CreatePrivateChannelValidationParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Cloud.Governance.Client.Client.RequestOptions localVarRequestOptions = new Cloud.Governance.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
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

            localVarRequestOptions.PathParameters.Add("serviceId", Cloud.Governance.Client.Client.ClientUtils.ParameterToString(serviceId)); // path parameter
            localVarRequestOptions.Data = createPrivateChannelValidationParameter;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<CreatePrivateChannelCheckResult>("/services/createprivatechannel/{serviceId}/team/validation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateTeamForCreatePrivateChannelService", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
