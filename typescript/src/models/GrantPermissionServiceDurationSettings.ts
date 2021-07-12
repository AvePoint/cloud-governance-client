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
    DurationDateType,
    DurationDateTypeFromJSON,
    DurationDateTypeFromJSONTyped,
    DurationDateTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionServiceDurationSettings
 */
export interface GrantPermissionServiceDurationSettings {
    /**
     * 
     * @type {AssignBy}
     * @memberof GrantPermissionServiceDurationSettings
     */
    assignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionServiceDurationSettings
     */
    isGrantTemporaryPermission?: boolean;
    /**
     * 
     * @type {number}
     * @memberof GrantPermissionServiceDurationSettings
     */
    defaultDurationInterval?: number | null;
    /**
     * 
     * @type {DurationDateType}
     * @memberof GrantPermissionServiceDurationSettings
     */
    defaultDurationType?: DurationDateType;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionServiceDurationSettings
     */
    isEnableMaxDuration?: boolean;
    /**
     * 
     * @type {number}
     * @memberof GrantPermissionServiceDurationSettings
     */
    maxDuration?: number;
    /**
     * 
     * @type {DurationDateType}
     * @memberof GrantPermissionServiceDurationSettings
     */
    maxDurationType?: DurationDateType;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionServiceDurationSettings
     */
    isEnableExpirationNotify?: boolean;
    /**
     * 
     * @type {number}
     * @memberof GrantPermissionServiceDurationSettings
     */
    expirationNotifyDurationInterval?: number;
    /**
     * 
     * @type {DurationDateType}
     * @memberof GrantPermissionServiceDurationSettings
     */
    expirationNotifyDurationType?: DurationDateType;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionServiceDurationSettings
     */
    isOnlyUseDefaultDuration?: boolean;
}

export function GrantPermissionServiceDurationSettingsFromJSON(json: any): GrantPermissionServiceDurationSettings {
    return GrantPermissionServiceDurationSettingsFromJSONTyped(json, false);
}

export function GrantPermissionServiceDurationSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionServiceDurationSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
        'isGrantTemporaryPermission': !exists(json, 'isGrantTemporaryPermission') ? undefined : json['isGrantTemporaryPermission'],
        'defaultDurationInterval': !exists(json, 'defaultDurationInterval') ? undefined : json['defaultDurationInterval'],
        'defaultDurationType': !exists(json, 'defaultDurationType') ? undefined : DurationDateTypeFromJSON(json['defaultDurationType']),
        'isEnableMaxDuration': !exists(json, 'isEnableMaxDuration') ? undefined : json['isEnableMaxDuration'],
        'maxDuration': !exists(json, 'maxDuration') ? undefined : json['maxDuration'],
        'maxDurationType': !exists(json, 'maxDurationType') ? undefined : DurationDateTypeFromJSON(json['maxDurationType']),
        'isEnableExpirationNotify': !exists(json, 'isEnableExpirationNotify') ? undefined : json['isEnableExpirationNotify'],
        'expirationNotifyDurationInterval': !exists(json, 'expirationNotifyDurationInterval') ? undefined : json['expirationNotifyDurationInterval'],
        'expirationNotifyDurationType': !exists(json, 'expirationNotifyDurationType') ? undefined : DurationDateTypeFromJSON(json['expirationNotifyDurationType']),
        'isOnlyUseDefaultDuration': !exists(json, 'isOnlyUseDefaultDuration') ? undefined : json['isOnlyUseDefaultDuration'],
    };
}

export function GrantPermissionServiceDurationSettingsToJSON(value?: GrantPermissionServiceDurationSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'assignBy': AssignByToJSON(value.assignBy),
        'isGrantTemporaryPermission': value.isGrantTemporaryPermission,
        'defaultDurationInterval': value.defaultDurationInterval,
        'defaultDurationType': DurationDateTypeToJSON(value.defaultDurationType),
        'isEnableMaxDuration': value.isEnableMaxDuration,
        'maxDuration': value.maxDuration,
        'maxDurationType': DurationDateTypeToJSON(value.maxDurationType),
        'isEnableExpirationNotify': value.isEnableExpirationNotify,
        'expirationNotifyDurationInterval': value.expirationNotifyDurationInterval,
        'expirationNotifyDurationType': DurationDateTypeToJSON(value.expirationNotifyDurationType),
        'isOnlyUseDefaultDuration': value.isOnlyUseDefaultDuration,
    };
}


