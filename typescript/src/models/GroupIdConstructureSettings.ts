/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    GroupConstructureRule,
    GroupConstructureRuleFromJSON,
    GroupConstructureRuleFromJSONTyped,
    GroupConstructureRuleToJSON,
    GroupIdRuleType,
    GroupIdRuleTypeFromJSON,
    GroupIdRuleTypeFromJSONTyped,
    GroupIdRuleTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface GroupIdConstructureSettings
 */
export interface GroupIdConstructureSettings {
    /**
     * 
     * @type {GroupIdRuleType}
     * @memberof GroupIdConstructureSettings
     */
    ruleType?: GroupIdRuleType;
    /**
     * 
     * @type {boolean}
     * @memberof GroupIdConstructureSettings
     */
    enableAutoSequenceNumber?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GroupIdConstructureSettings
     */
    autoSequenceNumber?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof GroupIdConstructureSettings
     */
    enabled?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof GroupIdConstructureSettings
     */
    assignBy?: AssignBy;
    /**
     * 
     * @type {Array<GroupConstructureRule>}
     * @memberof GroupIdConstructureSettings
     */
    prefixs?: Array<GroupConstructureRule> | null;
    /**
     * 
     * @type {Array<GroupConstructureRule>}
     * @memberof GroupIdConstructureSettings
     */
    suffixs?: Array<GroupConstructureRule> | null;
}

export function GroupIdConstructureSettingsFromJSON(json: any): GroupIdConstructureSettings {
    return GroupIdConstructureSettingsFromJSONTyped(json, false);
}

export function GroupIdConstructureSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupIdConstructureSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ruleType': !exists(json, 'ruleType') ? undefined : GroupIdRuleTypeFromJSON(json['ruleType']),
        'enableAutoSequenceNumber': !exists(json, 'enableAutoSequenceNumber') ? undefined : json['enableAutoSequenceNumber'],
        'autoSequenceNumber': !exists(json, 'autoSequenceNumber') ? undefined : json['autoSequenceNumber'],
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
        'prefixs': !exists(json, 'prefixs') ? undefined : (json['prefixs'] === null ? null : (json['prefixs'] as Array<any>).map(GroupConstructureRuleFromJSON)),
        'suffixs': !exists(json, 'suffixs') ? undefined : (json['suffixs'] === null ? null : (json['suffixs'] as Array<any>).map(GroupConstructureRuleFromJSON)),
    };
}

export function GroupIdConstructureSettingsToJSON(value?: GroupIdConstructureSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ruleType': GroupIdRuleTypeToJSON(value.ruleType),
        'enableAutoSequenceNumber': value.enableAutoSequenceNumber,
        'autoSequenceNumber': value.autoSequenceNumber,
        'enabled': value.enabled,
        'assignBy': AssignByToJSON(value.assignBy),
        'prefixs': value.prefixs === undefined ? undefined : (value.prefixs === null ? null : (value.prefixs as Array<any>).map(GroupConstructureRuleToJSON)),
        'suffixs': value.suffixs === undefined ? undefined : (value.suffixs === null ? null : (value.suffixs as Array<any>).map(GroupConstructureRuleToJSON)),
    };
}


