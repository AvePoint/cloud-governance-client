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
    ChangeSiteSettingRequest,
    ChangeSiteSettingRequestFromJSON,
    ChangeSiteSettingRequestFromJSONTyped,
    ChangeSiteSettingRequestToJSON,
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
 * @interface ChangeSiteSettingService
 */
export interface ChangeSiteSettingService {
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingService
     */
    enableChangeTitle?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingService
     */
    enableChangeDescription?: boolean;
    /**
     * 
     * @type {ChangeMetadataActionSetting}
     * @memberof ChangeSiteSettingService
     */
    changeMetadataSettings?: ChangeMetadataActionSetting | null;
    /**
     * 
     * @type {DpmServiceSetting}
     * @memberof ChangeSiteSettingService
     */
    deploymentManagerPlanSettings?: DpmServiceSetting | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingService
     */
    enableChangeHubSite?: boolean;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ChangeSiteSettingService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {ChangeSiteSettingRequest}
     * @memberof ChangeSiteSettingService
     */
    requestTemplate?: ChangeSiteSettingRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeSiteSettingService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangeSiteSettingService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteSettingService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteSettingService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangeSiteSettingService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangeSiteSettingService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangeSiteSettingService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingService
     */
    categoryId?: string | null;
}

export function ChangeSiteSettingServiceFromJSON(json: any): ChangeSiteSettingService {
    return ChangeSiteSettingServiceFromJSONTyped(json, false);
}

export function ChangeSiteSettingServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteSettingService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableChangeTitle': !exists(json, 'enableChangeTitle') ? undefined : json['enableChangeTitle'],
        'enableChangeDescription': !exists(json, 'enableChangeDescription') ? undefined : json['enableChangeDescription'],
        'changeMetadataSettings': !exists(json, 'changeMetadataSettings') ? undefined : ChangeMetadataActionSettingFromJSON(json['changeMetadataSettings']),
        'deploymentManagerPlanSettings': !exists(json, 'deploymentManagerPlanSettings') ? undefined : DpmServiceSettingFromJSON(json['deploymentManagerPlanSettings']),
        'enableChangeHubSite': !exists(json, 'enableChangeHubSite') ? undefined : json['enableChangeHubSite'],
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangeSiteSettingRequestFromJSON(json['requestTemplate']),
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

export function ChangeSiteSettingServiceToJSON(value?: ChangeSiteSettingService | null): any {
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
        'enableChangeHubSite': value.enableChangeHubSite,
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': ChangeSiteSettingRequestToJSON(value.requestTemplate),
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


