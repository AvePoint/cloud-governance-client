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
    CreateSiteRequest,
    CreateSiteRequestFromJSON,
    CreateSiteRequestFromJSONTyped,
    CreateSiteRequestToJSON,
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
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    HubSiteSettings,
    HubSiteSettingsFromJSON,
    HubSiteSettingsFromJSONTyped,
    HubSiteSettingsToJSON,
    IntModel,
    IntModelFromJSON,
    IntModelFromJSONTyped,
    IntModelToJSON,
    MultiGeoSerivceSetting,
    MultiGeoSerivceSettingFromJSON,
    MultiGeoSerivceSettingFromJSONTyped,
    MultiGeoSerivceSettingToJSON,
    PermissionSettings,
    PermissionSettingsFromJSON,
    PermissionSettingsFromJSONTyped,
    PermissionSettingsToJSON,
    PolicyRef,
    PolicyRefFromJSON,
    PolicyRefFromJSONTyped,
    PolicyRefToJSON,
    PolicyWithTemplates,
    PolicyWithTemplatesFromJSON,
    PolicyWithTemplatesFromJSONTyped,
    PolicyWithTemplatesToJSON,
    RootSiteWithManagedPaths,
    RootSiteWithManagedPathsFromJSON,
    RootSiteWithManagedPathsFromJSONTyped,
    RootSiteWithManagedPathsToJSON,
    ServiceScopeSettings,
    ServiceScopeSettingsFromJSON,
    ServiceScopeSettingsFromJSONTyped,
    ServiceScopeSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    SiteLeasePeriodServiceSettings,
    SiteLeasePeriodServiceSettingsFromJSON,
    SiteLeasePeriodServiceSettingsFromJSONTyped,
    SiteLeasePeriodServiceSettingsToJSON,
    SiteTitleSetting,
    SiteTitleSettingFromJSON,
    SiteTitleSettingFromJSONTyped,
    SiteTitleSettingToJSON,
    SiteUrlSetting,
    SiteUrlSettingFromJSON,
    SiteUrlSettingFromJSONTyped,
    SiteUrlSettingToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelFromJSONTyped,
    StringModelToJSON,
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
 * @interface CreateSiteService
 */
