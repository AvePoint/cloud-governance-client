/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ConflictSolutionType,
    ConflictSolutionTypeFromJSON,
    ConflictSolutionTypeFromJSONTyped,
    ConflictSolutionTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ConflictResolutionSetting
 */
export interface ConflictResolutionSetting {
    /**
     * 
     * @type {ConflictSolutionType}
     * @memberof ConflictResolutionSetting
     */
    containerConflictSolution?: ConflictSolutionType;
    /**
     * 
     * @type {boolean}
     * @memberof ConflictResolutionSetting
     */
    isCheckLowerObject?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ConflictResolutionSetting
     */
    isEnableContentConflictResolution?: boolean;
    /**
     * 
     * @type {ConflictSolutionType}
     * @memberof ConflictResolutionSetting
     */
    contentConflictSolution?: ConflictSolutionType;
    /**
     * 
     * @type {ConflictSolutionType}
     * @memberof ConflictResolutionSetting
     */
    appConflictSolution?: ConflictSolutionType;
}

export function ConflictResolutionSettingFromJSON(json: any): ConflictResolutionSetting {
    return ConflictResolutionSettingFromJSONTyped(json, false);
}

export function ConflictResolutionSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ConflictResolutionSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'containerConflictSolution': !exists(json, 'containerConflictSolution') ? undefined : ConflictSolutionTypeFromJSON(json['containerConflictSolution']),
        'isCheckLowerObject': !exists(json, 'isCheckLowerObject') ? undefined : json['isCheckLowerObject'],
        'isEnableContentConflictResolution': !exists(json, 'isEnableContentConflictResolution') ? undefined : json['isEnableContentConflictResolution'],
        'contentConflictSolution': !exists(json, 'contentConflictSolution') ? undefined : ConflictSolutionTypeFromJSON(json['contentConflictSolution']),
        'appConflictSolution': !exists(json, 'appConflictSolution') ? undefined : ConflictSolutionTypeFromJSON(json['appConflictSolution']),
    };
}

export function ConflictResolutionSettingToJSON(value?: ConflictResolutionSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'containerConflictSolution': ConflictSolutionTypeToJSON(value.containerConflictSolution),
        'isCheckLowerObject': value.isCheckLowerObject,
        'isEnableContentConflictResolution': value.isEnableContentConflictResolution,
        'contentConflictSolution': ConflictSolutionTypeToJSON(value.contentConflictSolution),
        'appConflictSolution': ConflictSolutionTypeToJSON(value.appConflictSolution),
    };
}


