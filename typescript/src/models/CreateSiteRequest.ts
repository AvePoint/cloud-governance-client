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
    GeoLocationBase,
    GeoLocationBaseFromJSON,
    GeoLocationBaseFromJSONTyped,
    GeoLocationBaseToJSON,
    HubSiteSettings,
    HubSiteSettingsFromJSON,
    HubSiteSettingsFromJSONTyped,
    HubSiteSettingsToJSON,
    RequestGroupWithPermissions,
    RequestGroupWithPermissionsFromJSON,
    RequestGroupWithPermissionsFromJSONTyped,
    RequestGroupWithPermissionsToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
    RequestStatus,
    RequestStatusFromJSON,
    RequestStatusFromJSONTyped,
    RequestStatusToJSON,
    RequestUserWithPermissions,
    RequestUserWithPermissionsFromJSON,
    RequestUserWithPermissionsFromJSONTyped,
    RequestUserWithPermissionsToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    SiteLeasePeriodRequestSettings,
    SiteLeasePeriodRequestSettingsFromJSON,
    SiteLeasePeriodRequestSettingsFromJSONTyped,
    SiteLeasePeriodRequestSettingsToJSON,
    SiteUrl,
    SiteUrlFromJSON,
    SiteUrlFromJSONTyped,
    SiteUrlToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelFromJSONTyped,
    StringModelToJSON,
    YammerGroupRequestSettings,
    YammerGroupRequestSettingsFromJSON,
    YammerGroupRequestSettingsFromJSONTyped,
    YammerGroupRequestSettingsToJSON,
} from './';

/**
 * Create collection requesst model
 * @export
 * @interface CreateSiteRequest
 */
export interface CreateSiteRequest {
    /**
     * Site collection title
     * @type {string}
     * @memberof CreateSiteRequest
     */
    siteTitle?: string | null;
    /**
     * Site collection description
     * @type {string}
     * @memberof CreateSiteRequest
     */
    siteDescription?: string | null;
    /**
     * Site collection url information
     * @type {SiteUrl}
     * @memberof CreateSiteRequest
     */
    siteUrl?: SiteUrl | null;
    /**
     * Site collection policy id, you can use GetCreateSiteService api to get all the available policy ids and names.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    policyId?: string | null;
    /**
     * Site collection time zone id, you can use GetCreateSiteService api to get all the available time zone ids and names.
     * @type {number}
     * @memberof CreateSiteRequest
     */
    timeZone?: number | null;
    /**
     * Site collection language id, you can use GetCreateSiteService api to get all the available language ids and names.
     * @type {number}
     * @memberof CreateSiteRequest
     */
    language?: number;
    /**
     * Site collection template id, you can use GetCreateSiteService api to get all the available template ids and names.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    template?: string | null;
    /**
     * Deployment manager plan name, you can use GetCreateSiteService api to get all the available deployment manager plan names.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    deploymentManagerPlanName?: string | null;
    /**
     * Primary site collection administrator
     * @type {ApiUser}
     * @memberof CreateSiteRequest
     */
    primaryAdmin?: ApiUser | null;
    /**
     * Additional site collection administrator
     * @type {Array<ApiUser>}
     * @memberof CreateSiteRequest
     */
    additionalAdmins?: Array<ApiUser> | null;
    /**
     * Primary site collection contact
     * @type {ApiUser}
     * @memberof CreateSiteRequest
     */
    primaryContact?: ApiUser | null;
    /**
     * Secondary site collection contact
     * @type {ApiUser}
     * @memberof CreateSiteRequest
     */
    secondaryContact?: ApiUser | null;
    /**
     * Communication site design
     * @type {StringModel}
     * @memberof CreateSiteRequest
     */
    siteDesign?: StringModel | null;
    /**
     * Team site design
     * @type {string}
     * @memberof CreateSiteRequest
     */
    teamSiteDesign?: string | null;
    /**
     * Communication site Classification
     * @type {string}
     * @memberof CreateSiteRequest
     */
    classification?: string | null;
    /**
     * Sensitive lable
     * @type {string}
     * @memberof CreateSiteRequest
     */
    sensitivity?: string | null;
    /**
     * Hub site setting
     * @type {HubSiteSettings}
     * @memberof CreateSiteRequest
     */
    hubSiteSettings?: HubSiteSettings | null;
    /**
     * Granted user/group permission setting
     * @type {Array<RequestUserWithPermissions>}
     * @memberof CreateSiteRequest
     */
    userPermissions?: Array<RequestUserWithPermissions> | null;
    /**
     * Site collection SharePoint group setting
     * @type {Array<RequestGroupWithPermissions>}
     * @memberof CreateSiteRequest
     */
    groupPermissions?: Array<RequestGroupWithPermissions> | null;
    /**
     * Yammer group setting
     * @type {YammerGroupRequestSettings}
     * @memberof CreateSiteRequest
     */
    yammerGroupSettings?: YammerGroupRequestSettings | null;
    /**
     * Lease period setting
     * @type {SiteLeasePeriodRequestSettings}
     * @memberof CreateSiteRequest
     */
    leasePeriodSettings?: SiteLeasePeriodRequestSettings | null;
    /**
     * Multi-geo location
     * @type {GeoLocationBase}
     * @memberof CreateSiteRequest
     */
    multiGeoLocation?: GeoLocationBase | null;
    /**
     * Site collection title without prefix and sufix when service enables constructing title
     * @type {string}
     * @memberof CreateSiteRequest
     */
    inputTitle?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof CreateSiteRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof CreateSiteRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof CreateSiteRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof CreateSiteRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof CreateSiteRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof CreateSiteRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof CreateSiteRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof CreateSiteRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof CreateSiteRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof CreateSiteRequest
     */
    readonly fullPath?: string | null;
}

