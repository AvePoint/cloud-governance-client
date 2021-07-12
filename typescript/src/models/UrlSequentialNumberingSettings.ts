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
 * @interface UrlSequentialNumberingSettings
 */
export interface UrlSequentialNumberingSettings {
    /**
     * 
     * @type {string}
     * @memberof UrlSequentialNumberingSettings
     */
    prefix?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UrlSequentialNumberingSettings
     */
    delimiter?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UrlSequentialNumberingSettings
     */
    sequenceNumber?: string | null;
}

export function UrlSequentialNumberingSettingsFromJSON(json: any): UrlSequentialNumberingSettings {
    return UrlSequentialNumberingSettingsFromJSONTyped(json, false);
}

export function UrlSequentialNumberingSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): UrlSequentialNumberingSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'prefix': !exists(json, 'prefix') ? undefined : json['prefix'],
        'delimiter': !exists(json, 'delimiter') ? undefined : json['delimiter'],
        'sequenceNumber': !exists(json, 'sequenceNumber') ? undefined : json['sequenceNumber'],
    };
}

export function UrlSequentialNumberingSettingsToJSON(value?: UrlSequentialNumberingSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'prefix': value.prefix,
        'delimiter': value.delimiter,
        'sequenceNumber': value.sequenceNumber,
    };
}


