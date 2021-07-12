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
 * @interface UrlRandomStringSettings
 */
export interface UrlRandomStringSettings {
    /**
     * 
     * @type {string}
     * @memberof UrlRandomStringSettings
     */
    prefix?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UrlRandomStringSettings
     */
    maxLength?: number;
    /**
     * 
     * @type {number}
     * @memberof UrlRandomStringSettings
     */
    minLength?: number;
}

export function UrlRandomStringSettingsFromJSON(json: any): UrlRandomStringSettings {
    return UrlRandomStringSettingsFromJSONTyped(json, false);
}

export function UrlRandomStringSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): UrlRandomStringSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'prefix': !exists(json, 'prefix') ? undefined : json['prefix'],
        'maxLength': !exists(json, 'maxLength') ? undefined : json['maxLength'],
        'minLength': !exists(json, 'minLength') ? undefined : json['minLength'],
    };
}

export function UrlRandomStringSettingsToJSON(value?: UrlRandomStringSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'prefix': value.prefix,
        'maxLength': value.maxLength,
        'minLength': value.minLength,
    };
}


