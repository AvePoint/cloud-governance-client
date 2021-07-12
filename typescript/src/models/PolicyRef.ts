/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    CommonStatus,
    CommonStatusFromJSON,
    CommonStatusFromJSONTyped,
    CommonStatusToJSON,
} from './';

/**
 * 
 * @export
 * @interface PolicyRef
 */
export interface PolicyRef {
    /**
     * 
     * @type {string}
     * @memberof PolicyRef
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof PolicyRef
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PolicyRef
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PolicyRef
     */
    category?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PolicyRef
     */
    tenantId?: string;
    /**
     * 
     * @type {CommonStatus}
     * @memberof PolicyRef
     */
    status?: CommonStatus;
}

export function PolicyRefFromJSON(json: any): PolicyRef {
    return PolicyRefFromJSONTyped(json, false);
}

export function PolicyRefFromJSONTyped(json: any, ignoreDiscriminator: boolean): PolicyRef {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'category': !exists(json, 'category') ? undefined : json['category'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'status': !exists(json, 'status') ? undefined : CommonStatusFromJSON(json['status']),
    };
}

export function PolicyRefToJSON(value?: PolicyRef | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'category': value.category,
        'tenantId': value.tenantId,
        'status': CommonStatusToJSON(value.status),
    };
}


