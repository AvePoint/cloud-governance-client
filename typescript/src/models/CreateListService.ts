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
    CreateListRequest,
    CreateListRequestFromJSON,
    CreateListRequestFromJSONTyped,
    CreateListRequestToJSON,
    CreateListUrlSettings,
    CreateListUrlSettingsFromJSON,
    CreateListUrlSettingsFromJSONTyped,
    CreateListUrlSettingsToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    ListTemplateSettings,
    ListTemplateSettingsFromJSON,
    ListTemplateSettingsFromJSONTyped,
    ListTemplateSettingsToJSON,
    ListType,
    ListTypeFromJSON,
    ListTypeFromJSONTyped,
    ListTypeToJSON,
    ListVersionSettings,
    ListVersionSettingsFromJSON,
    ListVersionSettingsFromJSONTyped,
    ListVersionSettingsToJSON,
    PermissionSettings,
    PermissionSettingsFromJSON,
    PermissionSettingsFromJSONTyped,
    PermissionSettingsToJSON,
    ServiceScopeSettings,
    ServiceScopeSettingsFromJSON,
    ServiceScopeSettingsFromJSONTyped,
    ServiceScopeSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateListService
 */
export interface CreateListService {
    /**
     * 
     * @type {boolean}
     * @memberof CreateListService
     */
    enableNavigation?: boolean;
    /**
     * 
     * @type {ListType}
     * @memberof CreateListService
     */
    defaultListType?: ListType;
    /**
     * 
     * @type {ListVersionSettings}
     * @memberof CreateListService
     */
    versionSettings?: ListVersionSettings | null;
    /**
     * 
     * @type {ListTemplateSettings}
     * @memberof CreateListService
     */
    listTemplateSettings?: ListTemplateSettings | null;
    /**
     * 
     * @type {CreateListUrlSettings}
     * @memberof CreateListService
     */
    urlSettings?: CreateListUrlSettings | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListService
     */
    allowBreakPermissionInheritance?: boolean;
    /**
     * 
     * @type {PermissionSettings}
     * @memberof CreateListService
     */
    permissionSettings?: PermissionSettings | null;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof CreateListService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateListService
     */
    listVersionAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateListService
     */
    listTemplateAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateListService
     */
    navigationAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateListService
     */
    listTypeAssignBy?: AssignBy;
    /**
     * 
     * @type {CreateListRequest}
     * @memberof CreateListService
     */
    requestTemplate?: CreateListRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof CreateListService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateListService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateListService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof CreateListService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateListService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateListService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof CreateListService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof CreateListService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof CreateListService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateListService
     */
    categoryId?: string | null;
}

export function CreateListServiceFromJSON(json: any): CreateListService {
    return CreateListServiceFromJSONTyped(json, false);
}

export function CreateListServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateListService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableNavigation': !exists(json, 'enableNavigation') ? undefined : json['enableNavigation'],
        'defaultListType': !exists(json, 'defaultListType') ? undefined : ListTypeFromJSON(json['defaultListType']),
        'versionSettings': !exists(json, 'versionSettings') ? undefined : ListVersionSettingsFromJSON(json['versionSettings']),
        'listTemplateSettings': !exists(json, 'listTemplateSettings') ? undefined : ListTemplateSettingsFromJSON(json['listTemplateSettings']),
        'urlSettings': !exists(json, 'urlSettings') ? undefined : CreateListUrlSettingsFromJSON(json['urlSettings']),
        'allowBreakPermissionInheritance': !exists(json, 'allowBreakPermissionInheritance') ? undefined : json['allowBreakPermissionInheritance'],
        'permissionSettings': !exists(json, 'permissionSettings') ? undefined : PermissionSettingsFromJSON(json['permissionSettings']),
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'listVersionAssignBy': !exists(json, 'listVersionAssignBy') ? undefined : AssignByFromJSON(json['listVersionAssignBy']),
        'listTemplateAssignBy': !exists(json, 'listTemplateAssignBy') ? undefined : AssignByFromJSON(json['listTemplateAssignBy']),
        'navigationAssignBy': !exists(json, 'navigationAssignBy') ? undefined : AssignByFromJSON(json['navigationAssignBy']),
        'listTypeAssignBy': !exists(json, 'listTypeAssignBy') ? undefined : AssignByFromJSON(json['listTypeAssignBy']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : CreateListRequestFromJSON(json['requestTemplate']),
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

export function CreateListServiceToJSON(value?: CreateListService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableNavigation': value.enableNavigation,
        'defaultListType': ListTypeToJSON(value.defaultListType),
        'versionSettings': ListVersionSettingsToJSON(value.versionSettings),
        'listTemplateSettings': ListTemplateSettingsToJSON(value.listTemplateSettings),
        'urlSettings': CreateListUrlSettingsToJSON(value.urlSettings),
        'allowBreakPermissionInheritance': value.allowBreakPermissionInheritance,
        'permissionSettings': PermissionSettingsToJSON(value.permissionSettings),
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'listVersionAssignBy': AssignByToJSON(value.listVersionAssignBy),
        'listTemplateAssignBy': AssignByToJSON(value.listTemplateAssignBy),
        'navigationAssignBy': AssignByToJSON(value.navigationAssignBy),
        'listTypeAssignBy': AssignByToJSON(value.listTypeAssignBy),
        'requestTemplate': CreateListRequestToJSON(value.requestTemplate),
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


