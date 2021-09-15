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
    InlineResponse200,
    InlineResponse200FromJSON,
    InlineResponse200ToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelToJSON,
    PersonalSettings,
    PersonalSettingsFromJSON,
    PersonalSettingsToJSON,
} from '../models';

export interface GetDynamicMembershipRuleItemsRequest {
    tenantid: string;
}

/**
 * 
 */
export class SettingsApi extends runtime.BaseAPI {

    /**
     * get group/teams dynamic membership rules
     */
    async getDynamicMembershipRuleItemsRaw(requestParameters: GetDynamicMembershipRuleItemsRequest): Promise<runtime.ApiResponse<InlineResponse200>> {
        if (requestParameters.tenantid === null || requestParameters.tenantid === undefined) {
            throw new runtime.RequiredError('tenantid','Required parameter requestParameters.tenantid was null or undefined when calling getDynamicMembershipRuleItems.');
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
            path: `/settings/office365/groups/dynamicmembershiprule/{tenantid}`.replace(`{${"tenantid"}}`, encodeURIComponent(String(requestParameters.tenantid))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => InlineResponse200FromJSON(jsonValue));
    }

    /**
     * get group/teams dynamic membership rules
     */
    async getDynamicMembershipRuleItems(requestParameters: GetDynamicMembershipRuleItemsRequest): Promise<InlineResponse200> {
        const response = await this.getDynamicMembershipRuleItemsRaw(requestParameters);
        return await response.value();
    }

    /**
     * get my personal settings
     */
    async getMyPersonalSettingsRaw(): Promise<runtime.ApiResponse<PersonalSettings>> {
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
            path: `/settings/my`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => PersonalSettingsFromJSON(jsonValue));
    }

    /**
     * get my personal settings
     */
    async getMyPersonalSettings(): Promise<PersonalSettings> {
        const response = await this.getMyPersonalSettingsRaw();
        return await response.value();
    }

    /**
     * get permission levels
     */
    async getPermissionLevelsRaw(): Promise<runtime.ApiResponse<Array<PermissionLevel>>> {
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
            path: `/settings/office365/permissionlevels`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(PermissionLevelFromJSON));
    }

    /**
     * get permission levels
     */
    async getPermissionLevels(): Promise<Array<PermissionLevel>> {
        const response = await this.getPermissionLevelsRaw();
        return await response.value();
    }

}
