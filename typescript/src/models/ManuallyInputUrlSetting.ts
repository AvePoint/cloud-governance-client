/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    TextValidationRuleRef,
    TextValidationRuleRefFromJSON,
    TextValidationRuleRefFromJSONTyped,
    TextValidationRuleRefToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManuallyInputUrlSetting
 */
export interface ManuallyInputUrlSetting {
    /**
     * 
     * @type {boolean}
     * @memberof ManuallyInputUrlSetting
     */
    enableConstructUrl?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManuallyInputUrlSetting
     */
    enableUrlValidation?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManuallyInputUrlSetting
     */
    constructUrlAssignBy?: AssignBy;
    /**
     * 
     * @type {TextValidationRuleRef}
     * @memberof ManuallyInputUrlSetting
     */
    validationRule?: TextValidationRuleRef | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof ManuallyInputUrlSetting
     */
    rules?: Array<string> | null;
    /**
     * 
     * @type {string}
     * @memberof ManuallyInputUrlSetting
     */
    suffix?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManuallyInputUrlSetting
     */
    connection?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManuallyInputUrlSetting
     */
    contructUrlAssignBy?: AssignBy;
}

export function ManuallyInputUrlSettingFromJSON(json: any): ManuallyInputUrlSetting {
    return ManuallyInputUrlSettingFromJSONTyped(json, false);
}

export function ManuallyInputUrlSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManuallyInputUrlSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableConstructUrl': !exists(json, 'enableConstructUrl') ? undefined : json['enableConstructUrl'],
        'enableUrlValidation': !exists(json, 'enableUrlValidation') ? undefined : json['enableUrlValidation'],
        'constructUrlAssignBy': !exists(json, 'constructUrlAssignBy') ? undefined : AssignByFromJSON(json['constructUrlAssignBy']),
        'validationRule': !exists(json, 'validationRule') ? undefined : TextValidationRuleRefFromJSON(json['validationRule']),
        'rules': !exists(json, 'rules') ? undefined : json['rules'],
        'suffix': !exists(json, 'suffix') ? undefined : json['suffix'],
        'connection': !exists(json, 'connection') ? undefined : json['connection'],
        'contructUrlAssignBy': !exists(json, 'contructUrlAssignBy') ? undefined : AssignByFromJSON(json['contructUrlAssignBy']),
    };
}

export function ManuallyInputUrlSettingToJSON(value?: ManuallyInputUrlSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableConstructUrl': value.enableConstructUrl,
        'enableUrlValidation': value.enableUrlValidation,
        'constructUrlAssignBy': AssignByToJSON(value.constructUrlAssignBy),
        'validationRule': TextValidationRuleRefToJSON(value.validationRule),
        'rules': value.rules,
        'suffix': value.suffix,
        'connection': value.connection,
        'contructUrlAssignBy': AssignByToJSON(value.contructUrlAssignBy),
    };
}


