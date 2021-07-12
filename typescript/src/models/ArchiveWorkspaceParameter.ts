/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    WorkspaceArchivedType,
    WorkspaceArchivedTypeFromJSON,
    WorkspaceArchivedTypeFromJSONTyped,
    WorkspaceArchivedTypeToJSON,
} from './';

/**
 * archive workspace parameter
 * @export
 * @interface ArchiveWorkspaceParameter
 */
export interface ArchiveWorkspaceParameter {
    /**
     * WorkspaceType is site, you should set profile name
     * WorkspaceType is teams, you should set profile id
     * @type {string}
     * @memberof ArchiveWorkspaceParameter
     */
    archiveProfile?: string | null;
    /**
     * workspace ids
     * @type {Array<string>}
     * @memberof ArchiveWorkspaceParameter
     */
    objectIds?: Array<string> | null;
    /**
     * workspace type
     * @type {WorkspaceArchivedType}
     * @memberof ArchiveWorkspaceParameter
     */
    workspaceType?: WorkspaceArchivedType;
}

export function ArchiveWorkspaceParameterFromJSON(json: any): ArchiveWorkspaceParameter {
    return ArchiveWorkspaceParameterFromJSONTyped(json, false);
}

export function ArchiveWorkspaceParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): ArchiveWorkspaceParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'archiveProfile': !exists(json, 'archiveProfile') ? undefined : json['archiveProfile'],
        'objectIds': !exists(json, 'objectIds') ? undefined : json['objectIds'],
        'workspaceType': !exists(json, 'workspaceType') ? undefined : WorkspaceArchivedTypeFromJSON(json['workspaceType']),
    };
}

export function ArchiveWorkspaceParameterToJSON(value?: ArchiveWorkspaceParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'archiveProfile': value.archiveProfile,
        'objectIds': value.objectIds,
        'workspaceType': WorkspaceArchivedTypeToJSON(value.workspaceType),
    };
}


