/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
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
 * Yammer community request settings model
 * @export
 * @interface YammerGroupRequestSettings
 */
export interface YammerGroupRequestSettings {
    /**
     * Yammer community name or ID
     * @type {string}
     * @memberof YammerGroupRequestSettings
     */
    nameOrId?: string | null;
    /**
     * Yammer community description
     * @type {string}
     * @memberof YammerGroupRequestSettings
     */
    description?: string | null;
    /**
     * Yammer community privacy type
     * @type {YammerGroupType}
     * @memberof YammerGroupRequestSettings
     */
    type?: YammerGroupType;
    /**
     * Set who can view Yammer community content. Whether to allow every user in the Yammer network to view the community content or allow users approved by community members to view the community content.
     * @type {YammerGroupJoinType}
     * @memberof YammerGroupRequestSettings
     */
    joinType?: YammerGroupJoinType;
    /**
     * Whether the Yammer community is associated with a Microsoft 365 Group.
     * @type {boolean}
     * @memberof YammerGroupRequestSettings
     */
    isListInDirectory?: boolean;
    /**
     * Whether the Yammer community already exists.
     * @type {boolean}
     * @memberof YammerGroupRequestSettings
     */
    isGroupAlreadyExisted?: boolean;
}

export function YammerGroupRequestSettingsFromJSON(json: any): YammerGroupRequestSettings {
    return YammerGroupRequestSettingsFromJSONTyped(json, false);
}

export function YammerGroupRequestSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): YammerGroupRequestSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'nameOrId': !exists(json, 'nameOrId') ? undefined : json['nameOrId'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'type': !exists(json, 'type') ? undefined : YammerGroupTypeFromJSON(json['type']),
        'joinType': !exists(json, 'joinType') ? undefined : YammerGroupJoinTypeFromJSON(json['joinType']),
        'isListInDirectory': !exists(json, 'isListInDirectory') ? undefined : json['isListInDirectory'],
        'isGroupAlreadyExisted': !exists(json, 'isGroupAlreadyExisted') ? undefined : json['isGroupAlreadyExisted'],
    };
}

export function YammerGroupRequestSettingsToJSON(value?: YammerGroupRequestSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'nameOrId': value.nameOrId,
        'description': value.description,
        'type': YammerGroupTypeToJSON(value.type),
        'joinType': YammerGroupJoinTypeToJSON(value.joinType),
        'isListInDirectory': value.isListInDirectory,
        'isGroupAlreadyExisted': value.isGroupAlreadyExisted,
    };
}


