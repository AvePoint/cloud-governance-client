/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ExternalSharingOptions,
    ExternalSharingOptionsFromJSON,
    ExternalSharingOptionsFromJSONTyped,
    ExternalSharingOptionsToJSON,
    ManagePermissionSPObject,
    ManagePermissionSPObjectFromJSON,
    ManagePermissionSPObjectFromJSONTyped,
    ManagePermissionSPObjectToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
    PermissionLevel,
    PermissionLevelFromJSON,
    PermissionLevelFromJSONTyped,
    PermissionLevelToJSON,
    UserInfo,
    UserInfoFromJSON,
    UserInfoFromJSONTyped,
    UserInfoToJSON,
} from './';

/**
 * 
 * @export
 * @interface ManagePermissionValidateResult
 */
export interface ManagePermissionValidateResult {
    /**
     * 
     * @type {Array<PermissionLevel>}
     * @memberof ManagePermissionValidateResult
     */
    permissionLevels?: Array<PermissionLevel> | null;
    /**
     * 
     * @type {ExternalSharingOptions}
     * @memberof ManagePermissionValidateResult
     */
    externalSharingOptions?: ExternalSharingOptions;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionValidateResult
     */
    enableShareAnonymousLink?: boolean;
    /**
     * 
     * @type {ManagePermissionSPObject}
     * @memberof ManagePermissionValidateResult
     */
    object?: ManagePermissionSPObject | null;
    /**
     * 
     * @type {{ [key: string]: UserInfo; }}
     * @memberof ManagePermissionValidateResult
     */
    userMetadata?: { [key: string]: UserInfo; } | null;
    /**
     * 
     * @type {boolean}
     * @memberof ManagePermissionValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ManagePermissionValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ManagePermissionValidateResult
     */
    messageCode?: MessageCode;
}

export function ManagePermissionValidateResultFromJSON(json: any): ManagePermissionValidateResult {
    return ManagePermissionValidateResultFromJSONTyped(json, false);
}

export function ManagePermissionValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ManagePermissionValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'permissionLevels': !exists(json, 'permissionLevels') ? undefined : (json['permissionLevels'] === null ? null : (json['permissionLevels'] as Array<any>).map(PermissionLevelFromJSON)),
        'externalSharingOptions': !exists(json, 'externalSharingOptions') ? undefined : ExternalSharingOptionsFromJSON(json['externalSharingOptions']),
        'enableShareAnonymousLink': !exists(json, 'enableShareAnonymousLink') ? undefined : json['enableShareAnonymousLink'],
        'object': !exists(json, 'object') ? undefined : ManagePermissionSPObjectFromJSON(json['object']),
        'userMetadata': !exists(json, 'userMetadata') ? undefined : (json['userMetadata'] === null ? null : mapValues(json['userMetadata'], UserInfoFromJSON)),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ManagePermissionValidateResultToJSON(value?: ManagePermissionValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'permissionLevels': value.permissionLevels === undefined ? undefined : (value.permissionLevels === null ? null : (value.permissionLevels as Array<any>).map(PermissionLevelToJSON)),
        'externalSharingOptions': ExternalSharingOptionsToJSON(value.externalSharingOptions),
        'enableShareAnonymousLink': value.enableShareAnonymousLink,
        'object': ManagePermissionSPObjectToJSON(value.object),
        'userMetadata': value.userMetadata === undefined ? undefined : (value.userMetadata === null ? null : mapValues(value.userMetadata, UserInfoToJSON)),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


