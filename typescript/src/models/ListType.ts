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
export enum ListType {
    Library = 0,
    List = 1
}

export function ListTypeFromJSON(json: any): ListType {
    return ListTypeFromJSONTyped(json, false);
}

export function ListTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListType {
    return json as ListType;
}

export function ListTypeToJSON(value?: ListType | null): any {
    return value as any;
}

