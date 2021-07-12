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
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    GroupLifecycleActionType,
    GroupLifecycleActionTypeFromJSON,
    GroupLifecycleActionTypeFromJSONTyped,
    GroupLifecycleActionTypeToJSON,
    GroupLifecycleRequest,
    GroupLifecycleRequestFromJSON,
    GroupLifecycleRequestFromJSONTyped,
    GroupLifecycleRequestToJSON,
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface GroupLifecycleService
 */
export interface GroupLifecycleService {
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    tenantId?: string;
    /**
     * 
     * @type {GroupLifecycleActionType}
     * @memberof GroupLifecycleService
     */
    action?: GroupLifecycleActionType;
    /**
     * 
     * @type {GroupObjectType}
     * @memberof GroupLifecycleService
     */
    groupObjectType?: GroupObjectType;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    networkId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    scopePeoplePickerFilterProfileId?: string | null;
    /**
     * Group lifecycle request model
     * @type {GroupLifecycleRequest}
     * @memberof GroupLifecycleService
     */
    requestTemplate?: GroupLifecycleRequest | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof GroupLifecycleService
     */
    changePolicyAssignBy?: AssignBy;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof GroupLifecycleService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof GroupLifecycleService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof GroupLifecycleService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof GroupLifecycleService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof GroupLifecycleService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof GroupLifecycleService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof GroupLifecycleService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof GroupLifecycleService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof GroupLifecycleService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof GroupLifecycleService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof GroupLifecycleService
     */
    categoryId?: string | null;
}

export function GroupLifecycleServiceFromJSON(json: any): GroupLifecycleService {
    return GroupLifecycleServiceFromJSONTyped(json, false);
}

export function GroupLifecycleServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupLifecycleService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'action': !exists(json, 'action') ? undefined : GroupLifecycleActionTypeFromJSON(json['action']),
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'scopePeoplePickerFilterProfileId': !exists(json, 'scopePeoplePickerFilterProfileId') ? undefined : json['scopePeoplePickerFilterProfileId'],
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : GroupLifecycleRequestFromJSON(json['requestTemplate']),
        'changePolicyAssignBy': !exists(json, 'changePolicyAssignBy') ? undefined : AssignByFromJSON(json['changePolicyAssignBy']),
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

export function GroupLifecycleServiceToJSON(value?: GroupLifecycleService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'tenantId': value.tenantId,
        'action': GroupLifecycleActionTypeToJSON(value.action),
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'networkId': value.networkId,
        'scopePeoplePickerFilterProfileId': value.scopePeoplePickerFilterProfileId,
        'requestTemplate': GroupLifecycleRequestToJSON(value.requestTemplate),
        'changePolicyAssignBy': AssignByToJSON(value.changePolicyAssignBy),
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


