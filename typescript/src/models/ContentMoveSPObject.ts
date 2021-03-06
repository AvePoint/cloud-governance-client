/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    NodeType,
    NodeTypeFromJSON,
    NodeTypeFromJSONTyped,
    NodeTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ContentMoveSPObject
 */
export interface ContentMoveSPObject {
    /**
     * 
     * @type {string}
     * @memberof ContentMoveSPObject
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveSPObject
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveSPObject
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveSPObject
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ContentMoveSPObject
     */
    fullUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof ContentMoveSPObject
     */
    type?: NodeType;
}

export function ContentMoveSPObjectFromJSON(json: any): ContentMoveSPObject {
    return ContentMoveSPObjectFromJSONTyped(json, false);
}

export function ContentMoveSPObjectFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveSPObject {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'fullUrl': !exists(json, 'fullUrl') ? undefined : json['fullUrl'],
        'type': !exists(json, 'type') ? undefined : NodeTypeFromJSON(json['type']),
    };
}

export function ContentMoveSPObjectToJSON(value?: ContentMoveSPObject | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'id': value.id,
        'title': value.title,
        'fullUrl': value.fullUrl,
        'type': NodeTypeToJSON(value.type),
    };
}


