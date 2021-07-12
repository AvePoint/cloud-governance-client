/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceList,
    ServiceListFromJSON,
    ServiceListFromJSONTyped,
    ServiceListToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceListPageResult
 */
export interface ServiceListPageResult {
    /**
     * 
     * @type {Array<ServiceList>}
     * @memberof ServiceListPageResult
     */
    value?: Array<ServiceList> | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceListPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceListPageResult
     */
    nextToken?: string | null;
}

export function ServiceListPageResultFromJSON(json: any): ServiceListPageResult {
    return ServiceListPageResultFromJSONTyped(json, false);
}

export function ServiceListPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceListPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(ServiceListFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function ServiceListPageResultToJSON(value?: ServiceListPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(ServiceListToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


