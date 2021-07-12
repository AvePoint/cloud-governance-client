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
    CommentsParam,
    CommentsParamFromJSON,
    CommentsParamToJSON,
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
    RestoreGroupRequest,
    RestoreGroupRequestFromJSON,
    RestoreGroupRequestToJSON,
    TaskApprovalStatus,
    TaskApprovalStatusFromJSON,
    TaskApprovalStatusToJSON,
    TaskList,
    TaskListFromJSON,
    TaskListToJSON,
    TaskListPageResult,
    TaskListPageResultFromJSON,
    TaskListPageResultToJSON,
    UnlockSiteRequest,
    UnlockSiteRequestFromJSON,
    UnlockSiteRequestToJSON,
} from '../models';

export interface ApproveTaskRequest {
    id: string;
    commentsParam?: CommentsParam;
}

export interface EditArchiveGroupRequestRequest {
    id: string;
    archiveGroupRequest?: ArchiveGroupRequest;
}

export interface EditArchiveSiteRequestRequest {
    id: string;
    archiveSiteRequest?: ArchiveSiteRequest;
}

export interface EditArchiveWebRequestRequest {
    id: string;
    archiveWebLifecycleRequest?: ArchiveWebLifecycleRequest;
}

export interface EditChangeGroupPolicyRequestRequest {
    id: string;
    changeGroupPolicyRequest?: ChangeGroupPolicyRequest;
}

export interface EditChangeGroupQuotaRequestRequest {
    id: string;
    changeGroupQuotaRequest?: ChangeGroupQuotaRequest;
}

export interface EditChangeGroupRequestRequest {
    id: string;
    changeGroupSettingRequest?: ChangeGroupSettingRequest;
}

export interface EditChangeListSettingRequestRequest {
    id: string;
    changeListSettingRequest?: ChangeListSettingRequest;
}

export interface EditChangePermissionRequestRequest {
    id: string;
    changePermissionRequest?: ChangePermissionRequest;
}

export interface EditChangeSiteContactRequestRequest {
    id: string;
    changeSiteContactRequest?: ChangeSiteContactRequest;
}

export interface EditChangeSitePolicyRequestRequest {
    id: string;
    changeSitePolicyRequest?: ChangeSitePolicyRequest;
}

export interface EditChangeSiteQuotaRequestRequest {
    id: string;
    changeSiteQuotaRequest?: ChangeSiteQuotaRequest;
}

export interface EditChangeSiteSettingRequestRequest {
    id: string;
    changeSiteSettingRequest?: ChangeSiteSettingRequest;
}

export interface EditChangeWebContactRequestRequest {
    id: string;
    changeWebContactRequest?: ChangeWebContactRequest;
}

export interface EditChangeWebSettingRequestRequest {
    id: string;
    changeWebSettingRequest?: ChangeWebSettingRequest;
}

export interface EditClonePermissionRequestRequest {
    id: string;
    clonePermissionRequest?: ClonePermissionRequest;
}

export interface EditContentMoveRequestRequest {
    id: string;
    contentMoveRequest?: ContentMoveRequest;
}

export interface EditCreateGroupRequestRequest {
    id: string;
    createGroupRequest?: CreateGroupRequest;
}

export interface EditCreateGuestUserRequestRequest {
    id: string;
    createGuestUserRequest?: CreateGuestUserRequest;
}

export interface EditCreateListRequestRequest {
    id: string;
    createListRequest?: CreateListRequest;
}

export interface EditCreateSiteRequestRequest {
    id: string;
    createSiteRequest?: CreateSiteRequest;
}

export interface EditCreateWebRequestRequest {
    id: string;
    createWebRequest?: CreateWebRequest;
}

export interface EditCustomRequestRequest {
    id: string;
    apiRequest?: ApiRequest;
}

export interface EditDeleteGroupRequestRequest {
    id: string;
    deleteGroupRequest?: DeleteGroupRequest;
}

export interface EditDeleteSiteRequestRequest {
    id: string;
    deleteSiteRequest?: DeleteSiteRequest;
}

export interface EditDeleteWebRequestRequest {
    id: string;
    deleteWebLifecycleRequest?: DeleteWebLifecycleRequest;
}

export interface EditExtendGroupRequestRequest {
    id: string;
    extendGroupRequest?: ExtendGroupRequest;
}

export interface EditExtendSiteRequestRequest {
    id: string;
    extendSiteRequest?: ExtendSiteRequest;
}

export interface EditGrantPermissionRequestRequest {
    id: string;
    grantPermissionRequest?: GrantPermissionRequest;
}

