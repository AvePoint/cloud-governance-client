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
 * @interface SiteTemplate
 */
export interface SiteTemplate {
    /**
     * 
     * @type {string}
     * @memberof SiteTemplate
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SiteTemplate
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SiteTemplate
     */
    category?: string | null;
}

export function SiteTemplateFromJSON(json: any): SiteTemplate {
    return SiteTemplateFromJSONTyped(json, false);
}

export function SiteTemplateFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteTemplate {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'category': !exists(json, 'category') ? undefined : json['category'],
    };
}

export function SiteTemplateToJSON(value?: SiteTemplate | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'title': value.title,
        'category': value.category,
    };
}


