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
 * @interface GeoLocationModel
 */
export interface GeoLocationModel {
    /**
     * 
     * @type {string}
     * @memberof GeoLocationModel
     */
    rootSiteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GeoLocationModel
     */
    tenantAdminUrl?: string | null;
    /**
     * Geo location name
     * @type {string}
     * @memberof GeoLocationModel
     */
    name?: string | null;
    /**
     * Geo location display name
     * @type {string}
     * @memberof GeoLocationModel
     */
    displayName?: string | null;
}

export function GeoLocationModelFromJSON(json: any): GeoLocationModel {
    return GeoLocationModelFromJSONTyped(json, false);
}

export function GeoLocationModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GeoLocationModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'rootSiteUrl': !exists(json, 'rootSiteUrl') ? undefined : json['rootSiteUrl'],
        'tenantAdminUrl': !exists(json, 'tenantAdminUrl') ? undefined : json['tenantAdminUrl'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
    };
}

export function GeoLocationModelToJSON(value?: GeoLocationModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'rootSiteUrl': value.rootSiteUrl,
        'tenantAdminUrl': value.tenantAdminUrl,
        'name': value.name,
        'displayName': value.displayName,
    };
}


