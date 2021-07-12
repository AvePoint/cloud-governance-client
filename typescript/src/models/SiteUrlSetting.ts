/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AutoGenerateUrlSetting,
    AutoGenerateUrlSettingFromJSON,
    AutoGenerateUrlSettingFromJSONTyped,
    AutoGenerateUrlSettingToJSON,
    ManuallyInputUrlSetting,
    ManuallyInputUrlSettingFromJSON,
    ManuallyInputUrlSettingFromJSONTyped,
    ManuallyInputUrlSettingToJSON,
    SiteConstructUrlType,
    SiteConstructUrlTypeFromJSON,
    SiteConstructUrlTypeFromJSONTyped,
    SiteConstructUrlTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface SiteUrlSetting
 */
export interface SiteUrlSetting {
    /**
     * 
     * @type {SiteConstructUrlType}
     * @memberof SiteUrlSetting
     */
    type?: SiteConstructUrlType;
    /**
     * 
     * @type {ManuallyInputUrlSetting}
     * @memberof SiteUrlSetting
     */
    manuallyInputSetting?: ManuallyInputUrlSetting | null;
    /**
     * 
     * @type {AutoGenerateUrlSetting}
     * @memberof SiteUrlSetting
     */
    autoGenerateUrlSetting?: AutoGenerateUrlSetting | null;
}

export function SiteUrlSettingFromJSON(json: any): SiteUrlSetting {
    return SiteUrlSettingFromJSONTyped(json, false);
}

export function SiteUrlSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): SiteUrlSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': !exists(json, 'type') ? undefined : SiteConstructUrlTypeFromJSON(json['type']),
        'manuallyInputSetting': !exists(json, 'manuallyInputSetting') ? undefined : ManuallyInputUrlSettingFromJSON(json['manuallyInputSetting']),
        'autoGenerateUrlSetting': !exists(json, 'autoGenerateUrlSetting') ? undefined : AutoGenerateUrlSettingFromJSON(json['autoGenerateUrlSetting']),
    };
}

export function SiteUrlSettingToJSON(value?: SiteUrlSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': SiteConstructUrlTypeToJSON(value.type),
        'manuallyInputSetting': ManuallyInputUrlSettingToJSON(value.manuallyInputSetting),
        'autoGenerateUrlSetting': AutoGenerateUrlSettingToJSON(value.autoGenerateUrlSetting),
    };
}


