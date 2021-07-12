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
 * @interface CreateListSPObject
 */
export interface CreateListSPObject {
    /**
     * 
     * @type {string}
     * @memberof CreateListSPObject
     */
    parentUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListSPObject
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateListSPObject
     */
    siteId?: string;
}

export function CreateListSPObjectFromJSON(json: any): CreateListSPObject {
    return CreateListSPObjectFromJSONTyped(json, false);
}

export function CreateListSPObjectFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateListSPObject {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'parentUrl': !exists(json, 'parentUrl') ? undefined : json['parentUrl'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
    };
}

export function CreateListSPObjectToJSON(value?: CreateListSPObject | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'parentUrl': value.parentUrl,
        'siteUrl': value.siteUrl,
        'siteId': value.siteId,
    };
}


