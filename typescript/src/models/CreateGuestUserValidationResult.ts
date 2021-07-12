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
 * @interface CreateGuestUserValidationResult
 */
export interface CreateGuestUserValidationResult {
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserValidationResult
     */
    groupName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserValidationResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserValidationResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof CreateGuestUserValidationResult
     */
    messageCode?: MessageCode;
}

export function CreateGuestUserValidationResultFromJSON(json: any): CreateGuestUserValidationResult {
    return CreateGuestUserValidationResultFromJSONTyped(json, false);
}

export function CreateGuestUserValidationResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGuestUserValidationResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function CreateGuestUserValidationResultToJSON(value?: CreateGuestUserValidationResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupName': value.groupName,
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


