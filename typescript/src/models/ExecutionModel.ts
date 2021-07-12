/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ExecutionParameter,
    ExecutionParameterFromJSON,
    ExecutionParameterFromJSONTyped,
    ExecutionParameterToJSON,
    WebServiceAuthenticationType,
    WebServiceAuthenticationTypeFromJSON,
    WebServiceAuthenticationTypeFromJSONTyped,
    WebServiceAuthenticationTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ExecutionModel
 */
export interface ExecutionModel {
    /**
     * 
     * @type {boolean}
     * @memberof ExecutionModel
     */
    enabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ExecutionModel
     */
    webServiceAddress?: string | null;
    /**
     * 
     * @type {WebServiceAuthenticationType}
     * @memberof ExecutionModel
     */
    webServiceAuthenticationType?: WebServiceAuthenticationType;
    /**
     * 
     * @type {string}
     * @memberof ExecutionModel
     */
    webServiceAppClientId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ExecutionModel
     */
    methodName?: string | null;
    /**
     * 
     * @type {Array<ExecutionParameter>}
     * @memberof ExecutionModel
     */
    arguments?: Array<ExecutionParameter> | null;
}

export function ExecutionModelFromJSON(json: any): ExecutionModel {
    return ExecutionModelFromJSONTyped(json, false);
}

export function ExecutionModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExecutionModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'webServiceAddress': !exists(json, 'webServiceAddress') ? undefined : json['webServiceAddress'],
        'webServiceAuthenticationType': !exists(json, 'webServiceAuthenticationType') ? undefined : WebServiceAuthenticationTypeFromJSON(json['webServiceAuthenticationType']),
        'webServiceAppClientId': !exists(json, 'webServiceAppClientId') ? undefined : json['webServiceAppClientId'],
        'methodName': !exists(json, 'methodName') ? undefined : json['methodName'],
        'arguments': !exists(json, 'arguments') ? undefined : (json['arguments'] === null ? null : (json['arguments'] as Array<any>).map(ExecutionParameterFromJSON)),
    };
}

export function ExecutionModelToJSON(value?: ExecutionModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'webServiceAddress': value.webServiceAddress,
        'webServiceAuthenticationType': WebServiceAuthenticationTypeToJSON(value.webServiceAuthenticationType),
        'webServiceAppClientId': value.webServiceAppClientId,
        'methodName': value.methodName,
        'arguments': value.arguments === undefined ? undefined : (value.arguments === null ? null : (value.arguments as Array<any>).map(ExecutionParameterToJSON)),
    };
}


