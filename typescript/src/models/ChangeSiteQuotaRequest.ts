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
 * Change site collection quota request model
 * @export
 * @interface ChangeSiteQuotaRequest
 */
export interface ChangeSiteQuotaRequest {
    /**
     * The new site collection quota size
     * @type {number}
     * @memberof ChangeSiteQuotaRequest
     */
    quotaSize?: number;
    /**
     * Lifecycle management action type
     * @type {SiteLifecycleActionType}
     * @memberof ChangeSiteQuotaRequest
     */
    action?: SiteLifecycleActionType;
    /**
     * Description of lifecycle management actions. You can get all available description of lifecycle management actions by invoking the GetSiteLifecycleService api.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Site collection ID
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    siteId?: string;
    /**
     * Site collection URL
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    siteUrl?: string | null;
    /**
     * Site Title
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    siteTitle?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeSiteQuotaRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeSiteQuotaRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeSiteQuotaRequestFromJSON(json: any): ChangeSiteQuotaRequest {
    return ChangeSiteQuotaRequestFromJSONTyped(json, false);
}

export function ChangeSiteQuotaRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteQuotaRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'quotaSize': !exists(json, 'quotaSize') ? undefined : json['quotaSize'],
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

export function ChangeSiteQuotaRequestToJSON(value?: ChangeSiteQuotaRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'quotaSize': value.quotaSize,
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


