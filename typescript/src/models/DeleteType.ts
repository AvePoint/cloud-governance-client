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
export enum DeleteType {
    None = 0,
    Manually = 1,
    Auto = 2
}

export function DeleteTypeFromJSON(json: any): DeleteType {
    return DeleteTypeFromJSONTyped(json, false);
}

export function DeleteTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): DeleteType {
    return json as DeleteType;
}

export function DeleteTypeToJSON(value?: DeleteType | null): any {
    return value as any;
}

