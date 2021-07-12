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
    MultiGeoControlMode,
    MultiGeoControlModeFromJSON,
    MultiGeoControlModeFromJSONTyped,
    MultiGeoControlModeToJSON,
} from './';

/**
 * 
 * @export
 * @interface MultiGeoSetting
 */
export interface MultiGeoSetting {
    /**
     * 
     * @type {boolean}
     * @memberof MultiGeoSetting
     */
    isEnabled?: boolean;
    /**
     * 
     * @type {MultiGeoControlMode}
     * @memberof MultiGeoSetting
     */
    controlMode?: MultiGeoControlMode;
    /**
     * Geo location base model
     * @type {GeoLocationBase}
     * @memberof MultiGeoSetting
     */
    defaultLocation?: GeoLocationBase | null;
    /**
     * 
     * @type {Array<GeoLocationBase>}
     * @memberof MultiGeoSetting
     */
    selectedLocations?: Array<GeoLocationBase> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof MultiGeoSetting
     */
    locationAssignBy?: AssignBy;
    /**
     * 
     * @type {string}
     * @memberof MultiGeoSetting
     */
    userRoleForLocation?: string | null;
    /**
     * 
     * @type {Array<GeoLocationBase>}
     * @memberof MultiGeoSetting
     */
    allLocations?: Array<GeoLocationBase> | null;
}

export function MultiGeoSettingFromJSON(json: any): MultiGeoSetting {
    return MultiGeoSettingFromJSONTyped(json, false);
}

export function MultiGeoSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): MultiGeoSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'controlMode': !exists(json, 'controlMode') ? undefined : MultiGeoControlModeFromJSON(json['controlMode']),
        'defaultLocation': !exists(json, 'defaultLocation') ? undefined : GeoLocationBaseFromJSON(json['defaultLocation']),
        'selectedLocations': !exists(json, 'selectedLocations') ? undefined : (json['selectedLocations'] === null ? null : (json['selectedLocations'] as Array<any>).map(GeoLocationBaseFromJSON)),
        'locationAssignBy': !exists(json, 'locationAssignBy') ? undefined : AssignByFromJSON(json['locationAssignBy']),
        'userRoleForLocation': !exists(json, 'userRoleForLocation') ? undefined : json['userRoleForLocation'],
        'allLocations': !exists(json, 'allLocations') ? undefined : (json['allLocations'] === null ? null : (json['allLocations'] as Array<any>).map(GeoLocationBaseFromJSON)),
    };
}

export function MultiGeoSettingToJSON(value?: MultiGeoSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnabled': value.isEnabled,
        'controlMode': MultiGeoControlModeToJSON(value.controlMode),
        'defaultLocation': GeoLocationBaseToJSON(value.defaultLocation),
        'selectedLocations': value.selectedLocations === undefined ? undefined : (value.selectedLocations === null ? null : (value.selectedLocations as Array<any>).map(GeoLocationBaseToJSON)),
        'locationAssignBy': AssignByToJSON(value.locationAssignBy),
        'userRoleForLocation': value.userRoleForLocation,
        'allLocations': value.allLocations === undefined ? undefined : (value.allLocations === null ? null : (value.allLocations as Array<any>).map(GeoLocationBaseToJSON)),
    };
}


