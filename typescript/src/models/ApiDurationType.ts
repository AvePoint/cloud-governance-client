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
export enum ApiDurationType {
    Day = 0,
    Week = 1,
    Month = 2,
    Year = 3
}

export function ApiDurationTypeFromJSON(json: any): ApiDurationType {
    return ApiDurationTypeFromJSONTyped(json, false);
}

export function ApiDurationTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiDurationType {
    return json as ApiDurationType;
}

export function ApiDurationTypeToJSON(value?: ApiDurationType | null): any {
    return value as any;
}

