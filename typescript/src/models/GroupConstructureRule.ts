/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ConstructureType,
    ConstructureTypeFromJSON,
    ConstructureTypeFromJSONTyped,
    ConstructureTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface GroupConstructureRule
 */
export interface GroupConstructureRule {
    /**
     * 
     * @type {ConstructureType}
     * @memberof GroupConstructureRule
     */
    type?: ConstructureType;
    /**
     * 
     * @type {string}
     * @memberof GroupConstructureRule
     */
    value?: string | null;
}

export function GroupConstructureRuleFromJSON(json: any): GroupConstructureRule {
    return GroupConstructureRuleFromJSONTyped(json, false);
}

export function GroupConstructureRuleFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupConstructureRule {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': !exists(json, 'type') ? undefined : ConstructureTypeFromJSON(json['type']),
        'value': !exists(json, 'value') ? undefined : json['value'],
    };
}

export function GroupConstructureRuleToJSON(value?: GroupConstructureRule | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': ConstructureTypeToJSON(value.type),
        'value': value.value,
    };
}


