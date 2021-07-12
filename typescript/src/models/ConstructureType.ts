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
export enum ConstructureType {
    Text = 0,
    Metadata = 1,
    Attribute = 2
}

export function ConstructureTypeFromJSON(json: any): ConstructureType {
    return ConstructureTypeFromJSONTyped(json, false);
}

export function ConstructureTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ConstructureType {
    return json as ConstructureType;
}

export function ConstructureTypeToJSON(value?: ConstructureType | null): any {
    return value as any;
}

