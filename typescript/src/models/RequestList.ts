/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiRequestProgressStatus,
    ApiRequestProgressStatusFromJSON,
    ApiRequestProgressStatusFromJSONTyped,
    ApiRequestProgressStatusToJSON,
    RequestProgressStatus,
    RequestProgressStatusFromJSON,
    RequestProgressStatusFromJSONTyped,
    RequestProgressStatusToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface RequestList
 */
export interface RequestList {
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    serviceId?: string;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    serviceName?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof RequestList
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {number}
     * @memberof RequestList
     */
    ticketNumber?: number;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    summary?: string | null;
    /**
     * 
     * @type {RequestProgressStatus}
     * @memberof RequestList
     */
    status?: RequestProgressStatus;
    /**
     * 
     * @type {ApiRequestProgressStatus}
     * @memberof RequestList
     */
    processStatus?: ApiRequestProgressStatus;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof RequestList
     */
    modified?: Date;
    /**
     * 
     * @type {number}
     * @memberof RequestList
     */
    submitStatus?: number;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    assigned?: string | null;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    serviceAdmin?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof RequestList
     */
    enabledCopy?: boolean;
    /**
     * 
     * @type {string}
     * @memberof RequestList
     */
    questionnaireId?: string;
}

export function RequestListFromJSON(json: any): RequestList {
    return RequestListFromJSONTyped(json, false);
}

export function RequestListFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'serviceId': !exists(json, 'serviceId') ? undefined : json['serviceId'],
        'serviceName': !exists(json, 'serviceName') ? undefined : json['serviceName'],
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
        'ticketNumber': !exists(json, 'ticketNumber') ? undefined : json['ticketNumber'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
        'status': !exists(json, 'status') ? undefined : RequestProgressStatusFromJSON(json['status']),
        'processStatus': !exists(json, 'processStatus') ? undefined : ApiRequestProgressStatusFromJSON(json['processStatus']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'modified': !exists(json, 'modified') ? undefined : (new Date(json['modified'])),
        'submitStatus': !exists(json, 'submitStatus') ? undefined : json['submitStatus'],
        'assigned': !exists(json, 'assigned') ? undefined : json['assigned'],
        'serviceAdmin': !exists(json, 'serviceAdmin') ? undefined : json['serviceAdmin'],
        'enabledCopy': !exists(json, 'enabledCopy') ? undefined : json['enabledCopy'],
        'questionnaireId': !exists(json, 'questionnaireId') ? undefined : json['questionnaireId'],
    };
}

export function RequestListToJSON(value?: RequestList | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'serviceId': value.serviceId,
        'serviceName': value.serviceName,
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'ticketNumber': value.ticketNumber,
        'summary': value.summary,
        'status': RequestProgressStatusToJSON(value.status),
        'processStatus': ApiRequestProgressStatusToJSON(value.processStatus),
        'statusDescription': value.statusDescription,
        'modified': value.modified === undefined ? undefined : (value.modified.toISOString()),
        'submitStatus': value.submitStatus,
        'assigned': value.assigned,
        'serviceAdmin': value.serviceAdmin,
        'enabledCopy': value.enabledCopy,
        'questionnaireId': value.questionnaireId,
    };
}


