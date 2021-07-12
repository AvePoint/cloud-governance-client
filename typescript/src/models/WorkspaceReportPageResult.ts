/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    WorkspaceReport,
    WorkspaceReportFromJSON,
    WorkspaceReportFromJSONTyped,
    WorkspaceReportToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkspaceReportPageResult
 */
export interface WorkspaceReportPageResult {
    /**
     * 
     * @type {Array<WorkspaceReport>}
     * @memberof WorkspaceReportPageResult
     */
    value?: Array<WorkspaceReport> | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReportPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReportPageResult
     */
    nextToken?: string | null;
}

export function WorkspaceReportPageResultFromJSON(json: any): WorkspaceReportPageResult {
    return WorkspaceReportPageResultFromJSONTyped(json, false);
}

export function WorkspaceReportPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceReportPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(WorkspaceReportFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function WorkspaceReportPageResultToJSON(value?: WorkspaceReportPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(WorkspaceReportToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


