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
    ChangeMetadataActionSetting,
    ChangeMetadataActionSettingFromJSON,
    ChangeMetadataActionSettingFromJSONTyped,
    ChangeMetadataActionSettingToJSON,
    ChangeWebSettingRequest,
    ChangeWebSettingRequestFromJSON,
    ChangeWebSettingRequestFromJSONTyped,
    ChangeWebSettingRequestToJSON,
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
    DpmServiceSetting,
    DpmServiceSettingFromJSON,
    DpmServiceSettingFromJSONTyped,
    DpmServiceSettingToJSON,
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
 * @interface ChangeWebSettingService
 */
export interface ChangeWebSettingService {
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebSettingService
     */
    enableChangeTitle?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebSettingService
     */
    enableChangeDescription?: boolean;
    /**
     * 
     * @type {ChangeMetadataActionSetting}
     * @memberof ChangeWebSettingService
     */
    changeMetadataSettings?: ChangeMetadataActionSetting | null;
    /**
     * 
     * @type {DpmServiceSetting}
     * @memberof ChangeWebSettingService
     */
    deploymentManagerPlanSettings?: DpmServiceSetting | null;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ChangeWebSettingService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {ChangeWebSettingRequest}
     * @memberof ChangeWebSettingService
     */
    requestTemplate?: ChangeWebSettingRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeWebSettingService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebSettingService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSettingService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSettingService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSettingService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangeWebSettingService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebSettingService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebSettingService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebSettingService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangeWebSettingService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebSettingService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangeWebSettingService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSettingService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangeWebSettingService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSettingService
     */
    categoryId?: string | null;
}

export function ChangeWebSettingServiceFromJSON(json: any): ChangeWebSettingService {
    return ChangeWebSettingServiceFromJSONTyped(json, false);
}

export function ChangeWebSettingServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebSettingService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableChangeTitle': !exists(json, 'enableChangeTitle') ? undefined : json['enableChangeTitle'],
        'enableChangeDescription': !exists(json, 'enableChangeDescription') ? undefined : json['enableChangeDescription'],
        'changeMetadataSettings': !exists(json, 'changeMetadataSettings') ? undefined : ChangeMetadataActionSettingFromJSON(json['changeMetadataSettings']),
        'deploymentManagerPlanSettings': !exists(json, 'deploymentManagerPlanSettings') ? undefined : DpmServiceSettingFromJSON(json['deploymentManagerPlanSettings']),
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangeWebSettingRequestFromJSON(json['requestTemplate']),
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

export function ChangeWebSettingServiceToJSON(value?: ChangeWebSettingService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableChangeTitle': value.enableChangeTitle,
        'enableChangeDescription': value.enableChangeDescription,
        'changeMetadataSettings': ChangeMetadataActionSettingToJSON(value.changeMetadataSettings),
        'deploymentManagerPlanSettings': DpmServiceSettingToJSON(value.deploymentManagerPlanSettings),
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': ChangeWebSettingRequestToJSON(value.requestTemplate),
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


