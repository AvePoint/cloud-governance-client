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
 * Site collection lifecycle request model
 * @export
 * @interface SiteLifecycleRequest
 */
export interface SiteLifecycleRequest {
    /**
     * Lifecycle management action type
     * @type {SiteLifecycleActionType}
     * @memberof SiteLifecycleRequest
     */
    action?: SiteLifecycleActionType;
    /**
     * Description of lifecycle management actions. You can get all available description of lifecycle management actions by invoking the GetSiteLifecycleService api.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Site collection ID
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    siteId?: string;
    /**
     * Site collection URL
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    siteUrl?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof SiteLifecycleRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof SiteLifecycleRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof SiteLifecycleRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof SiteLifecycleRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof SiteLifecycleRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof SiteLifecycleRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof SiteLifecycleRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof SiteLifecycleRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof SiteLifecycleRequest
     */
    readonly fullPath?: string | null;
}

export function SiteLifecycleRequestFromJSON(json: any): SiteLifecycleRequest {
    return SiteLifecycleRequestFromJSONTyped(json, false);
}

export function SiteLifecycleRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLifecycleRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'action': !exists(json, 'action') ? undefined : SiteLifecycleActionTypeFromJSON(json['action']),
        'actionDescription': !exists(json, 'actionDescription') ? undefined : json['actionDescription'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
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

export function SiteLifecycleRequestToJSON(value?: SiteLifecycleRequest | null): any {
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
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


