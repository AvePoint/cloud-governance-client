/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AutoImportProcessHookMessage,
    AutoImportProcessHookMessageFromJSON,
    AutoImportProcessHookMessageFromJSONTyped,
    AutoImportProcessHookMessageToJSON,
    ElectionHookMessage,
    ElectionHookMessageFromJSON,
    ElectionHookMessageFromJSONTyped,
    ElectionHookMessageToJSON,
    LifecycleHookMessage,
    LifecycleHookMessageFromJSON,
    LifecycleHookMessageFromJSONTyped,
    LifecycleHookMessageToJSON,
    RenewalTaskHookMessage,
    RenewalTaskHookMessageFromJSON,
    RenewalTaskHookMessageFromJSONTyped,
    RenewalTaskHookMessageToJSON,
    RequestHookMessage,
    RequestHookMessageFromJSON,
    RequestHookMessageFromJSONTyped,
    RequestHookMessageToJSON,
    TaskHookMessage,
    TaskHookMessageFromJSON,
    TaskHookMessageFromJSONTyped,
    TaskHookMessageToJSON,
} from './';

/**
 * 
 * @export
 * @interface HookMessageList
 */
export interface HookMessageList {
    /**
     * When a Renewal Task is Completed
     * @type {RenewalTaskHookMessage}
     * @memberof HookMessageList
     */
    renewalTaskCompleted?: RenewalTaskHookMessage | null;
    /**
     * 
     * @type {TaskHookMessage}
     * @memberof HookMessageList
     */
    taskCreated?: TaskHookMessage | null;
    /**
     * When an import process with pre-defined governance details or end user completes a confirm governance details task is completed
     * @type {AutoImportProcessHookMessage}
     * @memberof HookMessageList
     */
    autoImportCompleted?: AutoImportProcessHookMessage | null;
    /**
     * 
     * @type {RequestHookMessage}
     * @memberof HookMessageList
     */
    requestsRelated?: RequestHookMessage | null;
    /**
     * 
     * @type {LifecycleHookMessage}
     * @memberof HookMessageList
     */
    lifecycleHookMessage?: LifecycleHookMessage | null;
    /**
     * 
     * @type {ElectionHookMessage}
     * @memberof HookMessageList
     */
    electionHookMessage?: ElectionHookMessage | null;
}

export function HookMessageListFromJSON(json: any): HookMessageList {
    return HookMessageListFromJSONTyped(json, false);
}

export function HookMessageListFromJSONTyped(json: any, ignoreDiscriminator: boolean): HookMessageList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'renewalTaskCompleted': !exists(json, 'renewalTaskCompleted') ? undefined : RenewalTaskHookMessageFromJSON(json['renewalTaskCompleted']),
        'taskCreated': !exists(json, 'taskCreated') ? undefined : TaskHookMessageFromJSON(json['taskCreated']),
        'autoImportCompleted': !exists(json, 'autoImportCompleted') ? undefined : AutoImportProcessHookMessageFromJSON(json['autoImportCompleted']),
        'requestsRelated': !exists(json, 'requestsRelated') ? undefined : RequestHookMessageFromJSON(json['requestsRelated']),
        'lifecycleHookMessage': !exists(json, 'lifecycleHookMessage') ? undefined : LifecycleHookMessageFromJSON(json['lifecycleHookMessage']),
        'electionHookMessage': !exists(json, 'electionHookMessage') ? undefined : ElectionHookMessageFromJSON(json['electionHookMessage']),
    };
}

export function HookMessageListToJSON(value?: HookMessageList | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'renewalTaskCompleted': RenewalTaskHookMessageToJSON(value.renewalTaskCompleted),
        'taskCreated': TaskHookMessageToJSON(value.taskCreated),
        'autoImportCompleted': AutoImportProcessHookMessageToJSON(value.autoImportCompleted),
        'requestsRelated': RequestHookMessageToJSON(value.requestsRelated),
        'lifecycleHookMessage': LifecycleHookMessageToJSON(value.lifecycleHookMessage),
        'electionHookMessage': ElectionHookMessageToJSON(value.electionHookMessage),
    };
}


