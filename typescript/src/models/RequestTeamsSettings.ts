/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GiphyRatingType,
    GiphyRatingTypeFromJSON,
    GiphyRatingTypeFromJSONTyped,
    GiphyRatingTypeToJSON,
} from './';

/**
 * Teams settings model in request
 * @export
 * @interface RequestTeamsSettings
 */
export interface RequestTeamsSettings {
    /**
     * Whether to allow team members to create and update channels.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersCreateUpdateChannels?: boolean;
    /**
     * Whether to allow members to create private channels.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersCreatePrivateChannels?: boolean;
    /**
     * Whether to allow members to delete and restore channels.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMemberDeleteRestoreChannels?: boolean;
    /**
     * Whether to allow members to add and remove apps.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersAddRemoveApps?: boolean;
    /**
     * Whether to allow members to create, update, and remove tabs.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersCreateUpdateRemoveTabs?: boolean;
    /**
     * Whether to allow members to create, update, and remove connectors.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersCreateUpdateRemoveConnections?: boolean;
    /**
     * Whether to allow members to delete their messages.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersDeleteMessages?: boolean;
    /**
     * Whether to allow members to edit their messages.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMembersEditMessages?: boolean;
    /**
     * Whether to allow guests to create and update channels.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowGuestsCreateUpdateChannels?: boolean;
    /**
     * Whether to allow guests to delete channels.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowGuestsDeleteChannels?: boolean;
    /**
     * Whether to show members the option to @team or @[team name] (this will send a notification to everyone on the team).
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMentionsTeam?: boolean;
    /**
     * Whether to show members the option to @channel or @[channel name] (this will send a notification to everyone who has favorited the channel being mentioned).
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    allowMentionsChannel?: boolean;
    /**
     * Whether to enable giphy for the team.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    enableGiphy?: boolean;
    /**
     * Whether to enable stickers and memes.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    enableStickersAndMemes?: boolean;
    /**
     * Whether to allow memes to be uploaded.
     * @type {boolean}
     * @memberof RequestTeamsSettings
     */
    enableCustomMemes?: boolean;
    /**
     * Set the gihpy type settings.
     * @type {GiphyRatingType}
     * @memberof RequestTeamsSettings
     */
    giphyRatingType?: GiphyRatingType;
}

export function RequestTeamsSettingsFromJSON(json: any): RequestTeamsSettings {
    return RequestTeamsSettingsFromJSONTyped(json, false);
}

export function RequestTeamsSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestTeamsSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
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

export function RequestTeamsSettingsToJSON(value?: RequestTeamsSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
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


