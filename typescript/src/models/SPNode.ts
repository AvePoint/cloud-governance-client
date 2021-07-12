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
 * @interface SPNode
 */
export interface SPNode {
    /**
     * 
     * @type {string}
     * @memberof SPNode
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof SPNode
     */
    fullUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof SPNode
     */
    type?: NodeType;
    /**
     * 
     * @type {string}
     * @memberof SPNode
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPNode
     */
    title?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SPNode
     */
    isSelected?: boolean;
}

export function SPNodeFromJSON(json: any): SPNode {
    return SPNodeFromJSONTyped(json, false);
}

export function SPNodeFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPNode {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'fullUrl': !exists(json, 'fullUrl') ? undefined : json['fullUrl'],
        'type': !exists(json, 'type') ? undefined : NodeTypeFromJSON(json['type']),
        'name': !exists(json, 'name') ? undefined : json['name'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'isSelected': !exists(json, 'isSelected') ? undefined : json['isSelected'],
    };
}

export function SPNodeToJSON(value?: SPNode | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'fullUrl': value.fullUrl,
        'type': NodeTypeToJSON(value.type),
        'name': value.name,
        'title': value.title,
        'isSelected': value.isSelected,
    };
}


