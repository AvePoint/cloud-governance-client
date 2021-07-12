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
    GroupOwnerType,
    GroupOwnerTypeFromJSON,
    GroupOwnerTypeFromJSONTyped,
    GroupOwnerTypeToJSON,
    GroupUser,
    GroupUserFromJSON,
    GroupUserFromJSONTyped,
    GroupUserToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
    SharePointBuildInGroupType,
    SharePointBuildInGroupTypeFromJSON,
    SharePointBuildInGroupTypeFromJSONTyped,
    SharePointBuildInGroupTypeToJSON,
} from './';

/**
 * Group permissions model in request
 * @export
 * @interface RequestGroupWithPermissions
 */
export interface RequestGroupWithPermissions {
    /**
     * Group name
     * @type {string}
     * @memberof RequestGroupWithPermissions
     */
    name?: string | null;
    /**
     * Group description
     * @type {string}
     * @memberof RequestGroupWithPermissions
     */
    description?: string | null;
    /**
     * The list of the group users
     * @type {Array<GroupUser>}
     * @memberof RequestGroupWithPermissions
     */
    users?: Array<GroupUser> | null;
    /**
     * The list of the group permission levels
     * @type {Array<PermissionLevel>}
     * @memberof RequestGroupWithPermissions
     */
    permissionLevels?: Array<PermissionLevel> | null;
    /**
     * Group owner information
     * @type {ApiUser}
     * @memberof RequestGroupWithPermissions
     */
    groupOwner?: ApiUser | null;
    /**
     * Group owner type
     * @type {GroupOwnerType}
     * @memberof RequestGroupWithPermissions
     */
    groupOwnerType?: GroupOwnerType;
    /**
     * Built-in group type
     * @type {SharePointBuildInGroupType}
     * @memberof RequestGroupWithPermissions
     */
    buildInGroupType?: SharePointBuildInGroupType;
}

export function RequestGroupWithPermissionsFromJSON(json: any): RequestGroupWithPermissions {
    return RequestGroupWithPermissionsFromJSONTyped(json, false);
}

export function RequestGroupWithPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestGroupWithPermissions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'users': !exists(json, 'users') ? undefined : (json['users'] === null ? null : (json['users'] as Array<any>).map(GroupUserFromJSON)),
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : (json['permissionLevels'] === null ? null : (json['permissionLevels'] as Array<any>).map(PermissionLevelFromJSON)),
        'groupOwner': !exists(json, 'groupOwner') ? undefined : ApiUserFromJSON(json['groupOwner']),
        'groupOwnerType': !exists(json, 'groupOwnerType') ? undefined : GroupOwnerTypeFromJSON(json['groupOwnerType']),
        'buildInGroupType': !exists(json, 'buildInGroupType') ? undefined : SharePointBuildInGroupTypeFromJSON(json['buildInGroupType']),
    };
}

export function RequestGroupWithPermissionsToJSON(value?: RequestGroupWithPermissions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'name': value.name,
        'description': value.description,
        'users': value.users === undefined ? undefined : (value.users === null ? null : (value.users as Array<any>).map(GroupUserToJSON)),
        'permissionLevels': value.permissionLevels === undefined ? undefined : (value.permissionLevels === null ? null : (value.permissionLevels as Array<any>).map(PermissionLevelToJSON)),
        'groupOwner': ApiUserToJSON(value.groupOwner),
        'groupOwnerType': GroupOwnerTypeToJSON(value.groupOwnerType),
        'buildInGroupType': SharePointBuildInGroupTypeToJSON(value.buildInGroupType),
    };
}


