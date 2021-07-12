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
    ChangeListSettingRequest,
    ChangeListSettingRequestFromJSON,
    ChangeListSettingRequestFromJSONTyped,
    ChangeListSettingRequestToJSON,
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
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeListSettingService
 */
export interface ChangeListSettingService {
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    isEnableChangeTitle?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    isEnableChangeDescription?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    isEnableChangeQuickLaunch?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    isEnableChangeVersion?: boolean;
    /**
     * 
     * @type {ChangeListSettingRequest}
     * @memberof ChangeListSettingService
     */
    requestTemplate?: ChangeListSettingRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeListSettingService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangeListSettingService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeListSettingService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeListSettingService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangeListSettingService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangeListSettingService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangeListSettingService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingService
     */
    categoryId?: string | null;
}

export function ChangeListSettingServiceFromJSON(json: any): ChangeListSettingService {
    return ChangeListSettingServiceFromJSONTyped(json, false);
}

export function ChangeListSettingServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeListSettingService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnableChangeTitle': !exists(json, 'isEnableChangeTitle') ? undefined : json['isEnableChangeTitle'],
        'isEnableChangeDescription': !exists(json, 'isEnableChangeDescription') ? undefined : json['isEnableChangeDescription'],
        'isEnableChangeQuickLaunch': !exists(json, 'isEnableChangeQuickLaunch') ? undefined : json['isEnableChangeQuickLaunch'],
        'isEnableChangeVersion': !exists(json, 'isEnableChangeVersion') ? undefined : json['isEnableChangeVersion'],
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangeListSettingRequestFromJSON(json['requestTemplate']),
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

export function ChangeListSettingServiceToJSON(value?: ChangeListSettingService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnableChangeTitle': value.isEnableChangeTitle,
        'isEnableChangeDescription': value.isEnableChangeDescription,
        'isEnableChangeQuickLaunch': value.isEnableChangeQuickLaunch,
        'isEnableChangeVersion': value.isEnableChangeVersion,
        'requestTemplate': ChangeListSettingRequestToJSON(value.requestTemplate),
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


