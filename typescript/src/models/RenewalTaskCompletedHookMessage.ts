/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * When a Renewal Task is Completed
 * @export
 * @interface RenewalTaskCompletedHookMessage
 */
export interface RenewalTaskCompletedHookMessage {
    /**
     * Start time of the renewal process
     * @type {Date}
     * @memberof RenewalTaskCompletedHookMessage
     */
    phaseStartTime?: Date | null;
    /**
     * Name of the renewal profile
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    renewalProfileName?: string | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    groupEmail?: string | null;
    /**
     * Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,
     * TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,
     * ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    triggerType?: string | null;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof RenewalTaskCompletedHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof RenewalTaskCompletedHookMessage
     */
    summary?: string | null;
}

export function RenewalTaskCompletedHookMessageFromJSON(json: any): RenewalTaskCompletedHookMessage {
    return RenewalTaskCompletedHookMessageFromJSONTyped(json, false);
}

export function RenewalTaskCompletedHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): RenewalTaskCompletedHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
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

export function RenewalTaskCompletedHookMessageToJSON(value?: RenewalTaskCompletedHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
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


