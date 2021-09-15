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
 * @interface CreateWebUrlValidationResult
 */
export interface CreateWebUrlValidationResult {
    /**
     * 
     * @type {string}
     * @memberof CreateWebUrlValidationResult
     */
    parentWebUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateWebUrlValidationResult
     */
    parentSiteUrl?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebUrlValidationResult
     */
    sitePrimaryAdmin?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebUrlValidationResult
     */
    sitePrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateWebUrlValidationResult
     */
    siteSecondaryContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebUrlValidationResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateWebUrlValidationResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof CreateWebUrlValidationResult
     */
    messageCode?: MessageCode;
}

export function CreateWebUrlValidationResultFromJSON(json: any): CreateWebUrlValidationResult {
    return CreateWebUrlValidationResultFromJSONTyped(json, false);
}

export function CreateWebUrlValidationResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateWebUrlValidationResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'parentWebUrl': !exists(json, 'parentWebUrl') ? undefined : json['parentWebUrl'],
        'parentSiteUrl': !exists(json, 'parentSiteUrl') ? undefined : json['parentSiteUrl'],
        'sitePrimaryAdmin': !exists(json, 'sitePrimaryAdmin') ? undefined : ApiUserFromJSON(json['sitePrimaryAdmin']),
        'sitePrimaryContact': !exists(json, 'sitePrimaryContact') ? undefined : ApiUserFromJSON(json['sitePrimaryContact']),
        'siteSecondaryContact': !exists(json, 'siteSecondaryContact') ? undefined : ApiUserFromJSON(json['siteSecondaryContact']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function CreateWebUrlValidationResultToJSON(value?: CreateWebUrlValidationResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'parentWebUrl': value.parentWebUrl,
        'parentSiteUrl': value.parentSiteUrl,
        'sitePrimaryAdmin': ApiUserToJSON(value.sitePrimaryAdmin),
        'sitePrimaryContact': ApiUserToJSON(value.sitePrimaryContact),
        'siteSecondaryContact': ApiUserToJSON(value.siteSecondaryContact),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


