/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ExternalUserState,
    ExternalUserStateFromJSON,
    ExternalUserStateFromJSONTyped,
    ExternalUserStateToJSON,
    GuestUserStatus,
    GuestUserStatusFromJSON,
    GuestUserStatusFromJSONTyped,
    GuestUserStatusToJSON,
    ReportMetadata,
    ReportMetadataFromJSON,
    ReportMetadataFromJSONTyped,
    ReportMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface GuestUserGridModel
 */
export interface GuestUserGridModel {
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    displayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    mail?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    primaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    primaryContactDisplayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    secondaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    secondaryContactDisplayName?: string | null;
    /**
     * 
     * @type {GuestUserStatus}
     * @memberof GuestUserGridModel
     */
    status?: GuestUserStatus;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    profileName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    tenantId?: string;
    /**
     * 
     * @type {Date}
     * @memberof GuestUserGridModel
     */
    nextRenewalDate?: Date | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    renewalAssignees?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    renewalAssigneeDisplayNames?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    lastRenewalBy?: string | null;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    lastRenewalByDisplayName?: string | null;
    /**
     * 
     * @type {ExternalUserState}
     * @memberof GuestUserGridModel
     */
    externalUserState?: ExternalUserState;
    /**
     * 
     * @type {string}
     * @memberof GuestUserGridModel
     */
    externalUserStateDescription?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof GuestUserGridModel
     */
    lastSyncTime?: Date | null;
    /**
     * 
     * @type {Date}
     * @memberof GuestUserGridModel
     */
    inviteTime?: Date | null;
    /**
     * 
     * @type {Array<ReportMetadata>}
     * @memberof GuestUserGridModel
     */
    metadata?: Array<ReportMetadata> | null;
}

export function GuestUserGridModelFromJSON(json: any): GuestUserGridModel {
    return GuestUserGridModelFromJSONTyped(json, false);
}

export function GuestUserGridModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): GuestUserGridModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'mail': !exists(json, 'mail') ? undefined : json['mail'],
        'primaryContact': !exists(json, 'primaryContact') ? undefined : json['primaryContact'],
        'primaryContactDisplayName': !exists(json, 'primaryContactDisplayName') ? undefined : json['primaryContactDisplayName'],
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : json['secondaryContact'],
        'secondaryContactDisplayName': !exists(json, 'secondaryContactDisplayName') ? undefined : json['secondaryContactDisplayName'],
        'status': !exists(json, 'status') ? undefined : GuestUserStatusFromJSON(json['status']),
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'profileName': !exists(json, 'profileName') ? undefined : json['profileName'],
        'tenantId': !exists(json, 'tenantId') ? undefined : json['tenantId'],
        'nextRenewalDate': !exists(json, 'nextRenewalDate') ? undefined : (json['nextRenewalDate'] === null ? null : new Date(json['nextRenewalDate'])),
        'renewalAssignees': !exists(json, 'renewalAssignees') ? undefined : json['renewalAssignees'],
        'renewalAssigneeDisplayNames': !exists(json, 'renewalAssigneeDisplayNames') ? undefined : json['renewalAssigneeDisplayNames'],
        'lastRenewalBy': !exists(json, 'lastRenewalBy') ? undefined : json['lastRenewalBy'],
        'lastRenewalByDisplayName': !exists(json, 'lastRenewalByDisplayName') ? undefined : json['lastRenewalByDisplayName'],
        'externalUserState': !exists(json, 'externalUserState') ? undefined : ExternalUserStateFromJSON(json['externalUserState']),
        'externalUserStateDescription': !exists(json, 'externalUserStateDescription') ? undefined : json['externalUserStateDescription'],
        'lastSyncTime': !exists(json, 'lastSyncTime') ? undefined : (json['lastSyncTime'] === null ? null : new Date(json['lastSyncTime'])),
        'inviteTime': !exists(json, 'inviteTime') ? undefined : (json['inviteTime'] === null ? null : new Date(json['inviteTime'])),
        'metadata': !exists(json, 'metadata') ? undefined : (json['metadata'] === null ? null : (json['metadata'] as Array<any>).map(ReportMetadataFromJSON)),
    };
}

export function GuestUserGridModelToJSON(value?: GuestUserGridModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'displayName': value.displayName,
        'mail': value.mail,
        'primaryContact': value.primaryContact,
        'primaryContactDisplayName': value.primaryContactDisplayName,
        'secondaryContact': value.secondaryContact,
        'secondaryContactDisplayName': value.secondaryContactDisplayName,
        'status': GuestUserStatusToJSON(value.status),
        'statusDescription': value.statusDescription,
        'profileName': value.profileName,
        'tenantId': value.tenantId,
        'nextRenewalDate': value.nextRenewalDate === undefined ? undefined : (value.nextRenewalDate === null ? null : value.nextRenewalDate.toISOString()),
        'renewalAssignees': value.renewalAssignees,
        'renewalAssigneeDisplayNames': value.renewalAssigneeDisplayNames,
        'lastRenewalBy': value.lastRenewalBy,
        'lastRenewalByDisplayName': value.lastRenewalByDisplayName,
        'externalUserState': ExternalUserStateToJSON(value.externalUserState),
        'externalUserStateDescription': value.externalUserStateDescription,
        'lastSyncTime': value.lastSyncTime === undefined ? undefined : (value.lastSyncTime === null ? null : value.lastSyncTime.toISOString()),
        'inviteTime': value.inviteTime === undefined ? undefined : (value.inviteTime === null ? null : value.inviteTime.toISOString()),
        'metadata': value.metadata === undefined ? undefined : (value.metadata === null ? null : (value.metadata as Array<any>).map(ReportMetadataToJSON)),
    };
}


