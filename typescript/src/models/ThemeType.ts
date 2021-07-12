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
export enum ThemeType {
    None = 0,
    NavyBlue = 1,
    LightBlack = 2,
    LightBlue = 3,
    Orange = 4,
    GrassGreen = 5,
    Pink = 6,
    EmeraldGreen = 7,
    Lilac = 8
}

export function ThemeTypeFromJSON(json: any): ThemeType {
    return ThemeTypeFromJSONTyped(json, false);
}

export function ThemeTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ThemeType {
    return json as ThemeType;
}

export function ThemeTypeToJSON(value?: ThemeType | null): any {
    return value as any;
}

