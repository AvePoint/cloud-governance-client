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
export enum TaskType {
    ApprovalTask = 0,
    ErrorHandlingTask = 1,
    SCExpired = 2,
    SCNoAccess = 3,
    ToDoTask = 4,
    UserExpired = 5,
    GroupExpired = 6,
    GroupInactivityThreshold = 7,
    AutoImportGroup = 8,
    AutoImportSite = 9,
    RenewGroup = 10,
    RenewSite = 11,
    RenewGuestUser = 12
}

export function TaskTypeFromJSON(json: any): TaskType {
    return TaskTypeFromJSONTyped(json, false);
}

export function TaskTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskType {
    return json as TaskType;
}

export function TaskTypeToJSON(value?: TaskType | null): any {
    return value as any;
}

