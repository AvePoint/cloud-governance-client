/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ListVersionSettings,
    ListVersionSettingsFromJSON,
    ListVersionSettingsFromJSONTyped,
    ListVersionSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface ListVersionSettingsChangedProperty
 */
export interface ListVersionSettingsChangedProperty {
    /**
     * 
     * @type {ListVersionSettings}
     * @memberof ListVersionSettingsChangedProperty
     */
    changeValue?: ListVersionSettings | null;
    /**
     * 
     * @type {ListVersionSettings}
     * @memberof ListVersionSettingsChangedProperty
     */
    originalValue?: ListVersionSettings | null;
}

export function ListVersionSettingsChangedPropertyFromJSON(json: any): ListVersionSettingsChangedProperty {
    return ListVersionSettingsChangedPropertyFromJSONTyped(json, false);
}

export function ListVersionSettingsChangedPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListVersionSettingsChangedProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeValue': !exists(json, 'changeValue') ? undefined : ListVersionSettingsFromJSON(json['changeValue']),
        'originalValue': !exists(json, 'originalValue') ? undefined : ListVersionSettingsFromJSON(json['originalValue']),
    };
}

export function ListVersionSettingsChangedPropertyToJSON(value?: ListVersionSettingsChangedProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeValue': ListVersionSettingsToJSON(value.changeValue),
        'originalValue': ListVersionSettingsToJSON(value.originalValue),
    };
}


