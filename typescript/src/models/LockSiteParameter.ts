/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    LockSiteCollectionType,
    LockSiteCollectionTypeFromJSON,
    LockSiteCollectionTypeFromJSONTyped,
    LockSiteCollectionTypeToJSON,
    WorkspaceIdTypeModel,
    WorkspaceIdTypeModelFromJSON,
    WorkspaceIdTypeModelFromJSONTyped,
    WorkspaceIdTypeModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface LockSiteParameter
 */
export interface LockSiteParameter {
    /**
     * 
     * @type {LockSiteCollectionType}
     * @memberof LockSiteParameter
     */
    lockType?: LockSiteCollectionType;
    /**
     * 
     * @type {Array<WorkspaceIdTypeModel>}
     * @memberof LockSiteParameter
     */
    workspace?: Array<WorkspaceIdTypeModel> | null;
}

export function LockSiteParameterFromJSON(json: any): LockSiteParameter {
    return LockSiteParameterFromJSONTyped(json, false);
}

export function LockSiteParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): LockSiteParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'lockType': !exists(json, 'lockType') ? undefined : LockSiteCollectionTypeFromJSON(json['lockType']),
        'workspace': !exists(json, 'workspace') ? undefined : (json['workspace'] === null ? null : (json['workspace'] as Array<any>).map(WorkspaceIdTypeModelFromJSON)),
    };
}

export function LockSiteParameterToJSON(value?: LockSiteParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'lockType': LockSiteCollectionTypeToJSON(value.lockType),
        'workspace': value.workspace === undefined ? undefined : (value.workspace === null ? null : (value.workspace as Array<any>).map(WorkspaceIdTypeModelToJSON)),
    };
}


