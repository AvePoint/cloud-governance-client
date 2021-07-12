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
export enum HubSiteType {
    No = 0,
    Registere = 1,
    Associated = 2
}

export function HubSiteTypeFromJSON(json: any): HubSiteType {
    return HubSiteTypeFromJSONTyped(json, false);
}

export function HubSiteTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): HubSiteType {
    return json as HubSiteType;
}

export function HubSiteTypeToJSON(value?: HubSiteType | null): any {
    return value as any;
}

