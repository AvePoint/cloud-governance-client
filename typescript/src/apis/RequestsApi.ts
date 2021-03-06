/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import * as runtime from '../runtime';
import {
    ApiError,
    ApiErrorFromJSON,
    ApiErrorToJSON,
    ApiRequest,
    ApiRequestFromJSON,
    ApiRequestToJSON,
    ApiTask,
    ApiTaskFromJSON,
    ApiTaskToJSON,
    ArchiveGroupRequest,
    ArchiveGroupRequestFromJSON,
    ArchiveGroupRequestToJSON,
    ArchiveSiteRequest,
    ArchiveSiteRequestFromJSON,
    ArchiveSiteRequestToJSON,
    ArchiveWebLifecycleRequest,
    ArchiveWebLifecycleRequestFromJSON,
    ArchiveWebLifecycleRequestToJSON,
    ChangeGroupPolicyRequest,
    ChangeGroupPolicyRequestFromJSON,
    ChangeGroupPolicyRequestToJSON,
    ChangeGroupQuotaRequest,
    ChangeGroupQuotaRequestFromJSON,
    ChangeGroupQuotaRequestToJSON,
    ChangeGroupSettingRequest,
    ChangeGroupSettingRequestFromJSON,
    ChangeGroupSettingRequestToJSON,
    ChangeListSettingRequest,
    ChangeListSettingRequestFromJSON,
    ChangeListSettingRequestToJSON,
    ChangePermissionRequest,
    ChangePermissionRequestFromJSON,
    ChangePermissionRequestToJSON,
    ChangeSiteContactRequest,
    ChangeSiteContactRequestFromJSON,
    ChangeSiteContactRequestToJSON,
    ChangeSitePolicyRequest,
    ChangeSitePolicyRequestFromJSON,
    ChangeSitePolicyRequestToJSON,
    ChangeSiteQuotaRequest,
    ChangeSiteQuotaRequestFromJSON,
    ChangeSiteQuotaRequestToJSON,
    ChangeSiteSettingRequest,
    ChangeSiteSettingRequestFromJSON,
    ChangeSiteSettingRequestToJSON,
    ChangeWebContactRequest,
    ChangeWebContactRequestFromJSON,
    ChangeWebContactRequestToJSON,
    ChangeWebSettingRequest,
    ChangeWebSettingRequestFromJSON,
    ChangeWebSettingRequestToJSON,
    ClonePermissionRequest,
    ClonePermissionRequestFromJSON,
    ClonePermissionRequestToJSON,
    ContentMoveRequest,
    ContentMoveRequestFromJSON,
    ContentMoveRequestToJSON,
    CreateGroupRequest,
    CreateGroupRequestFromJSON,
    CreateGroupRequestToJSON,
    CreateGuestUserRequest,
    CreateGuestUserRequestFromJSON,
    CreateGuestUserRequestToJSON,
    CreateListRequest,
    CreateListRequestFromJSON,
    CreateListRequestToJSON,
    CreateSiteRequest,
    CreateSiteRequestFromJSON,
    CreateSiteRequestToJSON,
    CreateWebRequest,
    CreateWebRequestFromJSON,
    CreateWebRequestToJSON,
    DeleteGroupRequest,
    DeleteGroupRequestFromJSON,
    DeleteGroupRequestToJSON,
    DeleteSiteRequest,
    DeleteSiteRequestFromJSON,
    DeleteSiteRequestToJSON,
    DeleteWebLifecycleRequest,
    DeleteWebLifecycleRequestFromJSON,
    DeleteWebLifecycleRequestToJSON,
    ExtendGroupRequest,
    ExtendGroupRequestFromJSON,
    ExtendGroupRequestToJSON,
    ExtendSiteRequest,
    ExtendSiteRequestFromJSON,
    ExtendSiteRequestToJSON,
    GrantPermissionRequest,
    GrantPermissionRequestFromJSON,
    GrantPermissionRequestToJSON,
    LockSiteRequest,
    LockSiteRequestFromJSON,
    LockSiteRequestToJSON,
    ManagePermissionRequest,
    ManagePermissionRequestFromJSON,
    ManagePermissionRequestToJSON,
    RequestListPageResult,
    RequestListPageResultFromJSON,
    RequestListPageResultToJSON,
    RestoreGroupRequest,
    RestoreGroupRequestFromJSON,
    RestoreGroupRequestToJSON,
    SiteLifecycleRequest,
    SiteLifecycleRequestFromJSON,
    SiteLifecycleRequestToJSON,
    UnlockSiteRequest,
    UnlockSiteRequestFromJSON,
    UnlockSiteRequestToJSON,
} from '../models';

export interface CancelRequestRequest {
    id: string;
}

export interface GetArchiveGroupRequestRequest {
    id: string;
}

export interface GetArchiveSiteRequestRequest {
    id: string;
}

export interface GetArchiveWebRequestRequest {
    id: string;
}

export interface GetChagneGroupPolicyRequestRequest {
    id: string;
}

export interface GetChangeGroupQuotaRequestRequest {
    id: string;
}

export interface GetChangeGroupSettingRequestRequest {
    id: string;
}

export interface GetChangeListSettingRequestRequest {
    id: string;
}

export interface GetChangePermissionRequestRequest {
    id: string;
}

export interface GetChangeSiteContactRequestRequest {
    id: string;
}

export interface GetChangeSitePolicyRequestRequest {
    id: string;
}

export interface GetChangeSiteQuotaRequestRequest {
    id: string;
}

export interface GetChangeSiteSettingRequestRequest {
    id: string;
}

