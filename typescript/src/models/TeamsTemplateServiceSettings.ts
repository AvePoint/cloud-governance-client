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
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    TextModel,
    TextModelFromJSON,
    TextModelFromJSONTyped,
    TextModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface TeamsTemplateServiceSettings
 */
export interface TeamsTemplateServiceSettings {
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCreateTeamFromScratch?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCreateTeamFromExistTeam?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCreateTeamFromTeamTemplate?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCreateTeamFromIT?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCreateTeamFromOwned?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneChannels?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneApps?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneTabs?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneMembers?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneTeamSetting?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneTeamPrivacy?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    enableCloneTeamClassification?: boolean;
    /**
     * 
     * @type {AssignBy}
     * @memberof TeamsTemplateServiceSettings
     */
    cloneTeamTemplateSettingValueAssignBy?: AssignBy;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof TeamsTemplateServiceSettings
     */
    templateTeams?: Array<GuidModel> | null;
    /**
     * 
     * @type {Array<TextModel>}
     * @memberof TeamsTemplateServiceSettings
     */
    teamTemplates?: Array<TextModel> | null;
    /**
     * 
     * @type {boolean}
     * @memberof TeamsTemplateServiceSettings
     */
    hidden?: boolean;
}

export function TeamsTemplateServiceSettingsFromJSON(json: any): TeamsTemplateServiceSettings {
    return TeamsTemplateServiceSettingsFromJSONTyped(json, false);
}

export function TeamsTemplateServiceSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): TeamsTemplateServiceSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableCreateTeamFromScratch': !exists(json, 'enableCreateTeamFromScratch') ? undefined : json['enableCreateTeamFromScratch'],
        'enableCreateTeamFromExistTeam': !exists(json, 'enableCreateTeamFromExistTeam') ? undefined : json['enableCreateTeamFromExistTeam'],
        'enableCreateTeamFromTeamTemplate': !exists(json, 'enableCreateTeamFromTeamTemplate') ? undefined : json['enableCreateTeamFromTeamTemplate'],
        'enableCreateTeamFromIT': !exists(json, 'enableCreateTeamFromIT') ? undefined : json['enableCreateTeamFromIT'],
        'enableCreateTeamFromOwned': !exists(json, 'enableCreateTeamFromOwned') ? undefined : json['enableCreateTeamFromOwned'],
        'enableCloneChannels': !exists(json, 'enableCloneChannels') ? undefined : json['enableCloneChannels'],
        'enableCloneApps': !exists(json, 'enableCloneApps') ? undefined : json['enableCloneApps'],
        'enableCloneTabs': !exists(json, 'enableCloneTabs') ? undefined : json['enableCloneTabs'],
        'enableCloneMembers': !exists(json, 'enableCloneMembers') ? undefined : json['enableCloneMembers'],
        'enableCloneTeamSetting': !exists(json, 'enableCloneTeamSetting') ? undefined : json['enableCloneTeamSetting'],
        'enableCloneTeamPrivacy': !exists(json, 'enableCloneTeamPrivacy') ? undefined : json['enableCloneTeamPrivacy'],
        'enableCloneTeamClassification': !exists(json, 'enableCloneTeamClassification') ? undefined : json['enableCloneTeamClassification'],
        'cloneTeamTemplateSettingValueAssignBy': !exists(json, 'cloneTeamTemplateSettingValueAssignBy') ? undefined : AssignByFromJSON(json['cloneTeamTemplateSettingValueAssignBy']),
        'templateTeams': !exists(json, 'templateTeams') ? undefined : (json['templateTeams'] === null ? null : (json['templateTeams'] as Array<any>).map(GuidModelFromJSON)),
        'teamTemplates': !exists(json, 'teamTemplates') ? undefined : (json['teamTemplates'] === null ? null : (json['teamTemplates'] as Array<any>).map(TextModelFromJSON)),
        'hidden': !exists(json, 'hidden') ? undefined : json['hidden'],
    };
}

export function TeamsTemplateServiceSettingsToJSON(value?: TeamsTemplateServiceSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableCreateTeamFromScratch': value.enableCreateTeamFromScratch,
        'enableCreateTeamFromExistTeam': value.enableCreateTeamFromExistTeam,
        'enableCreateTeamFromTeamTemplate': value.enableCreateTeamFromTeamTemplate,
        'enableCreateTeamFromIT': value.enableCreateTeamFromIT,
        'enableCreateTeamFromOwned': value.enableCreateTeamFromOwned,
        'enableCloneChannels': value.enableCloneChannels,
        'enableCloneApps': value.enableCloneApps,
        'enableCloneTabs': value.enableCloneTabs,
        'enableCloneMembers': value.enableCloneMembers,
        'enableCloneTeamSetting': value.enableCloneTeamSetting,
        'enableCloneTeamPrivacy': value.enableCloneTeamPrivacy,
        'enableCloneTeamClassification': value.enableCloneTeamClassification,
        'cloneTeamTemplateSettingValueAssignBy': AssignByToJSON(value.cloneTeamTemplateSettingValueAssignBy),
        'templateTeams': value.templateTeams === undefined ? undefined : (value.templateTeams === null ? null : (value.templateTeams as Array<any>).map(GuidModelToJSON)),
        'teamTemplates': value.teamTemplates === undefined ? undefined : (value.teamTemplates === null ? null : (value.teamTemplates as Array<any>).map(TextModelToJSON)),
        'hidden': value.hidden,
    };
}


