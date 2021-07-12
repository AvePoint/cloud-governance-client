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
export enum UserSource {
    All = 0,
    Local = 1,
    Azure = 2,
    SharePoint = 3,
    Yammer = 4
}

export function UserSourceFromJSON(json: any): UserSource {
    return UserSourceFromJSONTyped(json, false);
}

export function UserSourceFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserSource {
    return json as UserSource;
}

export function UserSourceToJSON(value?: UserSource | null): any {
    return value as any;
}

