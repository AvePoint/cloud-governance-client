/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ThemeType,
    ThemeTypeFromJSON,
    ThemeTypeFromJSONTyped,
    ThemeTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface PersonalSettingsPropertyInfo
 */
export interface PersonalSettingsPropertyInfo {
    /**
     * 
     * @type {ThemeType}
     * @memberof PersonalSettingsPropertyInfo
     */
    theme?: ThemeType;
    /**
     * 
     * @type {Array<number>}
     * @memberof PersonalSettingsPropertyInfo
     */
    selectedLanguages?: Array<number> | null;
    /**
     * 
     * @type {boolean}
     * @memberof PersonalSettingsPropertyInfo
     */
    isUsingBrowserLanguage?: boolean;
}

export function PersonalSettingsPropertyInfoFromJSON(json: any): PersonalSettingsPropertyInfo {
    return PersonalSettingsPropertyInfoFromJSONTyped(json, false);
}

export function PersonalSettingsPropertyInfoFromJSONTyped(json: any, ignoreDiscriminator: boolean): PersonalSettingsPropertyInfo {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'theme': !exists(json, 'theme') ? undefined : ThemeTypeFromJSON(json['theme']),
        'selectedLanguages': !exists(json, 'selectedLanguages') ? undefined : json['selectedLanguages'],
        'isUsingBrowserLanguage': !exists(json, 'isUsingBrowserLanguage') ? undefined : json['isUsingBrowserLanguage'],
    };
}

export function PersonalSettingsPropertyInfoToJSON(value?: PersonalSettingsPropertyInfo | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'theme': ThemeTypeToJSON(value.theme),
        'selectedLanguages': value.selectedLanguages,
        'isUsingBrowserLanguage': value.isUsingBrowserLanguage,
    };
}


