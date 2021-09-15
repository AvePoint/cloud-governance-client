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
    CreateGroupType,
    CreateGroupTypeFromJSON,
    CreateGroupTypeFromJSONTyped,
    CreateGroupTypeToJSON,
    DynamicGroupRuleInfo,
    DynamicGroupRuleInfoFromJSON,
    DynamicGroupRuleInfoFromJSONTyped,
    DynamicGroupRuleInfoToJSON,
    GeoLocationBase,
    GeoLocationBaseFromJSON,
    GeoLocationBaseFromJSONTyped,
    GeoLocationBaseToJSON,
    GroupLeasePeriodSettings,
    GroupLeasePeriodSettingsFromJSON,
    GroupLeasePeriodSettingsFromJSONTyped,
    GroupLeasePeriodSettingsToJSON,
    GroupLinks,
    GroupLinksFromJSON,
    GroupLinksFromJSONTyped,
    GroupLinksToJSON,
    HubSiteSettings,
    HubSiteSettingsFromJSON,
    HubSiteSettingsFromJSONTyped,
    HubSiteSettingsToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
    RequestStatus,
    RequestStatusFromJSON,
    RequestStatusFromJSONTyped,
    RequestStatusToJSON,
    RequestTeamsSettings,
    RequestTeamsSettingsFromJSON,
    RequestTeamsSettingsFromJSONTyped,
    RequestTeamsSettingsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    TeamsTemplateSettings,
    TeamsTemplateSettingsFromJSON,
    TeamsTemplateSettingsFromJSONTyped,
    TeamsTemplateSettingsToJSON,
} from './';

/**
 * Create group request model
 * @export
 * @interface CreateGroupRequest
 */
