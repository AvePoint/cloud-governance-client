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
    HookMessageList,
    HookMessageListFromJSON,
    HookMessageListToJSON,
} from '../models';

/**
 * 
 */
export class SystemSettingsAdminApi extends runtime.BaseAPI {

    /**
     */
    async getHookMessageSamplesRaw(): Promise<runtime.ApiResponse<HookMessageList>> {
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
            path: `/admin/settings/system/hooks/messages/sample`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => HookMessageListFromJSON(jsonValue));
    }

    /**
     */
    async getHookMessageSamples(): Promise<HookMessageList> {
        const response = await this.getHookMessageSamplesRaw();
        return await response.value();
    }

}
