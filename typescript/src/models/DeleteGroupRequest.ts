/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
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
 * Delete group request model
 * @export
 * @interface DeleteGroupRequest
 */
export interface DeleteGroupRequest {
    /**
     * Object ID
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    groupId?: string;
    /**
     * Group name
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly groupName?: string | null;
    /**
     * Group e-mail address
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly groupEmail?: string | null;
    /**
     * Group type
     * @type {GroupObjectType}
     * @memberof DeleteGroupRequest
     */
    groupObjectType?: GroupObjectType;
    /**
     * Id of request.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof DeleteGroupRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof DeleteGroupRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof DeleteGroupRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof DeleteGroupRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof DeleteGroupRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof DeleteGroupRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof DeleteGroupRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof DeleteGroupRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof DeleteGroupRequest
     */
    readonly fullPath?: string | null;
}

export function DeleteGroupRequestFromJSON(json: any): DeleteGroupRequest {
    return DeleteGroupRequestFromJSONTyped(json, false);
}

export function DeleteGroupRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): DeleteGroupRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
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

export function DeleteGroupRequestToJSON(value?: DeleteGroupRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
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


