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
 * @interface UnlockSiteSetting
 */
export interface UnlockSiteSetting {
    /**
     * 
     * @type {boolean}
     * @memberof UnlockSiteSetting
     */
    isExpired?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof UnlockSiteSetting
     */
    isExtendEnabled?: boolean;
}

export function UnlockSiteSettingFromJSON(json: any): UnlockSiteSetting {
    return UnlockSiteSettingFromJSONTyped(json, false);
}

export function UnlockSiteSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): UnlockSiteSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isExpired': !exists(json, 'isExpired') ? undefined : json['isExpired'],
        'isExtendEnabled': !exists(json, 'isExtendEnabled') ? undefined : json['isExtendEnabled'],
    };
}

export function UnlockSiteSettingToJSON(value?: UnlockSiteSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isExpired': value.isExpired,
        'isExtendEnabled': value.isExtendEnabled,
    };
}


