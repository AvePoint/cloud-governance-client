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
    ChangeHubsiteActionType,
    ChangeHubsiteActionTypeFromJSON,
    ChangeHubsiteActionTypeFromJSONTyped,
    ChangeHubsiteActionTypeToJSON,
    DynamicGroupRuleInfo,
    DynamicGroupRuleInfoFromJSON,
    DynamicGroupRuleInfoFromJSONTyped,
    DynamicGroupRuleInfoToJSON,
    GroupMembershipItem,
    GroupMembershipItemFromJSON,
    GroupMembershipItemFromJSONTyped,
    GroupMembershipItemToJSON,
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
    RequestStatus,
    RequestStatusFromJSON,
    RequestStatusFromJSONTyped,
    RequestStatusToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeGroupSettingRequest
 */
export interface ChangeGroupSettingRequest {
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    groupId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    groupEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    groupName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    originalGroupName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    groupDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    originalGroupDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    originalYammerGroupInfo?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingRequest
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingRequest
     */
    originalPrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingRequest
     */
    secondaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingRequest
     */
    originalSecondaryContact?: ApiUser | null;
    /**
     * 
     * @type {Array<GroupMembershipItem>}
     * @memberof ChangeGroupSettingRequest
     */
    groupOwners?: Array<GroupMembershipItem> | null;
    /**
     * 
     * @type {Array<GroupMembershipItem>}
     * @memberof ChangeGroupSettingRequest
     */
    groupMembers?: Array<GroupMembershipItem> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    isDynamicMembership?: boolean;
    /**
     * 
     * @type {Array<DynamicGroupRuleInfo>}
     * @memberof ChangeGroupSettingRequest
     */
    dynamicMembershipRules?: Array<DynamicGroupRuleInfo> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    enabledSubscribe?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    originalEnabledSubscribe?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    enabledOutsideSender?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    originalEnabledOutsideSender?: boolean;
    /**
     * 
     * @type {ChangeHubsiteActionType}
     * @memberof ChangeGroupSettingRequest
     */
    hubSiteActionType?: ChangeHubsiteActionType;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    associateHubSiteId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    associateHubSiteTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    classification?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    originalClassification?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    sensitivity?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    originalSensitivity?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    enableTeams?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    originalEnableTeams?: boolean;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof ChangeGroupSettingRequest
     */
    groupMetadatas?: Array<RequestMetadata> | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof ChangeGroupSettingRequest
     */
    originalGroupMetadata?: Array<RequestMetadata> | null;
    /**
     * 
     * @type {AddGroupMemberType}
     * @memberof ChangeGroupSettingRequest
     */
    changedDynamicGroupType?: AddGroupMemberType;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    yammerGroupInfo?: string | null;
    /**
     * 
     * @type {GroupObjectType}
     * @memberof ChangeGroupSettingRequest
     */
    groupObjectType?: GroupObjectType;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    networkId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    groupObjectId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingRequest
     */
    enableTeamCollaboration?: boolean;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeGroupSettingRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeGroupSettingRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeGroupSettingRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeGroupSettingRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeGroupSettingRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeGroupSettingRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeGroupSettingRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeGroupSettingRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeGroupSettingRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeGroupSettingRequestFromJSON(json: any): ChangeGroupSettingRequest {
    return ChangeGroupSettingRequestFromJSONTyped(json, false);
}

export function ChangeGroupSettingRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupSettingRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupId': !exists(json, 'groupId') ? undefined : json['groupId'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'originalGroupName': !exists(json, 'originalGroupName') ? undefined : json['originalGroupName'],
        'groupDescription': !exists(json, 'groupDescription') ? undefined : json['groupDescription'],
        'originalGroupDescription': !exists(json, 'originalGroupDescription') ? undefined : json['originalGroupDescription'],
        'originalYammerGroupInfo': !exists(json, 'originalYammerGroupInfo') ? undefined : json['originalYammerGroupInfo'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'originalPrimaryContact': !exists(json, 'originalPrimaryContact') ? undefined : ApiUserFromJSON(json['originalPrimaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'originalSecondaryContact': !exists(json, 'originalSecondaryContact') ? undefined : ApiUserFromJSON(json['originalSecondaryContact']),
        'groupOwners': !exists(json, 'groupOwners') ? undefined : (json['groupOwners'] === null ? null : (json['groupOwners'] as Array<any>).map(GroupMembershipItemFromJSON)),
        'groupMembers': !exists(json, 'groupMembers') ? undefined : (json['groupMembers'] === null ? null : (json['groupMembers'] as Array<any>).map(GroupMembershipItemFromJSON)),
        'isDynamicMembership': !exists(json, 'isDynamicMembership') ? undefined : json['isDynamicMembership'],
        'dynamicMembershipRules': !exists(json, 'dynamicMembershipRules') ? undefined : (json['dynamicMembershipRules'] === null ? null : (json['dynamicMembershipRules'] as Array<any>).map(DynamicGroupRuleInfoFromJSON)),
        'enabledSubscribe': !exists(json, 'enabledSubscribe') ? undefined : json['enabledSubscribe'],
        'originalEnabledSubscribe': !exists(json, 'originalEnabledSubscribe') ? undefined : json['originalEnabledSubscribe'],
        'enabledOutsideSender': !exists(json, 'enabledOutsideSender') ? undefined : json['enabledOutsideSender'],
        'originalEnabledOutsideSender': !exists(json, 'originalEnabledOutsideSender') ? undefined : json['originalEnabledOutsideSender'],
        'hubSiteActionType': !exists(json, 'hubSiteActionType') ? undefined : ChangeHubsiteActionTypeFromJSON(json['hubSiteActionType']),
        'associateHubSiteId': !exists(json, 'associateHubSiteId') ? undefined : json['associateHubSiteId'],
        'associateHubSiteTitle': !exists(json, 'associateHubSiteTitle') ? undefined : json['associateHubSiteTitle'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'originalClassification': !exists(json, 'originalClassification') ? undefined : json['originalClassification'],
        'sensitivity': !exists(json, 'sensitivity') ? undefined : json['sensitivity'],
        'originalSensitivity': !exists(json, 'originalSensitivity') ? undefined : json['originalSensitivity'],
        'enableTeams': !exists(json, 'enableTeams') ? undefined : json['enableTeams'],
        'originalEnableTeams': !exists(json, 'originalEnableTeams') ? undefined : json['originalEnableTeams'],
        'groupMetadatas': !exists(json, 'groupMetadatas') ? undefined : (json['groupMetadatas'] === null ? null : (json['groupMetadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'originalGroupMetadata': !exists(json, 'originalGroupMetadata') ? undefined : (json['originalGroupMetadata'] === null ? null : (json['originalGroupMetadata'] as Array<any>).map(RequestMetadataFromJSON)),
        'changedDynamicGroupType': !exists(json, 'changedDynamicGroupType') ? undefined : AddGroupMemberTypeFromJSON(json['changedDynamicGroupType']),
        'yammerGroupInfo': !exists(json, 'yammerGroupInfo') ? undefined : json['yammerGroupInfo'],
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'groupObjectId': !exists(json, 'groupObjectId') ? undefined : json['groupObjectId'],
        'enableTeamCollaboration': !exists(json, 'enableTeamCollaboration') ? undefined : json['enableTeamCollaboration'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'serviceId': !exists(json, 'serviceId') ? undefined : json['serviceId'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
        'notesToApprovers': !exists(json, 'notesToApprovers') ? undefined : json['notesToApprovers'],
        'questionnaireId': !exists(json, 'questionnaireId') ? undefined : json['questionnaireId'],
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'ticketNumber': !exists(json, 'ticketNumber') ? undefined : json['ticketNumber'],
        'type': !exists(json, 'type') ? undefined : ServiceTypeFromJSON(json['type']),
        'typeDescription': !exists(json, 'typeDescription') ? undefined : json['typeDescription'],
        'requester': !exists(json, 'requester') ? undefined : json['requester'],
        'requesterLoginName': !exists(json, 'requesterLoginName') ? undefined : json['requesterLoginName'],
        'status': !exists(json, 'status') ? undefined : RequestStatusFromJSON(json['status']),
        'progressStatus': !exists(json, 'progressStatus') ? undefined : json['progressStatus'],
        'progressStatusDescription': !exists(json, 'progressStatusDescription') ? undefined : json['progressStatusDescription'],
        'submittedTime': !exists(json, 'submittedTime') ? undefined : (json['submittedTime'] === null ? null : new Date(json['submittedTime'])),
        'lastUpdated': !exists(json, 'lastUpdated') ? undefined : (json['lastUpdated'] === null ? null : new Date(json['lastUpdated'])),
        'createdTime': !exists(json, 'createdTime') ? undefined : (json['createdTime'] === null ? null : new Date(json['createdTime'])),
        'assignTo': !exists(json, 'assignTo') ? undefined : json['assignTo'],
        'fullPath': !exists(json, 'fullPath') ? undefined : json['fullPath'],
    };
}

export function ChangeGroupSettingRequestToJSON(value?: ChangeGroupSettingRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupId': value.groupId,
        'groupEmail': value.groupEmail,
        'groupName': value.groupName,
        'originalGroupName': value.originalGroupName,
        'groupDescription': value.groupDescription,
        'originalGroupDescription': value.originalGroupDescription,
        'originalYammerGroupInfo': value.originalYammerGroupInfo,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'originalPrimaryContact': ApiUserToJSON(value.originalPrimaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'originalSecondaryContact': ApiUserToJSON(value.originalSecondaryContact),
        'groupOwners': value.groupOwners === undefined ? undefined : (value.groupOwners === null ? null : (value.groupOwners as Array<any>).map(GroupMembershipItemToJSON)),
        'groupMembers': value.groupMembers === undefined ? undefined : (value.groupMembers === null ? null : (value.groupMembers as Array<any>).map(GroupMembershipItemToJSON)),
        'isDynamicMembership': value.isDynamicMembership,
        'dynamicMembershipRules': value.dynamicMembershipRules === undefined ? undefined : (value.dynamicMembershipRules === null ? null : (value.dynamicMembershipRules as Array<any>).map(DynamicGroupRuleInfoToJSON)),
        'enabledSubscribe': value.enabledSubscribe,
        'originalEnabledSubscribe': value.originalEnabledSubscribe,
        'enabledOutsideSender': value.enabledOutsideSender,
        'originalEnabledOutsideSender': value.originalEnabledOutsideSender,
        'hubSiteActionType': ChangeHubsiteActionTypeToJSON(value.hubSiteActionType),
        'associateHubSiteId': value.associateHubSiteId,
        'associateHubSiteTitle': value.associateHubSiteTitle,
        'classification': value.classification,
        'originalClassification': value.originalClassification,
        'sensitivity': value.sensitivity,
        'originalSensitivity': value.originalSensitivity,
        'enableTeams': value.enableTeams,
        'originalEnableTeams': value.originalEnableTeams,
        'groupMetadatas': value.groupMetadatas === undefined ? undefined : (value.groupMetadatas === null ? null : (value.groupMetadatas as Array<any>).map(RequestMetadataToJSON)),
        'originalGroupMetadata': value.originalGroupMetadata === undefined ? undefined : (value.originalGroupMetadata === null ? null : (value.originalGroupMetadata as Array<any>).map(RequestMetadataToJSON)),
        'changedDynamicGroupType': AddGroupMemberTypeToJSON(value.changedDynamicGroupType),
        'yammerGroupInfo': value.yammerGroupInfo,
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'networkId': value.networkId,
        'groupObjectId': value.groupObjectId,
        'enableTeamCollaboration': value.enableTeamCollaboration,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


