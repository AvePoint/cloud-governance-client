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
 * @interface WorkspaceReport
 */
export interface WorkspaceReport {
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    status?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    type?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    url?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    email?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    policyName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    primaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    primaryContactEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    primaryContactDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    secondaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    secondaryContactEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    secondaryContactDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    primaryAdministrators?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    primaryAdministratorDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    additionalAdministrators?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    additionalAdministratorDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    phase?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    phaseAssigneeDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    phaseAssignees?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    phaseProfileName?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    phaseStartTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    renewalDueDate?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    nextRenewalDate?: Date | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    privacy?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    associateHubTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    geoLocation?: string | null;
    /**
     * 
     * @type {number}
     * @memberof WorkspaceReport
     */
    storageLimit?: number | null;
    /**
     * 
     * @type {number}
     * @memberof WorkspaceReport
     */
    storageUsed?: number | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    siteSharing?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    groupSharing?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    sensitivityLable?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    classification?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    claimStatus?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    createdTime?: Date;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    leaseExpirationTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    inactivityThresholdTime?: Date | null;
    /**
     * 
     * @type {{ [key: string]: string; }}
     * @memberof WorkspaceReport
     */
    metadata?: { [key: string]: string; } | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    hasOngoingTasks?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceReport
     */
    lastRenewalTime?: Date | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    lastRenewalBy?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceReport
     */
    lastRenewalByDisplayName?: string | null;
}

export function WorkspaceReportFromJSON(json: any): WorkspaceReport {
    return WorkspaceReportFromJSONTyped(json, false);
}

export function WorkspaceReportFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceReport {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'Id') ? undefined : json['Id'],
        'name': !exists(json, 'Name') ? undefined : json['Name'],
        'description': !exists(json, 'Description') ? undefined : json['Description'],
        'status': !exists(json, 'Status') ? undefined : json['Status'],
        'type': !exists(json, 'Type') ? undefined : json['Type'],
        'url': !exists(json, 'Url') ? undefined : json['Url'],
        'email': !exists(json, 'Email') ? undefined : json['Email'],
        'policyName': !exists(json, 'PolicyName') ? undefined : json['PolicyName'],
        'primaryContact': !exists(json, 'PrimaryContact') ? undefined : json['PrimaryContact'],
        'primaryContactEmail': !exists(json, 'PrimaryContactEmail') ? undefined : json['PrimaryContactEmail'],
        'primaryContactDisplayName': !exists(json, 'PrimaryContactDisplayName') ? undefined : json['PrimaryContactDisplayName'],
        'secondaryContact': !exists(json, 'SecondaryContact') ? undefined : json['SecondaryContact'],
        'secondaryContactEmail': !exists(json, 'SecondaryContactEmail') ? undefined : json['SecondaryContactEmail'],
        'secondaryContactDisplayName': !exists(json, 'SecondaryContactDisplayName') ? undefined : json['SecondaryContactDisplayName'],
        'primaryAdministrators': !exists(json, 'PrimaryAdministrators') ? undefined : json['PrimaryAdministrators'],
        'primaryAdministratorDisplayNames': !exists(json, 'PrimaryAdministratorDisplayNames') ? undefined : json['PrimaryAdministratorDisplayNames'],
        'additionalAdministrators': !exists(json, 'AdditionalAdministrators') ? undefined : json['AdditionalAdministrators'],
        'additionalAdministratorDisplayNames': !exists(json, 'AdditionalAdministratorDisplayNames') ? undefined : json['AdditionalAdministratorDisplayNames'],
        'phase': !exists(json, 'Phase') ? undefined : json['Phase'],
        'phaseAssigneeDisplayNames': !exists(json, 'PhaseAssigneeDisplayNames') ? undefined : json['PhaseAssigneeDisplayNames'],
        'phaseAssignees': !exists(json, 'PhaseAssignees') ? undefined : json['PhaseAssignees'],
        'phaseProfileName': !exists(json, 'PhaseProfileName') ? undefined : json['PhaseProfileName'],
        'phaseStartTime': !exists(json, 'PhaseStartTime') ? undefined : (json['PhaseStartTime'] === null ? null : new Date(json['PhaseStartTime'])),
        'renewalDueDate': !exists(json, 'RenewalDueDate') ? undefined : (json['RenewalDueDate'] === null ? null : new Date(json['RenewalDueDate'])),
        'nextRenewalDate': !exists(json, 'NextRenewalDate') ? undefined : (json['NextRenewalDate'] === null ? null : new Date(json['NextRenewalDate'])),
        'privacy': !exists(json, 'Privacy') ? undefined : json['Privacy'],
        'associateHubTitle': !exists(json, 'AssociateHubTitle') ? undefined : json['AssociateHubTitle'],
        'geoLocation': !exists(json, 'GeoLocation') ? undefined : json['GeoLocation'],
        'storageLimit': !exists(json, 'StorageLimit') ? undefined : json['StorageLimit'],
        'storageUsed': !exists(json, 'StorageUsed') ? undefined : json['StorageUsed'],
        'siteSharing': !exists(json, 'SiteSharing') ? undefined : json['SiteSharing'],
        'groupSharing': !exists(json, 'GroupSharing') ? undefined : json['GroupSharing'],
        'sensitivityLable': !exists(json, 'SensitivityLable') ? undefined : json['SensitivityLable'],
        'classification': !exists(json, 'Classification') ? undefined : json['Classification'],
        'claimStatus': !exists(json, 'ClaimStatus') ? undefined : json['ClaimStatus'],
        'createdTime': !exists(json, 'CreatedTime') ? undefined : (new Date(json['CreatedTime'])),
        'leaseExpirationTime': !exists(json, 'LeaseExpirationTime') ? undefined : (json['LeaseExpirationTime'] === null ? null : new Date(json['LeaseExpirationTime'])),
        'inactivityThresholdTime': !exists(json, 'InactivityThresholdTime') ? undefined : (json['InactivityThresholdTime'] === null ? null : new Date(json['InactivityThresholdTime'])),
        'metadata': !exists(json, 'Metadata') ? undefined : json['Metadata'],
        'hasOngoingTasks': !exists(json, 'HasOngoingTasks') ? undefined : json['HasOngoingTasks'],
        'lastRenewalTime': !exists(json, 'LastRenewalTime') ? undefined : (json['LastRenewalTime'] === null ? null : new Date(json['LastRenewalTime'])),
        'lastRenewalBy': !exists(json, 'LastRenewalBy') ? undefined : json['LastRenewalBy'],
        'lastRenewalByDisplayName': !exists(json, 'LastRenewalByDisplayName') ? undefined : json['LastRenewalByDisplayName'],
    };
}

