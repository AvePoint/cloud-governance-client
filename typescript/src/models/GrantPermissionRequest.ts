/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ExternalUserSharingSettings,
    ExternalUserSharingSettingsFromJSON,
    ExternalUserSharingSettingsFromJSONTyped,
    ExternalUserSharingSettingsToJSON,
    GrantPermissionRequestDurationSettings,
    GrantPermissionRequestDurationSettingsFromJSON,
    GrantPermissionRequestDurationSettingsFromJSONTyped,
    GrantPermissionRequestDurationSettingsToJSON,
    GrantPermissionRequestPermissionSettings,
    GrantPermissionRequestPermissionSettingsFromJSON,
    GrantPermissionRequestPermissionSettingsFromJSONTyped,
    GrantPermissionRequestPermissionSettingsToJSON,
    GrantPermissionSPObject,
    GrantPermissionSPObjectFromJSON,
    GrantPermissionSPObjectFromJSONTyped,
    GrantPermissionSPObjectToJSON,
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
    SharingEnabledUser,
    SharingEnabledUserFromJSON,
    SharingEnabledUserFromJSONTyped,
    SharingEnabledUserToJSON,
    WelcomeEmailSettings,
    WelcomeEmailSettingsFromJSON,
    WelcomeEmailSettingsFromJSONTyped,
    WelcomeEmailSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionRequest
 */
export interface GrantPermissionRequest {
    /**
     * 
     * @type {GrantPermissionSPObject}
     * @memberof GrantPermissionRequest
     */
    url?: GrantPermissionSPObject | null;
    /**
     * 
     * @type {GrantPermissionRequestPermissionSettings}
     * @memberof GrantPermissionRequest
     */
    permissionSettings?: GrantPermissionRequestPermissionSettings | null;
    /**
     * 
     * @type {GrantPermissionRequestDurationSettings}
     * @memberof GrantPermissionRequest
     */
    permissionDurationSettings?: GrantPermissionRequestDurationSettings | null;
    /**
     * 
     * @type {Array<SharingEnabledUser>}
     * @memberof GrantPermissionRequest
     */
    selectedUsers?: Array<SharingEnabledUser> | null;
    /**
     * 
     * @type {ExternalUserSharingSettings}
     * @memberof GrantPermissionRequest
     */
    externalUserSharingSettings?: ExternalUserSharingSettings | null;
    /**
     * 
     * @type {WelcomeEmailSettings}
     * @memberof GrantPermissionRequest
     */
    welcomeEmailSettings?: WelcomeEmailSettings | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof GrantPermissionRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof GrantPermissionRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof GrantPermissionRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof GrantPermissionRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof GrantPermissionRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof GrantPermissionRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof GrantPermissionRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof GrantPermissionRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof GrantPermissionRequest
     */
    readonly fullPath?: string | null;
}

export function GrantPermissionRequestFromJSON(json: any): GrantPermissionRequest {
    return GrantPermissionRequestFromJSONTyped(json, false);
}

export function GrantPermissionRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'url': !exists(json, 'url') ? undefined : GrantPermissionSPObjectFromJSON(json['url']),
        'permissionSettings': !exists(json, 'permissionSettings') ? undefined : GrantPermissionRequestPermissionSettingsFromJSON(json['permissionSettings']),
        'permissionDurationSettings': !exists(json, 'permissionDurationSettings') ? undefined : GrantPermissionRequestDurationSettingsFromJSON(json['permissionDurationSettings']),
        'selectedUsers': !exists(json, 'selectedUsers') ? undefined : (json['selectedUsers'] === null ? null : (json['selectedUsers'] as Array<any>).map(SharingEnabledUserFromJSON)),
        'externalUserSharingSettings': !exists(json, 'externalUserSharingSettings') ? undefined : ExternalUserSharingSettingsFromJSON(json['externalUserSharingSettings']),
        'welcomeEmailSettings': !exists(json, 'welcomeEmailSettings') ? undefined : WelcomeEmailSettingsFromJSON(json['welcomeEmailSettings']),
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

export function GrantPermissionRequestToJSON(value?: GrantPermissionRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'url': GrantPermissionSPObjectToJSON(value.url),
        'permissionSettings': GrantPermissionRequestPermissionSettingsToJSON(value.permissionSettings),
        'permissionDurationSettings': GrantPermissionRequestDurationSettingsToJSON(value.permissionDurationSettings),
        'selectedUsers': value.selectedUsers === undefined ? undefined : (value.selectedUsers === null ? null : (value.selectedUsers as Array<any>).map(SharingEnabledUserToJSON)),
        'externalUserSharingSettings': ExternalUserSharingSettingsToJSON(value.externalUserSharingSettings),
        'welcomeEmailSettings': WelcomeEmailSettingsToJSON(value.welcomeEmailSettings),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


