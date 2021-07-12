/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
} from './';

/**
 * 
 * @export
 * @interface PermissionSettings
 */
export interface PermissionSettings {
    /**
     * 
     * @type {boolean}
     * @memberof PermissionSettings
     */
    allowGrantUserPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof PermissionSettings
     */
    preventGrantSpecificPermissionLevels?: boolean;
    /**
     * 
     * @type {Array<PermissionLevel>}
     * @memberof PermissionSettings
     */
    preventPermissionLevles?: Array<PermissionLevel> | null;
}

export function PermissionSettingsFromJSON(json: any): PermissionSettings {
    return PermissionSettingsFromJSONTyped(json, false);
}

export function PermissionSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'allowGrantUserPermission': !exists(json, 'allowGrantUserPermission') ? undefined : json['allowGrantUserPermission'],
        'preventGrantSpecificPermissionLevels': !exists(json, 'preventGrantSpecificPermissionLevels') ? undefined : json['preventGrantSpecificPermissionLevels'],
        'preventPermissionLevles': !exists(json, 'preventPermissionLevles') ? undefined : (json['preventPermissionLevles'] === null ? null : (json['preventPermissionLevles'] as Array<any>).map(PermissionLevelFromJSON)),
    };
}

export function PermissionSettingsToJSON(value?: PermissionSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'allowGrantUserPermission': value.allowGrantUserPermission,
        'preventGrantSpecificPermissionLevels': value.preventGrantSpecificPermissionLevels,
        'preventPermissionLevles': value.preventPermissionLevles === undefined ? undefined : (value.preventPermissionLevles === null ? null : (value.preventPermissionLevles as Array<any>).map(PermissionLevelToJSON)),
    };
}


