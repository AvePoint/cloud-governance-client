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
 * @interface WorkerJobModel
 */
export interface WorkerJobModel {
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    tenantId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    type?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    method?: string | null;
    /**
     * 
     * @type {Array<any>}
     * @memberof WorkerJobModel
     */
    params?: Array<any> | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkerJobModel
     */
    updateTime?: Date;
    /**
     * 
     * @type {boolean}
     * @memberof WorkerJobModel
     */
    isTimer?: boolean;
    /**
     * 
     * @type {TaskStatus}
     * @memberof WorkerJobModel
     */
    status?: TaskStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    message?: string | null;
    /**
     * 
     * @type {TaskPriority}
     * @memberof WorkerJobModel
     */
    priority?: TaskPriority;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    priorityDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    instanceId?: string | null;
    /**
     * 
     * @type {number}
     * @memberof WorkerJobModel
     */
    intervalSeconds?: number;
    /**
     * 
     * @type {Date}
     * @memberof WorkerJobModel
     */
    nextRunTime?: Date;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    jobType?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof WorkerJobModel
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof WorkerJobModel
     */
    serviceTypeDescription?: string | null;
}

export function WorkerJobModelFromJSON(json: any): WorkerJobModel {
    return WorkerJobModelFromJSONTyped(json, false);
}

export function WorkerJobModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkerJobModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'type': !exists(json, 'type') ? undefined : json['type'],
        'method': !exists(json, 'method') ? undefined : json['method'],
        'params': !exists(json, 'params') ? undefined : json['params'],
        'updateTime': !exists(json, 'updateTime') ? undefined : (new Date(json['updateTime'])),
        'isTimer': !exists(json, 'isTimer') ? undefined : json['isTimer'],
        'status': !exists(json, 'status') ? undefined : TaskStatusFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'message': !exists(json, 'message') ? undefined : json['message'],
        'priority': !exists(json, 'priority') ? undefined : TaskPriorityFromJSON(json['priority']),
        'priorityDescription': !exists(json, 'priorityDescription') ? undefined : json['priorityDescription'],
        'instanceId': !exists(json, 'instanceId') ? undefined : json['instanceId'],
        'intervalSeconds': !exists(json, 'intervalSeconds') ? undefined : json['intervalSeconds'],
        'nextRunTime': !exists(json, 'nextRunTime') ? undefined : (new Date(json['nextRunTime'])),
        'jobType': !exists(json, 'jobType') ? undefined : json['jobType'],
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
    };
}

export function WorkerJobModelToJSON(value?: WorkerJobModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'tenantId': value.tenantId,
        'name': value.name,
        'type': value.type,
        'method': value.method,
        'params': value.params,
        'updateTime': value.updateTime === undefined ? undefined : (value.updateTime.toISOString()),
        'isTimer': value.isTimer,
        'status': TaskStatusToJSON(value.status),
        'statusDescription': value.statusDescription,
        'message': value.message,
        'priority': TaskPriorityToJSON(value.priority),
        'priorityDescription': value.priorityDescription,
        'instanceId': value.instanceId,
        'intervalSeconds': value.intervalSeconds,
        'nextRunTime': value.nextRunTime === undefined ? undefined : (value.nextRunTime.toISOString()),
        'jobType': value.jobType,
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
    };
}


