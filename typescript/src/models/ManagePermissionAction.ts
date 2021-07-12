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
export enum ManagePermissionAction {
    None = 0,
    Added = 1,
    Changed = 2,
    Deleted = 3,
    Copied = 4
}

export function ManagePermissionActionFromJSON(json: any): ManagePermissionAction {
    return ManagePermissionActionFromJSONTyped(json, false);
}

export function ManagePermissionActionFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionAction {
    return json as ManagePermissionAction;
}

export function ManagePermissionActionToJSON(value?: ManagePermissionAction | null): any {
    return value as any;
}

