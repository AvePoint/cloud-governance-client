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
export enum SPPrincipalType {
    None = 0,
    User = 1,
    DistributionList = 2,
    SecurityGroup = 4,
    SharePointGroup = 8,
    All = 15
}

export function SPPrincipalTypeFromJSON(json: any): SPPrincipalType {
    return SPPrincipalTypeFromJSONTyped(json, false);
}

export function SPPrincipalTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPPrincipalType {
    return json as SPPrincipalType;
}

export function SPPrincipalTypeToJSON(value?: SPPrincipalType | null): any {
    return value as any;
}

