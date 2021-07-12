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
export enum MetadataFieldType {
    None = 0,
    SingleLineText = 1,
    MultiLineText = 2,
    YesOrNo = 3,
    Choices = 4,
    PeoplePickerValue = 5,
    Terms = 6,
    Hyperlink = 7,
    UserProfileService = 8,
    AzureADProperty = 9,
    SharePointList = 10
}

export function MetadataFieldTypeFromJSON(json: any): MetadataFieldType {
    return MetadataFieldTypeFromJSONTyped(json, false);
}

export function MetadataFieldTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataFieldType {
    return json as MetadataFieldType;
}

export function MetadataFieldTypeToJSON(value?: MetadataFieldType | null): any {
    return value as any;
}

