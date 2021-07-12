/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiDurationType,
    ApiDurationTypeFromJSON,
    ApiDurationTypeFromJSONTyped,
    ApiDurationTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface BriefGroupPolicy
 */
export interface BriefGroupPolicy {
    /**
     * 
     * @type {string}
     * @memberof BriefGroupPolicy
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof BriefGroupPolicy
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof BriefGroupPolicy
     */
    description?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof BriefGroupPolicy
     */
    enableLeaseExpiration?: boolean;
    /**
     * 
     * @type {number}
     * @memberof BriefGroupPolicy
     */
    leaseExpiredInterval?: number;
    /**
     * 
     * @type {ApiDurationType}
     * @memberof BriefGroupPolicy
     */
    leaseExpiredIntervalType?: ApiDurationType;
    /**
     * 
     * @type {boolean}
     * @memberof BriefGroupPolicy
     */
    enableManageGroupSharing?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof BriefGroupPolicy
     */
    enableInviteAuthorizedGuestUser?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof BriefGroupPolicy
     */
    enableInviteGuestUser?: boolean;
}

export function BriefGroupPolicyFromJSON(json: any): BriefGroupPolicy {
    return BriefGroupPolicyFromJSONTyped(json, false);
}

export function BriefGroupPolicyFromJSONTyped(json: any, ignoreDiscriminator: boolean): BriefGroupPolicy {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'enableLeaseExpiration': !exists(json, 'enableLeaseExpiration') ? undefined : json['enableLeaseExpiration'],
        'leaseExpiredInterval': !exists(json, 'leaseExpiredInterval') ? undefined : json['leaseExpiredInterval'],
        'leaseExpiredIntervalType': !exists(json, 'leaseExpiredIntervalType') ? undefined : ApiDurationTypeFromJSON(json['leaseExpiredIntervalType']),
        'enableManageGroupSharing': !exists(json, 'enableManageGroupSharing') ? undefined : json['enableManageGroupSharing'],
        'enableInviteAuthorizedGuestUser': !exists(json, 'enableInviteAuthorizedGuestUser') ? undefined : json['enableInviteAuthorizedGuestUser'],
        'enableInviteGuestUser': !exists(json, 'enableInviteGuestUser') ? undefined : json['enableInviteGuestUser'],
    };
}

export function BriefGroupPolicyToJSON(value?: BriefGroupPolicy | null): any {
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
        'enableLeaseExpiration': value.enableLeaseExpiration,
        'leaseExpiredInterval': value.leaseExpiredInterval,
        'leaseExpiredIntervalType': ApiDurationTypeToJSON(value.leaseExpiredIntervalType),
        'enableManageGroupSharing': value.enableManageGroupSharing,
        'enableInviteAuthorizedGuestUser': value.enableInviteAuthorizedGuestUser,
        'enableInviteGuestUser': value.enableInviteGuestUser,
    };
}


