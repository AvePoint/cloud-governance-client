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
    DelegatedAccessTokenApiResult,
    DelegatedAccessTokenApiResultFromJSON,
    DelegatedAccessTokenApiResultToJSON,
} from '../models';

export interface GetDelegateAccessTokenRequest {
    apiCredential: ApiCredential;
}

export interface RefreshUserAccessTokenRequest {
    refreshToken: string;
}

/**
 * 
 */
export class AuthApi extends runtime.BaseAPI {

    /**
     * get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
     */
    async getDelegateAccessTokenRaw(requestParameters: GetDelegateAccessTokenRequest): Promise<runtime.ApiResponse<DelegatedAccessTokenApiResult>> {
        if (requestParameters.apiCredential === null || requestParameters.apiCredential === undefined) {
            throw new runtime.RequiredError('apiCredential','Required parameter requestParameters.apiCredential was null or undefined when calling getDelegateAccessToken.');
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
            path: `/auth/token/delegate`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ApiCredentialToJSON(requestParameters.apiCredential),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => DelegatedAccessTokenApiResultFromJSON(jsonValue));
    }

    /**
     * get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
     */
    async getDelegateAccessToken(requestParameters: GetDelegateAccessTokenRequest): Promise<DelegatedAccessTokenApiResult> {
        const response = await this.getDelegateAccessTokenRaw(requestParameters);
        return await response.value();
    }

    /**
     * refresh user access token
     */
    async refreshUserAccessTokenRaw(requestParameters: RefreshUserAccessTokenRequest): Promise<runtime.ApiResponse<DelegatedAccessTokenApiResult>> {
        if (requestParameters.refreshToken === null || requestParameters.refreshToken === undefined) {
            throw new runtime.RequiredError('refreshToken','Required parameter requestParameters.refreshToken was null or undefined when calling refreshUserAccessToken.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (requestParameters.refreshToken !== undefined && requestParameters.refreshToken !== null) {
            headerParameters['refresh_token'] = String(requestParameters.refreshToken);
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.9.3)";
        const response = await this.request({
            path: `/auth/token/refresh`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => DelegatedAccessTokenApiResultFromJSON(jsonValue));
    }

    /**
     * refresh user access token
     */
    async refreshUserAccessToken(requestParameters: RefreshUserAccessTokenRequest): Promise<DelegatedAccessTokenApiResult> {
        const response = await this.refreshUserAccessTokenRaw(requestParameters);
        return await response.value();
    }

}
