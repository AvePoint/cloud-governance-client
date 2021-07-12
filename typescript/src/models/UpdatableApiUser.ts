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
    UserSource,
    UserSourceFromJSON,
    UserSourceFromJSONTyped,
    UserSourceToJSON,
} from './';

/**
 * 
 * @export
 * @interface UpdatableApiUser
 */
export interface UpdatableApiUser {
    /**
     * 
     * @type {string}
     * @memberof UpdatableApiUser
     */
    email?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdatableApiUser
     */
    jobTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdatableApiUser
     */
    tenantId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdatableApiUser
     */
    peopleFilterProfileId?: string | null;
    /**
     * 
     * @type {ApiUserType}
     * @memberof UpdatableApiUser
     */
    apiUserType?: ApiUserType;
    /**
     * 
     * @type {UserSource}
     * @memberof UpdatableApiUser
     */
    userSource?: UserSource;
    /**
     * Object ID
     * @type {string}
     * @memberof UpdatableApiUser
     */
    id?: string | null;
    /**
     * Login name
     * @type {string}
     * @memberof UpdatableApiUser
     */
    loginName?: string | null;
    /**
     * Whether the user is an external user.
     * @type {ExternalUserType}
     * @memberof UpdatableApiUser
     */
    isExternalUser?: ExternalUserType;
    /**
     * User type in Azure AD
     * @type {string}
     * @memberof UpdatableApiUser
     */
    azureUserType?: string | null;
    /**
     * User display name
     * @type {string}
     * @memberof UpdatableApiUser
     */
    displayName?: string | null;
    /**
     * Whether an object is a domain group.
     * @type {boolean}
     * @memberof UpdatableApiUser
     */
    isGroup?: boolean;
    /**
     * Whether the user is a local system user.
     * @type {boolean}
     * @memberof UpdatableApiUser
     */
    readonly isLocalUser?: boolean;
    /**
     * Physical delivery office name of the user
     * @type {string}
     * @memberof UpdatableApiUser
     */
    readonly physicalDeliveryOfficeName?: string | null;
    /**
     * Whether the user is valid.
     * @type {boolean}
     * @memberof UpdatableApiUser
     */
    readonly isValid?: boolean;
    /**
     * User additional data
     * @type {{ [key: string]: any; }}
     * @memberof UpdatableApiUser
     */
    readonly additionalData?: { [key: string]: any; } | null;
}

export function UpdatableApiUserFromJSON(json: any): UpdatableApiUser {
    return UpdatableApiUserFromJSONTyped(json, false);
}

export function UpdatableApiUserFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdatableApiUser {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'email': !exists(json, 'email') ? undefined : json['email'],
        'jobTitle': !exists(json, 'jobTitle') ? undefined : json['jobTitle'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'peopleFilterProfileId': !exists(json, 'peopleFilterProfileId') ? undefined : json['peopleFilterProfileId'],
        'apiUserType': !exists(json, 'apiUserType') ? undefined : ApiUserTypeFromJSON(json['apiUserType']),
        'userSource': !exists(json, 'userSource') ? undefined : UserSourceFromJSON(json['userSource']),
        'id': !exists(json, 'id') ? undefined : json['id'],
        'loginName': !exists(json, 'loginName') ? undefined : json['loginName'],
        'isExternalUser': !exists(json, 'isExternalUser') ? undefined : ExternalUserTypeFromJSON(json['isExternalUser']),
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'isGroup': !exists(json, 'isGroup') ? undefined : json['isGroup'],
        'isLocalUser': !exists(json, 'isLocalUser') ? undefined : json['isLocalUser'],
        'physicalDeliveryOfficeName': !exists(json, 'physicalDeliveryOfficeName') ? undefined : json['physicalDeliveryOfficeName'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'additionalData': !exists(json, 'additionalData') ? undefined : json['additionalData'],
    };
}

export function UpdatableApiUserToJSON(value?: UpdatableApiUser | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'email': value.email,
        'jobTitle': value.jobTitle,
        'tenantId': value.tenantId,
        'peopleFilterProfileId': value.peopleFilterProfileId,
        'apiUserType': ApiUserTypeToJSON(value.apiUserType),
        'userSource': UserSourceToJSON(value.userSource),
        'id': value.id,
        'loginName': value.loginName,
        'isExternalUser': ExternalUserTypeToJSON(value.isExternalUser),
        'azureUserType': value.azureUserType,
        'displayName': value.displayName,
        'isGroup': value.isGroup,
    };
}


