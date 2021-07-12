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
export enum AuthenticationType {
    LocalSystem = 0,
    WindowsIntegration = 1,
    ADIntegration = 2,
    ADFSIntegration = 3,
    Federation = 4,
    SharePointOnline = 6,
    SalesForce = 7,
    Yammer = 8,
    AzureAD = 9,
    Sandbox = 10,
    SharePoint = 11,
    Exchange = 12
}

export function AuthenticationTypeFromJSON(json: any): AuthenticationType {
    return AuthenticationTypeFromJSONTyped(json, false);
}

export function AuthenticationTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): AuthenticationType {
    return json as AuthenticationType;
}

export function AuthenticationTypeToJSON(value?: AuthenticationType | null): any {
    return value as any;
}

