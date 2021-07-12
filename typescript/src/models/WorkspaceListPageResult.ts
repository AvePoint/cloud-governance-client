/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    WorkspaceList,
    WorkspaceListFromJSON,
    WorkspaceListFromJSONTyped,
    WorkspaceListToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkspaceListPageResult
 */
export interface WorkspaceListPageResult {
    /**
     * 
     * @type {Array<WorkspaceList>}
     * @memberof WorkspaceListPageResult
     */
    value?: Array<WorkspaceList> | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceListPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceListPageResult
     */
    nextToken?: string | null;
}

export function WorkspaceListPageResultFromJSON(json: any): WorkspaceListPageResult {
    return WorkspaceListPageResultFromJSONTyped(json, false);
}

export function WorkspaceListPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceListPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(WorkspaceListFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function WorkspaceListPageResultToJSON(value?: WorkspaceListPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(WorkspaceListToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


