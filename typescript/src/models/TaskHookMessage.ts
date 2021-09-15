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
    TriggerType,
    TriggerTypeFromJSON,
    TriggerTypeFromJSONTyped,
    TriggerTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface TaskHookMessage
 */
export interface TaskHookMessage {
    /**
     * Unique ID of the task
     * @type {string}
     * @memberof TaskHookMessage
     */
    taskId?: string | null;
    /**
     * Link of the task
     * @type {string}
     * @memberof TaskHookMessage
     */
    taskLink?: string | null;
    /**
     * Display name of the task assignee
     * @type {string}
     * @memberof TaskHookMessage
     */
    assigneeDisplayName?: string | null;
    /**
     * User principal name of the task assignee
     * @type {string}
     * @memberof TaskHookMessage
     */
    assigneeIdentityName?: string | null;
    /**
     * Display name of the task assignee
     * @type {string}
     * @memberof TaskHookMessage
     */
    approverDisplayName?: string | null;
    /**
     * User principal name of the task assignee
     * @type {string}
     * @memberof TaskHookMessage
     */
    approverIdentityName?: string | null;
    /**
     * Task comments or error message
     * @type {string}
     * @memberof TaskHookMessage
     */
    message?: string | null;
    /**
     * Ticket number of the request
     * @type {number}
     * @memberof TaskHookMessage
     */
    requestId?: number;
    /**
     * Unique ID of the request
     * @type {string}
     * @memberof TaskHookMessage
     */
    requestGuid?: string | null;
    /**
     * User principal name of the requester
     * @type {string}
     * @memberof TaskHookMessage
     */
    requesterIdentityName?: string | null;
    /**
     * Display name of the requester
     * @type {string}
     * @memberof TaskHookMessage
     */
    requester?: string | null;
    /**
     * Type of service that is used to submit this request
     * @type {string}
     * @memberof TaskHookMessage
     */
    serviceType?: string | null;
    /**
     * Type enum of service that is used to submit this request
     * @type {ServiceType}
     * @memberof TaskHookMessage
     */
    serviceTypeEnum?: ServiceType;
    /**
     * Event type that being triggered, available values and corresponding messages:
     * 
     * RequestSubmitted,RequestCompleted,RequestCancelled ----> RequestHookMessage
     * TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped ----> TaskHookMessage
     * RenewalSuccess RenewalException,RenewalOverdue ----> RenewalTaskHookMessage
     * FullyAutoImportSuccess,ConfirmDetailSuccess ----> AutoImportProcessHookMessage
     * ElectionCompleted,ElectionOverdue ---> ElectionHookMessage
     * LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated ----> ElectionOverdue
     * @type {TriggerType}
     * @memberof TaskHookMessage
     */
    triggerType?: TriggerType;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof TaskHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof TaskHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof TaskHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof TaskHookMessage
     */
    summary?: string | null;
}

export function TaskHookMessageFromJSON(json: any): TaskHookMessage {
    return TaskHookMessageFromJSONTyped(json, false);
}

export function TaskHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'taskId': !exists(json, 'taskId') ? undefined : json['taskId'],
        'taskLink': !exists(json, 'taskLink') ? undefined : json['taskLink'],
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
        'assigneeIdentityName': !exists(json, 'assigneeIdentityName') ? undefined : json['assigneeIdentityName'],
        'approverDisplayName': !exists(json, 'approverDisplayName') ? undefined : json['approverDisplayName'],
        'approverIdentityName': !exists(json, 'approverIdentityName') ? undefined : json['approverIdentityName'],
        'message': !exists(json, 'message') ? undefined : json['message'],
        'requestId': !exists(json, 'requestId') ? undefined : json['requestId'],
        'requestGuid': !exists(json, 'requestGuid') ? undefined : json['requestGuid'],
        'requesterIdentityName': !exists(json, 'requesterIdentityName') ? undefined : json['requesterIdentityName'],
        'requester': !exists(json, 'requester') ? undefined : json['requester'],
        'serviceType': !exists(json, 'serviceType') ? undefined : json['serviceType'],
        'serviceTypeEnum': !exists(json, 'serviceTypeEnum') ? undefined : ServiceTypeFromJSON(json['serviceTypeEnum']),
        'triggerType': !exists(json, 'triggerType') ? undefined : TriggerTypeFromJSON(json['triggerType']),
        'triggerTime': !exists(json, 'triggerTime') ? undefined : (new Date(json['triggerTime'])),
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
    };
}

export function TaskHookMessageToJSON(value?: TaskHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'taskId': value.taskId,
        'taskLink': value.taskLink,
        'assigneeDisplayName': value.assigneeDisplayName,
        'assigneeIdentityName': value.assigneeIdentityName,
        'approverDisplayName': value.approverDisplayName,
        'approverIdentityName': value.approverIdentityName,
        'message': value.message,
        'requestId': value.requestId,
        'requestGuid': value.requestGuid,
        'requesterIdentityName': value.requesterIdentityName,
        'requester': value.requester,
        'serviceType': value.serviceType,
        'serviceTypeEnum': ServiceTypeToJSON(value.serviceTypeEnum),
        'triggerType': TriggerTypeToJSON(value.triggerType),
        'triggerTime': value.triggerTime === undefined ? undefined : (value.triggerTime.toISOString()),
        'objectUrl': value.objectUrl,
        'objectId': value.objectId,
        'summary': value.summary,
    };
}