export interface GetChangeWebContactRequestRequest {
    id: string;
}

export interface GetChangeWebSettingRequestRequest {
    id: string;
}

export interface GetClonePermissionRequestRequest {
    id: string;
}

export interface GetContentMoveRequestRequest {
    id: string;
}

export interface GetCreateGroupRequestRequest {
    id: string;
}

export interface GetCreateGuestUserRequestRequest {
    id: string;
}

export interface GetCreateListRequestRequest {
    id: string;
}

export interface GetCreateSiteRequestRequest {
    id: string;
}

export interface GetCreateWebRequestRequest {
    id: string;
}

export interface GetCustomRequestRequest {
    id: string;
}

export interface GetDeleteGroupRequestRequest {
    id: string;
}

export interface GetDeleteSiteRequestRequest {
    id: string;
}

export interface GetDeleteWebRequestRequest {
    id: string;
}

export interface GetExtendGroupRequestRequest {
    id: string;
}

export interface GetExtendSiteRequestRequest {
    id: string;
}

export interface GetGrantPermissionRequestRequest {
    id: string;
}

export interface GetLockSiteReuqestRequest {
    id: string;
}

export interface GetManagePermissionRequestRequest {
    id: string;
}

export interface GetMyRequestsRequest {
    filter?: string | null;
    orderby?: string | null;
    search?: string | null;
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

export interface GetRequestByIdRequest {
    id: string;
}

export interface GetRestoreGroupRequestRequest {
    id: string;
}

export interface GetSiteCollectionLifecycleRequestRequest {
    id: string;
}

export interface GetTasksRequest {
    requestid: string;
}

export interface GetUnlockSiteRequestRequest {
    id: string;
}

export interface IsUrlExistsInPendingRequestsRequest {
    url: string;
    requestId?: string;
}

export interface SubmitArchiveGroupRequestRequest {
    archiveGroupRequest?: ArchiveGroupRequest;
}

export interface SubmitArchiveSiteRequestRequest {
    archiveSiteRequest?: ArchiveSiteRequest;
}

export interface SubmitArchiveWebRequestRequest {
    archiveWebLifecycleRequest?: ArchiveWebLifecycleRequest;
}

export interface SubmitChangeGroupPolicyRequestRequest {
    changeGroupPolicyRequest?: ChangeGroupPolicyRequest;
}

export interface SubmitChangeGroupQuotaRequestRequest {
    changeGroupQuotaRequest?: ChangeGroupQuotaRequest;
}

export interface SubmitChangeGroupSettingRequestRequest {
    changeGroupSettingRequest?: ChangeGroupSettingRequest;
}

export interface SubmitChangeListSettingRequestRequest {
    changeListSettingRequest?: ChangeListSettingRequest;
}

export interface SubmitChangePermissionRequestRequest {
    changePermissionRequest?: ChangePermissionRequest;
}

export interface SubmitChangeSiteContactRequestRequest {
    changeSiteContactRequest?: ChangeSiteContactRequest;
}

export interface SubmitChangeSitePolicyRequestRequest {
    changeSitePolicyRequest?: ChangeSitePolicyRequest;
}

export interface SubmitChangeSiteQuotaRequestRequest {
    changeSiteQuotaRequest?: ChangeSiteQuotaRequest;
}

export interface SubmitChangeSiteSettingRequestRequest {
    changeSiteSettingRequest?: ChangeSiteSettingRequest;
}

export interface SubmitChangeWebContactRequestRequest {
    changeWebContactRequest?: ChangeWebContactRequest;
}

export interface SubmitChangeWebSettingRequestRequest {
    changeWebSettingRequest?: ChangeWebSettingRequest;
}

export interface SubmitClonePermissionRequestRequest {
    clonePermissionRequest?: ClonePermissionRequest;
}

export interface SubmitContentMoveRequestRequest {
    contentMoveRequest?: ContentMoveRequest;
}

export interface SubmitCreateGroupRequestRequest {
    createGroupRequest?: CreateGroupRequest;
}

export interface SubmitCreateGuestUserRequestRequest {
    createGuestUserRequest?: CreateGuestUserRequest;
}

export interface SubmitCreateListRequestRequest {
    createListRequest?: CreateListRequest;
}

export interface SubmitCreateSiteRequestRequest {
    createSiteRequest: CreateSiteRequest;
}

export interface SubmitCreateWebRequestRequest {
    createWebRequest?: CreateWebRequest;
}

export interface SubmitCustomRequestRequest {
    apiRequest?: ApiRequest;
}

export interface SubmitDeleteGroupRequestRequest {
    deleteGroupRequest?: DeleteGroupRequest;
}

export interface SubmitDeleteSiteRequestRequest {
    deleteSiteRequest?: DeleteSiteRequest;
}

export interface SubmitDeleteWebRequestRequest {
    deleteWebLifecycleRequest?: DeleteWebLifecycleRequest;
}

export interface SubmitExtendGroupRequestRequest {
    extendGroupRequest?: ExtendGroupRequest;
}

export interface SubmitExtendSiteRequestRequest {
    extendSiteRequest?: ExtendSiteRequest;
}

export interface SubmitGrantPermissionRequestRequest {
    grantPermissionRequest?: GrantPermissionRequest;
}

export interface SubmitLockSiteRequestRequest {
    lockSiteRequest?: LockSiteRequest;
}

export interface SubmitManagePermissionRequestRequest {
    managePermissionRequest?: ManagePermissionRequest;
}

export interface SubmitRestoreGroupRequestRequest {
    restoreGroupRequest?: RestoreGroupRequest;
}

export interface SubmitUnlockSiteRequestRequest {
    unlockSiteRequest?: UnlockSiteRequest;
}

/**
 * 
 */
export class RequestsApi extends runtime.BaseAPI {

