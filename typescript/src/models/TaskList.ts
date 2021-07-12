/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    DueDateType,
    DueDateTypeFromJSON,
    DueDateTypeFromJSONTyped,
    DueDateTypeToJSON,
    RequestProgressStatus,
    RequestProgressStatusFromJSON,
    RequestProgressStatusFromJSONTyped,
    RequestProgressStatusToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    TaskResult,
    TaskResultFromJSON,
    TaskResultFromJSONTyped,
    TaskResultToJSON,
    TaskType,
    TaskTypeFromJSON,
    TaskTypeFromJSONTyped,
    TaskTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface TaskList
 */
export interface TaskList {
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    requester?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    requestId?: string;
    /**
     * 
     * @type {number}
     * @memberof TaskList
     */
    requestTicketNumber?: number;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    requesterDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    requesterEmail?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof TaskList
     */
    dueDate?: Date | null;
    /**
     * 
     * @type {DueDateType}
     * @memberof TaskList
     */
    dueDateType?: DueDateType;
    /**
     * 
     * @type {ServiceType}
     * @memberof TaskList
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof TaskList
     */
    createdTime?: Date;
    /**
     * 
     * @type {TaskType}
     * @memberof TaskList
     */
    taskType?: TaskType;
    /**
     * 
     * @type {TaskResult}
     * @memberof TaskList
     */
    status?: TaskResult;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    taskFullPath?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof TaskList
     */
    lastUpdated?: Date;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    category?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    categoryDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    serviceName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    objectId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskList
     */
    profileId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof TaskList
     */
    allowEdit?: boolean;
    /**
     * 
     * @type {RequestProgressStatus}
     * @memberof TaskList
     */
    progressStatus?: RequestProgressStatus;
}

export function TaskListFromJSON(json: any): TaskList {
    return TaskListFromJSONTyped(json, false);
}

export function TaskListFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'requester': !exists(json, 'requester') ? undefined : json['requester'],
        'requestId': !exists(json, 'requestId') ? undefined : json['requestId'],
        'requestTicketNumber': !exists(json, 'requestTicketNumber') ? undefined : json['requestTicketNumber'],
        'requesterDisplayName': !exists(json, 'requesterDisplayName') ? undefined : json['requesterDisplayName'],
        'requesterEmail': !exists(json, 'requesterEmail') ? undefined : json['requesterEmail'],
        'dueDate': !exists(json, 'dueDate') ? undefined : (json['dueDate'] === null ? null : new Date(json['dueDate'])),
        'dueDateType': !exists(json, 'dueDateType') ? undefined : DueDateTypeFromJSON(json['dueDateType']),
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
        'createdTime': !exists(json, 'createdTime') ? undefined : (new Date(json['createdTime'])),
        'taskType': !exists(json, 'taskType') ? undefined : TaskTypeFromJSON(json['taskType']),
        'status': !exists(json, 'status') ? undefined : TaskResultFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'taskFullPath': !exists(json, 'taskFullPath') ? undefined : json['taskFullPath'],
        'lastUpdated': !exists(json, 'lastUpdated') ? undefined : (new Date(json['lastUpdated'])),
        'category': !exists(json, 'category') ? undefined : json['category'],
        'categoryDisplayName': !exists(json, 'categoryDisplayName') ? undefined : json['categoryDisplayName'],
        'serviceName': !exists(json, 'serviceName') ? undefined : json['serviceName'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'profileId': !exists(json, 'profileId') ? undefined : json['profileId'],
        'allowEdit': !exists(json, 'allowEdit') ? undefined : json['allowEdit'],
        'progressStatus': !exists(json, 'progressStatus') ? undefined : RequestProgressStatusFromJSON(json['progressStatus']),
    };
}

export function TaskListToJSON(value?: TaskList | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'title': value.title,
        'requester': value.requester,
        'requestId': value.requestId,
        'requestTicketNumber': value.requestTicketNumber,
        'requesterDisplayName': value.requesterDisplayName,
        'requesterEmail': value.requesterEmail,
        'dueDate': value.dueDate === undefined ? undefined : (value.dueDate === null ? null : value.dueDate.toISOString()),
        'dueDateType': DueDateTypeToJSON(value.dueDateType),
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'taskType': TaskTypeToJSON(value.taskType),
        'status': TaskResultToJSON(value.status),
        'statusDescription': value.statusDescription,
        'taskFullPath': value.taskFullPath,
        'lastUpdated': value.lastUpdated === undefined ? undefined : (value.lastUpdated.toISOString()),
        'category': value.category,
        'categoryDisplayName': value.categoryDisplayName,
        'serviceName': value.serviceName,
        'objectId': value.objectId,
        'profileId': value.profileId,
        'allowEdit': value.allowEdit,
        'progressStatus': RequestProgressStatusToJSON(value.progressStatus),
    };
}


