/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    GroupObjectType,
    GroupObjectTypeFromJSON,
    GroupObjectTypeFromJSONTyped,
    GroupObjectTypeToJSON,
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
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
    StartDateType,
    StartDateTypeFromJSON,
    StartDateTypeFromJSONTyped,
    StartDateTypeToJSON,
} from './';

/**
 * Change group policy request model
 * @export
 * @interface ChangeGroupPolicyRequest
 */
export interface ChangeGroupPolicyRequest {
    /**
     * The new policy information settings
     * @type {GuidModel}
     * @memberof ChangeGroupPolicyRequest
     */
    policy?: GuidModel | null;
    /**
     * The original policy information settings
     * @type {GuidModel}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly originalPolicy?: GuidModel | null;
    /**
     * Whether to enable the group/team lease extension.
     * @type {boolean}
     * @memberof ChangeGroupPolicyRequest
     */
    isLeaseEnabled?: boolean;
    /**
     * Set how to assign the group policy.
     * @type {AssignBy}
     * @memberof ChangeGroupPolicyRequest
     */
    changePolicyConfig?: AssignBy;
    /**
     * Group lease start date configuration after a policy change
     * @type {StartDateType}
     * @memberof ChangeGroupPolicyRequest
     */
    startDateType?: StartDateType;
    /**
     * New lease start date
     * @type {Date}
     * @memberof ChangeGroupPolicyRequest
     */
    specifyStartDate?: Date | null;
    /**
     * Object ID
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    groupId?: string;
    /**
     * Group name
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly groupName?: string | null;
    /**
     * Group e-mail address
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly groupEmail?: string | null;
    /**
     * Group type
     * @type {GroupObjectType}
     * @memberof ChangeGroupPolicyRequest
     */
    groupObjectType?: GroupObjectType;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeGroupPolicyRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeGroupPolicyRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeGroupPolicyRequestFromJSON(json: any): ChangeGroupPolicyRequest {
    return ChangeGroupPolicyRequestFromJSONTyped(json, false);
}

export function ChangeGroupPolicyRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupPolicyRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'policy': !exists(json, 'policy') ? undefined : GuidModelFromJSON(json['policy']),
        'originalPolicy': !exists(json, 'originalPolicy') ? undefined : GuidModelFromJSON(json['originalPolicy']),
        'isLeaseEnabled': !exists(json, 'isLeaseEnabled') ? undefined : json['isLeaseEnabled'],
        'changePolicyConfig': !exists(json, 'changePolicyConfig') ? undefined : AssignByFromJSON(json['changePolicyConfig']),
        'startDateType': !exists(json, 'startDateType') ? undefined : StartDateTypeFromJSON(json['startDateType']),
        'specifyStartDate': !exists(json, 'specifyStartDate') ? undefined : (json['specifyStartDate'] === null ? null : new Date(json['specifyStartDate'])),
        'groupId': !exists(json, 'groupId') ? undefined : json['groupId'],
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'groupObjectType': !exists(json, 'groupObjectType') ? undefined : GroupObjectTypeFromJSON(json['groupObjectType']),
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

export function ChangeGroupPolicyRequestToJSON(value?: ChangeGroupPolicyRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'policy': GuidModelToJSON(value.policy),
        'isLeaseEnabled': value.isLeaseEnabled,
        'changePolicyConfig': AssignByToJSON(value.changePolicyConfig),
        'startDateType': StartDateTypeToJSON(value.startDateType),
        'specifyStartDate': value.specifyStartDate === undefined ? undefined : (value.specifyStartDate === null ? null : value.specifyStartDate.toISOString()),
        'groupId': value.groupId,
        'groupObjectType': GroupObjectTypeToJSON(value.groupObjectType),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


