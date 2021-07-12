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
 * @interface TaskReport
 */
export interface TaskReport {
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    requestId?: string;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    requester?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    requesterLoginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    requesterDisplayName?: string | null;
    /**
     * 
     * @type {number}
     * @memberof TaskReport
     */
    requestTicketNumber?: number;
    /**
     * 
     * @type {Date}
     * @memberof TaskReport
     */
    dueDate?: Date | null;
    /**
     * 
     * @type {DueDateType}
     * @memberof TaskReport
     */
    dueDateType?: DueDateType;
    /**
     * 
     * @type {ServiceType}
     * @memberof TaskReport
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof TaskReport
     */
    createdTime?: Date;
    /**
     * 
     * @type {Date}
     * @memberof TaskReport
     */
    taskLastModifiedTime?: Date;
    /**
     * 
     * @type {Date}
     * @memberof TaskReport
     */
    requestLastModifiedTime?: Date | null;
    /**
     * 
     * @type {RequestProgressStatus}
     * @memberof TaskReport
     */
    requestProgressStatus?: RequestProgressStatus;
    /**
     * 
     * @type {TaskType}
     * @memberof TaskReport
     */
    taskType?: TaskType;
    /**
     * 
     * @type {TaskResult}
     * @memberof TaskReport
     */
    status?: TaskResult;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof TaskReport
     */
    isApproveTask?: boolean;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    assignee?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    assigneeLoginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TaskReport
     */
    assigneeDisplayName?: string | null;
}

export function TaskReportFromJSON(json: any): TaskReport {
    return TaskReportFromJSONTyped(json, false);
}

export function TaskReportFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskReport {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'requestId': !exists(json, 'requestId') ? undefined : json['requestId'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'requester': !exists(json, 'requester') ? undefined : json['requester'],
        'requesterLoginName': !exists(json, 'requesterLoginName') ? undefined : json['requesterLoginName'],
        'requesterDisplayName': !exists(json, 'requesterDisplayName') ? undefined : json['requesterDisplayName'],
        'requestTicketNumber': !exists(json, 'requestTicketNumber') ? undefined : json['requestTicketNumber'],
        'dueDate': !exists(json, 'dueDate') ? undefined : (json['dueDate'] === null ? null : new Date(json['dueDate'])),
        'dueDateType': !exists(json, 'dueDateType') ? undefined : DueDateTypeFromJSON(json['dueDateType']),
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
        'createdTime': !exists(json, 'createdTime') ? undefined : (new Date(json['createdTime'])),
        'taskLastModifiedTime': !exists(json, 'taskLastModifiedTime') ? undefined : (new Date(json['taskLastModifiedTime'])),
        'requestLastModifiedTime': !exists(json, 'requestLastModifiedTime') ? undefined : (json['requestLastModifiedTime'] === null ? null : new Date(json['requestLastModifiedTime'])),
        'requestProgressStatus': !exists(json, 'requestProgressStatus') ? undefined : RequestProgressStatusFromJSON(json['requestProgressStatus']),
        'taskType': !exists(json, 'taskType') ? undefined : TaskTypeFromJSON(json['taskType']),
        'status': !exists(json, 'status') ? undefined : TaskResultFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'isApproveTask': !exists(json, 'isApproveTask') ? undefined : json['isApproveTask'],
        'assignee': !exists(json, 'assignee') ? undefined : json['assignee'],
        'assigneeLoginName': !exists(json, 'assigneeLoginName') ? undefined : json['assigneeLoginName'],
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
    };
}

export function TaskReportToJSON(value?: TaskReport | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'requestId': value.requestId,
        'title': value.title,
        'requester': value.requester,
        'requesterLoginName': value.requesterLoginName,
        'requesterDisplayName': value.requesterDisplayName,
        'requestTicketNumber': value.requestTicketNumber,
        'dueDate': value.dueDate === undefined ? undefined : (value.dueDate === null ? null : value.dueDate.toISOString()),
        'dueDateType': DueDateTypeToJSON(value.dueDateType),
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'taskLastModifiedTime': value.taskLastModifiedTime === undefined ? undefined : (value.taskLastModifiedTime.toISOString()),
        'requestLastModifiedTime': value.requestLastModifiedTime === undefined ? undefined : (value.requestLastModifiedTime === null ? null : value.requestLastModifiedTime.toISOString()),
        'requestProgressStatus': RequestProgressStatusToJSON(value.requestProgressStatus),
        'taskType': TaskTypeToJSON(value.taskType),
        'status': TaskResultToJSON(value.status),
        'statusDescription': value.statusDescription,
        'isApproveTask': value.isApproveTask,
        'assignee': value.assignee,
        'assigneeLoginName': value.assigneeLoginName,
        'assigneeDisplayName': value.assigneeDisplayName,
    };
}


