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
 * @interface AllRequestList
 */
export interface AllRequestList {
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    serviceId?: string;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    serviceName?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof AllRequestList
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {number}
     * @memberof AllRequestList
     */
    ticketNumber?: number;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    summary?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    requester?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    requesterDisplayName?: string | null;
    /**
     * 
     * @type {RequestProgressStatus}
     * @memberof AllRequestList
     */
    detailStatus?: RequestProgressStatus;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    detailStatusDescription?: string | null;
    /**
     * 
     * @type {ApiRequestProgressStatus}
     * @memberof AllRequestList
     */
    progressStatus?: ApiRequestProgressStatus;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    progressStatusDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof AllRequestList
     */
    modified?: Date;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    assignTo?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    assignToDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    serviceAdmin?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    serviceAdminDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    objectUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllRequestList
     */
    createdTime?: string | null;
}

export function AllRequestListFromJSON(json: any): AllRequestList {
    return AllRequestListFromJSONTyped(json, false);
}

export function AllRequestListFromJSONTyped(json: any, ignoreDiscriminator: boolean): AllRequestList {
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
        'requester': !exists(json, 'requester') ? undefined : json['requester'],
        'requesterDisplayName': !exists(json, 'requesterDisplayName') ? undefined : json['requesterDisplayName'],
        'detailStatus': !exists(json, 'detailStatus') ? undefined : RequestProgressStatusFromJSON(json['detailStatus']),
        'detailStatusDescription': !exists(json, 'detailStatusDescription') ? undefined : json['detailStatusDescription'],
        'progressStatus': !exists(json, 'progressStatus') ? undefined : ApiRequestProgressStatusFromJSON(json['progressStatus']),
        'progressStatusDescription': !exists(json, 'progressStatusDescription') ? undefined : json['progressStatusDescription'],
        'modified': !exists(json, 'modified') ? undefined : (new Date(json['modified'])),
        'assignTo': !exists(json, 'assignTo') ? undefined : json['assignTo'],
        'assignToDisplayName': !exists(json, 'assignToDisplayName') ? undefined : json['assignToDisplayName'],
        'serviceAdmin': !exists(json, 'serviceAdmin') ? undefined : json['serviceAdmin'],
        'serviceAdminDisplayName': !exists(json, 'serviceAdminDisplayName') ? undefined : json['serviceAdminDisplayName'],
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'createdTime': !exists(json, 'createdTime') ? undefined : json['createdTime'],
    };
}

export function AllRequestListToJSON(value?: AllRequestList | null): any {
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
        'requester': value.requester,
        'requesterDisplayName': value.requesterDisplayName,
        'detailStatus': RequestProgressStatusToJSON(value.detailStatus),
        'detailStatusDescription': value.detailStatusDescription,
        'progressStatus': ApiRequestProgressStatusToJSON(value.progressStatus),
        'progressStatusDescription': value.progressStatusDescription,
        'modified': value.modified === undefined ? undefined : (value.modified.toISOString()),
        'assignTo': value.assignTo,
        'assignToDisplayName': value.assignToDisplayName,
        'serviceAdmin': value.serviceAdmin,
        'serviceAdminDisplayName': value.serviceAdminDisplayName,
        'objectUrl': value.objectUrl,
        'createdTime': value.createdTime,
    };
}


