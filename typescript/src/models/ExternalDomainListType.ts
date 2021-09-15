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
export enum ExternalDomainListType {
    AllowSpecificDomainList = 0,
    BlockSpecificDomainList = 1
}

export function ExternalDomainListTypeFromJSON(json: any): ExternalDomainListType {
    return ExternalDomainListTypeFromJSONTyped(json, false);
}

export function ExternalDomainListTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExternalDomainListType {
    return json as ExternalDomainListType;
}

export function ExternalDomainListTypeToJSON(value?: ExternalDomainListType | null): any {
    return value as any;
}

