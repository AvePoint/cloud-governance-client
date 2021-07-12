/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiDurationType,
    ApiDurationTypeFromJSON,
    ApiDurationTypeFromJSONTyped,
    ApiDurationTypeToJSON,
    ExpirationType,
    ExpirationTypeFromJSON,
    ExpirationTypeFromJSONTyped,
    ExpirationTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface TemporaryPermissionRequestSetting
 */
export interface TemporaryPermissionRequestSetting {
    /**
     * 
     * @type {boolean}
     * @memberof TemporaryPermissionRequestSetting
     */
    isGrantTemporaryPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TemporaryPermissionRequestSetting
     */
    isGrantAdminGroup?: boolean;
    /**
     * 
     * @type {ExpirationType}
     * @memberof TemporaryPermissionRequestSetting
     */
    expirationType?: ExpirationType;
    /**
     * 
     * @type {number}
     * @memberof TemporaryPermissionRequestSetting
     */
    durationInterval?: number | null;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof TemporaryPermissionRequestSetting
     */
    durationDateType?: ApiDurationType | null;
    /**
     * 
     * @type {Date}
     * @memberof TemporaryPermissionRequestSetting
     */
    startTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof TemporaryPermissionRequestSetting
     */
    endTime?: Date | null;
}

export function TemporaryPermissionRequestSettingFromJSON(json: any): TemporaryPermissionRequestSetting {
    return TemporaryPermissionRequestSettingFromJSONTyped(json, false);
}

export function TemporaryPermissionRequestSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): TemporaryPermissionRequestSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isGrantTemporaryPermission': !exists(json, 'isGrantTemporaryPermission') ? undefined : json['isGrantTemporaryPermission'],
        'isGrantAdminGroup': !exists(json, 'isGrantAdminGroup') ? undefined : json['isGrantAdminGroup'],
        'expirationType': !exists(json, 'expirationType') ? undefined : ExpirationTypeFromJSON(json['expirationType']),
        'durationInterval': !exists(json, 'durationInterval') ? undefined : json['durationInterval'],
        'durationDateType': !exists(json, 'durationDateType') ? undefined : ApiDurationTypeFromJSON(json['durationDateType']),
        'startTime': !exists(json, 'startTime') ? undefined : (json['startTime'] === null ? null : new Date(json['startTime'])),
        'endTime': !exists(json, 'endTime') ? undefined : (json['endTime'] === null ? null : new Date(json['endTime'])),
    };
}

export function TemporaryPermissionRequestSettingToJSON(value?: TemporaryPermissionRequestSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isGrantTemporaryPermission': value.isGrantTemporaryPermission,
        'isGrantAdminGroup': value.isGrantAdminGroup,
        'expirationType': ExpirationTypeToJSON(value.expirationType),
        'durationInterval': value.durationInterval,
        'durationDateType': ApiDurationTypeToJSON(value.durationDateType),
        'startTime': value.startTime === undefined ? undefined : (value.startTime === null ? null : value.startTime.toISOString()),
        'endTime': value.endTime === undefined ? undefined : (value.endTime === null ? null : value.endTime.toISOString()),
    };
}


