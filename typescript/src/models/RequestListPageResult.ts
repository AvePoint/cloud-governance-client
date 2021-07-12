/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    RequestList,
    RequestListFromJSON,
    RequestListFromJSONTyped,
    RequestListToJSON,
} from './';

/**
 * 
 * @export
 * @interface RequestListPageResult
 */
export interface RequestListPageResult {
    /**
     * 
     * @type {Array<RequestList>}
     * @memberof RequestListPageResult
     */
    value?: Array<RequestList> | null;
    /**
     * 
     * @type {string}
     * @memberof RequestListPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof RequestListPageResult
     */
    nextToken?: string | null;
}

export function RequestListPageResultFromJSON(json: any): RequestListPageResult {
    return RequestListPageResultFromJSONTyped(json, false);
}

export function RequestListPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestListPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(RequestListFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function RequestListPageResultToJSON(value?: RequestListPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(RequestListToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


