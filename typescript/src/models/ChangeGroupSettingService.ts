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
    ChangeGroupSettingRequest,
    ChangeGroupSettingRequestFromJSON,
    ChangeGroupSettingRequestFromJSONTyped,
    ChangeGroupSettingRequestToJSON,
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
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    GroupRestrictionType,
    GroupRestrictionTypeFromJSON,
    GroupRestrictionTypeFromJSONTyped,
    GroupRestrictionTypeToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    UserLevelRestrictionType,
    UserLevelRestrictionTypeFromJSON,
    UserLevelRestrictionTypeFromJSONTyped,
    UserLevelRestrictionTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeGroupSettingService
 */
export interface ChangeGroupSettingService {
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    tenantId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    networkId?: string | null;
    /**
     * 
     * @type {GroupRestrictionType}
     * @memberof ChangeGroupSettingService
     */
    groupRestriction?: GroupRestrictionType;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeName?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    preventDuplicateName?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeDescription?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeMemberSubscription?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeOutsideSenders?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangePrimaryContact?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeSecondaryContact?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableAddOwners?: boolean;
    /**
     * 
     * @type {UserLevelRestrictionType}
     * @memberof ChangeGroupSettingService
     */
    addOwnerRestriction?: UserLevelRestrictionType;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableRemoveOwners?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableAddMembers?: boolean;
    /**
     * 
     * @type {UserLevelRestrictionType}
     * @memberof ChangeGroupSettingService
     */
    addMemberRestriction?: UserLevelRestrictionType;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableRemoveMembers?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeDynamicMembershipRules?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeTeamCollaboration?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeHubSite?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeClassification?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof ChangeGroupSettingService
     */
    classificationList?: Array<string> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeSensitivity?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof ChangeGroupSettingService
     */
    sensitivityList?: Array<string> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeMetadata?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableAddOrDeleteMetadata?: boolean;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeGroupSettingService
     */
    metadataList?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeMembershipType?: boolean;
    /**
     * 
     * @type {GroupObjectType}
     * @memberof ChangeGroupSettingService
     */
    groupObjectType?: GroupObjectType;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    enableChangeYammerGroupInfo?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    scopePeoplePickerFilterProfileId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    peoplePickerFilterProfileId?: string | null;
    /**
     * 
     * @type {ChangeGroupSettingRequest}
     * @memberof ChangeGroupSettingService
     */
    requestTemplate?: ChangeGroupSettingRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeGroupSettingService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ChangeGroupSettingService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ChangeGroupSettingService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof ChangeGroupSettingService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof ChangeGroupSettingService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingService
     */
    categoryId?: string | null;
}

export function ChangeGroupSettingServiceFromJSON(json: any): ChangeGroupSettingService {
    return ChangeGroupSettingServiceFromJSONTyped(json, false);
}

