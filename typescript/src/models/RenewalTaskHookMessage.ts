/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    TriggerType,
    TriggerTypeFromJSON,
    TriggerTypeFromJSONTyped,
    TriggerTypeToJSON,
} from './';

/**
 * When a Renewal Task is Completed
 * @export
 * @interface RenewalTaskHookMessage
 */
export interface RenewalTaskHookMessage {
    /**
     * Start time of the renewal process
     * @type {Date}
     * @memberof RenewalTaskHookMessage
     */
    phaseStartTime?: Date | null;
    /**
     * Name of the renewal profile
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    renewalProfileName?: string | null;
    /**
     * Details of the renewal exception
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    message?: string | null;
    /**
     * Due date for the task assignee to complete the renewal task
     * @type {Date}
     * @memberof RenewalTaskHookMessage
     */
    dueDate?: Date | null;
    /**
     * Display name of the renewal task assignee
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    assigneeDisplayName?: string | null;
    /**
     * User principal name of the renewal task assignee
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    assigneeIdentityName?: string | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    groupEmail?: string | null;
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
     * @memberof RenewalTaskHookMessage
     */
    triggerType?: TriggerType;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof RenewalTaskHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof RenewalTaskHookMessage
     */
    summary?: string | null;
}

export function RenewalTaskHookMessageFromJSON(json: any): RenewalTaskHookMessage {
    return RenewalTaskHookMessageFromJSONTyped(json, false);
}

export function RenewalTaskHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): RenewalTaskHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'phaseStartTime': !exists(json, 'phaseStartTime') ? undefined : (json['phaseStartTime'] === null ? null : new Date(json['phaseStartTime'])),
        'renewalProfileName': !exists(json, 'renewalProfileName') ? undefined : json['renewalProfileName'],
        'message': !exists(json, 'message') ? undefined : json['message'],
        'dueDate': !exists(json, 'dueDate') ? undefined : (json['dueDate'] === null ? null : new Date(json['dueDate'])),
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
        'assigneeIdentityName': !exists(json, 'assigneeIdentityName') ? undefined : json['assigneeIdentityName'],
        'taskLink': !exists(json, 'taskLink') ? undefined : json['taskLink'],
        'objectTitle': !exists(json, 'objectTitle') ? undefined : json['objectTitle'],
        'objectType': !exists(json, 'objectType') ? undefined : json['objectType'],
        'objectTypeEnum': !exists(json, 'objectTypeEnum') ? undefined : json['objectTypeEnum'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'triggerType': !exists(json, 'triggerType') ? undefined : TriggerTypeFromJSON(json['triggerType']),
        'triggerTime': !exists(json, 'triggerTime') ? undefined : (new Date(json['triggerTime'])),
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
    };
}

export function RenewalTaskHookMessageToJSON(value?: RenewalTaskHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'phaseStartTime': value.phaseStartTime === undefined ? undefined : (value.phaseStartTime === null ? null : value.phaseStartTime.toISOString()),
        'renewalProfileName': value.renewalProfileName,
        'message': value.message,
        'dueDate': value.dueDate === undefined ? undefined : (value.dueDate === null ? null : value.dueDate.toISOString()),
        'assigneeDisplayName': value.assigneeDisplayName,
        'assigneeIdentityName': value.assigneeIdentityName,
        'taskLink': value.taskLink,
        'objectTitle': value.objectTitle,
        'objectType': value.objectType,
        'objectTypeEnum': value.objectTypeEnum,
        'groupEmail': value.groupEmail,
        'triggerType': TriggerTypeToJSON(value.triggerType),
        'triggerTime': value.triggerTime === undefined ? undefined : (value.triggerTime.toISOString()),
        'objectUrl': value.objectUrl,
        'objectId': value.objectId,
        'summary': value.summary,
    };
}


