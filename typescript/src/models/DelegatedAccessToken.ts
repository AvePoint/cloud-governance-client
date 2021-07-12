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
 * @interface DelegatedAccessToken
 */
export interface DelegatedAccessToken {
    /**
     * 
     * @type {string}
     * @memberof DelegatedAccessToken
     */
    accessToken?: string | null;
    /**
     * 
     * @type {string}
     * @memberof DelegatedAccessToken
     */
    refreshToken?: string | null;
    /**
     * 
     * @type {number}
     * @memberof DelegatedAccessToken
     */
    duration?: number;
}

export function DelegatedAccessTokenFromJSON(json: any): DelegatedAccessToken {
    return DelegatedAccessTokenFromJSONTyped(json, false);
}

export function DelegatedAccessTokenFromJSONTyped(json: any, ignoreDiscriminator: boolean): DelegatedAccessToken {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'accessToken': !exists(json, 'access_token') ? undefined : json['access_token'],
        'refreshToken': !exists(json, 'refresh_token') ? undefined : json['refresh_token'],
        'duration': !exists(json, 'duration') ? undefined : json['duration'],
    };
}

export function DelegatedAccessTokenToJSON(value?: DelegatedAccessToken | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'access_token': value.accessToken,
        'refresh_token': value.refreshToken,
        'duration': value.duration,
    };
}


