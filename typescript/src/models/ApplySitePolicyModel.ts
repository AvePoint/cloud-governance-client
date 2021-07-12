/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    LifecycleRenewalSetting,
    LifecycleRenewalSettingFromJSON,
    LifecycleRenewalSettingFromJSONTyped,
    LifecycleRenewalSettingToJSON,
} from './';

/**
 * 
 * @export
 * @interface ApplySitePolicyModel
 */
export interface ApplySitePolicyModel {
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyDesigner?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplySiteMaxDepth?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyPolicyIcon?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyAosPlans?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ApplySitePolicyModel
     */
    policyId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyAllSetting?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyQuota?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplySharing?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyQuotaThreshold?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyDeactivatedElection?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    isApplyLifecycle?: boolean;
    /**
     * 
     * @type {LifecycleRenewalSetting}
     * @memberof ApplySitePolicyModel
     */
    lifecycleRenewalSetting?: LifecycleRenewalSetting | null;
    /**
     * 
     * @type {string}
     * @memberof ApplySitePolicyModel
     */
    filter?: string | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof ApplySitePolicyModel
     */
    selectedObjects?: Array<string> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ApplySitePolicyModel
     */
    hasOngoingTasks?: boolean;
}

export function ApplySitePolicyModelFromJSON(json: any): ApplySitePolicyModel {
    return ApplySitePolicyModelFromJSONTyped(json, false);
}

export function ApplySitePolicyModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApplySitePolicyModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isApplyDesigner': !exists(json, 'isApplyDesigner') ? undefined : json['isApplyDesigner'],
        'isApplySiteMaxDepth': !exists(json, 'isApplySiteMaxDepth') ? undefined : json['isApplySiteMaxDepth'],
        'isApplyPolicyIcon': !exists(json, 'isApplyPolicyIcon') ? undefined : json['isApplyPolicyIcon'],
        'isApplyAosPlans': !exists(json, 'isApplyAosPlans') ? undefined : json['isApplyAosPlans'],
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

export function ApplySitePolicyModelToJSON(value?: ApplySitePolicyModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isApplyDesigner': value.isApplyDesigner,
        'isApplySiteMaxDepth': value.isApplySiteMaxDepth,
        'isApplyPolicyIcon': value.isApplyPolicyIcon,
        'isApplyAosPlans': value.isApplyAosPlans,
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


