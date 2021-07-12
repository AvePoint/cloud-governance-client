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
 * ApiUser model
 * @export
 * @interface ApiUser
 */
export interface ApiUser {
    /**
     * Object ID
     * @type {string}
     * @memberof ApiUser
     */
    id?: string | null;
    /**
     * Login name
     * @type {string}
     * @memberof ApiUser
     */
    loginName?: string | null;
    /**
     * Whether the user is an external user.
     * @type {ExternalUserType}
     * @memberof ApiUser
     */
    isExternalUser?: ExternalUserType;
    /**
     * User type in Azure AD
     * @type {string}
     * @memberof ApiUser
     */
    azureUserType?: string | null;
    /**
     * User display name
     * @type {string}
     * @memberof ApiUser
     */
    displayName?: string | null;
    /**
     * Whether an object is a domain group.
     * @type {boolean}
     * @memberof ApiUser
     */
    isGroup?: boolean;
    /**
     * Whether the user is a local system user.
     * @type {boolean}
     * @memberof ApiUser
     */
    readonly isLocalUser?: boolean;
    /**
     * User e-mail address
     * @type {string}
     * @memberof ApiUser
     */
    email?: string | null;
    /**
     * User job title
     * @type {string}
     * @memberof ApiUser
     */
    readonly jobTitle?: string | null;
    /**
     * Physical delivery office name of the user
     * @type {string}
     * @memberof ApiUser
     */
    readonly physicalDeliveryOfficeName?: string | null;
    /**
     * Whether the user is valid.
     * @type {boolean}
     * @memberof ApiUser
     */
    readonly isValid?: boolean;
    /**
     * Office 365 tenant ID of the user
     * @type {string}
     * @memberof ApiUser
     */
    readonly tenantId?: string | null;
    /**
     * User additional data
     * @type {{ [key: string]: any; }}
     * @memberof ApiUser
     */
    readonly additionalData?: { [key: string]: any; } | null;
    /**
     * ApiUser type
     * @type {ApiUserType}
     * @memberof ApiUser
     */
    readonly apiUserType?: ApiUserType;
}

export function ApiUserFromJSON(json: any): ApiUser {
    return ApiUserFromJSONTyped(json, false);
}

export function ApiUserFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiUser {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
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

export function ApiUserToJSON(value?: ApiUser | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'loginName': value.loginName,
        'isExternalUser': ExternalUserTypeToJSON(value.isExternalUser),
        'azureUserType': value.azureUserType,
        'displayName': value.displayName,
        'isGroup': value.isGroup,
        'email': value.email,
    };
}


