/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface TextValidationRuleRef
 */
export interface TextValidationRuleRef {
    /**
     * 
     * @type {string}
     * @memberof TextValidationRuleRef
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof TextValidationRuleRef
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TextValidationRuleRef
     */
    expression?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TextValidationRuleRef
     */
    errorMessage?: string | null;
}

export function TextValidationRuleRefFromJSON(json: any): TextValidationRuleRef {
    return TextValidationRuleRefFromJSONTyped(json, false);
}

export function TextValidationRuleRefFromJSONTyped(json: any, ignoreDiscriminator: boolean): TextValidationRuleRef {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'expression': !exists(json, 'expression') ? undefined : json['expression'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
    };
}

export function TextValidationRuleRefToJSON(value?: TextValidationRuleRef | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'expression': value.expression,
        'errorMessage': value.errorMessage,
    };
}


