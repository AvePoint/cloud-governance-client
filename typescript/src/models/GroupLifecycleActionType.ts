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
export enum GroupLifecycleActionType {
    Delete = 0,
    Extend = 1,
    ChangePolicy = 2,
    ChangeQuota = 3,
    Archive = 4,
    Restor = 5
}

export function GroupLifecycleActionTypeFromJSON(json: any): GroupLifecycleActionType {
    return GroupLifecycleActionTypeFromJSONTyped(json, false);
}

export function GroupLifecycleActionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupLifecycleActionType {
    return json as GroupLifecycleActionType;
}

export function GroupLifecycleActionTypeToJSON(value?: GroupLifecycleActionType | null): any {
    return value as any;
}

