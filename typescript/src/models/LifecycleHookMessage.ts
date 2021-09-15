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
 * 
 * @export
 * @interface LifecycleHookMessage
 */
export interface LifecycleHookMessage {
    /**
     * Unique ID of policy
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    policyId?: string;
    /**
     * Name of policy
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    policyName?: string | null;
    /**
     * Lifecycle type of workspace, availabe values: SCNoAccess,SCExpired,GroupExpired,GroupInactivityThreshold
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    taskType?: string | null;
    /**
     * Expiration time
     * @type {Date}
     * @memberof LifecycleHookMessage
     */
    reachedTime?: Date | null;
    /**
     * Display name of assignee
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    assigneeDisplayName?: string | null;
    /**
     * User principal name of assignee
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    assigneeIdentityName?: string | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof LifecycleHookMessage
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
     * @memberof LifecycleHookMessage
     */
    triggerType?: TriggerType;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof LifecycleHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof LifecycleHookMessage
     */
    summary?: string | null;
}

export function LifecycleHookMessageFromJSON(json: any): LifecycleHookMessage {
    return LifecycleHookMessageFromJSONTyped(json, false);
}

export function LifecycleHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): LifecycleHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'policyName': !exists(json, 'policyName') ? undefined : json['policyName'],
        'taskType': !exists(json, 'taskType') ? undefined : json['taskType'],
        'reachedTime': !exists(json, 'reachedTime') ? undefined : (json['reachedTime'] === null ? null : new Date(json['reachedTime'])),
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

export function LifecycleHookMessageToJSON(value?: LifecycleHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'policyId': value.policyId,
        'policyName': value.policyName,
        'taskType': value.taskType,
        'reachedTime': value.reachedTime === undefined ? undefined : (value.reachedTime === null ? null : value.reachedTime.toISOString()),
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


