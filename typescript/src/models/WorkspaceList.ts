/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AutoImportPhase,
    AutoImportPhaseFromJSON,
    AutoImportPhaseFromJSONTyped,
    AutoImportPhaseToJSON,
    EndUserReportMetadata,
    EndUserReportMetadataFromJSON,
    EndUserReportMetadataFromJSONTyped,
    EndUserReportMetadataToJSON,
    SiteStatus,
    SiteStatusFromJSON,
    SiteStatusFromJSONTyped,
    SiteStatusToJSON,
    WorkspaceType,
    WorkspaceTypeFromJSON,
    WorkspaceTypeFromJSONTyped,
    WorkspaceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorkspaceList
 */
export interface WorkspaceList {
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    name?: string | null;
    /**
     * 
     * @type {WorkspaceType}
     * @memberof WorkspaceList
     */
    type?: WorkspaceType;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    siteUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    groupEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    typeDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    primaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    primaryContactEmail?: string | null;
    /**
     * 
     * @type {AutoImportPhase}
     * @memberof WorkspaceList
     */
    phase?: AutoImportPhase;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    phaseDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof WorkspaceList
     */
    isCurrentRenewer?: boolean;
    /**
     * 
     * @type {Date}
     * @memberof WorkspaceList
     */
    createdTime?: Date;
    /**
     * 
     * @type {SiteStatus}
     * @memberof WorkspaceList
     */
    status?: SiteStatus;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    autoImportProfileId?: string;
    /**
     * 
     * @type {number}
     * @memberof WorkspaceList
     */
    pendingAction?: number;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    secondaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    secondaryContactEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    policy?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    policyId?: string;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    primaryAdmin?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    primaryAdminEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    additionalAdmin?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    additionalAdminEmail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    geoLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    geoLocationDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    storageLimit?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    storageUsage?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    classification?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof WorkspaceList
     */
    privacy?: boolean | null;
    /**
     * 
     * @type {string}
     * @memberof WorkspaceList
     */
    privacyDescription?: string | null;
    /**
     * 
     * @type {Array<EndUserReportMetadata>}
     * @memberof WorkspaceList
     */
    metadata?: Array<EndUserReportMetadata> | null;
}

export function WorkspaceListFromJSON(json: any): WorkspaceList {
    return WorkspaceListFromJSONTyped(json, false);
}

export function WorkspaceListFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'type': !exists(json, 'type') ? undefined : WorkspaceTypeFromJSON(json['type']),
        'siteUrl': !exists(json, 'siteUrl') ? undefined : json['siteUrl'],
        'groupEmail': !exists(json, 'groupEmail') ? undefined : json['groupEmail'],
        'typeDescription': !exists(json, 'typeDescription') ? undefined : json['typeDescription'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : json['primaryContact'],
        'primaryContactEmail': !exists(json, 'primaryContactEmail') ? undefined : json['primaryContactEmail'],
        'phase': !exists(json, 'phase') ? undefined : AutoImportPhaseFromJSON(json['phase']),
        'phaseDescription': !exists(json, 'phaseDescription') ? undefined : json['phaseDescription'],
        'isCurrentRenewer': !exists(json, 'isCurrentRenewer') ? undefined : json['isCurrentRenewer'],
        'createdTime': !exists(json, 'createdTime') ? undefined : (new Date(json['createdTime'])),
        'status': !exists(json, 'status') ? undefined : SiteStatusFromJSON(json['status']),
        'autoImportProfileId': !exists(json, 'autoImportProfileId') ? undefined : json['autoImportProfileId'],
        'pendingAction': !exists(json, 'pendingAction') ? undefined : json['pendingAction'],
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : json['secondaryContact'],
        'secondaryContactEmail': !exists(json, 'secondaryContactEmail') ? undefined : json['secondaryContactEmail'],
        'policy': !exists(json, 'policy') ? undefined : json['policy'],
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'primaryAdmin': !exists(json, 'primaryAdmin') ? undefined : json['primaryAdmin'],
        'primaryAdminEmail': !exists(json, 'primaryAdminEmail') ? undefined : json['primaryAdminEmail'],
        'additionalAdmin': !exists(json, 'additionalAdmin') ? undefined : json['additionalAdmin'],
        'additionalAdminEmail': !exists(json, 'additionalAdminEmail') ? undefined : json['additionalAdminEmail'],
        'geoLocation': !exists(json, 'geoLocation') ? undefined : json['geoLocation'],
        'geoLocationDescription': !exists(json, 'geoLocationDescription') ? undefined : json['geoLocationDescription'],
        'storageLimit': !exists(json, 'storageLimit') ? undefined : json['storageLimit'],
        'storageUsage': !exists(json, 'storageUsage') ? undefined : json['storageUsage'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'privacy': !exists(json, 'privacy') ? undefined : json['privacy'],
        'privacyDescription': !exists(json, 'privacyDescription') ? undefined : json['privacyDescription'],
        'metadata': !exists(json, 'metadata') ? undefined : (json['metadata'] === null ? null : (json['metadata'] as Array<any>).map(EndUserReportMetadataFromJSON)),
    };
}

export function WorkspaceListToJSON(value?: WorkspaceList | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'type': WorkspaceTypeToJSON(value.type),
        'siteUrl': value.siteUrl,
        'groupEmail': value.groupEmail,
        'typeDescription': value.typeDescription,
        'primaryContact': value.primaryContact,
        'primaryContactEmail': value.primaryContactEmail,
        'phase': AutoImportPhaseToJSON(value.phase),
        'phaseDescription': value.phaseDescription,
        'isCurrentRenewer': value.isCurrentRenewer,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'status': SiteStatusToJSON(value.status),
        'autoImportProfileId': value.autoImportProfileId,
        'pendingAction': value.pendingAction,
        'secondaryContact': value.secondaryContact,
        'secondaryContactEmail': value.secondaryContactEmail,
        'policy': value.policy,
        'policyId': value.policyId,
        'description': value.description,
        'primaryAdmin': value.primaryAdmin,
        'primaryAdminEmail': value.primaryAdminEmail,
        'additionalAdmin': value.additionalAdmin,
        'additionalAdminEmail': value.additionalAdminEmail,
        'geoLocation': value.geoLocation,
        'geoLocationDescription': value.geoLocationDescription,
        'storageLimit': value.storageLimit,
        'storageUsage': value.storageUsage,
        'classification': value.classification,
        'privacy': value.privacy,
        'privacyDescription': value.privacyDescription,
        'metadata': value.metadata === undefined ? undefined : (value.metadata === null ? null : (value.metadata as Array<any>).map(EndUserReportMetadataToJSON)),
    };
}


