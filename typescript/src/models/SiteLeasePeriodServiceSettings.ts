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
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
} from './';

/**
 * 
 * @export
 * @interface SiteLeasePeriodServiceSettings
 */
export interface SiteLeasePeriodServiceSettings {
    /**
     * 
     * @type {AssignBy}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leasePeriodAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseWarningAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseEnabled?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseWarningEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SiteLeasePeriodServiceSettings
     */
    approvalProcessId?: string | null;
    /**
     * Site Collection lease period
     * @type {number}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseInterval?: number;
    /**
     * Duration type of the site collection lease period
     * @type {ApiDurationType}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseDurationType?: ApiDurationType;
    /**
     * Site collection lease expiration warning interval
     * @type {number}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseWarningInterval?: number;
    /**
     * Duration type of the site collection lease expiration warning interval
     * @type {ApiDurationType}
     * @memberof SiteLeasePeriodServiceSettings
     */
    leaseWarningDurationType?: ApiDurationType;
}

export function SiteLeasePeriodServiceSettingsFromJSON(json: any): SiteLeasePeriodServiceSettings {
    return SiteLeasePeriodServiceSettingsFromJSONTyped(json, false);
}

export function SiteLeasePeriodServiceSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLeasePeriodServiceSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'leasePeriodAssignBy': !exists(json, 'leasePeriodAssignBy') ? undefined : AssignByFromJSON(json['leasePeriodAssignBy']),
        'leaseWarningAssignBy': !exists(json, 'leaseWarningAssignBy') ? undefined : AssignByFromJSON(json['leaseWarningAssignBy']),
        'leaseEnabled': !exists(json, 'leaseEnabled') ? undefined : json['leaseEnabled'],
        'leaseWarningEnabled': !exists(json, 'leaseWarningEnabled') ? undefined : json['leaseWarningEnabled'],
        'approvalProcessId': !exists(json, 'approvalProcessId') ? undefined : json['approvalProcessId'],
        'leaseInterval': !exists(json, 'leaseInterval') ? undefined : json['leaseInterval'],
        'leaseDurationType': !exists(json, 'leaseDurationType') ? undefined : ApiDurationTypeFromJSON(json['leaseDurationType']),
        'leaseWarningInterval': !exists(json, 'leaseWarningInterval') ? undefined : json['leaseWarningInterval'],
        'leaseWarningDurationType': !exists(json, 'leaseWarningDurationType') ? undefined : ApiDurationTypeFromJSON(json['leaseWarningDurationType']),
    };
}

export function SiteLeasePeriodServiceSettingsToJSON(value?: SiteLeasePeriodServiceSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'leasePeriodAssignBy': AssignByToJSON(value.leasePeriodAssignBy),
        'leaseWarningAssignBy': AssignByToJSON(value.leaseWarningAssignBy),
        'leaseEnabled': value.leaseEnabled,
        'leaseWarningEnabled': value.leaseWarningEnabled,
        'approvalProcessId': value.approvalProcessId,
        'leaseInterval': value.leaseInterval,
        'leaseDurationType': ApiDurationTypeToJSON(value.leaseDurationType),
        'leaseWarningInterval': value.leaseWarningInterval,
        'leaseWarningDurationType': ApiDurationTypeToJSON(value.leaseWarningDurationType),
    };
}


