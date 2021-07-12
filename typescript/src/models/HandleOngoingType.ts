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
export enum HandleOngoingType {
    None = 0,
    Skip = 1,
    CancelOngoing = 2
}

export function HandleOngoingTypeFromJSON(json: any): HandleOngoingType {
    return HandleOngoingTypeFromJSONTyped(json, false);
}

export function HandleOngoingTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): HandleOngoingType {
    return json as HandleOngoingType;
}

export function HandleOngoingTypeToJSON(value?: HandleOngoingType | null): any {
    return value as any;
}

