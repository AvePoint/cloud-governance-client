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
 * @interface ListValidationParameter
 */
export interface ListValidationParameter {
    /**
     * 
     * @type {string}
     * @memberof ListValidationParameter
     */
    listUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ListValidationParameter
     */
    parentUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ListValidationParameter
     */
    listTitle?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ListValidationParameter
     */
    isDocumentLibrary?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ListValidationParameter
     */
    isEditTask?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ListValidationParameter
     */
    isFromQuestionnaire?: boolean;
}

export function ListValidationParameterFromJSON(json: any): ListValidationParameter {
    return ListValidationParameterFromJSONTyped(json, false);
}

export function ListValidationParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListValidationParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'listUrl': !exists(json, 'listUrl') ? undefined : json['listUrl'],
        'parentUrl': !exists(json, 'parentUrl') ? undefined : json['parentUrl'],
        'listTitle': !exists(json, 'listTitle') ? undefined : json['listTitle'],
        'isDocumentLibrary': !exists(json, 'isDocumentLibrary') ? undefined : json['isDocumentLibrary'],
        'isEditTask': !exists(json, 'isEditTask') ? undefined : json['isEditTask'],
        'isFromQuestionnaire': !exists(json, 'isFromQuestionnaire') ? undefined : json['isFromQuestionnaire'],
    };
}

export function ListValidationParameterToJSON(value?: ListValidationParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'listUrl': value.listUrl,
        'parentUrl': value.parentUrl,
        'listTitle': value.listTitle,
        'isDocumentLibrary': value.isDocumentLibrary,
        'isEditTask': value.isEditTask,
        'isFromQuestionnaire': value.isFromQuestionnaire,
    };
}


