/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ServiceType,
    ServiceTypeFromJSON,
    ServiceTypeFromJSONTyped,
    ServiceTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface ServiceList
 */
export interface ServiceList {
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    category?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    contact?: string | null;
    /**
     * 
     * @type {number}
     * @memberof ServiceList
     */
    languageId?: number;
    /**
     * 
     * @type {ServiceType}
     * @memberof ServiceList
     */
    type?: ServiceType;
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    typeDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof ServiceList
     */
    isQuestionnaire?: boolean;
    /**
     * 
     * @type {string}
     * @memberof ServiceList
     */
    questionnaireId?: string | null;
}

export function ServiceListFromJSON(json: any): ServiceList {
    return ServiceListFromJSONTyped(json, false);
}

export function ServiceListFromJSONTyped(json: any, ignoreDiscriminator: boolean): ServiceList {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'category': !exists(json, 'category') ? undefined : json['category'],
        'contact': !exists(json, 'contact') ? undefined : json['contact'],
        'languageId': !exists(json, 'languageId') ? undefined : json['languageId'],
        'type': !exists(json, 'type') ? undefined : ServiceTypeFromJSON(json['type']),
        'typeDescription': !exists(json, 'typeDescription') ? undefined : json['typeDescription'],
        'isQuestionnaire': !exists(json, 'isQuestionnaire') ? undefined : json['isQuestionnaire'],
        'questionnaireId': !exists(json, 'questionnaireId') ? undefined : json['questionnaireId'],
    };
}

export function ServiceListToJSON(value?: ServiceList | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'description': value.description,
        'category': value.category,
        'contact': value.contact,
        'languageId': value.languageId,
        'type': ServiceTypeToJSON(value.type),
        'typeDescription': value.typeDescription,
        'isQuestionnaire': value.isQuestionnaire,
        'questionnaireId': value.questionnaireId,
    };
}


