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
 * @interface GuidBooleanModel
 */
export interface GuidBooleanModel {
    /**
     * 
     * @type {boolean}
     * @memberof GuidBooleanModel
     */
    enabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GuidBooleanModel
     */
    seletedItem?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof GuidBooleanModel
     */
    allItems?: Array<string> | null;
}

export function GuidBooleanModelFromJSON(json: any): GuidBooleanModel {
    return GuidBooleanModelFromJSONTyped(json, false);
}

export function GuidBooleanModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuidBooleanModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'seletedItem': !exists(json, 'seletedItem') ? undefined : json['seletedItem'],
        'allItems': !exists(json, 'allItems') ? undefined : json['allItems'],
    };
}

export function GuidBooleanModelToJSON(value?: GuidBooleanModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'seletedItem': value.seletedItem,
        'allItems': value.allItems,
    };
}


