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
 * @interface LinkMetadataSettings
 */
export interface LinkMetadataSettings {
    /**
     * 
     * @type {string}
     * @memberof LinkMetadataSettings
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof LinkMetadataSettings
     */
    address?: string | null;
}

export function LinkMetadataSettingsFromJSON(json: any): LinkMetadataSettings {
    return LinkMetadataSettingsFromJSONTyped(json, false);
}

export function LinkMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): LinkMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'title': !exists(json, 'title') ? undefined : json['title'],
        'address': !exists(json, 'address') ? undefined : json['address'],
    };
}

export function LinkMetadataSettingsToJSON(value?: LinkMetadataSettings | null): any {
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


