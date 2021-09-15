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
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataToJSON,
    MetadataGridModelPageResult,
    MetadataGridModelPageResultFromJSON,
    MetadataGridModelPageResultToJSON,
} from '../models';

export interface GetAllMetadataRequest {
    filter?: string | null;
    orderby?: string | null;
    search?: string | null;
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

export interface GetSingleMetadataByIdRequest {
    id: string;
}

/**
 * 
 */
export class MetadataAdminApi extends runtime.BaseAPI {

    /**
     * get all metadata
     */
    async getAllMetadataRaw(requestParameters: GetAllMetadataRequest): Promise<runtime.ApiResponse<MetadataGridModelPageResult>> {
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
            path: `/admin/metadata`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => MetadataGridModelPageResultFromJSON(jsonValue));
    }

    /**
     * get all metadata
     */
    async getAllMetadata(requestParameters: GetAllMetadataRequest): Promise<MetadataGridModelPageResult> {
        const response = await this.getAllMetadataRaw(requestParameters);
        return await response.value();
    }

    /**
     * Get metadata by id
     */
    async getSingleMetadataByIdRaw(requestParameters: GetSingleMetadataByIdRequest): Promise<runtime.ApiResponse<CustomMetadata>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getSingleMetadataById.');
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
            path: `/admin/metadata/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CustomMetadataFromJSON(jsonValue));
    }

    /**
     * Get metadata by id
     */
    async getSingleMetadataById(requestParameters: GetSingleMetadataByIdRequest): Promise<CustomMetadata> {
        const response = await this.getSingleMetadataByIdRaw(requestParameters);
        return await response.value();
    }

}
