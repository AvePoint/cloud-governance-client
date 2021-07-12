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
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeSiteSettingValidateResult
 */
export interface ChangeSiteSettingValidateResult {
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingValidateResult
     */
    siteTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingValidateResult
     */
    siteDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingValidateResult
     */
    isEnableChangeHubSite?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingValidateResult
     */
    isModernSite?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingValidateResult
     */
    isHubSite?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingValidateResult
     */
    associatedHubSiteId?: string | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeSiteSettingValidateResult
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteSettingValidateResult
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteSettingValidateResult
     */
    secondaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeSiteSettingValidateResult
     */
    primaryAdministrator?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteSettingValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteSettingValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangeSiteSettingValidateResult
     */
    messageCode?: MessageCode;
}

export function ChangeSiteSettingValidateResultFromJSON(json: any): ChangeSiteSettingValidateResult {
    return ChangeSiteSettingValidateResultFromJSONTyped(json, false);
}

export function ChangeSiteSettingValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteSettingValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteTitle': !exists(json, 'siteTitle') ? undefined : json['siteTitle'],
        'siteDescription': !exists(json, 'siteDescription') ? undefined : json['siteDescription'],
        'isEnableChangeHubSite': !exists(json, 'isEnableChangeHubSite') ? undefined : json['isEnableChangeHubSite'],
        'isModernSite': !exists(json, 'isModernSite') ? undefined : json['isModernSite'],
        'isHubSite': !exists(json, 'isHubSite') ? undefined : json['isHubSite'],
        'associatedHubSiteId': !exists(json, 'associatedHubSiteId') ? undefined : json['associatedHubSiteId'],
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(CustomMetadataFromJSON)),
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'primaryAdministrator': !exists(json, 'primaryAdministrator') ? undefined : ApiUserFromJSON(json['primaryAdministrator']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangeSiteSettingValidateResultToJSON(value?: ChangeSiteSettingValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteUrl': value.siteUrl,
        'siteId': value.siteId,
        'siteTitle': value.siteTitle,
        'siteDescription': value.siteDescription,
        'isEnableChangeHubSite': value.isEnableChangeHubSite,
        'isModernSite': value.isModernSite,
        'isHubSite': value.isHubSite,
        'associatedHubSiteId': value.associatedHubSiteId,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(CustomMetadataToJSON)),
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'primaryAdministrator': ApiUserToJSON(value.primaryAdministrator),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


