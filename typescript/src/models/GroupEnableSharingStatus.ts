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
export enum GroupEnableSharingStatus {
    None = 0,
    Allowed = 1,
    NotAllowed = 2
}

export function GroupEnableSharingStatusFromJSON(json: any): GroupEnableSharingStatus {
    return GroupEnableSharingStatusFromJSONTyped(json, false);
}

export function GroupEnableSharingStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupEnableSharingStatus {
    return json as GroupEnableSharingStatus;
}

export function GroupEnableSharingStatusToJSON(value?: GroupEnableSharingStatus | null): any {
    return value as any;
}

