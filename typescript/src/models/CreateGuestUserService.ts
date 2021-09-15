/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiDurationType,
    ApiDurationTypeFromJSON,
    ApiDurationTypeFromJSONTyped,
    ApiDurationTypeToJSON,
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
    CreateGuestUserRequest,
    CreateGuestUserRequestFromJSON,
    CreateGuestUserRequestFromJSONTyped,
    CreateGuestUserRequestToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    ExternalDomainListType,
    ExternalDomainListTypeFromJSON,
    ExternalDomainListTypeFromJSONTyped,
    ExternalDomainListTypeToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateGuestUserService
 */
export interface CreateGuestUserService {
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    tenantId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableInviteOwnersGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableInviteContactGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableAddToGroups?: boolean;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    primaryContact?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    primaryContactAssignBy?: AssignBy;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    secondaryContactAssignBy?: AssignBy;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    manager?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    managerAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableOnTimeRenewal?: boolean;
    /**
     * 
     * @type {number}
     * @memberof CreateGuestUserService
     */
    oneTimeDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof CreateGuestUserService
     */
    oneTimeDurationType?: ApiDurationType;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    peoplePickerFilterProfileId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableDomainList?: boolean;
    /**
     * 
     * @type {ExternalDomainListType}
     * @memberof CreateGuestUserService
     */
    domainListType?: ExternalDomainListType;
    /**
     * 
     * @type {Array<string>}
     * @memberof CreateGuestUserService
     */
    domains?: Array<string> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    usageLocationAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    jobTitleAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    jobDepartmentAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    welcomeEmailMessageAssignBy?: AssignBy;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    usageLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    jobTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    jobDepartment?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    welcomeEmailMessage?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    displayNameAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    firstNameAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    lastNameAssignBy?: AssignBy;
    /**
     * 
     * @type {CreateGuestUserRequest}
     * @memberof CreateGuestUserService
     */
    requestTemplate?: CreateGuestUserRequest | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableInviteMultiple?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    companyName?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    companyNameAssignBy?: AssignBy;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof CreateGuestUserService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof CreateGuestUserService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof CreateGuestUserService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof CreateGuestUserService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof CreateGuestUserService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    categoryId?: string | null;
}

export function CreateGuestUserServiceFromJSON(json: any): CreateGuestUserService {
    return CreateGuestUserServiceFromJSONTyped(json, false);
}

