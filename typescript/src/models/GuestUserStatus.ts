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
export enum GuestUserStatus {
    Active = 0,
    RenewalPreparing = 1,
    RenewalPending = 2,
    RenewalProcessing = 3,
    RenewalCompleted = 4,
    RenewalException = 5,
    RenewalOverdue = 6,
    Deleted = 7,
    Disabled = 8,
    RenewalDisabled = 9,
    AutoImportProcessInProgress = 10,
    AutoImportTaskException = 11,
    AutoImportComplete = 12
}

export function GuestUserStatusFromJSON(json: any): GuestUserStatus {
    return GuestUserStatusFromJSONTyped(json, false);
}

export function GuestUserStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuestUserStatus {
    return json as GuestUserStatus;
}

export function GuestUserStatusToJSON(value?: GuestUserStatus | null): any {
    return value as any;
}

