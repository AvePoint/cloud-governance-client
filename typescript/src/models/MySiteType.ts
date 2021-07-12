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
export enum MySiteType {
    Site = 0,
    Web = 1
}

export function MySiteTypeFromJSON(json: any): MySiteType {
    return MySiteTypeFromJSONTyped(json, false);
}

export function MySiteTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): MySiteType {
    return json as MySiteType;
}

export function MySiteTypeToJSON(value?: MySiteType | null): any {
    return value as any;
}

