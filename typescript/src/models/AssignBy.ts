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
export enum AssignBy {
    BusinessUser = 0,
    BusinessUserWithRequired = 1,
    ITAdminWithReadOnly = 2,
    ITAdminWithHide = 3
}

export function AssignByFromJSON(json: any): AssignBy {
    return AssignByFromJSONTyped(json, false);
}

export function AssignByFromJSONTyped(json: any, ignoreDiscriminator: boolean): AssignBy {
    return json as AssignBy;
}

export function AssignByToJSON(value?: AssignBy | null): any {
    return value as any;
}

