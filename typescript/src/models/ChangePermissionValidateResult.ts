/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    MessageCode,
    MessageCodeFromJSON,
    MessageCodeFromJSONTyped,
    MessageCodeToJSON,
    NodeType,
    NodeTypeFromJSON,
    NodeTypeFromJSONTyped,
    NodeTypeToJSON,
    UserInfo,
    UserInfoFromJSON,
    UserInfoFromJSONTyped,
    UserInfoToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangePermissionValidateResult
 */
export interface ChangePermissionValidateResult {
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    siteId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    webId?: string;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    webServerRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    listTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    objectUrl?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionValidateResult
     */
    isInherit?: boolean;
    /**
     * 
     * @type {NodeType}
     * @memberof ChangePermissionValidateResult
     */
    inheritNodeType?: NodeType;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    topInheritUrl?: string | null;
    /**
     * 
     * @type {NodeType}
     * @memberof ChangePermissionValidateResult
     */
    checkType?: NodeType;
    /**
     * 
     * @type {{ [key: string]: UserInfo; }}
     * @memberof ChangePermissionValidateResult
     */
    userMetadata?: { [key: string]: UserInfo; } | null;
    /**
     * 
     * @type {boolean}
     * @memberof ChangePermissionValidateResult
     */
    isValid?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ChangePermissionValidateResult
     */
    errorMessage?: string | null;
    /**
     * 
     * @type {MessageCode}
     * @memberof ChangePermissionValidateResult
     */
    messageCode?: MessageCode;
}

export function ChangePermissionValidateResultFromJSON(json: any): ChangePermissionValidateResult {
    return ChangePermissionValidateResultFromJSONTyped(json, false);
}

export function ChangePermissionValidateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangePermissionValidateResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'webId': !exists(json, 'webId') ? undefined : json['webId'],
        'webServerRelativeUrl': !exists(json, 'webServerRelativeUrl') ? undefined : json['webServerRelativeUrl'],
        'listTitle': !exists(json, 'listTitle') ? undefined : json['listTitle'],
        'objectUrl': !exists(json, 'objectUrl') ? undefined : json['objectUrl'],
        'isInherit': !exists(json, 'isInherit') ? undefined : json['isInherit'],
        'inheritNodeType': !exists(json, 'inheritNodeType') ? undefined : NodeTypeFromJSON(json['inheritNodeType']),
        'topInheritUrl': !exists(json, 'topInheritUrl') ? undefined : json['topInheritUrl'],
        'checkType': !exists(json, 'checkType') ? undefined : NodeTypeFromJSON(json['checkType']),
        'userMetadata': !exists(json, 'userMetadata') ? undefined : (json['userMetadata'] === null ? null : mapValues(json['userMetadata'], UserInfoFromJSON)),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
        'messageCode': !exists(json, 'messageCode') ? undefined : MessageCodeFromJSON(json['messageCode']),
    };
}

export function ChangePermissionValidateResultToJSON(value?: ChangePermissionValidateResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'siteId': value.siteId,
        'siteUrl': value.siteUrl,
        'webId': value.webId,
        'webServerRelativeUrl': value.webServerRelativeUrl,
        'listTitle': value.listTitle,
        'objectUrl': value.objectUrl,
        'isInherit': value.isInherit,
        'inheritNodeType': NodeTypeToJSON(value.inheritNodeType),
        'topInheritUrl': value.topInheritUrl,
        'checkType': NodeTypeToJSON(value.checkType),
        'userMetadata': value.userMetadata === undefined ? undefined : (value.userMetadata === null ? null : mapValues(value.userMetadata, UserInfoToJSON)),
        'isValid': value.isValid,
        'errorMessage': value.errorMessage,
        'messageCode': MessageCodeToJSON(value.messageCode),
    };
}


