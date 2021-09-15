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
    WorkerJobGridModelPageResult,
    WorkerJobGridModelPageResultFromJSON,
    WorkerJobGridModelPageResultToJSON,
    WorkerJobModel,
    WorkerJobModelFromJSON,
    WorkerJobModelToJSON,
    WorkerObjectType,
    WorkerObjectTypeFromJSON,
    WorkerObjectTypeToJSON,
} from '../models';

export interface GetJobsRequest {
    filter?: string | null;
    orderby?: string | null;
    search?: string | null;
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

export interface GetRelatedJobsRequest {
    workspaceIdentity: string;
    objectType: WorkerObjectType;
}

/**
 * 
 */
export class JobsAdminApi extends runtime.BaseAPI {

    /**
     * Get worker jobs
     */
    async getJobsRaw(requestParameters: GetJobsRequest): Promise<runtime.ApiResponse<WorkerJobGridModelPageResult>> {
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
            path: `/admin/jobs`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => WorkerJobGridModelPageResultFromJSON(jsonValue));
    }

    /**
     * Get worker jobs
     */
    async getJobs(requestParameters: GetJobsRequest): Promise<WorkerJobGridModelPageResult> {
        const response = await this.getJobsRaw(requestParameters);
        return await response.value();
    }

    /**
     * Get related worker job
     */
    async getRelatedJobsRaw(requestParameters: GetRelatedJobsRequest): Promise<runtime.ApiResponse<Array<WorkerJobModel>>> {
        if (requestParameters.workspaceIdentity === null || requestParameters.workspaceIdentity === undefined) {
            throw new runtime.RequiredError('workspaceIdentity','Required parameter requestParameters.workspaceIdentity was null or undefined when calling getRelatedJobs.');
        }

        if (requestParameters.objectType === null || requestParameters.objectType === undefined) {
            throw new runtime.RequiredError('objectType','Required parameter requestParameters.objectType was null or undefined when calling getRelatedJobs.');
        }

        const queryParameters: any = {};

        if (requestParameters.workspaceIdentity !== undefined) {
            queryParameters['workspaceIdentity'] = requestParameters.workspaceIdentity;
        }

        if (requestParameters.objectType !== undefined) {
            queryParameters['objectType'] = requestParameters.objectType;
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
            path: `/admin/jobs/relations`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(WorkerJobModelFromJSON));
    }

    /**
     * Get related worker job
     */
    async getRelatedJobs(requestParameters: GetRelatedJobsRequest): Promise<Array<WorkerJobModel>> {
        const response = await this.getRelatedJobsRaw(requestParameters);
        return await response.value();
    }

}
