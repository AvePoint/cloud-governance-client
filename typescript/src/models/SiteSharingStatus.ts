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
export enum SiteSharingStatus {
    None = 0,
    AnyOne = 1,
    NewAndExistingGuest = 2,
    ExistingGuestOnly = 3,
    Disabled = 4
}

export function SiteSharingStatusFromJSON(json: any): SiteSharingStatus {
    return SiteSharingStatusFromJSONTyped(json, false);
}

export function SiteSharingStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteSharingStatus {
    return json as SiteSharingStatus;
}

export function SiteSharingStatusToJSON(value?: SiteSharingStatus | null): any {
    return value as any;
}

