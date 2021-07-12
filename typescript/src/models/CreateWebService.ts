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
    AppSettings,
    AppSettingsFromJSON,
    AppSettingsFromJSONTyped,
    AppSettingsToJSON,
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    CommonStatus,
    CommonStatusFromJSON,
    CommonStatusFromJSONTyped,
    CommonStatusToJSON,
    CreateWebRequest,
    CreateWebRequestFromJSON,
    CreateWebRequestFromJSONTyped,
    CreateWebRequestToJSON,
    CreateWebScopeSettings,
    CreateWebScopeSettingsFromJSON,
    CreateWebScopeSettingsFromJSONTyped,
    CreateWebScopeSettingsToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    DeploymentManagerPlanSettings,
    DeploymentManagerPlanSettingsFromJSON,
    DeploymentManagerPlanSettingsFromJSONTyped,
    DeploymentManagerPlanSettingsToJSON,
    GuidBooleanModel,
    GuidBooleanModelFromJSON,
    GuidBooleanModelFromJSONTyped,
    GuidBooleanModelToJSON,
    IntModel,
    IntModelFromJSON,
    IntModelFromJSONTyped,
    IntModelToJSON,
    LanguageWithTemplates,
    LanguageWithTemplatesFromJSON,
    LanguageWithTemplatesFromJSONTyped,
    LanguageWithTemplatesToJSON,
    PermissionSettings,
    PermissionSettingsFromJSON,
    PermissionSettingsFromJSONTyped,
    PermissionSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    TemplateWithPermissions,
    TemplateWithPermissionsFromJSON,
    TemplateWithPermissionsFromJSONTyped,
    TemplateWithPermissionsToJSON,
    YammerGroupServiceSettings,
    YammerGroupServiceSettingsFromJSON,
    YammerGroupServiceSettingsFromJSONTyped,
    YammerGroupServiceSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateWebService
 */
export interface CreateWebService {
    /**
     * 
     * @type {CreateWebScopeSettings}
     * @memberof CreateWebService
     */
    scopeSettings?: CreateWebScopeSettings | null;
    /**
     * 
     * @type {Array<IntModel>}
     * @memberof CreateWebService
     */
    webLanguages?: Array<IntModel> | null;
    /**
     * 
     * @type {Array<LanguageWithTemplates>}
     * @memberof CreateWebService
     */
    languageIdsAndTemplates?: Array<LanguageWithTemplates> | null;
    /**
     * 
     * @type {Array<TemplateWithPermissions>}
     * @memberof CreateWebService
     */
    templateIdsAndPermissions?: Array<TemplateWithPermissions> | null;
    /**
     * 
     * @type {PermissionSettings}
     * @memberof CreateWebService
     */
    permissionSettings?: PermissionSettings | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    useUniquePermissions?: boolean;
    /**
     * 
     * @type {DeploymentManagerPlanSettings}
     * @memberof CreateWebService
     */
    deploymentManagerPlanSettings?: DeploymentManagerPlanSettings | null;
    /**
     * 
     * @type {YammerGroupServiceSettings}
     * @memberof CreateWebService
     */
    yammerGroupSettings?: YammerGroupServiceSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebService
     */
    templateStoreUrl?: string | null;
    /**
     * 
     * @type {AppSettings}
     * @memberof CreateWebService
     */
    appSettings?: AppSettings | null;
    /**
     * 
     * @type {GuidBooleanModel}
     * @memberof CreateWebService
     */
    notifyPrimaryContactSettings?: GuidBooleanModel | null;
    /**
     * 
     * @type {GuidBooleanModel}
     * @memberof CreateWebService
     */
    notifySecondaryContactSettings?: GuidBooleanModel | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebService
     */
    defaultPrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebService
     */
    defaultSecondaryContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    isOnQuickLaunch?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    isOnTopLinkBar?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    isNavigationInheritance?: boolean;
    /**
     * 
     * @type {number}
     * @memberof CreateWebService
     */
    defaultWebLanguage?: number;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    scopeAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    webLanguageAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    templateAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    navigationInheritanceAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    navigationAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    primaryContactAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    secondaryContactAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebService
     */
    permissionAssignBy?: AssignBy;
    /**
     * 
     * @type {CreateWebRequest}
     * @memberof CreateWebService
     */
    requestTemplate?: CreateWebRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof CreateWebService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateWebService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateWebService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof CreateWebService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof CreateWebService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof CreateWebService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof CreateWebService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateWebService
     */
    categoryId?: string | null;
}

