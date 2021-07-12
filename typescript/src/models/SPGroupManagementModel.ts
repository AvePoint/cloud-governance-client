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
    ManagePermissionAction,
    ManagePermissionActionFromJSON,
    ManagePermissionActionFromJSONTyped,
    ManagePermissionActionToJSON,
    SPGroupEditOption,
    SPGroupEditOptionFromJSON,
    SPGroupEditOptionFromJSONTyped,
    SPGroupEditOptionToJSON,
    SPGroupViewOption,
    SPGroupViewOptionFromJSON,
    SPGroupViewOptionFromJSONTyped,
    SPGroupViewOptionToJSON,
    SPUserManagementModel,
    SPUserManagementModelFromJSON,
    SPUserManagementModelFromJSONTyped,
    SPUserManagementModelToJSON,
    StringChangedProperty,
    StringChangedPropertyFromJSON,
    StringChangedPropertyFromJSONTyped,
    StringChangedPropertyToJSON,
} from './';

/**
 * 
 * @export
 * @interface SPGroupManagementModel
 */
export interface SPGroupManagementModel {
    /**
     * 
     * @type {number}
     * @memberof SPGroupManagementModel
     */
    id?: number;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof SPGroupManagementModel
     */
    name?: StringChangedProperty | null;
    /**
     * 
     * @type {string}
     * @memberof SPGroupManagementModel
     */
    description?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof SPGroupManagementModel
     */
    owner?: ApiUser | null;
    /**
     * 
     * @type {Array<SPUserManagementModel>}
     * @memberof SPGroupManagementModel
     */
    members?: Array<SPUserManagementModel> | null;
    /**
     * 
     * @type {SPGroupViewOption}
     * @memberof SPGroupManagementModel
     */
    spGroupViewType?: SPGroupViewOption;
    /**
     * 
     * @type {SPGroupEditOption}
     * @memberof SPGroupManagementModel
     */
    spGroupEditType?: SPGroupEditOption;
    /**
     * 
     * @type {Array<string>}
     * @memberof SPGroupManagementModel
     */
    permissions?: Array<string> | null;
    /**
     * 
     * @type {ManagePermissionAction}
     * @memberof SPGroupManagementModel
     */
    action?: ManagePermissionAction;
    /**
     * 
     * @type {boolean}
     * @memberof SPGroupManagementModel
     */
    isAllowJoinOrLeaveRequest?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SPGroupManagementModel
     */
    isAutoAcceptRequest?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SPGroupManagementModel
     */
    sendMembershipRequestEmailAddress?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SPGroupManagementModel
     */
    isTemporaryGroup?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof SPGroupManagementModel
     */
    roleID?: Array<string> | null;
}

export function SPGroupManagementModelFromJSON(json: any): SPGroupManagementModel {
    return SPGroupManagementModelFromJSONTyped(json, false);
}

export function SPGroupManagementModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPGroupManagementModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : StringChangedPropertyFromJSON(json['name']),
        'description': !exists(json, 'description') ? undefined : json['description'],
        'owner': !exists(json, 'owner') ? undefined : ApiUserFromJSON(json['owner']),
        'members': !exists(json, 'members') ? undefined : (json['members'] === null ? null : (json['members'] as Array<any>).map(SPUserManagementModelFromJSON)),
        'spGroupViewType': !exists(json, 'spGroupViewType') ? undefined : SPGroupViewOptionFromJSON(json['spGroupViewType']),
        'spGroupEditType': !exists(json, 'spGroupEditType') ? undefined : SPGroupEditOptionFromJSON(json['spGroupEditType']),
        'permissions': !exists(json, 'permissions') ? undefined : json['permissions'],
        'action': !exists(json, 'action') ? undefined : ManagePermissionActionFromJSON(json['action']),
        'isAllowJoinOrLeaveRequest': !exists(json, 'isAllowJoinOrLeaveRequest') ? undefined : json['isAllowJoinOrLeaveRequest'],
        'isAutoAcceptRequest': !exists(json, 'isAutoAcceptRequest') ? undefined : json['isAutoAcceptRequest'],
        'sendMembershipRequestEmailAddress': !exists(json, 'sendMembershipRequestEmailAddress') ? undefined : json['sendMembershipRequestEmailAddress'],
        'isTemporaryGroup': !exists(json, 'isTemporaryGroup') ? undefined : json['isTemporaryGroup'],
        'roleID': !exists(json, 'roleID') ? undefined : json['roleID'],
    };
}

export function SPGroupManagementModelToJSON(value?: SPGroupManagementModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': StringChangedPropertyToJSON(value.name),
        'description': value.description,
        'owner': ApiUserToJSON(value.owner),
        'members': value.members === undefined ? undefined : (value.members === null ? null : (value.members as Array<any>).map(SPUserManagementModelToJSON)),
        'spGroupViewType': SPGroupViewOptionToJSON(value.spGroupViewType),
        'spGroupEditType': SPGroupEditOptionToJSON(value.spGroupEditType),
        'permissions': value.permissions,
        'action': ManagePermissionActionToJSON(value.action),
        'isAllowJoinOrLeaveRequest': value.isAllowJoinOrLeaveRequest,
        'isAutoAcceptRequest': value.isAutoAcceptRequest,
        'sendMembershipRequestEmailAddress': value.sendMembershipRequestEmailAddress,
        'isTemporaryGroup': value.isTemporaryGroup,
        'roleID': value.roleID,
    };
}


