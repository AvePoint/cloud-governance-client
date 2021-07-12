/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ObjectPermissionManagementModel,
    ObjectPermissionManagementModelFromJSON,
    ObjectPermissionManagementModelFromJSONTyped,
    ObjectPermissionManagementModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface PermissionManagementModel
 */
export interface PermissionManagementModel {
    /**
     * 
     * @type {boolean}
     * @memberof PermissionManagementModel
     */
    isUniquePermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof PermissionManagementModel
     */
    isPermissionInheritanceChanged?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof PermissionManagementModel
     */
    isCopyPermissionsFromParent?: boolean;
    /**
     * 
     * @type {string}
     * @memberof PermissionManagementModel
     */
    inheritedSiteUrl?: string | null;
    /**
     * 
     * @type {Array<ObjectPermissionManagementModel>}
     * @memberof PermissionManagementModel
     */
    permissionItems?: Array<ObjectPermissionManagementModel> | null;
}

export function PermissionManagementModelFromJSON(json: any): PermissionManagementModel {
    return PermissionManagementModelFromJSONTyped(json, false);
}

export function PermissionManagementModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionManagementModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isUniquePermission': !exists(json, 'isUniquePermission') ? undefined : json['isUniquePermission'],
        'isPermissionInheritanceChanged': !exists(json, 'isPermissionInheritanceChanged') ? undefined : json['isPermissionInheritanceChanged'],
        'isCopyPermissionsFromParent': !exists(json, 'isCopyPermissionsFromParent') ? undefined : json['isCopyPermissionsFromParent'],
        'inheritedSiteUrl': !exists(json, 'inheritedSiteUrl') ? undefined : json['inheritedSiteUrl'],
        'permissionItems': !exists(json, 'permissionItems') ? undefined : (json['permissionItems'] === null ? null : (json['permissionItems'] as Array<any>).map(ObjectPermissionManagementModelFromJSON)),
    };
}

export function PermissionManagementModelToJSON(value?: PermissionManagementModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isUniquePermission': value.isUniquePermission,
        'isPermissionInheritanceChanged': value.isPermissionInheritanceChanged,
        'isCopyPermissionsFromParent': value.isCopyPermissionsFromParent,
        'inheritedSiteUrl': value.inheritedSiteUrl,
        'permissionItems': value.permissionItems === undefined ? undefined : (value.permissionItems === null ? null : (value.permissionItems as Array<any>).map(ObjectPermissionManagementModelToJSON)),
    };
}


