/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    HubSiteChangedSettings,
    HubSiteChangedSettingsFromJSON,
    HubSiteChangedSettingsFromJSONTyped,
    HubSiteChangedSettingsToJSON,
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
 * @interface ChangeSiteSettingRequest
 */
export interface ChangeSiteSettingRequest {
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    siteUrl?: string | null;
    /**
     * Site title
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    siteTitle?: string | null;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof ChangeSiteSettingRequest
     */
    siteTitleSetting?: StringChangedProperty | null;
    /**
     * 
     * @type {StringChangedProperty}
     * @memberof ChangeSiteSettingRequest
     */
    siteDescriptionSetting?: StringChangedProperty | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingRequest
     */
    readonly enableChangedMetadata?: boolean;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof ChangeSiteSettingRequest
     */
    changedMetadatas?: Array<RequestMetadata> | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof ChangeSiteSettingRequest
     */
    readonly originalSiteMetadatas?: Array<RequestMetadata> | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    deploymentPlanName?: string | null;
    /**
     * 
     * @type {HubSiteChangedSettings}
     * @memberof ChangeSiteSettingRequest
     */
    hubSiteSettings?: HubSiteChangedSettings | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeSiteSettingRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeSiteSettingRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeSiteSettingRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeSiteSettingRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeSiteSettingRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeSiteSettingRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeSiteSettingRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeSiteSettingRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeSiteSettingRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeSiteSettingRequestFromJSON(json: any): ChangeSiteSettingRequest {
    return ChangeSiteSettingRequestFromJSONTyped(json, false);
}

export function ChangeSiteSettingRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteSettingRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'siteTitle': !exists(json, 'siteTitle') ? undefined : json['siteTitle'],
        'siteTitleSetting': !exists(json, 'siteTitleSetting') ? undefined : StringChangedPropertyFromJSON(json['siteTitleSetting']),
        'siteDescriptionSetting': !exists(json, 'siteDescriptionSetting') ? undefined : StringChangedPropertyFromJSON(json['siteDescriptionSetting']),
        'enableChangedMetadata': !exists(json, 'enableChangedMetadata') ? undefined : json['enableChangedMetadata'],
        'changedMetadatas': !exists(json, 'changedMetadatas') ? undefined : (json['changedMetadatas'] === null ? null : (json['changedMetadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'originalSiteMetadatas': !exists(json, 'originalSiteMetadatas') ? undefined : (json['originalSiteMetadatas'] === null ? null : (json['originalSiteMetadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'deploymentPlanName': !exists(json, 'deploymentPlanName') ? undefined : json['deploymentPlanName'],
        'hubSiteSettings': !exists(json, 'hubSiteSettings') ? undefined : HubSiteChangedSettingsFromJSON(json['hubSiteSettings']),
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

export function ChangeSiteSettingRequestToJSON(value?: ChangeSiteSettingRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'siteTitle': value.siteTitle,
        'siteTitleSetting': StringChangedPropertyToJSON(value.siteTitleSetting),
        'siteDescriptionSetting': StringChangedPropertyToJSON(value.siteDescriptionSetting),
        'changedMetadatas': value.changedMetadatas === undefined ? undefined : (value.changedMetadatas === null ? null : (value.changedMetadatas as Array<any>).map(RequestMetadataToJSON)),
        'deploymentPlanName': value.deploymentPlanName,
        'hubSiteSettings': HubSiteChangedSettingsToJSON(value.hubSiteSettings),
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


