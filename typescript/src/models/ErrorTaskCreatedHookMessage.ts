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
} from './';

/**
 * When an Error Task is Generated
 * @export
 * @interface ErrorTaskCreatedHookMessage
 */
export interface ErrorTaskCreatedHookMessage {
    /**
     * Error details of the error task
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    message?: string | null;
    /**
     * Display name of the task assignee
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    assigneeDisplayName?: string | null;
    /**
     * User principal name of the task assignee
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    assigneeIdentityName?: string | null;
    /**
     * Unique ID of the task
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    taskId?: string | null;
    /**
     * Link of the task
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    taskLink?: string | null;
    /**
     * Ticket number of the request
     * @type {number}
     * @memberof ErrorTaskCreatedHookMessage
     */
    requestId?: number;
    /**
     * Unique ID of the request
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    requestGuid?: string | null;
    /**
     * User principal name of the requester
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    requesterIdentityName?: string | null;
    /**
     * Display name of the requester
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    requester?: string | null;
    /**
     * Type of service that is used to submit this request
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    serviceType?: string | null;
    /**
     * Type enum of service that is used to submit this request
     * @type {ServiceType}
     * @memberof ErrorTaskCreatedHookMessage
     */
    serviceTypeEnum?: ServiceType;
    /**
     * Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,
     * TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,
     * ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    triggerType?: string | null;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof ErrorTaskCreatedHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof ErrorTaskCreatedHookMessage
     */
    summary?: string | null;
}

export function ErrorTaskCreatedHookMessageFromJSON(json: any): ErrorTaskCreatedHookMessage {
    return ErrorTaskCreatedHookMessageFromJSONTyped(json, false);
}

export function ErrorTaskCreatedHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): ErrorTaskCreatedHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'message': !exists(json, 'message') ? undefined : json['message'],
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
        'assigneeIdentityName': !exists(json, 'assigneeIdentityName') ? undefined : json['assigneeIdentityName'],
        'taskId': !exists(json, 'taskId') ? undefined : json['taskId'],
        'taskLink': !exists(json, 'taskLink') ? undefined : json['taskLink'],
        'requestId': !exists(json, 'requestId') ? undefined : json['requestId'],
        'requestGuid': !exists(json, 'requestGuid') ? undefined : json['requestGuid'],
        'requesterIdentityName': !exists(json, 'requesterIdentityName') ? undefined : json['requesterIdentityName'],
        'requester': !exists(json, 'requester') ? undefined : json['requester'],
        'serviceType': !exists(json, 'serviceType') ? undefined : json['serviceType'],
        'serviceTypeEnum': !exists(json, 'serviceTypeEnum') ? undefined : ServiceTypeFromJSON(json['serviceTypeEnum']),
        'triggerType': !exists(json, 'triggerType') ? undefined : json['triggerType'],
        'triggerTime': !exists(json, 'triggerTime') ? undefined : (new Date(json['triggerTime'])),
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
    };
}

export function ErrorTaskCreatedHookMessageToJSON(value?: ErrorTaskCreatedHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'message': value.message,
        'assigneeDisplayName': value.assigneeDisplayName,
        'assigneeIdentityName': value.assigneeIdentityName,
        'taskId': value.taskId,
        'taskLink': value.taskLink,
        'requestId': value.requestId,
        'requestGuid': value.requestGuid,
        'requesterIdentityName': value.requesterIdentityName,
        'requester': value.requester,
        'serviceType': value.serviceType,
        'serviceTypeEnum': ServiceTypeToJSON(value.serviceTypeEnum),
        'triggerType': value.triggerType,
        'triggerTime': value.triggerTime === undefined ? undefined : (value.triggerTime.toISOString()),
        'objectUrl': value.objectUrl,
        'objectId': value.objectId,
        'summary': value.summary,
    };
}


