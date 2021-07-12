/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AddGroupMemberType,
    AddGroupMemberTypeFromJSON,
    AddGroupMemberTypeFromJSONTyped,
    AddGroupMemberTypeToJSON,
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    BriefGroupPolicy,
    BriefGroupPolicyFromJSON,
    BriefGroupPolicyFromJSONTyped,
    BriefGroupPolicyToJSON,
    CommonStatus,
    CommonStatusFromJSON,
    CommonStatusFromJSONTyped,
    CommonStatusToJSON,
    CreateGroupRequest,
    CreateGroupRequestFromJSON,
    CreateGroupRequestFromJSONTyped,
    CreateGroupRequestToJSON,
    CreateGroupType,
    CreateGroupTypeFromJSON,
    CreateGroupTypeFromJSONTyped,
    CreateGroupTypeToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    GroupIdConstructureSettings,
    GroupIdConstructureSettingsFromJSON,
    GroupIdConstructureSettingsFromJSONTyped,
    GroupIdConstructureSettingsToJSON,
    GroupNameConstructureSettings,
    GroupNameConstructureSettingsFromJSON,
    GroupNameConstructureSettingsFromJSONTyped,
    GroupNameConstructureSettingsToJSON,
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    HubSiteSettings,
    HubSiteSettingsFromJSON,
    HubSiteSettingsFromJSONTyped,
    HubSiteSettingsToJSON,
    MultiGeoSetting,
    MultiGeoSettingFromJSON,
    MultiGeoSettingFromJSONTyped,
    MultiGeoSettingToJSON,
    ServiceTeamsSettings,
    ServiceTeamsSettingsFromJSON,
    ServiceTeamsSettingsFromJSONTyped,
    ServiceTeamsSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelFromJSONTyped,
    StringModelToJSON,
    TeamsTemplateServiceSettings,
    TeamsTemplateServiceSettingsFromJSON,
    TeamsTemplateServiceSettingsFromJSONTyped,
    TeamsTemplateServiceSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateGroupService
 */
export interface CreateGroupService {
    /**
     * 
     * @type {CreateGroupType}
     * @memberof CreateGroupService
     */
    groupType?: CreateGroupType;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    tenantId?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    networkId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableTeams?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    isPrivate?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableSubscribe?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableApplySiteDesign?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableOutsideSender?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableHideGroupMembership?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableClassification?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    preventDuplicateName?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableSensitivity?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    allowConfigureLeasePeriod?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showNotebookLink?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showConversationsLink?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showFilesLink?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showTeamSiteLink?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showPlannerLink?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showYammerGroupLink?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof CreateGroupService
     */
    classifications?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof CreateGroupService
     */
    sensitivities?: Array<string> | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof CreateGroupService
     */
    siteDesigns?: Array<GuidModel> | null;
    /**
     * 
     * @type {AddGroupMemberType}
     * @memberof CreateGroupService
     */
    addGroupMemberType?: AddGroupMemberType;
    /**
     * 
     * @type {Array<BriefGroupPolicy>}
     * @memberof CreateGroupService
     */
    selectedPolicies?: Array<BriefGroupPolicy> | null;
    /**
     * 
     * @type {Array<StringModel>}
     * @memberof CreateGroupService
     */
    selectedLanguages?: Array<StringModel> | null;
    /**
     * 
     * @type {ServiceTeamsSettings}
     * @memberof CreateGroupService
     */
    teamsSettings?: ServiceTeamsSettings | null;
    /**
     * 
     * @type {GroupNameConstructureSettings}
     * @memberof CreateGroupService
     */
    groupNameConstructureSettings?: GroupNameConstructureSettings | null;
    /**
     * 
     * @type {GroupIdConstructureSettings}
     * @memberof CreateGroupService
     */
    groupIdConstructureSettings?: GroupIdConstructureSettings | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableInstallApp?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableInstallPanel?: boolean;
    /**
     * 
     * @type {TeamsTemplateServiceSettings}
     * @memberof CreateGroupService
     */
    templateSettings?: TeamsTemplateServiceSettings | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGroupService
     */
    defaultPrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGroupService
     */
    defaultSecondaryContact?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGroupService
     */
    defaultOwners?: Array<ApiUser> | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGroupService
     */
    defaultMembers?: Array<ApiUser> | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    defaultPolicy?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    defaultClassification?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    defaultSensitivity?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    defaultLanguage?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    defaultSiteDesign?: string | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGroupService
     */
    defaultOwnersReal?: Array<ApiUser> | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGroupService
     */
    defaultMembersReal?: Array<ApiUser> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGroupService
     */
    defaultPrimaryContactReal?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGroupService
     */
    defaultSecondaryContactReal?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    memberAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    ownerAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    privacyAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    subscribeAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    outsideSenderAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    classificationAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    sensitivityAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    languageAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    secondaryContactAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    primaryContactAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    enableDynamicMembership?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    hideGroupMembershipAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    policyAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    siteDesignAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGroupService
     */
    hubSiteAssignBy?: AssignBy;
    /**
     * 
     * @type {MultiGeoSetting}
     * @memberof CreateGroupService
     */
    multiGeoSetting?: MultiGeoSetting | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    readonly isShowHubSiteSection?: boolean;
    /**
     * Hub site settings model
     * @type {HubSiteSettings}
     * @memberof CreateGroupService
     */
    hubSiteSettings?: HubSiteSettings | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    hasImpernastionUsers?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    peoplePickerFilterProfileId?: string | null;
    /**
     * Create group request model
     * @type {CreateGroupRequest}
     * @memberof CreateGroupService
     */
    requestTemplate?: CreateGroupRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof CreateGroupService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof CreateGroupService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGroupService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGroupService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof CreateGroupService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGroupService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof CreateGroupService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof CreateGroupService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateGroupService
     */
    categoryId?: string | null;
}

