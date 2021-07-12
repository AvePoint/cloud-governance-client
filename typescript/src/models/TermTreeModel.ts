/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface TermTreeModel
 */
export interface TermTreeModel {
    /**
     * 
     * @type {string}
     * @memberof TermTreeModel
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TermTreeModel
     */
    id?: string;
    /**
     * 
     * @type {TermTreeModel}
     * @memberof TermTreeModel
     */
    child?: TermTreeModel | null;
}

export function TermTreeModelFromJSON(json: any): TermTreeModel {
    return TermTreeModelFromJSONTyped(json, false);
}

export function TermTreeModelFromJSONTyped(json: any, ignoreDiscriminator: boolean): TermTreeModel {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'name': !exists(json, 'name') ? undefined : json['name'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'child': !exists(json, 'child') ? undefined : TermTreeModelFromJSON(json['child']),
    };
}

export function TermTreeModelToJSON(value?: TermTreeModel | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'name': value.name,
        'id': value.id,
        'child': TermTreeModelToJSON(value.child),
    };
}