export function WorkspaceReportToJSON(value?: WorkspaceReport | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'Id': value.id,
        'Name': value.name,
        'Description': value.description,
        'Status': value.status,
        'Type': value.type,
        'Url': value.url,
        'Email': value.email,
        'PolicyName': value.policyName,
        'PrimaryContact': value.primaryContact,
        'PrimaryContactEmail': value.primaryContactEmail,
        'PrimaryContactDisplayName': value.primaryContactDisplayName,
        'SecondaryContact': value.secondaryContact,
        'SecondaryContactEmail': value.secondaryContactEmail,
        'SecondaryContactDisplayName': value.secondaryContactDisplayName,
        'PrimaryAdministrators': value.primaryAdministrators,
        'PrimaryAdministratorDisplayNames': value.primaryAdministratorDisplayNames,
        'AdditionalAdministrators': value.additionalAdministrators,
        'AdditionalAdministratorDisplayNames': value.additionalAdministratorDisplayNames,
        'Phase': value.phase,
        'PhaseAssigneeDisplayNames': value.phaseAssigneeDisplayNames,
        'PhaseAssignees': value.phaseAssignees,
        'PhaseProfileName': value.phaseProfileName,
        'PhaseStartTime': value.phaseStartTime === undefined ? undefined : (value.phaseStartTime === null ? null : value.phaseStartTime.toISOString()),
        'RenewalDueDate': value.renewalDueDate === undefined ? undefined : (value.renewalDueDate === null ? null : value.renewalDueDate.toISOString()),
        'NextRenewalDate': value.nextRenewalDate === undefined ? undefined : (value.nextRenewalDate === null ? null : value.nextRenewalDate.toISOString()),
        'Privacy': value.privacy,
        'AssociateHubTitle': value.associateHubTitle,
        'GeoLocation': value.geoLocation,
        'StorageLimit': value.storageLimit,
        'StorageUsed': value.storageUsed,
        'SiteSharing': value.siteSharing,
        'GroupSharing': value.groupSharing,
        'SensitivityLable': value.sensitivityLable,
        'Classification': value.classification,
        'ClaimStatus': value.claimStatus,
        'CreatedTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'LeaseExpirationTime': value.leaseExpirationTime === undefined ? undefined : (value.leaseExpirationTime === null ? null : value.leaseExpirationTime.toISOString()),
        'InactivityThresholdTime': value.inactivityThresholdTime === undefined ? undefined : (value.inactivityThresholdTime === null ? null : value.inactivityThresholdTime.toISOString()),
        'Metadata': value.metadata,
        'HasOngoingTasks': value.hasOngoingTasks,
        'LastRenewalTime': value.lastRenewalTime === undefined ? undefined : (value.lastRenewalTime === null ? null : value.lastRenewalTime.toISOString()),
        'LastRenewalBy': value.lastRenewalBy,
        'LastRenewalByDisplayName': value.lastRenewalByDisplayName,
    };
}


