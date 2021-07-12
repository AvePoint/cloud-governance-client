/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

/**
 * Action types when changing metadata
 * @export
 * @enum {string}
 */
export enum MetadataActionType {
    NoChange = 0,
    Add = 1,
    Edit = 2,
    Delete = -1
}

export function MetadataActionTypeFromJSON(json: any): MetadataActionType {
    return MetadataActionTypeFromJSONTyped(json, false);
}

export function MetadataActionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataActionType {
    return json as MetadataActionType;
}

export function MetadataActionTypeToJSON(value?: MetadataActionType | null): any {
    return value as any;
}

