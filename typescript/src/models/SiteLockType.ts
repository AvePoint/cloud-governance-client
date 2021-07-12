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
export enum SiteLockType {
    NoAccess = 0,
    ReadOnly = 1,
    NoAccessAndReadOnly = 2,
    Unlock = 3
}

export function SiteLockTypeFromJSON(json: any): SiteLockType {
    return SiteLockTypeFromJSONTyped(json, false);
}

export function SiteLockTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLockType {
    return json as SiteLockType;
}

export function SiteLockTypeToJSON(value?: SiteLockType | null): any {
    return value as any;
}

