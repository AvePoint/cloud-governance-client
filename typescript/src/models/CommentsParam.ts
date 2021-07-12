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
 * @interface CommentsParam
 */
export interface CommentsParam {
    /**
     * 
     * @type {string}
     * @memberof CommentsParam
     */
    comments?: string | null;
}

export function CommentsParamFromJSON(json: any): CommentsParam {
    return CommentsParamFromJSONTyped(json, false);
}

export function CommentsParamFromJSONTyped(json: any, ignoreDiscriminator: boolean): CommentsParam {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'comments': !exists(json, 'comments') ? undefined : json['comments'],
    };
}

export function CommentsParamToJSON(value?: CommentsParam | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'comments': value.comments,
    };
}


