/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface CreateWebValidationParameter
 */
export interface CreateWebValidationParameter {
    /**
     * 
     * @type {string}
     * @memberof CreateWebValidationParameter
     */
    parentUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebValidationParameter
     */
    uri?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebValidationParameter
     */
    ignoreLock?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebValidationParameter
     */
    isEditTask?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebValidationParameter
     */
    isFromQuestionnaire?: boolean;
}

export function CreateWebValidationParameterFromJSON(json: any): CreateWebValidationParameter {
    return CreateWebValidationParameterFromJSONTyped(json, false);
}

export function CreateWebValidationParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateWebValidationParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'parentUrl': !exists(json, 'parentUrl') ? undefined : json['parentUrl'],
        'uri': !exists(json, 'uri') ? undefined : json['uri'],
        'ignoreLock': !exists(json, 'ignoreLock') ? undefined : json['ignoreLock'],
        'isEditTask': !exists(json, 'isEditTask') ? undefined : json['isEditTask'],
        'isFromQuestionnaire': !exists(json, 'isFromQuestionnaire') ? undefined : json['isFromQuestionnaire'],
    };
}

export function CreateWebValidationParameterToJSON(value?: CreateWebValidationParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'parentUrl': value.parentUrl,
        'uri': value.uri,
        'ignoreLock': value.ignoreLock,
        'isEditTask': value.isEditTask,
        'isFromQuestionnaire': value.isFromQuestionnaire,
    };
}


