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
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceUserWithPermissions
 */
export interface ServiceUserWithPermissions {
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceUserWithPermissions
     */
    userAssignBy?: AssignBy;
    /**
     * User information
     * @type {ApiUser}
     * @memberof ServiceUserWithPermissions
     */
    user?: ApiUser | null;
    /**
     * User permission levels' information
     * @type {Array<PermissionLevel>}
     * @memberof ServiceUserWithPermissions
     */
    permissionLevels?: Array<PermissionLevel> | null;
}

export function ServiceUserWithPermissionsFromJSON(json: any): ServiceUserWithPermissions {
    return ServiceUserWithPermissionsFromJSONTyped(json, false);
}

export function ServiceUserWithPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceUserWithPermissions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'userAssignBy': !exists(json, 'userAssignBy') ? undefined : AssignByFromJSON(json['userAssignBy']),
        'user': !exists(json, 'user') ? undefined : ApiUserFromJSON(json['user']),
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : (json['permissionLevels'] === null ? null : (json['permissionLevels'] as Array<any>).map(PermissionLevelFromJSON)),
    };
}

export function ServiceUserWithPermissionsToJSON(value?: ServiceUserWithPermissions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userAssignBy': AssignByToJSON(value.userAssignBy),
        'user': ApiUserToJSON(value.user),
        'permissionLevels': value.permissionLevels === undefined ? undefined : (value.permissionLevels === null ? null : (value.permissionLevels as Array<any>).map(PermissionLevelToJSON)),
    };
}


