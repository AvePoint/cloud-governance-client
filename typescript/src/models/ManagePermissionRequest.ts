/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    NodeType,
    NodeTypeFromJSON,
    NodeTypeFromJSONTyped,
    NodeTypeToJSON,
    PermissionManagementModel,
    PermissionManagementModelFromJSON,
    PermissionManagementModelFromJSONTyped,
    PermissionManagementModelToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
    RequestStatus,
    RequestStatusFromJSON,
    RequestStatusFromJSONTyped,
    RequestStatusToJSON,
    SPGroupManagementModel,
    SPGroupManagementModelFromJSON,
    SPGroupManagementModelFromJSONTyped,
    SPGroupManagementModelToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * Manage permission request model
 * @export
 * @interface ManagePermissionRequest
 */
export interface ManagePermissionRequest {
    /**
     * Object URL
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    objectUrl?: string | null;
    /**
     * Object type
     * @type {NodeType}
     * @memberof ManagePermissionRequest
     */
    objectType?: NodeType;
    /**
     * Object name
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    objectTitle?: string | null;
    /**
     * Site collection URL
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    siteUrl?: string | null;
    /**
     * Site URL
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    webUrl?: string | null;
    /**
     * SharePoint group management settings
     * @type {Array<SPGroupManagementModel>}
     * @memberof ManagePermissionRequest
     */
    spGroupManagement?: Array<SPGroupManagementModel> | null;
    /**
     * Permission management settings
     * @type {PermissionManagementModel}
     * @memberof ManagePermissionRequest
     */
    permissionManagement?: PermissionManagementModel | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ManagePermissionRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ManagePermissionRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ManagePermissionRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ManagePermissionRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ManagePermissionRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ManagePermissionRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ManagePermissionRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ManagePermissionRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ManagePermissionRequest
     */
    readonly fullPath?: string | null;
}

export function ManagePermissionRequestFromJSON(json: any): ManagePermissionRequest {
    return ManagePermissionRequestFromJSONTyped(json, false);
}

export function ManagePermissionRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectType': !exists(json, 'objectType') ? undefined : NodeTypeFromJSON(json['objectType']),
        'objectTitle': !exists(json, 'objectTitle') ? undefined : json['objectTitle'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'spGroupManagement': !exists(json, 'spGroupManagement') ? undefined : (json['spGroupManagement'] === null ? null : (json['spGroupManagement'] as Array<any>).map(SPGroupManagementModelFromJSON)),
        'permissionManagement': !exists(json, 'permissionManagement') ? undefined : PermissionManagementModelFromJSON(json['permissionManagement']),
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

export function ManagePermissionRequestToJSON(value?: ManagePermissionRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'objectUrl': value.objectUrl,
        'objectType': NodeTypeToJSON(value.objectType),
        'objectTitle': value.objectTitle,
        'siteUrl': value.siteUrl,
        'webUrl': value.webUrl,
        'spGroupManagement': value.spGroupManagement === undefined ? undefined : (value.spGroupManagement === null ? null : (value.spGroupManagement as Array<any>).map(SPGroupManagementModelToJSON)),
        'permissionManagement': PermissionManagementModelToJSON(value.permissionManagement),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


