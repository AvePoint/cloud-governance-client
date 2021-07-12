/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * Group links model
 * @export
 * @interface GroupLinks
 */
export interface GroupLinks {
    /**
     * Group team site link
     * @type {string}
     * @memberof GroupLinks
     */
    groupSiteLink?: string | null;
    /**
     * Planner link
     * @type {string}
     * @memberof GroupLinks
     */
    groupPlannerLink?: string | null;
    /**
     * Files link
     * @type {string}
     * @memberof GroupLinks
     */
    groupFilesLink?: string | null;
    /**
     * Conversations link
     * @type {string}
     * @memberof GroupLinks
     */
    groupConversationsLink?: string | null;
    /**
     * Notebook link
     * @type {string}
     * @memberof GroupLinks
     */
    groupNotebookLink?: string | null;
    /**
     * Yammer community link
     * @type {string}
     * @memberof GroupLinks
     */
    yammerGroupLink?: string | null;
}

export function GroupLinksFromJSON(json: any): GroupLinks {
    return GroupLinksFromJSONTyped(json, false);
}

export function GroupLinksFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupLinks {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'groupSiteLink': !exists(json, 'groupSiteLink') ? undefined : json['groupSiteLink'],
        'groupPlannerLink': !exists(json, 'groupPlannerLink') ? undefined : json['groupPlannerLink'],
        'groupFilesLink': !exists(json, 'groupFilesLink') ? undefined : json['groupFilesLink'],
        'groupConversationsLink': !exists(json, 'groupConversationsLink') ? undefined : json['groupConversationsLink'],
        'groupNotebookLink': !exists(json, 'groupNotebookLink') ? undefined : json['groupNotebookLink'],
        'yammerGroupLink': !exists(json, 'yammerGroupLink') ? undefined : json['yammerGroupLink'],
    };
}

export function GroupLinksToJSON(value?: GroupLinks | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'groupSiteLink': value.groupSiteLink,
        'groupPlannerLink': value.groupPlannerLink,
        'groupFilesLink': value.groupFilesLink,
        'groupConversationsLink': value.groupConversationsLink,
        'groupNotebookLink': value.groupNotebookLink,
        'yammerGroupLink': value.yammerGroupLink,
    };
}


