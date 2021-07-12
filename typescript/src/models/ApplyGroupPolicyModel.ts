/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GroupPolicySubType,
    GroupPolicySubTypeFromJSON,
    GroupPolicySubTypeFromJSONTyped,
    GroupPolicySubTypeToJSON,
    LifecycleRenewalSetting,
    LifecycleRenewalSettingFromJSON,
    LifecycleRenewalSettingFromJSONTyped,
    LifecycleRenewalSettingToJSON,
} from './';

/**
 * 
 * @export
 * @interface ApplyGroupPolicyModel
 */
export interface ApplyGroupPolicyModel {
    /**
     * 
     * @type {GroupPolicySubType}
     * @memberof ApplyGroupPolicyModel
     */
    subType?: GroupPolicySubType;
    /**
     * 
     * @type {string}
     * @memberof ApplyGroupPolicyModel
     */
    policyId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    isApplyAllSetting?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    isApplyQuota?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    isApplySharing?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    isApplyQuotaThreshold?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    isApplyDeactivatedElection?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    isApplyLifecycle?: boolean;
    /**
     * 
     * @type {LifecycleRenewalSetting}
     * @memberof ApplyGroupPolicyModel
     */
    lifecycleRenewalSetting?: LifecycleRenewalSetting | null;
    /**
     * 
     * @type {string}
     * @memberof ApplyGroupPolicyModel
     */
    filter?: string | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof ApplyGroupPolicyModel
     */
    selectedObjects?: Array<string> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ApplyGroupPolicyModel
     */
    hasOngoingTasks?: boolean;
}

export function ApplyGroupPolicyModelFromJSON(json: any): ApplyGroupPolicyModel {
    return ApplyGroupPolicyModelFromJSONTyped(json, false);
}

export function ApplyGroupPolicyModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApplyGroupPolicyModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'subType': !exists(json, 'subType') ? undefined : GroupPolicySubTypeFromJSON(json['subType']),
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'isApplyAllSetting': !exists(json, 'isApplyAllSetting') ? undefined : json['isApplyAllSetting'],
        'isApplyQuota': !exists(json, 'isApplyQuota') ? undefined : json['isApplyQuota'],
        'isApplySharing': !exists(json, 'isApplySharing') ? undefined : json['isApplySharing'],
        'isApplyQuotaThreshold': !exists(json, 'isApplyQuotaThreshold') ? undefined : json['isApplyQuotaThreshold'],
        'isApplyDeactivatedElection': !exists(json, 'isApplyDeactivatedElection') ? undefined : json['isApplyDeactivatedElection'],
        'isApplyLifecycle': !exists(json, 'isApplyLifecycle') ? undefined : json['isApplyLifecycle'],
        'lifecycleRenewalSetting': !exists(json, 'lifecycleRenewalSetting') ? undefined : LifecycleRenewalSettingFromJSON(json['lifecycleRenewalSetting']),
        'filter': !exists(json, 'filter') ? undefined : json['filter'],
        'selectedObjects': !exists(json, 'selectedObjects') ? undefined : json['selectedObjects'],
        'hasOngoingTasks': !exists(json, 'hasOngoingTasks') ? undefined : json['hasOngoingTasks'],
    };
}

export function ApplyGroupPolicyModelToJSON(value?: ApplyGroupPolicyModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'subType': GroupPolicySubTypeToJSON(value.subType),
        'policyId': value.policyId,
        'isApplyAllSetting': value.isApplyAllSetting,
        'isApplyQuota': value.isApplyQuota,
        'isApplySharing': value.isApplySharing,
        'isApplyQuotaThreshold': value.isApplyQuotaThreshold,
        'isApplyDeactivatedElection': value.isApplyDeactivatedElection,
        'isApplyLifecycle': value.isApplyLifecycle,
        'lifecycleRenewalSetting': LifecycleRenewalSettingToJSON(value.lifecycleRenewalSetting),
        'filter': value.filter,
        'selectedObjects': value.selectedObjects,
        'hasOngoingTasks': value.hasOngoingTasks,
    };
}


