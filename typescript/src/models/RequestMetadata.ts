/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ApiUser,
    ApiUserFromJSON,
    ApiUserFromJSONTyped,
    ApiUserToJSON,
    LinkValue,
    LinkValueFromJSON,
    LinkValueFromJSONTyped,
    LinkValueToJSON,
    LookupListValue,
    LookupListValueFromJSON,
    LookupListValueFromJSONTyped,
    LookupListValueToJSON,
    LookupValue,
    LookupValueFromJSON,
    LookupValueFromJSONTyped,
    LookupValueToJSON,
    MetadataActionType,
    MetadataActionTypeFromJSON,
    MetadataActionTypeFromJSONTyped,
    MetadataActionTypeToJSON,
    MetadataFieldType,
    MetadataFieldTypeFromJSON,
    MetadataFieldTypeFromJSONTyped,
    MetadataFieldTypeToJSON,
    TermsValue,
    TermsValueFromJSON,
    TermsValueFromJSONTyped,
    TermsValueToJSON,
} from './';

/**
 * Metadata model of request.
 * @export
 * @interface RequestMetadata
 */
export interface RequestMetadata {
    /**
     * Id of metadata.
     * @type {string}
     * @memberof RequestMetadata
     */
    id?: string;
    /**
     * Name of metadata.
     * @type {string}
     * @memberof RequestMetadata
     */
    name?: string | null;
    /**
     * Value of Yes/No metadata.
     * @type {boolean}
     * @memberof RequestMetadata
     */
    booleanValue?: boolean | null;
    /**
     * Value of Single/Multiple line of text metadata.
     * @type {string}
     * @memberof RequestMetadata
     */
    singleLineOrMultipleLineValue?: string | null;
    /**
     * Value of User Profile or Azure AD metadata.
     * @type {LookupValue}
     * @memberof RequestMetadata
     */
    upsOrAzureAdValue?: LookupValue | null;
    /**
     * Value of Managed metadata metadata.
     * @type {TermsValue}
     * @memberof RequestMetadata
     */
    termsValue?: TermsValue | null;
    /**
     * Value of Person or Group metadata.
     * @type {Array<ApiUser>}
     * @memberof RequestMetadata
     */
    userValue?: Array<ApiUser> | null;
    /**
     * Value of Hyperlink metadata.
     * @type {LinkValue}
     * @memberof RequestMetadata
     */
    linkValue?: LinkValue | null;
    /**
     * Value of Choice metadata.
     * @type {Array<string>}
     * @memberof RequestMetadata
     */
    choiceValue?: Array<string> | null;
    /**
     * Value of Lookup to SharePoint library/list metadata.
     * @type {LookupListValue}
     * @memberof RequestMetadata
     */
    lookupListValue?: LookupListValue | null;
    /**
     * Type of metadata.
     * @type {MetadataFieldType}
     * @memberof RequestMetadata
     */
    readonly type?: MetadataFieldType | null;
    /**
     * Display value of metadata.
     * @type {string}
     * @memberof RequestMetadata
     */
    readonly valueString?: string | null;
    /**
     * Value of metadata, you can set this value for all metadata types when calling API
     * Examples:
     * Yes/No metadata: "True"
     * User Profile or Azure AD metadata: "user1@example.com"
     * Managed metadata metadata: "term1;term2"
     * Person or Group metadata: "user1@example.com;user2@example.com"
     * Hyperlink metadata: "linktitle;linkaddress"
     * Lookup to SharePoint library/list metadata: "value"
     * Choice metadata: "choice1;choice2"
     * @type {string}
     * @memberof RequestMetadata
     */
    value?: string | null;
    /**
     * Action of metadata, used in change workspace metadata service.
     * @type {MetadataActionType}
     * @memberof RequestMetadata
     */
    action?: MetadataActionType;
    /**
     * Whether the metadata is allowed to be referenced as a variable role that can be selected in an approval process.
     * @type {boolean}
     * @memberof RequestMetadata
     */
    allowReferenceAsRoleInApprovalProcess?: boolean;
}

export function RequestMetadataFromJSON(json: any): RequestMetadata {
    return RequestMetadataFromJSONTyped(json, false);
}

export function RequestMetadataFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestMetadata {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'booleanValue': !exists(json, 'booleanValue') ? undefined : json['booleanValue'],
        'singleLineOrMultipleLineValue': !exists(json, 'singleLineOrMultipleLineValue') ? undefined : json['singleLineOrMultipleLineValue'],
        'upsOrAzureAdValue': !exists(json, 'upsOrAzureAdValue') ? undefined : LookupValueFromJSON(json['upsOrAzureAdValue']),
        'termsValue': !exists(json, 'termsValue') ? undefined : TermsValueFromJSON(json['termsValue']),
        'userValue': !exists(json, 'userValue') ? undefined : (json['userValue'] === null ? null : (json['userValue'] as Array<any>).map(ApiUserFromJSON)),
        'linkValue': !exists(json, 'linkValue') ? undefined : LinkValueFromJSON(json['linkValue']),
        'choiceValue': !exists(json, 'choiceValue') ? undefined : json['choiceValue'],
        'lookupListValue': !exists(json, 'lookupListValue') ? undefined : LookupListValueFromJSON(json['lookupListValue']),
        'type': !exists(json, 'type') ? undefined : MetadataFieldTypeFromJSON(json['type']),
        'valueString': !exists(json, 'valueString') ? undefined : json['valueString'],
        'value': !exists(json, 'value') ? undefined : json['value'],
        'action': !exists(json, 'action') ? undefined : MetadataActionTypeFromJSON(json['action']),
        'allowReferenceAsRoleInApprovalProcess': !exists(json, 'allowReferenceAsRoleInApprovalProcess') ? undefined : json['allowReferenceAsRoleInApprovalProcess'],
    };
}

export function RequestMetadataToJSON(value?: RequestMetadata | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'name': value.name,
        'booleanValue': value.booleanValue,
        'singleLineOrMultipleLineValue': value.singleLineOrMultipleLineValue,
        'upsOrAzureAdValue': LookupValueToJSON(value.upsOrAzureAdValue),
        'termsValue': TermsValueToJSON(value.termsValue),
        'userValue': value.userValue === undefined ? undefined : (value.userValue === null ? null : (value.userValue as Array<any>).map(ApiUserToJSON)),
        'linkValue': LinkValueToJSON(value.linkValue),
        'choiceValue': value.choiceValue,
        'lookupListValue': LookupListValueToJSON(value.lookupListValue),
        'value': value.value,
        'action': MetadataActionTypeToJSON(value.action),
        'allowReferenceAsRoleInApprovalProcess': value.allowReferenceAsRoleInApprovalProcess,
    };
}


