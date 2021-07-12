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
 * @interface PolicyWithTemplates
 */
export interface PolicyWithTemplates {
    /**
     * 
     * @type {string}
     * @memberof PolicyWithTemplates
     */
    policyId?: string;
    /**
     * 
     * @type {string}
     * @memberof PolicyWithTemplates
     */
    defaultTemplate?: string | null;
    /**
     * 
     * @type {Array<SiteTemplate>}
     * @memberof PolicyWithTemplates
     */
    templates?: Array<SiteTemplate> | null;
}

export function PolicyWithTemplatesFromJSON(json: any): PolicyWithTemplates {
    return PolicyWithTemplatesFromJSONTyped(json, false);
}

export function PolicyWithTemplatesFromJSONTyped(json: any, ignoreDiscriminator: boolean): PolicyWithTemplates {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'defaultTemplate': !exists(json, 'defaultTemplate') ? undefined : json['defaultTemplate'],
        'templates': !exists(json, 'templates') ? undefined : (json['templates'] === null ? null : (json['templates'] as Array<any>).map(SiteTemplateFromJSON)),
    };
}

export function PolicyWithTemplatesToJSON(value?: PolicyWithTemplates | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'policyId': value.policyId,
        'defaultTemplate': value.defaultTemplate,
        'templates': value.templates === undefined ? undefined : (value.templates === null ? null : (value.templates as Array<any>).map(SiteTemplateToJSON)),
    };
}


