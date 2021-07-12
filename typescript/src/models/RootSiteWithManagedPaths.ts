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
 * @interface RootSiteWithManagedPaths
 */
export interface RootSiteWithManagedPaths {
    /**
     * 
     * @type {string}
     * @memberof RootSiteWithManagedPaths
     */
    rootSite?: string | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof RootSiteWithManagedPaths
     */
    managedPaths?: Array<string> | null;
}

export function RootSiteWithManagedPathsFromJSON(json: any): RootSiteWithManagedPaths {
    return RootSiteWithManagedPathsFromJSONTyped(json, false);
}

export function RootSiteWithManagedPathsFromJSONTyped(json: any, ignoreDiscriminator: boolean): RootSiteWithManagedPaths {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'rootSite': !exists(json, 'rootSite') ? undefined : json['rootSite'],
        'managedPaths': !exists(json, 'managedPaths') ? undefined : json['managedPaths'],
    };
}

export function RootSiteWithManagedPathsToJSON(value?: RootSiteWithManagedPaths | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'rootSite': value.rootSite,
        'managedPaths': value.managedPaths,
    };
}


