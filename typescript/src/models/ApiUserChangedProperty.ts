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
 * 
 * @export
 * @interface ApiUserChangedProperty
 */
export interface ApiUserChangedProperty {
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ApiUserChangedProperty
     */
    changeValue?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ApiUserChangedProperty
     */
    originalValue?: ApiUser | null;
}

export function ApiUserChangedPropertyFromJSON(json: any): ApiUserChangedProperty {
    return ApiUserChangedPropertyFromJSONTyped(json, false);
}

export function ApiUserChangedPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiUserChangedProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeValue': !exists(json, 'changeValue') ? undefined : ApiUserFromJSON(json['changeValue']),
        'originalValue': !exists(json, 'originalValue') ? undefined : ApiUserFromJSON(json['originalValue']),
    };
}

export function ApiUserChangedPropertyToJSON(value?: ApiUserChangedProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeValue': ApiUserToJSON(value.changeValue),
        'originalValue': ApiUserToJSON(value.originalValue),
    };
}


