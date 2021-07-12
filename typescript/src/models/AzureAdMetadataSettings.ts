/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    LookupValue,
    LookupValueFromJSON,
    LookupValueFromJSONTyped,
    LookupValueToJSON,
} from './';

/**
 * 
 * @export
 * @interface AzureAdMetadataSettings
 */
export interface AzureAdMetadataSettings {
    /**
     * 
     * @type {GuidModel}
     * @memberof AzureAdMetadataSettings
     */
    office365Tenant?: GuidModel | null;
    /**
     * 
     * @type {boolean}
     * @memberof AzureAdMetadataSettings
     */
    useBuiltInProperty?: boolean;
    /**
     * Value of Lookup to SharePoint library/list metadata.
     * @type {LookupValue}
     * @memberof AzureAdMetadataSettings
     */
    value?: LookupValue | null;
    /**
     * 
     * @type {string}
     * @memberof AzureAdMetadataSettings
     */
    property?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof AzureAdMetadataSettings
     */
    allowReferenceAsRoleInApprovalProcess?: boolean;
}

export function AzureAdMetadataSettingsFromJSON(json: any): AzureAdMetadataSettings {
    return AzureAdMetadataSettingsFromJSONTyped(json, false);
}

export function AzureAdMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): AzureAdMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'office365Tenant': !exists(json, 'office365Tenant') ? undefined : GuidModelFromJSON(json['office365Tenant']),
        'useBuiltInProperty': !exists(json, 'useBuiltInProperty') ? undefined : json['useBuiltInProperty'],
        'value': !exists(json, 'value') ? undefined : LookupValueFromJSON(json['value']),
        'property': !exists(json, 'property') ? undefined : json['property'],
        'allowReferenceAsRoleInApprovalProcess': !exists(json, 'allowReferenceAsRoleInApprovalProcess') ? undefined : json['allowReferenceAsRoleInApprovalProcess'],
    };
}

export function AzureAdMetadataSettingsToJSON(value?: AzureAdMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'office365Tenant': GuidModelToJSON(value.office365Tenant),
        'useBuiltInProperty': value.useBuiltInProperty,
        'value': LookupValueToJSON(value.value),
        'property': value.property,
        'allowReferenceAsRoleInApprovalProcess': value.allowReferenceAsRoleInApprovalProcess,
    };
}


