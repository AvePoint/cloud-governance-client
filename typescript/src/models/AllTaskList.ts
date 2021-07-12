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
 * @interface AllTaskList
 */
export interface AllTaskList {
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    requester?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    requesterLoginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    requesterDisplayName?: string | null;
    /**
     * 
     * @type {number}
     * @memberof AllTaskList
     */
    requestTicketNumber?: number;
    /**
     * 
     * @type {Date}
     * @memberof AllTaskList
     */
    dueDate?: Date | null;
    /**
     * 
     * @type {DueDateType}
     * @memberof AllTaskList
     */
    dueDateType?: DueDateType;
    /**
     * 
     * @type {ServiceType}
     * @memberof AllTaskList
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof AllTaskList
     */
    createdTime?: Date;
    /**
     * 
     * @type {TaskType}
     * @memberof AllTaskList
     */
    taskType?: TaskType;
    /**
     * 
     * @type {TaskResult}
     * @memberof AllTaskList
     */
    status?: TaskResult;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof AllTaskList
     */
    isApproveTask?: boolean;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    assignee?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    assigneeLoginName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AllTaskList
     */
    assigneeDisplayName?: string | null;
}

export function AllTaskListFromJSON(json: any): AllTaskList {
    return AllTaskListFromJSONTyped(json, false);
}

export function AllTaskListFromJSONTyped(json: any, ignoreDiscriminator: boolean): AllTaskList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
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
        'taskType': !exists(json, 'taskType') ? undefined : TaskTypeFromJSON(json['taskType']),
        'status': !exists(json, 'status') ? undefined : TaskResultFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'isApproveTask': !exists(json, 'isApproveTask') ? undefined : json['isApproveTask'],
        'assignee': !exists(json, 'assignee') ? undefined : json['assignee'],
        'assigneeLoginName': !exists(json, 'assigneeLoginName') ? undefined : json['assigneeLoginName'],
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
    };
}

export function AllTaskListToJSON(value?: AllTaskList | null): any {
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
        'requesterLoginName': value.requesterLoginName,
        'requesterDisplayName': value.requesterDisplayName,
        'requestTicketNumber': value.requestTicketNumber,
        'dueDate': value.dueDate === undefined ? undefined : (value.dueDate === null ? null : value.dueDate.toISOString()),
        'dueDateType': DueDateTypeToJSON(value.dueDateType),
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'taskType': TaskTypeToJSON(value.taskType),
        'status': TaskResultToJSON(value.status),
        'statusDescription': value.statusDescription,
        'isApproveTask': value.isApproveTask,
        'assignee': value.assignee,
        'assigneeLoginName': value.assigneeLoginName,
        'assigneeDisplayName': value.assigneeDisplayName,
    };
}


