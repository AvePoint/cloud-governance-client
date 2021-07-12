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
 * @interface ChangeGroupPolicyResult
 */
export interface ChangeGroupPolicyResult {
    /**
     * 
     * @type {GuidModel}
     * @memberof ChangeGroupPolicyResult
     */
    currentPolicy?: GuidModel | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ChangeGroupPolicyResult
     */
    allPolicies?: Array<GuidModel> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ChangeGroupPolicyResult
     */
    changePolicyAssignBy?: AssignBy;
    /**
     * 
     * @type {StartDateType}
     * @memberof ChangeGroupPolicyResult
     */
    startDateType?: StartDateType;
    /**
     * 
     * @type {Date}
     * @memberof ChangeGroupPolicyResult
     */
    serviceSpecifyDate?: Date;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupPolicyResult
     */
    isEnableLeaseExpired?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ChangeGroupPolicyResult
     */
    leaseDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ChangeGroupPolicyResult
     */
    leaseDurationType?: ApiDurationType;
    /**
     * 
     * @type {Date}
     * @memberof ChangeGroupPolicyResult
     */
    currentStartDate?: Date;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupPolicyResult
     */
    isAllowAutoCancel?: boolean;
}

export function ChangeGroupPolicyResultFromJSON(json: any): ChangeGroupPolicyResult {
    return ChangeGroupPolicyResultFromJSONTyped(json, false);
}

export function ChangeGroupPolicyResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupPolicyResult {
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

export function ChangeGroupPolicyResultToJSON(value?: ChangeGroupPolicyResult | null): any {
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


