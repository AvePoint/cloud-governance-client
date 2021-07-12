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
export enum WebServiceAuthenticationType {
    Anonymous = 0,
    AzureAD = 1
}

export function WebServiceAuthenticationTypeFromJSON(json: any): WebServiceAuthenticationType {
    return WebServiceAuthenticationTypeFromJSONTyped(json, false);
}

export function WebServiceAuthenticationTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): WebServiceAuthenticationType {
    return json as WebServiceAuthenticationType;
}

export function WebServiceAuthenticationTypeToJSON(value?: WebServiceAuthenticationType | null): any {
    return value as any;
}

