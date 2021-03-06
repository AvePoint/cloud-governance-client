/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ItemConflictResolutionType,
    ItemConflictResolutionTypeFromJSON,
    ItemConflictResolutionTypeFromJSONTyped,
    ItemConflictResolutionTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface CopyMoveSetting
 */
export interface CopyMoveSetting {
    /**
     * 
     * @type {boolean}
     * @memberof CopyMoveSetting
     */
    isMigrateConfiguration?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CopyMoveSetting
     */
    isKeepLookAndFeel?: boolean;
    /**
     * 
     * @type {ItemConflictResolutionType}
     * @memberof CopyMoveSetting
     */
    columnsAndContentConflictResolution?: ItemConflictResolutionType;
    /**
     * 
     * @type {boolean}
     * @memberof CopyMoveSetting
     */
    isMigrateSecurity?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CopyMoveSetting
     */
    isMigrateColumnsAndContentTypes?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CopyMoveSetting
     */
    isMigrateContent?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CopyMoveSetting
     */
    isMigrateContentIncludeListAttachment?: boolean;
}

export function CopyMoveSettingFromJSON(json: any): CopyMoveSetting {
    return CopyMoveSettingFromJSONTyped(json, false);
}

export function CopyMoveSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): CopyMoveSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isMigrateConfiguration': !exists(json, 'isMigrateConfiguration') ? undefined : json['isMigrateConfiguration'],
        'isKeepLookAndFeel': !exists(json, 'isKeepLookAndFeel') ? undefined : json['isKeepLookAndFeel'],
        'columnsAndContentConflictResolution': !exists(json, 'columnsAndContentConflictResolution') ? undefined : ItemConflictResolutionTypeFromJSON(json['columnsAndContentConflictResolution']),
        'isMigrateSecurity': !exists(json, 'isMigrateSecurity') ? undefined : json['isMigrateSecurity'],
        'isMigrateColumnsAndContentTypes': !exists(json, 'isMigrateColumnsAndContentTypes') ? undefined : json['isMigrateColumnsAndContentTypes'],
        'isMigrateContent': !exists(json, 'isMigrateContent') ? undefined : json['isMigrateContent'],
        'isMigrateContentIncludeListAttachment': !exists(json, 'isMigrateContentIncludeListAttachment') ? undefined : json['isMigrateContentIncludeListAttachment'],
    };
}

export function CopyMoveSettingToJSON(value?: CopyMoveSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isMigrateConfiguration': value.isMigrateConfiguration,
        'isKeepLookAndFeel': value.isKeepLookAndFeel,
        'columnsAndContentConflictResolution': ItemConflictResolutionTypeToJSON(value.columnsAndContentConflictResolution),
        'isMigrateSecurity': value.isMigrateSecurity,
        'isMigrateColumnsAndContentTypes': value.isMigrateColumnsAndContentTypes,
        'isMigrateContent': value.isMigrateContent,
        'isMigrateContentIncludeListAttachment': value.isMigrateContentIncludeListAttachment,
    };
}