export interface CreateGroupRequest {
    /**
     * Group type
     * @type {CreateGroupType}
     * @memberof CreateGroupRequest
     */
    groupType?: CreateGroupType;
    /**
     * An entire group ID
     * @type {string}
     * @memberof CreateGroupRequest
     */
    groupId?: string | null;
    /**
     * Group ID (without prefix and suffix)
     * @type {string}
     * @memberof CreateGroupRequest
     */
    groupIdWithoutPrefixSuffix?: string | null;
    /**
     * An entire group name
     * @type {string}
     * @memberof CreateGroupRequest
     */
    groupName?: string | null;
    /**
     * Group name (without prefix and suffix)
     * @type {string}
     * @memberof CreateGroupRequest
     */
    groupNameWithoutPrefixSuffix?: string | null;
    /**
     * Group e-mail address
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly groupEmail?: string | null;
    /**
     * The ID of a group policy. You can get IDs and names of all available policies by invoking the GetCreateGroupServiceApi.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    policy?: string;
    /**
     * Group description
     * @type {string}
     * @memberof CreateGroupRequest
     */
    groupDescription?: string | null;
    /**
     * Group owners
     * @type {Array<ApiUser>}
     * @memberof CreateGroupRequest
     */
    owners?: Array<ApiUser> | null;
    /**
     * Group members
     * @type {Array<ApiUser>}
     * @memberof CreateGroupRequest
     */
    members?: Array<ApiUser> | null;
    /**
     * The privacy settings of a group. Whether to allow anyone can see group content or only allow members to see group content.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    privacy?: boolean;
    /**
     * Whether to allow group members to receive copies of group conversations and events.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    subscribe?: boolean;
    /**
     * Whether to allow users outside the organization to send e-mails to groups.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    outsideSender?: boolean;
    /**
     * Enable a team for the group.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    enableTeamCollaboration?: boolean;
    /**
     * The language of a group. You can get IDs and names of all available languages by invoking the GetCreateGroupServiceApi.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    language?: string | null;
    /**
     * Group classification
     * @type {string}
     * @memberof CreateGroupRequest
     */
    classification?: string | null;
    /**
     * Group sensitive lable
     * @type {string}
     * @memberof CreateGroupRequest
     */
    sensitivity?: string | null;
    /**
     * Links of the group related objects. You can get IDs and names of all group related objects by invoking the GetCreateGroupServiceApi.
     * @type {GroupLinks}
     * @memberof CreateGroupRequest
     */
    readonly links?: GroupLinks | null;
    /**
     * Group lease period settings
     * @type {GroupLeasePeriodSettings}
     * @memberof CreateGroupRequest
     */
    leasePeriodSettings?: GroupLeasePeriodSettings | null;
    /**
     * Team members permission settings
     * @type {RequestTeamsSettings}
     * @memberof CreateGroupRequest
     */
    teamsSettings?: RequestTeamsSettings | null;
    /**
     * The ID of the group team site design. You can get IDs and names of all group team sites by invoking the GetCreateGroupServiceApi.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    appliedSiteDesignId?: string | null;
    /**
     * Primary group contact
     * @type {ApiUser}
     * @memberof CreateGroupRequest
     */
    primaryContact?: ApiUser | null;
    /**
     * Secondary group contact
     * @type {ApiUser}
     * @memberof CreateGroupRequest
     */
    secondaryContact?: ApiUser | null;
    /**
     * Whether to hide the group members from users who are not members of the group.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    enableGroupMembershipHidden?: boolean;
    /**
     * Whether to allow to copy team members from existing teams.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    enableAssignedMembership?: boolean;
    /**
     * Whether to use dynamic membership rules to get group members.
     * @type {boolean}
     * @memberof CreateGroupRequest
     */
    enableDynamicMembership?: boolean;
    /**
     * Teams template settings
     * @type {TeamsTemplateSettings}
     * @memberof CreateGroupRequest
     */
    templateSettings?: TeamsTemplateSettings | null;
    /**
     * Dynamic group membership rules
     * @type {Array<DynamicGroupRuleInfo>}
     * @memberof CreateGroupRequest
     */
    dynamicMembershipRules?: Array<DynamicGroupRuleInfo> | null;
    /**
     * Multi-geo locations settings
     * @type {GeoLocationBase}
     * @memberof CreateGroupRequest
     */
    multiGeoLocation?: GeoLocationBase | null;
    /**
     * Hub site settings
     * @type {HubSiteSettings}
     * @memberof CreateGroupRequest
     */
    hubSiteSettings?: HubSiteSettings | null;
    /**
     * Yammer community info
     * @type {string}
     * @memberof CreateGroupRequest
     */
    yammerGroupInfo?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof CreateGroupRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof CreateGroupRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof CreateGroupRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof CreateGroupRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof CreateGroupRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof CreateGroupRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof CreateGroupRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof CreateGroupRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof CreateGroupRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof CreateGroupRequest
     */
    readonly fullPath?: string | null;
}

export function CreateGroupRequestFromJSON(json: any): CreateGroupRequest {
    return CreateGroupRequestFromJSONTyped(json, false);
}

