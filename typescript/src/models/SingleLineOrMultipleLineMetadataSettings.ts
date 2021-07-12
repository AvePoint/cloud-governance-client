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
 * @interface SingleLineOrMultipleLineMetadataSettings
 */
export interface SingleLineOrMultipleLineMetadataSettings {
    /**
     * 
     * @type {string}
     * @memberof SingleLineOrMultipleLineMetadataSettings
     */
    value?: string | null;
}

export function SingleLineOrMultipleLineMetadataSettingsFromJSON(json: any): SingleLineOrMultipleLineMetadataSettings {
    return SingleLineOrMultipleLineMetadataSettingsFromJSONTyped(json, false);
}

export function SingleLineOrMultipleLineMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): SingleLineOrMultipleLineMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : json['value'],
    };
}

export function SingleLineOrMultipleLineMetadataSettingsToJSON(value?: SingleLineOrMultipleLineMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value,
    };
}


