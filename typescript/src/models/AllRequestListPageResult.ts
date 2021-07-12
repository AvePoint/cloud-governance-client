/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AllRequestList,
    AllRequestListFromJSON,
    AllRequestListFromJSONTyped,
    AllRequestListToJSON,
} from './';

/**
 * 
 * @export
 * @interface AllRequestListPageResult
 */
export interface AllRequestListPageResult {
    /**
     * 
     * @type {Array<AllRequestList>}
     * @memberof AllRequestListPageResult
     */
    value?: Array<AllRequestList> | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestListPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestListPageResult
     */
    nextToken?: string | null;
}

export function AllRequestListPageResultFromJSON(json: any): AllRequestListPageResult {
    return AllRequestListPageResultFromJSONTyped(json, false);
}

export function AllRequestListPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): AllRequestListPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(AllRequestListFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function AllRequestListPageResultToJSON(value?: AllRequestListPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(AllRequestListToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


