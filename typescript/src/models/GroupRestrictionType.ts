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
export enum GroupRestrictionType {
    AnyGroup = 0,
    PartOf = 1
}

export function GroupRestrictionTypeFromJSON(json: any): GroupRestrictionType {
    return GroupRestrictionTypeFromJSONTyped(json, false);
}

export function GroupRestrictionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): GroupRestrictionType {
    return json as GroupRestrictionType;
}

export function GroupRestrictionTypeToJSON(value?: GroupRestrictionType | null): any {
    return value as any;
}

