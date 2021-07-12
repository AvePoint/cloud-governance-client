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
export enum AnnoymouslinkPermissions {
    View = 0,
    Edit = 1
}

export function AnnoymouslinkPermissionsFromJSON(json: any): AnnoymouslinkPermissions {
    return AnnoymouslinkPermissionsFromJSONTyped(json, false);
}

export function AnnoymouslinkPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): AnnoymouslinkPermissions {
    return json as AnnoymouslinkPermissions;
}

export function AnnoymouslinkPermissionsToJSON(value?: AnnoymouslinkPermissions | null): any {
    return value as any;
}

