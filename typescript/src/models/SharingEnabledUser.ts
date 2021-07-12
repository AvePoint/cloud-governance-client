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
 * 
 * @export
 * @interface SharingEnabledUser
 */
export interface SharingEnabledUser {
    /**
     * 
     * @type {boolean}
     * @memberof SharingEnabledUser
     */
    isSharePointGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SharingEnabledUser
     */
    isGuestUser?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof SharingEnabledUser
     */
    isGuestUserExistsInOrganization?: boolean;
    /**
     * Object ID
     * @type {string}
     * @memberof SharingEnabledUser
     */
    id?: string | null;
    /**
     * Login name
     * @type {string}
     * @memberof SharingEnabledUser
     */
    loginName?: string | null;
    /**
     * Whether the user is an external user.
     * @type {ExternalUserType}
     * @memberof SharingEnabledUser
     */
    isExternalUser?: ExternalUserType;
    /**
     * User type in Azure AD
     * @type {string}
     * @memberof SharingEnabledUser
     */
    azureUserType?: string | null;
    /**
     * User display name
     * @type {string}
     * @memberof SharingEnabledUser
     */
    displayName?: string | null;
    /**
     * Whether an object is a domain group.
     * @type {boolean}
     * @memberof SharingEnabledUser
     */
    isGroup?: boolean;
    /**
     * Whether the user is a local system user.
     * @type {boolean}
     * @memberof SharingEnabledUser
     */
    readonly isLocalUser?: boolean;
    /**
     * User e-mail address
     * @type {string}
     * @memberof SharingEnabledUser
     */
    email?: string | null;
    /**
     * User job title
     * @type {string}
     * @memberof SharingEnabledUser
     */
    readonly jobTitle?: string | null;
    /**
     * Physical delivery office name of the user
     * @type {string}
     * @memberof SharingEnabledUser
     */
    readonly physicalDeliveryOfficeName?: string | null;
    /**
     * Whether the user is valid.
     * @type {boolean}
     * @memberof SharingEnabledUser
     */
    readonly isValid?: boolean;
    /**
     * Office 365 tenant ID of the user
     * @type {string}
     * @memberof SharingEnabledUser
     */
    readonly tenantId?: string | null;
    /**
     * User additional data
     * @type {{ [key: string]: any; }}
     * @memberof SharingEnabledUser
     */
    readonly additionalData?: { [key: string]: any; } | null;
    /**
     * ApiUser type
     * @type {ApiUserType}
     * @memberof SharingEnabledUser
     */
    readonly apiUserType?: ApiUserType;
}

export function SharingEnabledUserFromJSON(json: any): SharingEnabledUser {
    return SharingEnabledUserFromJSONTyped(json, false);
}

export function SharingEnabledUserFromJSONTyped(json: any, ignoreDiscriminator: boolean): SharingEnabledUser {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isSharePointGroup': !exists(json, 'isSharePointGroup') ? undefined : json['isSharePointGroup'],
        'isGuestUser': !exists(json, 'isGuestUser') ? undefined : json['isGuestUser'],
        'isGuestUserExistsInOrganization': !exists(json, 'isGuestUserExistsInOrganization') ? undefined : json['isGuestUserExistsInOrganization'],
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

export function SharingEnabledUserToJSON(value?: SharingEnabledUser | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isSharePointGroup': value.isSharePointGroup,
        'isGuestUser': value.isGuestUser,
        'isGuestUserExistsInOrganization': value.isGuestUserExistsInOrganization,
        'id': value.id,
        'loginName': value.loginName,
        'isExternalUser': ExternalUserTypeToJSON(value.isExternalUser),
        'azureUserType': value.azureUserType,
        'displayName': value.displayName,
        'isGroup': value.isGroup,
        'email': value.email,
    };
}


