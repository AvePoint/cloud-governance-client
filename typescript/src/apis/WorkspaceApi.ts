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
    ApiMyGroup,
    ApiMyGroupFromJSON,
    ApiMyGroupToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataToJSON,
    MySite,
    MySiteFromJSON,
    MySiteToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataToJSON,
    WorkspaceListPageResult,
    WorkspaceListPageResultFromJSON,
    WorkspaceListPageResultToJSON,
} from '../models';

export interface GetGroupMetadataRequest {
    id: string;
}

export interface GetMyGroupInformationRequest {
    id: string;
}

export interface GetMySiteInformationRequest {
    id: string;
}

export interface GetSiteMetadataRequest {
    url: string;
}

export interface GetWorkspaceItemsRequest {
    filter?: string | null;
    orderby?: string | null;
    search?: string | null;
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

/**
 * 
 */
export class WorkspaceApi extends runtime.BaseAPI {

    /**
     * get group/teams metadata
     */
    async getGroupMetadataRaw(requestParameters: GetGroupMetadataRequest): Promise<runtime.ApiResponse<Array<RequestMetadata>>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getGroupMetadata.');
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
            path: `/workspace/groups/{id}/metadata`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(RequestMetadataFromJSON));
    }

    /**
     * get group/teams metadata
     */
    async getGroupMetadata(requestParameters: GetGroupMetadataRequest): Promise<Array<RequestMetadata>> {
        const response = await this.getGroupMetadataRaw(requestParameters);
        return await response.value();
    }

    /**
     * get O365 group/teams information
     */
    async getMyGroupInformationRaw(requestParameters: GetMyGroupInformationRequest): Promise<runtime.ApiResponse<ApiMyGroup>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getMyGroupInformation.');
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
            path: `/workspace/groups/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ApiMyGroupFromJSON(jsonValue));
    }

    /**
     * get O365 group/teams information
     */
    async getMyGroupInformation(requestParameters: GetMyGroupInformationRequest): Promise<ApiMyGroup> {
        const response = await this.getMyGroupInformationRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site information
     */
    async getMySiteInformationRaw(requestParameters: GetMySiteInformationRequest): Promise<runtime.ApiResponse<MySite>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getMySiteInformation.');
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
            path: `/workspace/sites/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => MySiteFromJSON(jsonValue));
    }

    /**
     * get site information
     */
    async getMySiteInformation(requestParameters: GetMySiteInformationRequest): Promise<MySite> {
        const response = await this.getMySiteInformationRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site metadata
     */
    async getSiteMetadataRaw(requestParameters: GetSiteMetadataRequest): Promise<runtime.ApiResponse<Array<CustomMetadata>>> {
        if (requestParameters.url === null || requestParameters.url === undefined) {
            throw new runtime.RequiredError('url','Required parameter requestParameters.url was null or undefined when calling getSiteMetadata.');
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

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/workspace/sites/metadata`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(CustomMetadataFromJSON));
    }

    /**
     * get site metadata
     */
    async getSiteMetadata(requestParameters: GetSiteMetadataRequest): Promise<Array<CustomMetadata>> {
        const response = await this.getSiteMetadataRaw(requestParameters);
        return await response.value();
    }

    /**
     * get my workspace items
     */
    async getWorkspaceItemsRaw(requestParameters: GetWorkspaceItemsRequest): Promise<runtime.ApiResponse<WorkspaceListPageResult>> {
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
            path: `/workspace/my`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => WorkspaceListPageResultFromJSON(jsonValue));
    }

    /**
     * get my workspace items
     */
    async getWorkspaceItems(requestParameters: GetWorkspaceItemsRequest): Promise<WorkspaceListPageResult> {
        const response = await this.getWorkspaceItemsRaw(requestParameters);
        return await response.value();
    }

}
