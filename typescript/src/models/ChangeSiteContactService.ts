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
    ChangeSiteContactRequest,
    ChangeSiteContactRequestFromJSON,
    ChangeSiteContactRequestFromJSONTyped,
    ChangeSiteContactRequestToJSON,
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
 * @interface ChangeSiteContactService
 */
export interface ChangeSiteContactService {
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactService
     */
    enableChangeContact?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactService
     */
    enableChangeAdmin?: boolean;
    /**
     * 
     * @type {ChangeContactMethod}
     * @memberof ChangeSiteContactService
     */
    changedMethod?: ChangeContactMethod;
    /**
     * 
     * @type {AssignBy}
     * @memberof ChangeSiteContactService
     */
    changeModeAssignBy?: AssignBy;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof ChangeSiteContactService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {ChangeSiteContactRequest}
     * @memberof ChangeSiteContactService
     */
    requestTemplate?: ChangeSiteContactRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeSiteContactService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangeSiteContactService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteContactService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteContactService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangeSiteContactService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangeSiteContactService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangeSiteContactService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactService
     */
    categoryId?: string | null;
}

export function ChangeSiteContactServiceFromJSON(json: any): ChangeSiteContactService {
    return ChangeSiteContactServiceFromJSONTyped(json, false);
}

export function ChangeSiteContactServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteContactService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableChangeContact': !exists(json, 'enableChangeContact') ? undefined : json['enableChangeContact'],
        'enableChangeAdmin': !exists(json, 'enableChangeAdmin') ? undefined : json['enableChangeAdmin'],
        'changedMethod': !exists(json, 'changedMethod') ? undefined : ChangeContactMethodFromJSON(json['changedMethod']),
        'changeModeAssignBy': !exists(json, 'changeModeAssignBy') ? undefined : AssignByFromJSON(json['changeModeAssignBy']),
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangeSiteContactRequestFromJSON(json['requestTemplate']),
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

export function ChangeSiteContactServiceToJSON(value?: ChangeSiteContactService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableChangeContact': value.enableChangeContact,
        'enableChangeAdmin': value.enableChangeAdmin,
        'changedMethod': ChangeContactMethodToJSON(value.changedMethod),
        'changeModeAssignBy': AssignByToJSON(value.changeModeAssignBy),
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'requestTemplate': ChangeSiteContactRequestToJSON(value.requestTemplate),
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


