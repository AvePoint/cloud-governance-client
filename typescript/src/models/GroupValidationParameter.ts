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
 * @interface GroupValidationParameter
 */
export interface GroupValidationParameter {
    /**
     * 
     * @type {string}
     * @memberof GroupValidationParameter
     */
    groupId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof GroupValidationParameter
     */
    isEditTask?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof GroupValidationParameter
     */
    isFromQuestionnaire?: boolean;
}

export function GroupValidationParameterFromJSON(json: any): GroupValidationParameter {
    return GroupValidationParameterFromJSONTyped(json, false);
}

export function GroupValidationParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupValidationParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupId': !exists(json, 'groupId') ? undefined : json['groupId'],
        'isEditTask': !exists(json, 'isEditTask') ? undefined : json['isEditTask'],
        'isFromQuestionnaire': !exists(json, 'isFromQuestionnaire') ? undefined : json['isFromQuestionnaire'],
    };
}

export function GroupValidationParameterToJSON(value?: GroupValidationParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupId': value.groupId,
        'isEditTask': value.isEditTask,
        'isFromQuestionnaire': value.isFromQuestionnaire,
    };
}


