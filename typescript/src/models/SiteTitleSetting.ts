/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    SiteTitleConstructureRule,
    SiteTitleConstructureRuleFromJSON,
    SiteTitleConstructureRuleFromJSONTyped,
    SiteTitleConstructureRuleToJSON,
} from './';

/**
 * 
 * @export
 * @interface SiteTitleSetting
 */
export interface SiteTitleSetting {
    /**
     * 
     * @type {number}
     * @memberof SiteTitleSetting
     */
    titleAssignBy?: number;
    /**
     * 
     * @type {boolean}
     * @memberof SiteTitleSetting
     */
    enableTitleConstructure?: boolean;
    /**
     * 
     * @type {Array<SiteTitleConstructureRule>}
     * @memberof SiteTitleSetting
     */
    titlePrefixes?: Array<SiteTitleConstructureRule> | null;
    /**
     * 
     * @type {Array<SiteTitleConstructureRule>}
     * @memberof SiteTitleSetting
     */
    titleSuffixes?: Array<SiteTitleConstructureRule> | null;
}

export function SiteTitleSettingFromJSON(json: any): SiteTitleSetting {
    return SiteTitleSettingFromJSONTyped(json, false);
}

export function SiteTitleSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteTitleSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'titleAssignBy': !exists(json, 'titleAssignBy') ? undefined : json['titleAssignBy'],
        'enableTitleConstructure': !exists(json, 'enableTitleConstructure') ? undefined : json['enableTitleConstructure'],
        'titlePrefixes': !exists(json, 'titlePrefixes') ? undefined : (json['titlePrefixes'] === null ? null : (json['titlePrefixes'] as Array<any>).map(SiteTitleConstructureRuleFromJSON)),
        'titleSuffixes': !exists(json, 'titleSuffixes') ? undefined : (json['titleSuffixes'] === null ? null : (json['titleSuffixes'] as Array<any>).map(SiteTitleConstructureRuleFromJSON)),
    };
}

export function SiteTitleSettingToJSON(value?: SiteTitleSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'titleAssignBy': value.titleAssignBy,
        'enableTitleConstructure': value.enableTitleConstructure,
        'titlePrefixes': value.titlePrefixes === undefined ? undefined : (value.titlePrefixes === null ? null : (value.titlePrefixes as Array<any>).map(SiteTitleConstructureRuleToJSON)),
        'titleSuffixes': value.titleSuffixes === undefined ? undefined : (value.titleSuffixes === null ? null : (value.titleSuffixes as Array<any>).map(SiteTitleConstructureRuleToJSON)),
    };
}


