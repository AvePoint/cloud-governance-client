/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    CreateListSPObject,
    CreateListSPObjectFromJSON,
    CreateListSPObjectFromJSONTyped,
    CreateListSPObjectToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateListUrlValidationResult
 */
export interface CreateListUrlValidationResult {
    /**
     * 
     * @type {CreateListSPObject}
     * @memberof CreateListUrlValidationResult
     */
    parentObject?: CreateListSPObject | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListUrlValidationResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateListUrlValidationResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof CreateListUrlValidationResult
     */
    messageCode?: MessageCode;
}

export function CreateListUrlValidationResultFromJSON(json: any): CreateListUrlValidationResult {
    return CreateListUrlValidationResultFromJSONTyped(json, false);
}

export function CreateListUrlValidationResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateListUrlValidationResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'parentObject': !exists(json, 'parentObject') ? undefined : CreateListSPObjectFromJSON(json['parentObject']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function CreateListUrlValidationResultToJSON(value?: CreateListUrlValidationResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'parentObject': CreateListSPObjectToJSON(value.parentObject),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


