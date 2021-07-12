/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Permission level model
 * @export
 * @interface PermissionLevel
 */
export interface PermissionLevel {
    /**
     * Permission level ID
     * @type {string}
     * @memberof PermissionLevel
     */
    id?: string;
    /**
     * Permission ID in SharePoint
     * @type {number}
     * @memberof PermissionLevel
     */
    idInSharePoint?: number;
    /**
     * Permission name
     * @type {string}
     * @memberof PermissionLevel
     */
    name?: string | null;
    /**
     * Permission description
     * @type {string}
     * @memberof PermissionLevel
     */
    readonly description?: string | null;
    /**
     * Whether the permission is excluded.
     * @type {boolean}
     * @memberof PermissionLevel
     */
    readonly isExcluded?: boolean;
    /**
     * Permission type
     * @type {number}
     * @memberof PermissionLevel
     */
    readonly type?: number;
}

export function PermissionLevelFromJSON(json: any): PermissionLevel {
    return PermissionLevelFromJSONTyped(json, false);
}

export function PermissionLevelFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionLevel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'idInSharePoint': !exists(json, 'idInSharePoint') ? undefined : json['idInSharePoint'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'isExcluded': !exists(json, 'isExcluded') ? undefined : json['isExcluded'],
        'type': !exists(json, 'type') ? undefined : json['type'],
    };
}

export function PermissionLevelToJSON(value?: PermissionLevel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'idInSharePoint': value.idInSharePoint,
        'name': value.name,
    };
}


