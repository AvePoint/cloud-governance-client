/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ConvertHubSiteActionType,
    ConvertHubSiteActionTypeFromJSON,
    ConvertHubSiteActionTypeFromJSONTyped,
    ConvertHubSiteActionTypeToJSON,
} from './';

/**
 * Hub site settings model
 * @export
 * @interface HubSiteSettings
 */
export interface HubSiteSettings {
    /**
     * Whether the hub site functionality is enabled.
     * @type {boolean}
     * @memberof HubSiteSettings
     */
    enabled?: boolean;
    /**
     * Set how to enable the hub site functionality. You can register the site collection as a hub site or associate the site collection with a hub site.
     * @type {ConvertHubSiteActionType}
     * @memberof HubSiteSettings
     */
    action?: ConvertHubSiteActionType;
    /**
     * ID of the associated hub site
     * @type {string}
     * @memberof HubSiteSettings
     */
    associatedHubSiteId?: string | null;
    /**
     * Title of the associated hub site
     * @type {string}
     * @memberof HubSiteSettings
     */
    associatedHubSiteTitle?: string | null;
}

export function HubSiteSettingsFromJSON(json: any): HubSiteSettings {
    return HubSiteSettingsFromJSONTyped(json, false);
}

export function HubSiteSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): HubSiteSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'action': !exists(json, 'action') ? undefined : ConvertHubSiteActionTypeFromJSON(json['action']),
        'associatedHubSiteId': !exists(json, 'associatedHubSiteId') ? undefined : json['associatedHubSiteId'],
        'associatedHubSiteTitle': !exists(json, 'associatedHubSiteTitle') ? undefined : json['associatedHubSiteTitle'],
    };
}

export function HubSiteSettingsToJSON(value?: HubSiteSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'action': ConvertHubSiteActionTypeToJSON(value.action),
        'associatedHubSiteId': value.associatedHubSiteId,
        'associatedHubSiteTitle': value.associatedHubSiteTitle,
    };
}


