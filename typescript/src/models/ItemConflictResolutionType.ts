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
export enum ItemConflictResolutionType {
    DoNotMigrateTheItems = 0,
    OverwriteIdenticalItemsInDestination = 1,
    Append = 2,
    IgnoreDifferenceAndMoveItems = 3
}

export function ItemConflictResolutionTypeFromJSON(json: any): ItemConflictResolutionType {
    return ItemConflictResolutionTypeFromJSONTyped(json, false);
}

export function ItemConflictResolutionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ItemConflictResolutionType {
    return json as ItemConflictResolutionType;
}

export function ItemConflictResolutionTypeToJSON(value?: ItemConflictResolutionType | null): any {
    return value as any;
}

