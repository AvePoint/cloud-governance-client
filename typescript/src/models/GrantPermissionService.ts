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
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    GrantPermissionRequest,
    GrantPermissionRequestFromJSON,
    GrantPermissionRequestFromJSONTyped,
    GrantPermissionRequestToJSON,
    GrantPermissionServiceDurationSettings,
    GrantPermissionServiceDurationSettingsFromJSON,
    GrantPermissionServiceDurationSettingsFromJSONTyped,
    GrantPermissionServiceDurationSettingsToJSON,
    GrantPermissionServicePermissionSettings,
    GrantPermissionServicePermissionSettingsFromJSON,
    GrantPermissionServicePermissionSettingsFromJSONTyped,
    GrantPermissionServicePermissionSettingsToJSON,
    ServiceScopeSettings,
    ServiceScopeSettingsFromJSON,
    ServiceScopeSettingsFromJSONTyped,
    ServiceScopeSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    UserLevelControlSettings,
    UserLevelControlSettingsFromJSON,
    UserLevelControlSettingsFromJSONTyped,
    UserLevelControlSettingsToJSON,
    WelcomeEmailSettings,
    WelcomeEmailSettingsFromJSON,
    WelcomeEmailSettingsFromJSONTyped,
    WelcomeEmailSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionService
 */
export interface GrantPermissionService {
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionService
     */
    allowBreakPermissionInheritance?: boolean;
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof GrantPermissionService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {UserLevelControlSettings}
     * @memberof GrantPermissionService
     */
    userLevelControlSettings?: UserLevelControlSettings | null;
    /**
     * 
     * @type {GrantPermissionServiceDurationSettings}
     * @memberof GrantPermissionService
     */
    permissionDurationSettings?: GrantPermissionServiceDurationSettings | null;
    /**
     * 
     * @type {GrantPermissionServicePermissionSettings}
     * @memberof GrantPermissionService
     */
    permissionSettings?: GrantPermissionServicePermissionSettings | null;
    /**
     * 
     * @type {WelcomeEmailSettings}
     * @memberof GrantPermissionService
     */
    defaultWelcomeEmailSettings?: WelcomeEmailSettings | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof GrantPermissionService
     */
    welcomeEmailAssignBy?: AssignBy;
    /**
     * 
     * @type {GrantPermissionRequest}
     * @memberof GrantPermissionService
     */
    requestTemplate?: GrantPermissionRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof GrantPermissionService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof GrantPermissionService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof GrantPermissionService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof GrantPermissionService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof GrantPermissionService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof GrantPermissionService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof GrantPermissionService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionService
     */
    categoryId?: string | null;
}

export function GrantPermissionServiceFromJSON(json: any): GrantPermissionService {
    return GrantPermissionServiceFromJSONTyped(json, false);
}

export function GrantPermissionServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'allowBreakPermissionInheritance': !exists(json, 'allowBreakPermissionInheritance') ? undefined : json['allowBreakPermissionInheritance'],
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'userLevelControlSettings': !exists(json, 'userLevelControlSettings') ? undefined : UserLevelControlSettingsFromJSON(json['userLevelControlSettings']),
        'permissionDurationSettings': !exists(json, 'permissionDurationSettings') ? undefined : GrantPermissionServiceDurationSettingsFromJSON(json['permissionDurationSettings']),
        'permissionSettings': !exists(json, 'permissionSettings') ? undefined : GrantPermissionServicePermissionSettingsFromJSON(json['permissionSettings']),
        'defaultWelcomeEmailSettings': !exists(json, 'defaultWelcomeEmailSettings') ? undefined : WelcomeEmailSettingsFromJSON(json['defaultWelcomeEmailSettings']),
        'welcomeEmailAssignBy': !exists(json, 'welcomeEmailAssignBy') ? undefined : AssignByFromJSON(json['welcomeEmailAssignBy']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : GrantPermissionRequestFromJSON(json['requestTemplate']),
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

export function GrantPermissionServiceToJSON(value?: GrantPermissionService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'allowBreakPermissionInheritance': value.allowBreakPermissionInheritance,
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'userLevelControlSettings': UserLevelControlSettingsToJSON(value.userLevelControlSettings),
        'permissionDurationSettings': GrantPermissionServiceDurationSettingsToJSON(value.permissionDurationSettings),
        'permissionSettings': GrantPermissionServicePermissionSettingsToJSON(value.permissionSettings),
        'defaultWelcomeEmailSettings': WelcomeEmailSettingsToJSON(value.defaultWelcomeEmailSettings),
        'welcomeEmailAssignBy': AssignByToJSON(value.welcomeEmailAssignBy),
        'requestTemplate': GrantPermissionRequestToJSON(value.requestTemplate),
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


