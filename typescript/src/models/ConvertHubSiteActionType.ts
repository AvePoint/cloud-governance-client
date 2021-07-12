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
export enum ConvertHubSiteActionType {
    ConvertToHubSite = 0,
    AssociateOneHubSite = 1
}

export function ConvertHubSiteActionTypeFromJSON(json: any): ConvertHubSiteActionType {
    return ConvertHubSiteActionTypeFromJSONTyped(json, false);
}

export function ConvertHubSiteActionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ConvertHubSiteActionType {
    return json as ConvertHubSiteActionType;
}

export function ConvertHubSiteActionTypeToJSON(value?: ConvertHubSiteActionType | null): any {
    return value as any;
}

