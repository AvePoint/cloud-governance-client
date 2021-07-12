/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceGroupWithPermissions,
    ServiceGroupWithPermissionsFromJSON,
    ServiceGroupWithPermissionsFromJSONTyped,
    ServiceGroupWithPermissionsToJSON,
    ServiceUserWithPermissions,
    ServiceUserWithPermissionsFromJSON,
    ServiceUserWithPermissionsFromJSONTyped,
    ServiceUserWithPermissionsToJSON,
} from './';

/**
 * 
 * @export
 * @interface TemplateWithPermissions
 */
export interface TemplateWithPermissions {
    /**
     * 
     * @type {string}
     * @memberof TemplateWithPermissions
     */
    templateId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof TemplateWithPermissions
     */
    isUseCommon?: boolean;
    /**
     * 
     * @type {Array<ServiceUserWithPermissions>}
     * @memberof TemplateWithPermissions
     */
    userPermissions?: Array<ServiceUserWithPermissions> | null;
    /**
     * 
     * @type {Array<ServiceGroupWithPermissions>}
     * @memberof TemplateWithPermissions
     */
    groupPermissions?: Array<ServiceGroupWithPermissions> | null;
}

export function TemplateWithPermissionsFromJSON(json: any): TemplateWithPermissions {
    return TemplateWithPermissionsFromJSONTyped(json, false);
}

export function TemplateWithPermissionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): TemplateWithPermissions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'templateId': !exists(json, 'templateId') ? undefined : json['templateId'],
        'isUseCommon': !exists(json, 'isUseCommon') ? undefined : json['isUseCommon'],
        'userPermissions': !exists(json, 'userPermissions') ? undefined : (json['userPermissions'] === null ? null : (json['userPermissions'] as Array<any>).map(ServiceUserWithPermissionsFromJSON)),
        'groupPermissions': !exists(json, 'groupPermissions') ? undefined : (json['groupPermissions'] === null ? null : (json['groupPermissions'] as Array<any>).map(ServiceGroupWithPermissionsFromJSON)),
    };
}

export function TemplateWithPermissionsToJSON(value?: TemplateWithPermissions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'templateId': value.templateId,
        'isUseCommon': value.isUseCommon,
        'userPermissions': value.userPermissions === undefined ? undefined : (value.userPermissions === null ? null : (value.userPermissions as Array<any>).map(ServiceUserWithPermissionsToJSON)),
        'groupPermissions': value.groupPermissions === undefined ? undefined : (value.groupPermissions === null ? null : (value.groupPermissions as Array<any>).map(ServiceGroupWithPermissionsToJSON)),
    };
}


