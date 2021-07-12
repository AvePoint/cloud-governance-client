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
 * @interface StringModel
 */
export interface StringModel {
    /**
     * 
     * @type {string}
     * @memberof StringModel
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof StringModel
     */
    name?: string | null;
}

export function StringModelFromJSON(json: any): StringModel {
    return StringModelFromJSONTyped(json, false);
}

export function StringModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): StringModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
    };
}

export function StringModelToJSON(value?: StringModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
    };
}


