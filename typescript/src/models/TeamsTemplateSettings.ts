/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
    StringModel,
    StringModelFromJSON,
    StringModelFromJSONTyped,
    StringModelToJSON,
    TextModel,
    TextModelFromJSON,
    TextModelFromJSONTyped,
    TextModelToJSON,
} from './';

/**
 * Teams template settings model
 * @export
 * @interface TeamsTemplateSettings
 */
export interface TeamsTemplateSettings {
    /**
     * Whether to allow business users to create a team from scratch.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCreateTeamFromScratch?: boolean;
    /**
     * Whether to allow business users to create a team from an existing team.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCreateTeamFromExistTeam?: boolean;
    /**
     * Whether to allow business users to create a team using a team template.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCreateTeamFromTeamTemplate?: boolean;
    /**
     * The selected custom team template
     * @type {GuidModel}
     * @memberof TeamsTemplateSettings
     */
    selectedTemplate?: GuidModel | null;
    /**
     * The selected built-in team template
     * @type {StringModel}
     * @memberof TeamsTemplateSettings
     */
    selectedMSTemplate?: StringModel | null;
    /**
     * All team templates
     * @type {Array<TextModel>}
     * @memberof TeamsTemplateSettings
     */
    teamTemplates?: Array<TextModel> | null;
    /**
     * Set whether copying channels from the team is enabled.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneChannels?: boolean;
    /**
     * Set whether copying apps from the team is enabled.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneApps?: boolean;
    /**
     * Set whether copying tabs from the team is enabled.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneTabs?: boolean;
    /**
     * Set whether copying members from the team is enabled.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneMembers?: boolean;
    /**
     * Set whether copying team settings from the team is enabled.
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneTeamSetting?: boolean;
    /**
     * Whether to enable the team privacy. (Currently not supported)
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneTeamPrivacy?: boolean;
    /**
     * Whether to enable the team classification. (Currently not supported)
     * @type {boolean}
     * @memberof TeamsTemplateSettings
     */
    enableCloneTeamClassification?: boolean;
}

export function TeamsTemplateSettingsFromJSON(json: any): TeamsTemplateSettings {
    return TeamsTemplateSettingsFromJSONTyped(json, false);
}

export function TeamsTemplateSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): TeamsTemplateSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableCreateTeamFromScratch': !exists(json, 'enableCreateTeamFromScratch') ? undefined : json['enableCreateTeamFromScratch'],
        'enableCreateTeamFromExistTeam': !exists(json, 'enableCreateTeamFromExistTeam') ? undefined : json['enableCreateTeamFromExistTeam'],
        'enableCreateTeamFromTeamTemplate': !exists(json, 'enableCreateTeamFromTeamTemplate') ? undefined : json['enableCreateTeamFromTeamTemplate'],
        'selectedTemplate': !exists(json, 'selectedTemplate') ? undefined : GuidModelFromJSON(json['selectedTemplate']),
        'selectedMSTemplate': !exists(json, 'selectedMSTemplate') ? undefined : StringModelFromJSON(json['selectedMSTemplate']),
        'teamTemplates': !exists(json, 'teamTemplates') ? undefined : (json['teamTemplates'] === null ? null : (json['teamTemplates'] as Array<any>).map(TextModelFromJSON)),
        'enableCloneChannels': !exists(json, 'enableCloneChannels') ? undefined : json['enableCloneChannels'],
        'enableCloneApps': !exists(json, 'enableCloneApps') ? undefined : json['enableCloneApps'],
        'enableCloneTabs': !exists(json, 'enableCloneTabs') ? undefined : json['enableCloneTabs'],
        'enableCloneMembers': !exists(json, 'enableCloneMembers') ? undefined : json['enableCloneMembers'],
        'enableCloneTeamSetting': !exists(json, 'enableCloneTeamSetting') ? undefined : json['enableCloneTeamSetting'],
        'enableCloneTeamPrivacy': !exists(json, 'enableCloneTeamPrivacy') ? undefined : json['enableCloneTeamPrivacy'],
        'enableCloneTeamClassification': !exists(json, 'enableCloneTeamClassification') ? undefined : json['enableCloneTeamClassification'],
    };
}

export function TeamsTemplateSettingsToJSON(value?: TeamsTemplateSettings | null): any {
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
        'selectedTemplate': GuidModelToJSON(value.selectedTemplate),
        'selectedMSTemplate': StringModelToJSON(value.selectedMSTemplate),
        'teamTemplates': value.teamTemplates === undefined ? undefined : (value.teamTemplates === null ? null : (value.teamTemplates as Array<any>).map(TextModelToJSON)),
        'enableCloneChannels': value.enableCloneChannels,
        'enableCloneApps': value.enableCloneApps,
        'enableCloneTabs': value.enableCloneTabs,
        'enableCloneMembers': value.enableCloneMembers,
        'enableCloneTeamSetting': value.enableCloneTeamSetting,
        'enableCloneTeamPrivacy': value.enableCloneTeamPrivacy,
        'enableCloneTeamClassification': value.enableCloneTeamClassification,
    };
}


