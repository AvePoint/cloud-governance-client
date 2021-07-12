/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Value of Lookup User Profile or Azure Ad metadata.
 * @export
 * @interface LookupListValue
 */
export interface LookupListValue {
    /**
     * type of lookup list column
     * @type {string}
     * @memberof LookupListValue
     */
    columnType?: string | null;
    /**
     * name of lookup list column
     * @type {string}
     * @memberof LookupListValue
     */
    columnName?: string | null;
    /**
     * Value of lookup list
     * @type {string}
     * @memberof LookupListValue
     */
    value?: string | null;
    /**
     * Display value of lookup list
     * @type {string}
     * @memberof LookupListValue
     */
    displayValue?: string | null;
}

export function LookupListValueFromJSON(json: any): LookupListValue {
    return LookupListValueFromJSONTyped(json, false);
}

export function LookupListValueFromJSONTyped(json: any, ignoreDiscriminator: boolean): LookupListValue {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'columnType': !exists(json, 'columnType') ? undefined : json['columnType'],
        'columnName': !exists(json, 'columnName') ? undefined : json['columnName'],
        'value': !exists(json, 'value') ? undefined : json['value'],
        'displayValue': !exists(json, 'displayValue') ? undefined : json['displayValue'],
    };
}

export function LookupListValueToJSON(value?: LookupListValue | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'columnType': value.columnType,
        'columnName': value.columnName,
        'value': value.value,
        'displayValue': value.displayValue,
    };
}


