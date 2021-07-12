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
    CommonStatus,
    CommonStatusFromJSON,
    CommonStatusFromJSONTyped,
    CommonStatusToJSON,
    ContentMoveAction,
    ContentMoveActionFromJSON,
    ContentMoveActionFromJSONTyped,
    ContentMoveActionToJSON,
    ContentMoveCommonSetting,
    ContentMoveCommonSettingFromJSON,
    ContentMoveCommonSettingFromJSONTyped,
    ContentMoveCommonSettingToJSON,
    ContentMoveMethod,
    ContentMoveMethodFromJSON,
    ContentMoveMethodFromJSONTyped,
    ContentMoveMethodToJSON,
    ContentMoveRequest,
    ContentMoveRequestFromJSON,
    ContentMoveRequestFromJSONTyped,
    ContentMoveRequestToJSON,
    CopyMoveSetting,
    CopyMoveSettingFromJSON,
    CopyMoveSettingFromJSONTyped,
    CopyMoveSettingToJSON,
    CopyMoveSettingAssignBy,
    CopyMoveSettingAssignByFromJSON,
    CopyMoveSettingAssignByFromJSONTyped,
    CopyMoveSettingAssignByToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ContentMoveService
 */
export interface ContentMoveService {
    /**
     * 
     * @type {ContentMoveMethod}
     * @memberof ContentMoveService
     */
    method?: ContentMoveMethod;
    /**
     * 
     * @type {ContentMoveAction}
     * @memberof ContentMoveService
     */
    action?: ContentMoveAction;
    /**
     * 
     * @type {CopyMoveSetting}
     * @memberof ContentMoveService
     */
    copySettings?: CopyMoveSetting | null;
    /**
     * 
     * @type {CopyMoveSetting}
     * @memberof ContentMoveService
     */
    moveSettings?: CopyMoveSetting | null;
    /**
     * 
     * @type {ContentMoveCommonSetting}
     * @memberof ContentMoveService
     */
    commonSettings?: ContentMoveCommonSetting | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    conflictResolutionAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    deleteTypeAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    deleteCheckedFilesAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    filterPolicyAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    methodAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    actionAssignBy?: AssignBy;
    /**
     * 
     * @type {CopyMoveSettingAssignBy}
     * @memberof ContentMoveService
     */
    copySettingAssignBy?: CopyMoveSettingAssignBy | null;
    /**
     * 
     * @type {CopyMoveSettingAssignBy}
     * @memberof ContentMoveService
     */
    moveSettingAssignBy?: CopyMoveSettingAssignBy | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    versionsAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    workflowAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    informationRightsManagementAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    nullColumnValueAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    modifiedByAndModifiedTimeAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    mappingSettingAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContentMoveService
     */
    backupEnvironmentAssignBy?: AssignBy;
    /**
     * 
     * @type {ContentMoveRequest}
     * @memberof ContentMoveService
     */
    requestTemplate?: ContentMoveRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ContentMoveService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ContentMoveService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ContentMoveService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ContentMoveService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ContentMoveService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ContentMoveService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ContentMoveService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveService
     */
    categoryId?: string | null;
}

export function ContentMoveServiceFromJSON(json: any): ContentMoveService {
    return ContentMoveServiceFromJSONTyped(json, false);
}

