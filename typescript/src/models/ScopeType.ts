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
export enum ScopeType {
    ManuallyInput = 0,
    SelectFromTree = 1
}

export function ScopeTypeFromJSON(json: any): ScopeType {
    return ScopeTypeFromJSONTyped(json, false);
}

export function ScopeTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ScopeType {
    return json as ScopeType;
}

export function ScopeTypeToJSON(value?: ScopeType | null): any {
    return value as any;
}

