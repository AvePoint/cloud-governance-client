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
 * @interface ChangeGroupSettingValidationParameter
 */
export interface ChangeGroupSettingValidationParameter {
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingValidationParameter
     */
    groupEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeGroupSettingValidationParameter
     */
    groupId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingValidationParameter
     */
    isEditTask?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ChangeGroupSettingValidationParameter
     */
    isFromQuestionnaire?: boolean;
}

export function ChangeGroupSettingValidationParameterFromJSON(json: any): ChangeGroupSettingValidationParameter {
    return ChangeGroupSettingValidationParameterFromJSONTyped(json, false);
}

export function ChangeGroupSettingValidationParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeGroupSettingValidationParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'groupId': !exists(json, 'groupId') ? undefined : json['groupId'],
        'isEditTask': !exists(json, 'isEditTask') ? undefined : json['isEditTask'],
        'isFromQuestionnaire': !exists(json, 'isFromQuestionnaire') ? undefined : json['isFromQuestionnaire'],
    };
}

export function ChangeGroupSettingValidationParameterToJSON(value?: ChangeGroupSettingValidationParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupEmail': value.groupEmail,
        'groupId': value.groupId,
        'isEditTask': value.isEditTask,
        'isFromQuestionnaire': value.isFromQuestionnaire,
    };
}


