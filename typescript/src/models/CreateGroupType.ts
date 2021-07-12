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
export enum CreateGroupType {
    Group = 0,
    Team = 1,
    Yammer = 2
}

export function CreateGroupTypeFromJSON(json: any): CreateGroupType {
    return CreateGroupTypeFromJSONTyped(json, false);
}

export function CreateGroupTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGroupType {
    return json as CreateGroupType;
}

export function CreateGroupTypeToJSON(value?: CreateGroupType | null): any {
    return value as any;
}

