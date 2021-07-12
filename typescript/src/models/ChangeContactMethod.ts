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
export enum ChangeContactMethod {
    ChangeByUrl = 0,
    ChangeByUser = 1
}

export function ChangeContactMethodFromJSON(json: any): ChangeContactMethod {
    return ChangeContactMethodFromJSONTyped(json, false);
}

export function ChangeContactMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeContactMethod {
    return json as ChangeContactMethod;
}

export function ChangeContactMethodToJSON(value?: ChangeContactMethod | null): any {
    return value as any;
}