export function ContentMoveServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'method': !exists(json, 'method') ? undefined : ContentMoveMethodFromJSON(json['method']),
        'action': !exists(json, 'action') ? undefined : ContentMoveActionFromJSON(json['action']),
        'copySettings': !exists(json, 'copySettings') ? undefined : CopyMoveSettingFromJSON(json['copySettings']),
        'moveSettings': !exists(json, 'moveSettings') ? undefined : CopyMoveSettingFromJSON(json['moveSettings']),
        'commonSettings': !exists(json, 'commonSettings') ? undefined : ContentMoveCommonSettingFromJSON(json['commonSettings']),
        'conflictResolutionAssignBy': !exists(json, 'conflictResolutionAssignBy') ? undefined : AssignByFromJSON(json['conflictResolutionAssignBy']),
        'deleteTypeAssignBy': !exists(json, 'deleteTypeAssignBy') ? undefined : AssignByFromJSON(json['deleteTypeAssignBy']),
        'deleteCheckedFilesAssignBy': !exists(json, 'deleteCheckedFilesAssignBy') ? undefined : AssignByFromJSON(json['deleteCheckedFilesAssignBy']),
        'filterPolicyAssignBy': !exists(json, 'filterPolicyAssignBy') ? undefined : AssignByFromJSON(json['filterPolicyAssignBy']),
        'methodAssignBy': !exists(json, 'methodAssignBy') ? undefined : AssignByFromJSON(json['methodAssignBy']),
        'actionAssignBy': !exists(json, 'actionAssignBy') ? undefined : AssignByFromJSON(json['actionAssignBy']),
        'copySettingAssignBy': !exists(json, 'copySettingAssignBy') ? undefined : CopyMoveSettingAssignByFromJSON(json['copySettingAssignBy']),
        'moveSettingAssignBy': !exists(json, 'moveSettingAssignBy') ? undefined : CopyMoveSettingAssignByFromJSON(json['moveSettingAssignBy']),
        'versionsAssignBy': !exists(json, 'versionsAssignBy') ? undefined : AssignByFromJSON(json['versionsAssignBy']),
        'workflowAssignBy': !exists(json, 'workflowAssignBy') ? undefined : AssignByFromJSON(json['workflowAssignBy']),
        'informationRightsManagementAssignBy': !exists(json, 'informationRightsManagementAssignBy') ? undefined : AssignByFromJSON(json['informationRightsManagementAssignBy']),
        'nullColumnValueAssignBy': !exists(json, 'nullColumnValueAssignBy') ? undefined : AssignByFromJSON(json['nullColumnValueAssignBy']),
        'modifiedByAndModifiedTimeAssignBy': !exists(json, 'modifiedByAndModifiedTimeAssignBy') ? undefined : AssignByFromJSON(json['modifiedByAndModifiedTimeAssignBy']),
        'mappingSettingAssignBy': !exists(json, 'mappingSettingAssignBy') ? undefined : AssignByFromJSON(json['mappingSettingAssignBy']),
        'backupEnvironmentAssignBy': !exists(json, 'backupEnvironmentAssignBy') ? undefined : AssignByFromJSON(json['backupEnvironmentAssignBy']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ContentMoveRequestFromJSON(json['requestTemplate']),
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

export function ContentMoveServiceToJSON(value?: ContentMoveService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'method': ContentMoveMethodToJSON(value.method),
        'action': ContentMoveActionToJSON(value.action),
        'copySettings': CopyMoveSettingToJSON(value.copySettings),
        'moveSettings': CopyMoveSettingToJSON(value.moveSettings),
        'commonSettings': ContentMoveCommonSettingToJSON(value.commonSettings),
        'conflictResolutionAssignBy': AssignByToJSON(value.conflictResolutionAssignBy),
        'deleteTypeAssignBy': AssignByToJSON(value.deleteTypeAssignBy),
        'deleteCheckedFilesAssignBy': AssignByToJSON(value.deleteCheckedFilesAssignBy),
        'filterPolicyAssignBy': AssignByToJSON(value.filterPolicyAssignBy),
        'methodAssignBy': AssignByToJSON(value.methodAssignBy),
        'actionAssignBy': AssignByToJSON(value.actionAssignBy),
        'copySettingAssignBy': CopyMoveSettingAssignByToJSON(value.copySettingAssignBy),
        'moveSettingAssignBy': CopyMoveSettingAssignByToJSON(value.moveSettingAssignBy),
        'versionsAssignBy': AssignByToJSON(value.versionsAssignBy),
        'workflowAssignBy': AssignByToJSON(value.workflowAssignBy),
        'informationRightsManagementAssignBy': AssignByToJSON(value.informationRightsManagementAssignBy),
        'nullColumnValueAssignBy': AssignByToJSON(value.nullColumnValueAssignBy),
        'modifiedByAndModifiedTimeAssignBy': AssignByToJSON(value.modifiedByAndModifiedTimeAssignBy),
        'mappingSettingAssignBy': AssignByToJSON(value.mappingSettingAssignBy),
        'backupEnvironmentAssignBy': AssignByToJSON(value.backupEnvironmentAssignBy),
        'requestTemplate': ContentMoveRequestToJSON(value.requestTemplate),
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


