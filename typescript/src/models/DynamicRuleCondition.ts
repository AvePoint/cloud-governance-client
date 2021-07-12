/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

/**
 * 
 * @export
 * @enum {string}
 */
export enum DynamicRuleCondition {
    Equals = 0,
    Contains = 1,
    Is = 2,
    In = 3,
    DoesNotBelongTo = 4
}

export function DynamicRuleConditionFromJSON(json: any): DynamicRuleCondition {
    return DynamicRuleConditionFromJSONTyped(json, false);
}

export function DynamicRuleConditionFromJSONTyped(json: any, ignoreDiscriminator: boolean): DynamicRuleCondition {
    return json as DynamicRuleCondition;
}

export function DynamicRuleConditionToJSON(value?: DynamicRuleCondition | null): any {
    return value as any;
}

