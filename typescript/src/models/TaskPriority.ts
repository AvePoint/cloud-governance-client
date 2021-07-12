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
export enum TaskPriority {
    Lowest = 0,
    BelowNormal = 1,
    Normal = 2,
    AboveNormal = 3,
    Highest = 4
}

export function TaskPriorityFromJSON(json: any): TaskPriority {
    return TaskPriorityFromJSONTyped(json, false);
}

export function TaskPriorityFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskPriority {
    return json as TaskPriority;
}

export function TaskPriorityToJSON(value?: TaskPriority | null): any {
    return value as any;
}

