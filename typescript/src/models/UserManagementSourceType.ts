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
export enum UserManagementSourceType {
    User = 0,
    Group = 1,
    All = 2
}

export function UserManagementSourceTypeFromJSON(json: any): UserManagementSourceType {
    return UserManagementSourceTypeFromJSONTyped(json, false);
}

export function UserManagementSourceTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserManagementSourceType {
    return json as UserManagementSourceType;
}

export function UserManagementSourceTypeToJSON(value?: UserManagementSourceType | null): any {
    return value as any;
}

