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
    ApplyGroupPolicyModel,
    ApplyGroupPolicyModelFromJSON,
    ApplyGroupPolicyModelToJSON,
    ApplySitePolicyModel,
    ApplySitePolicyModelFromJSON,
    ApplySitePolicyModelToJSON,
    ArchiveWorkspaceParameter,
    ArchiveWorkspaceParameterFromJSON,
    ArchiveWorkspaceParameterToJSON,
    LockSiteParameter,
    LockSiteParameterFromJSON,
    LockSiteParameterToJSON,
    SpecifyContactParameter,
    SpecifyContactParameterFromJSON,
    SpecifyContactParameterToJSON,
    WorksapceOngoingTasksModel,
    WorksapceOngoingTasksModelFromJSON,
    WorksapceOngoingTasksModelToJSON,
    WorkspaceGridModelPageResult,
    WorkspaceGridModelPageResultFromJSON,
    WorkspaceGridModelPageResultToJSON,
    WorkspaceIdTypeModel,
    WorkspaceIdTypeModelFromJSON,
    WorkspaceIdTypeModelToJSON,
    WorkspaceType,
    WorkspaceTypeFromJSON,
    WorkspaceTypeToJSON,
} from '../models';

export interface ApplyGroupsPolicyRequest {
    applyGroupPolicyModel?: ApplyGroupPolicyModel;
}

export interface ApplySitesPolicyRequest {
    applySitePolicyModel?: ApplySitePolicyModel;
}

export interface ArchiveWorkspaceRequest {
    archiveWorkspaceParameter?: ArchiveWorkspaceParameter;
}

export interface CompleteWorkspaceRenewalTaskRequest {
    markAsCanceled?: boolean;
    workspaceIdTypeModel?: Array<WorkspaceIdTypeModel>;
}

export interface DeleteWorkspacesRequest {
    workspaceIdTypeModel?: Array<WorkspaceIdTypeModel>;
}

export interface GetOngoingTasksRequest {
    type: WorkspaceType;
    groupNameOrUrl: string;
}

export interface GetWorkspacesRequest {
    filter?: string | null;
    orderby?: string | null;
    search?: string | null;
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

export interface LockWorkspacesRequest {
    lockSiteParameter?: LockSiteParameter;
}

export interface SpecifyContactsRequest {
    specifyContactParameter?: SpecifyContactParameter;
}

export interface TriggerWorkspaceRenewalRequest {
    workspaceIdTypeModel?: Array<WorkspaceIdTypeModel>;
}

export interface UnlockWorkspaceRequest {
    workspaceIdTypeModel?: Array<WorkspaceIdTypeModel>;
}

/**
 * 
 */
export class WorkspacesAdminApi extends runtime.BaseAPI {

