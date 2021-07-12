/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface ContentMoveProfiles
 */
export interface ContentMoveProfiles {
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ContentMoveProfiles
     */
    backupEnvironmentStoragePolices?: Array<GuidModel> | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ContentMoveProfiles
     */
    columnMappings?: Array<GuidModel> | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ContentMoveProfiles
     */
    contentTypeMappings?: Array<GuidModel> | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ContentMoveProfiles
     */
    userMappings?: Array<GuidModel> | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ContentMoveProfiles
     */
    languageMappings?: Array<GuidModel> | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof ContentMoveProfiles
     */
    filterPolices?: Array<GuidModel> | null;
}

export function ContentMoveProfilesFromJSON(json: any): ContentMoveProfiles {
    return ContentMoveProfilesFromJSONTyped(json, false);
}

export function ContentMoveProfilesFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveProfiles {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'backupEnvironmentStoragePolices': !exists(json, 'backupEnvironmentStoragePolices') ? undefined : (json['backupEnvironmentStoragePolices'] === null ? null : (json['backupEnvironmentStoragePolices'] as Array<any>).map(GuidModelFromJSON)),
        'columnMappings': !exists(json, 'columnMappings') ? undefined : (json['columnMappings'] === null ? null : (json['columnMappings'] as Array<any>).map(GuidModelFromJSON)),
        'contentTypeMappings': !exists(json, 'contentTypeMappings') ? undefined : (json['contentTypeMappings'] === null ? null : (json['contentTypeMappings'] as Array<any>).map(GuidModelFromJSON)),
        'userMappings': !exists(json, 'userMappings') ? undefined : (json['userMappings'] === null ? null : (json['userMappings'] as Array<any>).map(GuidModelFromJSON)),
        'languageMappings': !exists(json, 'languageMappings') ? undefined : (json['languageMappings'] === null ? null : (json['languageMappings'] as Array<any>).map(GuidModelFromJSON)),
        'filterPolices': !exists(json, 'filterPolices') ? undefined : (json['filterPolices'] === null ? null : (json['filterPolices'] as Array<any>).map(GuidModelFromJSON)),
    };
}

export function ContentMoveProfilesToJSON(value?: ContentMoveProfiles | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'backupEnvironmentStoragePolices': value.backupEnvironmentStoragePolices === undefined ? undefined : (value.backupEnvironmentStoragePolices === null ? null : (value.backupEnvironmentStoragePolices as Array<any>).map(GuidModelToJSON)),
        'columnMappings': value.columnMappings === undefined ? undefined : (value.columnMappings === null ? null : (value.columnMappings as Array<any>).map(GuidModelToJSON)),
        'contentTypeMappings': value.contentTypeMappings === undefined ? undefined : (value.contentTypeMappings === null ? null : (value.contentTypeMappings as Array<any>).map(GuidModelToJSON)),
        'userMappings': value.userMappings === undefined ? undefined : (value.userMappings === null ? null : (value.userMappings as Array<any>).map(GuidModelToJSON)),
        'languageMappings': value.languageMappings === undefined ? undefined : (value.languageMappings === null ? null : (value.languageMappings as Array<any>).map(GuidModelToJSON)),
        'filterPolices': value.filterPolices === undefined ? undefined : (value.filterPolices === null ? null : (value.filterPolices as Array<any>).map(GuidModelToJSON)),
    };
}


