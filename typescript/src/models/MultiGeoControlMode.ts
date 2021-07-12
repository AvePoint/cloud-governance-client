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
export enum MultiGeoControlMode {
    None = 0,
    SpecifiedDirectly = 1,
    SpecifiedByRole = 2
}

export function MultiGeoControlModeFromJSON(json: any): MultiGeoControlMode {
    return MultiGeoControlModeFromJSONTyped(json, false);
}

export function MultiGeoControlModeFromJSONTyped(json: any, ignoreDiscriminator: boolean): MultiGeoControlMode {
    return json as MultiGeoControlMode;
}

export function MultiGeoControlModeToJSON(value?: MultiGeoControlMode | null): any {
    return value as any;
}

