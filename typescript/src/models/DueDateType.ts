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
export enum DueDateType {
    None = 0,
    Expired = 1,
    DueToday = 2,
    DueThisWeek = 3,
    DueThisMonth = 4
}

export function DueDateTypeFromJSON(json: any): DueDateType {
    return DueDateTypeFromJSONTyped(json, false);
}

export function DueDateTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): DueDateType {
    return json as DueDateType;
}

export function DueDateTypeToJSON(value?: DueDateType | null): any {
    return value as any;
}

