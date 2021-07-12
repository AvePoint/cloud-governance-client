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
    AutoImportPhase,
    AutoImportPhaseFromJSON,
    AutoImportPhaseFromJSONTyped,
    AutoImportPhaseToJSON,
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface ApiMyGroup
 */
export interface ApiMyGroup {
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    objectId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    policyId?: string;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    tenantId?: string;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    groupName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    email?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    language?: string | null;
    /**
     * 
     * @type {number}
     * @memberof ApiMyGroup
     */
    applyPolicyStatus?: number;
    /**
     * 
     * @type {boolean}
     * @memberof ApiMyGroup
     */
    enableTeamCollaboration?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    groupType?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof ApiMyGroup
     */
    createdTime?: Date | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ApiMyGroup
     */
    owners?: Array<ApiUser> | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    preferredDataLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    preferredDataLocationName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ApiMyGroup
     */
    enableDynamicMembership?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    groupTeamSiteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    teamLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    noteBookLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    plannerLink?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    classification?: string | null;
    /**
     * 
     * @type {GroupObjectType}
     * @memberof ApiMyGroup
     */
    groupObjectType?: GroupObjectType;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    groupObjectId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    networkId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    id?: string;
    /**
     * 
     * @type {AutoImportPhase}
     * @memberof ApiMyGroup
     */
    phase?: AutoImportPhase;
    /**
     * 
     * @type {Date}
     * @memberof ApiMyGroup
     */
    phaseStartTime?: Date | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    phaseDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    autoImportProfileId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    autoImportProfileName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    policyName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    policyDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ApiMyGroup
     */
    isCurrentRenewer?: boolean;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ApiMyGroup
     */
    phaseAssignees?: Array<ApiUser> | null;
    /**
     * 
     * @type {Date}
     * @memberof ApiMyGroup
     */
    phaseDueDate?: Date | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof ApiMyGroup
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ApiMyGroup
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ApiMyGroup
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof ApiMyGroup
     */
    errorMessage?: string | null;
}

export function ApiMyGroupFromJSON(json: any): ApiMyGroup {
    return ApiMyGroupFromJSONTyped(json, false);
}

export function ApiMyGroupFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiMyGroup {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'email': !exists(json, 'email') ? undefined : json['email'],
        'language': !exists(json, 'language') ? undefined : json['language'],
        'applyPolicyStatus': !exists(json, 'applyPolicyStatus') ? undefined : json['applyPolicyStatus'],
        'enableTeamCollaboration': !exists(json, 'enableTeamCollaboration') ? undefined : json['enableTeamCollaboration'],
        'groupType': !exists(json, 'groupType') ? undefined : json['groupType'],
        'createdTime': !exists(json, 'createdTime') ? undefined : (json['createdTime'] === null ? null : new Date(json['createdTime'])),
        'owners': !exists(json, 'owners') ? undefined : (json['owners'] === null ? null : (json['owners'] as Array<any>).map(ApiUserFromJSON)),
        'preferredDataLocation': !exists(json, 'preferredDataLocation') ? undefined : json['preferredDataLocation'],
        'preferredDataLocationName': !exists(json, 'preferredDataLocationName') ? undefined : json['preferredDataLocationName'],
        'enableDynamicMembership': !exists(json, 'enableDynamicMembership') ? undefined : json['enableDynamicMembership'],
        'groupTeamSiteUrl': !exists(json, 'groupTeamSiteUrl') ? undefined : json['groupTeamSiteUrl'],
        'teamLink': !exists(json, 'teamLink') ? undefined : json['teamLink'],
        'noteBookLink': !exists(json, 'noteBookLink') ? undefined : json['noteBookLink'],
        'plannerLink': !exists(json, 'plannerLink') ? undefined : json['plannerLink'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
        'groupObjectId': !exists(json, 'groupObjectId') ? undefined : json['groupObjectId'],
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'phase': !exists(json, 'phase') ? undefined : AutoImportPhaseFromJSON(json['phase']),
        'phaseStartTime': !exists(json, 'phaseStartTime') ? undefined : (json['phaseStartTime'] === null ? null : new Date(json['phaseStartTime'])),
        'phaseDescription': !exists(json, 'phaseDescription') ? undefined : json['phaseDescription'],
        'autoImportProfileId': !exists(json, 'autoImportProfileId') ? undefined : json['autoImportProfileId'],
        'autoImportProfileName': !exists(json, 'autoImportProfileName') ? undefined : json['autoImportProfileName'],
        'policyName': !exists(json, 'policyName') ? undefined : json['policyName'],
        'policyDescription': !exists(json, 'policyDescription') ? undefined : json['policyDescription'],
        'isCurrentRenewer': !exists(json, 'isCurrentRenewer') ? undefined : json['isCurrentRenewer'],
        'phaseAssignees': !exists(json, 'phaseAssignees') ? undefined : (json['phaseAssignees'] === null ? null : (json['phaseAssignees'] as Array<any>).map(ApiUserFromJSON)),
        'phaseDueDate': !exists(json, 'phaseDueDate') ? undefined : (json['phaseDueDate'] === null ? null : new Date(json['phaseDueDate'])),
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
    };
}

export function ApiMyGroupToJSON(value?: ApiMyGroup | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'objectId': value.objectId,
        'policyId': value.policyId,
        'tenantId': value.tenantId,
        'groupName': value.groupName,
        'email': value.email,
        'language': value.language,
        'applyPolicyStatus': value.applyPolicyStatus,
        'enableTeamCollaboration': value.enableTeamCollaboration,
        'groupType': value.groupType,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime === null ? null : value.createdTime.toISOString()),
        'owners': value.owners === undefined ? undefined : (value.owners === null ? null : (value.owners as Array<any>).map(ApiUserToJSON)),
        'preferredDataLocation': value.preferredDataLocation,
        'preferredDataLocationName': value.preferredDataLocationName,
        'enableDynamicMembership': value.enableDynamicMembership,
        'groupTeamSiteUrl': value.groupTeamSiteUrl,
        'teamLink': value.teamLink,
        'noteBookLink': value.noteBookLink,
        'plannerLink': value.plannerLink,
        'classification': value.classification,
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'groupObjectId': value.groupObjectId,
        'networkId': value.networkId,
        'id': value.id,
        'phase': AutoImportPhaseToJSON(value.phase),
        'phaseStartTime': value.phaseStartTime === undefined ? undefined : (value.phaseStartTime === null ? null : value.phaseStartTime.toISOString()),
        'phaseDescription': value.phaseDescription,
        'autoImportProfileId': value.autoImportProfileId,
        'autoImportProfileName': value.autoImportProfileName,
        'policyName': value.policyName,
        'policyDescription': value.policyDescription,
        'isCurrentRenewer': value.isCurrentRenewer,
        'phaseAssignees': value.phaseAssignees === undefined ? undefined : (value.phaseAssignees === null ? null : (value.phaseAssignees as Array<any>).map(ApiUserToJSON)),
        'phaseDueDate': value.phaseDueDate === undefined ? undefined : (value.phaseDueDate === null ? null : value.phaseDueDate.toISOString()),
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'errorMessage': value.errorMessage,
    };
}


