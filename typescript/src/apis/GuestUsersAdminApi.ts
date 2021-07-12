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
    GuestUserGridModelPageResult,
    GuestUserGridModelPageResultFromJSON,
    GuestUserGridModelPageResultToJSON,
} from '../models';

export interface GetManagedGuestUsersRequest {
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
export class GuestUsersAdminApi extends runtime.BaseAPI {

    /**
     * get all managed guest users
     */
    async getManagedGuestUsersRaw(requestParameters: GetManagedGuestUsersRequest): Promise<runtime.ApiResponse<GuestUserGridModelPageResult>> {
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
            path: `/admin/directory/guestusers`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => GuestUserGridModelPageResultFromJSON(jsonValue));
    }

    /**
     * get all managed guest users
     */
    async getManagedGuestUsers(requestParameters: GetManagedGuestUsersRequest): Promise<GuestUserGridModelPageResult> {
        const response = await this.getManagedGuestUsersRaw(requestParameters);
        return await response.value();
    }

}
