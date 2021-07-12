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
    ScopeType,
    ScopeTypeFromJSON,
    ScopeTypeFromJSONTyped,
    ScopeTypeToJSON,
    TextValidationRuleRef,
    TextValidationRuleRefFromJSON,
    TextValidationRuleRefFromJSONTyped,
    TextValidationRuleRefToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateWebScopeSettings
 */
export interface CreateWebScopeSettings {
    /**
     * 
     * @type {string}
     * @memberof CreateWebScopeSettings
     */
    restrictParentUrl?: string | null;
    /**
     * 
     * @type {ScopeType}
     * @memberof CreateWebScopeSettings
     */
    scopeType?: ScopeType;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebScopeSettings
     */
    useTitleInUrl?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebScopeSettings
     */
    enableUrlValidation?: boolean;
    /**
     * 
     * @type {TextValidationRuleRef}
     * @memberof CreateWebScopeSettings
     */
    textValidationRule?: TextValidationRuleRef | null;
    /**
     * 
     * @type {Array<SPNode>}
     * @memberof CreateWebScopeSettings
     */
    selectedNodes?: Array<SPNode> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateWebScopeSettings
     */
    autoPopulateUrlWithSPContext?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateWebScopeSettings
     */
    autoPopulateUrlWithSPContextAssignBy?: AssignBy;
}

export function CreateWebScopeSettingsFromJSON(json: any): CreateWebScopeSettings {
    return CreateWebScopeSettingsFromJSONTyped(json, false);
}

export function CreateWebScopeSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateWebScopeSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'restrictParentUrl': !exists(json, 'restrictParentUrl') ? undefined : json['restrictParentUrl'],
        'scopeType': !exists(json, 'scopeType') ? undefined : ScopeTypeFromJSON(json['scopeType']),
        'useTitleInUrl': !exists(json, 'useTitleInUrl') ? undefined : json['useTitleInUrl'],
        'enableUrlValidation': !exists(json, 'enableUrlValidation') ? undefined : json['enableUrlValidation'],
        'textValidationRule': !exists(json, 'textValidationRule') ? undefined : TextValidationRuleRefFromJSON(json['textValidationRule']),
        'selectedNodes': !exists(json, 'selectedNodes') ? undefined : (json['selectedNodes'] === null ? null : (json['selectedNodes'] as Array<any>).map(SPNodeFromJSON)),
        'autoPopulateUrlWithSPContext': !exists(json, 'autoPopulateUrlWithSPContext') ? undefined : json['autoPopulateUrlWithSPContext'],
        'autoPopulateUrlWithSPContextAssignBy': !exists(json, 'autoPopulateUrlWithSPContextAssignBy') ? undefined : AssignByFromJSON(json['autoPopulateUrlWithSPContextAssignBy']),
    };
}

export function CreateWebScopeSettingsToJSON(value?: CreateWebScopeSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'restrictParentUrl': value.restrictParentUrl,
        'scopeType': ScopeTypeToJSON(value.scopeType),
        'useTitleInUrl': value.useTitleInUrl,
        'enableUrlValidation': value.enableUrlValidation,
        'textValidationRule': TextValidationRuleRefToJSON(value.textValidationRule),
        'selectedNodes': value.selectedNodes === undefined ? undefined : (value.selectedNodes === null ? null : (value.selectedNodes as Array<any>).map(SPNodeToJSON)),
        'autoPopulateUrlWithSPContext': value.autoPopulateUrlWithSPContext,
        'autoPopulateUrlWithSPContextAssignBy': AssignByToJSON(value.autoPopulateUrlWithSPContextAssignBy),
    };
}


