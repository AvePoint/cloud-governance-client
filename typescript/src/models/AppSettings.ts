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
 * @interface AppSettings
 */
export interface AppSettings {
    /**
     * 
     * @type {boolean}
     * @memberof AppSettings
     */
    enableInstallApp?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof AppSettings
     */
    enableAddSiteInfoCard?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof AppSettings
     */
    enableAddTimeLine?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof AppSettings
     */
    enableAddPanel?: boolean;
}

export function AppSettingsFromJSON(json: any): AppSettings {
    return AppSettingsFromJSONTyped(json, false);
}

export function AppSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): AppSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableInstallApp': !exists(json, 'enableInstallApp') ? undefined : json['enableInstallApp'],
        'enableAddSiteInfoCard': !exists(json, 'enableAddSiteInfoCard') ? undefined : json['enableAddSiteInfoCard'],
        'enableAddTimeLine': !exists(json, 'enableAddTimeLine') ? undefined : json['enableAddTimeLine'],
        'enableAddPanel': !exists(json, 'enableAddPanel') ? undefined : json['enableAddPanel'],
    };
}

export function AppSettingsToJSON(value?: AppSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableInstallApp': value.enableInstallApp,
        'enableAddSiteInfoCard': value.enableAddSiteInfoCard,
        'enableAddTimeLine': value.enableAddTimeLine,
        'enableAddPanel': value.enableAddPanel,
    };
}


