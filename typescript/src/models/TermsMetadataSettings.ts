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
    TermTreeModel,
    TermTreeModelFromJSON,
    TermTreeModelFromJSONTyped,
    TermTreeModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface TermsMetadataSettings
 */
export interface TermsMetadataSettings {
    /**
     * 
     * @type {boolean}
     * @memberof TermsMetadataSettings
     */
    allowMultiple?: boolean;
    /**
     * 
     * @type {string}
     * @memberof TermsMetadataSettings
     */
    adminCenter?: string | null;
    /**
     * 
     * @type {Array<GuidModel>}
     * @memberof TermsMetadataSettings
     */
    value?: Array<GuidModel> | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof TermsMetadataSettings
     */
    termStore?: GuidModel | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof TermsMetadataSettings
     */
    termGroup?: GuidModel | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof TermsMetadataSettings
     */
    termSet?: GuidModel | null;
    /**
     * 
     * @type {GuidModel}
     * @memberof TermsMetadataSettings
     */
    scope?: GuidModel | null;
    /**
     * 
     * @type {TermTreeModel}
     * @memberof TermsMetadataSettings
     */
    tree?: TermTreeModel | null;
    /**
     * 
     * @type {boolean}
     * @memberof TermsMetadataSettings
     */
    isValid?: boolean;
}

export function TermsMetadataSettingsFromJSON(json: any): TermsMetadataSettings {
    return TermsMetadataSettingsFromJSONTyped(json, false);
}

export function TermsMetadataSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): TermsMetadataSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'allowMultiple': !exists(json, 'allowMultiple') ? undefined : json['allowMultiple'],
        'adminCenter': !exists(json, 'adminCenter') ? undefined : json['adminCenter'],
        'value': !exists(json, 'value') ? undefined : (json['value'] === null ? null : (json['value'] as Array<any>).map(GuidModelFromJSON)),
        'termStore': !exists(json, 'termStore') ? undefined : GuidModelFromJSON(json['termStore']),
        'termGroup': !exists(json, 'termGroup') ? undefined : GuidModelFromJSON(json['termGroup']),
        'termSet': !exists(json, 'termSet') ? undefined : GuidModelFromJSON(json['termSet']),
        'scope': !exists(json, 'scope') ? undefined : GuidModelFromJSON(json['scope']),
        'tree': !exists(json, 'tree') ? undefined : TermTreeModelFromJSON(json['tree']),
        'isValid': !exists(json, 'isValid') ? undefined : json['isValid'],
    };
}

export function TermsMetadataSettingsToJSON(value?: TermsMetadataSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'allowMultiple': value.allowMultiple,
        'adminCenter': value.adminCenter,
        'value': value.value === undefined ? undefined : (value.value === null ? null : (value.value as Array<any>).map(GuidModelToJSON)),
        'termStore': GuidModelToJSON(value.termStore),
        'termGroup': GuidModelToJSON(value.termGroup),
        'termSet': GuidModelToJSON(value.termSet),
        'scope': GuidModelToJSON(value.scope),
        'tree': TermTreeModelToJSON(value.tree),
        'isValid': value.isValid,
    };
}


