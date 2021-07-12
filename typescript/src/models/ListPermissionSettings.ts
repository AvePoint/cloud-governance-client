/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    RequestGroupWithPermissions,
    RequestGroupWithPermissionsFromJSON,
    RequestGroupWithPermissionsFromJSONTyped,
    RequestGroupWithPermissionsToJSON,
    RequestUserWithPermissions,
    RequestUserWithPermissionsFromJSON,
    RequestUserWithPermissionsFromJSONTyped,
    RequestUserWithPermissionsToJSON,
} from './';

/**
 * 
 * @export
 * @interface ListPermissionSettings
 */
export interface ListPermissionSettings {
    /**
     * 
     * @type {boolean}
     * @memberof ListPermissionSettings
     */
    stopInheritingPermissions?: boolean;
    /**
     * 
     * @type {Array<RequestUserWithPermissions>}
     * @memberof ListPermissionSettings
     */
    userPermissions?: Array<RequestUserWithPermissions> | null;
    /**
     * 
     * @type {Array<RequestGroupWithPermissions>}
     * @memberof ListPermissionSettings
     */
    groupPermissions?: Array<RequestGroupWithPermissions> | null;
}

export function ListPermissionSettingsFromJSON(json: any): ListPermissionSettings {
    return ListPermissionSettingsFromJSONTyped(json, false);
}

export function ListPermissionSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListPermissionSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'stopInheritingPermissions': !exists(json, 'stopInheritingPermissions') ? undefined : json['stopInheritingPermissions'],
        'userPermissions': !exists(json, 'userPermissions') ? undefined : (json['userPermissions'] === null ? null : (json['userPermissions'] as Array<any>).map(RequestUserWithPermissionsFromJSON)),
        'groupPermissions': !exists(json, 'groupPermissions') ? undefined : (json['groupPermissions'] === null ? null : (json['groupPermissions'] as Array<any>).map(RequestGroupWithPermissionsFromJSON)),
    };
}

export function ListPermissionSettingsToJSON(value?: ListPermissionSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'stopInheritingPermissions': value.stopInheritingPermissions,
        'userPermissions': value.userPermissions === undefined ? undefined : (value.userPermissions === null ? null : (value.userPermissions as Array<any>).map(RequestUserWithPermissionsToJSON)),
        'groupPermissions': value.groupPermissions === undefined ? undefined : (value.groupPermissions === null ? null : (value.groupPermissions as Array<any>).map(RequestGroupWithPermissionsToJSON)),
    };
}


