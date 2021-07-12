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
export enum GroupObjectType {
    Group = 0,
    Team = 1,
    Yammer = 2
}

export function GroupObjectTypeFromJSON(json: any): GroupObjectType {
    return GroupObjectTypeFromJSONTyped(json, false);
}

export function GroupObjectTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupObjectType {
    return json as GroupObjectType;
}

export function GroupObjectTypeToJSON(value?: GroupObjectType | null): any {
    return value as any;
}

