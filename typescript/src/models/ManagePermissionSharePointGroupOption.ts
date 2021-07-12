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
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    SPGroupEditOption,
    SPGroupEditOptionFromJSON,
    SPGroupEditOptionFromJSONTyped,
    SPGroupEditOptionToJSON,
    SPGroupViewOption,
    SPGroupViewOptionFromJSON,
    SPGroupViewOptionFromJSONTyped,
    SPGroupViewOptionToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManagePermissionSharePointGroupOption
 */
export interface ManagePermissionSharePointGroupOption {
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSharePointGroupOption
     */
    isEnableCreateSPGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSharePointGroupOption
     */
    isEnableDeleteSPGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSharePointGroupOption
     */
    isEnableManageGroupSettings?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSharePointGroupOption
     */
    isEnableManageGroupMembers?: boolean;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ManagePermissionSharePointGroupOption
     */
    groupOwner?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManagePermissionSharePointGroupOption
     */
    groupOwnerAssignBy?: AssignBy;
    /**
     * 
     * @type {SPGroupViewOption}
     * @memberof ManagePermissionSharePointGroupOption
     */
    spGroupViewType?: SPGroupViewOption;
    /**
     * 
     * @type {SPGroupEditOption}
     * @memberof ManagePermissionSharePointGroupOption
     */
    spGroupEditType?: SPGroupEditOption;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManagePermissionSharePointGroupOption
     */
    spGroupOptionAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSharePointGroupOption
     */
    isAllowJoinOrLeaveRequest?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSharePointGroupOption
     */
    isAutoAcceptRequest?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSharePointGroupOption
     */
    sendMembershipRequestEmailAddress?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManagePermissionSharePointGroupOption
     */
    groupRequestAssignBy?: AssignBy;
}

export function ManagePermissionSharePointGroupOptionFromJSON(json: any): ManagePermissionSharePointGroupOption {
    return ManagePermissionSharePointGroupOptionFromJSONTyped(json, false);
}

export function ManagePermissionSharePointGroupOptionFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionSharePointGroupOption {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnableCreateSPGroup': !exists(json, 'isEnableCreateSPGroup') ? undefined : json['isEnableCreateSPGroup'],
        'isEnableDeleteSPGroup': !exists(json, 'isEnableDeleteSPGroup') ? undefined : json['isEnableDeleteSPGroup'],
        'isEnableManageGroupSettings': !exists(json, 'isEnableManageGroupSettings') ? undefined : json['isEnableManageGroupSettings'],
        'isEnableManageGroupMembers': !exists(json, 'isEnableManageGroupMembers') ? undefined : json['isEnableManageGroupMembers'],
        'groupOwner': !exists(json, 'groupOwner') ? undefined : ApiUserFromJSON(json['groupOwner']),
        'groupOwnerAssignBy': !exists(json, 'groupOwnerAssignBy') ? undefined : AssignByFromJSON(json['groupOwnerAssignBy']),
        'spGroupViewType': !exists(json, 'spGroupViewType') ? undefined : SPGroupViewOptionFromJSON(json['spGroupViewType']),
        'spGroupEditType': !exists(json, 'spGroupEditType') ? undefined : SPGroupEditOptionFromJSON(json['spGroupEditType']),
        'spGroupOptionAssignBy': !exists(json, 'spGroupOptionAssignBy') ? undefined : AssignByFromJSON(json['spGroupOptionAssignBy']),
        'isAllowJoinOrLeaveRequest': !exists(json, 'isAllowJoinOrLeaveRequest') ? undefined : json['isAllowJoinOrLeaveRequest'],
        'isAutoAcceptRequest': !exists(json, 'isAutoAcceptRequest') ? undefined : json['isAutoAcceptRequest'],
        'sendMembershipRequestEmailAddress': !exists(json, 'sendMembershipRequestEmailAddress') ? undefined : json['sendMembershipRequestEmailAddress'],
        'groupRequestAssignBy': !exists(json, 'groupRequestAssignBy') ? undefined : AssignByFromJSON(json['groupRequestAssignBy']),
    };
}

export function ManagePermissionSharePointGroupOptionToJSON(value?: ManagePermissionSharePointGroupOption | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnableCreateSPGroup': value.isEnableCreateSPGroup,
        'isEnableDeleteSPGroup': value.isEnableDeleteSPGroup,
        'isEnableManageGroupSettings': value.isEnableManageGroupSettings,
        'isEnableManageGroupMembers': value.isEnableManageGroupMembers,
        'groupOwner': ApiUserToJSON(value.groupOwner),
        'groupOwnerAssignBy': AssignByToJSON(value.groupOwnerAssignBy),
        'spGroupViewType': SPGroupViewOptionToJSON(value.spGroupViewType),
        'spGroupEditType': SPGroupEditOptionToJSON(value.spGroupEditType),
        'spGroupOptionAssignBy': AssignByToJSON(value.spGroupOptionAssignBy),
        'isAllowJoinOrLeaveRequest': value.isAllowJoinOrLeaveRequest,
        'isAutoAcceptRequest': value.isAutoAcceptRequest,
        'sendMembershipRequestEmailAddress': value.sendMembershipRequestEmailAddress,
        'groupRequestAssignBy': AssignByToJSON(value.groupRequestAssignBy),
    };
}


