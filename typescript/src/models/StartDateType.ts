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
export enum StartDateType {
    None = 0,
    CurrentDate = 1,
    SpecifiedDate = 2
}

export function StartDateTypeFromJSON(json: any): StartDateType {
    return StartDateTypeFromJSONTyped(json, false);
}

export function StartDateTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): StartDateType {
    return json as StartDateType;
}

export function StartDateTypeToJSON(value?: StartDateType | null): any {
    return value as any;
}

