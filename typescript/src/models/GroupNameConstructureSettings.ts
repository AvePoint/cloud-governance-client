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
} from './';

/**
 * 
 * @export
 * @interface GroupNameConstructureSettings
 */
export interface GroupNameConstructureSettings {
    /**
     * 
     * @type {boolean}
     * @memberof GroupNameConstructureSettings
     */
    enabled?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof GroupNameConstructureSettings
     */
    assignBy?: AssignBy;
    /**
     * 
     * @type {Array<GroupConstructureRule>}
     * @memberof GroupNameConstructureSettings
     */
    prefixs?: Array<GroupConstructureRule> | null;
    /**
     * 
     * @type {Array<GroupConstructureRule>}
     * @memberof GroupNameConstructureSettings
     */
    suffixs?: Array<GroupConstructureRule> | null;
}

export function GroupNameConstructureSettingsFromJSON(json: any): GroupNameConstructureSettings {
    return GroupNameConstructureSettingsFromJSONTyped(json, false);
}

export function GroupNameConstructureSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupNameConstructureSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
        'prefixs': !exists(json, 'prefixs') ? undefined : (json['prefixs'] === null ? null : (json['prefixs'] as Array<any>).map(GroupConstructureRuleFromJSON)),
        'suffixs': !exists(json, 'suffixs') ? undefined : (json['suffixs'] === null ? null : (json['suffixs'] as Array<any>).map(GroupConstructureRuleFromJSON)),
    };
}

export function GroupNameConstructureSettingsToJSON(value?: GroupNameConstructureSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'assignBy': AssignByToJSON(value.assignBy),
        'prefixs': value.prefixs === undefined ? undefined : (value.prefixs === null ? null : (value.prefixs as Array<any>).map(GroupConstructureRuleToJSON)),
        'suffixs': value.suffixs === undefined ? undefined : (value.suffixs === null ? null : (value.suffixs as Array<any>).map(GroupConstructureRuleToJSON)),
    };
}


