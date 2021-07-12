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
export enum CommonStatus {
    Inactive = 0,
    Active = 1
}

export function CommonStatusFromJSON(json: any): CommonStatus {
    return CommonStatusFromJSONTyped(json, false);
}

export function CommonStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): CommonStatus {
    return json as CommonStatus;
}

export function CommonStatusToJSON(value?: CommonStatus | null): any {
    return value as any;
}

