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
export enum UserLevelControlMode {
    AnyUserOrGroup = 0,
    PeersAndDirectOrIn = 1,
    DirectOrIn = 2
}

export function UserLevelControlModeFromJSON(json: any): UserLevelControlMode {
    return UserLevelControlModeFromJSONTyped(json, false);
}

export function UserLevelControlModeFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserLevelControlMode {
    return json as UserLevelControlMode;
}

export function UserLevelControlModeToJSON(value?: UserLevelControlMode | null): any {
    return value as any;
}

