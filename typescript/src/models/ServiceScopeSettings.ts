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
    SPNode,
    SPNodeFromJSON,
    SPNodeFromJSONTyped,
    SPNodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceScopeSettings
 */
export interface ServiceScopeSettings {
    /**
     * 
     * @type {Array<SPNode>}
     * @memberof ServiceScopeSettings
     */
    selectedNodes?: Array<SPNode> | null;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceScopeSettings
     */
    autoPopulateUrlWithSPContext?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceScopeSettings
     */
    autoPopulateUrlWithSPContextAssignBy?: AssignBy;
}

export function ServiceScopeSettingsFromJSON(json: any): ServiceScopeSettings {
    return ServiceScopeSettingsFromJSONTyped(json, false);
}

export function ServiceScopeSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceScopeSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'selectedNodes': !exists(json, 'selectedNodes') ? undefined : (json['selectedNodes'] === null ? null : (json['selectedNodes'] as Array<any>).map(SPNodeFromJSON)),
        'autoPopulateUrlWithSPContext': !exists(json, 'autoPopulateUrlWithSPContext') ? undefined : json['autoPopulateUrlWithSPContext'],
        'autoPopulateUrlWithSPContextAssignBy': !exists(json, 'autoPopulateUrlWithSPContextAssignBy') ? undefined : AssignByFromJSON(json['autoPopulateUrlWithSPContextAssignBy']),
    };
}

export function ServiceScopeSettingsToJSON(value?: ServiceScopeSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'selectedNodes': value.selectedNodes === undefined ? undefined : (value.selectedNodes === null ? null : (value.selectedNodes as Array<any>).map(SPNodeToJSON)),
        'autoPopulateUrlWithSPContext': value.autoPopulateUrlWithSPContext,
        'autoPopulateUrlWithSPContextAssignBy': AssignByToJSON(value.autoPopulateUrlWithSPContextAssignBy),
    };
}


