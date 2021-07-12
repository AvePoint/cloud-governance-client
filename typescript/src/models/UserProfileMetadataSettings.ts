/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    LookupValue,
    LookupValueFromJSON,
    LookupValueFromJSONTyped,
    LookupValueToJSON,
} from './';

/**
 * 
 * @export
 * @interface UserProfileMetadataSettings
 */
export interface UserProfileMetadataSettings {
    /**
     * 
     * @type {string}
     * @memberof UserProfileMetadataSettings
     */
    adminCenter?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserProfileMetadataSettings
     */
    valueType?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserProfileMetadataSettings
     */
    enableValueSync?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof UserProfileMetadataSettings
     */
    enableRoleValueSync?: boolean;
    /**
     * Value of Lookup to SharePoint library/list metadata.
     * @type {LookupValue}
     * @memberof UserProfileMetadataSettings
     */
    value?: LookupValue | null;
    /**
     * 
     * @type {string}
     * @memberof UserProfileMetadataSettings
     */
    property?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserProfileMetadataSettings
     */
    allowReferenceAsRoleInApprovalProcess?: boolean;
}

export function UserProfileMetadataSettingsFromJSON(json: any): UserProfileMetadataSettings {
    return UserProfileMetadataSettingsFromJSONTyped(json, false);
}

export function UserProfileMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserProfileMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'adminCenter': !exists(json, 'adminCenter') ? undefined : json['adminCenter'],
        'valueType': !exists(json, 'valueType') ? undefined : json['valueType'],
        'enableValueSync': !exists(json, 'enableValueSync') ? undefined : json['enableValueSync'],
        'enableRoleValueSync': !exists(json, 'enableRoleValueSync') ? undefined : json['enableRoleValueSync'],
        'value': !exists(json, 'value') ? undefined : LookupValueFromJSON(json['value']),
        'property': !exists(json, 'property') ? undefined : json['property'],
        'allowReferenceAsRoleInApprovalProcess': !exists(json, 'allowReferenceAsRoleInApprovalProcess') ? undefined : json['allowReferenceAsRoleInApprovalProcess'],
    };
}

export function UserProfileMetadataSettingsToJSON(value?: UserProfileMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'adminCenter': value.adminCenter,
        'valueType': value.valueType,
        'enableValueSync': value.enableValueSync,
        'enableRoleValueSync': value.enableRoleValueSync,
        'value': LookupValueToJSON(value.value),
        'property': value.property,
        'allowReferenceAsRoleInApprovalProcess': value.allowReferenceAsRoleInApprovalProcess,
    };
}


