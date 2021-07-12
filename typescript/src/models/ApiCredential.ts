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
 * @interface ApiCredential
 */
export interface ApiCredential {
    /**
     * 
     * @type {string}
     * @memberof ApiCredential
     */
    clientSecret?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ApiCredential
     */
    userPrincipalName?: string | null;
}

export function ApiCredentialFromJSON(json: any): ApiCredential {
    return ApiCredentialFromJSONTyped(json, false);
}

export function ApiCredentialFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiCredential {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'clientSecret': !exists(json, 'clientSecret') ? undefined : json['clientSecret'],
        'userPrincipalName': !exists(json, 'userPrincipalName') ? undefined : json['userPrincipalName'],
    };
}

export function ApiCredentialToJSON(value?: ApiCredential | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'clientSecret': value.clientSecret,
        'userPrincipalName': value.userPrincipalName,
    };
}


