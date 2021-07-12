/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ContentMoveSPObject,
    ContentMoveSPObjectFromJSON,
    ContentMoveSPObjectFromJSONTyped,
    ContentMoveSPObjectToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ContentMoveUrlValidationResult
 */
export interface ContentMoveUrlValidationResult {
    /**
     * 
     * @type {ContentMoveSPObject}
     * @memberof ContentMoveUrlValidationResult
     */
    object?: ContentMoveSPObject | null;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveUrlValidationResult
     */
    listBaseType?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveUrlValidationResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveUrlValidationResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ContentMoveUrlValidationResult
     */
    messageCode?: MessageCode;
}

export function ContentMoveUrlValidationResultFromJSON(json: any): ContentMoveUrlValidationResult {
    return ContentMoveUrlValidationResultFromJSONTyped(json, false);
}

export function ContentMoveUrlValidationResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveUrlValidationResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'object': !exists(json, 'object') ? undefined : ContentMoveSPObjectFromJSON(json['object']),
        'listBaseType': !exists(json, 'listBaseType') ? undefined : json['listBaseType'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ContentMoveUrlValidationResultToJSON(value?: ContentMoveUrlValidationResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'object': ContentMoveSPObjectToJSON(value.object),
        'listBaseType': value.listBaseType,
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


