/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    SPPrincipalType,
    SPPrincipalTypeFromJSON,
    SPPrincipalTypeFromJSONTyped,
    SPPrincipalTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface SPRoleAssignment
 */
export interface SPRoleAssignment {
    /**
     * 
     * @type {number}
     * @memberof SPRoleAssignment
     */
    id?: number;
    /**
     * 
     * @type {string}
     * @memberof SPRoleAssignment
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPRoleAssignment
     */
    loginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPRoleAssignment
     */
    azureUserType?: string | null;
    /**
     * 
     * @type {SPPrincipalType}
     * @memberof SPRoleAssignment
     */
    principalType?: SPPrincipalType;
    /**
     * 
     * @type {string}
     * @memberof SPRoleAssignment
     */
    principalTypeDescription?: string | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof SPRoleAssignment
     */
    permissionLevels?: Array<string> | null;
}

export function SPRoleAssignmentFromJSON(json: any): SPRoleAssignment {
    return SPRoleAssignmentFromJSONTyped(json, false);
}

export function SPRoleAssignmentFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPRoleAssignment {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'loginName': !exists(json, 'loginName') ? undefined : json['loginName'],
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
        'principalType': !exists(json, 'principalType') ? undefined : SPPrincipalTypeFromJSON(json['principalType']),
        'principalTypeDescription': !exists(json, 'principalTypeDescription') ? undefined : json['principalTypeDescription'],
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : json['permissionLevels'],
    };
}

export function SPRoleAssignmentToJSON(value?: SPRoleAssignment | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'loginName': value.loginName,
        'azureUserType': value.azureUserType,
        'principalType': SPPrincipalTypeToJSON(value.principalType),
        'principalTypeDescription': value.principalTypeDescription,
        'permissionLevels': value.permissionLevels,
    };
}


