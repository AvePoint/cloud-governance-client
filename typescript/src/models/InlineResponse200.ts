/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    DynamicRuleElement,
    DynamicRuleElementFromJSON,
    DynamicRuleElementFromJSONTyped,
    DynamicRuleElementToJSON,
} from './';

/**
 * 
 * @export
 * @interface InlineResponse200
 */
export interface InlineResponse200 {
    /**
     * 
     * @type {Array<DynamicRuleElement>}
     * @memberof InlineResponse200
     */
    contact?: Array<DynamicRuleElement>;
    /**
     * 
     * @type {Array<DynamicRuleElement>}
     * @memberof InlineResponse200
     */
    license?: Array<DynamicRuleElement>;
    /**
     * 
     * @type {Array<DynamicRuleElement>}
     * @memberof InlineResponse200
     */
    organization?: Array<DynamicRuleElement>;
}

export function InlineResponse200FromJSON(json: any): InlineResponse200 {
    return InlineResponse200FromJSONTyped(json, false);
}

export function InlineResponse200FromJSONTyped(json: any, ignoreDiscriminator: boolean): InlineResponse200 {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'contact': !exists(json, 'Contact') ? undefined : ((json['Contact'] as Array<any>).map(DynamicRuleElementFromJSON)),
        'license': !exists(json, 'License') ? undefined : ((json['License'] as Array<any>).map(DynamicRuleElementFromJSON)),
        'organization': !exists(json, 'Organization') ? undefined : ((json['Organization'] as Array<any>).map(DynamicRuleElementFromJSON)),
    };
}

export function InlineResponse200ToJSON(value?: InlineResponse200 | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'Contact': value.contact === undefined ? undefined : ((value.contact as Array<any>).map(DynamicRuleElementToJSON)),
        'License': value.license === undefined ? undefined : ((value.license as Array<any>).map(DynamicRuleElementToJSON)),
        'Organization': value.organization === undefined ? undefined : ((value.organization as Array<any>).map(DynamicRuleElementToJSON)),
    };
}


