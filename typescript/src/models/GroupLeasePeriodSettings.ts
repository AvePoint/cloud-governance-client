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
    GroupLeasePeriodType,
    GroupLeasePeriodTypeFromJSON,
    GroupLeasePeriodTypeFromJSONTyped,
    GroupLeasePeriodTypeToJSON,
} from './';

/**
 * Group lease period settings model
 * @export
 * @interface GroupLeasePeriodSettings
 */
export interface GroupLeasePeriodSettings {
    /**
     * Whether group extend lease is enabled after expiration
     * @type {boolean}
     * @memberof GroupLeasePeriodSettings
     */
    isEnabled?: boolean;
    /**
     * Group lease period extension type
     * @type {GroupLeasePeriodType}
     * @memberof GroupLeasePeriodSettings
     */
    leaseType?: GroupLeasePeriodType;
    /**
     * Duration type of the group lease period
     * @type {ApiDurationType}
     * @memberof GroupLeasePeriodSettings
     */
    durationType?: ApiDurationType;
    /**
     * Group lease period
     * @type {number}
     * @memberof GroupLeasePeriodSettings
     */
    durationInterval?: number;
    /**
     * Group lease expiration date and time
     * @type {Date}
     * @memberof GroupLeasePeriodSettings
     */
    leaseExpirationDate?: Date | null;
}

export function GroupLeasePeriodSettingsFromJSON(json: any): GroupLeasePeriodSettings {
    return GroupLeasePeriodSettingsFromJSONTyped(json, false);
}

export function GroupLeasePeriodSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupLeasePeriodSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'leaseType': !exists(json, 'leaseType') ? undefined : GroupLeasePeriodTypeFromJSON(json['leaseType']),
        'durationType': !exists(json, 'durationType') ? undefined : ApiDurationTypeFromJSON(json['durationType']),
        'durationInterval': !exists(json, 'durationInterval') ? undefined : json['durationInterval'],
        'leaseExpirationDate': !exists(json, 'leaseExpirationDate') ? undefined : (json['leaseExpirationDate'] === null ? null : new Date(json['leaseExpirationDate'])),
    };
}

export function GroupLeasePeriodSettingsToJSON(value?: GroupLeasePeriodSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnabled': value.isEnabled,
        'leaseType': GroupLeasePeriodTypeToJSON(value.leaseType),
        'durationType': ApiDurationTypeToJSON(value.durationType),
        'durationInterval': value.durationInterval,
        'leaseExpirationDate': value.leaseExpirationDate === undefined ? undefined : (value.leaseExpirationDate === null ? null : value.leaseExpirationDate.toISOString()),
    };
}


