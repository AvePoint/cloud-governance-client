/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    TaskList,
    TaskListFromJSON,
    TaskListFromJSONTyped,
    TaskListToJSON,
} from './';

/**
 * 
 * @export
 * @interface TaskListPageResult
 */
export interface TaskListPageResult {
    /**
     * 
     * @type {Array<TaskList>}
     * @memberof TaskListPageResult
     */
    value?: Array<TaskList> | null;
    /**
     * 
     * @type {string}
     * @memberof TaskListPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskListPageResult
     */
    nextToken?: string | null;
}

export function TaskListPageResultFromJSON(json: any): TaskListPageResult {
    return TaskListPageResultFromJSONTyped(json, false);
}

export function TaskListPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskListPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(TaskListFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function TaskListPageResultToJSON(value?: TaskListPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(TaskListToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


