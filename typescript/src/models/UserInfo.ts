/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AuthenticationType,
    AuthenticationTypeFromJSON,
    AuthenticationTypeFromJSONTyped,
    AuthenticationTypeToJSON,
    ExternalUserType,
    ExternalUserTypeFromJSON,
    ExternalUserTypeFromJSONTyped,
    ExternalUserTypeToJSON,
    InviteType,
    InviteTypeFromJSON,
    InviteTypeFromJSONTyped,
    InviteTypeToJSON,
    PrincipalType,
    PrincipalTypeFromJSON,
    PrincipalTypeFromJSONTyped,
    PrincipalTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface UserInfo
 */
export interface UserInfo {
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    identityName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    userDisplayName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    domainGroup?: boolean;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    department?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    mobilePhone?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    manager?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    permission?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    isDeleted?: boolean;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    securityToken?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UserInfo
     */
    userType?: number;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    azureUserType?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    legalPerson?: boolean;
    /**
     * 
     * @type {AuthenticationType}
     * @memberof UserInfo
     */
    authenticationType?: AuthenticationType;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    adminCenterUrl?: string | null;
    /**
     * 
     * @type {InviteType}
     * @memberof UserInfo
     */
    inviteType?: InviteType;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    type?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    isRegisteredAosGroup?: boolean;
    /**
     * 
     * @type {ExternalUserType}
     * @memberof UserInfo
     */
    isExternalUser?: ExternalUserType;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    isAPIExceptional?: boolean;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    tenantId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    objectId?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UserInfo
     */
    version?: number;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    jobTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    usageLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    physicalDeliveryOfficeName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    isOtherTenantUser?: boolean;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    networkId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    isValidateByProfile?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof UserInfo
     */
    proxyAddresses?: Array<string> | null;
    /**
     * 
     * @type {PrincipalType}
     * @memberof UserInfo
     */
    principalType?: PrincipalType;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    inviter?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UserInfo
     */
    id?: number;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    displayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UserInfo
     */
    email?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    isValid?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof UserInfo
     */
    existInAOS?: boolean;
}

export function UserInfoFromJSON(json: any): UserInfo {
    return UserInfoFromJSONTyped(json, false);
}

export function UserInfoFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserInfo {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'identityName': !exists(json, 'identityName') ? undefined : json['identityName'],
        'userDisplayName': !exists(json, 'userDisplayName') ? undefined : json['userDisplayName'],
        'domainGroup': !exists(json, 'domainGroup') ? undefined : json['domainGroup'],
        'department': !exists(json, 'department') ? undefined : json['department'],
        'mobilePhone': !exists(json, 'mobilePhone') ? undefined : json['mobilePhone'],
        'manager': !exists(json, 'manager') ? undefined : json['manager'],
        'permission': !exists(json, 'permission') ? undefined : json['permission'],
        'isDeleted': !exists(json, 'isDeleted') ? undefined : json['isDeleted'],
        'securityToken': !exists(json, 'securityToken') ? undefined : json['securityToken'],
        'userType': !exists(json, 'userType') ? undefined : json['userType'],
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
        'legalPerson': !exists(json, 'legalPerson') ? undefined : json['legalPerson'],
        'authenticationType': !exists(json, 'authenticationType') ? undefined : AuthenticationTypeFromJSON(json['authenticationType']),
        'adminCenterUrl': !exists(json, 'adminCenterUrl') ? undefined : json['adminCenterUrl'],
        'inviteType': !exists(json, 'inviteType') ? undefined : InviteTypeFromJSON(json['inviteType']),
        'type': !exists(json, 'type') ? undefined : json['type'],
        'isRegisteredAosGroup': !exists(json, 'isRegisteredAosGroup') ? undefined : json['isRegisteredAosGroup'],
        'isExternalUser': !exists(json, 'isExternalUser') ? undefined : ExternalUserTypeFromJSON(json['isExternalUser']),
        'isAPIExceptional': !exists(json, 'isAPIExceptional') ? undefined : json['isAPIExceptional'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'version': !exists(json, 'version') ? undefined : json['version'],
        'jobTitle': !exists(json, 'jobTitle') ? undefined : json['jobTitle'],
        'usageLocation': !exists(json, 'usageLocation') ? undefined : json['usageLocation'],
        'physicalDeliveryOfficeName': !exists(json, 'physicalDeliveryOfficeName') ? undefined : json['physicalDeliveryOfficeName'],
        'isOtherTenantUser': !exists(json, 'isOtherTenantUser') ? undefined : json['isOtherTenantUser'],
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'isValidateByProfile': !exists(json, 'isValidateByProfile') ? undefined : json['isValidateByProfile'],
        'proxyAddresses': !exists(json, 'proxyAddresses') ? undefined : json['proxyAddresses'],
        'principalType': !exists(json, 'principalType') ? undefined : PrincipalTypeFromJSON(json['principalType']),
        'inviter': !exists(json, 'inviter') ? undefined : json['inviter'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'email': !exists(json, 'email') ? undefined : json['email'],
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
        'existInAOS': !exists(json, 'existInAOS') ? undefined : json['existInAOS'],
    };
}

export function UserInfoToJSON(value?: UserInfo | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'identityName': value.identityName,
        'userDisplayName': value.userDisplayName,
        'domainGroup': value.domainGroup,
        'department': value.department,
        'mobilePhone': value.mobilePhone,
        'manager': value.manager,
        'permission': value.permission,
        'isDeleted': value.isDeleted,
        'securityToken': value.securityToken,
        'userType': value.userType,
        'azureUserType': value.azureUserType,
        'legalPerson': value.legalPerson,
        'authenticationType': AuthenticationTypeToJSON(value.authenticationType),
        'adminCenterUrl': value.adminCenterUrl,
        'inviteType': InviteTypeToJSON(value.inviteType),
        'type': value.type,
        'isRegisteredAosGroup': value.isRegisteredAosGroup,
        'isExternalUser': ExternalUserTypeToJSON(value.isExternalUser),
        'isAPIExceptional': value.isAPIExceptional,
        'tenantId': value.tenantId,
        'objectId': value.objectId,
        'version': value.version,
        'jobTitle': value.jobTitle,
        'usageLocation': value.usageLocation,
        'physicalDeliveryOfficeName': value.physicalDeliveryOfficeName,
        'isOtherTenantUser': value.isOtherTenantUser,
        'networkId': value.networkId,
        'isValidateByProfile': value.isValidateByProfile,
        'proxyAddresses': value.proxyAddresses,
        'principalType': PrincipalTypeToJSON(value.principalType),
        'inviter': value.inviter,
        'id': value.id,
        'displayName': value.displayName,
        'title': value.title,
        'email': value.email,
        'isValid': value.isValid,
        'existInAOS': value.existInAOS,
    };
}


