/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    SPBaseType,
    SPBaseTypeFromJSON,
    SPBaseTypeFromJSONTyped,
    SPBaseTypeToJSON,
    SPListTemplateType,
    SPListTemplateTypeFromJSON,
    SPListTemplateTypeFromJSONTyped,
    SPListTemplateTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ListTemplate
 */
export interface ListTemplate {
    /**
     * 
     * @type {string}
     * @memberof ListTemplate
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ListTemplate
     */
    description?: string | null;
    /**
     * 
     * @type {SPListTemplateType}
     * @memberof ListTemplate
     */
    type?: SPListTemplateType;
    /**
     * 
     * @type {SPBaseType}
     * @memberof ListTemplate
     */
    baseType?: SPBaseType;
    /**
     * 
     * @type {string}
     * @memberof ListTemplate
     */
    name?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ListTemplate
     */
    isCustomTemplate?: boolean;
}

export function ListTemplateFromJSON(json: any): ListTemplate {
    return ListTemplateFromJSONTyped(json, false);
}

export function ListTemplateFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListTemplate {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'title': !exists(json, 'title') ? undefined : json['title'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'type': !exists(json, 'type') ? undefined : SPListTemplateTypeFromJSON(json['type']),
        'baseType': !exists(json, 'baseType') ? undefined : SPBaseTypeFromJSON(json['baseType']),
        'name': !exists(json, 'name') ? undefined : json['name'],
        'isCustomTemplate': !exists(json, 'isCustomTemplate') ? undefined : json['isCustomTemplate'],
    };
}

export function ListTemplateToJSON(value?: ListTemplate | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'title': value.title,
        'description': value.description,
        'type': SPListTemplateTypeToJSON(value.type),
        'baseType': SPBaseTypeToJSON(value.baseType),
        'name': value.name,
        'isCustomTemplate': value.isCustomTemplate,
    };
}


