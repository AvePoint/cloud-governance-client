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
export enum ApiRequestProgressStatus {
    None = 0,
    RequestSubmitted = 1,
    WaitingForApproval = 2,
    WaitingForSubmission = 3,
    Cancelled = 4,
    Rejected = 5,
    Completed = 6,
    CompletedWithException = 7,
    EncounterError = 8,
    InProgress = 9,
    FailedWithSubRequestException = 10
}

export function ApiRequestProgressStatusFromJSON(json: any): ApiRequestProgressStatus {
    return ApiRequestProgressStatusFromJSONTyped(json, false);
}

export function ApiRequestProgressStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiRequestProgressStatus {
    return json as ApiRequestProgressStatus;
}

export function ApiRequestProgressStatusToJSON(value?: ApiRequestProgressStatus | null): any {
    return value as any;
}

