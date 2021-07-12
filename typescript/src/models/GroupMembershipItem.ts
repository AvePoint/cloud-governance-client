/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GroupMembershipAction,
    GroupMembershipActionFromJSON,
    GroupMembershipActionFromJSONTyped,
    GroupMembershipActionToJSON,
} from './';

/**
 * 
 * @export
 * @interface GroupMembershipItem
 */
export interface GroupMembershipItem {
    /**
     * 
     * @type {string}
     * @memberof GroupMembershipItem
     */
    loginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupMembershipItem
     */
    displayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupMembershipItem
     */
    azureUserType?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof GroupMembershipItem
     */
    isGroup?: boolean;
    /**
     * 
     * @type {GroupMembershipAction}
     * @memberof GroupMembershipItem
     */
    action?: GroupMembershipAction;
}

export function GroupMembershipItemFromJSON(json: any): GroupMembershipItem {
    return GroupMembershipItemFromJSONTyped(json, false);
}

export function GroupMembershipItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupMembershipItem {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'loginName': !exists(json, 'loginName') ? undefined : json['loginName'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
        'isGroup': !exists(json, 'isGroup') ? undefined : json['isGroup'],
        'action': !exists(json, 'action') ? undefined : GroupMembershipActionFromJSON(json['action']),
    };
}

export function GroupMembershipItemToJSON(value?: GroupMembershipItem | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'loginName': value.loginName,
        'displayName': value.displayName,
        'azureUserType': value.azureUserType,
        'isGroup': value.isGroup,
        'action': GroupMembershipActionToJSON(value.action),
    };
}


