/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    TemporaryPermissionRequestSetting,
    TemporaryPermissionRequestSettingFromJSON,
    TemporaryPermissionRequestSettingFromJSONTyped,
    TemporaryPermissionRequestSettingToJSON,
    WelcomeEmailSettings,
    WelcomeEmailSettingsFromJSON,
    WelcomeEmailSettingsFromJSONTyped,
    WelcomeEmailSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionModel
 */
export interface GrantPermissionModel {
    /**
     * 
     * @type {TemporaryPermissionRequestSetting}
     * @memberof GrantPermissionModel
     */
    permissionDurationSettings?: TemporaryPermissionRequestSetting | null;
    /**
     * 
     * @type {WelcomeEmailSettings}
     * @memberof GrantPermissionModel
     */
    welcomeEmailSettings?: WelcomeEmailSettings | null;
}

export function GrantPermissionModelFromJSON(json: any): GrantPermissionModel {
    return GrantPermissionModelFromJSONTyped(json, false);
}

export function GrantPermissionModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'permissionDurationSettings': !exists(json, 'permissionDurationSettings') ? undefined : TemporaryPermissionRequestSettingFromJSON(json['permissionDurationSettings']),
        'welcomeEmailSettings': !exists(json, 'welcomeEmailSettings') ? undefined : WelcomeEmailSettingsFromJSON(json['welcomeEmailSettings']),
    };
}

export function GrantPermissionModelToJSON(value?: GrantPermissionModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'permissionDurationSettings': TemporaryPermissionRequestSettingToJSON(value.permissionDurationSettings),
        'welcomeEmailSettings': WelcomeEmailSettingsToJSON(value.welcomeEmailSettings),
    };
}


