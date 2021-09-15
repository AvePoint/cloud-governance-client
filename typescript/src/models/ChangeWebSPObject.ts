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
 * @interface ChangeWebSPObject
 */
export interface ChangeWebSPObject {
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSPObject
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSPObject
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSPObject
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebSPObject
     */
    webId?: string;
    /**
     * Web Title
     * @type {string}
     * @memberof ChangeWebSPObject
     */
    webTitle?: string | null;
}

export function ChangeWebSPObjectFromJSON(json: any): ChangeWebSPObject {
    return ChangeWebSPObjectFromJSONTyped(json, false);
}

export function ChangeWebSPObjectFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebSPObject {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webTitle': !exists(json, 'webTitle') ? undefined : json['webTitle'],
    };
}

export function ChangeWebSPObjectToJSON(value?: ChangeWebSPObject | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteUrl': value.siteUrl,
        'webUrl': value.webUrl,
        'siteId': value.siteId,
        'webId': value.webId,
        'webTitle': value.webTitle,
    };
}


