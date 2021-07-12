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
export enum ExpirationType {
    Duration = 0,
    Date = 1
}

export function ExpirationTypeFromJSON(json: any): ExpirationType {
    return ExpirationTypeFromJSONTyped(json, false);
}

export function ExpirationTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExpirationType {
    return json as ExpirationType;
}

export function ExpirationTypeToJSON(value?: ExpirationType | null): any {
    return value as any;
}

