/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    MetadataDisplayType,
    MetadataDisplayTypeFromJSON,
    MetadataDisplayTypeFromJSONTyped,
    MetadataDisplayTypeToJSON,
    MetadataFieldType,
    MetadataFieldTypeFromJSON,
    MetadataFieldTypeFromJSONTyped,
    MetadataFieldTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface MetadataGridModel
 */
export interface MetadataGridModel {
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    createdBy?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    createdByDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    description?: string | null;
    /**
     * 
     * @type {MetadataFieldType}
     * @memberof MetadataGridModel
     */
    fieldType?: MetadataFieldType;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    metadataValue?: string | null;
    /**
     * 
     * @type {MetadataDisplayType}
     * @memberof MetadataGridModel
     */
    showInReportType?: MetadataDisplayType;
    /**
     * 
     * @type {string}
     * @memberof MetadataGridModel
     */
    showInReportTypeDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof MetadataGridModel
     */
    lastModifiedTime?: Date;
}

export function MetadataGridModelFromJSON(json: any): MetadataGridModel {
    return MetadataGridModelFromJSONTyped(json, false);
}

export function MetadataGridModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataGridModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'createdBy': !exists(json, 'createdBy') ? undefined : json['createdBy'],
        'createdByDisplayName': !exists(json, 'createdByDisplayName') ? undefined : json['createdByDisplayName'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'fieldType': !exists(json, 'fieldType') ? undefined : MetadataFieldTypeFromJSON(json['fieldType']),
        'metadataValue': !exists(json, 'metadataValue') ? undefined : json['metadataValue'],
        'showInReportType': !exists(json, 'showInReportType') ? undefined : MetadataDisplayTypeFromJSON(json['showInReportType']),
        'showInReportTypeDescription': !exists(json, 'showInReportTypeDescription') ? undefined : json['showInReportTypeDescription'],
        'lastModifiedTime': !exists(json, 'lastModifiedTime') ? undefined : (new Date(json['lastModifiedTime'])),
    };
}

export function MetadataGridModelToJSON(value?: MetadataGridModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'createdBy': value.createdBy,
        'createdByDisplayName': value.createdByDisplayName,
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'fieldType': MetadataFieldTypeToJSON(value.fieldType),
        'metadataValue': value.metadataValue,
        'showInReportType': MetadataDisplayTypeToJSON(value.showInReportType),
        'showInReportTypeDescription': value.showInReportTypeDescription,
        'lastModifiedTime': value.lastModifiedTime === undefined ? undefined : (value.lastModifiedTime.toISOString()),
    };
}


