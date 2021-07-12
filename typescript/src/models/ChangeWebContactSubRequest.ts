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
    ChangeWebContactByUrlSetting,
    ChangeWebContactByUrlSettingFromJSON,
    ChangeWebContactByUrlSettingFromJSONTyped,
    ChangeWebContactByUrlSettingToJSON,
} from './';

/**
 * 
 * @export
 * @interface ChangeWebContactSubRequest
 */
export interface ChangeWebContactSubRequest {
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactSubRequest
     */
    id?: string;
    /**
     * ApiUser model
     * @type {ApiUser}
     * @memberof ChangeWebContactSubRequest
     */
    assignTo?: ApiUser | null;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactSubRequest
     */
    reason?: string | null;
    /**
     * 
     * @type {number}
     * @memberof ChangeWebContactSubRequest
     */
    readonly status?: number;
    /**
     * 
     * @type {string}
     * @memberof ChangeWebContactSubRequest
     */
    statusDescription?: string | null;
    /**
     * 
     * @type {ApiRequestProgressStatus}
     * @memberof ChangeWebContactSubRequest
     */
    readonly progressStatus?: ApiRequestProgressStatus;
    /**
     * 
     * @type {ChangeWebContactByUrlSetting}
     * @memberof ChangeWebContactSubRequest
     */
    contactChangeSettings?: ChangeWebContactByUrlSetting | null;
}

export function ChangeWebContactSubRequestFromJSON(json: any): ChangeWebContactSubRequest {
    return ChangeWebContactSubRequestFromJSONTyped(json, false);
}

export function ChangeWebContactSubRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): ChangeWebContactSubRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'assignTo': !exists(json, 'assignTo') ? undefined : ApiUserFromJSON(json['assignTo']),
        'reason': !exists(json, 'reason') ? undefined : json['reason'],
        'status': !exists(json, 'status') ? undefined : json['status'],
        'statusDescription': !exists(json, 'statusDescription') ? undefined : json['statusDescription'],
        'progressStatus': !exists(json, 'progressStatus') ? undefined : ApiRequestProgressStatusFromJSON(json['progressStatus']),
        'contactChangeSettings': !exists(json, 'contactChangeSettings') ? undefined : ChangeWebContactByUrlSettingFromJSON(json['contactChangeSettings']),
    };
}

export function ChangeWebContactSubRequestToJSON(value?: ChangeWebContactSubRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'assignTo': ApiUserToJSON(value.assignTo),
        'reason': value.reason,
        'statusDescription': value.statusDescription,
        'contactChangeSettings': ChangeWebContactByUrlSettingToJSON(value.contactChangeSettings),
    };
}


