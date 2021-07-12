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
 * @interface WebLifecycleValidateResult
 */
export interface WebLifecycleValidateResult {
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleValidateResult
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleValidateResult
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleValidateResult
     */
    webRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof WebLifecycleValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof WebLifecycleValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof WebLifecycleValidateResult
     */
    messageCode?: MessageCode;
}

export function WebLifecycleValidateResultFromJSON(json: any): WebLifecycleValidateResult {
    return WebLifecycleValidateResultFromJSONTyped(json, false);
}

export function WebLifecycleValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): WebLifecycleValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'webRelativeUrl': !exists(json, 'webRelativeUrl') ? undefined : json['webRelativeUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function WebLifecycleValidateResultToJSON(value?: WebLifecycleValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'webId': value.webId,
        'webUrl': value.webUrl,
        'webRelativeUrl': value.webRelativeUrl,
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


