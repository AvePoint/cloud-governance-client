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
    WorkspaceIdTypeModel,
    WorkspaceIdTypeModelFromJSON,
    WorkspaceIdTypeModelFromJSONTyped,
    WorkspaceIdTypeModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface SpecifyContactParameter
 */
export interface SpecifyContactParameter {
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof SpecifyContactParameter
     */
    primaryContact?: ApiUser | null;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof SpecifyContactParameter
     */
    secondaryContact?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof SpecifyContactParameter
     */
    primaryContactNotifiedEmail?: string;
    /**
     * 
     * @type {string}
     * @memberof SpecifyContactParameter
     */
    secondaryContactNotifiedEmail?: string;
    /**
     * 
     * @type {Array<WorkspaceIdTypeModel>}
     * @memberof SpecifyContactParameter
     */
    workspace?: Array<WorkspaceIdTypeModel> | null;
}

export function SpecifyContactParameterFromJSON(json: any): SpecifyContactParameter {
    return SpecifyContactParameterFromJSONTyped(json, false);
}

export function SpecifyContactParameterFromJSONTyped(json: any, ignoreDiscriminator: boolean): SpecifyContactParameter {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'primaryContact': !exists(json, 'primaryContact') ? undefined : ApiUserFromJSON(json['primaryContact']),
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : ApiUserFromJSON(json['secondaryContact']),
        'primaryContactNotifiedEmail': !exists(json, 'primaryContactNotifiedEmail') ? undefined : json['primaryContactNotifiedEmail'],
        'secondaryContactNotifiedEmail': !exists(json, 'secondaryContactNotifiedEmail') ? undefined : json['secondaryContactNotifiedEmail'],
        'workspace': !exists(json, 'workspace') ? undefined : (json['workspace'] === null ? null : (json['workspace'] as Array<any>).map(WorkspaceIdTypeModelFromJSON)),
    };
}

export function SpecifyContactParameterToJSON(value?: SpecifyContactParameter | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'primaryContact': ApiUserToJSON(value.primaryContact),
        'secondaryContact': ApiUserToJSON(value.secondaryContact),
        'primaryContactNotifiedEmail': value.primaryContactNotifiedEmail,
        'secondaryContactNotifiedEmail': value.secondaryContactNotifiedEmail,
        'workspace': value.workspace === undefined ? undefined : (value.workspace === null ? null : (value.workspace as Array<any>).map(WorkspaceIdTypeModelToJSON)),
    };
}


