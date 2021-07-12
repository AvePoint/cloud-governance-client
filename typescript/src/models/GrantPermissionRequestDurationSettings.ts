/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    DurationDateType,
    DurationDateTypeFromJSON,
    DurationDateTypeFromJSONTyped,
    DurationDateTypeToJSON,
    ExpirationType,
    ExpirationTypeFromJSON,
    ExpirationTypeFromJSONTyped,
    ExpirationTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionRequestDurationSettings
 */
export interface GrantPermissionRequestDurationSettings {
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionRequestDurationSettings
     */
    isGrantTemporaryPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionRequestDurationSettings
     */
    isGrantPermissionLevel?: boolean;
    /**
     * 
     * @type {ExpirationType}
     * @memberof GrantPermissionRequestDurationSettings
     */
    expirationType?: ExpirationType;
    /**
     * 
     * @type {number}
     * @memberof GrantPermissionRequestDurationSettings
     */
    durationInterval?: number | null;
    /**
     * 
     * @type {DurationDateType}
     * @memberof GrantPermissionRequestDurationSettings
     */
    durationDateType?: DurationDateType | null;
    /**
     * 
     * @type {Date}
     * @memberof GrantPermissionRequestDurationSettings
     */
    startTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof GrantPermissionRequestDurationSettings
     */
    endTime?: Date | null;
}

export function GrantPermissionRequestDurationSettingsFromJSON(json: any): GrantPermissionRequestDurationSettings {
    return GrantPermissionRequestDurationSettingsFromJSONTyped(json, false);
}

export function GrantPermissionRequestDurationSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionRequestDurationSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isGrantTemporaryPermission': !exists(json, 'isGrantTemporaryPermission') ? undefined : json['isGrantTemporaryPermission'],
        'isGrantPermissionLevel': !exists(json, 'isGrantPermissionLevel') ? undefined : json['isGrantPermissionLevel'],
        'expirationType': !exists(json, 'expirationType') ? undefined : ExpirationTypeFromJSON(json['expirationType']),
        'durationInterval': !exists(json, 'durationInterval') ? undefined : json['durationInterval'],
        'durationDateType': !exists(json, 'durationDateType') ? undefined : DurationDateTypeFromJSON(json['durationDateType']),
        'startTime': !exists(json, 'startTime') ? undefined : (json['startTime'] === null ? null : new Date(json['startTime'])),
        'endTime': !exists(json, 'endTime') ? undefined : (json['endTime'] === null ? null : new Date(json['endTime'])),
    };
}

export function GrantPermissionRequestDurationSettingsToJSON(value?: GrantPermissionRequestDurationSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isGrantTemporaryPermission': value.isGrantTemporaryPermission,
        'isGrantPermissionLevel': value.isGrantPermissionLevel,
        'expirationType': ExpirationTypeToJSON(value.expirationType),
        'durationInterval': value.durationInterval,
        'durationDateType': DurationDateTypeToJSON(value.durationDateType),
        'startTime': value.startTime === undefined ? undefined : (value.startTime === null ? null : value.startTime.toISOString()),
        'endTime': value.endTime === undefined ? undefined : (value.endTime === null ? null : value.endTime.toISOString()),
    };
}


