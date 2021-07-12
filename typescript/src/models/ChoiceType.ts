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
export enum ChoiceType {
    DropDown = 1,
    RadioButton = 2,
    CheckBoxes = 3
}

export function ChoiceTypeFromJSON(json: any): ChoiceType {
    return ChoiceTypeFromJSONTyped(json, false);
}

export function ChoiceTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChoiceType {
    return json as ChoiceType;
}

export function ChoiceTypeToJSON(value?: ChoiceType | null): any {
    return value as any;
}

