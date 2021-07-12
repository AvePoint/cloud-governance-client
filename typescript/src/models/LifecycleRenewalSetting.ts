/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    HandleOngoingType,
    HandleOngoingTypeFromJSON,
    HandleOngoingTypeFromJSONTyped,
    HandleOngoingTypeToJSON,
    LeaseDateType,
    LeaseDateTypeFromJSON,
    LeaseDateTypeFromJSONTyped,
    LeaseDateTypeToJSON,
    LeaseStartDateType,
    LeaseStartDateTypeFromJSON,
    LeaseStartDateTypeFromJSONTyped,
    LeaseStartDateTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface LifecycleRenewalSetting
 */
export interface LifecycleRenewalSetting {
    /**
     * 
     * @type {LeaseDateType}
     * @memberof LifecycleRenewalSetting
     */
    leaseDateType?: LeaseDateType;
    /**
     * 
     * @type {LeaseStartDateType}
     * @memberof LifecycleRenewalSetting
     */
    startDateType?: LeaseStartDateType;
    /**
     * 
     * @type {Date}
     * @memberof LifecycleRenewalSetting
     */
    specifyStartDate?: Date | null;
    /**
     * 
     * @type {HandleOngoingType}
     * @memberof LifecycleRenewalSetting
     */
    handleOngoingType?: HandleOngoingType;
}

export function LifecycleRenewalSettingFromJSON(json: any): LifecycleRenewalSetting {
    return LifecycleRenewalSettingFromJSONTyped(json, false);
}

export function LifecycleRenewalSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): LifecycleRenewalSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'leaseDateType': !exists(json, 'leaseDateType') ? undefined : LeaseDateTypeFromJSON(json['leaseDateType']),
        'startDateType': !exists(json, 'startDateType') ? undefined : LeaseStartDateTypeFromJSON(json['startDateType']),
        'specifyStartDate': !exists(json, 'specifyStartDate') ? undefined : (json['specifyStartDate'] === null ? null : new Date(json['specifyStartDate'])),
        'handleOngoingType': !exists(json, 'handleOngoingType') ? undefined : HandleOngoingTypeFromJSON(json['handleOngoingType']),
    };
}

export function LifecycleRenewalSettingToJSON(value?: LifecycleRenewalSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'leaseDateType': LeaseDateTypeToJSON(value.leaseDateType),
        'startDateType': LeaseStartDateTypeToJSON(value.startDateType),
        'specifyStartDate': value.specifyStartDate === undefined ? undefined : (value.specifyStartDate === null ? null : value.specifyStartDate.toISOString()),
        'handleOngoingType': HandleOngoingTypeToJSON(value.handleOngoingType),
    };
}


