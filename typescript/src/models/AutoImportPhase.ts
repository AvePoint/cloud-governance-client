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
export enum AutoImportPhase {
    Confirmed = 0,
    Processing = 1,
    PendingInition = 2,
    ApplyInformationException = 3,
    Overdue = 4,
    PendingRenewal = 5,
    RenewalExpired = 6,
    RenewalProcessing = 7,
    RenewalException = 8,
    Locked = 9,
    RenewalCanceled = 10,
    RenewalPreparing = 11,
    Invalid = 12,
    Archived = 13,
    Escalation = 14,
    ITRenewalCanceled = 15
}

export function AutoImportPhaseFromJSON(json: any): AutoImportPhase {
    return AutoImportPhaseFromJSONTyped(json, false);
}

export function AutoImportPhaseFromJSONTyped(json: any, ignoreDiscriminator: boolean): AutoImportPhase {
    return json as AutoImportPhase;
}

export function AutoImportPhaseToJSON(value?: AutoImportPhase | null): any {
    return value as any;
}