export interface CreateSiteService {
    /**
     * 
     * @type {ServiceScopeSettings}
     * @memberof CreateSiteService
     */
    scopeSettings?: ServiceScopeSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    adminCenterUrl?: string | null;
    /**
     * 
     * @type {Array<IntModel>}
     * @memberof CreateSiteService
     */
    siteLanguages?: Array<IntModel> | null;
    /**
     * 
     * @type {Array<RootSiteWithManagedPaths>}
     * @memberof CreateSiteService
     */
    rootSiteAndManagedPaths?: Array<RootSiteWithManagedPaths> | null;
    /**
     * 
     * @type {SiteUrlSetting}
     * @memberof CreateSiteService
     */
    siteUrlSetting?: SiteUrlSetting | null;
    /**
     * 
     * @type {MultiGeoSerivceSetting}
     * @memberof CreateSiteService
     */
    multiGeoSetting?: MultiGeoSerivceSetting | null;
    /**
     * 
     * @type {SiteTitleSetting}
     * @memberof CreateSiteService
     */
    siteTitleSetting?: SiteTitleSetting | null;
    /**
     * 
     * @type {Array<PolicyRef>}
     * @memberof CreateSiteService
     */
    policies?: Array<PolicyRef> | null;
    /**
     * 
     * @type {DeploymentManagerPlanSettings}
     * @memberof CreateSiteService
     */
    deploymentManagerPlanSettings?: DeploymentManagerPlanSettings | null;
    /**
     * 
     * @type {Array<PolicyWithTemplates>}
     * @memberof CreateSiteService
     */
    policyIdsAndTemplates?: Array<PolicyWithTemplates> | null;
    /**
     * 
     * @type {Array<TemplateWithPermissions>}
     * @memberof CreateSiteService
     */
    templateIdsAndPermissions?: Array<TemplateWithPermissions> | null;
    /**
     * 
     * @type {PermissionSettings}
     * @memberof CreateSiteService
     */
    permissionSettings?: PermissionSettings | null;
    /**
     * 
     * @type {SiteLeasePeriodServiceSettings}
     * @memberof CreateSiteService
     */
    leasePeriodSettings?: SiteLeasePeriodServiceSettings | null;
    /**
     * 
     * @type {Array<IntModel>}
     * @memberof CreateSiteService
     */
    timeZones?: Array<IntModel> | null;
    /**
     * 
     * @type {Array<StringModel>}
     * @memberof CreateSiteService
     */
    siteDesigns?: Array<StringModel> | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof CreateSiteService
     */
    siteDesign?: GuidModel | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultTeamSiteDesignId?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    siteDesignAssignBy?: AssignBy;
    /**
     * 
     * @type {YammerGroupServiceSettings}
     * @memberof CreateSiteService
     */
    yammerGroupSettings?: YammerGroupServiceSettings | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof CreateSiteService
     */
    classifications?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof CreateSiteService
     */
    sensitivities?: Array<string> | null;
    /**
     * Hub site settings model
     * @type {HubSiteSettings}
     * @memberof CreateSiteService
     */
    hubSiteSettings?: HubSiteSettings | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateSiteService
     */
    enabledCustomTemplate?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    customSiteTemplateListURL?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateSiteService
     */
    defaultPrimaryAdmin?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateSiteService
     */
    defaultAdditionalAdmins?: Array<ApiUser> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateSiteService
     */
    defaultPrimaryAdminReal?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateSiteService
     */
    defaultAdditionalAdminsReal?: Array<ApiUser> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateSiteService
     */
    defaultPrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateSiteService
     */
    defaultSecondaryContact?: ApiUser | null;
    /**
     * 
     * @type {number}
     * @memberof CreateSiteService
     */
    defaultSiteLanguage?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultRootSite?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultManagedPath?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultPolicy?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultTemplate?: string | null;
    /**
     * 
     * @type {number}
     * @memberof CreateSiteService
     */
    defaultTimeZone?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultClassification?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultSensitivity?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    defaultDesignType?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    siteLanguageAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    templateAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    policyAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    permissionAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    rootSiteAndManagedPathAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    timeZoneAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    primaryAdminAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    additionalAdminAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    primaryContactAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    secondaryContactAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    designTypeAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    classificationAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    sensitivityAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateSiteService
     */
    hubSiteAssignBy?: AssignBy;
    /**
     * Create collection requesst model
     * @type {CreateSiteRequest}
     * @memberof CreateSiteService
     */
    requestTemplate?: CreateSiteRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof CreateSiteService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateSiteService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof CreateSiteService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateSiteService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateSiteService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateSiteService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof CreateSiteService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof CreateSiteService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof CreateSiteService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof CreateSiteService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateSiteService
     */
    categoryId?: string | null;
}

export function CreateSiteServiceFromJSON(json: any): CreateSiteService {
    return CreateSiteServiceFromJSONTyped(json, false);
}

