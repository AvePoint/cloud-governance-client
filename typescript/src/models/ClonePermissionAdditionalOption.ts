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
export enum ClonePermissionAdditionalOption {
    AddUserToTheSameGroup = 0,
    GranPermissionDirectly = 1
}

export function ClonePermissionAdditionalOptionFromJSON(json: any): ClonePermissionAdditionalOption {
    return ClonePermissionAdditionalOptionFromJSONTyped(json, false);
}

export function ClonePermissionAdditionalOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): ClonePermissionAdditionalOption {
    return json as ClonePermissionAdditionalOption;
}

export function ClonePermissionAdditionalOptionToJSON(value?: ClonePermissionAdditionalOption | null): any {
    return value as any;
}

