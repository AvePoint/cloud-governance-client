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
    ManagePermissionOption,
    ManagePermissionOptionFromJSON,
    ManagePermissionOptionFromJSONTyped,
    ManagePermissionOptionToJSON,
    ManagePermissionRequest,
    ManagePermissionRequestFromJSON,
    ManagePermissionRequestFromJSONTyped,
    ManagePermissionRequestToJSON,
    ManagePermissionSharePointGroupOption,
    ManagePermissionSharePointGroupOptionFromJSON,
    ManagePermissionSharePointGroupOptionFromJSONTyped,
    ManagePermissionSharePointGroupOptionToJSON,
    ManagePermissionUserSetting,
    ManagePermissionUserSettingFromJSON,
    ManagePermissionUserSettingFromJSONTyped,
    ManagePermissionUserSettingToJSON,
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
 * @interface ManagePermissionService
 */
export interface ManagePermissionService {
    /**
     * 
     * @type {ManagePermissionUserSetting}
     * @memberof ManagePermissionService
     */
    userScopeSetting?: ManagePermissionUserSetting | null;
    /**
     * 
     * @type {ManagePermissionSharePointGroupOption}
     * @memberof ManagePermissionService
     */
    sharePointGroupOptions?: ManagePermissionSharePointGroupOption | null;
    /**
     * 
     * @type {ManagePermissionOption}
     * @memberof ManagePermissionService
     */
    permissionOptions?: ManagePermissionOption | null;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ManagePermissionService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionService
     */
    peoplePickerFilterProfileId?: string | null;
    /**
     * Manage permission request model
     * @type {ManagePermissionRequest}
     * @memberof ManagePermissionService
     */
    requestTemplate?: ManagePermissionRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ManagePermissionService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ManagePermissionService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ManagePermissionService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ManagePermissionService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ManagePermissionService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ManagePermissionService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ManagePermissionService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionService
     */
    categoryId?: string | null;
}

export function ManagePermissionServiceFromJSON(json: any): ManagePermissionService {
    return ManagePermissionServiceFromJSONTyped(json, false);
}

export function ManagePermissionServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'userScopeSetting': !exists(json, 'userScopeSetting') ? undefined : ManagePermissionUserSettingFromJSON(json['userScopeSetting']),
        'sharePointGroupOptions': !exists(json, 'sharePointGroupOptions') ? undefined : ManagePermissionSharePointGroupOptionFromJSON(json['sharePointGroupOptions']),
        'permissionOptions': !exists(json, 'permissionOptions') ? undefined : ManagePermissionOptionFromJSON(json['permissionOptions']),
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'peoplePickerFilterProfileId': !exists(json, 'peoplePickerFilterProfileId') ? undefined : json['peoplePickerFilterProfileId'],
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ManagePermissionRequestFromJSON(json['requestTemplate']),
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

export function ManagePermissionServiceToJSON(value?: ManagePermissionService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userScopeSetting': ManagePermissionUserSettingToJSON(value.userScopeSetting),
        'sharePointGroupOptions': ManagePermissionSharePointGroupOptionToJSON(value.sharePointGroupOptions),
        'permissionOptions': ManagePermissionOptionToJSON(value.permissionOptions),
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'peoplePickerFilterProfileId': value.peoplePickerFilterProfileId,
        'requestTemplate': ManagePermissionRequestToJSON(value.requestTemplate),
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


