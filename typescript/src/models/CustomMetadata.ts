/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    AssignBy,
    AssignByFromJSON,
    AssignByFromJSONTyped,
    AssignByToJSON,
    AzureAdMetadataSettings,
    AzureAdMetadataSettingsFromJSON,
    AzureAdMetadataSettingsFromJSONTyped,
    AzureAdMetadataSettingsToJSON,
    BooleanMetadataSettings,
    BooleanMetadataSettingsFromJSON,
    BooleanMetadataSettingsFromJSONTyped,
    BooleanMetadataSettingsToJSON,
    ChoiceMetadataSettings,
    ChoiceMetadataSettingsFromJSON,
    ChoiceMetadataSettingsFromJSONTyped,
    ChoiceMetadataSettingsToJSON,
    DisplayInReportType,
    DisplayInReportTypeFromJSON,
    DisplayInReportTypeFromJSONTyped,
    DisplayInReportTypeToJSON,
    LinkMetadataSettings,
    LinkMetadataSettingsFromJSON,
    LinkMetadataSettingsFromJSONTyped,
    LinkMetadataSettingsToJSON,
    MetadataFieldType,
    MetadataFieldTypeFromJSON,
    MetadataFieldTypeFromJSONTyped,
    MetadataFieldTypeToJSON,
    SharePointListMetadataSettings,
    SharePointListMetadataSettingsFromJSON,
    SharePointListMetadataSettingsFromJSONTyped,
    SharePointListMetadataSettingsToJSON,
    SingleLineOrMultipleLineMetadataSettings,
    SingleLineOrMultipleLineMetadataSettingsFromJSON,
    SingleLineOrMultipleLineMetadataSettingsFromJSONTyped,
    SingleLineOrMultipleLineMetadataSettingsToJSON,
    TermsMetadataSettings,
    TermsMetadataSettingsFromJSON,
    TermsMetadataSettingsFromJSONTyped,
    TermsMetadataSettingsToJSON,
    TextValidationRuleRef,
    TextValidationRuleRefFromJSON,
    TextValidationRuleRefFromJSONTyped,
    TextValidationRuleRefToJSON,
    UserMetadataSettings,
    UserMetadataSettingsFromJSON,
    UserMetadataSettingsFromJSONTyped,
    UserMetadataSettingsToJSON,
    UserProfileMetadataSettings,
    UserProfileMetadataSettingsFromJSON,
    UserProfileMetadataSettingsFromJSONTyped,
    UserProfileMetadataSettingsToJSON,
} from './';

/**
 * 
 * @export
 * @interface CustomMetadata
 */
export interface CustomMetadata {
    /**
     * 
     * @type {string}
     * @memberof CustomMetadata
     */
    id?: string;
    /**
     * 
     * @type {string}
     * @memberof CustomMetadata
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof CustomMetadata
     */
    description?: string | null;
    /**
     * 
     * @type {MetadataFieldType}
     * @memberof CustomMetadata
     */
    type?: MetadataFieldType;
    /**
     * 
     * @type {DisplayInReportType}
     * @memberof CustomMetadata
     */
    displayType?: DisplayInReportType;
    /**
     * 
     * @type {AssignBy}
     * @memberof CustomMetadata
     */
    assignBy?: AssignBy;
    /**
     * 
     * @type {boolean}
     * @memberof CustomMetadata
     */
    enableTextValidation?: boolean;
    /**
     * 
     * @type {TextValidationRuleRef}
     * @memberof CustomMetadata
     */
    textValidationRule?: TextValidationRuleRef | null;
    /**
     * 
     * @type {BooleanMetadataSettings}
     * @memberof CustomMetadata
     */
    booleanMetadataSettings?: BooleanMetadataSettings | null;
    /**
     * 
     * @type {TermsMetadataSettings}
     * @memberof CustomMetadata
     */
    termsMetadataSettings?: TermsMetadataSettings | null;
    /**
     * 
     * @type {UserMetadataSettings}
     * @memberof CustomMetadata
     */
    userMetadataSettings?: UserMetadataSettings | null;
    /**
     * 
     * @type {UserProfileMetadataSettings}
     * @memberof CustomMetadata
     */
    userProfileMetadataSettings?: UserProfileMetadataSettings | null;
    /**
     * 
     * @type {AzureAdMetadataSettings}
     * @memberof CustomMetadata
     */
    azureAdMetadataSettings?: AzureAdMetadataSettings | null;
    /**
     * 
     * @type {ChoiceMetadataSettings}
     * @memberof CustomMetadata
     */
    choiceMetadataSettings?: ChoiceMetadataSettings | null;
    /**
     * 
     * @type {LinkMetadataSettings}
     * @memberof CustomMetadata
     */
    linkMetadataSettings?: LinkMetadataSettings | null;
    /**
     * 
     * @type {SingleLineOrMultipleLineMetadataSettings}
     * @memberof CustomMetadata
     */
    singleLineOrMultipleLineMetadataSettings?: SingleLineOrMultipleLineMetadataSettings | null;
    /**
     * 
     * @type {SharePointListMetadataSettings}
     * @memberof CustomMetadata
     */
    sharePointListMetadataSettings?: SharePointListMetadataSettings | null;
}

