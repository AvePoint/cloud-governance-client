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
 * @interface LockSiteSetting
 */
export interface LockSiteSetting {
    /**
     * 
     * @type {boolean}
     * @memberof LockSiteSetting
     */
    enableLockAsNoAccess?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof LockSiteSetting
     */
    enableLockAsReadonly?: boolean;
}

export function LockSiteSettingFromJSON(json: any): LockSiteSetting {
    return LockSiteSettingFromJSONTyped(json, false);
}

export function LockSiteSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): LockSiteSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableLockAsNoAccess': !exists(json, 'enableLockAsNoAccess') ? undefined : json['enableLockAsNoAccess'],
        'enableLockAsReadonly': !exists(json, 'enableLockAsReadonly') ? undefined : json['enableLockAsReadonly'],
    };
}

export function LockSiteSettingToJSON(value?: LockSiteSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableLockAsNoAccess': value.enableLockAsNoAccess,
        'enableLockAsReadonly': value.enableLockAsReadonly,
    };
}


