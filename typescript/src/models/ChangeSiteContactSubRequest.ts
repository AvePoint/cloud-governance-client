/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiRequestProgressStatus,
    ApiRequestProgressStatusFromJSON,
    ApiRequestProgressStatusFromJSONTyped,
    ApiRequestProgressStatusToJSON,
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    ChangeContactByUrlSetting,
    ChangeContactByUrlSettingFromJSON,
    ChangeContactByUrlSettingFromJSONTyped,
    ChangeContactByUrlSettingToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeSiteContactSubRequest
 */
export interface ChangeSiteContactSubRequest {
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactSubRequest
     */
    id?: string;
    /**
     * 
     * @type {Array<ApiUser>}
     * @memberof ChangeSiteContactSubRequest
     */
    assignTo?: Array<ApiUser> | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactSubRequest
     */
    reason?: string | null;
    /**
     * 
     * @type {number}
     * @memberof ChangeSiteContactSubRequest
     */
    readonly status?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeSiteContactSubRequest
     */
    readonly statusDescription?: string | null;
    /**
     * 
     * @type {ChangeContactByUrlSetting}
     * @memberof ChangeSiteContactSubRequest
     */
    adminContactSettings?: ChangeContactByUrlSetting | null;
    /**
     * 
     * @type {ApiRequestProgressStatus}
     * @memberof ChangeSiteContactSubRequest
     */
    readonly progressStatus?: ApiRequestProgressStatus;
}

export function ChangeSiteContactSubRequestFromJSON(json: any): ChangeSiteContactSubRequest {
    return ChangeSiteContactSubRequestFromJSONTyped(json, false);
}

export function ChangeSiteContactSubRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeSiteContactSubRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'assignTo': !exists(json, 'assignTo') ? undefined : (json['assignTo'] === null ? null : (json['assignTo'] as Array<any>).map(ApiUserFromJSON)),
        'reason': !exists(json, 'reason') ? undefined : json['reason'],
        'status': !exists(json, 'status') ? undefined : json['status'],
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'adminContactSettings': !exists(json, 'adminContactSettings') ? undefined : ChangeContactByUrlSettingFromJSON(json['adminContactSettings']),
        'progressStatus': !exists(json, 'progressStatus') ? undefined : ApiRequestProgressStatusFromJSON(json['progressStatus']),
    };
}

export function ChangeSiteContactSubRequestToJSON(value?: ChangeSiteContactSubRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'assignTo': value.assignTo === undefined ? undefined : (value.assignTo === null ? null : (value.assignTo as Array<any>).map(ApiUserToJSON)),
        'reason': value.reason,
        'adminContactSettings': ChangeContactByUrlSettingToJSON(value.adminContactSettings),
    };
}


