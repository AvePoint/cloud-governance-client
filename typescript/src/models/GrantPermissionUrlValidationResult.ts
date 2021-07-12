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
    GrantPermissionGroup,
    GrantPermissionGroupFromJSON,
    GrantPermissionGroupFromJSONTyped,
    GrantPermissionGroupToJSON,
    GrantPermissionSPObject,
    GrantPermissionSPObjectFromJSON,
    GrantPermissionSPObjectFromJSONTyped,
    GrantPermissionSPObjectToJSON,
    IntModel,
    IntModelFromJSON,
    IntModelFromJSONTyped,
    IntModelToJSON,
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
    UserInfo,
    UserInfoFromJSON,
    UserInfoFromJSONTyped,
    UserInfoToJSON,
} from './';

/**
 * 
 * @export
 * @interface GrantPermissionUrlValidationResult
 */
export interface GrantPermissionUrlValidationResult {
    /**
     * 
     * @type {ExternalSharingOptions}
     * @memberof GrantPermissionUrlValidationResult
     */
    externalSharingOptions?: ExternalSharingOptions;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionUrlValidationResult
     */
    enableShareAnnoymousLink?: boolean;
    /**
     * 
     * @type {GrantPermissionSPObject}
     * @memberof GrantPermissionUrlValidationResult
     */
    object?: GrantPermissionSPObject | null;
    /**
     * 
     * @type {Array<IntModel>}
     * @memberof GrantPermissionUrlValidationResult
     */
    spPermissionLevels?: Array<IntModel> | null;
    /**
     * 
     * @type {Array<GrantPermissionGroup>}
     * @memberof GrantPermissionUrlValidationResult
     */
    spGroups?: Array<GrantPermissionGroup> | null;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionUrlValidationResult
     */
    allowBreakPermissionInheritance?: boolean;
    /**
     * 
     * @type {{ [key: string]: UserInfo; }}
     * @memberof GrantPermissionUrlValidationResult
     */
    userMetadata?: { [key: string]: UserInfo; } | null;
    /**
     * 
     * @type {boolean}
     * @memberof GrantPermissionUrlValidationResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof GrantPermissionUrlValidationResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof GrantPermissionUrlValidationResult
     */
    messageCode?: MessageCode;
}

export function GrantPermissionUrlValidationResultFromJSON(json: any): GrantPermissionUrlValidationResult {
    return GrantPermissionUrlValidationResultFromJSONTyped(json, false);
}

export function GrantPermissionUrlValidationResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): GrantPermissionUrlValidationResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'externalSharingOptions': !exists(json, 'externalSharingOptions') ? undefined : ExternalSharingOptionsFromJSON(json['externalSharingOptions']),
        'enableShareAnnoymousLink': !exists(json, 'enableShareAnnoymousLink') ? undefined : json['enableShareAnnoymousLink'],
        'object': !exists(json, 'object') ? undefined : GrantPermissionSPObjectFromJSON(json['object']),
        'spPermissionLevels': !exists(json, 'spPermissionLevels') ? undefined : (json['spPermissionLevels'] === null ? null : (json['spPermissionLevels'] as Array<any>).map(IntModelFromJSON)),
        'spGroups': !exists(json, 'spGroups') ? undefined : (json['spGroups'] === null ? null : (json['spGroups'] as Array<any>).map(GrantPermissionGroupFromJSON)),
        'allowBreakPermissionInheritance': !exists(json, 'allowBreakPermissionInheritance') ? undefined : json['allowBreakPermissionInheritance'],
        'userMetadata': !exists(json, 'userMetadata') ? undefined : (json['userMetadata'] === null ? null : mapValues(json['userMetadata'], UserInfoFromJSON)),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function GrantPermissionUrlValidationResultToJSON(value?: GrantPermissionUrlValidationResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'externalSharingOptions': ExternalSharingOptionsToJSON(value.externalSharingOptions),
        'enableShareAnnoymousLink': value.enableShareAnnoymousLink,
        'object': GrantPermissionSPObjectToJSON(value.object),
        'spPermissionLevels': value.spPermissionLevels === undefined ? undefined : (value.spPermissionLevels === null ? null : (value.spPermissionLevels as Array<any>).map(IntModelToJSON)),
        'spGroups': value.spGroups === undefined ? undefined : (value.spGroups === null ? null : (value.spGroups as Array<any>).map(GrantPermissionGroupToJSON)),
        'allowBreakPermissionInheritance': value.allowBreakPermissionInheritance,
        'userMetadata': value.userMetadata === undefined ? undefined : (value.userMetadata === null ? null : mapValues(value.userMetadata, UserInfoToJSON)),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


