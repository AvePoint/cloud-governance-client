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
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    CommonStatus,
    CommonStatusFromJSON,
    CommonStatusFromJSONTyped,
    CommonStatusToJSON,
    CreateGuestUserRequest,
    CreateGuestUserRequestFromJSON,
    CreateGuestUserRequestFromJSONTyped,
    CreateGuestUserRequestToJSON,
    CustomActionSettings,
    CustomActionSettingsFromJSON,
    CustomActionSettingsFromJSONTyped,
    CustomActionSettingsToJSON,
    CustomMetadata,
    CustomMetadataFromJSON,
    CustomMetadataFromJSONTyped,
    CustomMetadataToJSON,
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface CreateGuestUserService
 */
export interface CreateGuestUserService {
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    tenantId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableInviteOwnersGroup?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableInviteContactGroup?: boolean;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    primaryContact?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    primaryContactAssignBy?: AssignBy;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    secondaryContactAssignBy?: AssignBy;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    manager?: ApiUser | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof CreateGuestUserService
     */
    managerAssignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    enableOnTimeRenewal?: boolean;
    /**
     * 
     * @type {number}
     * @memberof CreateGuestUserService
     */
    oneTimeDuration?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof CreateGuestUserService
     */
    oneTimeDurationType?: ApiDurationType;
    /**
     * 
     * @type {CreateGuestUserRequest}
     * @memberof CreateGuestUserService
     */
    requestTemplate?: CreateGuestUserRequest | null;
    /**
     * 
     * @type {Array<CustomMetadata>}
     * @memberof CreateGuestUserService
     */
    metadatas?: Array<CustomMetadata> | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    hideRequestSummary?: boolean;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    description?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof CreateGuestUserService
     */
    type?: ServiceType;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    serviceContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof CreateGuestUserService
     */
    serviceAdminContact?: ApiUser | null;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    approversContainManagerRole?: boolean;
    /**
     * 
     * @type {CommonStatus}
     * @memberof CreateGuestUserService
     */
    status?: CommonStatus;
    /**
     * 
     * @type {boolean}
     * @memberof CreateGuestUserService
     */
    showServiceInCatalog?: boolean;
    /**
     * 
     * @type {CustomActionSettings}
     * @memberof CreateGuestUserService
     */
    customActions?: CustomActionSettings | null;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    approvalProcessId?: string;
    /**
     * 
     * @type {number}
     * @memberof CreateGuestUserService
     */
    languageId?: number;
    /**
     * 
     * @type {string}
     * @memberof CreateGuestUserService
     */
    categoryId?: string | null;
}

export function CreateGuestUserServiceFromJSON(json: any): CreateGuestUserService {
    return CreateGuestUserServiceFromJSONTyped(json, false);
}

export function CreateGuestUserServiceFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateGuestUserService {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'enableInviteOwnersGroup': !exists(json, 'enableInviteOwnersGroup') ? undefined : json['enableInviteOwnersGroup'],
        'enableInviteContactGroup': !exists(json, 'enableInviteContactGroup') ? undefined : json['enableInviteContactGroup'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'primaryContactAssignBy': !exists(json, 'primaryContactAssignBy') ? undefined : AssignByFromJSON(json['primaryContactAssignBy']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'secondaryContactAssignBy': !exists(json, 'secondaryContactAssignBy') ? undefined : AssignByFromJSON(json['secondaryContactAssignBy']),
        'manager': !exists(json, 'manager') ? undefined : ApiUserFromJSON(json['manager']),
        'managerAssignBy': !exists(json, 'managerAssignBy') ? undefined : AssignByFromJSON(json['managerAssignBy']),
        'enableOnTimeRenewal': !exists(json, 'enableOnTimeRenewal') ? undefined : json['enableOnTimeRenewal'],
        'oneTimeDuration': !exists(json, 'oneTimeDuration') ? undefined : json['oneTimeDuration'],
        'oneTimeDurationType': !exists(json, 'oneTimeDurationType') ? undefined : ApiDurationTypeFromJSON(json['oneTimeDurationType']),
        'requestTemplate': !exists(json, 'requestTemplate') ? undefined : CreateGuestUserRequestFromJSON(json['requestTemplate']),
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(CustomMetadataFromJSON)),
        'hideRequestSummary': !exists(json, 'hideRequestSummary') ? undefined : json['hideRequestSummary'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'type': !exists(json, 'type') ? undefined : ServiceTypeFromJSON(json['type']),
        'serviceContact': !exists(json, 'serviceContact') ? undefined : ApiUserFromJSON(json['serviceContact']),
        'serviceAdminContact': !exists(json, 'serviceAdminContact') ? undefined : ApiUserFromJSON(json['serviceAdminContact']),
        'approversContainManagerRole': !exists(json, 'approversContainManagerRole') ? undefined : json['approversContainManagerRole'],
        'status': !exists(json, 'status') ? undefined : CommonStatusFromJSON(json['status']),
        'showServiceInCatalog': !exists(json, 'showServiceInCatalog') ? undefined : json['showServiceInCatalog'],
        'customActions': !exists(json, 'customActions') ? undefined : CustomActionSettingsFromJSON(json['customActions']),
        'approvalProcessId': !exists(json, 'approvalProcessId') ? undefined : json['approvalProcessId'],
        'languageId': !exists(json, 'languageId') ? undefined : json['languageId'],
        'categoryId': !exists(json, 'categoryId') ? undefined : json['categoryId'],
    };
}

export function CreateGuestUserServiceToJSON(value?: CreateGuestUserService | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'tenantId': value.tenantId,
        'enableInviteOwnersGroup': value.enableInviteOwnersGroup,
        'enableInviteContactGroup': value.enableInviteContactGroup,
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'primaryContactAssignBy': AssignByToJSON(value.primaryContactAssignBy),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'secondaryContactAssignBy': AssignByToJSON(value.secondaryContactAssignBy),
        'manager': ApiUserToJSON(value.manager),
        'managerAssignBy': AssignByToJSON(value.managerAssignBy),
        'enableOnTimeRenewal': value.enableOnTimeRenewal,
        'oneTimeDuration': value.oneTimeDuration,
        'oneTimeDurationType': ApiDurationTypeToJSON(value.oneTimeDurationType),
        'requestTemplate': CreateGuestUserRequestToJSON(value.requestTemplate),
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(CustomMetadataToJSON)),
        'hideRequestSummary': value.hideRequestSummary,
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'type': ServiceTypeToJSON(value.type),
        'serviceContact': ApiUserToJSON(value.serviceContact),
        'serviceAdminContact': ApiUserToJSON(value.serviceAdminContact),
        'approversContainManagerRole': value.approversContainManagerRole,
        'status': CommonStatusToJSON(value.status),
        'showServiceInCatalog': value.showServiceInCatalog,
        'customActions': CustomActionSettingsToJSON(value.customActions),
        'approvalProcessId': value.approvalProcessId,
        'languageId': value.languageId,
        'categoryId': value.categoryId,
    };
}


