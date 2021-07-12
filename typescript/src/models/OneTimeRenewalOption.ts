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
export enum OneTimeRenewalOption {
    NoMore = 0,
    Specific = 1
}

export function OneTimeRenewalOptionFromJSON(json: any): OneTimeRenewalOption {
    return OneTimeRenewalOptionFromJSONTyped(json, false);
}

export function OneTimeRenewalOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): OneTimeRenewalOption {
    return json as OneTimeRenewalOption;
}

export function OneTimeRenewalOptionToJSON(value?: OneTimeRenewalOption | null): any {
    return value as any;
}

