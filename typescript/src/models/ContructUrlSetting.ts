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
 * @interface ContructUrlSetting
 */
export interface ContructUrlSetting {
    /**
     * 
     * @type {Array<string>}
     * @memberof ContructUrlSetting
     */
    rules?: Array<string> | null;
    /**
     * 
     * @type {string}
     * @memberof ContructUrlSetting
     */
    suffix?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ContructUrlSetting
     */
    connection?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ContructUrlSetting
     */
    contructUrlAssignBy?: AssignBy;
}

export function ContructUrlSettingFromJSON(json: any): ContructUrlSetting {
    return ContructUrlSettingFromJSONTyped(json, false);
}

export function ContructUrlSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContructUrlSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'rules': !exists(json, 'rules') ? undefined : json['rules'],
        'suffix': !exists(json, 'suffix') ? undefined : json['suffix'],
        'connection': !exists(json, 'connection') ? undefined : json['connection'],
        'contructUrlAssignBy': !exists(json, 'contructUrlAssignBy') ? undefined : AssignByFromJSON(json['contructUrlAssignBy']),
    };
}

export function ContructUrlSettingToJSON(value?: ContructUrlSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'rules': value.rules,
        'suffix': value.suffix,
        'connection': value.connection,
        'contructUrlAssignBy': AssignByToJSON(value.contructUrlAssignBy),
    };
}


