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
export enum SPGroupViewOption {
    GroupMembers = 0,
    EveryOne = 1
}

export function SPGroupViewOptionFromJSON(json: any): SPGroupViewOption {
    return SPGroupViewOptionFromJSONTyped(json, false);
}

export function SPGroupViewOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPGroupViewOption {
    return json as SPGroupViewOption;
}

export function SPGroupViewOptionToJSON(value?: SPGroupViewOption | null): any {
    return value as any;
}

