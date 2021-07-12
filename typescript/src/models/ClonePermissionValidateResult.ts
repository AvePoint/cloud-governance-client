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
 * @interface ClonePermissionValidateResult
 */
export interface ClonePermissionValidateResult {
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ClonePermissionValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ClonePermissionValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ClonePermissionValidateResult
     */
    messageCode?: MessageCode;
}

export function ClonePermissionValidateResultFromJSON(json: any): ClonePermissionValidateResult {
    return ClonePermissionValidateResultFromJSONTyped(json, false);
}

export function ClonePermissionValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ClonePermissionValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ClonePermissionValidateResultToJSON(value?: ClonePermissionValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


