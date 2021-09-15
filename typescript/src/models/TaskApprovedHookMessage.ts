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
 * When a Request is Approved
 * @export
 * @interface TaskApprovedHookMessage
 */
export interface TaskApprovedHookMessage {
    /**
     * Display name of the task assignee
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    approverDisplayName?: string | null;
    /**
     * User principal name of the task assignee
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    approverIdentityName?: string | null;
    /**
     * Unique ID of the task
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    taskId?: string | null;
    /**
     * Link of the task
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    taskLink?: string | null;
    /**
     * Ticket number of the request
     * @type {number}
     * @memberof TaskApprovedHookMessage
     */
    requestId?: number;
    /**
     * Unique ID of the request
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    requestGuid?: string | null;
    /**
     * User principal name of the requester
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    requesterIdentityName?: string | null;
    /**
     * Display name of the requester
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    requester?: string | null;
    /**
     * Type of service that is used to submit this request
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    serviceType?: string | null;
    /**
     * Type enum of service that is used to submit this request
     * @type {ServiceType}
     * @memberof TaskApprovedHookMessage
     */
    serviceTypeEnum?: ServiceType;
    /**
     * Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,
     * TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,
     * ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    triggerType?: string | null;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof TaskApprovedHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof TaskApprovedHookMessage
     */
    summary?: string | null;
}

export function TaskApprovedHookMessageFromJSON(json: any): TaskApprovedHookMessage {
    return TaskApprovedHookMessageFromJSONTyped(json, false);
}

export function TaskApprovedHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskApprovedHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'approverDisplayName': !exists(json, 'approverDisplayName') ? undefined : json['approverDisplayName'],
        'approverIdentityName': !exists(json, 'approverIdentityName') ? undefined : json['approverIdentityName'],
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

export function TaskApprovedHookMessageToJSON(value?: TaskApprovedHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'approverDisplayName': value.approverDisplayName,
        'approverIdentityName': value.approverIdentityName,
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


