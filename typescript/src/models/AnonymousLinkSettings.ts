/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AnnoymouslinkPermissions,
    AnnoymouslinkPermissionsFromJSON,
    AnnoymouslinkPermissionsFromJSONTyped,
    AnnoymouslinkPermissionsToJSON,
} from './';

/**
 * 
 * @export
 * @interface AnonymousLinkSettings
 */
export interface AnonymousLinkSettings {
    /**
     * 
     * @type {AnnoymouslinkPermissions}
     * @memberof AnonymousLinkSettings
     */
    permisssion?: AnnoymouslinkPermissions;
    /**
     * 
     * @type {Date}
     * @memberof AnonymousLinkSettings
     */
    expirationDate?: Date | null;
}

export function AnonymousLinkSettingsFromJSON(json: any): AnonymousLinkSettings {
    return AnonymousLinkSettingsFromJSONTyped(json, false);
}

export function AnonymousLinkSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): AnonymousLinkSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'permisssion': !exists(json, 'permisssion') ? undefined : AnnoymouslinkPermissionsFromJSON(json['permisssion']),
        'expirationDate': !exists(json, 'expirationDate') ? undefined : (json['expirationDate'] === null ? null : new Date(json['expirationDate'])),
    };
}

export function AnonymousLinkSettingsToJSON(value?: AnonymousLinkSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'permisssion': AnnoymouslinkPermissionsToJSON(value.permisssion),
        'expirationDate': value.expirationDate === undefined ? undefined : (value.expirationDate === null ? null : value.expirationDate.toISOString()),
    };
}


