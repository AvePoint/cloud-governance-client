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
export enum AutoGenerateUrlType {
    SequentialNumber = 0,
    RandomString = 1
}

export function AutoGenerateUrlTypeFromJSON(json: any): AutoGenerateUrlType {
    return AutoGenerateUrlTypeFromJSONTyped(json, false);
}

export function AutoGenerateUrlTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): AutoGenerateUrlType {
    return json as AutoGenerateUrlType;
}

export function AutoGenerateUrlTypeToJSON(value?: AutoGenerateUrlType | null): any {
    return value as any;
}

