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
export enum GroupIdRuleType {
    ConstructGroupId = 0,
    PopulateGroupIdWithGroupName = 1
}

export function GroupIdRuleTypeFromJSON(json: any): GroupIdRuleType {
    return GroupIdRuleTypeFromJSONTyped(json, false);
}

export function GroupIdRuleTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupIdRuleType {
    return json as GroupIdRuleType;
}

export function GroupIdRuleTypeToJSON(value?: GroupIdRuleType | null): any {
    return value as any;
}

