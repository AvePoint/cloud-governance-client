/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface RequestMetadataListChangedProperty
 */
export interface RequestMetadataListChangedProperty {
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof RequestMetadataListChangedProperty
     */
    changeValue?: Array<RequestMetadata> | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof RequestMetadataListChangedProperty
     */
    originalValue?: Array<RequestMetadata> | null;
}

export function RequestMetadataListChangedPropertyFromJSON(json: any): RequestMetadataListChangedProperty {
    return RequestMetadataListChangedPropertyFromJSONTyped(json, false);
}

export function RequestMetadataListChangedPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestMetadataListChangedProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeValue': !exists(json, 'changeValue') ? undefined : (json['changeValue'] === null ? null : (json['changeValue'] as Array<any>).map(RequestMetadataFromJSON)),
        'originalValue': !exists(json, 'originalValue') ? undefined : (json['originalValue'] === null ? null : (json['originalValue'] as Array<any>).map(RequestMetadataFromJSON)),
    };
}

export function RequestMetadataListChangedPropertyToJSON(value?: RequestMetadataListChangedProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeValue': value.changeValue === undefined ? undefined : (value.changeValue === null ? null : (value.changeValue as Array<any>).map(RequestMetadataToJSON)),
        'originalValue': value.originalValue === undefined ? undefined : (value.originalValue === null ? null : (value.originalValue as Array<any>).map(RequestMetadataToJSON)),
    };
}


