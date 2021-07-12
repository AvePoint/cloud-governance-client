/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeWebSPObject,
    ChangeWebSPObjectFromJSON,
    ChangeWebSPObjectFromJSONTyped,
    ChangeWebSPObjectToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeWebUrlValidateResult
 */
export interface ChangeWebUrlValidateResult {
    /**
     * 
     * @type {ChangeWebSPObject}
     * @memberof ChangeWebUrlValidateResult
     */
    url?: ChangeWebSPObject | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebUrlValidateResult
     */
    webTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebUrlValidateResult
     */
    webDescription?: string | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeWebUrlValidateResult
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebUrlValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebUrlValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangeWebUrlValidateResult
     */
    messageCode?: MessageCode;
}

export function ChangeWebUrlValidateResultFromJSON(json: any): ChangeWebUrlValidateResult {
    return ChangeWebUrlValidateResultFromJSONTyped(json, false);
}

export function ChangeWebUrlValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebUrlValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'url': !exists(json, 'url') ? undefined : ChangeWebSPObjectFromJSON(json['url']),
        'webTitle': !exists(json, 'webTitle') ? undefined : json['webTitle'],
        'webDescription': !exists(json, 'webDescription') ? undefined : json['webDescription'],
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(CustomMetadataFromJSON)),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangeWebUrlValidateResultToJSON(value?: ChangeWebUrlValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'url': ChangeWebSPObjectToJSON(value.url),
        'webTitle': value.webTitle,
        'webDescription': value.webDescription,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(CustomMetadataToJSON)),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


