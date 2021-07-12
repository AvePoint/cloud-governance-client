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
    ExtendType,
    ExtendTypeFromJSON,
    ExtendTypeFromJSONTyped,
    ExtendTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ExtendSiteSetting
 */
export interface ExtendSiteSetting {
    /**
     * 
     * @type {boolean}
     * @memberof ExtendSiteSetting
     */
    isEnabled?: boolean;
    /**
     * 
     * @type {ExtendType}
     * @memberof ExtendSiteSetting
     */
    extendType?: ExtendType;
    /**
     * 
     * @type {number}
     * @memberof ExtendSiteSetting
     */
    duration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ExtendSiteSetting
     */
    durationType?: ApiDurationType;
    /**
     * 
     * @type {number}
     * @memberof ExtendSiteSetting
     */
    constantDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ExtendSiteSetting
     */
    constantDurationType?: ApiDurationType;
    /**
     * 
     * @type {Date}
     * @memberof ExtendSiteSetting
     */
    extendBasedTime?: Date;
}

export function ExtendSiteSettingFromJSON(json: any): ExtendSiteSetting {
    return ExtendSiteSettingFromJSONTyped(json, false);
}

export function ExtendSiteSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExtendSiteSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'extendType': !exists(json, 'extendType') ? undefined : ExtendTypeFromJSON(json['extendType']),
        'duration': !exists(json, 'duration') ? undefined : json['duration'],
        'durationType': !exists(json, 'durationType') ? undefined : ApiDurationTypeFromJSON(json['durationType']),
        'constantDuration': !exists(json, 'constantDuration') ? undefined : json['constantDuration'],
        'constantDurationType': !exists(json, 'constantDurationType') ? undefined : ApiDurationTypeFromJSON(json['constantDurationType']),
        'extendBasedTime': !exists(json, 'extendBasedTime') ? undefined : (new Date(json['extendBasedTime'])),
    };
}

export function ExtendSiteSettingToJSON(value?: ExtendSiteSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnabled': value.isEnabled,
        'extendType': ExtendTypeToJSON(value.extendType),
        'duration': value.duration,
        'durationType': ApiDurationTypeToJSON(value.durationType),
        'constantDuration': value.constantDuration,
        'constantDurationType': ApiDurationTypeToJSON(value.constantDurationType),
        'extendBasedTime': value.extendBasedTime === undefined ? undefined : (value.extendBasedTime.toISOString()),
    };
}


