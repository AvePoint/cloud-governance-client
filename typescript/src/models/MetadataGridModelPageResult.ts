/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    MetadataGridModel,
    MetadataGridModelFromJSON,
    MetadataGridModelFromJSONTyped,
    MetadataGridModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface MetadataGridModelPageResult
 */
export interface MetadataGridModelPageResult {
    /**
     * 
     * @type {Array<MetadataGridModel>}
     * @memberof MetadataGridModelPageResult
     */
    value?: Array<MetadataGridModel> | null;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModelPageResult
     */
    nextLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModelPageResult
     */
    nextToken?: string | null;
}

export function MetadataGridModelPageResultFromJSON(json: any): MetadataGridModelPageResult {
    return MetadataGridModelPageResultFromJSONTyped(json, false);
}

export function MetadataGridModelPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataGridModelPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(MetadataGridModelFromJSON)),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
        'nextToken': !exists(json, 'nextToken') ? undefined : json['nextToken'],
    };
}

export function MetadataGridModelPageResultToJSON(value?: MetadataGridModelPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(MetadataGridModelToJSON)),
        'nextLink': value.nextLink,
        'nextToken': value.nextToken,
    };
}


