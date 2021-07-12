/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

/**
 * 
 * @export
 * @enum {string}
 */
export enum ContentMoveAction {
    Merge = 0,
    Attach = 1
}

export function ContentMoveActionFromJSON(json: any): ContentMoveAction {
    return ContentMoveActionFromJSONTyped(json, false);
}

export function ContentMoveActionFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveAction {
    return json as ContentMoveAction;
}

export function ContentMoveActionToJSON(value?: ContentMoveAction | null): any {
    return value as any;
}

