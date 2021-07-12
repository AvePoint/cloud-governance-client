/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApplyPolicyStatus,
    ApplyPolicyStatusFromJSON,
    ApplyPolicyStatusFromJSONTyped,
    ApplyPolicyStatusToJSON,
    AutoImportPhase,
    AutoImportPhaseFromJSON,
    AutoImportPhaseFromJSONTyped,
    AutoImportPhaseToJSON,
    ClaimStatus,
    ClaimStatusFromJSON,
    ClaimStatusFromJSONTyped,
    ClaimStatusToJSON,
    GroupEnableSharingStatus,
    GroupEnableSharingStatusFromJSON,
    GroupEnableSharingStatusFromJSONTyped,
    GroupEnableSharingStatusToJSON,
    HubSiteType,
    HubSiteTypeFromJSON,
    HubSiteTypeFromJSONTyped,
    HubSiteTypeToJSON,
    ReportMetadata,
    ReportMetadataFromJSON,
    ReportMetadataFromJSONTyped,
    ReportMetadataToJSON,
    SiteSharingStatus,
    SiteSharingStatusFromJSON,
    SiteSharingStatusFromJSONTyped,
    SiteSharingStatusToJSON,
    WorkspaceStatus,
    WorkspaceStatusFromJSON,
    WorkspaceStatusFromJSONTyped,
    WorkspaceStatusToJSON,
    WorkspaceType,
    WorkspaceTypeFromJSON,
    WorkspaceTypeFromJSONTyped,
    WorkspaceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkspaceGridModel
 */
export interface WorkspaceGridModel {
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    description?: string | null;
    /**
     * 
     * @type {WorkspaceStatus}
     * @memberof WorkspaceGridModel
     */
    status?: WorkspaceStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {WorkspaceType}
     * @memberof WorkspaceGridModel
     */
    type?: WorkspaceType;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    typeDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    url?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    email?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof WorkspaceGridModel
     */
    privacy?: boolean | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    privacyDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    policyName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    policyDisplay?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    policyId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    primaryAdministrators?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    primaryAdministratorDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    additionalAdministrators?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    additionalAdministratorDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    primaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    primaryContactEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    primaryContactDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    secondaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    secondaryContactEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    secondaryContactDisplayName?: string | null;
    /**
     * 
     * @type {HubSiteType}
     * @memberof WorkspaceGridModel
     */
    hubType?: HubSiteType;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    associateHubTitle?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    geoLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    geoLocationDescription?: string | null;
    /**
     * 
     * @type {number}
     * @memberof WorkspaceGridModel
     */
    storageLimit?: number | null;
    /**
     * 
     * @type {number}
     * @memberof WorkspaceGridModel
     */
    storageUsed?: number | null;
    /**
     * 
     * @type {SiteSharingStatus}
     * @memberof WorkspaceGridModel
     */
    siteSharing?: SiteSharingStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    siteSharingDescription?: string | null;
    /**
     * 
     * @type {GroupEnableSharingStatus}
     * @memberof WorkspaceGridModel
     */
    groupSharing?: GroupEnableSharingStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    groupSharingDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    classification?: string | null;
    /**
     * 
     * @type {ClaimStatus}
     * @memberof WorkspaceGridModel
     */
    claimStatus?: ClaimStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    claimStatusDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    createdTime?: Date;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    leaseExpirationTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    inactivityThresholdTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    lastRenewalTime?: Date | null;
    /**
     * 
     * @type {ApplyPolicyStatus}
     * @memberof WorkspaceGridModel
     */
    applyPolicyStatus?: ApplyPolicyStatus;
    /**
     * 
     * @type {boolean}
     * @memberof WorkspaceGridModel
     */
    hasOngoingTasks?: boolean;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    hasOngoingTasksDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    lastRenewalBy?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    lastRenewalByEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    lastRenewalByDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    phaseAssigneeDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    phaseAssignees?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    phaseProfileName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    phaseProfileId?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    phaseStartTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    renewalDueDate?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceGridModel
     */
    nextRenewalDate?: Date | null;
    /**
     * 
     * @type {AutoImportPhase}
     * @memberof WorkspaceGridModel
     */
    phase?: AutoImportPhase;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceGridModel
     */
    phaseDescription?: string | null;
    /**
     * 
     * @type {Array<ReportMetadata>}
     * @memberof WorkspaceGridModel
     */
    metadata?: Array<ReportMetadata> | null;
}

export function WorkspaceGridModelFromJSON(json: any): WorkspaceGridModel {
    return WorkspaceGridModelFromJSONTyped(json, false);
}

