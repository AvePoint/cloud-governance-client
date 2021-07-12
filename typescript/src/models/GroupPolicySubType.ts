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
export enum GroupPolicySubType {
    None = 0,
    Group = 1,
    Team = 2,
    Yammer = 3
}

export function GroupPolicySubTypeFromJSON(json: any): GroupPolicySubType {
    return GroupPolicySubTypeFromJSONTyped(json, false);
}

export function GroupPolicySubTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupPolicySubType {
    return json as GroupPolicySubType;
}

export function GroupPolicySubTypeToJSON(value?: GroupPolicySubType | null): any {
    return value as any;
}

