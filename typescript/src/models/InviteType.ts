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
export enum InviteType {
    User = 0,
    Group = 1,
    UserInGroup = 2,
    PortalSupport = 3,
    ProductSupport = 4
}

export function InviteTypeFromJSON(json: any): InviteType {
    return InviteTypeFromJSONTyped(json, false);
}

export function InviteTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): InviteType {
    return json as InviteType;
}

export function InviteTypeToJSON(value?: InviteType | null): any {
    return value as any;
}

