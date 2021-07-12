/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Represents a custom action associated with a Web site, or subsite.
 * @export
 * @interface UserCustomAction
 */
export interface UserCustomAction {
    /**
     * The target subsite or site's root web url which the user custom actions added to.
     * @type {string}
     * @memberof UserCustomAction
     */
    webFullUrl: string;
    /**
     * The display title of the custom action.
     * @type {string}
     * @memberof UserCustomAction
     */
    title?: string | null;
    /**
     * An implementation-specific value that determines the order of the custom action that appears on the page.
     * @type {number}
     * @memberof UserCustomAction
     */
    sequence?: number;
    /**
     * The URI of a file which contains the ECMAScript to execute on the page.
     * @type {string}
     * @memberof UserCustomAction
     */
    scriptSrc?: string | null;
    /**
     * the ECMAScript to be executed when the custom action is performed.
     * @type {string}
     * @memberof UserCustomAction
     */
    scriptBlock?: string | null;
    /**
     * The name of the custom action.
     * @type {string}
     * @memberof UserCustomAction
     */
    name: string;
    /**
     * The URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action.
     * @type {string}
     * @memberof UserCustomAction
     */
    url?: string | null;
    /**
     * The location of the custom action.
     * @type {string}
     * @memberof UserCustomAction
     */
    location: string;
    /**
     * An implementation-specific value that determines the position of the custom action in the page
     * @type {string}
     * @memberof UserCustomAction
     */
    group?: string | null;
    /**
     * The URL of the image associated with the custom action.
     * @type {string}
     * @memberof UserCustomAction
     */
    imageUrl?: string | null;
    /**
     * The description of the custom action.
     * @type {string}
     * @memberof UserCustomAction
     */
    description?: string | null;
}

export function UserCustomActionFromJSON(json: any): UserCustomAction {
    return UserCustomActionFromJSONTyped(json, false);
}

export function UserCustomActionFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserCustomAction {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'webFullUrl': json['webFullUrl'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'sequence': !exists(json, 'sequence') ? undefined : json['sequence'],
        'scriptSrc': !exists(json, 'scriptSrc') ? undefined : json['scriptSrc'],
        'scriptBlock': !exists(json, 'scriptBlock') ? undefined : json['scriptBlock'],
        'name': json['name'],
        'url': !exists(json, 'url') ? undefined : json['url'],
        'location': json['location'],
        'group': !exists(json, 'group') ? undefined : json['group'],
        'imageUrl': !exists(json, 'imageUrl') ? undefined : json['imageUrl'],
        'description': !exists(json, 'description') ? undefined : json['description'],
    };
}

export function UserCustomActionToJSON(value?: UserCustomAction | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'webFullUrl': value.webFullUrl,
        'title': value.title,
        'sequence': value.sequence,
        'scriptSrc': value.scriptSrc,
        'scriptBlock': value.scriptBlock,
        'name': value.name,
        'url': value.url,
        'location': value.location,
        'group': value.group,
        'imageUrl': value.imageUrl,
        'description': value.description,
    };
}


