/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    DelegatedAccessToken,
    DelegatedAccessTokenFromJSON,
    DelegatedAccessTokenFromJSONTyped,
    DelegatedAccessTokenToJSON,
} from './';

/**
 * 
 * @export
 * @interface DelegatedAccessTokenApiResult
 */
export interface DelegatedAccessTokenApiResult {
    /**
     * 
     * @type {DelegatedAccessToken}
     * @memberof DelegatedAccessTokenApiResult
     */
    value?: DelegatedAccessToken | null;
    /**
     * 
     * @type {boolean}
     * @memberof DelegatedAccessTokenApiResult
     */
    isSuccess?: boolean;
    /**
     * 
     * @type {string}
     * @memberof DelegatedAccessTokenApiResult
     */
    errorMsg?: string | null;
}

export function DelegatedAccessTokenApiResultFromJSON(json: any): DelegatedAccessTokenApiResult {
    return DelegatedAccessTokenApiResultFromJSONTyped(json, false);
}

export function DelegatedAccessTokenApiResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): DelegatedAccessTokenApiResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : DelegatedAccessTokenFromJSON(json['value']),
        'isSuccess': !exists(json, 'isSuccess') ? undefined : json['isSuccess'],
        'errorMsg': !exists(json, 'errorMsg') ? undefined : json['errorMsg'],
    };
}

export function DelegatedAccessTokenApiResultToJSON(value?: DelegatedAccessTokenApiResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': DelegatedAccessTokenToJSON(value.value),
        'isSuccess': value.isSuccess,
        'errorMsg': value.errorMsg,
    };
}


