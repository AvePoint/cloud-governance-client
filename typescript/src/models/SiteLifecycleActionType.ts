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
export enum SiteLifecycleActionType {
    None = 0,
    Extend = 1,
    Delete = 2,
    Archive = 3,
    ChangePolicy = 4,
    Unlock = 5,
    Lock = 7,
    ChangeQuota = 8
}

export function SiteLifecycleActionTypeFromJSON(json: any): SiteLifecycleActionType {
    return SiteLifecycleActionTypeFromJSONTyped(json, false);
}

export function SiteLifecycleActionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLifecycleActionType {
    return json as SiteLifecycleActionType;
}

export function SiteLifecycleActionTypeToJSON(value?: SiteLifecycleActionType | null): any {
    return value as any;
}

