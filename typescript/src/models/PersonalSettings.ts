/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    PersonalSettingsPropertyInfo,
    PersonalSettingsPropertyInfoFromJSON,
    PersonalSettingsPropertyInfoFromJSONTyped,
    PersonalSettingsPropertyInfoToJSON,
} from './';

/**
 * 
 * @export
 * @interface PersonalSettings
 */
export interface PersonalSettings {
    /**
     * 
     * @type {string}
     * @memberof PersonalSettings
     */
    id?: string;
    /**
     * 
     * @type {number}
     * @memberof PersonalSettings
     */
    userID?: number;
    /**
     * 
     * @type {number}
     * @memberof PersonalSettings
     */
    languageID?: number;
    /**
     * 
     * @type {number}
     * @memberof PersonalSettings
     */
    timeZoneID?: number;
    /**
     * 
     * @type {boolean}
     * @memberof PersonalSettings
     */
    isAdjustDaylight?: boolean;
    /**
     * 
     * @type {PersonalSettingsPropertyInfo}
     * @memberof PersonalSettings
     */
    properties?: PersonalSettingsPropertyInfo | null;
}

export function PersonalSettingsFromJSON(json: any): PersonalSettings {
    return PersonalSettingsFromJSONTyped(json, false);
}

export function PersonalSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): PersonalSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'userID': !exists(json, 'userID') ? undefined : json['userID'],
        'languageID': !exists(json, 'languageID') ? undefined : json['languageID'],
        'timeZoneID': !exists(json, 'timeZoneID') ? undefined : json['timeZoneID'],
        'isAdjustDaylight': !exists(json, 'isAdjustDaylight') ? undefined : json['isAdjustDaylight'],
        'properties': !exists(json, 'properties') ? undefined : PersonalSettingsPropertyInfoFromJSON(json['properties']),
    };
}

export function PersonalSettingsToJSON(value?: PersonalSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'userID': value.userID,
        'languageID': value.languageID,
        'timeZoneID': value.timeZoneID,
        'isAdjustDaylight': value.isAdjustDaylight,
        'properties': PersonalSettingsPropertyInfoToJSON(value.properties),
    };
}


