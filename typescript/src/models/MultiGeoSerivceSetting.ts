/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    GeoLocationBase,
    GeoLocationBaseFromJSON,
    GeoLocationBaseFromJSONTyped,
    GeoLocationBaseToJSON,
    GeoLocationModel,
    GeoLocationModelFromJSON,
    GeoLocationModelFromJSONTyped,
    GeoLocationModelToJSON,
    MultiGeoControlMode,
    MultiGeoControlModeFromJSON,
    MultiGeoControlModeFromJSONTyped,
    MultiGeoControlModeToJSON,
} from './';

/**
 * 
 * @export
 * @interface MultiGeoSerivceSetting
 */
export interface MultiGeoSerivceSetting {
    /**
     * 
     * @type {boolean}
     * @memberof MultiGeoSerivceSetting
     */
    isMultiGeoTenant?: boolean;
    /**
     * 
     * @type {Array<GeoLocationModel>}
     * @memberof MultiGeoSerivceSetting
     */
    allLocations?: Array<GeoLocationModel> | null;
    /**
     * 
     * @type {boolean}
     * @memberof MultiGeoSerivceSetting
     */
    isEnabled?: boolean;
    /**
     * 
     * @type {MultiGeoControlMode}
     * @memberof MultiGeoSerivceSetting
     */
    controlMode?: MultiGeoControlMode;
    /**
     * Geo location base model
     * @type {GeoLocationBase}
     * @memberof MultiGeoSerivceSetting
     */
    defaultLocation?: GeoLocationBase | null;
    /**
     * 
     * @type {Array<GeoLocationBase>}
     * @memberof MultiGeoSerivceSetting
     */
    selectedLocations?: Array<GeoLocationBase> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof MultiGeoSerivceSetting
     */
    locationAssignBy?: AssignBy;
    /**
     * 
     * @type {string}
     * @memberof MultiGeoSerivceSetting
     */
    userRoleForLocation?: string | null;
}

export function MultiGeoSerivceSettingFromJSON(json: any): MultiGeoSerivceSetting {
    return MultiGeoSerivceSettingFromJSONTyped(json, false);
}

export function MultiGeoSerivceSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): MultiGeoSerivceSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isMultiGeoTenant': !exists(json, 'isMultiGeoTenant') ? undefined : json['isMultiGeoTenant'],
        'allLocations': !exists(json, 'allLocations') ? undefined : (json['allLocations'] === null ? null : (json['allLocations'] as Array<any>).map(GeoLocationModelFromJSON)),
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'controlMode': !exists(json, 'controlMode') ? undefined : MultiGeoControlModeFromJSON(json['controlMode']),
        'defaultLocation': !exists(json, 'defaultLocation') ? undefined : GeoLocationBaseFromJSON(json['defaultLocation']),
        'selectedLocations': !exists(json, 'selectedLocations') ? undefined : (json['selectedLocations'] === null ? null : (json['selectedLocations'] as Array<any>).map(GeoLocationBaseFromJSON)),
        'locationAssignBy': !exists(json, 'locationAssignBy') ? undefined : AssignByFromJSON(json['locationAssignBy']),
        'userRoleForLocation': !exists(json, 'userRoleForLocation') ? undefined : json['userRoleForLocation'],
    };
}

export function MultiGeoSerivceSettingToJSON(value?: MultiGeoSerivceSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isMultiGeoTenant': value.isMultiGeoTenant,
        'allLocations': value.allLocations === undefined ? undefined : (value.allLocations === null ? null : (value.allLocations as Array<any>).map(GeoLocationModelToJSON)),
        'isEnabled': value.isEnabled,
        'controlMode': MultiGeoControlModeToJSON(value.controlMode),
        'defaultLocation': GeoLocationBaseToJSON(value.defaultLocation),
        'selectedLocations': value.selectedLocations === undefined ? undefined : (value.selectedLocations === null ? null : (value.selectedLocations as Array<any>).map(GeoLocationBaseToJSON)),
        'locationAssignBy': AssignByToJSON(value.locationAssignBy),
        'userRoleForLocation': value.userRoleForLocation,
    };
}


