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
export enum PrincipalType {
    None = 0,
    User = 1,
    DistributionList = 2,
    Office365Group = 4,
    SharePointGroup = 8,
    Guest = 16,
    SecurityGroupOnly = 32,
    MailEnabledSecurityGroup = 64,
    SecurityGroup = 100,
    All = 111
}

export function PrincipalTypeFromJSON(json: any): PrincipalType {
    return PrincipalTypeFromJSONTyped(json, false);
}

export function PrincipalTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): PrincipalType {
    return json as PrincipalType;
}

export function PrincipalTypeToJSON(value?: PrincipalType | null): any {
    return value as any;
}

