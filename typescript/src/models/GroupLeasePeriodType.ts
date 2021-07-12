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
export enum GroupLeasePeriodType {
    Duration = 0,
    Date = 1
}

export function GroupLeasePeriodTypeFromJSON(json: any): GroupLeasePeriodType {
    return GroupLeasePeriodTypeFromJSONTyped(json, false);
}

export function GroupLeasePeriodTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupLeasePeriodType {
    return json as GroupLeasePeriodType;
}

export function GroupLeasePeriodTypeToJSON(value?: GroupLeasePeriodType | null): any {
    return value as any;
}

