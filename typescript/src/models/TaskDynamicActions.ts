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
export enum TaskDynamicActions {
    None = 0,
    Extend = 1,
    Archive = 2,
    ChangePolicy = 3,
    OffBoarding = 4,
    Delete = 5,
    ContinueAccess = 6,
    Claim = 7,
    Decline = 8,
    SpecifyContacts = 9,
    SpecifySecondaryContact = 10
}

export function TaskDynamicActionsFromJSON(json: any): TaskDynamicActions {
    return TaskDynamicActionsFromJSONTyped(json, false);
}

export function TaskDynamicActionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskDynamicActions {
    return json as TaskDynamicActions;
}

export function TaskDynamicActionsToJSON(value?: TaskDynamicActions | null): any {
    return value as any;
}

