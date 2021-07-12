/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceGroupWithPermissions,
    ServiceGroupWithPermissionsFromJSON,
    ServiceGroupWithPermissionsFromJSONTyped,
    ServiceGroupWithPermissionsToJSON,
    ServiceUserWithPermissions,
    ServiceUserWithPermissionsFromJSON,
    ServiceUserWithPermissionsFromJSONTyped,
    ServiceUserWithPermissionsToJSON,
} from './';

/**
 * 
 * @export
 * @interface UserGroupPermissions
 */
export interface UserGroupPermissions {
    /**
     * 
     * @type {Array<ServiceUserWithPermissions>}
     * @memberof UserGroupPermissions
     */
    userPermissions?: Array<ServiceUserWithPermissions> | null;
    /**
     * 
     * @type {Array<ServiceGroupWithPermissions>}
     * @memberof UserGroupPermissions
     */
    groupPermissions?: Array<ServiceGroupWithPermissions> | null;
}

export function UserGroupPermissionsFromJSON(json: any): UserGroupPermissions {
    return UserGroupPermissionsFromJSONTyped(json, false);
}

export function UserGroupPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserGroupPermissions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'userPermissions': !exists(json, 'userPermissions') ? undefined : (json['userPermissions'] === null ? null : (json['userPermissions'] as Array<any>).map(ServiceUserWithPermissionsFromJSON)),
        'groupPermissions': !exists(json, 'groupPermissions') ? undefined : (json['groupPermissions'] === null ? null : (json['groupPermissions'] as Array<any>).map(ServiceGroupWithPermissionsFromJSON)),
    };
}

export function UserGroupPermissionsToJSON(value?: UserGroupPermissions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userPermissions': value.userPermissions === undefined ? undefined : (value.userPermissions === null ? null : (value.userPermissions as Array<any>).map(ServiceUserWithPermissionsToJSON)),
        'groupPermissions': value.groupPermissions === undefined ? undefined : (value.groupPermissions === null ? null : (value.groupPermissions as Array<any>).map(ServiceGroupWithPermissionsToJSON)),
    };
}