export function WorkspaceGridModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceGridModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'status': !exists(json, 'status') ? undefined : WorkspaceStatusFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'type': !exists(json, 'type') ? undefined : WorkspaceTypeFromJSON(json['type']),
        'typeDescription': !exists(json, 'typeDescription') ? undefined : json['typeDescription'],
        'url': !exists(json, 'url') ? undefined : json['url'],
        'email': !exists(json, 'email') ? undefined : json['email'],
        'privacy': !exists(json, 'privacy') ? undefined : json['privacy'],
        'privacyDescription': !exists(json, 'privacyDescription') ? undefined : json['privacyDescription'],
        'policyName': !exists(json, 'policyName') ? undefined : json['policyName'],
        'policyDisplay': !exists(json, 'policyDisplay') ? undefined : json['policyDisplay'],
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'primaryAdministrators': !exists(json, 'primaryAdministrators') ? undefined : json['primaryAdministrators'],
        'primaryAdministratorDisplayNames': !exists(json, 'primaryAdministratorDisplayNames') ? undefined : json['primaryAdministratorDisplayNames'],
        'additionalAdministrators': !exists(json, 'additionalAdministrators') ? undefined : json['additionalAdministrators'],
        'additionalAdministratorDisplayNames': !exists(json, 'additionalAdministratorDisplayNames') ? undefined : json['additionalAdministratorDisplayNames'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : json['primaryContact'],
        'primaryContactEmail': !exists(json, 'primaryContactEmail') ? undefined : json['primaryContactEmail'],
        'primaryContactDisplayName': !exists(json, 'primaryContactDisplayName') ? undefined : json['primaryContactDisplayName'],
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : json['secondaryContact'],
        'secondaryContactEmail': !exists(json, 'secondaryContactEmail') ? undefined : json['secondaryContactEmail'],
        'secondaryContactDisplayName': !exists(json, 'secondaryContactDisplayName') ? undefined : json['secondaryContactDisplayName'],
        'hubType': !exists(json, 'hubType') ? undefined : HubSiteTypeFromJSON(json['hubType']),
        'associateHubTitle': !exists(json, 'associateHubTitle') ? undefined : json['associateHubTitle'],
        'geoLocation': !exists(json, 'geoLocation') ? undefined : json['geoLocation'],
        'geoLocationDescription': !exists(json, 'geoLocationDescription') ? undefined : json['geoLocationDescription'],
        'storageLimit': !exists(json, 'storageLimit') ? undefined : json['storageLimit'],
        'storageUsed': !exists(json, 'storageUsed') ? undefined : json['storageUsed'],
        'siteSharing': !exists(json, 'siteSharing') ? undefined : SiteSharingStatusFromJSON(json['siteSharing']),
        'siteSharingDescription': !exists(json, 'siteSharingDescription') ? undefined : json['siteSharingDescription'],
        'groupSharing': !exists(json, 'groupSharing') ? undefined : GroupEnableSharingStatusFromJSON(json['groupSharing']),
        'groupSharingDescription': !exists(json, 'groupSharingDescription') ? undefined : json['groupSharingDescription'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'claimStatus': !exists(json, 'claimStatus') ? undefined : ClaimStatusFromJSON(json['claimStatus']),
        'claimStatusDescription': !exists(json, 'claimStatusDescription') ? undefined : json['claimStatusDescription'],
        'createdTime': !exists(json, 'createdTime') ? undefined : (new Date(json['createdTime'])),
        'leaseExpirationTime': !exists(json, 'leaseExpirationTime') ? undefined : (json['leaseExpirationTime'] === null ? null : new Date(json['leaseExpirationTime'])),
        'inactivityThresholdTime': !exists(json, 'inactivityThresholdTime') ? undefined : (json['inactivityThresholdTime'] === null ? null : new Date(json['inactivityThresholdTime'])),
        'lastRenewalTime': !exists(json, 'lastRenewalTime') ? undefined : (json['lastRenewalTime'] === null ? null : new Date(json['lastRenewalTime'])),
        'applyPolicyStatus': !exists(json, 'applyPolicyStatus') ? undefined : ApplyPolicyStatusFromJSON(json['applyPolicyStatus']),
        'hasOngoingTasks': !exists(json, 'hasOngoingTasks') ? undefined : json['hasOngoingTasks'],
        'hasOngoingTasksDescription': !exists(json, 'hasOngoingTasksDescription') ? undefined : json['hasOngoingTasksDescription'],
        'lastRenewalBy': !exists(json, 'lastRenewalBy') ? undefined : json['lastRenewalBy'],
        'lastRenewalByEmail': !exists(json, 'lastRenewalByEmail') ? undefined : json['lastRenewalByEmail'],
        'lastRenewalByDisplayName': !exists(json, 'lastRenewalByDisplayName') ? undefined : json['lastRenewalByDisplayName'],
        'phaseAssigneeDisplayNames': !exists(json, 'phaseAssigneeDisplayNames') ? undefined : json['phaseAssigneeDisplayNames'],
        'phaseAssignees': !exists(json, 'phaseAssignees') ? undefined : json['phaseAssignees'],
        'phaseProfileName': !exists(json, 'phaseProfileName') ? undefined : json['phaseProfileName'],
        'phaseProfileId': !exists(json, 'phaseProfileId') ? undefined : json['phaseProfileId'],
        'phaseStartTime': !exists(json, 'phaseStartTime') ? undefined : (json['phaseStartTime'] === null ? null : new Date(json['phaseStartTime'])),
        'renewalDueDate': !exists(json, 'renewalDueDate') ? undefined : (json['renewalDueDate'] === null ? null : new Date(json['renewalDueDate'])),
        'nextRenewalDate': !exists(json, 'nextRenewalDate') ? undefined : (json['nextRenewalDate'] === null ? null : new Date(json['nextRenewalDate'])),
        'phase': !exists(json, 'phase') ? undefined : AutoImportPhaseFromJSON(json['phase']),
        'phaseDescription': !exists(json, 'phaseDescription') ? undefined : json['phaseDescription'],
        'metadata': !exists(json, 'metadata') ? undefined : (json['metadata'] === null ? null : (json['metadata'] as Array<any>).map(ReportMetadataFromJSON)),
    };
}

