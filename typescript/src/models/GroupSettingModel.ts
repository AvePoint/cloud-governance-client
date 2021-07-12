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
 * @interface GroupSettingModel
 */
export interface GroupSettingModel {
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    groupName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    groupDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    groupEmailAddress?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    owners?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    members?: string | null;
    /**
     * 
     * @type {number}
     * @memberof GroupSettingModel
     */
    groupDuration?: number;
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    emailSubject?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GroupSettingModel
     */
    emailBody?: string | null;
}

export function GroupSettingModelFromJSON(json: any): GroupSettingModel {
    return GroupSettingModelFromJSONTyped(json, false);
}

export function GroupSettingModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupSettingModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupName': !exists(json, 'groupName') ? undefined : json['groupName'],
        'groupDescription': !exists(json, 'groupDescription') ? undefined : json['groupDescription'],
        'groupEmailAddress': !exists(json, 'groupEmailAddress') ? undefined : json['groupEmailAddress'],
        'owners': !exists(json, 'owners') ? undefined : json['owners'],
        'members': !exists(json, 'members') ? undefined : json['members'],
        'groupDuration': !exists(json, 'groupDuration') ? undefined : json['groupDuration'],
        'emailSubject': !exists(json, 'emailSubject') ? undefined : json['emailSubject'],
        'emailBody': !exists(json, 'emailBody') ? undefined : json['emailBody'],
    };
}

export function GroupSettingModelToJSON(value?: GroupSettingModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupName': value.groupName,
        'groupDescription': value.groupDescription,
        'groupEmailAddress': value.groupEmailAddress,
        'owners': value.owners,
        'members': value.members,
        'groupDuration': value.groupDuration,
        'emailSubject': value.emailSubject,
        'emailBody': value.emailBody,
    };
}


