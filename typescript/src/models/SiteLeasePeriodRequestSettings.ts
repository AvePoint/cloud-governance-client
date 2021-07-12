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
} from './';

/**
 * Site Collection lease period request settings model
 * @export
 * @interface SiteLeasePeriodRequestSettings
 */
export interface SiteLeasePeriodRequestSettings {
    /**
     * Site Collection lease period
     * @type {number}
     * @memberof SiteLeasePeriodRequestSettings
     */
    leaseInterval?: number;
    /**
     * Duration type of the site collection lease period
     * @type {ApiDurationType}
     * @memberof SiteLeasePeriodRequestSettings
     */
    leaseDurationType?: ApiDurationType;
    /**
     * Site collection lease expiration warning interval
     * @type {number}
     * @memberof SiteLeasePeriodRequestSettings
     */
    leaseWarningInterval?: number;
    /**
     * Duration type of the site collection lease expiration warning interval
     * @type {ApiDurationType}
     * @memberof SiteLeasePeriodRequestSettings
     */
    leaseWarningDurationType?: ApiDurationType;
}

export function SiteLeasePeriodRequestSettingsFromJSON(json: any): SiteLeasePeriodRequestSettings {
    return SiteLeasePeriodRequestSettingsFromJSONTyped(json, false);
}

export function SiteLeasePeriodRequestSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLeasePeriodRequestSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'leaseInterval': !exists(json, 'leaseInterval') ? undefined : json['leaseInterval'],
        'leaseDurationType': !exists(json, 'leaseDurationType') ? undefined : ApiDurationTypeFromJSON(json['leaseDurationType']),
        'leaseWarningInterval': !exists(json, 'leaseWarningInterval') ? undefined : json['leaseWarningInterval'],
        'leaseWarningDurationType': !exists(json, 'leaseWarningDurationType') ? undefined : ApiDurationTypeFromJSON(json['leaseWarningDurationType']),
    };
}

export function SiteLeasePeriodRequestSettingsToJSON(value?: SiteLeasePeriodRequestSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'leaseInterval': value.leaseInterval,
        'leaseDurationType': ApiDurationTypeToJSON(value.leaseDurationType),
        'leaseWarningInterval': value.leaseWarningInterval,
        'leaseWarningDurationType': ApiDurationTypeToJSON(value.leaseWarningDurationType),
    };
}


