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
 * @interface BooleanMetadataSettings
 */
export interface BooleanMetadataSettings {
    /**
     * 
     * @type {boolean}
     * @memberof BooleanMetadataSettings
     */
    enableTerms?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof BooleanMetadataSettings
     */
    value?: boolean;
    /**
     * 
     * @type {string}
     * @memberof BooleanMetadataSettings
     */
    termsAndConditions?: string | null;
}

export function BooleanMetadataSettingsFromJSON(json: any): BooleanMetadataSettings {
    return BooleanMetadataSettingsFromJSONTyped(json, false);
}

export function BooleanMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): BooleanMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableTerms': !exists(json, 'enableTerms') ? undefined : json['enableTerms'],
        'value': !exists(json, 'value') ? undefined : json['value'],
        'termsAndConditions': !exists(json, 'termsAndConditions') ? undefined : json['termsAndConditions'],
    };
}

export function BooleanMetadataSettingsToJSON(value?: BooleanMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableTerms': value.enableTerms,
        'value': value.value,
        'termsAndConditions': value.termsAndConditions,
    };
}


