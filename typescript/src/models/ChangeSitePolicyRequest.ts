/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
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
    SiteLifecycleActionType,
    SiteLifecycleActionTypeFromJSON,
    SiteLifecycleActionTypeFromJSONTyped,
    SiteLifecycleActionTypeToJSON,
    StartDateType,
    StartDateTypeFromJSON,
    StartDateTypeFromJSONTyped,
    StartDateTypeToJSON,
} from './';

/**
 * Change site collection policy request model
 * @export
 * @interface ChangeSitePolicyRequest
 */
export interface ChangeSitePolicyRequest {
    /**
     * The new site collection policy information settings
     * @type {GuidModel}
     * @memberof ChangeSitePolicyRequest
     */
    policy?: GuidModel | null;
    /**
     * The original site collection policy information settings
     * @type {GuidModel}
     * @memberof ChangeSitePolicyRequest
     */
    readonly originalPolicy?: GuidModel | null;
    /**
     * Whether to enable the site collection lease extension.
     * @type {boolean}
     * @memberof ChangeSitePolicyRequest
     */
    isLeaseEnabled?: boolean;
    /**
     * Set how to assign the site collection policy.
     * @type {AssignBy}
     * @memberof ChangeSitePolicyRequest
     */
    changePolicyConfig?: AssignBy;
    /**
     * Site collection lease start date configuration after a policy change
     * @type {StartDateType}
     * @memberof ChangeSitePolicyRequest
     */
    startDateType?: StartDateType;
    /**
     * New lease start date
     * @type {Date}
     * @memberof ChangeSitePolicyRequest
     */
    specifyStartDate?: Date | null;
    /**
     * Lifecycle management action type
     * @type {SiteLifecycleActionType}
     * @memberof ChangeSitePolicyRequest
     */
    action?: SiteLifecycleActionType;
    /**
     * Description of lifecycle management actions. You can get all available description of lifecycle management actions by invoking the GetSiteLifecycleService api.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly actionDescription?: string | null;
    /**
     * Site collection ID
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    siteId?: string;
    /**
     * Site collection URL
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    siteUrl?: string | null;
    /**
     * Id of request.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    id?: string | null;
    /**
     * Id of service.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    serviceId?: string;
    /**
     * Summary of request.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    summary?: string | null;
    /**
     * Notes to approvers.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    notesToApprovers?: string | null;
    /**
     * Id of questionnaire
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    questionnaireId?: string | null;
    /**
     * Metadata of request.
     * @type {Array<RequestMetadata>}
     * @memberof ChangeSitePolicyRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * Ticket number of request.
     * @type {number}
     * @memberof ChangeSitePolicyRequest
     */
    readonly ticketNumber?: number | null;
    /**
     * Service type of request.
     * @type {ServiceType}
     * @memberof ChangeSitePolicyRequest
     */
    readonly type?: ServiceType | null;
    /**
     * Service type description of request.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly typeDescription?: string | null;
    /**
     * Requester display name.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly requester?: string | null;
    /**
     * Requester login name.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly requesterLoginName?: string | null;
    /**
     * Status of request.
     * @type {RequestStatus}
     * @memberof ChangeSitePolicyRequest
     */
    readonly status?: RequestStatus | null;
    /**
     * Progress status of request.
     * @type {number}
     * @memberof ChangeSitePolicyRequest
     */
    readonly progressStatus?: number;
    /**
     * Progress status description of request.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly progressStatusDescription?: string | null;
    /**
     * Submitted time of request.
     * @type {Date}
     * @memberof ChangeSitePolicyRequest
     */
    readonly submittedTime?: Date | null;
    /**
     * Last updated time of request.
     * @type {Date}
     * @memberof ChangeSitePolicyRequest
     */
    readonly lastUpdated?: Date | null;
    /**
     * Created time of request.
     * @type {Date}
     * @memberof ChangeSitePolicyRequest
     */
    readonly createdTime?: Date | null;
    /**
     * Task assignee of request.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly assignTo?: string | null;
    /**
     * Object full path of request.
     * @type {string}
     * @memberof ChangeSitePolicyRequest
     */
    readonly fullPath?: string | null;
}

export function ChangeSitePolicyRequestFromJSON(json: any): ChangeSitePolicyRequest {
    return ChangeSitePolicyRequestFromJSONTyped(json, false);
}

export function ChangeSitePolicyRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSitePolicyRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'policy': !exists(json, 'policy') ? undefined : GuidModelFromJSON(json['policy']),
        'originalPolicy': !exists(json, 'originalPolicy') ? undefined : GuidModelFromJSON(json['originalPolicy']),
        'isLeaseEnabled': !exists(json, 'isLeaseEnabled') ? undefined : json['isLeaseEnabled'],
        'changePolicyConfig': !exists(json, 'changePolicyConfig') ? undefined : AssignByFromJSON(json['changePolicyConfig']),
        'startDateType': !exists(json, 'startDateType') ? undefined : StartDateTypeFromJSON(json['startDateType']),
        'specifyStartDate': !exists(json, 'specifyStartDate') ? undefined : (json['specifyStartDate'] === null ? null : new Date(json['specifyStartDate'])),
        'action': !exists(json, 'action') ? undefined : SiteLifecycleActionTypeFromJSON(json['action']),
        'actionDescription': !exists(json, 'actionDescription') ? undefined : json['actionDescription'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
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

export function ChangeSitePolicyRequestToJSON(value?: ChangeSitePolicyRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'policy': GuidModelToJSON(value.policy),
        'isLeaseEnabled': value.isLeaseEnabled,
        'changePolicyConfig': AssignByToJSON(value.changePolicyConfig),
        'startDateType': StartDateTypeToJSON(value.startDateType),
        'specifyStartDate': value.specifyStartDate === undefined ? undefined : (value.specifyStartDate === null ? null : value.specifyStartDate.toISOString()),
        'action': SiteLifecycleActionTypeToJSON(value.action),
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'id': value.id,
        'serviceId': value.serviceId,
        'summary': value.summary,
        'notesToApprovers': value.notesToApprovers,
        'questionnaireId': value.questionnaireId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
    };
}


