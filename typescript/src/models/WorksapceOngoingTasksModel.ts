/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface WorksapceOngoingTasksModel
 */
export interface WorksapceOngoingTasksModel {
    /**
     * 
     * @type {string}
     * @memberof WorksapceOngoingTasksModel
     */
    taskName?: string | null;
    /**
     * 
     * @type {ServiceType}
     * @memberof WorksapceOngoingTasksModel
     */
    serviceType?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof WorksapceOngoingTasksModel
     */
    serviceTypeDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WorksapceOngoingTasksModel
     */
    instanceId?: string;
    /**
     * 
     * @type {string}
     * @memberof WorksapceOngoingTasksModel
     */
    workspaceId?: string;
}

export function WorksapceOngoingTasksModelFromJSON(json: any): WorksapceOngoingTasksModel {
    return WorksapceOngoingTasksModelFromJSONTyped(json, false);
}

export function WorksapceOngoingTasksModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): WorksapceOngoingTasksModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'taskName': !exists(json, 'taskName') ? undefined : json['taskName'],
        'serviceType': !exists(json, 'serviceType') ? undefined : ServiceTypeFromJSON(json['serviceType']),
        'serviceTypeDescription': !exists(json, 'serviceTypeDescription') ? undefined : json['serviceTypeDescription'],
        'instanceId': !exists(json, 'instanceId') ? undefined : json['instanceId'],
        'workspaceId': !exists(json, 'workspaceId') ? undefined : json['workspaceId'],
    };
}

export function WorksapceOngoingTasksModelToJSON(value?: WorksapceOngoingTasksModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'taskName': value.taskName,
        'serviceType': ServiceTypeToJSON(value.serviceType),
        'serviceTypeDescription': value.serviceTypeDescription,
        'instanceId': value.instanceId,
        'workspaceId': value.workspaceId,
    };
}


