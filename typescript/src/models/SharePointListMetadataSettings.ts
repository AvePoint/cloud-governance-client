/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    LookupListValue,
    LookupListValueFromJSON,
    LookupListValueFromJSONTyped,
    LookupListValueToJSON,
} from './';

/**
 * 
 * @export
 * @interface SharePointListMetadataSettings
 */
export interface SharePointListMetadataSettings {
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    listUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    propertyType?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    property?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    propertyName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SharePointListMetadataSettings
     */
    isAdditionalColumnEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    matchedMetadataId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    matchedMetadataName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    additionalColumn?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    additionalColumnType?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SharePointListMetadataSettings
     */
    additionalColumnName?: string | null;
    /**
     * Value of Lookup User Profile or Azure Ad metadata.
     * @type {LookupListValue}
     * @memberof SharePointListMetadataSettings
     */
    value?: LookupListValue | null;
    /**
     * 
     * @type {boolean}
     * @memberof SharePointListMetadataSettings
     */
    allowReferenceAsRoleInApprovalProcess?: boolean;
}

export function SharePointListMetadataSettingsFromJSON(json: any): SharePointListMetadataSettings {
    return SharePointListMetadataSettingsFromJSONTyped(json, false);
}

export function SharePointListMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): SharePointListMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'listUrl': !exists(json, 'listUrl') ? undefined : json['listUrl'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'propertyType': !exists(json, 'propertyType') ? undefined : json['propertyType'],
        'property': !exists(json, 'property') ? undefined : json['property'],
        'propertyName': !exists(json, 'propertyName') ? undefined : json['propertyName'],
        'isAdditionalColumnEnabled': !exists(json, 'isAdditionalColumnEnabled') ? undefined : json['isAdditionalColumnEnabled'],
        'matchedMetadataId': !exists(json, 'matchedMetadataId') ? undefined : json['matchedMetadataId'],
        'matchedMetadataName': !exists(json, 'matchedMetadataName') ? undefined : json['matchedMetadataName'],
        'additionalColumn': !exists(json, 'additionalColumn') ? undefined : json['additionalColumn'],
        'additionalColumnType': !exists(json, 'additionalColumnType') ? undefined : json['additionalColumnType'],
        'additionalColumnName': !exists(json, 'additionalColumnName') ? undefined : json['additionalColumnName'],
        'value': !exists(json, 'value') ? undefined : LookupListValueFromJSON(json['value']),
        'allowReferenceAsRoleInApprovalProcess': !exists(json, 'allowReferenceAsRoleInApprovalProcess') ? undefined : json['allowReferenceAsRoleInApprovalProcess'],
    };
}

export function SharePointListMetadataSettingsToJSON(value?: SharePointListMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'listUrl': value.listUrl,
        'webUrl': value.webUrl,
        'propertyType': value.propertyType,
        'property': value.property,
        'propertyName': value.propertyName,
        'isAdditionalColumnEnabled': value.isAdditionalColumnEnabled,
        'matchedMetadataId': value.matchedMetadataId,
        'matchedMetadataName': value.matchedMetadataName,
        'additionalColumn': value.additionalColumn,
        'additionalColumnType': value.additionalColumnType,
        'additionalColumnName': value.additionalColumnName,
        'value': LookupListValueToJSON(value.value),
        'allowReferenceAsRoleInApprovalProcess': value.allowReferenceAsRoleInApprovalProcess,
    };
}


