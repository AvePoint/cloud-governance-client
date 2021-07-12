/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    AutoImportPhase,
    AutoImportPhaseFromJSON,
    AutoImportPhaseFromJSONTyped,
    AutoImportPhaseToJSON,
    MySiteType,
    MySiteTypeFromJSON,
    MySiteTypeFromJSONTyped,
    MySiteTypeToJSON,
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface MySite
 */
export interface MySite {
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    fullUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    description?: string | null;
    /**
     * 
     * @type {number}
     * @memberof MySite
     */
    size?: number | null;
    /**
     * 
     * @type {number}
     * @memberof MySite
     */
    quotaSize?: number;
    /**
     * 
     * @type {MySiteType}
     * @memberof MySite
     */
    type?: MySiteType;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    mySiteType?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    classification?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    sensitivity?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof MySite
     */
    isCommunicationSite?: boolean;
    /**
     * 
     * @type {Date}
     * @memberof MySite
     */
    createdTime?: Date;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    storageUsed?: string | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof MySite
     */
    primaryAdministrator?: ApiUser | null;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof MySite
     */
    additionalAdministrator?: Array<ApiUser> | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    preferredDataLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    preferredDataLocationName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    id?: string;
    /**
     * 
     * @type {AutoImportPhase}
     * @memberof MySite
     */
    phase?: AutoImportPhase;
    /**
     * 
     * @type {Date}
     * @memberof MySite
     */
    phaseStartTime?: Date | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    phaseDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    autoImportProfileId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    autoImportProfileName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    policyName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    policyDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof MySite
     */
    isCurrentRenewer?: boolean;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof MySite
     */
    phaseAssignees?: Array<ApiUser> | null;
    /**
     * 
     * @type {Date}
     * @memberof MySite
     */
    phaseDueDate?: Date | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof MySite
     */
    metadatas?: Array<RequestMetadata> | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof MySite
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof MySite
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof MySite
     */
    errorMessage?: string | null;
}

export function MySiteFromJSON(json: any): MySite {
    return MySiteFromJSONTyped(json, false);
}

export function MySiteFromJSONTyped(json: any, ignoreDiscriminator: boolean): MySite {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'fullUrl': !exists(json, 'fullUrl') ? undefined : json['fullUrl'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'size': !exists(json, 'size') ? undefined : json['size'],
        'quotaSize': !exists(json, 'quotaSize') ? undefined : json['quotaSize'],
        'type': !exists(json, 'type') ? undefined : MySiteTypeFromJSON(json['type']),
        'mySiteType': !exists(json, 'mySiteType') ? undefined : json['mySiteType'],
        'classification': !exists(json, 'classification') ? undefined : json['classification'],
        'sensitivity': !exists(json, 'sensitivity') ? undefined : json['sensitivity'],
        'isCommunicationSite': !exists(json, 'isCommunicationSite') ? undefined : json['isCommunicationSite'],
        'createdTime': !exists(json, 'createdTime') ? undefined : (new Date(json['createdTime'])),
        'storageUsed': !exists(json, 'storageUsed') ? undefined : json['storageUsed'],
        'primaryAdministrator': !exists(json, 'primaryAdministrator') ? undefined : ApiUserFromJSON(json['primaryAdministrator']),
        'additionalAdministrator': !exists(json, 'additionalAdministrator') ? undefined : (json['additionalAdministrator'] === null ? null : (json['additionalAdministrator'] as Array<any>).map(ApiUserFromJSON)),
        'preferredDataLocation': !exists(json, 'preferredDataLocation') ? undefined : json['preferredDataLocation'],
        'preferredDataLocationName': !exists(json, 'preferredDataLocationName') ? undefined : json['preferredDataLocationName'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'phase': !exists(json, 'phase') ? undefined : AutoImportPhaseFromJSON(json['phase']),
        'phaseStartTime': !exists(json, 'phaseStartTime') ? undefined : (json['phaseStartTime'] === null ? null : new Date(json['phaseStartTime'])),
        'phaseDescription': !exists(json, 'phaseDescription') ? undefined : json['phaseDescription'],
        'autoImportProfileId': !exists(json, 'autoImportProfileId') ? undefined : json['autoImportProfileId'],
        'autoImportProfileName': !exists(json, 'autoImportProfileName') ? undefined : json['autoImportProfileName'],
        'policyName': !exists(json, 'policyName') ? undefined : json['policyName'],
        'policyDescription': !exists(json, 'policyDescription') ? undefined : json['policyDescription'],
        'isCurrentRenewer': !exists(json, 'isCurrentRenewer') ? undefined : json['isCurrentRenewer'],
        'phaseAssignees': !exists(json, 'phaseAssignees') ? undefined : (json['phaseAssignees'] === null ? null : (json['phaseAssignees'] as Array<any>).map(ApiUserFromJSON)),
        'phaseDueDate': !exists(json, 'phaseDueDate') ? undefined : (json['phaseDueDate'] === null ? null : new Date(json['phaseDueDate'])),
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] === null ? null : (json['metadatas'] as Array<any>).map(RequestMetadataFromJSON)),
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'errorMessage': !exists(json, 'errorMessage') ? undefined : json['errorMessage'],
    };
}

export function MySiteToJSON(value?: MySite | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'fullUrl': value.fullUrl,
        'title': value.title,
        'description': value.description,
        'size': value.size,
        'quotaSize': value.quotaSize,
        'type': MySiteTypeToJSON(value.type),
        'mySiteType': value.mySiteType,
        'classification': value.classification,
        'sensitivity': value.sensitivity,
        'isCommunicationSite': value.isCommunicationSite,
        'createdTime': value.createdTime === undefined ? undefined : (value.createdTime.toISOString()),
        'storageUsed': value.storageUsed,
        'primaryAdministrator': ApiUserToJSON(value.primaryAdministrator),
        'additionalAdministrator': value.additionalAdministrator === undefined ? undefined : (value.additionalAdministrator === null ? null : (value.additionalAdministrator as Array<any>).map(ApiUserToJSON)),
        'preferredDataLocation': value.preferredDataLocation,
        'preferredDataLocationName': value.preferredDataLocationName,
        'id': value.id,
        'phase': AutoImportPhaseToJSON(value.phase),
        'phaseStartTime': value.phaseStartTime === undefined ? undefined : (value.phaseStartTime === null ? null : value.phaseStartTime.toISOString()),
        'phaseDescription': value.phaseDescription,
        'autoImportProfileId': value.autoImportProfileId,
        'autoImportProfileName': value.autoImportProfileName,
        'policyName': value.policyName,
        'policyDescription': value.policyDescription,
        'isCurrentRenewer': value.isCurrentRenewer,
        'phaseAssignees': value.phaseAssignees === undefined ? undefined : (value.phaseAssignees === null ? null : (value.phaseAssignees as Array<any>).map(ApiUserToJSON)),
        'phaseDueDate': value.phaseDueDate === undefined ? undefined : (value.phaseDueDate === null ? null : value.phaseDueDate.toISOString()),
        'metadatas': value.metadatas === undefined ? undefined : (value.metadatas === null ? null : (value.metadatas as Array<any>).map(RequestMetadataToJSON)),
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'errorMessage': value.errorMessage,
    };
}


