/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    BooleanChangedProperty,
    BooleanChangedPropertyFromJSON,
    BooleanChangedPropertyFromJSONTyped,
    BooleanChangedPropertyToJSON,
    ChangeListSettingObjectInfo,
    ChangeListSettingObjectInfoFromJSON,
    ChangeListSettingObjectInfoFromJSONTyped,
    ChangeListSettingObjectInfoToJSON,
    ListVersionSettingsChangedProperty,
    ListVersionSettingsChangedPropertyFromJSON,
    ListVersionSettingsChangedPropertyFromJSONTyped,
    ListVersionSettingsChangedPropertyToJSON,
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
    StringChangedProperty,
    StringChangedPropertyFromJSON,
    StringChangedPropertyFromJSONTyped,
    StringChangedPropertyToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeListSettingRequest
 */
export interface ChangeListSettingRequest {
    /**
     * 
     * @type {ChangeListSettingObjectInfo}
     * @memberof ChangeListSettingRequest
     */
    objectInfo?: ChangeListSettingObjectInfo | null;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof ChangeListSettingRequest
     */
    listTitle?: StringChangedProperty | null;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof ChangeListSettingRequest
     */
    listDescription?: StringChangedProperty | null;
    /**
     * 
     * @type {BooleanChangedProperty}
     * @memberof ChangeListSettingRequest
     */
    navigationSetting?: BooleanChangedProperty | null;
    /**
     * 
     * @type {ListVersionSettingsChangedProperty}
     * @memberof ChangeListSettingRequest
     */
    versionSetting?: ListVersionSettingsChangedProperty | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeListSettingRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeListSettingRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeListSettingRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeListSettingRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeListSettingRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeListSettingRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeListSettingRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeListSettingRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeListSettingRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeListSettingRequestFromJSON(json: any): ChangeListSettingRequest {
    return ChangeListSettingRequestFromJSONTyped(json, false);
}

export function ChangeListSettingRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeListSettingRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'objectInfo': !exists(json, 'objectInfo') ? undefined : ChangeListSettingObjectInfoFromJSON(json['objectInfo']),
        'listTitle': !exists(json, 'listTitle') ? undefined : StringChangedPropertyFromJSON(json['listTitle']),
        'listDescription': !exists(json, 'listDescription') ? undefined : StringChangedPropertyFromJSON(json['listDescription']),
        'navigationSetting': !exists(json, 'navigationSetting') ? undefined : BooleanChangedPropertyFromJSON(json['navigationSetting']),
        'versionSetting': !exists(json, 'versionSetting') ? undefined : ListVersionSettingsChangedPropertyFromJSON(json['versionSetting']),
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

export function ChangeListSettingRequestToJSON(value?: ChangeListSettingRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'objectInfo': ChangeListSettingObjectInfoToJSON(value.objectInfo),
        'listTitle': StringChangedPropertyToJSON(value.listTitle),
        'listDescription': StringChangedPropertyToJSON(value.listDescription),
        'navigationSetting': BooleanChangedPropertyToJSON(value.navigationSetting),
        'versionSetting': ListVersionSettingsChangedPropertyToJSON(value.versionSetting),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


