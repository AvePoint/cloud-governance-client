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
    ServiceGridModelPageResult,
    ServiceGridModelPageResultFromJSON,
    ServiceGridModelPageResultToJSON,
} from '../models';

export interface GetServicesRequest {
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
export class ServicesAdminApi extends runtime.BaseAPI {

    /**
     * get all services
     */
    async getServicesRaw(requestParameters: GetServicesRequest): Promise<runtime.ApiResponse<ServiceGridModelPageResult>> {
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
            path: `/admin/services`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ServiceGridModelPageResultFromJSON(jsonValue));
    }

    /**
     * get all services
     */
    async getServices(requestParameters: GetServicesRequest): Promise<ServiceGridModelPageResult> {
        const response = await this.getServicesRaw(requestParameters);
        return await response.value();
    }

}
