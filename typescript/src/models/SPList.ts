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
 * @interface SPList
 */
export interface SPList {
    /**
     * 
     * @type {string}
     * @memberof SPList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof SPList
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPList
     */
    url?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPList
     */
    description?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SPList
     */
    isLibrary?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SPList
     */
    isOnQuickLaunch?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SPList
     */
    isEnableModeration?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SPList
     */
    isEnableVersioning?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SPList
     */
    isEnableMinorVersion?: boolean;
    /**
     * 
     * @type {number}
     * @memberof SPList
     */
    majorVersionLimit?: number;
    /**
     * 
     * @type {number}
     * @memberof SPList
     */
    majorWithMinorVersionsLimit?: number;
}

export function SPListFromJSON(json: any): SPList {
    return SPListFromJSONTyped(json, false);
}

export function SPListFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'url': !exists(json, 'url') ? undefined : json['url'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'isLibrary': !exists(json, 'isLibrary') ? undefined : json['isLibrary'],
        'isOnQuickLaunch': !exists(json, 'isOnQuickLaunch') ? undefined : json['isOnQuickLaunch'],
        'isEnableModeration': !exists(json, 'isEnableModeration') ? undefined : json['isEnableModeration'],
        'isEnableVersioning': !exists(json, 'isEnableVersioning') ? undefined : json['isEnableVersioning'],
        'isEnableMinorVersion': !exists(json, 'isEnableMinorVersion') ? undefined : json['isEnableMinorVersion'],
        'majorVersionLimit': !exists(json, 'majorVersionLimit') ? undefined : json['majorVersionLimit'],
        'majorWithMinorVersionsLimit': !exists(json, 'majorWithMinorVersionsLimit') ? undefined : json['majorWithMinorVersionsLimit'],
    };
}

export function SPListToJSON(value?: SPList | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'title': value.title,
        'url': value.url,
        'description': value.description,
        'isLibrary': value.isLibrary,
        'isOnQuickLaunch': value.isOnQuickLaunch,
        'isEnableModeration': value.isEnableModeration,
        'isEnableVersioning': value.isEnableVersioning,
        'isEnableMinorVersion': value.isEnableMinorVersion,
        'majorVersionLimit': value.majorVersionLimit,
        'majorWithMinorVersionsLimit': value.majorWithMinorVersionsLimit,
    };
}


