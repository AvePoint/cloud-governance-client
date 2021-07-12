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
    ChangeContactMethod,
    ChangeContactMethodFromJSON,
    ChangeContactMethodFromJSONTyped,
    ChangeContactMethodToJSON,
    ChangeWebContactRequest,
    ChangeWebContactRequestFromJSON,
    ChangeWebContactRequestFromJSONTyped,
    ChangeWebContactRequestToJSON,
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
} from './';

/**
 * 
 * @export
 * @interface ChangeWebContactService
 */
export interface ChangeWebContactService {
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    selectedNodes?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    unCheckedNodesInfo?: string | null;
    /**
     * 
     * @type {ChangeContactMethod}
     * @memberof ChangeWebContactService
     */
    changeMethod?: ChangeContactMethod;
    /**
     * 
     * @type {AssignBy}
     * @memberof ChangeWebContactService
     */
    changeMethodAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebContactService
     */
    enableNotifyNewContact?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    newContactNotifiedEmail?: string | null;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ChangeWebContactService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {ChangeWebContactRequest}
     * @memberof ChangeWebContactService
     */
    requestTemplate?: ChangeWebContactRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeWebContactService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebContactService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangeWebContactService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebContactService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebContactService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebContactService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangeWebContactService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebContactService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangeWebContactService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangeWebContactService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactService
     */
    categoryId?: string | null;
}

export function ChangeWebContactServiceFromJSON(json: any): ChangeWebContactService {
    return ChangeWebContactServiceFromJSONTyped(json, false);
}

export function ChangeWebContactServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebContactService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'selectedNodes': !exists(json, 'selectedNodes') ? undefined : json['selectedNodes'],
        'unCheckedNodesInfo': !exists(json, 'unCheckedNodesInfo') ? undefined : json['unCheckedNodesInfo'],
        'changeMethod': !exists(json, 'changeMethod') ? undefined : ChangeContactMethodFromJSON(json['changeMethod']),
        'changeMethodAssignBy': !exists(json, 'changeMethodAssignBy') ? undefined : AssignByFromJSON(json['changeMethodAssignBy']),
        'enableNotifyNewContact': !exists(json, 'enableNotifyNewContact') ? undefined : json['enableNotifyNewContact'],
        'newContactNotifiedEmail': !exists(json, 'newContactNotifiedEmail') ? undefined : json['newContactNotifiedEmail'],
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangeWebContactRequestFromJSON(json['requestTemplate']),
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

export function ChangeWebContactServiceToJSON(value?: ChangeWebContactService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'selectedNodes': value.selectedNodes,
        'unCheckedNodesInfo': value.unCheckedNodesInfo,
        'changeMethod': ChangeContactMethodToJSON(value.changeMethod),
        'changeMethodAssignBy': AssignByToJSON(value.changeMethodAssignBy),
        'enableNotifyNewContact': value.enableNotifyNewContact,
        'newContactNotifiedEmail': value.newContactNotifiedEmail,
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': ChangeWebContactRequestToJSON(value.requestTemplate),
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


