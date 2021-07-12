/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GuestUserGridModel,
    GuestUserGridModelFromJSON,
    GuestUserGridModelFromJSONTyped,
    GuestUserGridModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface GuestUserGridModelPageResult
 */
export interface GuestUserGridModelPageResult {
    /**
     * 
     * @type {Array<GuestUserGridModel>}
     * @memberof GuestUserGridModelPageResult
     */
    value?: Array<GuestUserGridModel> | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModelPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModelPageResult
     */
    nextToken?: string | null;
}

export function GuestUserGridModelPageResultFromJSON(json: any): GuestUserGridModelPageResult {
    return GuestUserGridModelPageResultFromJSONTyped(json, false);
}

export function GuestUserGridModelPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuestUserGridModelPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(GuestUserGridModelFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function GuestUserGridModelPageResultToJSON(value?: GuestUserGridModelPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(GuestUserGridModelToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


