/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * When an import process with pre-defined governance details or end user completes a confirm governance details task is completed
 * @export
 * @interface AutoImportProcessCompletedHookMessage
 */
export interface AutoImportProcessCompletedHookMessage {
    /**
     * Name of the import job
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    autoImportProfileName?: string | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    groupEmail?: string | null;
    /**
     * Event type that being triggered, available values:RequestSubmitted,RequestCompleted,RequestCancelled,TaskCreated,TaskApproved,
     * TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped,RenewalSuccess,RenewalException,RenewalOverdue,FullyAutoImportSuccess,
     * ConfirmDetailSuccess,ElectionCompleted,LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated,ElectionOverdue
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    triggerType?: string | null;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof AutoImportProcessCompletedHookMessage
     */
    summary?: string | null;
}

export function AutoImportProcessCompletedHookMessageFromJSON(json: any): AutoImportProcessCompletedHookMessage {
    return AutoImportProcessCompletedHookMessageFromJSONTyped(json, false);
}

export function AutoImportProcessCompletedHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): AutoImportProcessCompletedHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'autoImportProfileName': !exists(json, 'autoImportProfileName') ? undefined : json['autoImportProfileName'],
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

export function AutoImportProcessCompletedHookMessageToJSON(value?: AutoImportProcessCompletedHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'autoImportProfileName': value.autoImportProfileName,
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


