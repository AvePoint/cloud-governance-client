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
 * @interface ReportMetadata
 */
export interface ReportMetadata {
    /**
     * 
     * @type {string}
     * @memberof ReportMetadata
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ReportMetadata
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ReportMetadata
     */
    value?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ReportMetadata
     */
    displayValue?: string | null;
    /**
     * 
     * @type {MetadataFieldType}
     * @memberof ReportMetadata
     */
    type?: MetadataFieldType;
}

export function ReportMetadataFromJSON(json: any): ReportMetadata {
    return ReportMetadataFromJSONTyped(json, false);
}

export function ReportMetadataFromJSONTyped(json: any, ignoreDiscriminator: boolean): ReportMetadata {
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

export function ReportMetadataToJSON(value?: ReportMetadata | null): any {
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


