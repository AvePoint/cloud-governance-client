/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    BackupEnvironmentSetting,
    BackupEnvironmentSettingFromJSON,
    BackupEnvironmentSettingFromJSONTyped,
    BackupEnvironmentSettingToJSON,
    ConflictResolutionSetting,
    ConflictResolutionSettingFromJSON,
    ConflictResolutionSettingFromJSONTyped,
    ConflictResolutionSettingToJSON,
    ContentMoveProfileMappings,
    ContentMoveProfileMappingsFromJSON,
    ContentMoveProfileMappingsFromJSONTyped,
    ContentMoveProfileMappingsToJSON,
    DeleteType,
    DeleteTypeFromJSON,
    DeleteTypeFromJSONTyped,
    DeleteTypeToJSON,
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface ContentMoveCommonSetting
 */
export interface ContentMoveCommonSetting {
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveCommonSetting
     */
    isIncludeVersions?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveCommonSetting
     */
    isIncludeWorkflowDefinition?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveCommonSetting
     */
    isDisableInformationRightsManagement?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveCommonSetting
     */
    isPreserveNullColumnValues?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveCommonSetting
     */
    isKeepModifiedByAndModifiedTime?: boolean;
    /**
     * 
     * @type {ContentMoveProfileMappings}
     * @memberof ContentMoveCommonSetting
     */
    profileMappings?: ContentMoveProfileMappings | null;
    /**
     * 
     * @type {BackupEnvironmentSetting}
     * @memberof ContentMoveCommonSetting
     */
    backupSettings?: BackupEnvironmentSetting | null;
    /**
     * 
     * @type {ConflictResolutionSetting}
     * @memberof ContentMoveCommonSetting
     */
    conflictResolutionSettings?: ConflictResolutionSetting | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof ContentMoveCommonSetting
     */
    filterPolicy?: GuidModel | null;
    /**
     * 
     * @type {DeleteType}
     * @memberof ContentMoveCommonSetting
     */
    deleteType?: DeleteType;
    /**
     * 
     * @type {boolean}
     * @memberof ContentMoveCommonSetting
     */
    isDeleteCheckedFiles?: boolean;
}

export function ContentMoveCommonSettingFromJSON(json: any): ContentMoveCommonSetting {
    return ContentMoveCommonSettingFromJSONTyped(json, false);
}

export function ContentMoveCommonSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveCommonSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isIncludeVersions': !exists(json, 'isIncludeVersions') ? undefined : json['isIncludeVersions'],
        'isIncludeWorkflowDefinition': !exists(json, 'isIncludeWorkflowDefinition') ? undefined : json['isIncludeWorkflowDefinition'],
        'isDisableInformationRightsManagement': !exists(json, 'isDisableInformationRightsManagement') ? undefined : json['isDisableInformationRightsManagement'],
        'isPreserveNullColumnValues': !exists(json, 'isPreserveNullColumnValues') ? undefined : json['isPreserveNullColumnValues'],
        'isKeepModifiedByAndModifiedTime': !exists(json, 'isKeepModifiedByAndModifiedTime') ? undefined : json['isKeepModifiedByAndModifiedTime'],
        'profileMappings': !exists(json, 'profileMappings') ? undefined : ContentMoveProfileMappingsFromJSON(json['profileMappings']),
        'backupSettings': !exists(json, 'backupSettings') ? undefined : BackupEnvironmentSettingFromJSON(json['backupSettings']),
        'conflictResolutionSettings': !exists(json, 'conflictResolutionSettings') ? undefined : ConflictResolutionSettingFromJSON(json['conflictResolutionSettings']),
        'filterPolicy': !exists(json, 'filterPolicy') ? undefined : GuidModelFromJSON(json['filterPolicy']),
        'deleteType': !exists(json, 'deleteType') ? undefined : DeleteTypeFromJSON(json['deleteType']),
        'isDeleteCheckedFiles': !exists(json, 'isDeleteCheckedFiles') ? undefined : json['isDeleteCheckedFiles'],
    };
}

export function ContentMoveCommonSettingToJSON(value?: ContentMoveCommonSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isIncludeVersions': value.isIncludeVersions,
        'isIncludeWorkflowDefinition': value.isIncludeWorkflowDefinition,
        'isDisableInformationRightsManagement': value.isDisableInformationRightsManagement,
        'isPreserveNullColumnValues': value.isPreserveNullColumnValues,
        'isKeepModifiedByAndModifiedTime': value.isKeepModifiedByAndModifiedTime,
        'profileMappings': ContentMoveProfileMappingsToJSON(value.profileMappings),
        'backupSettings': BackupEnvironmentSettingToJSON(value.backupSettings),
        'conflictResolutionSettings': ConflictResolutionSettingToJSON(value.conflictResolutionSettings),
        'filterPolicy': GuidModelToJSON(value.filterPolicy),
        'deleteType': DeleteTypeToJSON(value.deleteType),
        'isDeleteCheckedFiles': value.isDeleteCheckedFiles,
    };
}


