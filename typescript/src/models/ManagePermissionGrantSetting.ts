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
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManagePermissionGrantSetting
 */
export interface ManagePermissionGrantSetting {
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isEnableGrantPermission?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isGrantTemporaryPermission?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManagePermissionGrantSetting
     */
    grantPermissionAssignBy?: AssignBy;
    /**
     * 
     * @type {number}
     * @memberof ManagePermissionGrantSetting
     */
    temporaryPermissionDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ManagePermissionGrantSetting
     */
    temporaryDurationType?: ApiDurationType;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isMaxTemporaryDurationSetted?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ManagePermissionGrantSetting
     */
    temporaryPermissionMaxDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ManagePermissionGrantSetting
     */
    temporaryPermissionMaxDurationType?: ApiDurationType;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isEnableExpireNotify?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isAllowSelectAdmin?: boolean;
    /**
     * 
     * @type {number}
     * @memberof ManagePermissionGrantSetting
     */
    expireNotifyDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof ManagePermissionGrantSetting
     */
    expireNotifyDurationType?: ApiDurationType;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionGrantSetting
     */
    expireNotifyEmailTemplate?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isEnableWelcomeNotify?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionGrantSetting
     */
    welcomeEmailSubject?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionGrantSetting
     */
    welcomeEmailBody?: string | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof ManagePermissionGrantSetting
     */
    welcomeEmailAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    allowSpecifyTemporayPermissionDuration?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionGrantSetting
     */
    welcomeEmailTemplateId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionGrantSetting
     */
    isWelcomeEmailTemplate?: boolean;
}

export function ManagePermissionGrantSettingFromJSON(json: any): ManagePermissionGrantSetting {
    return ManagePermissionGrantSettingFromJSONTyped(json, false);
}

export function ManagePermissionGrantSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionGrantSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnableGrantPermission': !exists(json, 'isEnableGrantPermission') ? undefined : json['isEnableGrantPermission'],
        'isGrantTemporaryPermission': !exists(json, 'isGrantTemporaryPermission') ? undefined : json['isGrantTemporaryPermission'],
        'grantPermissionAssignBy': !exists(json, 'grantPermissionAssignBy') ? undefined : AssignByFromJSON(json['grantPermissionAssignBy']),
        'temporaryPermissionDuration': !exists(json, 'temporaryPermissionDuration') ? undefined : json['temporaryPermissionDuration'],
        'temporaryDurationType': !exists(json, 'temporaryDurationType') ? undefined : ApiDurationTypeFromJSON(json['temporaryDurationType']),
        'isMaxTemporaryDurationSetted': !exists(json, 'isMaxTemporaryDurationSetted') ? undefined : json['isMaxTemporaryDurationSetted'],
        'temporaryPermissionMaxDuration': !exists(json, 'temporaryPermissionMaxDuration') ? undefined : json['temporaryPermissionMaxDuration'],
        'temporaryPermissionMaxDurationType': !exists(json, 'temporaryPermissionMaxDurationType') ? undefined : ApiDurationTypeFromJSON(json['temporaryPermissionMaxDurationType']),
        'isEnableExpireNotify': !exists(json, 'isEnableExpireNotify') ? undefined : json['isEnableExpireNotify'],
        'isAllowSelectAdmin': !exists(json, 'isAllowSelectAdmin') ? undefined : json['isAllowSelectAdmin'],
        'expireNotifyDuration': !exists(json, 'expireNotifyDuration') ? undefined : json['expireNotifyDuration'],
        'expireNotifyDurationType': !exists(json, 'expireNotifyDurationType') ? undefined : ApiDurationTypeFromJSON(json['expireNotifyDurationType']),
        'expireNotifyEmailTemplate': !exists(json, 'expireNotifyEmailTemplate') ? undefined : json['expireNotifyEmailTemplate'],
        'isEnableWelcomeNotify': !exists(json, 'isEnableWelcomeNotify') ? undefined : json['isEnableWelcomeNotify'],
        'welcomeEmailSubject': !exists(json, 'welcomeEmailSubject') ? undefined : json['welcomeEmailSubject'],
        'welcomeEmailBody': !exists(json, 'welcomeEmailBody') ? undefined : json['welcomeEmailBody'],
        'welcomeEmailAssignBy': !exists(json, 'welcomeEmailAssignBy') ? undefined : AssignByFromJSON(json['welcomeEmailAssignBy']),
        'allowSpecifyTemporayPermissionDuration': !exists(json, 'allowSpecifyTemporayPermissionDuration') ? undefined : json['allowSpecifyTemporayPermissionDuration'],
        'welcomeEmailTemplateId': !exists(json, 'welcomeEmailTemplateId') ? undefined : json['welcomeEmailTemplateId'],
        'isWelcomeEmailTemplate': !exists(json, 'isWelcomeEmailTemplate') ? undefined : json['isWelcomeEmailTemplate'],
    };
}

export function ManagePermissionGrantSettingToJSON(value?: ManagePermissionGrantSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnableGrantPermission': value.isEnableGrantPermission,
        'isGrantTemporaryPermission': value.isGrantTemporaryPermission,
        'grantPermissionAssignBy': AssignByToJSON(value.grantPermissionAssignBy),
        'temporaryPermissionDuration': value.temporaryPermissionDuration,
        'temporaryDurationType': ApiDurationTypeToJSON(value.temporaryDurationType),
        'isMaxTemporaryDurationSetted': value.isMaxTemporaryDurationSetted,
        'temporaryPermissionMaxDuration': value.temporaryPermissionMaxDuration,
        'temporaryPermissionMaxDurationType': ApiDurationTypeToJSON(value.temporaryPermissionMaxDurationType),
        'isEnableExpireNotify': value.isEnableExpireNotify,
        'isAllowSelectAdmin': value.isAllowSelectAdmin,
        'expireNotifyDuration': value.expireNotifyDuration,
        'expireNotifyDurationType': ApiDurationTypeToJSON(value.expireNotifyDurationType),
        'expireNotifyEmailTemplate': value.expireNotifyEmailTemplate,
        'isEnableWelcomeNotify': value.isEnableWelcomeNotify,
        'welcomeEmailSubject': value.welcomeEmailSubject,
        'welcomeEmailBody': value.welcomeEmailBody,
        'welcomeEmailAssignBy': AssignByToJSON(value.welcomeEmailAssignBy),
        'allowSpecifyTemporayPermissionDuration': value.allowSpecifyTemporayPermissionDuration,
        'welcomeEmailTemplateId': value.welcomeEmailTemplateId,
        'isWelcomeEmailTemplate': value.isWelcomeEmailTemplate,
    };
}


