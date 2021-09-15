/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ElectionContact,
    ElectionContactFromJSON,
    ElectionContactFromJSONTyped,
    ElectionContactToJSON,
    TriggerType,
    TriggerTypeFromJSON,
    TriggerTypeFromJSONTyped,
    TriggerTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ElectionHookMessage
 */
export interface ElectionHookMessage {
    /**
     * Type enum of election, available values: Group Deactivated Contact Election, Site Collection Deactivated Contact Election
     * , Elect Contact, Specify contact
     * @type {string}
     * @memberof ElectionHookMessage
     */
    serviceType?: string | null;
    /**
     * Is primary contact deactived
     * @type {boolean}
     * @memberof ElectionHookMessage
     */
    isPrimaryContactDeactived?: boolean;
    /**
     * Original primary contact
     * @type {ElectionContact}
     * @memberof ElectionHookMessage
     */
    originalPrimaryContact?: ElectionContact | null;
    /**
     * Is primary contact changed
     * @type {boolean}
     * @memberof ElectionHookMessage
     */
    isPrimaryContactChanged?: boolean;
    /**
     * New primary contact
     * @type {ElectionContact}
     * @memberof ElectionHookMessage
     */
    newPrimaryContact?: ElectionContact | null;
    /**
     * Is secondary contact deactived
     * @type {boolean}
     * @memberof ElectionHookMessage
     */
    isSecondaryContactDeactived?: boolean;
    /**
     * Original secondary contact
     * @type {ElectionContact}
     * @memberof ElectionHookMessage
     */
    originalSecondaryContact?: ElectionContact | null;
    /**
     * Is secondary contact changed
     * @type {boolean}
     * @memberof ElectionHookMessage
     */
    isSecondaryContactChanged?: boolean;
    /**
     * New secondary contact
     * @type {ElectionContact}
     * @memberof ElectionHookMessage
     */
    newSecondaryContact?: ElectionContact | null;
    /**
     * Link of task
     * <sample>abc</sample>
     * @type {string}
     * @memberof ElectionHookMessage
     */
    taskLink?: string | null;
    /**
     * Name of the workspace
     * @type {string}
     * @memberof ElectionHookMessage
     */
    objectTitle?: string | null;
    /**
     * Type of the workspace
     * @type {string}
     * @memberof ElectionHookMessage
     */
    objectType?: string | null;
    /**
     * Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
     * @type {string}
     * @memberof ElectionHookMessage
     */
    objectTypeEnum?: string | null;
    /**
     * E-mail address of the workspace
     * @type {string}
     * @memberof ElectionHookMessage
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
     * @memberof ElectionHookMessage
     */
    triggerType?: TriggerType;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof ElectionHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof ElectionHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof ElectionHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof ElectionHookMessage
     */
    summary?: string | null;
}

export function ElectionHookMessageFromJSON(json: any): ElectionHookMessage {
    return ElectionHookMessageFromJSONTyped(json, false);
}

export function ElectionHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): ElectionHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'serviceType': !exists(json, 'serviceType') ? undefined : json['serviceType'],
        'isPrimaryContactDeactived': !exists(json, 'isPrimaryContactDeactived') ? undefined : json['isPrimaryContactDeactived'],
        'originalPrimaryContact': !exists(json, 'originalPrimaryContact') ? undefined : ElectionContactFromJSON(json['originalPrimaryContact']),
        'isPrimaryContactChanged': !exists(json, 'isPrimaryContactChanged') ? undefined : json['isPrimaryContactChanged'],
        'newPrimaryContact': !exists(json, 'newPrimaryContact') ? undefined : ElectionContactFromJSON(json['newPrimaryContact']),
        'isSecondaryContactDeactived': !exists(json, 'isSecondaryContactDeactived') ? undefined : json['isSecondaryContactDeactived'],
        'originalSecondaryContact': !exists(json, 'originalSecondaryContact') ? undefined : ElectionContactFromJSON(json['originalSecondaryContact']),
        'isSecondaryContactChanged': !exists(json, 'isSecondaryContactChanged') ? undefined : json['isSecondaryContactChanged'],
        'newSecondaryContact': !exists(json, 'newSecondaryContact') ? undefined : ElectionContactFromJSON(json['newSecondaryContact']),
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

export function ElectionHookMessageToJSON(value?: ElectionHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'serviceType': value.serviceType,
        'isPrimaryContactDeactived': value.isPrimaryContactDeactived,
        'originalPrimaryContact': ElectionContactToJSON(value.originalPrimaryContact),
        'isPrimaryContactChanged': value.isPrimaryContactChanged,
        'newPrimaryContact': ElectionContactToJSON(value.newPrimaryContact),
        'isSecondaryContactDeactived': value.isSecondaryContactDeactived,
        'originalSecondaryContact': ElectionContactToJSON(value.originalSecondaryContact),
        'isSecondaryContactChanged': value.isSecondaryContactChanged,
        'newSecondaryContact': ElectionContactToJSON(value.newSecondaryContact),
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


