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
 * @interface SiteValidationParameter
 */
export interface SiteValidationParameter {
    /**
     * 
     * @type {string}
     * @memberof SiteValidationParameter
     */
    uri?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SiteValidationParameter
     */
    ignoreLock?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SiteValidationParameter
     */
    isEditTask?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SiteValidationParameter
     */
    isFromQuestionnaire?: boolean;
}

export function SiteValidationParameterFromJSON(json: any): SiteValidationParameter {
    return SiteValidationParameterFromJSONTyped(json, false);
}

export function SiteValidationParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteValidationParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'uri': !exists(json, 'uri') ? undefined : json['uri'],
        'ignoreLock': !exists(json, 'ignoreLock') ? undefined : json['ignoreLock'],
        'isEditTask': !exists(json, 'isEditTask') ? undefined : json['isEditTask'],
        'isFromQuestionnaire': !exists(json, 'isFromQuestionnaire') ? undefined : json['isFromQuestionnaire'],
    };
}

export function SiteValidationParameterToJSON(value?: SiteValidationParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'uri': value.uri,
        'ignoreLock': value.ignoreLock,
        'isEditTask': value.isEditTask,
        'isFromQuestionnaire': value.isFromQuestionnaire,
    };
}


