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
export enum CategoryType {
    Contact = 0,
    License = 1,
    Organization = 2
}

export function CategoryTypeFromJSON(json: any): CategoryType {
    return CategoryTypeFromJSONTyped(json, false);
}

export function CategoryTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): CategoryType {
    return json as CategoryType;
}

export function CategoryTypeToJSON(value?: CategoryType | null): any {
    return value as any;
}