export function CreateSiteServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateSiteService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'scopeSettings': !exists(json, 'scopeSettings') ? undefined : ServiceScopeSettingsFromJSON(json['scopeSettings']),
        'adminCenterUrl': !exists(json, 'adminCenterUrl') ? undefined : json['adminCenterUrl'],
        'siteLanguages': !exists(json, 'siteLanguages') ? undefined : (json['siteLanguages'] === null ? null : (json['siteLanguages'] as Array<any>).map(IntModelFromJSON)),
        'rootSiteAndManagedPaths': !exists(json, 'rootSiteAndManagedPaths') ? undefined : (json['rootSiteAndManagedPaths'] === null ? null : (json['rootSiteAndManagedPaths'] as Array<any>).map(RootSiteWithManagedPathsFromJSON)),
        'siteUrlSetting': !exists(json, 'siteUrlSetting') ? undefined : SiteUrlSettingFromJSON(json['siteUrlSetting']),
        'multiGeoSetting': !exists(json, 'multiGeoSetting') ? undefined : MultiGeoSerivceSettingFromJSON(json['multiGeoSetting']),
        'siteTitleSetting': !exists(json, 'siteTitleSetting') ? undefined : SiteTitleSettingFromJSON(json['siteTitleSetting']),
        'policies': !exists(json, 'policies') ? undefined : (json['policies'] === null ? null : (json['policies'] as Array<any>).map(PolicyRefFromJSON)),
        'deploymentManagerPlanSettings': !exists(json, 'deploymentManagerPlanSettings') ? undefined : DeploymentManagerPlanSettingsFromJSON(json['deploymentManagerPlanSettings']),
        'policyIdsAndTemplates': !exists(json, 'policyIdsAndTemplates') ? undefined : (json['policyIdsAndTemplates'] === null ? null : (json['policyIdsAndTemplates'] as Array<any>).map(PolicyWithTemplatesFromJSON)),
        'templateIdsAndPermissions': !exists(json, 'templateIdsAndPermissions') ? undefined : (json['templateIdsAndPermissions'] === null ? null : (json['templateIdsAndPermissions'] as Array<any>).map(TemplateWithPermissionsFromJSON)),
        'permissionSettings': !exists(json, 'permissionSettings') ? undefined : PermissionSettingsFromJSON(json['permissionSettings']),
        'leasePeriodSettings': !exists(json, 'leasePeriodSettings') ? undefined : SiteLeasePeriodServiceSettingsFromJSON(json['leasePeriodSettings']),
        'timeZones': !exists(json, 'timeZones') ? undefined : (json['timeZones'] === null ? null : (json['timeZones'] as Array<any>).map(IntModelFromJSON)),
        'siteDesigns': !exists(json, 'siteDesigns') ? undefined : (json['siteDesigns'] === null ? null : (json['siteDesigns'] as Array<any>).map(StringModelFromJSON)),
        'siteDesign': !exists(json, 'siteDesign') ? undefined : GuidModelFromJSON(json['siteDesign']),
        'defaultTeamSiteDesignId': !exists(json, 'defaultTeamSiteDesignId') ? undefined : json['defaultTeamSiteDesignId'],
        'siteDesignAssignBy': !exists(json, 'siteDesignAssignBy') ? undefined : AssignByFromJSON(json['siteDesignAssignBy']),
        'yammerGroupSettings': !exists(json, 'yammerGroupSettings') ? undefined : YammerGroupServiceSettingsFromJSON(json['yammerGroupSettings']),
        'classifications': !exists(json, 'classifications') ? undefined : json['classifications'],
        'sensitivities': !exists(json, 'sensitivities') ? undefined : json['sensitivities'],
        'hubSiteSettings': !exists(json, 'hubSiteSettings') ? undefined : HubSiteSettingsFromJSON(json['hubSiteSettings']),
        'enabledCustomTemplate': !exists(json, 'enabledCustomTemplate') ? undefined : json['enabledCustomTemplate'],
        'customSiteTemplateListURL': !exists(json, 'customSiteTemplateListURL') ? undefined : json['customSiteTemplateListURL'],
        'defaultPrimaryAdmin': !exists(json, 'defaultPrimaryAdmin') ? undefined : ApiUserFromJSON(json['defaultPrimaryAdmin']),
        'defaultAdditionalAdmins': !exists(json, 'defaultAdditionalAdmins') ? undefined : (json['defaultAdditionalAdmins'] === null ? null : (json['defaultAdditionalAdmins'] as Array<any>).map(ApiUserFromJSON)),
        'defaultPrimaryAdminReal': !exists(json, 'defaultPrimaryAdminReal') ? undefined : ApiUserFromJSON(json['defaultPrimaryAdminReal']),
        'defaultAdditionalAdminsReal': !exists(json, 'defaultAdditionalAdminsReal') ? undefined : (json['defaultAdditionalAdminsReal'] === null ? null : (json['defaultAdditionalAdminsReal'] as Array<any>).map(ApiUserFromJSON)),
        'defaultPrimaryContact': !exists(json, 'defaultPrimaryContact') ? undefined : ApiUserFromJSON(json['defaultPrimaryContact']),
        'defaultSecondaryContact': !exists(json, 'defaultSecondaryContact') ? undefined : ApiUserFromJSON(json['defaultSecondaryContact']),
        'defaultSiteLanguage': !exists(json, 'defaultSiteLanguage') ? undefined : json['defaultSiteLanguage'],
        'defaultRootSite': !exists(json, 'defaultRootSite') ? undefined : json['defaultRootSite'],
        'defaultManagedPath': !exists(json, 'defaultManagedPath') ? undefined : json['defaultManagedPath'],
        'defaultPolicy': !exists(json, 'defaultPolicy') ? undefined : json['defaultPolicy'],
        'defaultTemplate': !exists(json, 'defaultTemplate') ? undefined : json['defaultTemplate'],
        'defaultTimeZone': !exists(json, 'defaultTimeZone') ? undefined : json['defaultTimeZone'],
        'defaultClassification': !exists(json, 'defaultClassification') ? undefined : json['defaultClassification'],
        'defaultSensitivity': !exists(json, 'defaultSensitivity') ? undefined : json['defaultSensitivity'],
        'defaultDesignType': !exists(json, 'defaultDesignType') ? undefined : json['defaultDesignType'],
        'siteLanguageAssignBy': !exists(json, 'siteLanguageAssignBy') ? undefined : AssignByFromJSON(json['siteLanguageAssignBy']),
        'templateAssignBy': !exists(json, 'templateAssignBy') ? undefined : AssignByFromJSON(json['templateAssignBy']),
        'policyAssignBy': !exists(json, 'policyAssignBy') ? undefined : AssignByFromJSON(json['policyAssignBy']),
        'permissionAssignBy': !exists(json, 'permissionAssignBy') ? undefined : AssignByFromJSON(json['permissionAssignBy']),
        'rootSiteAndManagedPathAssignBy': !exists(json, 'rootSiteAndManagedPathAssignBy') ? undefined : AssignByFromJSON(json['rootSiteAndManagedPathAssignBy']),
        'timeZoneAssignBy': !exists(json, 'timeZoneAssignBy') ? undefined : AssignByFromJSON(json['timeZoneAssignBy']),
        'primaryAdminAssignBy': !exists(json, 'primaryAdminAssignBy') ? undefined : AssignByFromJSON(json['primaryAdminAssignBy']),
        'additionalAdminAssignBy': !exists(json, 'additionalAdminAssignBy') ? undefined : AssignByFromJSON(json['additionalAdminAssignBy']),
        'primaryContactAssignBy': !exists(json, 'primaryContactAssignBy') ? undefined : AssignByFromJSON(json['primaryContactAssignBy']),
        'secondaryContactAssignBy': !exists(json, 'secondaryContactAssignBy') ? undefined : AssignByFromJSON(json['secondaryContactAssignBy']),
        'designTypeAssignBy': !exists(json, 'designTypeAssignBy') ? undefined : AssignByFromJSON(json['designTypeAssignBy']),
        'classificationAssignBy': !exists(json, 'classificationAssignBy') ? undefined : AssignByFromJSON(json['classificationAssignBy']),
        'sensitivityAssignBy': !exists(json, 'sensitivityAssignBy') ? undefined : AssignByFromJSON(json['sensitivityAssignBy']),
        'hubSiteAssignBy': !exists(json, 'hubSiteAssignBy') ? undefined : AssignByFromJSON(json['hubSiteAssignBy']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : CreateSiteRequestFromJSON(json['requestTemplate']),
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

export function CreateSiteServiceToJSON(value?: CreateSiteService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'scopeSettings': ServiceScopeSettingsToJSON(value.scopeSettings),
        'adminCenterUrl': value.adminCenterUrl,
        'siteLanguages': value.siteLanguages === undefined ? undefined : (value.siteLanguages === null ? null : (value.siteLanguages as Array<any>).map(IntModelToJSON)),
        'rootSiteAndManagedPaths': value.rootSiteAndManagedPaths === undefined ? undefined : (value.rootSiteAndManagedPaths === null ? null : (value.rootSiteAndManagedPaths as Array<any>).map(RootSiteWithManagedPathsToJSON)),
        'siteUrlSetting': SiteUrlSettingToJSON(value.siteUrlSetting),
        'multiGeoSetting': MultiGeoSerivceSettingToJSON(value.multiGeoSetting),
        'siteTitleSetting': SiteTitleSettingToJSON(value.siteTitleSetting),
        'policies': value.policies === undefined ? undefined : (value.policies === null ? null : (value.policies as Array<any>).map(PolicyRefToJSON)),
        'deploymentManagerPlanSettings': DeploymentManagerPlanSettingsToJSON(value.deploymentManagerPlanSettings),
        'policyIdsAndTemplates': value.policyIdsAndTemplates === undefined ? undefined : (value.policyIdsAndTemplates === null ? null : (value.policyIdsAndTemplates as Array<any>).map(PolicyWithTemplatesToJSON)),
        'templateIdsAndPermissions': value.templateIdsAndPermissions === undefined ? undefined : (value.templateIdsAndPermissions === null ? null : (value.templateIdsAndPermissions as Array<any>).map(TemplateWithPermissionsToJSON)),
        'permissionSettings': PermissionSettingsToJSON(value.permissionSettings),
        'leasePeriodSettings': SiteLeasePeriodServiceSettingsToJSON(value.leasePeriodSettings),
        'timeZones': value.timeZones === undefined ? undefined : (value.timeZones === null ? null : (value.timeZones as Array<any>).map(IntModelToJSON)),
        'siteDesigns': value.siteDesigns === undefined ? undefined : (value.siteDesigns === null ? null : (value.siteDesigns as Array<any>).map(StringModelToJSON)),
        'siteDesign': GuidModelToJSON(value.siteDesign),
        'defaultTeamSiteDesignId': value.defaultTeamSiteDesignId,
        'siteDesignAssignBy': AssignByToJSON(value.siteDesignAssignBy),
        'yammerGroupSettings': YammerGroupServiceSettingsToJSON(value.yammerGroupSettings),
        'classifications': value.classifications,
        'sensitivities': value.sensitivities,
        'hubSiteSettings': HubSiteSettingsToJSON(value.hubSiteSettings),
        'enabledCustomTemplate': value.enabledCustomTemplate,
        'customSiteTemplateListURL': value.customSiteTemplateListURL,
        'defaultPrimaryAdmin': ApiUserToJSON(value.defaultPrimaryAdmin),
        'defaultAdditionalAdmins': value.defaultAdditionalAdmins === undefined ? undefined : (value.defaultAdditionalAdmins === null ? null : (value.defaultAdditionalAdmins as Array<any>).map(ApiUserToJSON)),
        'defaultPrimaryAdminReal': ApiUserToJSON(value.defaultPrimaryAdminReal),
        'defaultAdditionalAdminsReal': value.defaultAdditionalAdminsReal === undefined ? undefined : (value.defaultAdditionalAdminsReal === null ? null : (value.defaultAdditionalAdminsReal as Array<any>).map(ApiUserToJSON)),
        'defaultPrimaryContact': ApiUserToJSON(value.defaultPrimaryContact),
        'defaultSecondaryContact': ApiUserToJSON(value.defaultSecondaryContact),
        'defaultSiteLanguage': value.defaultSiteLanguage,
        'defaultRootSite': value.defaultRootSite,
        'defaultManagedPath': value.defaultManagedPath,
        'defaultPolicy': value.defaultPolicy,
        'defaultTemplate': value.defaultTemplate,
        'defaultTimeZone': value.defaultTimeZone,
        'defaultClassification': value.defaultClassification,
        'defaultSensitivity': value.defaultSensitivity,
        'defaultDesignType': value.defaultDesignType,
        'siteLanguageAssignBy': AssignByToJSON(value.siteLanguageAssignBy),
        'templateAssignBy': AssignByToJSON(value.templateAssignBy),
        'policyAssignBy': AssignByToJSON(value.policyAssignBy),
        'permissionAssignBy': AssignByToJSON(value.permissionAssignBy),
        'rootSiteAndManagedPathAssignBy': AssignByToJSON(value.rootSiteAndManagedPathAssignBy),
        'timeZoneAssignBy': AssignByToJSON(value.timeZoneAssignBy),
        'primaryAdminAssignBy': AssignByToJSON(value.primaryAdminAssignBy),
        'additionalAdminAssignBy': AssignByToJSON(value.additionalAdminAssignBy),
        'primaryContactAssignBy': AssignByToJSON(value.primaryContactAssignBy),
        'secondaryContactAssignBy': AssignByToJSON(value.secondaryContactAssignBy),
        'designTypeAssignBy': AssignByToJSON(value.designTypeAssignBy),
        'classificationAssignBy': AssignByToJSON(value.classificationAssignBy),
        'sensitivityAssignBy': AssignByToJSON(value.sensitivityAssignBy),
        'hubSiteAssignBy': AssignByToJSON(value.hubSiteAssignBy),
        'requestTemplate': CreateSiteRequestToJSON(value.requestTemplate),
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


