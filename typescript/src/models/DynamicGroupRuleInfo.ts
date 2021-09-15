/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    CategoryType,
    CategoryTypeFromJSON,
    CategoryTypeFromJSONTyped,
    CategoryTypeToJSON,
    DynamicRuleCondition,
    DynamicRuleConditionFromJSON,
    DynamicRuleConditionFromJSONTyped,
    DynamicRuleConditionToJSON,
    LogicalOperator,
    LogicalOperatorFromJSON,
    LogicalOperatorFromJSONTyped,
    LogicalOperatorToJSON,
} from './';

/**
 * 
 * @export
 * @interface DynamicGroupRuleInfo
 */
export interface DynamicGroupRuleInfo {
    /**
     * 
     * @type {string}
     * @memberof DynamicGroupRuleInfo
     */
    id?: string;
    /**
     * 
     * @type {number}
     * @memberof DynamicGroupRuleInfo
     */
    order?: number;
    /**
     * 
     * @type {LogicalOperator}
     * @memberof DynamicGroupRuleInfo
     */
    relation?: LogicalOperator;
    /**
     * 
     * @type {CategoryType}
     * @memberof DynamicGroupRuleInfo
     */
    category?: CategoryType;
    /**
     * 
     * @type {string}
     * @memberof DynamicGroupRuleInfo
     */
    metadataId?: string;
    /**
     * 
     * @type {string}
     * @memberof DynamicGroupRuleInfo
     */
    metadataName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DynamicGroupRuleInfo
     */
    metadataValue?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DynamicGroupRuleInfo
     */
    metadataDisplayValue?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DynamicGroupRuleInfo
     */
    metadataValueAzureUserType?: string | null;
    /**
     * 
     * @type {DynamicRuleCondition}
     * @memberof DynamicGroupRuleInfo
     */
    condition?: DynamicRuleCondition;
    /**
     * 
     * @type {boolean}
     * @memberof DynamicGroupRuleInfo
     */
    disableEditRule?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof DynamicGroupRuleInfo
     */
    disableEditRuleValue?: boolean;
}

export function DynamicGroupRuleInfoFromJSON(json: any): DynamicGroupRuleInfo {
    return DynamicGroupRuleInfoFromJSONTyped(json, false);
}

export function DynamicGroupRuleInfoFromJSONTyped(json: any, ignoreDiscriminator: boolean): DynamicGroupRuleInfo {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'order': !exists(json, 'order') ? undefined : json['order'],
        'relation': !exists(json, 'relation') ? undefined : LogicalOperatorFromJSON(json['relation']),
        'category': !exists(json, 'category') ? undefined : CategoryTypeFromJSON(json['category']),
        'metadataId': !exists(json, 'metadataId') ? undefined : json['metadataId'],
        'metadataName': !exists(json, 'metadataName') ? undefined : json['metadataName'],
        'metadataValue': !exists(json, 'metadataValue') ? undefined : json['metadataValue'],
        'metadataDisplayValue': !exists(json, 'metadataDisplayValue') ? undefined : json['metadataDisplayValue'],
        'metadataValueAzureUserType': !exists(json, 'metadataValueAzureUserType') ? undefined : json['metadataValueAzureUserType'],
        'condition': !exists(json, 'condition') ? undefined : DynamicRuleConditionFromJSON(json['condition']),
        'disableEditRule': !exists(json, 'disableEditRule') ? undefined : json['disableEditRule'],
        'disableEditRuleValue': !exists(json, 'disableEditRuleValue') ? undefined : json['disableEditRuleValue'],
    };
}

export function DynamicGroupRuleInfoToJSON(value?: DynamicGroupRuleInfo | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'order': value.order,
        'relation': LogicalOperatorToJSON(value.relation),
        'category': CategoryTypeToJSON(value.category),
        'metadataId': value.metadataId,
        'metadataName': value.metadataName,
        'metadataValue': value.metadataValue,
        'metadataDisplayValue': value.metadataDisplayValue,
        'metadataValueAzureUserType': value.metadataValueAzureUserType,
        'condition': DynamicRuleConditionToJSON(value.condition),
        'disableEditRule': value.disableEditRule,
        'disableEditRuleValue': value.disableEditRuleValue,
    };
}


