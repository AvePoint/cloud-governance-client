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
export enum YammerGroupJoinType {
    Anyone = 0,
    AdminApproved = 1
}

export function YammerGroupJoinTypeFromJSON(json: any): YammerGroupJoinType {
    return YammerGroupJoinTypeFromJSONTyped(json, false);
}

export function YammerGroupJoinTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): YammerGroupJoinType {
    return json as YammerGroupJoinType;
}

export function YammerGroupJoinTypeToJSON(value?: YammerGroupJoinType | null): any {
    return value as any;
}

