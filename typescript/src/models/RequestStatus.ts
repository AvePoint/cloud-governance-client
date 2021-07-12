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
export enum RequestStatus {
    Saved = 0,
    Submitted = 1
}

export function RequestStatusFromJSON(json: any): RequestStatus {
    return RequestStatusFromJSONTyped(json, false);
}

export function RequestStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestStatus {
    return json as RequestStatus;
}

export function RequestStatusToJSON(value?: RequestStatus | null): any {
    return value as any;
}

