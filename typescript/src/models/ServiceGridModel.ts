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
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceGridModel
 */
export interface ServiceGridModel {
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    name?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof ServiceGridModel
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {CommonStatus}
     * @memberof ServiceGridModel
     */
    status?: CommonStatus;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {number}
     * @memberof ServiceGridModel
     */
    language?: number;
    /**
     * 
     * @type {Date}
     * @memberof ServiceGridModel
     */
    modifiedTime?: Date;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    createdByDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceGridModel
     */
    createdBy?: string | null;
}

export function ServiceGridModelFromJSON(json: any): ServiceGridModel {
    return ServiceGridModelFromJSONTyped(json, false);
}

export function ServiceGridModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceGridModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
        'status': !exists(json, 'status') ? undefined : CommonStatusFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'language': !exists(json, 'language') ? undefined : json['language'],
        'modifiedTime': !exists(json, 'modifiedTime') ? undefined : (new Date(json['modifiedTime'])),
        'createdByDisplayName': !exists(json, 'createdByDisplayName') ? undefined : json['createdByDisplayName'],
        'createdBy': !exists(json, 'createdBy') ? undefined : json['createdBy'],
    };
}

export function ServiceGridModelToJSON(value?: ServiceGridModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'description': value.description,
        'name': value.name,
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'status': CommonStatusToJSON(value.status),
        'statusDescription': value.statusDescription,
        'language': value.language,
        'modifiedTime': value.modifiedTime === undefined ? undefined : (value.modifiedTime.toISOString()),
        'createdByDisplayName': value.createdByDisplayName,
        'createdBy': value.createdBy,
    };
}


