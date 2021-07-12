/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    SPGroupEditOption,
    SPGroupEditOptionFromJSON,
    SPGroupEditOptionFromJSONTyped,
    SPGroupEditOptionToJSON,
    SPGroupViewOption,
    SPGroupViewOptionFromJSON,
    SPGroupViewOptionFromJSONTyped,
    SPGroupViewOptionToJSON,
    SPPrincipal,
    SPPrincipalFromJSON,
    SPPrincipalFromJSONTyped,
    SPPrincipalToJSON,
} from './';

/**
 * 
 * @export
 * @interface SPGroup
 */
export interface SPGroup {
    /**
     * 
     * @type {number}
     * @memberof SPGroup
     */
    id?: number;
    /**
     * 
     * @type {string}
     * @memberof SPGroup
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPGroup
     */
    description?: string | null;
    /**
     * 
     * @type {SPPrincipal}
     * @memberof SPGroup
     */
    owner?: SPPrincipal | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof SPGroup
     */
    members?: Array<ApiUser> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof SPGroup
     */
    permissionLevels?: Array<string> | null;
    /**
     * 
     * @type {SPGroupViewOption}
     * @memberof SPGroup
     */
    spGroupViewType?: SPGroupViewOption;
    /**
     * 
     * @type {SPGroupEditOption}
     * @memberof SPGroup
     */
    spGroupEditType?: SPGroupEditOption;
    /**
     * 
     * @type {boolean}
     * @memberof SPGroup
     */
    isAllowJoinOrLeaveRequest?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SPGroup
     */
    autoAcceptRequestToJoinLeave?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SPGroup
     */
    requestToJoinLeaveEmailSetting?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SPGroup
     */
    isTemporaryGroup?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof SPGroup
     */
    roleID?: Array<string> | null;
}

export function SPGroupFromJSON(json: any): SPGroup {
    return SPGroupFromJSONTyped(json, false);
}

export function SPGroupFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPGroup {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'owner': !exists(json, 'owner') ? undefined : SPPrincipalFromJSON(json['owner']),
        'members': !exists(json, 'members') ? undefined : (json['members'] === null ? null : (json['members'] as Array<any>).map(ApiUserFromJSON)),
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : json['permissionLevels'],
        'spGroupViewType': !exists(json, 'spGroupViewType') ? undefined : SPGroupViewOptionFromJSON(json['spGroupViewType']),
        'spGroupEditType': !exists(json, 'spGroupEditType') ? undefined : SPGroupEditOptionFromJSON(json['spGroupEditType']),
        'isAllowJoinOrLeaveRequest': !exists(json, 'isAllowJoinOrLeaveRequest') ? undefined : json['isAllowJoinOrLeaveRequest'],
        'autoAcceptRequestToJoinLeave': !exists(json, 'autoAcceptRequestToJoinLeave') ? undefined : json['autoAcceptRequestToJoinLeave'],
        'requestToJoinLeaveEmailSetting': !exists(json, 'requestToJoinLeaveEmailSetting') ? undefined : json['requestToJoinLeaveEmailSetting'],
        'isTemporaryGroup': !exists(json, 'isTemporaryGroup') ? undefined : json['isTemporaryGroup'],
        'roleID': !exists(json, 'roleID') ? undefined : json['roleID'],
    };
}

export function SPGroupToJSON(value?: SPGroup | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'owner': SPPrincipalToJSON(value.owner),
        'members': value.members === undefined ? undefined : (value.members === null ? null : (value.members as Array<any>).map(ApiUserToJSON)),
        'permissionLevels': value.permissionLevels,
        'spGroupViewType': SPGroupViewOptionToJSON(value.spGroupViewType),
        'spGroupEditType': SPGroupEditOptionToJSON(value.spGroupEditType),
        'isAllowJoinOrLeaveRequest': value.isAllowJoinOrLeaveRequest,
        'autoAcceptRequestToJoinLeave': value.autoAcceptRequestToJoinLeave,
        'requestToJoinLeaveEmailSetting': value.requestToJoinLeaveEmailSetting,
        'isTemporaryGroup': value.isTemporaryGroup,
        'roleID': value.roleID,
    };
}