export interface EditLockSiteRequestRequest {
    id: string;
    lockSiteRequest?: LockSiteRequest;
}

export interface EditManagePermissionRequestRequest {
    id: string;
    managePermissionRequest?: ManagePermissionRequest;
}

export interface EditRestoreGroupRequestRequest {
    id: string;
    restoreGroupRequest?: RestoreGroupRequest;
}

export interface EditUnLockSiteRequestRequest {
    id: string;
    unlockSiteRequest?: UnlockSiteRequest;
}

export interface GetBatchTasksByIdRequest {
    id: string;
}

export interface GetMyTasksRequest {
    taskApprovalStatus: TaskApprovalStatus;
    filter?: string | null;
    orderby?: string | null;
    search?: string | null;
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

export interface GetTaskByBatchIdRequest {
    batchid: string;
}

export interface GetTaskByIdRequest {
    id: string;
}

export interface ReassignTaskRequest {
    id: string;
    user: string;
}

export interface RejectTaskRequest {
    id: string;
    commentsParam?: CommentsParam;
}

export interface RetryErrorTaskRequest {
    id: string;
    commentsParam?: CommentsParam;
}

export interface SkipErrorTaskRequest {
    id: string;
    commentsParam?: CommentsParam;
}

/**
 * 
 */
export class TasksApi extends runtime.BaseAPI {

