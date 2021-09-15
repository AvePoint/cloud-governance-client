/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * When a Renewal Process Encounters an Exception
 * @export
 * @interface RenewalTaskExceptionHookMessage
 */
export interface RenewalTaskExceptionHookMessage {
    /**
     * Details of the renewal exception
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    message?: string | null;
    /**
     * Due date for the task assignee to complete the renewal task
     * @type {Date}
     * @memberof RenewalTaskExceptionHookMessage
     */
    dueDate?: Date | null;
    /**
     * Display name of the renewal task assignee
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    assigneeDisplayName?: string | null;
    /**
     * User principal name of the renewal task assignee
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    assigneeIdentityName?: string | null;
    /**
     * Start time of the renewal process
     * @type {Date}
     * @memberof RenewalTaskExceptionHookMessage
     */
    phaseStartTime?: Date | null;
    /**
     * Name of the renewal profile
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    renewalProfileName?: string | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    groupEmail?: string | null;
    /**
     * Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,
     * TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,
     * ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    triggerType?: string | null;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof RenewalTaskExceptionHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof RenewalTaskExceptionHookMessage
     */
    summary?: string | null;
}

export function RenewalTaskExceptionHookMessageFromJSON(json: any): RenewalTaskExceptionHookMessage {
    return RenewalTaskExceptionHookMessageFromJSONTyped(json, false);
}

export function RenewalTaskExceptionHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): RenewalTaskExceptionHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'message': !exists(json, 'message') ? undefined : json['message'],
        'dueDate': !exists(json, 'dueDate') ? undefined : (json['dueDate'] === null ? null : new Date(json['dueDate'])),
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
        'assigneeIdentityName': !exists(json, 'assigneeIdentityName') ? undefined : json['assigneeIdentityName'],
        'phaseStartTime': !exists(json, 'phaseStartTime') ? undefined : (json['phaseStartTime'] === null ? null : new Date(json['phaseStartTime'])),
        'renewalProfileName': !exists(json, 'renewalProfileName') ? undefined : json['renewalProfileName'],
        'taskLink': !exists(json, 'taskLink') ? undefined : json['taskLink'],
        'objectTitle': !exists(json, 'objectTitle') ? undefined : json['objectTitle'],
        'objectType': !exists(json, 'objectType') ? undefined : json['objectType'],
        'objectTypeEnum': !exists(json, 'objectTypeEnum') ? undefined : json['objectTypeEnum'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'triggerType': !exists(json, 'triggerType') ? undefined : json['triggerType'],
        'triggerTime': !exists(json, 'triggerTime') ? undefined : (new Date(json['triggerTime'])),
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
    };
}

export function RenewalTaskExceptionHookMessageToJSON(value?: RenewalTaskExceptionHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'message': value.message,
        'dueDate': value.dueDate === undefined ? undefined : (value.dueDate === null ? null : value.dueDate.toISOString()),
        'assigneeDisplayName': value.assigneeDisplayName,
        'assigneeIdentityName': value.assigneeIdentityName,
        'phaseStartTime': value.phaseStartTime === undefined ? undefined : (value.phaseStartTime === null ? null : value.phaseStartTime.toISOString()),
        'renewalProfileName': value.renewalProfileName,
        'taskLink': value.taskLink,
        'objectTitle': value.objectTitle,
        'objectType': value.objectType,
        'objectTypeEnum': value.objectTypeEnum,
        'groupEmail': value.groupEmail,
        'triggerType': value.triggerType,
        'triggerTime': value.triggerTime === undefined ? undefined : (value.triggerTime.toISOString()),
        'objectUrl': value.objectUrl,
        'objectId': value.objectId,
        'summary': value.summary,
    };
}


