/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ContentMoveAction,
    ContentMoveActionFromJSON,
    ContentMoveActionFromJSONTyped,
    ContentMoveActionToJSON,
    ContentMoveSPObject,
    ContentMoveSPObjectFromJSON,
    ContentMoveSPObjectFromJSONTyped,
    ContentMoveSPObjectToJSON,
} from './';

/**
 * 
 * @export
 * @interface ContentMoveSPObjectMapping
 */
export interface ContentMoveSPObjectMapping {
    /**
     * 
     * @type {ContentMoveSPObject}
     * @memberof ContentMoveSPObjectMapping
     */
    source?: ContentMoveSPObject | null;
    /**
     * 
     * @type {ContentMoveSPObject}
     * @memberof ContentMoveSPObjectMapping
     */
    destination?: ContentMoveSPObject | null;
    /**
     * 
     * @type {ContentMoveAction}
     * @memberof ContentMoveSPObjectMapping
     */
    action?: ContentMoveAction;
}

export function ContentMoveSPObjectMappingFromJSON(json: any): ContentMoveSPObjectMapping {
    return ContentMoveSPObjectMappingFromJSONTyped(json, false);
}

export function ContentMoveSPObjectMappingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContentMoveSPObjectMapping {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'source': !exists(json, 'source') ? undefined : ContentMoveSPObjectFromJSON(json['source']),
        'destination': !exists(json, 'destination') ? undefined : ContentMoveSPObjectFromJSON(json['destination']),
        'action': !exists(json, 'action') ? undefined : ContentMoveActionFromJSON(json['action']),
    };
}

export function ContentMoveSPObjectMappingToJSON(value?: ContentMoveSPObjectMapping | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'source': ContentMoveSPObjectToJSON(value.source),
        'destination': ContentMoveSPObjectToJSON(value.destination),
        'action': ContentMoveActionToJSON(value.action),
    };
}


