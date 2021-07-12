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
export enum WorkspaceArchivedType {
    Site = 0,
    Teams = 1
}

export function WorkspaceArchivedTypeFromJSON(json: any): WorkspaceArchivedType {
    return WorkspaceArchivedTypeFromJSONTyped(json, false);
}

export function WorkspaceArchivedTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceArchivedType {
    return json as WorkspaceArchivedType;
}

export function WorkspaceArchivedTypeToJSON(value?: WorkspaceArchivedType | null): any {
    return value as any;
}

