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
    ExternalUserType,
    ExternalUserTypeFromJSON,
    ExternalUserTypeFromJSONTyped,
    ExternalUserTypeToJSON,
    GrantPermissionModel,
    GrantPermissionModelFromJSON,
    GrantPermissionModelFromJSONTyped,
    GrantPermissionModelToJSON,
    ManagePermissionAction,
    ManagePermissionActionFromJSON,
    ManagePermissionActionFromJSONTyped,
    ManagePermissionActionToJSON,
    SPPrincipalType,
    SPPrincipalTypeFromJSON,
    SPPrincipalTypeFromJSONTyped,
    SPPrincipalTypeToJSON,
    SharingEnabledUser,
    SharingEnabledUserFromJSON,
    SharingEnabledUserFromJSONTyped,
    SharingEnabledUserToJSON,
} from './';

/**
 * 
 * @export
 * @interface ObjectPermissionManagementModel
 */
export interface ObjectPermissionManagementModel {
    /**
     * 
     * @type {SPPrincipalType}
     * @memberof ObjectPermissionManagementModel
     */
    objectType?: SPPrincipalType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ObjectPermissionManagementModel
     */
    objectInfo?: ApiUser | null;
    /**
     * 
     * @type {ManagePermissionAction}
     * @memberof ObjectPermissionManagementModel
     */
    action?: ManagePermissionAction;
    /**
     * 
     * @type {Array<string>}
     * @memberof ObjectPermissionManagementModel
     */
    permissions?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof ObjectPermissionManagementModel
     */
    originalPermissions?: Array<string> | null;
    /**
     * 
     * @type {ExternalUserType}
     * @memberof ObjectPermissionManagementModel
     */
    externalUserType?: ExternalUserType;
    /**
     * 
     * @type {Array<SharingEnabledUser>}
     * @memberof ObjectPermissionManagementModel
     */
    members?: Array<SharingEnabledUser> | null;
    /**
     * 
     * @type {GrantPermissionModel}
     * @memberof ObjectPermissionManagementModel
     */
    grantPermissionSetting?: GrantPermissionModel | null;
    /**
     * 
     * @type {string}
     * @memberof ObjectPermissionManagementModel
     */
    originalName?: string | null;
}

export function ObjectPermissionManagementModelFromJSON(json: any): ObjectPermissionManagementModel {
    return ObjectPermissionManagementModelFromJSONTyped(json, false);
}

export function ObjectPermissionManagementModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): ObjectPermissionManagementModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'objectType': !exists(json, 'objectType') ? undefined : SPPrincipalTypeFromJSON(json['objectType']),
        'objectInfo': !exists(json, 'objectInfo') ? undefined : ApiUserFromJSON(json['objectInfo']),
        'action': !exists(json, 'action') ? undefined : ManagePermissionActionFromJSON(json['action']),
        'permissions': !exists(json, 'permissions') ? undefined : json['permissions'],
        'originalPermissions': !exists(json, 'originalPermissions') ? undefined : json['originalPermissions'],
        'externalUserType': !exists(json, 'externalUserType') ? undefined : ExternalUserTypeFromJSON(json['externalUserType']),
        'members': !exists(json, 'members') ? undefined : (json['members'] === null ? null : (json['members'] as Array<any>).map(SharingEnabledUserFromJSON)),
        'grantPermissionSetting': !exists(json, 'grantPermissionSetting') ? undefined : GrantPermissionModelFromJSON(json['grantPermissionSetting']),
        'originalName': !exists(json, 'originalName') ? undefined : json['originalName'],
    };
}

export function ObjectPermissionManagementModelToJSON(value?: ObjectPermissionManagementModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'objectType': SPPrincipalTypeToJSON(value.objectType),
        'objectInfo': ApiUserToJSON(value.objectInfo),
        'action': ManagePermissionActionToJSON(value.action),
        'permissions': value.permissions,
        'originalPermissions': value.originalPermissions,
        'externalUserType': ExternalUserTypeToJSON(value.externalUserType),
        'members': value.members === undefined ? undefined : (value.members === null ? null : (value.members as Array<any>).map(SharingEnabledUserToJSON)),
        'grantPermissionSetting': GrantPermissionModelToJSON(value.grantPermissionSetting),
        'originalName': value.originalName,
    };
}


