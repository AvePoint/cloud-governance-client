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
export enum ExternalSharingOptions {
    Disabled = 0,
    VerifiedGuestUser = 1,
    Anyone = 2,
    ExistingGuestUser = 3
}

export function ExternalSharingOptionsFromJSON(json: any): ExternalSharingOptions {
    return ExternalSharingOptionsFromJSONTyped(json, false);
}

export function ExternalSharingOptionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExternalSharingOptions {
    return json as ExternalSharingOptions;
}

export function ExternalSharingOptionsToJSON(value?: ExternalSharingOptions | null): any {
    return value as any;
}

