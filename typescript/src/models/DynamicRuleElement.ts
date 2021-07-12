/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    MetadataFieldType,
    MetadataFieldTypeFromJSON,
    MetadataFieldTypeFromJSONTyped,
    MetadataFieldTypeToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelFromJSONTyped,
    StringModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface DynamicRuleElement
 */
export interface DynamicRuleElement {
    /**
     * 
     * @type {string}
     * @memberof DynamicRuleElement
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof DynamicRuleElement
     */
    name?: string | null;
    /**
     * 
     * @type {MetadataFieldType}
     * @memberof DynamicRuleElement
     */
    type?: MetadataFieldType;
    /**
     * 
     * @type {Array<StringModel>}
     * @memberof DynamicRuleElement
     */
    choiceItems?: Array<StringModel> | null;
}

export function DynamicRuleElementFromJSON(json: any): DynamicRuleElement {
    return DynamicRuleElementFromJSONTyped(json, false);
}

export function DynamicRuleElementFromJSONTyped(json: any, ignoreDiscriminator: boolean): DynamicRuleElement {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'type': !exists(json, 'type') ? undefined : MetadataFieldTypeFromJSON(json['type']),
        'choiceItems': !exists(json, 'choiceItems') ? undefined : (json['choiceItems'] === null ? null : (json['choiceItems'] as Array<any>).map(StringModelFromJSON)),
    };
}

export function DynamicRuleElementToJSON(value?: DynamicRuleElement | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'type': MetadataFieldTypeToJSON(value.type),
        'choiceItems': value.choiceItems === undefined ? undefined : (value.choiceItems === null ? null : (value.choiceItems as Array<any>).map(StringModelToJSON)),
    };
}


