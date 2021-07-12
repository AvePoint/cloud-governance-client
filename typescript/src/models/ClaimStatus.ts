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
export enum ClaimStatus {
    Unclaimed = 0,
    Claiming = 1,
    Claimed = 2,
    Failed = 3,
    Overdue = 4
}

export function ClaimStatusFromJSON(json: any): ClaimStatus {
    return ClaimStatusFromJSONTyped(json, false);
}

export function ClaimStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): ClaimStatus {
    return json as ClaimStatus;
}

export function ClaimStatusToJSON(value?: ClaimStatus | null): any {
    return value as any;
}

