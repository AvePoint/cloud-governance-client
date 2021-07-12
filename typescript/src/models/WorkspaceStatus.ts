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
export enum WorkspaceStatus {
    Active = 0,
    Deleted = 1,
    Archived = 2,
    Locked = 3,
    TemporaryLocked = 4,
    GroupSiteLocked = 5,
    RestrictAccess = 6
}

export function WorkspaceStatusFromJSON(json: any): WorkspaceStatus {
    return WorkspaceStatusFromJSONTyped(json, false);
}

export function WorkspaceStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceStatus {
    return json as WorkspaceStatus;
}

export function WorkspaceStatusToJSON(value?: WorkspaceStatus | null): any {
    return value as any;
}

