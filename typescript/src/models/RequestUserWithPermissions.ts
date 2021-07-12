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
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
} from './';

/**
 * User permissions model in request
 * @export
 * @interface RequestUserWithPermissions
 */
export interface RequestUserWithPermissions {
    /**
     * User information
     * @type {ApiUser}
     * @memberof RequestUserWithPermissions
     */
    user?: ApiUser | null;
    /**
     * User permission levels' information
     * @type {Array<PermissionLevel>}
     * @memberof RequestUserWithPermissions
     */
    permissionLevels?: Array<PermissionLevel> | null;
}

export function RequestUserWithPermissionsFromJSON(json: any): RequestUserWithPermissions {
    return RequestUserWithPermissionsFromJSONTyped(json, false);
}

export function RequestUserWithPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestUserWithPermissions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'user': !exists(json, 'user') ? undefined : ApiUserFromJSON(json['user']),
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : (json['permissionLevels'] === null ? null : (json['permissionLevels'] as Array<any>).map(PermissionLevelFromJSON)),
    };
}

export function RequestUserWithPermissionsToJSON(value?: RequestUserWithPermissions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'user': ApiUserToJSON(value.user),
        'permissionLevels': value.permissionLevels === undefined ? undefined : (value.permissionLevels === null ? null : (value.permissionLevels as Array<any>).map(PermissionLevelToJSON)),
    };
}


