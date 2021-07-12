/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeSitePolicySetting,
    ChangeSitePolicySettingFromJSON,
    ChangeSitePolicySettingFromJSONTyped,
    ChangeSitePolicySettingToJSON,
    ChangeSiteQuotaSettings,
    ChangeSiteQuotaSettingsFromJSON,
    ChangeSiteQuotaSettingsFromJSONTyped,
    ChangeSiteQuotaSettingsToJSON,
    ExtendSiteSetting,
    ExtendSiteSettingFromJSON,
    ExtendSiteSettingFromJSONTyped,
    ExtendSiteSettingToJSON,
    LockSiteSetting,
    LockSiteSettingFromJSON,
    LockSiteSettingFromJSONTyped,
    LockSiteSettingToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
    UnlockSiteSetting,
    UnlockSiteSettingFromJSON,
    UnlockSiteSettingFromJSONTyped,
    UnlockSiteSettingToJSON,
} from './';

/**
 * 
 * @export
 * @interface SiteLifecycleValidateResult
 */
export interface SiteLifecycleValidateResult {
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {ChangeSiteQuotaSettings}
     * @memberof SiteLifecycleValidateResult
     */
    changeQuotaSetting?: ChangeSiteQuotaSettings | null;
    /**
     * 
     * @type {ExtendSiteSetting}
     * @memberof SiteLifecycleValidateResult
     */
    extendSetting?: ExtendSiteSetting | null;
    /**
     * 
     * @type {UnlockSiteSetting}
     * @memberof SiteLifecycleValidateResult
     */
    unlockSetting?: UnlockSiteSetting | null;
    /**
     * 
     * @type {ChangeSitePolicySetting}
     * @memberof SiteLifecycleValidateResult
     */
    changePolicySetting?: ChangeSitePolicySetting | null;
    /**
     * 
     * @type {LockSiteSetting}
     * @memberof SiteLifecycleValidateResult
     */
    lockSetting?: LockSiteSetting | null;
    /**
     * 
     * @type {boolean}
     * @memberof SiteLifecycleValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SiteLifecycleValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof SiteLifecycleValidateResult
     */
    messageCode?: MessageCode;
}

export function SiteLifecycleValidateResultFromJSON(json: any): SiteLifecycleValidateResult {
    return SiteLifecycleValidateResultFromJSONTyped(json, false);
}

export function SiteLifecycleValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteLifecycleValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'changeQuotaSetting': !exists(json, 'changeQuotaSetting') ? undefined : ChangeSiteQuotaSettingsFromJSON(json['changeQuotaSetting']),
        'extendSetting': !exists(json, 'extendSetting') ? undefined : ExtendSiteSettingFromJSON(json['extendSetting']),
        'unlockSetting': !exists(json, 'unlockSetting') ? undefined : UnlockSiteSettingFromJSON(json['unlockSetting']),
        'changePolicySetting': !exists(json, 'changePolicySetting') ? undefined : ChangeSitePolicySettingFromJSON(json['changePolicySetting']),
        'lockSetting': !exists(json, 'lockSetting') ? undefined : LockSiteSettingFromJSON(json['lockSetting']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function SiteLifecycleValidateResultToJSON(value?: SiteLifecycleValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'changeQuotaSetting': ChangeSiteQuotaSettingsToJSON(value.changeQuotaSetting),
        'extendSetting': ExtendSiteSettingToJSON(value.extendSetting),
        'unlockSetting': UnlockSiteSettingToJSON(value.unlockSetting),
        'changePolicySetting': ChangeSitePolicySettingToJSON(value.changePolicySetting),
        'lockSetting': LockSiteSettingToJSON(value.lockSetting),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


