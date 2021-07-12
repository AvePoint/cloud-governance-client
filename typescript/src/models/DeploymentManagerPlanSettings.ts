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
 * @interface DeploymentManagerPlanSettings
 */
export interface DeploymentManagerPlanSettings {
    /**
     * 
     * @type {boolean}
     * @memberof DeploymentManagerPlanSettings
     */
    enabled?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof DeploymentManagerPlanSettings
     */
    plans?: Array<string> | null;
    /**
     * 
     * @type {AssignBy}
     * @memberof DeploymentManagerPlanSettings
     */
    assignBy?: AssignBy;
    /**
     * 
     * @type {string}
     * @memberof DeploymentManagerPlanSettings
     */
    _default?: string | null;
}

export function DeploymentManagerPlanSettingsFromJSON(json: any): DeploymentManagerPlanSettings {
    return DeploymentManagerPlanSettingsFromJSONTyped(json, false);
}

export function DeploymentManagerPlanSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): DeploymentManagerPlanSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'plans': !exists(json, 'plans') ? undefined : json['plans'],
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
        '_default': !exists(json, 'default') ? undefined : json['default'],
    };
}

export function DeploymentManagerPlanSettingsToJSON(value?: DeploymentManagerPlanSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'plans': value.plans,
        'assignBy': AssignByToJSON(value.assignBy),
        'default': value._default,
    };
}


