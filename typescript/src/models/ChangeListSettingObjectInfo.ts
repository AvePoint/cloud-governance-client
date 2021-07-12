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
 * @interface ChangeListSettingObjectInfo
 */
export interface ChangeListSettingObjectInfo {
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingObjectInfo
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingObjectInfo
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingObjectInfo
     */
    webUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingObjectInfo
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingObjectInfo
     */
    objectUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeListSettingObjectInfo
     */
    objectTitle?: string | null;
}

export function ChangeListSettingObjectInfoFromJSON(json: any): ChangeListSettingObjectInfo {
    return ChangeListSettingObjectInfoFromJSONTyped(json, false);
}

export function ChangeListSettingObjectInfoFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeListSettingObjectInfo {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'objectTitle': !exists(json, 'objectTitle') ? undefined : json['objectTitle'],
    };
}

export function ChangeListSettingObjectInfoToJSON(value?: ChangeListSettingObjectInfo | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteUrl': value.siteUrl,
        'webId': value.webId,
        'webUrl': value.webUrl,
        'siteId': value.siteId,
        'objectUrl': value.objectUrl,
        'objectTitle': value.objectTitle,
    };
}


