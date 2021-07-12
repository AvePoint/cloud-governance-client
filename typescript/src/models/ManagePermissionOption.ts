/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ManagePermissionGrantSetting,
    ManagePermissionGrantSettingFromJSON,
    ManagePermissionGrantSettingFromJSONTyped,
    ManagePermissionGrantSettingToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManagePermissionOption
 */
export interface ManagePermissionOption {
    /**
     * 
     * @type {ManagePermissionGrantSetting}
     * @memberof ManagePermissionOption
     */
    grantPermissionSetting?: ManagePermissionGrantSetting | null;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionOption
     */
    isEnableEditPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionOption
     */
    isEnableRemovePermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionOption
     */
    isEnableStopInheritPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionOption
     */
    isEnableDeleteUniquePermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionOption
     */
    isEnableExcludePermissionLevel?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionOption
     */
    isHideExcludePermissionItem?: boolean;
    /**
     * 
     * @type {Array<PermissionLevel>}
     * @memberof ManagePermissionOption
     */
    excludedPermissionLevles?: Array<PermissionLevel> | null;
}

export function ManagePermissionOptionFromJSON(json: any): ManagePermissionOption {
    return ManagePermissionOptionFromJSONTyped(json, false);
}

export function ManagePermissionOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionOption {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'grantPermissionSetting': !exists(json, 'grantPermissionSetting') ? undefined : ManagePermissionGrantSettingFromJSON(json['grantPermissionSetting']),
        'isEnableEditPermission': !exists(json, 'isEnableEditPermission') ? undefined : json['isEnableEditPermission'],
        'isEnableRemovePermission': !exists(json, 'isEnableRemovePermission') ? undefined : json['isEnableRemovePermission'],
        'isEnableStopInheritPermission': !exists(json, 'isEnableStopInheritPermission') ? undefined : json['isEnableStopInheritPermission'],
        'isEnableDeleteUniquePermission': !exists(json, 'isEnableDeleteUniquePermission') ? undefined : json['isEnableDeleteUniquePermission'],
        'isEnableExcludePermissionLevel': !exists(json, 'isEnableExcludePermissionLevel') ? undefined : json['isEnableExcludePermissionLevel'],
        'isHideExcludePermissionItem': !exists(json, 'isHideExcludePermissionItem') ? undefined : json['isHideExcludePermissionItem'],
        'excludedPermissionLevles': !exists(json, 'excludedPermissionLevles') ? undefined : (json['excludedPermissionLevles'] === null ? null : (json['excludedPermissionLevles'] as Array<any>).map(PermissionLevelFromJSON)),
    };
}

export function ManagePermissionOptionToJSON(value?: ManagePermissionOption | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'grantPermissionSetting': ManagePermissionGrantSettingToJSON(value.grantPermissionSetting),
        'isEnableEditPermission': value.isEnableEditPermission,
        'isEnableRemovePermission': value.isEnableRemovePermission,
        'isEnableStopInheritPermission': value.isEnableStopInheritPermission,
        'isEnableDeleteUniquePermission': value.isEnableDeleteUniquePermission,
        'isEnableExcludePermissionLevel': value.isEnableExcludePermissionLevel,
        'isHideExcludePermissionItem': value.isHideExcludePermissionItem,
        'excludedPermissionLevles': value.excludedPermissionLevles === undefined ? undefined : (value.excludedPermissionLevles === null ? null : (value.excludedPermissionLevles as Array<any>).map(PermissionLevelToJSON)),
    };
}


