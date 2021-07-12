/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface ApiTaskDynamicProperties
 */
export interface ApiTaskDynamicProperties {
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    none?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    primaryContact?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    secondaryContact?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    siteId?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    siteUrl?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    groupName?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    expirationDate?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    groupOwners?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    autoTaskActionHistories?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    inactivityThresholdDate?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    groupEmail?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    groupId?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    policyName?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    primaryAdministrator?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    siteTemplate?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    siteTitle?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    siteDescription?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    requester?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    isTeam?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    isYammer?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    groupOwnersStr?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    tenantId?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    approver?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    approvalHistory?: any | null;
    /**
     * 
     * @type {any}
     * @memberof ApiTaskDynamicProperties
     */
    currentTaskAction?: any | null;
}

export function ApiTaskDynamicPropertiesFromJSON(json: any): ApiTaskDynamicProperties {
    return ApiTaskDynamicPropertiesFromJSONTyped(json, false);
}

export function ApiTaskDynamicPropertiesFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiTaskDynamicProperties {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'none': !exists(json, 'None') ? undefined : json['None'],
        'primaryContact': !exists(json, 'PrimaryContact') ? undefined : json['PrimaryContact'],
        'secondaryContact': !exists(json, 'SecondaryContact') ? undefined : json['SecondaryContact'],
        'siteId': !exists(json, 'SiteId') ? undefined : json['SiteId'],
        'siteUrl': !exists(json, 'SiteUrl') ? undefined : json['SiteUrl'],
        'groupName': !exists(json, 'GroupName') ? undefined : json['GroupName'],
        'expirationDate': !exists(json, 'ExpirationDate') ? undefined : json['ExpirationDate'],
        'groupOwners': !exists(json, 'GroupOwners') ? undefined : json['GroupOwners'],
        'autoTaskActionHistories': !exists(json, 'AutoTaskActionHistories') ? undefined : json['AutoTaskActionHistories'],
        'inactivityThresholdDate': !exists(json, 'InactivityThresholdDate') ? undefined : json['InactivityThresholdDate'],
        'groupEmail': !exists(json, 'GroupEmail') ? undefined : json['GroupEmail'],
        'groupId': !exists(json, 'GroupId') ? undefined : json['GroupId'],
        'policyName': !exists(json, 'PolicyName') ? undefined : json['PolicyName'],
        'primaryAdministrator': !exists(json, 'PrimaryAdministrator') ? undefined : json['PrimaryAdministrator'],
        'siteTemplate': !exists(json, 'SiteTemplate') ? undefined : json['SiteTemplate'],
        'siteTitle': !exists(json, 'SiteTitle') ? undefined : json['SiteTitle'],
        'siteDescription': !exists(json, 'SiteDescription') ? undefined : json['SiteDescription'],
        'requester': !exists(json, 'Requester') ? undefined : json['Requester'],
        'isTeam': !exists(json, 'IsTeam') ? undefined : json['IsTeam'],
        'isYammer': !exists(json, 'IsYammer') ? undefined : json['IsYammer'],
        'groupOwnersStr': !exists(json, 'GroupOwnersStr') ? undefined : json['GroupOwnersStr'],
        'tenantId': !exists(json, 'TenantId') ? undefined : json['TenantId'],
        'approver': !exists(json, 'Approver') ? undefined : json['Approver'],
        'approvalHistory': !exists(json, 'ApprovalHistory') ? undefined : json['ApprovalHistory'],
        'currentTaskAction': !exists(json, 'CurrentTaskAction') ? undefined : json['CurrentTaskAction'],
    };
}

export function ApiTaskDynamicPropertiesToJSON(value?: ApiTaskDynamicProperties | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'None': value.none,
        'PrimaryContact': value.primaryContact,
        'SecondaryContact': value.secondaryContact,
        'SiteId': value.siteId,
        'SiteUrl': value.siteUrl,
        'GroupName': value.groupName,
        'ExpirationDate': value.expirationDate,
        'GroupOwners': value.groupOwners,
        'AutoTaskActionHistories': value.autoTaskActionHistories,
        'InactivityThresholdDate': value.inactivityThresholdDate,
        'GroupEmail': value.groupEmail,
        'GroupId': value.groupId,
        'PolicyName': value.policyName,
        'PrimaryAdministrator': value.primaryAdministrator,
        'SiteTemplate': value.siteTemplate,
        'SiteTitle': value.siteTitle,
        'SiteDescription': value.siteDescription,
        'Requester': value.requester,
        'IsTeam': value.isTeam,
        'IsYammer': value.isYammer,
        'GroupOwnersStr': value.groupOwnersStr,
        'TenantId': value.tenantId,
        'Approver': value.approver,
        'ApprovalHistory': value.approvalHistory,
        'CurrentTaskAction': value.currentTaskAction,
    };
}


