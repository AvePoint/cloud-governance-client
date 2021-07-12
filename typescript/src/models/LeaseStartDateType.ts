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
export enum LeaseStartDateType {
    None = 0,
    CreateDate = 1,
    SpecificDate = 2
}

export function LeaseStartDateTypeFromJSON(json: any): LeaseStartDateType {
    return LeaseStartDateTypeFromJSONTyped(json, false);
}

export function LeaseStartDateTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): LeaseStartDateType {
    return json as LeaseStartDateType;
}

export function LeaseStartDateTypeToJSON(value?: LeaseStartDateType | null): any {
    return value as any;
}

