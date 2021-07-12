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
    OneTimeRenewalOption,
    OneTimeRenewalOptionFromJSON,
    OneTimeRenewalOptionFromJSONTyped,
    OneTimeRenewalOptionToJSON,
} from './';

/**
 * 
 * @export
 * @interface GuestUserRequestOneTimeRenewalSettingModel
 */
export interface GuestUserRequestOneTimeRenewalSettingModel {
    /**
     * 
     * @type {OneTimeRenewalOption}
     * @memberof GuestUserRequestOneTimeRenewalSettingModel
     */
    option?: OneTimeRenewalOption;
    /**
     * 
     * @type {number}
     * @memberof GuestUserRequestOneTimeRenewalSettingModel
     */
    duration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof GuestUserRequestOneTimeRenewalSettingModel
     */
    durationType?: ApiDurationType;
    /**
     * 
     * @type {Date}
     * @memberof GuestUserRequestOneTimeRenewalSettingModel
     */
    startTime?: Date | null;
}

export function GuestUserRequestOneTimeRenewalSettingModelFromJSON(json: any): GuestUserRequestOneTimeRenewalSettingModel {
    return GuestUserRequestOneTimeRenewalSettingModelFromJSONTyped(json, false);
}

export function GuestUserRequestOneTimeRenewalSettingModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuestUserRequestOneTimeRenewalSettingModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'option': !exists(json, 'option') ? undefined : OneTimeRenewalOptionFromJSON(json['option']),
        'duration': !exists(json, 'duration') ? undefined : json['duration'],
        'durationType': !exists(json, 'durationType') ? undefined : ApiDurationTypeFromJSON(json['durationType']),
        'startTime': !exists(json, 'startTime') ? undefined : (json['startTime'] === null ? null : new Date(json['startTime'])),
    };
}

export function GuestUserRequestOneTimeRenewalSettingModelToJSON(value?: GuestUserRequestOneTimeRenewalSettingModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'option': OneTimeRenewalOptionToJSON(value.option),
        'duration': value.duration,
        'durationType': ApiDurationTypeToJSON(value.durationType),
        'startTime': value.startTime === undefined ? undefined : (value.startTime === null ? null : value.startTime.toISOString()),
    };
}