    /**
     * apply groups policy
     */
    async applyGroupsPolicyRaw(requestParameters: ApplyGroupsPolicyRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/groups/policy`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ApplyGroupPolicyModelToJSON(requestParameters.applyGroupPolicyModel),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * apply groups policy
     */
    async applyGroupsPolicy(requestParameters: ApplyGroupsPolicyRequest): Promise<void> {
        await this.applyGroupsPolicyRaw(requestParameters);
    }

    /**
     * apply site policy
     */
    async applySitesPolicyRaw(requestParameters: ApplySitesPolicyRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/sites/policy`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ApplySitePolicyModelToJSON(requestParameters.applySitePolicyModel),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * apply site policy
     */
    async applySitesPolicy(requestParameters: ApplySitesPolicyRequest): Promise<void> {
        await this.applySitesPolicyRaw(requestParameters);
    }

    /**
     * archive workspace
     */
    async archiveWorkspaceRaw(requestParameters: ArchiveWorkspaceRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/archive`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ArchiveWorkspaceParameterToJSON(requestParameters.archiveWorkspaceParameter),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * archive workspace
     */
    async archiveWorkspace(requestParameters: ArchiveWorkspaceRequest): Promise<void> {
        await this.archiveWorkspaceRaw(requestParameters);
    }

    /**
     * completed renewal task
     */
    async completeWorkspaceRenewalTaskRaw(requestParameters: CompleteWorkspaceRenewalTaskRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        if (requestParameters.markAsCanceled !== undefined) {
            queryParameters['markAsCanceled'] = requestParameters.markAsCanceled;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/renewal/complete`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: requestParameters.workspaceIdTypeModel.map(WorkspaceIdTypeModelToJSON),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * completed renewal task
     */
    async completeWorkspaceRenewalTask(requestParameters: CompleteWorkspaceRenewalTaskRequest): Promise<void> {
        await this.completeWorkspaceRenewalTaskRaw(requestParameters);
    }

    /**
     * delete workspaces
     */
    async deleteWorkspacesRaw(requestParameters: DeleteWorkspacesRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace`,
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
            body: requestParameters.workspaceIdTypeModel.map(WorkspaceIdTypeModelToJSON),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * delete workspaces
     */
    async deleteWorkspaces(requestParameters: DeleteWorkspacesRequest): Promise<void> {
        await this.deleteWorkspacesRaw(requestParameters);
    }

    /**
     * get workspace ongoing tasks
     */
    async getOngoingTasksRaw(requestParameters: GetOngoingTasksRequest): Promise<runtime.ApiResponse<Array<WorksapceOngoingTasksModel>>> {
        if (requestParameters.type === null || requestParameters.type === undefined) {
            throw new runtime.RequiredError('type','Required parameter requestParameters.type was null or undefined when calling getOngoingTasks.');
        }

        if (requestParameters.groupNameOrUrl === null || requestParameters.groupNameOrUrl === undefined) {
            throw new runtime.RequiredError('groupNameOrUrl','Required parameter requestParameters.groupNameOrUrl was null or undefined when calling getOngoingTasks.');
        }

        const queryParameters: any = {};

        if (requestParameters.groupNameOrUrl !== undefined) {
            queryParameters['groupNameOrUrl'] = requestParameters.groupNameOrUrl;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/{type}/ongoningtasks`.replace(`{${"type"}}`, encodeURIComponent(String(requestParameters.type))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(WorksapceOngoingTasksModelFromJSON));
    }

    /**
     * get workspace ongoing tasks
     */
    async getOngoingTasks(requestParameters: GetOngoingTasksRequest): Promise<Array<WorksapceOngoingTasksModel>> {
        const response = await this.getOngoingTasksRaw(requestParameters);
        return await response.value();
    }

    /**
     * get managed workspaces
     */
    async getWorkspacesRaw(requestParameters: GetWorkspacesRequest): Promise<runtime.ApiResponse<WorkspaceGridModelPageResult>> {
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

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => WorkspaceGridModelPageResultFromJSON(jsonValue));
    }

    /**
     * get managed workspaces
     */
    async getWorkspaces(requestParameters: GetWorkspacesRequest): Promise<WorkspaceGridModelPageResult> {
        const response = await this.getWorkspacesRaw(requestParameters);
        return await response.value();
    }

    /**
     * lock sites or Office365 group sites
     */
    async lockWorkspacesRaw(requestParameters: LockWorkspacesRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/lock`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: LockSiteParameterToJSON(requestParameters.lockSiteParameter),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * lock sites or Office365 group sites
     */
    async lockWorkspaces(requestParameters: LockWorkspacesRequest): Promise<void> {
        await this.lockWorkspacesRaw(requestParameters);
    }

    /**
     * sepcify cnotacts
     */
    async specifyContactsRaw(requestParameters: SpecifyContactsRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/contacts`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SpecifyContactParameterToJSON(requestParameters.specifyContactParameter),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * sepcify cnotacts
     */
    async specifyContacts(requestParameters: SpecifyContactsRequest): Promise<void> {
        await this.specifyContactsRaw(requestParameters);
    }

    /**
     * trigger workspace renewal
     */
    async triggerWorkspaceRenewalRaw(requestParameters: TriggerWorkspaceRenewalRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/renewal/trigger`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: requestParameters.workspaceIdTypeModel.map(WorkspaceIdTypeModelToJSON),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * trigger workspace renewal
     */
    async triggerWorkspaceRenewal(requestParameters: TriggerWorkspaceRenewalRequest): Promise<void> {
        await this.triggerWorkspaceRenewalRaw(requestParameters);
    }

    /**
     * unlock sites and Office365 group site
     */
    async unlockWorkspaceRaw(requestParameters: UnlockWorkspaceRequest): Promise<runtime.ApiResponse<void>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/directory/workspace/unlock`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: requestParameters.workspaceIdTypeModel.map(WorkspaceIdTypeModelToJSON),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * unlock sites and Office365 group site
     */
    async unlockWorkspace(requestParameters: UnlockWorkspaceRequest): Promise<void> {
        await this.unlockWorkspaceRaw(requestParameters);
    }

}