export function CreateGroupServiceFromJSON(json: any): CreateGroupService {
    return CreateGroupServiceFromJSONTyped(json, false);
}

export function CreateGroupServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGroupService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupType': !exists(json, 'groupType') ? undefined : CreateGroupTypeFromJSON(json['groupType']),
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'enableTeams': !exists(json, 'enableTeams') ? undefined : json['enableTeams'],
        'isPrivate': !exists(json, 'isPrivate') ? undefined : json['isPrivate'],
        'enableSubscribe': !exists(json, 'enableSubscribe') ? undefined : json['enableSubscribe'],
        'enableApplySiteDesign': !exists(json, 'enableApplySiteDesign') ? undefined : json['enableApplySiteDesign'],
        'enableOutsideSender': !exists(json, 'enableOutsideSender') ? undefined : json['enableOutsideSender'],
        'enableHideGroupMembership': !exists(json, 'enableHideGroupMembership') ? undefined : json['enableHideGroupMembership'],
        'enableClassification': !exists(json, 'enableClassification') ? undefined : json['enableClassification'],
        'preventDuplicateName': !exists(json, 'preventDuplicateName') ? undefined : json['preventDuplicateName'],
        'enableSensitivity': !exists(json, 'enableSensitivity') ? undefined : json['enableSensitivity'],
        'allowConfigureLeasePeriod': !exists(json, 'allowConfigureLeasePeriod') ? undefined : json['allowConfigureLeasePeriod'],
        'showNotebookLink': !exists(json, 'showNotebookLink') ? undefined : json['showNotebookLink'],
        'showConversationsLink': !exists(json, 'showConversationsLink') ? undefined : json['showConversationsLink'],
        'showFilesLink': !exists(json, 'showFilesLink') ? undefined : json['showFilesLink'],
        'showTeamSiteLink': !exists(json, 'showTeamSiteLink') ? undefined : json['showTeamSiteLink'],
        'showPlannerLink': !exists(json, 'showPlannerLink') ? undefined : json['showPlannerLink'],
        'showYammerGroupLink': !exists(json, 'showYammerGroupLink') ? undefined : json['showYammerGroupLink'],
        'classifications': !exists(json, 'classifications') ? undefined : json['classifications'],
        'sensitivities': !exists(json, 'sensitivities') ? undefined : json['sensitivities'],
        'siteDesigns': !exists(json, 'siteDesigns') ? undefined : (json['siteDesigns'] === null ? null : (json['siteDesigns'] as Array<any>).map(GuidModelFromJSON)),
        'addGroupMemberType': !exists(json, 'addGroupMemberType') ? undefined : AddGroupMemberTypeFromJSON(json['addGroupMemberType']),
        'selectedPolicies': !exists(json, 'selectedPolicies') ? undefined : (json['selectedPolicies'] === null ? null : (json['selectedPolicies'] as Array<any>).map(BriefGroupPolicyFromJSON)),
        'selectedLanguages': !exists(json, 'selectedLanguages') ? undefined : (json['selectedLanguages'] === null ? null : (json['selectedLanguages'] as Array<any>).map(StringModelFromJSON)),
        'teamsSettings': !exists(json, 'teamsSettings') ? undefined : ServiceTeamsSettingsFromJSON(json['teamsSettings']),
        'groupNameConstructureSettings': !exists(json, 'groupNameConstructureSettings') ? undefined : GroupNameConstructureSettingsFromJSON(json['groupNameConstructureSettings']),
        'groupIdConstructureSettings': !exists(json, 'groupIdConstructureSettings') ? undefined : GroupIdConstructureSettingsFromJSON(json['groupIdConstructureSettings']),
        'enableInstallApp': !exists(json, 'enableInstallApp') ? undefined : json['enableInstallApp'],
        'enableInstallPanel': !exists(json, 'enableInstallPanel') ? undefined : json['enableInstallPanel'],
        'templateSettings': !exists(json, 'templateSettings') ? undefined : TeamsTemplateServiceSettingsFromJSON(json['templateSettings']),
        'defaultPrimaryContact': !exists(json, 'defaultPrimaryContact') ? undefined : ApiUserFromJSON(json['defaultPrimaryContact']),
        'defaultSecondaryContact': !exists(json, 'defaultSecondaryContact') ? undefined : ApiUserFromJSON(json['defaultSecondaryContact']),
        'defaultOwners': !exists(json, 'defaultOwners') ? undefined : (json['defaultOwners'] === null ? null : (json['defaultOwners'] as Array<any>).map(ApiUserFromJSON)),
        'defaultMembers': !exists(json, 'defaultMembers') ? undefined : (json['defaultMembers'] === null ? null : (json['defaultMembers'] as Array<any>).map(ApiUserFromJSON)),
        'defaultPolicy': !exists(json, 'defaultPolicy') ? undefined : json['defaultPolicy'],
        'defaultClassification': !exists(json, 'defaultClassification') ? undefined : json['defaultClassification'],
        'defaultSensitivity': !exists(json, 'defaultSensitivity') ? undefined : json['defaultSensitivity'],
        'defaultLanguage': !exists(json, 'defaultLanguage') ? undefined : json['defaultLanguage'],
        'defaultSiteDesign': !exists(json, 'defaultSiteDesign') ? undefined : json['defaultSiteDesign'],
        'defaultOwnersReal': !exists(json, 'defaultOwnersReal') ? undefined : (json['defaultOwnersReal'] === null ? null : (json['defaultOwnersReal'] as Array<any>).map(ApiUserFromJSON)),
        'defaultMembersReal': !exists(json, 'defaultMembersReal') ? undefined : (json['defaultMembersReal'] === null ? null : (json['defaultMembersReal'] as Array<any>).map(ApiUserFromJSON)),
        'defaultPrimaryContactReal': !exists(json, 'defaultPrimaryContactReal') ? undefined : ApiUserFromJSON(json['defaultPrimaryContactReal']),
        'defaultSecondaryContactReal': !exists(json, 'defaultSecondaryContactReal') ? undefined : ApiUserFromJSON(json['defaultSecondaryContactReal']),
        'memberAssignBy': !exists(json, 'memberAssignBy') ? undefined : AssignByFromJSON(json['memberAssignBy']),
        'ownerAssignBy': !exists(json, 'ownerAssignBy') ? undefined : AssignByFromJSON(json['ownerAssignBy']),
        'privacyAssignBy': !exists(json, 'privacyAssignBy') ? undefined : AssignByFromJSON(json['privacyAssignBy']),
        'subscribeAssignBy': !exists(json, 'subscribeAssignBy') ? undefined : AssignByFromJSON(json['subscribeAssignBy']),
        'outsideSenderAssignBy': !exists(json, 'outsideSenderAssignBy') ? undefined : AssignByFromJSON(json['outsideSenderAssignBy']),
        'classificationAssignBy': !exists(json, 'classificationAssignBy') ? undefined : AssignByFromJSON(json['classificationAssignBy']),
        'sensitivityAssignBy': !exists(json, 'sensitivityAssignBy') ? undefined : AssignByFromJSON(json['sensitivityAssignBy']),
        'languageAssignBy': !exists(json, 'languageAssignBy') ? undefined : AssignByFromJSON(json['languageAssignBy']),
        'secondaryContactAssignBy': !exists(json, 'secondaryContactAssignBy') ? undefined : AssignByFromJSON(json['secondaryContactAssignBy']),
        'primaryContactAssignBy': !exists(json, 'primaryContactAssignBy') ? undefined : AssignByFromJSON(json['primaryContactAssignBy']),
        'enableDynamicMembership': !exists(json, 'enableDynamicMembership') ? undefined : json['enableDynamicMembership'],
        'hideGroupMembershipAssignBy': !exists(json, 'hideGroupMembershipAssignBy') ? undefined : AssignByFromJSON(json['hideGroupMembershipAssignBy']),
        'policyAssignBy': !exists(json, 'policyAssignBy') ? undefined : AssignByFromJSON(json['policyAssignBy']),
        'siteDesignAssignBy': !exists(json, 'siteDesignAssignBy') ? undefined : AssignByFromJSON(json['siteDesignAssignBy']),
        'hubSiteAssignBy': !exists(json, 'hubSiteAssignBy') ? undefined : AssignByFromJSON(json['hubSiteAssignBy']),
        'multiGeoSetting': !exists(json, 'multiGeoSetting') ? undefined : MultiGeoSettingFromJSON(json['multiGeoSetting']),
        'isShowHubSiteSection': !exists(json, 'isShowHubSiteSection') ? undefined : json['isShowHubSiteSection'],
        'hubSiteSettings': !exists(json, 'hubSiteSettings') ? undefined : HubSiteSettingsFromJSON(json['hubSiteSettings']),
        'hasImpernastionUsers': !exists(json, 'hasImpernastionUsers') ? undefined : json['hasImpernastionUsers'],
        'peoplePickerFilterProfileId': !exists(json, 'peoplePickerFilterProfileId') ? undefined : json['peoplePickerFilterProfileId'],
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : CreateGroupRequestFromJSON(json['requestTemplate']),
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

