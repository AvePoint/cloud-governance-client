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
    UserCustomAction,
    UserCustomActionFromJSON,
    UserCustomActionToJSON,
} from '../models';

export interface AddWebUserCustomActionRequest {
    userCustomAction: UserCustomAction;
}

export interface DeleteWebUserCustomActionRequest {
    webFullUrl: string;
    name: string;
}

export interface GetAzureAdCustomPropertyNamesRequest {
    tenantId: string;
    isSearchUserProperty?: boolean;
}

export interface GetTenantIdByUrlRequest {
    uri: string;
}

/**
 * 
 */
export class Office365AdminApi extends runtime.BaseAPI {

    /**
     * add user custom actions, if exists, will update the existing one.
     */
    async addWebUserCustomActionRaw(requestParameters: AddWebUserCustomActionRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.userCustomAction === null || requestParameters.userCustomAction === undefined) {
            throw new runtime.RequiredError('userCustomAction','Required parameter requestParameters.userCustomAction was null or undefined when calling addWebUserCustomAction.');
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

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/admin/office365/web/usercustomactions`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: UserCustomActionToJSON(requestParameters.userCustomAction),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * add user custom actions, if exists, will update the existing one.
     */
    async addWebUserCustomAction(requestParameters: AddWebUserCustomActionRequest): Promise<void> {
        await this.addWebUserCustomActionRaw(requestParameters);
    }

    /**
     * delete user custom actions by action name
     */
    async deleteWebUserCustomActionRaw(requestParameters: DeleteWebUserCustomActionRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.webFullUrl === null || requestParameters.webFullUrl === undefined) {
            throw new runtime.RequiredError('webFullUrl','Required parameter requestParameters.webFullUrl was null or undefined when calling deleteWebUserCustomAction.');
        }

        if (requestParameters.name === null || requestParameters.name === undefined) {
            throw new runtime.RequiredError('name','Required parameter requestParameters.name was null or undefined when calling deleteWebUserCustomAction.');
        }

        const queryParameters: any = {};

        if (requestParameters.webFullUrl !== undefined) {
            queryParameters['webFullUrl'] = requestParameters.webFullUrl;
        }

        if (requestParameters.name !== undefined) {
            queryParameters['name'] = requestParameters.name;
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
            path: `/admin/office365/web/usercustomactions`,
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * delete user custom actions by action name
     */
    async deleteWebUserCustomAction(requestParameters: DeleteWebUserCustomActionRequest): Promise<void> {
        await this.deleteWebUserCustomActionRaw(requestParameters);
    }

    /**
     * get azure ad custom property names
     */
    async getAzureAdCustomPropertyNamesRaw(requestParameters: GetAzureAdCustomPropertyNamesRequest): Promise<runtime.ApiResponse<Array<string>>> {
        if (requestParameters.tenantId === null || requestParameters.tenantId === undefined) {
            throw new runtime.RequiredError('tenantId','Required parameter requestParameters.tenantId was null or undefined when calling getAzureAdCustomPropertyNames.');
        }

        const queryParameters: any = {};

        if (requestParameters.isSearchUserProperty !== undefined) {
            queryParameters['isSearchUserProperty'] = requestParameters.isSearchUserProperty;
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
            path: `/admin/office365/azuread/{tenantId}/property/names/custom`.replace(`{${"tenantId"}}`, encodeURIComponent(String(requestParameters.tenantId))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * get azure ad custom property names
     */
    async getAzureAdCustomPropertyNames(requestParameters: GetAzureAdCustomPropertyNamesRequest): Promise<Array<string>> {
        const response = await this.getAzureAdCustomPropertyNamesRaw(requestParameters);
        return await response.value();
    }

    /**
     * get tenant ids by url
     */
    async getTenantIdByUrlRaw(requestParameters: GetTenantIdByUrlRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.uri === null || requestParameters.uri === undefined) {
            throw new runtime.RequiredError('uri','Required parameter requestParameters.uri was null or undefined when calling getTenantIdByUrl.');
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
            path: `/admin/office365/tenantid`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * get tenant ids by url
     */
    async getTenantIdByUrl(requestParameters: GetTenantIdByUrlRequest): Promise<void> {
        await this.getTenantIdByUrlRaw(requestParameters);
    }

}
