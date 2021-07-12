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
 * @interface ChangeContactByUserSetting
 */
export interface ChangeContactByUserSetting {
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUserSetting
     */
    currentUser?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUserSetting
     */
    newUser?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUserSetting
     */
    alternativeUser?: ApiUser | null;
}

export function ChangeContactByUserSettingFromJSON(json: any): ChangeContactByUserSetting {
    return ChangeContactByUserSettingFromJSONTyped(json, false);
}

export function ChangeContactByUserSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeContactByUserSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'currentUser': !exists(json, 'currentUser') ? undefined : ApiUserFromJSON(json['currentUser']),
        'newUser': !exists(json, 'newUser') ? undefined : ApiUserFromJSON(json['newUser']),
        'alternativeUser': !exists(json, 'alternativeUser') ? undefined : ApiUserFromJSON(json['alternativeUser']),
    };
}

export function ChangeContactByUserSettingToJSON(value?: ChangeContactByUserSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'currentUser': ApiUserToJSON(value.currentUser),
        'newUser': ApiUserToJSON(value.newUser),
        'alternativeUser': ApiUserToJSON(value.alternativeUser),
    };
}


