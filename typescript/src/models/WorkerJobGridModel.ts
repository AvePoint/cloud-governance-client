/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    TaskPriority,
    TaskPriorityFromJSON,
    TaskPriorityFromJSONTyped,
    TaskPriorityToJSON,
    TaskStatus,
    TaskStatusFromJSON,
    TaskStatusFromJSONTyped,
    TaskStatusToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkerJobGridModel
 */
export interface WorkerJobGridModel {
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    type?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    method?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkerJobGridModel
     */
    updateTime?: Date;
    /**
     * 
     * @type {Date}
     * @memberof WorkerJobGridModel
     */
    nextRunTime?: Date;
    /**
     * 
     * @type {boolean}
     * @memberof WorkerJobGridModel
     */
    isTimer?: boolean;
    /**
     * 
     * @type {TaskStatus}
     * @memberof WorkerJobGridModel
     */
    status?: TaskStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    message?: string | null;
    /**
     * 
     * @type {TaskPriority}
     * @memberof WorkerJobGridModel
     */
    priority?: TaskPriority;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    priorityDescription?: string | null;
    /**
     * 
     * @type {number}
     * @memberof WorkerJobGridModel
     */
    intervalSeconds?: number;
    /**
     * 
     * @type {ServiceType}
     * @memberof WorkerJobGridModel
     */
    jobType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobGridModel
     */
    jobTypeDescription?: string | null;
}

export function WorkerJobGridModelFromJSON(json: any): WorkerJobGridModel {
    return WorkerJobGridModelFromJSONTyped(json, false);
}

export function WorkerJobGridModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkerJobGridModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'type': !exists(json, 'type') ? undefined : json['type'],
        'method': !exists(json, 'method') ? undefined : json['method'],
        'updateTime': !exists(json, 'updateTime') ? undefined : (new Date(json['updateTime'])),
        'nextRunTime': !exists(json, 'nextRunTime') ? undefined : (new Date(json['nextRunTime'])),
        'isTimer': !exists(json, 'isTimer') ? undefined : json['isTimer'],
        'status': !exists(json, 'status') ? undefined : TaskStatusFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'message': !exists(json, 'message') ? undefined : json['message'],
        'priority': !exists(json, 'priority') ? undefined : TaskPriorityFromJSON(json['priority']),
        'priorityDescription': !exists(json, 'priorityDescription') ? undefined : json['priorityDescription'],
        'intervalSeconds': !exists(json, 'intervalSeconds') ? undefined : json['intervalSeconds'],
        'jobType': !exists(json, 'jobType') ? undefined : ServiceTypeFromJSON(json['jobType']),
        'jobTypeDescription': !exists(json, 'jobTypeDescription') ? undefined : json['jobTypeDescription'],
    };
}

export function WorkerJobGridModelToJSON(value?: WorkerJobGridModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'type': value.type,
        'method': value.method,
        'updateTime': value.updateTime === undefined ? undefined : (value.updateTime.toISOString()),
        'nextRunTime': value.nextRunTime === undefined ? undefined : (value.nextRunTime.toISOString()),
        'isTimer': value.isTimer,
        'status': TaskStatusToJSON(value.status),
        'statusDescription': value.statusDescription,
        'message': value.message,
        'priority': TaskPriorityToJSON(value.priority),
        'priorityDescription': value.priorityDescription,
        'intervalSeconds': value.intervalSeconds,
        'jobType': ServiceTypeToJSON(value.jobType),
        'jobTypeDescription': value.jobTypeDescription,
    };
}


