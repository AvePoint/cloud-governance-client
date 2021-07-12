/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    WorkspaceType,
    WorkspaceTypeFromJSON,
    WorkspaceTypeFromJSONTyped,
    WorkspaceTypeToJSON,
} from './';

/**
 * id and type of workspace
 * @export
 * @interface WorkspaceIdTypeModel
 */
export interface WorkspaceIdTypeModel {
    /**
     * workspace id
     * @type {string}
     * @memberof WorkspaceIdTypeModel
     */
    objectId?: string;
    /**
     * workspace type
     * @type {WorkspaceType}
     * @memberof WorkspaceIdTypeModel
     */
    workspaceType?: WorkspaceType;
}

export function WorkspaceIdTypeModelFromJSON(json: any): WorkspaceIdTypeModel {
    return WorkspaceIdTypeModelFromJSONTyped(json, false);
}

export function WorkspaceIdTypeModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorkspaceIdTypeModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'workspaceType': !exists(json, 'workspaceType') ? undefined : WorkspaceTypeFromJSON(json['workspaceType']),
    };
}

export function WorkspaceIdTypeModelToJSON(value?: WorkspaceIdTypeModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'objectId': value.objectId,
        'workspaceType': WorkspaceTypeToJSON(value.workspaceType),
    };
}


