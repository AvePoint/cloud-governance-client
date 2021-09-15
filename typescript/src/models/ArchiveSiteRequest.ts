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
    SiteLifecycleActionType,
    SiteLifecycleActionTypeFromJSON,
    SiteLifecycleActionTypeFromJSONTyped,
    SiteLifecycleActionTypeToJSON,
} from './';

/**
 * Archive site collection request model
 * @export
 * @interface ArchiveSiteRequest
 */
export interface ArchiveSiteRequest {
    /**
     * Lifecycle management action type
     * @type {SiteLifecycleActionType}
     * @memberof ArchiveSiteRequest
     */
    action?: SiteLifecycleActionType;
    /**
     * Description of lifecycle management actions. You can get all available description of lifecycle management actions by invoking the GetSiteLifecycleService api.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Site collection ID
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    siteId?: string;
    /**
     * Site collection URL
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    siteUrl?: string | null;
    /**
     * Site Title
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    siteTitle?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ArchiveSiteRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ArchiveSiteRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ArchiveSiteRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ArchiveSiteRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ArchiveSiteRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ArchiveSiteRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ArchiveSiteRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ArchiveSiteRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ArchiveSiteRequest
     */
    readonly fullPath?: string | null;
}

export function ArchiveSiteRequestFromJSON(json: any): ArchiveSiteRequest {
    return ArchiveSiteRequestFromJSONTyped(json, false);
}

export function ArchiveSiteRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ArchiveSiteRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'action': !exists(json, 'action') ? undefined : SiteLifecycleActionTypeFromJSON(json['action']),
        'actionDescription': !exists(json, 'actionDescription') ? undefined : json['actionDescription'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'siteTitle': !exists(json, 'siteTitle') ? undefined : json['siteTitle'],
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

export function ArchiveSiteRequestToJSON(value?: ArchiveSiteRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'action': SiteLifecycleActionTypeToJSON(value.action),
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'siteTitle': value.siteTitle,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


