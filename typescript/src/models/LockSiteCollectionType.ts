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
export enum LockSiteCollectionType {
    NoAccess = 0,
    ReadOnly = 1
}

export function LockSiteCollectionTypeFromJSON(json: any): LockSiteCollectionType {
    return LockSiteCollectionTypeFromJSONTyped(json, false);
}

export function LockSiteCollectionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): LockSiteCollectionType {
    return json as LockSiteCollectionType;
}

export function LockSiteCollectionTypeToJSON(value?: LockSiteCollectionType | null): any {
    return value as any;
}

