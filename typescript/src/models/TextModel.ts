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
 * @interface TextModel
 */
export interface TextModel {
    /**
     * 
     * @type {string}
     * @memberof TextModel
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TextModel
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TextModel
     */
    name?: string | null;
}

export function TextModelFromJSON(json: any): TextModel {
    return TextModelFromJSONTyped(json, false);
}

export function TextModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): TextModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'description': !exists(json, 'description') ? undefined : json['description'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
    };
}

export function TextModelToJSON(value?: TextModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'description': value.description,
        'id': value.id,
        'name': value.name,
    };
}


