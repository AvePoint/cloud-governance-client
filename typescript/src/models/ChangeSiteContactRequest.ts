/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeContactByUrlSetting,
    ChangeContactByUrlSettingFromJSON,
    ChangeContactByUrlSettingFromJSONTyped,
    ChangeContactByUrlSettingToJSON,
    ChangeContactByUserSetting,
    ChangeContactByUserSettingFromJSON,
    ChangeContactByUserSettingFromJSONTyped,
    ChangeContactByUserSettingToJSON,
    ChangeContactMethod,
    ChangeContactMethodFromJSON,
    ChangeContactMethodFromJSONTyped,
    ChangeContactMethodToJSON,
    ChangeSiteContactSubRequest,
    ChangeSiteContactSubRequestFromJSON,
    ChangeSiteContactSubRequestFromJSONTyped,
    ChangeSiteContactSubRequestToJSON,
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
 * @interface ChangeSiteContactRequest
 */
export interface ChangeSiteContactRequest {
    /**
     * 
     * @type {ChangeContactMethod}
     * @memberof ChangeSiteContactRequest
     */
    changeContactMethod?: ChangeContactMethod;
    /**
     * 
     * @type {Array<ChangeContactByUrlSetting>}
     * @memberof ChangeSiteContactRequest
     */
    changeByUrlSetting?: Array<ChangeContactByUrlSetting> | null;
    /**
     * 
     * @type {ChangeContactByUserSetting}
     * @memberof ChangeSiteContactRequest
     */
    changeByUserSetting?: ChangeContactByUserSetting | null;
    /**
     * 
     * @type {Array<ChangeSiteContactSubRequest>}
     * @memberof ChangeSiteContactRequest
     */
    readonly subRequests?: Array<ChangeSiteContactSubRequest> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactRequest
     */
    readonly isServiceEnableChangeContact?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactRequest
     */
    readonly isServiceEnableChangeAdmin?: boolean;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeSiteContactRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeSiteContactRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeSiteContactRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeSiteContactRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeSiteContactRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeSiteContactRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeSiteContactRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeSiteContactRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeSiteContactRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeSiteContactRequestFromJSON(json: any): ChangeSiteContactRequest {
    return ChangeSiteContactRequestFromJSONTyped(json, false);
}

export function ChangeSiteContactRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteContactRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeContactMethod': !exists(json, 'changeContactMethod') ? undefined : ChangeContactMethodFromJSON(json['changeContactMethod']),
        'changeByUrlSetting': !exists(json, 'changeByUrlSetting') ? undefined : (json['changeByUrlSetting'] === null ? null : (json['changeByUrlSetting'] as Array<any>).map(ChangeContactByUrlSettingFromJSON)),
        'changeByUserSetting': !exists(json, 'changeByUserSetting') ? undefined : ChangeContactByUserSettingFromJSON(json['changeByUserSetting']),
        'subRequests': !exists(json, 'subRequests') ? undefined : (json['subRequests'] === null ? null : (json['subRequests'] as Array<any>).map(ChangeSiteContactSubRequestFromJSON)),
        'isServiceEnableChangeContact': !exists(json, 'isServiceEnableChangeContact') ? undefined : json['isServiceEnableChangeContact'],
        'isServiceEnableChangeAdmin': !exists(json, 'isServiceEnableChangeAdmin') ? undefined : json['isServiceEnableChangeAdmin'],
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

export function ChangeSiteContactRequestToJSON(value?: ChangeSiteContactRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeContactMethod': ChangeContactMethodToJSON(value.changeContactMethod),
        'changeByUrlSetting': value.changeByUrlSetting === undefined ? undefined : (value.changeByUrlSetting === null ? null : (value.changeByUrlSetting as Array<any>).map(ChangeContactByUrlSettingToJSON)),
        'changeByUserSetting': ChangeContactByUserSettingToJSON(value.changeByUserSetting),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


