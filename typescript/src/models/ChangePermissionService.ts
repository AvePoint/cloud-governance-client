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
    ChangePermissionRequest,
    ChangePermissionRequestFromJSON,
    ChangePermissionRequestFromJSONTyped,
    ChangePermissionRequestToJSON,
    CommonStatus,
    CommonStatusFromJSON,
    CommonStatusFromJSONTyped,
    CommonStatusToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    PermissionChangedType,
    PermissionChangedTypeFromJSON,
    PermissionChangedTypeFromJSONTyped,
    PermissionChangedTypeToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
    ServiceScopeSettings,
    ServiceScopeSettingsFromJSON,
    ServiceScopeSettingsFromJSONTyped,
    ServiceScopeSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    TreeNode,
    TreeNodeFromJSON,
    TreeNodeFromJSONTyped,
    TreeNodeToJSON,
    UserLevelRestrictionType,
    UserLevelRestrictionTypeFromJSON,
    UserLevelRestrictionTypeFromJSONTyped,
    UserLevelRestrictionTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangePermissionService
 */
export interface ChangePermissionService {
    /**
     * 
     * @type {Array<TreeNode>}
     * @memberof ChangePermissionService
     */
    selectedNodes?: Array<TreeNode> | null;
    /**
     * 
     * @type {Array<TreeNode>}
     * @memberof ChangePermissionService
     */
    uncheckedNodes?: Array<TreeNode> | null;
    /**
     * 
     * @type {UserLevelRestrictionType}
     * @memberof ChangePermissionService
     */
    userRestrictionType?: UserLevelRestrictionType;
    /**
     * 
     * @type {PermissionChangedType}
     * @memberof ChangePermissionService
     */
    permissionChangedType?: PermissionChangedType;
    /**
     * 
     * @type {AssignBy}
     * @memberof ChangePermissionService
     */
    permissionChangedTypeAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionService
     */
    enabledExcludePermissions?: boolean;
    /**
     * 
     * @type {Array<PermissionLevel>}
     * @memberof ChangePermissionService
     */
    excludedPermissions?: Array<PermissionLevel> | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof ChangePermissionService
     */
    reviewTaskEmailTemplate?: GuidModel | null;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ChangePermissionService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {number}
     * @memberof ChangePermissionService
     */
    stageCount?: number;
    /**
     * 
     * @type {ChangePermissionRequest}
     * @memberof ChangePermissionService
     */
    requestTemplate?: ChangePermissionRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangePermissionService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangePermissionService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangePermissionService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangePermissionService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangePermissionService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangePermissionService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangePermissionService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionService
     */
    categoryId?: string | null;
}

export function ChangePermissionServiceFromJSON(json: any): ChangePermissionService {
    return ChangePermissionServiceFromJSONTyped(json, false);
}

export function ChangePermissionServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangePermissionService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'selectedNodes': !exists(json, 'selectedNodes') ? undefined : (json['selectedNodes'] === null ? null : (json['selectedNodes'] as Array<any>).map(TreeNodeFromJSON)),
        'uncheckedNodes': !exists(json, 'uncheckedNodes') ? undefined : (json['uncheckedNodes'] === null ? null : (json['uncheckedNodes'] as Array<any>).map(TreeNodeFromJSON)),
        'userRestrictionType': !exists(json, 'userRestrictionType') ? undefined : UserLevelRestrictionTypeFromJSON(json['userRestrictionType']),
        'permissionChangedType': !exists(json, 'permissionChangedType') ? undefined : PermissionChangedTypeFromJSON(json['permissionChangedType']),
        'permissionChangedTypeAssignBy': !exists(json, 'permissionChangedTypeAssignBy') ? undefined : AssignByFromJSON(json['permissionChangedTypeAssignBy']),
        'enabledExcludePermissions': !exists(json, 'enabledExcludePermissions') ? undefined : json['enabledExcludePermissions'],
        'excludedPermissions': !exists(json, 'excludedPermissions') ? undefined : (json['excludedPermissions'] === null ? null : (json['excludedPermissions'] as Array<any>).map(PermissionLevelFromJSON)),
        'reviewTaskEmailTemplate': !exists(json, 'reviewTaskEmailTemplate') ? undefined : GuidModelFromJSON(json['reviewTaskEmailTemplate']),
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'stageCount': !exists(json, 'stageCount') ? undefined : json['stageCount'],
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangePermissionRequestFromJSON(json['requestTemplate']),
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(CustomMetadataFromJSON)),
        'hideRequestSummary': !exists(json, 'hideRequestSummary') ? undefined : json['hideRequestSummary'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'type': !exists(json, 'type') ? undefined : ServiceTypeFromJSON(json['type']),
        'serviceContact': !exists(json, 'serviceContact') ? undefined : ApiUserFromJSON(json['serviceContact']),
        'serviceAdminContact': !exists(json, 'serviceAdminContact') ? undefined : ApiUserFromJSON(json['serviceAdminContact']),
        'approversContainManagerRole': !exists(json, 'approversContainManagerRole') ? undefined : json['approversContainManagerRole'],
        'status': !exists(json, 'status') ? undefined : CommonStatusFromJSON(json['status']),
        'showServiceInCatalog': !exists(json, 'showServiceInCatalog') ? undefined : json['showServiceInCatalog'],
        'customActions': !exists(json, 'customActions') ? undefined : CustomActionSettingsFromJSON(json['customActions']),
        'approvalProcessId': !exists(json, 'approvalProcessId') ? undefined : json['approvalProcessId'],
        'languageId': !exists(json, 'languageId') ? undefined : json['languageId'],
        'categoryId': !exists(json, 'categoryId') ? undefined : json['categoryId'],
    };
}

export function ChangePermissionServiceToJSON(value?: ChangePermissionService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'selectedNodes': value.selectedNodes === undefined ? undefined : (value.selectedNodes === null ? null : (value.selectedNodes as Array<any>).map(TreeNodeToJSON)),
        'uncheckedNodes': value.uncheckedNodes === undefined ? undefined : (value.uncheckedNodes === null ? null : (value.uncheckedNodes as Array<any>).map(TreeNodeToJSON)),
        'userRestrictionType': UserLevelRestrictionTypeToJSON(value.userRestrictionType),
        'permissionChangedType': PermissionChangedTypeToJSON(value.permissionChangedType),
        'permissionChangedTypeAssignBy': AssignByToJSON(value.permissionChangedTypeAssignBy),
        'enabledExcludePermissions': value.enabledExcludePermissions,
        'excludedPermissions': value.excludedPermissions === undefined ? undefined : (value.excludedPermissions === null ? null : (value.excludedPermissions as Array<any>).map(PermissionLevelToJSON)),
        'reviewTaskEmailTemplate': GuidModelToJSON(value.reviewTaskEmailTemplate),
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'stageCount': value.stageCount,
        'requestTemplate': ChangePermissionRequestToJSON(value.requestTemplate),
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(CustomMetadataToJSON)),
        'hideRequestSummary': value.hideRequestSummary,
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'type': ServiceTypeToJSON(value.type),
        'serviceContact': ApiUserToJSON(value.serviceContact),
        'serviceAdminContact': ApiUserToJSON(value.serviceAdminContact),
        'approversContainManagerRole': value.approversContainManagerRole,
        'status': CommonStatusToJSON(value.status),
        'showServiceInCatalog': value.showServiceInCatalog,
        'customActions': CustomActionSettingsToJSON(value.customActions),
        'approvalProcessId': value.approvalProcessId,
        'languageId': value.languageId,
        'categoryId': value.categoryId,
    };
}


