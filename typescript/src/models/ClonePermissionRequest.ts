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
    ClonePermissionAdditionalOption,
    ClonePermissionAdditionalOptionFromJSON,
    ClonePermissionAdditionalOptionFromJSONTyped,
    ClonePermissionAdditionalOptionToJSON,
    ClonePermissionOption,
    ClonePermissionOptionFromJSON,
    ClonePermissionOptionFromJSONTyped,
    ClonePermissionOptionToJSON,
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
 * @interface ClonePermissionRequest
 */
export interface ClonePermissionRequest {
    /**
     * 
     * @type {Array<string>}
     * @memberof ClonePermissionRequest
     */
    urls?: Array<string> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ClonePermissionRequest
     */
    sourceUser?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ClonePermissionRequest
     */
    targetUser?: ApiUser | null;
    /**
     * 
     * @type {ClonePermissionOption}
     * @memberof ClonePermissionRequest
     */
    cloneOption?: ClonePermissionOption;
    /**
     * 
     * @type {ClonePermissionAdditionalOption}
     * @memberof ClonePermissionRequest
     */
    additionalCloneOption?: ClonePermissionAdditionalOption;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionRequest
     */
    enabledRemoveExplicitPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionRequest
     */
    enabledRemoveUserFromSPGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionRequest
     */
    enabledDeleteUserPermission?: boolean;
    /**
     * Id of request.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ClonePermissionRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ClonePermissionRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ClonePermissionRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ClonePermissionRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ClonePermissionRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ClonePermissionRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ClonePermissionRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ClonePermissionRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ClonePermissionRequest
     */
    readonly fullPath?: string | null;
}

export function ClonePermissionRequestFromJSON(json: any): ClonePermissionRequest {
    return ClonePermissionRequestFromJSONTyped(json, false);
}

export function ClonePermissionRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ClonePermissionRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'urls': !exists(json, 'urls') ? undefined : json['urls'],
        'sourceUser': !exists(json, 'sourceUser') ? undefined : ApiUserFromJSON(json['sourceUser']),
        'targetUser': !exists(json, 'targetUser') ? undefined : ApiUserFromJSON(json['targetUser']),
        'cloneOption': !exists(json, 'cloneOption') ? undefined : ClonePermissionOptionFromJSON(json['cloneOption']),
        'additionalCloneOption': !exists(json, 'additionalCloneOption') ? undefined : ClonePermissionAdditionalOptionFromJSON(json['additionalCloneOption']),
        'enabledRemoveExplicitPermission': !exists(json, 'enabledRemoveExplicitPermission') ? undefined : json['enabledRemoveExplicitPermission'],
        'enabledRemoveUserFromSPGroup': !exists(json, 'enabledRemoveUserFromSPGroup') ? undefined : json['enabledRemoveUserFromSPGroup'],
        'enabledDeleteUserPermission': !exists(json, 'enabledDeleteUserPermission') ? undefined : json['enabledDeleteUserPermission'],
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

export function ClonePermissionRequestToJSON(value?: ClonePermissionRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'urls': value.urls,
        'sourceUser': ApiUserToJSON(value.sourceUser),
        'targetUser': ApiUserToJSON(value.targetUser),
        'cloneOption': ClonePermissionOptionToJSON(value.cloneOption),
        'additionalCloneOption': ClonePermissionAdditionalOptionToJSON(value.additionalCloneOption),
        'enabledRemoveExplicitPermission': value.enabledRemoveExplicitPermission,
        'enabledRemoveUserFromSPGroup': value.enabledRemoveUserFromSPGroup,
        'enabledDeleteUserPermission': value.enabledDeleteUserPermission,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


