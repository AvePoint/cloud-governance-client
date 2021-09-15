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
 * When an import process with pre-defined governance details or end user completes a confirm governance details task is completed
 * @export
 * @interface AutoImportProcessHookMessage
 */
export interface AutoImportProcessHookMessage {
    /**
     * Name of the import job
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    autoImportProfileName?: string | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof AutoImportProcessHookMessage
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
     * @memberof AutoImportProcessHookMessage
     */
    triggerType?: TriggerType;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof AutoImportProcessHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof AutoImportProcessHookMessage
     */
    summary?: string | null;
}

export function AutoImportProcessHookMessageFromJSON(json: any): AutoImportProcessHookMessage {
    return AutoImportProcessHookMessageFromJSONTyped(json, false);
}

export function AutoImportProcessHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): AutoImportProcessHookMessage {
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
        'triggerType': !exists(json, 'triggerType') ? undefined : TriggerTypeFromJSON(json['triggerType']),
        'triggerTime': !exists(json, 'triggerTime') ? undefined : (new Date(json['triggerTime'])),
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'summary': !exists(json, 'summary') ? undefined : json['summary'],
    };
}

export function AutoImportProcessHookMessageToJSON(value?: AutoImportProcessHookMessage | null): any {
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
        'triggerType': TriggerTypeToJSON(value.triggerType),
        'triggerTime': value.triggerTime === undefined ? undefined : (value.triggerTime.toISOString()),
        'objectUrl': value.objectUrl,
        'objectId': value.objectId,
        'summary': value.summary,
    };
}


