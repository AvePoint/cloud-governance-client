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
export enum DisplayInReportType {
    Hide = 1,
    DisplayInAllPlaces = 2,
    OnlyDisplayInAdminReport = 3
}

export function DisplayInReportTypeFromJSON(json: any): DisplayInReportType {
    return DisplayInReportTypeFromJSONTyped(json, false);
}

export function DisplayInReportTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): DisplayInReportType {
    return json as DisplayInReportType;
}

export function DisplayInReportTypeToJSON(value?: DisplayInReportType | null): any {
    return value as any;
}

