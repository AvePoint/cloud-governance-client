/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ListType,
    ListTypeFromJSON,
    ListTypeFromJSONTyped,
    ListTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ListVersionSettings
 */
export interface ListVersionSettings {
    /**
     * 
     * @type {ListType}
     * @memberof ListVersionSettings
     */
    listType?: ListType;
    /**
     * 
     * @type {boolean}
     * @memberof ListVersionSettings
     */
    enableMajorVersions?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ListVersionSettings
     */
    enableMajorAndMinorVersions?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ListVersionSettings
     */
    enableMajorVersionLimit?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ListVersionSettings
     */
    majorVersionLimit?: number;
    /**
     * 
     * @type {boolean}
     * @memberof ListVersionSettings
     */
    enableMinorVersionLimit?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ListVersionSettings
     */
    minorVersionsLimit?: number;
    /**
     * 
     * @type {boolean}
     * @memberof ListVersionSettings
     */
    requireContentApproval?: boolean;
}

export function ListVersionSettingsFromJSON(json: any): ListVersionSettings {
    return ListVersionSettingsFromJSONTyped(json, false);
}

export function ListVersionSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ListVersionSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'listType': !exists(json, 'listType') ? undefined : ListTypeFromJSON(json['listType']),
        'enableMajorVersions': !exists(json, 'enableMajorVersions') ? undefined : json['enableMajorVersions'],
        'enableMajorAndMinorVersions': !exists(json, 'enableMajorAndMinorVersions') ? undefined : json['enableMajorAndMinorVersions'],
        'enableMajorVersionLimit': !exists(json, 'enableMajorVersionLimit') ? undefined : json['enableMajorVersionLimit'],
        'majorVersionLimit': !exists(json, 'majorVersionLimit') ? undefined : json['majorVersionLimit'],
        'enableMinorVersionLimit': !exists(json, 'enableMinorVersionLimit') ? undefined : json['enableMinorVersionLimit'],
        'minorVersionsLimit': !exists(json, 'minorVersionsLimit') ? undefined : json['minorVersionsLimit'],
        'requireContentApproval': !exists(json, 'requireContentApproval') ? undefined : json['requireContentApproval'],
    };
}

export function ListVersionSettingsToJSON(value?: ListVersionSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'listType': ListTypeToJSON(value.listType),
        'enableMajorVersions': value.enableMajorVersions,
        'enableMajorAndMinorVersions': value.enableMajorAndMinorVersions,
        'enableMajorVersionLimit': value.enableMajorVersionLimit,
        'majorVersionLimit': value.majorVersionLimit,
        'enableMinorVersionLimit': value.enableMinorVersionLimit,
        'minorVersionsLimit': value.minorVersionsLimit,
        'requireContentApproval': value.requireContentApproval,
    };
}


