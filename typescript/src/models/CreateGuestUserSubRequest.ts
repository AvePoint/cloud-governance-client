/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiRequestProgressStatus,
    ApiRequestProgressStatusFromJSON,
    ApiRequestProgressStatusFromJSONTyped,
    ApiRequestProgressStatusToJSON,
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    GuestUserPropertyModel,
    GuestUserPropertyModelFromJSON,
    GuestUserPropertyModelFromJSONTyped,
    GuestUserPropertyModelToJSON,
    GuestUserRequestOneTimeRenewalSettingModel,
    GuestUserRequestOneTimeRenewalSettingModelFromJSON,
    GuestUserRequestOneTimeRenewalSettingModelFromJSONTyped,
    GuestUserRequestOneTimeRenewalSettingModelToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateGuestUserSubRequest
 */
export interface CreateGuestUserSubRequest {
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserSubRequest
     */
    readonly id?: string;
    /**
     * 
     * @type {GuestUserPropertyModel}
     * @memberof CreateGuestUserSubRequest
     */
    userProperties?: GuestUserPropertyModel | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserSubRequest
     */
    welcomeEmailMessage?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserSubRequest
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserSubRequest
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGuestUserSubRequest
     */
    inviteGroups?: Array<ApiUser> | null;
    /**
     * 
     * @type {GuestUserRequestOneTimeRenewalSettingModel}
     * @memberof CreateGuestUserSubRequest
     */
    oneTimeSettings?: GuestUserRequestOneTimeRenewalSettingModel | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof CreateGuestUserSubRequest
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * 
     * @type {ApiRequestProgressStatus}
     * @memberof CreateGuestUserSubRequest
     */
    readonly processStatus?: ApiRequestProgressStatus;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof CreateGuestUserSubRequest
     */
    assignTo?: Array<ApiUser> | null;
}

export function CreateGuestUserSubRequestFromJSON(json: any): CreateGuestUserSubRequest {
    return CreateGuestUserSubRequestFromJSONTyped(json, false);
}

export function CreateGuestUserSubRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGuestUserSubRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'userProperties': !exists(json, 'userProperties') ? undefined : GuestUserPropertyModelFromJSON(json['userProperties']),
        'welcomeEmailMessage': !exists(json, 'welcomeEmailMessage') ? undefined : json['welcomeEmailMessage'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'inviteGroups': !exists(json, 'inviteGroups') ? undefined : (json['inviteGroups'] === null ? null : (json['inviteGroups'] as Array<any>).map(ApiUserFromJSON)),
        'oneTimeSettings': !exists(json, 'oneTimeSettings') ? undefined : GuestUserRequestOneTimeRenewalSettingModelFromJSON(json['oneTimeSettings']),
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'processStatus': !exists(json, 'processStatus') ? undefined : ApiRequestProgressStatusFromJSON(json['processStatus']),
        'assignTo': !exists(json, 'assignTo') ? undefined : (json['assignTo'] === null ? null : (json['assignTo'] as Array<any>).map(ApiUserFromJSON)),
    };
}

export function CreateGuestUserSubRequestToJSON(value?: CreateGuestUserSubRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'userProperties': GuestUserPropertyModelToJSON(value.userProperties),
        'welcomeEmailMessage': value.welcomeEmailMessage,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'inviteGroups': value.inviteGroups === undefined ? undefined : (value.inviteGroups === null ? null : (value.inviteGroups as Array<any>).map(ApiUserToJSON)),
        'oneTimeSettings': GuestUserRequestOneTimeRenewalSettingModelToJSON(value.oneTimeSettings),
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
        'assignTo': value.assignTo === undefined ? undefined : (value.assignTo === null ? null : (value.assignTo as Array<any>).map(ApiUserToJSON)),
    };
}


