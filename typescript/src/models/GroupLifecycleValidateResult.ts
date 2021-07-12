/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeGroupPolicyResult,
    ChangeGroupPolicyResultFromJSON,
    ChangeGroupPolicyResultFromJSONTyped,
    ChangeGroupPolicyResultToJSON,
    ChangeGroupQuotaResult,
    ChangeGroupQuotaResultFromJSON,
    ChangeGroupQuotaResultFromJSONTyped,
    ChangeGroupQuotaResultToJSON,
    ExtendGroupResult,
    ExtendGroupResultFromJSON,
    ExtendGroupResultFromJSONTyped,
    ExtendGroupResultToJSON,
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface GroupLifecycleValidateResult
 */
export interface GroupLifecycleValidateResult {
    /**
     * 
     * @type {ExtendGroupResult}
     * @memberof GroupLifecycleValidateResult
     */
    extendSetting?: ExtendGroupResult | null;
    /**
     * 
     * @type {ChangeGroupPolicyResult}
     * @memberof GroupLifecycleValidateResult
     */
    changePolicySetting?: ChangeGroupPolicyResult | null;
    /**
     * 
     * @type {ChangeGroupQuotaResult}
     * @memberof GroupLifecycleValidateResult
     */
    changeQuotaSetting?: ChangeGroupQuotaResult | null;
    /**
     * 
     * @type {boolean}
     * @memberof GroupLifecycleValidateResult
     */
    enableTeamCollaboration?: boolean;
    /**
     * 
     * @type {GroupObjectType}
     * @memberof GroupLifecycleValidateResult
     */
    groupObjectType?: GroupObjectType;
    /**
     * 
     * @type {boolean}
     * @memberof GroupLifecycleValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof GroupLifecycleValidateResult
     */
    messageCode?: MessageCode;
}

export function GroupLifecycleValidateResultFromJSON(json: any): GroupLifecycleValidateResult {
    return GroupLifecycleValidateResultFromJSONTyped(json, false);
}

export function GroupLifecycleValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupLifecycleValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'extendSetting': !exists(json, 'extendSetting') ? undefined : ExtendGroupResultFromJSON(json['extendSetting']),
        'changePolicySetting': !exists(json, 'changePolicySetting') ? undefined : ChangeGroupPolicyResultFromJSON(json['changePolicySetting']),
        'changeQuotaSetting': !exists(json, 'changeQuotaSetting') ? undefined : ChangeGroupQuotaResultFromJSON(json['changeQuotaSetting']),
        'enableTeamCollaboration': !exists(json, 'enableTeamCollaboration') ? undefined : json['enableTeamCollaboration'],
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function GroupLifecycleValidateResultToJSON(value?: GroupLifecycleValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'extendSetting': ExtendGroupResultToJSON(value.extendSetting),
        'changePolicySetting': ChangeGroupPolicyResultToJSON(value.changePolicySetting),
        'changeQuotaSetting': ChangeGroupQuotaResultToJSON(value.changeQuotaSetting),
        'enableTeamCollaboration': value.enableTeamCollaboration,
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


