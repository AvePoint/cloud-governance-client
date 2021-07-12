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
    TaskReportPageResult,
    TaskReportPageResultFromJSON,
    TaskReportPageResultToJSON,
    WorkspaceReportPageResult,
    WorkspaceReportPageResultFromJSON,
    WorkspaceReportPageResultToJSON,
} from '../models';

export interface GeTaskReportRequest {
    top?: number | null;
    skip?: string | null;
    nexttoken?: string | null;
}

export interface GetWorkspaceReportRequest {
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
export class ReportAdminApi extends runtime.BaseAPI {

    /**
     * get all tasks report
     */
    async geTaskReportRaw(requestParameters: GeTaskReportRequest): Promise<runtime.ApiResponse<TaskReportPageResult>> {
        const queryParameters: any = {};

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
            path: `/admin/report/tasks`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => TaskReportPageResultFromJSON(jsonValue));
    }

    /**
     * get all tasks report
     */
    async geTaskReport(requestParameters: GeTaskReportRequest): Promise<TaskReportPageResult> {
        const response = await this.geTaskReportRaw(requestParameters);
        return await response.value();
    }

    /**
     * get workspaces report
     */
    async getWorkspaceReportRaw(requestParameters: GetWorkspaceReportRequest): Promise<runtime.ApiResponse<WorkspaceReportPageResult>> {
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
            path: `/admin/report/workspaces`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => WorkspaceReportPageResultFromJSON(jsonValue));
    }

    /**
     * get workspaces report
     */
    async getWorkspaceReport(requestParameters: GetWorkspaceReportRequest): Promise<WorkspaceReportPageResult> {
        const response = await this.getWorkspaceReportRaw(requestParameters);
        return await response.value();
    }

}
