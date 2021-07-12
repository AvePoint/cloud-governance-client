/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeWebContactValidateResult
 */
export interface ChangeWebContactValidateResult {
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactValidateResult
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactValidateResult
     */
    webUrl?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebContactValidateResult
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebContactValidateResult
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeWebContactValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangeWebContactValidateResult
     */
    messageCode?: MessageCode;
}

export function ChangeWebContactValidateResultFromJSON(json: any): ChangeWebContactValidateResult {
    return ChangeWebContactValidateResultFromJSONTyped(json, false);
}

export function ChangeWebContactValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebContactValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangeWebContactValidateResultToJSON(value?: ChangeWebContactValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'webId': value.webId,
        'webUrl': value.webUrl,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


