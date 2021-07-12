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
export enum ApiSiteStatus {
    NotExists = 0,
    Active = 1,
    Recycled = 2,
    NoAccess = 3,
    ReadOnly = 4
}

export function ApiSiteStatusFromJSON(json: any): ApiSiteStatus {
    return ApiSiteStatusFromJSONTyped(json, false);
}

export function ApiSiteStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiSiteStatus {
    return json as ApiSiteStatus;
}

export function ApiSiteStatusToJSON(value?: ApiSiteStatus | null): any {
    return value as any;
}

