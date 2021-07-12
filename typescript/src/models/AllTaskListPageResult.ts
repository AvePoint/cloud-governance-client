/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AllTaskList,
    AllTaskListFromJSON,
    AllTaskListFromJSONTyped,
    AllTaskListToJSON,
} from './';

/**
 * 
 * @export
 * @interface AllTaskListPageResult
 */
export interface AllTaskListPageResult {
    /**
     * 
     * @type {Array<AllTaskList>}
     * @memberof AllTaskListPageResult
     */
    value?: Array<AllTaskList> | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskListPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskListPageResult
     */
    nextToken?: string | null;
}

export function AllTaskListPageResultFromJSON(json: any): AllTaskListPageResult {
    return AllTaskListPageResultFromJSONTyped(json, false);
}

export function AllTaskListPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): AllTaskListPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(AllTaskListFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function AllTaskListPageResultToJSON(value?: AllTaskListPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(AllTaskListToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


