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
export enum ConflictSolutionType {
    Skip = 0,
    NotOverWrite = 1,
    Append = 2,
    OverWrite = 3,
    Replace = 4,
    Merge = 5,
    OverWritebyLastModifiedTime = 6,
    None = 7
}

export function ConflictSolutionTypeFromJSON(json: any): ConflictSolutionType {
    return ConflictSolutionTypeFromJSONTyped(json, false);
}

export function ConflictSolutionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ConflictSolutionType {
    return json as ConflictSolutionType;
}

export function ConflictSolutionTypeToJSON(value?: ConflictSolutionType | null): any {
    return value as any;
}

