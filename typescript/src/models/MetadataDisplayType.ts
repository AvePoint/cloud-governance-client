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
export enum MetadataDisplayType {
    DoNotDisplayInReport = 1,
    DisplayInPublicSCDirectoryReport = 2,
    DisplayInAdministrationReport = 3
}

export function MetadataDisplayTypeFromJSON(json: any): MetadataDisplayType {
    return MetadataDisplayTypeFromJSONTyped(json, false);
}

export function MetadataDisplayTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataDisplayType {
    return json as MetadataDisplayType;
}

export function MetadataDisplayTypeToJSON(value?: MetadataDisplayType | null): any {
    return value as any;
}

