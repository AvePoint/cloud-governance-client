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
 * @interface ContentMoveProfileMappings
 */
export interface ContentMoveProfileMappings {
    /**
     * 
     * @type {GuidModel}
     * @memberof ContentMoveProfileMappings
     */
    columnMapping?: GuidModel | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof ContentMoveProfileMappings
     */
    contentTypeMapping?: GuidModel | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof ContentMoveProfileMappings
     */
    userMapping?: GuidModel | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof ContentMoveProfileMappings
     */
    languageMapping?: GuidModel | null;
}

export function ContentMoveProfileMappingsFromJSON(json: any): ContentMoveProfileMappings {
    return ContentMoveProfileMappingsFromJSONTyped(json, false);
}

export function ContentMoveProfileMappingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveProfileMappings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'columnMapping': !exists(json, 'columnMapping') ? undefined : GuidModelFromJSON(json['columnMapping']),
        'contentTypeMapping': !exists(json, 'contentTypeMapping') ? undefined : GuidModelFromJSON(json['contentTypeMapping']),
        'userMapping': !exists(json, 'userMapping') ? undefined : GuidModelFromJSON(json['userMapping']),
        'languageMapping': !exists(json, 'languageMapping') ? undefined : GuidModelFromJSON(json['languageMapping']),
    };
}

export function ContentMoveProfileMappingsToJSON(value?: ContentMoveProfileMappings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'columnMapping': GuidModelToJSON(value.columnMapping),
        'contentTypeMapping': GuidModelToJSON(value.contentTypeMapping),
        'userMapping': GuidModelToJSON(value.userMapping),
        'languageMapping': GuidModelToJSON(value.languageMapping),
    };
}


