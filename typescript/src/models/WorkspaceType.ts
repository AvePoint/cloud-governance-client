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
export enum WorkspaceType {
    Site = 0,
    Web = 1,
    Group = 2,
    Teams = 3,
    Yammer = 4
}

export function WorkspaceTypeFromJSON(json: any): WorkspaceType {
    return WorkspaceTypeFromJSONTyped(json, false);
}

export function WorkspaceTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceType {
    return json as WorkspaceType;
}

export function WorkspaceTypeToJSON(value?: WorkspaceType | null): any {
    return value as any;
}

