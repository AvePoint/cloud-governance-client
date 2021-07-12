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
} from './';

/**
 * 
 * @export
 * @interface CopyMoveSettingAssignBy
 */
export interface CopyMoveSettingAssignBy {
    /**
     * 
     * @type {AssignBy}
     * @memberof CopyMoveSettingAssignBy
     */
    configurationAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CopyMoveSettingAssignBy
     */
    securityAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof CopyMoveSettingAssignBy
     */
    contentAssignBy?: AssignBy;
}

export function CopyMoveSettingAssignByFromJSON(json: any): CopyMoveSettingAssignBy {
    return CopyMoveSettingAssignByFromJSONTyped(json, false);
}

export function CopyMoveSettingAssignByFromJSONTyped(json: any, ignoreDiscriminator: boolean): CopyMoveSettingAssignBy {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'configurationAssignBy': !exists(json, 'configurationAssignBy') ? undefined : AssignByFromJSON(json['configurationAssignBy']),
        'securityAssignBy': !exists(json, 'securityAssignBy') ? undefined : AssignByFromJSON(json['securityAssignBy']),
        'contentAssignBy': !exists(json, 'contentAssignBy') ? undefined : AssignByFromJSON(json['contentAssignBy']),
    };
}

export function CopyMoveSettingAssignByToJSON(value?: CopyMoveSettingAssignBy | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'configurationAssignBy': AssignByToJSON(value.configurationAssignBy),
        'securityAssignBy': AssignByToJSON(value.securityAssignBy),
        'contentAssignBy': AssignByToJSON(value.contentAssignBy),
    };
}


