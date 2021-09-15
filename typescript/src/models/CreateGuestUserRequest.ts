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
    CreateGuestUserSubRequest,
    CreateGuestUserSubRequestFromJSON,
    CreateGuestUserSubRequestFromJSONTyped,
    CreateGuestUserSubRequestToJSON,
    GuestUserPropertyModel,
    GuestUserPropertyModelFromJSON,
    GuestUserPropertyModelFromJSONTyped,
    GuestUserPropertyModelToJSON,
    GuestUserRequestOneTimeRenewalSettingModel,
    GuestUserRequestOneTimeRenewalSettingModelFromJSON,
    GuestUserRequestOneTimeRenewalSettingModelFromJSONTyped,
    GuestUserRequestOneTimeRenewalSettingModelToJSON,
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
 * @interface CreateGuestUserRequest
 */
export interface CreateGuestUserRequest {
    /**
     * 
     * @type {GuestUserPropertyModel}
     * @memberof CreateGuestUserRequest
     */
    userProperties?: GuestUserPropertyModel | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    welcomeEmailMessage?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserRequest
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserRequest
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGuestUserRequest
     */
    inviteGroups?: Array<ApiUser> | null;
    /**
     * 
     * @type {GuestUserRequestOneTimeRenewalSettingModel}
     * @memberof CreateGuestUserRequest
     */
    oneTimeSettings?: GuestUserRequestOneTimeRenewalSettingModel | null;
    /**
     * 
     * @type {Array<CreateGuestUserSubRequest>}
     * @memberof CreateGuestUserRequest
     */
    subRequestInfos?: Array<CreateGuestUserSubRequest> | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof CreateGuestUserRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof CreateGuestUserRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof CreateGuestUserRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof CreateGuestUserRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof CreateGuestUserRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof CreateGuestUserRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof CreateGuestUserRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof CreateGuestUserRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof CreateGuestUserRequest
     */
    readonly fullPath?: string | null;
}

export function CreateGuestUserRequestFromJSON(json: any): CreateGuestUserRequest {
    return CreateGuestUserRequestFromJSONTyped(json, false);
}

export function CreateGuestUserRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGuestUserRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'userProperties': !exists(json, 'userProperties') ? undefined : GuestUserPropertyModelFromJSON(json['userProperties']),
        'welcomeEmailMessage': !exists(json, 'welcomeEmailMessage') ? undefined : json['welcomeEmailMessage'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'inviteGroups': !exists(json, 'inviteGroups') ? undefined : (json['inviteGroups'] === null ? null : (json['inviteGroups'] as Array<any>).map(ApiUserFromJSON)),
        'oneTimeSettings': !exists(json, 'oneTimeSettings') ? undefined : GuestUserRequestOneTimeRenewalSettingModelFromJSON(json['oneTimeSettings']),
        'subRequestInfos': !exists(json, 'subRequestInfos') ? undefined : (json['subRequestInfos'] === null ? null : (json['subRequestInfos'] as Array<any>).map(CreateGuestUserSubRequestFromJSON)),
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

export function CreateGuestUserRequestToJSON(value?: CreateGuestUserRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userProperties': GuestUserPropertyModelToJSON(value.userProperties),
        'welcomeEmailMessage': value.welcomeEmailMessage,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'inviteGroups': value.inviteGroups === undefined ? undefined : (value.inviteGroups === null ? null : (value.inviteGroups as Array<any>).map(ApiUserToJSON)),
        'oneTimeSettings': GuestUserRequestOneTimeRenewalSettingModelToJSON(value.oneTimeSettings),
        'subRequestInfos': value.subRequestInfos === undefined ? undefined : (value.subRequestInfos === null ? null : (value.subRequestInfos as Array<any>).map(CreateGuestUserSubRequestToJSON)),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


