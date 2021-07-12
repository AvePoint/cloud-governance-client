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
 * @interface GuidModel
 */
export interface GuidModel {
    /**
     * 
     * @type {string}
     * @memberof GuidModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof GuidModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuidModel
     */
    description?: string | null;
}

export function GuidModelFromJSON(json: any): GuidModel {
    return GuidModelFromJSONTyped(json, false);
}

export function GuidModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuidModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
    };
}

export function GuidModelToJSON(value?: GuidModel | null): any {
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


