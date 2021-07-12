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
export enum GroupOwnerType {
    SpoGroup = 0,
    User = 1
}

export function GroupOwnerTypeFromJSON(json: any): GroupOwnerType {
    return GroupOwnerTypeFromJSONTyped(json, false);
}

export function GroupOwnerTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupOwnerType {
    return json as GroupOwnerType;
}

export function GroupOwnerTypeToJSON(value?: GroupOwnerType | null): any {
    return value as any;
}

