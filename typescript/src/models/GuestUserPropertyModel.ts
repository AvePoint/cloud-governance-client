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
 * @interface GuestUserPropertyModel
 */
export interface GuestUserPropertyModel {
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    displayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    firstName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    lastName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    userName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    usageLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    usageLocationDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    jobTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    jobDepartment?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof GuestUserPropertyModel
     */
    manager?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserPropertyModel
     */
    companyName?: string | null;
}

export function GuestUserPropertyModelFromJSON(json: any): GuestUserPropertyModel {
    return GuestUserPropertyModelFromJSONTyped(json, false);
}

export function GuestUserPropertyModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuestUserPropertyModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'firstName': !exists(json, 'firstName') ? undefined : json['firstName'],
        'lastName': !exists(json, 'lastName') ? undefined : json['lastName'],
        'userName': !exists(json, 'userName') ? undefined : json['userName'],
        'usageLocation': !exists(json, 'usageLocation') ? undefined : json['usageLocation'],
        'usageLocationDisplayName': !exists(json, 'usageLocationDisplayName') ? undefined : json['usageLocationDisplayName'],
        'jobTitle': !exists(json, 'jobTitle') ? undefined : json['jobTitle'],
        'jobDepartment': !exists(json, 'jobDepartment') ? undefined : json['jobDepartment'],
        'manager': !exists(json, 'manager') ? undefined : ApiUserFromJSON(json['manager']),
        'companyName': !exists(json, 'companyName') ? undefined : json['companyName'],
    };
}

export function GuestUserPropertyModelToJSON(value?: GuestUserPropertyModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'displayName': value.displayName,
        'firstName': value.firstName,
        'lastName': value.lastName,
        'userName': value.userName,
        'usageLocation': value.usageLocation,
        'usageLocationDisplayName': value.usageLocationDisplayName,
        'jobTitle': value.jobTitle,
        'jobDepartment': value.jobDepartment,
        'manager': ApiUserToJSON(value.manager),
        'companyName': value.companyName,
    };
}


