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
 * @interface UserMetadataSettings
 */
export interface UserMetadataSettings {
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof UserMetadataSettings
     */
    value?: Array<ApiUser> | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserMetadataSettings
     */
    allowReferenceAsRoleInApprovalProcess?: boolean;
}

export function UserMetadataSettingsFromJSON(json: any): UserMetadataSettings {
    return UserMetadataSettingsFromJSONTyped(json, false);
}

export function UserMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(ApiUserFromJSON)),
        'allowReferenceAsRoleInApprovalProcess': !exists(json, 'allowReferenceAsRoleInApprovalProcess') ? undefined : json['allowReferenceAsRoleInApprovalProcess'],
    };
}

export function UserMetadataSettingsToJSON(value?: UserMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(ApiUserToJSON)),
        'allowReferenceAsRoleInApprovalProcess': value.allowReferenceAsRoleInApprovalProcess,
    };
}


