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
 * @interface ChangePolicyActionSetting
 */
export interface ChangePolicyActionSetting {
    /**
     * 
     * @type {number}
     * @memberof ChangePolicyActionSetting
     */
    startDateType?: number;
    /**
     * 
     * @type {number}
     * @memberof ChangePolicyActionSetting
     */
    specifyDateTicks?: number;
    /**
     * 
     * @type {number}
     * @memberof ChangePolicyActionSetting
     */
    changePolicyConfig?: number;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePolicyActionSetting
     */
    isAllowAutoCancel?: boolean;
}

export function ChangePolicyActionSettingFromJSON(json: any): ChangePolicyActionSetting {
    return ChangePolicyActionSettingFromJSONTyped(json, false);
}

export function ChangePolicyActionSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangePolicyActionSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'startDateType': !exists(json, 'startDateType') ? undefined : json['startDateType'],
        'specifyDateTicks': !exists(json, 'specifyDateTicks') ? undefined : json['specifyDateTicks'],
        'changePolicyConfig': !exists(json, 'changePolicyConfig') ? undefined : json['changePolicyConfig'],
        'isAllowAutoCancel': !exists(json, 'isAllowAutoCancel') ? undefined : json['isAllowAutoCancel'],
    };
}

export function ChangePolicyActionSettingToJSON(value?: ChangePolicyActionSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'startDateType': value.startDateType,
        'specifyDateTicks': value.specifyDateTicks,
        'changePolicyConfig': value.changePolicyConfig,
        'isAllowAutoCancel': value.isAllowAutoCancel,
    };
}


