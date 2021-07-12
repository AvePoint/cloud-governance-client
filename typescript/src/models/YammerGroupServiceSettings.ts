/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    YammerGroupJoinType,
    YammerGroupJoinTypeFromJSON,
    YammerGroupJoinTypeFromJSONTyped,
    YammerGroupJoinTypeToJSON,
    YammerGroupType,
    YammerGroupTypeFromJSON,
    YammerGroupTypeFromJSONTyped,
    YammerGroupTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface YammerGroupServiceSettings
 */
export interface YammerGroupServiceSettings {
    /**
     * 
     * @type {string}
     * @memberof YammerGroupServiceSettings
     */
    networkId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof YammerGroupServiceSettings
     */
    allowCreate?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof YammerGroupServiceSettings
     */
    allowReuseExisting?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof YammerGroupServiceSettings
     */
    enabled?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof YammerGroupServiceSettings
     */
    createNewGroupAssignBy?: AssignBy;
    /**
     * Yammer community name or ID
     * @type {string}
     * @memberof YammerGroupServiceSettings
     */
    nameOrId?: string | null;
    /**
     * Yammer community description
     * @type {string}
     * @memberof YammerGroupServiceSettings
     */
    description?: string | null;
    /**
     * Yammer community privacy type
     * @type {YammerGroupType}
     * @memberof YammerGroupServiceSettings
     */
    type?: YammerGroupType;
    /**
     * Set who can view Yammer community content. Whether to allow every user in the Yammer network to view the community content or allow users approved by community members to view the community content.
     * @type {YammerGroupJoinType}
     * @memberof YammerGroupServiceSettings
     */
    joinType?: YammerGroupJoinType;
    /**
     * Whether the Yammer community is associated with a Microsoft 365 Group.
     * @type {boolean}
     * @memberof YammerGroupServiceSettings
     */
    isListInDirectory?: boolean;
    /**
     * Whether the Yammer community already exists.
     * @type {boolean}
     * @memberof YammerGroupServiceSettings
     */
    isGroupAlreadyExisted?: boolean;
}

export function YammerGroupServiceSettingsFromJSON(json: any): YammerGroupServiceSettings {
    return YammerGroupServiceSettingsFromJSONTyped(json, false);
}

export function YammerGroupServiceSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): YammerGroupServiceSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'allowCreate': !exists(json, 'allowCreate') ? undefined : json['allowCreate'],
        'allowReuseExisting': !exists(json, 'allowReuseExisting') ? undefined : json['allowReuseExisting'],
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'createNewGroupAssignBy': !exists(json, 'createNewGroupAssignBy') ? undefined : AssignByFromJSON(json['createNewGroupAssignBy']),
        'nameOrId': !exists(json, 'nameOrId') ? undefined : json['nameOrId'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'type': !exists(json, 'type') ? undefined : YammerGroupTypeFromJSON(json['type']),
        'joinType': !exists(json, 'joinType') ? undefined : YammerGroupJoinTypeFromJSON(json['joinType']),
        'isListInDirectory': !exists(json, 'isListInDirectory') ? undefined : json['isListInDirectory'],
        'isGroupAlreadyExisted': !exists(json, 'isGroupAlreadyExisted') ? undefined : json['isGroupAlreadyExisted'],
    };
}

export function YammerGroupServiceSettingsToJSON(value?: YammerGroupServiceSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'networkId': value.networkId,
        'allowCreate': value.allowCreate,
        'allowReuseExisting': value.allowReuseExisting,
        'enabled': value.enabled,
        'createNewGroupAssignBy': AssignByToJSON(value.createNewGroupAssignBy),
        'nameOrId': value.nameOrId,
        'description': value.description,
        'type': YammerGroupTypeToJSON(value.type),
        'joinType': YammerGroupJoinTypeToJSON(value.joinType),
        'isListInDirectory': value.isListInDirectory,
        'isGroupAlreadyExisted': value.isGroupAlreadyExisted,
    };
}


