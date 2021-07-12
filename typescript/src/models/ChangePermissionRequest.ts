/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    PermissionChangedType,
    PermissionChangedTypeFromJSON,
    PermissionChangedTypeFromJSONTyped,
    PermissionChangedTypeToJSON,
    PermissionObjectProperty,
    PermissionObjectPropertyFromJSON,
    PermissionObjectPropertyFromJSONTyped,
    PermissionObjectPropertyToJSON,
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
 * @interface ChangePermissionRequest
 */
export interface ChangePermissionRequest {
    /**
     * 
     * @type {PermissionObjectProperty}
     * @memberof ChangePermissionRequest
     */
    objectProperty?: PermissionObjectProperty | null;
    /**
     * 
     * @type {PermissionChangedType}
     * @memberof ChangePermissionRequest
     */
    permissionChangedType?: PermissionChangedType;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionRequest
     */
    isManagedAllUsers?: boolean;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ChangePermissionRequest
     */
    selectedUsers?: Array<ApiUser> | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangePermissionRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangePermissionRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangePermissionRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangePermissionRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangePermissionRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangePermissionRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangePermissionRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangePermissionRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangePermissionRequest
     */
    readonly fullPath?: string | null;
}

export function ChangePermissionRequestFromJSON(json: any): ChangePermissionRequest {
    return ChangePermissionRequestFromJSONTyped(json, false);
}

export function ChangePermissionRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangePermissionRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'objectProperty': !exists(json, 'objectProperty') ? undefined : PermissionObjectPropertyFromJSON(json['objectProperty']),
        'permissionChangedType': !exists(json, 'permissionChangedType') ? undefined : PermissionChangedTypeFromJSON(json['permissionChangedType']),
        'isManagedAllUsers': !exists(json, 'isManagedAllUsers') ? undefined : json['isManagedAllUsers'],
        'selectedUsers': !exists(json, 'selectedUsers') ? undefined : (json['selectedUsers'] === null ? null : (json['selectedUsers'] as Array<any>).map(ApiUserFromJSON)),
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

export function ChangePermissionRequestToJSON(value?: ChangePermissionRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'objectProperty': PermissionObjectPropertyToJSON(value.objectProperty),
        'permissionChangedType': PermissionChangedTypeToJSON(value.permissionChangedType),
        'isManagedAllUsers': value.isManagedAllUsers,
        'selectedUsers': value.selectedUsers === undefined ? undefined : (value.selectedUsers === null ? null : (value.selectedUsers as Array<any>).map(ApiUserToJSON)),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


