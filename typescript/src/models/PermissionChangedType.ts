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
export enum PermissionChangedType {
    RemovePermission = 0,
    ChangePermission = 1
}

export function PermissionChangedTypeFromJSON(json: any): PermissionChangedType {
    return PermissionChangedTypeFromJSONTyped(json, false);
}

export function PermissionChangedTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionChangedType {
    return json as PermissionChangedType;
}

export function PermissionChangedTypeToJSON(value?: PermissionChangedType | null): any {
    return value as any;
}

