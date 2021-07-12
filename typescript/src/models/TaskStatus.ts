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
export enum TaskStatus {
    Created = 0,
    WaitingForActivation = 1,
    WaitingToRun = 2,
    Running = 3,
    WaitingForChildrenToComplete = 4,
    RanToCompletion = 5,
    Canceled = 6,
    Faulted = 7
}

export function TaskStatusFromJSON(json: any): TaskStatus {
    return TaskStatusFromJSONTyped(json, false);
}

export function TaskStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskStatus {
    return json as TaskStatus;
}

export function TaskStatusToJSON(value?: TaskStatus | null): any {
    return value as any;
}

