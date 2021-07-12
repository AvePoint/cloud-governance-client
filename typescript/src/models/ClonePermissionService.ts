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
    ClonePermissionAdditionalOption,
    ClonePermissionAdditionalOptionFromJSON,
    ClonePermissionAdditionalOptionFromJSONTyped,
    ClonePermissionAdditionalOptionToJSON,
    ClonePermissionOption,
    ClonePermissionOptionFromJSON,
    ClonePermissionOptionFromJSONTyped,
    ClonePermissionOptionToJSON,
    ClonePermissionRequest,
    ClonePermissionRequestFromJSON,
    ClonePermissionRequestFromJSONTyped,
    ClonePermissionRequestToJSON,
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
 * @interface ClonePermissionService
 */
export interface ClonePermissionService {
    /**
     * 
     * @type {Array<TreeNode>}
     * @memberof ClonePermissionService
     */
    selectedNodes?: Array<TreeNode> | null;
    /**
     * 
     * @type {Array<TreeNode>}
     * @memberof ClonePermissionService
     */
    uncheckedNodes?: Array<TreeNode> | null;
    /**
     * 
     * @type {UserLevelRestrictionType}
     * @memberof ClonePermissionService
     */
    sourceUserRestrictionType?: UserLevelRestrictionType;
    /**
     * 
     * @type {UserLevelRestrictionType}
     * @memberof ClonePermissionService
     */
    targetUserRestrictionType?: UserLevelRestrictionType;
    /**
     * 
     * @type {ClonePermissionOption}
     * @memberof ClonePermissionService
     */
    cloneOption?: ClonePermissionOption;
    /**
     * 
     * @type {AssignBy}
     * @memberof ClonePermissionService
     */
    clonePermissionAssignBy?: AssignBy;
    /**
     * 
     * @type {ClonePermissionAdditionalOption}
     * @memberof ClonePermissionService
     */
    additionalCloneOption?: ClonePermissionAdditionalOption;
    /**
     * 
     * @type {AssignBy}
     * @memberof ClonePermissionService
     */
    cloneAdditionalOptionAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    enabledRemoveExplicitPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    enabledRemoveUserFromSPGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    enabledDeleteUserPermission?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof ClonePermissionService
     */
    transferOptionValueAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    isHideTree?: boolean;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ClonePermissionService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {ClonePermissionRequest}
     * @memberof ClonePermissionService
     */
    requestTemplate?: ClonePermissionRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ClonePermissionService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ClonePermissionService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ClonePermissionService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ClonePermissionService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ClonePermissionService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ClonePermissionService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ClonePermissionService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionService
     */
    categoryId?: string | null;
}

export function ClonePermissionServiceFromJSON(json: any): ClonePermissionService {
    return ClonePermissionServiceFromJSONTyped(json, false);
}

export function ClonePermissionServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ClonePermissionService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'selectedNodes': !exists(json, 'selectedNodes') ? undefined : (json['selectedNodes'] === null ? null : (json['selectedNodes'] as Array<any>).map(TreeNodeFromJSON)),
        'uncheckedNodes': !exists(json, 'uncheckedNodes') ? undefined : (json['uncheckedNodes'] === null ? null : (json['uncheckedNodes'] as Array<any>).map(TreeNodeFromJSON)),
        'sourceUserRestrictionType': !exists(json, 'sourceUserRestrictionType') ? undefined : UserLevelRestrictionTypeFromJSON(json['sourceUserRestrictionType']),
        'targetUserRestrictionType': !exists(json, 'targetUserRestrictionType') ? undefined : UserLevelRestrictionTypeFromJSON(json['targetUserRestrictionType']),
        'cloneOption': !exists(json, 'cloneOption') ? undefined : ClonePermissionOptionFromJSON(json['cloneOption']),
        'clonePermissionAssignBy': !exists(json, 'clonePermissionAssignBy') ? undefined : AssignByFromJSON(json['clonePermissionAssignBy']),
        'additionalCloneOption': !exists(json, 'additionalCloneOption') ? undefined : ClonePermissionAdditionalOptionFromJSON(json['additionalCloneOption']),
        'cloneAdditionalOptionAssignBy': !exists(json, 'cloneAdditionalOptionAssignBy') ? undefined : AssignByFromJSON(json['cloneAdditionalOptionAssignBy']),
        'enabledRemoveExplicitPermission': !exists(json, 'enabledRemoveExplicitPermission') ? undefined : json['enabledRemoveExplicitPermission'],
        'enabledRemoveUserFromSPGroup': !exists(json, 'enabledRemoveUserFromSPGroup') ? undefined : json['enabledRemoveUserFromSPGroup'],
        'enabledDeleteUserPermission': !exists(json, 'enabledDeleteUserPermission') ? undefined : json['enabledDeleteUserPermission'],
        'transferOptionValueAssignBy': !exists(json, 'transferOptionValueAssignBy') ? undefined : AssignByFromJSON(json['transferOptionValueAssignBy']),
        'isHideTree': !exists(json, 'isHideTree') ? undefined : json['isHideTree'],
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ClonePermissionRequestFromJSON(json['requestTemplate']),
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

export function ClonePermissionServiceToJSON(value?: ClonePermissionService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'selectedNodes': value.selectedNodes === undefined ? undefined : (value.selectedNodes === null ? null : (value.selectedNodes as Array<any>).map(TreeNodeToJSON)),
        'uncheckedNodes': value.uncheckedNodes === undefined ? undefined : (value.uncheckedNodes === null ? null : (value.uncheckedNodes as Array<any>).map(TreeNodeToJSON)),
        'sourceUserRestrictionType': UserLevelRestrictionTypeToJSON(value.sourceUserRestrictionType),
        'targetUserRestrictionType': UserLevelRestrictionTypeToJSON(value.targetUserRestrictionType),
        'cloneOption': ClonePermissionOptionToJSON(value.cloneOption),
        'clonePermissionAssignBy': AssignByToJSON(value.clonePermissionAssignBy),
        'additionalCloneOption': ClonePermissionAdditionalOptionToJSON(value.additionalCloneOption),
        'cloneAdditionalOptionAssignBy': AssignByToJSON(value.cloneAdditionalOptionAssignBy),
        'enabledRemoveExplicitPermission': value.enabledRemoveExplicitPermission,
        'enabledRemoveUserFromSPGroup': value.enabledRemoveUserFromSPGroup,
        'enabledDeleteUserPermission': value.enabledDeleteUserPermission,
        'transferOptionValueAssignBy': AssignByToJSON(value.transferOptionValueAssignBy),
        'isHideTree': value.isHideTree,
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': ClonePermissionRequestToJSON(value.requestTemplate),
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


