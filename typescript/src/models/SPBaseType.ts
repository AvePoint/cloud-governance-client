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
export enum SPBaseType {
    GenericList = 0,
    DocumentLibrary = 1,
    Unused = 2,
    DiscussionBoard = 3,
    Survey = 4,
    Issue = 5,
    UnspecifiedBaseType = -1
}

export function SPBaseTypeFromJSON(json: any): SPBaseType {
    return SPBaseTypeFromJSONTyped(json, false);
}

export function SPBaseTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPBaseType {
    return json as SPBaseType;
}

export function SPBaseTypeToJSON(value?: SPBaseType | null): any {
    return value as any;
}

