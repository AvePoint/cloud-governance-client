/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    UserLevelRestrictionType,
    UserLevelRestrictionTypeFromJSON,
    UserLevelRestrictionTypeFromJSONTyped,
    UserLevelRestrictionTypeToJSON,
    UserManagementSourceType,
    UserManagementSourceTypeFromJSON,
    UserManagementSourceTypeFromJSONTyped,
    UserManagementSourceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManagePermissionUserSetting
 */
export interface ManagePermissionUserSetting {
    /**
     * 
     * @type {UserLevelRestrictionType}
     * @memberof ManagePermissionUserSetting
     */
    userLevelRestrictionType?: UserLevelRestrictionType;
    /**
     * 
     * @type {UserManagementSourceType}
     * @memberof ManagePermissionUserSetting
     */
    userManagementSourceType?: UserManagementSourceType;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionUserSetting
     */
    isEnableShowAADGroupMembers?: boolean;
}

export function ManagePermissionUserSettingFromJSON(json: any): ManagePermissionUserSetting {
    return ManagePermissionUserSettingFromJSONTyped(json, false);
}

export function ManagePermissionUserSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionUserSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'userLevelRestrictionType': !exists(json, 'userLevelRestrictionType') ? undefined : UserLevelRestrictionTypeFromJSON(json['userLevelRestrictionType']),
        'userManagementSourceType': !exists(json, 'userManagementSourceType') ? undefined : UserManagementSourceTypeFromJSON(json['userManagementSourceType']),
        'isEnableShowAADGroupMembers': !exists(json, 'isEnableShowAADGroupMembers') ? undefined : json['isEnableShowAADGroupMembers'],
    };
}

export function ManagePermissionUserSettingToJSON(value?: ManagePermissionUserSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userLevelRestrictionType': UserLevelRestrictionTypeToJSON(value.userLevelRestrictionType),
        'userManagementSourceType': UserManagementSourceTypeToJSON(value.userManagementSourceType),
        'isEnableShowAADGroupMembers': value.isEnableShowAADGroupMembers,
    };
}