export function CustomMetadataFromJSON(json: any): CustomMetadata {
    return CustomMetadataFromJSONTyped(json, false);
}

export function CustomMetadataFromJSONTyped(json: any, ignoreDiscriminator: boolean): CustomMetadata {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'type': !exists(json, 'type') ? undefined : MetadataFieldTypeFromJSON(json['type']),
        'displayType': !exists(json, 'displayType') ? undefined : DisplayInReportTypeFromJSON(json['displayType']),
        'assignBy': !exists(json, 'assignBy') ? undefined : AssignByFromJSON(json['assignBy']),
        'enableTextValidation': !exists(json, 'enableTextValidation') ? undefined : json['enableTextValidation'],
        'textValidationRule': !exists(json, 'textValidationRule') ? undefined : TextValidationRuleRefFromJSON(json['textValidationRule']),
        'booleanMetadataSettings': !exists(json, 'booleanMetadataSettings') ? undefined : BooleanMetadataSettingsFromJSON(json['booleanMetadataSettings']),
        'termsMetadataSettings': !exists(json, 'termsMetadataSettings') ? undefined : TermsMetadataSettingsFromJSON(json['termsMetadataSettings']),
        'userMetadataSettings': !exists(json, 'userMetadataSettings') ? undefined : UserMetadataSettingsFromJSON(json['userMetadataSettings']),
        'userProfileMetadataSettings': !exists(json, 'userProfileMetadataSettings') ? undefined : UserProfileMetadataSettingsFromJSON(json['userProfileMetadataSettings']),
        'azureAdMetadataSettings': !exists(json, 'azureAdMetadataSettings') ? undefined : AzureAdMetadataSettingsFromJSON(json['azureAdMetadataSettings']),
        'choiceMetadataSettings': !exists(json, 'choiceMetadataSettings') ? undefined : ChoiceMetadataSettingsFromJSON(json['choiceMetadataSettings']),
        'linkMetadataSettings': !exists(json, 'linkMetadataSettings') ? undefined : LinkMetadataSettingsFromJSON(json['linkMetadataSettings']),
        'singleLineOrMultipleLineMetadataSettings': !exists(json, 'singleLineOrMultipleLineMetadataSettings') ? undefined : SingleLineOrMultipleLineMetadataSettingsFromJSON(json['singleLineOrMultipleLineMetadataSettings']),
        'sharePointListMetadataSettings': !exists(json, 'sharePointListMetadataSettings') ? undefined : SharePointListMetadataSettingsFromJSON(json['sharePointListMetadataSettings']),
    };
}

export function CustomMetadataToJSON(value?: CustomMetadata | null): any {
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
        'type': MetadataFieldTypeToJSON(value.type),
        'displayType': DisplayInReportTypeToJSON(value.displayType),
        'assignBy': AssignByToJSON(value.assignBy),
        'enableTextValidation': value.enableTextValidation,
        'textValidationRule': TextValidationRuleRefToJSON(value.textValidationRule),
        'booleanMetadataSettings': BooleanMetadataSettingsToJSON(value.booleanMetadataSettings),
        'termsMetadataSettings': TermsMetadataSettingsToJSON(value.termsMetadataSettings),
        'userMetadataSettings': UserMetadataSettingsToJSON(value.userMetadataSettings),
        'userProfileMetadataSettings': UserProfileMetadataSettingsToJSON(value.userProfileMetadataSettings),
        'azureAdMetadataSettings': AzureAdMetadataSettingsToJSON(value.azureAdMetadataSettings),
        'choiceMetadataSettings': ChoiceMetadataSettingsToJSON(value.choiceMetadataSettings),
        'linkMetadataSettings': LinkMetadataSettingsToJSON(value.linkMetadataSettings),
        'singleLineOrMultipleLineMetadataSettings': SingleLineOrMultipleLineMetadataSettingsToJSON(value.singleLineOrMultipleLineMetadataSettings),
        'sharePointListMetadataSettings': SharePointListMetadataSettingsToJSON(value.sharePointListMetadataSettings),
    };
}


