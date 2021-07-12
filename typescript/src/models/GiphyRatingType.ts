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
export enum GiphyRatingType {
    Moderate = 0,
    Strict = 1
}

export function GiphyRatingTypeFromJSON(json: any): GiphyRatingType {
    return GiphyRatingTypeFromJSONTyped(json, false);
}

export function GiphyRatingTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GiphyRatingType {
    return json as GiphyRatingType;
}

export function GiphyRatingTypeToJSON(value?: GiphyRatingType | null): any {
    return value as any;
}

