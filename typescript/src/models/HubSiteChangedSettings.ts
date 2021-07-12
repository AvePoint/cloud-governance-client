/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ChangeHubsiteActionType,
    ChangeHubsiteActionTypeFromJSON,
    ChangeHubsiteActionTypeFromJSONTyped,
    ChangeHubsiteActionTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface HubSiteChangedSettings
 */
export interface HubSiteChangedSettings {
    /**
     * 
     * @type {boolean}
     * @memberof HubSiteChangedSettings
     */
    readonly enabled?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof HubSiteChangedSettings
     */
    isModernSite?: boolean;
    /**
     * 
     * @type {ChangeHubsiteActionType}
     * @memberof HubSiteChangedSettings
     */
    action?: ChangeHubsiteActionType;
    /**
     * 
     * @type {string}
     * @memberof HubSiteChangedSettings
     */
    associatedHubSiteId?: string;
    /**
     * 
     * @type {string}
     * @memberof HubSiteChangedSettings
     */
    associatedHubSiteTitle?: string | null;
}

export function HubSiteChangedSettingsFromJSON(json: any): HubSiteChangedSettings {
    return HubSiteChangedSettingsFromJSONTyped(json, false);
}

export function HubSiteChangedSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): HubSiteChangedSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'isModernSite': !exists(json, 'isModernSite') ? undefined : json['isModernSite'],
        'action': !exists(json, 'action') ? undefined : ChangeHubsiteActionTypeFromJSON(json['action']),
        'associatedHubSiteId': !exists(json, 'associatedHubSiteId') ? undefined : json['associatedHubSiteId'],
        'associatedHubSiteTitle': !exists(json, 'associatedHubSiteTitle') ? undefined : json['associatedHubSiteTitle'],
    };
}

export function HubSiteChangedSettingsToJSON(value?: HubSiteChangedSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isModernSite': value.isModernSite,
        'action': ChangeHubsiteActionTypeToJSON(value.action),
        'associatedHubSiteId': value.associatedHubSiteId,
        'associatedHubSiteTitle': value.associatedHubSiteTitle,
    };
}


