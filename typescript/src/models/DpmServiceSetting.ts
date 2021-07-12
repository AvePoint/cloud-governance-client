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
} from './';

/**
 * 
 * @export
 * @interface DpmServiceSetting
 */
export interface DpmServiceSetting {
    /**
     * 
     * @type {boolean}
     * @memberof DpmServiceSetting
     */
    isEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof DpmServiceSetting
     */
    defaultValue?: string | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof DpmServiceSetting
     */
    selectedItems?: Array<string> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof DpmServiceSetting
     */
    assignBy?: AssignBy;
}

export function DpmServiceSettingFromJSON(json: any): DpmServiceSetting {
    return DpmServiceSettingFromJSONTyped(json, false);
}

export function DpmServiceSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): DpmServiceSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'defaultValue': !exists(json, 'defaultValue') ? undefined : json['defaultValue'],
        'selectedItems': !exists(json, 'selectedItems') ? undefined : json['selectedItems'],
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
    };
}

export function DpmServiceSettingToJSON(value?: DpmServiceSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnabled': value.isEnabled,
        'defaultValue': value.defaultValue,
        'selectedItems': value.selectedItems,
        'assignBy': AssignByToJSON(value.assignBy),
    };
}


