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
export enum WebLifecycleActionType {
    None = 0,
    Delete = 1,
    Archive = 2
}

export function WebLifecycleActionTypeFromJSON(json: any): WebLifecycleActionType {
    return WebLifecycleActionTypeFromJSONTyped(json, false);
}

export function WebLifecycleActionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): WebLifecycleActionType {
    return json as WebLifecycleActionType;
}

export function WebLifecycleActionTypeToJSON(value?: WebLifecycleActionType | null): any {
    return value as any;
}

