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
    ApiUser,
    ApiUserFromJSON,
    ApiUserToJSON,
    ApiUserType,
    ApiUserTypeFromJSON,
    ApiUserTypeToJSON,
    ExternalSharingOptions,
    ExternalSharingOptionsFromJSON,
    ExternalSharingOptionsToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelToJSON,
    UpdatableApiUser,
    UpdatableApiUserFromJSON,
    UpdatableApiUserToJSON,
    UserSource,
    UserSourceFromJSON,
    UserSourceToJSON,
} from '../models';

export interface FilterUsersByAttributeRequest {
    attributeName: string;
    attributeValue: string;
    office365TenantId?: string;
}

export interface GetAzureAdUserPropertyValueRequest {
    username: string;
    propertyName: string;
}

export interface GetExtensionAzureAdUserPropertyValuesRequest {
    username: string;
}

export interface IsMemberOfGroupRequest {
    userprincipalname: string;
    groupid: string;
}

export interface ResolveUsersRequest {
    keyword: string;
    userType: ApiUserType;
    userSource: UserSource;
    sharingOptions: ExternalSharingOptions;
    siteUrlOrTenantId?: string;
    peopleFilterProfileId?: string;
}

export interface SearchUsersRequest {
    keyword: string;
    userType: ApiUserType;
    userSource: UserSource;
    sharingOptions: ExternalSharingOptions;
    siteUrlOrTenantId?: string;
    peopleFilterProfileId?: string;
}

export interface UpdateUserInfoRequest {
    updatableApiUser?: UpdatableApiUser;
}

/**
 * 
 */
export class UsersApi extends runtime.BaseAPI {

    /**
     * filter users by property value
     */
    async filterUsersByAttributeRaw(requestParameters: FilterUsersByAttributeRequest): Promise<runtime.ApiResponse<Array<ApiUser>>> {
        if (requestParameters.attributeName === null || requestParameters.attributeName === undefined) {
            throw new runtime.RequiredError('attributeName','Required parameter requestParameters.attributeName was null or undefined when calling filterUsersByAttribute.');
        }

        if (requestParameters.attributeValue === null || requestParameters.attributeValue === undefined) {
            throw new runtime.RequiredError('attributeValue','Required parameter requestParameters.attributeValue was null or undefined when calling filterUsersByAttribute.');
        }

        const queryParameters: any = {};

        if (requestParameters.attributeName !== undefined) {
            queryParameters['attributeName'] = requestParameters.attributeName;
        }

        if (requestParameters.attributeValue !== undefined) {
            queryParameters['attributeValue'] = requestParameters.attributeValue;
        }

        if (requestParameters.office365TenantId !== undefined) {
            queryParameters['office365TenantId'] = requestParameters.office365TenantId;
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
            path: `/users/filter`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(ApiUserFromJSON));
    }

    /**
     * filter users by property value
     */
    async filterUsersByAttribute(requestParameters: FilterUsersByAttributeRequest): Promise<Array<ApiUser>> {
        const response = await this.filterUsersByAttributeRaw(requestParameters);
        return await response.value();
    }