export function CreateGroupServiceToJSON(value?: CreateGroupService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupType': CreateGroupTypeToJSON(value.groupType),
        'tenantId': value.tenantId,
        'networkId': value.networkId,
        'enableTeams': value.enableTeams,
        'isPrivate': value.isPrivate,
        'enableSubscribe': value.enableSubscribe,
        'enableApplySiteDesign': value.enableApplySiteDesign,
        'enableOutsideSender': value.enableOutsideSender,
        'enableHideGroupMembership': value.enableHideGroupMembership,
        'enableClassification': value.enableClassification,
        'preventDuplicateName': value.preventDuplicateName,
        'enableSensitivity': value.enableSensitivity,
        'allowConfigureLeasePeriod': value.allowConfigureLeasePeriod,
        'showNotebookLink': value.showNotebookLink,
        'showConversationsLink': value.showConversationsLink,
        'showFilesLink': value.showFilesLink,
        'showTeamSiteLink': value.showTeamSiteLink,
        'showPlannerLink': value.showPlannerLink,
        'showYammerGroupLink': value.showYammerGroupLink,
        'classifications': value.classifications,
        'sensitivities': value.sensitivities,
        'siteDesigns': value.siteDesigns === undefined ? undefined : (value.siteDesigns === null ? null : (value.siteDesigns as Array<any>).map(GuidModelToJSON)),
        'addGroupMemberType': AddGroupMemberTypeToJSON(value.addGroupMemberType),
        'selectedPolicies': value.selectedPolicies === undefined ? undefined : (value.selectedPolicies === null ? null : (value.selectedPolicies as Array<any>).map(BriefGroupPolicyToJSON)),
        'selectedLanguages': value.selectedLanguages === undefined ? undefined : (value.selectedLanguages === null ? null : (value.selectedLanguages as Array<any>).map(StringModelToJSON)),
        'teamsSettings': ServiceTeamsSettingsToJSON(value.teamsSettings),
        'groupNameConstructureSettings': GroupNameConstructureSettingsToJSON(value.groupNameConstructureSettings),
        'groupIdConstructureSettings': GroupIdConstructureSettingsToJSON(value.groupIdConstructureSettings),
        'enableInstallApp': value.enableInstallApp,
        'enableInstallPanel': value.enableInstallPanel,
        'templateSettings': TeamsTemplateServiceSettingsToJSON(value.templateSettings),
        'defaultPrimaryContact': ApiUserToJSON(value.defaultPrimaryContact),
        'defaultSecondaryContact': ApiUserToJSON(value.defaultSecondaryContact),
        'defaultOwners': value.defaultOwners === undefined ? undefined : (value.defaultOwners === null ? null : (value.defaultOwners as Array<any>).map(ApiUserToJSON)),
        'defaultMembers': value.defaultMembers === undefined ? undefined : (value.defaultMembers === null ? null : (value.defaultMembers as Array<any>).map(ApiUserToJSON)),
        'defaultPolicy': value.defaultPolicy,
        'defaultClassification': value.defaultClassification,
        'defaultSensitivity': value.defaultSensitivity,
        'defaultLanguage': value.defaultLanguage,
        'defaultSiteDesign': value.defaultSiteDesign,
        'defaultOwnersReal': value.defaultOwnersReal === undefined ? undefined : (value.defaultOwnersReal === null ? null : (value.defaultOwnersReal as Array<any>).map(ApiUserToJSON)),
        'defaultMembersReal': value.defaultMembersReal === undefined ? undefined : (value.defaultMembersReal === null ? null : (value.defaultMembersReal as Array<any>).map(ApiUserToJSON)),
        'defaultPrimaryContactReal': ApiUserToJSON(value.defaultPrimaryContactReal),
        'defaultSecondaryContactReal': ApiUserToJSON(value.defaultSecondaryContactReal),
        'memberAssignBy': AssignByToJSON(value.memberAssignBy),
        'ownerAssignBy': AssignByToJSON(value.ownerAssignBy),
        'privacyAssignBy': AssignByToJSON(value.privacyAssignBy),
        'subscribeAssignBy': AssignByToJSON(value.subscribeAssignBy),
        'outsideSenderAssignBy': AssignByToJSON(value.outsideSenderAssignBy),
        'classificationAssignBy': AssignByToJSON(value.classificationAssignBy),
        'sensitivityAssignBy': AssignByToJSON(value.sensitivityAssignBy),
        'languageAssignBy': AssignByToJSON(value.languageAssignBy),
        'secondaryContactAssignBy': AssignByToJSON(value.secondaryContactAssignBy),
        'primaryContactAssignBy': AssignByToJSON(value.primaryContactAssignBy),
        'enableDynamicMembership': value.enableDynamicMembership,
        'hideGroupMembershipAssignBy': AssignByToJSON(value.hideGroupMembershipAssignBy),
        'policyAssignBy': AssignByToJSON(value.policyAssignBy),
        'siteDesignAssignBy': AssignByToJSON(value.siteDesignAssignBy),
        'hubSiteAssignBy': AssignByToJSON(value.hubSiteAssignBy),
        'multiGeoSetting': MultiGeoSettingToJSON(value.multiGeoSetting),
        'hubSiteSettings': HubSiteSettingsToJSON(value.hubSiteSettings),
        'hasImpernastionUsers': value.hasImpernastionUsers,
        'peoplePickerFilterProfileId': value.peoplePickerFilterProfileId,
        'requestTemplate': CreateGroupRequestToJSON(value.requestTemplate),
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


