/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChoiceType,
    ChoiceTypeFromJSON,
    ChoiceTypeFromJSONTyped,
    ChoiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChoiceMetadataSettings
 */
export interface ChoiceMetadataSettings {
    /**
     * 
     * @type {Array<string>}
     * @memberof ChoiceMetadataSettings
     */
    choices?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof ChoiceMetadataSettings
     */
    value?: Array<string> | null;
    /**
     * 
     * @type {ChoiceType}
     * @memberof ChoiceMetadataSettings
     */
    choiceType?: ChoiceType;
}

export function ChoiceMetadataSettingsFromJSON(json: any): ChoiceMetadataSettings {
    return ChoiceMetadataSettingsFromJSONTyped(json, false);
}

export function ChoiceMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChoiceMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'choices': !exists(json, 'choices') ? undefined : json['choices'],
        'value': !exists(json, 'value') ? undefined : json['value'],
        'choiceType': !exists(json, 'choiceType') ? undefined : ChoiceTypeFromJSON(json['choiceType']),
    };
}

export function ChoiceMetadataSettingsToJSON(value?: ChoiceMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'choices': value.choices,
        'value': value.value,
        'choiceType': ChoiceTypeToJSON(value.choiceType),
    };
}


