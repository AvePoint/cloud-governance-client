/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    TaskReport,
    TaskReportFromJSON,
    TaskReportFromJSONTyped,
    TaskReportToJSON,
} from './';

/**
 * 
 * @export
 * @interface TaskReportPageResult
 */
export interface TaskReportPageResult {
    /**
     * 
     * @type {Array<TaskReport>}
     * @memberof TaskReportPageResult
     */
    value?: Array<TaskReport> | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReportPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReportPageResult
     */
    nextToken?: string | null;
}

export function TaskReportPageResultFromJSON(json: any): TaskReportPageResult {
    return TaskReportPageResultFromJSONTyped(json, false);
}

export function TaskReportPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskReportPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(TaskReportFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function TaskReportPageResultToJSON(value?: TaskReportPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(TaskReportToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


