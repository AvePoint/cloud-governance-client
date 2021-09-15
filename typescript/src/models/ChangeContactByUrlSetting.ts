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
 * @interface ChangeContactByUrlSetting
 */
export interface ChangeContactByUrlSetting {
    /**
     * 
     * @type {string}
     * @memberof ChangeContactByUrlSetting
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeContactByUrlSetting
     */
    siteUrl?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUrlSetting
     */
    originalPrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUrlSetting
     */
    newPrimaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUrlSetting
     */
    originalSecondaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUrlSetting
     */
    newSecondaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUrlSetting
     */
    originalPrimaryAdministrator?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeContactByUrlSetting
     */
    newPrimaryAdministrator?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ChangeContactByUrlSetting
     */
    originalAdditionalAdministrators?: Array<ApiUser> | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ChangeContactByUrlSetting
     */
    newAdditionalAdministrators?: Array<ApiUser> | null;
    /**
     * Site Title
     * @type {string}
     * @memberof ChangeContactByUrlSetting
     */
    siteTitle?: string | null;
}

export function ChangeContactByUrlSettingFromJSON(json: any): ChangeContactByUrlSetting {
    return ChangeContactByUrlSettingFromJSONTyped(json, false);
}

export function ChangeContactByUrlSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeContactByUrlSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'originalPrimaryContact': !exists(json, 'originalPrimaryContact') ? undefined : ApiUserFromJSON(json['originalPrimaryContact']),
        'newPrimaryContact': !exists(json, 'newPrimaryContact') ? undefined : ApiUserFromJSON(json['newPrimaryContact']),
        'originalSecondaryContact': !exists(json, 'originalSecondaryContact') ? undefined : ApiUserFromJSON(json['originalSecondaryContact']),
        'newSecondaryContact': !exists(json, 'newSecondaryContact') ? undefined : ApiUserFromJSON(json['newSecondaryContact']),
        'originalPrimaryAdministrator': !exists(json, 'originalPrimaryAdministrator') ? undefined : ApiUserFromJSON(json['originalPrimaryAdministrator']),
        'newPrimaryAdministrator': !exists(json, 'newPrimaryAdministrator') ? undefined : ApiUserFromJSON(json['newPrimaryAdministrator']),
        'originalAdditionalAdministrators': !exists(json, 'originalAdditionalAdministrators') ? undefined : (json['originalAdditionalAdministrators'] === null ? null : (json['originalAdditionalAdministrators'] as Array<any>).map(ApiUserFromJSON)),
        'newAdditionalAdministrators': !exists(json, 'newAdditionalAdministrators') ? undefined : (json['newAdditionalAdministrators'] === null ? null : (json['newAdditionalAdministrators'] as Array<any>).map(ApiUserFromJSON)),
        'siteTitle': !exists(json, 'siteTitle') ? undefined : json['siteTitle'],
    };
}

export function ChangeContactByUrlSettingToJSON(value?: ChangeContactByUrlSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'originalPrimaryContact': ApiUserToJSON(value.originalPrimaryContact),
        'newPrimaryContact': ApiUserToJSON(value.newPrimaryContact),
        'originalSecondaryContact': ApiUserToJSON(value.originalSecondaryContact),
        'newSecondaryContact': ApiUserToJSON(value.newSecondaryContact),
        'originalPrimaryAdministrator': ApiUserToJSON(value.originalPrimaryAdministrator),
        'newPrimaryAdministrator': ApiUserToJSON(value.newPrimaryAdministrator),
        'originalAdditionalAdministrators': value.originalAdditionalAdministrators === undefined ? undefined : (value.originalAdditionalAdministrators === null ? null : (value.originalAdditionalAdministrators as Array<any>).map(ApiUserToJSON)),
        'newAdditionalAdministrators': value.newAdditionalAdministrators === undefined ? undefined : (value.newAdditionalAdministrators === null ? null : (value.newAdditionalAdministrators as Array<any>).map(ApiUserToJSON)),
        'siteTitle': value.siteTitle,
    };
}


