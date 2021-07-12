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
    GiphyRatingType,
    GiphyRatingTypeFromJSON,
    GiphyRatingTypeFromJSONTyped,
    GiphyRatingTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceTeamsSettings
 */
export interface ServiceTeamsSettings {
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceTeamsSettings
     */
    memberPermissionsAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceTeamsSettings
     */
    guestPermissionsAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceTeamsSettings
     */
    mentionsAssignBy?: AssignBy;
    /**
     * 
     * @type {AssignBy}
     * @memberof ServiceTeamsSettings
     */
    funStuffAssignBy?: AssignBy;
    /**
     * Whether to allow team members to create and update channels.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersCreateUpdateChannels?: boolean;
    /**
     * Whether to allow members to create private channels.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersCreatePrivateChannels?: boolean;
    /**
     * Whether to allow members to delete and restore channels.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMemberDeleteRestoreChannels?: boolean;
    /**
     * Whether to allow members to add and remove apps.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersAddRemoveApps?: boolean;
    /**
     * Whether to allow members to create, update, and remove tabs.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersCreateUpdateRemoveTabs?: boolean;
    /**
     * Whether to allow members to create, update, and remove connectors.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersCreateUpdateRemoveConnections?: boolean;
    /**
     * Whether to allow members to delete their messages.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersDeleteMessages?: boolean;
    /**
     * Whether to allow members to edit their messages.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMembersEditMessages?: boolean;
    /**
     * Whether to allow guests to create and update channels.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowGuestsCreateUpdateChannels?: boolean;
    /**
     * Whether to allow guests to delete channels.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowGuestsDeleteChannels?: boolean;
    /**
     * Whether to show members the option to @team or @[team name] (this will send a notification to everyone on the team).
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMentionsTeam?: boolean;
    /**
     * Whether to show members the option to @channel or @[channel name] (this will send a notification to everyone who has favorited the channel being mentioned).
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    allowMentionsChannel?: boolean;
    /**
     * Whether to enable giphy for the team.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    enableGiphy?: boolean;
    /**
     * Whether to enable stickers and memes.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    enableStickersAndMemes?: boolean;
    /**
     * Whether to allow memes to be uploaded.
     * @type {boolean}
     * @memberof ServiceTeamsSettings
     */
    enableCustomMemes?: boolean;
    /**
     * Set the gihpy type settings.
     * @type {GiphyRatingType}
     * @memberof ServiceTeamsSettings
     */
    giphyRatingType?: GiphyRatingType;
}

export function ServiceTeamsSettingsFromJSON(json: any): ServiceTeamsSettings {
    return ServiceTeamsSettingsFromJSONTyped(json, false);
}

export function ServiceTeamsSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceTeamsSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'memberPermissionsAssignBy': !exists(json, 'memberPermissionsAssignBy') ? undefined : AssignByFromJSON(json['memberPermissionsAssignBy']),
        'guestPermissionsAssignBy': !exists(json, 'guestPermissionsAssignBy') ? undefined : AssignByFromJSON(json['guestPermissionsAssignBy']),
        'mentionsAssignBy': !exists(json, 'mentionsAssignBy') ? undefined : AssignByFromJSON(json['mentionsAssignBy']),
        'funStuffAssignBy': !exists(json, 'funStuffAssignBy') ? undefined : AssignByFromJSON(json['funStuffAssignBy']),
        'allowMembersCreateUpdateChannels': !exists(json, 'allowMembersCreateUpdateChannels') ? undefined : json['allowMembersCreateUpdateChannels'],
        'allowMembersCreatePrivateChannels': !exists(json, 'allowMembersCreatePrivateChannels') ? undefined : json['allowMembersCreatePrivateChannels'],
        'allowMemberDeleteRestoreChannels': !exists(json, 'allowMemberDeleteRestoreChannels') ? undefined : json['allowMemberDeleteRestoreChannels'],
        'allowMembersAddRemoveApps': !exists(json, 'allowMembersAddRemoveApps') ? undefined : json['allowMembersAddRemoveApps'],
        'allowMembersCreateUpdateRemoveTabs': !exists(json, 'allowMembersCreateUpdateRemoveTabs') ? undefined : json['allowMembersCreateUpdateRemoveTabs'],
        'allowMembersCreateUpdateRemoveConnections': !exists(json, 'allowMembersCreateUpdateRemoveConnections') ? undefined : json['allowMembersCreateUpdateRemoveConnections'],
        'allowMembersDeleteMessages': !exists(json, 'allowMembersDeleteMessages') ? undefined : json['allowMembersDeleteMessages'],
        'allowMembersEditMessages': !exists(json, 'allowMembersEditMessages') ? undefined : json['allowMembersEditMessages'],
        'allowGuestsCreateUpdateChannels': !exists(json, 'allowGuestsCreateUpdateChannels') ? undefined : json['allowGuestsCreateUpdateChannels'],
        'allowGuestsDeleteChannels': !exists(json, 'allowGuestsDeleteChannels') ? undefined : json['allowGuestsDeleteChannels'],
        'allowMentionsTeam': !exists(json, 'allowMentionsTeam') ? undefined : json['allowMentionsTeam'],
        'allowMentionsChannel': !exists(json, 'allowMentionsChannel') ? undefined : json['allowMentionsChannel'],
        'enableGiphy': !exists(json, 'enableGiphy') ? undefined : json['enableGiphy'],
        'enableStickersAndMemes': !exists(json, 'enableStickersAndMemes') ? undefined : json['enableStickersAndMemes'],
        'enableCustomMemes': !exists(json, 'enableCustomMemes') ? undefined : json['enableCustomMemes'],
        'giphyRatingType': !exists(json, 'giphyRatingType') ? undefined : GiphyRatingTypeFromJSON(json['giphyRatingType']),
    };
}

export function ServiceTeamsSettingsToJSON(value?: ServiceTeamsSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'memberPermissionsAssignBy': AssignByToJSON(value.memberPermissionsAssignBy),
        'guestPermissionsAssignBy': AssignByToJSON(value.guestPermissionsAssignBy),
        'mentionsAssignBy': AssignByToJSON(value.mentionsAssignBy),
        'funStuffAssignBy': AssignByToJSON(value.funStuffAssignBy),
        'allowMembersCreateUpdateChannels': value.allowMembersCreateUpdateChannels,
        'allowMembersCreatePrivateChannels': value.allowMembersCreatePrivateChannels,
        'allowMemberDeleteRestoreChannels': value.allowMemberDeleteRestoreChannels,
        'allowMembersAddRemoveApps': value.allowMembersAddRemoveApps,
        'allowMembersCreateUpdateRemoveTabs': value.allowMembersCreateUpdateRemoveTabs,
        'allowMembersCreateUpdateRemoveConnections': value.allowMembersCreateUpdateRemoveConnections,
        'allowMembersDeleteMessages': value.allowMembersDeleteMessages,
        'allowMembersEditMessages': value.allowMembersEditMessages,
        'allowGuestsCreateUpdateChannels': value.allowGuestsCreateUpdateChannels,
        'allowGuestsDeleteChannels': value.allowGuestsDeleteChannels,
        'allowMentionsTeam': value.allowMentionsTeam,
        'allowMentionsChannel': value.allowMentionsChannel,
        'enableGiphy': value.enableGiphy,
        'enableStickersAndMemes': value.enableStickersAndMemes,
        'enableCustomMemes': value.enableCustomMemes,
        'giphyRatingType': GiphyRatingTypeToJSON(value.giphyRatingType),
    };
}


