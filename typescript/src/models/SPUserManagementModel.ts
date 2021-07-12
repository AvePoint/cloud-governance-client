/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ExternalUserType,
    ExternalUserTypeFromJSON,
    ExternalUserTypeFromJSONTyped,
    ExternalUserTypeToJSON,
    ManagePermissionAction,
    ManagePermissionActionFromJSON,
    ManagePermissionActionFromJSONTyped,
    ManagePermissionActionToJSON,
} from './';

/**
 * 
 * @export
 * @interface SPUserManagementModel
 */
export interface SPUserManagementModel {
    /**
     * 
     * @type {string}
     * @memberof SPUserManagementModel
     */
    identityName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof SPUserManagementModel
     */
    displayName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof SPUserManagementModel
     */
    isGroup?: boolean;
    /**
     * 
     * @type {string}
     * @memberof SPUserManagementModel
     */
    azureUserType?: string | null;
    /**
     * 
     * @type {ManagePermissionAction}
     * @memberof SPUserManagementModel
     */
    action?: ManagePermissionAction;
    /**
     * 
     * @type {ExternalUserType}
     * @memberof SPUserManagementModel
     */
    externalUserType?: ExternalUserType;
}

export function SPUserManagementModelFromJSON(json: any): SPUserManagementModel {
    return SPUserManagementModelFromJSONTyped(json, false);
}

export function SPUserManagementModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): SPUserManagementModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'identityName': !exists(json, 'identityName') ? undefined : json['identityName'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'isGroup': !exists(json, 'isGroup') ? undefined : json['isGroup'],
        'azureUserType': !exists(json, 'azureUserType') ? undefined : json['azureUserType'],
        'action': !exists(json, 'action') ? undefined : ManagePermissionActionFromJSON(json['action']),
        'externalUserType': !exists(json, 'externalUserType') ? undefined : ExternalUserTypeFromJSON(json['externalUserType']),
    };
}

export function SPUserManagementModelToJSON(value?: SPUserManagementModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'identityName': value.identityName,
        'displayName': value.displayName,
        'isGroup': value.isGroup,
        'azureUserType': value.azureUserType,
        'action': ManagePermissionActionToJSON(value.action),
        'externalUserType': ExternalUserTypeToJSON(value.externalUserType),
    };
}


