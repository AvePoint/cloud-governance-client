/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    GuidModel,
    GuidModelFromJSON,
    GuidModelFromJSONTyped,
    GuidModelToJSON,
} from './';

/**
 * Value of Managed metadata metadata.
 * @export
 * @interface TermsValue
 */
export interface TermsValue {
    /**
     * Id and name of term store.
     * @type {GuidModel}
     * @memberof TermsValue
     */
    readonly termStore?: GuidModel | null;
    /**
     * Id and name of term group.
     * @type {GuidModel}
     * @memberof TermsValue
     */
    readonly termGroup?: GuidModel | null;
    /**
     * Id and name of term set.
     * @type {GuidModel}
     * @memberof TermsValue
     */
    readonly termSet?: GuidModel | null;
    /**
     * Id and name collection of terms.
     * @type {Array<GuidModel>}
     * @memberof TermsValue
     */
    value?: Array<GuidModel> | null;
}

export function TermsValueFromJSON(json: any): TermsValue {
    return TermsValueFromJSONTyped(json, false);
}

export function TermsValueFromJSONTyped(json: any, ignoreDiscriminator: boolean): TermsValue {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'termStore': !exists(json, 'termStore') ? undefined : GuidModelFromJSON(json['termStore']),
        'termGroup': !exists(json, 'termGroup') ? undefined : GuidModelFromJSON(json['termGroup']),
        'termSet': !exists(json, 'termSet') ? undefined : GuidModelFromJSON(json['termSet']),
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(GuidModelFromJSON)),
    };
}

export function TermsValueToJSON(value?: TermsValue | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(GuidModelToJSON)),
    };
}


