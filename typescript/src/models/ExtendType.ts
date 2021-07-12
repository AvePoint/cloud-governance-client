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
export enum ExtendType {
    WithConstantValue = 0,
    WithinSpecifyLimit = 1
}

export function ExtendTypeFromJSON(json: any): ExtendType {
    return ExtendTypeFromJSONTyped(json, false);
}

export function ExtendTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExtendType {
    return json as ExtendType;
}

export function ExtendTypeToJSON(value?: ExtendType | null): any {
    return value as any;
}