export function WorkspaceGridModelToJSON(value?: WorkspaceGridModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'status': WorkspaceStatusToJSON(value.status),
        'statusDescription': value.statusDescription,
        'type': WorkspaceTypeToJSON(value.type),
        'typeDescription': value.typeDescription,
        'url': value.url,
        'email': value.email,
        'privacy': value.privacy,
        'privacyDescription': value.privacyDescription,
        'policyName': value.policyName,
        'policyDisplay': value.policyDisplay,
        'policyId': value.policyId,
        'primaryAdministrators': value.primaryAdministrators,
        'primaryAdministratorDisplayNames': value.primaryAdministratorDisplayNames,
        'additionalAdministrators': value.additionalAdministrators,
        'additionalAdministratorDisplayNames': value.additionalAdministratorDisplayNames,
        'primaryContact': value.primaryContact,
        'primaryContactEmail': value.primaryContactEmail,
        'primaryContactDisplayName': value.primaryContactDisplayName,
        'secondaryContact': value.secondaryContact,
        'secondaryContactEmail': value.secondaryContactEmail,
        'secondaryContactDisplayName': value.secondaryContactDisplayName,
        'hubType': HubSiteTypeToJSON(value.hubType),
        'associateHubTitle': value.associateHubTitle,
        'geoLocation': value.geoLocation,
        'geoLocationDescription': value.geoLocationDescription,
        'storageLimit': value.storageLimit,
        'storageUsed': value.storageUsed,
        'siteSharing': SiteSharingStatusToJSON(value.siteSharing),
        'siteSharingDescription': value.siteSharingDescription,
        'groupSharing': GroupEnableSharingStatusToJSON(value.groupSharing),
        'groupSharingDescription': value.groupSharingDescription,
        'classification': value.classification,
        'claimStatus': ClaimStatusToJSON(value.claimStatus),
        'claimStatusDescription': value.claimStatusDescription,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'leaseExpirationTime': value.leaseExpirationTime === undefined ? undefined : (value.leaseExpirationTime === null ? null : value.leaseExpirationTime.toISOString()),
        'inactivityThresholdTime': value.inactivityThresholdTime === undefined ? undefined : (value.inactivityThresholdTime === null ? null : value.inactivityThresholdTime.toISOString()),
        'lastRenewalTime': value.lastRenewalTime === undefined ? undefined : (value.lastRenewalTime === null ? null : value.lastRenewalTime.toISOString()),
        'applyPolicyStatus': ApplyPolicyStatusToJSON(value.applyPolicyStatus),
        'hasOngoingTasks': value.hasOngoingTasks,
        'hasOngoingTasksDescription': value.hasOngoingTasksDescription,
        'lastRenewalBy': value.lastRenewalBy,
        'lastRenewalByEmail': value.lastRenewalByEmail,
        'lastRenewalByDisplayName': value.lastRenewalByDisplayName,
        'phaseAssigneeDisplayNames': value.phaseAssigneeDisplayNames,
        'phaseAssignees': value.phaseAssignees,
        'phaseProfileName': value.phaseProfileName,
        'phaseProfileId': value.phaseProfileId,
        'phaseStartTime': value.phaseStartTime === undefined ? undefined : (value.phaseStartTime === null ? null : value.phaseStartTime.toISOString()),
        'renewalDueDate': value.renewalDueDate === undefined ? undefined : (value.renewalDueDate === null ? null : value.renewalDueDate.toISOString()),
        'nextRenewalDate': value.nextRenewalDate === undefined ? undefined : (value.nextRenewalDate === null ? null : value.nextRenewalDate.toISOString()),
        'phase': AutoImportPhaseToJSON(value.phase),
        'phaseDescription': value.phaseDescription,
        'metadata': value.metadata === undefined ? undefined : (value.metadata === null ? null : (value.metadata as Array<any>).map(ReportMetadataToJSON)),
    };
}


