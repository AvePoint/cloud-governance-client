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
export enum SiteStatus {
    Active = 0,
    Deleted = 1,
    Archived = 2,
    Locked = 3,
    TemporaryLocked = 4
}

export function SiteStatusFromJSON(json: any): SiteStatus {
    return SiteStatusFromJSONTyped(json, false);
}

export function SiteStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteStatus {
    return json as SiteStatus;
}

export function SiteStatusToJSON(value?: SiteStatus | null): any {
    return value as any;
}

