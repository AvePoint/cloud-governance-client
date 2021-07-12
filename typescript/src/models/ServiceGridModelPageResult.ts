/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceGridModel,
    ServiceGridModelFromJSON,
    ServiceGridModelFromJSONTyped,
    ServiceGridModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceGridModelPageResult
 */
export interface ServiceGridModelPageResult {
    /**
     * 
     * @type {Array<ServiceGridModel>}
     * @memberof ServiceGridModelPageResult
     */
    value?: Array<ServiceGridModel> | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModelPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModelPageResult
     */
    nextToken?: string | null;
}

export function ServiceGridModelPageResultFromJSON(json: any): ServiceGridModelPageResult {
    return ServiceGridModelPageResultFromJSONTyped(json, false);
}

export function ServiceGridModelPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceGridModelPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(ServiceGridModelFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function ServiceGridModelPageResultToJSON(value?: ServiceGridModelPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(ServiceGridModelToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


