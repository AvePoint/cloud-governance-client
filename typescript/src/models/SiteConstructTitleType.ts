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
export enum SiteConstructTitleType {
    Text = 0,
    Metadata = 1
}

export function SiteConstructTitleTypeFromJSON(json: any): SiteConstructTitleType {
    return SiteConstructTitleTypeFromJSONTyped(json, false);
}

export function SiteConstructTitleTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteConstructTitleType {
    return json as SiteConstructTitleType;
}

export function SiteConstructTitleTypeToJSON(value?: SiteConstructTitleType | null): any {
    return value as any;
}

