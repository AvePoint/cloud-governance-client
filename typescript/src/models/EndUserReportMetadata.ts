/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    MetadataFieldType,
    MetadataFieldTypeFromJSON,
    MetadataFieldTypeFromJSONTyped,
    MetadataFieldTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface EndUserReportMetadata
 */
export interface EndUserReportMetadata {
    /**
     * 
     * @type {string}
     * @memberof EndUserReportMetadata
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof EndUserReportMetadata
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof EndUserReportMetadata
     */
    value?: string | null;
    /**
     * 
     * @type {string}
     * @memberof EndUserReportMetadata
     */
    displayValue?: string | null;
    /**
     * 
     * @type {MetadataFieldType}
     * @memberof EndUserReportMetadata
     */
    type?: MetadataFieldType;
}

export function EndUserReportMetadataFromJSON(json: any): EndUserReportMetadata {
    return EndUserReportMetadataFromJSONTyped(json, false);
}

export function EndUserReportMetadataFromJSONTyped(json: any, ignoreDiscriminator: boolean): EndUserReportMetadata {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'value': !exists(json, 'value') ? undefined : json['value'],
        'displayValue': !exists(json, 'displayValue') ? undefined : json['displayValue'],
        'type': !exists(json, 'type') ? undefined : MetadataFieldTypeFromJSON(json['type']),
    };
}

export function EndUserReportMetadataToJSON(value?: EndUserReportMetadata | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'value': value.value,
        'displayValue': value.displayValue,
        'type': MetadataFieldTypeToJSON(value.type),
    };
}


