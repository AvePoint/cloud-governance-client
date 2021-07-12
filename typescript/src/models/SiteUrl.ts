/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Site collection url model
 * @export
 * @interface SiteUrl
 */
export interface SiteUrl {
    /**
     * Site collection root site url
     * @type {string}
     * @memberof SiteUrl
     */
    root?: string | null;
    /**
     * Managed path
     * @type {string}
     * @memberof SiteUrl
     */
    managedPath?: string | null;
    /**
     * Site collection name
     * @type {string}
     * @memberof SiteUrl
     */
    name?: string | null;
}

export function SiteUrlFromJSON(json: any): SiteUrl {
    return SiteUrlFromJSONTyped(json, false);
}

export function SiteUrlFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteUrl {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'root': !exists(json, 'root') ? undefined : json['root'],
        'managedPath': !exists(json, 'managedPath') ? undefined : json['managedPath'],
        'name': !exists(json, 'name') ? undefined : json['name'],
    };
}

export function SiteUrlToJSON(value?: SiteUrl | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'root': value.root,
        'managedPath': value.managedPath,
        'name': value.name,
    };
}


