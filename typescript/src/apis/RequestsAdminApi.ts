/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import * as runtime from '../runtime';
import {
    AllRequestListPageResult,
    AllRequestListPageResultFromJSON,
    AllRequestListPageResultToJSON,
    ApiError,
    ApiErrorFromJSON,
    ApiErrorToJSON,
} from '../models';

export interface GetAllRequestsRequest {
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
export class RequestsAdminApi extends runtime.BaseAPI {

    /**
     * get all requests
     */
    async getAllRequestsRaw(requestParameters: GetAllRequestsRequest): Promise<runtime.ApiResponse<AllRequestListPageResult>> {
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
            path: `/admin/directory/requests`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => AllRequestListPageResultFromJSON(jsonValue));
    }

    /**
     * get all requests
     */
    async getAllRequests(requestParameters: GetAllRequestsRequest): Promise<AllRequestListPageResult> {
        const response = await this.getAllRequestsRaw(requestParameters);
        return await response.value();
    }

}
