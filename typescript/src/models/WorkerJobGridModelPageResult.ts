/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    WorkerJobGridModel,
    WorkerJobGridModelFromJSON,
    WorkerJobGridModelFromJSONTyped,
    WorkerJobGridModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkerJobGridModelPageResult
 */
export interface WorkerJobGridModelPageResult {
    /**
     * 
     * @type {Array<WorkerJobGridModel>}
     * @memberof WorkerJobGridModelPageResult
     */
    value?: Array<WorkerJobGridModel> | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModelPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModelPageResult
     */
    nextToken?: string | null;
}

export function WorkerJobGridModelPageResultFromJSON(json: any): WorkerJobGridModelPageResult {
    return WorkerJobGridModelPageResultFromJSONTyped(json, false);
}

export function WorkerJobGridModelPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkerJobGridModelPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(WorkerJobGridModelFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function WorkerJobGridModelPageResultToJSON(value?: WorkerJobGridModelPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(WorkerJobGridModelToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


