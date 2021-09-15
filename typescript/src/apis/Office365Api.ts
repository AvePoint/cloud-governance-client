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
    ApiSiteStatus,
    ApiSiteStatusFromJSON,
    ApiSiteStatusToJSON,
    ApiUserPageResult,
    ApiUserPageResultFromJSON,
    ApiUserPageResultToJSON,
    GroupSettingModel,
    GroupSettingModelFromJSON,
    GroupSettingModelToJSON,
    GuidModel,
    GuidModelFromJSON,
    GuidModelToJSON,
    NodeType,
    NodeTypeFromJSON,
    NodeTypeToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelToJSON,
    SPGroup,
    SPGroupFromJSON,
    SPGroupToJSON,
    SPRoleAssignment,
    SPRoleAssignmentFromJSON,
    SPRoleAssignmentToJSON,
    SiteTemplate,
    SiteTemplateFromJSON,
    SiteTemplateToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelToJSON,
    UserGroupPermissions,
    UserGroupPermissionsFromJSON,
    UserGroupPermissionsToJSON,
} from '../models';

export interface CreateSecurityGroupRequest {
    groupSettingModel?: GroupSettingModel;
}

export interface GetGroupAllMembersByGroupValueRequest {
    objectIdOrNameOrEmail: string;
    tenantId: string;
    top?: number;
    skip?: number;
    search?: string;
}

export interface GetGroupMembersRequest {
    email: string;
    top?: number;
    skip?: number;
    search?: string;
}

export interface GetGroupOwnersRequest {
    email: string;
    top?: number;
    skip?: number;
    search?: string;
}

export interface GetHubSitesByUrlRequest {
    siteUrl: string;
}

export interface GetPermissionsRequest {
    webUrl: string;
}

export interface GetRoleAssignmentRequest {
    url: string;
    type: NodeType;
}

export interface GetSiteDesignsRequest {
    siteUrl: string;
}

export interface GetSitePermissionLevelsRequest {
    uri: string;
}

export interface GetSiteSharePointGroupsRequest {
    uri: string;
}

export interface GetSiteStatusRequest {
    fullUrl: string;
}

export interface GetSiteTemplatesRequest {
    url: string;
    languageid: number;
}

export interface HasPermissionRequest {
    siteurl: string;
    currentuser: string;
}

export interface RemoveSecurityGroupRequest {
    name: string;
}

/**
 * 
 */
export class Office365Api extends runtime.BaseAPI {

