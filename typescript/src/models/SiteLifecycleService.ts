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
    ChangePolicyActionSetting,
    ChangePolicyActionSettingFromJSON,
    ChangePolicyActionSettingFromJSONTyped,
    ChangePolicyActionSettingToJSON,
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
    SiteLifecycleActionType,
    SiteLifecycleActionTypeFromJSON,
    SiteLifecycleActionTypeFromJSONTyped,
    SiteLifecycleActionTypeToJSON,
    SiteLifecycleRequest,
    SiteLifecycleRequestFromJSON,
    SiteLifecycleRequestFromJSONTyped,
    SiteLifecycleRequestToJSON,
} from './';

/**
 * 
 * @export
 * @interface SiteLifecycleService
 */
export interface SiteLifecycleService {
    /**
     * 
     * @type {SiteLifecycleActionType}
     * @memberof SiteLifecycleService
     */
    action?: SiteLifecycleActionType;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLifecycleService
     */
    displayMetadataInAutoLifecycleTask?: boolean;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof SiteLifecycleService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * Site collection lifecycle request model
     * @type {SiteLifecycleRequest}
     * @memberof SiteLifecycleService
     */
    requestTemplate?: SiteLifecycleRequest | null;
    /**
     * 
     * @type {ChangePolicyActionSetting}
     * @memberof SiteLifecycleService
     */
    changePolicySetting?: ChangePolicyActionSetting | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof SiteLifecycleService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLifecycleService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof SiteLifecycleService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof SiteLifecycleService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof SiteLifecycleService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLifecycleService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof SiteLifecycleService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLifecycleService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof SiteLifecycleService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof SiteLifecycleService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleService
     */
    categoryId?: string | null;
}

export function SiteLifecycleServiceFromJSON(json: any): SiteLifecycleService {
    return SiteLifecycleServiceFromJSONTyped(json, false);
}

export function SiteLifecycleServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLifecycleService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'action': !exists(json, 'action') ? undefined : SiteLifecycleActionTypeFromJSON(json['action']),
        'displayMetadataInAutoLifecycleTask': !exists(json, 'displayMetadataInAutoLifecycleTask') ? undefined : json['displayMetadataInAutoLifecycleTask'],
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : SiteLifecycleRequestFromJSON(json['requestTemplate']),
        'changePolicySetting': !exists(json, 'changePolicySetting') ? undefined : ChangePolicyActionSettingFromJSON(json['changePolicySetting']),
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

export function SiteLifecycleServiceToJSON(value?: SiteLifecycleService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'action': SiteLifecycleActionTypeToJSON(value.action),
        'displayMetadataInAutoLifecycleTask': value.displayMetadataInAutoLifecycleTask,
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': SiteLifecycleRequestToJSON(value.requestTemplate),
        'changePolicySetting': ChangePolicyActionSettingToJSON(value.changePolicySetting),
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


