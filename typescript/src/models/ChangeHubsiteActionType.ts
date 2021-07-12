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
export enum ChangeHubsiteActionType {
    None = 0,
    RegisterAsHubSite = 1,
    AssociateToHubSite = 2,
    UnRegisterAsHubSite = 3,
    UnRegisterAndAssociateToHubSite = 4
}

export function ChangeHubsiteActionTypeFromJSON(json: any): ChangeHubsiteActionType {
    return ChangeHubsiteActionTypeFromJSONTyped(json, false);
}

export function ChangeHubsiteActionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeHubsiteActionType {
    return json as ChangeHubsiteActionType;
}

export function ChangeHubsiteActionTypeToJSON(value?: ChangeHubsiteActionType | null): any {
    return value as any;
}

