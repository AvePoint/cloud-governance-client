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
 * @interface WelcomeEmailSettings
 */
export interface WelcomeEmailSettings {
    /**
     * 
     * @type {boolean}
     * @memberof WelcomeEmailSettings
     */
    enabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof WelcomeEmailSettings
     */
    subject?: string | null;
    /**
     * 
     * @type {string}
     * @memberof WelcomeEmailSettings
     */
    personalMessage?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof WelcomeEmailSettings
     */
    enabledSendEmailInService?: boolean;
    /**
     * 
     * @type {string}
     * @memberof WelcomeEmailSettings
     */
    welcomeEmailTemplateId?: string;
    /**
     * 
     * @type {boolean}
     * @memberof WelcomeEmailSettings
     */
    isWelcomeEmailTemplate?: boolean;
}

export function WelcomeEmailSettingsFromJSON(json: any): WelcomeEmailSettings {
    return WelcomeEmailSettingsFromJSONTyped(json, false);
}

export function WelcomeEmailSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): WelcomeEmailSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enabled': !exists(json, 'enabled') ? undefined : json['enabled'],
        'subject': !exists(json, 'subject') ? undefined : json['subject'],
        'personalMessage': !exists(json, 'personalMessage') ? undefined : json['personalMessage'],
        'enabledSendEmailInService': !exists(json, 'enabledSendEmailInService') ? undefined : json['enabledSendEmailInService'],
        'welcomeEmailTemplateId': !exists(json, 'welcomeEmailTemplateId') ? undefined : json['welcomeEmailTemplateId'],
        'isWelcomeEmailTemplate': !exists(json, 'isWelcomeEmailTemplate') ? undefined : json['isWelcomeEmailTemplate'],
    };
}

export function WelcomeEmailSettingsToJSON(value?: WelcomeEmailSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enabled': value.enabled,
        'subject': value.subject,
        'personalMessage': value.personalMessage,
        'enabledSendEmailInService': value.enabledSendEmailInService,
        'welcomeEmailTemplateId': value.welcomeEmailTemplateId,
        'isWelcomeEmailTemplate': value.isWelcomeEmailTemplate,
    };
}