    /**
     * cancel request
     */
    async cancelRequestRaw(requestParameters: CancelRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling cancelRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/{id}/cancel`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * cancel request
     */
    async cancelRequest(requestParameters: CancelRequestRequest): Promise<void> {
        await this.cancelRequestRaw(requestParameters);
    }

    /**
     * get archive group request
     */
    async getArchiveGroupRequestRaw(requestParameters: GetArchiveGroupRequestRequest): Promise<runtime.ApiResponse<ArchiveGroupRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getArchiveGroupRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/archivegroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ArchiveGroupRequestFromJSON(jsonValue));
    }

    /**
     * get archive group request
     */
    async getArchiveGroupRequest(requestParameters: GetArchiveGroupRequestRequest): Promise<ArchiveGroupRequest> {
        const response = await this.getArchiveGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get archive site request
     */
    async getArchiveSiteRequestRaw(requestParameters: GetArchiveSiteRequestRequest): Promise<runtime.ApiResponse<ArchiveSiteRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getArchiveSiteRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/archivesite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ArchiveSiteRequestFromJSON(jsonValue));
    }

    /**
     * get archive site request
     */
    async getArchiveSiteRequest(requestParameters: GetArchiveSiteRequestRequest): Promise<ArchiveSiteRequest> {
        const response = await this.getArchiveSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get archive web request
     */
    async getArchiveWebRequestRaw(requestParameters: GetArchiveWebRequestRequest): Promise<runtime.ApiResponse<ArchiveWebLifecycleRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getArchiveWebRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/archiveweb/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ArchiveWebLifecycleRequestFromJSON(jsonValue));
    }

    /**
     * get archive web request
     */
    async getArchiveWebRequest(requestParameters: GetArchiveWebRequestRequest): Promise<ArchiveWebLifecycleRequest> {
        const response = await this.getArchiveWebRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change group policy request
     */
    async getChagneGroupPolicyRequestRaw(requestParameters: GetChagneGroupPolicyRequestRequest): Promise<runtime.ApiResponse<ChangeGroupPolicyRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChagneGroupPolicyRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changegrouppolicy/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeGroupPolicyRequestFromJSON(jsonValue));
    }

    /**
     * get change group policy request
     */
    async getChagneGroupPolicyRequest(requestParameters: GetChagneGroupPolicyRequestRequest): Promise<ChangeGroupPolicyRequest> {
        const response = await this.getChagneGroupPolicyRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change group quota request
     */
    async getChangeGroupQuotaRequestRaw(requestParameters: GetChangeGroupQuotaRequestRequest): Promise<runtime.ApiResponse<ChangeGroupQuotaRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeGroupQuotaRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changegroupquota/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeGroupQuotaRequestFromJSON(jsonValue));
    }

    /**
     * get change group quota request
     */
    async getChangeGroupQuotaRequest(requestParameters: GetChangeGroupQuotaRequestRequest): Promise<ChangeGroupQuotaRequest> {
        const response = await this.getChangeGroupQuotaRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change group settings request
     */
    async getChangeGroupSettingRequestRaw(requestParameters: GetChangeGroupSettingRequestRequest): Promise<runtime.ApiResponse<ChangeGroupSettingRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeGroupSettingRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changegroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeGroupSettingRequestFromJSON(jsonValue));
    }

    /**
     * get change group settings request
     */
    async getChangeGroupSettingRequest(requestParameters: GetChangeGroupSettingRequestRequest): Promise<ChangeGroupSettingRequest> {
        const response = await this.getChangeGroupSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change list settings request
     */
    async getChangeListSettingRequestRaw(requestParameters: GetChangeListSettingRequestRequest): Promise<runtime.ApiResponse<ChangeListSettingRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeListSettingRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changelistsetting/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeListSettingRequestFromJSON(jsonValue));
    }

    /**
     * get change list settings request
     */
    async getChangeListSettingRequest(requestParameters: GetChangeListSettingRequestRequest): Promise<ChangeListSettingRequest> {
        const response = await this.getChangeListSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change permission request
     */
    async getChangePermissionRequestRaw(requestParameters: GetChangePermissionRequestRequest): Promise<runtime.ApiResponse<ChangePermissionRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangePermissionRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changepermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangePermissionRequestFromJSON(jsonValue));
    }

    /**
     * get change permission request
     */
    async getChangePermissionRequest(requestParameters: GetChangePermissionRequestRequest): Promise<ChangePermissionRequest> {
        const response = await this.getChangePermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change site administrator or contact request
     */
    async getChangeSiteContactRequestRaw(requestParameters: GetChangeSiteContactRequestRequest): Promise<runtime.ApiResponse<ChangeSiteContactRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeSiteContactRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesite/adminorcontact/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteContactRequestFromJSON(jsonValue));
    }

    /**
     * get change site administrator or contact request
     */
    async getChangeSiteContactRequest(requestParameters: GetChangeSiteContactRequestRequest): Promise<ChangeSiteContactRequest> {
        const response = await this.getChangeSiteContactRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change site policy request
     */
    async getChangeSitePolicyRequestRaw(requestParameters: GetChangeSitePolicyRequestRequest): Promise<runtime.ApiResponse<ChangeSitePolicyRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeSitePolicyRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesitepolicy/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSitePolicyRequestFromJSON(jsonValue));
    }

    /**
     * get change site policy request
     */
    async getChangeSitePolicyRequest(requestParameters: GetChangeSitePolicyRequestRequest): Promise<ChangeSitePolicyRequest> {
        const response = await this.getChangeSitePolicyRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change site quota request
     */
    async getChangeSiteQuotaRequestRaw(requestParameters: GetChangeSiteQuotaRequestRequest): Promise<runtime.ApiResponse<ChangeSiteQuotaRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeSiteQuotaRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesitequota/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteQuotaRequestFromJSON(jsonValue));
    }

    /**
     * get change site quota request
     */
    async getChangeSiteQuotaRequest(requestParameters: GetChangeSiteQuotaRequestRequest): Promise<ChangeSiteQuotaRequest> {
        const response = await this.getChangeSiteQuotaRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change site settings request
     */
    async getChangeSiteSettingRequestRaw(requestParameters: GetChangeSiteSettingRequestRequest): Promise<runtime.ApiResponse<ChangeSiteSettingRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeSiteSettingRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesite/setting/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteSettingRequestFromJSON(jsonValue));
    }

    /**
     * get change site settings request
     */
    async getChangeSiteSettingRequest(requestParameters: GetChangeSiteSettingRequestRequest): Promise<ChangeSiteSettingRequest> {
        const response = await this.getChangeSiteSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change web contact request
     */
    async getChangeWebContactRequestRaw(requestParameters: GetChangeWebContactRequestRequest): Promise<runtime.ApiResponse<ChangeWebContactRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeWebContactRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changewebcontact/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeWebContactRequestFromJSON(jsonValue));
    }

    /**
     * get change web contact request
     */
    async getChangeWebContactRequest(requestParameters: GetChangeWebContactRequestRequest): Promise<ChangeWebContactRequest> {
        const response = await this.getChangeWebContactRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change web settings request
     */
    async getChangeWebSettingRequestRaw(requestParameters: GetChangeWebSettingRequestRequest): Promise<runtime.ApiResponse<ChangeWebSettingRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeWebSettingRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changewebsettings/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeWebSettingRequestFromJSON(jsonValue));
    }

    /**
     * get change web settings request
     */
    async getChangeWebSettingRequest(requestParameters: GetChangeWebSettingRequestRequest): Promise<ChangeWebSettingRequest> {
        const response = await this.getChangeWebSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get clone permission request
     */
    async getClonePermissionRequestRaw(requestParameters: GetClonePermissionRequestRequest): Promise<runtime.ApiResponse<ClonePermissionRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getClonePermissionRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/clonepermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ClonePermissionRequestFromJSON(jsonValue));
    }

    /**
     * get clone permission request
     */
    async getClonePermissionRequest(requestParameters: GetClonePermissionRequestRequest): Promise<ClonePermissionRequest> {
        const response = await this.getClonePermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get content move request
     */
    async getContentMoveRequestRaw(requestParameters: GetContentMoveRequestRequest): Promise<runtime.ApiResponse<ContentMoveRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getContentMoveRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/contentmove/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ContentMoveRequestFromJSON(jsonValue));
    }

    /**
     * get content move request
     */
    async getContentMoveRequest(requestParameters: GetContentMoveRequestRequest): Promise<ContentMoveRequest> {
        const response = await this.getContentMoveRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create group request
     */
    async getCreateGroupRequestRaw(requestParameters: GetCreateGroupRequestRequest): Promise<runtime.ApiResponse<CreateGroupRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateGroupRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/creategroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateGroupRequestFromJSON(jsonValue));
    }

    /**
     * get create group request
     */
    async getCreateGroupRequest(requestParameters: GetCreateGroupRequestRequest): Promise<CreateGroupRequest> {
        const response = await this.getCreateGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create guest user request
     */
    async getCreateGuestUserRequestRaw(requestParameters: GetCreateGuestUserRequestRequest): Promise<runtime.ApiResponse<CreateGuestUserRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateGuestUserRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createguestuser/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateGuestUserRequestFromJSON(jsonValue));
    }

    /**
     * get create guest user request
     */
    async getCreateGuestUserRequest(requestParameters: GetCreateGuestUserRequestRequest): Promise<CreateGuestUserRequest> {
        const response = await this.getCreateGuestUserRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create list request
     */
    async getCreateListRequestRaw(requestParameters: GetCreateListRequestRequest): Promise<runtime.ApiResponse<CreateListRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateListRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createlist/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateListRequestFromJSON(jsonValue));
    }

    /**
     * get create list request
     */
    async getCreateListRequest(requestParameters: GetCreateListRequestRequest): Promise<CreateListRequest> {
        const response = await this.getCreateListRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create site request
     */
    async getCreateSiteRequestRaw(requestParameters: GetCreateSiteRequestRequest): Promise<runtime.ApiResponse<CreateSiteRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateSiteRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createsite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateSiteRequestFromJSON(jsonValue));
    }

    /**
     * get create site request
     */
    async getCreateSiteRequest(requestParameters: GetCreateSiteRequestRequest): Promise<CreateSiteRequest> {
        const response = await this.getCreateSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create web request
     */
    async getCreateWebRequestRaw(requestParameters: GetCreateWebRequestRequest): Promise<runtime.ApiResponse<CreateWebRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateWebRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createweb/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateWebRequestFromJSON(jsonValue));
    }

    /**
     * get create web request
     */
    async getCreateWebRequest(requestParameters: GetCreateWebRequestRequest): Promise<CreateWebRequest> {
        const response = await this.getCreateWebRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get custom service request
     */
    async getCustomRequestRaw(requestParameters: GetCustomRequestRequest): Promise<runtime.ApiResponse<ApiRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCustomRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/custom/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiRequestFromJSON(jsonValue));
    }

    /**
     * get custom service request
     */
    async getCustomRequest(requestParameters: GetCustomRequestRequest): Promise<ApiRequest> {
        const response = await this.getCustomRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get delete group request
     */
    async getDeleteGroupRequestRaw(requestParameters: GetDeleteGroupRequestRequest): Promise<runtime.ApiResponse<DeleteGroupRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getDeleteGroupRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/deletegroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => DeleteGroupRequestFromJSON(jsonValue));
    }

    /**
     * get delete group request
     */
    async getDeleteGroupRequest(requestParameters: GetDeleteGroupRequestRequest): Promise<DeleteGroupRequest> {
        const response = await this.getDeleteGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get delete site request
     */
    async getDeleteSiteRequestRaw(requestParameters: GetDeleteSiteRequestRequest): Promise<runtime.ApiResponse<DeleteSiteRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getDeleteSiteRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/deletesite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => DeleteSiteRequestFromJSON(jsonValue));
    }

    /**
     * get delete site request
     */
    async getDeleteSiteRequest(requestParameters: GetDeleteSiteRequestRequest): Promise<DeleteSiteRequest> {
        const response = await this.getDeleteSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get delete web request
     */
    async getDeleteWebRequestRaw(requestParameters: GetDeleteWebRequestRequest): Promise<runtime.ApiResponse<DeleteWebLifecycleRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getDeleteWebRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/deleteweb/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => DeleteWebLifecycleRequestFromJSON(jsonValue));
    }

    /**
     * get delete web request
     */
    async getDeleteWebRequest(requestParameters: GetDeleteWebRequestRequest): Promise<DeleteWebLifecycleRequest> {
        const response = await this.getDeleteWebRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get extend group request
     */
    async getExtendGroupRequestRaw(requestParameters: GetExtendGroupRequestRequest): Promise<runtime.ApiResponse<ExtendGroupRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getExtendGroupRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/extendgroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ExtendGroupRequestFromJSON(jsonValue));
    }

    /**
     * get extend group request
     */
    async getExtendGroupRequest(requestParameters: GetExtendGroupRequestRequest): Promise<ExtendGroupRequest> {
        const response = await this.getExtendGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get extend site request
     */
    async getExtendSiteRequestRaw(requestParameters: GetExtendSiteRequestRequest): Promise<runtime.ApiResponse<ExtendSiteRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getExtendSiteRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/extendsite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ExtendSiteRequestFromJSON(jsonValue));
    }

    /**
     * get extend site request
     */
    async getExtendSiteRequest(requestParameters: GetExtendSiteRequestRequest): Promise<ExtendSiteRequest> {
        const response = await this.getExtendSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get grant permission request
     */
    async getGrantPermissionRequestRaw(requestParameters: GetGrantPermissionRequestRequest): Promise<runtime.ApiResponse<GrantPermissionRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getGrantPermissionRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/grantpermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => GrantPermissionRequestFromJSON(jsonValue));
    }

    /**
     * get grant permission request
     */
    async getGrantPermissionRequest(requestParameters: GetGrantPermissionRequestRequest): Promise<GrantPermissionRequest> {
        const response = await this.getGrantPermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get lock site request
     */
    async getLockSiteReuqestRaw(requestParameters: GetLockSiteReuqestRequest): Promise<runtime.ApiResponse<LockSiteRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getLockSiteReuqest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/locksite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => LockSiteRequestFromJSON(jsonValue));
    }

    /**
     * get lock site request
     */
    async getLockSiteReuqest(requestParameters: GetLockSiteReuqestRequest): Promise<LockSiteRequest> {
        const response = await this.getLockSiteReuqestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get manage permission request
     */
    async getManagePermissionRequestRaw(requestParameters: GetManagePermissionRequestRequest): Promise<runtime.ApiResponse<ManagePermissionRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getManagePermissionRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/managepermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ManagePermissionRequestFromJSON(jsonValue));
    }

    /**
     * get manage permission request
     */
    async getManagePermissionRequest(requestParameters: GetManagePermissionRequestRequest): Promise<ManagePermissionRequest> {
        const response = await this.getManagePermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get my requests
     */
    async getMyRequestsRaw(requestParameters: GetMyRequestsRequest): Promise<runtime.ApiResponse<RequestListPageResult>> {
        const queryParameters: any = {};

        if (requestParameters.filter !== undefined) {
            queryParameters['filter'] = requestParameters.filter;
        }

        if (requestParameters.orderby !== undefined) {
            queryParameters['orderby'] = requestParameters.orderby;
        }

        if (requestParameters.search !== undefined) {
            queryParameters['search'] = requestParameters.search;
        }

        if (requestParameters.top !== undefined) {
            queryParameters['top'] = requestParameters.top;
        }

        if (requestParameters.skip !== undefined) {
            queryParameters['skip'] = requestParameters.skip;
        }

        if (requestParameters.nexttoken !== undefined) {
            queryParameters['nexttoken'] = requestParameters.nexttoken;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/my`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => RequestListPageResultFromJSON(jsonValue));
    }

