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
    SPList,
    SPListFromJSON,
    SPListFromJSONTyped,
    SPListToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeListSettingValidateResult
 */
export interface ChangeListSettingValidateResult {
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingValidateResult
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingValidateResult
     */
    webId?: string;
    /**
     * 
     * @type {Array<SPList>}
     * @memberof ChangeListSettingValidateResult
     */
    lists?: Array<SPList> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeListSettingValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangeListSettingValidateResult
     */
    messageCode?: MessageCode;
}

export function ChangeListSettingValidateResultFromJSON(json: any): ChangeListSettingValidateResult {
    return ChangeListSettingValidateResultFromJSONTyped(json, false);
}

export function ChangeListSettingValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeListSettingValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'lists': !exists(json, 'lists') ? undefined : (json['lists'] === null ? null : (json['lists'] as Array<any>).map(SPListFromJSON)),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangeListSettingValidateResultToJSON(value?: ChangeListSettingValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteUrl': value.siteUrl,
        'siteId': value.siteId,
        'webUrl': value.webUrl,
        'webId': value.webId,
        'lists': value.lists === undefined ? undefined : (value.lists === null ? null : (value.lists as Array<any>).map(SPListToJSON)),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


