/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Value of Hyperlink metadata
 * @export
 * @interface LinkValue
 */
export interface LinkValue {
    /**
     * Title of link metadata
     * @type {string}
     * @memberof LinkValue
     */
    title?: string | null;
    /**
     * Address of link metadata
     * @type {string}
     * @memberof LinkValue
     */
    address?: string | null;
}

export function LinkValueFromJSON(json: any): LinkValue {
    return LinkValueFromJSONTyped(json, false);
}

export function LinkValueFromJSONTyped(json: any, ignoreDiscriminator: boolean): LinkValue {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'title': !exists(json, 'title') ? undefined : json['title'],
        'address': !exists(json, 'address') ? undefined : json['address'],
    };
}

export function LinkValueToJSON(value?: LinkValue | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'title': value.title,
        'address': value.address,
    };
}


