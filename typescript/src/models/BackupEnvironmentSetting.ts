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
 * @interface BackupEnvironmentSetting
 */
export interface BackupEnvironmentSetting {
    /**
     * 
     * @type {boolean}
     * @memberof BackupEnvironmentSetting
     */
    isBackupSource?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof BackupEnvironmentSetting
     */
    isBackupDestination?: boolean;
    /**
     * 
     * @type {GuidModel}
     * @memberof BackupEnvironmentSetting
     */
    storagePolicy?: GuidModel | null;
}

export function BackupEnvironmentSettingFromJSON(json: any): BackupEnvironmentSetting {
    return BackupEnvironmentSettingFromJSONTyped(json, false);
}

export function BackupEnvironmentSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): BackupEnvironmentSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isBackupSource': !exists(json, 'isBackupSource') ? undefined : json['isBackupSource'],
        'isBackupDestination': !exists(json, 'isBackupDestination') ? undefined : json['isBackupDestination'],
        'storagePolicy': !exists(json, 'storagePolicy') ? undefined : GuidModelFromJSON(json['storagePolicy']),
    };
}

export function BackupEnvironmentSettingToJSON(value?: BackupEnvironmentSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isBackupSource': value.isBackupSource,
        'isBackupDestination': value.isBackupDestination,
        'storagePolicy': GuidModelToJSON(value.storagePolicy),
    };
}


