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
 * @interface IntModel
 */
export interface IntModel {
    /**
     * 
     * @type {number}
     * @memberof IntModel
     */
    id?: number;
    /**
     * 
     * @type {string}
     * @memberof IntModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof IntModel
     */
    description?: string | null;
}

export function IntModelFromJSON(json: any): IntModel {
    return IntModelFromJSONTyped(json, false);
}

export function IntModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): IntModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
    };
}

export function IntModelToJSON(value?: IntModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'description': value.description,
    };
}


