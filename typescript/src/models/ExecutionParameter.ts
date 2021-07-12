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
 * @interface ExecutionParameter
 */
export interface ExecutionParameter {
    /**
     * 
     * @type {string}
     * @memberof ExecutionParameter
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ExecutionParameter
     */
    type?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ExecutionParameter
     */
    value?: string | null;
}

export function ExecutionParameterFromJSON(json: any): ExecutionParameter {
    return ExecutionParameterFromJSONTyped(json, false);
}

export function ExecutionParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExecutionParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'name': !exists(json, 'name') ? undefined : json['name'],
        'type': !exists(json, 'type') ? undefined : json['type'],
        'value': !exists(json, 'value') ? undefined : json['value'],
    };
}

export function ExecutionParameterToJSON(value?: ExecutionParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'name': value.name,
        'type': value.type,
        'value': value.value,
    };
}