    /**
     * get my requests
     */
    async getMyRequests(requestParameters: GetMyRequestsRequest): Promise<RequestListPageResult> {
        const response = await this.getMyRequestsRaw(requestParameters);
        return await response.value();
    }

    /**
     * get request by id
     */
    async getRequestByIdRaw(requestParameters: GetRequestByIdRequest): Promise<runtime.ApiResponse<ApiRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getRequestById.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiRequestFromJSON(jsonValue));
    }

    /**
     * get request by id
     */
    async getRequestById(requestParameters: GetRequestByIdRequest): Promise<ApiRequest> {
        const response = await this.getRequestByIdRaw(requestParameters);
        return await response.value();
    }

    /**
     * get restore group request
     */
    async getRestoreGroupRequestRaw(requestParameters: GetRestoreGroupRequestRequest): Promise<runtime.ApiResponse<RestoreGroupRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getRestoreGroupRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/restoregroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => RestoreGroupRequestFromJSON(jsonValue));
    }

    /**
     * get restore group request
     */
    async getRestoreGroupRequest(requestParameters: GetRestoreGroupRequestRequest): Promise<RestoreGroupRequest> {
        const response = await this.getRestoreGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site lifecycel request
     */
    async getSiteCollectionLifecycleRequestRaw(requestParameters: GetSiteCollectionLifecycleRequestRequest): Promise<runtime.ApiResponse<SiteLifecycleRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getSiteCollectionLifecycleRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/sitelifecycle/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => SiteLifecycleRequestFromJSON(jsonValue));
    }

    /**
     * get site lifecycel request
     */
    async getSiteCollectionLifecycleRequest(requestParameters: GetSiteCollectionLifecycleRequestRequest): Promise<SiteLifecycleRequest> {
        const response = await this.getSiteCollectionLifecycleRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get task by request id
     */
    async getTasksRaw(requestParameters: GetTasksRequest): Promise<runtime.ApiResponse<Array<ApiTask>>> {
        if (requestParameters.requestid === null || requestParameters.requestid === undefined) {
            throw new runtime.RequiredError('requestid','Required parameter requestParameters.requestid was null or undefined when calling getTasks.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/{requestid}/tasks`.replace(`{${"requestid"}}`, encodeURIComponent(String(requestParameters.requestid))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(ApiTaskFromJSON));
    }

    /**
     * get task by request id
     */
    async getTasks(requestParameters: GetTasksRequest): Promise<Array<ApiTask>> {
        const response = await this.getTasksRaw(requestParameters);
        return await response.value();
    }

    /**
     * get unlock site request
     */
    async getUnlockSiteRequestRaw(requestParameters: GetUnlockSiteRequestRequest): Promise<runtime.ApiResponse<UnlockSiteRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getUnlockSiteRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/unlocksite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => UnlockSiteRequestFromJSON(jsonValue));
    }

    /**
     * get unlock site request
     */
    async getUnlockSiteRequest(requestParameters: GetUnlockSiteRequestRequest): Promise<UnlockSiteRequest> {
        const response = await this.getUnlockSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * check url exists in pending requests.
     */
    async isUrlExistsInPendingRequestsRaw(requestParameters: IsUrlExistsInPendingRequestsRequest): Promise<runtime.ApiResponse<boolean>> {
        if (requestParameters.url === null || requestParameters.url === undefined) {
            throw new runtime.RequiredError('url','Required parameter requestParameters.url was null or undefined when calling isUrlExistsInPendingRequests.');
        }

        const queryParameters: any = {};

        if (requestParameters.url !== undefined) {
            queryParameters['url'] = requestParameters.url;
        }

        if (requestParameters.requestId !== undefined) {
            queryParameters['requestId'] = requestParameters.requestId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/isUrlExistInPendingRequests`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * check url exists in pending requests.
     */
    async isUrlExistsInPendingRequests(requestParameters: IsUrlExistsInPendingRequestsRequest): Promise<boolean> {
        const response = await this.isUrlExistsInPendingRequestsRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit archive group group request
     */
    async submitArchiveGroupRequestRaw(requestParameters: SubmitArchiveGroupRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/archivegroup`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveGroupRequestToJSON(requestParameters.archiveGroupRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit archive group group request
     */
    async submitArchiveGroupRequest(requestParameters: SubmitArchiveGroupRequestRequest): Promise<string> {
        const response = await this.submitArchiveGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit archive site request
     */
    async submitArchiveSiteRequestRaw(requestParameters: SubmitArchiveSiteRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/archivesite`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveSiteRequestToJSON(requestParameters.archiveSiteRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit archive site request
     */
    async submitArchiveSiteRequest(requestParameters: SubmitArchiveSiteRequestRequest): Promise<string> {
        const response = await this.submitArchiveSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit archive web request
     */
    async submitArchiveWebRequestRaw(requestParameters: SubmitArchiveWebRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/archiveweb`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveWebLifecycleRequestToJSON(requestParameters.archiveWebLifecycleRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit archive web request
     */
    async submitArchiveWebRequest(requestParameters: SubmitArchiveWebRequestRequest): Promise<string> {
        const response = await this.submitArchiveWebRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change group policy request
     */
    async submitChangeGroupPolicyRequestRaw(requestParameters: SubmitChangeGroupPolicyRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changegrouppolicy`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupPolicyRequestToJSON(requestParameters.changeGroupPolicyRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change group policy request
     */
    async submitChangeGroupPolicyRequest(requestParameters: SubmitChangeGroupPolicyRequestRequest): Promise<string> {
        const response = await this.submitChangeGroupPolicyRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change group quota request
     */
    async submitChangeGroupQuotaRequestRaw(requestParameters: SubmitChangeGroupQuotaRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changegroupquota`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupQuotaRequestToJSON(requestParameters.changeGroupQuotaRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change group quota request
     */
    async submitChangeGroupQuotaRequest(requestParameters: SubmitChangeGroupQuotaRequestRequest): Promise<string> {
        const response = await this.submitChangeGroupQuotaRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change group settings request
     */
    async submitChangeGroupSettingRequestRaw(requestParameters: SubmitChangeGroupSettingRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changegroup`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupSettingRequestToJSON(requestParameters.changeGroupSettingRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change group settings request
     */
    async submitChangeGroupSettingRequest(requestParameters: SubmitChangeGroupSettingRequestRequest): Promise<string> {
        const response = await this.submitChangeGroupSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change list settings request
     */
    async submitChangeListSettingRequestRaw(requestParameters: SubmitChangeListSettingRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changelistsetting`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeListSettingRequestToJSON(requestParameters.changeListSettingRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change list settings request
     */
    async submitChangeListSettingRequest(requestParameters: SubmitChangeListSettingRequestRequest): Promise<string> {
        const response = await this.submitChangeListSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change permission request
     */
    async submitChangePermissionRequestRaw(requestParameters: SubmitChangePermissionRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changepermission`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangePermissionRequestToJSON(requestParameters.changePermissionRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change permission request
     */
    async submitChangePermissionRequest(requestParameters: SubmitChangePermissionRequestRequest): Promise<string> {
        const response = await this.submitChangePermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change site administrator or contact request
     */
    async submitChangeSiteContactRequestRaw(requestParameters: SubmitChangeSiteContactRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesite/adminorcontact`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSiteContactRequestToJSON(requestParameters.changeSiteContactRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change site administrator or contact request
     */
    async submitChangeSiteContactRequest(requestParameters: SubmitChangeSiteContactRequestRequest): Promise<string> {
        const response = await this.submitChangeSiteContactRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change site policy request
     */
    async submitChangeSitePolicyRequestRaw(requestParameters: SubmitChangeSitePolicyRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesitepolicy`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSitePolicyRequestToJSON(requestParameters.changeSitePolicyRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change site policy request
     */
    async submitChangeSitePolicyRequest(requestParameters: SubmitChangeSitePolicyRequestRequest): Promise<string> {
        const response = await this.submitChangeSitePolicyRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change site quota request
     */
    async submitChangeSiteQuotaRequestRaw(requestParameters: SubmitChangeSiteQuotaRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesitequota`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSiteQuotaRequestToJSON(requestParameters.changeSiteQuotaRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change site quota request
     */
    async submitChangeSiteQuotaRequest(requestParameters: SubmitChangeSiteQuotaRequestRequest): Promise<string> {
        const response = await this.submitChangeSiteQuotaRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change site settings request
     */
    async submitChangeSiteSettingRequestRaw(requestParameters: SubmitChangeSiteSettingRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changesite/setting`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSiteSettingRequestToJSON(requestParameters.changeSiteSettingRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change site settings request
     */
    async submitChangeSiteSettingRequest(requestParameters: SubmitChangeSiteSettingRequestRequest): Promise<string> {
        const response = await this.submitChangeSiteSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change web contact request
     */
    async submitChangeWebContactRequestRaw(requestParameters: SubmitChangeWebContactRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changewebcontact`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeWebContactRequestToJSON(requestParameters.changeWebContactRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change web contact request
     */
    async submitChangeWebContactRequest(requestParameters: SubmitChangeWebContactRequestRequest): Promise<string> {
        const response = await this.submitChangeWebContactRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit change web settings request
     */
    async submitChangeWebSettingRequestRaw(requestParameters: SubmitChangeWebSettingRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/changewebsettings`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeWebSettingRequestToJSON(requestParameters.changeWebSettingRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit change web settings request
     */
    async submitChangeWebSettingRequest(requestParameters: SubmitChangeWebSettingRequestRequest): Promise<string> {
        const response = await this.submitChangeWebSettingRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get clone permission request
     */
    async submitClonePermissionRequestRaw(requestParameters: SubmitClonePermissionRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/clonepermission`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ClonePermissionRequestToJSON(requestParameters.clonePermissionRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * get clone permission request
     */
    async submitClonePermissionRequest(requestParameters: SubmitClonePermissionRequestRequest): Promise<string> {
        const response = await this.submitClonePermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit create content move request
     */
    async submitContentMoveRequestRaw(requestParameters: SubmitContentMoveRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/contentmove`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ContentMoveRequestToJSON(requestParameters.contentMoveRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit create content move request
     */
    async submitContentMoveRequest(requestParameters: SubmitContentMoveRequestRequest): Promise<string> {
        const response = await this.submitContentMoveRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit create group request
     */
    async submitCreateGroupRequestRaw(requestParameters: SubmitCreateGroupRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/creategroup`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateGroupRequestToJSON(requestParameters.createGroupRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit create group request
     */
    async submitCreateGroupRequest(requestParameters: SubmitCreateGroupRequestRequest): Promise<string> {
        const response = await this.submitCreateGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit create guest user request
     */
    async submitCreateGuestUserRequestRaw(requestParameters: SubmitCreateGuestUserRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createguestuser`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateGuestUserRequestToJSON(requestParameters.createGuestUserRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit create guest user request
     */
    async submitCreateGuestUserRequest(requestParameters: SubmitCreateGuestUserRequestRequest): Promise<string> {
        const response = await this.submitCreateGuestUserRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit create list request
     */
    async submitCreateListRequestRaw(requestParameters: SubmitCreateListRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createlist`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateListRequestToJSON(requestParameters.createListRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit create list request
     */
    async submitCreateListRequest(requestParameters: SubmitCreateListRequestRequest): Promise<string> {
        const response = await this.submitCreateListRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit create site collection request
     */
    async submitCreateSiteRequestRaw(requestParameters: SubmitCreateSiteRequestRequest): Promise<runtime.ApiResponse<string>> {
        if (requestParameters.createSiteRequest === null || requestParameters.createSiteRequest === undefined) {
            throw new runtime.RequiredError('createSiteRequest','Required parameter requestParameters.createSiteRequest was null or undefined when calling submitCreateSiteRequest.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createsite`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateSiteRequestToJSON(requestParameters.createSiteRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit create site collection request
     */
    async submitCreateSiteRequest(requestParameters: SubmitCreateSiteRequestRequest): Promise<string> {
        const response = await this.submitCreateSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit create web request
     */
    async submitCreateWebRequestRaw(requestParameters: SubmitCreateWebRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/createweb`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateWebRequestToJSON(requestParameters.createWebRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit create web request
     */
    async submitCreateWebRequest(requestParameters: SubmitCreateWebRequestRequest): Promise<string> {
        const response = await this.submitCreateWebRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit custom service request
     */
    async submitCustomRequestRaw(requestParameters: SubmitCustomRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/custom`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ApiRequestToJSON(requestParameters.apiRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit custom service request
     */
    async submitCustomRequest(requestParameters: SubmitCustomRequestRequest): Promise<string> {
        const response = await this.submitCustomRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit delete group request
     */
    async submitDeleteGroupRequestRaw(requestParameters: SubmitDeleteGroupRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/deletegroup`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: DeleteGroupRequestToJSON(requestParameters.deleteGroupRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit delete group request
     */
    async submitDeleteGroupRequest(requestParameters: SubmitDeleteGroupRequestRequest): Promise<string> {
        const response = await this.submitDeleteGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit delete site request
     */
    async submitDeleteSiteRequestRaw(requestParameters: SubmitDeleteSiteRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/deletesite`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: DeleteSiteRequestToJSON(requestParameters.deleteSiteRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit delete site request
     */
    async submitDeleteSiteRequest(requestParameters: SubmitDeleteSiteRequestRequest): Promise<string> {
        const response = await this.submitDeleteSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit delete web request
     */
    async submitDeleteWebRequestRaw(requestParameters: SubmitDeleteWebRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/deleteweb`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: DeleteWebLifecycleRequestToJSON(requestParameters.deleteWebLifecycleRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit delete web request
     */
    async submitDeleteWebRequest(requestParameters: SubmitDeleteWebRequestRequest): Promise<string> {
        const response = await this.submitDeleteWebRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit extend group request
     */
    async submitExtendGroupRequestRaw(requestParameters: SubmitExtendGroupRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/extendgroup`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ExtendGroupRequestToJSON(requestParameters.extendGroupRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit extend group request
     */
    async submitExtendGroupRequest(requestParameters: SubmitExtendGroupRequestRequest): Promise<string> {
        const response = await this.submitExtendGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit extend site request
     */
    async submitExtendSiteRequestRaw(requestParameters: SubmitExtendSiteRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/extendsite`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ExtendSiteRequestToJSON(requestParameters.extendSiteRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit extend site request
     */
    async submitExtendSiteRequest(requestParameters: SubmitExtendSiteRequestRequest): Promise<string> {
        const response = await this.submitExtendSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * get submit grant permission request
     */
    async submitGrantPermissionRequestRaw(requestParameters: SubmitGrantPermissionRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/grantpermission`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: GrantPermissionRequestToJSON(requestParameters.grantPermissionRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * get submit grant permission request
     */
    async submitGrantPermissionRequest(requestParameters: SubmitGrantPermissionRequestRequest): Promise<string> {
        const response = await this.submitGrantPermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit lock site request
     */
    async submitLockSiteRequestRaw(requestParameters: SubmitLockSiteRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/locksite`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: LockSiteRequestToJSON(requestParameters.lockSiteRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit lock site request
     */
    async submitLockSiteRequest(requestParameters: SubmitLockSiteRequestRequest): Promise<string> {
        const response = await this.submitLockSiteRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit manage permission request
     */
    async submitManagePermissionRequestRaw(requestParameters: SubmitManagePermissionRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/managepermission`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ManagePermissionRequestToJSON(requestParameters.managePermissionRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit manage permission request
     */
    async submitManagePermissionRequest(requestParameters: SubmitManagePermissionRequestRequest): Promise<string> {
        const response = await this.submitManagePermissionRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit restore group request
     */
    async submitRestoreGroupRequestRaw(requestParameters: SubmitRestoreGroupRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/restoregroup`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: RestoreGroupRequestToJSON(requestParameters.restoreGroupRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit restore group request
     */
    async submitRestoreGroupRequest(requestParameters: SubmitRestoreGroupRequestRequest): Promise<string> {
        const response = await this.submitRestoreGroupRequestRaw(requestParameters);
        return await response.value();
    }

    /**
     * submit unlock site request
     */
    async submitUnlockSiteRequestRaw(requestParameters: SubmitUnlockSiteRequestRequest): Promise<runtime.ApiResponse<string>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/requests/unlocksite`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: UnlockSiteRequestToJSON(requestParameters.unlockSiteRequest),
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * submit unlock site request
     */
    async submitUnlockSiteRequest(requestParameters: SubmitUnlockSiteRequestRequest): Promise<string> {
        const response = await this.submitUnlockSiteRequestRaw(requestParameters);
        return await response.value();
    }

}