export function CreateGroupRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGroupRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupType': !exists(json, 'groupType') ? undefined : CreateGroupTypeFromJSON(json['groupType']),
        'groupId': !exists(json, 'groupId') ? undefined : json['groupId'],
        'groupIdWithoutPrefixSuffix': !exists(json, 'groupIdWithoutPrefixSuffix') ? undefined : json['groupIdWithoutPrefixSuffix'],
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'groupNameWithoutPrefixSuffix': !exists(json, 'groupNameWithoutPrefixSuffix') ? undefined : json['groupNameWithoutPrefixSuffix'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'policy': !exists(json, 'policy') ? undefined : json['policy'],
        'groupDescription': !exists(json, 'groupDescription') ? undefined : json['groupDescription'],
        'owners': !exists(json, 'owners') ? undefined : (json['owners'] === null ? null : (json['owners'] as Array<any>).map(ApiUserFromJSON)),
        'members': !exists(json, 'members') ? undefined : (json['members'] === null ? null : (json['members'] as Array<any>).map(ApiUserFromJSON)),
        'privacy': !exists(json, 'privacy') ? undefined : json['privacy'],
        'subscribe': !exists(json, 'subscribe') ? undefined : json['subscribe'],
        'outsideSender': !exists(json, 'outsideSender') ? undefined : json['outsideSender'],
        'enableTeamCollaboration': !exists(json, 'enableTeamCollaboration') ? undefined : json['enableTeamCollaboration'],
        'language': !exists(json, 'language') ? undefined : json['language'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'sensitivity': !exists(json, 'sensitivity') ? undefined : json['sensitivity'],
        'links': !exists(json, 'links') ? undefined : GroupLinksFromJSON(json['links']),
        'leasePeriodSettings': !exists(json, 'leasePeriodSettings') ? undefined : GroupLeasePeriodSettingsFromJSON(json['leasePeriodSettings']),
        'teamsSettings': !exists(json, 'teamsSettings') ? undefined : RequestTeamsSettingsFromJSON(json['teamsSettings']),
        'appliedSiteDesignId': !exists(json, 'appliedSiteDesignId') ? undefined : json['appliedSiteDesignId'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'enableGroupMembershipHidden': !exists(json, 'enableGroupMembershipHidden') ? undefined : json['enableGroupMembershipHidden'],
        'enableAssignedMembership': !exists(json, 'enableAssignedMembership') ? undefined : json['enableAssignedMembership'],
        'enableDynamicMembership': !exists(json, 'enableDynamicMembership') ? undefined : json['enableDynamicMembership'],
        'templateSettings': !exists(json, 'templateSettings') ? undefined : TeamsTemplateSettingsFromJSON(json['templateSettings']),
        'dynamicMembershipRules': !exists(json, 'dynamicMembershipRules') ? undefined : (json['dynamicMembershipRules'] === null ? null : (json['dynamicMembershipRules'] as Array<any>).map(DynamicGroupRuleInfoFromJSON)),
        'multiGeoLocation': !exists(json, 'multiGeoLocation') ? undefined : GeoLocationBaseFromJSON(json['multiGeoLocation']),
        'hubSiteSettings': !exists(json, 'hubSiteSettings') ? undefined : HubSiteSettingsFromJSON(json['hubSiteSettings']),
        'yammerGroupInfo': !exists(json, 'yammerGroupInfo') ? undefined : json['yammerGroupInfo'],
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

export function CreateGroupRequestToJSON(value?: CreateGroupRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupType': CreateGroupTypeToJSON(value.groupType),
        'groupId': value.groupId,
        'groupIdWithoutPrefixSuffix': value.groupIdWithoutPrefixSuffix,
        'groupName': value.groupName,
        'groupNameWithoutPrefixSuffix': value.groupNameWithoutPrefixSuffix,
        'policy': value.policy,
        'groupDescription': value.groupDescription,
        'owners': value.owners === undefined ? undefined : (value.owners === null ? null : (value.owners as Array<any>).map(ApiUserToJSON)),
        'members': value.members === undefined ? undefined : (value.members === null ? null : (value.members as Array<any>).map(ApiUserToJSON)),
        'privacy': value.privacy,
        'subscribe': value.subscribe,
        'outsideSender': value.outsideSender,
        'enableTeamCollaboration': value.enableTeamCollaboration,
        'language': value.language,
        'classification': value.classification,
        'sensitivity': value.sensitivity,
        'leasePeriodSettings': GroupLeasePeriodSettingsToJSON(value.leasePeriodSettings),
        'teamsSettings': RequestTeamsSettingsToJSON(value.teamsSettings),
        'appliedSiteDesignId': value.appliedSiteDesignId,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'enableGroupMembershipHidden': value.enableGroupMembershipHidden,
        'enableAssignedMembership': value.enableAssignedMembership,
        'enableDynamicMembership': value.enableDynamicMembership,
        'templateSettings': TeamsTemplateSettingsToJSON(value.templateSettings),
        'dynamicMembershipRules': value.dynamicMembershipRules === undefined ? undefined : (value.dynamicMembershipRules === null ? null : (value.dynamicMembershipRules as Array<any>).map(DynamicGroupRuleInfoToJSON)),
        'multiGeoLocation': GeoLocationBaseToJSON(value.multiGeoLocation),
        'hubSiteSettings': HubSiteSettingsToJSON(value.hubSiteSettings),
        'yammerGroupInfo': value.yammerGroupInfo,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


