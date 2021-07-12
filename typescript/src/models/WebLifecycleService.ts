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
    ServiceScopeSettings,
    ServiceScopeSettingsFromJSON,
    ServiceScopeSettingsFromJSONTyped,
    ServiceScopeSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    WebLifecycleActionType,
    WebLifecycleActionTypeFromJSON,
    WebLifecycleActionTypeFromJSONTyped,
    WebLifecycleActionTypeToJSON,
    WebLifecycleRequest,
    WebLifecycleRequestFromJSON,
    WebLifecycleRequestFromJSONTyped,
    WebLifecycleRequestToJSON,
} from './';

/**
 * 
 * @export
 * @interface WebLifecycleService
 */
export interface WebLifecycleService {
    /**
     * 
     * @type {WebLifecycleActionType}
     * @memberof WebLifecycleService
     */
    action?: WebLifecycleActionType;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleService
     */
    archiveContentProfile?: string | null;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof WebLifecycleService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {WebLifecycleRequest}
     * @memberof WebLifecycleService
     */
    requestTemplate?: WebLifecycleRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof WebLifecycleService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof WebLifecycleService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof WebLifecycleService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof WebLifecycleService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof WebLifecycleService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof WebLifecycleService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof WebLifecycleService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof WebLifecycleService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof WebLifecycleService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof WebLifecycleService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleService
     */
    categoryId?: string | null;
}

export function WebLifecycleServiceFromJSON(json: any): WebLifecycleService {
    return WebLifecycleServiceFromJSONTyped(json, false);
}

export function WebLifecycleServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): WebLifecycleService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'action': !exists(json, 'action') ? undefined : WebLifecycleActionTypeFromJSON(json['action']),
        'archiveContentProfile': !exists(json, 'archiveContentProfile') ? undefined : json['archiveContentProfile'],
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : WebLifecycleRequestFromJSON(json['requestTemplate']),
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

export function WebLifecycleServiceToJSON(value?: WebLifecycleService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'action': WebLifecycleActionTypeToJSON(value.action),
        'archiveContentProfile': value.archiveContentProfile,
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': WebLifecycleRequestToJSON(value.requestTemplate),
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


