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
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    DynamicGroupRuleInfo,
    DynamicGroupRuleInfoFromJSON,
    DynamicGroupRuleInfoFromJSONTyped,
    DynamicGroupRuleInfoToJSON,
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeGroupSettingCheckResult
 */
export interface ChangeGroupSettingCheckResult {
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingCheckResult
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeGroupSettingCheckResult
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    groupId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    groupName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    groupEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    groupDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    isEnableSubscribeMembers?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    isEnableOutsideSender?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    classification?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    isTeamsEnabled?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    enableManageGroupSharing?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    enableInviteAuthorizedGuestUser?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    enableInviteGuestUser?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    enableDynamicMembership?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    enableTeamCollaboration?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    isHubSite?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    associatedHubSiteId?: string | null;
    /**
     * 
     * @type {Array<DynamicGroupRuleInfo>}
     * @memberof ChangeGroupSettingCheckResult
     */
    dynamicMembershipRules?: Array<DynamicGroupRuleInfo> | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeGroupSettingCheckResult
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    enableChangeMembershipType?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    yammerGroupInfo?: string | null;
    /**
     * 
     * @type {GroupObjectType}
     * @memberof ChangeGroupSettingCheckResult
     */
    groupObjectType?: GroupObjectType;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    networkId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    groupObjectId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingCheckResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingCheckResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangeGroupSettingCheckResult
     */
    messageCode?: MessageCode;
}

export function ChangeGroupSettingCheckResultFromJSON(json: any): ChangeGroupSettingCheckResult {
    return ChangeGroupSettingCheckResultFromJSONTyped(json, false);
}

export function ChangeGroupSettingCheckResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupSettingCheckResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'groupId': !exists(json, 'groupId') ? undefined : json['groupId'],
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'groupDescription': !exists(json, 'groupDescription') ? undefined : json['groupDescription'],
        'isEnableSubscribeMembers': !exists(json, 'isEnableSubscribeMembers') ? undefined : json['isEnableSubscribeMembers'],
        'isEnableOutsideSender': !exists(json, 'isEnableOutsideSender') ? undefined : json['isEnableOutsideSender'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'isTeamsEnabled': !exists(json, 'isTeamsEnabled') ? undefined : json['isTeamsEnabled'],
        'enableManageGroupSharing': !exists(json, 'enableManageGroupSharing') ? undefined : json['enableManageGroupSharing'],
        'enableInviteAuthorizedGuestUser': !exists(json, 'enableInviteAuthorizedGuestUser') ? undefined : json['enableInviteAuthorizedGuestUser'],
        'enableInviteGuestUser': !exists(json, 'enableInviteGuestUser') ? undefined : json['enableInviteGuestUser'],
        'enableDynamicMembership': !exists(json, 'enableDynamicMembership') ? undefined : json['enableDynamicMembership'],
        'enableTeamCollaboration': !exists(json, 'enableTeamCollaboration') ? undefined : json['enableTeamCollaboration'],
        'isHubSite': !exists(json, 'isHubSite') ? undefined : json['isHubSite'],
        'associatedHubSiteId': !exists(json, 'associatedHubSiteId') ? undefined : json['associatedHubSiteId'],
        'dynamicMembershipRules': !exists(json, 'dynamicMembershipRules') ? undefined : (json['dynamicMembershipRules'] === null ? null : (json['dynamicMembershipRules'] as Array<any>).map(DynamicGroupRuleInfoFromJSON)),
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(CustomMetadataFromJSON)),
        'enableChangeMembershipType': !exists(json, 'enableChangeMembershipType') ? undefined : json['enableChangeMembershipType'],
        'yammerGroupInfo': !exists(json, 'yammerGroupInfo') ? undefined : json['yammerGroupInfo'],
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'groupObjectId': !exists(json, 'groupObjectId') ? undefined : json['groupObjectId'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangeGroupSettingCheckResultToJSON(value?: ChangeGroupSettingCheckResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'groupId': value.groupId,
        'groupName': value.groupName,
        'groupEmail': value.groupEmail,
        'groupDescription': value.groupDescription,
        'isEnableSubscribeMembers': value.isEnableSubscribeMembers,
        'isEnableOutsideSender': value.isEnableOutsideSender,
        'classification': value.classification,
        'isTeamsEnabled': value.isTeamsEnabled,
        'enableManageGroupSharing': value.enableManageGroupSharing,
        'enableInviteAuthorizedGuestUser': value.enableInviteAuthorizedGuestUser,
        'enableInviteGuestUser': value.enableInviteGuestUser,
        'enableDynamicMembership': value.enableDynamicMembership,
        'enableTeamCollaboration': value.enableTeamCollaboration,
        'isHubSite': value.isHubSite,
        'associatedHubSiteId': value.associatedHubSiteId,
        'dynamicMembershipRules': value.dynamicMembershipRules === undefined ? undefined : (value.dynamicMembershipRules === null ? null : (value.dynamicMembershipRules as Array<any>).map(DynamicGroupRuleInfoToJSON)),
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(CustomMetadataToJSON)),
        'enableChangeMembershipType': value.enableChangeMembershipType,
        'yammerGroupInfo': value.yammerGroupInfo,
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'networkId': value.networkId,
        'groupObjectId': value.groupObjectId,
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