    /**
     * approve task
     */
    async approveTaskRaw(requestParameters: ApproveTaskRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling approveTask.');
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
            path: `/tasks/{id}/approve`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CommentsParamToJSON(requestParameters.commentsParam),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * approve task
     */
    async approveTask(requestParameters: ApproveTaskRequest): Promise<void> {
        await this.approveTaskRaw(requestParameters);
    }

    /**
     * edit archive group request in task
     */
    async editArchiveGroupRequestRaw(requestParameters: EditArchiveGroupRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editArchiveGroupRequest.');
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
            path: `/tasks/{id}/archivegroup`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveGroupRequestToJSON(requestParameters.archiveGroupRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit archive group request in task
     */
    async editArchiveGroupRequest(requestParameters: EditArchiveGroupRequestRequest): Promise<void> {
        await this.editArchiveGroupRequestRaw(requestParameters);
    }

    /**
     * edit archive site request in task
     */
    async editArchiveSiteRequestRaw(requestParameters: EditArchiveSiteRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editArchiveSiteRequest.');
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
            path: `/tasks/{id}/archivesite`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveSiteRequestToJSON(requestParameters.archiveSiteRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit archive site request in task
     */
    async editArchiveSiteRequest(requestParameters: EditArchiveSiteRequestRequest): Promise<void> {
        await this.editArchiveSiteRequestRaw(requestParameters);
    }

    /**
     * edit archive web request in task
     */
    async editArchiveWebRequestRaw(requestParameters: EditArchiveWebRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editArchiveWebRequest.');
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
            path: `/tasks/{id}/archiveweb`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveWebLifecycleRequestToJSON(requestParameters.archiveWebLifecycleRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit archive web request in task
     */
    async editArchiveWebRequest(requestParameters: EditArchiveWebRequestRequest): Promise<void> {
        await this.editArchiveWebRequestRaw(requestParameters);
    }

    /**
     * edit change group policy request in task
     */
    async editChangeGroupPolicyRequestRaw(requestParameters: EditChangeGroupPolicyRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeGroupPolicyRequest.');
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
            path: `/tasks/{id}/changegrouppolicy`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupPolicyRequestToJSON(requestParameters.changeGroupPolicyRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change group policy request in task
     */
    async editChangeGroupPolicyRequest(requestParameters: EditChangeGroupPolicyRequestRequest): Promise<void> {
        await this.editChangeGroupPolicyRequestRaw(requestParameters);
    }

    /**
     * edit change group quota request in task
     */
    async editChangeGroupQuotaRequestRaw(requestParameters: EditChangeGroupQuotaRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeGroupQuotaRequest.');
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
            path: `/tasks/{id}/changegroupquota`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupQuotaRequestToJSON(requestParameters.changeGroupQuotaRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change group quota request in task
     */
    async editChangeGroupQuotaRequest(requestParameters: EditChangeGroupQuotaRequestRequest): Promise<void> {
        await this.editChangeGroupQuotaRequestRaw(requestParameters);
    }

    /**
     * edit create change group request
     */
    async editChangeGroupRequestRaw(requestParameters: EditChangeGroupRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeGroupRequest.');
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
            path: `/tasks/{id}/changegroup`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupSettingRequestToJSON(requestParameters.changeGroupSettingRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit create change group request
     */
    async editChangeGroupRequest(requestParameters: EditChangeGroupRequestRequest): Promise<void> {
        await this.editChangeGroupRequestRaw(requestParameters);
    }

    /**
     * edit change list setting request in task
     */
    async editChangeListSettingRequestRaw(requestParameters: EditChangeListSettingRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeListSettingRequest.');
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
            path: `/tasks/{id}/changelistsetting`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeListSettingRequestToJSON(requestParameters.changeListSettingRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change list setting request in task
     */
    async editChangeListSettingRequest(requestParameters: EditChangeListSettingRequestRequest): Promise<void> {
        await this.editChangeListSettingRequestRaw(requestParameters);
    }

    /**
     * edit change permission request in task
     */
    async editChangePermissionRequestRaw(requestParameters: EditChangePermissionRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangePermissionRequest.');
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
            path: `/tasks/{id}/changepermission`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangePermissionRequestToJSON(requestParameters.changePermissionRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change permission request in task
     */
    async editChangePermissionRequest(requestParameters: EditChangePermissionRequestRequest): Promise<void> {
        await this.editChangePermissionRequestRaw(requestParameters);
    }

    /**
     * edit change site administrator/contact request
     */
    async editChangeSiteContactRequestRaw(requestParameters: EditChangeSiteContactRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeSiteContactRequest.');
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
            path: `/tasks/{id}/changesite/adminorcontact`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSiteContactRequestToJSON(requestParameters.changeSiteContactRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change site administrator/contact request
     */
    async editChangeSiteContactRequest(requestParameters: EditChangeSiteContactRequestRequest): Promise<void> {
        await this.editChangeSiteContactRequestRaw(requestParameters);
    }

    /**
     * edit change site policy request in task
     */
    async editChangeSitePolicyRequestRaw(requestParameters: EditChangeSitePolicyRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeSitePolicyRequest.');
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
            path: `/tasks/{id}/changesitepolicy`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSitePolicyRequestToJSON(requestParameters.changeSitePolicyRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change site policy request in task
     */
    async editChangeSitePolicyRequest(requestParameters: EditChangeSitePolicyRequestRequest): Promise<void> {
        await this.editChangeSitePolicyRequestRaw(requestParameters);
    }

    /**
     * edit change site quota request in task
     */
    async editChangeSiteQuotaRequestRaw(requestParameters: EditChangeSiteQuotaRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeSiteQuotaRequest.');
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
            path: `/tasks/{id}/changesitequota`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSiteQuotaRequestToJSON(requestParameters.changeSiteQuotaRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change site quota request in task
     */
    async editChangeSiteQuotaRequest(requestParameters: EditChangeSiteQuotaRequestRequest): Promise<void> {
        await this.editChangeSiteQuotaRequestRaw(requestParameters);
    }

    /**
     * edit change site setting request
     */
    async editChangeSiteSettingRequestRaw(requestParameters: EditChangeSiteSettingRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeSiteSettingRequest.');
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
            path: `/tasks/{id}/changesite/setting`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeSiteSettingRequestToJSON(requestParameters.changeSiteSettingRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change site setting request
     */
    async editChangeSiteSettingRequest(requestParameters: EditChangeSiteSettingRequestRequest): Promise<void> {
        await this.editChangeSiteSettingRequestRaw(requestParameters);
    }

    /**
     * edit change web contact request in task
     */
    async editChangeWebContactRequestRaw(requestParameters: EditChangeWebContactRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeWebContactRequest.');
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
            path: `/tasks/{id}/changewebcontact`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeWebContactRequestToJSON(requestParameters.changeWebContactRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change web contact request in task
     */
    async editChangeWebContactRequest(requestParameters: EditChangeWebContactRequestRequest): Promise<void> {
        await this.editChangeWebContactRequestRaw(requestParameters);
    }

    /**
     * edit change web setting request in task
     */
    async editChangeWebSettingRequestRaw(requestParameters: EditChangeWebSettingRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editChangeWebSettingRequest.');
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
            path: `/tasks/{id}/changewebsettings`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeWebSettingRequestToJSON(requestParameters.changeWebSettingRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit change web setting request in task
     */
    async editChangeWebSettingRequest(requestParameters: EditChangeWebSettingRequestRequest): Promise<void> {
        await this.editChangeWebSettingRequestRaw(requestParameters);
    }

    /**
     * edit clone permission request
     */
    async editClonePermissionRequestRaw(requestParameters: EditClonePermissionRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editClonePermissionRequest.');
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
            path: `/tasks/{id}/clonepermission`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ClonePermissionRequestToJSON(requestParameters.clonePermissionRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit clone permission request
     */
    async editClonePermissionRequest(requestParameters: EditClonePermissionRequestRequest): Promise<void> {
        await this.editClonePermissionRequestRaw(requestParameters);
    }

    /**
     * edit content move request
     */
    async editContentMoveRequestRaw(requestParameters: EditContentMoveRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editContentMoveRequest.');
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
            path: `/tasks/{id}/contentmove`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ContentMoveRequestToJSON(requestParameters.contentMoveRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit content move request
     */
    async editContentMoveRequest(requestParameters: EditContentMoveRequestRequest): Promise<void> {
        await this.editContentMoveRequestRaw(requestParameters);
    }

    /**
     * edit create site group request
     */
    async editCreateGroupRequestRaw(requestParameters: EditCreateGroupRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editCreateGroupRequest.');
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
            path: `/tasks/{id}/creategroup`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: CreateGroupRequestToJSON(requestParameters.createGroupRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit create site group request
     */
    async editCreateGroupRequest(requestParameters: EditCreateGroupRequestRequest): Promise<void> {
        await this.editCreateGroupRequestRaw(requestParameters);
    }

    /**
     * edit create guest user request in task
     */
    async editCreateGuestUserRequestRaw(requestParameters: EditCreateGuestUserRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editCreateGuestUserRequest.');
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
            path: `/tasks/{id}/createguestuser`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: CreateGuestUserRequestToJSON(requestParameters.createGuestUserRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit create guest user request in task
     */
    async editCreateGuestUserRequest(requestParameters: EditCreateGuestUserRequestRequest): Promise<void> {
        await this.editCreateGuestUserRequestRaw(requestParameters);
    }

    /**
     * edit create list request in task
     */
    async editCreateListRequestRaw(requestParameters: EditCreateListRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editCreateListRequest.');
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
            path: `/tasks/{id}/createlist`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: CreateListRequestToJSON(requestParameters.createListRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit create list request in task
     */
    async editCreateListRequest(requestParameters: EditCreateListRequestRequest): Promise<void> {
        await this.editCreateListRequestRaw(requestParameters);
    }

    /**
     * edit create site request
     */
    async editCreateSiteRequestRaw(requestParameters: EditCreateSiteRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editCreateSiteRequest.');
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
            path: `/tasks/{id}/createsite`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: CreateSiteRequestToJSON(requestParameters.createSiteRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit create site request
     */
    async editCreateSiteRequest(requestParameters: EditCreateSiteRequestRequest): Promise<void> {
        await this.editCreateSiteRequestRaw(requestParameters);
    }

    /**
     * edit create web request in task
     */
    async editCreateWebRequestRaw(requestParameters: EditCreateWebRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editCreateWebRequest.');
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
            path: `/tasks/{id}/createweb`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: CreateWebRequestToJSON(requestParameters.createWebRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit create web request in task
     */
    async editCreateWebRequest(requestParameters: EditCreateWebRequestRequest): Promise<void> {
        await this.editCreateWebRequestRaw(requestParameters);
    }

    /**
     * edit custom request
     */
    async editCustomRequestRaw(requestParameters: EditCustomRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editCustomRequest.');
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
            path: `/tasks/{id}/custom`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ApiRequestToJSON(requestParameters.apiRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit custom request
     */
    async editCustomRequest(requestParameters: EditCustomRequestRequest): Promise<void> {
        await this.editCustomRequestRaw(requestParameters);
    }

    /**
     * edit delete change group request in task
     */
    async editDeleteGroupRequestRaw(requestParameters: EditDeleteGroupRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editDeleteGroupRequest.');
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
            path: `/tasks/{id}/deletegroup`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: DeleteGroupRequestToJSON(requestParameters.deleteGroupRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit delete change group request in task
     */
    async editDeleteGroupRequest(requestParameters: EditDeleteGroupRequestRequest): Promise<void> {
        await this.editDeleteGroupRequestRaw(requestParameters);
    }

    /**
     * edit delete site request in task
     */
    async editDeleteSiteRequestRaw(requestParameters: EditDeleteSiteRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editDeleteSiteRequest.');
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
            path: `/tasks/{id}/deletesite`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: DeleteSiteRequestToJSON(requestParameters.deleteSiteRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit delete site request in task
     */
    async editDeleteSiteRequest(requestParameters: EditDeleteSiteRequestRequest): Promise<void> {
        await this.editDeleteSiteRequestRaw(requestParameters);
    }

    /**
     * edit delete web request in task
     */
    async editDeleteWebRequestRaw(requestParameters: EditDeleteWebRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editDeleteWebRequest.');
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
            path: `/tasks/{id}/deleteweb`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: DeleteWebLifecycleRequestToJSON(requestParameters.deleteWebLifecycleRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit delete web request in task
     */
    async editDeleteWebRequest(requestParameters: EditDeleteWebRequestRequest): Promise<void> {
        await this.editDeleteWebRequestRaw(requestParameters);
    }

    /**
     * edit extend group request in task
     */
    async editExtendGroupRequestRaw(requestParameters: EditExtendGroupRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editExtendGroupRequest.');
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
            path: `/tasks/{id}/extendgroup`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ExtendGroupRequestToJSON(requestParameters.extendGroupRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit extend group request in task
     */
    async editExtendGroupRequest(requestParameters: EditExtendGroupRequestRequest): Promise<void> {
        await this.editExtendGroupRequestRaw(requestParameters);
    }

    /**
     * edit extend site request in task
     */
    async editExtendSiteRequestRaw(requestParameters: EditExtendSiteRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editExtendSiteRequest.');
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
            path: `/tasks/{id}/extendsite`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ExtendSiteRequestToJSON(requestParameters.extendSiteRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit extend site request in task
     */
    async editExtendSiteRequest(requestParameters: EditExtendSiteRequestRequest): Promise<void> {
        await this.editExtendSiteRequestRaw(requestParameters);
    }

    /**
     * edit grant permission request in task
     */
    async editGrantPermissionRequestRaw(requestParameters: EditGrantPermissionRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editGrantPermissionRequest.');
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
            path: `/tasks/{id}/grantpermission`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: GrantPermissionRequestToJSON(requestParameters.grantPermissionRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit grant permission request in task
     */
    async editGrantPermissionRequest(requestParameters: EditGrantPermissionRequestRequest): Promise<void> {
        await this.editGrantPermissionRequestRaw(requestParameters);
    }

    /**
     * edit lock site request
     */
    async editLockSiteRequestRaw(requestParameters: EditLockSiteRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editLockSiteRequest.');
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
            path: `/tasks/{id}/locksite`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: LockSiteRequestToJSON(requestParameters.lockSiteRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit lock site request
     */
    async editLockSiteRequest(requestParameters: EditLockSiteRequestRequest): Promise<void> {
        await this.editLockSiteRequestRaw(requestParameters);
    }

    /**
     * edit manage permission request
     */
    async editManagePermissionRequestRaw(requestParameters: EditManagePermissionRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editManagePermissionRequest.');
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
            path: `/tasks/{id}/managepermission`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: ManagePermissionRequestToJSON(requestParameters.managePermissionRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit manage permission request
     */
    async editManagePermissionRequest(requestParameters: EditManagePermissionRequestRequest): Promise<void> {
        await this.editManagePermissionRequestRaw(requestParameters);
    }

    /**
     * edit restore group request in task
     */
    async editRestoreGroupRequestRaw(requestParameters: EditRestoreGroupRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editRestoreGroupRequest.');
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
            path: `/tasks/{id}/restoregroup`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: RestoreGroupRequestToJSON(requestParameters.restoreGroupRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit restore group request in task
     */
    async editRestoreGroupRequest(requestParameters: EditRestoreGroupRequestRequest): Promise<void> {
        await this.editRestoreGroupRequestRaw(requestParameters);
    }

    /**
     * edit unlock site request
     */
    async editUnLockSiteRequestRaw(requestParameters: EditUnLockSiteRequestRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling editUnLockSiteRequest.');
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
            path: `/tasks/{id}/unlocksite`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: UnlockSiteRequestToJSON(requestParameters.unlockSiteRequest),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * edit unlock site request
     */
    async editUnLockSiteRequest(requestParameters: EditUnLockSiteRequestRequest): Promise<void> {
        await this.editUnLockSiteRequestRaw(requestParameters);
    }

    /**
     * get all batch tasks by id
     */
    async getBatchTasksByIdRaw(requestParameters: GetBatchTasksByIdRequest): Promise<runtime.ApiResponse<Array<ApiTask>>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getBatchTasksById.');
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
            path: `/tasks/{id}/batchTasks`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(ApiTaskFromJSON));
    }

    /**
     * get all batch tasks by id
     */
    async getBatchTasksById(requestParameters: GetBatchTasksByIdRequest): Promise<Array<ApiTask>> {
        const response = await this.getBatchTasksByIdRaw(requestParameters);
        return await response.value();
    }

    /**
     * get my tasks
     */
    async getMyTasksRaw(requestParameters: GetMyTasksRequest): Promise<runtime.ApiResponse<TaskListPageResult>> {
        if (requestParameters.taskApprovalStatus === null || requestParameters.taskApprovalStatus === undefined) {
            throw new runtime.RequiredError('taskApprovalStatus','Required parameter requestParameters.taskApprovalStatus was null or undefined when calling getMyTasks.');
        }

        const queryParameters: any = {};

        if (requestParameters.taskApprovalStatus !== undefined) {
            queryParameters['taskApprovalStatus'] = requestParameters.taskApprovalStatus;
        }

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
            path: `/tasks/my/v2`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => TaskListPageResultFromJSON(jsonValue));
    }

    /**
     * get my tasks
     */
    async getMyTasks(requestParameters: GetMyTasksRequest): Promise<TaskListPageResult> {
        const response = await this.getMyTasksRaw(requestParameters);
        return await response.value();
    }

    /**
     * get my task by batch id
     */
    async getTaskByBatchIdRaw(requestParameters: GetTaskByBatchIdRequest): Promise<runtime.ApiResponse<TaskList>> {
        if (requestParameters.batchid === null || requestParameters.batchid === undefined) {
            throw new runtime.RequiredError('batchid','Required parameter requestParameters.batchid was null or undefined when calling getTaskByBatchId.');
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
            path: `/tasks/my/{batchid}`.replace(`{${"batchid"}}`, encodeURIComponent(String(requestParameters.batchid))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => TaskListFromJSON(jsonValue));
    }

    /**
     * get my task by batch id
     */
    async getTaskByBatchId(requestParameters: GetTaskByBatchIdRequest): Promise<TaskList> {
        const response = await this.getTaskByBatchIdRaw(requestParameters);
        return await response.value();
    }

    /**
     * get task by id
     */
    async getTaskByIdRaw(requestParameters: GetTaskByIdRequest): Promise<runtime.ApiResponse<ApiTask>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getTaskById.');
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
            path: `/tasks/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiTaskFromJSON(jsonValue));
    }

    /**
     * get task by id
     */
    async getTaskById(requestParameters: GetTaskByIdRequest): Promise<ApiTask> {
        const response = await this.getTaskByIdRaw(requestParameters);
        return await response.value();
    }

    /**
     * reassign task
     */
    async reassignTaskRaw(requestParameters: ReassignTaskRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling reassignTask.');
        }

        if (requestParameters.user === null || requestParameters.user === undefined) {
            throw new runtime.RequiredError('user','Required parameter requestParameters.user was null or undefined when calling reassignTask.');
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
            path: `/tasks/{id}/reassignto/{user}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))).replace(`{${"user"}}`, encodeURIComponent(String(requestParameters.user))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * reassign task
     */
    async reassignTask(requestParameters: ReassignTaskRequest): Promise<void> {
        await this.reassignTaskRaw(requestParameters);
    }

    /**
     * reject task
     */
    async rejectTaskRaw(requestParameters: RejectTaskRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling rejectTask.');
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
            path: `/tasks/{id}/reject`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CommentsParamToJSON(requestParameters.commentsParam),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * reject task
     */
    async rejectTask(requestParameters: RejectTaskRequest): Promise<void> {
        await this.rejectTaskRaw(requestParameters);
    }

    /**
     * retry error task
     */
    async retryErrorTaskRaw(requestParameters: RetryErrorTaskRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling retryErrorTask.');
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
            path: `/tasks/{id}/retry`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CommentsParamToJSON(requestParameters.commentsParam),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * retry error task
     */
    async retryErrorTask(requestParameters: RetryErrorTaskRequest): Promise<void> {
        await this.retryErrorTaskRaw(requestParameters);
    }

    /**
     * skip error task
     */
    async skipErrorTaskRaw(requestParameters: SkipErrorTaskRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling skipErrorTask.');
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
            path: `/tasks/{id}/skip`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CommentsParamToJSON(requestParameters.commentsParam),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * skip error task
     */
    async skipErrorTask(requestParameters: SkipErrorTaskRequest): Promise<void> {
        await this.skipErrorTaskRaw(requestParameters);
    }

}
