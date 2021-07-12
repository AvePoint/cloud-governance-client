/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
} from './';

/**
 * 
 * @export
 * @interface ApiUserPageResult
 */
export interface ApiUserPageResult {
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ApiUserPageResult
     */
    value?: Array<ApiUser> | null;
    /**
     * 
     * @type {string}
     * @memberof ApiUserPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiUserPageResult
     */
    nextToken?: string | null;
}

export function ApiUserPageResultFromJSON(json: any): ApiUserPageResult {
    return ApiUserPageResultFromJSONTyped(json, false);
}

export function ApiUserPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiUserPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(ApiUserFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function ApiUserPageResultToJSON(value?: ApiUserPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(ApiUserToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


