/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface ApiError
 */
export interface ApiError {
    /**
     * 
     * @type {string}
     * @memberof ApiError
     */
    code?: string | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof ApiError
     */
    message?: Array<string> | null;
    /**
     * 
     * @type {string}
     * @memberof ApiError
     */
    requestId?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof ApiError
     */
    date?: Date;
}

export function ApiErrorFromJSON(json: any): ApiError {
    return ApiErrorFromJSONTyped(json, false);
}

export function ApiErrorFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiError {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'code': !exists(json, 'code') ? undefined : json['code'],
        'message': !exists(json, 'message') ? undefined : json['message'],
        'requestId': !exists(json, 'requestId') ? undefined : json['requestId'],
        'date': !exists(json, 'date') ? undefined : (new Date(json['date'])),
    };
}

export function ApiErrorToJSON(value?: ApiError | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'code': value.code,
        'message': value.message,
        'requestId': value.requestId,
        'date': value.date === undefined ? undefined : (value.date.toISOString()),
    };
}


