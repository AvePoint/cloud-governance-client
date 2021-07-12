/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ContentMoveCommonSetting,
    ContentMoveCommonSettingFromJSON,
    ContentMoveCommonSettingFromJSONTyped,
    ContentMoveCommonSettingToJSON,
    ContentMoveMethod,
    ContentMoveMethodFromJSON,
    ContentMoveMethodFromJSONTyped,
    ContentMoveMethodToJSON,
    ContentMoveSPObjectMapping,
    ContentMoveSPObjectMappingFromJSON,
    ContentMoveSPObjectMappingFromJSONTyped,
    ContentMoveSPObjectMappingToJSON,
    CopyMoveSetting,
    CopyMoveSettingFromJSON,
    CopyMoveSettingFromJSONTyped,
    CopyMoveSettingToJSON,
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
 * @interface ContentMoveRequest
 */
export interface ContentMoveRequest {
    /**
     * 
     * @type {ContentMoveMethod}
     * @memberof ContentMoveRequest
     */
    method?: ContentMoveMethod;
    /**
     * 
     * @type {CopyMoveSetting}
     * @memberof ContentMoveRequest
     */
    copySettings?: CopyMoveSetting | null;
    /**
     * 
     * @type {CopyMoveSetting}
     * @memberof ContentMoveRequest
     */
    moveSettings?: CopyMoveSetting | null;
    /**
     * 
     * @type {ContentMoveCommonSetting}
     * @memberof ContentMoveRequest
     */
    commonSettings?: ContentMoveCommonSetting | null;
    /**
     * 
     * @type {Array<ContentMoveSPObjectMapping>}
     * @memberof ContentMoveRequest
     */
    objectMappings?: Array<ContentMoveSPObjectMapping> | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ContentMoveRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ContentMoveRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ContentMoveRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ContentMoveRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ContentMoveRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ContentMoveRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ContentMoveRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ContentMoveRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ContentMoveRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ContentMoveRequest
     */
    readonly fullPath?: string | null;
}

export function ContentMoveRequestFromJSON(json: any): ContentMoveRequest {
    return ContentMoveRequestFromJSONTyped(json, false);
}

export function ContentMoveRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'method': !exists(json, 'method') ? undefined : ContentMoveMethodFromJSON(json['method']),
        'copySettings': !exists(json, 'copySettings') ? undefined : CopyMoveSettingFromJSON(json['copySettings']),
        'moveSettings': !exists(json, 'moveSettings') ? undefined : CopyMoveSettingFromJSON(json['moveSettings']),
        'commonSettings': !exists(json, 'commonSettings') ? undefined : ContentMoveCommonSettingFromJSON(json['commonSettings']),
        'objectMappings': !exists(json, 'objectMappings') ? undefined : (json['objectMappings'] === null ? null : (json['objectMappings'] as Array<any>).map(ContentMoveSPObjectMappingFromJSON)),
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

export function ContentMoveRequestToJSON(value?: ContentMoveRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'method': ContentMoveMethodToJSON(value.method),
        'copySettings': CopyMoveSettingToJSON(value.copySettings),
        'moveSettings': CopyMoveSettingToJSON(value.moveSettings),
        'commonSettings': ContentMoveCommonSettingToJSON(value.commonSettings),
        'objectMappings': value.objectMappings === undefined ? undefined : (value.objectMappings === null ? null : (value.objectMappings as Array<any>).map(ContentMoveSPObjectMappingToJSON)),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


