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
 * 
 * @export
 * @interface ServiceGroupWithPermissions
 */
export interface ServiceGroupWithPermissions {
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceGroupWithPermissions
     */
    usersAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceGroupWithPermissions
     */
    groupOwnerAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceGroupWithPermissions
     */
    allowChangePermissionLevel?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceGroupWithPermissions
     */
    removable?: boolean;
    /**
     * Group name
     * @type {string}
     * @memberof ServiceGroupWithPermissions
     */
    name?: string | null;
    /**
     * Group description
     * @type {string}
     * @memberof ServiceGroupWithPermissions
     */
    description?: string | null;
    /**
     * The list of the group users
     * @type {Array<GroupUser>}
     * @memberof ServiceGroupWithPermissions
     */
    users?: Array<GroupUser> | null;
    /**
     * The list of the group permission levels
     * @type {Array<PermissionLevel>}
     * @memberof ServiceGroupWithPermissions
     */
    permissionLevels?: Array<PermissionLevel> | null;
    /**
     * Group owner information
     * @type {ApiUser}
     * @memberof ServiceGroupWithPermissions
     */
    groupOwner?: ApiUser | null;
    /**
     * Group owner type
     * @type {GroupOwnerType}
     * @memberof ServiceGroupWithPermissions
     */
    groupOwnerType?: GroupOwnerType;
    /**
     * Built-in group type
     * @type {SharePointBuildInGroupType}
     * @memberof ServiceGroupWithPermissions
     */
    buildInGroupType?: SharePointBuildInGroupType;
}

export function ServiceGroupWithPermissionsFromJSON(json: any): ServiceGroupWithPermissions {
    return ServiceGroupWithPermissionsFromJSONTyped(json, false);
}

export function ServiceGroupWithPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceGroupWithPermissions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'usersAssignBy': !exists(json, 'usersAssignBy') ? undefined : AssignByFromJSON(json['usersAssignBy']),
        'groupOwnerAssignBy': !exists(json, 'groupOwnerAssignBy') ? undefined : AssignByFromJSON(json['groupOwnerAssignBy']),
        'allowChangePermissionLevel': !exists(json, 'allowChangePermissionLevel') ? undefined : json['allowChangePermissionLevel'],
        'removable': !exists(json, 'removable') ? undefined : json['removable'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'users': !exists(json, 'users') ? undefined : (json['users'] === null ? null : (json['users'] as Array<any>).map(GroupUserFromJSON)),
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : (json['permissionLevels'] === null ? null : (json['permissionLevels'] as Array<any>).map(PermissionLevelFromJSON)),
        'groupOwner': !exists(json, 'groupOwner') ? undefined : ApiUserFromJSON(json['groupOwner']),
        'groupOwnerType': !exists(json, 'groupOwnerType') ? undefined : GroupOwnerTypeFromJSON(json['groupOwnerType']),
        'buildInGroupType': !exists(json, 'buildInGroupType') ? undefined : SharePointBuildInGroupTypeFromJSON(json['buildInGroupType']),
    };
}

export function ServiceGroupWithPermissionsToJSON(value?: ServiceGroupWithPermissions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'usersAssignBy': AssignByToJSON(value.usersAssignBy),
        'groupOwnerAssignBy': AssignByToJSON(value.groupOwnerAssignBy),
        'allowChangePermissionLevel': value.allowChangePermissionLevel,
        'removable': value.removable,
        'name': value.name,
        'description': value.description,
        'users': value.users === undefined ? undefined : (value.users === null ? null : (value.users as Array<any>).map(GroupUserToJSON)),
        'permissionLevels': value.permissionLevels === undefined ? undefined : (value.permissionLevels === null ? null : (value.permissionLevels as Array<any>).map(PermissionLevelToJSON)),
        'groupOwner': ApiUserToJSON(value.groupOwner),
        'groupOwnerType': GroupOwnerTypeToJSON(value.groupOwnerType),
        'buildInGroupType': SharePointBuildInGroupTypeToJSON(value.buildInGroupType),
    };
}