export function CreateWebServiceFromJSON(json: any): CreateWebService {
    return CreateWebServiceFromJSONTyped(json, false);
}

export function CreateWebServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateWebService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : CreateWebScopeSettingsFromJSON(json['scopeSettings']),
        'webLanguages': !exists(json, 'webLanguages') ? undefined : (json['webLanguages'] === null ? null : (json['webLanguages'] as Array<any>).map(IntModelFromJSON)),
        'languageIdsAndTemplates': !exists(json, 'languageIdsAndTemplates') ? undefined : (json['languageIdsAndTemplates'] === null ? null : (json['languageIdsAndTemplates'] as Array<any>).map(LanguageWithTemplatesFromJSON)),
        'templateIdsAndPermissions': !exists(json, 'templateIdsAndPermissions') ? undefined : (json['templateIdsAndPermissions'] === null ? null : (json['templateIdsAndPermissions'] as Array<any>).map(TemplateWithPermissionsFromJSON)),
        'permissionSettings': !exists(json, 'permissionSettings') ? undefined : PermissionSettingsFromJSON(json['permissionSettings']),
        'useUniquePermissions': !exists(json, 'useUniquePermissions') ? undefined : json['useUniquePermissions'],
        'deploymentManagerPlanSettings': !exists(json, 'deploymentManagerPlanSettings') ? undefined : DeploymentManagerPlanSettingsFromJSON(json['deploymentManagerPlanSettings']),
        'yammerGroupSettings': !exists(json, 'yammerGroupSettings') ? undefined : YammerGroupServiceSettingsFromJSON(json['yammerGroupSettings']),
        'templateStoreUrl': !exists(json, 'templateStoreUrl') ? undefined : json['templateStoreUrl'],
        'appSettings': !exists(json, 'appSettings') ? undefined : AppSettingsFromJSON(json['appSettings']),
        'notifyPrimaryContactSettings': !exists(json, 'notifyPrimaryContactSettings') ? undefined : GuidBooleanModelFromJSON(json['notifyPrimaryContactSettings']),
        'notifySecondaryContactSettings': !exists(json, 'notifySecondaryContactSettings') ? undefined : GuidBooleanModelFromJSON(json['notifySecondaryContactSettings']),
        'defaultPrimaryContact': !exists(json, 'defaultPrimaryContact') ? undefined : ApiUserFromJSON(json['defaultPrimaryContact']),
        'defaultSecondaryContact': !exists(json, 'defaultSecondaryContact') ? undefined : ApiUserFromJSON(json['defaultSecondaryContact']),
        'isOnQuickLaunch': !exists(json, 'isOnQuickLaunch') ? undefined : json['isOnQuickLaunch'],
        'isOnTopLinkBar': !exists(json, 'isOnTopLinkBar') ? undefined : json['isOnTopLinkBar'],
        'isNavigationInheritance': !exists(json, 'isNavigationInheritance') ? undefined : json['isNavigationInheritance'],
        'defaultWebLanguage': !exists(json, 'defaultWebLanguage') ? undefined : json['defaultWebLanguage'],
        'scopeAssignBy': !exists(json, 'scopeAssignBy') ? undefined : AssignByFromJSON(json['scopeAssignBy']),
        'webLanguageAssignBy': !exists(json, 'webLanguageAssignBy') ? undefined : AssignByFromJSON(json['webLanguageAssignBy']),
        'templateAssignBy': !exists(json, 'templateAssignBy') ? undefined : AssignByFromJSON(json['templateAssignBy']),
        'navigationInheritanceAssignBy': !exists(json, 'navigationInheritanceAssignBy') ? undefined : AssignByFromJSON(json['navigationInheritanceAssignBy']),
        'navigationAssignBy': !exists(json, 'navigationAssignBy') ? undefined : AssignByFromJSON(json['navigationAssignBy']),
        'primaryContactAssignBy': !exists(json, 'primaryContactAssignBy') ? undefined : AssignByFromJSON(json['primaryContactAssignBy']),
        'secondaryContactAssignBy': !exists(json, 'secondaryContactAssignBy') ? undefined : AssignByFromJSON(json['secondaryContactAssignBy']),
        'permissionAssignBy': !exists(json, 'permissionAssignBy') ? undefined : AssignByFromJSON(json['permissionAssignBy']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : CreateWebRequestFromJSON(json['requestTemplate']),
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

export function CreateWebServiceToJSON(value?: CreateWebService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'scopeSettings': CreateWebScopeSettingsToJSON(value.scopeSettings),
        'webLanguages': value.webLanguages === undefined ? undefined : (value.webLanguages === null ? null : (value.webLanguages as Array<any>).map(IntModelToJSON)),
        'languageIdsAndTemplates': value.languageIdsAndTemplates === undefined ? undefined : (value.languageIdsAndTemplates === null ? null : (value.languageIdsAndTemplates as Array<any>).map(LanguageWithTemplatesToJSON)),
        'templateIdsAndPermissions': value.templateIdsAndPermissions === undefined ? undefined : (value.templateIdsAndPermissions === null ? null : (value.templateIdsAndPermissions as Array<any>).map(TemplateWithPermissionsToJSON)),
        'permissionSettings': PermissionSettingsToJSON(value.permissionSettings),
        'useUniquePermissions': value.useUniquePermissions,
        'deploymentManagerPlanSettings': DeploymentManagerPlanSettingsToJSON(value.deploymentManagerPlanSettings),
        'yammerGroupSettings': YammerGroupServiceSettingsToJSON(value.yammerGroupSettings),
        'templateStoreUrl': value.templateStoreUrl,
        'appSettings': AppSettingsToJSON(value.appSettings),
        'notifyPrimaryContactSettings': GuidBooleanModelToJSON(value.notifyPrimaryContactSettings),
        'notifySecondaryContactSettings': GuidBooleanModelToJSON(value.notifySecondaryContactSettings),
        'defaultPrimaryContact': ApiUserToJSON(value.defaultPrimaryContact),
        'defaultSecondaryContact': ApiUserToJSON(value.defaultSecondaryContact),
        'isOnQuickLaunch': value.isOnQuickLaunch,
        'isOnTopLinkBar': value.isOnTopLinkBar,
        'isNavigationInheritance': value.isNavigationInheritance,
        'defaultWebLanguage': value.defaultWebLanguage,
        'scopeAssignBy': AssignByToJSON(value.scopeAssignBy),
        'webLanguageAssignBy': AssignByToJSON(value.webLanguageAssignBy),
        'templateAssignBy': AssignByToJSON(value.templateAssignBy),
        'navigationInheritanceAssignBy': AssignByToJSON(value.navigationInheritanceAssignBy),
        'navigationAssignBy': AssignByToJSON(value.navigationAssignBy),
        'primaryContactAssignBy': AssignByToJSON(value.primaryContactAssignBy),
        'secondaryContactAssignBy': AssignByToJSON(value.secondaryContactAssignBy),
        'permissionAssignBy': AssignByToJSON(value.permissionAssignBy),
        'requestTemplate': CreateWebRequestToJSON(value.requestTemplate),
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


