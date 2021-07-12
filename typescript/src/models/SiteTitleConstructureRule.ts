/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    SiteConstructTitleType,
    SiteConstructTitleTypeFromJSON,
    SiteConstructTitleTypeFromJSONTyped,
    SiteConstructTitleTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface SiteTitleConstructureRule
 */
export interface SiteTitleConstructureRule {
    /**
     * 
     * @type {SiteConstructTitleType}
     * @memberof SiteTitleConstructureRule
     */
    type?: SiteConstructTitleType;
    /**
     * 
     * @type {string}
     * @memberof SiteTitleConstructureRule
     */
    value?: string | null;
}

export function SiteTitleConstructureRuleFromJSON(json: any): SiteTitleConstructureRule {
    return SiteTitleConstructureRuleFromJSONTyped(json, false);
}

export function SiteTitleConstructureRuleFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteTitleConstructureRule {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': !exists(json, 'type') ? undefined : SiteConstructTitleTypeFromJSON(json['type']),
        'value': !exists(json, 'value') ? undefined : json['value'],
    };
}

export function SiteTitleConstructureRuleToJSON(value?: SiteTitleConstructureRule | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': SiteConstructTitleTypeToJSON(value.type),
        'value': value.value,
    };
}


