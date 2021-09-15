/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import * as runtime from '../runtime';
import {
    ApiCredential,
    ApiCredentialFromJSON,
    ApiCredentialToJSON,
    ApiError,
    ApiErrorFromJSON,
    ApiErrorToJSON,
} from '../models';

export interface DeleteTokenCacheRequest {
    apiCredential: ApiCredential;
}

/**
 * 
 */
export class AuthAdminApi extends runtime.BaseAPI {

    /**
     * delete token cache
     */
    async deleteTokenCacheRaw(requestParameters: DeleteTokenCacheRequest): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.apiCredential === null || requestParameters.apiCredential === undefined) {
            throw new runtime.RequiredError('apiCredential','Required parameter requestParameters.apiCredential was null or undefined when calling deleteTokenCache.');
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
            path: `/admin/auth/token/cache`,
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
            body: ApiCredentialToJSON(requestParameters.apiCredential),
        });

        return new runtime.VoidApiResponse(response);
    }

    /**
     * delete token cache
     */
    async deleteTokenCache(requestParameters: DeleteTokenCacheRequest): Promise<void> {
        await this.deleteTokenCacheRaw(requestParameters);
    }

}
