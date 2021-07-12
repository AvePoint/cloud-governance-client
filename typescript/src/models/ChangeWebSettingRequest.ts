/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeWebSPObject,
    ChangeWebSPObjectFromJSON,
    ChangeWebSPObjectFromJSONTyped,
    ChangeWebSPObjectToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
    RequestMetadataListChangedProperty,
    RequestMetadataListChangedPropertyFromJSON,
    RequestMetadataListChangedPropertyFromJSONTyped,
    RequestMetadataListChangedPropertyToJSON,
    RequestStatus,
    RequestStatusFromJSON,
    RequestStatusFromJSONTyped,
    RequestStatusToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    StringChangedProperty,
    StringChangedPropertyFromJSON,
    StringChangedPropertyFromJSONTyped,
    StringChangedPropertyToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeWebSettingRequest
 */
export interface ChangeWebSettingRequest {
    /**
     * 
     * @type {ChangeWebSPObject}
     * @memberof ChangeWebSettingRequest
     */
    url?: ChangeWebSPObject | null;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof ChangeWebSettingRequest
     */
    changedTitle?: StringChangedProperty | null;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof ChangeWebSettingRequest
     */
    changedDescription?: StringChangedProperty | null;
    /**
     * 
     * @type {RequestMetadataListChangedProperty}
     * @memberof ChangeWebSettingRequest
     */
    changedMetadata?: RequestMetadataListChangedProperty | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    deploymentPlanName?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeWebSettingRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeWebSettingRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeWebSettingRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeWebSettingRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeWebSettingRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeWebSettingRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeWebSettingRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeWebSettingRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeWebSettingRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeWebSettingRequestFromJSON(json: any): ChangeWebSettingRequest {
    return ChangeWebSettingRequestFromJSONTyped(json, false);
}

export function ChangeWebSettingRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebSettingRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'url': !exists(json, 'url') ? undefined : ChangeWebSPObjectFromJSON(json['url']),
        'changedTitle': !exists(json, 'changedTitle') ? undefined : StringChangedPropertyFromJSON(json['changedTitle']),
        'changedDescription': !exists(json, 'changedDescription') ? undefined : StringChangedPropertyFromJSON(json['changedDescription']),
        'changedMetadata': !exists(json, 'changedMetadata') ? undefined : RequestMetadataListChangedPropertyFromJSON(json['changedMetadata']),
        'deploymentPlanName': !exists(json, 'deploymentPlanName') ? undefined : json['deploymentPlanName'],
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

export function ChangeWebSettingRequestToJSON(value?: ChangeWebSettingRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'url': ChangeWebSPObjectToJSON(value.url),
        'changedTitle': StringChangedPropertyToJSON(value.changedTitle),
        'changedDescription': StringChangedPropertyToJSON(value.changedDescription),
        'changedMetadata': RequestMetadataListChangedPropertyToJSON(value.changedMetadata),
        'deploymentPlanName': value.deploymentPlanName,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


