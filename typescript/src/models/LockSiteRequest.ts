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
    SiteLockType,
    SiteLockTypeFromJSON,
    SiteLockTypeFromJSONTyped,
    SiteLockTypeToJSON,
} from './';

/**
 * Lock site collection request model
 * @export
 * @interface LockSiteRequest
 */
export interface LockSiteRequest {
    /**
     * Site collection locking status
     * @type {SiteLockType}
     * @memberof LockSiteRequest
     */
    lockType?: SiteLockType;
    /**
     * Description of site collection locking status. You can get all available description of site collection locking statuses by invoking the GetSiteLifecycleService api.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly lockTypeDescription?: string | null;
    /**
     * Lifecycle management action type
     * @type {SiteLifecycleActionType}
     * @memberof LockSiteRequest
     */
    action?: SiteLifecycleActionType;
    /**
     * Description of lifecycle management actions. You can get all available description of lifecycle management actions by invoking the GetSiteLifecycleService api.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Site collection ID
     * @type {string}
     * @memberof LockSiteRequest
     */
    siteId?: string;
    /**
     * Site collection URL
     * @type {string}
     * @memberof LockSiteRequest
     */
    siteUrl?: string | null;
    /**
     * Site Title
     * @type {string}
     * @memberof LockSiteRequest
     */
    siteTitle?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof LockSiteRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof LockSiteRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof LockSiteRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof LockSiteRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof LockSiteRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof LockSiteRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof LockSiteRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof LockSiteRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof LockSiteRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof LockSiteRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof LockSiteRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof LockSiteRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof LockSiteRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof LockSiteRequest
     */
    readonly fullPath?: string | null;
}

export function LockSiteRequestFromJSON(json: any): LockSiteRequest {
    return LockSiteRequestFromJSONTyped(json, false);
}

export function LockSiteRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): LockSiteRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'lockType': !exists(json, 'lockType') ? undefined : SiteLockTypeFromJSON(json['lockType']),
        'lockTypeDescription': !exists(json, 'lockTypeDescription') ? undefined : json['lockTypeDescription'],
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

export function LockSiteRequestToJSON(value?: LockSiteRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'lockType': SiteLockTypeToJSON(value.lockType),
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


