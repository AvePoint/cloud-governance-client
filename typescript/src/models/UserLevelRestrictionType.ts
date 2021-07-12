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
export enum UserLevelRestrictionType {
    AnyUser = 0,
    PeersAndDirectOrIndirectReport = 1,
    DirectOrIndirectReports = 2
}

export function UserLevelRestrictionTypeFromJSON(json: any): UserLevelRestrictionType {
    return UserLevelRestrictionTypeFromJSONTyped(json, false);
}

export function UserLevelRestrictionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserLevelRestrictionType {
    return json as UserLevelRestrictionType;
}

export function UserLevelRestrictionTypeToJSON(value?: UserLevelRestrictionType | null): any {
    return value as any;
}

