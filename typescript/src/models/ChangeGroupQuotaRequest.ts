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
 * Change group team site quota request model
 * @export
 * @interface ChangeGroupQuotaRequest
 */
export interface ChangeGroupQuotaRequest {
    /**
     * The new group team site quota size
     * @type {number}
     * @memberof ChangeGroupQuotaRequest
     */
    groupQuotaSize?: number;
    /**
     * The original group team site quota size
     * @type {number}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly originalQuotaSize?: number;
    /**
     * Object ID
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    groupId?: string;
    /**
     * Group name
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly groupName?: string | null;
    /**
     * Group e-mail address
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly groupEmail?: string | null;
    /**
     * Group type
     * @type {GroupObjectType}
     * @memberof ChangeGroupQuotaRequest
     */
    groupObjectType?: GroupObjectType;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeGroupQuotaRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeGroupQuotaRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeGroupQuotaRequestFromJSON(json: any): ChangeGroupQuotaRequest {
    return ChangeGroupQuotaRequestFromJSONTyped(json, false);
}

export function ChangeGroupQuotaRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupQuotaRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupQuotaSize': !exists(json, 'groupQuotaSize') ? undefined : json['groupQuotaSize'],
        'originalQuotaSize': !exists(json, 'originalQuotaSize') ? undefined : json['originalQuotaSize'],
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

export function ChangeGroupQuotaRequestToJSON(value?: ChangeGroupQuotaRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupQuotaSize': value.groupQuotaSize,
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


