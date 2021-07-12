/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiDurationType,
    ApiDurationTypeFromJSON,
    ApiDurationTypeFromJSONTyped,
    ApiDurationTypeToJSON,
    ExtendType,
    ExtendTypeFromJSON,
    ExtendTypeFromJSONTyped,
    ExtendTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ExtendGroupResult
 */
export interface ExtendGroupResult {
    /**
     * 
     * @type {ExtendType}
     * @memberof ExtendGroupResult
     */
    extendType?: ExtendType;
    /**
     * 
     * @type {number}
     * @memberof ExtendGroupResult
     */
    duration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ExtendGroupResult
     */
    durationType?: ApiDurationType;
}

export function ExtendGroupResultFromJSON(json: any): ExtendGroupResult {
    return ExtendGroupResultFromJSONTyped(json, false);
}

export function ExtendGroupResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExtendGroupResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'extendType': !exists(json, 'extendType') ? undefined : ExtendTypeFromJSON(json['extendType']),
        'duration': !exists(json, 'duration') ? undefined : json['duration'],
        'durationType': !exists(json, 'durationType') ? undefined : ApiDurationTypeFromJSON(json['durationType']),
    };
}

export function ExtendGroupResultToJSON(value?: ExtendGroupResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'extendType': ExtendTypeToJSON(value.extendType),
        'duration': value.duration,
        'durationType': ApiDurationTypeToJSON(value.durationType),
    };
}


