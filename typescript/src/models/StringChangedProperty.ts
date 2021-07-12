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
 * @interface StringChangedProperty
 */
export interface StringChangedProperty {
    /**
     * 
     * @type {string}
     * @memberof StringChangedProperty
     */
    changeValue?: string | null;
    /**
     * 
     * @type {string}
     * @memberof StringChangedProperty
     */
    originalValue?: string | null;
}

export function StringChangedPropertyFromJSON(json: any): StringChangedProperty {
    return StringChangedPropertyFromJSONTyped(json, false);
}

export function StringChangedPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): StringChangedProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeValue': !exists(json, 'changeValue') ? undefined : json['changeValue'],
        'originalValue': !exists(json, 'originalValue') ? undefined : json['originalValue'],
    };
}

export function StringChangedPropertyToJSON(value?: StringChangedProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeValue': value.changeValue,
        'originalValue': value.originalValue,
    };
}


