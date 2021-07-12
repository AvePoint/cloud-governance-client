/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ListTemplate,
    ListTemplateFromJSON,
    ListTemplateFromJSONTyped,
    ListTemplateToJSON,
} from './';

/**
 * 
 * @export
 * @interface ListTemplateSettings
 */
export interface ListTemplateSettings {
    /**
     * 
     * @type {Array<ListTemplate>}
     * @memberof ListTemplateSettings
     */
    availabeTemplates?: Array<ListTemplate> | null;
    /**
     * 
     * @type {string}
     * @memberof ListTemplateSettings
     */
    defaultTemplate?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ListTemplateSettings
     */
    templateStoreUrl?: string | null;
}

export function ListTemplateSettingsFromJSON(json: any): ListTemplateSettings {
    return ListTemplateSettingsFromJSONTyped(json, false);
}

export function ListTemplateSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListTemplateSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'availabeTemplates': !exists(json, 'availabeTemplates') ? undefined : (json['availabeTemplates'] === null ? null : (json['availabeTemplates'] as Array<any>).map(ListTemplateFromJSON)),
        'defaultTemplate': !exists(json, 'defaultTemplate') ? undefined : json['defaultTemplate'],
        'templateStoreUrl': !exists(json, 'templateStoreUrl') ? undefined : json['templateStoreUrl'],
    };
}

export function ListTemplateSettingsToJSON(value?: ListTemplateSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'availabeTemplates': value.availabeTemplates === undefined ? undefined : (value.availabeTemplates === null ? null : (value.availabeTemplates as Array<any>).map(ListTemplateToJSON)),
        'defaultTemplate': value.defaultTemplate,
        'templateStoreUrl': value.templateStoreUrl,
    };
}


