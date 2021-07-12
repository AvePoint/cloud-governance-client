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
export enum AddGroupMemberType {
    Manually = 0,
    Dynamically = 1
}

export function AddGroupMemberTypeFromJSON(json: any): AddGroupMemberType {
    return AddGroupMemberTypeFromJSONTyped(json, false);
}

export function AddGroupMemberTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): AddGroupMemberType {
    return json as AddGroupMemberType;
}

export function AddGroupMemberTypeToJSON(value?: AddGroupMemberType | null): any {
    return value as any;
}

