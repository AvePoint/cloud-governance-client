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
export enum ClonePermissionOption {
    Append = 0,
    Replace = 1
}

export function ClonePermissionOptionFromJSON(json: any): ClonePermissionOption {
    return ClonePermissionOptionFromJSONTyped(json, false);
}

export function ClonePermissionOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): ClonePermissionOption {
    return json as ClonePermissionOption;
}

export function ClonePermissionOptionToJSON(value?: ClonePermissionOption | null): any {
    return value as any;
}

