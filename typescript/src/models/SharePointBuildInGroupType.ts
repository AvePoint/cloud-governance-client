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
export enum SharePointBuildInGroupType {
    None = 0,
    Owners = 1,
    Members = 2,
    Visitors = 3
}

export function SharePointBuildInGroupTypeFromJSON(json: any): SharePointBuildInGroupType {
    return SharePointBuildInGroupTypeFromJSONTyped(json, false);
}

export function SharePointBuildInGroupTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SharePointBuildInGroupType {
    return json as SharePointBuildInGroupType;
}

export function SharePointBuildInGroupTypeToJSON(value?: SharePointBuildInGroupType | null): any {
    return value as any;
}

