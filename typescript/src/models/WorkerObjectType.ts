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
export enum WorkerObjectType {
    GroupOrTeamOrYammer = 0,
    Site = 1,
    Web = 2,
    GuestUser = 3
}

export function WorkerObjectTypeFromJSON(json: any): WorkerObjectType {
    return WorkerObjectTypeFromJSONTyped(json, false);
}

export function WorkerObjectTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkerObjectType {
    return json as WorkerObjectType;
}

export function WorkerObjectTypeToJSON(value?: WorkerObjectType | null): any {
    return value as any;
}

