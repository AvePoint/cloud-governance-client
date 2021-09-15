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
 * @interface RequestHookMessage
 */
export interface RequestHookMessage {
    /**
     * 
     * @type {string}
     * @memberof RequestHookMessage
     */
    serviceName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof RequestHookMessage
     */
    serviceId?: string | null;
    /**
     * Ticket number of the request
     * @type {number}
     * @memberof RequestHookMessage
     */
    requestId?: number;
    /**
     * Unique ID of the request
     * @type {string}
     * @memberof RequestHookMessage
     */
    requestGuid?: string | null;
    /**
     * User principal name of the requester
     * @type {string}
     * @memberof RequestHookMessage
     */
    requesterIdentityName?: string | null;
    /**
     * Display name of the requester
     * @type {string}
     * @memberof RequestHookMessage
     */
    requester?: string | null;
    /**
     * Type of service that is used to submit this request
     * @type {string}
     * @memberof RequestHookMessage
     */
    serviceType?: string | null;
    /**
     * Type enum of service that is used to submit this request
     * @type {ServiceType}
     * @memberof RequestHookMessage
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
     * @memberof RequestHookMessage
     */
    triggerType?: TriggerType;
    /**
     * Time that the webhook is triggered
     * @type {Date}
     * @memberof RequestHookMessage
     */
    triggerTime?: Date;
    /**
     * URL of the workspace
     * @type {string}
     * @memberof RequestHookMessage
     */
    objectUrl?: string | null;
    /**
     * The unique ID of the workspace
     * @type {string}
     * @memberof RequestHookMessage
     */
    objectId?: string | null;
    /**
     * Request or task summary
     * @type {string}
     * @memberof RequestHookMessage
     */
    summary?: string | null;
}

export function RequestHookMessageFromJSON(json: any): RequestHookMessage {
    return RequestHookMessageFromJSONTyped(json, false);
}

export function RequestHookMessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestHookMessage {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'serviceName': !exists(json, 'serviceName') ? undefined : json['serviceName'],
        'serviceId': !exists(json, 'serviceId') ? undefined : json['serviceId'],
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

export function RequestHookMessageToJSON(value?: RequestHookMessage | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'serviceName': value.serviceName,
        'serviceId': value.serviceId,
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


