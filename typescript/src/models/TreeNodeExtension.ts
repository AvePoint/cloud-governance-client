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
 * @interface TreeNodeExtension
 */
export interface TreeNodeExtension {
    /**
     * 
     * @type {number}
     * @memberof TreeNodeExtension
     */
    size?: number;
    /**
     * 
     * @type {string}
     * @memberof TreeNodeExtension
     */
    userName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNodeExtension
     */
    password?: string | null;
}

export function TreeNodeExtensionFromJSON(json: any): TreeNodeExtension {
    return TreeNodeExtensionFromJSONTyped(json, false);
}

export function TreeNodeExtensionFromJSONTyped(json: any, ignoreDiscriminator: boolean): TreeNodeExtension {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'size': !exists(json, 'size') ? undefined : json['size'],
        'userName': !exists(json, 'userName') ? undefined : json['userName'],
        'password': !exists(json, 'password') ? undefined : json['password'],
    };
}

export function TreeNodeExtensionToJSON(value?: TreeNodeExtension | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'size': value.size,
        'userName': value.userName,
        'password': value.password,
    };
}


