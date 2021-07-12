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
export enum ContentMoveMethod {
    Copy = 0,
    Move = 1
}

export function ContentMoveMethodFromJSON(json: any): ContentMoveMethod {
    return ContentMoveMethodFromJSONTyped(json, false);
}

export function ContentMoveMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveMethod {
    return json as ContentMoveMethod;
}

export function ContentMoveMethodToJSON(value?: ContentMoveMethod | null): any {
    return value as any;
}

