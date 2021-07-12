/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeContactByUserSetting,
    ChangeContactByUserSettingFromJSON,
    ChangeContactByUserSettingFromJSONTyped,
    ChangeContactByUserSettingToJSON,
    ChangeContactMethod,
    ChangeContactMethodFromJSON,
    ChangeContactMethodFromJSONTyped,
    ChangeContactMethodToJSON,
    ChangeWebContactByUrlSetting,
    ChangeWebContactByUrlSettingFromJSON,
    ChangeWebContactByUrlSettingFromJSONTyped,
    ChangeWebContactByUrlSettingToJSON,
    ChangeWebContactSubRequest,
    ChangeWebContactSubRequestFromJSON,
    ChangeWebContactSubRequestFromJSONTyped,
    ChangeWebContactSubRequestToJSON,
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
 * 
 * @export
 * @interface ChangeWebContactRequest
 */
export interface ChangeWebContactRequest {
    /**
     * 
     * @type {ChangeContactMethod}
     * @memberof ChangeWebContactRequest
     */
    changedMethod?: ChangeContactMethod;
    /**
     * 
     * @type {ChangeContactByUserSetting}
     * @memberof ChangeWebContactRequest
     */
    changedByUserSetting?: ChangeContactByUserSetting | null;
    /**
     * 
     * @type {Array<ChangeWebContactByUrlSetting>}
     * @memberof ChangeWebContactRequest
     */
    changedByUrlItems?: Array<ChangeWebContactByUrlSetting> | null;
    /**
     * 
     * @type {Array<ChangeWebContactSubRequest>}
     * @memberof ChangeWebContactRequest
     */
    readonly subRequests?: Array<ChangeWebContactSubRequest> | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeWebContactRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeWebContactRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeWebContactRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeWebContactRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeWebContactRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeWebContactRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeWebContactRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeWebContactRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeWebContactRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeWebContactRequestFromJSON(json: any): ChangeWebContactRequest {
    return ChangeWebContactRequestFromJSONTyped(json, false);
}

export function ChangeWebContactRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebContactRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changedMethod': !exists(json, 'changedMethod') ? undefined : ChangeContactMethodFromJSON(json['changedMethod']),
        'changedByUserSetting': !exists(json, 'changedByUserSetting') ? undefined : ChangeContactByUserSettingFromJSON(json['changedByUserSetting']),
        'changedByUrlItems': !exists(json, 'changedByUrlItems') ? undefined : (json['changedByUrlItems'] === null ? null : (json['changedByUrlItems'] as Array<any>).map(ChangeWebContactByUrlSettingFromJSON)),
        'subRequests': !exists(json, 'subRequests') ? undefined : (json['subRequests'] === null ? null : (json['subRequests'] as Array<any>).map(ChangeWebContactSubRequestFromJSON)),
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

export function ChangeWebContactRequestToJSON(value?: ChangeWebContactRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changedMethod': ChangeContactMethodToJSON(value.changedMethod),
        'changedByUserSetting': ChangeContactByUserSettingToJSON(value.changedByUserSetting),
        'changedByUrlItems': value.changedByUrlItems === undefined ? undefined : (value.changedByUrlItems === null ? null : (value.changedByUrlItems as Array<any>).map(ChangeWebContactByUrlSettingToJSON)),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


