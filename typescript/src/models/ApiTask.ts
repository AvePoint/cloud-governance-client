/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiTaskDynamicProperties,
    ApiTaskDynamicPropertiesFromJSON,
    ApiTaskDynamicPropertiesFromJSONTyped,
    ApiTaskDynamicPropertiesToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
    TaskComment,
    TaskCommentFromJSON,
    TaskCommentFromJSONTyped,
    TaskCommentToJSON,
    TaskDynamicActions,
    TaskDynamicActionsFromJSON,
    TaskDynamicActionsFromJSONTyped,
    TaskDynamicActionsToJSON,
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
 * @interface ApiTask
 */
export interface ApiTask {
    /**
     * 
     * @type {ApiTaskDynamicProperties}
     * @memberof ApiTask
     */
    dynamicProperties?: ApiTaskDynamicProperties | null;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    requestGuid?: string;
    /**
     * 
     * @type {TaskResult}
     * @memberof ApiTask
     */
    status?: TaskResult;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ApiTask
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    comments?: string | null;
    /**
     * 
     * @type {Array<TaskComment>}
     * @memberof ApiTask
     */
    allComments?: Array<TaskComment> | null;
    /**
     * 
     * @type {string}
     * @memberof ApiTask
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof ApiTask
     */
    lastModifiedTime?: Date;
    /**
     * 
     * @type {TaskType}
     * @memberof ApiTask
     */
    taskType?: TaskType;
    /**
     * 
     * @type {boolean}
     * @memberof ApiTask
     */
    allowReassign?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ApiTask
     */
    allowEdit?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ApiTask
     */
    requestTicketNumber?: number;
    /**
     * 
     * @type {Array<TaskDynamicActions>}
     * @memberof ApiTask
     */
    dynamicActions?: Array<TaskDynamicActions> | null;
}

export function ApiTaskFromJSON(json: any): ApiTask {
    return ApiTaskFromJSONTyped(json, false);
}

export function ApiTaskFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiTask {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'dynamicProperties': !exists(json, 'dynamicProperties') ? undefined : ApiTaskDynamicPropertiesFromJSON(json['dynamicProperties']),
        'id': !exists(json, 'id') ? undefined : json['id'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'requestGuid': !exists(json, 'requestGuid') ? undefined : json['requestGuid'],
        'status': !exists(json, 'status') ? undefined : TaskResultFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
        'comments': !exists(json, 'comments') ? undefined : json['comments'],
        'allComments': !exists(json, 'allComments') ? undefined : (json['allComments'] === null ? null : (json['allComments'] as Array<any>).map(TaskCommentFromJSON)),
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'lastModifiedTime': !exists(json, 'lastModifiedTime') ? undefined : (new Date(json['lastModifiedTime'])),
        'taskType': !exists(json, 'taskType') ? undefined : TaskTypeFromJSON(json['taskType']),
        'allowReassign': !exists(json, 'allowReassign') ? undefined : json['allowReassign'],
        'allowEdit': !exists(json, 'allowEdit') ? undefined : json['allowEdit'],
        'requestTicketNumber': !exists(json, 'requestTicketNumber') ? undefined : json['requestTicketNumber'],
        'dynamicActions': !exists(json, 'dynamicActions') ? undefined : (json['dynamicActions'] === null ? null : (json['dynamicActions'] as Array<any>).map(TaskDynamicActionsFromJSON)),
    };
}

export function ApiTaskToJSON(value?: ApiTask | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'dynamicProperties': ApiTaskDynamicPropertiesToJSON(value.dynamicProperties),
        'id': value.id,
        'title': value.title,
        'description': value.description,
        'requestGuid': value.requestGuid,
        'status': TaskResultToJSON(value.status),
        'statusDescription': value.statusDescription,
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'comments': value.comments,
        'allComments': value.allComments === undefined ? undefined : (value.allComments === null ? null : (value.allComments as Array<any>).map(TaskCommentToJSON)),
        'errorMessage': value.errorMessage,
        'lastModifiedTime': value.lastModifiedTime === undefined ? undefined : (value.lastModifiedTime.toISOString()),
        'taskType': TaskTypeToJSON(value.taskType),
        'allowReassign': value.allowReassign,
        'allowEdit': value.allowEdit,
        'requestTicketNumber': value.requestTicketNumber,
        'dynamicActions': value.dynamicActions === undefined ? undefined : (value.dynamicActions === null ? null : (value.dynamicActions as Array<any>).map(TaskDynamicActionsToJSON)),
    };
}


