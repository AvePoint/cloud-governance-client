/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GrantPermissionGroup,
    GrantPermissionGroupFromJSON,
    GrantPermissionGroupFromJSONTyped,
    GrantPermissionGroupToJSON,
    IntModel,
    IntModelFromJSON,
    IntModelFromJSONTyped,
    IntModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionRequestPermissionSettings
 */
export interface GrantPermissionRequestPermissionSettings {
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionRequestPermissionSettings
     */
    isBreakInheritance?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionRequestPermissionSettings
     */
    isGrantPermissionDirectly?: boolean;
    /**
     * 
     * @type {GrantPermissionGroup}
     * @memberof GrantPermissionRequestPermissionSettings
     */
    selectedSPGroup?: GrantPermissionGroup | null;
    /**
     * 
     * @type {Array<IntModel>}
     * @memberof GrantPermissionRequestPermissionSettings
     */
    selectedPermissionLevels?: Array<IntModel> | null;
}

export function GrantPermissionRequestPermissionSettingsFromJSON(json: any): GrantPermissionRequestPermissionSettings {
    return GrantPermissionRequestPermissionSettingsFromJSONTyped(json, false);
}

export function GrantPermissionRequestPermissionSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionRequestPermissionSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isBreakInheritance': !exists(json, 'isBreakInheritance') ? undefined : json['isBreakInheritance'],
        'isGrantPermissionDirectly': !exists(json, 'isGrantPermissionDirectly') ? undefined : json['isGrantPermissionDirectly'],
        'selectedSPGroup': !exists(json, 'selectedSPGroup') ? undefined : GrantPermissionGroupFromJSON(json['selectedSPGroup']),
        'selectedPermissionLevels': !exists(json, 'selectedPermissionLevels') ? undefined : (json['selectedPermissionLevels'] === null ? null : (json['selectedPermissionLevels'] as Array<any>).map(IntModelFromJSON)),
    };
}

export function GrantPermissionRequestPermissionSettingsToJSON(value?: GrantPermissionRequestPermissionSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isBreakInheritance': value.isBreakInheritance,
        'isGrantPermissionDirectly': value.isGrantPermissionDirectly,
        'selectedSPGroup': GrantPermissionGroupToJSON(value.selectedSPGroup),
        'selectedPermissionLevels': value.selectedPermissionLevels === undefined ? undefined : (value.selectedPermissionLevels === null ? null : (value.selectedPermissionLevels as Array<any>).map(IntModelToJSON)),
    };
}


