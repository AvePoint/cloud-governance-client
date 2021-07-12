/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
} from './';

/**
 * Value of Lookup to SharePoint library/list metadata.
 * @export
 * @interface LookupValue
 */
export interface LookupValue {
    /**
     * Id of Office365 tenant.
     * @type {string}
     * @memberof LookupValue
     */
    readonly tenant?: string | null;
    /**
     * Name of user property.
     * @type {string}
     * @memberof LookupValue
     */
    readonly property?: string | null;
    /**
     * Lookup user
     * @type {ApiUser}
     * @memberof LookupValue
     */
    targetUser?: ApiUser | null;
    /**
     * Property value of lookup user
     * @type {string}
     * @memberof LookupValue
     */
    userPropertyValue?: string | null;
    /**
     * Property display value of lookup user
     * @type {string}
     * @memberof LookupValue
     */
    userPropertyDisplayValue?: string | null;
}

export function LookupValueFromJSON(json: any): LookupValue {
    return LookupValueFromJSONTyped(json, false);
}

export function LookupValueFromJSONTyped(json: any, ignoreDiscriminator: boolean): LookupValue {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'tenant': !exists(json, 'tenant') ? undefined : json['tenant'],
        'property': !exists(json, 'property') ? undefined : json['property'],
        'targetUser': !exists(json, 'targetUser') ? undefined : ApiUserFromJSON(json['targetUser']),
        'userPropertyValue': !exists(json, 'userPropertyValue') ? undefined : json['userPropertyValue'],
        'userPropertyDisplayValue': !exists(json, 'userPropertyDisplayValue') ? undefined : json['userPropertyDisplayValue'],
    };
}

export function LookupValueToJSON(value?: LookupValue | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'targetUser': ApiUserToJSON(value.targetUser),
        'userPropertyValue': value.userPropertyValue,
        'userPropertyDisplayValue': value.userPropertyDisplayValue,
    };
}


