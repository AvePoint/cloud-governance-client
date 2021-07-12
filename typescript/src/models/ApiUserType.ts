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
export enum ApiUserType {
    User = 1,
    DistributionList = 2,
    Office365Group = 4,
    SharePointGroup = 8,
    Guest = 16,
    SecurityGroupOnly = 32,
    MailEnabledSecurityGroup = 64,
    Group = 100,
    UserAndGroup = 101,
    All = 111
}

export function ApiUserTypeFromJSON(json: any): ApiUserType {
    return ApiUserTypeFromJSONTyped(json, false);
}

export function ApiUserTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ApiUserType {
    return json as ApiUserType;
}

export function ApiUserTypeToJSON(value?: ApiUserType | null): any {
    return value as any;
}

