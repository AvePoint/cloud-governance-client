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
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    StartDateType,
    StartDateTypeFromJSON,
    StartDateTypeFromJSONTyped,
    StartDateTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeSitePolicySetting
 */
export interface ChangeSitePolicySetting {
    /**
     * 
     * @type {GuidModel}
     * @memberof ChangeSitePolicySetting
     */
    currentPolicy?: GuidModel | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ChangeSitePolicySetting
     */
    allPolicies?: Array<GuidModel> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ChangeSitePolicySetting
     */
    changePolicyAssignBy?: AssignBy;
    /**
     * 
     * @type {StartDateType}
     * @memberof ChangeSitePolicySetting
     */
    startDateType?: StartDateType;
    /**
     * 
     * @type {Date}
     * @memberof ChangeSitePolicySetting
     */
    serviceSpecifyDate?: Date;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSitePolicySetting
     */
    isEnableLeaseExpired?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ChangeSitePolicySetting
     */
    leaseDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ChangeSitePolicySetting
     */
    leaseDurationType?: ApiDurationType;
    /**
     * 
     * @type {Date}
     * @memberof ChangeSitePolicySetting
     */
    currentStartDate?: Date;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSitePolicySetting
     */
    isAllowAutoCancel?: boolean;
}

export function ChangeSitePolicySettingFromJSON(json: any): ChangeSitePolicySetting {
    return ChangeSitePolicySettingFromJSONTyped(json, false);
}

export function ChangeSitePolicySettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSitePolicySetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'currentPolicy': !exists(json, 'currentPolicy') ? undefined : GuidModelFromJSON(json['currentPolicy']),
        'allPolicies': !exists(json, 'allPolicies') ? undefined : (json['allPolicies'] === null ? null : (json['allPolicies'] as Array<any>).map(GuidModelFromJSON)),
        'changePolicyAssignBy': !exists(json, 'changePolicyAssignBy') ? undefined : AssignByFromJSON(json['changePolicyAssignBy']),
        'startDateType': !exists(json, 'startDateType') ? undefined : StartDateTypeFromJSON(json['startDateType']),
        'serviceSpecifyDate': !exists(json, 'serviceSpecifyDate') ? undefined : (new Date(json['serviceSpecifyDate'])),
        'isEnableLeaseExpired': !exists(json, 'isEnableLeaseExpired') ? undefined : json['isEnableLeaseExpired'],
        'leaseDuration': !exists(json, 'leaseDuration') ? undefined : json['leaseDuration'],
        'leaseDurationType': !exists(json, 'leaseDurationType') ? undefined : ApiDurationTypeFromJSON(json['leaseDurationType']),
        'currentStartDate': !exists(json, 'currentStartDate') ? undefined : (new Date(json['currentStartDate'])),
        'isAllowAutoCancel': !exists(json, 'isAllowAutoCancel') ? undefined : json['isAllowAutoCancel'],
    };
}

export function ChangeSitePolicySettingToJSON(value?: ChangeSitePolicySetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'currentPolicy': GuidModelToJSON(value.currentPolicy),
        'allPolicies': value.allPolicies === undefined ? undefined : (value.allPolicies === null ? null : (value.allPolicies as Array<any>).map(GuidModelToJSON)),
        'changePolicyAssignBy': AssignByToJSON(value.changePolicyAssignBy),
        'startDateType': StartDateTypeToJSON(value.startDateType),
        'serviceSpecifyDate': value.serviceSpecifyDate === undefined ? undefined : (value.serviceSpecifyDate.toISOString()),
        'isEnableLeaseExpired': value.isEnableLeaseExpired,
        'leaseDuration': value.leaseDuration,
        'leaseDurationType': ApiDurationTypeToJSON(value.leaseDurationType),
        'currentStartDate': value.currentStartDate === undefined ? undefined : (value.currentStartDate.toISOString()),
        'isAllowAutoCancel': value.isAllowAutoCancel,
    };
}