export function ChangeGroupSettingServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupSettingService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'groupRestriction': !exists(json, 'groupRestriction') ? undefined : GroupRestrictionTypeFromJSON(json['groupRestriction']),
        'enableChangeName': !exists(json, 'enableChangeName') ? undefined : json['enableChangeName'],
        'preventDuplicateName': !exists(json, 'preventDuplicateName') ? undefined : json['preventDuplicateName'],
        'enableChangeDescription': !exists(json, 'enableChangeDescription') ? undefined : json['enableChangeDescription'],
        'enableChangeMemberSubscription': !exists(json, 'enableChangeMemberSubscription') ? undefined : json['enableChangeMemberSubscription'],
        'enableChangeOutsideSenders': !exists(json, 'enableChangeOutsideSenders') ? undefined : json['enableChangeOutsideSenders'],
        'enableChangePrimaryContact': !exists(json, 'enableChangePrimaryContact') ? undefined : json['enableChangePrimaryContact'],
        'enableChangeSecondaryContact': !exists(json, 'enableChangeSecondaryContact') ? undefined : json['enableChangeSecondaryContact'],
        'enableAddOwners': !exists(json, 'enableAddOwners') ? undefined : json['enableAddOwners'],
        'addOwnerRestriction': !exists(json, 'addOwnerRestriction') ? undefined : UserLevelRestrictionTypeFromJSON(json['addOwnerRestriction']),
        'enableRemoveOwners': !exists(json, 'enableRemoveOwners') ? undefined : json['enableRemoveOwners'],
        'enableAddMembers': !exists(json, 'enableAddMembers') ? undefined : json['enableAddMembers'],
        'addMemberRestriction': !exists(json, 'addMemberRestriction') ? undefined : UserLevelRestrictionTypeFromJSON(json['addMemberRestriction']),
        'enableRemoveMembers': !exists(json, 'enableRemoveMembers') ? undefined : json['enableRemoveMembers'],
        'enableChangeDynamicMembershipRules': !exists(json, 'enableChangeDynamicMembershipRules') ? undefined : json['enableChangeDynamicMembershipRules'],
        'enableChangeTeamCollaboration': !exists(json, 'enableChangeTeamCollaboration') ? undefined : json['enableChangeTeamCollaboration'],
        'enableChangeHubSite': !exists(json, 'enableChangeHubSite') ? undefined : json['enableChangeHubSite'],
        'enableChangeClassification': !exists(json, 'enableChangeClassification') ? undefined : json['enableChangeClassification'],
        'classificationList': !exists(json, 'classificationList') ? undefined : json['classificationList'],
        'enableChangeSensitivity': !exists(json, 'enableChangeSensitivity') ? undefined : json['enableChangeSensitivity'],
        'sensitivityList': !exists(json, 'sensitivityList') ? undefined : json['sensitivityList'],
        'enableChangeMetadata': !exists(json, 'enableChangeMetadata') ? undefined : json['enableChangeMetadata'],
        'enableAddOrDeleteMetadata': !exists(json, 'enableAddOrDeleteMetadata') ? undefined : json['enableAddOrDeleteMetadata'],
        'metadataList': !exists(json, 'metadataList') ? undefined : (json['metadataList'] === null ? null : (json['metadataList'] as Array<any>).map(CustomMetadataFromJSON)),
        'enableChangeMembershipType': !exists(json, 'enableChangeMembershipType') ? undefined : json['enableChangeMembershipType'],
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
        'enableChangeYammerGroupInfo': !exists(json, 'enableChangeYammerGroupInfo') ? undefined : json['enableChangeYammerGroupInfo'],
        'scopePeoplePickerFilterProfileId': !exists(json, 'scopePeoplePickerFilterProfileId') ? undefined : json['scopePeoplePickerFilterProfileId'],
        'peoplePickerFilterProfileId': !exists(json, 'peoplePickerFilterProfileId') ? undefined : json['peoplePickerFilterProfileId'],
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : ChangeGroupSettingRequestFromJSON(json['requestTemplate']),
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

export function ChangeGroupSettingServiceToJSON(value?: ChangeGroupSettingService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'tenantId': value.tenantId,
        'networkId': value.networkId,
        'groupRestriction': GroupRestrictionTypeToJSON(value.groupRestriction),
        'enableChangeName': value.enableChangeName,
        'preventDuplicateName': value.preventDuplicateName,
        'enableChangeDescription': value.enableChangeDescription,
        'enableChangeMemberSubscription': value.enableChangeMemberSubscription,
        'enableChangeOutsideSenders': value.enableChangeOutsideSenders,
        'enableChangePrimaryContact': value.enableChangePrimaryContact,
        'enableChangeSecondaryContact': value.enableChangeSecondaryContact,
        'enableAddOwners': value.enableAddOwners,
        'addOwnerRestriction': UserLevelRestrictionTypeToJSON(value.addOwnerRestriction),
        'enableRemoveOwners': value.enableRemoveOwners,
        'enableAddMembers': value.enableAddMembers,
        'addMemberRestriction': UserLevelRestrictionTypeToJSON(value.addMemberRestriction),
        'enableRemoveMembers': value.enableRemoveMembers,
        'enableChangeDynamicMembershipRules': value.enableChangeDynamicMembershipRules,
        'enableChangeTeamCollaboration': value.enableChangeTeamCollaboration,
        'enableChangeHubSite': value.enableChangeHubSite,
        'enableChangeClassification': value.enableChangeClassification,
        'classificationList': value.classificationList,
        'enableChangeSensitivity': value.enableChangeSensitivity,
        'sensitivityList': value.sensitivityList,
        'enableChangeMetadata': value.enableChangeMetadata,
        'enableAddOrDeleteMetadata': value.enableAddOrDeleteMetadata,
        'metadataList': value.metadataList === undefined ? undefined : (value.metadataList === null ? null : (value.metadataList as Array<any>).map(CustomMetadataToJSON)),
        'enableChangeMembershipType': value.enableChangeMembershipType,
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'enableChangeYammerGroupInfo': value.enableChangeYammerGroupInfo,
        'scopePeoplePickerFilterProfileId': value.scopePeoplePickerFilterProfileId,
        'peoplePickerFilterProfileId': value.peoplePickerFilterProfileId,
        'requestTemplate': ChangeGroupSettingRequestToJSON(value.requestTemplate),
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


