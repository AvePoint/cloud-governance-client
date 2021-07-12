/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AutoGenerateUrlType,
    AutoGenerateUrlTypeFromJSON,
    AutoGenerateUrlTypeFromJSONTyped,
    AutoGenerateUrlTypeToJSON,
    UrlRandomStringSettings,
    UrlRandomStringSettingsFromJSON,
    UrlRandomStringSettingsFromJSONTyped,
    UrlRandomStringSettingsToJSON,
    UrlSequentialNumberingSettings,
    UrlSequentialNumberingSettingsFromJSON,
    UrlSequentialNumberingSettingsFromJSONTyped,
    UrlSequentialNumberingSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface AutoGenerateUrlSetting
 */
export interface AutoGenerateUrlSetting {
    /**
     * 
     * @type {AutoGenerateUrlType}
     * @memberof AutoGenerateUrlSetting
     */
    generateUrlType?: AutoGenerateUrlType;
    /**
     * 
     * @type {UrlSequentialNumberingSettings}
     * @memberof AutoGenerateUrlSetting
     */
    sequentialNumberingSettings?: UrlSequentialNumberingSettings | null;
    /**
     * 
     * @type {UrlRandomStringSettings}
     * @memberof AutoGenerateUrlSetting
     */
    randomStringSettings?: UrlRandomStringSettings | null;
}

export function AutoGenerateUrlSettingFromJSON(json: any): AutoGenerateUrlSetting {
    return AutoGenerateUrlSettingFromJSONTyped(json, false);
}

export function AutoGenerateUrlSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): AutoGenerateUrlSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'generateUrlType': !exists(json, 'generateUrlType') ? undefined : AutoGenerateUrlTypeFromJSON(json['generateUrlType']),
        'sequentialNumberingSettings': !exists(json, 'sequentialNumberingSettings') ? undefined : UrlSequentialNumberingSettingsFromJSON(json['sequentialNumberingSettings']),
        'randomStringSettings': !exists(json, 'randomStringSettings') ? undefined : UrlRandomStringSettingsFromJSON(json['randomStringSettings']),
    };
}

export function AutoGenerateUrlSettingToJSON(value?: AutoGenerateUrlSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'generateUrlType': AutoGenerateUrlTypeToJSON(value.generateUrlType),
        'sequentialNumberingSettings': UrlSequentialNumberingSettingsToJSON(value.sequentialNumberingSettings),
        'randomStringSettings': UrlRandomStringSettingsToJSON(value.randomStringSettings),
    };
}


