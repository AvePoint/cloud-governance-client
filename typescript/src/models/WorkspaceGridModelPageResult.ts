/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    WorkspaceGridModel,
    WorkspaceGridModelFromJSON,
    WorkspaceGridModelFromJSONTyped,
    WorkspaceGridModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkspaceGridModelPageResult
 */
export interface WorkspaceGridModelPageResult {
    /**
     * 
     * @type {Array<WorkspaceGridModel>}
     * @memberof WorkspaceGridModelPageResult
     */
    value?: Array<WorkspaceGridModel> | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModelPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModelPageResult
     */
    nextToken?: string | null;
}

export function WorkspaceGridModelPageResultFromJSON(json: any): WorkspaceGridModelPageResult {
    return WorkspaceGridModelPageResultFromJSONTyped(json, false);
}

export function WorkspaceGridModelPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceGridModelPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(WorkspaceGridModelFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function WorkspaceGridModelPageResultToJSON(value?: WorkspaceGridModelPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(WorkspaceGridModelToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


