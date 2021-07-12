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
export enum LogicalOperator {
    And = 0,
    Or = 1
}

export function LogicalOperatorFromJSON(json: any): LogicalOperator {
    return LogicalOperatorFromJSONTyped(json, false);
}

export function LogicalOperatorFromJSONTyped(json: any, ignoreDiscriminator: boolean): LogicalOperator {
    return json as LogicalOperator;
}

export function LogicalOperatorToJSON(value?: LogicalOperator | null): any {
    return value as any;
}

