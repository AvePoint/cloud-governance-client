/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    SiteTemplate,
    SiteTemplateFromJSON,
    SiteTemplateFromJSONTyped,
    SiteTemplateToJSON,
} from './';

/**
 * 
 * @export
 * @interface LanguageWithTemplates
 */
export interface LanguageWithTemplates {
    /**
     * 
     * @type {number}
     * @memberof LanguageWithTemplates
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof LanguageWithTemplates
     */
    defaultTemplate?: string | null;
    /**
     * 
     * @type {Array<SiteTemplate>}
     * @memberof LanguageWithTemplates
     */
    templates?: Array<SiteTemplate> | null;
}

export function LanguageWithTemplatesFromJSON(json: any): LanguageWithTemplates {
    return LanguageWithTemplatesFromJSONTyped(json, false);
}

export function LanguageWithTemplatesFromJSONTyped(json: any, ignoreDiscriminator: boolean): LanguageWithTemplates {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'languageId': !exists(json, 'languageId') ? undefined : json['languageId'],
        'defaultTemplate': !exists(json, 'defaultTemplate') ? undefined : json['defaultTemplate'],
        'templates': !exists(json, 'templates') ? undefined : (json['templates'] === null ? null : (json['templates'] as Array<any>).map(SiteTemplateFromJSON)),
    };
}

export function LanguageWithTemplatesToJSON(value?: LanguageWithTemplates | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'languageId': value.languageId,
        'defaultTemplate': value.defaultTemplate,
        'templates': value.templates === undefined ? undefined : (value.templates === null ? null : (value.templates as Array<any>).map(SiteTemplateToJSON)),
    };
}


