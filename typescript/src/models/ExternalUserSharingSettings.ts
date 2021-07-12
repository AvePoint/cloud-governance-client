/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AnonymousLinkSettings,
    AnonymousLinkSettingsFromJSON,
    AnonymousLinkSettingsFromJSONTyped,
    AnonymousLinkSettingsToJSON,
    ExternalUserSharingType,
    ExternalUserSharingTypeFromJSON,
    ExternalUserSharingTypeFromJSONTyped,
    ExternalUserSharingTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ExternalUserSharingSettings
 */
export interface ExternalUserSharingSettings {
    /**
     * 
     * @type {boolean}
     * @memberof ExternalUserSharingSettings
     */
    enabled?: boolean;
    /**
     * 
     * @type {ExternalUserSharingType}
     * @memberof ExternalUserSharingSettings
     */
    sharingType?: ExternalUserSharingType;
    /**
     * 
     * @type {AnonymousLinkSettings}
     * @memberof ExternalUserSharingSettings
     */
    anonymousLinkSettings?: AnonymousLinkSettings | null;
}

export function ExternalUserSharingSettingsFromJSON(json: any): ExternalUserSharingSettings {
    return ExternalUserSharingSettingsFromJSONTyped(json, false);
}

export function ExternalUserSharingSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExternalUserSharingSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'sharingType': !exists(json, 'sharingType') ? undefined : ExternalUserSharingTypeFromJSON(json['sharingType']),
        'anonymousLinkSettings': !exists(json, 'anonymousLinkSettings') ? undefined : AnonymousLinkSettingsFromJSON(json['anonymousLinkSettings']),
    };
}

export function ExternalUserSharingSettingsToJSON(value?: ExternalUserSharingSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'sharingType': ExternalUserSharingTypeToJSON(value.sharingType),
        'anonymousLinkSettings': AnonymousLinkSettingsToJSON(value.anonymousLinkSettings),
    };
}


