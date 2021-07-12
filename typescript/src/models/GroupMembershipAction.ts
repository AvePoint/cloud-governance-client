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
export enum GroupMembershipAction {
    None = 0,
    Added = 1,
    Deleted = 2
}

export function GroupMembershipActionFromJSON(json: any): GroupMembershipAction {
    return GroupMembershipActionFromJSONTyped(json, false);
}

export function GroupMembershipActionFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupMembershipAction {
    return json as GroupMembershipAction;
}

export function GroupMembershipActionToJSON(value?: GroupMembershipAction | null): any {
    return value as any;
}

