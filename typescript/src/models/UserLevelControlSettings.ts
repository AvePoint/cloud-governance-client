/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    UserLevelControlMode,
    UserLevelControlModeFromJSON,
    UserLevelControlModeFromJSONTyped,
    UserLevelControlModeToJSON,
} from './';

/**
 * 
 * @export
 * @interface UserLevelControlSettings
 */
export interface UserLevelControlSettings {
    /**
     * 
     * @type {UserLevelControlMode}
     * @memberof UserLevelControlSettings
     */
    userLevelControlMode?: UserLevelControlMode;
    /**
     * 
     * @type {boolean}
     * @memberof UserLevelControlSettings
     */
    isSetRequesterAsDefaultEnabled?: boolean;
}

export function UserLevelControlSettingsFromJSON(json: any): UserLevelControlSettings {
    return UserLevelControlSettingsFromJSONTyped(json, false);
}

export function UserLevelControlSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserLevelControlSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'userLevelControlMode': !exists(json, 'userLevelControlMode') ? undefined : UserLevelControlModeFromJSON(json['userLevelControlMode']),
        'isSetRequesterAsDefaultEnabled': !exists(json, 'isSetRequesterAsDefaultEnabled') ? undefined : json['isSetRequesterAsDefaultEnabled'],
    };
}

export function UserLevelControlSettingsToJSON(value?: UserLevelControlSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userLevelControlMode': UserLevelControlModeToJSON(value.userLevelControlMode),
        'isSetRequesterAsDefaultEnabled': value.isSetRequesterAsDefaultEnabled,
    };
}


