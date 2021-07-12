/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiRequest,
    ApiRequestFromJSON,
    ApiRequestFromJSONTyped,
    ApiRequestToJSON,
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
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceForRequest
 */
export interface ServiceForRequest {
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ServiceForRequest
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceForRequest
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ServiceForRequest
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ServiceForRequest
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceForRequest
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ServiceForRequest
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ServiceForRequest
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ServiceForRequest
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceForRequest
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ServiceForRequest
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceForRequest
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ServiceForRequest
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceForRequest
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ServiceForRequest
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ServiceForRequest
     */
    categoryId?: string | null;
    /**
     * Base model of request.
     * @type {ApiRequest}
     * @memberof ServiceForRequest
     */
    requestTemplate?: ApiRequest | null;
}

export function ServiceForRequestFromJSON(json: any): ServiceForRequest {
    return ServiceForRequestFromJSONTyped(json, false);
}

export function ServiceForRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceForRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
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
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ApiRequestFromJSON(json['requestTemplate']),
    };
}

export function ServiceForRequestToJSON(value?: ServiceForRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
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
        'requestTemplate': ApiRequestToJSON(value.requestTemplate),
    };
}


