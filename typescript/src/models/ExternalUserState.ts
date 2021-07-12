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
export enum ExternalUserState {
    PendingAcceptance = 0,
    Accepted = 1
}

export function ExternalUserStateFromJSON(json: any): ExternalUserState {
    return ExternalUserStateFromJSONTyped(json, false);
}

export function ExternalUserStateFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExternalUserState {
    return json as ExternalUserState;
}

export function ExternalUserStateToJSON(value?: ExternalUserState | null): any {
    return value as any;
}