export function CreateSiteRequestFromJSON(json: any): CreateSiteRequest {
    return CreateSiteRequestFromJSONTyped(json, false);
}

export function CreateSiteRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateSiteRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteTitle': !exists(json, 'siteTitle') ? undefined : json['siteTitle'],
        'siteDescription': !exists(json, 'siteDescription') ? undefined : json['siteDescription'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : SiteUrlFromJSON(json['siteUrl']),
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'timeZone': !exists(json, 'timeZone') ? undefined : json['timeZone'],
        'language': !exists(json, 'language') ? undefined : json['language'],
        'template': !exists(json, 'template') ? undefined : json['template'],
        'deploymentManagerPlanName': !exists(json, 'deploymentManagerPlanName') ? undefined : json['deploymentManagerPlanName'],
        'primaryAdmin': !exists(json, 'primaryAdmin') ? undefined : ApiUserFromJSON(json['primaryAdmin']),
        'additionalAdmins': !exists(json, 'additionalAdmins') ? undefined : (json['additionalAdmins'] === null ? null : (json['additionalAdmins'] as Array<any>).map(ApiUserFromJSON)),
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'siteDesign': !exists(json, 'siteDesign') ? undefined : StringModelFromJSON(json['siteDesign']),
        'teamSiteDesign': !exists(json, 'teamSiteDesign') ? undefined : json['teamSiteDesign'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'sensitivity': !exists(json, 'sensitivity') ? undefined : json['sensitivity'],
        'hubSiteSettings': !exists(json, 'hubSiteSettings') ? undefined : HubSiteSettingsFromJSON(json['hubSiteSettings']),
        'userPermissions': !exists(json, 'userPermissions') ? undefined : (json['userPermissions'] === null ? null : (json['userPermissions'] as Array<any>).map(RequestUserWithPermissionsFromJSON)),
        'groupPermissions': !exists(json, 'groupPermissions') ? undefined : (json['groupPermissions'] === null ? null : (json['groupPermissions'] as Array<any>).map(RequestGroupWithPermissionsFromJSON)),
        'yammerGroupSettings': !exists(json, 'yammerGroupSettings') ? undefined : YammerGroupRequestSettingsFromJSON(json['yammerGroupSettings']),
        'leasePeriodSettings': !exists(json, 'leasePeriodSettings') ? undefined : SiteLeasePeriodRequestSettingsFromJSON(json['leasePeriodSettings']),
        'multiGeoLocation': !exists(json, 'multiGeoLocation') ? undefined : GeoLocationBaseFromJSON(json['multiGeoLocation']),
        'inputTitle': !exists(json, 'inputTitle') ? undefined : json['inputTitle'],
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

export function CreateSiteRequestToJSON(value?: CreateSiteRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteTitle': value.siteTitle,
        'siteDescription': value.siteDescription,
        'siteUrl': SiteUrlToJSON(value.siteUrl),
        'policyId': value.policyId,
        'timeZone': value.timeZone,
        'language': value.language,
        'template': value.template,
        'deploymentManagerPlanName': value.deploymentManagerPlanName,
        'primaryAdmin': ApiUserToJSON(value.primaryAdmin),
        'additionalAdmins': value.additionalAdmins === undefined ? undefined : (value.additionalAdmins === null ? null : (value.additionalAdmins as Array<any>).map(ApiUserToJSON)),
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'siteDesign': StringModelToJSON(value.siteDesign),
        'teamSiteDesign': value.teamSiteDesign,
        'classification': value.classification,
        'sensitivity': value.sensitivity,
        'hubSiteSettings': HubSiteSettingsToJSON(value.hubSiteSettings),
        'userPermissions': value.userPermissions === undefined ? undefined : (value.userPermissions === null ? null : (value.userPermissions as Array<any>).map(RequestUserWithPermissionsToJSON)),
        'groupPermissions': value.groupPermissions === undefined ? undefined : (value.groupPermissions === null ? null : (value.groupPermissions as Array<any>).map(RequestGroupWithPermissionsToJSON)),
        'yammerGroupSettings': YammerGroupRequestSettingsToJSON(value.yammerGroupSettings),
        'leasePeriodSettings': SiteLeasePeriodRequestSettingsToJSON(value.leasePeriodSettings),
        'multiGeoLocation': GeoLocationBaseToJSON(value.multiGeoLocation),
        'inputTitle': value.inputTitle,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


