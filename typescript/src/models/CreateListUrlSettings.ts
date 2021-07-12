/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ContructUrlSetting,
    ContructUrlSettingFromJSON,
    ContructUrlSettingFromJSONTyped,
    ContructUrlSettingToJSON,
    TextValidationRuleRef,
    TextValidationRuleRefFromJSON,
    TextValidationRuleRefFromJSONTyped,
    TextValidationRuleRefToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateListUrlSettings
 */
export interface CreateListUrlSettings {
    /**
     * 
     * @type {boolean}
     * @memberof CreateListUrlSettings
     */
    enableContructUrl?: boolean;
    /**
     * 
     * @type {ContructUrlSetting}
     * @memberof CreateListUrlSettings
     */
    contructUrlSetting?: ContructUrlSetting | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateListUrlSettings
     */
    enableUrlValidation?: boolean;
    /**
     * 
     * @type {TextValidationRuleRef}
     * @memberof CreateListUrlSettings
     */
    textValidationRule?: TextValidationRuleRef | null;
}

export function CreateListUrlSettingsFromJSON(json: any): CreateListUrlSettings {
    return CreateListUrlSettingsFromJSONTyped(json, false);
}

export function CreateListUrlSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateListUrlSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableContructUrl': !exists(json, 'enableContructUrl') ? undefined : json['enableContructUrl'],
        'contructUrlSetting': !exists(json, 'contructUrlSetting') ? undefined : ContructUrlSettingFromJSON(json['contructUrlSetting']),
        'enableUrlValidation': !exists(json, 'enableUrlValidation') ? undefined : json['enableUrlValidation'],
        'textValidationRule': !exists(json, 'textValidationRule') ? undefined : TextValidationRuleRefFromJSON(json['textValidationRule']),
    };
}

export function CreateListUrlSettingsToJSON(value?: CreateListUrlSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableContructUrl': value.enableContructUrl,
        'contructUrlSetting': ContructUrlSettingToJSON(value.contructUrlSetting),
        'enableUrlValidation': value.enableUrlValidation,
        'textValidationRule': TextValidationRuleRefToJSON(value.textValidationRule),
    };
}


