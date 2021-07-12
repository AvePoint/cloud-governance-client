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
export enum LeaseDateType {
    None = 0,
    KeepStartDate = 1,
    NewStartDate = 2,
    KeepLeaseDate = 3
}

export function LeaseDateTypeFromJSON(json: any): LeaseDateType {
    return LeaseDateTypeFromJSONTyped(json, false);
}

export function LeaseDateTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): LeaseDateType {
    return json as LeaseDateType;
}

export function LeaseDateTypeToJSON(value?: LeaseDateType | null): any {
    return value as any;
}

