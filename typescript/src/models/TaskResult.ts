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
export enum TaskResult {
    Running = 0,
    Approved = 1,
    Rejected = 2,
    Canceled = 3,
    TimeOut = 4,
    Completed = 5,
    AutoActionApproved = 6,
    Retried = 7,
    Skipped = 8,
    Submited = 9,
    WaitingForSubmission = 10,
    AllStagesTimeOut = 11,
    Declined = 12,
    WaitingForClaim = 13,
    ElectionTaskTimeOut = 14,
    Claimed = 15,
    AutoComplete = 16,
    WaitingForSpecify = 17,
    PendingConfirm = 19,
    ConfirmOverdue = 20,
    PendingRenewal = 21,
    RenewalExpired = 22,
    ConfirmException = 23,
    RenewalException = 24,
    WaitingForSpecifyBothContacts = 25,
    WaitingForConfirmation = 26,
    InProgress = 27,
    ConfirmTaskOverdue = 28,
    ConfirmTaskEscalation = 29,
    WaitingForAssistant = 30
}

export function TaskResultFromJSON(json: any): TaskResult {
    return TaskResultFromJSONTyped(json, false);
}

export function TaskResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskResult {
    return json as TaskResult;
}

export function TaskResultToJSON(value?: TaskResult | null): any {
    return value as any;
}

