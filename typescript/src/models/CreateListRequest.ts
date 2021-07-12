/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    CreateListSPObject,
    CreateListSPObjectFromJSON,
    CreateListSPObjectFromJSONTyped,
    CreateListSPObjectToJSON,
    ListPermissionSettings,
    ListPermissionSettingsFromJSON,
    ListPermissionSettingsFromJSONTyped,
    ListPermissionSettingsToJSON,
    ListType,
    ListTypeFromJSON,
    ListTypeFromJSONTyped,
    ListTypeToJSON,
    ListVersionSettings,
    ListVersionSettingsFromJSON,
    ListVersionSettingsFromJSONTyped,
    ListVersionSettingsToJSON,
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
 * @interface CreateListRequest
 */
export interface CreateListRequest {
    /**
     * 
     * @type {string}
     * @memberof CreateListRequest
     */
    listTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListRequest
     */
    listName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListRequest
     */
    listDescription?: string | null;
    /**
     * 
     * @type {CreateListSPObject}
     * @memberof CreateListRequest
     */
    parentObject?: CreateListSPObject | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListRequest
     */
    listTemplate?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListRequest
     */
    enableNavigation?: boolean;
    /**
     * 
     * @type {ListType}
     * @memberof CreateListRequest
     */
    listType?: ListType;
    /**
     * 
     * @type {ListVersionSettings}
     * @memberof CreateListRequest
     */
    versionSettings?: ListVersionSettings | null;
    /**
     * 
     * @type {ListPermissionSettings}
     * @memberof CreateListRequest
     */
    permissionSettings?: ListPermissionSettings | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof CreateListRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof CreateListRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof CreateListRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof CreateListRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof CreateListRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof CreateListRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof CreateListRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof CreateListRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof CreateListRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof CreateListRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof CreateListRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof CreateListRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof CreateListRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof CreateListRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof CreateListRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof CreateListRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof CreateListRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof CreateListRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof CreateListRequest
     */
    readonly fullPath?: string | null;
}

export function CreateListRequestFromJSON(json: any): CreateListRequest {
    return CreateListRequestFromJSONTyped(json, false);
}

export function CreateListRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateListRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'listTitle': !exists(json, 'listTitle') ? undefined : json['listTitle'],
        'listName': !exists(json, 'listName') ? undefined : json['listName'],
        'listDescription': !exists(json, 'listDescription') ? undefined : json['listDescription'],
        'parentObject': !exists(json, 'parentObject') ? undefined : CreateListSPObjectFromJSON(json['parentObject']),
        'listTemplate': !exists(json, 'listTemplate') ? undefined : json['listTemplate'],
        'enableNavigation': !exists(json, 'enableNavigation') ? undefined : json['enableNavigation'],
        'listType': !exists(json, 'listType') ? undefined : ListTypeFromJSON(json['listType']),
        'versionSettings': !exists(json, 'versionSettings') ? undefined : ListVersionSettingsFromJSON(json['versionSettings']),
        'permissionSettings': !exists(json, 'permissionSettings') ? undefined : ListPermissionSettingsFromJSON(json['permissionSettings']),
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

export function CreateListRequestToJSON(value?: CreateListRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'listTitle': value.listTitle,
        'listName': value.listName,
        'listDescription': value.listDescription,
        'parentObject': CreateListSPObjectToJSON(value.parentObject),
        'listTemplate': value.listTemplate,
        'enableNavigation': value.enableNavigation,
        'listType': ListTypeToJSON(value.listType),
        'versionSettings': ListVersionSettingsToJSON(value.versionSettings),
        'permissionSettings': ListPermissionSettingsToJSON(value.permissionSettings),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