export function CreateGuestUserServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGuestUserService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'enableInviteOwnersGroup': !exists(json, 'enableInviteOwnersGroup') ? undefined : json['enableInviteOwnersGroup'],
        'enableInviteContactGroup': !exists(json, 'enableInviteContactGroup') ? undefined : json['enableInviteContactGroup'],
        'enableAddToGroups': !exists(json, 'enableAddToGroups') ? undefined : json['enableAddToGroups'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'primaryContactAssignBy': !exists(json, 'primaryContactAssignBy') ? undefined : AssignByFromJSON(json['primaryContactAssignBy']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'secondaryContactAssignBy': !exists(json, 'secondaryContactAssignBy') ? undefined : AssignByFromJSON(json['secondaryContactAssignBy']),
        'manager': !exists(json, 'manager') ? undefined : ApiUserFromJSON(json['manager']),
        'managerAssignBy': !exists(json, 'managerAssignBy') ? undefined : AssignByFromJSON(json['managerAssignBy']),
        'enableOnTimeRenewal': !exists(json, 'enableOnTimeRenewal') ? undefined : json['enableOnTimeRenewal'],
        'oneTimeDuration': !exists(json, 'oneTimeDuration') ? undefined : json['oneTimeDuration'],
        'oneTimeDurationType': !exists(json, 'oneTimeDurationType') ? undefined : ApiDurationTypeFromJSON(json['oneTimeDurationType']),
        'peoplePickerFilterProfileId': !exists(json, 'peoplePickerFilterProfileId') ? undefined : json['peoplePickerFilterProfileId'],
        'enableDomainList': !exists(json, 'enableDomainList') ? undefined : json['enableDomainList'],
        'domainListType': !exists(json, 'domainListType') ? undefined : ExternalDomainListTypeFromJSON(json['domainListType']),
        'domains': !exists(json, 'domains') ? undefined : json['domains'],
        'usageLocationAssignBy': !exists(json, 'usageLocationAssignBy') ? undefined : AssignByFromJSON(json['usageLocationAssignBy']),
        'jobTitleAssignBy': !exists(json, 'jobTitleAssignBy') ? undefined : AssignByFromJSON(json['jobTitleAssignBy']),
        'jobDepartmentAssignBy': !exists(json, 'jobDepartmentAssignBy') ? undefined : AssignByFromJSON(json['jobDepartmentAssignBy']),
        'welcomeEmailMessageAssignBy': !exists(json, 'welcomeEmailMessageAssignBy') ? undefined : AssignByFromJSON(json['welcomeEmailMessageAssignBy']),
        'usageLocation': !exists(json, 'usageLocation') ? undefined : json['usageLocation'],
        'jobTitle': !exists(json, 'jobTitle') ? undefined : json['jobTitle'],
        'jobDepartment': !exists(json, 'jobDepartment') ? undefined : json['jobDepartment'],
        'welcomeEmailMessage': !exists(json, 'welcomeEmailMessage') ? undefined : json['welcomeEmailMessage'],
        'displayNameAssignBy': !exists(json, 'displayNameAssignBy') ? undefined : AssignByFromJSON(json['displayNameAssignBy']),
        'firstNameAssignBy': !exists(json, 'firstNameAssignBy') ? undefined : AssignByFromJSON(json['firstNameAssignBy']),
        'lastNameAssignBy': !exists(json, 'lastNameAssignBy') ? undefined : AssignByFromJSON(json['lastNameAssignBy']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : CreateGuestUserRequestFromJSON(json['requestTemplate']),
        'enableInviteMultiple': !exists(json, 'enableInviteMultiple') ? undefined : json['enableInviteMultiple'],
        'companyName': !exists(json, 'companyName') ? undefined : json['companyName'],
        'companyNameAssignBy': !exists(json, 'companyNameAssignBy') ? undefined : AssignByFromJSON(json['companyNameAssignBy']),
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

export function CreateGuestUserServiceToJSON(value?: CreateGuestUserService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'tenantId': value.tenantId,
        'enableInviteOwnersGroup': value.enableInviteOwnersGroup,
        'enableInviteContactGroup': value.enableInviteContactGroup,
        'enableAddToGroups': value.enableAddToGroups,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'primaryContactAssignBy': AssignByToJSON(value.primaryContactAssignBy),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'secondaryContactAssignBy': AssignByToJSON(value.secondaryContactAssignBy),
        'manager': ApiUserToJSON(value.manager),
        'managerAssignBy': AssignByToJSON(value.managerAssignBy),
        'enableOnTimeRenewal': value.enableOnTimeRenewal,
        'oneTimeDuration': value.oneTimeDuration,
        'oneTimeDurationType': ApiDurationTypeToJSON(value.oneTimeDurationType),
        'peoplePickerFilterProfileId': value.peoplePickerFilterProfileId,
        'enableDomainList': value.enableDomainList,
        'domainListType': ExternalDomainListTypeToJSON(value.domainListType),
        'domains': value.domains,
        'usageLocationAssignBy': AssignByToJSON(value.usageLocationAssignBy),
        'jobTitleAssignBy': AssignByToJSON(value.jobTitleAssignBy),
        'jobDepartmentAssignBy': AssignByToJSON(value.jobDepartmentAssignBy),
        'welcomeEmailMessageAssignBy': AssignByToJSON(value.welcomeEmailMessageAssignBy),
        'usageLocation': value.usageLocation,
        'jobTitle': value.jobTitle,
        'jobDepartment': value.jobDepartment,
        'welcomeEmailMessage': value.welcomeEmailMessage,
        'displayNameAssignBy': AssignByToJSON(value.displayNameAssignBy),
        'firstNameAssignBy': AssignByToJSON(value.firstNameAssignBy),
        'lastNameAssignBy': AssignByToJSON(value.lastNameAssignBy),
        'requestTemplate': CreateGuestUserRequestToJSON(value.requestTemplate),
        'enableInviteMultiple': value.enableInviteMultiple,
        'companyName': value.companyName,
        'companyNameAssignBy': AssignByToJSON(value.companyNameAssignBy),
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


