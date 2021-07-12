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
export enum SiteConstructUrlType {
    ManualInputUrl = 0,
    AutoGenerateUrl = 1
}

export function SiteConstructUrlTypeFromJSON(json: any): SiteConstructUrlType {
    return SiteConstructUrlTypeFromJSONTyped(json, false);
}

export function SiteConstructUrlTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteConstructUrlType {
    return json as SiteConstructUrlType;
}

export function SiteConstructUrlTypeToJSON(value?: SiteConstructUrlType | null): any {
    return value as any;
}

