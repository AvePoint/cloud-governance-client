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
export enum ExternalUserType {
    None = 0,
    Authentication = 1,
    NoAuthentication = 2
}

export function ExternalUserTypeFromJSON(json: any): ExternalUserType {
    return ExternalUserTypeFromJSONTyped(json, false);
}

export function ExternalUserTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExternalUserType {
    return json as ExternalUserType;
}

export function ExternalUserTypeToJSON(value?: ExternalUserType | null): any {
    return value as any;
}

