/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    NodeType,
    NodeTypeFromJSON,
    NodeTypeFromJSONTyped,
    NodeTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManagePermissionSPObject
 */
export interface ManagePermissionSPObject {
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    parentUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof ManagePermissionSPObject
     */
    parentNodeType?: NodeType;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    webUrl?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ManagePermissionSPObject
     */
    primaryAdministrator?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ManagePermissionSPObject
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ManagePermissionSPObject
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    temporaryGroupTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    webServerRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    listTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    topInheritUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof ManagePermissionSPObject
     */
    inheritNodeType?: NodeType;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionSPObject
     */
    isInheritedPermission?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionSPObject
     */
    fullUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof ManagePermissionSPObject
     */
    type?: NodeType;
}

export function ManagePermissionSPObjectFromJSON(json: any): ManagePermissionSPObject {
    return ManagePermissionSPObjectFromJSONTyped(json, false);
}

export function ManagePermissionSPObjectFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionSPObject {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'parentUrl': !exists(json, 'parentUrl') ? undefined : json['parentUrl'],
        'parentNodeType': !exists(json, 'parentNodeType') ? undefined : NodeTypeFromJSON(json['parentNodeType']),
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webUrl': !exists(json, 'webUrl') ? undefined : json['webUrl'],
        'primaryAdministrator': !exists(json, 'primaryAdministrator') ? undefined : ApiUserFromJSON(json['primaryAdministrator']),
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'temporaryGroupTitle': !exists(json, 'temporaryGroupTitle') ? undefined : json['temporaryGroupTitle'],
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

export function ManagePermissionSPObjectToJSON(value?: ManagePermissionSPObject | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'parentUrl': value.parentUrl,
        'parentNodeType': NodeTypeToJSON(value.parentNodeType),
        'siteUrl': value.siteUrl,
        'webUrl': value.webUrl,
        'primaryAdministrator': ApiUserToJSON(value.primaryAdministrator),
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'temporaryGroupTitle': value.temporaryGroupTitle,
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


