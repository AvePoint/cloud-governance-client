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
 * @interface BooleanChangedProperty
 */
export interface BooleanChangedProperty {
    /**
     * 
     * @type {boolean}
     * @memberof BooleanChangedProperty
     */
    changeValue?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof BooleanChangedProperty
     */
    originalValue?: boolean;
}

export function BooleanChangedPropertyFromJSON(json: any): BooleanChangedProperty {
    return BooleanChangedPropertyFromJSONTyped(json, false);
}

export function BooleanChangedPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): BooleanChangedProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeValue': !exists(json, 'changeValue') ? undefined : json['changeValue'],
        'originalValue': !exists(json, 'originalValue') ? undefined : json['originalValue'],
    };
}

export function BooleanChangedPropertyToJSON(value?: BooleanChangedProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeValue': value.changeValue,
        'originalValue': value.originalValue,
    };
}


