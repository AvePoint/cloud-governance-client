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
export enum YammerGroupType {
    Public = 0,
    Private = 1
}

export function YammerGroupTypeFromJSON(json: any): YammerGroupType {
    return YammerGroupTypeFromJSONTyped(json, false);
}

export function YammerGroupTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): YammerGroupType {
    return json as YammerGroupType;
}

export function YammerGroupTypeToJSON(value?: YammerGroupType | null): any {
    return value as any;
}

