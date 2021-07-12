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
 * @interface ChangeSiteContactValidateResult
 */
export interface ChangeSiteContactValidateResult {
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactValidateResult
     */
    siteUrl?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteContactValidateResult
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteContactValidateResult
     */
    secondaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteContactValidateResult
     */
    primaryAdministrator?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ChangeSiteContactValidateResult
     */
    additionalAdministrators?: Array<ApiUser> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteContactValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangeSiteContactValidateResult
     */
    messageCode?: MessageCode;
}

export function ChangeSiteContactValidateResultFromJSON(json: any): ChangeSiteContactValidateResult {
    return ChangeSiteContactValidateResultFromJSONTyped(json, false);
}

export function ChangeSiteContactValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteContactValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'primaryAdministrator': !exists(json, 'primaryAdministrator') ? undefined : ApiUserFromJSON(json['primaryAdministrator']),
        'additionalAdministrators': !exists(json, 'additionalAdministrators') ? undefined : (json['additionalAdministrators'] === null ? null : (json['additionalAdministrators'] as Array<any>).map(ApiUserFromJSON)),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangeSiteContactValidateResultToJSON(value?: ChangeSiteContactValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'primaryAdministrator': ApiUserToJSON(value.primaryAdministrator),
        'additionalAdministrators': value.additionalAdministrators === undefined ? undefined : (value.additionalAdministrators === null ? null : (value.additionalAdministrators as Array<any>).map(ApiUserToJSON)),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


