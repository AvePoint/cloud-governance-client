/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeMetadataActionSetting
 */
export interface ChangeMetadataActionSetting {
    /**
     * 
     * @type {boolean}
     * @memberof ChangeMetadataActionSetting
     */
    isEnabled?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeMetadataActionSetting
     */
    enableAddOrDelete?: boolean;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof ChangeMetadataActionSetting
     */
    metadatas?: Array<CustomMetadata> | null;
}

export function ChangeMetadataActionSettingFromJSON(json: any): ChangeMetadataActionSetting {
    return ChangeMetadataActionSettingFromJSONTyped(json, false);
}

export function ChangeMetadataActionSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeMetadataActionSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'enableAddOrDelete': !exists(json, 'enableAddOrDelete') ? undefined : json['enableAddOrDelete'],
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(CustomMetadataFromJSON)),
    };
}

export function ChangeMetadataActionSettingToJSON(value?: ChangeMetadataActionSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnabled': value.isEnabled,
        'enableAddOrDelete': value.enableAddOrDelete,
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(CustomMetadataToJSON)),
    };
}


