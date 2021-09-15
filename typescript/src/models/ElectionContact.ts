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
 * @interface ElectionContact
 */
export interface ElectionContact {
    /**
     * Display name of contact
     * @type {string}
     * @memberof ElectionContact
     */
    displayName?: string | null;
    /**
     * User principal name of contact
     * @type {string}
     * @memberof ElectionContact
     */
    identityName?: string | null;
}

export function ElectionContactFromJSON(json: any): ElectionContact {
    return ElectionContactFromJSONTyped(json, false);
}

export function ElectionContactFromJSONTyped(json: any, ignoreDiscriminator: boolean): ElectionContact {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'identityName': !exists(json, 'identityName') ? undefined : json['identityName'],
    };
}

export function ElectionContactToJSON(value?: ElectionContact | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'displayName': value.displayName,
        'identityName': value.identityName,
    };
}


