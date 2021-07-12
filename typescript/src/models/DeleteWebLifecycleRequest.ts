/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
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
    WebLifecycleActionType,
    WebLifecycleActionTypeFromJSON,
    WebLifecycleActionTypeFromJSONTyped,
    WebLifecycleActionTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface DeleteWebLifecycleRequest
 */
export interface DeleteWebLifecycleRequest {
    /**
     * 
     * @type {WebLifecycleActionType}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly action?: WebLifecycleActionType;
    /**
     * 
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    webRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof DeleteWebLifecycleRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof DeleteWebLifecycleRequest
     */
    readonly fullPath?: string | null;
}

export function DeleteWebLifecycleRequestFromJSON(json: any): DeleteWebLifecycleRequest {
    return DeleteWebLifecycleRequestFromJSONTyped(json, false);
}

export function DeleteWebLifecycleRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): DeleteWebLifecycleRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'action': !exists(json, 'action') ? undefined : WebLifecycleActionTypeFromJSON(json['action']),
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'webRelativeUrl': !exists(json, 'webRelativeUrl') ? undefined : json['webRelativeUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'actionDescription': !exists(json, 'actionDescription') ? undefined : json['actionDescription'],
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

export function DeleteWebLifecycleRequestToJSON(value?: DeleteWebLifecycleRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'webId': value.webId,
        'webUrl': value.webUrl,
        'webRelativeUrl': value.webRelativeUrl,
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