    /**
     * Create mail-enabled security group
     */
    async createSecurityGroupRaw(requestParameters: CreateSecurityGroupRequest): Promise<runtime.ApiResponse<void>> {
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
            path: `/office365/securitygroups`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: GroupSettingModelToJSON(requestParameters.groupSettingModel),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * Create mail-enabled security group
     */
    async createSecurityGroup(requestParameters: CreateSecurityGroupRequest): Promise<void> {
        await this.createSecurityGroupRaw(requestParameters);
    }

    /**
     * get group members by group email
     */
    async getGroupAllMembersByGroupValueRaw(requestParameters: GetGroupAllMembersByGroupValueRequest): Promise<runtime.ApiResponse<ApiUserPageResult>> {
        if (requestParameters.objectIdOrNameOrEmail === null || requestParameters.objectIdOrNameOrEmail === undefined) {
            throw new runtime.RequiredError('objectIdOrNameOrEmail','Required parameter requestParameters.objectIdOrNameOrEmail was null or undefined when calling getGroupAllMembersByGroupValue.');
        }

        if (requestParameters.tenantId === null || requestParameters.tenantId === undefined) {
            throw new runtime.RequiredError('tenantId','Required parameter requestParameters.tenantId was null or undefined when calling getGroupAllMembersByGroupValue.');
        }

        const queryParameters: any = {};

        if (requestParameters.objectIdOrNameOrEmail !== undefined) {
            queryParameters['objectIdOrNameOrEmail'] = requestParameters.objectIdOrNameOrEmail;
        }

        if (requestParameters.tenantId !== undefined) {
            queryParameters['tenantId'] = requestParameters.tenantId;
        }

        if (requestParameters.top !== undefined) {
            queryParameters['top'] = requestParameters.top;
        }

        if (requestParameters.skip !== undefined) {
            queryParameters['skip'] = requestParameters.skip;
        }

        if (requestParameters.search !== undefined) {
            queryParameters['search'] = requestParameters.search;
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
            path: `/office365/groups/allmembers`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiUserPageResultFromJSON(jsonValue));
    }

    /**
     * get group members by group email
     */
    async getGroupAllMembersByGroupValue(requestParameters: GetGroupAllMembersByGroupValueRequest): Promise<ApiUserPageResult> {
        const response = await this.getGroupAllMembersByGroupValueRaw(requestParameters);
        return await response.value();
    }

    /**
     * get group members without owners by group email
     */
    async getGroupMembersRaw(requestParameters: GetGroupMembersRequest): Promise<runtime.ApiResponse<ApiUserPageResult>> {
        if (requestParameters.email === null || requestParameters.email === undefined) {
            throw new runtime.RequiredError('email','Required parameter requestParameters.email was null or undefined when calling getGroupMembers.');
        }

        const queryParameters: any = {};

        if (requestParameters.top !== undefined) {
            queryParameters['top'] = requestParameters.top;
        }

        if (requestParameters.skip !== undefined) {
            queryParameters['skip'] = requestParameters.skip;
        }

        if (requestParameters.search !== undefined) {
            queryParameters['search'] = requestParameters.search;
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
            path: `/office365/groups/{email}/memberswithoutowner`.replace(`{${"email"}}`, encodeURIComponent(String(requestParameters.email))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiUserPageResultFromJSON(jsonValue));
    }

    /**
     * get group members without owners by group email
     */
    async getGroupMembers(requestParameters: GetGroupMembersRequest): Promise<ApiUserPageResult> {
        const response = await this.getGroupMembersRaw(requestParameters);
        return await response.value();
    }

    /**
     * get group owners by group email
     */
    async getGroupOwnersRaw(requestParameters: GetGroupOwnersRequest): Promise<runtime.ApiResponse<ApiUserPageResult>> {
        if (requestParameters.email === null || requestParameters.email === undefined) {
            throw new runtime.RequiredError('email','Required parameter requestParameters.email was null or undefined when calling getGroupOwners.');
        }

        const queryParameters: any = {};

        if (requestParameters.top !== undefined) {
            queryParameters['top'] = requestParameters.top;
        }

        if (requestParameters.skip !== undefined) {
            queryParameters['skip'] = requestParameters.skip;
        }

        if (requestParameters.search !== undefined) {
            queryParameters['search'] = requestParameters.search;
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
            path: `/office365/groups/{email}/owners`.replace(`{${"email"}}`, encodeURIComponent(String(requestParameters.email))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiUserPageResultFromJSON(jsonValue));
    }

    /**
     * get group owners by group email
     */
    async getGroupOwners(requestParameters: GetGroupOwnersRequest): Promise<ApiUserPageResult> {
        const response = await this.getGroupOwnersRaw(requestParameters);
        return await response.value();
    }

    /**
     * get all hubsites from site\'s tenant
     */
    async getHubSitesByUrlRaw(requestParameters: GetHubSitesByUrlRequest): Promise<runtime.ApiResponse<Array<GuidModel>>> {
        if (requestParameters.siteUrl === null || requestParameters.siteUrl === undefined) {
            throw new runtime.RequiredError('siteUrl','Required parameter requestParameters.siteUrl was null or undefined when calling getHubSitesByUrl.');
        }

        const queryParameters: any = {};

        if (requestParameters.siteUrl !== undefined) {
            queryParameters['siteUrl'] = requestParameters.siteUrl;
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
            path: `/office365/hubsites`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(GuidModelFromJSON));
    }

    /**
     * get all hubsites from site\'s tenant
     */
    async getHubSitesByUrl(requestParameters: GetHubSitesByUrlRequest): Promise<Array<GuidModel>> {
        const response = await this.getHubSitesByUrlRaw(requestParameters);
        return await response.value();
    }

    /**
     * get all teams that owner is curernt user
     */
    async getOwnedTeamsRaw(): Promise<runtime.ApiResponse<Array<GuidModel>>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/office365/teams/my`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(GuidModelFromJSON));
    }

    /**
     * get all teams that owner is curernt user
     */
    async getOwnedTeams(): Promise<Array<GuidModel>> {
        const response = await this.getOwnedTeamsRaw();
        return await response.value();
    }

    /**
     * get web permissions for creating list request by web url
     */
    async getPermissionsRaw(requestParameters: GetPermissionsRequest): Promise<runtime.ApiResponse<UserGroupPermissions>> {
        if (requestParameters.webUrl === null || requestParameters.webUrl === undefined) {
            throw new runtime.RequiredError('webUrl','Required parameter requestParameters.webUrl was null or undefined when calling getPermissions.');
        }

        const queryParameters: any = {};

        if (requestParameters.webUrl !== undefined) {
            queryParameters['webUrl'] = requestParameters.webUrl;
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
            path: `/office365/permissions`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => UserGroupPermissionsFromJSON(jsonValue));
    }

    /**
     * get web permissions for creating list request by web url
     */
    async getPermissions(requestParameters: GetPermissionsRequest): Promise<UserGroupPermissions> {
        const response = await this.getPermissionsRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site permimssion role assignment
     */
    async getRoleAssignmentRaw(requestParameters: GetRoleAssignmentRequest): Promise<runtime.ApiResponse<Array<SPRoleAssignment>>> {
        if (requestParameters.url === null || requestParameters.url === undefined) {
            throw new runtime.RequiredError('url','Required parameter requestParameters.url was null or undefined when calling getRoleAssignment.');
        }

        if (requestParameters.type === null || requestParameters.type === undefined) {
            throw new runtime.RequiredError('type','Required parameter requestParameters.type was null or undefined when calling getRoleAssignment.');
        }

        const queryParameters: any = {};

        if (requestParameters.url !== undefined) {
            queryParameters['url'] = requestParameters.url;
        }

        if (requestParameters.type !== undefined) {
            queryParameters['type'] = requestParameters.type;
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
            path: `/office365/roleassignment`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(SPRoleAssignmentFromJSON));
    }

    /**
     * get site permimssion role assignment
     */
    async getRoleAssignment(requestParameters: GetRoleAssignmentRequest): Promise<Array<SPRoleAssignment>> {
        const response = await this.getRoleAssignmentRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site designs by site url
     */
    async getSiteDesignsRaw(requestParameters: GetSiteDesignsRequest): Promise<runtime.ApiResponse<Array<StringModel>>> {
        if (requestParameters.siteUrl === null || requestParameters.siteUrl === undefined) {
            throw new runtime.RequiredError('siteUrl','Required parameter requestParameters.siteUrl was null or undefined when calling getSiteDesigns.');
        }

        const queryParameters: any = {};

        if (requestParameters.siteUrl !== undefined) {
            queryParameters['siteUrl'] = requestParameters.siteUrl;
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
            path: `/office365/sitedesigns`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(StringModelFromJSON));
    }

    /**
     * get site designs by site url
     */
    async getSiteDesigns(requestParameters: GetSiteDesignsRequest): Promise<Array<StringModel>> {
        const response = await this.getSiteDesignsRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site permission levels
     */
    async getSitePermissionLevelsRaw(requestParameters: GetSitePermissionLevelsRequest): Promise<runtime.ApiResponse<Array<PermissionLevel>>> {
        if (requestParameters.uri === null || requestParameters.uri === undefined) {
            throw new runtime.RequiredError('uri','Required parameter requestParameters.uri was null or undefined when calling getSitePermissionLevels.');
        }

        const queryParameters: any = {};

        if (requestParameters.uri !== undefined) {
            queryParameters['uri'] = requestParameters.uri;
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
            path: `/office365/sites/permissionlevels`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(PermissionLevelFromJSON));
    }

    /**
     * get site permission levels
     */
    async getSitePermissionLevels(requestParameters: GetSitePermissionLevelsRequest): Promise<Array<PermissionLevel>> {
        const response = await this.getSitePermissionLevelsRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site sharePoint groups
     */
    async getSiteSharePointGroupsRaw(requestParameters: GetSiteSharePointGroupsRequest): Promise<runtime.ApiResponse<Array<SPGroup>>> {
        if (requestParameters.uri === null || requestParameters.uri === undefined) {
            throw new runtime.RequiredError('uri','Required parameter requestParameters.uri was null or undefined when calling getSiteSharePointGroups.');
        }

        const queryParameters: any = {};

        if (requestParameters.uri !== undefined) {
            queryParameters['uri'] = requestParameters.uri;
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
            path: `/office365/sites/sharepointgroups`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(SPGroupFromJSON));
    }

    /**
     * get site sharePoint groups
     */
    async getSiteSharePointGroups(requestParameters: GetSiteSharePointGroupsRequest): Promise<Array<SPGroup>> {
        const response = await this.getSiteSharePointGroupsRaw(requestParameters);
        return await response.value();
    }

    /**
     * check site collection status by full url
     */
    async getSiteStatusRaw(requestParameters: GetSiteStatusRequest): Promise<runtime.ApiResponse<ApiSiteStatus>> {
        if (requestParameters.fullUrl === null || requestParameters.fullUrl === undefined) {
            throw new runtime.RequiredError('fullUrl','Required parameter requestParameters.fullUrl was null or undefined when calling getSiteStatus.');
        }

        const queryParameters: any = {};

        if (requestParameters.fullUrl !== undefined) {
            queryParameters['fullUrl'] = requestParameters.fullUrl;
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
            path: `/office365/sites/status`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiSiteStatusFromJSON(jsonValue));
    }

    /**
     * check site collection status by full url
     */
    async getSiteStatus(requestParameters: GetSiteStatusRequest): Promise<ApiSiteStatus> {
        const response = await this.getSiteStatusRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site templates with language code identifier
     */
    async getSiteTemplatesRaw(requestParameters: GetSiteTemplatesRequest): Promise<runtime.ApiResponse<Array<SiteTemplate>>> {
        if (requestParameters.url === null || requestParameters.url === undefined) {
            throw new runtime.RequiredError('url','Required parameter requestParameters.url was null or undefined when calling getSiteTemplates.');
        }

        if (requestParameters.languageid === null || requestParameters.languageid === undefined) {
            throw new runtime.RequiredError('languageid','Required parameter requestParameters.languageid was null or undefined when calling getSiteTemplates.');
        }

        const queryParameters: any = {};

        if (requestParameters.url !== undefined) {
            queryParameters['url'] = requestParameters.url;
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
            path: `/office365/sites/templates/{languageid}`.replace(`{${"languageid"}}`, encodeURIComponent(String(requestParameters.languageid))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(SiteTemplateFromJSON));
    }

    /**
     * get site templates with language code identifier
     */
    async getSiteTemplates(requestParameters: GetSiteTemplatesRequest): Promise<Array<SiteTemplate>> {
        const response = await this.getSiteTemplatesRaw(requestParameters);
        return await response.value();
    }

    /**
     * whether user has permission on the site
     */
    async hasPermissionRaw(requestParameters: HasPermissionRequest): Promise<runtime.ApiResponse<boolean>> {
        if (requestParameters.siteurl === null || requestParameters.siteurl === undefined) {
            throw new runtime.RequiredError('siteurl','Required parameter requestParameters.siteurl was null or undefined when calling hasPermission.');
        }

        if (requestParameters.currentuser === null || requestParameters.currentuser === undefined) {
            throw new runtime.RequiredError('currentuser','Required parameter requestParameters.currentuser was null or undefined when calling hasPermission.');
        }

        const queryParameters: any = {};

        if (requestParameters.siteurl !== undefined) {
            queryParameters['siteurl'] = requestParameters.siteurl;
        }

        if (requestParameters.currentuser !== undefined) {
            queryParameters['currentuser'] = requestParameters.currentuser;
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
            path: `/office365/sites/haspermission`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * whether user has permission on the site
     */
    async hasPermission(requestParameters: HasPermissionRequest): Promise<boolean> {
        const response = await this.hasPermissionRaw(requestParameters);
        return await response.value();
    }

    /**
     * Remove mail-enabled security group by group name
     */
    async removeSecurityGroupRaw(requestParameters: RemoveSecurityGroupRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.name === null || requestParameters.name === undefined) {
            throw new runtime.RequiredError('name','Required parameter requestParameters.name was null or undefined when calling removeSecurityGroup.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/office365/securitygroups/{name}`.replace(`{${"name"}}`, encodeURIComponent(String(requestParameters.name))),
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * Remove mail-enabled security group by group name
     */
    async removeSecurityGroup(requestParameters: RemoveSecurityGroupRequest): Promise<void> {
        await this.removeSecurityGroupRaw(requestParameters);
    }

}
