/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ObjectValidateResult
 */
export interface ObjectValidateResult {
    /**
     * 
     * @type {boolean}
     * @memberof ObjectValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ObjectValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ObjectValidateResult
     */
    messageCode?: MessageCode;
}

export function ObjectValidateResultFromJSON(json: any): ObjectValidateResult {
    return ObjectValidateResultFromJSONTyped(json, false);
}

export function ObjectValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ObjectValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ObjectValidateResultToJSON(value?: ObjectValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


