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
export enum DurationDateType {
    Day = 0,
    Month = 1,
    Year = 2
}

export function DurationDateTypeFromJSON(json: any): DurationDateType {
    return DurationDateTypeFromJSONTyped(json, false);
}

export function DurationDateTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): DurationDateType {
    return json as DurationDateType;
}

export function DurationDateTypeToJSON(value?: DurationDateType | null): any {
    return value as any;
}

