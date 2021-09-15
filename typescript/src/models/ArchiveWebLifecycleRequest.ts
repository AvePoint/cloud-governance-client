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
 * @interface ArchiveWebLifecycleRequest
 */
export interface ArchiveWebLifecycleRequest {
    /**
     * 
     * @type {WebLifecycleActionType}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly action?: WebLifecycleActionType;
    /**
     * 
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    webRelativeUrl?: string | null;
    /**
     * Web Title
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    webTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ArchiveWebLifecycleRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ArchiveWebLifecycleRequest
     */
    readonly fullPath?: string | null;
}

export function ArchiveWebLifecycleRequestFromJSON(json: any): ArchiveWebLifecycleRequest {
    return ArchiveWebLifecycleRequestFromJSONTyped(json, false);
}

export function ArchiveWebLifecycleRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ArchiveWebLifecycleRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'action': !exists(json, 'action') ? undefined : WebLifecycleActionTypeFromJSON(json['action']),
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'webRelativeUrl': !exists(json, 'webRelativeUrl') ? undefined : json['webRelativeUrl'],
        'webTitle': !exists(json, 'webTitle') ? undefined : json['webTitle'],
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

export function ArchiveWebLifecycleRequestToJSON(value?: ArchiveWebLifecycleRequest | null): any {
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
        'webTitle': value.webTitle,
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


