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
export enum SPGroupEditOption {
    GroupOwner = 0,
    GroupMembers = 1
}

export function SPGroupEditOptionFromJSON(json: any): SPGroupEditOption {
    return SPGroupEditOptionFromJSONTyped(json, false);
}

export function SPGroupEditOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPGroupEditOption {
    return json as SPGroupEditOption;
}

export function SPGroupEditOptionToJSON(value?: SPGroupEditOption | null): any {
    return value as any;
}

