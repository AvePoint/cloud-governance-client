/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
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
 * @interface GrantPermissionServicePermissionSettings
 */
export interface GrantPermissionServicePermissionSettings {
    /**
     * 
     * @type {AssignBy}
     * @memberof GrantPermissionServicePermissionSettings
     */
    assignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionServicePermissionSettings
     */
    isGrantPermissionDirectly?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionServicePermissionSettings
     */
    enableExcludePermissionLevles?: boolean;
    /**
     * 
     * @type {Array<PermissionLevel>}
     * @memberof GrantPermissionServicePermissionSettings
     */
    excludedPermissionLevles?: Array<PermissionLevel> | null;
}

export function GrantPermissionServicePermissionSettingsFromJSON(json: any): GrantPermissionServicePermissionSettings {
    return GrantPermissionServicePermissionSettingsFromJSONTyped(json, false);
}

export function GrantPermissionServicePermissionSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionServicePermissionSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
        'isGrantPermissionDirectly': !exists(json, 'isGrantPermissionDirectly') ? undefined : json['isGrantPermissionDirectly'],
        'enableExcludePermissionLevles': !exists(json, 'enableExcludePermissionLevles') ? undefined : json['enableExcludePermissionLevles'],
        'excludedPermissionLevles': !exists(json, 'excludedPermissionLevles') ? undefined : (json['excludedPermissionLevles'] === null ? null : (json['excludedPermissionLevles'] as Array<any>).map(PermissionLevelFromJSON)),
    };
}

export function GrantPermissionServicePermissionSettingsToJSON(value?: GrantPermissionServicePermissionSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'assignBy': AssignByToJSON(value.assignBy),
        'isGrantPermissionDirectly': value.isGrantPermissionDirectly,
        'enableExcludePermissionLevles': value.enableExcludePermissionLevles,
        'excludedPermissionLevles': value.excludedPermissionLevles === undefined ? undefined : (value.excludedPermissionLevles === null ? null : (value.excludedPermissionLevles as Array<any>).map(PermissionLevelToJSON)),
    };
}


