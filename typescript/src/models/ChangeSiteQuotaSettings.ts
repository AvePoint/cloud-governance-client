/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface ChangeSiteQuotaSettings
 */
export interface ChangeSiteQuotaSettings {
    /**
     * 
     * @type {boolean}
     * @memberof ChangeSiteQuotaSettings
     */
    allowedAnySize?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ChangeSiteQuotaSettings
     */
    minQuotaSize?: number;
    /**
     * 
     * @type {number}
     * @memberof ChangeSiteQuotaSettings
     */
    maxQuotaSize?: number;
    /**
     * 
     * @type {number}
     * @memberof ChangeSiteQuotaSettings
     */
    currentQuotaSize?: number;
}

export function ChangeSiteQuotaSettingsFromJSON(json: any): ChangeSiteQuotaSettings {
    return ChangeSiteQuotaSettingsFromJSONTyped(json, false);
}

export function ChangeSiteQuotaSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteQuotaSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'allowedAnySize': !exists(json, 'allowedAnySize') ? undefined : json['allowedAnySize'],
        'minQuotaSize': !exists(json, 'minQuotaSize') ? undefined : json['minQuotaSize'],
        'maxQuotaSize': !exists(json, 'maxQuotaSize') ? undefined : json['maxQuotaSize'],
        'currentQuotaSize': !exists(json, 'currentQuotaSize') ? undefined : json['currentQuotaSize'],
    };
}

export function ChangeSiteQuotaSettingsToJSON(value?: ChangeSiteQuotaSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'allowedAnySize': value.allowedAnySize,
        'minQuotaSize': value.minQuotaSize,
        'maxQuotaSize': value.maxQuotaSize,
        'currentQuotaSize': value.currentQuotaSize,
    };
}


