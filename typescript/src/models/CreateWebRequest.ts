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
    IntModel,
    IntModelFromJSON,
    IntModelFromJSONTyped,
    IntModelToJSON,
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
    YammerGroupRequestSettings,
    YammerGroupRequestSettingsFromJSON,
    YammerGroupRequestSettingsFromJSONTyped,
    YammerGroupRequestSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateWebRequest
 */
export interface CreateWebRequest {
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    webName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    webTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    webDescription?: string | null;
    /**
     * 
     * @type {IntModel}
     * @memberof CreateWebRequest
     */
    webLanguage?: IntModel | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    webTemplate?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    parentSiteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    parentWebUrl?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebRequest
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebRequest
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {Array<RequestUserWithPermissions>}
     * @memberof CreateWebRequest
     */
    userPermissions?: Array<RequestUserWithPermissions> | null;
    /**
     * 
     * @type {Array<RequestGroupWithPermissions>}
     * @memberof CreateWebRequest
     */
    groupPermissions?: Array<RequestGroupWithPermissions> | null;
    /**
     * Yammer community request settings model
     * @type {YammerGroupRequestSettings}
     * @memberof CreateWebRequest
     */
    yammerGroupSettings?: YammerGroupRequestSettings | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebRequest
     */
    isOnQuickLaunch?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebRequest
     */
    isOnTopLinkBar?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebRequest
     */
    isInheritance?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateWebRequest
     */
    deploymentManagerPlanName?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof CreateWebRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof CreateWebRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof CreateWebRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof CreateWebRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof CreateWebRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof CreateWebRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof CreateWebRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof CreateWebRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof CreateWebRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof CreateWebRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof CreateWebRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof CreateWebRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof CreateWebRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof CreateWebRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof CreateWebRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof CreateWebRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof CreateWebRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof CreateWebRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof CreateWebRequest
     */
    readonly fullPath?: string | null;
}

export function CreateWebRequestFromJSON(json: any): CreateWebRequest {
    return CreateWebRequestFromJSONTyped(json, false);
}

export function CreateWebRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateWebRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'webName': !exists(json, 'webName') ? undefined : json['webName'],
        'webTitle': !exists(json, 'webTitle') ? undefined : json['webTitle'],
        'webDescription': !exists(json, 'webDescription') ? undefined : json['webDescription'],
        'webLanguage': !exists(json, 'webLanguage') ? undefined : IntModelFromJSON(json['webLanguage']),
        'webTemplate': !exists(json, 'webTemplate') ? undefined : json['webTemplate'],
        'parentSiteUrl': !exists(json, 'parentSiteUrl') ? undefined : json['parentSiteUrl'],
        'parentWebUrl': !exists(json, 'parentWebUrl') ? undefined : json['parentWebUrl'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'userPermissions': !exists(json, 'userPermissions') ? undefined : (json['userPermissions'] === null ? null : (json['userPermissions'] as Array<any>).map(RequestUserWithPermissionsFromJSON)),
        'groupPermissions': !exists(json, 'groupPermissions') ? undefined : (json['groupPermissions'] === null ? null : (json['groupPermissions'] as Array<any>).map(RequestGroupWithPermissionsFromJSON)),
        'yammerGroupSettings': !exists(json, 'yammerGroupSettings') ? undefined : YammerGroupRequestSettingsFromJSON(json['yammerGroupSettings']),
        'isOnQuickLaunch': !exists(json, 'isOnQuickLaunch') ? undefined : json['isOnQuickLaunch'],
        'isOnTopLinkBar': !exists(json, 'isOnTopLinkBar') ? undefined : json['isOnTopLinkBar'],
        'isInheritance': !exists(json, 'isInheritance') ? undefined : json['isInheritance'],
        'deploymentManagerPlanName': !exists(json, 'deploymentManagerPlanName') ? undefined : json['deploymentManagerPlanName'],
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

export function CreateWebRequestToJSON(value?: CreateWebRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'webName': value.webName,
        'webTitle': value.webTitle,
        'webDescription': value.webDescription,
        'webLanguage': IntModelToJSON(value.webLanguage),
        'webTemplate': value.webTemplate,
        'parentSiteUrl': value.parentSiteUrl,
        'parentWebUrl': value.parentWebUrl,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'userPermissions': value.userPermissions === undefined ? undefined : (value.userPermissions === null ? null : (value.userPermissions as Array<any>).map(RequestUserWithPermissionsToJSON)),
        'groupPermissions': value.groupPermissions === undefined ? undefined : (value.groupPermissions === null ? null : (value.groupPermissions as Array<any>).map(RequestGroupWithPermissionsToJSON)),
        'yammerGroupSettings': YammerGroupRequestSettingsToJSON(value.yammerGroupSettings),
        'isOnQuickLaunch': value.isOnQuickLaunch,
        'isOnTopLinkBar': value.isOnTopLinkBar,
        'isInheritance': value.isInheritance,
        'deploymentManagerPlanName': value.deploymentManagerPlanName,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


