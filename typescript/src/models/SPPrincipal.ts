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
 * @interface SPPrincipal
 */
export interface SPPrincipal {
    /**
     * 
     * @type {number}
     * @memberof SPPrincipal
     */
    id?: number;
    /**
     * 
     * @type {string}
     * @memberof SPPrincipal
     */
    loginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPPrincipal
     */
    name?: string | null;
    /**
     * 
     * @type {SPPrincipalType}
     * @memberof SPPrincipal
     */
    principalType?: SPPrincipalType;
    /**
     * 
     * @type {string}
     * @memberof SPPrincipal
     */
    azureUserType?: string | null;
}

export function SPPrincipalFromJSON(json: any): SPPrincipal {
    return SPPrincipalFromJSONTyped(json, false);
}

export function SPPrincipalFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPPrincipal {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'loginName': !exists(json, 'loginName') ? undefined : json['loginName'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'principalType': !exists(json, 'principalType') ? undefined : SPPrincipalTypeFromJSON(json['principalType']),
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
    };
}

export function SPPrincipalToJSON(value?: SPPrincipal | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'loginName': value.loginName,
        'name': value.name,
        'principalType': SPPrincipalTypeToJSON(value.principalType),
        'azureUserType': value.azureUserType,
    };
}