    /**
     * get Azure Ad user\'s property value
     */
    async getAzureAdUserPropertyValueRaw(requestParameters: GetAzureAdUserPropertyValueRequest): Promise<runtime.ApiResponse<StringModel>> {
        if (requestParameters.username === null || requestParameters.username === undefined) {
            throw new runtime.RequiredError('username','Required parameter requestParameters.username was null or undefined when calling getAzureAdUserPropertyValue.');
        }

        if (requestParameters.propertyName === null || requestParameters.propertyName === undefined) {
            throw new runtime.RequiredError('propertyName','Required parameter requestParameters.propertyName was null or undefined when calling getAzureAdUserPropertyValue.');
        }

        const queryParameters: any = {};

        if (requestParameters.propertyName !== undefined) {
            queryParameters['propertyName'] = requestParameters.propertyName;
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
            path: `/users/{username}/azuread/property`.replace(`{${"username"}}`, encodeURIComponent(String(requestParameters.username))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => StringModelFromJSON(jsonValue));
    }

    /**
     * get Azure Ad user\'s property value
     */
    async getAzureAdUserPropertyValue(requestParameters: GetAzureAdUserPropertyValueRequest): Promise<StringModel> {
        const response = await this.getAzureAdUserPropertyValueRaw(requestParameters);
        return await response.value();
    }

    /**
     * get user\'s extension property value from azure ad
     */
    async getExtensionAzureAdUserPropertyValuesRaw(requestParameters: GetExtensionAzureAdUserPropertyValuesRequest): Promise<runtime.ApiResponse<Array<StringModel>>> {
        if (requestParameters.username === null || requestParameters.username === undefined) {
            throw new runtime.RequiredError('username','Required parameter requestParameters.username was null or undefined when calling getExtensionAzureAdUserPropertyValues.');
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
            path: `/users/{username}/azuread/extensionproperties`.replace(`{${"username"}}`, encodeURIComponent(String(requestParameters.username))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(StringModelFromJSON));
    }

    /**
     * get user\'s extension property value from azure ad
     */
    async getExtensionAzureAdUserPropertyValues(requestParameters: GetExtensionAzureAdUserPropertyValuesRequest): Promise<Array<StringModel>> {
        const response = await this.getExtensionAzureAdUserPropertyValuesRaw(requestParameters);
        return await response.value();
    }

    /**
     * Is Member Of Group
     */
    async isMemberOfGroupRaw(requestParameters: IsMemberOfGroupRequest): Promise<runtime.ApiResponse<boolean>> {
        if (requestParameters.userprincipalname === null || requestParameters.userprincipalname === undefined) {
            throw new runtime.RequiredError('userprincipalname','Required parameter requestParameters.userprincipalname was null or undefined when calling isMemberOfGroup.');
        }

        if (requestParameters.groupid === null || requestParameters.groupid === undefined) {
            throw new runtime.RequiredError('groupid','Required parameter requestParameters.groupid was null or undefined when calling isMemberOfGroup.');
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
            path: `/users/{userprincipalname}/ismemberof/{groupid}`.replace(`{${"userprincipalname"}}`, encodeURIComponent(String(requestParameters.userprincipalname))).replace(`{${"groupid"}}`, encodeURIComponent(String(requestParameters.groupid))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * Is Member Of Group
     */
    async isMemberOfGroup(requestParameters: IsMemberOfGroupRequest): Promise<boolean> {
        const response = await this.isMemberOfGroupRaw(requestParameters);
        return await response.value();
    }

    /**
     * resolve users
     */
    async resolveUsersRaw(requestParameters: ResolveUsersRequest): Promise<runtime.ApiResponse<Array<ApiUser>>> {
        if (requestParameters.keyword === null || requestParameters.keyword === undefined) {
            throw new runtime.RequiredError('keyword','Required parameter requestParameters.keyword was null or undefined when calling resolveUsers.');
        }

        if (requestParameters.userType === null || requestParameters.userType === undefined) {
            throw new runtime.RequiredError('userType','Required parameter requestParameters.userType was null or undefined when calling resolveUsers.');
        }

        if (requestParameters.userSource === null || requestParameters.userSource === undefined) {
            throw new runtime.RequiredError('userSource','Required parameter requestParameters.userSource was null or undefined when calling resolveUsers.');
        }

        if (requestParameters.sharingOptions === null || requestParameters.sharingOptions === undefined) {
            throw new runtime.RequiredError('sharingOptions','Required parameter requestParameters.sharingOptions was null or undefined when calling resolveUsers.');
        }

        const queryParameters: any = {};

        if (requestParameters.keyword !== undefined) {
            queryParameters['keyword'] = requestParameters.keyword;
        }

        if (requestParameters.userType !== undefined) {
            queryParameters['userType'] = requestParameters.userType;
        }

        if (requestParameters.userSource !== undefined) {
            queryParameters['userSource'] = requestParameters.userSource;
        }

        if (requestParameters.sharingOptions !== undefined) {
            queryParameters['sharingOptions'] = requestParameters.sharingOptions;
        }

        if (requestParameters.siteUrlOrTenantId !== undefined) {
            queryParameters['siteUrlOrTenantId'] = requestParameters.siteUrlOrTenantId;
        }

        if (requestParameters.peopleFilterProfileId !== undefined) {
            queryParameters['peopleFilterProfileId'] = requestParameters.peopleFilterProfileId;
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
            path: `/users/resolve`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(ApiUserFromJSON));
    }

    /**
     * resolve users
     */
    async resolveUsers(requestParameters: ResolveUsersRequest): Promise<Array<ApiUser>> {
        const response = await this.resolveUsersRaw(requestParameters);
        return await response.value();
    }

    /**
     * search users
     */
    async searchUsersRaw(requestParameters: SearchUsersRequest): Promise<runtime.ApiResponse<Array<ApiUser>>> {
        if (requestParameters.keyword === null || requestParameters.keyword === undefined) {
            throw new runtime.RequiredError('keyword','Required parameter requestParameters.keyword was null or undefined when calling searchUsers.');
        }

        if (requestParameters.userType === null || requestParameters.userType === undefined) {
            throw new runtime.RequiredError('userType','Required parameter requestParameters.userType was null or undefined when calling searchUsers.');
        }

        if (requestParameters.userSource === null || requestParameters.userSource === undefined) {
            throw new runtime.RequiredError('userSource','Required parameter requestParameters.userSource was null or undefined when calling searchUsers.');
        }

        if (requestParameters.sharingOptions === null || requestParameters.sharingOptions === undefined) {
            throw new runtime.RequiredError('sharingOptions','Required parameter requestParameters.sharingOptions was null or undefined when calling searchUsers.');
        }

        const queryParameters: any = {};

        if (requestParameters.keyword !== undefined) {
            queryParameters['keyword'] = requestParameters.keyword;
        }

        if (requestParameters.userType !== undefined) {
            queryParameters['userType'] = requestParameters.userType;
        }

        if (requestParameters.userSource !== undefined) {
            queryParameters['userSource'] = requestParameters.userSource;
        }

        if (requestParameters.sharingOptions !== undefined) {
            queryParameters['sharingOptions'] = requestParameters.sharingOptions;
        }

        if (requestParameters.siteUrlOrTenantId !== undefined) {
            queryParameters['siteUrlOrTenantId'] = requestParameters.siteUrlOrTenantId;
        }

        if (requestParameters.peopleFilterProfileId !== undefined) {
            queryParameters['peopleFilterProfileId'] = requestParameters.peopleFilterProfileId;
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
            path: `/users/search`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(ApiUserFromJSON));
    }

    /**
     * search users
     */
    async searchUsers(requestParameters: SearchUsersRequest): Promise<Array<ApiUser>> {
        const response = await this.searchUsersRaw(requestParameters);
        return await response.value();
    }

    /**
     * add users or update user information
     */
    async updateUserInfoRaw(requestParameters: UpdateUserInfoRequest): Promise<runtime.ApiResponse<void>> {
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
            path: `/users`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: UpdatableApiUserToJSON(requestParameters.updatableApiUser),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * add users or update user information
     */
    async updateUserInfo(requestParameters: UpdateUserInfoRequest): Promise<void> {
        await this.updateUserInfoRaw(requestParameters);
    }

}
