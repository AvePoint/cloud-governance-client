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
 * @interface GrantPermissionSPObject
 */
export interface GrantPermissionSPObject {
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    webServerRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    listTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    topInheritUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof GrantPermissionSPObject
     */
    inheritNodeType?: NodeType;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionSPObject
     */
    isInheritedPermission?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionSPObject
     */
    fullUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof GrantPermissionSPObject
     */
    type?: NodeType;
}

export function GrantPermissionSPObjectFromJSON(json: any): GrantPermissionSPObject {
    return GrantPermissionSPObjectFromJSONTyped(json, false);
}

export function GrantPermissionSPObjectFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionSPObject {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'webServerRelativeUrl': !exists(json, 'webServerRelativeUrl') ? undefined : json['webServerRelativeUrl'],
        'listTitle': !exists(json, 'listTitle') ? undefined : json['listTitle'],
        'topInheritUrl': !exists(json, 'topInheritUrl') ? undefined : json['topInheritUrl'],
        'inheritNodeType': !exists(json, 'inheritNodeType') ? undefined : NodeTypeFromJSON(json['inheritNodeType']),
        'isInheritedPermission': !exists(json, 'isInheritedPermission') ? undefined : json['isInheritedPermission'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'fullUrl': !exists(json, 'fullUrl') ? undefined : json['fullUrl'],
        'type': !exists(json, 'type') ? undefined : NodeTypeFromJSON(json['type']),
    };
}

export function GrantPermissionSPObjectToJSON(value?: GrantPermissionSPObject | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'webId': value.webId,
        'siteId': value.siteId,
        'webServerRelativeUrl': value.webServerRelativeUrl,
        'listTitle': value.listTitle,
        'topInheritUrl': value.topInheritUrl,
        'inheritNodeType': NodeTypeToJSON(value.inheritNodeType),
        'isInheritedPermission': value.isInheritedPermission,
        'id': value.id,
        'title': value.title,
        'fullUrl': value.fullUrl,
        'type': NodeTypeToJSON(value.type),
    };
}


