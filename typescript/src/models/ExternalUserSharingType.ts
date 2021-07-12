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
export enum ExternalUserSharingType {
    RequireSignIn = 0,
    AnonymousLink = 1
}

export function ExternalUserSharingTypeFromJSON(json: any): ExternalUserSharingType {
    return ExternalUserSharingTypeFromJSONTyped(json, false);
}

export function ExternalUserSharingTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExternalUserSharingType {
    return json as ExternalUserSharingType;
}

export function ExternalUserSharingTypeToJSON(value?: ExternalUserSharingType | null): any {
    return value as any;
}

