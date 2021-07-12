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
export enum ApplyPolicyStatus {
    None = 0,
    Applying = 1,
    Waiting = 2,
    Succeed = 3,
    Failed = 4
}

export function ApplyPolicyStatusFromJSON(json: any): ApplyPolicyStatus {
    return ApplyPolicyStatusFromJSONTyped(json, false);
}

export function ApplyPolicyStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApplyPolicyStatus {
    return json as ApplyPolicyStatus;
}

export function ApplyPolicyStatusToJSON(value?: ApplyPolicyStatus | null): any {
    return value as any;
}

