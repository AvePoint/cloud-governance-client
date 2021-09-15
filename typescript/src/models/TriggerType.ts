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
export enum TriggerType {
    None = 0,
    RequestSubmitted = 1,
    RequestCompleted = 2,
    RequestCancelled = 4,
    TaskCreated = 8,
    TaskApproved = 16,
    TaskRejected = 32,
    ErrorTaskCreated = 64,
    TaskRetried = 128,
    TaskSkipped = 256,
    RenewalSuccess = 512,
    RenewalException = 1024,
    RenewalOverdue = 2048,
    FullyAutoImportSuccess = 4096,
    ConfirmDetailSuccess = 8192,
    ElectionCompleted = 16384,
    LifecycleInactiveTaskCreated = 32768,
    LifecycleLeaseTaskCreated = 65536,
    ElectionOverdue = 131072
}

export function TriggerTypeFromJSON(json: any): TriggerType {
    return TriggerTypeFromJSONTyped(json, false);
}

export function TriggerTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): TriggerType {
    return json as TriggerType;
}

export function TriggerTypeToJSON(value?: TriggerType | null): any {
    return value as any;
}

