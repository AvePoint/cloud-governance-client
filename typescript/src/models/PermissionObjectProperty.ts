/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    TreeNodeType,
    TreeNodeTypeFromJSON,
    TreeNodeTypeFromJSONTyped,
    TreeNodeTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface PermissionObjectProperty
 */
export interface PermissionObjectProperty {
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    webServerRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    listTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    objectUrl?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof PermissionObjectProperty
     */
    isInherit?: boolean;
    /**
     * 
     * @type {TreeNodeType}
     * @memberof PermissionObjectProperty
     */
    inheritNodeType?: TreeNodeType;
    /**
     * 
     * @type {string}
     * @memberof PermissionObjectProperty
     */
    topInheritUrl?: string | null;
    /**
     * 
     * @type {TreeNodeType}
     * @memberof PermissionObjectProperty
     */
    checkType?: TreeNodeType;
}

export function PermissionObjectPropertyFromJSON(json: any): PermissionObjectProperty {
    return PermissionObjectPropertyFromJSONTyped(json, false);
}

export function PermissionObjectPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionObjectProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webServerRelativeUrl': !exists(json, 'webServerRelativeUrl') ? undefined : json['webServerRelativeUrl'],
        'listTitle': !exists(json, 'listTitle') ? undefined : json['listTitle'],
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'isInherit': !exists(json, 'isInherit') ? undefined : json['isInherit'],
        'inheritNodeType': !exists(json, 'inheritNodeType') ? undefined : TreeNodeTypeFromJSON(json['inheritNodeType']),
        'topInheritUrl': !exists(json, 'topInheritUrl') ? undefined : json['topInheritUrl'],
        'checkType': !exists(json, 'checkType') ? undefined : TreeNodeTypeFromJSON(json['checkType']),
    };
}

export function PermissionObjectPropertyToJSON(value?: PermissionObjectProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'webId': value.webId,
        'webServerRelativeUrl': value.webServerRelativeUrl,
        'listTitle': value.listTitle,
        'objectUrl': value.objectUrl,
        'isInherit': value.isInherit,
        'inheritNodeType': TreeNodeTypeToJSON(value.inheritNodeType),
        'topInheritUrl': value.topInheritUrl,
        'checkType': TreeNodeTypeToJSON(value.checkType),
    };
}


