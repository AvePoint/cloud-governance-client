/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface TaskComment
 */
export interface TaskComment {
    /**
     * 
     * @type {string}
     * @memberof TaskComment
     */
    assigneeDisplayName?: string | null;
    /**
     * 
     * @type {Date}
     * @memberof TaskComment
     */
    commentTime?: Date;
    /**
     * 
     * @type {string}
     * @memberof TaskComment
     */
    content?: string | null;
}

export function TaskCommentFromJSON(json: any): TaskComment {
    return TaskCommentFromJSONTyped(json, false);
}

export function TaskCommentFromJSONTyped(json: any, ignoreDiscriminator: boolean): TaskComment {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'assigneeDisplayName': !exists(json, 'assigneeDisplayName') ? undefined : json['assigneeDisplayName'],
        'commentTime': !exists(json, 'commentTime') ? undefined : (new Date(json['commentTime'])),
        'content': !exists(json, 'content') ? undefined : json['content'],
    };
}

export function TaskCommentToJSON(value?: TaskComment | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'assigneeDisplayName': value.assigneeDisplayName,
        'commentTime': value.commentTime === undefined ? undefined : (value.commentTime.toISOString()),
        'content': value.content,
    };
}


