/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Geo location base model
 * @export
 * @interface GeoLocationBase
 */
export interface GeoLocationBase {
    /**
     * Geo location name
     * @type {string}
     * @memberof GeoLocationBase
     */
    name?: string | null;
    /**
     * Geo location display name
     * @type {string}
     * @memberof GeoLocationBase
     */
    displayName?: string | null;
}

export function GeoLocationBaseFromJSON(json: any): GeoLocationBase {
    return GeoLocationBaseFromJSONTyped(json, false);
}

export function GeoLocationBaseFromJSONTyped(json: any, ignoreDiscriminator: boolean): GeoLocationBase {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'name': !exists(json, 'name') ? undefined : json['name'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
    };
}

export function GeoLocationBaseToJSON(value?: GeoLocationBase | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'name': value.name,
        'displayName': value.displayName,
    };
}


