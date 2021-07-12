/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUserType,
    ApiUserTypeFromJSON,
    ApiUserTypeFromJSONTyped,
    ApiUserTypeToJSON,
    ExternalUserType,
    ExternalUserTypeFromJSON,
    ExternalUserTypeFromJSONTyped,
    ExternalUserTypeToJSON,
} from './';

/**
 * Group user model
 * @export
 * @interface GroupUser
 */
export interface GroupUser {
    /**
     * Whether to enforce permissions for the user.
     * @type {boolean}
     * @memberof GroupUser
     */
    isEnforce?: boolean;
    /**
     * Whether to hide the enforced user from the request page.
     * @type {boolean}
     * @memberof GroupUser
     */
    isHide?: boolean;
    /**
     * Object ID
     * @type {string}
     * @memberof GroupUser
     */
    id?: string | null;
    /**
     * Login name
     * @type {string}
     * @memberof GroupUser
     */
    loginName?: string | null;
    /**
     * Whether the user is an external user.
     * @type {ExternalUserType}
     * @memberof GroupUser
     */
    isExternalUser?: ExternalUserType;
    /**
     * User type in Azure AD
     * @type {string}
     * @memberof GroupUser
     */
    azureUserType?: string | null;
    /**
     * User display name
     * @type {string}
     * @memberof GroupUser
     */
    displayName?: string | null;
    /**
     * Whether an object is a domain group.
     * @type {boolean}
     * @memberof GroupUser
     */
    isGroup?: boolean;
    /**
     * Whether the user is a local system user.
     * @type {boolean}
     * @memberof GroupUser
     */
    readonly isLocalUser?: boolean;
    /**
     * User e-mail address
     * @type {string}
     * @memberof GroupUser
     */
    email?: string | null;
    /**
     * User job title
     * @type {string}
     * @memberof GroupUser
     */
    readonly jobTitle?: string | null;
    /**
     * Physical delivery office name of the user
     * @type {string}
     * @memberof GroupUser
     */
    readonly physicalDeliveryOfficeName?: string | null;
    /**
     * Whether the user is valid.
     * @type {boolean}
     * @memberof GroupUser
     */
    readonly isValid?: boolean;
    /**
     * Office 365 tenant ID of the user
     * @type {string}
     * @memberof GroupUser
     */
    readonly tenantId?: string | null;
    /**
     * User additional data
     * @type {{ [key: string]: any; }}
     * @memberof GroupUser
     */
    readonly additionalData?: { [key: string]: any; } | null;
    /**
     * ApiUser type
     * @type {ApiUserType}
     * @memberof GroupUser
     */
    readonly apiUserType?: ApiUserType;
}

export function GroupUserFromJSON(json: any): GroupUser {
    return GroupUserFromJSONTyped(json, false);
}

export function GroupUserFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupUser {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnforce': !exists(json, 'isEnforce') ? undefined : json['isEnforce'],
        'isHide': !exists(json, 'isHide') ? undefined : json['isHide'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'loginName': !exists(json, 'loginName') ? undefined : json['loginName'],
        'isExternalUser': !exists(json, 'isExternalUser') ? undefined : ExternalUserTypeFromJSON(json['isExternalUser']),
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'isGroup': !exists(json, 'isGroup') ? undefined : json['isGroup'],
        'isLocalUser': !exists(json, 'isLocalUser') ? undefined : json['isLocalUser'],
        'email': !exists(json, 'email') ? undefined : json['email'],
        'jobTitle': !exists(json, 'jobTitle') ? undefined : json['jobTitle'],
        'physicalDeliveryOfficeName': !exists(json, 'physicalDeliveryOfficeName') ? undefined : json['physicalDeliveryOfficeName'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'additionalData': !exists(json, 'additionalData') ? undefined : json['additionalData'],
        'apiUserType': !exists(json, 'apiUserType') ? undefined : ApiUserTypeFromJSON(json['apiUserType']),
    };
}

export function GroupUserToJSON(value?: GroupUser | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnforce': value.isEnforce,
        'isHide': value.isHide,
        'id': value.id,
        'loginName': value.loginName,
        'isExternalUser': ExternalUserTypeToJSON(value.isExternalUser),
        'azureUserType': value.azureUserType,
        'displayName': value.displayName,
        'isGroup': value.isGroup,
        'email': value.email,
    };
}


