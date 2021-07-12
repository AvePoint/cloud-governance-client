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
export enum TaskApprovalStatus {
    PendingApproval = 0,
    PendingConfirm = 1,
    PendingAndCompleted = 2
}

export function TaskApprovalStatusFromJSON(json: any): TaskApprovalStatus {
    return TaskApprovalStatusFromJSONTyped(json, false);
}

export function TaskApprovalStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskApprovalStatus {
    return json as TaskApprovalStatus;
}

export function TaskApprovalStatusToJSON(value?: TaskApprovalStatus | null): any {
    return value as any;
}

